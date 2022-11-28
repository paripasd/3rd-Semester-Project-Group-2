﻿using Microsoft.AspNetCore.Mvc;
using WebApi.DataAccessLayer;
using WebApi.ModelLayer;

namespace WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class GameFileController : ControllerBase
    {
        const string baseURI = "api/v1/gameFile";
        private IGameFileDataAccess DataAccessLayer { get; set; }

        public GameFileController(IGameFileDataAccess dataAccessLayer)
        {
            DataAccessLayer = dataAccessLayer;
        }

        #region Download Game
        [HttpGet]
        public ActionResult FileDownload(int gameId)
        {
            byte[] filebytes = DataAccessLayer.GetGameFileById(gameId).FileContent; // file in the form of  bytes array.
            return File(filebytes,System.Net.Mime.MediaTypeNames.Application.Octet, DataAccessLayer.GetGameFileById(gameId).FileName);
        }

        #endregion

        [HttpGet("{id}")]
        public ActionResult<GameFile> GetGameFileById(int gameId)
        {
            GameFile gameFile = DataAccessLayer.GetGameFileById(gameId);
            if (gameFile == null)
            {
                return NotFound();  //returns 404
            }
            return Ok(gameFile); //returns 200 + account JSON as body
        }
        
        /*[HttpPost]
        public ActionResult<GameFile> Post(GameFile gameFile)
        {
            DataAccessLayer.AddGame(gameFile);
            return Created($"{baseURI}/{gameFile.FileName}", gameFile);
        }*/

        [HttpPut("{id}")]
        public ActionResult<GameFile> UpdateGameFile(GameFile gameFile)
        {
            if (!DataAccessLayer.UpdateGameFile(gameFile))
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
