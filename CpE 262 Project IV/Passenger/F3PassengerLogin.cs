using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CpE_262_Project_IV
{
    public partial class F3PassengerLogin : Form
    {
        OleDbConnection connectionDatabase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\johnl\\OneDrive\\Desktop\\Code\\CpE262Project\\CpE262ProjectFINAL\\CpE 262 Project IV\\Database\\ManagerAppDatabase.accdb");
        OleDbCommand cmd = new OleDbCommand();

        private byte[] selectedImageBytes;
        public F3PassengerLogin()
        {
            InitializeComponent();
            selectedImageBytes = new byte[0];
            panelCA2.Hide();
            panelCA1.Hide();
            panelLog2.Hide();

        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

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
        private void pbHam_Click(object sender, EventArgs e)
        {
            panelCA2.Hide();
            panelCA1.Show();
        }
        private void btnCAnext_Click(object sender, EventArgs e)
        {
            panelCA1.Hide();
            panelCA2.Show();
        }
        private void linkLabelCA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLog.Hide();
            panelCA1.Show();
        }
        private void label14_Click(object sender, EventArgs e) { }
        private void linklabelBacktoLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelCA2.Hide();
            panelCA1.Hide();
            panelLog.Show();
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string passengerID = txtboxPassengerID.Text;
                    File.WriteAllText("PassengerIDSET.txt", passengerID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connectionDatabase.Open();
                string login = "Select * from PassengerAccount where PassengerID='" + txtboxPassengerID.Text + "' and Password= '" + txtboxPassword.Text + "'";
                cmd = new OleDbCommand(login, connectionDatabase);
                OleDbDataReader drLogin = cmd.ExecuteReader();
                if (drLogin.Read() == true)
                {
                    new Passenger().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid PassengerID or Password\nPlease Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxPassengerID.Text = "";
                    txtboxPassword.Text = "";
                    txtboxPassengerID.Focus();
                }
                connectionDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

        private void txtboxPassengerID_TextChanged(object sender, EventArgs e) { }

        private void btnloginDriver_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string driverid = txtboxDriverId.Text;
                    File.WriteAllText("DriverIDSET.txt", driverid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connectionDatabase.Open();
                string login = "Select * from DriverAccount where DriverID='" + txtboxDriverId.Text + "' and Password= '" + txtboxDriverPass.Text + "'";
                cmd = new OleDbCommand(login, connectionDatabase);
                OleDbDataReader drLogin = cmd.ExecuteReader();
                if (drLogin.Read() == true)
                {
                    new Driver().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid DriverID or Password\nPlease Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxDriverId.Text = "";
                    txtboxDriverPass.Text = "";
                    txtboxDriverId.Focus();
                }
                connectionDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
