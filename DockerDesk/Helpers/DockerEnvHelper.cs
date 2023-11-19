using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerDesk.Helpers
{
    public static class DockerEnvHelper
    {
        public static async Task UpdateJsonFileWithContainerEnvVariables()
        {
            var containersEnvData = new Dictionary<string, DockerJsonContainer>();
            List<string> containerIds = await GetDockerContainerNamesAsync();

            foreach (var containerId in containerIds)
            {
                List<DockerJsonVariable> envVariables = await GetDockerEnvVariablesAsync(containerId);

                containersEnvData[containerId] = new DockerJsonContainer
                {
                    Name = containerId,
                    EnvVariables = envVariables
                };
            }

            string jsonContent = JsonConvert.SerializeObject(containersEnvData, Formatting.Indented);
            File.WriteAllText(Path.Combine(Application.StartupPath, "jvariables.json"), jsonContent);
        }

        private static async Task<List<string>> GetDockerContainerNamesAsync()
        {
            var result = await DoskerRunner.DockerExecute("ps -q", ""); // Ottiene tutti i container

            if (!string.IsNullOrEmpty(result.Error))
            {
                throw new Exception($"Errore durante l'esecuzione del comando Docker: {result.Error}");
            }

            return result.OperationResult.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        private static async Task<List<DockerJsonVariable>> GetDockerEnvVariablesAsync(string containerId)
        {
            // Nota l'uso di doppie parentesi graffe per rappresentare una singola parentesi graffa nel comando
            var command = $"inspect --format=\"{{{{json .Config.Env}}}}\" {containerId}";
            var result = await DoskerRunner.DockerExecute(command, "");

            if (!string.IsNullOrEmpty(result.Error))
            {
                throw new Exception($"Errore durante l'esecuzione del comando Docker: {result.Error}");
            }

            var envVariables = JsonConvert.DeserializeObject<List<string>>(result.OperationResult);
            return envVariables.Select(envVar =>
            {
                var parts = envVar.Split('=');
                return new DockerJsonVariable { Name = parts[0], Value = parts.Length > 1 ? parts[1] : "" };
            }).ToList();
        }

    }
}
