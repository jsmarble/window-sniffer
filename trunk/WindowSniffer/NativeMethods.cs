using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing;

namespace WindowSniffer
{
    internal class NativeMethods
    {
        internal static int SW_HIDE = 0;
        internal static int SW_SHOWNORMAL = 1;
        internal static int SW_NORMAL = 1;
        internal static int SW_SHOWMINIMIZED = 2;
        internal static int SW_SHOWMAXIMIZED = 3;
        internal static int SW_MAXIMIZE = 3;
        internal static int SW_SHOWNOACTIVATE = 4;
        internal static int SW_SHOW = 5;
        internal static int SW_MINIMIZE = 6;
        internal static int SW_SHOWMINNOACTIVE = 7;
        internal static int SW_SHOWNA = 8;
        internal static int SW_RESTORE = 9;
        internal static int SW_SHOWDEFAULT = 10;
        internal static int SW_FORCEMINIMIZE = 11;
        internal static int SW_MAX = 11;

        public delegate bool CallBackPtr(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        internal static extern bool EnumWindows(CallBackPtr callPtr, IntPtr lPar);

        [DllImport("user32.dll")]
        internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        internal static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int width, int height, uint uFlags);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        internal static extern bool SetWindowText(IntPtr hWnd, string lpString);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        internal struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        internal static List<Window> GetAllWindows()
        {
            List<Window> windows = new List<Window>();
            CallBackPtr callback = new CallBackPtr(delegate(IntPtr hWnd, IntPtr lParam)
            {
                StringBuilder windowText = new StringBuilder(255);
                GetWindowText(hWnd, windowText, 255);
                RECT r = new RECT();
                GetWindowRect(hWnd, out r);

                Window w = new Window();
                w.Handle = hWnd;
                w.Text = windowText.ToString();
                w.Bounds = new Rectangle(r.Left, r.Top, r.Right - r.Left, r.Bottom - r.Top);
                windows.Add(w);

                return true;
            });
            EnumWindows(callback, IntPtr.Zero);
            return windows;
        }
    }
}
