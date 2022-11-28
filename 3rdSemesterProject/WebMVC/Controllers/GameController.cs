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

	public class GameController : Controller
    {

        ApiGameDataAccess _dataAccess = new("https://localhost:7023/api/v1/game");

        // GET: Game
        public ActionResult Index()
        {
			return View(_dataAccess.GetAllGames());
        }

        // GET: Game/Details/5
        public ActionResult Details(int id)
        {
            return View(_dataAccess.GetGameUsingId(id));
        }

        // GET: Game/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Game/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Game/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Game/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Game/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Game/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


		[HttpGet]
        public FileResult DownloadGame(int gameId)
		{
            Game gameToDownload = _dataAccess.GetGameFileById(gameId);
            return File(gameToDownload.FileContent, System.Net.Mime.MediaTypeNames.Application.Octet, gameToDownload.FileName);
		}
    }
}