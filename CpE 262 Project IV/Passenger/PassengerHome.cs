using System.Data.OleDb;

namespace CpE_262_Project_IV
{
    public partial class PassengerHome : UserControl
    {
        public PassengerHome()
        {
            InitializeComponent();
            DisplayPassInfo();
        }

        private void PassengerHome_Load(object sender, EventArgs e) { }
        public void DisplayPassInfo()
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            InitializePassDrive pass = new InitializePassDrive();
            string? passID = pass.RetrievePassID()?.ToString();
            string query = $"SELECT PassengerID, UserName, FullName, PassengerType, Email, ContactNumber, PhotoID FROM PassengerAccount WHERE PassengerID = @passID";

            using (var connection = databaseAccess.GetConnection())
            using (var command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@passID", passID);
                try
                {
                    databaseAccess.OpenConn();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtboxPassengerID.Text = reader["PassengerID"].ToString();
                        txtboxUsername.Text = reader["UserName"].ToString();
                        txtboxFullname.Text = reader["FullName"].ToString();
                        cbPassengertype.Text = reader["PassengerType"].ToString();
                        txtboxEmail.Text = reader["Email"].ToString();
                        txtboxContactNumber.Text = reader["ContactNumber"].ToString();
                        byte[] imageData = (byte[])reader["PhotoID"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    reader.Close();
                    databaseAccess.CloseConn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
