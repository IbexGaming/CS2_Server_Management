namespace CS2_Server_Management
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.bwUpdateServer = new System.ComponentModel.BackgroundWorker();
            this.bwInstallCS2Server = new System.ComponentModel.BackgroundWorker();
            this.bwConnectToSserver = new System.ComponentModel.BackgroundWorker();
            this.gbxInstances = new System.Windows.Forms.GroupBox();
            this.btnStopInstance = new System.Windows.Forms.Button();
            this.btnStartInstance = new System.Windows.Forms.Button();
            this.btnRemoveInstance = new System.Windows.Forms.Button();
            this.btnAddInstance = new System.Windows.Forms.Button();
            this.lsbIsntances = new System.Windows.Forms.ListBox();
            this.tpInstances = new System.Windows.Forms.TabPage();
            this.tpServers = new System.Windows.Forms.TabPage();
            this.lblCs2ServerInstalled = new System.Windows.Forms.Label();
            this.lblCs2ServerInstalledTitle = new System.Windows.Forms.Label();
            this.gbxCSServerControl = new System.Windows.Forms.GroupBox();
            this.btnInstallCSSharp = new System.Windows.Forms.Button();
            this.btnInstallMetamod = new System.Windows.Forms.Button();
            this.btnAddServer = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblServerConnectionStatus = new System.Windows.Forms.Label();
            this.cbxServer = new System.Windows.Forms.ComboBox();
            this.lblSelectServer = new System.Windows.Forms.Label();
            this.btnRemoveServer = new System.Windows.Forms.Button();
            this.lblServerStatusConnectionTitle = new System.Windows.Forms.Label();
            this.gbxLinuxServerControl = new System.Windows.Forms.GroupBox();
            this.btnUninstallCS2Server = new System.Windows.Forms.Button();
            this.btnUpdateCS2Sserver = new System.Windows.Forms.Button();
            this.btnInstallCS2Server = new System.Windows.Forms.Button();
            this.btnUpdateServer = new System.Windows.Forms.Button();
            this.btnGetNetworkInfo = new System.Windows.Forms.Button();
            this.btnReboot = new System.Windows.Forms.Button();
            this.tbxConsoleServer = new System.Windows.Forms.RichTextBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.bwCheckCs2ServerInstalled = new System.ComponentModel.BackgroundWorker();
            this.bwCs2InstallMetamod = new System.ComponentModel.BackgroundWorker();
            this.bwCs2InstallCsSharp = new System.ComponentModel.BackgroundWorker();
            this.lblMetamodStatus = new System.Windows.Forms.Label();
            this.lblCsSStatus = new System.Windows.Forms.Label();
            this.btnInstallMatchzy = new System.Windows.Forms.Button();
            this.lblMatchZyStatus = new System.Windows.Forms.Label();
            this.gbxInstances.SuspendLayout();
            this.tpInstances.SuspendLayout();
            this.tpServers.SuspendLayout();
            this.gbxCSServerControl.SuspendLayout();
            this.gbxLinuxServerControl.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // bwUpdateServer
            // 
            this.bwUpdateServer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUpdateServer_DoWork);
            this.bwUpdateServer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwUpdateServer_RunWorkerCompleted);
            // 
            // bwInstallCS2Server
            // 
            this.bwInstallCS2Server.WorkerReportsProgress = true;
            this.bwInstallCS2Server.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwInstallCS2Server_DoWork);
            this.bwInstallCS2Server.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwInstallCS2Server_ProgressChanged);
            this.bwInstallCS2Server.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwInstallCS2Server_RunWorkerCompleted);
            // 
            // bwConnectToSserver
            // 
            this.bwConnectToSserver.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConnectToSserver_DoWork);
            this.bwConnectToSserver.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwConnectToSserver_RunWorkerCompleted);
            // 
            // gbxInstances
            // 
            this.gbxInstances.Controls.Add(this.btnStopInstance);
            this.gbxInstances.Controls.Add(this.btnStartInstance);
            this.gbxInstances.Controls.Add(this.btnRemoveInstance);
            this.gbxInstances.Controls.Add(this.btnAddInstance);
            this.gbxInstances.Controls.Add(this.lsbIsntances);
            this.gbxInstances.Location = new System.Drawing.Point(680, 51);
            this.gbxInstances.Name = "gbxInstances";
            this.gbxInstances.Size = new System.Drawing.Size(336, 301);
            this.gbxInstances.TabIndex = 13;
            this.gbxInstances.TabStop = false;
            this.gbxInstances.Text = "Instances control";
            // 
            // btnStopInstance
            // 
            this.btnStopInstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopInstance.Location = new System.Drawing.Point(186, 49);
            this.btnStopInstance.Name = "btnStopInstance";
            this.btnStopInstance.Size = new System.Drawing.Size(144, 23);
            this.btnStopInstance.TabIndex = 16;
            this.btnStopInstance.Text = "Stop";
            this.btnStopInstance.UseVisualStyleBackColor = true;
            // 
            // btnStartInstance
            // 
            this.btnStartInstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartInstance.Location = new System.Drawing.Point(186, 20);
            this.btnStartInstance.Name = "btnStartInstance";
            this.btnStartInstance.Size = new System.Drawing.Size(144, 23);
            this.btnStartInstance.TabIndex = 10;
            this.btnStartInstance.Text = "Start";
            this.btnStartInstance.UseVisualStyleBackColor = true;
            this.btnStartInstance.Click += new System.EventHandler(this.btnStartInstance_Click);
            // 
            // btnRemoveInstance
            // 
            this.btnRemoveInstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveInstance.Location = new System.Drawing.Point(86, 274);
            this.btnRemoveInstance.Name = "btnRemoveInstance";
            this.btnRemoveInstance.Size = new System.Drawing.Size(63, 21);
            this.btnRemoveInstance.TabIndex = 15;
            this.btnRemoveInstance.Text = "-";
            this.btnRemoveInstance.UseVisualStyleBackColor = true;
            // 
            // btnAddInstance
            // 
            this.btnAddInstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInstance.Location = new System.Drawing.Point(7, 274);
            this.btnAddInstance.Name = "btnAddInstance";
            this.btnAddInstance.Size = new System.Drawing.Size(63, 21);
            this.btnAddInstance.TabIndex = 14;
            this.btnAddInstance.Text = "+";
            this.btnAddInstance.UseVisualStyleBackColor = true;
            // 
            // lsbIsntances
            // 
            this.lsbIsntances.FormattingEnabled = true;
            this.lsbIsntances.Location = new System.Drawing.Point(7, 20);
            this.lsbIsntances.Name = "lsbIsntances";
            this.lsbIsntances.Size = new System.Drawing.Size(142, 251);
            this.lsbIsntances.TabIndex = 0;
            // 
            // tpInstances
            // 
            this.tpInstances.Controls.Add(this.gbxInstances);
            this.tpInstances.Location = new System.Drawing.Point(4, 22);
            this.tpInstances.Name = "tpInstances";
            this.tpInstances.Padding = new System.Windows.Forms.Padding(3);
            this.tpInstances.Size = new System.Drawing.Size(1132, 487);
            this.tpInstances.TabIndex = 0;
            this.tpInstances.Text = "Instances";
            this.tpInstances.UseVisualStyleBackColor = true;
            // 
            // tpServers
            // 
            this.tpServers.Controls.Add(this.lblCs2ServerInstalled);
            this.tpServers.Controls.Add(this.lblCs2ServerInstalledTitle);
            this.tpServers.Controls.Add(this.gbxCSServerControl);
            this.tpServers.Controls.Add(this.btnAddServer);
            this.tpServers.Controls.Add(this.lblInfo);
            this.tpServers.Controls.Add(this.lblServerConnectionStatus);
            this.tpServers.Controls.Add(this.cbxServer);
            this.tpServers.Controls.Add(this.lblSelectServer);
            this.tpServers.Controls.Add(this.btnRemoveServer);
            this.tpServers.Controls.Add(this.lblServerStatusConnectionTitle);
            this.tpServers.Controls.Add(this.gbxLinuxServerControl);
            this.tpServers.Controls.Add(this.tbxConsoleServer);
            this.tpServers.Location = new System.Drawing.Point(4, 22);
            this.tpServers.Name = "tpServers";
            this.tpServers.Padding = new System.Windows.Forms.Padding(3);
            this.tpServers.Size = new System.Drawing.Size(1132, 487);
            this.tpServers.TabIndex = 1;
            this.tpServers.Text = "Servers";
            this.tpServers.UseVisualStyleBackColor = true;
            // 
            // lblCs2ServerInstalled
            // 
            this.lblCs2ServerInstalled.AutoSize = true;
            this.lblCs2ServerInstalled.Location = new System.Drawing.Point(714, 16);
            this.lblCs2ServerInstalled.Name = "lblCs2ServerInstalled";
            this.lblCs2ServerInstalled.Size = new System.Drawing.Size(10, 13);
            this.lblCs2ServerInstalled.TabIndex = 23;
            this.lblCs2ServerInstalled.Text = "-";
            // 
            // lblCs2ServerInstalledTitle
            // 
            this.lblCs2ServerInstalledTitle.AutoSize = true;
            this.lblCs2ServerInstalledTitle.Location = new System.Drawing.Point(605, 16);
            this.lblCs2ServerInstalledTitle.Name = "lblCs2ServerInstalledTitle";
            this.lblCs2ServerInstalledTitle.Size = new System.Drawing.Size(108, 13);
            this.lblCs2ServerInstalledTitle.TabIndex = 22;
            this.lblCs2ServerInstalledTitle.Text = "CS2 Server installed :";
            // 
            // gbxCSServerControl
            // 
            this.gbxCSServerControl.Controls.Add(this.lblMatchZyStatus);
            this.gbxCSServerControl.Controls.Add(this.btnInstallMatchzy);
            this.gbxCSServerControl.Controls.Add(this.lblCsSStatus);
            this.gbxCSServerControl.Controls.Add(this.lblMetamodStatus);
            this.gbxCSServerControl.Controls.Add(this.btnInstallCSSharp);
            this.gbxCSServerControl.Controls.Add(this.btnInstallMetamod);
            this.gbxCSServerControl.Location = new System.Drawing.Point(761, 194);
            this.gbxCSServerControl.Name = "gbxCSServerControl";
            this.gbxCSServerControl.Size = new System.Drawing.Size(360, 153);
            this.gbxCSServerControl.TabIndex = 17;
            this.gbxCSServerControl.TabStop = false;
            this.gbxCSServerControl.Text = "CS Server control";
            // 
            // btnInstallCSSharp
            // 
            this.btnInstallCSSharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallCSSharp.Location = new System.Drawing.Point(16, 68);
            this.btnInstallCSSharp.Name = "btnInstallCSSharp";
            this.btnInstallCSSharp.Size = new System.Drawing.Size(144, 23);
            this.btnInstallCSSharp.TabIndex = 11;
            this.btnInstallCSSharp.Text = "Install CSSharp";
            this.btnInstallCSSharp.UseVisualStyleBackColor = true;
            this.btnInstallCSSharp.Click += new System.EventHandler(this.btnInstallCSSharp_Click);
            // 
            // btnInstallMetamod
            // 
            this.btnInstallMetamod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallMetamod.Location = new System.Drawing.Point(16, 28);
            this.btnInstallMetamod.Name = "btnInstallMetamod";
            this.btnInstallMetamod.Size = new System.Drawing.Size(144, 23);
            this.btnInstallMetamod.TabIndex = 10;
            this.btnInstallMetamod.Text = "Install Metamod";
            this.btnInstallMetamod.UseVisualStyleBackColor = true;
            this.btnInstallMetamod.Click += new System.EventHandler(this.btnInstallMetamod_Click);
            // 
            // btnAddServer
            // 
            this.btnAddServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServer.Location = new System.Drawing.Point(218, 12);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(100, 21);
            this.btnAddServer.TabIndex = 20;
            this.btnAddServer.Text = "Add";
            this.btnAddServer.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(6, 456);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(749, 28);
            this.lblInfo.TabIndex = 19;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServerConnectionStatus
            // 
            this.lblServerConnectionStatus.AutoSize = true;
            this.lblServerConnectionStatus.Location = new System.Drawing.Point(517, 16);
            this.lblServerConnectionStatus.Name = "lblServerConnectionStatus";
            this.lblServerConnectionStatus.Size = new System.Drawing.Size(10, 13);
            this.lblServerConnectionStatus.TabIndex = 18;
            this.lblServerConnectionStatus.Text = "-";
            // 
            // cbxServer
            // 
            this.cbxServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxServer.FormattingEnabled = true;
            this.cbxServer.Location = new System.Drawing.Point(56, 13);
            this.cbxServer.Name = "cbxServer";
            this.cbxServer.Size = new System.Drawing.Size(156, 21);
            this.cbxServer.TabIndex = 15;
            this.cbxServer.SelectedIndexChanged += new System.EventHandler(this.cbxServer_SelectedIndexChanged);
            // 
            // lblSelectServer
            // 
            this.lblSelectServer.AutoSize = true;
            this.lblSelectServer.Location = new System.Drawing.Point(6, 16);
            this.lblSelectServer.Name = "lblSelectServer";
            this.lblSelectServer.Size = new System.Drawing.Size(44, 13);
            this.lblSelectServer.TabIndex = 14;
            this.lblSelectServer.Text = "Server :";
            // 
            // btnRemoveServer
            // 
            this.btnRemoveServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveServer.Location = new System.Drawing.Point(334, 12);
            this.btnRemoveServer.Name = "btnRemoveServer";
            this.btnRemoveServer.Size = new System.Drawing.Size(100, 21);
            this.btnRemoveServer.TabIndex = 21;
            this.btnRemoveServer.Text = "Remove";
            this.btnRemoveServer.UseVisualStyleBackColor = true;
            // 
            // lblServerStatusConnectionTitle
            // 
            this.lblServerStatusConnectionTitle.AutoSize = true;
            this.lblServerStatusConnectionTitle.Location = new System.Drawing.Point(441, 16);
            this.lblServerStatusConnectionTitle.Name = "lblServerStatusConnectionTitle";
            this.lblServerStatusConnectionTitle.Size = new System.Drawing.Size(75, 13);
            this.lblServerStatusConnectionTitle.TabIndex = 17;
            this.lblServerStatusConnectionTitle.Text = "Server status :";
            // 
            // gbxLinuxServerControl
            // 
            this.gbxLinuxServerControl.Controls.Add(this.btnUninstallCS2Server);
            this.gbxLinuxServerControl.Controls.Add(this.btnUpdateCS2Sserver);
            this.gbxLinuxServerControl.Controls.Add(this.btnInstallCS2Server);
            this.gbxLinuxServerControl.Controls.Add(this.btnUpdateServer);
            this.gbxLinuxServerControl.Controls.Add(this.btnGetNetworkInfo);
            this.gbxLinuxServerControl.Controls.Add(this.btnReboot);
            this.gbxLinuxServerControl.Location = new System.Drawing.Point(761, 35);
            this.gbxLinuxServerControl.Name = "gbxLinuxServerControl";
            this.gbxLinuxServerControl.Size = new System.Drawing.Size(360, 153);
            this.gbxLinuxServerControl.TabIndex = 16;
            this.gbxLinuxServerControl.TabStop = false;
            this.gbxLinuxServerControl.Text = "Server control";
            // 
            // btnUninstallCS2Server
            // 
            this.btnUninstallCS2Server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUninstallCS2Server.Location = new System.Drawing.Point(197, 112);
            this.btnUninstallCS2Server.Name = "btnUninstallCS2Server";
            this.btnUninstallCS2Server.Size = new System.Drawing.Size(144, 23);
            this.btnUninstallCS2Server.TabIndex = 9;
            this.btnUninstallCS2Server.Text = "Uninstall CS2 Server";
            this.btnUninstallCS2Server.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCS2Sserver
            // 
            this.btnUpdateCS2Sserver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCS2Sserver.Location = new System.Drawing.Point(197, 70);
            this.btnUpdateCS2Sserver.Name = "btnUpdateCS2Sserver";
            this.btnUpdateCS2Sserver.Size = new System.Drawing.Size(144, 23);
            this.btnUpdateCS2Sserver.TabIndex = 8;
            this.btnUpdateCS2Sserver.Text = "Update CS2 Server";
            this.btnUpdateCS2Sserver.UseVisualStyleBackColor = true;
            // 
            // btnInstallCS2Server
            // 
            this.btnInstallCS2Server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallCS2Server.Location = new System.Drawing.Point(197, 30);
            this.btnInstallCS2Server.Name = "btnInstallCS2Server";
            this.btnInstallCS2Server.Size = new System.Drawing.Size(144, 23);
            this.btnInstallCS2Server.TabIndex = 7;
            this.btnInstallCS2Server.Text = "Install CS2 Server";
            this.btnInstallCS2Server.UseVisualStyleBackColor = true;
            this.btnInstallCS2Server.Click += new System.EventHandler(this.btnInstallCS2Server_Click);
            // 
            // btnUpdateServer
            // 
            this.btnUpdateServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateServer.Location = new System.Drawing.Point(16, 112);
            this.btnUpdateServer.Name = "btnUpdateServer";
            this.btnUpdateServer.Size = new System.Drawing.Size(144, 23);
            this.btnUpdateServer.TabIndex = 6;
            this.btnUpdateServer.Text = "Update server";
            this.btnUpdateServer.UseVisualStyleBackColor = true;
            this.btnUpdateServer.Click += new System.EventHandler(this.btnUpdateServer_Click);
            // 
            // btnGetNetworkInfo
            // 
            this.btnGetNetworkInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetNetworkInfo.Location = new System.Drawing.Point(16, 70);
            this.btnGetNetworkInfo.Name = "btnGetNetworkInfo";
            this.btnGetNetworkInfo.Size = new System.Drawing.Size(144, 23);
            this.btnGetNetworkInfo.TabIndex = 5;
            this.btnGetNetworkInfo.Text = "Get network info";
            this.btnGetNetworkInfo.UseVisualStyleBackColor = true;
            this.btnGetNetworkInfo.Click += new System.EventHandler(this.btnGetNetworkInfo_Click);
            // 
            // btnReboot
            // 
            this.btnReboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReboot.Location = new System.Drawing.Point(16, 30);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(144, 23);
            this.btnReboot.TabIndex = 4;
            this.btnReboot.Text = "Reboot server";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // tbxConsoleServer
            // 
            this.tbxConsoleServer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxConsoleServer.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxConsoleServer.Location = new System.Drawing.Point(6, 40);
            this.tbxConsoleServer.Name = "tbxConsoleServer";
            this.tbxConsoleServer.ReadOnly = true;
            this.tbxConsoleServer.Size = new System.Drawing.Size(749, 413);
            this.tbxConsoleServer.TabIndex = 13;
            this.tbxConsoleServer.Text = "";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpServers);
            this.tcMain.Controls.Add(this.tpInstances);
            this.tcMain.Location = new System.Drawing.Point(12, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1140, 513);
            this.tcMain.TabIndex = 14;
            // 
            // bwCheckCs2ServerInstalled
            // 
            this.bwCheckCs2ServerInstalled.WorkerReportsProgress = true;
            this.bwCheckCs2ServerInstalled.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCheckCS2ServerInstalled_DoWork);
            this.bwCheckCs2ServerInstalled.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwCheckCS2ServerInstalled_RunWorkerCompleted);
            // 
            // bwCs2InstallMetamod
            // 
            this.bwCs2InstallMetamod.WorkerReportsProgress = true;
            this.bwCs2InstallMetamod.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCS2InstallMetamod_DoWork);
            this.bwCs2InstallMetamod.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwCS2InstallMetamod_ProgressChanged);
            this.bwCs2InstallMetamod.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwCS2InstallMetamod_RunWorkerCompleted);
            // 
            // bwCs2InstallCsSharp
            // 
            this.bwCs2InstallCsSharp.WorkerReportsProgress = true;
            this.bwCs2InstallCsSharp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCs2InstallCsSharp_DoWork);
            this.bwCs2InstallCsSharp.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwCs2InstallCsSharp_ProgressChanged);
            this.bwCs2InstallCsSharp.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwCs2InstallCsSharp_RunWorkerCompleted);
            // 
            // lblMetamodStatus
            // 
            this.lblMetamodStatus.AutoSize = true;
            this.lblMetamodStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetamodStatus.ForeColor = System.Drawing.Color.Green;
            this.lblMetamodStatus.Location = new System.Drawing.Point(194, 33);
            this.lblMetamodStatus.Name = "lblMetamodStatus";
            this.lblMetamodStatus.Size = new System.Drawing.Size(54, 13);
            this.lblMetamodStatus.TabIndex = 24;
            this.lblMetamodStatus.Text = "Running";
            // 
            // lblCsSStatus
            // 
            this.lblCsSStatus.AutoSize = true;
            this.lblCsSStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCsSStatus.ForeColor = System.Drawing.Color.Green;
            this.lblCsSStatus.Location = new System.Drawing.Point(194, 73);
            this.lblCsSStatus.Name = "lblCsSStatus";
            this.lblCsSStatus.Size = new System.Drawing.Size(54, 13);
            this.lblCsSStatus.TabIndex = 25;
            this.lblCsSStatus.Text = "Running";
            // 
            // btnInstallMatchzy
            // 
            this.btnInstallMatchzy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallMatchzy.Location = new System.Drawing.Point(16, 109);
            this.btnInstallMatchzy.Name = "btnInstallMatchzy";
            this.btnInstallMatchzy.Size = new System.Drawing.Size(144, 23);
            this.btnInstallMatchzy.TabIndex = 26;
            this.btnInstallMatchzy.Text = "Install MatchZy";
            this.btnInstallMatchzy.UseVisualStyleBackColor = true;
            // 
            // lblMatchZyStatus
            // 
            this.lblMatchZyStatus.AutoSize = true;
            this.lblMatchZyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchZyStatus.ForeColor = System.Drawing.Color.Red;
            this.lblMatchZyStatus.Location = new System.Drawing.Point(194, 114);
            this.lblMatchZyStatus.Name = "lblMatchZyStatus";
            this.lblMatchZyStatus.Size = new System.Drawing.Size(78, 13);
            this.lblMatchZyStatus.TabIndex = 27;
            this.lblMatchZyStatus.Text = "Not installed";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 540);
            this.Controls.Add(this.tcMain);
            this.Name = "Main";
            this.Text = "Form1";
            this.gbxInstances.ResumeLayout(false);
            this.tpInstances.ResumeLayout(false);
            this.tpServers.ResumeLayout(false);
            this.tpServers.PerformLayout();
            this.gbxCSServerControl.ResumeLayout(false);
            this.gbxCSServerControl.PerformLayout();
            this.gbxLinuxServerControl.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bwUpdateServer;
        private System.ComponentModel.BackgroundWorker bwInstallCS2Server;
        private System.ComponentModel.BackgroundWorker bwConnectToSserver;
        private System.Windows.Forms.GroupBox gbxInstances;
        private System.Windows.Forms.Button btnStopInstance;
        private System.Windows.Forms.Button btnStartInstance;
        private System.Windows.Forms.Button btnRemoveInstance;
        private System.Windows.Forms.Button btnAddInstance;
        private System.Windows.Forms.ListBox lsbIsntances;
        private System.Windows.Forms.TabPage tpInstances;
        private System.Windows.Forms.TabPage tpServers;
        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cbxServer;
        private System.Windows.Forms.Label lblSelectServer;
        private System.Windows.Forms.Button btnRemoveServer;
        private System.Windows.Forms.GroupBox gbxLinuxServerControl;
        private System.Windows.Forms.Button btnUninstallCS2Server;
        private System.Windows.Forms.Button btnUpdateCS2Sserver;
        private System.Windows.Forms.Button btnInstallCS2Server;
        private System.Windows.Forms.Button btnUpdateServer;
        private System.Windows.Forms.Button btnGetNetworkInfo;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.RichTextBox tbxConsoleServer;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.GroupBox gbxCSServerControl;
        private System.ComponentModel.BackgroundWorker bwCheckCs2ServerInstalled;
        private System.Windows.Forms.Button btnInstallCSSharp;
        private System.Windows.Forms.Button btnInstallMetamod;
        private System.ComponentModel.BackgroundWorker bwCs2InstallMetamod;
        private System.Windows.Forms.Label lblCs2ServerInstalled;
        private System.Windows.Forms.Label lblCs2ServerInstalledTitle;
        private System.Windows.Forms.Label lblServerStatusConnectionTitle;
        private System.Windows.Forms.Label lblServerConnectionStatus;
        private System.ComponentModel.BackgroundWorker bwCs2InstallCsSharp;
        private System.Windows.Forms.Label lblCsSStatus;
        private System.Windows.Forms.Label lblMetamodStatus;
        private System.Windows.Forms.Button btnInstallMatchzy;
        private System.Windows.Forms.Label lblMatchZyStatus;
    }
}

