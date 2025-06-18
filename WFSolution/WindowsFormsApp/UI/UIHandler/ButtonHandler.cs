using System;
using System.Windows.Forms;

namespace WindowsFormsApp.UI.UIHandler
{
    internal static class ButtonHandler
    {
        public static void ToggleProcess(Label label, ref bool isRunning, ProgressBar progressBar, ListBox processLog, PictureBox mainCamera)
        {
            if (isRunning)
            {
                // Stop the process
                label.Text = "Process Stopped";
                isRunning = false;
                progressBar.Value = 0;
                processLog.Items.Add("Process stopped at " + DateTime.Now);
                mainCamera.Image = null; // Clear the camera image
            }
            else
            {
                // Start the process
                label.Text = "Process Running";
                isRunning = true;
                progressBar.Value = 100; // Simulate full progress for demo
                processLog.Items.Add("Process started at " + DateTime.Now);
                // Here you would typically start the camera feed or processing logic
            }
        }
    }
}
