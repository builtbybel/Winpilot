using Bloatynosy;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace Features.Feature.Desktop
{
    internal class WidgetsRemove : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        public override string ID()
        {
            return "[MIDDLE] Uninstall Widgets feature";
        }

        public override string Info()
        {
            return "The Widgets app runs in the background even with the option turned off.\nThis will uninstall the Widgets app package.";
        }

        public override bool CheckFeature()
        {
            var appPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Packages", "MicrosoftWindows.Client.WebExperience_cw5n1h2txyewy");

            if (!Directory.Exists(appPath))
            {
                return false;
            }

            return true;
        }

        public override bool DoFeature()
        {
            try
            {
                using (var client = new WebClient())
                {
                    logger.Log("- Uninstalling Widgets app");
                    WindowsHelper.RunWT("winget uninstall \"windows web experience pack\" --silent");
                    logger.Log("Done.");
                    return true;
                }
            }
            catch (Exception ex)
            { logger.Log("{0}", ex.Message); }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                using (var client = new WebClient())
                {
                    logger.Log("+ Installing Widgets app...\nWe've opened the download link in the Microsoft Store.\nPlease install the package \"Windows Web Experience Pack\". ");
                    Process.Start("ms-windows-store://pdp/?ProductId=9MSSGKG348SP");

                    return true;
                }
            }
            catch (Exception ex)
            { logger.Log("{0}", ex.Message); }

            return false;
        }
    }
}