using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace WindowsFormsApp.MachineVision.OpenCv
{
    internal class OpenCvUtilities
    {
        // Gets the list of connected cameras
        public static string GetCameraInfo(VideoCapture capture)
        {
            if (capture == null || !capture.IsOpened())
            {
                throw new ArgumentException("VideoCapture is not initialized or opened.");
            }
            StringBuilder info = new StringBuilder();
            info.AppendLine($"Camera Index: {capture.Get(VideoCaptureProperties.PosFrames)}");
            info.AppendLine($"Frame Width: {capture.Get(VideoCaptureProperties.FrameWidth)}");
            info.AppendLine($"Frame Height: {capture.Get(VideoCaptureProperties.FrameHeight)}");
            info.AppendLine($"FPS: {capture.Get(VideoCaptureProperties.Fps)}");
            info.AppendLine($"FourCC: {capture.Get(VideoCaptureProperties.FourCC)}");
            return info.ToString();
        }

        // Sets the resolution of the video capture device
        public static void SetResolution(VideoCapture capture, int width, int height)
        {
            if (capture == null || !capture.IsOpened())
            {
                throw new ArgumentException("VideoCapture is not initialized or opened.");
            }
            if (!capture.Set(VideoCaptureProperties.FrameWidth, width) ||
                !capture.Set(VideoCaptureProperties.FrameHeight, height))
            {
                throw new Exception("Failed to set resolution.");
            }
        }

    }
}
