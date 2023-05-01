using BloatyNosy;
using Microsoft.Win32;
using System;

namespace Features.Feature.Privacy
{
    internal class BackgroundApps : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\BackgroundAccessApplications";
        private const int desiredValue = 1;

        public override string ID()
        {
            return "[HIGH] Disable Apps running in background";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckFeature()
        {
            return !(
               RegistryHelper.IntEquals(keyName, "GlobalUserDisabled", desiredValue)
             );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "GlobalUserDisabled", desiredValue, RegistryValueKind.DWord);

                logger.Log("- App access to running in background has been successfully disabled.");
                logger.Log(keyName);
                return true;
            }
            catch
            { }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "GlobalUserDisabled", 0, RegistryValueKind.DWord);
                logger.Log("- App access to running in background has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}