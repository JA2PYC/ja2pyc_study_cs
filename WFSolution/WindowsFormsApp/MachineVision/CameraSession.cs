using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.MachineVision
{
    internal class CameraSession
    {
        public int SessionId { get; set; }
        public string SessionName { get; set; }
        public ICameraStrategy CameraStrategy { get; set; }
        public string CameraType { get; set; }
        public int CameraIndex { get; set; }
        public string CameraName { get; set; }
        public string CameraInfo { get; set; }
        public int FrameWidth { get; set; }
        public int FrameHeight { get; set; }
        public int FrameRate { get; set; }
        public string Resolution => $"{FrameWidth}x{FrameHeight}";
        public bool IsConnected { get; set; }
        public DateTime LastConnectionTime { get; set; }
        public byte[] LastCapturedFrame { get; set; }
        public DateTime LastCaptureTime { get; set; }

    }
}
