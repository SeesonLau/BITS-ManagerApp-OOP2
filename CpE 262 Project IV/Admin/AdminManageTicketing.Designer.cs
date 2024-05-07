namespace CpE_262_Project_IV
{
    partial class AdminManageTicketing
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
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            dgvTicketing = new DataGridView();
            panel9 = new Panel();
            cbDestinationCity = new ComboBox();
            label6 = new Label();
            btnAdd = new Button();
            cbPassengertype = new ComboBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            cbDestination = new ComboBox();
            label2 = new Label();
            btnLoad = new Button();
            label3 = new Label();
            cbBoardingCity = new ComboBox();
            cbBusType = new ComboBox();
            btnUpdate = new Button();
            dateTimePicker2 = new DateTimePicker();
            btn_Delete = new Button();
            txtboxFare = new TextBox();
            label8 = new Label();
            label5 = new Label();
            txtboxCustomerID = new TextBox();
            cbBoardingfrom = new ComboBox();
            txtboxID = new TextBox();
            panel8 = new Panel();
            groupBox1 = new GroupBox();
            panel10 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTicketing).BeginInit();
            panel9.SuspendLayout();
            groupBox1.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(168, 183, 200);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 854);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(168, 183, 200);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1230, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 854);
            panel3.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(168, 183, 200);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1220, 10);
            panel4.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(168, 183, 200);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 841);
            panel1.Name = "panel1";
            panel1.Size = new Size(1204, 10);
            panel1.TabIndex = 39;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(17, 22, 43);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(3, 164);
            panel5.Name = "panel5";
            panel5.Size = new Size(30, 677);
            panel5.TabIndex = 41;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(17, 22, 43);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(33, 811);
            panel6.Name = "panel6";
            panel6.Size = new Size(1174, 30);
            panel6.TabIndex = 42;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(17, 22, 43);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(1207, 164);
            panel7.Name = "panel7";
            panel7.Size = new Size(30, 687);
            panel7.TabIndex = 43;
            // 
            // dgvTicketing
            // 
            dgvTicketing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTicketing.BackgroundColor = Color.FromArgb(41, 50, 65);
            dgvTicketing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTicketing.Dock = DockStyle.Fill;
            dgvTicketing.Location = new Point(33, 194);
            dgvTicketing.Name = "dgvTicketing";
            dgvTicketing.Size = new Size(1174, 617);
            dgvTicketing.TabIndex = 9;
            dgvTicketing.CellClick += dgvTicketing_CellClick;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(3, 37, 76);
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(txtboxID);
            panel9.Controls.Add(cbBoardingfrom);
            panel9.Controls.Add(txtboxCustomerID);
            panel9.Controls.Add(label8);
            panel9.Controls.Add(dateTimePicker2);
            panel9.Controls.Add(cbBusType);
            panel9.Controls.Add(cbBoardingCity);
            panel9.Controls.Add(label3);
            panel9.Controls.Add(label2);
            panel9.Controls.Add(cbDestination);
            panel9.Controls.Add(label4);
            panel9.Controls.Add(dateTimePicker1);
            panel9.Controls.Add(label1);
            panel9.Controls.Add(cbPassengertype);
            panel9.Controls.Add(label6);
            panel9.Controls.Add(cbDestinationCity);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(3, 19);
            panel9.Name = "panel9";
            panel9.Size = new Size(1234, 145);
            panel9.TabIndex = 45;
            // 
            // cbDestinationCity
            // 
            cbDestinationCity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDestinationCity.FormattingEnabled = true;
            cbDestinationCity.Items.AddRange(new object[] { "Cebu City", "Talisay", "Minglanilla", "Naga", "San Fernando", "Carcar", "Sibonga", "Argao", "Dalaguete" });
            cbDestinationCity.Location = new Point(507, 103);
            cbDestinationCity.Name = "cbDestinationCity";
            cbDestinationCity.Size = new Size(150, 28);
            cbDestinationCity.TabIndex = 32;
            cbDestinationCity.SelectedIndexChanged += cbDestinationCity_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(229, 186, 115);
            label6.Location = new Point(507, 14);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 11;
            label6.Text = "Bus Type";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(146, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbPassengertype
            // 
            cbPassengertype.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPassengertype.FormattingEnabled = true;
            cbPassengertype.Items.AddRange(new object[] { "Regular", "Student", "PWD", "SeniorCitizen" });
            cbPassengertype.Location = new Point(286, 37);
            cbPassengertype.Name = "cbPassengertype";
            cbPassengertype.Size = new Size(193, 28);
            cbPassengertype.TabIndex = 34;
            cbPassengertype.SelectedIndexChanged += cbPassengertype_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(229, 186, 115);
            label1.Location = new Point(511, 80);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 35;
            label1.Text = "Destination";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Font = new Font("Segoe UI", 11.25F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(826, 38);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(115, 27);
            dateTimePicker1.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(229, 186, 115);
            label4.Location = new Point(23, 80);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 9;
            label4.Text = "Boarding From";
            // 
            // cbDestination
            // 
            cbDestination.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDestination.FormattingEnabled = true;
            cbDestination.Items.AddRange(new object[] { "Cebu South Bus Terminal", "Cebu Institute of Technology University", "Basak San Nicolas", "Cogon Pardo", "Bulacao", "Tabunok", "Lawaan", "Linao", "Tungkil", "Calajo-an", "Tulay", "Tungkop", "Inayagan", "Tuyan", "Colon", "Naga City", "Tinaan", "Inoburan", "Langtad", "Pitalo", "San Isidro", "SanFernando Municipal Hall", "Balud", "Sangat", "Perrelos", "Carcar Gaisano Grand Mall", "Rotonda", "Bolinawan", "Ocana", "Abugon", "Candaguit", "Sabang", "Sibonga Municipal Hall", "Bahay", "Simala", "Bulasa", "Binlod", "Langtad", "Tulic", "Bogo", "Talaga", "Balisong", "Casay", "Cawayan", "Dalaguete Municipal Hall" });
            cbDestination.Location = new Point(663, 103);
            cbDestination.Name = "cbDestination";
            cbDestination.Size = new Size(300, 28);
            cbDestination.TabIndex = 4;
            cbDestination.SelectedIndexChanged += cbDestination_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(229, 186, 115);
            label2.Location = new Point(23, 15);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 7;
            label2.Text = "ID";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(146, 46);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(88, 23);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(229, 186, 115);
            label3.Location = new Point(286, 15);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 36;
            label3.Text = "Passenger Type";
            // 
            // cbBoardingCity
            // 
            cbBoardingCity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbBoardingCity.FormattingEnabled = true;
            cbBoardingCity.Items.AddRange(new object[] { "Cebu City", "Talisay", "Minglanilla", "Naga", "San Fernando", "Carcar", "Sibonga", "Argao", "Dalaguete" });
            cbBoardingCity.Location = new Point(23, 103);
            cbBoardingCity.Name = "cbBoardingCity";
            cbBoardingCity.Size = new Size(150, 28);
            cbBoardingCity.TabIndex = 33;
            cbBoardingCity.SelectedIndexChanged += cbBoardingCity_SelectedIndexChanged;
            // 
            // cbBusType
            // 
            cbBusType.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbBusType.FormattingEnabled = true;
            cbBusType.Items.AddRange(new object[] { "Ordinary", "Aircon" });
            cbBusType.Location = new Point(507, 37);
            cbBusType.Name = "cbBusType";
            cbBusType.Size = new Size(184, 28);
            cbBusType.TabIndex = 5;
            cbBusType.SelectedIndexChanged += cbBusType_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(146, 75);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.CustomFormat = "";
            dateTimePicker2.Font = new Font("Segoe UI", 11.25F);
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(697, 38);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(123, 27);
            dateTimePicker2.TabIndex = 37;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(146, 104);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(89, 23);
            btn_Delete.TabIndex = 10;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // txtboxFare
            // 
            txtboxFare.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtboxFare.Location = new Point(20, 82);
            txtboxFare.Name = "txtboxFare";
            txtboxFare.Size = new Size(103, 50);
            txtboxFare.TabIndex = 2;
            txtboxFare.TextChanged += txtboxFare_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(229, 186, 115);
            label8.Location = new Point(117, 16);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 24;
            label8.Text = "Passenger ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(229, 186, 115);
            label5.Location = new Point(20, 60);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 38;
            label5.Text = "Fare";
            // 
            // txtboxCustomerID
            // 
            txtboxCustomerID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxCustomerID.Location = new Point(119, 38);
            txtboxCustomerID.Name = "txtboxCustomerID";
            txtboxCustomerID.Size = new Size(149, 27);
            txtboxCustomerID.TabIndex = 23;
            // 
            // cbBoardingfrom
            // 
            cbBoardingfrom.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbBoardingfrom.FormattingEnabled = true;
            cbBoardingfrom.Items.AddRange(new object[] { "Cebu South Bus Terminal", "Cebu Institute of Technology University", "Basak San Nicolas", "Cogon Pardo", "Bulacao", "Tabunok", "Lawaan", "Linao", "Tungkil", "Calajo-an", "Tulay", "Tungkop", "Inayagan", "Tuyan", "Colon", "Naga City", "Tinaan", "Inoburan", "Langtad", "Pitalo", "San Isidro", "SanFernando Municipal Hall", "Balud", "Sangat", "Perrelos", "Carcar Gaisano Grand Mall", "Rotonda", "Bolinawan", "Ocana", "Abugon", "Candaguit", "Sabang", "Sibonga Municipal Hall", "Bahay", "Simala", "Bulasa", "Binlod", "Langtad", "Tulic", "Bogo", "Talaga", "Balisong", "Casay", "Cawayan", "Dalaguete Municipal Hall", "" });
            cbBoardingfrom.Location = new Point(179, 103);
            cbBoardingfrom.Name = "cbBoardingfrom";
            cbBoardingfrom.Size = new Size(300, 28);
            cbBoardingfrom.TabIndex = 3;
            cbBoardingfrom.SelectedIndexChanged += cbBoardingfrom_SelectedIndexChanged;
            // 
            // txtboxID
            // 
            txtboxID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxID.Location = new Point(23, 38);
            txtboxID.Name = "txtboxID";
            txtboxID.Size = new Size(47, 27);
            txtboxID.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(17, 22, 43);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(33, 164);
            panel8.Name = "panel8";
            panel8.Size = new Size(1174, 30);
            panel8.TabIndex = 44;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.BackColor = Color.FromArgb(3, 37, 76);
            groupBox1.Controls.Add(dgvTicketing);
            groupBox1.Controls.Add(panel8);
            groupBox1.Controls.Add(panel6);
            groupBox1.Controls.Add(panel5);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(panel7);
            groupBox1.Controls.Add(panel9);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1240, 854);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(26, 34, 77);
            panel10.Controls.Add(btn_Delete);
            panel10.Controls.Add(btnAdd);
            panel10.Controls.Add(btnLoad);
            panel10.Controls.Add(label5);
            panel10.Controls.Add(btnUpdate);
            panel10.Controls.Add(txtboxFare);
            panel10.Dock = DockStyle.Right;
            panel10.Location = new Point(969, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(265, 145);
            panel10.TabIndex = 46;
            // 
            // AdminManageTicketing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 59, 61);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Name = "AdminManageTicketing";
            Size = new Size(1240, 854);
            ((System.ComponentModel.ISupportInitialize)dgvTicketing).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel1;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private DataGridView dgvTicketing;
        private Panel panel9;
        private TextBox txtboxID;
        private ComboBox cbBoardingfrom;
        private TextBox txtboxCustomerID;
        private Label label5;
        private Label label8;
        private TextBox txtboxFare;
        private Button btn_Delete;
        private DateTimePicker dateTimePicker2;
        private Button btnUpdate;
        private ComboBox cbBusType;
        private ComboBox cbBoardingCity;
        private Label label3;
        private Button btnLoad;
        private Label label2;
        private ComboBox cbDestination;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ComboBox cbPassengertype;
        private Button btnAdd;
        private Label label6;
        private ComboBox cbDestinationCity;
        private Panel panel8;
        private GroupBox groupBox1;
        private Panel panel10;
    }
}
