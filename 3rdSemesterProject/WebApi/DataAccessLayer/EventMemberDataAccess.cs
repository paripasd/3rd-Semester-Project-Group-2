using System.Data.SqlClient;
using System.Linq.Expressions;
using WebApi.ModelLayer;

namespace WebApi.DataAccessLayer
{
    public class EventMemberDataAccess : IEventMemberDataAccess
    {
        SqlConnection connection;
        public EventMemberDataAccess(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }
        #region CRUD Methods
        public EventMember FindEventByMemberId(int memberid)
        {
            string commandText = "SELECT EventID FROM EventMember WHERE MemberID = @memberid";
            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@memberid", memberid);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return DataReaderRowToEventMember(reader);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to find the event by member id with the '{memberid}'. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public EventMember FindMemberInEventFromId(int eventId)
        {
            string commandText = "SELECT MemberID FROM EventMember WHERE EventID = @eventid";
            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@eventid", eventId);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return DataReaderRowToEventMember(reader);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to find the member in event with the '{eventId}'. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public bool JoinEvent(EventMember eventMember)
        {
            SqlTransaction transaction;
            int eventCapacity;
            int eventParticipantNumber;
            string step1 = "SELECT Capacity FROM Event WHERE EventID = @eventid";
            string step2 = "SELECT COUNT(MemberID) FROM EventMember WHERE EventID = @eventid";
            string step3 = "INSERT INTO EventMember (EventID, MemberID) VALUES (@eventid, @memberid)";
            using (connection)
            {
                connection.Open();                                        //we need to lock the resources when we use them for the transaction to make sense
                transaction = connection.BeginTransaction(System.Data.IsolationLevel.RepeatableRead);

                SqlCommand commandGetCapacity = new SqlCommand(step1, connection);
                commandGetCapacity.Parameters.AddWithValue("@eventid", eventMember.EventID);

                SqlCommand numberOfParticipants = new SqlCommand(step2, connection);
                numberOfParticipants.Parameters.AddWithValue("@eventid", eventMember.EventID);

                SqlCommand commandCreateAttendance = new SqlCommand(step3, connection);
                commandCreateAttendance.Parameters.AddWithValue("@eventid", eventMember.EventID);
                commandCreateAttendance.Parameters.AddWithValue("@memberid", eventMember.MemberID);

                try
                {
                    eventCapacity = (int)commandGetCapacity.ExecuteReader().GetInt64(0);
                    eventParticipantNumber = (int)numberOfParticipants.ExecuteReader().GetInt64(0);
                    if (!(eventParticipantNumber < eventCapacity))
                    {
                        transaction.Rollback();
                        return false;
                    }
                    commandCreateAttendance.ExecuteScalar();
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    //if the connection with the database breaks at the same time as the rollback happens we need to add a try catch to be able to see what happened.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception)
                    {

                        throw new Exception("Error rolling back signup transaction.");
                    }
                    return false;
                }
            }
        }

        public bool RemoveMemberFromEvent(EventMember eventMember)
        {
            string commandText = "DELETE FROM EventMember WHERE MemberID = @memberid AND EventID = @eventid";
            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@memberid", eventMember.MemberID);
                command.Parameters.AddWithValue("@eventid", eventMember.EventID);

                try
                {
                    return command.ExecuteNonQuery() == 1;

                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to remove participant in event. The exception was: '{ex.Message}'", ex);
                }
            }
        }
        #endregion

        #region Helper Methods
        protected EventMember DataReaderRowToEventMember(SqlDataReader reader)
        {
            EventMember eventMember = new EventMember();
            eventMember.EventID = (int)reader["EventID"];
            eventMember.MemberID = (int)reader["MemberID"];


            return eventMember;
        }
        #endregion
    }
}
