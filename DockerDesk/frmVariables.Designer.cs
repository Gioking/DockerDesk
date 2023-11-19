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
            this.richVariables = new System.Windows.Forms.RichTextBox();
            this.btnSaveVariables = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richVariables
            // 
            this.richVariables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.richVariables.Location = new System.Drawing.Point(12, 12);
            this.richVariables.Name = "richVariables";
            this.richVariables.Size = new System.Drawing.Size(1079, 572);
            this.richVariables.TabIndex = 0;
            this.richVariables.Text = "";
            // 
            // btnSaveVariables
            // 
            this.btnSaveVariables.Location = new System.Drawing.Point(12, 601);
            this.btnSaveVariables.Name = "btnSaveVariables";
            this.btnSaveVariables.Size = new System.Drawing.Size(122, 35);
            this.btnSaveVariables.TabIndex = 1;
            this.btnSaveVariables.Text = "Save";
            this.btnSaveVariables.UseVisualStyleBackColor = true;
            this.btnSaveVariables.Click += new System.EventHandler(this.btnSaveVariables_Click);
            // 
            // frmVariables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 648);
            this.Controls.Add(this.btnSaveVariables);
            this.Controls.Add(this.richVariables);
            this.Name = "frmVariables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Containers Variables";
            this.Load += new System.EventHandler(this.frmVariables_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richVariables;
        private System.Windows.Forms.Button btnSaveVariables;
    }
}