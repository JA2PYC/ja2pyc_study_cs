// OpenCvSharp Libraries
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp.MachineVision.OpenCv
{
    internal class OpenCvManager : ICameraStrategy
    {
        private VideoCapture _currentCamera;

        public List<int> GetConnectedCameras()
        {
            return OpenCvCamera.GetConnectedCameras();
        }

        public bool OpenCamera(int index, int width = 640, int height = 480)
        {
            _currentCamera = OpenCvCamera.ConnectCamera(index);
            if (_currentCamera != null && _currentCamera.IsOpened())
            {
                OpenCvUtilities.SetResolution(_currentCamera, width, height);
                return true;
            }
            return false;
        }

        public Mat CaptureStillImage()
        {
            if (_currentCamera == null || !_currentCamera.IsOpened())
            {
                throw new InvalidOperationException("Camera is not opened.");
            }
            Mat frame = OpenCvCapture.CaptureFrame(_currentCamera);
            return frame;

        }

        public string GetCurrentCameraInfo()
        {
            if (_currentCamera == null || !_currentCamera.IsOpened())
            {
                throw new InvalidOperationException("Camera is not opened.");
            }
            return OpenCvUtilities.GetCameraInfo(_currentCamera);
        }

        public void CloseCamera()
        {
            OpenCvCamera.ReleaseCamera(_currentCamera);
            _currentCamera = null;
        }

        public bool IsCameraOpen()
        {
            return _currentCamera != null && _currentCamera.IsOpened();
        }

        //private readonly OpenCvCamera _camera;
        //private readonly OpenCvDisplay _display;

        //public OpenCvManager(PictureBox pictureBox)
        //{
        //    _camera = new OpenCvCamera();
        //    _display = new OpenCvDisplay(pictureBox);
        //}

        //public List<int> GetConnectedCameras()
        //{
        //    return OpenCvCamera.GetConnectedCameras();
        //}

        //public bool ConnectCamera(int cameraIndex)
        //{
        //    return _camera.ConnectCamera(cameraIndex);
        //}

        //public void ShowLiveVideo(Timer timer)
        //{
        //    timer.Interval = 30;
        //    timer.Tick += (sender, e) =>
        //    {
        //        Mat frame = _camera.CaptureFrame();
        //        _display.ShowImage(frame);
        //    };
        //    timer.Start();
        //}

        //public void StopLiveVideo(Timer timer)
        //{
        //    timer.Stop();
        //    _camera.Release();
        //}
    }
}
