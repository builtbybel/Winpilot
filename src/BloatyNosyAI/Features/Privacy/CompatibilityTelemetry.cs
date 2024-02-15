using Bloatynosy;
using Microsoft.Win32;
using System;

namespace Features.Feature.Privacy
{
    internal class CompatibilityTelemetry : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\CompatTelRunner.exe";
        private const string desiredValue = @"%windir%\System32\taskkill.exe";

        public override string ID()
        {
            return "Disable Compatibility Telemetry";
        }

        public override string Info()
        {
            return "This process is periodically collecting a variety of technical data about your computer and its performance and sending it to Microsoft for its Windows Customer Experience Improvement Program.";
        }

        public override bool CheckFeature()
        {
            return !(
          RegistryHelper.StringEquals(keyName, "Debugger", desiredValue)
           );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "Debugger", desiredValue, RegistryValueKind.String);
                logger.Log("- Compatibility Telemetry has been successfully disabled.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable compatibility telemetry: {0}", ex.Message); }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                var RegKey = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\CompatTelRunner.exe", true);
                RegKey.DeleteValue("Debugger");

                logger.Log("+ Compatibility Telemetry has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}