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
        ApiEventDataAccess _dataAccess = new("https://localhost:7023/api/v1/Event");

		// GET: Event
		[HttpGet]
        public ActionResult Index()
        {
            return View(_dataAccess.GetUpcomingEvent());
        }

        // GET: Event/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}