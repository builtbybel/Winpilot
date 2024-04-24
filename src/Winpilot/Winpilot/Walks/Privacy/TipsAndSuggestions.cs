using Microsoft.Win32;
using Winpilot;
using System;
using System.Drawing;

namespace Walks
{
    internal class TipsAndSuggestions : WalksBase
    {
        public TipsAndSuggestions(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CloudContent";
        private const string keyName2 = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        private const int desiredValue = 1;
        private const int desiredValue2 = 0;

        public override string ID() => "Tips and suggestions";

        public override bool CheckFeature()
        {
            return !(Utils.IntEquals(keyName, "DisableSoftLanding", desiredValue) &&
                     Utils.IntEquals(keyName2, "SoftLandingEnabled", desiredValue2) &&
                      Utils.IntEquals(keyName2, "ScoobeSystemSettingEnabled", desiredValue2)
                 );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "DisableSoftLanding", 0, Microsoft.Win32.RegistryValueKind.DWord);
                Registry.SetValue(keyName2, "SoftLandingEnabled", 1, Microsoft.Win32.RegistryValueKind.DWord);
                Registry.SetValue(keyName2, "ScoobeSystemSettingEnabled", 1, Microsoft.Win32.RegistryValueKind.DWord);

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
                Registry.SetValue(keyName, "DisableSoftLanding", desiredValue, Microsoft.Win32.RegistryValueKind.DWord);
                Registry.SetValue(keyName2, "SoftLandingEnabled", desiredValue2, Microsoft.Win32.RegistryValueKind.DWord);
                Registry.SetValue(keyName2, "ScoobeSystemSettingEnabled", desiredValue2, Microsoft.Win32.RegistryValueKind.DWord);

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