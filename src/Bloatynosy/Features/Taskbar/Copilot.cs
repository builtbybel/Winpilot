using Bloatynosy;
using Microsoft.Win32;
using System;

namespace Features.Feature.Taskbar
{
    internal class Copilot: FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string showCopilotButton = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        private const string turnOffWindowsCopilotU = @"HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\WindowsCopilot";
        private const string turnOffWindowsCopilotM = @"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\WindowsCopilot";

        private const int desiredValue = 1;

        public override string ID()
        {
            return "[MIDDLE] Disable Windows Copilot";
        }

        public override string Info()
        {
            return "Copilot in Windows is an artificial intelligence assistant that's integrated in Windows 11 to enhance productivity and creativity.";
        }

        public override bool CheckFeature()
        {
            return !(
                   RegistryHelper.IntEquals(showCopilotButton, "ShowCopilotButton", 0) &&
                    RegistryHelper.IntEquals(turnOffWindowsCopilotU, "TurnOffWindowsCopilot", desiredValue) &&
                    RegistryHelper.IntEquals(turnOffWindowsCopilotM, "TurnOffWindowsCopilot", desiredValue)
            );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(showCopilotButton, "ShowCopilotButton", 0, RegistryValueKind.DWord);
                Registry.SetValue(turnOffWindowsCopilotU, "TurnOffWindowsCopilot", desiredValue, RegistryValueKind.DWord);
                Registry.SetValue(turnOffWindowsCopilotM, "TurnOffWindowsCopilot", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Copilot has been successfully disabled.");
                logger.Log(showCopilotButton + Environment.NewLine + turnOffWindowsCopilotU + Environment.NewLine + turnOffWindowsCopilotM);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable Copilot {0}", ex.Message); }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                var RegKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);
                RegKey.DeleteValue("ShowCopilotButton");

                var RegKeyU = Registry.CurrentUser.OpenSubKey(@"Software\Policies\Microsoft\Windows\WindowsCopilot", true);
                RegKeyU.DeleteValue("TurnOffWindowsCopilot");

                var RegKeyM = Registry.LocalMachine.OpenSubKey(@"Software\Policies\Microsoft\Windows\WindowsCopilot", true);
                RegKeyM.DeleteValue("TurnOffWindowsCopilot");


                logger.Log("+ Copilot has been successfully enabled.");
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not enable Copilot {0}", ex.Message); }

            return false;
        }
    }
}