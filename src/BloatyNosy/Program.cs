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
            Application.Run(new MainForm());
        }
    }
}