﻿using Newtonsoft.Json;
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
        private string _imageName = string.Empty;
        private string _imageId = string.Empty;
        private string _fullJsonPath = string.Empty;

        public frmVariables(string imageName, string imageId)
        {
            InitializeComponent();
            _imageId = imageId;
            _imageName = imageName;
        }

        private void frmVariables_Load(object sender, EventArgs e)
        {
            LoadJsonFile();
        }

        private void LoadJsonFile()
        {
            string pathToFile = Path.Combine(Application.StartupPath, $@"variables\{_imageId}.json");

            if (!File.Exists(pathToFile))
            {
                string json = $@"
                        {{
                          ""image_name"": ""{_imageName}"",
                          ""image_id"": ""{_imageId}"",
                          ""EnvVariable"": [
                            {{
                              ""name"": ""SQLSERVER_CONNECTION_STRING"",
                              ""value"": ""Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;""
                            }},
                            {{
                              ""name"": ""MONGODB_URI"",
                              ""value"": ""mongodb://username:password@host:port/database""
                            }}
                            // Aggiungi altre variabili d'ambiente qui se necessario
                          ]
                        }}";


                File.WriteAllText(pathToFile, json);
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
