﻿using System.Data.SqlClient;
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
        public bool CreateGame(Game game) //creates game table and gameFile table full entry
        {            
            string commandText = "INSERT INTO Game (DeveloperID, Title, Description, YearOfRelease, Specifications, Type, Price) VALUES (@developerid, @title, @description, @yearofrelease, @specifications, @type, @price); INSERT INTO GameFile (GameID, FileName, FileContent) VALUES (SCOPE_IDENTITY(), @fileName, @fileContent)";
           
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
                command.Parameters.AddWithValue("@fileName", game.FileName);
                command.Parameters.AddWithValue("@fileContent", game.FileContent);

                try
                {
                    command.ExecuteScalar();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                    throw new Exception($"Exception while trying to insert Game object into Game and GameFile tables. The exception was: '{ex.Message}'", ex);
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
        protected Game DataReaderRowToGameAll(SqlDataReader reader)
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
            game.FileName = (string)reader["FileName"];
            game.FileContent = (byte[])reader["FileContent"];  //FileContent was GameFile up to now ??

            return game;
        }

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

        protected Game DataReaderRowToGameFile(SqlDataReader reader)
        {
            Game game = new Game();
            game.FileName = (string)reader["FileName"];
            game.FileContent = (byte[])reader["FileContent"];  //FileContent was GameFile up to now ??

            return game;
        }
        #endregion
    }
}