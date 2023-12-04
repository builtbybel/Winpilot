using Bloatynosy;
using Microsoft.Win32;
using System;

namespace Features.Feature.System
{
    internal class TeamsAutostart : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
        private string desiredValue = string.Format("C:\\Users\\{0}\\AppData\\Local\\Microsoft\\Teams\\Update.exe --processStart \"Teams.exe\" --process-start-args \"--system-initiated", Environment.UserName);

        public override string ID()
        {
            return "[LOW] Disable Microsoft Teams on Startup";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckFeature()
        {
            string AppValue = "com.squirrel.Teams.Teams";

            if (Registry.GetValue(keyName, AppValue, null) == null)
            {
                logger.Log("Problem on System: [SOLVED] Teams AutoStart is already disabled.");
                return false;
            }
            else
            {
                // logger.Log("Teams AutoStart is enabled.");
                return true;
            }
        }

        public override bool DoFeature()
        {
            try
            {
                var RegKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                RegKey.DeleteValue("com.squirrel.Teams.Teams");

                logger.Log("- Teams AutoStart has been disabled.");
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
                Registry.SetValue(keyName, "com.squirrel.Teams.Teams", desiredValue, RegistryValueKind.String);

                logger.Log("+ Teams AutoStart has been enabled again.");
                logger.Log(keyName);
                return true;
            }
            catch
            { }

            return false;
        }
    }
}