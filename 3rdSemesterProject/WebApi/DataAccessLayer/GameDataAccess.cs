using System.Data.SqlClient;
using System.Security.Principal;
using WebApi.ModelLayer;

namespace WebApi.DataAccessLayer
{
    public class GameDataAccess : IGameDataAccess
    {
        DatabaseConnection connection;

        public GameDataAccess()
        {
            connection = new DatabaseConnection();
        }
        #region CRUD Methods
        //can only add into GameFile table if Game table info is added first
        public bool CreateGame(Game game, GameFile gameFile)
        {
            SqlTransaction transaction;
            string commandText = "INSERT INTO Game (DeveloperID, Title, Description, YearOfRelease, Specifications, Type, Price) VALUES (@developerid, @title, @description, @yearofrelease, @specifications, @type, @price)";
            string commandText2 = "INSERT INTO GameFile (GameID, FileName, GameFile) VALUES (@gameid, @fileName, @gameFile)";
            using (connection.GetConnection())
            {
                connection.Open();
                transaction = connection.GetConnection().BeginTransaction(System.Data.IsolationLevel.RepeatableRead);

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());
                command.Parameters.AddWithValue("@developerid", game.DeveloperID);
                command.Parameters.AddWithValue("@title", game.Title);
                command.Parameters.AddWithValue("@description", game.Description);
                command.Parameters.AddWithValue("@yearofrelease", game.YearOfRelease);
                command.Parameters.AddWithValue("@specifications", game.Specifications);
                command.Parameters.AddWithValue("@type", game.Type);
                command.Parameters.AddWithValue("@price", game.Price);



                // in the try and catch part there are try catches to see if the code breaks exactly at the roll back line
                int gameID;
                try
                {
                    gameID = (int)command.ExecuteScalar();
                    gameFile.GameID = gameID;
                    
                }
                catch (Exception ex)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception)
                    {
                        throw new Exception("Error rolling back create game transaction.");
                    }
                    return false;
                    throw new Exception($"Exception while trying to insert game info into game table. The exception was: '{ex.Message}'", ex);
                }

                SqlCommand command2 = new SqlCommand(commandText2, connection.GetConnection());
                command2.Parameters.AddWithValue("@fileName", gameFile.FileName);
                command2.Parameters.AddWithValue("@fileContent", gameFile.FileContent);
                command2.Parameters.AddWithValue("@gameid", gameFile.GameID);

                try
                {
                    command2.ExecuteScalar();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {

                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception)
                    {
                        throw new Exception("Error rolling back create game transaction.");
                    }
                    return false;
                    throw new Exception($"Exception while trying to insert game file info into GameFile table. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public Game FindGameFromId(int gameId)
        {
            string commandText = "SELECT * FROM Game WHERE GameID = @gameId";
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
                        return DataReaderRowToGame(reader);
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

        public IEnumerable<Game> GetAllGames()
        {
            string commandText = "SELECT * FROM Game";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());

                try
                {
                    List<Game> games = new List<Game>();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        games.Add(DataReaderRowToGame(reader));
                    }
                    return games;

                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to read all rows from the Game table. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public bool UpdateAllGameDetails(Game game)
        {
            string commandText = "UPDATE Game SET DeveloperID=@developerid, Title=@title, Description=@description, YearOfRelease=@yearofrelease, Specifications=@specifications, Type=@type, Price=@price WHERE GameID=@gameid";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());
                command.Parameters.AddWithValue("@developerid", game.DeveloperID);
                command.Parameters.AddWithValue("@title", game.Title);
                command.Parameters.AddWithValue("@description", game.Description);
                command.Parameters.AddWithValue("@yearofrelease", game.YearOfRelease);
                command.Parameters.AddWithValue("@specifications", game.Specifications);
                command.Parameters.AddWithValue("@type", game.Type);
                command.Parameters.AddWithValue("@price", game.Price);

                try
                {
                    return command.ExecuteNonQuery() == 1;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to update game. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public bool DeleteGame(int id)
        {
            string commandText = "DELETE FROM Game WHERE GameID = @gameid";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());
                command.Parameters.AddWithValue("@gameid", id);

                try
                {
                    return command.ExecuteNonQuery() == 1;

                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to delete a game. The exception was: '{ex.Message}'", ex);
                }
            }
        }
        #endregion
        #region Helper Methods
        protected Game DataReaderRowToGame(SqlDataReader reader)
        {
            Game game = new Game();
            game.GameID = (int)reader["GameID"];
            game.DeveloperID = (int)reader["DeveloperID"];
            game.Title = (string)reader["Title"];
            game.Description = (string)reader["Description"];
            game.YearOfRelease = (int)reader["YearOfRelease"];
            game.Specifications = (string)reader["Specifications"];
            game.Type = (string)reader["Type"];
            game.Price = Convert.ToSingle(reader["Price"]);

            return game;
        }
        #endregion
    }
}