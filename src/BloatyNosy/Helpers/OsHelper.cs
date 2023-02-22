using Microsoft.Win32;
using System;

namespace HelperTool
{
    public static class OsHelper
    {
        public static readonly string thisOS = GetSupportedOS() + "\x20" + GetVersion();

        public static string GetSupportedOS()
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
                int osbuild = Convert.ToInt32(key.GetValue("CurrentBuildNumber"));
                if (osbuild >= 21996)
                {
                    return "Windows 11";
                }
            }
            catch { }
            return "Windows 10";
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