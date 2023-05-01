using BloatyNosy;
using Microsoft.Win32;
using System;

namespace Features.Feature.System
{
    internal class TPMCheck : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_LOCAL_MACHINE\SYSTEM\Setup\LabConfig";
        private const string keyName2 = @"HKEY_LOCAL_MACHINE\SYSTEM\Setup\MoSetup";
        private const int desiredValue = 1;

        public override string ID()
        {
            return "[LOW] Disable TPM 2.0 Check";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckFeature()
        {
            return !(
                 RegistryHelper.IntEquals(keyName, "BypassCPUCheck", desiredValue) &&
                 RegistryHelper.IntEquals(keyName, "BypassStorageCheck", desiredValue) &&
                 RegistryHelper.IntEquals(keyName, "BypassTPMCheck", desiredValue) &&
                 RegistryHelper.IntEquals(keyName, "BypassRAMCheck", desiredValue) &&
                 RegistryHelper.IntEquals(keyName, "BypassSecureBootCheck", desiredValue) &&
                 RegistryHelper.IntEquals(keyName2, "AllowUpgradesWithUnsupportedTPMOrCPU", desiredValue)
            );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "BypassCPUCheck", desiredValue, RegistryValueKind.DWord);
                Registry.SetValue(keyName, "BypassStorageCheck", desiredValue, RegistryValueKind.DWord);
                Registry.SetValue(keyName, "BypassTPMCheck", desiredValue, RegistryValueKind.DWord);
                Registry.SetValue(keyName, "BypassRAMCheck", desiredValue, RegistryValueKind.DWord);
                Registry.SetValue(keyName, "BypassSecureBootCheck", desiredValue, RegistryValueKind.DWord);
                Registry.SetValue(keyName2, "AllowUpgradesWithUnsupportedTPMOrCPU", desiredValue, RegistryValueKind.DWord);

                logger.Log("- TPM 2.0 Check has been successfully disabled.");
                logger.Log(keyName);
                logger.Log(keyName2);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable TPM 2.0 Check {0}", ex.Message); }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                Registry.LocalMachine.OpenSubKey(@"SYSTEM\Setup\LabConfig", true).DeleteValue("BypassTPMCheck", false);
                Registry.LocalMachine.OpenSubKey(@"SYSTEM\Setup\LabConfig", true).DeleteValue("BypassRAMCheck", false);
                Registry.LocalMachine.OpenSubKey(@"SYSTEM\Setup\LabConfig", true).DeleteValue("BypassSecureBootCheck", false);
                Registry.LocalMachine.OpenSubKey(@"SYSTEM\Setup\LabConfig", true).DeleteValue("BypassStorageCheck", false);
                Registry.LocalMachine.OpenSubKey(@"SYSTEM\Setup\LabConfig", true).DeleteValue("BypassCPUCheck", false);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\Setup\MoSetup", "AllowUpgradesWithUnsupportedTPMOrCPU", "0", RegistryValueKind.DWord);

                logger.Log("+ TPM 2.0 Check has been enabled again.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}