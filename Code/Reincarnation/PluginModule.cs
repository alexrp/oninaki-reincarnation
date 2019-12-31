namespace Oninaki.Reincarnation
{
    public static class PluginModule
    {
#pragma warning disable IDE0060

        public static void Attach(object[] args)
        {
            ConsoleWindow.Start();
            DebugLogListener.Start();
            UnityLogListener.Start();

            Log.InfoLine("Oninaki Reincarnation plugin module started.");
        }

        public static void Detach(object[] args)
        {
            Log.InfoLine("Oninaki Reincarnation plugin module stopped.");

            UnityLogListener.Stop();
            DebugLogListener.Stop();
            ConsoleWindow.Stop();
        }

#pragma warning restore IDE0060
    }
}
