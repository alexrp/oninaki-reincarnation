using System;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Oninaki.Reincarnation
{
    static class DebugLogListener
    {
        static readonly CancellationTokenSource _cts = new CancellationTokenSource();

        static Task _task;

        public static void Start()
        {
            _task = Task.Run(() =>
            {
                const int BufferSize = 4096;

                using var mmf = MemoryMappedFile.CreateNew("DBWIN_BUFFER", BufferSize);
                using var bufReady = new EventWaitHandle(false, EventResetMode.AutoReset, "DBWIN_BUFFER_READY");
                using var dataReady = new EventWaitHandle(false, EventResetMode.AutoReset, "DBWIN_DATA_READY");

                var id = Process.GetCurrentProcess().Id;

                while (true)
                {
                    _cts.Token.ThrowIfCancellationRequested();

                    _ = bufReady.Set();

                    if (!dataReady.WaitOne(250))
                        continue;

                    using var stream = mmf.CreateViewStream(0, BufferSize, MemoryMappedFileAccess.Read);
                    using var reader = new BinaryReader(stream);

                    if (reader.ReadInt32() != id)
                        continue;

                    var bytes = reader.ReadBytes(BufferSize - sizeof(int));
                    var str = Encoding.ASCII.GetString(bytes, 0, Array.IndexOf<byte>(bytes, 0));

                    Log.DebugLine("Debug: {0}", str.Substring(0, str.Length - 1));
                }
            }, _cts.Token).ContinueWith(t => {});
        }

        public static void Stop()
        {
            _cts.Cancel();
            _task.Wait();
        }
    }
}
