using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerDesk
{
    public partial class frmVariables : Form
    {
        private string _containerId = string.Empty;
        private string _containerName = string.Empty;
        private string _fullJsonPath = string.Empty;

        public frmVariables(string containerName, string conyainerId)
        {
            InitializeComponent();
            _containerId = conyainerId;
            _containerName = containerName;
        }

        private void frmVariables_Load(object sender, EventArgs e)
        {
            LoadJsonFile();
        }

        private void LoadJsonFile()
        {
            string pathToFile = Path.Combine(Application.StartupPath, $"{_containerId}.json");

            // Verifica se il file esiste, se no copia jvariables.json
            if (!File.Exists(pathToFile))
            {
                //string sourcePath = Path.Combine(Application.StartupPath, $"templatevar.json");

                string json = $@"
                {{
                  ""{_containerName}"": {{
                    ""container_id"": ""{_containerId}"",
                    ""EnvVariable"": [
                      {{
                        ""name"": ""EXAMPLE_NAME"",
                        ""value"": ""example_value""
                      }}
                    ]
                  }}
                }}";

                File.WriteAllText(pathToFile, json);

                //try
                //{
                //    File.Copy(sourcePath, pathToFile);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Errore durante la copia del file di default: " + ex.Message);
                //    return;
                //}
            }

            _fullJsonPath = pathToFile;

            try
            {
                string jsonContent = File.ReadAllText(pathToFile);
                string formattedJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(jsonContent), Formatting.Indented);
                richVariables.Text = formattedJson;
                ColorizeJson();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il caricamento del file JSON: " + ex.Message);
            }
        }


        private void ColorizeJson()
        {
            // ... (impostazione del colore di default come prima)

            // Regex aggiornata per identificare chiavi e stringhe
            var regex = new Regex("(\"(?<key>[^\"]+)\": )|(?<string>\"[^\"]*\")");
            var matches = regex.Matches(richVariables.Text);

            foreach (Match match in matches)
            {
                if (match.Groups["key"].Success)
                {
                    richVariables.SelectionStart = match.Groups["key"].Index;
                    richVariables.SelectionLength = match.Groups["key"].Length;
                    richVariables.SelectionColor = Color.DarkRed;
                }

                if (match.Groups["string"].Success)
                {
                    richVariables.SelectionStart = match.Groups["string"].Index;
                    richVariables.SelectionLength = match.Groups["string"].Length;
                    richVariables.SelectionColor = Color.DarkOrange;
                }
            }

        }

        private void btnSaveVariables_Click(object sender, EventArgs e)
        {
            try
            {
                // Legge il testo dal RichTextBox
                string modifiedJsonContent = richVariables.Text;

                // Scrive il testo modificato nel file
                File.WriteAllText(_fullJsonPath, modifiedJsonContent);
                MessageBox.Show("Modifiche salvate con successo.", "Salvato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadJsonFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il salvataggio delle modifiche: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
