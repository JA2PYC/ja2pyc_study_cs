using System;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp.Interop;
using WindowsFormsApp.UI; // Ensure you have the correct namespace for your form

namespace WindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Check if the application is running on a compatible platform and version
            if (Environment.OSVersion.Platform != PlatformID.Win32NT)
            {
                MessageBox.Show("This application can only run on Windows NT platforms.", "Platform Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the OS version is at least Windows Vista (6.0)
            if (Environment.OSVersion.Version.Major < 6)
            {
                MessageBox.Show("This application requires Windows Vista or later.", "Version Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the application is already running
            bool createdNew;
            using (Mutex mutex = new Mutex(true, "Global\\WFApp", out createdNew))
            {
                if (!createdNew)
                {
                    MessageBox.Show("An instance of this application is already running.", "Application Running", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            //if (User32.FindWindow(null, "Frm Main Load Test") != IntPtr.Zero)
            //{
            //    MessageBox.Show("The application is already running.", "Application Running", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Application.Exit();
            //    return;
            //}

            // Initialize the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());

        }
    }
}
