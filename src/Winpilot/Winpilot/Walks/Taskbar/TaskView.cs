using Microsoft.Win32;
using Winpilot;
using System;
using System.Drawing;

namespace Walks
{
    internal class TaskView : WalksBase
    {
        public TaskView(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "Task view button on taskbar";
        }

        public override bool CheckFeature()
        {
            return !(
                   Utils.IntEquals(keyName, "ShowTaskViewButton", desiredValue)
             );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "ShowTaskViewButton", 1, RegistryValueKind.DWord);
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
                Registry.SetValue(keyName, "ShowTaskViewButton", desiredValue, RegistryValueKind.DWord);
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