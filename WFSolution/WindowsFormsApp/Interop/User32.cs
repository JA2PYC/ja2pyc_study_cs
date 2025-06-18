using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Interop
{
    public static class User32
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetForegroundWindow(IntPtr hwWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern void BringWindowToTop(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern void ShowWindowAsync(IntPtr hWnd, int nCmdShow);

    }
}
