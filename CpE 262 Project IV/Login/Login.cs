using System.Data.OleDb;
using System;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Windows.Forms;
using FaceRecognition;

namespace CpE_262_Project_IV
{
    public partial class Login : Form
    {
        private MethodPanel dragpanel = new MethodPanel();
        OleDbConnection connectionDatabase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\johnl\\OneDrive\\Desktop\\Code\\CpE262Project\\CpE262ProjectFINAL\\CpE 262 Project IV\\Database\\ManagerAppDatabase.accdb");
        OleDbCommand cmd = new OleDbCommand();
        private byte[] selectedImageBytes;
        //FaceRec faceRec = new FaceRec();
        public Login()
        {
            InitializeComponent();
            selectedImageBytes = new byte[0];
            dragpanel.Attach(panel1, this);
            panelLog.Show();
            panelCA1.Hide();
            panelCA2.Hide();
            panelFacial.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
}
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e){}
        private void panel1_MouseMove(object sender, MouseEventArgs e){}
        private void panel1_MouseUp(object sender, MouseEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connectionDatabase.Open();
                string login = "Select * from UserAccount where Username='" + txtboxUsername.Text + "' and Password= '" + txtboxPassword.Text + "'";
                cmd = new OleDbCommand(login, connectionDatabase);
                OleDbDataReader drLogin = cmd.ExecuteReader();
                if (drLogin.Read() == true)
                {
                    new Admin().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password\nPlease Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxUsername.Text = "";
                    txtboxPassword.Text = "";
                    txtboxUsername.Focus();
                }
                connectionDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void linkLabelCA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLog.Hide();
            panelCA1.Show();
        }
        private void linklabelBacktoLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelCA2.Hide();
            panelCA1.Hide();
            panelLog.Show();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int randomID = RandomID.GRNPassenger();
            string fullname = txtboxCAfirstname.Text + " " + txtboxCAfullname.Text;
            try
            {
                if (txtboxCAusername.Text == "" && txtboxCApassword.Text == "" && txtboxCAconfirmpassword.Text == "" && txtboxCAemail.Text == ""
                    && txtboxCAfullname.Text == "" && cbCApassengertype.Text == "" && txtboxCAcontactnumber.Text == "")
                {
                    MessageBox.Show("Fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtboxCApassword.Text == txtboxCAconfirmpassword.Text)
                {
                    string query = "INSERT INTO PassengerAccount ([PassengerID], [UserName], [Password], [FullName], [PassengerType], [Email], [ContactNumber], [PhotoID]) " +
                        "VALUES (@cusID, @username, @pass, @fullname, @passenger, @email, @contact, @photo)";
                    cmd = new OleDbCommand(query, connectionDatabase);
                    cmd.Parameters.AddWithValue("@cusID", randomID.ToString());
                    cmd.Parameters.AddWithValue("@username", txtboxCAusername.Text);
                    cmd.Parameters.AddWithValue("@pass", txtboxCAconfirmpassword.Text);
                    cmd.Parameters.AddWithValue("@fullname", fullname);
                    cmd.Parameters.AddWithValue("@passenger", cbCApassengertype.Text);
                    cmd.Parameters.AddWithValue("@email", txtboxCAemail.Text);
                    cmd.Parameters.AddWithValue("@contact", txtboxCAcontactnumber.Text);
                    cmd.Parameters.AddWithValue("@photo", selectedImageBytes);
                    connectionDatabase.Open();
                    cmd.ExecuteNonQuery();
                    connectionDatabase.Close();

                    MessageBox.Show("Account Creation is Completed. Customer ID: " + randomID.ToString(), "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxCApassword.Text = "";
                    txtboxCAconfirmpassword.Text = "";
                    txtboxCApassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                txtboxCApassword.PasswordChar = '\0';
                txtboxCAconfirmpassword.PasswordChar = '\0';
            }
            else
            {
                txtboxCApassword.PasswordChar = '•';
                txtboxCAconfirmpassword.PasswordChar = '•';
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxCAusername.Text = "";
            txtboxCApassword.Text = "";
            txtboxCAconfirmpassword.Text = "";
            txtboxCAemail.Text = "";
            txtboxUsername.Focus();

        }
        private void checkBoxLoginShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLoginShowpass.Checked)
            {
                txtboxPassword.PasswordChar = '\0';
            }
            else
            {
                txtboxPassword.PasswordChar = '•';
            }
        }
        private void btnCAclearimage_Click(object sender, EventArgs e)
        {
            try
            {
                this.pbCAphoto.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnCAchooseimage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfileD = new OpenFileDialog();
                string mypictures = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openfileD.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";
                openfileD.FileName = "Image file name";
                openfileD.Title = "Choose an image...";
                openfileD.AddExtension = true;
                openfileD.FilterIndex = 0;
                openfileD.Multiselect = false;
                openfileD.ValidateNames = true;
                openfileD.InitialDirectory = mypictures;
                openfileD.RestoreDirectory = true;
                if (openfileD.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openfileD.FileName;
                    selectedImageBytes = File.ReadAllBytes(imagePath);
                    pbCAphoto.Image = Image.FromFile(openfileD.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCAnext_Click(object sender, EventArgs e)
        {
            panelCA1.Hide();
            panelCA2.Show();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            panelCA2.Hide();
            panelCA1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Driver().Show();
        }
        private void btnOpenCam_Click(object sender, EventArgs e)
        {
           //faceRec.openCamera(pbFaceDetect, pbFaceCapture);
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {

        }

        private void btnDetectFace_Click(object sender, EventArgs e)
        {

        }
   
        
    }
}
