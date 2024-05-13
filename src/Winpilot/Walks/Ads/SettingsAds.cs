using Microsoft.Win32;
using System;
using System.Drawing;
using Winpilot;

namespace Walks
{
    internal class SettingsAds : WalksBase
    {
        public SettingsAds(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string keyName = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        private const int desiredValue = 0;

        public override string ID() => "Settings Ads";

        public override bool CheckFeature()
        {
            return !(Utils.IntEquals(keyName, "SubscribedContent-338393Enabled", desiredValue) &&
                   Utils.IntEquals(keyName, "SubscribedContent-353694Enabled", desiredValue) &&
                   Utils.IntEquals(keyName, "SubscribedContent-353696Enabled", desiredValue)
            );
        }
   

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "SubscribedContent-338393Enabled", 1, Microsoft.Win32.RegistryValueKind.DWord); 
                Registry.SetValue(keyName, "SubscribedContent-353694Enabled", 1, Microsoft.Win32.RegistryValueKind.DWord); 
                Registry.SetValue(keyName, "SubscribedContent-353696Enabled", 1, Microsoft.Win32.RegistryValueKind.DWord);

                return true;
            }
            catch (Exception ex)
            {
                logger.Log("Code red in " + ex.Message, Color.Red);
            }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "SubscribedContent-338393Enabled", desiredValue, Microsoft.Win32.RegistryValueKind.DWord);
                Registry.SetValue(keyName, "SubscribedContent-353694Enabled", desiredValue, Microsoft.Win32.RegistryValueKind.DWord);
                Registry.SetValue(keyName, "SubscribedContent-353696Enabled", desiredValue, Microsoft.Win32.RegistryValueKind.DWord);

                return true;
            }
            catch (Exception ex)
            {
                logger.Log("Code red in " + ex.Message, Color.Red);
            }

            return false;
        }
    }
}