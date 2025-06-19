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

    }
}
