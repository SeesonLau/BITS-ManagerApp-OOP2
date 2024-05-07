namespace CpE_262_Project_IV
{
    partial class Passenger2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            btnLogout = new Button();
            btnHome = new Button();
            btnTicketing = new Button();
            btnHistory = new Button();
            panel4 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            passengerHome1 = new PassengerHome();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(12, 15, 29);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnHome);
            panel2.Controls.Add(btnTicketing);
            panel2.Controls.Add(btnHistory);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 829);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1440, 71);
            panel2.TabIndex = 16;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.FromArgb(61, 74, 96);
            btnLogout.BackgroundImageLayout = ImageLayout.Center;
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Image = Properties.Resources.Logout_50px;
            btnLogout.Location = new Point(840, 9);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(60, 50);
            btnLogout.TabIndex = 4;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnHome.BackColor = Color.FromArgb(61, 74, 96);
            btnHome.BackgroundImageLayout = ImageLayout.Center;
            btnHome.ForeColor = SystemColors.ActiveCaptionText;
            btnHome.Image = Properties.Resources.Structural_50px;
            btnHome.Location = new Point(748, 9);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(60, 50);
            btnHome.TabIndex = 2;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnTicketing
            // 
            btnTicketing.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTicketing.BackColor = Color.FromArgb(61, 74, 96);
            btnTicketing.BackgroundImageLayout = ImageLayout.Center;
            btnTicketing.ForeColor = SystemColors.ActiveCaptionText;
            btnTicketing.Image = Properties.Resources.Ticket_50px;
            btnTicketing.Location = new Point(564, 9);
            btnTicketing.Name = "btnTicketing";
            btnTicketing.Size = new Size(60, 50);
            btnTicketing.TabIndex = 0;
            btnTicketing.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            btnHistory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnHistory.BackColor = Color.FromArgb(61, 74, 96);
            btnHistory.BackgroundImageLayout = ImageLayout.Center;
            btnHistory.ForeColor = SystemColors.ActiveCaptionText;
            btnHistory.Image = Properties.Resources.Time_Machine_50px;
            btnHistory.Location = new Point(656, 9);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(60, 50);
            btnHistory.TabIndex = 1;
            btnHistory.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(12, 15, 29);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1430, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 819);
            panel4.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(12, 15, 29);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 10);
            panel1.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(12, 15, 29);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 819);
            panel3.TabIndex = 20;
            // 
            // passengerHome1
            // 
            passengerHome1.BackColor = Color.FromArgb(41, 50, 65);
            passengerHome1.Dock = DockStyle.Fill;
            passengerHome1.Location = new Point(10, 10);
            passengerHome1.Name = "passengerHome1";
            passengerHome1.Size = new Size(1420, 819);
            passengerHome1.TabIndex = 21;
            // 
            // Passenger2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 244, 216);
            ClientSize = new Size(1440, 900);
            Controls.Add(passengerHome1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Passenger2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Passenger2";
            Load += Passenger2_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnLogout;
        private Button btnHome;
        private Button btnTicketing;
        private Button btnHistory;
        private Panel panel4;
        private Panel panel1;
        private Panel panel3;
        private PassengerHome passengerHome1;
    }
}