using Winpilot;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

namespace Interop
{
    public class ThemeSettings : InteropBase
    {
        public ThemeSettings(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string RegistryKeyPath = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        private const string RegistryValueName = "AppsUseLightTheme";

        public void ToggleThemeMode()
        {
            try
            {
                // Get current registry value
                int currentValue = (int)Registry.GetValue(RegistryKeyPath, RegistryValueName, -1);

                // Toggle theme mode
                int newValue = (currentValue == 0) ? 1 : 0;

                // Set new value
                Registry.SetValue(RegistryKeyPath, RegistryValueName, newValue, RegistryValueKind.DWord);

                Logger.Log(newValue == 0 ? "Dark mode enabled." : "Light mode enabled.", Color.Black);

                // Im delaying here restart to allow changes to take effect
                Thread.Sleep(1000);

                RestartExplorer();
            }
            catch (Exception ex)
            {
                Logger.Log($"Error toggling theme mode: {ex.Message}", Color.Red);
            }
        }

        public override void Execute()
        {
            ToggleThemeMode();
        }

        private void RestartExplorer()
        {
            try
            {
                foreach (var process in Process.GetProcessesByName("explorer"))
                {
                    process.Kill();
                }

                Process.Start("explorer.exe");
            }
            catch (Exception ex)
            {
                Logger.Log($"Error restarting explorer.exe: {ex.Message}", Color.Red);
            }
        }
    }
}