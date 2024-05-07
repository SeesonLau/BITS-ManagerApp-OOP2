using System.Drawing.Drawing2D;

namespace CpE_262_Project_IV
{
    public class RoundPanel : Panel
    {
        public int CornerRadius { get; set; } = 10;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, CornerRadius * 2, CornerRadius * 2, 180, 90);
            path.AddArc(Width - CornerRadius * 2, 0, CornerRadius * 2, CornerRadius * 2, 270, 90);
            path.AddArc(Width - CornerRadius * 2, Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 0, 90);
            path.AddArc(0, Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
        }
        public void RoundCorners(Control control, int radius)
        {
            // Create a graphics path
            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = control.ClientRectangle;

            // Add a rectangle to the path with rounded corners
            path.AddArc(bounds.X, bounds.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(bounds.Right - radius * 2, bounds.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(bounds.Right - radius * 2, bounds.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();

            // Set the panel's region to the rounded rectangle path
            control.Region = new Region(path);
        }
    }
}
