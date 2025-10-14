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
            this.tbxConsole = new System.Windows.Forms.RichTextBox();
            this.lblSelectServer = new System.Windows.Forms.Label();
            this.cbxServer = new System.Windows.Forms.ComboBox();
            this.btnReboot = new System.Windows.Forms.Button();
            this.gbxServerControl = new System.Windows.Forms.GroupBox();
            this.btnUninstallCS2Server = new System.Windows.Forms.Button();
            this.btnUpdateCS2Sserver = new System.Windows.Forms.Button();
            this.btnInstallCS2Server = new System.Windows.Forms.Button();
            this.btnUpdateServer = new System.Windows.Forms.Button();
            this.btnGetNetworkInfo = new System.Windows.Forms.Button();
            this.lblConnectionStatusTitle = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.bwUpdateServer = new System.ComponentModel.BackgroundWorker();
            this.bwInstallCS2Server = new System.ComponentModel.BackgroundWorker();
            this.bwConnectToSserver = new System.ComponentModel.BackgroundWorker();
            this.btnAddServer = new System.Windows.Forms.Button();
            this.btnRemoveServer = new System.Windows.Forms.Button();
            this.gbxInstances = new System.Windows.Forms.GroupBox();
            this.btnStopInstance = new System.Windows.Forms.Button();
            this.btnStartInstance = new System.Windows.Forms.Button();
            this.btnRemoveInstance = new System.Windows.Forms.Button();
            this.btnAddInstance = new System.Windows.Forms.Button();
            this.lsbIsntances = new System.Windows.Forms.ListBox();
            this.bwStartInstance = new System.ComponentModel.BackgroundWorker();
            this.gbxServerControl.SuspendLayout();
            this.gbxInstances.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxConsole
            // 
            this.tbxConsole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxConsole.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxConsole.Location = new System.Drawing.Point(12, 37);
            this.tbxConsole.Name = "tbxConsole";
            this.tbxConsole.ReadOnly = true;
            this.tbxConsole.Size = new System.Drawing.Size(749, 413);
            this.tbxConsole.TabIndex = 3;
            this.tbxConsole.Text = "";
            // 
            // lblSelectServer
            // 
            this.lblSelectServer.AutoSize = true;
            this.lblSelectServer.Location = new System.Drawing.Point(12, 13);
            this.lblSelectServer.Name = "lblSelectServer";
            this.lblSelectServer.Size = new System.Drawing.Size(44, 13);
            this.lblSelectServer.TabIndex = 5;
            this.lblSelectServer.Text = "Server :";
            // 
            // cbxServer
            // 
            this.cbxServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxServer.FormattingEnabled = true;
            this.cbxServer.Location = new System.Drawing.Point(62, 10);
            this.cbxServer.Name = "cbxServer";
            this.cbxServer.Size = new System.Drawing.Size(156, 21);
            this.cbxServer.TabIndex = 6;
            this.cbxServer.SelectedIndexChanged += new System.EventHandler(this.cbxServer_SelectedIndexChanged);
            // 
            // btnReboot
            // 
            this.btnReboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReboot.Location = new System.Drawing.Point(6, 19);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(144, 23);
            this.btnReboot.TabIndex = 4;
            this.btnReboot.Text = "Reboot server";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // gbxServerControl
            // 
            this.gbxServerControl.Controls.Add(this.btnUninstallCS2Server);
            this.gbxServerControl.Controls.Add(this.btnUpdateCS2Sserver);
            this.gbxServerControl.Controls.Add(this.btnInstallCS2Server);
            this.gbxServerControl.Controls.Add(this.btnUpdateServer);
            this.gbxServerControl.Controls.Add(this.btnGetNetworkInfo);
            this.gbxServerControl.Controls.Add(this.btnReboot);
            this.gbxServerControl.Location = new System.Drawing.Point(767, 32);
            this.gbxServerControl.Name = "gbxServerControl";
            this.gbxServerControl.Size = new System.Drawing.Size(337, 110);
            this.gbxServerControl.TabIndex = 7;
            this.gbxServerControl.TabStop = false;
            this.gbxServerControl.Text = "Server control";
            // 
            // btnUninstallCS2Server
            // 
            this.btnUninstallCS2Server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUninstallCS2Server.Location = new System.Drawing.Point(187, 77);
            this.btnUninstallCS2Server.Name = "btnUninstallCS2Server";
            this.btnUninstallCS2Server.Size = new System.Drawing.Size(144, 23);
            this.btnUninstallCS2Server.TabIndex = 9;
            this.btnUninstallCS2Server.Text = "Uninstall CS2 Server";
            this.btnUninstallCS2Server.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCS2Sserver
            // 
            this.btnUpdateCS2Sserver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCS2Sserver.Location = new System.Drawing.Point(187, 48);
            this.btnUpdateCS2Sserver.Name = "btnUpdateCS2Sserver";
            this.btnUpdateCS2Sserver.Size = new System.Drawing.Size(144, 23);
            this.btnUpdateCS2Sserver.TabIndex = 8;
            this.btnUpdateCS2Sserver.Text = "Update CS2 Server";
            this.btnUpdateCS2Sserver.UseVisualStyleBackColor = true;
            // 
            // btnInstallCS2Server
            // 
            this.btnInstallCS2Server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallCS2Server.Location = new System.Drawing.Point(187, 19);
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
            this.btnUpdateServer.Location = new System.Drawing.Point(6, 77);
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
            this.btnGetNetworkInfo.Location = new System.Drawing.Point(6, 48);
            this.btnGetNetworkInfo.Name = "btnGetNetworkInfo";
            this.btnGetNetworkInfo.Size = new System.Drawing.Size(144, 23);
            this.btnGetNetworkInfo.TabIndex = 5;
            this.btnGetNetworkInfo.Text = "Get network info";
            this.btnGetNetworkInfo.UseVisualStyleBackColor = true;
            this.btnGetNetworkInfo.Click += new System.EventHandler(this.btnGetNetworkInfo_Click);
            // 
            // lblConnectionStatusTitle
            // 
            this.lblConnectionStatusTitle.AutoSize = true;
            this.lblConnectionStatusTitle.Location = new System.Drawing.Point(537, 13);
            this.lblConnectionStatusTitle.Name = "lblConnectionStatusTitle";
            this.lblConnectionStatusTitle.Size = new System.Drawing.Size(43, 13);
            this.lblConnectionStatusTitle.TabIndex = 8;
            this.lblConnectionStatusTitle.Text = "Status :";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(586, 13);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(10, 13);
            this.lblConnectionStatus.TabIndex = 9;
            this.lblConnectionStatus.Text = "-";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 459);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(312, 18);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // btnAddServer
            // 
            this.btnAddServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServer.Location = new System.Drawing.Point(224, 10);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(100, 21);
            this.btnAddServer.TabIndex = 11;
            this.btnAddServer.Text = "Add";
            this.btnAddServer.UseVisualStyleBackColor = true;
            // 
            // btnRemoveServer
            // 
            this.btnRemoveServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveServer.Location = new System.Drawing.Point(340, 9);
            this.btnRemoveServer.Name = "btnRemoveServer";
            this.btnRemoveServer.Size = new System.Drawing.Size(100, 21);
            this.btnRemoveServer.TabIndex = 12;
            this.btnRemoveServer.Text = "Remove";
            this.btnRemoveServer.UseVisualStyleBackColor = true;
            // 
            // gbxInstances
            // 
            this.gbxInstances.Controls.Add(this.btnStopInstance);
            this.gbxInstances.Controls.Add(this.btnStartInstance);
            this.gbxInstances.Controls.Add(this.btnRemoveInstance);
            this.gbxInstances.Controls.Add(this.btnAddInstance);
            this.gbxInstances.Controls.Add(this.lsbIsntances);
            this.gbxInstances.Location = new System.Drawing.Point(768, 149);
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
            // bwStartInstance
            // 
            this.bwStartInstance.WorkerReportsProgress = true;
            this.bwStartInstance.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwStartInstance_DoWork);
            this.bwStartInstance.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwStartInstance_ProgressChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 492);
            this.Controls.Add(this.gbxInstances);
            this.Controls.Add(this.btnRemoveServer);
            this.Controls.Add(this.btnAddServer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.lblConnectionStatusTitle);
            this.Controls.Add(this.gbxServerControl);
            this.Controls.Add(this.cbxServer);
            this.Controls.Add(this.lblSelectServer);
            this.Controls.Add(this.tbxConsole);
            this.Name = "Main";
            this.Text = "Form1";
            this.gbxServerControl.ResumeLayout(false);
            this.gbxInstances.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox tbxConsole;
        private System.Windows.Forms.Label lblSelectServer;
        private System.Windows.Forms.ComboBox cbxServer;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.GroupBox gbxServerControl;
        private System.Windows.Forms.Button btnGetNetworkInfo;
        private System.Windows.Forms.Button btnUpdateServer;
        private System.Windows.Forms.Label lblConnectionStatusTitle;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnInstallCS2Server;
        private System.Windows.Forms.Button btnUninstallCS2Server;
        private System.Windows.Forms.Button btnUpdateCS2Sserver;
        private System.Windows.Forms.Label lblStatus;
        private System.ComponentModel.BackgroundWorker bwUpdateServer;
        private System.ComponentModel.BackgroundWorker bwInstallCS2Server;
        private System.ComponentModel.BackgroundWorker bwConnectToSserver;
        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.Button btnRemoveServer;
        private System.Windows.Forms.GroupBox gbxInstances;
        private System.Windows.Forms.Button btnStopInstance;
        private System.Windows.Forms.Button btnStartInstance;
        private System.Windows.Forms.Button btnRemoveInstance;
        private System.Windows.Forms.Button btnAddInstance;
        private System.Windows.Forms.ListBox lsbIsntances;
        private System.ComponentModel.BackgroundWorker bwStartInstance;
    }
}

