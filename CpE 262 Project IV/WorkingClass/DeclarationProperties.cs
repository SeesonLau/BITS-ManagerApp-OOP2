using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpE_262_Project_IV
{
    public class DeclarationProperties : DatabaseAccess
    {
        //DEFAULT RATES if NULL
        private double RF_aircon = 15;
        private double RF_ordinary = 13;
        private double RR_aircon = 2.64;
        private double RR_ordinary = 2.25;
        private double discount = 0.2;
        public double GetRF_Aircon(){return RF_aircon;}
        public double GetRF_Ordinary(){return RF_ordinary;}
        public double GetRR_Aircon(){return RR_aircon;}
        public double GetRR_Ordinary(){return RR_ordinary;}
        public double GetDiscount(){return discount;}
        protected void SetRF_Aircon(double RF_aircon){this.RF_aircon = RF_aircon;}
        protected void SetRF_Ordinary(double RF_ordinary){this.RF_ordinary = RF_ordinary;}
        protected void SetRR_Aircon(double RR_aircon){this.RR_aircon = RR_aircon;}
        protected void SetRR_Ordinary(double RR_ordinary){this.RR_ordinary = RR_ordinary;}
        protected void SetDiscount(double discount){this.discount = discount;}

        private double RegularRate = 0;
        private double RegularFare = 0;
        public double GetRegularRate() { return RegularRate;}
        public double GetRegularFare() { return RegularFare;}
        protected void SetRegularRate(double RegularRate) { this.RegularRate = RegularRate; }
        protected void SetRegularFare(double RegularFare) { this.RegularFare = RegularFare; }
        public void FareDeclaration(string busType)
        {
            string query = "SELECT RR, RF FROM Fare WHERE BusType = @bustype";
            double RR = 0, RF = 0;
            using (var connection = GetConnection())
            using (var command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@bustype", busType);

                try
                {
                    OpenConn();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        RR = Convert.ToDouble(reader["RR"]);
                        RF = Convert.ToDouble(reader["RF"]);
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
            SetRegularRate(RR);
            SetRegularFare(RF);
        }

    }
    
}
