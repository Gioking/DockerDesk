using Renci.SshNet;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerDesk.Helpers
{
    public class DockerPortChecker
    {
        public static async Task<bool> IsPortInUseByDockerContainerAsync(int port)
        {
            try
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = "docker",
                    Arguments = "ps --format \"{{.Ports}}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process { StartInfo = startInfo })
                {
                    process.Start();
                    using (var reader = process.StandardOutput)
                    {
                        string line;
                        while ((line = await reader.ReadLineAsync()) != null)
                        {
                            if (line.Contains($":{port}->"))
                            {
                                return true;
                            }
                        }
                    }

                    await Task.Run(() => process.WaitForExit());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Si è verificato un errore: {ex.Message}");
            }

            return false; // La porta non è in uso
        }

        public static async Task<bool> IsRemotePortInUseByDockerContainerAsync(int port, SshClientManager sshClientManager)
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
                    var cmd = sshClient.CreateCommand("docker ps --format '{{.Ports}}'");
                    var result = cmd.Execute();
                    sshClient.Disconnect();

                    if (result.Contains(port.ToString()))
                    {
                        return true;
                    }
                }


                //using (var process = new Process { StartInfo = startInfo })
                //{
                //    process.Start();
                //    using (var reader = process.StandardOutput)
                //    {
                //        string line;
                //        while ((line = await reader.ReadLineAsync()) != null)
                //        {
                //            if (line.Contains($":{port}->"))
                //            {
                //                return true;
                //            }
                //        }
                //    }

                //    await Task.Run(() => process.WaitForExit());
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Si è verificato un errore: {ex.Message}");
            }

            return false; // La porta non è in uso
        }
    }
}
