using System.Data.OleDb;

namespace CpE_262_Project_IV
{
    public class BusType : DatabaseAccess
    {
        public string? GetBusType(string bustype)
        {
            string query = "SELECT BusType FROM Fare WHERE BusType = @busType";
            string? busType = null;

            using (var connection = GetConnection())
            using (var command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@busType", bustype);

                try
                {
                    OpenConn();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        busType = Convert.ToString(reader["BusType"]);
                    }
                    reader.Close();
                    CloseConn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return busType;
        }
    }
}
