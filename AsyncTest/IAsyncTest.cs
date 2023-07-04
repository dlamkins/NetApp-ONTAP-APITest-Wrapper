using System;
using System.Threading.Tasks;

namespace APITest_Wrapper.AsyncTest {
    public interface IAsyncTest {

        Task RunTest(TestParams testParams, IProgress<ProgressOutput> progress);

    }
}
