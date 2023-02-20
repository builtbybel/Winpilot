using BloatyNosy;
using Microsoft.Win32;

namespace Features.Feature.Desktop
{
    internal class AppsTheme : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "[LOW] Use Apps dark theme";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckFeature()
        {
            return !(
               RegistryHelper.IntEquals(keyName, "AppsUseLightTheme", desiredValue)
             );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "AppsUseLightTheme", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Apps dark theme has been successfully enabled.");
                logger.Log(keyName);

                logger.Log("\n\nDark theme will also be enabled for BloatyNosy.\nPlease restart the app for the changes to take effect.");

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
                Registry.SetValue(keyName, "AppsUseLightTheme", "1", RegistryValueKind.DWord);
                logger.Log("- Apps light theme has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}