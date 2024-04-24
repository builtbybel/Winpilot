using Microsoft.Win32;
using Winpilot;
using System;
using System.Drawing;
using System.Management.Automation;
using System.Threading.Tasks;

namespace Walks
{
    internal class XPSWriter : WalksBase
    {
        public XPSWriter(MainForm form, Logger logger) : base(form, logger)
        {
        }

        public override string ID()
        {
            return "Uninstall XPS Writer";
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
                    // logger.Log("XPS Documents Writer is installed.", Color.Green);
                    return false;
                }
            }
           // logger.Log("XPS Documents Writer not found.", Color.Red);

            return true;
        }

        public override bool DoFeature()
        {
            logger.Log("I am uninstalling XPS Documents Writer. Please wait.", Color.Magenta);

            string script = "Disable-WindowsOptionalFeature -Online -FeatureName \"Printing-XPSServices-Features\" -NoRestart -WarningAction SilentlyContinue | Out-Null";
            PowerShell powerShell = PowerShell.Create();
            powerShell.AddScript(script);

            Task.Run(() =>
            {
                var results = powerShell.Invoke();

                if (powerShell.Streams.Error.Count > 0)
                {
                    logger.Log("= XPS Documents Writer not found.", Color.Red);
                }
                else
                {
                    logger.Log("XPS Documents Writer has been successfully removed.", Color.Green);
                }
            });

            return true;
        }


        public override bool UndoFeature()
        {
            logger.Log("I am diving back into this sh*t show, reinstalling 'XPS Documents Writer' once more, man. Hang tight!", Color.Magenta);

            string script = "Enable-WindowsOptionalFeature -Online -FeatureName \"Printing-XPSServices-Features\" -NoRestart -WarningAction SilentlyContinue | Out-Null";
            PowerShell powerShell = PowerShell.Create();
            powerShell.AddScript(script);

            Task.Run(() =>
            {
                var results = powerShell.Invoke();

                if (powerShell.Streams.Error.Count > 0)
                {
                    logger.Log("XPS Documents Writer could not be installed.", Color.Red);
                }
                else
                {
                    logger.Log("XPS Documents Writer has been successfully installed.", Color.Green);
                }
            });

            return true;
        }

    }
}