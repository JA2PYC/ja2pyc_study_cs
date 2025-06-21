using System;
using System.Collections.Generic;
using System.IO;
using WindowsFormsApp.Logging.Enums;

namespace WindowsFormsApp.Logging
{
    internal class FileLogSink : ILogSink
    {
        public enum LogType
        {
            System,
            UI,
            Camera,
            Etc
        }

        private readonly string _logType;
        private readonly string _logDirectory;
        private readonly string _logFilePath;

        public FileLogSink(LogType logType)
        {
            _logType = logType.ToString();
            string root = Path.Combine("Logs", _logType);
            _logDirectory = root;

            Directory.CreateDirectory(_logDirectory);

            string fileName = $"{DateTime.Now:yyyyMMdd}_{_logType}Log.log";
            _logFilePath = Path.Combine(_logDirectory, fileName);

            lock (_logFilePath)
            {
                if (!File.Exists(_logFilePath))
                    File.Create(_logFilePath).Dispose();
            }
        }

        // Log methods
        public void Log(string message, LogLevel logLevel)
        {
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}][{logLevel.ToString().ToUpper()}] {message}";

            using (var writer = new StreamWriter(_logFilePath, append: true))
            {
                writer.WriteLine(logMessage);
            }
            //File.AppendAllText(_logFilePath, logMessage + Environment.NewLine);

        }

        public void Log(string message, LogLevel logLevel, Exception ex)
        {
            Log($"{message} - Exception: {ex.Message}", logLevel);
        }

        public void Log(List<string> messages, LogLevel logLevel)
        {
            foreach (var message in messages)
            {
                Log(message, logLevel);
            }
        }


        public void Log(List<string> messages, LogLevel logLevel, Exception ex)
        {
            foreach (var message in messages)
            {
                Log($"{message} - Exception: {ex.Message}", logLevel);
            }
        }

        //private readonly ListBox _logListBox;
        //public UILogSink(ListBox logListBox)
        //{
        //    _logListBox = logListBox;
        //}
        //public void Log(string message)
        //{
        //    _logListBox.Invoke((MethodInvoker)delegate
        //    {
        //        _logListBox.Items.Add($"[{DateTime.Now}] : {message}");
        //    });
        //}


        //public void Log(string message, Exception ex)
        //{
        //    Log($"{message} - Exception: {ex.Message}");
        //}

        //public void Log(List<string> messages)
        //{
        //    foreach (var message in messages)
        //    {
        //        Log(message);
        //    }
        //}
        //public void Log(List<string> messages, Exception ex)
        //{
        //    foreach (var message in messages)
        //    {
        //        Log($"{message} - Exception: {ex.Message}");
        //    }
        //}

    }
}
