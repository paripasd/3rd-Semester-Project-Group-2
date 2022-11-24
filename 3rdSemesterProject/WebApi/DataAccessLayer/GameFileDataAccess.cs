using System.Data.SqlClient;
using System.Security.Principal;
using WebApi.ModelLayer;

namespace WebApi.DataAccessLayer
{
    public class GameFileDataAccess : IGameFileDataAccess
    {

        DatabaseConnection connection;
        public GameFileDataAccess()
        {
            connection = new DatabaseConnection();
        }
        public bool AddGame(GameFile gameFile)
        {
            string commandText = "INSERT INTO GameFile (FileName, GameFile) VALUES (@fileName, @gameFile)";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());
                command.Parameters.AddWithValue("@fileName", gameFile.FileName);
                command.Parameters.AddWithValue("@fileContent", gameFile.FileContent);

                try
                {
                    command.ExecuteScalar();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                    throw new Exception($"Exception while trying to insert GameFile object. The exception was: '{ex.Message}'", ex);
                }
            }
        }
    }
}
