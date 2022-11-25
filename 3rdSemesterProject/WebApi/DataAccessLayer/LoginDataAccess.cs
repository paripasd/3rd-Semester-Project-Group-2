using System.Data.SqlClient;
using WebApi.ModelLayer;


namespace WebApi.DataAccessLayer
{
    public class LoginDataAccess : ILoginDataAccess
    {
        DatabaseConnection connection;
        public LoginDataAccess()
        {
            connection = new DatabaseConnection();
        }
        #region CRUD Methods
        public bool CreateLogin(Login login)
        {
            string hashPassword = Login.HashPassword(login.Password);
            string commandText = "INSERT INTO Login (UserName,Password) VALUES (@username,@password)";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());
                command.Parameters.AddWithValue("@username", login.UserName);
                command.Parameters.AddWithValue("@password", hashPassword);
                try
                {
                    command.ExecuteScalar();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                    throw new Exception($"Exception while trying to insert Login object. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public bool DeleteLogin(Login login)
        {
            string commandText = "DELETE FROM Login WHERE UserName = @username";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());
                command.Parameters.AddWithValue("@username", login.UserName);

                try
                {
                    return command.ExecuteNonQuery() == 1;

                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to delete a Login. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public IEnumerable<Login> GetAllLoginInformation()
        {
            string commandText = "SELECT * FROM Login";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());

                try
                {
                    List<Login> members = new List<Login>();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        members.Add(DataReaderRowToLogin(reader));
                    }
                    return members;

                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to read all rows from the Login table. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public bool UpdateLogin(Login login)
        {
            string commandText = "UPDATE Login SET UserName=@username, Password=@password WHERE UserName=@un";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());
                command.Parameters.AddWithValue("@username", login.UserName);
                command.Parameters.AddWithValue("@password", login.Password);
                command.Parameters.AddWithValue("@un", login.UserName);

                try
                {
                    return command.ExecuteNonQuery() == 1;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to update Login. The exception was: '{ex.Message}'", ex);
                }
            }
        }
        #endregion

        #region Helper Methods
        protected Login DataReaderRowToLogin(SqlDataReader reader)
        {
            Login login = new Login();
            login.UserName = (string)reader["UserName"];
            login.Password = (string)reader["Password"];
            

            return login;
        }
        #endregion
    }
}
