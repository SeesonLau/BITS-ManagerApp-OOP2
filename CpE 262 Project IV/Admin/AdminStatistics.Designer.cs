namespace CpE_262_Project_IV
{
    partial class AdminStatistics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            formsPlot1 = new ScottPlot.FormsPlot();
            txtboxMostEarnedDay = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtboxHighestEarningsinaDay = new TextBox();
            dgvAdminSatistics = new DataGridView();
            txtboxCustomerID = new TextBox();
            label4 = new Label();
            txtboxLfietimeSpend = new TextBox();
            label3 = new Label();
            checkViewTotal = new CheckBox();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvAdminSatistics).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(168, 183, 200);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 844);
            panel1.Name = "panel1";
            panel1.Size = new Size(1240, 10);
            panel1.TabIndex = 40;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(168, 183, 200);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1230, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 844);
            panel3.TabIndex = 41;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(168, 183, 200);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1230, 10);
            panel4.TabIndex = 42;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(168, 183, 200);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 834);
            panel2.TabIndex = 43;
            // 
            // formsPlot1
            // 
            formsPlot1.BackColor = Color.FromArgb(255, 255, 192);
            formsPlot1.Location = new Point(39, 43);
            formsPlot1.Margin = new Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(1157, 427);
            formsPlot1.TabIndex = 44;
            formsPlot1.Load += formsPlot1_Load;
            // 
            // txtboxMostEarnedDay
            // 
            txtboxMostEarnedDay.Font = new Font("Segoe UI", 14F);
            txtboxMostEarnedDay.Location = new Point(60, 515);
            txtboxMostEarnedDay.Name = "txtboxMostEarnedDay";
            txtboxMostEarnedDay.Size = new Size(248, 32);
            txtboxMostEarnedDay.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.FromArgb(229, 186, 115);
            label1.Location = new Point(60, 487);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 46;
            label1.Text = "Most Earned Day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.FromArgb(229, 186, 115);
            label2.Location = new Point(60, 550);
            label2.Name = "label2";
            label2.Size = new Size(227, 25);
            label2.TabIndex = 47;
            label2.Text = "Highest Earnings in a Day";
            // 
            // txtboxHighestEarningsinaDay
            // 
            txtboxHighestEarningsinaDay.Font = new Font("Segoe UI", 14F);
            txtboxHighestEarningsinaDay.Location = new Point(60, 578);
            txtboxHighestEarningsinaDay.Name = "txtboxHighestEarningsinaDay";
            txtboxHighestEarningsinaDay.Size = new Size(248, 32);
            txtboxHighestEarningsinaDay.TabIndex = 48;
            // 
            // dgvAdminSatistics
            // 
            dgvAdminSatistics.BackgroundColor = Color.FromArgb(41, 50, 65);
            dgvAdminSatistics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminSatistics.Location = new Point(358, 476);
            dgvAdminSatistics.Name = "dgvAdminSatistics";
            dgvAdminSatistics.Size = new Size(838, 335);
            dgvAdminSatistics.TabIndex = 49;
            // 
            // txtboxCustomerID
            // 
            txtboxCustomerID.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtboxCustomerID.Font = new Font("Segoe UI", 14F);
            txtboxCustomerID.Location = new Point(23, 63);
            txtboxCustomerID.Name = "txtboxCustomerID";
            txtboxCustomerID.Size = new Size(248, 32);
            txtboxCustomerID.TabIndex = 62;
            txtboxCustomerID.TextChanged += txtboxCustomerID_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.FromArgb(229, 186, 115);
            label4.Location = new Point(23, 21);
            label4.Name = "label4";
            label4.Size = new Size(248, 25);
            label4.TabIndex = 61;
            label4.Text = "Enter PassengerID to Search";
            // 
            // txtboxLfietimeSpend
            // 
            txtboxLfietimeSpend.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtboxLfietimeSpend.Font = new Font("Segoe UI", 14F);
            txtboxLfietimeSpend.Location = new Point(23, 126);
            txtboxLfietimeSpend.Name = "txtboxLfietimeSpend";
            txtboxLfietimeSpend.Size = new Size(248, 32);
            txtboxLfietimeSpend.TabIndex = 60;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.FromArgb(229, 186, 115);
            label3.Location = new Point(23, 98);
            label3.Name = "label3";
            label3.Size = new Size(207, 25);
            label3.TabIndex = 59;
            label3.Text = "Bus Lifetime Spendings";
            // 
            // checkViewTotal
            // 
            checkViewTotal.AutoSize = true;
            checkViewTotal.Font = new Font("Segoe UI", 11F);
            checkViewTotal.ForeColor = Color.FromArgb(229, 186, 115);
            checkViewTotal.Location = new Point(251, 491);
            checkViewTotal.Name = "checkViewTotal";
            checkViewTotal.Size = new Size(97, 24);
            checkViewTotal.TabIndex = 63;
            checkViewTotal.Text = "View Total";
            checkViewTotal.UseVisualStyleBackColor = true;
            checkViewTotal.CheckedChanged += checkViewTotal_CheckedChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(26, 34, 77);
            panel5.Controls.Add(txtboxLfietimeSpend);
            panel5.Controls.Add(txtboxCustomerID);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(37, 634);
            panel5.Name = "panel5";
            panel5.Size = new Size(311, 177);
            panel5.TabIndex = 64;
            // 
            // AdminStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 37, 76);
            Controls.Add(txtboxMostEarnedDay);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtboxHighestEarningsinaDay);
            Controls.Add(checkViewTotal);
            Controls.Add(dgvAdminSatistics);
            Controls.Add(formsPlot1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Name = "AdminStatistics";
            Size = new Size(1240, 854);
            Load += AdminStatistics_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdminSatistics).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private ScottPlot.FormsPlot formsPlot1;
        private TextBox txtboxMostEarnedDay;
        private Label label1;
        private Label label2;
        private TextBox txtboxHighestEarningsinaDay;
        private DataGridView dgvAdminSatistics;
        private TextBox txtboxCustomerID;
        private Label label4;
        private TextBox txtboxLfietimeSpend;
        private Label label3;
        private CheckBox checkViewTotal;
        private Panel panel5;
    }
}
