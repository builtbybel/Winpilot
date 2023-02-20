using BloatyNosy;
using System.Management.Automation;

namespace Features.Feature.System
{
    internal class XPSWriter : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        public override string ID()
        {
            return "[LOW] Remove XPS Documents Writer";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckFeature()
        {
            string script = "Get-WindowsOptionalFeature -Online -FeatureName \"Printing-XPSServices-Features\"";

            PowerShell powerShell = PowerShell.Create();
            powerShell.AddScript(script);

            var results = powerShell.Invoke();

            foreach (var item in results)
            {
                var Status = item.Members["State"].Value;

                if (Status.ToString() == "Enabled")
                {
                    // logger.Log("XPS Documents Writer is installed.");
                    return true;
                }
            }
            //logger.Log("XPS Documents Writer not found.");

            return false;
        }

        public override bool DoFeature()
        {
            string script = "Disable-WindowsOptionalFeature -Online -FeatureName \"Printing-XPSServices-Features\" -NoRestart -WarningAction SilentlyContinue | Out-Null";
            PowerShell powerShell = PowerShell.Create();
            powerShell.AddScript(script);
            var results = powerShell.Invoke();

            if (powerShell.Streams.Error.Count > 0)
            {
                logger.Log("XPS Documents Writer not found.");
                return false;
            }

            logger.Log("- XPS Documents Writer has been successfully removed.");
            return true;
        }

        public override bool UndoFeature()
        {
            string script = "Enable-WindowsOptionalFeature -Online -FeatureName \"Printing-XPSServices-Features\" -NoRestart -WarningAction SilentlyContinue | Out-Null";
            PowerShell powerShell = PowerShell.Create();
            powerShell.AddScript(script);

            var results = powerShell.Invoke();
            if (powerShell.Streams.Error.Count > 0)
            {
                logger.Log("XPS Documents Writer could not be installed.");
                return false;
            }

            logger.Log("- XPS Documents Writer has been successfully installed.");
            return true;
        }
    }
}