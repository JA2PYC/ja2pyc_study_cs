using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Logging
{
    internal interface ILogSink
    {
        void Log(string message);
        void Log(string message, Exception ex);
        void Log(List<string> messages);
        void Log(List<string> messages, Exception ex);

    }
}
