using Microsoft.Win32;
using Winpilot;
using System;
using System.Drawing;

namespace Walks
{
    public class GameDVR: WalksBase
    {
        public GameDVR(MainForm form, Logger logger) : base(form, logger)
        {
        }
        private const string keyName = @"HKEY_CURRENT_USER\System\GameConfigStore";
        private const string keyName2 = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\ApplicationManagement\AllowGameDVR";

        public override string ID() => "GameDVR";


        public override bool CheckFeature()
        {
            return Utils.IntEquals(keyName, "GameDVR_Enabled", 1) &&
                    Utils.IntEquals(keyName, "GameDVR_FSEBehaviorMode", 0) &&
                    Utils.IntEquals(keyName2, "value", 1);
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "GameDVR_Enabled", 1, RegistryValueKind.DWord);
                Registry.SetValue(keyName, "GameDVR_FSEBehaviorMode",0 , RegistryValueKind.DWord);
                Registry.SetValue(keyName2, "value", 1, RegistryValueKind.DWord);


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
                Registry.SetValue(keyName, "GameDVR_Enabled", 0, RegistryValueKind.DWord);
                Registry.SetValue(keyName, "GameDVR_FSEBehaviorMode", 2, RegistryValueKind.DWord);
                Registry.SetValue(keyName2, "value", 0, RegistryValueKind.DWord);

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