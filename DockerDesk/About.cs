using System;
using System.Windows.Forms;

namespace DockerDesk
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkToSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://gioking.github.io/DockerDeskSite/");
        }

        private void linkLocal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=shGNVBQFDPQ&ab_channel=GiokingdevGiokingdev");
        }

        private void linkRemote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=YkWeIECKWtU&ab_channel=GiokingdevGiokingdev");
        }

        private void linkToBuyMeaCoffe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.buymeacoffee.com/dockerdesk");
        }
    }
}
