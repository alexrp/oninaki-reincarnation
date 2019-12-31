using UnityEngine;

namespace Oninaki.Reincarnation
{
    static class UnityLogListener
    {
        public static void Start()
        {
            Application.logMessageReceived += OnLog;
        }

        public static void Stop()
        {
            Application.logMessageReceived -= OnLog;
        }

        static void OnLog(string condition, string stackTrace, LogType type)
        {
            switch (type)
            {
                case LogType.Error:
                case LogType.Assert:
                case LogType.Exception:
                    Log.ErrorLine("Unity: {0}", condition);
                    break;
                case LogType.Warning:
                    Log.WarningLine("Unity: {0}", condition);
                    break;
                case LogType.Log:
                    Log.InfoLine("Unity: {0}", condition);
                    break;
            }
        }
    }
}
