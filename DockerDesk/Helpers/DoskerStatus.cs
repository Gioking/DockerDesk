using DockerDesk.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace DockerDesk.Helpers
{
    public static class DoskerStatus
    {
        public static bool IsDockerRunning()
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

                    process.Start();
                    process.WaitForExit();

                    return process.ExitCode == 0;
                }
            }
            catch
            {
                // In caso di errore, assumiamo che Docker non sia in esecuzione
                return false;
            }
        }
        public static List<DockerImage> ParseDockerImagesOutput(string output)
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
        }

        public static List<DockerContainer> ParseDockerContainersOutput(string output)
        {
            var containersList = new List<DockerContainer>();

            // Regex per dividere l'output in righe
            var lineRegex = new Regex(@"(.+?\r?\n|\r)");
            var matches = lineRegex.Matches(output);

            // Aggiornare l'espressione regolare per corrispondere alle colonne desiderate
            var columnRegex = new Regex(@"(\S+)\s+(\S+)\s+(\"".+?\"")\s+(.+ ago)\s+(\S+)\s+(\S+)\s+(.+)");

            foreach (Match line in matches)
            {
                if (line.Success && !line.Value.StartsWith("CONTAINER ID"))
                {
                    var match = columnRegex.Match(line.Value);
                    if (match.Success)
                    {
                        var container = new DockerContainer
                        {
                            ContainerId = match.Groups[1].Value,
                            Image = match.Groups[2].Value,
                            Command = match.Groups[3].Value,
                            Created = match.Groups[4].Value,
                            Status = match.Groups[5].Value,
                            Ports = match.Groups[6].Value,
                            Names = match.Groups[7].Value
                        };
                        containersList.Add(container);
                    }
                }
            }

            return containersList;
        }


        public static string DockerExecute(string arguments, string workdir)
        {
            try
            {
                StringBuilder output = new StringBuilder();
                StringBuilder error = new StringBuilder();

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    WorkingDirectory = workdir,
                    FileName = "docker",
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
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

                        process.WaitForExit();
                    }
                }

                string OperationResult = output.ToString();
                string ErrorResult = error.ToString();

                if (!string.IsNullOrEmpty(OperationResult))
                {
                    return OperationResult;
                }
                else if (!string.IsNullOrEmpty(ErrorResult))
                {
                    return ErrorResult;
                }
                else
                {
                    return "Nessun output o errore rilevato.";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Si è verificato un errore: {e.Message}");
                return "Error:";
            }
        }



        public static void DockerExecute2(string arguments, string workdir = null)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    WorkingDirectory = workdir,
                    FileName = "cmd.exe", // Utilizziamo cmd.exe per eseguire il comando
                    Arguments = $"/K docker {arguments}", // Modifica qui per utilizzare /K
                    UseShellExecute = true // Impostato su true per utilizzare una shell esterna
                };

                Process process = new Process();
                process.StartInfo = startInfo;
                process.Start();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Si è verificato un errore: {e.Message}");
            }
        }

    }
}
