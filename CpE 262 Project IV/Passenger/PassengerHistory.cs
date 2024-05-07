using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace CpE_262_Project_IV
{
    public partial class PassengerHistory : UserControl
    {
        OleDbDataAdapter? da;
        DataSet? ds;
        DatabaseAccess databaseAccess = new DatabaseAccess();
        public PassengerHistory()
        {
            InitializeComponent();
            InitializeInputs();
        }
        private void InitializeInputs()
        {
            InitializePassDrive pass = new InitializePassDrive();
            string? passID = pass.RetrievePassID()?.ToString();
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
                        txtboxCustomerID.Text = reader["PassengerID"].ToString();
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
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string customerID = txtboxCustomerID.ToString();
                DisplayChart(customerID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void txtboxCustomerID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (databaseAccess.GetConnection()?.State != ConnectionState.Open)
                {
                    databaseAccess.OpenConn();
                }

                da = new OleDbDataAdapter($"SELECT * FROM [PassengerHistory] WHERE CustomerID = '{txtboxCustomerID.Text}'", databaseAccess.GetConnection());
                ds = new DataSet();
                da.Fill(ds, "PassengerHistory");
                dgvHistory.DataSource = ds.Tables["PassengerHistory"];

                // Calculate the total sum of the "Fare" column
                double totalFare = 0;
                DataTable? passengerHistoryTable = ds.Tables["PassengerHistory"];
                if (passengerHistoryTable != null)
                {
                    string customerID = txtboxCustomerID.ToString();
                    DisplayChart(customerID);
                    foreach (DataRow row in passengerHistoryTable.Rows)
                    {
                        double fare;
                        if (double.TryParse(row["Fare"].ToString(), out fare))
                        {
                            totalFare += fare;
                        }
                    }
                }
                // Display the total sum of the "Fare" column in txtboxLifetimeSpend
                txtboxLfietimeSpend.Text = totalFare.ToString("F2");
                // Find the most frequent "Destination City/Municipality"
                if (passengerHistoryTable != null)
                {
                    // Find the most frequent "Boarding City/Municipality" and "BoardingFrom"
                    var mostFrequentBoardingCityMunicipality = passengerHistoryTable.AsEnumerable()
                        .GroupBy(r => new { City = r.Field<string>("Boarding City/Municipality"), From = r.Field<string>("BoardingFrom") })
                        .OrderByDescending(g => g.Count())
                        .Select(g => g.Key)
                        .FirstOrDefault();

                    if (mostFrequentBoardingCityMunicipality != null)
                    {
                        // Display the most frequent "Boarding City/Municipality" and "BoardingFrom"
                        txtboxCityBoarding.Text = mostFrequentBoardingCityMunicipality.City;
                        txtboxBoardingBarangay.Text = mostFrequentBoardingCityMunicipality.From;

                        // Find the corresponding "Destination City/Municipality" and "Destination"
                        var mostFrequentDestination = passengerHistoryTable.AsEnumerable()
                            .Where(r => r.Field<string>("Boarding City/Municipality") == mostFrequentBoardingCityMunicipality.City && r.Field<string>("BoardingFrom") == mostFrequentBoardingCityMunicipality.From)
                            .GroupBy(r => new { City = r.Field<string>("Destination City/Municipality"), Destination = r.Field<string>("Destination") })
                            .OrderByDescending(g => g.Count())
                            .Select(g => g.Key)
                            .FirstOrDefault();

                        if (mostFrequentDestination != null)
                        {
                            // Display the corresponding "Destination City/Municipality" and "Destination"
                            txtboxCityDestination.Text = mostFrequentDestination.City;
                            txtboxDestinationBarangay.Text = mostFrequentDestination.Destination;
                        }
                    }
                }
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

        private void formsPlot1_Load(object sender, EventArgs e){}
        private void DisplayChart(string customerID)
        {
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.Style(dataBackground: Color.LightYellow); // Set background color
            formsPlot1.Plot.Grid(color: Color.Black); // Set grid line color
            // Ensure the connection is not null and open
            if (databaseAccess.GetConnection() == null)
            {
                databaseAccess.GetConnection();
            }
            if (databaseAccess.GetConnection().State != ConnectionState.Open)
            {
                databaseAccess.OpenConn();
            }

            // Query to select DateIssued and Fare columns from PassengerHistory table
            string query = $"SELECT DateIssued, Fare FROM PassengerHistory WHERE CustomerID = '{txtboxCustomerID.Text}'";

            using (OleDbCommand command = new OleDbCommand(query, databaseAccess.GetConnection()))
            {
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    Dictionary<DateTime, double> fareSumByDate = new Dictionary<DateTime, double>();

                    // Read data from the database
                    while (reader.Read())
                    {
                        string? dateIssuedStr = reader["DateIssued"].ToString();
                        string? fareStr = reader["Fare"].ToString();

                        // Convert DateIssued to DateTime and Fare to double
                        if (DateTime.TryParse(dateIssuedStr, out DateTime dateIssued))
                        {
                            double fare;
                            if (double.TryParse(fareStr, out fare))
                            {
                                // Aggregate fare values for the same date
                                if (fareSumByDate.ContainsKey(dateIssued))
                                    fareSumByDate[dateIssued] += fare;
                                else
                                    fareSumByDate[dateIssued] = fare;
                            }
                        }
                    }
                    var dates = fareSumByDate.Keys.ToList();
                    dates.Sort();
                    for (int i = 0; i < dates.Count - 1; i++)
                    {
                        double xDate1 = new XDate(dates[i].Year, dates[i].Month, dates[i].Day).XLDate;
                        double xDate2 = new XDate(dates[i + 1].Year, dates[i + 1].Month, dates[i + 1].Day).XLDate;
                        formsPlot1.Plot.AddLine(xDate1, fareSumByDate[dates[i]], xDate2, fareSumByDate[dates[i + 1]]);
                    }
                }
            }

            // Close the connection (if not already closed)
            if (databaseAccess.GetConnection().State != ConnectionState.Closed)
            {
                databaseAccess.CloseConn();
            }

            // Specify that the X-axis should be treated as dates
            formsPlot1.Plot.XAxis.DateTimeFormat(true);
            // Set the X-axis label
            formsPlot1.Plot.XAxis.Label("Date");
            formsPlot1.Plot.YAxis.Label("Total Fare Spent");
            formsPlot1.Refresh();
        }
    }

}
