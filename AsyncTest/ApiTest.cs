using System;
using System.Threading.Tasks;

namespace APITest_Wrapper.AsyncTest {
    public class ApiTest : IAsyncTest {

        public async Task RunTest(TestParams testParams, IProgress<ProgressOutput> progress) {
            progress.Report(ProgressOutput.ProgressStatus($"Performing API test '{testParams.ApiCall}'..."));

            await TestUtils.ApiTool(testParams, progress);
        }

    }
}
