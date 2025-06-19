using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;

namespace WindowsFormsApp.UI.UIHandler
{
    internal class MainManager
    {
        private readonly PictureBox _pictureBoxMain;
        private readonly ListBox _listboxMain;

        public MainManager(PictureBox pictureBox, ListBox listboxMain)
        {
            _pictureBoxMain = pictureBox ?? throw new ArgumentNullException(nameof(pictureBox), "PictureBoxMain cannot be null.");
            _listboxMain = listboxMain ?? throw new ArgumentNullException(nameof(listboxMain), "ListBoxMain cannot be null.");
        }

        // Method to update the main UI components with an image and a list item
        public void UpdateMainUI(string imagePath, string listItem)
        {
            if (string.IsNullOrEmpty(imagePath))
            {
                throw new ArgumentException("Image path cannot be null or empty.", nameof(imagePath));
            }
            if (string.IsNullOrEmpty(listItem))
            {
                throw new ArgumentException("List item cannot be null or empty.", nameof(listItem));
            }
            if (_pictureBoxMain.InvokeRequired)
            {
                _pictureBoxMain.Invoke(new Action(() => UpdateMainUI(imagePath, listItem)));
            }
            else
            {
                _pictureBoxMain.ImageLocation = imagePath;
                _listboxMain.Items.Add(listItem);
            }
        }

        public void UpdateMainUI(string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath))
            {
                throw new ArgumentException("Image path cannot be null or empty.", nameof(imagePath));
            }
            if (_pictureBoxMain.InvokeRequired)
            {
                _pictureBoxMain.Invoke(new Action(() => UpdateMainUI(imagePath)));
            }
            else
            {
                _pictureBoxMain.ImageLocation = imagePath;
            }
        }

        public void UpdateMainUI(Mat frame, string listItem)
        {
            if (frame == null)
            {
                throw new ArgumentNullException(nameof(frame), "Frame cannot be null.");
            }
            if (string.IsNullOrEmpty(listItem))
            {
                throw new ArgumentException("List item cannot be null or empty.", nameof(listItem));
            }
            if (_pictureBoxMain.InvokeRequired)
            {
                _pictureBoxMain.Invoke(new Action(() => UpdateMainUI(frame, listItem)));
            }
            else
            {
                _pictureBoxMain.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame);
                _listboxMain.Items.Add(listItem);
            }
        }

        public void UpdateMainUI(Mat frame)
        {
            if (frame == null)
            {
                throw new ArgumentNullException(nameof(frame), "Frame cannot be null.");
            }
            if (_pictureBoxMain.InvokeRequired)
            {
                _pictureBoxMain.Invoke(new Action(() => UpdateMainUI(frame)));
            }
            else
            {
                _pictureBoxMain.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame);
            }
        }

        // Method to clear the main UI components
        public void ClearMainUI()
        {
            if (_pictureBoxMain.InvokeRequired)
            {
                _pictureBoxMain.Invoke(new Action(ClearMainUI));
            }
            else
            {
                _pictureBoxMain.Image = null;
                _listboxMain.Items.Clear();
            }
        }

        // Methods to add items to the ListBox in the main UI
        public void AddItemToListBoxMain(string item)
        {
            if (string.IsNullOrEmpty(item))
            {
                throw new ArgumentException("Item cannot be null or empty.", nameof(item));
            }
            if (_listboxMain.InvokeRequired)
            {
                _listboxMain.Invoke(new Action(() => AddItemToListBoxMain(item)));
            }
            else
            {
                _listboxMain.Items.Add(item);
            }
        }

        // Method to add multiple items to the ListBox in the main UI
        public void AddItemToListBoxMain(List<string> items)
        {
            if (items == null || items.Count == 0)
            {
                throw new ArgumentException("Items cannot be null or empty.", nameof(items));
            }
            if (_listboxMain.InvokeRequired)
            {
                _listboxMain.Invoke(new Action(() => AddItemToListBoxMain(items)));
            }
            else
            {
                //_listboxMain.Items.Clear();
                foreach (var item in items)
                {
                    _listboxMain.Items.Add(item);
                }
            }
        }

        // Method to remove an item from the ListBox in the main UI
        public void RemoveItemFromListBox(string item)
        {
            if (string.IsNullOrEmpty(item))
            {
                throw new ArgumentException("Item cannot be null or empty.", nameof(item));
            }
            if (_listboxMain.InvokeRequired)
            {
                _listboxMain.Invoke(new Action(() => _listboxMain.Items.Remove(item)));
            }
            else
            {
                _listboxMain.Items.Remove(item);
            }
        }

        // Method to clear the ListBox in the main UI
        public void ClearListBox()
        {
            if (_listboxMain.InvokeRequired)
            {
                _listboxMain.Invoke(new Action(ClearListBox));
            }
            else
            {
                _listboxMain.Items.Clear();
            }
        }



        public void ResetUI()
        {
            if (_pictureBoxMain.InvokeRequired)
            {
                _pictureBoxMain.Invoke(new Action(ResetUI));
            }
            else
            {
                _pictureBoxMain.Image = null;
                _listboxMain.Items.Clear();
            }
        }



    }
}
