using System;
using System.Drawing;
using System.Threading.Tasks;

namespace APITest_Wrapper.AsyncTest {
    public class TncTest : IAsyncTest {

        public int TestPort { get; set; }

        public TncTest(int port) {
            this.TestPort = port;
        }

        public async Task RunTest(TestParams testParams, IProgress<ProgressOutput> progress) {
            progress.Report(ProgressOutput.ProgressStatus($"Checking port {this.TestPort}..."));
            progress.Report(ProgressOutput.Console($"Checking port {this.TestPort}..."));

            var listenerStatus = await TestUtils.TncAsync(testParams.Hostname, this.TestPort);

            var result = listenerStatus ? "OK" : $"PORT {this.TestPort} INACCESSIBLE";
            var status = listenerStatus ? Color.Green : Color.DarkGray;

            progress.Report(ProgressOutput.Console(result + "\r\n"));

            progress.Report(this.TestPort == 80
                                ? ProgressOutput.TcpHttpResult(result, status)
                                : ProgressOutput.TcpHttpsResult(result, status));
        }

    }
}
