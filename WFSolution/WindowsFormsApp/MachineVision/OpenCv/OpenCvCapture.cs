using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using OpenCvSharp;

namespace WindowsFormsApp.MachineVision.OpenCv
{
    internal class OpenCvCapture
    {
        public static Mat CaptureFrame(VideoCapture capture)
        {
            if (capture == null || !capture.IsOpened())
            {
                throw new ArgumentException("VideoCapture is not initialized or opened.");
            }
            Mat frame = new Mat();
            capture.Read(frame);
            if (frame.Empty())
            {
                throw new Exception("Captured frame is empty.");
            }
            return frame;
        }
        //private VideoCapture _capture;
        //public OpenCvCapture(int cameraIndex = 0)
        //{
        //    _capture = new VideoCapture(cameraIndex);
        //    if (!_capture.IsOpened())
        //    {
        //        throw new Exception("Could not open video capture device.");
        //    }
        //}

        //public Mat CaptureFrame()
        //{
        //    Mat frame = new Mat();
        //    _capture.Read(frame);
        //    if (frame.Empty())
        //    {
        //        throw new Exception("Captured frame is empty.");
        //    }
        //    return frame;
        //}
    }
}
