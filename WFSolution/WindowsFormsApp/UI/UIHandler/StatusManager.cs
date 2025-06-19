using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp.UI.UIHandler
{
    internal class StatusManager
    {
        private readonly Label _statusLabel;
        private readonly ProgressBar _progressBar;
        private readonly Timer resetProgressBarTimer;

        public StatusManager(Label _statusLabel, ProgressBar _progressBar)
        {
            this._statusLabel = _statusLabel ?? throw new ArgumentNullException(nameof(_statusLabel), "Status label cannot be null.");
            this._progressBar = _progressBar ?? throw new ArgumentNullException(nameof(_progressBar), "Progress bar cannot be null.");
            this.resetProgressBarTimer = new Timer();
        }

        // Methods to update the status label and progress bar
        public void UpdateStatusUI(string message, int progressValue)
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
                _statusLabel.Invoke(new Action(() => UpdateStatusUI(message, progressValue)));
            }
            else
            {
                _statusLabel.Text = message;
                _progressBar.Value = progressValue;
                ResetProgressBar(3);
            }
        }

        public void UpdateStatusUI(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentException("Status message cannot be null or empty.", nameof(message));
            }
            if (_statusLabel.InvokeRequired)
            {
                _statusLabel.Invoke(new Action(() => UpdateStatusUI(message)));
            }
            else
            {
                _statusLabel.Text = message;
            }
        }

        public void UpdateStatusUI(int progressValue)
        {
            if (progressValue < 0 || progressValue > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(progressValue), "Progress value must be between 0 and 100.");
            }
            if (_progressBar.InvokeRequired)
            {
                _progressBar.Invoke(new Action(() => UpdateStatusUI(progressValue)));
            }
            else
            {
                _progressBar.Value = progressValue;
                ResetProgressBar(3);
            }
        }

        // Method to reset the status label and progress bar
        public void ResetStatusUI()
        {
            if (_statusLabel.InvokeRequired)
            {
                _statusLabel.Invoke(new Action(ResetStatusUI));
            }
            else
            {
                _statusLabel.Text = "Ready";
                _progressBar.Value = 0;
            }
        }

        public void ResetStatusLabel()
        {
            if (_statusLabel.InvokeRequired)
            {
                _statusLabel.Invoke(new Action(ResetStatusLabel));
            }
            else
            {
                _statusLabel.Text = "Ready";
            }
        }

        public void ResetProgressBar()
        {
            if (_progressBar.InvokeRequired)
            {
                _progressBar.Invoke(new Action(ResetProgressBar));
            }
            else
            {
                _progressBar.Value = 0;
            }
        }

        // Reset the progress bar after specific seconds
        public void ResetProgressBar(int delayInSeconds)
        {

            if (delayInSeconds < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(delayInSeconds), "Delay must be a non-negative integer.");
            }

            if (_progressBar.InvokeRequired)
            {
                _progressBar.Invoke(new Action(() => ResetProgressBar(delayInSeconds)));
            }
            else
            {
                if (resetProgressBarTimer.Enabled)
                {
                    resetProgressBarTimer.Stop();
                    resetProgressBarTimer.Dispose();
                }
                resetProgressBarTimer.Interval = delayInSeconds * 1000;
                resetProgressBarTimer.Tick += (s, e) =>
                {
                    resetProgressBarTimer.Stop();    // 타이머 반복 방지
                    resetProgressBarTimer.Dispose();
                    _progressBar.Value = 0;
                };
                resetProgressBarTimer.Start();
            }

        }
    }
}
