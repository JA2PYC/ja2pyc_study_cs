using System;
using System.Threading;
using Timer = System.Timers.Timer;

namespace WindowsFormsApp.MachineVision
{
    internal class CaptureContext
    {
        public CameraSession ActiveSession { get; set; }
        public Timer StreamTimer { get; set; }
        public CancellationTokenSource CancellationTokenSource { get; set; }
        public Action<byte[]> OnFrameCaptured { get; set; }

        public CaptureContext()
        {
            ActiveSession = new CameraSession();
            StreamTimer = new Timer();
            CancellationTokenSource = new CancellationTokenSource();
            OnFrameCaptured = null;
        }
    }
}
