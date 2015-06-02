using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Forms;
using Replay.ServiceHost.Contracts;
using System.Net;
using Replay.Core.Client;
using System.IO;
using System.Management;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using Replay.Agent.Contracts.VolumeMountPoints;
using Replay.Common.Contracts.Metadata.Storage;
using Replay.Common.Contracts.Mounts;
using Replay.Core.Contracts.Agents;
using Replay.Core.Contracts.Mounts;
using Replay.Core.Contracts.RecoveryPoints;
using Replay.Reporting.Contracts;

namespace CheckDDTTool
{
    public partial class CheckTool : Form
    {
        public CheckTool()
        {
            InitializeComponent();
        }
        
        private ICoreClient _coreClient;
        private AgentInfoCollection protectedAgents;
        private RecoveryPointSummaryInfoCollection RPs;
        private RecoveryPointSummaryInfo rPtoMount;
        private string Seed;

        public static int ExecuteCommand(string command, int timeout)
        {
            var processInfo = new ProcessStartInfo("cmd.exe", "/C " + command)
            {
                CreateNoWindow = true,
                UseShellExecute = true,
                WorkingDirectory = "C:\\",
            };

            var process = Process.Start(processInfo);
            process.WaitForExit(timeout);
            var exitCode = process.ExitCode;
            process.Close();
            return exitCode;
        } 

        public static ICoreClient GetFullCoreClient(string host, int port, string username, string password)
        {
            var networdCredentials = new NetworkCredential(username, password);
            var factory = new CoreClientFactory();
            var coreClient = factory.Create(CreateApiUri(host, port));
            coreClient.UseSpecificCredentials(networdCredentials);

            return coreClient;
        }
        
        private static ICoreClient GetDefaultCoreClient(string host, int port)
        {
            var coreClientFactory = new CoreClientFactory();

            var coreClient = coreClientFactory.Create(CreateApiUri(host, port));
            coreClient.UseDefaultCredentials();

            return coreClient;
        }
        
        private static Uri CreateApiUri(string host, int port)
        {
            var apiUri = string.Format("https://{0}:{1}/{2}/api/core/", host, port, ServiceHostConstants.RootOfServiceHostAddress);

            return new Uri(apiUri);
        }
      
        private void ConnectButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                StatusBar.Text = "Trying to connnect to the Core...";
                AgentList.Items.Clear();
                if (String.IsNullOrEmpty(UserNameBox.Text) || String.IsNullOrEmpty(PasswordBox.Text))
                {
                    _coreClient = GetDefaultCoreClient(ServerBox.Text, 8006);
                }
                else
                {
                    _coreClient = GetFullCoreClient(ServerBox.Text, 8006, UserNameBox.Text, PasswordBox.Text);
                }
                StatusBar.Text = "Getting Protected aggents";
                protectedAgents  = _coreClient.AgentsManagement.GetProtectedAgents();
                StatusBar.Text = "Updating Agent list";
                foreach (var Agent in protectedAgents)
                {
                    var agentInfo = _coreClient.AgentsManagement.GetAgentInfo(Agent.Id.ToString());
                    AgentList.Items.Add(agentInfo.Descriptor.DisplayName);
                }
                StatusBar.Text = "Connected to " + ServerBox.Text;
                RPButton.Enabled = Enabled;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something going wrong:\n\n" + ex);
            }
        }
        
        private void RPButton_Click(object sender, EventArgs e)
        {
            try
            {

                var query = from Agent in protectedAgents
                    where Agent.DisplayName.ToString() == AgentList.SelectedItem.ToString()
                    select Agent.Id;
                StatusBar.Text = "Getting Recovery points" ;
                RPs = _coreClient.RecoveryPointsManagement.GetAllRecoveryPoints(query.FirstOrDefault().ToString());
                if (RPs == null)
                {
                    MessageBox.Show("there are no RPs for this Agent");
                }
                foreach (var rp in RPs)
                {
                    RPList.Items.Add(rp.DateTimestamp);
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something going wrong:\n\n" + ex);
            }
        }

        private void MountButton_Click(object sender, EventArgs e)
        {
            foreach (var RP in RPs)
            {
                if (RP.DateTimestamp.ToString() == RPList.SelectedItem.ToString())
                {
                    rPtoMount = RP;
                }
            }
           var volumeImagesToMount = rPtoMount.VolumeImageSummaries.Select(x => x.Id).ToList();
           var localmountJobRequest = new LocalMountJobRequest
           {
               RecoveryPointId = rPtoMount.Id,
               MountType = MountType.ReadOnly,
               VolumeImagesToMount = new Collection<string>(volumeImagesToMount),
               MountPoint = MountPathBox.Text
               
           };
            try
                {
                    // Verify if the recovery point can be mounted
                    _coreClient.LocalMountManagement.VerifyVolumeImagesMountability(localmountJobRequest);
                }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: The recovery point can't be mounted. "+ ex.Message);
                
            }
            var jobId = _coreClient.LocalMountManagement.StartMount(localmountJobRequest);
            MessageBox.Show("The recovery point with id "+ rPtoMount.Id + " has been successful mounted. MountPoint: "+ localmountJobRequest.MountPoint);

            while (true)
            {
                var status = _coreClient.BackgroundJobManagement.GetJob(jobId).Status;

                if ((status == JobStatus.Succeeded) || (status == JobStatus.Canceled) || (status == JobStatus.Failed))
                {
                    break;

                }
            }
            

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
         //Generate a Same file
         //var script = "$Parameters = Import-Csv C:\\Parameters.csv \n $arguments = \"op=write threads=1 filename="+ DDTPath.Text + "\\testFile filesize=$size blocksize=$blocksize dup-percentage=$dup_percentage buffering=direct io=sequential seed=$Seed";
         //ExecuteCommand("", 5000); 
         //var arguments = "op=write threads=1 filename="+ FilePathBox.Text + "filesize="+ +"blocksize=$blocksize dup-percentage=$dup_percentage buffering=direct io=sequential seed=$Seed";
         //var command = DDTPath.Text + arguments;
         //ExecuteCommand(command, 10000);
         //Dismount all local mounted recovery points
         //var mount = _coreClient.LocalMountManagement.GetMounts().Single();
         //_coreClient.LocalMountManagement.Dismount(mount.MountedVolume.GuidName);
         //MessageBox.Show("The recovery point has been succesfully dismounted");

           var Current = Directory.GetCurrentDirectory();
           TextFieldParser parser = new TextFieldParser(ConfigBox.Text);
           parser.TextFieldType = FieldType.Delimited;
           parser.SetDelimiters(",");
           while (!parser.EndOfData)
           {
               //Process row
               string[] fields = parser.ReadFields();
               foreach (string field in fields)
               {
                   //TODO: Process field
               }
           }
           parser.Close();
 
          //  ExecuteCommand( ,5000)
           MessageBox.Show(Current);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           FileDialog FileDial = new OpenFileDialog();
           DialogResult SelectedFile = FileDial.ShowDialog();
           FilePathBox.Text = FileDial.FileName.ToString();
           Seed = System.IO.Path.GetFileName(FileDial.FileName);
           CheckButton.Enabled = Enabled;
        }

        private void RPList_Click(object sender, EventArgs e)
        {
            MountButton.Enabled = Enabled;
        }



    }
}

