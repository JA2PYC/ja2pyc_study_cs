using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// OpenCvSharp Libraries
using OpenCvSharp;
using OpenCvSharp.Extensions;


namespace WindowsFormsApp.MachineVision.OpenCv
{
    internal class OpenCvManager
    {
        private OpenCvCamera _camera;
        private OpenCvDisplay _display;

        public OpenCvManager(PictureBox pictureBox)
        {
            _camera = new OpenCvCamera();
            _display = new OpenCvDisplay(pictureBox);
        }
        
        public List<int> GetConnectedCameras()
        {
            return OpenCvCamera.GetConnectedCameras();
        }

        public bool ConnectCamera(int cameraIndex)
        {
            return _camera.ConnectCamera(cameraIndex);
        }

        public void ShowLiveVideo(Timer timer)
        {
            timer.Interval = 30;
            timer.Tick += (sender, e) =>
            {
                Mat frame = _camera.CaptureFrame();
                _display.ShowImage(frame);
            };
            timer.Start();
        }

        public void StopLiveVideo(Timer timer)
        {
            timer.Stop();
            _camera.Release();
        }
    }
}
