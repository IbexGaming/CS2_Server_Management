using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CS2_Server_Management
{
    public class Server
    {
        public List<string> GetServers(string FilePath)
        {
            List<string> servers = new List<string>();

            XDocument doc = XDocument.Load(FilePath);
            foreach (var server in doc.Descendants("server"))
            {
                string name = server.Element("name")?.Value;
                if (!string.IsNullOrEmpty(name))
                {
                    servers.Add(name);
                }
            }

            return servers;
        }

        public (string ip, string user, string password, string port) GetServerDetails(string filePath, string serverName)
        {
            try
            {
                XDocument doc = XDocument.Load(filePath);
                var server = doc.Descendants("server")
                                .FirstOrDefault(s => (string)s.Element("name") == serverName);

                if (server != null)
                {
                    string ip = server.Element("ip")?.Value ?? "";
                    string user = server.Element("user")?.Value ?? "";
                    string password = server.Element("password")?.Value ?? "";
                    string port = server.Element("port")?.Value ?? "";

                    return (ip, user, password, port);
                }
                else
                {
                    return ("Not found", "", "", "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return ("Error", "", "", "");
            }
        }
    }
}
