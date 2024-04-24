using Microsoft.Win32;
using Winpilot;
using System;
using System.Drawing;

namespace Walks
{
    public class Telemetry : WalksBase
    {
        public Telemetry(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string dataCollection = @"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\DataCollection";
        private const string diagTrack = @"HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\DiagTrack";
        private const string dmwappushservice = @"HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\dmwappushservice";

        public override string ID() => "Send optional diagnostic data";

        public override bool CheckFeature()
        {
            return (
               Utils.IntEquals(dataCollection, "AllowTelemetry", 3) &&
                Utils.IntEquals(dataCollection, "MaxTelemetryAllowed", 3) &&
                Utils.IntEquals(diagTrack, "Start", 4) &&
                Utils.IntEquals(dmwappushservice, "Start", 4)

           );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(dataCollection, "AllowTelemetry", 3, RegistryValueKind.DWord);
                Registry.SetValue(dataCollection, "MaxTelemetryAllowed", 3, RegistryValueKind.DWord);
                Registry.SetValue(diagTrack, "Start", 4, RegistryValueKind.DWord);
                Registry.SetValue(dmwappushservice, "Start", 4, RegistryValueKind.DWord);

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
                Registry.SetValue(dataCollection, "AllowTelemetry", 1, RegistryValueKind.DWord);
                Registry.SetValue(dataCollection, "MaxTelemetryAllowed", 1, RegistryValueKind.DWord);
                Registry.SetValue(diagTrack, "Start", 2, RegistryValueKind.DWord);
                Registry.SetValue(dmwappushservice, "Start", 2, RegistryValueKind.DWord);

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