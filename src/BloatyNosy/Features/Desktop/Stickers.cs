using BloatyNosy;
using Microsoft.Win32;

namespace Features.Feature.Desktop
{
    internal class Stickers : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\current\device\Stickers";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "[HIGH] Remove Desktop Stickers";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckFeature()
        {
            return !(
               RegistryHelper.IntEquals(keyName, "EnableStickers", desiredValue)
             );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "EnableStickers", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Desktop Stickers has been removed.");
                logger.Log(keyName);
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
                Registry.SetValue(keyName, "EnableStickers", "1", RegistryValueKind.DWord);
                logger.Log("- Desktop Sticker feature has been enabled again.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}