using System;
using System.Windows.Forms;

namespace BloatyNosy
{
    internal static class Program
    {
        /// <summary>
        /// Get app version
        /// </summary>
        internal static string GetCurrentVersionTostring() => new Version(Application.ProductVersion).ToString(3);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
           {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!HelperTool.OsHelper.IsWin11())
            {
                MessageBox.Show("You are running Bloaty&Nosy on a system older than Windows 11.\nBloatyNosy is limited to Windows 11 ONLY.", "OS not supported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else Application.Run(new MainForm());

        }
    }
}