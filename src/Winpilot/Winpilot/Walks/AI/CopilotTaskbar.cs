using Microsoft.Win32;
using System;
using System.Drawing;
using Winpilot;

namespace Walks
{
    public class CopilotTaskbar : WalksBase
    {
        public CopilotTaskbar(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string keyName = @"HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows";

        public override string ID() => "Copilot in Taskbar";

        public override bool CheckFeature()
        {
            return Utils.IntEquals(keyName, "TurnOffWindowsCopilot", 0);
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "TurnOffWindowsCopilot", 0, Microsoft.Win32.RegistryValueKind.DWord);

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
                Registry.SetValue(keyName, "TurnOffWindowsCopilot", 1, Microsoft.Win32.RegistryValueKind.DWord);

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