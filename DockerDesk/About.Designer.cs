namespace DockerDesk
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLocal = new System.Windows.Forms.LinkLabel();
            this.linkRemote = new System.Windows.Forms.LinkLabel();
            this.linkToSite = new System.Windows.Forms.LinkLabel();
            this.linkToBuyMeaCoffe = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DockerDesk beta version 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "This program help you to containerize visual studio applications.";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(370, 255);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 40);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // linkLocal
            // 
            this.linkLocal.AutoSize = true;
            this.linkLocal.Location = new System.Drawing.Point(42, 156);
            this.linkLocal.Name = "linkLocal";
            this.linkLocal.Size = new System.Drawing.Size(124, 13);
            this.linkLocal.TabIndex = 4;
            this.linkLocal.TabStop = true;
            this.linkLocal.Text = "See Local Session video";
            this.linkLocal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLocal_LinkClicked);
            // 
            // linkRemote
            // 
            this.linkRemote.AutoSize = true;
            this.linkRemote.Location = new System.Drawing.Point(42, 186);
            this.linkRemote.Name = "linkRemote";
            this.linkRemote.Size = new System.Drawing.Size(135, 13);
            this.linkRemote.TabIndex = 5;
            this.linkRemote.TabStop = true;
            this.linkRemote.Text = "See Remote Session video";
            this.linkRemote.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRemote_LinkClicked);
            // 
            // linkToSite
            // 
            this.linkToSite.AutoSize = true;
            this.linkToSite.Location = new System.Drawing.Point(42, 126);
            this.linkToSite.Name = "linkToSite";
            this.linkToSite.Size = new System.Drawing.Size(117, 13);
            this.linkToSite.TabIndex = 6;
            this.linkToSite.TabStop = true;
            this.linkToSite.Text = "Visit DockerDesk Page";
            this.linkToSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToSite_LinkClicked);
            // 
            // linkToBuyMeaCoffe
            // 
            this.linkToBuyMeaCoffe.AutoSize = true;
            this.linkToBuyMeaCoffe.Location = new System.Drawing.Point(42, 216);
            this.linkToBuyMeaCoffe.Name = "linkToBuyMeaCoffe";
            this.linkToBuyMeaCoffe.Size = new System.Drawing.Size(107, 13);
            this.linkToBuyMeaCoffe.TabIndex = 7;
            this.linkToBuyMeaCoffe.TabStop = true;
            this.linkToBuyMeaCoffe.Text = "Buy me a Coffe Page";
            this.linkToBuyMeaCoffe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToBuyMeaCoffe_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 311);
            this.Controls.Add(this.linkToBuyMeaCoffe);
            this.Controls.Add(this.linkToSite);
            this.Controls.Add(this.linkRemote);
            this.Controls.Add(this.linkLocal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "About";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Author F.G.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLocal;
        private System.Windows.Forms.LinkLabel linkRemote;
        private System.Windows.Forms.LinkLabel linkToSite;
        private System.Windows.Forms.LinkLabel linkToBuyMeaCoffe;
    }
}