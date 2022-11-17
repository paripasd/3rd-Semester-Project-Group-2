using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApi.DataAccessLayer
{
    public class DatabaseConnection
    {

        string ConnectionString = "Data Source=hildur.ucn.dk;Initial Catalog=CSC-CSD-S212_10407565;User ID=csc-csd-s212_10407565;Password=Password1!";
        SqlConnection con;

        public DatabaseConnection()
        { 
            con = new SqlConnection(ConnectionString);
        }

        public SqlConnection GetConnection()
        {
            return con;
        }

        public void Open()
        {
            con.Open();
        }

        public void Close()
        {
            con.Close();
        }
    }
}
