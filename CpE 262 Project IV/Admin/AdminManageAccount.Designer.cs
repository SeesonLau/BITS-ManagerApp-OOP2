namespace CpE_262_Project_IV
{
    partial class AdminManageAccount
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
            panel4 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            panel11 = new Panel();
            btnAdd = new Button();
            btnLoad = new Button();
            btnUpdate = new Button();
            btn_Delete = new Button();
            panel10 = new Panel();
            label6 = new Label();
            txtboxUsername = new TextBox();
            label5 = new Label();
            txtboxContactNumber = new TextBox();
            label4 = new Label();
            txtboxEmail = new TextBox();
            label1 = new Label();
            txtboxFullname = new TextBox();
            pbPhotoID = new PictureBox();
            label3 = new Label();
            cbPassengertype = new ComboBox();
            label8 = new Label();
            txtboxPassengerID = new TextBox();
            panel6 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel9 = new Panel();
            dgvAccount = new DataGridView();
            panel5.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPhotoID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(168, 183, 200);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1240, 10);
            panel4.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(168, 183, 200);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1230, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 844);
            panel3.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(168, 183, 200);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 844);
            panel1.Name = "panel1";
            panel1.Size = new Size(1230, 10);
            panel1.TabIndex = 40;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(168, 183, 200);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 834);
            panel2.TabIndex = 41;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(3, 37, 76);
            panel5.Controls.Add(panel11);
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txtboxUsername);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(txtboxContactNumber);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txtboxEmail);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(txtboxFullname);
            panel5.Controls.Add(pbPhotoID);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(cbPassengertype);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(txtboxPassengerID);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(1220, 165);
            panel5.TabIndex = 43;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(41, 50, 65);
            panel11.Controls.Add(btnAdd);
            panel11.Controls.Add(btnLoad);
            panel11.Controls.Add(btnUpdate);
            panel11.Controls.Add(btn_Delete);
            panel11.Dock = DockStyle.Right;
            panel11.Location = new Point(857, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(363, 165);
            panel11.TabIndex = 54;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(137, 27);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(137, 56);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(88, 23);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(137, 85);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 23);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(137, 114);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(89, 23);
            btn_Delete.TabIndex = 14;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(41, 50, 65);
            panel10.BackgroundImage = Properties.Resources.Blue_Bus_PNG_Clipart_1079;
            panel10.BackgroundImageLayout = ImageLayout.Zoom;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 165);
            panel10.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(229, 186, 115);
            label6.Location = new Point(377, 7);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 52;
            label6.Text = "Username";
            // 
            // txtboxUsername
            // 
            txtboxUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxUsername.Location = new Point(379, 29);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.Size = new Size(214, 27);
            txtboxUsername.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(229, 186, 115);
            label5.Location = new Point(618, 109);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 50;
            label5.Text = "Contact Number";
            // 
            // txtboxContactNumber
            // 
            txtboxContactNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxContactNumber.Location = new Point(620, 131);
            txtboxContactNumber.Name = "txtboxContactNumber";
            txtboxContactNumber.Size = new Size(214, 27);
            txtboxContactNumber.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(229, 186, 115);
            label4.Location = new Point(618, 58);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 48;
            label4.Text = "Email";
            // 
            // txtboxEmail
            // 
            txtboxEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxEmail.Location = new Point(620, 80);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(214, 27);
            txtboxEmail.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(229, 186, 115);
            label1.Location = new Point(618, 7);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 46;
            label1.Text = "Fullname";
            // 
            // txtboxFullname
            // 
            txtboxFullname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxFullname.Location = new Point(620, 29);
            txtboxFullname.Name = "txtboxFullname";
            txtboxFullname.Size = new Size(214, 27);
            txtboxFullname.TabIndex = 45;
            // 
            // pbPhotoID
            // 
            pbPhotoID.BackgroundImageLayout = ImageLayout.Zoom;
            pbPhotoID.Location = new Point(206, 7);
            pbPhotoID.Name = "pbPhotoID";
            pbPhotoID.Size = new Size(165, 152);
            pbPhotoID.SizeMode = PictureBoxSizeMode.Zoom;
            pbPhotoID.TabIndex = 44;
            pbPhotoID.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(229, 186, 115);
            label3.Location = new Point(377, 109);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 42;
            label3.Text = "Passenger Type";
            // 
            // cbPassengertype
            // 
            cbPassengertype.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPassengertype.FormattingEnabled = true;
            cbPassengertype.Items.AddRange(new object[] { "Regular", "Student", "PWD", "SeniorCitizen" });
            cbPassengertype.Location = new Point(377, 131);
            cbPassengertype.Name = "cbPassengertype";
            cbPassengertype.Size = new Size(216, 28);
            cbPassengertype.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(229, 186, 115);
            label8.Location = new Point(377, 58);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 40;
            label8.Text = "Passenger ID";
            // 
            // txtboxPassengerID
            // 
            txtboxPassengerID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxPassengerID.Location = new Point(379, 80);
            txtboxPassengerID.Name = "txtboxPassengerID";
            txtboxPassengerID.Size = new Size(214, 27);
            txtboxPassengerID.TabIndex = 39;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(17, 22, 43);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(10, 175);
            panel6.Name = "panel6";
            panel6.Size = new Size(30, 669);
            panel6.TabIndex = 44;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(17, 22, 43);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(40, 175);
            panel8.Name = "panel8";
            panel8.Size = new Size(1190, 30);
            panel8.TabIndex = 45;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(17, 22, 43);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(1200, 205);
            panel7.Name = "panel7";
            panel7.Size = new Size(30, 639);
            panel7.TabIndex = 46;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(17, 22, 43);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(40, 814);
            panel9.Name = "panel9";
            panel9.Size = new Size(1160, 30);
            panel9.TabIndex = 47;
            // 
            // dgvAccount
            // 
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccount.BackgroundColor = Color.FromArgb(41, 50, 65);
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Dock = DockStyle.Fill;
            dgvAccount.Location = new Point(40, 205);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.Size = new Size(1160, 609);
            dgvAccount.TabIndex = 48;
            dgvAccount.CellClick += dgvAccount_CellClick;
            // 
            // AdminManageAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvAccount);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "AdminManageAccount";
            Size = new Size(1240, 854);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbPhotoID).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private Panel panel8;
        private Panel panel7;
        private Panel panel9;
        private PictureBox pbPhotoID;
        private Label label3;
        private ComboBox cbPassengertype;
        private Label label8;
        private TextBox txtboxPassengerID;
        private Label label4;
        private TextBox txtboxEmail;
        private Label label1;
        private TextBox txtboxFullname;
        private Label label6;
        private TextBox txtboxUsername;
        private Label label5;
        private TextBox txtboxContactNumber;
        private Panel panel11;
        private Panel panel10;
        private Button btnAdd;
        private Button btnLoad;
        private Button btnUpdate;
        private Button btn_Delete;
        private DataGridView dgvAccount;
    }
}
