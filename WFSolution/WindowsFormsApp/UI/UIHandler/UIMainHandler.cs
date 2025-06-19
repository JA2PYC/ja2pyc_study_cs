using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace WindowsFormsApp.UI.UIHandler
{
    internal class UIMainHandler
    {
        private readonly MainManager _mainManager;
        private readonly StatusManager _statusManager;
        private readonly LogManager _logManager;

        public UIMainHandler (PictureBox mainPictureBox, ListBox mainListBox, Label statusLabel, ProgressBar progressBar, ListBox logListBox)
        {
            _mainManager = new MainManager(mainPictureBox, mainListBox);
            _statusManager = new StatusManager(statusLabel, progressBar);
            _logManager = new LogManager(logListBox);
        }

        public void UpdateMainUI(string imagePath, string item)
        {
            try
            {
                _mainManager.UpdateMainUI(imagePath, item);
                _statusManager.UpdateStatusUI("UI updated successfully.");
            }
            catch (Exception ex)
            {
                _logManager.AddLog($"[{DateTime.Now}] : Error updating main UI: {ex.Message}");
                _statusManager.UpdateStatusUI("Error updating UI.");
            }
        }

        public void UpdateMainUI(string imagePath)
        {
            try
            {
                _mainManager.UpdateMainUI(imagePath);
                _statusManager.UpdateStatusUI("Image updated successfully.");
            }
            catch (Exception ex)
            {
                _logManager.AddLog($"[{DateTime.Now}] : Error updating main UI with image: {ex.Message}");
                _statusManager.UpdateStatusUI("Error updating image.");
            }
        }

        public void UpdateMainUI(Mat frame, string item)
        {
            try
            {
                _mainManager.UpdateMainUI(frame, item);
                _statusManager.UpdateStatusUI("Frame and item updated successfully.");
            }
            catch (Exception ex)
            {
                _logManager.AddLog($"[{DateTime.Now}] : Error updating main UI with frame and item: {ex.Message}");
                _statusManager.UpdateStatusUI("Error updating frame and item.");
            }
        }

        public void UpdateMainUI(Mat frame)
        {
            try
            {
                _mainManager.UpdateMainUI(frame);
                _statusManager.UpdateStatusUI("Frame updated successfully.");
            }
            catch (Exception ex)
            {
                _logManager.AddLog($"[{DateTime.Now}] : Error updating main UI with frame: {ex.Message}");
                _statusManager.UpdateStatusUI("Error updating frame.");
            }
        }

        public void ResetMainUI()
        {
            try
            {
                _statusManager.ResetStatusUI();
            }
            catch (Exception ex)
            {
                _logManager.AddLog($"Error resetting main UI: {ex.Message}");
            }
        }

    }
}
