using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DockerDesk.Helpers
{
    public static class RenderLogHelper
    {
        public static string LogImages(string[] logLines)
        {
            var imagesContent = new StringBuilder();
            bool isImageSection = false;
            bool isTableHeader = false;

            imagesContent.AppendLine("<style> .table { border-collapse: collapse; width:100% } .table, .table th, .table td { border: 1px solid black; } th, td { text-align: left; padding: 8px; } .command { color: green; font-weight: bold; } </style>");

            foreach (var line in logLines)
            {
                if (line.Contains("> command: docker images"))
                {
                    isImageSection = true;
                    isTableHeader = true;
                    imagesContent.AppendLine("<br/>");
                    imagesContent.AppendLine($"<span class='command'><b>{System.Net.WebUtility.HtmlEncode(line)}<b/></span><br>");
                    imagesContent.AppendLine("<br/>");
                    continue;
                }

                if (isImageSection)
                {
                    if (line.Contains("END ---"))
                    {
                        isImageSection = false;
                        imagesContent.AppendLine("</table>");
                        continue;
                    }

                    if (isTableHeader)
                    {
                        imagesContent.AppendLine("<table class='table'><tr><th>REPOSITORY</th><th>TAG</th><th>IMAGE ID</th><th colspan=\"3\">CREATED</th>\r\n<th>SIZE</th></tr>");
                        isTableHeader = false;
                        continue;
                    }

                    // Uso di Regex per catturare le colonne tenendo conto di spazi multipli
                    var columns = Regex.Matches(line, @"([^\s]+(?=\s|$))|(""[^""]*"")")
                                       .Cast<Match>()
                                       .Select(m => m.Value.Trim('"'))
                                       .ToArray();

                    if (columns.Length >= 5)
                    {
                        imagesContent.AppendLine("<tr>");
                        for (int i = 0; i < columns.Length; i++)
                        {
                            imagesContent.AppendLine($"<td>{System.Net.WebUtility.HtmlEncode(columns[i])}</td>");
                        }
                        imagesContent.AppendLine("</tr>");
                    }
                }
            }

            return imagesContent.ToString();
        }

        public static string LogContainers(string[] logLines)
        {
            var containersContent = new StringBuilder();
            bool isContainerSection = false;

            containersContent.AppendLine("<style> ... </style>"); // I tuoi stili CSS
            containersContent.AppendLine("<style> .table { border-collapse: collapse; width:100% } .table, .table th, .table td { border: 1px solid black; } th, td { text-align: left; padding: 8px; } .command { color: green; font-weight: bold; } </style>");

            foreach (var line in logLines)
            {
                if (line.Contains("> command: docker ps -a"))
                {
                    isContainerSection = true;
                    containersContent.AppendLine("<br/>");
                    containersContent.AppendLine($"<span class='command'><b>{System.Net.WebUtility.HtmlEncode(line)}<b/></span><br>");
                    containersContent.AppendLine("<br/>");

                    containersContent.AppendLine("<table class='table'><tr><th>Container</th></tr>");
                    continue;
                }

                if (isContainerSection)
                {
                    if (line.Contains("END ---"))
                    {
                        isContainerSection = false;
                        containersContent.AppendLine("</table>");
                        break;
                    }

                    // Salta la riga di intestazione del risultato
                    if (line.StartsWith("2023-12-05") && line.Contains("Result:CONTAINER ID"))
                    {
                        continue;
                    }

                    // Inserisci l'intera riga sotto la colonna "Container"
                    containersContent.AppendLine("<tr>");
                    containersContent.AppendLine($"<td>{System.Net.WebUtility.HtmlEncode(line)}</td>");
                    containersContent.AppendLine("</tr>");

                }
            }

            return containersContent.ToString();
        }

        public static string LogVolumes(string[] logLines)
        {
            var volumesContent = new StringBuilder();
            bool isVolumeSection = false;

            volumesContent.AppendLine("<style> ... </style>"); // I tuoi stili CSS

            foreach (var line in logLines)
            {
                if (line.Contains("> command: docker volume ls"))
                {
                    isVolumeSection = true;
                    volumesContent.AppendLine("<br/>");
                    volumesContent.AppendLine($"<span class='command'>{System.Net.WebUtility.HtmlEncode(line)}</span><br>");
                    volumesContent.AppendLine("<br/>");

                    volumesContent.AppendLine("<table class='table'><tr><th>DRIVER</th><th>VOLUME NAME</th></tr>");
                    continue;
                }

                if (isVolumeSection)
                {
                    if (line.Contains("END ---"))
                    {
                        isVolumeSection = false;
                        volumesContent.AppendLine("</table>");
                        break;
                    }

                    // Salta la riga di intestazione del risultato
                    if (line.StartsWith("2023-12-05") && line.Contains("Result:DRIVER"))
                    {
                        continue;
                    }

                    // Parsing delle righe della tabella per i volumi
                    var columns = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (columns.Length >= 2)
                    {
                        volumesContent.AppendLine("<tr>");
                        volumesContent.AppendLine($"<td>{System.Net.WebUtility.HtmlEncode(columns[0])}</td>"); // DRIVER
                        volumesContent.AppendLine($"<td>{System.Net.WebUtility.HtmlEncode(columns[1])}</td>"); // VOLUME NAME
                        volumesContent.AppendLine("</tr>");
                    }
                }
            }

            return volumesContent.ToString();
        }


        public static string LogNetworks(string[] logLines)
        {
            var networksContent = new StringBuilder();
            bool isNetworkSection = false;

            foreach (var line in logLines)
            {
                if (line.Contains("> command: docker network ls"))
                {
                    isNetworkSection = true;

                    networksContent.AppendLine("<br/>");
                    networksContent.AppendLine($"<span class='command'>{System.Net.WebUtility.HtmlEncode(line)}</span><br>");
                    networksContent.AppendLine("<br/>");

                    networksContent.AppendLine("<table class='table'><tr><th>NETWORK ID</th><th>NAME</th><th>DRIVER</th><th>SCOPE</th></tr>");
                    continue;
                }

                if (isNetworkSection)
                {
                    if (line.Contains("END ---"))
                    {
                        isNetworkSection = false;
                        networksContent.AppendLine("</table>");
                        break;
                    }

                    // Salta la riga di intestazione del risultato
                    if (line.StartsWith("2023-12-05") && line.Contains("Result:NETWORK ID"))
                    {
                        continue;
                    }

                    // Parsing delle righe della tabella per le reti
                    var columns = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (columns.Length >= 4)
                    {
                        networksContent.AppendLine("<tr>");
                        // Aggiungi NETWORK ID, NAME, DRIVER e SCOPE
                        for (int i = 0; i < 4; i++)
                        {
                            networksContent.AppendLine($"<td>{System.Net.WebUtility.HtmlEncode(columns[i])}</td>");
                        }
                        networksContent.AppendLine("</tr>");
                    }
                }
            }

            return networksContent.ToString();
        }


        public static string LogVariables(string[] logLines)
        {
            var variablesContent = new StringBuilder();

            // Aggiungi stile CSS per la lista
            variablesContent.AppendLine("<style> ul { list-style-type: none; padding: 0; } li { padding: 5px; border: 1px solid #ddd; margin-bottom: 5px; } </style>");

            bool isVariablesSection = false;

            foreach (var line in logLines)
            {
                if (line.Contains("> command: docker exec") && line.Contains(" env"))
                {
                    isVariablesSection = true;

                    variablesContent.AppendLine("<br/>");
                    variablesContent.AppendLine($"<span class='command'>{System.Net.WebUtility.HtmlEncode(line)}</span><br>");
                    variablesContent.AppendLine("<br/>");

                    variablesContent.AppendLine("<ul>");
                    continue;
                }

                if (isVariablesSection)
                {
                    if (line.Contains("END ---"))
                    {
                        isVariablesSection = false;
                        variablesContent.AppendLine("</ul>");
                        break;
                    }

                    // Salta le righe non necessarie
                    if (line.StartsWith("2023-12-05") || line.Contains("Result:"))
                    {
                        continue;
                    }

                    // Aggiungi la variabile corrente come un elemento della lista
                    variablesContent.AppendLine($"<li>{System.Net.WebUtility.HtmlEncode(line)}</li>");
                }
            }

            return variablesContent.ToString();
        }


    }

}
