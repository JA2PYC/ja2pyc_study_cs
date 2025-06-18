using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// OpenCvSharp Libraries
using OpenCvSharp;
using OpenCvSharp.Extensions;


namespace WindowsFormsApp.MachineVision.OpenCv
{
    internal class OpenCvManager
    {
        private void ComputeImage()
        {
            // Create a new Mat object with the specified dimensions and type
            Mat mat = new Mat(100, 100, MatType.CV_8UC3);
            // Fill the Mat with a color (e.g., red)
            mat.SetTo(new Scalar(0, 0, 255));
            // Convert the Mat to a Bitmap
            var bitmap = mat.ToBitmap();
            // Display or use the bitmap as needed
            // For example, you can save it to a file or display it in a PictureBox
            bitmap.Save("output_image.png");
        }
    }
}
