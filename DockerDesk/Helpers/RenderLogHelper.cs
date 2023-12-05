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
                    imagesContent.AppendLine($"<span class='command'>{System.Net.WebUtility.HtmlEncode(line)}</span><br>");
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
    }

}
