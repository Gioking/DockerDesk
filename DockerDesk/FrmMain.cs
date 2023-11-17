using DockerDesk.Helpers;
using DockerDesk.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private List<DockerVolume> volumeList = new List<DockerVolume>();
        private List<DockerNetwork> networkList = new List<DockerNetwork>();
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

        #region Region Loadding

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

                imagesList.Clear();
                var command = DoskerStatus.DockerExecute("images", txtWorkDirPath.Text);
                if (!string.IsNullOrEmpty(command.Error))
                {
                    txtLog.Text = LogHelper.LogError(command.Error);
                }
                imagesList = DoskerStatus.ParseDockerImagesOutput(command.OperationResult);
                GridImages.DataSource = imagesList;
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
                containersList.Clear();
                var command = DoskerStatus.DockerExecute("ps -a", txtWorkDirPath.Text);
                if (!string.IsNullOrEmpty(command.Error))
                {
                    txtLog.Text = LogHelper.LogError(command.Error);
                }
                containersList = DoskerStatus.ParseDockerContainersOutput(command.OperationResult);
                gridContainers.DataSource = containersList;
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
                volumeList.Clear();
                var command = DoskerStatus.DockerExecute("volume ls", txtWorkDirPath.Text);
                if (!string.IsNullOrEmpty(command.Error))
                {
                    txtLog.Text = LogHelper.LogError(command.Error);
                }
                volumeList = DoskerStatus.ParseDockerVolumesOutput(command.OperationResult);
                GridVolumes.DataSource = volumeList;
                cmbVolumes.DataSource = volumeList;
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
                networkList.Clear();
                var command = DoskerStatus.DockerExecute("network ls", txtWorkDirPath.Text);
                if (!string.IsNullOrEmpty(command.Error))
                {
                    txtLog.Text = LogHelper.LogError(command.Error);
                }
                networkList = DoskerStatus.ParseDockerNetworksOutput(command.OperationResult);
                GridNetwork.DataSource = networkList;
                Font font = new Font("Arial", 12, FontStyle.Regular);
                GridNetwork.Font = font;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Si è verificato un errore: {e.Message}");
            }
        }

        #endregion

        #region Commands

        //docker build -t myapp:1.0 .
        private void btnCreateImage_Click(object sender, EventArgs e)
        {
            ResultModel command;
            if (string.IsNullOrEmpty(txtTag.Text))
            {
                command = DoskerStatus.DockerExecute($"build -t {txtImageName.Text} -f Dockerfile .", txtWorkDirPath.Text);
            }
            else
            {
                command = DoskerStatus.DockerExecute($"build -t {txtImageName.Text}:{txtTag.Text} -f Dockerfile .", txtWorkDirPath.Text);
            }
            txtLog.Text = LogHelper.LogInfo(command.OperationResult);
            LoadImages();
        }

        //docker image rm -f image
        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            var command = DoskerStatus.DockerExecute($"rmi {selectedImage.Image}:{selectedImage.Tag}", txtWorkDirPath.Text);
            txtLog.Text = LogHelper.LogInfo(command.OperationResult);
            LoadImages();
        }

        //docker rm -f container_id_o_nome
        private void btnRemoveContainer_Click(object sender, EventArgs e)
        {
            var command = DoskerStatus.DockerExecute($"rm -f {selectedContainer.ContainerId}", txtWorkDirPath.Text);
            txtLog.Text = LogHelper.LogInfo(command.OperationResult);
            LoadContainers();
        }

        //docker volume create hello
        private void btnCreateVolume_Click(object sender, EventArgs e)
        {
            var command = DoskerStatus.DockerExecute($"volume create {txtNewVolumeName.Text}", txtWorkDirPath.Text);
            txtLog.Text = LogHelper.LogInfo(command.OperationResult);
            LoadVolumes();
        }

        //docker network create -d bridge my-bridge-network
        private void btnCreateNetwork_Click(object sender, EventArgs e)
        {
            var command = DoskerStatus.DockerExecute($"network create -d {comboDrive.Text} {txtNetworkName.Text}", txtWorkDirPath.Text);
            txtLog.Text = LogHelper.LogInfo(command.OperationResult);
            LoadNetworks();
        }

        private void btnRemoveNetwork_Click(object sender, EventArgs e)
        {
            var command = DoskerStatus.DockerExecute($"network rm {selectedNetwork.NetworkId}", txtWorkDirPath.Text);
            txtLog.Text = LogHelper.LogInfo(command.OperationResult);
            LoadNetworks();
        }

        //docker volume rm hello
        private void btnRemoveVolume_Click(object sender, EventArgs e)
        {
            var command = DoskerStatus.DockerExecute($"volume rm {selectedVolume.VolumeName}", txtWorkDirPath.Text);
            txtLog.Text = LogHelper.LogInfo(command.OperationResult);
            LoadVolumes();
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
                var command = DoskerStatus.DockerExecute($"run -d --name {txtContainerName.Text} -p {txtHostPort.Text}:{txtContainerPort.Text} {selectedImage.Image}:{selectedImage.Tag}", txtWorkDirPath.Text);
                txtLog.Text = LogHelper.LogInfo(command.OperationResult);
            }
            else
            {
                var command = DoskerStatus.DockerExecute($"run -d --name {txtContainerName.Text} -p {txtHostPort.Text}:{txtContainerPort.Text} -v {$"{selectedVolume.VolumeName}:{txtVolumeName.Text}"} {selectedImage.Image}:{selectedImage.Tag}", txtWorkDirPath.Text);
                txtLog.Text = LogHelper.LogInfo(command.OperationResult);
            }

            LoadContainers();
            tabControl1.SelectedTab = tabLog;
        }

        #endregion

        #region Various

        private void SelectWorkDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                WorkingFolderPath = folderBrowserDialog.SelectedPath;
                txtWorkDirPath.Text = WorkingFolderPath;
            }
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();

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

        private void reloadAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImages();
            LoadContainers();
            LoadVolumes();
            LoadNetworks();
        }

        //Combobox Volumes
        private void cmbVolumes_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedVolume = (DockerVolume)cmbVolumes.SelectedItem;
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }

        #endregion

    }
}
