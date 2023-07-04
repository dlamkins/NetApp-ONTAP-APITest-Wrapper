using System.Drawing;

namespace APITest_Wrapper {
    public class ProgressOutput {

        public enum ProgressType {
            ConsoleOut,
            ProgressBar,
            PingResult,
            TcpHttpResult,
            TcpHttpsResult
        }

        public ProgressType Type { get; }

        public string TextOut     { get; set; } = null;
        public Color  StatusColor { get; set; } = Color.Black;

        private ProgressOutput(ProgressType type) {
            this.Type = type;
        }

        public static ProgressOutput Console(string console) {
            return new ProgressOutput(ProgressType.ConsoleOut) {
                TextOut = console
            };
        }

        public static ProgressOutput ProgressStatus(string status) {
            return new ProgressOutput(ProgressType.ProgressBar) {
                TextOut = status
            };
        }

        public static ProgressOutput PingResult(string result, Color status) {
            return new ProgressOutput(ProgressType.PingResult) {
                TextOut     = result,
                StatusColor = status
            };
        }

        public static ProgressOutput TcpHttpResult(string result, Color status) {
            return new ProgressOutput(ProgressType.TcpHttpResult) {
                TextOut     = result,
                StatusColor = status
            };
        }

        public static ProgressOutput TcpHttpsResult(string result, Color status) {
            return new ProgressOutput(ProgressType.TcpHttpsResult) {
                TextOut     = result,
                StatusColor = status
            };
        }

    }
}
