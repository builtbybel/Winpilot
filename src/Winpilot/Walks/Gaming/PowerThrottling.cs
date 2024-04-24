using Winpilot;
using Microsoft.Win32;
using System;
using System.Drawing;

namespace Walks
{
    public class PowerThrottling : WalksBase
    {
        public PowerThrottling(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string keyName = @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Power\PowerThrottling";

        public override string ID() => "PowerThrottling";

        public override bool CheckFeature()
        {
            return !Utils.IntEquals(keyName, "PowerThrottlingOff", 1);
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "PowerThrottlingOff", 0, Microsoft.Win32.RegistryValueKind.DWord);

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
                Registry.SetValue(keyName, "PowerThrottlingOff", 1, Microsoft.Win32.RegistryValueKind.DWord);

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