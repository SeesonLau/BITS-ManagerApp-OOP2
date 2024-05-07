namespace CpE_262_Project_IV
{
    public class MethodPanel
    {
        private bool isDragging;
        private Point lastLocation;

        public void Attach(Control panel, Form form)
        {
            panel.MouseDown += Panel_MouseDown;
            panel.MouseMove += Panel_MouseMove;
            panel.MouseUp += Panel_MouseUp;
        }

        private void Panel_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastLocation = e.Location;
            }
        }
        private void Panel_MouseMove(object? sender, MouseEventArgs e)
        {
            if (isDragging && sender is Control control)
            {
                Form? form = control.FindForm();
                if (form != null)
                {
                    form.Location = new Point(
                        form.Location.X + (e.X - lastLocation.X),
                        form.Location.Y + (e.Y - lastLocation.Y));
                }
            }
        }

        private void Panel_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}
