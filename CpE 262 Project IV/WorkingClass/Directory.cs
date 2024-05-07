using System.Data.OleDb;

namespace CpE_262_Project_IV
{
    public class Directory : DatabaseAccess
    { 
        public double? GetDistance(string barangay)
        {
            string query = "SELECT Distance FROM Directory WHERE Barangay = @barangay";
            double? distance = null;

            using (var connection = GetConnection())
            using (var command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@barangay", barangay);

                try
                {
                    OpenConn();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        distance = Convert.ToDouble(reader["Distance"]);
                    }
                    reader.Close();
                    CloseConn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return distance;
        }
    }

}
