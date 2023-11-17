using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace DockerDesk
{
    public partial class frmWebView : Form
    {
        private string jsonString;
        public frmWebView(string data)
        {
            InitializeComponent();
            jsonString = data;
        }

        public void SetData(string data)
        {
            jsonString = data;
        }

        private void frmWebView_Load(object sender, EventArgs e)
        {
            // Formatta il JSON con indentazioni
            string formattedJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(jsonString), Formatting.Indented);

            // Converti il JSON in HTML
            string htmlContent = $"<html><body><pre>{System.Security.SecurityElement.Escape(formattedJson)}</pre></body></html>";

            // Carica l'HTML nel controllo WebBrowser
            webBrowser1.DocumentText = htmlContent;
        }
    }
}
