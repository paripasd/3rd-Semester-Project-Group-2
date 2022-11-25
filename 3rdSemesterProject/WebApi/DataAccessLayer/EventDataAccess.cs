﻿using System.Data.SqlClient;
using WebApi.ModelLayer;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WebApi.DataAccessLayer
{
    public class EventDataAccess : IEventDataAccess
    {
        DatabaseConnection connection;
        public EventDataAccess()
        {
            connection = new DatabaseConnection();
        }
        #region CRUD Methods
        public bool CreateEvent(Event e)
        {
            string commandText = "INSERT INTO Event (Name,Description,StartDate,EndDate,Capacity) VALUES (@name,@description,@startdate,@enddate,@capacity)";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());
                command.Parameters.AddWithValue("@name", e.Name);
                command.Parameters.AddWithValue("@description", e.Description);
                command.Parameters.AddWithValue("@startdate", e.StartDate);
                command.Parameters.AddWithValue("@enddate", e.EndDate);
                command.Parameters.AddWithValue("@capacity", e.Capacity);
                try
                {
                    command.ExecuteScalar();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                    throw new Exception($"Exception while trying to insert Event object. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public bool DeleteEvent(Event e)
        {
            string commandText = "DELETE FROM Event WHERE EventID = @eventid";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());
                command.Parameters.AddWithValue("@eventid", e.EventID);

                try
                {
                    return command.ExecuteNonQuery() == 1;

                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to delete an Event. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public Event FindEventFromId(int eventId)
        {
            string commandText = "SELECT * FROM Event WHERE EventID = @eventid";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());
                command.Parameters.AddWithValue("@eventid", eventId);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return DataReaderRowToEvent(reader);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to find the Event with the '{eventId}'. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public IEnumerable<Event> GetAllEvents()
        {
            string commandText = "SELECT * FROM Event";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());

                try
                {
                    List<Event> events = new List<Event>();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        events.Add(DataReaderRowToEvent(reader));
                    }
                    return events;

                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to read all rows from the Event table. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public bool UpdateEvent(Event e)
        {
            string commandText = "UPDATE Event SET Name=@name, Description=@description, StartDate=@startdate, EndDate=@enddate, Capacity=@capacity WHERE EventID=@eventid";
            using (connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection.GetConnection());
                command.Parameters.AddWithValue("@name", e.Name);
                command.Parameters.AddWithValue("@description", e.Description);
                command.Parameters.AddWithValue("@startdate", e.StartDate);
                command.Parameters.AddWithValue("@enddate", e.EndDate);
                command.Parameters.AddWithValue("@capacity", e.Capacity);
                command.Parameters.AddWithValue("@eventid", e.EventID);

                try
                {
                    return command.ExecuteNonQuery() == 1;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to update Event. The exception was: '{ex.Message}'", ex);
                }
            }
        }
        #endregion
        #region Helper Methods
        protected Event DataReaderRowToEvent(SqlDataReader reader)
        {
            Event e = new Event();
            e.EventID = (int)reader["EventID"];
            e.GameID = (int)reader["GameID"];
            e.Description = (string)reader["Description"];
            e.StartDate = (DateTime)reader["StartDate"];
            e.EndDate = (DateTime)reader["EndDate"];
            e.Capacity = (int)reader["Capacity"];


            return e;
        }
        #endregion
    }
}
