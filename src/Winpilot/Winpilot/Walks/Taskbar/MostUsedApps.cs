using Microsoft.Win32;
using Winpilot;
using System;
using System.Drawing;

namespace Walks
{
    internal class MostUsedApps : WalksBase
    {
        public MostUsedApps(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Explorer";
        private const int desiredValue = 2;

        public override string ID()
        {
            return "Most used apps in start menu";
        }

        public override bool CheckFeature()
        {
            return (
                   Utils.IntEquals(keyName, "ShowOrHideMostUsedApps", desiredValue)
             );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "ShowOrHideMostUsedApps", 2, RegistryValueKind.DWord);
                return true;
            }
            catch (Exception ex)
            {
                logger.Log("Code red in " + ex.Message, Color.Red);
            }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                var RegKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\Explorer", true);
                RegKey.DeleteValue("ShowOrHideMostUsedApps");
                return true;
            }
            catch (Exception ex)
            {
                logger.Log("Code red in " + ex.Message, Color.Red);
            }

            return false;
        }
    }
}