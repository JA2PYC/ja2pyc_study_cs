using System;
using System.Windows.Forms;

namespace WindowsFormsApp.UI.UIHandler
{
    internal static class ButtonHandler
    {
        public static void AddLogToListBox(ListBox logListBox, string message)
        {
            try
            {
                if (string.IsNullOrEmpty(message))
                {
                    throw new ArgumentException("Message cannot be null or empty.", nameof(message));
                }

                if (logListBox == null)
                {
                    throw new ArgumentNullException(nameof(logListBox), "Log ListBox cannot be null.");
                }


                if (logListBox.InvokeRequired)
                {
                    logListBox.Invoke(new Action(() => logListBox.Items.Add($"[{DateTime.Now}] : {message}")));
                }
                else
                {
                    logListBox.Items.Add(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding message to log: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Toggle the process state and update UI elements accordingly
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
