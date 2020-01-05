using System;

namespace Oninaki.Reincarnation
{
    public static class PluginModule
    {
#pragma warning disable IDE0060

        public static void Attach()
        {
            ConsoleWindow.Start();
            DebugLogListener.Start();
            UnityLogListener.Start();

            Log.SuccessLine("Oninaki Reincarnation plugin module started");
        }

        public static void Detach()
        {
            Log.SuccessLine("Oninaki Reincarnation plugin module stopped");

            UnityLogListener.Stop();
            DebugLogListener.Stop();
            ConsoleWindow.Stop();
        }

        public static void Info(string format, params object[] args)
        {
            Log.Info(format, args);
        }

        public static void InfoLine(string format, params object[] args)
        {
            Log.InfoLine(format, args);
        }

        public static void Warning(string format, params object[] args)
        {
            Log.Warning(format, args);
        }

        public static void WarningLine(string format, params object[] args)
        {
            Log.WarningLine(format, args);
        }

        public static void Error(string format, params object[] args)
        {
            Log.Error(format, args);
        }

        public static void ErrorLine(string format, params object[] args)
        {
            Log.ErrorLine(format, args);
        }

        public static void Success(string format, params object[] args)
        {
            Log.Success(format, args);
        }

        public static void SuccessLine(string format, params object[] args)
        {
            Log.SuccessLine(format, args);
        }

        public static void Debug(string format, params object[] args)
        {
            Log.Debug(format, args);
        }

        public static void DebugLine(string format, params object[] args)
        {
            Log.DebugLine(format, args);
        }

        public static void Color(ConsoleColor color, string format, params object[] args)
        {
            Log.Color(color, format, args);
        }

        public static void ColorLine(ConsoleColor color, string format, params object[] args)
        {
            Log.ColorLine(color, format, args);
        }

#pragma warning restore IDE0060
    }
}
