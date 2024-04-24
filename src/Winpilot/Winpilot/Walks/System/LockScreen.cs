using Microsoft.Win32;
using Winpilot;
using System;
using System.Drawing;

namespace Walks
{
    internal class LockScreen : WalksBase
    {
        public LockScreen(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Personalization";
        private const int desiredValue = 1;

        public override string ID()
        {
            return "Lock screen";
        }

        public override bool CheckFeature()
        {
            return !(
                   Utils.IntEquals(keyName, "NoLockScreen", desiredValue)
             );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "NoLockScreen", 0, RegistryValueKind.DWord);
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
                Registry.SetValue(keyName, "NoLockScreen", desiredValue, RegistryValueKind.DWord);

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