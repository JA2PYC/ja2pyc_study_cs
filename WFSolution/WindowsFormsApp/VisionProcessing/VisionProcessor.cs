using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp.VisionProcessing
{
    internal class VisionProcessor
    {
        private Thread _workerThread;
        private bool _isRunning = false;

        public void StartProcessing()
        {
            if (_isRunning) return;

            _isRunning = true;
            _workerThread = new Thread(ProcessInspection);

        }

        public void StopProcessing()
        {
            if (!_isRunning) return;

            if (_workerThread != null && _workerThread.IsAlive)
            {
                _workerThread.Join();
                _isRunning = false;
                _workerThread = null;
            }
        }


        private void ProcessInspection()
        {
            while (_isRunning)
            {
                Debug.WriteLine(_isRunning ? "Processing..." : "Not processing.");

                Thread.Sleep(1000);
            }
        }

    }
}
