using DockerDesk.Helpers;
using DockerDesk.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DockerDesk
{
    public partial class frmMain : Form
    {
        DockerImage selectedImage;
        List<DockerImage> imagesList = new List<DockerImage>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadImages();
        }


        private void LoadImages()
        {
            try
            {
                // Verifica se Docker è in esecuzione
                if (!DoskerStatus.IsDockerRunning())
                {
                    imageStatusLabel.Text = "Il servizio Docker non è attivo. Per favore, avvialo prima di procedere.";
                    return;
                }
                else
                {
                    imageStatusLabel.Text = "Servizio Docker Attivo.";
                }

                // Crea un nuovo processo
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "docker",
                    Arguments = "images",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                // Avvia il processo
                using (Process process = Process.Start(startInfo))
                {
                    listViewImages.View = View.Details;
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        var images = DoskerStatus.ParseDockerImagesOutput(result);
                        PopulateListView(images);
                    }

                    process.WaitForExit();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Si è verificato un errore: {e.Message}");
            }
        }

        private void PopulateListView(List<DockerImage> images)
        {
            listViewImages.Items.Clear();
            imagesList.Clear();

            foreach (var image in images)
            {
                var item = new ListViewItem(image.Image);
                item.SubItems.Add(image.Tag);
                item.SubItems.Add(image.ImageId);
                item.SubItems.Add(image.Created);
                item.SubItems.Add(image.Size);

                listViewImages.Items.Add(item);
                imagesList.Add(image);
            }

            listViewImages.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }


        private void listViewImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = listViewImages.SelectedItems[0];
            selectedImage = imagesList.FirstOrDefault(i => i.Image == selectedItem.Text);
        }


        private void btnRunContainer_Click(object sender, EventArgs e)
        {

        }

    }
}
