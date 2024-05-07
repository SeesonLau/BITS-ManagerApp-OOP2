using System.Data;
using System.Data.OleDb;
using ZedGraph;

namespace CpE_262_Project_IV
{
    public partial class AdminStatistics : UserControl
    {
        DatabaseAccess databaseAccess = new DatabaseAccess();
        OleDbDataAdapter? da;
        System.Data.DataSet? ds;
        public AdminStatistics()
        {
            InitializeComponent();
        }
        void CreateChart()
        {
            formsPlot1.Plot.Style(dataBackground: Color.LightYellow); // Set background color
            formsPlot1.Plot.Grid(color: Color.Black); // Set grid line color

            databaseAccess.OpenConn();
            string query = "SELECT DateIssued, Fare FROM Ticketing";

            using (OleDbCommand command = new OleDbCommand(query, databaseAccess.GetConnection()))
            {
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    Dictionary<DateTime, double> fareSumByDate = new Dictionary<DateTime, double>();
                    DateTime mostEarnedDay = DateTime.MinValue;
                    double highestEarningsInADay = 0;
                    while (reader.Read())
                    {
                        string? dateIssuedStr = reader["DateIssued"].ToString();
                        string? fareStr = reader["Fare"].ToString();
                        if (DateTime.TryParse(dateIssuedStr, out DateTime dateIssued))
                        {
                            double fare;
                            if (double.TryParse(fareStr, out fare))
                            {
                                if (fareSumByDate.ContainsKey(dateIssued))
                                    fareSumByDate[dateIssued] += fare;
                                else
                                    fareSumByDate[dateIssued] = fare;
                                if (fareSumByDate[dateIssued] > highestEarningsInADay)
                                {
                                    highestEarningsInADay = fareSumByDate[dateIssued];
                                    mostEarnedDay = dateIssued;
                                }
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
                    // Display the most earned day in txtboxMostEarnedDay
                    txtboxMostEarnedDay.Text = mostEarnedDay.ToShortDateString();
                    // Display the highest earnings in a day in txtboxHighestEarningsinaDay
                    txtboxHighestEarningsinaDay.Text = highestEarningsInADay.ToString("C");
                }
                databaseAccess.CloseConn();
            }
            // X axis in DATE TIME format
            formsPlot1.Plot.XAxis.DateTimeFormat(true);
            // Set LABEL
            formsPlot1.Plot.XAxis.Label("Date");
            formsPlot1.Plot.YAxis.Label("Total Fare Earnings");
            formsPlot1.Refresh();
        }
        private void AdminStatistics_Load(object sender, EventArgs e){}
        private void formsPlot1_Load(object sender, EventArgs e)
        {
            try
            {
                if (checkViewTotal.Checked)
                {
                    CreateChart();
                }
                else
                {
                    string customerID = txtboxCustomerID.ToString();
                    DisplayChart(customerID);
                }
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

                da = new OleDbDataAdapter($"SELECT * FROM [Ticketing] WHERE CustomerID = '{txtboxCustomerID.Text}'", databaseAccess.GetConnection());
                ds = new System.Data.DataSet();
                da.Fill(ds, "Ticketing");
                dgvAdminSatistics.DataSource = ds.Tables["Ticketing"];

                // Calculate the total sum of the "Fare" column
                double totalFare = 0;
                DataTable? passengerHistoryTable = ds.Tables["Ticketing"];
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseAccess?.CloseConn();
            }

        }
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
            string query = $"SELECT DateIssued, Fare FROM Ticketing WHERE CustomerID = '{txtboxCustomerID.Text}'";

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
        private void checkViewTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkViewTotal.Checked)
            {
                CreateChart();
            }
            else
            {
                string customerID = txtboxCustomerID.Text;
                DisplayChart(customerID);
            }
        }
    }
}
