namespace CpE_262_Project_IV
{
    partial class Passenger
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnLogout = new Button();
            btnHome = new Button();
            btnTicketing = new Button();
            btnHistory = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            passengerHome2 = new PassengerHome();
            passengerHistory1 = new PassengerHistory();
            passengerTicket1 = new PassengerTicket();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(12, 15, 29);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 10);
            panel1.TabIndex = 0;
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
            panel2.TabIndex = 15;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.FromArgb(61, 74, 96);
            btnLogout.BackgroundImageLayout = ImageLayout.Center;
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Image = Properties.Resources.Logout_50px;
            btnLogout.Location = new Point(845, 9);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(60, 50);
            btnLogout.TabIndex = 4;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnHome.BackColor = Color.FromArgb(61, 74, 96);
            btnHome.BackgroundImageLayout = ImageLayout.Center;
            btnHome.ForeColor = SystemColors.ActiveCaptionText;
            btnHome.Image = Properties.Resources.Structural_50px;
            btnHome.Location = new Point(753, 9);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(60, 50);
            btnHome.TabIndex = 2;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnTicketing
            // 
            btnTicketing.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTicketing.BackColor = Color.FromArgb(61, 74, 96);
            btnTicketing.BackgroundImageLayout = ImageLayout.Center;
            btnTicketing.ForeColor = SystemColors.ActiveCaptionText;
            btnTicketing.Image = Properties.Resources.Ticket_50px;
            btnTicketing.Location = new Point(569, 9);
            btnTicketing.Name = "btnTicketing";
            btnTicketing.Size = new Size(60, 50);
            btnTicketing.TabIndex = 0;
            btnTicketing.UseVisualStyleBackColor = false;
            btnTicketing.Click += btnTicketing_Click;
            // 
            // btnHistory
            // 
            btnHistory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnHistory.BackColor = Color.FromArgb(61, 74, 96);
            btnHistory.BackgroundImageLayout = ImageLayout.Center;
            btnHistory.ForeColor = SystemColors.ActiveCaptionText;
            btnHistory.Image = Properties.Resources.Time_Machine_50px;
            btnHistory.Location = new Point(661, 9);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(60, 50);
            btnHistory.TabIndex = 1;
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(12, 15, 29);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 819);
            panel3.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(12, 15, 29);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1430, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 819);
            panel4.TabIndex = 17;
            // 
            // passengerHome2
            // 
            passengerHome2.BackColor = Color.FromArgb(41, 50, 65);
            passengerHome2.Dock = DockStyle.Fill;
            passengerHome2.Location = new Point(10, 10);
            passengerHome2.Name = "passengerHome2";
            passengerHome2.Size = new Size(1420, 819);
            passengerHome2.TabIndex = 18;
            // 
            // passengerHistory1
            // 
            passengerHistory1.BackColor = Color.FromArgb(17, 22, 43);
            passengerHistory1.Dock = DockStyle.Fill;
            passengerHistory1.Location = new Point(10, 10);
            passengerHistory1.Name = "passengerHistory1";
            passengerHistory1.Size = new Size(1420, 819);
            passengerHistory1.TabIndex = 19;
            // 
            // passengerTicket1
            // 
            passengerTicket1.BackColor = Color.FromArgb(17, 22, 43);
            passengerTicket1.Dock = DockStyle.Fill;
            passengerTicket1.Location = new Point(10, 10);
            passengerTicket1.Name = "passengerTicket1";
            passengerTicket1.Size = new Size(1420, 819);
            passengerTicket1.TabIndex = 20;
            // 
            // Passenger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 244, 216);
            ClientSize = new Size(1440, 900);
            Controls.Add(passengerTicket1);
            Controls.Add(passengerHistory1);
            Controls.Add(passengerHome2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Passenger";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F4Passenger";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnTicketing;
        private Button btnLogout;
        private Button btnHome;
        private Button btnHistory;
        private PassengerTicket ticketing1;
        private PassengerHistory travelHistory1;
        private PassengerHome passengerHome1;
        private PassengerHome passengerHome2;
        private PassengerHistory passengerHistory1;
        private PassengerTicket passengerTicket1;
    }
}