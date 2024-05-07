using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace CpE_262_Project_IV
{
    public class DatabaseAccess
    {
        private string connectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\johnl\\OneDrive\\Desktop\\Code\\CpE262Project\\CpE262ProjectFINAL\\CpE 262 Project IV\\Database\\ManagerAppDatabase.accdb");
        private static OleDbConnection? connection;
        public OleDbConnection GetConnection()
        {
            connection = new OleDbConnection(connectionString);
            return connection;
        }
        public void OpenConn()
        {
            if (connection != null && connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void CloseConn()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }

}
