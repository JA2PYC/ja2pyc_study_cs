using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;

namespace WindowsFormsApp.MachineVision.OpenCv
{
    internal class OpenCvDisplay
    {
        private PictureBox _pictureBox;

        public OpenCvDisplay(PictureBox pictureBox)
        {
            _pictureBox = pictureBox ?? throw new ArgumentNullException(nameof(pictureBox), "PictureBox cannot be null.");
        }

        public void ShowImage(Mat image)
        {
                       if (image == null)
            {
                throw new ArgumentNullException(nameof(image), "Image cannot be null.");
            }
            if (image.Empty())
            {
                throw new InvalidOperationException("Cannot display an empty image.");
            }
            // Convert Mat to Bitmap
            var bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
            // Set the PictureBox image
            _pictureBox.Image?.Dispose(); // Dispose of the previous image if it exists
            _pictureBox.Image = bitmap;
        }

        public void DisplayImage(Mat image)
        {
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image), "Image cannot be null.");
            }
            if (image.Empty())
            {
                throw new InvalidOperationException("Cannot display an empty image.");
            }
            // Convert Mat to Bitmap
            var bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
            // Set the PictureBox image
            _pictureBox.Image?.Dispose(); // Dispose of the previous image if it exists
            _pictureBox.Image = bitmap;
        }
    }
}
