using Microsoft.Win32;
using Winpilot;
using System;
using System.Drawing;

namespace Walks
{
    internal class DiagnosticData : WalksBase
    {
        public DiagnosticData(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Privacy";

        public override string ID()
        {
            return "Diagnostic data";
        }

        public override bool CheckFeature()
        {
            return !(
            Utils.IntEquals(keyName, "TailoredExperiencesWithDiagnosticDataEnabled", 0)
            );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "TailoredExperiencesWithDiagnosticDataEnabled", 1, RegistryValueKind.DWord);

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
                Registry.SetValue(keyName, "TailoredExperiencesWithDiagnosticDataEnabled", 0, RegistryValueKind.DWord);

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