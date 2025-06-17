using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Utils
{
    internal class Logger
    {
        private static readonly string logPath = "log.txt";

        public static void WriteLog(string message)
        {
            try
            {
                //File.AppendAllText(logPath, $"{DateTime.Now} : {message} \n");
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(logPath, true))
                {
                    writer.WriteLine($"[{DateTime.Now}] {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to write log: {ex.Message}");
            }
        }
        public static void Log(string message)
        {
            // Here you can implement your logging logic, e.g., write to a file or console
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }
        public static void LogError(string message)
        {
            // Here you can implement your error logging logic, e.g., write to a file or console
            Console.WriteLine($"[ERROR] [{DateTime.Now}] {message}");
        }
    }
}
