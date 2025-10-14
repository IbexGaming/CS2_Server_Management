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

            gbxInstances.Visible = false;
        }

        private void AppendToConsole(string text)
        {
            tbxConsole.AppendText("> " + text + "\n");
            tbxConsole.ScrollToCaret();
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            AppendToConsole(sshClientConn.SendSudoCommand("reboot"));
        }

        private void cbxServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxServer.Text != "")
            {
                lblStatus.Text = "Connecting to server ...";
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
            lblStatus.Text = "CS2 server installation in progress...";

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
                lblStatus.Text = "Server update in progress...";

                AppendToConsole(sshClientConn.SendSudoCommand("apt update"));
                AppendToConsole(sshClientConn.SendSudoCommand("apt upgrade"));
                AppendToConsole(sshClientConn.SendSudoCommand("apt list --upgradable"));
            });
        }

        private void bwUpdateServer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Server update completed.";
            });
        }

        private void bwInstallCS2Server_DoWork(object sender, DoWorkEventArgs e)
        {
            // Get the BackgroundWorker object that raised this event
            var worker = sender as BackgroundWorker;

            // Install dependencies
            worker.ReportProgress(0, sshClientConn.SendSudoCommand("add-apt-repository multiverse"));
            worker.ReportProgress(0, sshClientConn.SendSudoCommand("dpkg --add-architecture i386"));
            worker.ReportProgress(0, sshClientConn.SendSudoCommand("apt update -y"));

            // Install SteamCMD
            worker.ReportProgress(0, sshClientConn.SendSudoCommand("apt install -y lib32gcc-s1 lib32stdc++6 curl tar"));
            worker.ReportProgress(0, sshClientConn.SendCommand("curl -sqL \"https://steamcdn-a.akamaihd.net/client/installer/steamcmd_linux.tar.gz\" | tar zxvf -"));
            worker.ReportProgress(0, sshClientConn.SendCommand("./steamcmd.sh +login anonymous +app_update 730 validate +quit"));

            //  Create link to fix steamclient.so issue
            worker.ReportProgress(0, sshClientConn.SendSudoCommand("ln -s /home/cs2/linux64/steamclient.so /home/cs2/.steam/sdk64/steamclient.so"));
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
                lblStatus.Text = "CS2 server installation completed.";
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
                lblConnectionStatus.Text = "Connected";
                lblConnectionStatus.ForeColor = Color.Green;
                lblConnectionStatus.Font = new Font(lblConnectionStatus.Font, FontStyle.Bold);
                AppendToConsole("Connected to " + serverDetails.ip + "\n");

                lblStatus.Text = "Successfully connected to server.";

                btnReboot.Enabled = true;
                btnGetNetworkInfo.Enabled = true;
                btnUpdateServer.Enabled = true;
                btnInstallCS2Server.Enabled = true;
                btnUpdateCS2Sserver.Enabled = true;
                btnUninstallCS2Server.Enabled = true;

                gbxInstances.Visible = true;
            }
            else
            {
                lblConnectionStatus.Text = "Not connected";
                lblConnectionStatus.ForeColor = Color.Red;
                lblConnectionStatus.Font = new Font(lblConnectionStatus.Font, FontStyle.Bold);
                AppendToConsole("Failed to connect to " + serverDetails.ip + "\n");

                lblStatus.Text = "Failed to connected to server !";

                // Disable buttons until a server is selected and connected
                btnReboot.Enabled = false;
                btnGetNetworkInfo.Enabled = false;
                btnUpdateServer.Enabled = false;
                btnInstallCS2Server.Enabled = false;
                btnUpdateCS2Sserver.Enabled = false;
                btnUninstallCS2Server.Enabled = false;

                gbxInstances.Visible = false;

                return;
            }
        }

        private void btnStartInstance_Click(object sender, EventArgs e)
        {
            AppendToConsole(sshClientConn.SendCommand("LD_LIBRARY_PATH=\"/home/cs2/Steam/steamapps/common/Counter-Strike Global Offensive/game/csgo/bin/linuxsteamrt64\":$LD_LIBRARY_PATH /home/cs2/Steam/steamapps/common/'Counter-Strike Global Offensive'/game/bin/linuxsteamrt64/cs2 -dedicated -usercon -maxplayers 16 -port 27015 +tv_port 27020 -ip 192.168.1.118 +map de_anubis +game_mode 1 +game_type 0 +hostname \"Test server\""));
        }
    }
}
