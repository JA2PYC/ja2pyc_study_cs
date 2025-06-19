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
        private readonly UIStatusManager _statusManager;
        private readonly UILogManager _logManager;

        public UIEventHandler(Label statusLabel, ProgressBar progressBar, ListBox mainListBox, ListBox logListBox)
        {
            _statusManager = new UIStatusManager(statusLabel, progressBar);
            _logManager = new UILogManager(logListBox, mainListBox);
        }

        public void UpdateStatus(string message, int progressValue)
        {
            try
            {
                _statusManager.UpdateStatus(message, progressValue);
            }
            catch (Exception ex)
            {
                _logManager.AddLog($"Error updating status: {ex.Message}");
            }
        }

        public void ResetStatus()
        {
            try
            {
                _statusManager.ResetStatus();
            }
            catch (Exception ex)
            {
                _logManager.AddLog($"Error resetting status: {ex.Message}");
            }
        }

        public void OnButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (sender is Button button)
                {
                    _logManager.AddLog($"Button clicked: {button.Text}");
                    // Additional logic for button click can be added here
                }
            }
            catch (Exception ex)
            {
                _logManager.AddLog($"Error handling button click: {ex.Message}");
            }
        }
    }
}
