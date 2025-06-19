using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.UI.UIHandler
{
    internal class UILogManager
    {
        private readonly ListBox _mainListBox;
        private readonly ListBox _logListBox;

        public UILogManager(ListBox logListBox, ListBox _mainListBox)
        {
            this._mainListBox = _mainListBox ?? throw new ArgumentNullException(nameof(_mainListBox), "Main ListBox cannot be null.");
            this._logListBox = logListBox ?? throw new ArgumentNullException(nameof(logListBox), "Log ListBox cannot be null.");
        }

        public void AddMainLog(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentException("Message cannot be null or empty.", nameof(message));
            }
            if (_mainListBox.InvokeRequired)
            {
                _mainListBox.Invoke(new Action(() => _mainListBox.Items.Add($"[{DateTime.Now}] : {message}")));
            }
            else
            {
                _mainListBox.Items.Add($"[{DateTime.Now}] : {message}");
            }
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
