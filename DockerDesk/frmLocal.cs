using DockerDesk.Helpers;
using DockerDesk.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerDesk
{
    public partial class frmLocal : Form
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
        private List<DockerNetwork> customNetworkList = new List<DockerNetwork>();
        private List<DockerVariable> envVariableList;
        private StringBuilder sb = new StringBuilder();
        string remoteMappedIpAddress = string.Empty;

        public frmLocal()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ReloadAll();
            PopulateComboBoxWithIPs();
        }

        private async void ReloadAll()
        {
            if (await CheckIfConnection())
            {
                LoadImages();
                LoadContainers();
                LoadVolumes();
                LoadNetworks();
                LoadVariables();
            }
        }

        public void PopulateComboBoxWithIPs()
        {
            List<string> ipAddresses = DockerNetWorkChecker.GetAllLocalIPv4Addresses();
            foreach (string ip in ipAddresses)
            {
                cmbIpAddresses.Items.Add(ip);
            }
        }

        #region Region Loadding

        private async Task<bool> CheckIfConnection()
        {
            bool isRunning = await DockerRunner.IsDockerRunningAsync();
            if (!isRunning)
            {
                imageStatusLabel.Text = "Il servizio Docker non è attivo. Per favore, avvialo prima di procedere.";
                toolStripStatus.Image = imageList1.Images["red-button.png"];
                return false;
            }
            else
            {
                imageStatusLabel.Text = "Servizio Docker Attivo.";
                toolStripStatus.Image = imageList1.Images["green-button.png"];
                return true;
            }
        }

        private async void LoadImages()
        {
            try
            {
                try
                {
                    imagesList.Clear();
                    var command = await DockerRunner.DockerExecute("images", txtWorkDirPath.Text);
                    imagesList = await DockerRunner.ParseDockerImagesOutputAsync(command.OperationResult);
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
                var command = await DockerRunner.DockerExecute("ps -a", txtWorkDirPath.Text);
                containersList = await DockerRunner.ParseDockerContainersOutputAsync(command.OperationResult);
                gridContainers.DataSource = containersList;
                cmbContainers.DataSource = containersList;
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
                var command = await DockerRunner.DockerExecute("volume ls", txtWorkDirPath.Text);
                volumeList = await DockerRunner.ParseDockerVolumesOutputAsync(command.OperationResult);
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
                var command = await DockerRunner.DockerExecute("network ls", txtWorkDirPath.Text);
                networkList = await DockerRunner.ParseDockerNetworksOutputAsync(command.OperationResult);
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

        private async void LoadVariables()
        {
            try
            {
                await DockerEnvHelper.UpdateJsonFileWithContainerEnvVariables();

                string pathToFile = Path.Combine(Application.StartupPath, "containers_svariables.json");
                var jsonContent = File.ReadAllText(pathToFile);
                var containers = JsonConvert.DeserializeObject<Dictionary<string, DockerJsonContainer>>(jsonContent);
                var containerNames = containers.Keys.ToList();
                cmbContainers.DataSource = containerNames;
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
        private async void CreateImage(object sender, EventArgs e)
        {
            try
            {
                string dockerFilePath = Path.Combine(Application.StartupPath, txtWorkDirPath.Text);
                string dockerfile = Path.Combine(dockerFilePath, "Dockerfile");
                if (!File.Exists(dockerfile))
                {
                    MessageBox.Show($"No dockerfile has been found in this path {dockerFilePath}");
                    return;
                }

                SpinnerHelper.ToggleSpinner(pBar, true);

                ResultModel command;
                if (string.IsNullOrEmpty(txtTag.Text))
                {
                    command = await DockerRunner.DockerExecute($"build -t {txtImageName.Text} -f Dockerfile .", dockerFilePath);
                }
                else
                {
                    command = await DockerRunner.DockerExecute($"build -t {txtImageName.Text}:{txtTag.Text} -f Dockerfile .", dockerFilePath);
                }
                if (command == null) { return; }
                LoadImages();
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //docker image rm -f image
        private async void DeleteImage(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                var command = await DockerRunner.DockerExecute($"rmi {selectedImage.Image}:{selectedImage.Tag}", txtWorkDirPath.Text);
                LoadImages();
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // docker run -d --name webapi-container -p 9000:80 -v mio-volume:/percorso/nel/container webapi-image^
        private async void CreateContainer(object sender, EventArgs e)
        {
            try
            {

                string containerName = txtContainerName.Text;
                string hostPort = txtHostPort.Text;
                string containerPort = txtContainerPort.Text;
                string workDirPath = txtWorkDirPath.Text;

                SpinnerHelper.ToggleSpinner(pBar, true);
                string result = string.Empty;
                if (selectedImage == null || string.IsNullOrEmpty(containerName))
                {
                    MessageBox.Show("Warning.. select an image and provide the container name!");
                    SpinnerHelper.ToggleSpinner(pBar, false);
                    return;
                }

                var isContainer = containersList.FirstOrDefault(c => c.Names == containerName);
                if (isContainer != null)
                {
                    MessageBox.Show($"Warning.. a container with same name: {containerName} already exist!");
                    SpinnerHelper.ToggleSpinner(pBar, false);
                    return;
                }

                int port = int.Parse(hostPort);
                bool isPortInUse = await DockerPortChecker.IsPortInUseByDockerContainerAsync(port);
                if (isPortInUse)
                {
                    MessageBox.Show($"Warning.. the host port: {hostPort} is already in use!");
                    SpinnerHelper.ToggleSpinner(pBar, false);
                    return;
                }

                string pathToFile = Path.Combine(Application.StartupPath, $@"variables\{selectedImage.ImageId}.json");
                if (chkUseVariables.Checked && pathToFile == null)
                {
                    MessageBox.Show("Please edit the variables into the json file by clicking on 'Edit container variables' button");
                    return;
                }

                string envVars = DockerEnvHelper.GetEnvVariablesFromJson(pathToFile);
                string baseDockerCommand = $"run -d {envVars} --name {containerName}";

                if (chkHasVolume.Checked && chkShareVolumeToHost.Checked)
                {
                    var command = await DockerRunner.DockerExecute($"{baseDockerCommand} --mount type=bind,source={txtHostPathName.Text},target={txtContainerPathName.Text} {selectedImage.Image}:{selectedImage.Tag} -p {hostPort}:{containerPort}", txtWorkDirPath.Text);
                }
                else
                {
                    string portMapping = string.IsNullOrEmpty(remoteMappedIpAddress) ? $"{hostPort}:{containerPort}" : $"{remoteMappedIpAddress}:{hostPort}:{containerPort}";

                    if (!chkHasVolume.Checked)
                    {
                        var command = await DockerRunner.DockerExecute($"{baseDockerCommand} -p {portMapping} {selectedImage.Image}:{selectedImage.Tag}", workDirPath);
                    }
                    else
                    {
                        var command = await DockerRunner.DockerExecute($"{baseDockerCommand} -p {portMapping} -v {$"{selectedVolume.VolumeName}:{txtContainerPathName.Text}"} {selectedImage.Image}:{selectedImage.Tag}", workDirPath);
                    }
                }


                LoadContainers();
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //docker rm -f container_id_o_nome
        private async void DeleteContainer(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                if (selectedContainer == null)
                {
                    MessageBox.Show("Please select the container to remove.");
                    return;
                }
                var command = await DockerRunner.DockerExecute($"rm -f {selectedContainer.ContainerId}", txtWorkDirPath.Text);
                LoadContainers();
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //docker volume create hello
        private async void CreateVolume(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                var command = await DockerRunner.DockerExecute($"volume create {txtNewVolumeName.Text}", txtWorkDirPath.Text);
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
        private async void CreateNetwork(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                if (string.IsNullOrEmpty(selectedDrive))
                {
                    var command = await DockerRunner.DockerExecute($"network create -d {comboDrive.Text} {txtNetworkName.Text}", txtWorkDirPath.Text);
                }
                else
                {
                    if (string.IsNullOrEmpty(txtSubnet.Text))
                    {
                        MessageBox.Show("Warning... the subnet is required.");
                        return;
                    }
                    var command = await DockerRunner.DockerExecute($"network create --subnet={txtSubnet.Text} --gateway={txtGateway.Text} {txtNetworkName.Text}", txtWorkDirPath.Text);
                }
                LoadNetworks();
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void DeleteNetwork(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                var command = await DockerRunner.DockerExecute($"network rm {selectedNetwork.NetworkId}", txtWorkDirPath.Text);
                LoadNetworks();
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //docker volume rm hello
        private async void DeleteVolume(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                var command = await DockerRunner.DockerExecute($"volume rm {selectedVolume.VolumeName}", txtWorkDirPath.Text);
                LoadVolumes();
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //docker network connect mia-rete mio-container
        private async void ConnectNetwork(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                if (selectedNetwork == null || selectedContainer == null)
                {
                    MessageBox.Show("Warning.. Select a container and the network to bind to.");
                    return;
                }

                var command = await DockerRunner.DockerExecute($"network connect {selectedNetwork.NetworkId} {selectedContainer.ContainerId}", txtWorkDirPath.Text);
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //docker network disconnect mynetwork mycontainer  /Per disconnettere dalla network
        private async void DisconnectNetwork(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);
                if (selectedNetwork == null || selectedContainer == null)
                {
                    MessageBox.Show("Warning.. Select a container and the network to bind to.");
                    return;
                }

                var command = await DockerRunner.DockerExecute($"network disconnect {selectedNetwork.NetworkId} {selectedContainer.ContainerId}", txtWorkDirPath.Text);
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void InspectVolume(object sender, EventArgs e)
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
                var command = await DockerRunner.DockerExecute($"inspect {dockerContainer.ContainerId}", txtWorkDirPath.Text);

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

        private void CreateVars(object sender, EventArgs e)
        {
            if (selectedImage == null)
            {
                MessageBox.Show("Please select an image first.");
                return;
            }
            Form form = new frmVariables(selectedImage.Image, selectedImage.ImageId);
            form.Show();
        }

        #endregion

        #region Various

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

        private void SelectWorkDir(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                WorkingFolderPath = $@"{folderBrowserDialog.SelectedPath}\";
                txtWorkDirPath.Text = $@"{folderBrowserDialog.SelectedPath}\";
            }
        }

        private void menuShowAbout(object sender, EventArgs e)
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

        private void menuReloadAll(object sender, EventArgs e)
        {
            ReloadAll();
        }

        //Combobox Volumes
        private void cmbVolumes_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedVolume = (DockerVolume)cmbVolumes.SelectedItem;
        }

        private void btnClearLogs(object sender, EventArgs e)
        {
            WBLog.DocumentText = string.Empty;
        }

        private void comboDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDrive = comboDrive.SelectedItem.ToString();
        }

        private void cmbNetworksConnect_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedNetwork = (DockerNetwork)cmbNetworksConnect.SelectedItem;
        }

        private async void NetworkInspect(object sender, EventArgs e)
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
            var command = await DockerRunner.DockerExecute($"network inspect {selectedNetwork.NetworkId}", txtWorkDirPath.Text);

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

        //docker exec [nome_o_id_del_container] env
        private async void cmbContainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);

                var container = (DockerContainer)cmbContainers.SelectedItem;

                if (container == null)
                {
                    return;
                }

                var command = await DockerRunner.DockerExecute($"exec {container.ContainerId} env", txtWorkDirPath.Text);

                var result = await DockerRunner.ParseDockerEnvOutputAsync(command.OperationResult);
                GridVariables.DataSource = result;

                selectedContainer = containersList.FirstOrDefault(c => c.ContainerId == container.ContainerId);

                SpinnerHelper.ToggleSpinner(pBar, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            //tabControl1.SelectedTab = tabLog;
        }

        private void menuShowHelp(object sender, EventArgs e)
        {
            Form form = new frmHelp();
            form.ShowDialog();
        }


        private void GridImages_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void gridContainers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void GridVolumes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void GridNetwork_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void GridVariables_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void txtWorkDirPath_TextChanged(object sender, EventArgs e)
        {
            ReloadAll();
        }

        private void cmbIpAddresses_TextChanged(object sender, EventArgs e)
        {
            remoteMappedIpAddress = cmbIpAddresses.Text;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            TabPage selectedTab = tabControl.SelectedTab;
            if (selectedTab.Name == "tabLog")
            {
                UpdateCommandsLog();
            }
        }

        private void UpdateCommandsLog()
        {
            string pathToFile = Path.Combine(Application.StartupPath, "logs", "local-commands.log");

            if (File.Exists(pathToFile))
            {
                try
                {
                    string[] logLines = File.ReadAllLines(pathToFile);

                    var htmlContent = new StringBuilder("<html>...</html>");

                    //var logimages = RenderLogHelper.LogImages(logLines);
                    //htmlContent.AppendLine(logimages);

                    //var logcontainers = RenderLogHelper.LogContainers(logLines);
                    //htmlContent.AppendLine(logcontainers);

                    //var logvolumes = RenderLogHelper.LogVolumes(logLines);
                    //htmlContent.AppendLine(logvolumes);

                    //var lognetworks = RenderLogHelper.LogNetworks(logLines);
                    //htmlContent.AppendLine(lognetworks);

                    //var logvariables = RenderLogHelper.LogVariables(logLines);
                    //htmlContent.AppendLine(logvariables);



                    htmlContent.AppendLine("</pre></body></html>");

                    if (WBLog.InvokeRequired)
                    {
                        WBLog.Invoke(new Action(() =>
                        {
                            WBLog.DocumentText = htmlContent.ToString();
                            WBLog.DocumentCompleted += WBLogDocumentCompleted;
                        }));
                    }
                    else
                    {
                        WBLog.DocumentText = htmlContent.ToString();
                        WBLog.DocumentCompleted += WBLogDocumentCompleted;
                    }
                }
                catch (IOException ex)
                {
                    // Gestione delle eccezioni
                }
            }
        }

        private void WBLogDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.Equals(WBLog.Url))
            {
                ScrollToBottom();
                WBLog.DocumentCompleted -= WBLogDocumentCompleted;
            }
        }

        private void ScrollToBottom()
        {
            if (WBLog.Document != null)
            {
                WBLog.Document.Window.ScrollTo(0, WBLog.Document.Body.ScrollRectangle.Height);
            }
        }

        #endregion


    }
}
