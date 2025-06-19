using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.UI.UIHandler
{
    internal class LogManager
    {
        private readonly ListBox _logListBox;

        public LogManager(ListBox logListBox)
        {
            this._logListBox = logListBox ?? throw new ArgumentNullException(nameof(logListBox), "Log ListBox cannot be null.");
        }

        public void AddLog(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentException("Message cannot be null or empty.", nameof(message));
            }
            if (_logListBox.InvokeRequired)
            {
                _logListBox.Invoke(new Action(() => _logListBox.Items.Add($"[{DateTime.Now}] : {message}")));
            }
            else
            {
                _logListBox.Items.Add($"[{DateTime.Now}] : {message}");
            }
        }

        public void AddLog(List<string> message)
        {
            if (message == null || message.Count == 0)
            {
                throw new ArgumentException("Message list cannot be null or empty.", nameof(message));
            }
            if (_logListBox.InvokeRequired)
            {
                _logListBox.Invoke(new Action(() => 
                {
                    foreach (var msg in message)
                    {
                        _logListBox.Items.Add($"[{DateTime.Now}] : {msg}");
                    }
                }));
            }
            else
            {
                foreach (var msg in message)
                {
                    _logListBox.Items.Add($"[{DateTime.Now}] : {msg}");
                }
            }
        }


        public void AddLog(string message, bool isError)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentException("Message cannot be null or empty.", nameof(message));
            }
            if (_logListBox.InvokeRequired)
            {
                _logListBox.Invoke(new Action(() => _logListBox.Items.Add($"[{DateTime.Now}] : {(isError ? "ERROR: " : "")}{message}")));
            }
            else
            {
                _logListBox.Items.Add($"[{DateTime.Now}] : {(isError ? "ERROR: " : "")}{message}");
            }
        }

        public void ClearLogs()
        {
            if (_logListBox.InvokeRequired)
            {
                _logListBox.Invoke(new Action(ClearLogs));
            }
            else
            {
                _logListBox.Items.Clear();
            }
        }

    }
}
