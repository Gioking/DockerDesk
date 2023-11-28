using System;
using System.Windows.Forms;

namespace DockerDesk
{
    public partial class frmMDIParent : Form
    {
        private int childFormNumber = 0;

        public frmMDIParent()
        {
            InitializeComponent();
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocal childForm = new frmLocal();
            childForm.MdiParent = this;
            childForm.Show();
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void remoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemote childForm = new frmRemote();
            childForm.MdiParent = this;
            childForm.Show();
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuOpenLocal_Click(object sender, EventArgs e)
        {
            frmLocal childForm = new frmLocal();
            childForm.MdiParent = this;
            childForm.Show();
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuOpenRemote_Click(object sender, EventArgs e)
        {
            frmRemote childForm = new frmRemote();
            childForm.MdiParent = this;
            childForm.Show();
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


    }
}
