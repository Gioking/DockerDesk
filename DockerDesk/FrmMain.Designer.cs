﻿namespace DockerDesk
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabImages = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbVolumes = new System.Windows.Forms.ComboBox();
            this.dockerVolumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRunContainer = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.chkHasVolume = new System.Windows.Forms.CheckBox();
            this.txtHostPort = new System.Windows.Forms.TextBox();
            this.txtVolumeName = new System.Windows.Forms.TextBox();
            this.txtContainerPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContainerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GridImages = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dockerImageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreateImage = new System.Windows.Forms.Button();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabContainers = new System.Windows.Forms.TabPage();
            this.btnRemoveContainer = new System.Windows.Forms.Button();
            this.gridContainers = new System.Windows.Forms.DataGridView();
            this.containerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dockerContainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.tabVolume = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateVolume = new System.Windows.Forms.Button();
            this.txtNewVolumeName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRemoveVolume = new System.Windows.Forms.Button();
            this.GridVolumes = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.tabNetwork = new System.Windows.Forms.TabPage();
            this.btnRemoveNetwork = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSubnet = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboDrive = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCreateNetwork = new System.Windows.Forms.Button();
            this.txtNetworkName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.GridNetwork = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectProjectPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectWorkDir = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.imageStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSelectedImage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSelectedContainer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSelectedVolume = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton5 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSelectedNetwork = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.txtWorkDirPath = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtContainerInspect = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabImages.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockerVolumeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockerImageBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabContainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContainers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockerContainerBindingSource)).BeginInit();
            this.tabVolume.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVolumes)).BeginInit();
            this.tabNetwork.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridNetwork)).BeginInit();
            this.tabLog.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabImages);
            this.tabControl1.Controls.Add(this.tabContainers);
            this.tabControl1.Controls.Add(this.tabVolume);
            this.tabControl1.Controls.Add(this.tabNetwork);
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1094, 579);
            this.tabControl1.TabIndex = 0;
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
            this.tabImages.Size = new System.Drawing.Size(1086, 546);
            this.tabImages.TabIndex = 0;
            this.tabImages.Text = "Images";
            this.tabImages.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.cmbVolumes);
            this.groupBox4.Controls.Add(this.btnRunContainer);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.chkHasVolume);
            this.groupBox4.Controls.Add(this.txtHostPort);
            this.groupBox4.Controls.Add(this.txtVolumeName);
            this.groupBox4.Controls.Add(this.txtContainerPort);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtContainerName);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(15, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 224);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Container data";
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
            // cmbVolumes
            // 
            this.cmbVolumes.DataSource = this.dockerVolumeBindingSource;
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
            // dockerVolumeBindingSource
            // 
            this.dockerVolumeBindingSource.DataSource = typeof(DockerDesk.Models.DockerVolume);
            // 
            // btnRunContainer
            // 
            this.btnRunContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRunContainer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunContainer.ImageKey = "gear-2-32.png";
            this.btnRunContainer.ImageList = this.imageList1;
            this.btnRunContainer.Location = new System.Drawing.Point(69, 164);
            this.btnRunContainer.Name = "btnRunContainer";
            this.btnRunContainer.Size = new System.Drawing.Size(220, 45);
            this.btnRunContainer.TabIndex = 5;
            this.btnRunContainer.Text = "Run Countainer";
            this.btnRunContainer.UseVisualStyleBackColor = true;
            this.btnRunContainer.Click += new System.EventHandler(this.btnRunContainer_Click);
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
            this.imageList1.Images.SetKeyName(9, "info-5-32.png");
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
            // txtVolumeName
            // 
            this.txtVolumeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtVolumeName.Location = new System.Drawing.Point(69, 136);
            this.txtVolumeName.Multiline = true;
            this.txtVolumeName.Name = "txtVolumeName";
            this.txtVolumeName.Size = new System.Drawing.Size(220, 22);
            this.txtVolumeName.TabIndex = 14;
            this.txtVolumeName.Text = "/path/to/container";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "V.Path";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "C.Name";
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
            this.GridImages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn,
            this.imageIdDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn});
            this.GridImages.DataSource = this.dockerImageBindingSource;
            this.GridImages.Location = new System.Drawing.Point(15, 43);
            this.GridImages.MultiSelect = false;
            this.GridImages.Name = "GridImages";
            this.GridImages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridImages.Size = new System.Drawing.Size(748, 253);
            this.GridImages.TabIndex = 16;
            this.GridImages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridImages_MouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 152.2843F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.FillWeight = 89.54315F;
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.Width = 66;
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn.FillWeight = 89.54315F;
            this.tagDataGridViewTextBoxColumn.HeaderText = "Tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            this.tagDataGridViewTextBoxColumn.Width = 52;
            // 
            // imageIdDataGridViewTextBoxColumn
            // 
            this.imageIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.imageIdDataGridViewTextBoxColumn.DataPropertyName = "ImageId";
            this.imageIdDataGridViewTextBoxColumn.FillWeight = 89.54315F;
            this.imageIdDataGridViewTextBoxColumn.HeaderText = "ImageId";
            this.imageIdDataGridViewTextBoxColumn.Name = "imageIdDataGridViewTextBoxColumn";
            this.imageIdDataGridViewTextBoxColumn.Width = 77;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.FillWeight = 89.54315F;
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.Width = 76;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.FillWeight = 89.54315F;
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.Width = 56;
            // 
            // dockerImageBindingSource
            // 
            this.dockerImageBindingSource.DataSource = typeof(DockerDesk.Models.DockerImage);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDeleteImage);
            this.groupBox1.Controls.Add(this.txtTag);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnCreateImage);
            this.groupBox1.Controls.Add(this.txtImageName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(769, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 255);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image data";
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteImage.Location = new System.Drawing.Point(161, 204);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(142, 35);
            this.btnDeleteImage.TabIndex = 5;
            this.btnDeleteImage.Text = "Delete Image";
            this.btnDeleteImage.UseVisualStyleBackColor = true;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // txtTag
            // 
            this.txtTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtTag.Location = new System.Drawing.Point(87, 55);
            this.txtTag.Multiline = true;
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(210, 22);
            this.txtTag.TabIndex = 4;
            this.txtTag.Text = "v1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Image tag";
            // 
            // btnCreateImage
            // 
            this.btnCreateImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateImage.Location = new System.Drawing.Point(9, 204);
            this.btnCreateImage.Name = "btnCreateImage";
            this.btnCreateImage.Size = new System.Drawing.Size(142, 35);
            this.btnCreateImage.TabIndex = 2;
            this.btnCreateImage.Text = "Create Image";
            this.btnCreateImage.UseVisualStyleBackColor = true;
            this.btnCreateImage.Click += new System.EventHandler(this.btnCreateImage_Click);
            // 
            // txtImageName
            // 
            this.txtImageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtImageName.Location = new System.Drawing.Point(87, 27);
            this.txtImageName.Multiline = true;
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(210, 22);
            this.txtImageName.TabIndex = 1;
            this.txtImageName.Text = "docker-image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Image name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Docker Images";
            // 
            // tabContainers
            // 
            this.tabContainers.Controls.Add(this.txtContainerInspect);
            this.tabContainers.Controls.Add(this.btnRemoveContainer);
            this.tabContainers.Controls.Add(this.gridContainers);
            this.tabContainers.Controls.Add(this.label7);
            this.tabContainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabContainers.ImageIndex = 3;
            this.tabContainers.Location = new System.Drawing.Point(4, 29);
            this.tabContainers.Name = "tabContainers";
            this.tabContainers.Padding = new System.Windows.Forms.Padding(3);
            this.tabContainers.Size = new System.Drawing.Size(1086, 546);
            this.tabContainers.TabIndex = 1;
            this.tabContainers.Text = "Containers";
            this.tabContainers.UseVisualStyleBackColor = true;
            // 
            // btnRemoveContainer
            // 
            this.btnRemoveContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRemoveContainer.Location = new System.Drawing.Point(11, 362);
            this.btnRemoveContainer.Name = "btnRemoveContainer";
            this.btnRemoveContainer.Size = new System.Drawing.Size(220, 31);
            this.btnRemoveContainer.TabIndex = 8;
            this.btnRemoveContainer.Text = "Remove Container";
            this.btnRemoveContainer.UseVisualStyleBackColor = true;
            this.btnRemoveContainer.Click += new System.EventHandler(this.btnRemoveContainer_Click);
            // 
            // gridContainers
            // 
            this.gridContainers.AllowUserToAddRows = false;
            this.gridContainers.AllowUserToDeleteRows = false;
            this.gridContainers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridContainers.AutoGenerateColumns = false;
            this.gridContainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContainers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.containerIdDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn1,
            this.commandDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn,
            this.portsDataGridViewTextBoxColumn,
            this.namesDataGridViewTextBoxColumn});
            this.gridContainers.DataSource = this.dockerContainerBindingSource;
            this.gridContainers.Location = new System.Drawing.Point(11, 43);
            this.gridContainers.MultiSelect = false;
            this.gridContainers.Name = "gridContainers";
            this.gridContainers.ReadOnly = true;
            this.gridContainers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridContainers.Size = new System.Drawing.Size(1067, 313);
            this.gridContainers.TabIndex = 7;
            this.gridContainers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridContainers_MouseClick);
            // 
            // containerIdDataGridViewTextBoxColumn
            // 
            this.containerIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.containerIdDataGridViewTextBoxColumn.DataPropertyName = "ContainerId";
            this.containerIdDataGridViewTextBoxColumn.HeaderText = "ContainerId";
            this.containerIdDataGridViewTextBoxColumn.Name = "containerIdDataGridViewTextBoxColumn";
            this.containerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.containerIdDataGridViewTextBoxColumn.Width = 97;
            // 
            // imageDataGridViewTextBoxColumn1
            // 
            this.imageDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.imageDataGridViewTextBoxColumn1.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn1.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn1.Name = "imageDataGridViewTextBoxColumn1";
            this.imageDataGridViewTextBoxColumn1.ReadOnly = true;
            this.imageDataGridViewTextBoxColumn1.Width = 66;
            // 
            // commandDataGridViewTextBoxColumn
            // 
            this.commandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.commandDataGridViewTextBoxColumn.DataPropertyName = "Command";
            this.commandDataGridViewTextBoxColumn.HeaderText = "Command";
            this.commandDataGridViewTextBoxColumn.Name = "commandDataGridViewTextBoxColumn";
            this.commandDataGridViewTextBoxColumn.ReadOnly = true;
            this.commandDataGridViewTextBoxColumn.Width = 86;
            // 
            // createdDataGridViewTextBoxColumn1
            // 
            this.createdDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.createdDataGridViewTextBoxColumn1.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn1.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn1.Name = "createdDataGridViewTextBoxColumn1";
            this.createdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.createdDataGridViewTextBoxColumn1.Width = 76;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 68;
            // 
            // portsDataGridViewTextBoxColumn
            // 
            this.portsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.portsDataGridViewTextBoxColumn.DataPropertyName = "Ports";
            this.portsDataGridViewTextBoxColumn.HeaderText = "Ports";
            this.portsDataGridViewTextBoxColumn.Name = "portsDataGridViewTextBoxColumn";
            this.portsDataGridViewTextBoxColumn.ReadOnly = true;
            this.portsDataGridViewTextBoxColumn.Width = 61;
            // 
            // namesDataGridViewTextBoxColumn
            // 
            this.namesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.namesDataGridViewTextBoxColumn.DataPropertyName = "Names";
            this.namesDataGridViewTextBoxColumn.HeaderText = "Names";
            this.namesDataGridViewTextBoxColumn.Name = "namesDataGridViewTextBoxColumn";
            this.namesDataGridViewTextBoxColumn.ReadOnly = true;
            this.namesDataGridViewTextBoxColumn.Width = 69;
            // 
            // dockerContainerBindingSource
            // 
            this.dockerContainerBindingSource.DataSource = typeof(DockerDesk.Models.DockerContainer);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Current Docker Images";
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
            this.tabVolume.Size = new System.Drawing.Size(1086, 546);
            this.tabVolume.TabIndex = 2;
            this.tabVolume.Text = "Volume";
            this.tabVolume.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnCreateVolume);
            this.groupBox2.Controls.Add(this.txtNewVolumeName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(745, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 240);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volume data";
            // 
            // btnCreateVolume
            // 
            this.btnCreateVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateVolume.Location = new System.Drawing.Point(9, 189);
            this.btnCreateVolume.Name = "btnCreateVolume";
            this.btnCreateVolume.Size = new System.Drawing.Size(142, 35);
            this.btnCreateVolume.TabIndex = 2;
            this.btnCreateVolume.Text = "Create Volume";
            this.btnCreateVolume.UseVisualStyleBackColor = true;
            this.btnCreateVolume.Click += new System.EventHandler(this.btnCreateVolume_Click);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Volume name";
            // 
            // btnRemoveVolume
            // 
            this.btnRemoveVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRemoveVolume.Location = new System.Drawing.Point(11, 286);
            this.btnRemoveVolume.Name = "btnRemoveVolume";
            this.btnRemoveVolume.Size = new System.Drawing.Size(220, 31);
            this.btnRemoveVolume.TabIndex = 11;
            this.btnRemoveVolume.Text = "Remove Volume";
            this.btnRemoveVolume.UseVisualStyleBackColor = true;
            this.btnRemoveVolume.Click += new System.EventHandler(this.btnRemoveVolume_Click);
            // 
            // GridVolumes
            // 
            this.GridVolumes.AllowUserToAddRows = false;
            this.GridVolumes.AllowUserToDeleteRows = false;
            this.GridVolumes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridVolumes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVolumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVolumes.Location = new System.Drawing.Point(11, 42);
            this.GridVolumes.MultiSelect = false;
            this.GridVolumes.Name = "GridVolumes";
            this.GridVolumes.ReadOnly = true;
            this.GridVolumes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridVolumes.Size = new System.Drawing.Size(728, 238);
            this.GridVolumes.TabIndex = 10;
            this.GridVolumes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridVolumes_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Current Docker Images";
            // 
            // tabNetwork
            // 
            this.tabNetwork.Controls.Add(this.btnRemoveNetwork);
            this.tabNetwork.Controls.Add(this.groupBox3);
            this.tabNetwork.Controls.Add(this.GridNetwork);
            this.tabNetwork.Controls.Add(this.label10);
            this.tabNetwork.ImageIndex = 0;
            this.tabNetwork.Location = new System.Drawing.Point(4, 29);
            this.tabNetwork.Name = "tabNetwork";
            this.tabNetwork.Size = new System.Drawing.Size(1086, 546);
            this.tabNetwork.TabIndex = 3;
            this.tabNetwork.Text = "Network";
            this.tabNetwork.UseVisualStyleBackColor = true;
            // 
            // btnRemoveNetwork
            // 
            this.btnRemoveNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRemoveNetwork.Location = new System.Drawing.Point(11, 286);
            this.btnRemoveNetwork.Name = "btnRemoveNetwork";
            this.btnRemoveNetwork.Size = new System.Drawing.Size(220, 31);
            this.btnRemoveNetwork.TabIndex = 20;
            this.btnRemoveNetwork.Text = "Remove Network";
            this.btnRemoveNetwork.UseVisualStyleBackColor = true;
            this.btnRemoveNetwork.Click += new System.EventHandler(this.btnRemoveNetwork_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox3.Location = new System.Drawing.Point(729, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 240);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image data";
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 20);
            this.label15.TabIndex = 8;
            this.label15.Text = "Gateway";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Subnet";
            // 
            // comboDrive
            // 
            this.comboDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDrive.FormattingEnabled = true;
            this.comboDrive.Items.AddRange(new object[] {
            "bridge",
            "Host",
            "Overlay",
            "Macvlan"});
            this.comboDrive.Location = new System.Drawing.Point(123, 60);
            this.comboDrive.Name = "comboDrive";
            this.comboDrive.Size = new System.Drawing.Size(210, 28);
            this.comboDrive.TabIndex = 5;
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
            // btnCreateNetwork
            // 
            this.btnCreateNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateNetwork.Location = new System.Drawing.Point(9, 189);
            this.btnCreateNetwork.Name = "btnCreateNetwork";
            this.btnCreateNetwork.Size = new System.Drawing.Size(142, 35);
            this.btnCreateNetwork.TabIndex = 2;
            this.btnCreateNetwork.Text = "Create Network";
            this.btnCreateNetwork.UseVisualStyleBackColor = true;
            this.btnCreateNetwork.Click += new System.EventHandler(this.btnCreateNetwork_Click);
            // 
            // txtNetworkName
            // 
            this.txtNetworkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtNetworkName.Location = new System.Drawing.Point(123, 31);
            this.txtNetworkName.Name = "txtNetworkName";
            this.txtNetworkName.Size = new System.Drawing.Size(210, 23);
            this.txtNetworkName.TabIndex = 1;
            this.txtNetworkName.Text = "my-network";
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
            // GridNetwork
            // 
            this.GridNetwork.AllowUserToAddRows = false;
            this.GridNetwork.AllowUserToDeleteRows = false;
            this.GridNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridNetwork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridNetwork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNetwork.Location = new System.Drawing.Point(11, 42);
            this.GridNetwork.MultiSelect = false;
            this.GridNetwork.Name = "GridNetwork";
            this.GridNetwork.ReadOnly = true;
            this.GridNetwork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridNetwork.Size = new System.Drawing.Size(712, 238);
            this.GridNetwork.TabIndex = 18;
            this.GridNetwork.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridNetwork_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Current Docker Images";
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.btnClearLog);
            this.tabLog.Controls.Add(this.txtLog);
            this.tabLog.ImageIndex = 1;
            this.tabLog.Location = new System.Drawing.Point(4, 29);
            this.tabLog.Name = "tabLog";
            this.tabLog.Size = new System.Drawing.Size(1086, 546);
            this.tabLog.TabIndex = 4;
            this.tabLog.Text = "Logs";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearLog.Location = new System.Drawing.Point(8, 507);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(142, 35);
            this.btnClearLog.TabIndex = 3;
            this.btnClearLog.Text = "Clear Logs";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
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
            this.txtLog.Size = new System.Drawing.Size(1086, 501);
            this.txtLog.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1094, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectProjectPathToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.reloadAllToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectProjectPathToolStripMenuItem
            // 
            this.selectProjectPathToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectWorkDir});
            this.selectProjectPathToolStripMenuItem.Name = "selectProjectPathToolStripMenuItem";
            this.selectProjectPathToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.selectProjectPathToolStripMenuItem.Text = "Projects";
            // 
            // SelectWorkDir
            // 
            this.SelectWorkDir.Image = ((System.Drawing.Image)(resources.GetObject("SelectWorkDir.Image")));
            this.SelectWorkDir.Name = "SelectWorkDir";
            this.SelectWorkDir.Size = new System.Drawing.Size(221, 24);
            this.SelectWorkDir.Text = "Select Work Directory";
            this.SelectWorkDir.Click += new System.EventHandler(this.SelectWorkDir_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // reloadAllToolStripMenuItem
            // 
            this.reloadAllToolStripMenuItem.Name = "reloadAllToolStripMenuItem";
            this.reloadAllToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.reloadAllToolStripMenuItem.Text = "Reload All";
            this.reloadAllToolStripMenuItem.Click += new System.EventHandler(this.reloadAllToolStripMenuItem_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.SelectedPath = "C:\\";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton3,
            this.imageStatusLabel,
            this.toolStripSplitButton1,
            this.toolStripSelectedImage,
            this.toolStripSplitButton2,
            this.toolStripSelectedContainer,
            this.toolStripSplitButton4,
            this.toolStripSelectedVolume,
            this.toolStripSplitButton5,
            this.toolStripSelectedNetwork});
            this.statusBar.Location = new System.Drawing.Point(0, 653);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1094, 25);
            this.statusBar.TabIndex = 3;
            this.statusBar.Text = "Status";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(32, 23);
            this.toolStripSplitButton3.Text = "toolStripSplitButton3";
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
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOpenFolder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenFolder.Location = new System.Drawing.Point(1062, 31);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(28, 31);
            this.btnOpenFolder.TabIndex = 4;
            this.btnOpenFolder.Text = "...";
            this.btnOpenFolder.UseVisualStyleBackColor = false;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // txtWorkDirPath
            // 
            this.txtWorkDirPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkDirPath.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtWorkDirPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkDirPath.ForeColor = System.Drawing.SystemColors.Info;
            this.txtWorkDirPath.Location = new System.Drawing.Point(209, 34);
            this.txtWorkDirPath.Multiline = true;
            this.txtWorkDirPath.Name = "txtWorkDirPath";
            this.txtWorkDirPath.Size = new System.Drawing.Size(847, 28);
            this.txtWorkDirPath.TabIndex = 5;
            this.txtWorkDirPath.Text = "D:\\Dev\\AppDemos\\aspdockerapi\\";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(197, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "Dockerfile path (Project path):";
            // 
            // txtContainerInspect
            // 
            this.txtContainerInspect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContainerInspect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContainerInspect.Location = new System.Drawing.Point(237, 362);
            this.txtContainerInspect.Multiline = true;
            this.txtContainerInspect.Name = "txtContainerInspect";
            this.txtContainerInspect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContainerInspect.Size = new System.Drawing.Size(841, 178);
            this.txtContainerInspect.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 678);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtWorkDirPath);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DockerDesk v.1.0 for visual studio containers By F.G.";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabImages.ResumeLayout(false);
            this.tabImages.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockerVolumeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockerImageBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabContainers.ResumeLayout(false);
            this.tabContainers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContainers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockerContainerBindingSource)).EndInit();
            this.tabVolume.ResumeLayout(false);
            this.tabVolume.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVolumes)).EndInit();
            this.tabNetwork.ResumeLayout(false);
            this.tabNetwork.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridNetwork)).EndInit();
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabImages;
        private System.Windows.Forms.TabPage tabContainers;
        private System.Windows.Forms.TabPage tabVolume;
        private System.Windows.Forms.TabPage tabNetwork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRunContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtImageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectProjectPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectWorkDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel imageStatusLabel;
        private System.Windows.Forms.Button btnCreateImage;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.TextBox txtWorkDirPath;
        private System.Windows.Forms.TextBox txtContainerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContainerPort;
        private System.Windows.Forms.TextBox txtHostPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVolumeName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkHasVolume;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSelectedImage;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridContainers;
        private System.Windows.Forms.DataGridView GridImages;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSelectedContainer;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.Button btnRemoveContainer;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnRemoveVolume;
        private System.Windows.Forms.DataGridView GridVolumes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreateVolume;
        private System.Windows.Forms.TextBox txtNewVolumeName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSelectedVolume;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView GridNetwork;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSelectedNetwork;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboDrive;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCreateNetwork;
        private System.Windows.Forms.TextBox txtNetworkName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSubnet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRemoveNetwork;
        public System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ToolStripMenuItem reloadAllToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbVolumes;
        private System.Windows.Forms.BindingSource dockerVolumeBindingSource;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.BindingSource dockerImageBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn containerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dockerContainerBindingSource;
        public System.Windows.Forms.TextBox txtContainerInspect;
    }
}

