using Microsoft.Win32;
using System;
using System.Drawing;
using Winpilot;

namespace Walks
{
    public class CopilotMSEdge : WalksBase
    {
        public CopilotMSEdge(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string keyName = @"HKEY_CURRENT_USER\Software\Policies\Microsoft\Edge";

        public override string ID() => "Copilot in Edge";

        public override bool CheckFeature()
        {
            return Utils.IntEquals(keyName, "HubsSidebarEnabled", 1);
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "HubsSidebarEnabled", 1, Microsoft.Win32.RegistryValueKind.DWord);

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
                Registry.SetValue(keyName, "HubsSidebarEnabled", 0, Microsoft.Win32.RegistryValueKind.DWord);

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