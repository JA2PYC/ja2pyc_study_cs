using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.MachineVision.OpenCv;

namespace WindowsFormsApp.MachineVision
{
    public enum CameraType
    {
        OpenCv,
        //VisionPro,
        //InSight
    }

    internal class CameraManager
    {
        private ICameraStrategy _cameraStrategy;




        public void SetCameraType(CameraType cameraType)
        {
            switch (cameraType)
            {
                case CameraType.OpenCv:
                    _cameraStrategy = new OpenCvManager();
                    break;
                //case CameraType.VisionPro:
                //    _cameraStrategy = new VisionProcessing.VisionProManager();
                //    break;
                //case CameraType.InSight:
                //    _cameraStrategy = new InSight.InSightManager();
                //    break;
                default:
                    throw new NotSupportedException("Unsupported camera type.");
            }
        }
        //public void SetMode(CameraType cameraType)
        //{
        //    _cameraStrategy = cameraType switch
        //    {
        //        CameraType.OpenCv => new OpenCv.OpenCvManager(),
        //        //CameraType.VisionPro => throw new NotImplementedException(),
        //        //CameraType.InSight => throw new NotImplementedException(),
        //        _ => throw new ArgumentException("Unsupported camera type.")
        //    };
        //}

        public bool ConnectCamera(int index) => _cameraStrategy.ConnectCamera(index);
        public string GetCameraInfo() => _cameraStrategy.GetCameraInfo();

        public byte[] CaptureFrame() => _cameraStrategy.CaptureFrame();

        public void DisconnectCamera() => _cameraStrategy.DisconnectCamera();


    }
}
