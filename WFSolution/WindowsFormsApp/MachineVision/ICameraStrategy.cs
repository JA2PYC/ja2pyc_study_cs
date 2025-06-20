using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.MachineVision
{
    internal interface ICameraStrategy
    {
        bool ConnectCamera(int cameraIndex);
        string GetCameraInfo();
        byte[] CaptureFrame();
        void DisconnectCamera();
    }
}
