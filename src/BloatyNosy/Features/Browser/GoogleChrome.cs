using BloatyNosy;
using Microsoft.Win32;

namespace Features.Feature.Browser
{
    internal class ChromeTelemetry : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "[HIGH] Disable Google Chrome Telemetry";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckFeature()
        {
            return !(
               RegistryHelper.IntEquals(keyName, "MetricsReportingEnabled", desiredValue) &&
               RegistryHelper.IntEquals(keyName, "ChromeCleanupReportingEnabled", desiredValue) &&
               RegistryHelper.IntEquals(keyName, "SubscribedContent-353696Enabled", desiredValue)
           );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "MetricsReportingEnabled", desiredValue, RegistryValueKind.DWord);
                Registry.SetValue(keyName, "ChromeCleanupReportingEnabled", desiredValue, RegistryValueKind.DWord);
                Registry.SetValue(keyName, "SubscribedContent-353696Enabled", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Google Chrome Telemetry has been disabled.");
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
                Registry.LocalMachine.DeleteSubKeyTree(@"Software\Policies\Google\Chrome", false);
                logger.Log("+ Google Chrome Telemetry has been enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}