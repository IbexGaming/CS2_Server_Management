using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Renci.SshNet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CS2_Server_Management
{
    public class Ssh
    {
        public Ssh(string Ip, string Username, string Password)
        {
            this.Ip = Ip;
            this.Username = Username;
            this.Password = Password;
            sshClient = new SshClient(Ip, Username, Password);
        }

        public string Ip { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        private SshClient sshClient;
        private ShellStream shellStream;

        public void Connect()
        {
            try
            {
                sshClient.Connect();

                shellStream = sshClient.CreateShellStream("xterm", 80, 24, 800, 600, 1024);

                /* Run a command
                var cmd = client.RunCommand("ls -la");
                Console.WriteLine("Command output:\n" + cmd.Result);

                client.Disconnect();
                Console.WriteLine("Disconnected.");*/


            }
            catch (Exception ex)
            {
                
            }
        }

        public bool IsSConnected()
        {
            return sshClient.IsConnected;
        }

        internal string SendCommand(string command)
        {
            string output = string.Empty;
            try
            {
                var cmd = sshClient.RunCommand(command);
                
                output = cmd.Result;

            }
            catch (Exception ex)
            {
                output = "ERROR: " + ex.Message;
            }

            return output;
        }

        internal string SendSudoCommand(string command)
        {
            string output = string.Empty;

            try
            {
                // Run sudo command with password input
                string commandText = $"echo {Password} | sudo -S {command}";

                var cmd = sshClient.CreateCommand(commandText);
                var result = cmd.Execute();

                if (command == "reboot")
                {
                    sshClient.Disconnect();

                    output = "Reboot command sent. Disconnected.";
                }

                else
                {
                    output = result;
                }

            }

            catch (Exception ex)
            {
                output = "ERROR: " + ex.Message;
            }

            return output;
        }
    }
}
