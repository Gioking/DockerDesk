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
            this.tabCOntainers = new System.Windows.Forms.TabPage();
            this.tabVolume = new System.Windows.Forms.TabPage();
            this.tabNetwork = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.imageStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.listViewImages = new System.Windows.Forms.ListView();
            this.btnRunContainer = new System.Windows.Forms.Button();
            this.Image = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabImages.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabImages);
            this.tabControl1.Controls.Add(this.tabCOntainers);
            this.tabControl1.Controls.Add(this.tabVolume);
            this.tabControl1.Controls.Add(this.tabNetwork);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1094, 541);
            this.tabControl1.TabIndex = 0;
            // 
            // tabImages
            // 
            this.tabImages.Controls.Add(this.btnRunContainer);
            this.tabImages.Controls.Add(this.listViewImages);
            this.tabImages.Controls.Add(this.statusStrip1);
            this.tabImages.Controls.Add(this.statusBar);
            this.tabImages.Controls.Add(this.label1);
            this.tabImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabImages.Location = new System.Drawing.Point(4, 29);
            this.tabImages.Name = "tabImages";
            this.tabImages.Padding = new System.Windows.Forms.Padding(3);
            this.tabImages.Size = new System.Drawing.Size(1086, 508);
            this.tabImages.TabIndex = 0;
            this.tabImages.Text = "Images";
            this.tabImages.UseVisualStyleBackColor = true;
            // 
            // tabCOntainers
            // 
            this.tabCOntainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabCOntainers.Location = new System.Drawing.Point(4, 29);
            this.tabCOntainers.Name = "tabCOntainers";
            this.tabCOntainers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCOntainers.Size = new System.Drawing.Size(1086, 508);
            this.tabCOntainers.TabIndex = 1;
            this.tabCOntainers.Text = "Containers";
            this.tabCOntainers.UseVisualStyleBackColor = true;
            // 
            // tabVolume
            // 
            this.tabVolume.Location = new System.Drawing.Point(4, 29);
            this.tabVolume.Name = "tabVolume";
            this.tabVolume.Size = new System.Drawing.Size(1062, 484);
            this.tabVolume.TabIndex = 2;
            this.tabVolume.Text = "Volume";
            this.tabVolume.UseVisualStyleBackColor = true;
            // 
            // tabNetwork
            // 
            this.tabNetwork.Location = new System.Drawing.Point(4, 29);
            this.tabNetwork.Name = "tabNetwork";
            this.tabNetwork.Size = new System.Drawing.Size(1062, 484);
            this.tabNetwork.TabIndex = 3;
            this.tabNetwork.Text = "Netword";
            this.tabNetwork.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Docker Images";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(3, 480);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1080, 25);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "Status";
            // 
            // imageStatusLabel
            // 
            this.imageStatusLabel.Name = "imageStatusLabel";
            this.imageStatusLabel.Size = new System.Drawing.Size(57, 20);
            this.imageStatusLabel.Text = "Images";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1080, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // listViewImages
            // 
            this.listViewImages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Image,
            this.Tag,
            this.ImageId,
            this.Created,
            this.Size});
            this.listViewImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.listViewImages.FullRowSelect = true;
            this.listViewImages.HideSelection = false;
            this.listViewImages.Location = new System.Drawing.Point(11, 41);
            this.listViewImages.MultiSelect = false;
            this.listViewImages.Name = "listViewImages";
            this.listViewImages.Size = new System.Drawing.Size(1067, 322);
            this.listViewImages.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewImages.TabIndex = 4;
            this.listViewImages.UseCompatibleStateImageBehavior = false;
            this.listViewImages.SelectedIndexChanged += new System.EventHandler(this.listViewImages_SelectedIndexChanged);
            // 
            // btnRunContainer
            // 
            this.btnRunContainer.Location = new System.Drawing.Point(11, 369);
            this.btnRunContainer.Name = "btnRunContainer";
            this.btnRunContainer.Size = new System.Drawing.Size(147, 35);
            this.btnRunContainer.TabIndex = 5;
            this.btnRunContainer.Text = "Run Countainer";
            this.btnRunContainer.UseVisualStyleBackColor = true;
            this.btnRunContainer.Click += new System.EventHandler(this.btnRunContainer_Click);
            // 
            // Image
            // 
            this.Image.Text = "Image";
            // 
            // Tag
            // 
            this.Tag.Text = "Tag";
            // 
            // ImageId
            // 
            this.ImageId.Text = "Image id";
            // 
            // Created
            // 
            this.Created.Text = "Created on";
            // 
            // Size
            // 
            this.Size.Text = "Size";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 541);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DockerDesk";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabImages.ResumeLayout(false);
            this.tabImages.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabImages;
        private System.Windows.Forms.TabPage tabCOntainers;
        private System.Windows.Forms.TabPage tabVolume;
        private System.Windows.Forms.TabPage tabNetwork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel imageStatusLabel;
        private System.Windows.Forms.ListView listViewImages;
        private System.Windows.Forms.Button btnRunContainer;
        private System.Windows.Forms.ColumnHeader Image;
        private System.Windows.Forms.ColumnHeader Tag;
        private System.Windows.Forms.ColumnHeader ImageId;
        private System.Windows.Forms.ColumnHeader Created;
        private System.Windows.Forms.ColumnHeader Size;
    }
}

