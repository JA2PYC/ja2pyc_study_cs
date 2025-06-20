using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.Logging
{
    internal class UILogSink : ILogSink
    {
        private readonly ListBox _logListBox;
        public UILogSink(ListBox logListBox)
        {
            _logListBox = logListBox;
        }
        public void Log(string message)
        {
            _logListBox.Invoke((MethodInvoker)delegate
            {
                _logListBox.Items.Add($"[{DateTime.Now}] : {message}");
            });
        }
        public void Log(string message, Exception ex)
        {
            Log($"{message} - Exception: {ex.Message}");
        }
        public void Log(List<string> messages)
        {
            foreach (var message in messages)
            {
                Log(message);
            }
        }
        public void Log(List<string> messages, Exception ex)
        {
            foreach (var message in messages)
            {
                Log($"{message} - Exception: {ex.Message}");
            }
        }

    }
}
