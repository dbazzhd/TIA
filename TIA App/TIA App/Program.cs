using System;
using System.Reflection;
using System.Windows.Forms;

namespace TIA_App {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main() {
            try {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (!ApiResolver.IsOpennessInstalled()) {
                    throw new Exception($"TIA Portal Openness {ApiResolver.Version} is not installed.");
                }
                AppDomain.CurrentDomain.AssemblyResolve += ApiResolver.AssemblyResolver;

                new TiaApplication().Run();
            }
            catch (Exception ex) {
                MessageBox.Show($"{ex.Message}\n\nDetails:\n{ex}", "Tia App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TiaUtils.Log("Quitting");
        }
    }
}
