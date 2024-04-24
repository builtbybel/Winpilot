using Winpilot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public static class SwitchView
    {
        public static MainForm mainForm;
        public static Control INavPage;

        public static void SetView(Control View)
        {
            var control = View as Control;

            control.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            control.Dock = DockStyle.Fill;
            INavPage.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            INavPage.Dock = DockStyle.Fill;

            mainForm.pnlForm.Controls.Clear();
            mainForm.pnlForm.Controls.Add(View);
        }

        // Handle the back navigation
        public static void SetMainFormAsView()
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().Single();
            mainForm.pnlForm.Controls.Clear();
            if (INavPage != null) mainForm.pnlForm.Controls.Add(INavPage);
        }
    }
}
