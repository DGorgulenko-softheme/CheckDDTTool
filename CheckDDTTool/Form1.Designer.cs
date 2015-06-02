namespace CheckDDTTool
{
    partial class CheckTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AgentList = new System.Windows.Forms.ListBox();
            this.RPList = new System.Windows.Forms.ListBox();
            this.ServerBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.RPButton = new System.Windows.Forms.Button();
            this.MountButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CheckButton = new System.Windows.Forms.Button();
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.MountPathBox = new System.Windows.Forms.TextBox();
            this.DDTPath = new System.Windows.Forms.TextBox();
            this.ConfigBox = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AgentList
            // 
            this.AgentList.FormattingEnabled = true;
            this.AgentList.Location = new System.Drawing.Point(12, 64);
            this.AgentList.Name = "AgentList";
            this.AgentList.Size = new System.Drawing.Size(312, 56);
            this.AgentList.TabIndex = 0;
            // 
            // RPList
            // 
            this.RPList.FormattingEnabled = true;
            this.RPList.Location = new System.Drawing.Point(12, 126);
            this.RPList.Name = "RPList";
            this.RPList.Size = new System.Drawing.Size(312, 56);
            this.RPList.TabIndex = 0;
            this.RPList.Click += new System.EventHandler(this.RPList_Click);
            // 
            // ServerBox
            // 
            this.ServerBox.Location = new System.Drawing.Point(12, 38);
            this.ServerBox.Name = "ServerBox";
            this.ServerBox.Size = new System.Drawing.Size(100, 20);
            this.ServerBox.TabIndex = 1;
            this.ServerBox.Text = "LocalHost";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(118, 38);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(100, 20);
            this.UserNameBox.TabIndex = 2;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(224, 38);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordBox.TabIndex = 3;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(330, 38);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click_1);
            // 
            // RPButton
            // 
            this.RPButton.Enabled = false;
            this.RPButton.Location = new System.Drawing.Point(330, 80);
            this.RPButton.Name = "RPButton";
            this.RPButton.Size = new System.Drawing.Size(75, 23);
            this.RPButton.TabIndex = 5;
            this.RPButton.Text = "Get RPs";
            this.RPButton.UseVisualStyleBackColor = true;
            this.RPButton.Click += new System.EventHandler(this.RPButton_Click);
            // 
            // MountButton
            // 
            this.MountButton.Enabled = false;
            this.MountButton.Location = new System.Drawing.Point(330, 185);
            this.MountButton.Name = "MountButton";
            this.MountButton.Size = new System.Drawing.Size(75, 23);
            this.MountButton.TabIndex = 6;
            this.MountButton.Text = "Mount";
            this.MountButton.UseVisualStyleBackColor = true;
            this.MountButton.Click += new System.EventHandler(this.MountButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "CoreIP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(330, 266);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 6;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // FilePathBox
            // 
            this.FilePathBox.Location = new System.Drawing.Point(12, 266);
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.Size = new System.Drawing.Size(312, 20);
            this.FilePathBox.TabIndex = 8;
            this.FilePathBox.DoubleClick += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 292);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(417, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusBar
            // 
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(126, 17);
            this.StatusBar.Text = "Please connect to core";
            // 
            // MountPathBox
            // 
            this.MountPathBox.Location = new System.Drawing.Point(12, 188);
            this.MountPathBox.Name = "MountPathBox";
            this.MountPathBox.Size = new System.Drawing.Size(312, 20);
            this.MountPathBox.TabIndex = 10;
            this.MountPathBox.Text = "C:\\MountTest\\";
            // 
            // DDTPath
            // 
            this.DDTPath.Location = new System.Drawing.Point(12, 214);
            this.DDTPath.Name = "DDTPath";
            this.DDTPath.Size = new System.Drawing.Size(312, 20);
            this.DDTPath.TabIndex = 11;
            this.DDTPath.Text = "C:\\ChangeGen\\DDT.exe";
            // 
            // ConfigBox
            // 
            this.ConfigBox.Location = new System.Drawing.Point(12, 240);
            this.ConfigBox.Name = "ConfigBox";
            this.ConfigBox.Size = new System.Drawing.Size(312, 20);
            this.ConfigBox.TabIndex = 12;
            this.ConfigBox.Text = "C:\\Parameters.csv";
            // 
            // CheckTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 314);
            this.Controls.Add(this.ConfigBox);
            this.Controls.Add(this.DDTPath);
            this.Controls.Add(this.MountPathBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.FilePathBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.MountButton);
            this.Controls.Add(this.RPButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.ServerBox);
            this.Controls.Add(this.RPList);
            this.Controls.Add(this.AgentList);
            this.Name = "CheckTool";
            this.Text = "CheckTool";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AgentList;
        private System.Windows.Forms.ListBox RPList;
        private System.Windows.Forms.TextBox ServerBox;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button RPButton;
        private System.Windows.Forms.Button MountButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox FilePathBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar;
        private System.Windows.Forms.TextBox MountPathBox;
        private System.Windows.Forms.TextBox DDTPath;
        private System.Windows.Forms.TextBox ConfigBox;
    }
}

