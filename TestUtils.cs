using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace APITest_Wrapper {
    public static class TestUtils {

        public static async Task<PingReply> PingAsync(string host) {
            try {
                var reply = await (new Ping()).SendPingAsync(host, 128, Encoding.ASCII.GetBytes("never gonna give you up never go"), new PingOptions(128, true));
                return reply;
            } catch (Exception) {
                return null;
            }
        }

        public static async Task<bool> TncAsync(string host, int port) {
            var socket = new Socket(SocketType.Stream, ProtocolType.Tcp);

            var socketThread = new Thread(delegate () {
                try {
                    socket.Connect(host, port);
                } catch (Exception) { /* NOOP */ }
            });
            socketThread.Start();

            int c = 50;

            while (!socket.Connected && c > 0) {
                await Task.Delay(100);
                c--;
            }
            
            socketThread.Abort();

            return socket.Connected;
        }

        public static async Task ApiTool(TestParams testParams, IProgress<ProgressOutput> progress) {
            string extractDir = Path.Combine(Path.GetTempPath(), Path.GetTempFileName().Replace(".tmp", ""));
            Directory.CreateDirectory(extractDir);

            var zipStream = new MemoryStream(Properties.Resources.apitest_5_6_0);
            var zip = new ZipArchive(zipStream);

            foreach (var entry in zip.Entries) {
                string entryExportPath = Path.Combine(extractDir, entry.Name);

                using (var ms = new MemoryStream()) {
                    await entry.Open().CopyToAsync(ms);

                    File.WriteAllBytes(entryExportPath, ms.ToArray());
                }
            }

            if (testParams.CheckHttp) {
                progress.Report(ProgressOutput.Console("\r\n[HTTP] API Tool Output:\r\n"));

                var apiToolProc = new Process() {
                    StartInfo = new ProcessStartInfo(Path.Combine(extractDir, "apitest.exe"), $"-n {testParams.Hostname} {testParams.Username} \"{testParams.Password}\" {testParams.ApiCall}") {
                        UseShellExecute        = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow         = true
                    }
                };

                apiToolProc.Start();

                while (!apiToolProc.StandardOutput.EndOfStream) {
                    progress.Report(ProgressOutput.Console(await apiToolProc.StandardOutput.ReadLineAsync()));
                }

                progress.Report(ProgressOutput.Console("\r\n"));
            }

            progress.Report(ProgressOutput.Console("\r\n[HTTPS] API Tool Output:\r\n"));

            var apiToolProc2 = new Process() {
                StartInfo = new ProcessStartInfo(Path.Combine(extractDir, "apitest.exe"), $"{testParams.Hostname} {testParams.Username} \"{testParams.Password}\" {testParams.ApiCall}") {
                    UseShellExecute        = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow         = true
                }
            };

            apiToolProc2.Start();

            while (!apiToolProc2.StandardOutput.EndOfStream) {
                progress.Report(ProgressOutput.Console(await apiToolProc2.StandardOutput.ReadLineAsync()));
            }

            progress.Report(ProgressOutput.Console("\r\n"));
        }

    }
}
