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

            imagesContent.AppendLine("<style> .table { border-collapse: collapse; } .table, .table th, .table td { border: 1px solid black; } th, td { text-align: left; padding: 8px; } .command { color: green; font-weight: bold; } </style>");

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

        //public static string LogContainers(string[] logLines)
        //{
        //    var containersContent = new StringBuilder();
        //    bool isContainerSection = false;

        //    containersContent.AppendLine("<style> ... </style>"); // Aggiungi qui i tuoi stili CSS

        //    foreach (var line in logLines)
        //    {
        //        if (line.Contains("> command: docker ps -a"))
        //        {
        //            isContainerSection = true;
        //            containersContent.AppendLine($"<span class='command'>{System.Net.WebUtility.HtmlEncode(line)}</span><br>");
        //            containersContent.AppendLine("<table class='table'><tr><th>CONTAINER ID</th><th>IMAGE</th><th>COMMAND</th><th>CREATED</th><th>STATUS</th><th>PORTS</th><th>NAMES</th></tr>");
        //            continue;
        //        }

        //        if (isContainerSection)
        //        {
        //            if (line.Contains("END ---"))
        //            {
        //                isContainerSection = false;
        //                containersContent.AppendLine("</table>");
        //                break;
        //            }

        //            // Parsing delle righe della tabella per i contenitori
        //            var columns = Regex.Matches(line, @"([^\s\""]+|\""[^\""]*"")|\b\d+\s+\w+\s+ago")
        //                               .Cast<Match>()
        //                               .Select(m => m.Value.Trim('"'))
        //                               .ToList();

        //            if (columns.Count >= 7)
        //            {
        //                containersContent.AppendLine("<tr>");
        //                foreach (var column in columns.Take(7))
        //                {
        //                    containersContent.AppendLine($"<td>{System.Net.WebUtility.HtmlEncode(column)}</td>");
        //                }
        //                containersContent.AppendLine("</tr>");
        //            }
        //        }
        //    }

        //    return containersContent.ToString();
        //}



    }

}
