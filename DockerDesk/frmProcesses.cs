using Newtonsoft.Json;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DockerDesk
{
    public partial class frmProcesses : Form
    {
        private string jsonString;

        public frmProcesses(string data)
        {
            InitializeComponent();
            jsonString = data;
        }

        public void SetData(string data)
        {
            jsonString = data;
        }

        private void frmProcesses_Load(object sender, EventArgs e)
        {
            string formattedJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(jsonString), Formatting.Indented);
            string htmlContent = ConvertiJsonInHtml(formattedJson);

            // HTML completo con stili CSS
            // HTML completo con stili CSS
            string fullHtml = $@"
<html>
<head>
<style>
.key {{ color: blue; font-weight: bold; }}
.string {{ color: green; font-weight: bold; }}
.number {{ color: darkorange; font-weight: bold; }}
.boolean {{ color: red; font-weight: bold; }}
.null {{ color: gray; font-weight: bold; }}
/* Altri stili CSS qui */
</style>
</head>
<body>
<pre>{htmlContent}</pre>
</body>
</html>";


            webBrowser1.DocumentText = fullHtml;
        }


        private string ConvertiJsonInHtml(string formattedJson)
        {
            // Definisce il pattern per identificare le chiavi e i valori nel JSON
            string pattern = "(\"(?<key>[^\"]+)\": )?(?<value>(\"[^\"]*\"|true|false|null|\\d+(?:\\.\\d+)?))";

            // Sostituisce ogni corrispondenza nel JSON formattato
            return Regex.Replace(formattedJson, pattern, new MatchEvaluator((Match match) =>
            {
                // Controlla se la corrispondenza contiene una chiave
                if (match.Groups["key"].Success)
                {
                    // Restituisce la stringa HTML con la chiave e il valore stilizzati
                    return $"<span class='key'>{match.Groups["key"].Value}</span>: <span class='{GetCssClassForValue(match.Groups["value"].Value)}'>{match.Groups["value"].Value}</span>";
                }
                else
                {
                    // Restituisce solo il valore stilizzato
                    return $"<span class='{GetCssClassForValue(match.Groups["value"].Value)}'>{match.Groups["value"].Value}</span>";
                }
            }));
        }


        private string GetCssClassForValue(string value)
        {
            if (value.StartsWith("\"") && value.EndsWith("\"")) return "string";
            if (value == "null") return "null";
            if (value == "true" || value == "false") return "boolean";
            if (double.TryParse(value, out _)) return "number"; // verifica se è un numero
            return "unknown"; // per sicurezza, in caso non rientri in nessuna categoria nota
        }


    }
}
