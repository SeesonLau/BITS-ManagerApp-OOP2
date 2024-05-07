namespace CpE_262_Project_IV
{
    partial class Admin
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnClose = new Button();
            label1 = new Label();
            btnMinimize = new Button();
            pbHam = new PictureBox();
            flpSidebar = new FlowLayoutPanel();
            panel12 = new Panel();
            btnHome = new Button();
            flpMenuContainer = new FlowLayoutPanel();
            panel2 = new Panel();
            btnUserSelection = new Button();
            panel5 = new Panel();
            btnDriver = new Button();
            panel6 = new Panel();
            btnPassenger = new Button();
            panel7 = new Panel();
            btnManageTicketing = new Button();
            panel13 = new Panel();
            btnManageAccounts = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel11 = new Panel();
            btnStatistics = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel3 = new Panel();
            btnAbout = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel10 = new Panel();
            btnLogout = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            adminManageTicketing1 = new AdminManageTicketing();
            adminManageAccount1 = new AdminManageAccount();
            adminStatistics1 = new AdminStatistics();
            panelAbout = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHam).BeginInit();
            flpSidebar.SuspendLayout();
            panel12.SuspendLayout();
            flpMenuContainer.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel13.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel11.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel10.SuspendLayout();
            panelAbout.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(12, 15, 29);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(pbHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 46);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(254, 202, 114);
            btnClose.BackgroundImage = Properties.Resources.Close_25px;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Location = new Point(1398, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(229, 186, 115);
            label1.Location = new Point(618, 11);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 1;
            label1.Text = "Manager App";
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.FromArgb(254, 202, 114);
            btnMinimize.BackgroundImage = Properties.Resources.Minus_25px;
            btnMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimize.Location = new Point(1362, 7);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.TabIndex = 2;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // pbHam
            // 
            pbHam.BackgroundImage = Properties.Resources.Menu_32px;
            pbHam.Location = new Point(3, 7);
            pbHam.Name = "pbHam";
            pbHam.Size = new Size(34, 31);
            pbHam.SizeMode = PictureBoxSizeMode.CenterImage;
            pbHam.TabIndex = 0;
            pbHam.TabStop = false;
            pbHam.Click += pbHam_Click;
            // 
            // flpSidebar
            // 
            flpSidebar.BackColor = Color.FromArgb(41, 50, 65);
            flpSidebar.Controls.Add(panel12);
            flpSidebar.Controls.Add(flpMenuContainer);
            flpSidebar.Controls.Add(panel7);
            flpSidebar.Controls.Add(panel13);
            flpSidebar.Controls.Add(flowLayoutPanel2);
            flpSidebar.Controls.Add(flowLayoutPanel3);
            flpSidebar.Controls.Add(flowLayoutPanel1);
            flpSidebar.Dock = DockStyle.Left;
            flpSidebar.Location = new Point(0, 46);
            flpSidebar.Margin = new Padding(0);
            flpSidebar.Name = "flpSidebar";
            flpSidebar.Padding = new Padding(0, 80, 0, 0);
            flpSidebar.Size = new Size(200, 854);
            flpSidebar.TabIndex = 3;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(41, 50, 65);
            panel12.Controls.Add(btnHome);
            panel12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel12.ForeColor = Color.FromArgb(229, 186, 115);
            panel12.Location = new Point(0, 80);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Size = new Size(200, 50);
            panel12.TabIndex = 14;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(41, 50, 65);
            btnHome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Image = Properties.Resources.Home_32px1;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(-22, -30);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(25, 0, 0, 0);
            btnHome.Size = new Size(235, 102);
            btnHome.TabIndex = 11;
            btnHome.Text = "             Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // flpMenuContainer
            // 
            flpMenuContainer.BackColor = Color.FromArgb(41, 50, 65);
            flpMenuContainer.Controls.Add(panel2);
            flpMenuContainer.Controls.Add(panel5);
            flpMenuContainer.Controls.Add(panel6);
            flpMenuContainer.ForeColor = Color.FromArgb(229, 186, 115);
            flpMenuContainer.Location = new Point(0, 130);
            flpMenuContainer.Margin = new Padding(0);
            flpMenuContainer.Name = "flpMenuContainer";
            flpMenuContainer.Size = new Size(200, 50);
            flpMenuContainer.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Wheat;
            panel2.Controls.Add(btnUserSelection);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(203, 50);
            panel2.TabIndex = 10;
            // 
            // btnUserSelection
            // 
            btnUserSelection.BackColor = Color.FromArgb(41, 50, 65);
            btnUserSelection.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUserSelection.Image = Properties.Resources.Select_User_32px;
            btnUserSelection.ImageAlign = ContentAlignment.MiddleLeft;
            btnUserSelection.Location = new Point(-22, -28);
            btnUserSelection.Margin = new Padding(0);
            btnUserSelection.Name = "btnUserSelection";
            btnUserSelection.Padding = new Padding(25, 0, 0, 0);
            btnUserSelection.Size = new Size(235, 102);
            btnUserSelection.TabIndex = 9;
            btnUserSelection.Text = " User Selection";
            btnUserSelection.UseVisualStyleBackColor = false;
            btnUserSelection.Click += btnUserSelection_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Cornsilk;
            panel5.Controls.Add(btnDriver);
            panel5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel5.Location = new Point(0, 50);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(203, 50);
            panel5.TabIndex = 11;
            // 
            // btnDriver
            // 
            btnDriver.BackColor = Color.FromArgb(61, 74, 96);
            btnDriver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDriver.Image = Properties.Resources.Driver_32px;
            btnDriver.ImageAlign = ContentAlignment.MiddleLeft;
            btnDriver.Location = new Point(-22, -28);
            btnDriver.Margin = new Padding(0);
            btnDriver.Name = "btnDriver";
            btnDriver.Padding = new Padding(25, 0, 0, 0);
            btnDriver.Size = new Size(235, 102);
            btnDriver.TabIndex = 9;
            btnDriver.Text = "Driver";
            btnDriver.UseVisualStyleBackColor = false;
            btnDriver.Click += btnDriver_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Cornsilk;
            panel6.Controls.Add(btnPassenger);
            panel6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel6.Location = new Point(0, 100);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(203, 50);
            panel6.TabIndex = 12;
            // 
            // btnPassenger
            // 
            btnPassenger.BackColor = Color.FromArgb(61, 74, 96);
            btnPassenger.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPassenger.Image = Properties.Resources.Passenger_32px;
            btnPassenger.ImageAlign = ContentAlignment.MiddleLeft;
            btnPassenger.Location = new Point(-22, -28);
            btnPassenger.Margin = new Padding(0);
            btnPassenger.Name = "btnPassenger";
            btnPassenger.Padding = new Padding(25, 0, 0, 0);
            btnPassenger.Size = new Size(235, 102);
            btnPassenger.TabIndex = 9;
            btnPassenger.Text = "Passenger";
            btnPassenger.UseVisualStyleBackColor = false;
            btnPassenger.Click += btnPassenger_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(41, 50, 65);
            panel7.Controls.Add(btnManageTicketing);
            panel7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel7.ForeColor = Color.FromArgb(229, 186, 115);
            panel7.Location = new Point(0, 180);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 50);
            panel7.TabIndex = 13;
            // 
            // btnManageTicketing
            // 
            btnManageTicketing.BackColor = Color.FromArgb(41, 50, 65);
            btnManageTicketing.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageTicketing.Image = Properties.Resources.TicketMain_32px;
            btnManageTicketing.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageTicketing.Location = new Point(-22, -24);
            btnManageTicketing.Margin = new Padding(0);
            btnManageTicketing.Name = "btnManageTicketing";
            btnManageTicketing.Padding = new Padding(25, 0, 0, 0);
            btnManageTicketing.Size = new Size(235, 102);
            btnManageTicketing.TabIndex = 10;
            btnManageTicketing.Text = "       Manage Ticketing";
            btnManageTicketing.UseVisualStyleBackColor = false;
            btnManageTicketing.Click += btnManageTicketing_Click;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(41, 50, 65);
            panel13.Controls.Add(btnManageAccounts);
            panel13.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel13.ForeColor = Color.FromArgb(229, 186, 115);
            panel13.Location = new Point(0, 230);
            panel13.Margin = new Padding(0);
            panel13.Name = "panel13";
            panel13.Size = new Size(200, 50);
            panel13.TabIndex = 14;
            // 
            // btnManageAccounts
            // 
            btnManageAccounts.BackColor = Color.FromArgb(41, 50, 65);
            btnManageAccounts.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageAccounts.Image = Properties.Resources.UserSettings_32px;
            btnManageAccounts.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageAccounts.Location = new Point(-22, -28);
            btnManageAccounts.Margin = new Padding(0);
            btnManageAccounts.Name = "btnManageAccounts";
            btnManageAccounts.Padding = new Padding(25, 0, 0, 0);
            btnManageAccounts.Size = new Size(235, 102);
            btnManageAccounts.TabIndex = 10;
            btnManageAccounts.Text = "       Manage Accounts";
            btnManageAccounts.UseVisualStyleBackColor = false;
            btnManageAccounts.Click += btnManageAccounts_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(41, 50, 65);
            flowLayoutPanel2.Controls.Add(panel11);
            flowLayoutPanel2.ForeColor = Color.FromArgb(229, 186, 115);
            flowLayoutPanel2.Location = new Point(0, 280);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(200, 50);
            flowLayoutPanel2.TabIndex = 14;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Wheat;
            panel11.Controls.Add(btnStatistics);
            panel11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel11.Location = new Point(0, 0);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(203, 50);
            panel11.TabIndex = 10;
            // 
            // btnStatistics
            // 
            btnStatistics.BackColor = Color.FromArgb(41, 50, 65);
            btnStatistics.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStatistics.Image = Properties.Resources.Graph_32px;
            btnStatistics.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatistics.Location = new Point(-22, -28);
            btnStatistics.Margin = new Padding(0);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Padding = new Padding(25, 0, 0, 0);
            btnStatistics.Size = new Size(235, 102);
            btnStatistics.TabIndex = 9;
            btnStatistics.Text = "             Statistics";
            btnStatistics.TextAlign = ContentAlignment.MiddleLeft;
            btnStatistics.UseVisualStyleBackColor = false;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(41, 50, 65);
            flowLayoutPanel3.Controls.Add(panel3);
            flowLayoutPanel3.ForeColor = Color.FromArgb(229, 186, 115);
            flowLayoutPanel3.Location = new Point(0, 330);
            flowLayoutPanel3.Margin = new Padding(0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(200, 50);
            flowLayoutPanel3.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Wheat;
            panel3.Controls.Add(btnAbout);
            panel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(203, 50);
            panel3.TabIndex = 10;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.FromArgb(41, 50, 65);
            btnAbout.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbout.Image = Properties.Resources.About_32px;
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(-22, -26);
            btnAbout.Margin = new Padding(0);
            btnAbout.Name = "btnAbout";
            btnAbout.Padding = new Padding(25, 0, 0, 0);
            btnAbout.Size = new Size(235, 102);
            btnAbout.TabIndex = 9;
            btnAbout.Text = "             About";
            btnAbout.TextAlign = ContentAlignment.MiddleLeft;
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(41, 50, 65);
            flowLayoutPanel1.Controls.Add(panel10);
            flowLayoutPanel1.ForeColor = Color.FromArgb(229, 186, 115);
            flowLayoutPanel1.Location = new Point(0, 380);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 50);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Wheat;
            panel10.Controls.Add(btnLogout);
            panel10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel10.Location = new Point(0, 0);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(203, 50);
            panel10.TabIndex = 10;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(41, 50, 65);
            btnLogout.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Image = Properties.Resources.Logout_32px;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-22, -28);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(25, 0, 0, 0);
            btnLogout.Size = new Size(235, 102);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "             Log Out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 5;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // adminManageTicketing1
            // 
            adminManageTicketing1.BackColor = Color.FromArgb(58, 59, 61);
            adminManageTicketing1.Dock = DockStyle.Fill;
            adminManageTicketing1.Location = new Point(200, 46);
            adminManageTicketing1.Name = "adminManageTicketing1";
            adminManageTicketing1.Size = new Size(1240, 854);
            adminManageTicketing1.TabIndex = 8;
            // 
            // adminManageAccount1
            // 
            adminManageAccount1.Dock = DockStyle.Fill;
            adminManageAccount1.Location = new Point(200, 46);
            adminManageAccount1.Name = "adminManageAccount1";
            adminManageAccount1.Size = new Size(1240, 854);
            adminManageAccount1.TabIndex = 9;
            // 
            // adminStatistics1
            // 
            adminStatistics1.BackColor = Color.FromArgb(3, 37, 76);
            adminStatistics1.Dock = DockStyle.Fill;
            adminStatistics1.Location = new Point(200, 46);
            adminStatistics1.Name = "adminStatistics1";
            adminStatistics1.Size = new Size(1240, 854);
            adminStatistics1.TabIndex = 10;
            // 
            // panelAbout
            // 
            panelAbout.BackColor = Color.DimGray;
            panelAbout.Controls.Add(label5);
            panelAbout.Controls.Add(label4);
            panelAbout.Controls.Add(label3);
            panelAbout.Controls.Add(label2);
            panelAbout.Dock = DockStyle.Fill;
            panelAbout.Location = new Point(200, 46);
            panelAbout.Name = "panelAbout";
            panelAbout.Size = new Size(1240, 854);
            panelAbout.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 32F);
            label5.ForeColor = Color.FromArgb(192, 255, 255);
            label5.Location = new Point(400, 450);
            label5.Name = "label5";
            label5.Size = new Size(460, 177);
            label5.TabIndex = 3;
            label5.Text = "A ticketing software \r\nthat is intended to use \r\nduring bus trips.";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 32F);
            label4.ForeColor = Color.FromArgb(229, 186, 115);
            label4.Location = new Point(719, 739);
            label4.Name = "label4";
            label4.Size = new Size(473, 59);
            label4.TabIndex = 2;
            label4.Text = "by: John Laurence Sison";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 52F);
            label3.ForeColor = Color.FromArgb(229, 186, 115);
            label3.Location = new Point(418, 280);
            label3.Name = "label3";
            label3.Size = new Size(463, 93);
            label3.TabIndex = 1;
            label3.Text = "Manager App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 52F);
            label2.ForeColor = Color.FromArgb(229, 186, 115);
            label2.Location = new Point(118, 156);
            label2.Name = "label2";
            label2.Size = new Size(1030, 93);
            label2.TabIndex = 0;
            label2.Text = "Bus Integrated Ticketing System";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 34, 77);
            ClientSize = new Size(1440, 900);
            Controls.Add(panelAbout);
            Controls.Add(adminStatistics1);
            Controls.Add(adminManageAccount1);
            Controls.Add(adminManageTicketing1);
            Controls.Add(flpSidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHam).EndInit();
            flpSidebar.ResumeLayout(false);
            panel12.ResumeLayout(false);
            flpMenuContainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel13.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel11.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panelAbout.ResumeLayout(false);
            panelAbout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnMinimize;
        private Button btnClose;
        private PictureBox pbHam;
        private FlowLayoutPanel flpSidebar;
        private FlowLayoutPanel flpMenuContainer;
        private Panel panel2;
        private Button btnUserSelection;
        private Panel panel5;
        private Button btnDriver;
        private Panel panel6;
        private Button btnPassenger;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panel7;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel10;
        private Button btnLogout;
        private Panel panel12;
        private Button btnManageTicketing;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel11;
        private Button btnStatistics;
        private Panel panel13;
        private Button btnManageAccounts;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel3;
        private Button btnAbout;
        private Button btnHome;
        private AdminManageTicketing adminManageTicketing1;
        private AdminManageAccount adminManageAccount1;
        private AdminStatistics adminStatistics1;
        private Panel panelAbout;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}