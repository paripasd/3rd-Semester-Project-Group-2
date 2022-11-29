using Microsoft.AspNetCore.Mvc;
using WebApi.DataAccessLayer;
using WebApi.ModelLayer;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("ap1/v1/[controller]")]
    public class EventController : ControllerBase
    {
        #region Properties
        const string baseURI = "api/v1/event";
        private IEventDataAccess DataAccessLayer { get; set; }

        #endregion

        #region Constructor
        public EventController(IEventDataAccess dataAccessLayer)
        {
            DataAccessLayer = dataAccessLayer;
        }
        #endregion

        #region RESTful CRUD methods
        [HttpGet]
        public ActionResult<IEnumerable<Event>> GetAllEvents()
        {
            return Ok(DataAccessLayer.GetAllEvents());
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Event> GetEventUsingId(int id)
        {
            Event e = DataAccessLayer.FindEventFromId(id);
            if (e == null)
            {
                return NotFound();  //returns 404
            }
            return Ok(e); //returns 200 + account JSON as body
        }

        [HttpPost]
        public ActionResult<Event> AddEvent(Event e)
        {
            DataAccessLayer.CreateEvent(e);
            return Created($"{baseURI}/{e.EventID}", e);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteEvent(Event e)
        {
            if (!DataAccessLayer.DeleteEvent(e))
            {
                return NotFound();  //returns 404
            }
            return Ok();    //returns 200
        }

        [HttpPut]
        public ActionResult UpdateEvent(Event e)
        {
            if (!DataAccessLayer.UpdateEvent(e))
            {
                return NotFound();
            }
            return Ok();
        }
        #endregion
    }
}
