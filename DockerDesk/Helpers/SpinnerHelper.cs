using System;
using System.Windows.Forms;

namespace DockerDesk.Helpers
{
    public static class SpinnerHelper
    {
        public static void ToggleSpinner(ProgressBar progressBar, bool show)
        {
            if (progressBar == null) return;

            progressBar.Invoke(new Action(() =>
            {
                progressBar.Visible = show;

                if (show)
                {
                    progressBar.Style = ProgressBarStyle.Marquee;
                    progressBar.MarqueeAnimationSpeed = 30;

                    // Forza l'aggiornamento dell'interfaccia utente
                    Application.DoEvents();
                }
                else
                {
                    progressBar.MarqueeAnimationSpeed = 0;
                }
            }));
        }
    }

}
