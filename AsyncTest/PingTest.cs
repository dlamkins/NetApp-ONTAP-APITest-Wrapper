using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace APITest_Wrapper.AsyncTest {
    public class PingTest : IAsyncTest {

        public async Task RunTest(TestParams testParams, IProgress<ProgressOutput> progress) {
            progress.Report(ProgressOutput.ProgressStatus($"Pinging {testParams.Hostname}..."));
            progress.Report(ProgressOutput.Console($"Pinging {testParams.Hostname}..."));

            var pingResult = await TestUtils.PingAsync(testParams.Hostname);

            string result;
            Color  status;

            if (pingResult != null) {
                result = pingResult.Status == IPStatus.Success
                             ? $"OK ({pingResult.RoundtripTime}ms)"
                             : $"{pingResult.Status}";

                status = pingResult.Status == IPStatus.Success
                    ? Color.Green
                    : Color.Red;
            } else {
                result = "FAILED (Unknown)";
                status = Color.Red;
            }

            progress.Report(ProgressOutput.Console(result + "\r\n"));
            progress.Report(ProgressOutput.PingResult(result, status));
        }

    }
}
