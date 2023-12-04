using Bloatynosy;
using Microsoft.Win32;
using System;

namespace Features.Feature.Taskbar
{
    internal class StartmenuSearch : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\Explorer";
        private const int desiredValue = 1;

        public override string ID()
        {
            return "[HIGH] Disable start menu Bing search";
        }

        public override string Info()
        {
            return "This will disable web search recommendations from the start menu search bar.\nThere is no need for web search results there. That search should return local files and applications.";
        }

        public override bool CheckFeature()
        {
            return !(
                 RegistryHelper.IntEquals(keyName, "DisableSearchBoxSuggestions", desiredValue)
            );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "DisableSearchBoxSuggestions", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Start menu Bing search has been disabled.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable start menu Bing search {0}", ex.Message); }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                Registry.SetValue(keyName, "DisableSearchBoxSuggestions", 0, RegistryValueKind.DWord);
                logger.Log("+ Start menu Bing search has been enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}