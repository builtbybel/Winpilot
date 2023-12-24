using Bloatynosy;
using Microsoft.Win32;
using System;

namespace Features.Feature.Privacy
{
    internal class LocationTracking : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\location";
        private const string desiredValue = @"Deny";

        public override string ID()
        {
            return "Disable Location tracking";
        }

        public override string Info()
        {
            return "Wherever you go, Windows 11 knows you're there. When Location Tracking is turned on, Windows and its apps are allowed to detect the current location of your computer or device.";
        }

        public override bool CheckFeature()
        {
            return !(
                  RegistryHelper.StringEquals(keyName, "Value", desiredValue)
            );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "Value", desiredValue, RegistryValueKind.String);

                logger.Log("- Location tracking has been successfully disabled.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable location tracking {0}", ex.Message); }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "Value", "Allow", RegistryValueKind.String);
                logger.Log("+ Location tracking info has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}