using DockerDesk.Helpers;
using DockerDesk.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        private DockerNetwork selectedNetworkToConnect;
        private string selectedDrive = string.Empty;
        private string WorkingFolderPath = string.Empty;
        private List<DockerImage> imagesList = new List<DockerImage>();
        private List<DockerContainer> containersList = new List<DockerContainer>();
        private List<DockerVolume> volumeList = new List<DockerVolume>();
        private List<DockerNetwork> networkList = new List<DockerNetwork>();
        List<DockerNetwork> customNetworkList = new List<DockerNetwork>();
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

        private async void LoadImages()
        {
            try
            {
                // Verifica se Docker è in esecuzione
                bool isRunning = await DoskerRunner.IsDockerRunningAsync();
                if (!isRunning)
                {
                    imageStatusLabel.Text = "Il servizio Docker non è attivo. Per favore, avvialo prima di procedere.";
                    toolStripStatus.Image = imageList1.Images["red-button.png"];
                    return;
                }
                else
                {
                    imageStatusLabel.Text = "Servizio Docker Attivo.";
                    toolStripStatus.Image = imageList1.Images["green-button.png"];
                }

                try
                {
                    //SpinnerHelper.ToggleSpinner(pBar, true);
                    imagesList.Clear();
                    var command = await DoskerRunner.DockerExecute("images", txtWorkDirPath.Text);
                    if (!string.IsNullOrEmpty(command.Error))
                    {
                        txtLog.Text = LogHelper.LogError(command.Error);
                    }
                    imagesList = await DoskerRunner.ParseDockerImagesOutputAsync(command.OperationResult);
                    GridImages.DataSource = imagesList;
                    Font font = new Font("Arial", 12, FontStyle.Regular);
                    GridImages.Font = font;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Si è verificato un errore: {e.Message}");
            }
        }

        private async void LoadContainers()
        {
            try
            {
                containersList.Clear();
                var command = await DoskerRunner.DockerExecute("ps -a", txtWorkDirPath.Text);
                if (!string.IsNullOrEmpty(command.Error))
                {
                    txtLog.Text = LogHelper.LogError(command.Error);
                }
                containersList = await DoskerRunner.ParseDockerContainersOutputAsync(command.OperationResult);
                gridContainers.DataSource = containersList;
                Font font = new Font("Arial", 12, FontStyle.Regular);
                gridContainers.Font = font;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Si è verificato un errore: {e.Message}");
            }
        }

        private async void LoadVolumes()
        {
            try
            {
                volumeList.Clear();
                var command = await DoskerRunner.DockerExecute("volume ls", txtWorkDirPath.Text);
                if (!string.IsNullOrEmpty(command.Error))
                {
                    txtLog.Text = LogHelper.LogError(command.Error);
                }
                volumeList = await DoskerRunner.ParseDockerVolumesOutputAsync(command.OperationResult);
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

        private async void LoadNetworks()
        {
            try
            {
                networkList.Clear();
                var command = await DoskerRunner.DockerExecute("network ls", txtWorkDirPath.Text);
                if (!string.IsNullOrEmpty(command.Error))
                {
                    txtLog.Text = LogHelper.LogError(command.Error);
                }

                networkList = await DoskerRunner.ParseDockerNetworksOutputAsync(command.OperationResult);
                GridNetwork.DataSource = networkList;

                customNetworkList = new List<DockerNetwork>(networkList)
                {
                    new DockerNetwork { NetworkId = "", Name = null }
                };

                cmbNetworksConnect.DataSource = customNetworkList;

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
        //docker build -t test-image-gio:v1 -f Dockerfile .
        private async void btnCreateImage_Click(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                //await Task.Delay(3000);

                ResultModel command;
                if (string.IsNullOrEmpty(txtTag.Text))
                {
                    command = await DoskerRunner.DockerExecute($"build -t {txtImageName.Text} -f Dockerfile .", txtWorkDirPath.Text);
                }
                else
                {
                    command = await DoskerRunner.DockerExecute($"build -t {txtImageName.Text}:{txtTag.Text} -f Dockerfile .", txtWorkDirPath.Text);
                }
                txtLog.Text = LogHelper.LogInfo(command.OperationResult);
                LoadImages();
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //docker image rm -f image
        private async void btnDeleteImage_Click(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                var command = await DoskerRunner.DockerExecute($"rmi {selectedImage.Image}:{selectedImage.Tag}", txtWorkDirPath.Text);
                txtLog.Text = LogHelper.LogInfo(command.OperationResult);
                LoadImages();
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //docker rm -f container_id_o_nome
        private async void btnRemoveContainer_Click(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                if (selectedContainer == null)
                {
                    MessageBox.Show("Please select the container to remove.");
                    return;
                }
                var command = await DoskerRunner.DockerExecute($"rm -f {selectedContainer.ContainerId}", txtWorkDirPath.Text);
                txtLog.Text = LogHelper.LogInfo(command.OperationResult);
                LoadContainers();
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //docker volume create hello
        private async void btnCreateVolume_Click(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                var command = await DoskerRunner.DockerExecute($"volume create {txtNewVolumeName.Text}", txtWorkDirPath.Text);
                txtLog.Text = LogHelper.LogInfo(command.OperationResult);
                LoadVolumes();
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //docker network create -d bridge my-bridge-network
        //docker network create --subnet=192.168.1.0/24 --gateway=192.168.1.1 --ip-range=192.168.1.4/32 my-custom-network
        private async void btnCreateNetwork_Click(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                if (string.IsNullOrEmpty(selectedDrive))
                {
                    var command = await DoskerRunner.DockerExecute($"network create -d {comboDrive.Text} {txtNetworkName.Text}", txtWorkDirPath.Text);
                    txtLog.Text = LogHelper.LogInfo(command.OperationResult);
                }
                else
                {
                    if (string.IsNullOrEmpty(txtSubnet.Text))
                    {
                        MessageBox.Show("Warning... the subnet is required.");
                        return;
                    }
                    var command = await DoskerRunner.DockerExecute($"network create --subnet={txtSubnet.Text} --gateway={txtGateway.Text} {txtNetworkName.Text}", txtWorkDirPath.Text);
                    txtLog.Text = LogHelper.LogInfo(command.OperationResult);
                }
                LoadNetworks();
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void btnRemoveNetwork_Click(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                var command = await DoskerRunner.DockerExecute($"network rm {selectedNetwork.NetworkId}", txtWorkDirPath.Text);
                txtLog.Text = LogHelper.LogInfo(command.OperationResult);
                LoadNetworks();
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //docker volume rm hello
        private async void btnRemoveVolume_Click(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                var command = await DoskerRunner.DockerExecute($"volume rm {selectedVolume.VolumeName}", txtWorkDirPath.Text);
                txtLog.Text = LogHelper.LogInfo(command.OperationResult);
                LoadVolumes();
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //docker network connect mia-rete mio-container
        private async void btnConnectNetwork_Click(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                if (selectedNetwork == null || selectedContainer == null)
                {
                    MessageBox.Show("Warning.. Select a container and the network to bind to.");
                    return;
                }

                var command = await DoskerRunner.DockerExecute($"network connect {selectedNetwork.NetworkId} {selectedContainer.ContainerId}", txtWorkDirPath.Text);
                txtLog.Text = LogHelper.LogInfo(command.OperationResult);

                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //docker network disconnect mynetwork mycontainer  /Per disconnettere dalla network
        private async void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                if (selectedNetwork == null || selectedContainer == null)
                {
                    MessageBox.Show("Warning.. Select a container and the network to bind to.");
                    return;
                }

                var command = await DoskerRunner.DockerExecute($"network disconnect {selectedNetwork.NetworkId} {selectedContainer.ContainerId}", txtWorkDirPath.Text);
                txtLog.Text = LogHelper.LogInfo(command.OperationResult);

                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // docker run -d --name webapi-container -p 9000:80 -v mio-volume:/percorso/nel/container webapi-image^
        private async void btnRunContainer_Click(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                string result = string.Empty;
                if (selectedImage == null)
                {
                    MessageBox.Show("Warning.. select an image first!");
                    return;
                }

                if (!chkHasVolume.Checked)
                {
                    var command = await DoskerRunner.DockerExecute($"run -d --name {txtContainerName.Text} -p {txtHostPort.Text}:{txtContainerPort.Text} {selectedImage.Image}:{selectedImage.Tag}", txtWorkDirPath.Text);
                    txtLog.Text = LogHelper.LogInfo(command.OperationResult);
                }
                else
                {
                    var command = await DoskerRunner.DockerExecute($"run -d --name {txtContainerName.Text} -p {txtHostPort.Text}:{txtContainerPort.Text} -v {$"{selectedVolume.VolumeName}:{txtVolumeName.Text}"} {selectedImage.Image}:{selectedImage.Tag}", txtWorkDirPath.Text);
                    txtLog.Text = LogHelper.LogInfo(command.OperationResult);
                }
                LoadContainers();
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void btnInspect_Click(object sender, EventArgs e)
        {
            if (gridContainers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gridContainers.SelectedRows[0];

                DockerContainer dockerContainer = new DockerContainer();
                dockerContainer.ContainerId = Convert.ToString(row.Cells[0].Value);
                dockerContainer.Image = Convert.ToString(row.Cells[1].Value);
                dockerContainer.Command = Convert.ToString(row.Cells[2].Value);
                dockerContainer.Created = Convert.ToString(row.Cells[3].Value);
                dockerContainer.Status = Convert.ToString(row.Cells[4].Value);
                dockerContainer.Ports = Convert.ToString(row.Cells[5].Value);
                dockerContainer.Names = Convert.ToString(row.Cells[6].Value);
                selectedContainer = dockerContainer;
                toolStripSelectedContainer.Text = selectedContainer.Names;

                //Inspect if container has a volume
                //docker inspect --format '{{ .Mounts }}' nome_container
                var command = await DoskerRunner.DockerExecute($"inspect {dockerContainer.ContainerId}", txtWorkDirPath.Text);

                frmWebView existingForm = Application.OpenForms.OfType<frmWebView>().FirstOrDefault();

                if (existingForm != null)
                {
                    existingForm.SetData(command.OperationResult);
                    existingForm.BringToFront();
                }
                else
                {
                    frmWebView nuovoForm = new frmWebView(command.OperationResult);
                    nuovoForm.Show();
                }
            }
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

        private void comboDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDrive = comboDrive.SelectedItem.ToString();
        }

        private void cmbNetworksConnect_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedNetwork = (DockerNetwork)cmbNetworksConnect.SelectedItem;
        }

        private async void btnNetInspect_Click(object sender, EventArgs e)
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

            //docker network inspect my-custom-network
            //docker network inspect my-custom-network --format '{{json .}}' | jq
            var command = await DoskerRunner.DockerExecute($"network inspect {selectedNetwork.NetworkId}", txtWorkDirPath.Text);

            frmWebView existingForm = Application.OpenForms.OfType<frmWebView>().FirstOrDefault();

            if (existingForm != null)
            {
                existingForm.SetData(command.OperationResult);
                existingForm.BringToFront();
            }
            else
            {
                frmWebView nuovoForm = new frmWebView(command.OperationResult);
                nuovoForm.Show();
            }

        }

        private void gridContainers_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow row = gridContainers.SelectedRows[0];
            DockerContainer dockerContainer = new DockerContainer();
            dockerContainer.ContainerId = Convert.ToString(row.Cells[0].Value);
            dockerContainer.Names = Convert.ToString(row.Cells[1].Value);
            dockerContainer.Image = Convert.ToString(row.Cells[2].Value);
            dockerContainer.Command = Convert.ToString(row.Cells[3].Value);
            dockerContainer.Created = Convert.ToString(row.Cells[4].Value);
            dockerContainer.Status = Convert.ToString(row.Cells[5].Value);
            dockerContainer.Ports = Convert.ToString(row.Cells[6].Value);
            selectedContainer = dockerContainer;
            toolStripSelectedContainer.Text = selectedContainer.Names;
        }



        #endregion

        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabLog;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmHelp();
            form.ShowDialog();
        }


    }
}
