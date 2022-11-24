﻿using System.Data.SqlClient;
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
        public bool UpdateGameFile(GameFile gameFile)
        {
            string commandText = "UPDATE GameFile SET FileName=@filename, FileContent=@filecontent WHERE GameID=@gameid";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());
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
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());
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
                    throw new Exception($"Exception while trying to find the game with the '{gameId}'. The exception was: '{ex.Message}'", ex);
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
