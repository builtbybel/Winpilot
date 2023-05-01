using BloatyNosy;
using Microsoft.Win32;
using System;

namespace Features.Feature.Gaming
{
    internal class GameDVR : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\System\GameConfigStore";
        private const string keyName2 = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\ApplicationManagement\AllowGameDVR";
        private const int desiredValue = 0;
        private const int desiredValue2 = 2;
        private const int desiredValue3 = 0;

        public override string ID()
        {
            return "[MIDDLE] Disable Game DVR feature";
        }

        public override string Info()
        {
            return "The built-in Game DVR feature helps you record your gameplay, capture screenshots, and share them online.\n" +
                    "But it can interfere with your game’s performance, too. Background recording requires some of your GPU power, and some gamers will want all the GPU power they can get.\n" +
                    "If you experience low FPS or FPS loss after upgrading to Windows 11, you may resolve the issue by disabling the Xbox DVR feature.";
        }

        public override bool CheckFeature()
        {
            return !(
               RegistryHelper.IntEquals(keyName, "GameDVR_Enabled", desiredValue) &&
               RegistryHelper.IntEquals(keyName, "GameDVR_FSEBehaviorMode", desiredValue2) &&
               RegistryHelper.IntEquals(keyName2, "value", desiredValue3)
             );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "GameDVR_Enabled", desiredValue, RegistryValueKind.DWord);
                Registry.SetValue(keyName, "GameDVR_FSEBehaviorMode", desiredValue2, RegistryValueKind.DWord);
                Registry.SetValue(keyName2, "value", desiredValue3, RegistryValueKind.DWord);

                logger.Log("- Game DVR feature has been successfully disabled.");
                logger.Log(keyName + Environment.NewLine + keyName2);
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
                Registry.SetValue(keyName, "GameDVR_Enabled", "1", RegistryValueKind.DWord);
                Registry.SetValue(keyName, "GameDVR_FSEBehaviorMode", "0", RegistryValueKind.DWord);
                Registry.SetValue(keyName2, "value", 1, RegistryValueKind.DWord);

                logger.Log("+ Game DVR feature has been successfully enabled.");
                logger.Log(keyName + Environment.NewLine + keyName2);
                return true;
            }
            catch
            { }

            return false;
        }
    }
}