using Emgu.CV.CvEnum;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CpE_262_Project_IV
{
    public partial class PassengerTicket : UserControl
    {
        private string? locBoarding;
        private string? locDestination;
        private string? cityBoarding;
        private string? cityDestination;
        private string? passengeType;
        public string? GetLocB()
        {
            return locBoarding;
        }
        public string? GetLocD()
        {
            return locDestination;
        }
        public string? GetCityBoarding()
        {
            return cityBoarding;
        }
        public string? GetCityDestination()
        {
            return cityDestination;
        }
        public string? GetPassengerType()
        {
            return passengeType;
        }

        private OleDbConnection? connection;
        OleDbCommand? cmd;
        OleDbDataAdapter? da;
        DataSet? ds;
        private string connectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\johnl\\OneDrive\\Desktop\\Code\\CpE262Project\\CpE262ProjectFINAL\\CpE 262 Project IV\\Database\\ManagerAppDatabase.accdb");
        public PassengerTicket()
        {
            InitializeComponent();
            InitializePictureBoxes();
            InitializeInputsPassenger();
            this.DoubleBuffered = true;
            gunaCircleBar.Value = 0;
            UpdateSeats();
            connection = new OleDbConnection(connectionString);

            InitializePassDrive driver = new InitializePassDrive();
            string? bustype = driver.RetrieveBusType()?.ToString();
            cbBusType.Text = bustype;
        }
        private void InitializeInputsPassenger()
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            InitializePassDrive pass = new InitializePassDrive();
            string? passID = pass.RetrievePassID()?.ToString();
            //string? passID = null;
            string query = $"SELECT PassengerID, PassengerType FROM PassengerAccount WHERE PassengerID = @passID";

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
                        cbPassengertype.Text = reader["PassengerType"].ToString();
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

        private void InitializePictureBoxes()
        {
            // Assuming you have 61 picture boxes named pictureBox1, pictureBox2, ..., pictureBox61
            for (int i = 1; i <= 61; i++)
            {
                PictureBox pictureBox = (PictureBox)this.Controls.Find("pictureBox" + i, true)[0];
                pictureBox.Click += PictureBox_Click;
                UpdatePictureBoxStatus(pictureBox, i);
            }
        }
        private void UpdatePictureBoxStatus(PictureBox pictureBox, int seatId)
        {
            using (connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SeatStatus FROM Seats WHERE SeatID = @SeatID";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SeatID", seatId);
                    object? result = command.ExecuteScalar();
                    string? seatStatus = result != null ? result.ToString() : "Unoccupied"; // Default to "Unoccupied" if null
                    Color newColor = seatStatus == "Occupied" ? Color.Red : Color.Green;
                    pictureBox.BackColor = newColor;

                    // Update corresponding label's back color
                    System.Windows.Forms.Label label = (System.Windows.Forms.Label)this.Controls.Find("label" + seatId, true)[0];
                    label.BackColor = newColor;
                }
            }
        }
        private void PictureBox_Click(object? sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                int seatId = int.Parse(pictureBox.Name.Replace("pictureBox", ""));
                using (connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Seats SET SeatStatus = @SeatStatus WHERE SeatID = @SeatID";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        string newStatus = pictureBox.BackColor == Color.Green ? "Occupied" : "Unoccupied";
                        command.Parameters.AddWithValue("@SeatStatus", newStatus);
                        command.Parameters.AddWithValue("@SeatID", seatId);
                        command.ExecuteNonQuery();
                    }
                }
                UpdatePictureBoxStatus(pictureBox, seatId);
                UpdateSeats();
            }
        }
        private void UpdateSeats()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    int totalSeats = 61;
                    string unoccupiedQuery = "SELECT COUNT(*) FROM Seats WHERE SeatStatus = 'Unoccupied'";
                    OleDbCommand unoccupiedCommand = new OleDbCommand(unoccupiedQuery, connection);
                    int unoccupiedSeats = (int)(unoccupiedCommand.ExecuteScalar() ?? 0);

                    string occupiedQuery = "SELECT COUNT(*) FROM Seats WHERE SeatStatus = 'Occupied'";
                    OleDbCommand occupiedCommand = new OleDbCommand(occupiedQuery, connection);
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
        }
        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            try
            {
                string ticketing = "INSERT INTO Ticketing (DateIssued, CustomerID, PassengerType, [Boarding City/Municipality], BoardingFrom, BusType, [Destination City/Municipality], Destination, Fare) " +
                "VALUES (@dateissued, @customerID, @passengertype, @Bcity, @boardingfrom, @bustype, @Dcity, @destination, @fare)";
                cmd = new OleDbCommand(ticketing, connection);
                cmd.Parameters.AddWithValue("@dateissued", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@customeID", txtboxPassengerID.Text);
                cmd.Parameters.AddWithValue("@passengertype", cbPassengertype.Text);
                cmd.Parameters.AddWithValue("@Bcity", cbBoardingCity.Text);
                cmd.Parameters.AddWithValue("@boardingfrom", cbBoardingfrom.Text);
                cmd.Parameters.AddWithValue("@bustype", cbBusType.Text);
                cmd.Parameters.AddWithValue("@Dcity", cbDestinationCity.Text);
                cmd.Parameters.AddWithValue("@destination", cbDestination.Text);
                cmd.Parameters.AddWithValue("@fare", txtboxFare.Text);
                connection?.Open();
                cmd.ExecuteNonQuery();
                connection?.Close();

                Random random = new Random();
                string serialNumber = new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10).Select(s => s[random.Next(s.Length)]).ToArray());
                string receiptDirectory = @"C:\Users\johnl\OneDrive\Desktop\Code\CpE262Project\CpE262ProjectFINAL\CpE 262 Project IV\Receipts";
                string receiptFileName = Path.Combine(receiptDirectory, $"Receipt_{serialNumber}.pdf");

                if (!System.IO.Directory.Exists(receiptDirectory))
                {
                    System.IO.Directory.CreateDirectory(receiptDirectory);
                }
                string? paymentMethod = null;
                if (checkCASH.Checked)
                {
                    paymentMethod = "CASH";
                }
                else
                {
                    paymentMethod = "ONLINE";
                }


                using (FileStream fs = new FileStream(receiptFileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Document doc = new Document();
                    PdfWriter.GetInstance(doc, fs);
                    doc.Open();
                    doc.Add(new Paragraph("\n\n"));
                    doc.Add(new Paragraph("                                                                    Bus Bus Co."));
                    doc.Add(new Paragraph("                                                              Southern Cebu Route"));
                    doc.Add(new Paragraph("                                                      Bus Integrated and Ticketing System"));
                    doc.Add(new Paragraph("                                                              Manager Application"));
                    doc.Add(new Paragraph($"                                                                   Serial # {serialNumber}"));
                    doc.Add(new Paragraph("\n\n"));
                    doc.Add(new Paragraph($"Date: {dateTimePicker1.Text}"));
                    doc.Add(new Paragraph($"PassengerID: {txtboxPassengerID.Text}"));
                    doc.Add(new Paragraph($"Time: {dateTimePicker2.Text}"));
                    doc.Add(new Paragraph($"Bus Type: {cbBusType.Text}"));
                    doc.Add(new Paragraph($"Boarding From: {cbBoardingCity.Text}, {cbBoardingfrom.Text}"));
                    doc.Add(new Paragraph($"Destination: {cbDestinationCity.Text}, {cbDestination.Text}"));
                    doc.Add(new Paragraph($"Passenger Type: {cbPassengertype.Text}"));
                    doc.Add(new Paragraph("----------------------------------------------------------------------------------------------------------------------------------"));
                    doc.Add(new Paragraph($"Payment Method:     {paymentMethod}"));
                    doc.Add(new Paragraph($"Total:                         {txtboxFare.Text}"));
                    doc.Add(new Paragraph("\n\n"));
                    doc.Add(new Paragraph("  THIS TICKET SHALL BE VALID FOR FIVE (5) YEARS FROM THE DATE OF ATP"));
                    doc.Add(new Paragraph("      THIS DOCUMENT IS NOT VALID FOR CLAIM OF INPUT TAXES"));
                    doc.Close();
                }
                if (checkCASH.Checked)
                {
                    MessageBox.Show("Please pay to the Driver when leaving the bus. Thank you!");
                }
                else
                {
                    MessageBox.Show("Payment successful.");
                }
                System.Diagnostics.Process.Start(receiptFileName);
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

        private void cbPassengertype_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string tempCity = cbBoardingCity.Text;
            cbBoardingCity.Text = cbDestinationCity.Text;
            cbDestinationCity.Text = tempCity;

            string tempLocation = cbBoardingfrom.Text;
            cbBoardingfrom.Text = cbDestination.Text;
            cbDestination.Text = tempLocation;
        }

        private void btnTheUsual_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();

                cmd = new OleDbCommand("SELECT TOP 1 [Boarding City/Municipality], [BoardingFrom], [Destination City/Municipality], [Destination], COUNT(*) AS Frequency " +
                                       "FROM Ticketing " +
                                       "GROUP BY [Boarding City/Municipality], [BoardingFrom], [Destination City/Municipality], [Destination] " +
                                       "ORDER BY COUNT(*) DESC", connection);

                da = new OleDbDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Ticketing");

                if (ds?.Tables["Ticketing"] != null)
                {
                    DataRow? row = ds.Tables["Ticketing"]?.Rows.Count > 0 ? ds.Tables["Ticketing"]?.Rows[0] : null;
                    if (row != null)
                    {
                        string? boardingCity = row["Boarding City/Municipality"].ToString();
                        string? boardingFrom = row["BoardingFrom"].ToString();
                        string? destinationCity = row["Destination City/Municipality"].ToString();
                        string? destination = row["Destination"].ToString();
                        int frequency = Convert.ToInt32(row["Frequency"]);

                        cbBoardingCity.Text = boardingCity;
                        cbBoardingfrom.Text = boardingFrom;
                        cbDestinationCity.Text = destinationCity;
                        cbDestination.Text = destination;
                        /*
                        MessageBox.Show($"Most frequent values:\n" +
                                        $"Boarding City/Municipality: {boardingCity}\n" +
                                        $"Boarding From: {boardingFrom}\n" +
                                        $"Destination City/Municipality: {destinationCity}\n" +
                                        $"Destination: {destination}\n" +
                                        $"Frequency: {frequency}");*/
                    }
                    else
                    {
                        MessageBox.Show("No data found in the Ticketing table.");
                    }
                }
                else
                {
                    MessageBox.Show("The Ticketing table is null or not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }
    }
}
