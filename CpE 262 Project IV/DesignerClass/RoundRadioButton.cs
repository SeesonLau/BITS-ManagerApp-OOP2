using System.Drawing.Drawing2D;


namespace CpE_262_Project_IV
{
    public class RoundRadioButton : RadioButton
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a rounded rectangle region
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(ClientRectangle);

            // Apply the region to the control
            this.Region = new Region(path);
        }
        public void SetRoundedCorners(RadioButton radioButton, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(radioButton.ClientRectangle.Left, radioButton.ClientRectangle.Top, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(radioButton.ClientRectangle.Right - cornerRadius, radioButton.ClientRectangle.Top, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(radioButton.ClientRectangle.Right - cornerRadius, radioButton.ClientRectangle.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(radioButton.ClientRectangle.Left, radioButton.ClientRectangle.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();

            radioButton.Region = new Region(path);
        }
        public void SetCircularAppearance(RadioButton radioButton)
        {
            // Set the control size to be square
            int size = Math.Max(radioButton.Width, radioButton.Height);
            radioButton.Size = new Size(size, size);

            // Create a circular region
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, size, size);

            // Apply the circular region to the control
            radioButton.Region = new Region(path);

            // Set the appearance to button and remove border
            radioButton.FlatStyle = FlatStyle.Flat;
            radioButton.Appearance = Appearance.Button;
            radioButton.FlatAppearance.BorderSize = 0;
        }
        public void SetCircularGradientAppearance(RadioButton radioButton, Color startColor, Color endColor)
        {
            // Set the control size to be square
            int size = Math.Max(radioButton.Width, radioButton.Height);
            radioButton.Size = new Size(size, size);

            // Create a circular region
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, size, size);

            // Apply the circular region to the control
            radioButton.Region = new Region(path);

            // Set the appearance to button, remove border
            radioButton.FlatStyle = FlatStyle.Flat;
            radioButton.Appearance = Appearance.Button;
            radioButton.FlatAppearance.BorderSize = 0;

            // Subscribe to the Paint event
            radioButton.Paint += (sender, e) =>
            {
                // Create a linear gradient brush for the background
                Rectangle rect = new Rectangle(0, 0, size, size);
                LinearGradientBrush brush = new LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Vertical);

                // Fill the background with the gradient
                e.Graphics.FillEllipse(brush, rect);
            };
        }
    }
}
