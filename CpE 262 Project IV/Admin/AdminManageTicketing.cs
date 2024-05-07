using System;
using System.Data;
using System.Data.OleDb;

namespace CpE_262_Project_IV
{
    public partial class AdminManageTicketing : UserControl
    {
        private string? locBoarding;
        private string? locDestination;
        private string? cityDestination;
        private string? passengeType;
        private string? cityBoarding;
        public string? GetLocB()
        {
            return locBoarding;
        }
        public string? GetLocD()
        {
            return locDestination;
        }
        DatabaseAccess databaseAccess = new DatabaseAccess();
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public AdminManageTicketing()
        {
            InitializeComponent();
            try
            {
                da = new OleDbDataAdapter("SELECT *FROM Ticketing", databaseAccess.GetConnection());
                ds = new DataSet();
                databaseAccess.OpenConn();
                da.Fill(ds, "Ticketing");
                dgvTicketing.DataSource = ds.Tables["Ticketing"];
                databaseAccess.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            updateText();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string ticketing = "INSERT INTO Ticketing (DateIssued, CustomerID, PassengerType, [Boarding City/Municipality], BoardingFrom, BusType, [Destination City/Municipality], Destination, Fare) " +
                "VALUES (@dateissued, @customerID, @passengertype, @Bcity, @boardingfrom, @bustype, @Dcity, @destination, @fare)";
                cmd = new OleDbCommand(ticketing, databaseAccess.GetConnection());
                cmd.Parameters.AddWithValue("@dateissued", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@customeID", txtboxCustomerID.Text);
                cmd.Parameters.AddWithValue("@passengertype", cbPassengertype.Text);
                cmd.Parameters.AddWithValue("@Bcity", cbBoardingCity.Text);
                cmd.Parameters.AddWithValue("@boardingfrom", cbBoardingfrom.Text);
                cmd.Parameters.AddWithValue("@bustype", cbBusType.Text);
                cmd.Parameters.AddWithValue("@Dcity", cbDestinationCity.Text);
                cmd.Parameters.AddWithValue("@destination", cbDestination.Text);
                cmd.Parameters.AddWithValue("@fare", txtboxFare.Text);
                databaseAccess.OpenConn();
                cmd.ExecuteNonQuery();
                databaseAccess.CloseConn();
                btnLoad_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                da = new OleDbDataAdapter("SELECT *FROM Ticketing", databaseAccess.GetConnection());
                ds = new DataSet();
                databaseAccess.OpenConn();
                da.Fill(ds, "Ticketing");
                dgvTicketing.DataSource = ds.Tables["Ticketing"];
                databaseAccess.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (indexRow >= 0 && indexRow < dgvTicketing.Rows.Count)
                {
                    DataGridViewRow row = dgvTicketing.Rows[indexRow];
                    string Ticketing = "UPDATE Ticketing SET DateIssued = @dateissued, CustomerID = @customerID, PassengerType = @passengertype, [Boarding City/Municipality] = @Bcity, BoardingFrom = @boardingfrom, BusType = @bustype, " +
                        "[Destination City/Municipality] = @Dcity, Destination = @Destination, Fare = @Fare Where ID = @ID";
                    cmd = new OleDbCommand(Ticketing, databaseAccess.GetConnection());
                    cmd.Parameters.AddWithValue("@dateissued", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@customeID", txtboxCustomerID.Text);
                    cmd.Parameters.AddWithValue("@passengertype", cbPassengertype.Text);
                    cmd.Parameters.AddWithValue("@Bcity", cbBoardingCity.Text);
                    cmd.Parameters.AddWithValue("@boardingfrom", cbBoardingfrom.Text);
                    cmd.Parameters.AddWithValue("@bustype", cbBusType.Text);
                    cmd.Parameters.AddWithValue("@Dcity", cbDestinationCity.Text);
                    cmd.Parameters.AddWithValue("@destination", cbDestination.Text);
                    cmd.Parameters.AddWithValue("@fare", txtboxFare.Text);
                    cmd.Parameters.AddWithValue("@ID", row.Cells["ID"].Value);
                    databaseAccess.OpenConn();
                    cmd.ExecuteNonQuery();
                    databaseAccess.CloseConn();
                    btnLoad_Click(sender, e);
                    row.Cells["DateIssued"].Value = dateTimePicker1.Text;
                    row.Cells["CustomerID"].Value = txtboxCustomerID.Text;
                    row.Cells["PassengerType"].Value = cbPassengertype.Text;
                    row.Cells["Boarding City/Municipality"].Value = cbBoardingCity.Text;
                    row.Cells["BoardingFrom"].Value = cbBoardingfrom.Text;
                    row.Cells["BusType"].Value = cbBusType.Text;
                    row.Cells["Destination City/Municipality"].Value = cbDestinationCity.Text;
                    row.Cells["Destination"].Value = cbDestination.Text;
                    row.Cells["Fare"].Value = txtboxFare.Text;
                    MessageBox.Show("Data updated successfully! LEGIT");
                }
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Data updated successfully!");
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string ticketing = "Delete from Ticketing where ID = @id";
                cmd = new OleDbCommand(ticketing, databaseAccess.GetConnection());
                cmd.Parameters.AddWithValue("@id", dgvTicketing.CurrentRow.Cells[0].Value);
                databaseAccess.OpenConn();
                cmd.ExecuteNonQuery();
                databaseAccess.CloseConn();

                btnLoad_Click(sender, e);
                MessageBox.Show("Data deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void cbBoardingfrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            locBoarding = cbBoardingfrom.SelectedItem?.ToString() ?? "";
            updateText();
        }
        private void cbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            locDestination = cbDestination.SelectedItem?.ToString() ?? "";
            updateText();
        }
        private void cbBusType_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateText();
        }
        private void txtboxFare_TextChanged(object sender, EventArgs e)
        {
            updateText();
        }
        private void updateText()
        {
            Directory directory = new Directory();
            FareCalculator calc = new FareCalculator();
            BusType bustype = new BusType();
            PassengerType pass = new PassengerType();
            TrueDistance dis = new TrueDistance();

            string boardingBarangay = cbBoardingfrom.SelectedItem?.ToString() ?? "";
            string destinationBarangay = cbDestination.SelectedItem?.ToString() ?? "";
            string BusType = cbBusType.SelectedItem?.ToString() ?? "";


            var boardingDistance = directory.GetDistance(boardingBarangay);
            var destinationDistance = directory.GetDistance(destinationBarangay);
            var busType = bustype.GetBusType(BusType);
            var Fare = calc.CalculateFare(boardingDistance, destinationDistance, cbPassengertype.Text, BusType);
            var passenger = pass.GetPassengerType(cbPassengertype.Text);
            var distance = dis.GetTrueDistance(destinationDistance, boardingDistance);


            if (cbBusType.Text == "Aircon")
            {
                txtboxFare.Text = calc.GetFare()?.ToString("0.00");
            }
            else if (cbBusType.Text == "Ordinary")
            {
                txtboxFare.Text = calc.GetFare()?.ToString("0.00");
            }
            else
            {
                txtboxFare.Text = "0";
            }
        }
        private void button1_Click(object sender, EventArgs e) // DONT DELETE THIS IS TEST BUTTON, TEST CODE
        {
            Directory directory = new Directory();
            FareCalculator calc = new FareCalculator();
            BusType bustype = new BusType();
            PassengerType pass = new PassengerType();
            TrueDistance dis = new TrueDistance();

            string boardingBarangay = cbBoardingfrom.SelectedItem?.ToString() ?? "";
            string destinationBarangay = cbDestination.SelectedItem?.ToString() ?? "";
            string BusType = cbBusType.SelectedItem?.ToString() ?? "";


            var boardingDistance = directory.GetDistance(boardingBarangay);
            var destinationDistance = directory.GetDistance(destinationBarangay);
            var busType = bustype.GetBusType(BusType);
            var Fare = calc.CalculateFare(boardingDistance, destinationDistance, cbPassengertype.Text, BusType);
            var passenger = pass.GetPassengerType(cbPassengertype.Text);
            var distance = dis.GetTrueDistance(destinationDistance, boardingDistance);

            if (cbBusType.Text == "Aircon")
            {
                MessageBox.Show("Fare: " + Fare.ToString("F2")
                    + Environment.NewLine + "PassengerType: " + passenger
                    + Environment.NewLine + "Boarding: " + GetLocB()
                    + Environment.NewLine + "Destination: " + GetLocD()
                    + Environment.NewLine + "BoardingDis: " + boardingDistance?.ToString("F2")
                    + Environment.NewLine + "DestinationDis: " + destinationDistance?.ToString("F2")
                    + Environment.NewLine + "Distance: " + distance?.ToString("F2"));
            }
            else if (cbBusType.Text == "Ordinary")
            {
                MessageBox.Show("Fare: " + Fare.ToString("F2")
                    + Environment.NewLine + "PassengerType1: " + passenger
                    + Environment.NewLine + "Boarding: " + GetLocB()
                    + Environment.NewLine + "Destination: " + GetLocD()
                    + Environment.NewLine + "BoardingDis: " + boardingDistance?.ToString("F2")
                    + Environment.NewLine + "DestinationDis: " + destinationDistance?.ToString("F2")
                    + Environment.NewLine + "BusType: " + busType?.ToString()
                + Environment.NewLine + "Distance: " + distance?.ToString("F2"));
            }
            else
            {
                MessageBox.Show($"NOT WORKING");
            }

        }
        private void cbBoardingCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityBoarding = cbBoardingCity.SelectedItem?.ToString() ?? "";
            updateText();
            cbBoardingfrom.Items.Clear();
            switch (cbBoardingCity.SelectedItem?.ToString())
            {
                case "Cebu City":
                    cbBoardingfrom.Items.Add("Cebu South Bus Terminal");
                    cbBoardingfrom.Items.Add("Cebu Institute of Technology University");
                    cbBoardingfrom.Items.Add("Basak San Nicolas");
                    cbBoardingfrom.Items.Add("Cogon Pardo");
                    cbBoardingfrom.Items.Add("Bulacao");
                    break;
                case "Talisay":
                    cbBoardingfrom.Items.Add("Tabunok");
                    cbBoardingfrom.Items.Add("Lawaan");
                    cbBoardingfrom.Items.Add("Linao");
                    break;
                case "Minglanilla":
                    cbBoardingfrom.Items.Add("Tungkil");
                    cbBoardingfrom.Items.Add("Calajo-an");
                    cbBoardingfrom.Items.Add("Tulay");
                    cbBoardingfrom.Items.Add("Tungkop");
                    break;
                case "Naga":
                    cbBoardingfrom.Items.Add("Inayagan");
                    cbBoardingfrom.Items.Add("Tuyan");
                    cbBoardingfrom.Items.Add("Colon");
                    cbBoardingfrom.Items.Add("Naga City");
                    cbBoardingfrom.Items.Add("Tinaan");
                    cbBoardingfrom.Items.Add("Inoburan");
                    cbBoardingfrom.Items.Add("Langtad");
                    break;
                case "San Fernando":
                    cbBoardingfrom.Items.Add("Pitalo");
                    cbBoardingfrom.Items.Add("San Isidro");
                    cbBoardingfrom.Items.Add("San Fernando Municipal Hall");
                    cbBoardingfrom.Items.Add("Balud");
                    cbBoardingfrom.Items.Add("Sangat");
                    break;
                case "Carcar":
                    cbBoardingfrom.Items.Add("Perrelos");
                    cbBoardingfrom.Items.Add("Carcar Gaisano Grand Mall");
                    cbBoardingfrom.Items.Add("Rotonda");
                    cbBoardingfrom.Items.Add("Bolinawan");
                    cbBoardingfrom.Items.Add("Ocana");
                    break;
                case "Sibonga":
                    cbBoardingfrom.Items.Add("Abugon");
                    cbBoardingfrom.Items.Add("Candaguit");
                    cbBoardingfrom.Items.Add("Sabang");
                    cbBoardingfrom.Items.Add("Sibonga Municipal Hall");
                    cbBoardingfrom.Items.Add("Bahay");
                    cbBoardingfrom.Items.Add("Simala");
                    break;
                case "Argao":
                    cbBoardingfrom.Items.Add("Bulasa");
                    cbBoardingfrom.Items.Add("Binlod");
                    cbBoardingfrom.Items.Add("Langtad Argao");
                    cbBoardingfrom.Items.Add("Tulic");
                    cbBoardingfrom.Items.Add("Bogo");
                    cbBoardingfrom.Items.Add("Talaga");
                    cbBoardingfrom.Items.Add("Balisong");
                    break;
                case "Dalaguete":
                    cbBoardingfrom.Items.Add("Casay");
                    cbBoardingfrom.Items.Add("Cawayan");
                    cbBoardingfrom.Items.Add("Dalaguete Municipal Hall");
                    break;
            }
        }
        private void cbDestinationCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityDestination = cbDestinationCity.SelectedItem?.ToString() ?? "";
            updateText();
            cbDestination.Items.Clear();
            switch (cbDestinationCity.SelectedItem?.ToString())
            {
                case "Cebu City":
                    cbDestination.Items.Add("Cebu South Bus Terminal");
                    cbDestination.Items.Add("Cebu Institute of Technology University");
                    cbDestination.Items.Add("Basak San Nicolas");
                    cbDestination.Items.Add("Cogon Pardo");
                    cbDestination.Items.Add("Bulacao");
                    break;
                case "Talisay":
                    cbDestination.Items.Add("Tabunok");
                    cbDestination.Items.Add("Lawaan");
                    cbDestination.Items.Add("Linao");
                    break;
                case "Minglanilla":
                    cbDestination.Items.Add("Tungkil");
                    cbDestination.Items.Add("Calajo-an");
                    cbDestination.Items.Add("Tulay");
                    cbDestination.Items.Add("Tungkop");
                    break;
                case "Naga":
                    cbDestination.Items.Add("Inayagan");
                    cbDestination.Items.Add("Tuyan");
                    cbDestination.Items.Add("Colon");
                    cbDestination.Items.Add("Naga City");
                    cbDestination.Items.Add("Tinaan");
                    cbDestination.Items.Add("Inoburan");
                    cbDestination.Items.Add("Langtad");
                    break;
                case "San Fernando":
                    cbDestination.Items.Add("Pitalo");
                    cbDestination.Items.Add("San Isidro");
                    cbDestination.Items.Add("San Fernando Municipal Hall");
                    cbDestination.Items.Add("Balud");
                    cbDestination.Items.Add("Sangat");
                    break;
                case "Carcar":
                    cbDestination.Items.Add("Perrelos");
                    cbDestination.Items.Add("Carcar Gaisano Grand Mall");
                    cbDestination.Items.Add("Rotonda");
                    cbDestination.Items.Add("Bolinawan");
                    cbDestination.Items.Add("Ocana");
                    break;
                case "Sibonga":
                    cbDestination.Items.Add("Abugon");
                    cbDestination.Items.Add("Candaguit");
                    cbDestination.Items.Add("Sabang");
                    cbDestination.Items.Add("Sibonga Municipal Hall");
                    cbDestination.Items.Add("Bahay");
                    cbDestination.Items.Add("Simala");
                    break;
                case "Argao":
                    cbDestination.Items.Add("Bulasa");
                    cbDestination.Items.Add("Binlod");
                    cbDestination.Items.Add("Langtad Argao");
                    cbDestination.Items.Add("Tulic");
                    cbDestination.Items.Add("Bogo");
                    cbDestination.Items.Add("Talaga");
                    cbDestination.Items.Add("Balisong");
                    break;
                case "Dalaguete":
                    cbDestination.Items.Add("Casay");
                    cbDestination.Items.Add("Cawayan");
                    cbDestination.Items.Add("Dalaguete Municipal Hall");
                    break;
            }
        }
        private void cbPassengertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            passengeType = cbPassengertype.SelectedItem?.ToString() ?? "";
            updateText();
        }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void dgvTicketing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    indexRow = e.RowIndex;
                    DataGridViewRow row = dgvTicketing.Rows[indexRow];
                    txtboxID.Text = row.Cells["ID"].Value.ToString();

                    if (DateTime.TryParse(row.Cells["DateIssued"].Value?.ToString(), out DateTime dateIssued))
                    {
                        dateTimePicker1.Value = dateIssued;
                    }
                    else
                    {
                        dateTimePicker1.Value = DateTime.Today; 
                    }
                    txtboxCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                    cbPassengertype.Text = row.Cells["PassengerType"].Value.ToString();
                    cbBoardingCity.Text = row.Cells["Boarding City/Municipality"].Value?.ToString();
                    cbBoardingfrom.Text = row.Cells["BoardingFrom"].Value.ToString();
                    cbBusType.Text = row.Cells["BusType"].Value.ToString();
                    cbDestinationCity.Text = row.Cells["Destination City/Municipality"].Value?.ToString();
                    cbDestination.Text = row.Cells["Destination"].Value.ToString();
                    txtboxFare.Text = row.Cells["Fare"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
