using BloatyNosy;
using Microsoft.Win32;
using System;

namespace Features.Feature.Privacy
{
    internal class Biometrics : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Biometrics";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "[LOW] Disable Windows Hello Biometrics";
        }

        public override string Info()
        {
            return "Windows Hello biometrics lets you sign in to your devices, apps, online services, and networks using your face, iris, or fingerprint.";
        }

        public override bool CheckFeature()
        {
            return !(
             RegistryHelper.IntEquals(keyName, "Enabled", desiredValue)
           );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "Enabled", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Windows Hello Biometrics has been successfully disabled.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable Windows Hello Biometrics {0}", ex.Message); }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "Enabled", 1, RegistryValueKind.DWord);
                logger.Log("- Windows Hello Biometrics has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}