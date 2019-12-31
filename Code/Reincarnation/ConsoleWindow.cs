using System;
using System.IO;
using Vanara.PInvoke;

namespace Oninaki.Reincarnation
{
    static class ConsoleWindow
    {
        public static void Start()
        {
            if (!Kernel32.AllocConsole())
                return;

            Console.SetOut(TextWriter.Synchronized(new StreamWriter(Console.OpenStandardOutput(),
                Console.OutputEncoding, 4096, true)
            {
                AutoFlush = true,
            }));

            var hwnd = Kernel32.GetConsoleWindow();

            if (hwnd.IsNull)
                return;

            if (User32.SetWindowPos(hwnd, User32.SpecialWindowHandles.HWND_TOPMOST,
                0, 0, 1920 / 2, 1080, User32.SetWindowPosFlags.SWP_DRAWFRAME))
                _ = User32.ShowWindow(hwnd, ShowWindowCommand.SW_NORMAL);
        }

        public static void Stop()
        {
            _ = Kernel32.FreeConsole();
        }
    }
}
