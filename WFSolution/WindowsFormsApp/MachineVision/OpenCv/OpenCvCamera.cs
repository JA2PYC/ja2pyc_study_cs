using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenCvSharp;

namespace WindowsFormsApp.MachineVision.OpenCv
{
    internal class OpenCvCamera
    {
        private VideoCapture _capture;

        public OpenCvCamera(int cameraIndex = 0)
        {
            _capture = new VideoCapture(cameraIndex);
            if (!_capture.IsOpened())
            {
                throw new Exception("Could not open video capture device.");
            }
        }


        public static List<int> GetConnectedCameras(int maxCamera = 10)
        {
            List<int> cameraIndexes = new List<int>();

            for (int i = 0; i < maxCamera; i++ )
            {
                using (VideoCapture capture = new VideoCapture(i))
                {
                    if (capture.IsOpened())
                    {
                        cameraIndexes.Add(i);
                        Console.WriteLine($"Camera {i} is connected.");
                    }
                }
            }

            return cameraIndexes;
        }

        public Mat CaptureFrame()
        {
            Mat frame = new Mat();
            _capture.Read(frame);
            if (frame.Empty())
            {
                throw new Exception("Captured frame is empty.");
            }
            return frame;
        }
        public void Release()
        {
            _capture.Release();
        }

        public bool ConnectCamera(int cameraIndex)
        {
            if (_capture.IsOpened())
            {
                _capture.Release();
            }
            _capture = new VideoCapture(cameraIndex);
            return _capture.IsOpened();
        }


    }
}
