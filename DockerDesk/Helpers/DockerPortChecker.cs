using System;
using System.Diagnostics;
using System.Threading.Tasks;

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
                                return true; // La porta è in uso da un container Docker
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
    }
}
