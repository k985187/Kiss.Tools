﻿using System;
using System.Runtime.InteropServices;

namespace Kiss.Tools.Api
{
    public class WinApi
    {
        public const UInt32 FLASHW_STOP = 0;
        public const UInt32 FLASHW_CAPTION = 1;
        public const UInt32 FLASHW_TRAY = 2;
        public const UInt32 FLASHW_ALL = 3;
        public const UInt32 FLASHW_TIMER = 4;
        public const UInt32 FLASHW_TIMERNOFG = 12;

        public struct FLASHWINFO
        {

            public UInt32 cbSize;
            public IntPtr hwnd;
            public UInt32 dwFlags;
            public UInt32 uCount;
            public UInt32 dwTimeout;
        }

        [DllImport("User32.dll")]
        public static extern bool FlashWindowEx(ref FLASHWINFO pwfi);

        [DllImport("User32.dll")]
        public static extern IntPtr GetForegroundWindow();

        public enum WindowShowStyle : uint
        {
            Hide = 0,
            ShowNormal = 1,
            ShowMinimized = 2,
            ShowMaximized = 3,
            Maximize = 3,
            ShowNormalNoActivate = 4,
            Show = 5,
            Minimize = 6,
            ShowMinNoActivate = 7,
            ShowNoActivate = 8,
            Restore = 9,
            ShowDefault = 10,
            ForceMinimized = 11
        }

        [DllImport("User32.dll")]
        public static extern bool IsIconic(IntPtr hWnd);

        [DllImport("User32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, WindowShowStyle nCmdShow);

        [DllImport("User32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
    }
}