namespace DockerDesk
{
    partial class frmLocal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocal));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dockerNetworkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dockerImageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dockerContainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dockerVolumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dockerVariableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remoteMachineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripSplitButton();
            this.imageStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSelectedImage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSelectedContainer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSelectedVolume = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton5 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSelectedNetwork = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.tabVariables = new System.Windows.Forms.TabPage();
            this.GridVariables = new System.Windows.Forms.DataGridView();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbContainers = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabNetwork = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.GridNetwork = new System.Windows.Forms.DataGridView();
            this.scopeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.networkIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNetworkName = new System.Windows.Forms.TextBox();
            this.btnCreateNetwork = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboDrive = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSubnet = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.btnNetInspect = new System.Windows.Forms.Button();
            this.btnRemoveNetwork = new System.Windows.Forms.Button();
            this.tabVolume = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.GridVolumes = new System.Windows.Forms.DataGridView();
            this.volumeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveVolume = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNewVolumeName = new System.Windows.Forms.TextBox();
            this.btnCreateVolume = new System.Windows.Forms.Button();
            this.tabContainers = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.gridContainers = new System.Windows.Forms.DataGridView();
            this.portsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveContainer = new System.Windows.Forms.Button();
            this.cmbNetworksConnect = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnConnectNetwork = new System.Windows.Forms.Button();
            this.btnInspect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.tabImages = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.btnCreateImage = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtWorkDirPath = new System.Windows.Forms.TextBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.GridImages = new System.Windows.Forms.DataGridView();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContainerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContainerPort = new System.Windows.Forms.TextBox();
            this.txtContainerPathName = new System.Windows.Forms.TextBox();
            this.txtHostPort = new System.Windows.Forms.TextBox();
            this.chkHasVolume = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRunContainer = new System.Windows.Forms.Button();
            this.cmbVolumes = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.chkShareVolumeToHost = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtHostPathName = new System.Windows.Forms.TextBox();
            this.btnCreateVariables = new System.Windows.Forms.Button();
            this.chkUseVariables = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dockerNetworkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockerImageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockerContainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockerVolumeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockerVariableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteMachineBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.tabVariables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVariables)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabNetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridNetwork)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVolumes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabContainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContainers)).BeginInit();
            this.tabImages.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridImages)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "arrow-96-32.png");
            this.imageList1.Images.SetKeyName(1, "arrow-213-32.png");
            this.imageList1.Images.SetKeyName(2, "check-mark-32.png");
            this.imageList1.Images.SetKeyName(3, "gear-2-32.png");
            this.imageList1.Images.SetKeyName(4, "globe-4-32.png");
            this.imageList1.Images.SetKeyName(5, "hexagon-32.png");
            this.imageList1.Images.SetKeyName(6, "settings-5-32.png");
            this.imageList1.Images.SetKeyName(7, "accept-database-32.png");
            this.imageList1.Images.SetKeyName(8, "folder-8-32.png");
            this.imageList1.Images.SetKeyName(9, "green-button.png");
            this.imageList1.Images.SetKeyName(10, "red-button.png");
            this.imageList1.Images.SetKeyName(11, "high-importance-32.png");
            this.imageList1.Images.SetKeyName(12, "server-yellow-32.png");
            // 
            // dockerNetworkBindingSource
            // 
            this.dockerNetworkBindingSource.DataSource = typeof(DockerDesk.Models.DockerNetwork);
            // 
            // dockerImageBindingSource
            // 
            this.dockerImageBindingSource.DataSource = typeof(DockerDesk.Models.DockerImage);
            // 
            // dockerContainerBindingSource
            // 
            this.dockerContainerBindingSource.DataSource = typeof(DockerDesk.Models.DockerContainer);
            // 
            // dockerVolumeBindingSource
            // 
            this.dockerVolumeBindingSource.DataSource = typeof(DockerDesk.Models.DockerVolume);
            // 
            // dockerVariableBindingSource
            // 
            this.dockerVariableBindingSource.DataSource = typeof(DockerDesk.Models.DockerVariable);
            // 
            // remoteMachineBindingSource
            // 
            this.remoteMachineBindingSource.DataSource = typeof(DockerDesk.Models.RemoteMachine);
            // 
            // pBar
            // 
            this.pBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pBar.Location = new System.Drawing.Point(1086, 657);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(119, 16);
            this.pBar.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadAllToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.fileToolStripMenuItem.Text = "Tools";
            // 
            // reloadAllToolStripMenuItem
            // 
            this.reloadAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadAllToolStripMenuItem.Image")));
            this.reloadAllToolStripMenuItem.Name = "reloadAllToolStripMenuItem";
            this.reloadAllToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.reloadAllToolStripMenuItem.Text = "Reload All";
            this.reloadAllToolStripMenuItem.Click += new System.EventHandler(this.reloadAllToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.SelectedPath = "C:\\";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus,
            this.imageStatusLabel,
            this.toolStripSplitButton1,
            this.toolStripSelectedImage,
            this.toolStripSplitButton2,
            this.toolStripSelectedContainer,
            this.toolStripSplitButton4,
            this.toolStripSelectedVolume,
            this.toolStripSplitButton5,
            this.toolStripSelectedNetwork});
            this.statusBar.Location = new System.Drawing.Point(0, 654);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1234, 25);
            this.statusBar.TabIndex = 3;
            this.statusBar.Text = "Status";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatus.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatus.Image")));
            this.toolStripStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(32, 23);
            this.toolStripStatus.Text = "toolStripSplitButton3";
            // 
            // imageStatusLabel
            // 
            this.imageStatusLabel.Name = "imageStatusLabel";
            this.imageStatusLabel.Size = new System.Drawing.Size(57, 20);
            this.imageStatusLabel.Text = "Images";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 23);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripSelectedImage
            // 
            this.toolStripSelectedImage.Name = "toolStripSelectedImage";
            this.toolStripSelectedImage.Size = new System.Drawing.Size(115, 20);
            this.toolStripSelectedImage.Text = "Selected Image:";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 23);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // toolStripSelectedContainer
            // 
            this.toolStripSelectedContainer.Name = "toolStripSelectedContainer";
            this.toolStripSelectedContainer.Size = new System.Drawing.Size(134, 20);
            this.toolStripSelectedContainer.Text = "Selected Container";
            // 
            // toolStripSplitButton4
            // 
            this.toolStripSplitButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton4.Image")));
            this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton4.Name = "toolStripSplitButton4";
            this.toolStripSplitButton4.Size = new System.Drawing.Size(32, 23);
            this.toolStripSplitButton4.Text = "toolStripSplitButton4";
            // 
            // toolStripSelectedVolume
            // 
            this.toolStripSelectedVolume.Name = "toolStripSelectedVolume";
            this.toolStripSelectedVolume.Size = new System.Drawing.Size(120, 20);
            this.toolStripSelectedVolume.Text = "Selected Volume";
            // 
            // toolStripSplitButton5
            // 
            this.toolStripSplitButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton5.Image")));
            this.toolStripSplitButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton5.Name = "toolStripSplitButton5";
            this.toolStripSplitButton5.Size = new System.Drawing.Size(32, 23);
            this.toolStripSplitButton5.Text = "toolStripSplitButton5";
            // 
            // toolStripSelectedNetwork
            // 
            this.toolStripSelectedNetwork.Name = "toolStripSelectedNetwork";
            this.toolStripSelectedNetwork.Size = new System.Drawing.Size(126, 20);
            this.toolStripSelectedNetwork.Text = "Selected Network";
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.btnClearLog);
            this.tabLog.Controls.Add(this.txtLog);
            this.tabLog.ImageKey = "high-importance-32.png";
            this.tabLog.Location = new System.Drawing.Point(4, 29);
            this.tabLog.Name = "tabLog";
            this.tabLog.Size = new System.Drawing.Size(1226, 593);
            this.tabLog.TabIndex = 4;
            this.tabLog.Text = "Logs";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(1218, 526);
            this.txtLog.TabIndex = 0;
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearLog.Location = new System.Drawing.Point(8, 542);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(142, 35);
            this.btnClearLog.TabIndex = 3;
            this.btnClearLog.Text = "Clear Logs";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // tabVariables
            // 
            this.tabVariables.Controls.Add(this.label24);
            this.tabVariables.Controls.Add(this.groupBox5);
            this.tabVariables.Controls.Add(this.GridVariables);
            this.tabVariables.ImageKey = "arrow-213-32.png";
            this.tabVariables.Location = new System.Drawing.Point(4, 29);
            this.tabVariables.Name = "tabVariables";
            this.tabVariables.Size = new System.Drawing.Size(1226, 593);
            this.tabVariables.TabIndex = 5;
            this.tabVariables.Text = "Variables";
            this.tabVariables.UseVisualStyleBackColor = true;
            // 
            // GridVariables
            // 
            this.GridVariables.AllowUserToAddRows = false;
            this.GridVariables.AllowUserToDeleteRows = false;
            this.GridVariables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridVariables.AutoGenerateColumns = false;
            this.GridVariables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.GridVariables.DataSource = this.dockerVariableBindingSource;
            this.GridVariables.Location = new System.Drawing.Point(13, 25);
            this.GridVariables.MultiSelect = false;
            this.GridVariables.Name = "GridVariables";
            this.GridVariables.ReadOnly = true;
            this.GridVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridVariables.Size = new System.Drawing.Size(880, 360);
            this.GridVariables.TabIndex = 20;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keyDataGridViewTextBoxColumn
            // 
            this.keyDataGridViewTextBoxColumn.DataPropertyName = "Key";
            this.keyDataGridViewTextBoxColumn.HeaderText = "Key";
            this.keyDataGridViewTextBoxColumn.Name = "keyDataGridViewTextBoxColumn";
            this.keyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.cmbContainers);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox5.Location = new System.Drawing.Point(899, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(319, 360);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Variables data";
            // 
            // cmbContainers
            // 
            this.cmbContainers.DataSource = this.dockerContainerBindingSource;
            this.cmbContainers.DisplayMember = "Names";
            this.cmbContainers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cmbContainers.FormattingEnabled = true;
            this.cmbContainers.Location = new System.Drawing.Point(6, 49);
            this.cmbContainers.Name = "cmbContainers";
            this.cmbContainers.Size = new System.Drawing.Size(307, 24);
            this.cmbContainers.TabIndex = 22;
            this.cmbContainers.ValueMember = "ContainerId";
            this.cmbContainers.SelectedIndexChanged += new System.EventHandler(this.cmbContainers_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 20);
            this.label20.TabIndex = 23;
            this.label20.Text = "Container";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(11, 7);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(133, 15);
            this.label24.TabIndex = 22;
            this.label24.Text = "Container Variables";
            // 
            // tabNetwork
            // 
            this.tabNetwork.Controls.Add(this.groupBox3);
            this.tabNetwork.Controls.Add(this.GridNetwork);
            this.tabNetwork.Controls.Add(this.label10);
            this.tabNetwork.ImageIndex = 0;
            this.tabNetwork.Location = new System.Drawing.Point(4, 29);
            this.tabNetwork.Name = "tabNetwork";
            this.tabNetwork.Size = new System.Drawing.Size(1226, 593);
            this.tabNetwork.TabIndex = 3;
            this.tabNetwork.Text = "Network";
            this.tabNetwork.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Current Docker Images";
            // 
            // GridNetwork
            // 
            this.GridNetwork.AllowUserToAddRows = false;
            this.GridNetwork.AllowUserToDeleteRows = false;
            this.GridNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridNetwork.AutoGenerateColumns = false;
            this.GridNetwork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridNetwork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNetwork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.networkIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.driveDataGridViewTextBoxColumn,
            this.scopeDataGridViewTextBoxColumn});
            this.GridNetwork.DataSource = this.dockerNetworkBindingSource;
            this.GridNetwork.Location = new System.Drawing.Point(13, 25);
            this.GridNetwork.MultiSelect = false;
            this.GridNetwork.Name = "GridNetwork";
            this.GridNetwork.ReadOnly = true;
            this.GridNetwork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridNetwork.Size = new System.Drawing.Size(856, 360);
            this.GridNetwork.TabIndex = 18;
            this.GridNetwork.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridNetwork_MouseClick);
            // 
            // scopeDataGridViewTextBoxColumn
            // 
            this.scopeDataGridViewTextBoxColumn.DataPropertyName = "Scope";
            this.scopeDataGridViewTextBoxColumn.HeaderText = "Scope";
            this.scopeDataGridViewTextBoxColumn.Name = "scopeDataGridViewTextBoxColumn";
            this.scopeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driveDataGridViewTextBoxColumn
            // 
            this.driveDataGridViewTextBoxColumn.DataPropertyName = "Drive";
            this.driveDataGridViewTextBoxColumn.HeaderText = "Drive";
            this.driveDataGridViewTextBoxColumn.Name = "driveDataGridViewTextBoxColumn";
            this.driveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // networkIdDataGridViewTextBoxColumn
            // 
            this.networkIdDataGridViewTextBoxColumn.DataPropertyName = "NetworkId";
            this.networkIdDataGridViewTextBoxColumn.HeaderText = "NetworkId";
            this.networkIdDataGridViewTextBoxColumn.Name = "networkIdDataGridViewTextBoxColumn";
            this.networkIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 50;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnRemoveNetwork);
            this.groupBox3.Controls.Add(this.btnNetInspect);
            this.groupBox3.Controls.Add(this.txtGateway);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtSubnet);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.comboDrive);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnCreateNetwork);
            this.groupBox3.Controls.Add(this.txtNetworkName);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(873, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 360);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image data";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Network name";
            // 
            // txtNetworkName
            // 
            this.txtNetworkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtNetworkName.Location = new System.Drawing.Point(123, 31);
            this.txtNetworkName.Name = "txtNetworkName";
            this.txtNetworkName.Size = new System.Drawing.Size(210, 23);
            this.txtNetworkName.TabIndex = 1;
            this.txtNetworkName.Text = "custom-network";
            // 
            // btnCreateNetwork
            // 
            this.btnCreateNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCreateNetwork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNetwork.ImageKey = "arrow-96-32.png";
            this.btnCreateNetwork.ImageList = this.imageList1;
            this.btnCreateNetwork.Location = new System.Drawing.Point(118, 229);
            this.btnCreateNetwork.Name = "btnCreateNetwork";
            this.btnCreateNetwork.Size = new System.Drawing.Size(210, 35);
            this.btnCreateNetwork.TabIndex = 2;
            this.btnCreateNetwork.Text = "Create Network";
            this.btnCreateNetwork.UseVisualStyleBackColor = true;
            this.btnCreateNetwork.Click += new System.EventHandler(this.btnCreateNetwork_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Drive";
            // 
            // comboDrive
            // 
            this.comboDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDrive.FormattingEnabled = true;
            this.comboDrive.Items.AddRange(new object[] {
            "",
            "bridge",
            "Host",
            "Overlay",
            "Macvlan"});
            this.comboDrive.Location = new System.Drawing.Point(123, 60);
            this.comboDrive.Name = "comboDrive";
            this.comboDrive.Size = new System.Drawing.Size(210, 28);
            this.comboDrive.TabIndex = 5;
            this.comboDrive.SelectedIndexChanged += new System.EventHandler(this.comboDrive_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Subnet";
            // 
            // txtSubnet
            // 
            this.txtSubnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtSubnet.Location = new System.Drawing.Point(123, 94);
            this.txtSubnet.Name = "txtSubnet";
            this.txtSubnet.Size = new System.Drawing.Size(210, 23);
            this.txtSubnet.TabIndex = 7;
            this.txtSubnet.Text = "192.168.1.0/24";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 20);
            this.label15.TabIndex = 8;
            this.label15.Text = "Gateway";
            // 
            // txtGateway
            // 
            this.txtGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtGateway.Location = new System.Drawing.Point(123, 122);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(210, 23);
            this.txtGateway.TabIndex = 9;
            this.txtGateway.Text = "192.168.1.1";
            // 
            // btnNetInspect
            // 
            this.btnNetInspect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNetInspect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnNetInspect.Location = new System.Drawing.Point(118, 270);
            this.btnNetInspect.Name = "btnNetInspect";
            this.btnNetInspect.Size = new System.Drawing.Size(210, 31);
            this.btnNetInspect.TabIndex = 21;
            this.btnNetInspect.Text = "Inspect";
            this.btnNetInspect.UseVisualStyleBackColor = true;
            this.btnNetInspect.Click += new System.EventHandler(this.btnNetInspect_Click);
            // 
            // btnRemoveNetwork
            // 
            this.btnRemoveNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRemoveNetwork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveNetwork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveNetwork.ImageKey = "(none)";
            this.btnRemoveNetwork.ImageList = this.imageList1;
            this.btnRemoveNetwork.Location = new System.Drawing.Point(118, 307);
            this.btnRemoveNetwork.Name = "btnRemoveNetwork";
            this.btnRemoveNetwork.Size = new System.Drawing.Size(210, 31);
            this.btnRemoveNetwork.TabIndex = 20;
            this.btnRemoveNetwork.Text = "Remove Network";
            this.btnRemoveNetwork.UseVisualStyleBackColor = true;
            this.btnRemoveNetwork.Click += new System.EventHandler(this.btnRemoveNetwork_Click);
            // 
            // tabVolume
            // 
            this.tabVolume.Controls.Add(this.groupBox2);
            this.tabVolume.Controls.Add(this.btnRemoveVolume);
            this.tabVolume.Controls.Add(this.GridVolumes);
            this.tabVolume.Controls.Add(this.label9);
            this.tabVolume.ImageIndex = 7;
            this.tabVolume.Location = new System.Drawing.Point(4, 29);
            this.tabVolume.Name = "tabVolume";
            this.tabVolume.Size = new System.Drawing.Size(1226, 593);
            this.tabVolume.TabIndex = 2;
            this.tabVolume.Text = "Volume";
            this.tabVolume.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Current Docker Images";
            // 
            // GridVolumes
            // 
            this.GridVolumes.AllowUserToAddRows = false;
            this.GridVolumes.AllowUserToDeleteRows = false;
            this.GridVolumes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridVolumes.AutoGenerateColumns = false;
            this.GridVolumes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVolumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVolumes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.driveDataGridViewTextBoxColumn1,
            this.volumeNameDataGridViewTextBoxColumn});
            this.GridVolumes.DataSource = this.dockerVolumeBindingSource;
            this.GridVolumes.Location = new System.Drawing.Point(13, 25);
            this.GridVolumes.MultiSelect = false;
            this.GridVolumes.Name = "GridVolumes";
            this.GridVolumes.ReadOnly = true;
            this.GridVolumes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridVolumes.Size = new System.Drawing.Size(856, 502);
            this.GridVolumes.TabIndex = 10;
            this.GridVolumes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridVolumes_MouseClick);
            // 
            // volumeNameDataGridViewTextBoxColumn
            // 
            this.volumeNameDataGridViewTextBoxColumn.DataPropertyName = "VolumeName";
            this.volumeNameDataGridViewTextBoxColumn.HeaderText = "Volume Name";
            this.volumeNameDataGridViewTextBoxColumn.Name = "volumeNameDataGridViewTextBoxColumn";
            this.volumeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driveDataGridViewTextBoxColumn1
            // 
            this.driveDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.driveDataGridViewTextBoxColumn1.DataPropertyName = "Drive";
            this.driveDataGridViewTextBoxColumn1.HeaderText = "Drive";
            this.driveDataGridViewTextBoxColumn1.Name = "driveDataGridViewTextBoxColumn1";
            this.driveDataGridViewTextBoxColumn1.ReadOnly = true;
            this.driveDataGridViewTextBoxColumn1.Width = 150;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 50;
            // 
            // btnRemoveVolume
            // 
            this.btnRemoveVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRemoveVolume.Location = new System.Drawing.Point(14, 533);
            this.btnRemoveVolume.Name = "btnRemoveVolume";
            this.btnRemoveVolume.Size = new System.Drawing.Size(220, 31);
            this.btnRemoveVolume.TabIndex = 11;
            this.btnRemoveVolume.Text = "Remove Volume";
            this.btnRemoveVolume.UseVisualStyleBackColor = true;
            this.btnRemoveVolume.Click += new System.EventHandler(this.btnRemoveVolume_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnCreateVolume);
            this.groupBox2.Controls.Add(this.txtNewVolumeName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(873, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 502);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volume data";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Volume name";
            // 
            // txtNewVolumeName
            // 
            this.txtNewVolumeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtNewVolumeName.Location = new System.Drawing.Point(119, 31);
            this.txtNewVolumeName.Multiline = true;
            this.txtNewVolumeName.Name = "txtNewVolumeName";
            this.txtNewVolumeName.Size = new System.Drawing.Size(201, 24);
            this.txtNewVolumeName.TabIndex = 1;
            this.txtNewVolumeName.Text = "container-volume";
            // 
            // btnCreateVolume
            // 
            this.btnCreateVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCreateVolume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateVolume.ImageKey = "accept-database-32.png";
            this.btnCreateVolume.ImageList = this.imageList1;
            this.btnCreateVolume.Location = new System.Drawing.Point(119, 70);
            this.btnCreateVolume.Name = "btnCreateVolume";
            this.btnCreateVolume.Size = new System.Drawing.Size(201, 35);
            this.btnCreateVolume.TabIndex = 2;
            this.btnCreateVolume.Text = "Create Volume";
            this.btnCreateVolume.UseVisualStyleBackColor = true;
            this.btnCreateVolume.Click += new System.EventHandler(this.btnCreateVolume_Click);
            // 
            // tabContainers
            // 
            this.tabContainers.Controls.Add(this.btnDisconnect);
            this.tabContainers.Controls.Add(this.btnInspect);
            this.tabContainers.Controls.Add(this.btnConnectNetwork);
            this.tabContainers.Controls.Add(this.label18);
            this.tabContainers.Controls.Add(this.cmbNetworksConnect);
            this.tabContainers.Controls.Add(this.btnRemoveContainer);
            this.tabContainers.Controls.Add(this.gridContainers);
            this.tabContainers.Controls.Add(this.label7);
            this.tabContainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabContainers.ImageIndex = 3;
            this.tabContainers.Location = new System.Drawing.Point(4, 29);
            this.tabContainers.Name = "tabContainers";
            this.tabContainers.Padding = new System.Windows.Forms.Padding(3);
            this.tabContainers.Size = new System.Drawing.Size(1226, 593);
            this.tabContainers.TabIndex = 1;
            this.tabContainers.Text = "Containers";
            this.tabContainers.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Current Docker Images";
            // 
            // gridContainers
            // 
            this.gridContainers.AllowUserToAddRows = false;
            this.gridContainers.AllowUserToDeleteRows = false;
            this.gridContainers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridContainers.AutoGenerateColumns = false;
            this.gridContainers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridContainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContainers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.containerIdDataGridViewTextBoxColumn,
            this.namesDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn1,
            this.commandDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn,
            this.portsDataGridViewTextBoxColumn});
            this.gridContainers.DataSource = this.dockerContainerBindingSource;
            this.gridContainers.Location = new System.Drawing.Point(13, 25);
            this.gridContainers.MultiSelect = false;
            this.gridContainers.Name = "gridContainers";
            this.gridContainers.ReadOnly = true;
            this.gridContainers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridContainers.Size = new System.Drawing.Size(1207, 359);
            this.gridContainers.TabIndex = 7;
            this.gridContainers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridContainers_MouseClick);
            // 
            // portsDataGridViewTextBoxColumn
            // 
            this.portsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.portsDataGridViewTextBoxColumn.DataPropertyName = "Ports";
            this.portsDataGridViewTextBoxColumn.HeaderText = "Ports";
            this.portsDataGridViewTextBoxColumn.Name = "portsDataGridViewTextBoxColumn";
            this.portsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdDataGridViewTextBoxColumn1
            // 
            this.createdDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdDataGridViewTextBoxColumn1.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn1.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn1.Name = "createdDataGridViewTextBoxColumn1";
            this.createdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // commandDataGridViewTextBoxColumn
            // 
            this.commandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commandDataGridViewTextBoxColumn.DataPropertyName = "Command";
            this.commandDataGridViewTextBoxColumn.HeaderText = "Command";
            this.commandDataGridViewTextBoxColumn.Name = "commandDataGridViewTextBoxColumn";
            this.commandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewTextBoxColumn1
            // 
            this.imageDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imageDataGridViewTextBoxColumn1.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn1.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn1.Name = "imageDataGridViewTextBoxColumn1";
            this.imageDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // namesDataGridViewTextBoxColumn
            // 
            this.namesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namesDataGridViewTextBoxColumn.DataPropertyName = "Names";
            this.namesDataGridViewTextBoxColumn.HeaderText = "C.Name";
            this.namesDataGridViewTextBoxColumn.Name = "namesDataGridViewTextBoxColumn";
            this.namesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // containerIdDataGridViewTextBoxColumn
            // 
            this.containerIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.containerIdDataGridViewTextBoxColumn.DataPropertyName = "ContainerId";
            this.containerIdDataGridViewTextBoxColumn.HeaderText = "ContainerId";
            this.containerIdDataGridViewTextBoxColumn.Name = "containerIdDataGridViewTextBoxColumn";
            this.containerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnRemoveContainer
            // 
            this.btnRemoveContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRemoveContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveContainer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveContainer.ImageKey = "(none)";
            this.btnRemoveContainer.ImageList = this.imageList1;
            this.btnRemoveContainer.Location = new System.Drawing.Point(1001, 392);
            this.btnRemoveContainer.Name = "btnRemoveContainer";
            this.btnRemoveContainer.Size = new System.Drawing.Size(220, 31);
            this.btnRemoveContainer.TabIndex = 8;
            this.btnRemoveContainer.Text = "Remove Container";
            this.btnRemoveContainer.UseVisualStyleBackColor = true;
            this.btnRemoveContainer.Click += new System.EventHandler(this.btnRemoveContainer_Click);
            // 
            // cmbNetworksConnect
            // 
            this.cmbNetworksConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbNetworksConnect.DataSource = this.dockerNetworkBindingSource;
            this.cmbNetworksConnect.DisplayMember = "Name";
            this.cmbNetworksConnect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNetworksConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cmbNetworksConnect.FormattingEnabled = true;
            this.cmbNetworksConnect.Location = new System.Drawing.Point(366, 395);
            this.cmbNetworksConnect.Name = "cmbNetworksConnect";
            this.cmbNetworksConnect.Size = new System.Drawing.Size(326, 24);
            this.cmbNetworksConnect.TabIndex = 17;
            this.cmbNetworksConnect.ValueMember = "NetworkId";
            this.cmbNetworksConnect.SelectedIndexChanged += new System.EventHandler(this.cmbNetworksConnect_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(160, 400);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(200, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Connect container to this network:";
            // 
            // btnConnectNetwork
            // 
            this.btnConnectNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConnectNetwork.Location = new System.Drawing.Point(698, 395);
            this.btnConnectNetwork.Name = "btnConnectNetwork";
            this.btnConnectNetwork.Size = new System.Drawing.Size(75, 26);
            this.btnConnectNetwork.TabIndex = 19;
            this.btnConnectNetwork.Text = "Connect";
            this.btnConnectNetwork.UseVisualStyleBackColor = true;
            this.btnConnectNetwork.Click += new System.EventHandler(this.btnConnectNetwork_Click);
            // 
            // btnInspect
            // 
            this.btnInspect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInspect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnInspect.Location = new System.Drawing.Point(14, 390);
            this.btnInspect.Name = "btnInspect";
            this.btnInspect.Size = new System.Drawing.Size(128, 31);
            this.btnInspect.TabIndex = 20;
            this.btnInspect.Text = "Inspect";
            this.btnInspect.UseVisualStyleBackColor = true;
            this.btnInspect.Click += new System.EventHandler(this.btnInspect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDisconnect.Location = new System.Drawing.Point(779, 395);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(88, 26);
            this.btnDisconnect.TabIndex = 21;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // tabImages
            // 
            this.tabImages.Controls.Add(this.groupBox4);
            this.tabImages.Controls.Add(this.GridImages);
            this.tabImages.Controls.Add(this.groupBox1);
            this.tabImages.Controls.Add(this.label1);
            this.tabImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabImages.ImageIndex = 5;
            this.tabImages.Location = new System.Drawing.Point(4, 29);
            this.tabImages.Name = "tabImages";
            this.tabImages.Padding = new System.Windows.Forms.Padding(3);
            this.tabImages.Size = new System.Drawing.Size(1226, 593);
            this.tabImages.TabIndex = 0;
            this.tabImages.Text = "Images";
            this.tabImages.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Docker Images";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnDeleteImage);
            this.groupBox1.Controls.Add(this.btnOpenFolder);
            this.groupBox1.Controls.Add(this.txtWorkDirPath);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtTag);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnCreateImage);
            this.groupBox1.Controls.Add(this.txtImageName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(13, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 242);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "2) Image name";
            // 
            // txtImageName
            // 
            this.txtImageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtImageName.Location = new System.Drawing.Point(125, 53);
            this.txtImageName.Multiline = true;
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(210, 22);
            this.txtImageName.TabIndex = 1;
            this.txtImageName.Text = "docker-image";
            // 
            // btnCreateImage
            // 
            this.btnCreateImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateImage.ImageKey = "hexagon-32.png";
            this.btnCreateImage.ImageList = this.imageList1;
            this.btnCreateImage.Location = new System.Drawing.Point(9, 191);
            this.btnCreateImage.Name = "btnCreateImage";
            this.btnCreateImage.Size = new System.Drawing.Size(142, 35);
            this.btnCreateImage.TabIndex = 2;
            this.btnCreateImage.Text = "Create Image";
            this.btnCreateImage.UseVisualStyleBackColor = true;
            this.btnCreateImage.Click += new System.EventHandler(this.btnCreateImage_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "3) Image tag";
            // 
            // txtTag
            // 
            this.txtTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtTag.Location = new System.Drawing.Point(125, 81);
            this.txtTag.Multiline = true;
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(210, 22);
            this.txtTag.TabIndex = 4;
            this.txtTag.Text = "v1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 16);
            this.label17.TabIndex = 6;
            this.label17.Text = "1) Dockerfile";
            // 
            // txtWorkDirPath
            // 
            this.txtWorkDirPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkDirPath.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtWorkDirPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWorkDirPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtWorkDirPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWorkDirPath.Location = new System.Drawing.Point(125, 25);
            this.txtWorkDirPath.Name = "txtWorkDirPath";
            this.txtWorkDirPath.Size = new System.Drawing.Size(708, 22);
            this.txtWorkDirPath.TabIndex = 5;
            this.txtWorkDirPath.Text = "D:\\Dev\\AppDemos\\aspdockerapi\\";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenFolder.Location = new System.Drawing.Point(839, 25);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(40, 22);
            this.btnOpenFolder.TabIndex = 4;
            this.btnOpenFolder.Text = "---";
            this.btnOpenFolder.UseVisualStyleBackColor = false;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteImage.Location = new System.Drawing.Point(161, 191);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(142, 35);
            this.btnDeleteImage.TabIndex = 5;
            this.btnDeleteImage.Text = "Delete Image";
            this.btnDeleteImage.UseVisualStyleBackColor = true;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // GridImages
            // 
            this.GridImages.AllowUserToAddRows = false;
            this.GridImages.AllowUserToDeleteRows = false;
            this.GridImages.AllowUserToOrderColumns = true;
            this.GridImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridImages.AutoGenerateColumns = false;
            this.GridImages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridImages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn,
            this.imageIdDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn});
            this.GridImages.DataSource = this.dockerImageBindingSource;
            this.GridImages.Location = new System.Drawing.Point(13, 25);
            this.GridImages.MultiSelect = false;
            this.GridImages.Name = "GridImages";
            this.GridImages.ReadOnly = true;
            this.GridImages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridImages.Size = new System.Drawing.Size(900, 314);
            this.GridImages.TabIndex = 16;
            this.GridImages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridImages_MouseClick);
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.FillWeight = 89.54315F;
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.FillWeight = 89.54315F;
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageIdDataGridViewTextBoxColumn
            // 
            this.imageIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imageIdDataGridViewTextBoxColumn.DataPropertyName = "ImageId";
            this.imageIdDataGridViewTextBoxColumn.FillWeight = 89.54315F;
            this.imageIdDataGridViewTextBoxColumn.HeaderText = "ImageId";
            this.imageIdDataGridViewTextBoxColumn.Name = "imageIdDataGridViewTextBoxColumn";
            this.imageIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn.FillWeight = 89.54315F;
            this.tagDataGridViewTextBoxColumn.HeaderText = "Tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            this.tagDataGridViewTextBoxColumn.ReadOnly = true;
            this.tagDataGridViewTextBoxColumn.Width = 60;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.FillWeight = 89.54315F;
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 152.2843F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.chkUseVariables);
            this.groupBox4.Controls.Add(this.btnCreateVariables);
            this.groupBox4.Controls.Add(this.txtHostPathName);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.chkShareVolumeToHost);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.cmbVolumes);
            this.groupBox4.Controls.Add(this.btnRunContainer);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.chkHasVolume);
            this.groupBox4.Controls.Add(this.txtHostPort);
            this.groupBox4.Controls.Add(this.txtContainerPathName);
            this.groupBox4.Controls.Add(this.txtContainerPort);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtContainerName);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(919, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 562);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Container data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "C.Name";
            // 
            // txtContainerName
            // 
            this.txtContainerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtContainerName.Location = new System.Drawing.Point(69, 79);
            this.txtContainerName.Multiline = true;
            this.txtContainerName.Name = "txtContainerName";
            this.txtContainerName.Size = new System.Drawing.Size(220, 22);
            this.txtContainerName.TabIndex = 12;
            this.txtContainerName.Text = "container-name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "C.Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "V.Path";
            // 
            // txtContainerPort
            // 
            this.txtContainerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtContainerPort.Location = new System.Drawing.Point(215, 51);
            this.txtContainerPort.Multiline = true;
            this.txtContainerPort.Name = "txtContainerPort";
            this.txtContainerPort.Size = new System.Drawing.Size(74, 22);
            this.txtContainerPort.TabIndex = 9;
            this.txtContainerPort.Text = "80";
            this.txtContainerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContainerPathName
            // 
            this.txtContainerPathName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtContainerPathName.Location = new System.Drawing.Point(69, 136);
            this.txtContainerPathName.Multiline = true;
            this.txtContainerPathName.Name = "txtContainerPathName";
            this.txtContainerPathName.Size = new System.Drawing.Size(220, 22);
            this.txtContainerPathName.TabIndex = 14;
            this.txtContainerPathName.Text = "/app/logs";
            // 
            // txtHostPort
            // 
            this.txtHostPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtHostPort.Location = new System.Drawing.Point(70, 51);
            this.txtHostPort.Multiline = true;
            this.txtHostPort.Name = "txtHostPort";
            this.txtHostPort.Size = new System.Drawing.Size(81, 22);
            this.txtHostPort.TabIndex = 8;
            this.txtHostPort.Text = "8080";
            this.txtHostPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkHasVolume
            // 
            this.chkHasVolume.AutoSize = true;
            this.chkHasVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.chkHasVolume.Location = new System.Drawing.Point(70, 28);
            this.chkHasVolume.Name = "chkHasVolume";
            this.chkHasVolume.Size = new System.Drawing.Size(165, 19);
            this.chkHasVolume.TabIndex = 15;
            this.chkHasVolume.Text = "Container has volume";
            this.chkHasVolume.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "H.Port";
            // 
            // btnRunContainer
            // 
            this.btnRunContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRunContainer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunContainer.ImageKey = "gear-2-32.png";
            this.btnRunContainer.ImageList = this.imageList1;
            this.btnRunContainer.Location = new System.Drawing.Point(69, 511);
            this.btnRunContainer.Name = "btnRunContainer";
            this.btnRunContainer.Size = new System.Drawing.Size(220, 45);
            this.btnRunContainer.TabIndex = 5;
            this.btnRunContainer.Text = "Run Countainer";
            this.btnRunContainer.UseVisualStyleBackColor = true;
            this.btnRunContainer.Click += new System.EventHandler(this.btnRunContainer_Click);
            // 
            // cmbVolumes
            // 
            this.cmbVolumes.DataSource = this.dockerNetworkBindingSource;
            this.cmbVolumes.DisplayMember = "VolumeName";
            this.cmbVolumes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVolumes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cmbVolumes.FormattingEnabled = true;
            this.cmbVolumes.Location = new System.Drawing.Point(69, 107);
            this.cmbVolumes.Name = "cmbVolumes";
            this.cmbVolumes.Size = new System.Drawing.Size(220, 24);
            this.cmbVolumes.TabIndex = 16;
            this.cmbVolumes.ValueMember = "VolumeName";
            this.cmbVolumes.SelectedIndexChanged += new System.EventHandler(this.cmbVolumes_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "C.Vol";
            // 
            // chkShareVolumeToHost
            // 
            this.chkShareVolumeToHost.AutoSize = true;
            this.chkShareVolumeToHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.chkShareVolumeToHost.Location = new System.Drawing.Point(69, 175);
            this.chkShareVolumeToHost.Name = "chkShareVolumeToHost";
            this.chkShareVolumeToHost.Size = new System.Drawing.Size(184, 20);
            this.chkShareVolumeToHost.TabIndex = 18;
            this.chkShareVolumeToHost.Text = "Share volume with host";
            this.chkShareVolumeToHost.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 196);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "H.Path";
            // 
            // txtHostPathName
            // 
            this.txtHostPathName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtHostPathName.Location = new System.Drawing.Point(68, 201);
            this.txtHostPathName.Multiline = true;
            this.txtHostPathName.Name = "txtHostPathName";
            this.txtHostPathName.Size = new System.Drawing.Size(220, 22);
            this.txtHostPathName.TabIndex = 20;
            this.txtHostPathName.Text = "C:\\Shared";
            // 
            // btnCreateVariables
            // 
            this.btnCreateVariables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCreateVariables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateVariables.ImageKey = "arrow-213-32.png";
            this.btnCreateVariables.ImageList = this.imageList1;
            this.btnCreateVariables.Location = new System.Drawing.Point(68, 268);
            this.btnCreateVariables.Name = "btnCreateVariables";
            this.btnCreateVariables.Size = new System.Drawing.Size(220, 35);
            this.btnCreateVariables.TabIndex = 23;
            this.btnCreateVariables.Text = "Edit container variables";
            this.btnCreateVariables.UseVisualStyleBackColor = true;
            this.btnCreateVariables.Click += new System.EventHandler(this.btnCreateVariables_Click);
            // 
            // chkUseVariables
            // 
            this.chkUseVariables.AutoSize = true;
            this.chkUseVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.chkUseVariables.Location = new System.Drawing.Point(70, 242);
            this.chkUseVariables.Name = "chkUseVariables";
            this.chkUseVariables.Size = new System.Drawing.Size(214, 20);
            this.chkUseVariables.TabIndex = 24;
            this.chkUseVariables.Text = "Use Environment Variables";
            this.chkUseVariables.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabImages);
            this.tabControl1.Controls.Add(this.tabContainers);
            this.tabControl1.Controls.Add(this.tabVolume);
            this.tabControl1.Controls.Add(this.tabNetwork);
            this.tabControl1.Controls.Add(this.tabVariables);
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1234, 626);
            this.tabControl1.TabIndex = 0;
            // 
            // frmLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 679);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DockerDesk for local session";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockerNetworkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockerImageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockerContainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockerVolumeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockerVariableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteMachineBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.tabVariables.ResumeLayout(false);
            this.tabVariables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVariables)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabNetwork.ResumeLayout(false);
            this.tabNetwork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridNetwork)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabVolume.ResumeLayout(false);
            this.tabVolume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVolumes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabContainers.ResumeLayout(false);
            this.tabContainers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContainers)).EndInit();
            this.tabImages.ResumeLayout(false);
            this.tabImages.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridImages)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel imageStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSelectedImage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSelectedContainer;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripSplitButton toolStripStatus;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSelectedVolume;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSelectedNetwork;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton5;
        private System.Windows.Forms.ToolStripMenuItem reloadAllToolStripMenuItem;
        private System.Windows.Forms.BindingSource dockerVolumeBindingSource;
        private System.Windows.Forms.BindingSource dockerImageBindingSource;
        private System.Windows.Forms.BindingSource dockerContainerBindingSource;
        private System.Windows.Forms.BindingSource dockerNetworkBindingSource;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.BindingSource dockerVariableBindingSource;
        private System.Windows.Forms.BindingSource remoteMachineBindingSource;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.Button btnClearLog;
        public System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TabPage tabVariables;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbContainers;
        private System.Windows.Forms.DataGridView GridVariables;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabNetwork;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRemoveNetwork;
        private System.Windows.Forms.Button btnNetInspect;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSubnet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboDrive;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCreateNetwork;
        private System.Windows.Forms.TextBox txtNetworkName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView GridNetwork;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn networkIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scopeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabVolume;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreateVolume;
        private System.Windows.Forms.TextBox txtNewVolumeName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRemoveVolume;
        private System.Windows.Forms.DataGridView GridVolumes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabContainers;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnInspect;
        private System.Windows.Forms.Button btnConnectNetwork;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbNetworksConnect;
        private System.Windows.Forms.Button btnRemoveContainer;
        private System.Windows.Forms.DataGridView gridContainers;
        private System.Windows.Forms.DataGridViewTextBoxColumn containerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabImages;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkUseVariables;
        private System.Windows.Forms.Button btnCreateVariables;
        private System.Windows.Forms.TextBox txtHostPathName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chkShareVolumeToHost;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbVolumes;
        private System.Windows.Forms.Button btnRunContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkHasVolume;
        private System.Windows.Forms.TextBox txtHostPort;
        private System.Windows.Forms.TextBox txtContainerPathName;
        private System.Windows.Forms.TextBox txtContainerPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContainerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GridImages;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.TextBox txtWorkDirPath;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCreateImage;
        private System.Windows.Forms.TextBox txtImageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

