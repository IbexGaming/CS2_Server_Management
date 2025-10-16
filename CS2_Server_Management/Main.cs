using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Renci.SshNet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS2_Server_Management
{
    public partial class Main : Form
    {
        Server server = new Server();
        Ssh sshClientConn = null;

        public Main()
        {
            InitializeComponent();

            // Get the list of servers from the XML file
            List<string> serverList = server.GetServers(@".\resources\servers.xml");

            foreach (string server in serverList)
            {
                cbxServer.Items.Add(server);
            }

            /*using (var client = new SshClient(host, username, password))
            {
                try
                {
                    client.Connect();
                    lblResult.Text = "Connected";

                    // Run a command
                    var cmd = client.RunCommand("ls -la");
                    Console.WriteLine("Command output:\n" + cmd.Result);

                    client.Disconnect();
                    Console.WriteLine("Disconnected.");

                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }*/

            // Disable buttons until a server is selected and connected
            btnReboot.Enabled = false;
            btnGetNetworkInfo.Enabled = false;
            btnUpdateServer.Enabled = false;
            btnInstallCS2Server.Enabled = false;
            btnUpdateCS2Sserver.Enabled = false;
            btnUninstallCS2Server.Enabled = false;

            tcMain.TabPages.Remove(tpInstances);
        }

        private void AppendToConsole(string text)
        {
            tbxConsoleServer.AppendText("> " + text + "\n");
            tbxConsoleServer.ScrollToCaret();
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            AppendToConsole(sshClientConn.SendSudoCommand("reboot"));
        }

        private void cbxServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxServer.Text != "")
            {
                lblInfo.Text = "Connecting to server ...";
                cbxServer.Enabled = false;
                bwConnectToSserver.RunWorkerAsync(cbxServer.Text);
            }
        }

        private void btnGetNetworkInfo_Click(object sender, EventArgs e)
        {
            AppendToConsole(sshClientConn.SendCommand("ip a"));
        }

        private void btnInstallCS2Server_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "CS2 server installation in progress...";

            bwInstallCS2Server.RunWorkerAsync();
        }

        /// <summary>
        /// Server update button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateServer_Click(object sender, EventArgs e)
        {
            bwUpdateServer.RunWorkerAsync();
        }

        private void bwUpdateServer_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                lblInfo.Text = "Server update in progress...";

                AppendToConsole(sshClientConn.SendSudoCommand("apt update"));
                AppendToConsole(sshClientConn.SendSudoCommand("apt upgrade"));
                AppendToConsole(sshClientConn.SendSudoCommand("apt list --upgradable"));
            });
        }

        private void bwUpdateServer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lblInfo.Text = "Server update completed.";
            });
        }

        private void bwInstallCS2Server_DoWork(object sender, DoWorkEventArgs e)
        {
            // Get the BackgroundWorker object that raised this event
            var worker = sender as BackgroundWorker;

            // Install dependencies
            worker.ReportProgress(0, sshClientConn.SendSudoCommand("add-apt-repository multiverse"));
            worker.ReportProgress(5, sshClientConn.SendSudoCommand("dpkg --add-architecture i386"));
            worker.ReportProgress(10, sshClientConn.SendSudoCommand("apt update -y"));

            // Install SteamCMD
            worker.ReportProgress(15, sshClientConn.SendSudoCommand("apt install -y lib32gcc-s1 lib32stdc++6 curl tar"));
            worker.ReportProgress(20, sshClientConn.SendCommand("curl -sqL \"https://steamcdn-a.akamaihd.net/client/installer/steamcmd_linux.tar.gz\" | tar zxvf -"));
            worker.ReportProgress(25, sshClientConn.SendCommand("./steamcmd.sh +login anonymous +app_update 730 validate +quit"));

            //  Create link to fix steamclient.so issue
            worker.ReportProgress(90, sshClientConn.SendCommand("mkdir -p /home/cs2/.steam/sdk64/"));
            worker.ReportProgress(95, sshClientConn.SendSudoCommand("ln -s /home/cs2/linux64/steamclient.so /home/cs2/.steam/sdk64/steamclient.so"));

            // Copy config files
        }

        private void bwInstallCS2Server_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string output = e.UserState as string;
            if (!string.IsNullOrEmpty(output))
            {
                AppendToConsole(output);
            }
        }

        private void bwInstallCS2Server_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                lblInfo.Text = "CS2 server installation completed.";
            });
        }

        private void bwConnectToSserver_DoWork(object sender, DoWorkEventArgs e)
        {
            string serverName = e.Argument as string;
            var serverDetails = server.GetServerDetails(@".\resources\servers.xml", serverName);

            sshClientConn = new Ssh(serverDetails.ip, serverDetails.user, serverDetails.password);
            sshClientConn.Connect();
        }

        private void bwConnectToSserver_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var serverDetails = server.GetServerDetails(@".\resources\servers.xml", cbxServer.Text);

            cbxServer.Enabled = true;

            if (sshClientConn.IsSConnected())
            {
                lblServerConnectionStatus.Text = "Connected";
                lblServerConnectionStatus.ForeColor = Color.Green;
                lblServerConnectionStatus.Font = new Font(lblServerConnectionStatus.Font, FontStyle.Bold);
                AppendToConsole("Connected to " + serverDetails.ip + "\n");

                lblInfo.Text = "Successfully connected to server.";

                // bwCheckCs2ServerInstalled.RunWorkerAsync();

                //  Check if CS2 server is installed
                string output = sshClientConn.SendCommand("test -f /home/cs2/Steam/steamapps/common/'Counter-Strike Global Offensive'/game/bin/linuxsteamrt64/cs2 && echo 'True'");

                if (output == "True\n")
                {
                    lblCs2ServerInstalled.Text = "Yes";
                    lblCs2ServerInstalled.ForeColor = Color.Green;
                    lblCs2ServerInstalled.Font = new Font(lblCs2ServerInstalled.Font, FontStyle.Bold);
                }

                else
                {
                    lblCs2ServerInstalled.Text = "No";
                    lblCs2ServerInstalled.ForeColor = Color.Red;
                    lblCs2ServerInstalled.Font = new Font(lblCs2ServerInstalled.Font, FontStyle.Bold);
                }

                btnReboot.Enabled = true;
                btnGetNetworkInfo.Enabled = true;
                btnUpdateServer.Enabled = true;
                btnInstallCS2Server.Enabled = true;
                btnUpdateCS2Sserver.Enabled = true;
                btnUninstallCS2Server.Enabled = true;

                if (!tcMain.TabPages.Contains(tpInstances))
                {
                    tcMain.TabPages.Insert(1, tpInstances);
                }
            }
            else
            {
                lblServerConnectionStatus.Text = "Not connected";
                lblServerConnectionStatus.ForeColor = Color.Red;
                lblServerConnectionStatus.Font = new Font(lblServerConnectionStatus.Font, FontStyle.Bold);
                AppendToConsole("Failed to connect to " + serverDetails.ip + "\n");

                lblInfo.Text = "Failed to connected to server !";

                // Disable buttons until a server is selected and connected
                btnReboot.Enabled = false;
                btnGetNetworkInfo.Enabled = false;
                btnUpdateServer.Enabled = false;
                btnInstallCS2Server.Enabled = false;
                btnUpdateCS2Sserver.Enabled = false;
                btnUninstallCS2Server.Enabled = false;

                tcMain.TabPages.Remove(tpInstances);

                return;
            }
        }

        private void btnStartInstance_Click(object sender, EventArgs e)
        {
            AppendToConsole(sshClientConn.SendCommand("LD_LIBRARY_PATH=\"/home/cs2/Steam/steamapps/common/Counter-Strike Global Offensive/game/csgo/bin/linuxsteamrt64\":$LD_LIBRARY_PATH /home/cs2/Steam/steamapps/common/'Counter-Strike Global Offensive'/game/bin/linuxsteamrt64/cs2 -dedicated -usercon -maxplayers 16 -port 27015 +tv_port 27020 -ip 192.168.1.118 +map de_anubis +game_mode 1 +game_type 0 +hostname \"Test server\""));
        }

        private void bwCheckCS2ServerInstalled_DoWork(object sender, DoWorkEventArgs e)
        {
            // Exécute la commande et stocke le résultat dans e.Result
            string output = sshClientConn.SendCommand("test -f /home/cs2/Steam/steamapps/common/'Counter-Strike Global Offensive'/game/bin/linuxsteamrt64/cs2 && echo 'True'");
            e.Result = output;
        }

        private void bwCheckCS2ServerInstalled_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string output = e.Result as string;
            if(output == "True\n")
            {
                lblCs2ServerInstalled.Text = "Yes";
                lblCs2ServerInstalled.ForeColor = Color.Green;
                lblCs2ServerInstalled.Font = new Font(lblCs2ServerInstalled.Font, FontStyle.Bold);
            }

            else
            {
                lblCs2ServerInstalled.Text = "No";
                lblCs2ServerInstalled.ForeColor = Color.Red;
                lblCs2ServerInstalled.Font = new Font(lblCs2ServerInstalled.Font, FontStyle.Bold);
            }
        }

        private void btnInstallMetamod_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Installing Metamod on CS2 Server ...";

            bwCopyFiles.RunWorkerAsync("metamod");
        }

        private void bwCopyFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            string localPath = "";
            string remotePath = "";

            switch (e.Argument as string)
            {
                case "metamod":
                        localPath = @".\resources\metamod";
                        remotePath = "/home/cs2/Steam/steamapps/common/Counter-Strike Global Offensive/game/csgo/";
                    break;
                case "cssharp":
                        localPath = @".\resources\counterstrikesharp";
                        remotePath = "/home/cs2/Steam/steamapps/common/Counter-Strike Global Offensive/game/csgo/";
                    break;
                default:
                    break;
            }

            worker.ReportProgress(0, "Installing Metamod on CS2 Server");

            // Use SFTP to upload files
            using (var sftp = new SftpClient(sshClientConn.Ip, sshClientConn.Username, sshClientConn.Password))
            {
                sftp.Connect();
                foreach (var file in Directory.GetFiles(localPath, "*", SearchOption.AllDirectories))
                {
                    // Compute the relative path and construct the remote file path
                    string relativePath = file.Substring(localPath.Length).TrimStart('\\', '/');
                    string remoteFilePath = remotePath + relativePath.Replace("\\", "/");

                    // Create remote directory if it doesn't exist
                    string remoteDir = Path.GetDirectoryName(remoteFilePath).Replace("\\","/");
                    EnsureRemoteDirectoryRecursive(sftp, remoteDir);
                    using (var fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                        sftp.UploadFile(fs, remoteFilePath);
                        worker.ReportProgress(0, $"Copied : {relativePath}");
                    }
                }
                sftp.Disconnect();
            }
        }

        private void bwCopyFiles_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string output = e.UserState as string;
            if (!string.IsNullOrEmpty(output))
            {
                AppendToConsole(output);
            }
        }

        private void bwCopyFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                lblInfo.Text = "Files successfully installed on CS2 Server.";
            });
        }

        private void btnInstallCSSharp_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Installing CounterStrikeSharp on CS2 Server ...";

            bwCs2InstallCsSharp.RunWorkerAsync();
        }

        private void bwCs2InstallCsSharp_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            string localCsSharpPath = @".\resources\counterstrikesharp";
            string remoteCsSharpPath = "/home/cs2/Steam/steamapps/common/Counter-Strike Global Offensive/game/csgo/";

            worker.ReportProgress(0, "Installing CounterStrikeSharp on CS2 Server");

            // Use SFTP to upload files
            using (var sftp = new SftpClient(sshClientConn.Ip, sshClientConn.Username, sshClientConn.Password))
            {
                sftp.Connect();
                foreach (var file in Directory.GetFiles(localCsSharpPath, "*", SearchOption.AllDirectories))
                {
                    // Compute the relative path and construct the remote file path
                    string relativePath = file.Substring(localCsSharpPath.Length).TrimStart('\\', '/');
                    string remoteFilePath = remoteCsSharpPath + relativePath.Replace("\\", "/");

                    // Create remote directory if it doesn't exist
                    string remoteDir = Path.GetDirectoryName(remoteFilePath).Replace("\\","/");
                    EnsureRemoteDirectoryRecursive(sftp, remoteDir);
                    using (var fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                        sftp.UploadFile(fs, remoteFilePath);
                        worker.ReportProgress(0, $"Copied : {relativePath}");
                    }
                }
                sftp.Disconnect();
            }
        }

        private void bwCs2InstallCsSharp_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string output = e.UserState as string;
            if (!string.IsNullOrEmpty(output))
            {
                AppendToConsole(output);
            }
        }

        private void bwCs2InstallCsSharp_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                lblInfo.Text = "CounterStrikeSharp successfully installed on CS2 Server.";
            });
        }

        private void EnsureRemoteDirectoryRecursive(Renci.SshNet.SftpClient sftp, string remoteDirectory)
        {
            if (string.IsNullOrEmpty(remoteDirectory) || remoteDirectory == "/")
                return;

            // Normalize separators and remove trailing slash
            remoteDirectory = remoteDirectory.Replace("\\", "/").TrimEnd('/');

            var parts = remoteDirectory.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            string current = remoteDirectory.StartsWith("/") ? "/" : string.Empty;

            foreach (var part in parts)
            {
                current = current == "/" ? "/" + part : current + "/" + part;

                // skip root re-check
                if (current == "/") continue;

                if (!sftp.Exists(current))
                {
                    try
                    {
                        sftp.CreateDirectory(current);
                    }
                    catch (Renci.SshNet.Common.SftpPathNotFoundException)
                    {
                        // If creation fails, rethrow with context
                        throw new InvalidOperationException($"Failed to create remote directory '{current}'. Ensure parent exists and the SFTP user has permissions.");
                    }
                }
            }
        }
    }
}
