using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.UI.UIHandler
{
    internal class UIEventHandler
    {
        private readonly StatusManager _statusManager;
        private readonly LogManager _logManager;

        public UIEventHandler(Label statusLabel, ProgressBar progressBar, ListBox logListBox)
        {
            _statusManager = new StatusManager(statusLabel, progressBar);
            _logManager = new LogManager(logListBox);
        }


        // Method to update the status label and progress bar
        public void UpdateStatusUI(string message, int progressValue)
        {
            try
            {
                _statusManager.UpdateStatusUI(message, progressValue);
            }
            catch (Exception ex)
            {
                _logManager.AddLog($"Error updating status: {ex.Message}");
            }
        }

        public void UpdateStatusUI(string message)
        {
            try
            {
                _statusManager.UpdateStatusUI(message);
            }
            catch (Exception ex)
            {
                _logManager.AddLog($"Error updating status: {ex.Message}");
            }
        }

        public void UpdateStatusUI(int progressValue)
        {
            try
            {
                _statusManager.UpdateStatusUI(progressValue);
            }
            catch (Exception ex)
            {
                _logManager.AddLog($"Error updating status: {ex.Message}");
            }
        }

        public void ResetStatusUI()
        {
            try
            {
                _statusManager.ResetStatusUI();
            }
            catch (Exception ex)
            {
                _logManager.AddLog($"Error resetting status: {ex.Message}");
            }
        }

        public void ResetProgressBar()
        {
            try
            {
                _statusManager.ResetProgressBar();
            }
            catch (Exception ex)
            {
                _logManager.AddLog($"Error resetting progress bar: {ex.Message}");
            }
        }
    }
}
