using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;
using WebApi.DataAccessLayer;
using WebApi.ModelLayer;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        #region Properties
        const string baseURI = "api/v1/game";
        private IGameDataAccess DataAccessLayer { get; set; }
        #endregion

        #region Constructor
        public GameController(IGameDataAccess dataAccessLayer)
        {
            DataAccessLayer = dataAccessLayer;
        }
        #endregion

        #region RESTful CRUD methods
        [HttpGet]
        public ActionResult<IEnumerable<Game>> GetAll()
        {
            return Ok(DataAccessLayer.GetAllGames());
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Game> GetGameUsingId(int id)
        {
            Game game = DataAccessLayer.FindGameFromId(id);
            if (game == null)
            {
                return NotFound();  //returns 404
            }
            return Ok(game); //returns 200 + account JSON as body
        }

        [HttpPost]
        public ActionResult<Game> AddGame(Game game)
        {
            DataAccessLayer.CreateGame(game);
            return Created($"{baseURI}/{game.GameID}", game);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteGame(Game game)
        {
            if (!DataAccessLayer.DeleteGame(game))
            {
                return NotFound();  //returns 404
            }
            return Ok();    //returns 200
        }

        [HttpPut]
        public ActionResult UpdateGame(Game game)
        {
            if (!DataAccessLayer.UpdateGame(game))
            {
                return NotFound();
            }
            return Ok();
        }
        #endregion
    }
}