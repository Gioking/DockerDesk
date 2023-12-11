using System;
using System.IO;
using System.Windows.Forms;

namespace DockerDesk
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }
        private void frmHelp_Load(object sender, EventArgs e)
        {
            string pathToFile = Path.Combine(Application.StartupPath, "help.html");
            browserHelp.Navigate(pathToFile);

        }
    }
}
