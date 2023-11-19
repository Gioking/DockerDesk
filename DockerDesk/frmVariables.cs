using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerDesk
{
    public partial class frmVariables : Form
    {
        public frmVariables()
        {
            InitializeComponent();
        }

        private void frmVariables_Load(object sender, EventArgs e)
        {
            string pathToFile = Path.Combine(Application.StartupPath, "jeditor.html");
            webBrowseVariables.Navigate(pathToFile);
        }
    }
}
