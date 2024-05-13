using Microsoft.Win32;
using System;
using System.Drawing;
using Winpilot;

namespace Walks
{
    internal class LockScreenAds : WalksBase
    {
        public LockScreenAds(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string keyName = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        private const int desiredValue = 0;

        public override string ID() => "Lock Screen Tips and Ads";

        public override bool CheckFeature()
        {
            return !(Utils.IntEquals(keyName, "RotatingLockScreenOverlayEnabled", desiredValue) &&
                   Utils.IntEquals(keyName, "SubscribedContent-338387Enabled", desiredValue)
            );
        }


        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "RotatingLockScreenOverlayEnabled", 1, Microsoft.Win32.RegistryValueKind.DWord);
                Registry.SetValue(keyName, "SubscribedContent-338387Enabled", 1, Microsoft.Win32.RegistryValueKind.DWord);

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
                Registry.SetValue(keyName, "RotatingLockScreenOverlayEnabled", desiredValue, Microsoft.Win32.RegistryValueKind.DWord);
                Registry.SetValue(keyName, "SubscribedContent-338387Enabled", desiredValue, Microsoft.Win32.RegistryValueKind.DWord);

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