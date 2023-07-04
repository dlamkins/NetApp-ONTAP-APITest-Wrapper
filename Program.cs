using System;
using System.IO;
using System.Windows.Forms;

namespace APITest_Wrapper {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e) {
            string err = $"NetApp APITest Wrapper Crashed with unhandled exception.\r\nPlease send this output to Dade Lamkins (dade@lamkins.org) for review.\r\n{(e.ExceptionObject as Exception).Message}";

            try {
                File.WriteAllText("apitestwrapper_crash.txt", err);
            } catch (Exception) {
                MessageBox.Show(err, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
