using BloatyNosy;
using Microsoft.Win32;
using System;

namespace Features.Feature.Taskbar
{
    internal class StartmenuLayout : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        private const int desiredValue = 1;

        public override string ID()
        {
            return "[MIDDLE] Pin more Apps on Start menu";
        }

        public override string Info()
        {
            return "This option is ONLY available in preview versions of Windows 11 Build 22509 or newer.";
        }

        public override bool CheckFeature()
        {
            return !(
                 RegistryHelper.IntEquals(keyName, "Start_Layout", desiredValue)
            );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "Start_Layout", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Start menu layout is now showing more Pins.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not enable more Pins on Start menu.{0}", ex.Message); }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "Start_Layout", 0, RegistryValueKind.DWord);
                logger.Log("- Showing more Pins on Start menu has been enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}