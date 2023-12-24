using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ToggleSwitch : CheckBox
{
    public ToggleSwitch()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        Padding = new Padding(6);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        this.OnPaintBackground(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using (var path = new GraphicsPath())
        {
            var d = Padding.All;
            var r = Height - 2 * d;
            var trackRect = new RectangleF(d, d, Width - 2 * d, r);

            // Draw rounded rectangle track
            path.AddArc(trackRect.X, trackRect.Y, r, r, 90, 180);
            path.AddArc(trackRect.Right - r, trackRect.Y, r, r, -90, 180);
            path.CloseFigure();
            e.Graphics.FillPath(Checked ? Brushes.DarkGray : Brushes.Gray, path);

            // Draw circular thumb
            r = Height - 2 * d;
            var thumbRect = Checked ? new RectangleF(Width - r - d, d, r, r) : new RectangleF(d, d, r, r);
            e.Graphics.FillEllipse(Checked ? Brushes.DeepPink : Brushes.Thistle, thumbRect);
        }
    }
}
