using DockerDesk.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
    }
}
