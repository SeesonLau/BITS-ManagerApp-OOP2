using System.Drawing.Drawing2D;

namespace CpE_262_Project_IV
{
    public class RoundButton : Button
    {
        private Color _backgroundColor = Color.Transparent;

        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
                Invalidate(); // Redraw the button when the background color changes
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);

            this.Region = new Region(path);

            using (Brush brush = new SolidBrush(BackgroundColor))
            {
                e.Graphics.FillEllipse(brush, 0, 0, ClientSize.Width, ClientSize.Height);
            }
        }

    }
}
