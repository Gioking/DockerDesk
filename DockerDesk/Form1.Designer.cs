namespace DockerDesk
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabImages = new System.Windows.Forms.TabPage();
            this.chkHasVolume = new System.Windows.Forms.CheckBox();
            this.txtVolumeName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContainerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContainerPort = new System.Windows.Forms.TextBox();
            this.txtHostPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateImage = new System.Windows.Forms.Button();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRunContainer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCOntainers = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tabVolume = new System.Windows.Forms.TabPage();
            this.tabNetwork = new System.Windows.Forms.TabPage();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectProjectPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectWorkDir = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.imageStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSelectedImage = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.txtWorkDirPath = new System.Windows.Forms.TextBox();
            this.gridContainers = new System.Windows.Forms.DataGridView();
            this.GridImages = new System.Windows.Forms.DataGridView();
            this.toolStripSelectedContainer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabImages.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabCOntainers.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContainers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridImages)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabImages);
            this.tabControl1.Controls.Add(this.tabCOntainers);
            this.tabControl1.Controls.Add(this.tabVolume);
            this.tabControl1.Controls.Add(this.tabNetwork);
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1094, 494);
            this.tabControl1.TabIndex = 0;
            // 
            // tabImages
            // 
            this.tabImages.Controls.Add(this.GridImages);
            this.tabImages.Controls.Add(this.chkHasVolume);
            this.tabImages.Controls.Add(this.txtVolumeName);
            this.tabImages.Controls.Add(this.label6);
            this.tabImages.Controls.Add(this.txtContainerName);
            this.tabImages.Controls.Add(this.label5);
            this.tabImages.Controls.Add(this.label4);
            this.tabImages.Controls.Add(this.txtContainerPort);
            this.tabImages.Controls.Add(this.txtHostPort);
            this.tabImages.Controls.Add(this.label3);
            this.tabImages.Controls.Add(this.groupBox1);
            this.tabImages.Controls.Add(this.btnRunContainer);
            this.tabImages.Controls.Add(this.label1);
            this.tabImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabImages.Location = new System.Drawing.Point(4, 29);
            this.tabImages.Name = "tabImages";
            this.tabImages.Padding = new System.Windows.Forms.Padding(3);
            this.tabImages.Size = new System.Drawing.Size(1086, 461);
            this.tabImages.TabIndex = 0;
            this.tabImages.Text = "Images";
            this.tabImages.UseVisualStyleBackColor = true;
            // 
            // chkHasVolume
            // 
            this.chkHasVolume.AutoSize = true;
            this.chkHasVolume.Location = new System.Drawing.Point(65, 303);
            this.chkHasVolume.Name = "chkHasVolume";
            this.chkHasVolume.Size = new System.Drawing.Size(148, 17);
            this.chkHasVolume.TabIndex = 15;
            this.chkHasVolume.Text = "Container has volume";
            this.chkHasVolume.UseVisualStyleBackColor = true;
            // 
            // txtVolumeName
            // 
            this.txtVolumeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtVolumeName.Location = new System.Drawing.Point(64, 382);
            this.txtVolumeName.Multiline = true;
            this.txtVolumeName.Name = "txtVolumeName";
            this.txtVolumeName.Size = new System.Drawing.Size(220, 22);
            this.txtVolumeName.TabIndex = 14;
            this.txtVolumeName.Text = "my-volume:/path/to/container";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "C.Vol.";
            // 
            // txtContainerName
            // 
            this.txtContainerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtContainerName.Location = new System.Drawing.Point(64, 354);
            this.txtContainerName.Multiline = true;
            this.txtContainerName.Name = "txtContainerName";
            this.txtContainerName.Size = new System.Drawing.Size(220, 22);
            this.txtContainerName.TabIndex = 12;
            this.txtContainerName.Text = "container-name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "C.Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "C.Port";
            // 
            // txtContainerPort
            // 
            this.txtContainerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtContainerPort.Location = new System.Drawing.Point(210, 326);
            this.txtContainerPort.Multiline = true;
            this.txtContainerPort.Name = "txtContainerPort";
            this.txtContainerPort.Size = new System.Drawing.Size(74, 22);
            this.txtContainerPort.TabIndex = 9;
            this.txtContainerPort.Text = "80";
            this.txtContainerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHostPort
            // 
            this.txtHostPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtHostPort.Location = new System.Drawing.Point(65, 326);
            this.txtHostPort.Multiline = true;
            this.txtHostPort.Name = "txtHostPort";
            this.txtHostPort.Size = new System.Drawing.Size(81, 22);
            this.txtHostPort.TabIndex = 8;
            this.txtHostPort.Text = "8080";
            this.txtHostPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "H.Port";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateImage);
            this.groupBox1.Controls.Add(this.txtImageName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(769, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 240);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image data";
            // 
            // btnCreateImage
            // 
            this.btnCreateImage.Location = new System.Drawing.Point(9, 189);
            this.btnCreateImage.Name = "btnCreateImage";
            this.btnCreateImage.Size = new System.Drawing.Size(142, 35);
            this.btnCreateImage.TabIndex = 2;
            this.btnCreateImage.Text = "Create Image";
            this.btnCreateImage.UseVisualStyleBackColor = true;
            this.btnCreateImage.Click += new System.EventHandler(this.btnCreateImage_Click);
            // 
            // txtImageName
            // 
            this.txtImageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtImageName.Location = new System.Drawing.Point(87, 27);
            this.txtImageName.Multiline = true;
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(210, 22);
            this.txtImageName.TabIndex = 1;
            this.txtImageName.Text = "test-image-gio";
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
            // btnRunContainer
            // 
            this.btnRunContainer.Location = new System.Drawing.Point(64, 410);
            this.btnRunContainer.Name = "btnRunContainer";
            this.btnRunContainer.Size = new System.Drawing.Size(220, 22);
            this.btnRunContainer.TabIndex = 5;
            this.btnRunContainer.Text = "Run Countainer";
            this.btnRunContainer.UseVisualStyleBackColor = true;
            this.btnRunContainer.Click += new System.EventHandler(this.btnRunContainer_Click);
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
            // tabCOntainers
            // 
            this.tabCOntainers.Controls.Add(this.gridContainers);
            this.tabCOntainers.Controls.Add(this.label7);
            this.tabCOntainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabCOntainers.Location = new System.Drawing.Point(4, 29);
            this.tabCOntainers.Name = "tabCOntainers";
            this.tabCOntainers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCOntainers.Size = new System.Drawing.Size(1086, 461);
            this.tabCOntainers.TabIndex = 1;
            this.tabCOntainers.Text = "Containers";
            this.tabCOntainers.UseVisualStyleBackColor = true;
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
            this.tabVolume.Location = new System.Drawing.Point(4, 29);
            this.tabVolume.Name = "tabVolume";
            this.tabVolume.Size = new System.Drawing.Size(1086, 461);
            this.tabVolume.TabIndex = 2;
            this.tabVolume.Text = "Volume";
            this.tabVolume.UseVisualStyleBackColor = true;
            // 
            // tabNetwork
            // 
            this.tabNetwork.Location = new System.Drawing.Point(4, 29);
            this.tabNetwork.Name = "tabNetwork";
            this.tabNetwork.Size = new System.Drawing.Size(1086, 461);
            this.tabNetwork.TabIndex = 3;
            this.tabNetwork.Text = "Network";
            this.tabNetwork.UseVisualStyleBackColor = true;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.txtLog);
            this.tabLog.Location = new System.Drawing.Point(4, 29);
            this.tabLog.Name = "tabLog";
            this.tabLog.Size = new System.Drawing.Size(1086, 461);
            this.tabLog.TabIndex = 4;
            this.tabLog.Text = "Logs";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(1086, 461);
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
            this.selectProjectPathToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectProjectPathToolStripMenuItem
            // 
            this.selectProjectPathToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectWorkDir});
            this.selectProjectPathToolStripMenuItem.Name = "selectProjectPathToolStripMenuItem";
            this.selectProjectPathToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.selectProjectPathToolStripMenuItem.Text = "Projects";
            // 
            // SelectWorkDir
            // 
            this.SelectWorkDir.Name = "SelectWorkDir";
            this.SelectWorkDir.Size = new System.Drawing.Size(221, 24);
            this.SelectWorkDir.Text = "Select Work Directory";
            this.SelectWorkDir.Click += new System.EventHandler(this.SelectWorkDir_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.SelectedPath = "C:\\";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageStatusLabel,
            this.toolStripSelectedImage,
            this.toolStripSelectedContainer});
            this.statusBar.Location = new System.Drawing.Point(0, 568);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1094, 25);
            this.statusBar.TabIndex = 3;
            this.statusBar.Text = "Status";
            // 
            // imageStatusLabel
            // 
            this.imageStatusLabel.Name = "imageStatusLabel";
            this.imageStatusLabel.Size = new System.Drawing.Size(57, 20);
            this.imageStatusLabel.Text = "Images";
            // 
            // toolStripSelectedImage
            // 
            this.toolStripSelectedImage.Name = "toolStripSelectedImage";
            this.toolStripSelectedImage.Size = new System.Drawing.Size(115, 20);
            this.toolStripSelectedImage.Text = "Selected Image:";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.Location = new System.Drawing.Point(1062, 31);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(28, 34);
            this.btnOpenFolder.TabIndex = 4;
            this.btnOpenFolder.Text = "...";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // txtWorkDirPath
            // 
            this.txtWorkDirPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkDirPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkDirPath.Location = new System.Drawing.Point(4, 34);
            this.txtWorkDirPath.Multiline = true;
            this.txtWorkDirPath.Name = "txtWorkDirPath";
            this.txtWorkDirPath.Size = new System.Drawing.Size(1052, 31);
            this.txtWorkDirPath.TabIndex = 5;
            this.txtWorkDirPath.Text = "D:\\Dev\\AppDemos\\aspdockerapi\\";
            // 
            // gridContainers
            // 
            this.gridContainers.AllowUserToAddRows = false;
            this.gridContainers.AllowUserToDeleteRows = false;
            this.gridContainers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridContainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContainers.Location = new System.Drawing.Point(11, 43);
            this.gridContainers.MultiSelect = false;
            this.gridContainers.Name = "gridContainers";
            this.gridContainers.ReadOnly = true;
            this.gridContainers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridContainers.Size = new System.Drawing.Size(1067, 313);
            this.gridContainers.TabIndex = 7;
            this.gridContainers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridContainers_MouseClick);
            // 
            // GridImages
            // 
            this.GridImages.AllowUserToAddRows = false;
            this.GridImages.AllowUserToDeleteRows = false;
            this.GridImages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridImages.Location = new System.Drawing.Point(15, 43);
            this.GridImages.MultiSelect = false;
            this.GridImages.Name = "GridImages";
            this.GridImages.ReadOnly = true;
            this.GridImages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridImages.Size = new System.Drawing.Size(748, 238);
            this.GridImages.TabIndex = 16;
            this.GridImages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridImages_MouseClick);
            // 
            // toolStripSelectedContainer
            // 
            this.toolStripSelectedContainer.Name = "toolStripSelectedContainer";
            this.toolStripSelectedContainer.Size = new System.Drawing.Size(151, 20);
            this.toolStripSelectedContainer.Text = "toolStripStatusLabel1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 593);
            this.Controls.Add(this.txtWorkDirPath);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DockerDesk";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabImages.ResumeLayout(false);
            this.tabImages.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabCOntainers.ResumeLayout(false);
            this.tabCOntainers.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContainers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabImages;
        private System.Windows.Forms.TabPage tabCOntainers;
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
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridContainers;
        private System.Windows.Forms.DataGridView GridImages;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSelectedContainer;
    }
}

