using Microsoft.Win32;
using Winpilot;
using System;
using System.Drawing;
using System.Management.Automation;

namespace Walks
{
    internal class FaxPrinter : WalksBase
    {
        public FaxPrinter(MainForm form, Logger logger) : base(form, logger)
        {
        }

        public override string ID()
        {
            return "Uninstall Fax Printer";
        }

        public override bool CheckFeature()
        {
            return false;
        }

        public override bool DoFeature()
        {
            string script = "Remove-Printer -Name \"Fax\"";

            PowerShell powerShell = PowerShell.Create();

            powerShell.AddScript(script);
            powerShell.Invoke();

            if (powerShell.Streams.Error.Count > 0)
            {
                return false;
            }
            return true;
        }

        public override bool UndoFeature()
        {
            return true;
        }
    }
}