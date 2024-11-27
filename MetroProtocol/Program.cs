using Converx.FRM.MainMenu;
using System;
using System.Windows.Forms;

namespace MetroProtocol
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Fix for blurry 
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();
            //SetProcessDpiAwarenessContext();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());  
            Application.Run(new MainForm());
        }

        // Fix for blurry forms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        // Fix for blurry forms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDpiAwarenessContext();

    }
}
