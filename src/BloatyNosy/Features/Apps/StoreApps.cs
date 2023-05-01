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
            return "*[HIGH] Search and remove pre-installed bloatware apps automatically (Right-click to remove bloatware manually)";
        }

        public override string Info()
        {
            return "To remove specific apps use the AppyTrash app in the \"More Apps\" section or right click on this feature";
        }

        private void RemoveApps(string str)
        {
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
            }

            return;
        }

        public override bool CheckFeature()
        {
            var apps = BloatwareList.GetList();

            powerShell.Commands.Clear();
            powerShell.AddCommand("get-appxpackage");
            powerShell.AddCommand("Select").AddParameter("property", "name");

            logger.Log("We found the following bloatware on your system: (if no apps are listed, then nothing was found)");

            foreach (PSObject result in powerShell.Invoke())
            {
                string current = result.ToString();

                if (!apps.Contains(Regex.Replace(current, "(@{Name=)|(})", ""))) continue;
                logger.Log("- " + (Regex.Replace(current, "(@{Name=)|(})", "")));
            }
            return true;
        }

        public override bool DoFeature()
        {
            var apps = BloatwareList.GetList();

            logger.Log("Searching bloatware database...");
            foreach (var str in apps)
            {
                logger.Log("- Uninstalling " + str.ToString());
                RemoveApps(str);
            }

            return true;
        }

        public override bool UndoFeature()
        {
            logger.Log("-[RemoveStoreApps] This feature does not provide a restore mode.");
            return false;
        }
    }
}