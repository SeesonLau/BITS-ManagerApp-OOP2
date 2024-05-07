
namespace CpE_262_Project_IV
{
    public class MethodTextBox
    {
        public static void HandleTextBoxEnter(object? sender, EventArgs e)
        { 
            if (sender is TextBox textBox)
            {
                if (textBox.Text == textBox.Tag?.ToString())
                {
                    textBox.Text = "";
                    textBox.ForeColor = SystemColors.ControlText;
                }
            }
        }

        public static void HandleTextBoxLeave(object? sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = textBox.Tag?.ToString();
                    textBox.ForeColor = SystemColors.GrayText;
                }
            }
        }

        public static void HandleTextBoxTextChanged(object? sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (!textBox.Focused && string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = textBox.Tag?.ToString();
                    textBox.ForeColor = SystemColors.GrayText;
                }
            }
        }
        private static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private static string previousText = "";
        public static void txtbox_password_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                string text = textBox.Text;
                timer.Stop(); // Stop the timer if it is running
                              // SOLVES ISSUE WHEN USER TYPED FAST
                textBox.Text = new string('*', textBox.TextLength);
                textBox.SelectionStart = textBox.TextLength; // Set cursor position to end

                // Check the length of the text
                if (textBox.TextLength > 16)
                {
                    textBox.Text = textBox.Text.Substring(0, 16);
                    textBox.SelectionStart = textBox.TextLength; // Set cursor position to end
                }
                // Replace the entire text with * after a x delay
                timer.Interval = 50;
                timer.Tick += (s, _) =>
                {
                    if (textBox.TextLength > previousText.Length)
                    {
                        if (textBox.TextLength > 16)
                        {
                            textBox.Text = textBox.Text.Substring(0, 16);
                            textBox.SelectionStart = textBox.TextLength; // Set cursor position to end
                        }
                        else
                        {
                            textBox.Text = new string('*', textBox.TextLength);
                            textBox.SelectionStart = textBox.TextLength; // Set cursor position to end
                        }
                    }
                    previousText = textBox.Text;
                    timer.Stop();
                };
                timer.Start();// Start the timer
            }
        }
    }
}
