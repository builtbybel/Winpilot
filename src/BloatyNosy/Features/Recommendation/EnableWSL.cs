using BloatyNosy;
using System.Management.Automation;

namespace Features.Feature.Recommendation
{
    internal class EnableWSL : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        public override string ID()
        {
            return "[LOW] We've recommend enabling Microsoft Windows Subsystem for Linux";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckFeature()
        {
            string script = "Get-WindowsOptionalFeature -Online -FeatureName Microsoft-Windows-Subsystem-Linux";
            PowerShell powerShell = PowerShell.Create();
            powerShell.AddScript(script);
            var results = powerShell.Invoke();

            foreach (var item in results)
            {
                var Status = item.Members["State"].Value;

                if (Status.ToString() == "Enabled")
                {
                    logger.Log("Problem on Features: [SOLVED] We found a recommended feature on your system \"Microsoft Windows Subsystem for Linux\"");
                    return false;
                }
            }
            //logger.Log("Microsoft Windows Subsystem for Linux is disabled.");

            return true;
        }

        public override bool DoFeature()
        {
            string script = "Enable-WindowsOptionalFeature -Online -FeatureName Microsoft-Windows-Subsystem-Linux";

            PowerShell powerShell = PowerShell.Create();

            powerShell.AddScript(script);
            powerShell.Invoke();

            logger.Log("+ Microsoft Windows Subsystem for Linux has been successfully enabled.");
            return true;
        }

        public override bool UndoFeature()
        {
            string script = "Disable-WindowsOptionalFeature -Online -FeatureName Microsoft-Windows-Subsystem-Linux";

            PowerShell powerShell = PowerShell.Create();

            powerShell.AddScript(script);
            powerShell.Invoke();

            logger.Log("- Microsoft Windows Subsystem for Linux has been successfully disabled.");
            return true;
        }
    }
}