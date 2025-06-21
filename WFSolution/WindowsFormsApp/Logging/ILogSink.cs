using System;
using System.Collections.Generic;
using WindowsFormsApp.Logging.Enums;

namespace WindowsFormsApp.Logging
{
    internal interface ILogSink
    {
        void Log(string message, LogLevel loglevel);
        void Log(string message, LogLevel loglevel, Exception ex);
        void Log(List<string> messages, LogLevel loglevel);
        void Log(List<string> messages, LogLevel loglevel, Exception ex);

    }
}
