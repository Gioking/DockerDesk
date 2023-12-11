using Renci.SshNet;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerDesk.Helpers
{
    public class DockerImageHelpers
    {
        public static async Task<bool> CleanSourceFilesAsync(string remotePath, SshClientManager sshClientManager)
        {
            try
            {
                var client = sshClientManager.GetClient();

                if (client == null)
                {
                    MessageBox.Show("Please connect ssh client first.");
                    return false;
                }

                using (var sshClient = new SshClient(client.ConnectionInfo))
                {
                    sshClient.Connect();
                    var cmd = sshClient.CreateCommand($"rm -rf {remotePath}*");
                    var result = await Task.Run(() => cmd.Execute());
                    sshClient.Disconnect();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Si è verificato un errore: {ex.Message}");
            }

            return false; // La porta non è in uso
        }
    }
}
