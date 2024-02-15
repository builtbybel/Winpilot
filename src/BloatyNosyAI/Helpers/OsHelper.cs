using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace HelperTool
{
    public static class OsHelper
    {
        public static readonly string thisOS = IsWin11() + "\x20" + GetVersion();

        public static bool IsWin11()
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
                int osbuild = Convert.ToInt32(key.GetValue("CurrentBuildNumber"));
                if (osbuild >= 21996)
                {
                    return true;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return false;
        }

        public static string GetVersion()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");

            var UBR = key.GetValue("UBR").ToString();
            var CurrentBuild = key.GetValue("CurrentBuild").ToString();

            string version = CurrentBuild + "." + UBR;

            return "Build " + version;
        }
    }
}