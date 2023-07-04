using System;
using System.Drawing;
using System.Windows.Forms;
using APITest_Wrapper.AsyncTest;
// ReSharper disable ReplaceWithSingleAssignment.True

namespace APITest_Wrapper {
    public partial class Main : Form {

        private const string STATUS_PINGHOST      = "⭕ PING HOST";
        private const string STATUS_TCPCHECKHTTP  = "⭕ TCP CHECK HTTP";
        private const string STATUS_TCPCHECKHTTPS = "⭕ TCP CHECK HTTPS";

        public Main() {
            InitializeComponent();

            cbApiCall.SelectedIndex = 0;

            UpdateValidation();
        }

        private void UpdateStates(bool running) {
            bttnRunTests.Enabled   = !running;
            bttnCopyOutput.Enabled = !running;
            tbUsername.Enabled     = !running;
            tbPassword.Enabled     = !running;
            tbHost.Enabled         = !running;
            cbApiCall.Enabled      = !running;
            cbCheckHttp.Enabled    = !running;
        }

        private void UpdateValidation() {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(tbUsername.Text)) valid = false;
            if (string.IsNullOrWhiteSpace(tbPassword.Text)) valid = false;
            if (string.IsNullOrWhiteSpace(tbHost.Text)) valid     = false;
            if (tbPassword.Text.Contains("\"")) valid             = false;

            bttnRunTests.Enabled = valid;
        }

        private async void bttnRunTests_Click(object sender, EventArgs e) {
            UpdateStates(true);

            tbRawOutput.Clear();
            lblPingHosts.Text          = STATUS_PINGHOST;
            lblPingHosts.ForeColor     = Color.Black;
            lblTcpCheckHttp.Text       = STATUS_TCPCHECKHTTP;
            lblTcpCheckHttp.ForeColor  = Color.Black;
            lblTcpCheckHttps.Text      = STATUS_TCPCHECKHTTPS;
            lblTcpCheckHttps.ForeColor = Color.Black;

            var progressMonitor = new Progress<ProgressOutput>();
            progressMonitor.ProgressChanged += ProgressMonitorOnProgressChanged;

            var testParams = new TestParams() {
                Username  = tbUsername.Text,
                Password  = tbPassword.Text,
                Hostname  = tbHost.Text,
                ApiCall   = cbApiCall.Text,
                CheckHttp = cbCheckHttp.Checked
            };

            tbRawOutput.Text = $"Hostname: {testParams.Hostname}\r\nUsername: {testParams.Username}\r\nAPI Call: {testParams.ApiCall}\r\n\r\n";

            IAsyncTest[] tests = { 
                new PingTest(),
                new TncTest(80),
                new TncTest(443),
                new ApiTest()
            };

            spbStatus.Maximum = tests.Length;

            for (int i = 0; i < tests.Length; i++) {
                await tests[i].RunTest(testParams, progressMonitor);
                spbStatus.Value = i + 1;
                spbStatus.Invalidate();
            }

            spbStatus.Value      = 0;
            spbStatus.StatusText = "Done";
            spbStatus.Invalidate();

            UpdateStates(false);
        }

        private void ProgressMonitorOnProgressChanged(object sender, ProgressOutput e) {
            switch (e.Type) {
                case ProgressOutput.ProgressType.ConsoleOut:
                    tbRawOutput.AppendText(e.TextOut);
                    break;
                case ProgressOutput.ProgressType.ProgressBar:
                    spbStatus.StatusText = e.TextOut;
                    spbStatus.Invalidate();
                    break;
                case ProgressOutput.ProgressType.PingResult:
                    lblPingHosts.Text      = STATUS_PINGHOST.PadRight(STATUS_TCPCHECKHTTPS.Length + 3, '.') + e.TextOut;
                    lblPingHosts.ForeColor = e.StatusColor;
                    break;
                case ProgressOutput.ProgressType.TcpHttpResult:
                    lblTcpCheckHttp.Text      = STATUS_TCPCHECKHTTP.PadRight(STATUS_TCPCHECKHTTPS.Length + 3, '.') + e.TextOut;
                    lblTcpCheckHttp.ForeColor = e.StatusColor;
                    break;
                case ProgressOutput.ProgressType.TcpHttpsResult:
                    lblTcpCheckHttps.Text      = STATUS_TCPCHECKHTTPS.PadRight(STATUS_TCPCHECKHTTPS.Length + 3, '.') + e.TextOut;
                    lblTcpCheckHttps.ForeColor = e.StatusColor;
                    break;
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e) {
            UpdateValidation();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e) {
            UpdateValidation();
        }

        private void tbHost_TextChanged(object sender, EventArgs e) {
            UpdateValidation();
        }

        private void bttnCopyOutput_Click(object sender, EventArgs e) {
            if (tbRawOutput.Text == null) return;
            Clipboard.SetText(tbRawOutput.Text);
        }
    }
}
