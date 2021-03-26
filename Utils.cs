using System;
using System.Windows.Forms;

namespace Shutdown {
    public static class Utils {

        public static void ScheduleShutdown(int timeoutInSeconds) {
            ExecuteCommand($"shutdown -s -t {timeoutInSeconds}");
        }

        public static void ScheduleHibernation(int timeoutInSeconds) {
            ExecuteCommand($"timeout /t {timeoutInSeconds} & rundll32.exe powrprof.dll,SetSuspendState");
        }

        public static void CancelShutdown() {
            ExecuteCommand($"shutdown /a");
        }

        /**
         * Execution d'une commande dans la console en arrière plan
         */
        private static void ExecuteCommand(string command) {
            var startInfo = new System.Diagnostics.ProcessStartInfo {
                WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Windows),
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = $"/C {command}"
            };

            var process = new System.Diagnostics.Process();
            process.StartInfo = startInfo;
            process.Start();
        }

        public static DialogResult ShowConfirmDialog(IWin32Window owner, string message) {
            return MessageBox.Show(owner, message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }


}
