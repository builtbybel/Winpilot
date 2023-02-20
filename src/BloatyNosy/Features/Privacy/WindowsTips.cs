using BloatyNosy;
using Microsoft.Win32;
using System;

namespace Features.Feature.Privacy
{
    internal class WindowsTips : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager ";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "[LOW] Disable Windows tips";
        }

        public override string Info()
        {
            return "You will no longer see Windows tips, e.g. Spotlight and Consumer Features, Feedback Notifications etc.";
        }

        public override bool CheckFeature()
        {
            return !(
        RegistryHelper.IntEquals(keyName, "SubscribedContent-338393Enabled", desiredValue)
            );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "SubscribedContent-338393Enabled", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Windows 11 tips has been successfully disabled.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable Windows 11 tips {0}", ex.Message); }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "SubscribedContent-338393Enabled", 1, RegistryValueKind.DWord);
                logger.Log("- Windows 11 tips has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}