using Microsoft.AspNetCore.Mvc;
using WebApi.DataAccessLayer;
using WebApi.ModelLayer;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class LoginController : ControllerBase
    {
        #region Properties
        const string baseURI = "api/v1/login";
        private ILoginDataAccess DataAccessLayer { get; set; }

        #endregion

        #region Constructor
        public LoginController(ILoginDataAccess dataAccessLayer)
        {
            DataAccessLayer = dataAccessLayer;
        }
        #endregion

        #region RESTful CRUD methods
        [HttpGet]
        public ActionResult<IEnumerable<Login>> GetAllLoginInformation()
        {
            return Ok(DataAccessLayer.GetAllLoginInformation());
        }

        [HttpPost]
        public ActionResult<Login> AddLogin(Login login)
        {
            DataAccessLayer.CreateLogin(login);
            return Created($"{baseURI}/{login.UserName}", login);
        }

        [HttpDelete]
        public ActionResult DeleteLogin(Login login)
        {
            if (!DataAccessLayer.DeleteLogin(login))
            {
                return NotFound();  //returns 404
            }
            return Ok();    //returns 200
        }

        /*[HttpPut]
        public ActionResult UpdateLogin(Login login)
        {
            login.Password = Login.HashPassword(login.Password);
            if (!DataAccessLayer.UpdateLogin(login))
            {
                return NotFound();
            }
            return Ok();
        }*/
        #endregion
    }
}
