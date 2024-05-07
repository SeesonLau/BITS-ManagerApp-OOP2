using System.Data;
using System.Data.OleDb;
namespace CpE_262_Project_IV
{
    public partial class DriverHome : UserControl
    {
        OleDbDataAdapter? da;
        DataSet? ds;
        DatabaseAccess databaseAccess = new DatabaseAccess();
        public DriverHome()
        {
            InitializeComponent();
            InitializePictureBoxes();
            this.DoubleBuffered = true;
            gunaCircleBar.Value = 0;
            UpdateSeats();
            DisplayDriverInfo();
        }
        public void DisplayDriverInfo()
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            InitializePassDrive pass = new InitializePassDrive();
            string? driverid = pass.RetrieveDriverID()?.ToString();
            string query = $"SELECT DriverID, UserName, FullName, Email, ContactNumber, DriverPhoto FROM DriverAccount WHERE DriverID = @driverid";

            using (var connection = databaseAccess.GetConnection())
            using (var command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@driverid", driverid);
                try
                {
                    databaseAccess.OpenConn();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtboxDriverID.Text = reader["DriverID"].ToString();
                        txtboxUsername.Text = reader["UserName"].ToString();
                        txtboxFullname.Text = reader["FullName"].ToString();
                        txtboxEmail.Text = reader["Email"].ToString();
                        txtboxContactNumber.Text = reader["ContactNumber"].ToString();
                        byte[] imageData = (byte[])reader["DriverPhoto"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pbDriverPhoto.Image = Image.FromStream(ms);
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
        private void DriverHome_Load(object sender, EventArgs e){}
        private void InitializePictureBoxes()
        {
            for (int i = 1; i <= 61; i++)
            {
                PictureBox pictureBox = (PictureBox)this.Controls.Find("pictureBox" + i, true)[0];
                pictureBox.Click += PictureBox_Click;
                UpdatePictureBoxStatus(pictureBox, i);
            }
        }
        private void UpdatePictureBoxStatus(PictureBox pictureBox, int seatId)
        {
            databaseAccess.OpenConn();
            string query = "SELECT SeatStatus FROM Seats WHERE SeatID = @SeatID";
            using (OleDbCommand command = new OleDbCommand(query, databaseAccess.GetConnection()))
            {
                command.Parameters.AddWithValue("@SeatID", seatId);
                object? result = command.ExecuteScalar();
                string? seatStatus = result != null ? result.ToString() : "Unoccupied";
                Color newColor = seatStatus == "Occupied" ? Color.Red : Color.Green;
                pictureBox.BackColor = newColor;
                System.Windows.Forms.Label label = (System.Windows.Forms.Label)this.Controls.Find("label" + seatId, true)[0];
                label.BackColor = newColor;
            }
        }

        private void PictureBox_Click(object? sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                int seatId = int.Parse(pictureBox.Name.Replace("pictureBox", ""));
                databaseAccess.OpenConn();
                string query = "UPDATE Seats SET SeatStatus = @SeatStatus WHERE SeatID = @SeatID";
                using (OleDbCommand command = new OleDbCommand(query, databaseAccess.GetConnection()))
                {
                    string newStatus = pictureBox.BackColor == Color.Green ? "Occupied" : "Unoccupied";
                    command.Parameters.AddWithValue("@SeatStatus", newStatus);
                    command.Parameters.AddWithValue("@SeatID", seatId);
                    command.ExecuteNonQuery();
                }
                UpdatePictureBoxStatus(pictureBox, seatId);
                UpdateSeats();
            }
        }
        private void UpdateSeats()
        {
            try
            {
                databaseAccess.OpenConn();
                int totalSeats = 61;
                string unoccupiedQuery = "SELECT COUNT(*) FROM Seats WHERE SeatStatus = 'Unoccupied'";
                OleDbCommand unoccupiedCommand = new OleDbCommand(unoccupiedQuery, databaseAccess.GetConnection());
                int unoccupiedSeats = (int)(unoccupiedCommand.ExecuteScalar() ?? 0);

                string occupiedQuery = "SELECT COUNT(*) FROM Seats WHERE SeatStatus = 'Occupied'";
                OleDbCommand occupiedCommand = new OleDbCommand(occupiedQuery, databaseAccess.GetConnection());
                int occupiedSeats = (int)(occupiedCommand.ExecuteScalar() ?? 0);

                totalSeats = occupiedSeats + unoccupiedSeats;
                double occupiedPercentage = (double)occupiedSeats / totalSeats * 100;

                gunaCircleBar.Value = (int)occupiedPercentage;
                labelUnoccupied.Text = unoccupiedSeats.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dgvDriverQueue_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                da = new OleDbDataAdapter("SELECT * FROM DriverQueue", databaseAccess.GetConnection());
                ds = new DataSet();
                databaseAccess.OpenConn();
                da.Fill(ds, "DriverQueue");
                dgvDriverQueue.DataSource = ds.Tables["DriverQueue"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseAccess.CloseConn();
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = dateTimePicker1.Value.Date;
                string formattedDate = selectedDate.ToString("MM/dd/yyyy"); 
                string query = $"SELECT * FROM DriverQueue WHERE DateIssued = #{formattedDate}#";

                databaseAccess.OpenConn();
                OleDbDataAdapter da = new OleDbDataAdapter(query, databaseAccess.GetConnection());
                DataSet ds = new DataSet();
                da.Fill(ds, "DriverQueue");
                dgvDriverQueue.DataSource = ds.Tables["DriverQueue"];

                if (dgvDriverQueue.Rows.Count > 0)
                {
                    DataGridViewRow firstRow = dgvDriverQueue.Rows[0];
                    txtboxCity.Text = firstRow.Cells["Destination City/Municipality"].Value.ToString();
                    txtboxBarangay.Text = firstRow.Cells["Destination"].Value.ToString();
                    txtboxFare.Text = firstRow.Cells["Fare"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbBusType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedBusType = cbBusType.SelectedItem?.ToString();
            File.WriteAllText("DriverSETbustype.txt", selectedBusType);
        }
        private int currentRowIndex = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDriverQueue.Rows.Count > 0 && currentRowIndex < dgvDriverQueue.Rows.Count - 1)
                {
                    currentRowIndex++; // Move to the next row if there are more rows
                    DataGridViewRow nextRow = dgvDriverQueue.Rows[currentRowIndex];
                    txtboxCity.Text = nextRow.Cells["Destination City/Municipality"].Value.ToString();
                    txtboxBarangay.Text = nextRow.Cells["Destination"].Value.ToString();
                    txtboxFare.Text = nextRow.Cells["Fare"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("No more rows to display.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
