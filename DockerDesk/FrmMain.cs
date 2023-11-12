using DockerDesk.Helpers;
using DockerDesk.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace DockerDesk
{
    public partial class frmMain : Form
    {
        private DockerImage selectedImage;
        private DockerContainer selectedContainer;
        private DockerVolume selectedVolume;
        private DockerNetwork selectedNetwork;
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
            LoadVolumes();
            LoadNetworks();
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

                var result = DoskerStatus.DockerExecute("images", txtWorkDirPath.Text);
                sb.AppendLine(result);
                var objImages = DoskerStatus.ParseDockerImagesOutput(result);
                GridImages.DataSource = objImages;
                Font font = new Font("Arial", 12, FontStyle.Regular);
                GridImages.Font = font;
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
                var result = DoskerStatus.DockerExecute("ps -a", txtWorkDirPath.Text);
                sb.AppendLine(result);
                var objContainers = DoskerStatus.ParseDockerContainersOutput(result);
                gridContainers.DataSource = objContainers;
                Font font = new Font("Arial", 12, FontStyle.Regular);
                gridContainers.Font = font;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Si è verificato un errore: {e.Message}");
            }
        }

        private void LoadVolumes()
        {
            try
            {
                var result = DoskerStatus.DockerExecute("volume ls", txtWorkDirPath.Text);
                sb.AppendLine(result);
                var objVolumes = DoskerStatus.ParseDockerVolumesOutput(result);
                GridVolumes.DataSource = objVolumes;
                Font font = new Font("Arial", 12, FontStyle.Regular);
                GridVolumes.Font = font;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Si è verificato un errore: {e.Message}");
            }
        }

        private void LoadNetworks()
        {
            try
            {
                var result = DoskerStatus.DockerExecute("network ls", txtWorkDirPath.Text);
                sb.AppendLine(result);
                var objNetworks = DoskerStatus.ParseDockerNetworksOutput(result);
                GridNetwork.DataSource = objNetworks;
                Font font = new Font("Arial", 12, FontStyle.Regular);
                GridNetwork.Font = font;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Si è verificato un errore: {e.Message}");
            }
        }

        private void SelectWorkDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                WorkingFolderPath = folderBrowserDialog.SelectedPath;
                txtWorkDirPath.Text = WorkingFolderPath;
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

            LoadContainers();
            sb.AppendLine(result);
            txtLog.Text = sb.ToString();
            tabControl1.SelectedTab = tabLog;
        }

        //docker build -t myapp:1.0 .
        private void btnCreateImage_Click(object sender, EventArgs e)
        {
            var result = DoskerStatus.DockerExecute($"build -t {txtImageName.Text}:{txtTag.Text} -f Dockerfile .", txtWorkDirPath.Text);
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                WorkingFolderPath = $@"{folderBrowserDialog.SelectedPath}\";
                txtWorkDirPath.Text = $@"{folderBrowserDialog.SelectedPath}\";
            }
        }

        private void GridImages_MouseClick(object sender, MouseEventArgs e)
        {
            if (GridImages.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridImages.SelectedRows[0];

                selectedImage = new DockerImage();
                selectedImage.Id = Convert.ToInt32(row.Cells[0].Value);
                selectedImage.Image = Convert.ToString(row.Cells[1].Value);
                selectedImage.Tag = Convert.ToString(row.Cells[2].Value);
                selectedImage.ImageId = Convert.ToString(row.Cells[3].Value);
                selectedImage.Created = Convert.ToString(row.Cells[4].Value);
                selectedImage.Size = Convert.ToString(row.Cells[5].Value);

                toolStripSelectedImage.Text = selectedImage.Image;
            }
        }

        private void gridContainers_MouseClick(object sender, MouseEventArgs e)
        {
            if (gridContainers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gridContainers.SelectedRows[0];

                DockerContainer dockerContainer = new DockerContainer();

                // Assicurati che gli indici delle celle siano corretti in base all'ordine delle colonne nella DataGridView
                dockerContainer.ContainerId = Convert.ToString(row.Cells[0].Value);
                dockerContainer.Image = Convert.ToString(row.Cells[1].Value);
                dockerContainer.Command = Convert.ToString(row.Cells[2].Value);
                dockerContainer.Created = Convert.ToString(row.Cells[3].Value);
                dockerContainer.Status = Convert.ToString(row.Cells[4].Value);
                dockerContainer.Ports = Convert.ToString(row.Cells[5].Value);
                dockerContainer.Names = Convert.ToString(row.Cells[6].Value);

                selectedContainer = dockerContainer;

                toolStripSelectedContainer.Text = selectedContainer.Names;
            }
        }

        //docker rm -f container_id_o_nome
        private void btnRemoveContainer_Click(object sender, EventArgs e)
        {
            var result = DoskerStatus.DockerExecute($"rm -f {selectedContainer.ContainerId}", txtWorkDirPath.Text);
            LoadContainers();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();

        }

        private void btnCreateVolume_Click(object sender, EventArgs e)
        {
            var result = DoskerStatus.DockerExecute($"volume create {txtNewVolumeName.Text}", txtWorkDirPath.Text);
        }

        private void GridVolumes_MouseClick(object sender, MouseEventArgs e)
        {
            if (GridVolumes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridVolumes.SelectedRows[0];

                selectedVolume = new DockerVolume();
                selectedVolume.Id = Convert.ToInt32(row.Cells[0].Value);
                selectedVolume.Drive = Convert.ToString(row.Cells[1].Value);
                selectedVolume.VolumeName = Convert.ToString(row.Cells[2].Value);

                txtContainerName.Text = selectedVolume.VolumeName;
                toolStripSelectedVolume.Text = selectedVolume.VolumeName;
            }
        }

        private void GridNetwork_MouseClick(object sender, MouseEventArgs e)
        {
            if (GridNetwork.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridNetwork.SelectedRows[0];

                selectedNetwork = new DockerNetwork();
                selectedNetwork.Id = Convert.ToInt32(row.Cells[0].Value);
                selectedNetwork.NetworkId = Convert.ToString(row.Cells[1].Value);
                selectedNetwork.Name = Convert.ToString(row.Cells[2].Value);
                selectedNetwork.Drive = Convert.ToString(row.Cells[3].Value);
                selectedNetwork.Scope = Convert.ToString(row.Cells[4].Value);

                toolStripSelectedNetwork.Text = selectedNetwork.Name;
            }
        }


    }
}
