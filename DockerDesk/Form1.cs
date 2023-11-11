using DockerDesk.Helpers;
using DockerDesk.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DockerDesk
{
    public partial class frmMain : Form
    {
        private DockerImage selectedImage;
        private DockerContainer selectedContainer;
        private string WorkingFolderPath = string.Empty;
        private List<DockerImage> imagesList = new List<DockerImage>();
        private List<DockerContainer> containersList = new List<DockerContainer>();
        private StringBuilder sb = new StringBuilder();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadImages();
            LoadContainers();
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

                listViewImages.View = View.Details;
                var result = DoskerStatus.DockerExecute("images", txtWorkDirPath.Text);
                sb.AppendLine(result);
                var objImages = DoskerStatus.ParseDockerImagesOutput(result);
                PopulateImagesListView(objImages);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Si è verificato un errore: {e.Message}");
            }
        }

        private void LoadContainers()
        {
            try
            {
                lstContainers.View = View.Details;
                var result = DoskerStatus.DockerExecute("ps -a", txtWorkDirPath.Text);
                sb.AppendLine(result);
                var objContainers = DoskerStatus.ParseDockerContainersOutput(result);
                PopulateContainersListView(objContainers);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Si è verificato un errore: {e.Message}");
            }
        }

        private void PopulateImagesListView(List<DockerImage> images)
        {
            listViewImages.Items.Clear();
            imagesList.Clear();

            foreach (var image in images)
            {
                var item = new ListViewItem(image.Id.ToString());
                item.SubItems.Add(image.Image);
                item.SubItems.Add(image.Tag);
                item.SubItems.Add(image.ImageId);
                item.SubItems.Add(image.Created);
                item.SubItems.Add(image.Size);

                listViewImages.Items.Add(item);
                imagesList.Add(image);
            }

            listViewImages.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void PopulateContainersListView(List<DockerContainer> containers)
        {
            lstContainers.Items.Clear();
            containersList.Clear();

            foreach (var container in containers)
            {
                var item = new ListViewItem(container.ContainerId);
                item.SubItems.Add(container.Image);
                item.SubItems.Add(container.Command);
                item.SubItems.Add(container.Created);
                item.SubItems.Add(container.Status);
                item.SubItems.Add(container.Ports);
                item.SubItems.Add(container.Names);

                lstContainers.Items.Add(item);
                containersList.Add(container);
            }

            lstContainers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }


        private void listViewImages_MouseClick(object sender, MouseEventArgs e)
        {
            if (listViewImages.SelectedItems.Count > 0)
            {
                var id = listViewImages.SelectedItems[0].Text;
                selectedImage = imagesList.FirstOrDefault(i => i.Id == int.Parse(id));
            }
            else
            {
                selectedImage = null;
            }

            toolStripSelectedImage.Text = selectedImage.Image;
        }

        private void SelectWorkDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                WorkingFolderPath = folderBrowserDialog.SelectedPath;
            }

        }

        // docker run -d --name webapi-container -p 9000:80 -v mio-volume:/percorso/nel/container webapi-image^
        private void btnRunContainer_Click(object sender, EventArgs e)
        {
            string result = string.Empty;

            if (selectedImage == null)
            {
                MessageBox.Show("Warning.. select an image first!");
                return;
            }

            if (!chkHasVolume.Checked)
            {
                result = DoskerStatus.DockerExecute($"run -d --name {txtContainerName.Text} -p {txtHostPort.Text}:{txtContainerPort.Text} {selectedImage.Image}", txtWorkDirPath.Text);

            }
            else
            {
                result = DoskerStatus.DockerExecute($"run -d --name {txtContainerName.Text} -p {txtHostPort.Text}:{txtContainerPort.Text} -v {txtVolumeName.Text} {selectedImage.Image}", txtWorkDirPath.Text);
            }

            sb.AppendLine(result);

            txtLog.Text = sb.ToString();

            tabControl1.SelectedTab = tabLog; // Supponendo che tabPage2 sia il riferimento alla scheda che vuoi selezionare

        }

        private void btnCreateImage_Click(object sender, EventArgs e)
        {
            var result = DoskerStatus.DockerExecute($"build -t {txtImageName.Text} -f Dockerfile .", txtWorkDirPath.Text);
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                WorkingFolderPath = folderBrowserDialog.SelectedPath;
            }
        }

        private void lstContainers_Click(object sender, EventArgs e)
        {

        }
    }
}
