using Bloatynosy;
using Microsoft.Win32;
using System;

namespace Features.Feature.Privacy
{
    internal class Feedback : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string periodInNanoSeconds = @"HKEY_CURRENT_USER\Software\Microsoft\Siuf\Rules";
        private const string numberOfSIUFInPeriod = @"HKEY_CURRENT_USER\Software\Microsoft\Siuf\Rules";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "[HIGH] Disable Feedback notifications";
        }

        public override string Info()
        {
            return "Changes the Windows 11 feedback frequency from Automatically to Never.";
        }

        public override bool CheckFeature()
        {
            return !(
                   RegistryHelper.IntEquals(periodInNanoSeconds, "PeriodInNanoSeconds", desiredValue) &&
                    RegistryHelper.IntEquals(numberOfSIUFInPeriod, "NumberOfSIUFInPeriod", desiredValue)
            );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(periodInNanoSeconds, "PeriodInNanoSeconds", desiredValue, RegistryValueKind.DWord);
                Registry.SetValue(numberOfSIUFInPeriod, "NumberOfSIUFInPeriod", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Feedback has been successfully disabled.");
                logger.Log(periodInNanoSeconds + Environment.NewLine + numberOfSIUFInPeriod);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable Feedback {0}", ex.Message); }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                var RegKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Siuf\Rules", true);
                RegKey.DeleteValue("NumberOfSIUFInPeriod");
                RegKey.DeleteValue("PeriodInNanoSeconds");

                logger.Log("+ Feedback has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}