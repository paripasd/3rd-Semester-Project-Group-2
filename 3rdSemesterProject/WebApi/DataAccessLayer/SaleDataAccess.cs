using System.Data.SqlClient;
using WebApi.ModelLayer;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WebApi.DataAccessLayer
{
    public class SaleDataAccess : ISaleDataAccess
    {
        DatabaseConnection connection;
        public SaleDataAccess()
        {
            connection = new DatabaseConnection();
        }
        public bool CreateSale(Sale sale)
        {
            string commandText = "INSERT INTO Sale (GameKey, GameID, Email, Date, SalesPrice) VALUES (@gamekey, @gameid, @email, @date, @salesprice)";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());
                command.Parameters.AddWithValue("@gamekey", sale.GameKey);
                command.Parameters.AddWithValue("@gameid", sale.GameID);
                command.Parameters.AddWithValue("@email", sale.Email);
                command.Parameters.AddWithValue("@date", sale.Date);
                command.Parameters.AddWithValue("@salesprice", sale.SalesPrice);
                

                try
                {
                    command.ExecuteScalar();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                    throw new Exception($"Exception while trying to insert Sale object. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public bool DeleteSale(Sale sale)
        {
            string commandText = "DELETE FROM Sale WHERE GameKey = @gamekey";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());
                command.Parameters.AddWithValue("@gamekey", sale.GameKey);

                try
                {
                    return command.ExecuteNonQuery() == 1;

                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to delete a sale. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public Sale FindSaleFromGameKey(string gameKey)
        {
            string commandText = "SELECT * FROM Sale WHERE GameKey = @gamekey";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());
                command.Parameters.AddWithValue("@gamekey", gameKey);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return DataReaderRowToSale(reader);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to find the specific sale. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public IEnumerable<Sale> GetAllSales()
        {
            string commandText = "SELECT * FROM Sale";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());

                try
                {
                    List<Sale> sales = new List<Sale>();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        sales.Add(DataReaderRowToSale(reader));
                    }
                    return sales;

                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to read all rows from the Sale table. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        #region Helper Methods
        protected Sale DataReaderRowToSale(SqlDataReader reader)
        {
            Sale sale = new Sale();
            sale.GameKey = (string)reader["GameKey"];
            sale.GameID = (int)reader["GameID"];
            sale.Email = (string)reader["Email"];
            sale.Date = (DateTime)reader["Date"];
            sale.SalesPrice = (int)reader["SalesPrice"];

            return sale;
        }
        #endregion
    }
}
