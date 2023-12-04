using Bloatynosy;
using Microsoft.Win32;

namespace Features.Feature.Browser
{
    internal class EdgeBingAIButton : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "[HIGH] Disable giant Bing search (AI chat) button in Edge Browser";
        }

        public override string Info()
        {
            return "This policy may lead to the following behavior in Edge Browser:\r\nManaged by your organization, your browser is managed." +
                 "\r\nThe changes can be reverted at any time.";
        }

        public override bool CheckFeature()
        {
            return !(
               RegistryHelper.IntEquals(keyName, "HubsSidebarEnabled", desiredValue)
           );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "HubsSidebarEnabled", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Bing search (AI chat) button has been disabled.");
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
                var RegKey = Registry.LocalMachine.OpenSubKey(@"Software\Policies\Microsoft\Edge", true);
                RegKey.DeleteValue("HubsSidebarEnabled");

                logger.Log("+ Bing search (AI chat) button has been enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}