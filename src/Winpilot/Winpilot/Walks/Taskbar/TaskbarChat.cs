using Microsoft.Win32;
using Winpilot;
using System;
using System.Drawing;

namespace Walks
{
    internal class TaskbarChat : WalksBase
    {
        public TaskbarChat(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "Chat icon on taskbar";
        }

        public override bool CheckFeature()
        {
            return !(
                   Utils.IntEquals(keyName, "TaskbarMn", desiredValue)
             );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "TaskbarMn", 1, RegistryValueKind.DWord);
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
                Registry.SetValue(keyName, "TaskbarMn", 0, RegistryValueKind.DWord);
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