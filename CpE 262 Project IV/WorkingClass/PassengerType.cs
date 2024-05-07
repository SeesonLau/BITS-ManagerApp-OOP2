using System.Data.OleDb;
namespace CpE_262_Project_IV
{
    public class PassengerType : DatabaseAccess
    {   
        public string? GetPassengerType(string passengertype)
        {
            string query = "SELECT Types FROM PassengerType WHERE Types = @passengerType";
            string? passType = null;

            using (var connection = GetConnection())
            using (var command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@passengerType", passengertype);

                try
                {
                    OpenConn();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        passType = Convert.ToString(reader["Types"]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    CloseConn();
                }
            }
            return passType;
        }
    }
}
