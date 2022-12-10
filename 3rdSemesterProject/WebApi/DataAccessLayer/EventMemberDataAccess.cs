using Microsoft.Extensions.Logging;
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
            connection.Open();
        }
        #region CRUD Methods
        public IEnumerable<int> GetEventIdListByMemberId(int memberid)
        {
            string commandText = "SELECT EventID FROM EventMember WHERE MemberID = @memberid";
            using (connection)
            {

                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@memberid", memberid);

                try
                {
                    List<int> eventIdList = new List<int>();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        eventIdList.Add((int)reader["EventID"]);
                    }
                    return eventIdList;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to find the event list by member id with the '{memberid}'. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public IEnumerable<int> GetMemberIdListByEventId(int eventId)
        {
            string commandText = "SELECT MemberID FROM EventMember WHERE EventID = @eventid";
            using (connection)
            {

                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@eventid", eventId);

                try
                {
                    List<int> memberIdList = new List<int>();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        memberIdList.Add((int)reader["MemberID"]);
                    }
                    return memberIdList;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception while trying to find the member list in event with the '{eventId}'. The exception was: '{ex.Message}'", ex);
                }
            }
        }

        public bool JoinEvent(EventMember eventMember)
        {
            SqlTransaction transaction;
            int eventCapacity;
            int eventParticipantNumber;

            string getCapacity = "SELECT Capacity FROM Event WHERE EventID = @eventid";
            string getCurrentParticipantNumber = "SELECT Count(*) FROM EventMember WHERE EventID = @eventid";
            string makeJoinEvent = "INSERT INTO EventMember (EventID, MemberID) VALUES (@eventid, @memberid)";
            using (transaction = connection.BeginTransaction(System.Data.IsolationLevel.RepeatableRead))
            {
                SqlCommand commandGetCapacity = new SqlCommand(getCapacity, connection, transaction);
                commandGetCapacity.Parameters.AddWithValue("@eventid", eventMember.EventID);

                SqlCommand numberOfParticipants = new SqlCommand(getCurrentParticipantNumber, connection, transaction);
                numberOfParticipants.Parameters.AddWithValue("@eventid", eventMember.EventID);

                SqlCommand commandCreateAttendance = new SqlCommand(makeJoinEvent, connection, transaction);
                commandCreateAttendance.Parameters.AddWithValue("@eventid", eventMember.EventID);
                commandCreateAttendance.Parameters.AddWithValue("@memberid", eventMember.MemberID);


                try
                {
                    try
                    {
                        SqlDataReader readerCapacity = commandGetCapacity.ExecuteReader();
                        readerCapacity.Read();
                        eventCapacity = (int)readerCapacity["Capacity"];
                        readerCapacity.Close();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                    try
                    {
                        SqlDataReader readerParticipant = numberOfParticipants.ExecuteReader();
                        readerParticipant.Read();
                        eventParticipantNumber = (int)readerParticipant.GetInt32(0);
                        readerParticipant.Close();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                   
                    if (eventParticipantNumber >= eventCapacity)
                    {
                        transaction.Rollback();
                        return false;
                    }
                    commandCreateAttendance.ExecuteScalar();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    //if the connection with the database breaks at the same time as the rollback happens we need to add a try catch to be able to see what happened.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception e)
                    {

                        throw new Exception(e.Message);
                    }
                    throw new Exception("Error in the transaction." + ex);
                    return false;
                }
            }
        }

        public bool RemoveMemberFromEvent(EventMember eventMember)
        {
            string commandText = "DELETE FROM EventMember WHERE MemberID = @memberid AND EventID = @eventid";
            using (connection)
            {

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
