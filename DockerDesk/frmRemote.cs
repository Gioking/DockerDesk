﻿using DockerDesk.Helpers;
using DockerDesk.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerDesk
{
    public partial class frmRemote : Form
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
        private SshClientManager sshClientManager = new SshClientManager("", "", "", "", 22);

        public frmRemote()
        {
            InitializeComponent();
            sshClientManager.ProgressChanged += UpdateProgressBar;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Init();
            ReloadAll();
        }

        private void Init()
        {
            panelLogin.Height = 80;
            chkShowCommandResult.Checked = Properties.Settings.Default.ShowCommandResult;
        }

        private void ReloadAll()
        {
            if (CheckIfConnection())
            {
                LoadImages();
                LoadContainers();
                LoadVolumes();
                LoadNetworks();
                LoadVariables();
            }
        }

        private bool CheckIfConnection()
        {
            try
            {
                bool isRunning = DockerRunner.IsSshConnected(sshClientManager);
                if (!isRunning)
                {
                    imageStatusLabel.Text = "Client ssh non connesso.";
                    toolStripStatus.Image = imageList1.Images["red-button.png"];
                    return false;
                }
                else
                {
                    imageStatusLabel.Text = "Client ssh connesso.";
                    toolStripStatus.Image = imageList1.Images["green-button.png"];
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Si è verificato un errore: {ex.Message}");
                return false;
            }
        }

        #region Loadding
        private async void LoadImages()
        {
            try
            {
                try
                {
                    imagesList.Clear();
                    await Task.Delay(100);
                    var command = await DockerRunner.DockerExecute("images", WBCmd, sshClientManager);
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
                await Task.Delay(100);
                var command = await DockerRunner.DockerExecute("ps -a", WBCmd, sshClientManager);
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
                await Task.Delay(100);
                var command = await DockerRunner.DockerExecute("volume ls", WBCmd, sshClientManager);
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
                await Task.Delay(100);
                var command = await DockerRunner.DockerExecute("network ls", WBCmd, sshClientManager);
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

        private void rdoKeyChanged(object sender, EventArgs e)
        {
            panelLogin.Height = 88;
        }

        private void rdoCredChanged(object sender, EventArgs e)
        {
            panelLogin.Height = 154;
        }

        private async void ConnectToRemote(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);

                string privateKeyFile = ConfigurationManager.AppSettings["OpenSshKeyPath"];
                string sshUserName = txtRemoteUsername.Text;
                string[] parts = sshUserName.Split('@');

                if (rdoAccessByKeys.Checked)
                {
                    if (!DockerNetWorkChecker.IsValidIPAddress(txtRemoteUsername.Text))
                    {
                        MessageBox.Show("Warning... the remote ip address is not a valid ip address.");
                        return;
                    }

                    if (!DockerNetWorkChecker.IsValidPort(txtRemotePort.Text))
                    {
                        MessageBox.Show("Warning... the remote port is not a valid.");
                        return;
                    }

                    string username = parts[0];
                    string host = parts[1];
                    int port = int.Parse(txtRemotePort.Text);

                    sshClientManager = new SshClientManager(host, username, "", privateKeyFile, port);
                    await sshClientManager.ConnectAsync();
                }
                else
                {
                    string username = parts[0];
                    string host = parts[1];
                    int port = int.Parse(txtRemotePort.Text);
                    string password = txtPassword.Text;

                    sshClientManager = new SshClientManager(host, username, password, privateKeyFile, port);
                    await sshClientManager.ConnectAsync();
                }

                ReloadAll();

                CheckIfConnection();

                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                SpinnerHelper.ToggleSpinner(pBar, false);
                Console.WriteLine("Errore: " + ex.Message);
            }
        }

        private void DisconnectSsh(object sender, EventArgs e)
        {
            DisconnectSshClient();
        }

        private void DisconnectSshClient()
        {
            try
            {
                sshClientManager.DisconnectAndDispose();
                CheckIfConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante la chiusura della connessione ssh: " + ex.Message);
            }
        }

        private void UpdateProgressBar(int percentage)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int>(UpdateProgressBar), percentage);
            }
            else
            {
                UploaderPBar.Value = percentage;
            }
        }

        //docker build -t myapp:1.0 .
        //docker build -t test-image-gio:v1 -f Dockerfile .
        private async void CreateImage(object sender, EventArgs e)
        {
            try
            {
                //Check if a initial dockerfile is missing
                string dockerFilePath = Path.Combine(Application.StartupPath, txtLocalPath.Text, "dockerfile");
                if (!File.Exists(dockerFilePath))
                {
                    MessageBox.Show($"No dockerfile has been found in this path {dockerFilePath}");
                    return;
                }

                string tempDirectory = Path.GetTempPath();
                string localPath = txtLocalPath.Text;
                string projectName = Path.GetFileName(localPath);
                string zipFilePath = $@"{tempDirectory}{projectName}.zip";
                string remotePath = txtRemotePath.Text;

                //Chack if remotepath is correct
                if (!remotePath.StartsWith("/") || !remotePath.EndsWith("/"))
                {
                    MessageBox.Show($"Warning... the remote path must start with / and must end with / eg. /remorepath/");
                    return;
                }

                SpinnerHelper.ToggleSpinner(pBar, true);

                //Create zip file from project folder
                await FileHelpers.CreateZipFileAsync(localPath, zipFilePath);

                //Copy zip file to remote host
                string result = await sshClientManager.UploadAndDecompressFileAsync(zipFilePath, $"{remotePath}{projectName}.zip", remotePath);
                //txtLog.Text = LogHelper.LogInfo(result);

                ResultModel command;

                //Build docker image command 
                string dockerCommand = string.IsNullOrEmpty(txtTag.Text) ?
                    $"cd {remotePath} && docker build -t {txtImageName.Text} ." : $"cd {remotePath} && docker build -t {txtImageName.Text}:{txtTag.Text} .";

                //Execute ssh command on remote machine
                command = await DockerRunner.DockerCreateImage(dockerCommand, WBCmd, sshClientManager);

                if (command.OperationResult == null && command.OperationResult == null)
                {
                    return;
                }

                //If successful clean the working folder in remote machine
                if (command.OperationResult.Contains("Successfully built"))
                {
                    LoadImages();

                    var chose = MessageBox.Show($"Warning... want you clean the working folder {remotePath} on remote machine ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (chose == DialogResult.Yes)
                    {
                        await DockerImageHelpers.CleanSourceFilesAsync(remotePath, sshClientManager);
                    }
                }

                //txtLog.Text = LogHelper.LogInfo(command.OperationResult);
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                SpinnerHelper.ToggleSpinner(pBar, false);
                MessageBox.Show(ex.Message);
            }
        }

        //docker rmi -f image:v1
        private async void DeleteImage(object sender, EventArgs e)
        {
            try
            {
                if (selectedImage == null)
                {
                    return;
                }

                var chose = MessageBox.Show($"Warning... want delete the image: {selectedImage.Image} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (chose == DialogResult.Yes)
                {
                    SpinnerHelper.ToggleSpinner(pBar, true);
                    var command = await DockerRunner.DockerExecute($"rmi {selectedImage.Image}:{selectedImage.Tag}", WBCmd, sshClientManager);
                    LoadImages();
                    SpinnerHelper.ToggleSpinner(pBar, false);
                }
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
                string hostPathName = txtHostPathName.Text;
                string hostPort = txtHostPort.Text;
                string containerPort = txtContainerPort.Text;
                string containerPathName = txtContainerPathName.Text;
                string remoteMappedIpAddress = txtRemoteMappedIpAddress.Text;

                SpinnerHelper.ToggleSpinner(pBar, true);
                string result = string.Empty;
                if (selectedImage == null || string.IsNullOrEmpty(txtContainerName.Text))
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
                bool isPortInUse = await DockerPortChecker.IsRemotePortInUseByDockerContainerAsync(port, sshClientManager);
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

                // Comando base
                string baseDockerCommand = "run -d";

                // Aggiungi variabili di ambiente se necessario
                if (chkUseVariables.Checked)
                {
                    string envVars = DockerEnvHelper.GetEnvVariablesFromJson(pathToFile);
                    if (envVars != null)
                    {
                        baseDockerCommand += $" {envVars}";
                    }
                }

                // Aggiungi il nome del container
                baseDockerCommand += $" --name {containerName}";

                // Gestione dei volumi
                if (chkHasVolume.Checked)
                {
                    if (chkShareVolumeToHost.Checked)
                    {
                        baseDockerCommand += $" --mount type=bind,source={hostPathName},target={containerPathName}";
                    }
                    else
                    {
                        baseDockerCommand += $" -v {selectedVolume.VolumeName}:{containerPathName}";
                    }
                }

                // Aggiungi mappatura delle porte
                string portMapping = string.IsNullOrEmpty(remoteMappedIpAddress) ? $"{hostPort}:{containerPort}" : $"{remoteMappedIpAddress}:{hostPort}:{containerPort}";
                baseDockerCommand += $" -p {portMapping}";

                // Completa il comando con l'immagine e il tag
                baseDockerCommand += $" {selectedImage.Image}:{selectedImage.Tag}";

                // Esegui il comando
                var command = await DockerRunner.DockerExecute(baseDockerCommand, WBCmd, sshClientManager);

                LoadContainers();
                SpinnerHelper.ToggleSpinner(pBar, false);

                //MessageBox.Show($"The Container {containerName} has been created!");
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
                if (selectedContainer == null)
                {
                    return;
                }

                var chose = MessageBox.Show($"Warning... want delete the container: {selectedContainer.Names} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (chose == DialogResult.Yes)
                {
                    SpinnerHelper.ToggleSpinner(pBar, true);
                    if (selectedContainer == null)
                    {
                        MessageBox.Show("Please select the container to remove.");
                        return;
                    }
                    var command = await DockerRunner.DockerExecute($"rm -f {selectedContainer.ContainerId}", WBCmd, sshClientManager);
                    LoadContainers();
                    SpinnerHelper.ToggleSpinner(pBar, false);
                }
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
                string volumeName = txtNewVolumeName.Text;

                SpinnerHelper.ToggleSpinner(pBar, true);
                var command = await DockerRunner.DockerExecute($"volume create {volumeName}", WBCmd, sshClientManager);
                LoadVolumes();
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
                var chose = MessageBox.Show($"Warning... want delete the volume: {selectedVolume.VolumeName} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (chose == DialogResult.Yes)
                {
                    SpinnerHelper.ToggleSpinner(pBar, true);
                    var command = await DockerRunner.DockerExecute($"volume rm {selectedVolume.VolumeName}", WBCmd, sshClientManager);
                    LoadVolumes();
                    SpinnerHelper.ToggleSpinner(pBar, false);
                }
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
                string drive = comboDrive.Text;
                string gateway = txtGateway.Text;
                string subnet = txtSubnet.Text;
                string networkName = txtNetworkName.Text;

                if (string.IsNullOrEmpty(txtSubnet.Text) || string.IsNullOrEmpty(drive) || string.IsNullOrEmpty(gateway))
                {
                    MessageBox.Show("Missing network information: Subnet, Drive, Gateway");
                    return;
                }

                SpinnerHelper.ToggleSpinner(pBar, true);
                var (suggestedSubnet, suggestedGateway) = await DockerNetWorkChecker.IsNetworkRangeInUseAsync(subnet, sshClientManager);

                if (!string.IsNullOrEmpty(suggestedSubnet))
                {
                    MessageBox.Show($"Warning: The subnet '{subnet}' is already in use! A suggested subnet could be: '{suggestedSubnet}' with gateway '{suggestedGateway}'.");
                    txtSubnet.Text = suggestedSubnet;
                    txtGateway.Text = suggestedGateway;
                    SpinnerHelper.ToggleSpinner(pBar, false);
                    return;
                }


                if (string.IsNullOrEmpty(selectedDrive))
                {
                    var command = await DockerRunner.DockerExecute($"network create -d {comboDrive.Text} {networkName}", WBCmd, sshClientManager);
                }
                else
                {
                    if (string.IsNullOrEmpty(txtSubnet.Text))
                    {
                        MessageBox.Show("Warning... the subnet is required.");
                        return;
                    }
                    var command = await DockerRunner.DockerExecute($"network create --subnet={subnet} --gateway={gateway} {networkName}", WBCmd, sshClientManager);
                }
                LoadNetworks();
                SpinnerHelper.ToggleSpinner(pBar, false);
            }
            catch (Exception ex)
            {
                SpinnerHelper.ToggleSpinner(pBar, false);
                MessageBox.Show(ex.Message);
            }
        }

        private async void DeleteNetwork(object sender, EventArgs e)
        {
            try
            {
                var chose = MessageBox.Show($"Warning... want delete the network: {selectedNetwork.Name} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (chose == DialogResult.Yes)
                {
                    SpinnerHelper.ToggleSpinner(pBar, true);
                    var command = await DockerRunner.DockerExecute($"network rm {selectedNetwork.NetworkId}", WBCmd, sshClientManager);
                    LoadNetworks();
                    SpinnerHelper.ToggleSpinner(pBar, false);
                }
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

                var command = await DockerRunner.DockerExecute($"network connect {selectedNetwork.NetworkId} {selectedContainer.ContainerId}", WBCmd, sshClientManager);
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

                var command = await DockerRunner.DockerExecute($"network disconnect {selectedNetwork.NetworkId} {selectedContainer.ContainerId}", WBCmd, sshClientManager);
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
                var command = await DockerRunner.DockerExecute($"inspect {dockerContainer.ContainerId}", WBCmd, sshClientManager);

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

        //docker top containerid
        private async void btnShowContainerProcesses_Click(object sender, EventArgs e)
        {
            var command = await DockerRunner.DockerExecute($"top {selectedContainer.ContainerId}", WBCmd, sshClientManager);

            frmProcesses existingForm = Application.OpenForms.OfType<frmProcesses>().FirstOrDefault();

            var processList = await DockerRunner.ParseDockerTopOutputAsync(command.OperationResult);

            var jsonData = JsonConvert.SerializeObject(processList, Formatting.Indented);

            if (existingForm != null)
            {
                existingForm.SetData(jsonData);
                existingForm.BringToFront();
            }
            else
            {
                frmProcesses nuovoForm = new frmProcesses(jsonData);
                nuovoForm.Show();
            }
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
            var command = await DockerRunner.DockerExecute($"network inspect {selectedNetwork.NetworkId}", WBCmd, sshClientManager);

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

        #endregion

        #region Various

        private void btnOpenFolder1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                WorkingFolderPath = $@"{folderBrowserDialog.SelectedPath}\";
                txtLocalPath.Text = $@"{folderBrowserDialog.SelectedPath}\";
            }
        }

        private void btnOpenFolder2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                WorkingFolderPath = $@"{folderBrowserDialog.SelectedPath}\";
                txtLocalPath.Text = $@"{folderBrowserDialog.SelectedPath}\";
            }
        }

        private void GridImages_MouseClick(object sender, MouseEventArgs e)
        {
            try
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
            catch (Exception)
            {
            }
        }

        private void gridContainers_MouseClick(object sender, MouseEventArgs e)
        {
            try
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
            catch (Exception)
            {
            }
        }

        private void GridVolumes_MouseClick(object sender, MouseEventArgs e)
        {
            try
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
            catch (Exception)
            {
            }

        }

        private void GridNetwork_MouseClick(object sender, MouseEventArgs e)
        {
            try
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
            catch (Exception)
            {
            }

        }

        private void menuShowAbout(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
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

        //docker exec [nome_o_id_del_container] env
        private async void cmbContainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SpinnerHelper.ToggleSpinner(pBar, true);

                var container = (DockerContainer)cmbContainers.SelectedItem;

                if (container == null)
                {
                    SpinnerHelper.ToggleSpinner(pBar, false);
                    return;
                }

                var command = await DockerRunner.DockerExecute($"exec {container.ContainerId} env", WBCmd, sshClientManager);

                if (command == null) { return; }

                if (command.OperationResult == null && command.OperationResult == null)
                {
                    SpinnerHelper.ToggleSpinner(pBar, false);
                    return;
                }

                var result = await DockerRunner.ParseDockerEnvOutputAsync(command.OperationResult);
                GridVariables.DataSource = result;

                //txtLog.Text = LogHelper.LogInfo(command.OperationResult);

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

        private void frmRemote_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectSshClient();
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

        private async void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            TabPage selectedTab = tabControl.SelectedTab;
            if (selectedTab.Name == "tabLog")
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(await RenderLogHelper.ReportDataGridAsync(GridImages));
                sb.AppendLine(await RenderLogHelper.ReportDataGridAsync(gridContainers));
                sb.AppendLine(await RenderLogHelper.ReportDataGridAsync(GridVolumes));
                sb.AppendLine(await RenderLogHelper.ReportDataGridAsync(GridNetwork));
                sb.AppendLine(await RenderLogHelper.ReportDataGridAsync(GridVariables));

                if (WBLog.InvokeRequired)
                {
                    WBLog.Invoke(new Action(() =>
                    {
                        WBLog.DocumentText = sb.ToString();
                        WBLog.DocumentCompleted += WBLogDocumentCompleted;
                    }));
                }
                else
                {
                    WBLog.DocumentText = sb.ToString();
                    WBLog.DocumentCompleted += WBLogDocumentCompleted;
                }
            }

            if (selectedTab.Name == "tabHistory")
            {
                if (WBCmd.InvokeRequired)
                {
                    WBCmd.Invoke(new Action(() =>
                    {
                        WBCmd.DocumentCompleted += WBCmdDocumentCompleted;
                    }));
                }
                else
                {
                    WBCmd.DocumentCompleted += WBCmdDocumentCompleted;
                }
            }
        }

        private void WBCmdDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.Equals(WBCmd.Url))
            {
                if (WBCmd.Document != null)
                {
                    WBCmd.Document.Window.ScrollTo(0, WBCmd.Document.Body.ScrollRectangle.Height);
                }
                WBCmd.DocumentCompleted -= WBCmdDocumentCompleted; // Rimuovi il gestore dell'evento dopo l'uso
            }
        }

        private void WBLogDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.Equals(WBLog.Url))
            {
                if (WBLog.Document != null)
                {
                    WBLog.Document.Window.ScrollTo(0, WBLog.Document.Body.ScrollRectangle.Height);
                }
                WBLog.DocumentCompleted -= WBLogDocumentCompleted; // Rimuovi il gestore dell'evento dopo l'uso
            }
        }





        #endregion

        private void chkShowCommandResult_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowCommandResult = chkShowCommandResult.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
