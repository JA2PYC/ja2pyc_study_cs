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

            for (int i = 0; i < maxCamera; i++)
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

        public static VideoCapture ConnectCamera(int cameraIndex)
        {
            VideoCapture capture = new VideoCapture(cameraIndex);
            if (!capture.IsOpened())
            {
                throw new Exception($"Could not open camera at index {cameraIndex}.");
            }
            return capture;
        }

        public static void ReleaseCamera(VideoCapture capture)
        {
            if (capture != null && capture.IsOpened())
            {
                capture.Release();
                capture.Dispose();
            }
        }

        public void Release()
        {
            _capture.Release();
        }



    }
}
