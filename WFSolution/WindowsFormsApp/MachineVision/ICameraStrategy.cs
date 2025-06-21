namespace WindowsFormsApp.MachineVision
{
    internal interface ICameraStrategy
    {
        bool ConnectCamera(int cameraIndex);

        string GetCameraInfo();

        byte[] CaptureFrame();

        void DisconnectCamera();
    }
}
