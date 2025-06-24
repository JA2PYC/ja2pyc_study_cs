using System;
using System.Timers;
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
        private CameraSession _cameraSession;
        private CaptureContext _captureContext;

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
            //_cameraStrategy = cameraType switch
            //{
            //    CameraType.OpenCv => new OpenCv.OpenCvManager(),
            //    //CameraType.VisionPro => throw new NotImplementedException(),
            //    //CameraType.InSight => throw new NotImplementedException(),
            //    _ => throw new ArgumentException("Unsupported camera type.")
            //};
        }

        public bool ConnectCamera(int index)
        {
            bool success = _cameraStrategy.ConnectCamera(index);
            if (success)
            {
                _cameraSession = new CameraSession
                {
                    SessionId = index,
                    CameraStrategy = _cameraStrategy,
                    CameraType = _cameraStrategy.GetType().Name,
                    CameraIndex = index,
                    IsConnected = true,
                    LastConnectionTime = DateTime.Now
                };
            }
            return success;
        }
        public string GetCameraInfo() => _cameraStrategy.GetCameraInfo();

        public byte[] CaptureFrame() => _cameraStrategy.CaptureFrame();

        public void DisconnectCamera()
        {
            _cameraStrategy.DisconnectCamera();
            _cameraSession = null;
            StopLiveVideo();
        }

        public void StartLiveVideo()
        {
            if (_cameraSession == null || !_cameraSession.IsConnected)
            {
                throw new InvalidOperationException("Camera is not connected.");
            }

            //_captureContext = new CaptureContext
            //{
                //ActiveSession = _cameraSession,
                //StreamTimer = new Timer { Interval = 30 },
                //OnFreameCaptured = frame =>
                //{
                //    if (frame != null)
                //    {
                //        using var ms = new System.IO.MemoryStream(frame);
                //    }
                //}
            //}
        }

        public void StopLiveVideo()
        {
             
        }

        public CameraSession GetSession() => _cameraSession;
        public CaptureContext GetContext() => _captureContext;


    }
}
