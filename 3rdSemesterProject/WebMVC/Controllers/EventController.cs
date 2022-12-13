using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebMVC.RestClientLayer;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class EventController : Controller
    {
        ApiEventDataAccess _dataAccessEvent = new("https://localhost:7023/api/v1/Event");
		ApiMemberDataAccess _dataAccessMember = new("https://localhost:7023/api/v1/Member");
		ApiEventMemberDataAccess _dataAccessEventMember = new("https://localhost:7023/api/v1/EventMember");

		// GET: Event
		[HttpGet]
        public ActionResult Index()
        {
            return View(_dataAccessEvent.GetUpcomingEvent());
        }

        // GET: Event/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

		[HttpGet]
        public string GetMemberAmount(int eventId)
		{
            return _dataAccessEventMember.GetMemberAmount(eventId);
		}

        [HttpPost]
        public bool JoinEvent([FromBody] EventJoinData data)
		{
            Member member;
            try
            {
                member = _dataAccessMember.GetAllMembers().First(m => m.Email == data.MemberEmail);
            }
            catch(Exception ex) //we don't have a member with the given email address
			{
                _dataAccessMember.CreateMember(data.MemberEmail); //create Member
				member = _dataAccessMember.GetAllMembers().First(m => m.Email == data.MemberEmail); //get Member again, now that it exists
			}
            EventMember eventMember = new(data.EventId, member.MemberId);
            return _dataAccessEventMember.JoinEvent(eventMember);
		}

        public class EventJoinData
		{
			public int EventId { get; private set; }
			public string MemberEmail { get; private set; }
            public EventJoinData(int eventId, string memberEmail)
			{
                EventId = eventId;
                MemberEmail = memberEmail;
			}
		}
    }
}