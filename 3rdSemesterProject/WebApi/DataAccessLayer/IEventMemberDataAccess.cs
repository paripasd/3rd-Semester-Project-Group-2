using WebApi.ModelLayer;

namespace WebApi.DataAccessLayer
{
    public interface IEventMemberDataAccess
    {
        public bool JoinEvent(EventMember eventMember);
        public EventMember FindMemberInEventFromId(int eventId);
        public EventMember FindEventByMemberId(int eventId);
        public bool RemoveMemberFromEvent(EventMember eventMember);
    }
}
