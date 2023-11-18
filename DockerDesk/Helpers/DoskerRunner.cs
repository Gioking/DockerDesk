using DockerDesk.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DockerDesk.Helpers
{
    public static class DoskerRunner
    {
        public static async Task<bool> IsDockerRunningAsync()
        {
            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo = new ProcessStartInfo
                    {
                        FileName = "docker",
                        Arguments = "info",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    await Task.Run(() => process.Start());
                    await Task.Run(() => process.WaitForExit());

                    return process.ExitCode == 0;
                }
            }
            catch
            {
                // In caso di errore, assumiamo che Docker non sia in esecuzione
                return false;
            }
        }


        public static async Task<List<DockerImage>> ParseDockerImagesOutputAsync(string output)
        {
            return await Task.Run(() =>
            {
                var imagesList = new List<DockerImage>();

                // Regex per dividere l'output in righe
                var lineRegex = new Regex(@"(.+?\r?\n|\r)");
                var matches = lineRegex.Matches(output);

                // Espressione regolare per corrispondere alle colonne
                var columnRegex = new Regex(@"(\S+)\s+(\S+)\s+(\S+)\s+(.+ ago)\s+(\S+)");

                int ids = 0;
                foreach (Match line in matches)
                {
                    if (line.Success && !line.Value.StartsWith("REPOSITORY"))
                    {
                        var match = columnRegex.Match(line.Value);
                        if (match.Success)
                        {
                            ids++;
                            var image = new DockerImage
                            {
                                Id = ids,
                                Image = match.Groups[1].Value,
                                Tag = match.Groups[2].Value,
                                ImageId = match.Groups[3].Value,
                                Created = match.Groups[4].Value,
                                Size = match.Groups[5].Value
                            };
                            imagesList.Add(image);
                        }
                    }
                }

                return imagesList;
            });
        }


        public static async Task<List<DockerContainer>> ParseDockerContainersOutputAsync(string output)
        {
            return await Task.Run(() =>
            {
                var containersList = new List<DockerContainer>();
                var lines = output.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                // Array di espressioni regolari per gestire diversi formati
                var columnRegexPatterns = new[]
                {
            new Regex(@"(\S+)\s+([\w.-]+(?:\:\w+)?\s+)\s+\""(.*?)\""\s+([\d\w\s]+ ago)\s+([\w\s]+)\s+(.*?)\s+(.+)")
        };

                foreach (var line in lines)
                {
                    if (!line.StartsWith("CONTAINER ID"))
                    {
                        foreach (var regex in columnRegexPatterns)
                        {
                            var match = regex.Match(line);
                            if (match.Success)
                            {
                                var container = new DockerContainer
                                {
                                    ContainerId = match.Groups[1].Value,
                                    Image = match.Groups[2].Value.Trim(),
                                    Command = match.Groups[3].Value,
                                    Created = match.Groups[4].Value,
                                    Status = match.Groups[5].Value,
                                    Ports = match.Groups[6].Value,
                                    Names = match.Groups[7].Value
                                };
                                containersList.Add(container);
                                break; // Esce dal ciclo di regex una volta trovato un match
                            }
                        }
                    }
                }

                return containersList;
            });
        }




        public static async Task<List<DockerVolume>> ParseDockerVolumesOutputAsync(string output)
        {
            return await Task.Run(() =>
            {
                int ids = 0;
                var volumesList = new List<DockerVolume>();

                // Dividi l'output per linee usando entrambi i tipi di newline
                var lines = output.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                if (lines.Length <= 1)
                {
                    Console.WriteLine("Nessun volume da elaborare.");
                    return volumesList;
                }

                foreach (var line in lines.Skip(1))
                {
                    ids++;
                    var columns = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (columns.Length >= 2)
                    {
                        var volume = new DockerVolume
                        {
                            Id = ids,
                            Drive = columns[0],
                            VolumeName = columns[1]
                        };
                        volumesList.Add(volume);
                    }
                }

                return volumesList;
            });
        }


        public static async Task<List<DockerNetwork>> ParseDockerNetworksOutputAsync(string output)
        {
            return await Task.Run(() =>
            {
                int ids = 0;
                var networkList = new List<DockerNetwork>();

                var lines = output.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                if (lines.Length <= 1)
                {
                    Console.WriteLine("Nessun network da elaborare.");
                    return networkList;
                }

                foreach (var line in lines.Skip(1))
                {
                    var columns = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (columns.Length >= 4)
                    {
                        ids++;
                        var network = new DockerNetwork
                        {
                            Id = ids,
                            NetworkId = columns[0],
                            Name = columns[1],
                            Drive = columns[2],
                            Scope = columns[3]
                        };
                        networkList.Add(network);
                    }
                }

                return networkList;
            });
        }



        public static async Task<ResultModel> DockerExecute(string arguments, string workdir)
        {
            try
            {
                LogHelper.LogInfo($"Command: docker {arguments}");

                StringBuilder output = new StringBuilder();
                StringBuilder error = new StringBuilder();

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    WorkingDirectory = workdir,
                    FileName = "docker",
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();

                    using (StreamReader outputReader = process.StandardOutput)
                    using (StreamReader errorReader = process.StandardError)
                    {
                        // Legge l'output man mano che è disponibile
                        while (!process.HasExited)
                        {
                            output.Append(outputReader.ReadToEnd());
                            error.Append(errorReader.ReadToEnd());
                        }

                        // Leggi eventuali resti dopo l'uscita del processo
                        output.Append(outputReader.ReadToEnd());
                        error.Append(errorReader.ReadToEnd());

                        await Task.Run(() => process.WaitForExit());
                    }
                }

                string OperationResult = output.ToString();
                string ErrorResult = error.ToString();

                ResultModel resultModel = new ResultModel();

                resultModel.OperationResult = OperationResult;
                resultModel.Error = ErrorResult;

                if (!string.IsNullOrEmpty(OperationResult))
                {
                    resultModel.OperationResult = OperationResult;
                }
                else if (!string.IsNullOrEmpty(ErrorResult))
                {
                    resultModel.OperationResult = ErrorResult;
                }

                return resultModel;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Si è verificato un errore: {e.Message}");
                LogHelper.LogError($"Err: {e.Message}");
                return null;
            }
        }



        //public static void DockerExecuteCmd(string arguments, string workdir = null)
        //{
        //    try
        //    {
        //        ProcessStartInfo startInfo = new ProcessStartInfo
        //        {
        //            WorkingDirectory = workdir,
        //            FileName = "cmd.exe", // Utilizziamo cmd.exe per eseguire il comando
        //            Arguments = $"/K docker {arguments}", // Modifica qui per utilizzare /K
        //            UseShellExecute = true // Impostato su true per utilizzare una shell esterna
        //        };

        //        Process process = new Process();
        //        process.StartInfo = startInfo;
        //        process.Start();

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine($"Si è verificato un errore: {e.Message}");
        //    }
        //}

    }
}
