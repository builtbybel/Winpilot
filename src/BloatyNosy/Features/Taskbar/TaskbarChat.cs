using BloatyNosy;
using Microsoft.Win32;
using System;

namespace Features.Feature.Taskbar
{
    internal class TaskbarChat : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "[LOW] Hide Chat icon (Microsoft Teams) on taskbar";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckFeature()
        {
            return !(
                 RegistryHelper.IntEquals(keyName, "TaskbarMn", desiredValue)
            );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "TaskbarMn", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Chat icon has been disabled.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable chat icon {0}", ex.Message); }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "TaskbarMn", 1, RegistryValueKind.DWord);
                logger.Log("- Chat icon has been enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}