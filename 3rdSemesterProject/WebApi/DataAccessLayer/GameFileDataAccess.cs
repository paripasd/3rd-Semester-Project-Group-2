using System.Data.SqlClient;
using System.Security.Principal;
using WebApi.ModelLayer;

namespace WebApi.DataAccessLayer
{
    public class GameFileDataAccess : IGameFileDataAccess
    {

        SqlConnection connection;
        public GameFileDataAccess(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }
        public bool AddGame(GameFile gameFile)
        {
            string commandText = "INSERT INTO GameFile (FileName, GameFile) VALUES (@fileName, @gameFile)";
            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection);
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
        public bool UpdateGameFile(GameFile gameFile)
        {
            string commandText = "UPDATE GameFile SET FileName=@filename, FileContent=@filecontent WHERE GameID=@gameid";
            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@filename", gameFile.FileName);
                command.Parameters.AddWithValue("@filecontent", gameFile.FileContent);
                command.Parameters.AddWithValue("@gameid", gameFile.GameID);

                try
                {
                    return command.ExecuteNonQuery() == 1;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to update gameFile info. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public GameFile GetGameFileById(int gameId)
        {
            string commandText = "SELECT * FROM GameFile WHERE GameID = @gameId";
            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@gameId", gameId);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return DataReaderRowToGameFile(reader);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to find the gamefile with the '{gameId}'. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        #region Helper Methods
        protected GameFile DataReaderRowToGameFile(SqlDataReader reader)
        {
            GameFile gameFile = new GameFile();
            gameFile.GameID = (int)reader["GameID"];
            gameFile.FileName = (string)reader["FileName"];
            gameFile.FileContent = (byte[])reader["FileContent"];
            return gameFile;
        }
        #endregion

    }
}
