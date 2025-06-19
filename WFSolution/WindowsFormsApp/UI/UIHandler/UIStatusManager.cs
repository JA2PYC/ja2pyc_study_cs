using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.UI.UIHandler
{
    internal class UIStatusManager
    {
        private readonly Label _statusLabel;
        private readonly ProgressBar _progressBar;

        public UIStatusManager(Label _statusLabel, ProgressBar _progressBar)
        {
            this._statusLabel = _statusLabel ?? throw new ArgumentNullException(nameof(_statusLabel), "Status label cannot be null.");
            this._progressBar = _progressBar ?? throw new ArgumentNullException(nameof(_progressBar), "Progress bar cannot be null.");
        }

        public void UpdateStatus(string message, int progressValue)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentException("Status message cannot be null or empty.", nameof(message));
            }
            if (progressValue < 0 || progressValue > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(progressValue), "Progress value must be between 0 and 100.");
            }
            if (_statusLabel.InvokeRequired)
            {
                _statusLabel.Invoke(new Action(() => UpdateStatus(message, progressValue)));
            }
            else
            {
                _statusLabel.Text = message;
                _progressBar.Value = progressValue;
            }
        }

        public void ResetStatus()
        {
            if (_statusLabel.InvokeRequired)
            {
                _statusLabel.Invoke(new Action(ResetStatus));
            }
            else
            {
                _statusLabel.Text = "Ready";
                _progressBar.Value = 0;
            }
        }
    }
}
