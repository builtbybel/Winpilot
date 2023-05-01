using BloatyNosy;
using Microsoft.Win32;

namespace Features.Feature.Browser
{
    internal class FirefoxTelemetry : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox";
        private const int desiredValue = 1;

        public override string ID()
        {
            return "[HIGH] Disable Mozilla Firefox Telemetry";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckFeature()
        {
            return !(
               RegistryHelper.IntEquals(keyName, "DisableTelemetry", desiredValue) &&
               RegistryHelper.IntEquals(keyName, "DisableDefaultBrowserAgent", desiredValue)
           );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "DisableTelemetry", desiredValue, RegistryValueKind.DWord);
                Registry.SetValue(keyName, "DisableDefaultBrowserAgent", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Mozilla Firefox Telemetry has been disabled.");
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
                Registry.LocalMachine.DeleteSubKeyTree(@"Policies\Mozilla\Firefox", false);
                logger.Log("+ Mozilla Firefox Telemetry has been enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}