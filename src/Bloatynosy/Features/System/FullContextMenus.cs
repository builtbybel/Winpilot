using Bloatynosy;
using Microsoft.Win32;
using System;

namespace Features.Feature.System
{
    internal class FullContextMenus : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\SOFTWARE\CLASSES\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32";

        public override string ID()
        {
            return "Enable Full Context Menus in Windows 11";
        }

        public override string Info()
        {
            return "Truncated context menus are Windows 11's worst feature.";
        }

        public override bool CheckFeature()
        {
            return !(
                 RegistryHelper.StringEquals(keyName, "", "")
            );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "", "", RegistryValueKind.String);

                logger.Log("- Full Context Menus in Windows 11 have been enabled.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not enable Full Context Menus in Windows 11 {0}", ex.Message); }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                Registry.CurrentUser.DeleteSubKeyTree(@"Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}", false);
                logger.Log("+ Truncated context menus has been enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}