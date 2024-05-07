namespace CpE_262_Project_IV
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            btnMinimize = new Button();
            btnMaximize = new Button();
            txtboxUsername = new TextBox();
            txtboxPassword = new TextBox();
            linkLabelCA = new LinkLabel();
            btnLogin = new Button();
            btnClear = new Button();
            checkBoxShowPassword = new CheckBox();
            linklabelBacktoLogin = new LinkLabel();
            btnCreate = new Button();
            txtboxCAemail = new TextBox();
            txtboxCAconfirmpassword = new TextBox();
            txtboxCApassword = new TextBox();
            txtboxCAusername = new TextBox();
            panelLog = new Panel();
            checkBoxLoginShowpass = new CheckBox();
            panelCA1 = new Panel();
            label10 = new Label();
            txtboxCAfirstname = new TextBox();
            groupBox1 = new GroupBox();
            btnCAchooseimage = new Button();
            btnCAclearimage = new Button();
            pbCAphoto = new PictureBox();
            btnCAnext = new Button();
            label14 = new Label();
            label7 = new Label();
            cbCApassengertype = new ComboBox();
            txtboxCAcontactnumber = new TextBox();
            txtboxCAfullname = new TextBox();
            label8 = new Label();
            label9 = new Label();
            panelCA2 = new Panel();
            pbBack = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            label16 = new Label();
            panelFacial = new Panel();
            txtBoxFace = new TextBox();
            btnDetectFace = new Button();
            btnSaveImage = new Button();
            btnOpenCam = new Button();
            pbFaceCapture = new PictureBox();
            pbFaceDetect = new PictureBox();
            panel1.SuspendLayout();
            panelLog.SuspendLayout();
            panelCA1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCAphoto).BeginInit();
            panelCA2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            panelFacial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFaceCapture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFaceDetect).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(12, 15, 29);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnMaximize);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 46);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(229, 186, 115);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 1;
            label1.Text = "Manager App v3.0.1";
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.FromArgb(61, 74, 96);
            btnMinimize.BackgroundImage = Properties.Resources.Minimize_25px;
            btnMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimize.Location = new Point(1362, 10);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.TabIndex = 2;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.FromArgb(61, 74, 96);
            btnMaximize.BackgroundImage = (Image)resources.GetObject("btnMaximize.BackgroundImage");
            btnMaximize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMaximize.Location = new Point(1398, 10);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(30, 30);
            btnMaximize.TabIndex = 1;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // txtboxUsername
            // 
            txtboxUsername.BackColor = Color.White;
            txtboxUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxUsername.Location = new Point(13, 16);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.PlaceholderText = "Username";
            txtboxUsername.Size = new Size(336, 33);
            txtboxUsername.TabIndex = 1;
            // 
            // txtboxPassword
            // 
            txtboxPassword.BackColor = Color.White;
            txtboxPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxPassword.Location = new Point(13, 67);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.PasswordChar = '•';
            txtboxPassword.PlaceholderText = "Password";
            txtboxPassword.Size = new Size(336, 33);
            txtboxPassword.TabIndex = 2;
            // 
            // linkLabelCA
            // 
            linkLabelCA.AutoSize = true;
            linkLabelCA.Cursor = Cursors.Hand;
            linkLabelCA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelCA.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelCA.LinkColor = Color.FromArgb(229, 186, 115);
            linkLabelCA.Location = new Point(126, 201);
            linkLabelCA.Name = "linkLabelCA";
            linkLabelCA.Size = new Size(115, 21);
            linkLabelCA.TabIndex = 3;
            linkLabelCA.TabStop = true;
            linkLabelCA.Text = "Create Account";
            linkLabelCA.LinkClicked += linkLabelCA_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(13, 130);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(336, 51);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(7, 397);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(301, 51);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Location = new Point(200, 326);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(108, 19);
            checkBoxShowPassword.TabIndex = 15;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // linklabelBacktoLogin
            // 
            linklabelBacktoLogin.AutoSize = true;
            linklabelBacktoLogin.Cursor = Cursors.Hand;
            linklabelBacktoLogin.LinkBehavior = LinkBehavior.NeverUnderline;
            linklabelBacktoLogin.LinkColor = Color.FromArgb(229, 186, 115);
            linklabelBacktoLogin.Location = new Point(87, 518);
            linklabelBacktoLogin.Name = "linklabelBacktoLogin";
            linklabelBacktoLogin.Size = new Size(146, 30);
            linklabelBacktoLogin.TabIndex = 14;
            linklabelBacktoLogin.TabStop = true;
            linklabelBacktoLogin.Text = "Already Have an Account?\r\nBack to Log In";
            linklabelBacktoLogin.TextAlign = ContentAlignment.MiddleCenter;
            linklabelBacktoLogin.LinkClicked += linklabelBacktoLogin_LinkClicked;
            // 
            // btnCreate
            // 
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(7, 454);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(300, 51);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtboxCAemail
            // 
            txtboxCAemail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxCAemail.Location = new Point(15, 157);
            txtboxCAemail.Name = "txtboxCAemail";
            txtboxCAemail.Size = new Size(297, 33);
            txtboxCAemail.TabIndex = 12;
            // 
            // txtboxCAconfirmpassword
            // 
            txtboxCAconfirmpassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxCAconfirmpassword.Location = new Point(15, 290);
            txtboxCAconfirmpassword.Name = "txtboxCAconfirmpassword";
            txtboxCAconfirmpassword.PasswordChar = '•';
            txtboxCAconfirmpassword.Size = new Size(297, 33);
            txtboxCAconfirmpassword.TabIndex = 8;
            // 
            // txtboxCApassword
            // 
            txtboxCApassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxCApassword.Location = new Point(15, 217);
            txtboxCApassword.Name = "txtboxCApassword";
            txtboxCApassword.PasswordChar = '•';
            txtboxCApassword.Size = new Size(297, 33);
            txtboxCApassword.TabIndex = 7;
            // 
            // txtboxCAusername
            // 
            txtboxCAusername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxCAusername.Location = new Point(15, 96);
            txtboxCAusername.Name = "txtboxCAusername";
            txtboxCAusername.Size = new Size(297, 33);
            txtboxCAusername.TabIndex = 6;
            // 
            // panelLog
            // 
            panelLog.BackColor = Color.FromArgb(61, 74, 96);
            panelLog.Controls.Add(checkBoxLoginShowpass);
            panelLog.Controls.Add(txtboxUsername);
            panelLog.Controls.Add(txtboxPassword);
            panelLog.Controls.Add(btnLogin);
            panelLog.Controls.Add(linkLabelCA);
            panelLog.Location = new Point(500, 300);
            panelLog.Name = "panelLog";
            panelLog.Size = new Size(367, 237);
            panelLog.TabIndex = 6;
            // 
            // checkBoxLoginShowpass
            // 
            checkBoxLoginShowpass.AutoSize = true;
            checkBoxLoginShowpass.Location = new Point(241, 105);
            checkBoxLoginShowpass.Name = "checkBoxLoginShowpass";
            checkBoxLoginShowpass.Size = new Size(108, 19);
            checkBoxLoginShowpass.TabIndex = 17;
            checkBoxLoginShowpass.Text = "Show Password";
            checkBoxLoginShowpass.UseVisualStyleBackColor = true;
            checkBoxLoginShowpass.CheckedChanged += checkBoxLoginShowpass_CheckedChanged;
            // 
            // panelCA1
            // 
            panelCA1.BackColor = Color.FromArgb(61, 74, 96);
            panelCA1.Controls.Add(label10);
            panelCA1.Controls.Add(txtboxCAfirstname);
            panelCA1.Controls.Add(groupBox1);
            panelCA1.Controls.Add(btnCAnext);
            panelCA1.Controls.Add(label14);
            panelCA1.Controls.Add(label7);
            panelCA1.Controls.Add(cbCApassengertype);
            panelCA1.Controls.Add(txtboxCAcontactnumber);
            panelCA1.Controls.Add(txtboxCAfullname);
            panelCA1.Controls.Add(label8);
            panelCA1.Controls.Add(label9);
            panelCA1.Location = new Point(3, 0);
            panelCA1.Name = "panelCA1";
            panelCA1.Size = new Size(320, 558);
            panelCA1.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlDark;
            label10.Location = new Point(154, 88);
            label10.Name = "label10";
            label10.Size = new Size(79, 21);
            label10.TabIndex = 26;
            label10.Text = "Firstname";
            // 
            // txtboxCAfirstname
            // 
            txtboxCAfirstname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxCAfirstname.Location = new Point(154, 112);
            txtboxCAfirstname.Name = "txtboxCAfirstname";
            txtboxCAfirstname.Size = new Size(156, 33);
            txtboxCAfirstname.TabIndex = 25;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCAchooseimage);
            groupBox1.Controls.Add(btnCAclearimage);
            groupBox1.Controls.Add(pbCAphoto);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = SystemColors.ControlDark;
            groupBox1.Location = new Point(7, 290);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 168);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insert ID to verify passenger type";
            // 
            // btnCAchooseimage
            // 
            btnCAchooseimage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCAchooseimage.ForeColor = SystemColors.ActiveCaptionText;
            btnCAchooseimage.Image = (Image)resources.GetObject("btnCAchooseimage.Image");
            btnCAchooseimage.ImageAlign = ContentAlignment.MiddleLeft;
            btnCAchooseimage.Location = new Point(162, 104);
            btnCAchooseimage.Name = "btnCAchooseimage";
            btnCAchooseimage.Size = new Size(135, 31);
            btnCAchooseimage.TabIndex = 26;
            btnCAchooseimage.Text = "        Choose Image";
            btnCAchooseimage.UseVisualStyleBackColor = true;
            btnCAchooseimage.Click += btnCAchooseimage_Click;
            // 
            // btnCAclearimage
            // 
            btnCAclearimage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCAclearimage.ForeColor = SystemColors.ActiveCaptionText;
            btnCAclearimage.Image = (Image)resources.GetObject("btnCAclearimage.Image");
            btnCAclearimage.ImageAlign = ContentAlignment.MiddleLeft;
            btnCAclearimage.Location = new Point(162, 38);
            btnCAclearimage.Name = "btnCAclearimage";
            btnCAclearimage.Size = new Size(135, 31);
            btnCAclearimage.TabIndex = 25;
            btnCAclearimage.Text = "      Clear Image";
            btnCAclearimage.UseVisualStyleBackColor = true;
            btnCAclearimage.Click += btnCAclearimage_Click;
            // 
            // pbCAphoto
            // 
            pbCAphoto.Location = new Point(8, 23);
            pbCAphoto.Name = "pbCAphoto";
            pbCAphoto.Size = new Size(148, 139);
            pbCAphoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbCAphoto.TabIndex = 24;
            pbCAphoto.TabStop = false;
            // 
            // btnCAnext
            // 
            btnCAnext.Cursor = Cursors.Hand;
            btnCAnext.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCAnext.Location = new Point(9, 464);
            btnCAnext.Name = "btnCAnext";
            btnCAnext.Size = new Size(301, 51);
            btnCAnext.TabIndex = 16;
            btnCAnext.Text = "Next";
            btnCAnext.UseVisualStyleBackColor = true;
            btnCAnext.Click += btnCAnext_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(229, 186, 115);
            label14.Location = new Point(15, 19);
            label14.Name = "label14";
            label14.Size = new Size(148, 25);
            label14.TabIndex = 0;
            label14.Text = "Create Account";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDark;
            label7.Location = new Point(13, 88);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 18;
            label7.Text = "Lastname";
            // 
            // cbCApassengertype
            // 
            cbCApassengertype.Font = new Font("Segoe UI", 14.25F);
            cbCApassengertype.FormattingEnabled = true;
            cbCApassengertype.Items.AddRange(new object[] { "Regular", "Student", "PWD", "SeniorCitizen" });
            cbCApassengertype.Location = new Point(13, 251);
            cbCApassengertype.Name = "cbCApassengertype";
            cbCApassengertype.Size = new Size(297, 33);
            cbCApassengertype.TabIndex = 22;
            // 
            // txtboxCAcontactnumber
            // 
            txtboxCAcontactnumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxCAcontactnumber.Location = new Point(13, 181);
            txtboxCAcontactnumber.Name = "txtboxCAcontactnumber";
            txtboxCAcontactnumber.Size = new Size(297, 33);
            txtboxCAcontactnumber.TabIndex = 19;
            // 
            // txtboxCAfullname
            // 
            txtboxCAfullname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxCAfullname.Location = new Point(13, 112);
            txtboxCAfullname.Name = "txtboxCAfullname";
            txtboxCAfullname.Size = new Size(135, 33);
            txtboxCAfullname.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(13, 157);
            label8.Name = "label8";
            label8.Size = new Size(125, 21);
            label8.TabIndex = 20;
            label8.Text = "Contact Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlDark;
            label9.Location = new Point(13, 226);
            label9.Name = "label9";
            label9.Size = new Size(116, 21);
            label9.TabIndex = 21;
            label9.Text = "Passenger Type";
            // 
            // panelCA2
            // 
            panelCA2.BackColor = Color.FromArgb(61, 74, 96);
            panelCA2.Controls.Add(btnClear);
            panelCA2.Controls.Add(txtboxCAemail);
            panelCA2.Controls.Add(linklabelBacktoLogin);
            panelCA2.Controls.Add(panelCA1);
            panelCA2.Controls.Add(pbBack);
            panelCA2.Controls.Add(btnCreate);
            panelCA2.Controls.Add(checkBoxShowPassword);
            panelCA2.Controls.Add(txtboxCAconfirmpassword);
            panelCA2.Controls.Add(label11);
            panelCA2.Controls.Add(txtboxCApassword);
            panelCA2.Controls.Add(label12);
            panelCA2.Controls.Add(txtboxCAusername);
            panelCA2.Controls.Add(label13);
            panelCA2.Controls.Add(label15);
            panelCA2.Controls.Add(label16);
            panelCA2.Location = new Point(513, 157);
            panelCA2.Name = "panelCA2";
            panelCA2.Size = new Size(320, 558);
            panelCA2.TabIndex = 24;
            // 
            // pbBack
            // 
            pbBack.BackgroundImage = Properties.Resources.Back_32px;
            pbBack.BackgroundImageLayout = ImageLayout.Center;
            pbBack.Location = new Point(274, 19);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(34, 31);
            pbBack.SizeMode = PictureBoxSizeMode.CenterImage;
            pbBack.TabIndex = 17;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlDark;
            label11.Location = new Point(15, 130);
            label11.Name = "label11";
            label11.Size = new Size(48, 21);
            label11.TabIndex = 13;
            label11.Text = "Email";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlDark;
            label12.Location = new Point(15, 258);
            label12.Name = "label12";
            label12.Size = new Size(137, 21);
            label12.TabIndex = 11;
            label12.Text = "Confirm Password";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlDark;
            label13.Location = new Point(15, 190);
            label13.Name = "label13";
            label13.Size = new Size(76, 21);
            label13.TabIndex = 10;
            label13.Text = "Password";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ControlDark;
            label15.Location = new Point(15, 72);
            label15.Name = "label15";
            label15.Size = new Size(81, 21);
            label15.TabIndex = 9;
            label15.Text = "Username";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(15, 19);
            label16.Name = "label16";
            label16.Size = new Size(148, 25);
            label16.TabIndex = 0;
            label16.Text = "Create Account";
            // 
            // panelFacial
            // 
            panelFacial.BackColor = Color.FromArgb(61, 74, 96);
            panelFacial.Controls.Add(txtBoxFace);
            panelFacial.Controls.Add(btnDetectFace);
            panelFacial.Controls.Add(btnSaveImage);
            panelFacial.Controls.Add(btnOpenCam);
            panelFacial.Controls.Add(pbFaceCapture);
            panelFacial.Controls.Add(pbFaceDetect);
            panelFacial.Location = new Point(12, 217);
            panelFacial.Name = "panelFacial";
            panelFacial.Size = new Size(495, 429);
            panelFacial.TabIndex = 27;
            // 
            // txtBoxFace
            // 
            txtBoxFace.Location = new Point(230, 283);
            txtBoxFace.Name = "txtBoxFace";
            txtBoxFace.Size = new Size(100, 23);
            txtBoxFace.TabIndex = 21;
            // 
            // btnDetectFace
            // 
            btnDetectFace.Cursor = Cursors.Hand;
            btnDetectFace.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDetectFace.Location = new Point(363, 192);
            btnDetectFace.Name = "btnDetectFace";
            btnDetectFace.Size = new Size(129, 33);
            btnDetectFace.TabIndex = 20;
            btnDetectFace.Text = "Detect Face";
            btnDetectFace.UseVisualStyleBackColor = true;
            // 
            // btnSaveImage
            // 
            btnSaveImage.Cursor = Cursors.Hand;
            btnSaveImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveImage.Location = new Point(363, 130);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(129, 33);
            btnSaveImage.TabIndex = 19;
            btnSaveImage.Text = "Save Image";
            btnSaveImage.UseVisualStyleBackColor = true;
            // 
            // btnOpenCam
            // 
            btnOpenCam.Cursor = Cursors.Hand;
            btnOpenCam.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenCam.Location = new Point(363, 77);
            btnOpenCam.Name = "btnOpenCam";
            btnOpenCam.Size = new Size(129, 33);
            btnOpenCam.TabIndex = 18;
            btnOpenCam.Text = "Open Cam";
            btnOpenCam.UseVisualStyleBackColor = true;
            btnOpenCam.Click += btnOpenCam_Click;
            // 
            // pbFaceCapture
            // 
            pbFaceCapture.Location = new Point(230, 177);
            pbFaceCapture.Name = "pbFaceCapture";
            pbFaceCapture.Size = new Size(100, 100);
            pbFaceCapture.TabIndex = 1;
            pbFaceCapture.TabStop = false;
            // 
            // pbFaceDetect
            // 
            pbFaceDetect.Location = new Point(13, 77);
            pbFaceDetect.Name = "pbFaceDetect";
            pbFaceDetect.Size = new Size(200, 200);
            pbFaceDetect.TabIndex = 0;
            pbFaceDetect.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 50, 65);
            ClientSize = new Size(1440, 900);
            Controls.Add(panelFacial);
            Controls.Add(panelLog);
            Controls.Add(panelCA2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLog.ResumeLayout(false);
            panelLog.PerformLayout();
            panelCA1.ResumeLayout(false);
            panelCA1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCAphoto).EndInit();
            panelCA2.ResumeLayout(false);
            panelCA2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            panelFacial.ResumeLayout(false);
            panelFacial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFaceCapture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFaceDetect).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMinimize;
        private Button btnMaximize;
        private Label label1;
        private TextBox txtboxUsername;
        private TextBox txtboxPassword;
        private LinkLabel linkLabelCA;
        private Button btnLogin;
        private Button btnCreate;
        private TextBox txtboxCAemail;
        private TextBox txtboxCAconfirmpassword;
        private TextBox txtboxCApassword;
        private TextBox txtboxCAusername;
        private LinkLabel linklabelBacktoLogin;
        private Panel panelLog;
        private CheckBox checkBoxShowPassword;
        private Button btnClear;
        private CheckBox checkBoxLoginShowpass;
        private Panel panelCA1;
        private Label label10;
        private TextBox txtboxCAfirstname;
        private GroupBox groupBox1;
        private Button btnCAchooseimage;
        private Button btnCAclearimage;
        private PictureBox pbCAphoto;
        private Button btnCAnext;
        private Label label14;
        private Label label7;
        private ComboBox cbCApassengertype;
        private TextBox txtboxCAcontactnumber;
        private TextBox txtboxCAfullname;
        private Label label8;
        private Label label9;
        private Panel panelCA2;
        private PictureBox pbBack;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label15;
        private Label label16;
        private Panel panelFacial;
        private Button btnOpenCam;
        private PictureBox pbFaceCapture;
        private PictureBox pbFaceDetect;
        private Button btnDetectFace;
        private Button btnSaveImage;
        private TextBox txtBoxFace;
    }
}
