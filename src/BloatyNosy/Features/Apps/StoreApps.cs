using BloatyNosy;
using System.Linq;
using System.Management.Automation;
using System.Text.RegularExpressions;

namespace Features.Feature.Apps
{
    internal class StoreApps : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        private readonly PowerShell powerShell = PowerShell.Create();

        public override string ID()
        {
            return "*[HIGH] Search and remove pre-installed bloatware apps automatically (Configure with a right-click)";
        }

        public override string Info()
        {
            return "To remove specific apps use the BloatPilot app in the \"More Apps\" section or right click on this feature";
        }

        private void RemoveApps(string str, out bool removed)
        {
            removed = false;
            bool error = false;
            using (PowerShell script = PowerShell.Create())
            {
                script.AddScript("Get-AppxPackage " + str + " | Remove-AppxPackage");
                script.Invoke();
                error = script.HadErrors;
            }

            if (error)
            {
                logger.Log("Error removing " + str);
            }
            else
            {
                logger.Log("App removed " + str);
                removed = true;
            }
        }

        public override bool CheckFeature()
        {
            var apps = BloatwareList.GetList();

            powerShell.Commands.Clear();
            powerShell.AddCommand("get-appxpackage");
            powerShell.AddCommand("Select").AddParameter("property", "name");

            bool foundMatches = false; // Flag variable to track if matches are found
            logger.Log("The following bloatware has been found:");

            foreach (PSObject result in powerShell.Invoke())
            {
                string current = result.Properties["Name"].Value.ToString();

                if (apps.Contains(Regex.Replace(current, "(@{Name=)|(})", "")))
                {

                    foundMatches = true;
                    logger.Log((Regex.Replace(current, "(@{Name=)|(})", "")));
                }
            }

            if (!foundMatches)
            {
                logger.Log("Your system is free of bloatware.");
            }

            return foundMatches; // Return value of foundMatches
        }

        public override bool DoFeature()
        {
            var apps = BloatwareList.GetList();
            logger.Log("Searching bloatware database...");
            bool foundAndDeleted = false;

            foreach (var str in apps)
            {
                RemoveApps(str, out bool removed);
                if (removed)
                {
                    logger.Log("[-] Uninstalled " + str.ToString());
                    foundAndDeleted = true;
                }
            }

            return foundAndDeleted;
        }

        public override bool UndoFeature()
        {
            logger.Log("-[Remove Store Apps] This feature does not provide a restore mode.");
            return false;
        }
    }
}