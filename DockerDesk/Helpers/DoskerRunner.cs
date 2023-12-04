using DockerDesk.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                return false;
            }
        }

        public static bool IsSshConnected(SshClientManager sshClientManager)
        {
            try
            {
                return sshClientManager.GetClient().IsConnected;
            }
            catch
            {
                return false;
            }
        }

        public static async Task<List<DockerImage>> ParseDockerImagesOutputAsync(string output)
        {
            return await Task.Run(() =>
            {
                var imagesList = new List<DockerImage>();

                var lineRegex = new Regex(@"(.+?\r?\n|\r)");
                var matches = lineRegex.Matches(output);

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
                                break;
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

        public static async Task<List<DockerVariable>> ParseDockerEnvOutputAsync(string output)
        {
            return await Task.Run(() =>
            {
                var variableList = new List<DockerVariable>();
                var lines = output.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var line in lines)
                {
                    var keyValue = line.Split(new[] { '=' }, 2);
                    if (keyValue.Length == 2)
                    {
                        var variable = new DockerVariable
                        {
                            Key = keyValue[0],
                            Value = keyValue[1]
                        };
                        variableList.Add(variable);
                    }
                }

                return variableList;
            });
        }

        //Local Docker
        public static async Task<ResultModel> DockerExecute(string arguments, string workdir)
        {
            ResultModel resultModel = new ResultModel();

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

                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    process.OutputDataReceived += (sender, args) => output.AppendLine(args.Data);
                    process.ErrorDataReceived += (sender, args) => error.AppendLine(args.Data);

                    await Task.Run(() => process.WaitForExit());

                    string OperationResult = output.ToString();
                    string ErrorResult = error.ToString();

                    if (!string.IsNullOrEmpty(OperationResult))
                    {
                        resultModel.OperationResult = OperationResult;
                    }
                    else if (!string.IsNullOrEmpty(ErrorResult))
                    {
                        resultModel.OperationResult = ErrorResult;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Si è verificato un errore: {e.Message}");
                LogHelper.LogError($"Err: {e.Message}");
                resultModel.OperationResult = e.Message;
                return resultModel;
            }

            return resultModel;
        }

        //Remote Docker
        public static async Task<ResultModel> DockerExecute(string arguments, SshClientManager sshClientManager)
        {
            ResultModel resultModel = new ResultModel();

            try
            {
                LogHelper.LogInfo($"> Command: docker {arguments}");

                var dockerCommandExecutor = new DockerCommandExecutor(sshClientManager);
                string result = await dockerCommandExecutor.SendDockerCommandAsync(arguments);

                if (!string.IsNullOrEmpty(result))
                {
                    resultModel.OperationResult = result;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Si è verificato un errore: {e.Message}");
                LogHelper.LogError($"Err: {e.Message}");
                return null;
            }

            return resultModel;
        }

        //Remote Docker
        public static async Task<ResultModel> DockerCreateImage(string arguments, SshClientManager sshClientManager)
        {
            ResultModel resultModel = new ResultModel();

            try
            {
                LogHelper.LogInfo($"Command: docker {arguments}");


                var client = sshClientManager.GetClient();

                if (client == null)
                {
                    MessageBox.Show("Please connect ssh client first.");
                    return null;
                }

                var cmd = client.CreateCommand(arguments);
                var result = await Task.Run(() => cmd.Execute());

                if (!string.IsNullOrEmpty(result))
                {
                    resultModel.OperationResult = result;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Si è verificato un errore: {e.Message}");
                LogHelper.LogError($"Err: {e.Message}");
                return null;
            }

            return resultModel;
        }

        public static async Task<List<DockerProcess>> ParseDockerTopOutputAsync(string output)
        {
            return await Task.Run(() =>
            {
                var processList = new List<DockerProcess>();
                var lines = output.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                if (lines.Length <= 1)
                {
                    Console.WriteLine("Nessun processo da elaborare.");
                    return processList;
                }

                foreach (var line in lines.Skip(1))
                {
                    var columns = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (columns.Length >= 8)
                    {
                        var process = new DockerProcess
                        {
                            Id = processList.Count + 1,
                            UID = columns[0],
                            PID = int.Parse(columns[1]),
                            PPID = int.Parse(columns[2]),
                            C = int.Parse(columns[3]),
                            STIME = columns[4],
                            TTY = columns[5],
                            TIME = columns[6],
                            CMD = string.Join(" ", columns.Skip(7))
                        };
                        processList.Add(process);
                    }
                }

                return processList;
            });
        }

    }
}
