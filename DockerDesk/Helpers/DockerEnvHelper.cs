﻿using Newtonsoft.Json;
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
            var containers = await GetDockerContainerIdsAndNamesAsync();

            foreach (var (Id, Name) in containers)
            {
                List<DockerJsonVariable> envVariables = await GetDockerEnvVariablesAsync(Id);

                containersEnvData[Id] = new DockerJsonContainer
                {
                    Name = Name,
                    EnvVariables = envVariables
                };
            }

            string jsonContent = JsonConvert.SerializeObject(containersEnvData, Formatting.Indented);
            File.WriteAllText(Path.Combine(Application.StartupPath, "jvariables.json"), jsonContent);
        }

        private static async Task<List<(string Id, string Name)>> GetDockerContainerIdsAndNamesAsync()
        {
            var result = await DoskerRunner.DockerExecute("ps -a --format \"{{.ID}}:{{.Names}}\"", "");

            if (!string.IsNullOrEmpty(result.Error))
            {
                throw new Exception($"Errore durante l'esecuzione del comando Docker: {result.Error}");
            }

            var containers = new List<(string Id, string Name)>();
            foreach (var line in result.OperationResult.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                var parts = line.Split(':');
                if (parts.Length == 2)
                {
                    containers.Add((Id: parts[1], Name: parts[0]));
                }
            }

            return containers;
        }

        private static async Task<List<DockerJsonVariable>> GetDockerEnvVariablesAsync(string containerId)
        {
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
                var dockerPbj = new DockerJsonVariable { Name = parts[0], Value = parts.Length > 1 ? parts[1] : "" };
                return dockerPbj;
            }).ToList();
        }
    }

}
