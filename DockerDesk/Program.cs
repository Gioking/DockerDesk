using System;
using System.Windows.Forms;

namespace DockerDesk
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMDIParent());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Main() error: {ex.Message}");
            }

        }
    }
}
