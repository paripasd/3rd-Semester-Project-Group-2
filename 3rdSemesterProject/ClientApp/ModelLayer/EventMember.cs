using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.ModelLayer
{
    internal class EventMember
    {
        public int EventID { get; set; }
        public int EventMemberID { get; set; }

        public EventMember()
        {

        }

        public EventMember(int eventId,int eventMemberId)
        {
            EventID = eventId;
            EventMemberID = eventMemberId;
        }
    }
}
