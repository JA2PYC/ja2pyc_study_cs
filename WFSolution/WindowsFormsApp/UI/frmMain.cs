using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using System.Collections.Generic;


// Libraries
using WindowsFormsApp.Interop;
using WindowsFormsApp.UI.UIHandler;

// Machine Vision Libraries
using WindowsFormsApp.MachineVision.OpenCv;
using OpenCvSharp;
using OpenCvSharp.Extensions;


namespace WindowsFormsApp.UI
{
    public partial class FrmMain : Form
    {
        private bool isRunning = false;

        public FrmMain()
        {
            Debug.WriteLine("frmMain constructor called");
            InitializeComponent();
        }

        private void FrmMain_Load_Test(object sender, EventArgs e)
        {
            Debug.WriteLine("frmMain_Load called");

            // Set the form properties
            this.Text = "Frm Main Load Test";
            this.Size = new System.Drawing.Size(1280, 720);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Add a label to the form
            //Button btnSettings = new Button
            //{
            //    Text = "Open Settings",
            //    Location = new System.Drawing.Point(350, 250),
            //    Size = new System.Drawing.Size(100, 30)
            //};
            //btnSettings.Click += BtnSettings_Click;
            //this.Controls.Add(btnSettings);



            // Check if the platform is Windows NT to use User32 interop methods
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                Debug.WriteLine("Running on Windows NT platform. User32 interop methods can be used.");
                // Example usage of User32 interop methods
                IntPtr hWnd = User32.FindWindow(null, "Frm Main Load Test"); 
                if (hWnd != IntPtr.Zero)
                {
                    Debug.WriteLine($"Found window handle: {hWnd}");
                    User32.SetForegroundWindow(hWnd);
                    User32.ShowWindow(hWnd, 5); // SW_SHOW
                    User32.BringWindowToTop(hWnd);
                    User32.ShowWindowAsync(hWnd, 5); // SW_SHOW
                }
                else
                {
                    Debug.WriteLine("Window not found!");
                    User32.MessageBox(IntPtr.Zero, "Window not found!", "Error", 0);
                }
            }
        }


        // Test Settings button click event handler
        //private void BtnSettings_Click(object sender, EventArgs e)
        //{
        //    frmSettings settingsForm = new frmSettings();
        //    settingsForm.ShowDialog(); // Opens the settings form as a modal dialog
        //}

        // This method is called when the form is loaded
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        // Button On Off click event handler
        private void BtnOnOff_Click(object sender, EventArgs e)
        {
            ButtonHandler.ToggleProcess(LabelStatus, ref isRunning, ProgressBarStatus, ProcessLog, MainCamera);
            //isRunning = !isRunning; // Toggle the running state

            //if (isRunning)
            //{
            //    LabelStatus.Text = "Running...";
            //    LabelStatus.ForeColor = Color.Green;

            //} else
            //{
            //    LabelStatus.Text = "Stopped";
            //    LabelStatus.ForeColor = Color.Red;
            //} 
        }

        // Button Start click event handler
        private void BtnStart_Click(object sender, EventArgs e)
        {

        }

        // This method is called when the table layout panel is painted
        private void MainLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnOpenCvTest_Click(object sender, EventArgs e)
        {
            OpenCvCamera camera = new OpenCvCamera();


            try
            {
                if (camera.ConnectCamera(0))
                {
                    Mat frame = camera.CaptureFrame();
                    if (!frame.Empty())
                    {
                        MainCamera.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame);
                        camera.Release();
                    }
                    else
                    {
                        MessageBox.Show("Captured frame is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Could not connect to the camera.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCameraList_Click(object sender, EventArgs e)
        {
            List<int> cameraList = OpenCvCamera.GetConnectedCameras();

           if (cameraList.Count > 0)
            {
                Debug.WriteLine($"Connected cameras: {string.Join(", ", cameraList)}");
                string cameras = string.Join(", ", cameraList);
                MessageBox.Show($"Connected cameras: {cameras}", "Camera List", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No cameras connected.", "Camera List", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnLive_Click(object sender, EventArgs e)
        {
            OpenCvCamera liveCamera = new OpenCvCamera();

            if (liveCamera.ConnectCamera(0))
            {
                try
                {
                    // Start the camera live feed
                    Timer _timer = new Timer();
                    _timer.Interval = 30;
                    _timer.Tick += UpdateFrame;
                    _timer.Start();
                    MessageBox.Show("Starting live feed...", "Live Feed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while starting the live feed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Could not connect to the camera.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateFrame(object sender, EventArgs e)
        {
                       OpenCvCamera liveCamera = new OpenCvCamera();
            try
            {
                Mat frame = liveCamera.CaptureFrame();
                if (!frame.Empty())
                {
                    MainCamera.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame);
                }
                else
                {
                    MessageBox.Show("Captured frame is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while capturing the frame: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
