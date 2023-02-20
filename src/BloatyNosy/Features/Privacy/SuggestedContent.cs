using BloatyNosy;
using Microsoft.Win32;
using System;

namespace Features.Feature.Privacy
{
    internal class SuggestedContent : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        private const string keyName2 = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        private const string keyName3 = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "[HIGH] Disable Suggested content in Settings app";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckFeature()
        {
            return !(
                 RegistryHelper.IntEquals(keyName, "SubscribedContent-338393Enabled", desiredValue) &&
                 RegistryHelper.IntEquals(keyName2, "SubscribedContent-353694Enabled", desiredValue) &&
                 RegistryHelper.IntEquals(keyName3, "SubscribedContent-353696Enabled", desiredValue)
             );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "SubscribedContent-338393Enabled", desiredValue, RegistryValueKind.DWord);
                Registry.SetValue(keyName2, "SubscribedContent-353694Enabled", desiredValue, RegistryValueKind.DWord);
                Registry.SetValue(keyName3, "SubscribedContent-353696Enabled", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Suggested content in Settings app has been successfully disabled.");
                logger.Log(keyName + Environment.NewLine + keyName2 + Environment.NewLine + keyName3);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable suggested content in Settings app {0}", ex.Message); }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "SubscribedContent-338393Enabled", 1, RegistryValueKind.DWord);
                Registry.SetValue(keyName2, "SubscribedContent-353694Enabled", 1, RegistryValueKind.DWord);
                Registry.SetValue(keyName3, "SubscribedContent-353696Enabled", 1, RegistryValueKind.DWord);

                logger.Log("- Suggested content in Settings app has been successfully enabled.");
                logger.Log(keyName + Environment.NewLine + keyName2 + Environment.NewLine + keyName3);
                return true;
            }
            catch
            { }

            return false;
        }
    }
}