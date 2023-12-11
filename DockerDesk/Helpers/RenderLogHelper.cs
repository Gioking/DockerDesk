using DockerDesk.Models;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerDesk.Helpers
{
    public static class RenderLogHelper
    {

        private static StringBuilder html = new StringBuilder();
        public static Task<string> ReportDockerCommandsAsync(string command, ResultModel resultModel)
        {
            html.Append("<!DOCTYPE html>");
            html.Append("<html>");

            html.Append("<head>");

            html.Append("<style>");
            html.Append("html, body { width: 100%; margin: 0; padding: 0; }");
            html.Append("h3 { color:darkgreen; font-weight: bold; font-size: 20px; }");
            html.Append(".command { color:darkgreen; font-weight: bold; font-size: 20px; }");
            html.Append(".result { color:darkred; font-weight: bold; font-size: 20px; }");
            html.Append(".outtext { color:black; font-size: 20px; }");
            html.Append("</style>");
            html.Append("</head>");


            html.Append("<body>");

            html.Append("<br/>");

            html.Append("<ul>");

            html.Append($"<li class='command'>Command</li>");
            html.Append($"<li class='outtext'>docker {command}</li>");

            if (Properties.Settings.Default.ShowCommandResult)
            {
                html.Append($"<li class='result'>Result</li>");
                html.Append($"<li class='outtext'>{resultModel.OperationResult}</li>");
            }

            html.Append("</ul>");

            html.Append("</body>");
            html.Append("</html>");

            return Task.FromResult(html.ToString());
        }


        public static Task<string> ReportDataGridAsync(DataGridView grid)
        {
            StringBuilder html = new StringBuilder();

            html.Append("<!DOCTYPE html>");
            html.Append("<html>");

            html.Append("<head>");
            html.Append("<style>");
            html.Append("html, body { width: 100%; margin: 0; padding: 0; }");
            html.Append("table { width: 100%; border-collapse: collapse; }");
            html.Append("th, td { border: 1px solid black; }");
            html.Append("th { background-color: blue; color: white; }"); // Stile per le celle di intestazione
            html.Append("h3 { color:darkgreen; font-weight: bold; font-size: 20px; }");
            html.Append("</style>");
            html.Append("</head>");

            html.Append("<body>");

            html.Append("<br/>");
            html.Append($"<h3>---{grid.Tag}</h3>");

            html.Append("<table>");

            html.Append("<tr>");
            foreach (DataGridViewColumn column in grid.Columns)
            {
                html.Append("<th>");
                html.Append(column.HeaderText);
                html.Append("</th>");
            }
            html.Append("</tr>");

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;

                html.Append("<tr>");
                foreach (DataGridViewCell cell in row.Cells)
                {
                    html.Append("<td>");
                    html.Append(cell.Value?.ToString() ?? String.Empty);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }

            html.Append("</table>");
            html.Append("</body>");
            html.Append("</html>");

            return Task.FromResult(html.ToString());
        }



    }

}
