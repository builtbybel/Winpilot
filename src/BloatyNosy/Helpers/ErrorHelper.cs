using System;
using System.Windows.Forms;

namespace Bloatynosy
{ 
    internal class ErrorHelper
    {
        private static readonly ErrorHelper instance = new ErrorHelper();
        private static RichTextBox target = null;

        private ErrorHelper() { }  // Private constructor to prevent external instantiation

        // Errorlogger to target richLog
        public void SetTarget(RichTextBox richText)
        {
            target = richText;
        }

        public void Log(string format, params object[] args)
        {
            format += "\r\n";

            try
            {
                if (target.InvokeRequired)
                {
                    target.Invoke(new Action(() => target.AppendText(string.Format(format, args))));
                }
                else
                {
                    target.AppendText(string.Format(format, args));
                }
            }
            catch { }
        }

        public void ClearLog()
        {
            try
            {
                if (target.InvokeRequired)
                {
                    target.Invoke(new Action(() => target.Clear()));
                }
                else
                {
                    target.Clear();
                }
            }
            catch { }
        }

        public static ErrorHelper Instance
        {
            get => instance;
        }
    }
}
