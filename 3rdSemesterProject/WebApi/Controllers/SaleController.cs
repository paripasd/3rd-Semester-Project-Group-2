using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;
using WebApi.DataAccessLayer;
using WebApi.ModelLayer;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaleController : ControllerBase
    {
        #region Properties
        const string baseURI = "api/v1/sale";
        private ISaleDataAccess DataAccessLayer { get; set; }
        #endregion

        #region Constructor
        public SaleController(ISaleDataAccess dataAccessLayer)
        {
            DataAccessLayer = dataAccessLayer;
        }
        #endregion

        #region RESTful CRUD methods
        [HttpGet]
        public ActionResult<IEnumerable<Sale>> GetAll()
        {
            return Ok(DataAccessLayer.GetAllSales());
        }

        [HttpGet]
        [Route("{gamekey}")]
        public ActionResult<Game> GetSaleUsingGameKey(string gamekey)
        {
            Sale sale = DataAccessLayer.FindSaleFromGameKey(gamekey);
            if (sale == null)
            {
                return NotFound();  //returns 404
            }
            return Ok(sale); //returns 200 + account JSON as body
        }

        [HttpPost]
        public ActionResult<Game> AddSale(Sale sale)
        {
            DataAccessLayer.CreateSale(sale);
            return Created($"{baseURI}/{sale.GameID}", sale);
        }

        [HttpDelete]
        [Route("{gamekey}")]
        public ActionResult DeleteSale(Sale sale)
        {
            if (!DataAccessLayer.DeleteSale(sale))
            {
                return NotFound();  //returns 404
            }
            return Ok();    //returns 200
        }
        #endregion
    }
}