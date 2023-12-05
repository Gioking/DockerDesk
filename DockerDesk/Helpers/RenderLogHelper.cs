using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerDesk.Helpers
{
    public static class RenderLogHelper
    {

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


        //--------------------------------------------------------------

        public static Task<string> ReportDataGridAsync(DataGridView grid)
        {
            StringBuilder html = new StringBuilder();

            // DOCTYPE e inizio del file HTML
            html.Append("<!DOCTYPE html>");
            html.Append("<html>");

            // CSS per garantire che la tabella sia larga al 100%
            html.Append("<head>");
            html.Append("<style>");
            html.Append("html, body { width: 100%; margin: 0; padding: 0; }");
            html.Append("table { width: 100%; border-collapse: collapse; }");
            html.Append("th, td { border: 1px solid black; }");
            html.Append("th { background-color: blue; color: white; }"); // Stile per le celle di intestazione
            html.Append("h3 { color:darkgreen; font-weight: bold; font-size: 20px; }");
            html.Append("</style>");
            html.Append("</head>");


            // Inizio del corpo e della tabella
            html.Append("<body>");

            html.Append("<br/>");
            html.Append($"<h3>---{grid.Tag}</h3>");

            html.Append("<table>");

            // Aggiunta delle intestazioni
            html.Append("<tr>");
            foreach (DataGridViewColumn column in grid.Columns)
            {
                html.Append("<th>");
                html.Append(column.HeaderText);
                html.Append("</th>");
            }
            html.Append("</tr>");

            // Aggiunta delle righe dei dati
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue; // Ignora la riga per l'inserimento di nuovi dati

                html.Append("<tr>");
                foreach (DataGridViewCell cell in row.Cells)
                {
                    html.Append("<td>");
                    html.Append(cell.Value?.ToString() ?? String.Empty);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }

            // Fine della tabella e del file HTML
            html.Append("</table>");
            html.Append("</body>");
            html.Append("</html>");

            return Task.FromResult(html.ToString());
        }



    }

}
