using BloatyNosy;
using Microsoft.Win32;
using System;

namespace Features.Feature.Privacy
{
    internal class Telemetry : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string dataCollection = @"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\DataCollection";
        private const string diagTrack = @"HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\DiagTrack";
        private const string dmwappushservice = @"HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\dmwappushservice";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "[MIDDLE] Disable Connected User Experiences and Telemetry";
        }

        public override string Info()
        {
            return "This will prevent Windows from collecting usage information and setting diagnostic data to Basic, which is the lowest level available for all consumer versions of Windows 11.\n" +
                   "The services diagtrack & dmwappushservice will also be disabled.\nNOTE: Diagnostic Data must be set to Full to get preview builds from Windows-Insider-Program!";
        }

        public override bool CheckFeature()
        {
            // WindowsHelper.IsServiceRunning("DiagTrack");
            // WindowsHelper.IsServiceRunning("dmwappushservice");

            return !(
                 RegistryHelper.IntEquals(dataCollection, "AllowTelemetry", desiredValue) &&
                 RegistryHelper.IntEquals(diagTrack, "Start", 4) &&
                 RegistryHelper.IntEquals(dmwappushservice, "Start", 4)

             );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(dataCollection, "AllowTelemetry", desiredValue, RegistryValueKind.DWord);
                Registry.SetValue(diagTrack, "Start", 4, RegistryValueKind.DWord);
                Registry.SetValue(dmwappushservice, "Start", 4, RegistryValueKind.DWord);

                WindowsHelper.DisableService("DiagTrack");
                WindowsHelper.DisableService("dmwappushservice");

                logger.Log("- Connected User Experiences and Telemetry has been successfully disabled.");
                logger.Log(dataCollection + Environment.NewLine + diagTrack + Environment.NewLine + dmwappushservice);

                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable telemetry: {0}", ex.Message); }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                Registry.SetValue(dataCollection, "AllowTelemetry", 3, RegistryValueKind.DWord);
                Registry.SetValue(diagTrack, "Start", 2, RegistryValueKind.DWord);
                Registry.SetValue(dmwappushservice, "Start", 2, RegistryValueKind.DWord);

                WindowsHelper.EnableService("DiagTrack");
                WindowsHelper.EnableService("dmwappushservice");

                logger.Log("+ Connected User Experiences and Telemetry has been successfully enabled.");
                logger.Log(dataCollection + Environment.NewLine + diagTrack + Environment.NewLine + dmwappushservice);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not enable telemetry: {0}", ex.Message); }

            return false;
        }
    }
}