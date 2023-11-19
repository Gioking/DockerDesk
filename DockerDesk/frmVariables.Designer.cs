namespace DockerDesk
{
    partial class frmVariables
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
            this.webBrowseVariables = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowseVariables
            // 
            this.webBrowseVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowseVariables.Location = new System.Drawing.Point(0, 0);
            this.webBrowseVariables.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowseVariables.Name = "webBrowseVariables";
            this.webBrowseVariables.Size = new System.Drawing.Size(1103, 648);
            this.webBrowseVariables.TabIndex = 0;
            // 
            // frmVariables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 648);
            this.Controls.Add(this.webBrowseVariables);
            this.Name = "frmVariables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVariables";
            this.Load += new System.EventHandler(this.frmVariables_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowseVariables;
    }
}