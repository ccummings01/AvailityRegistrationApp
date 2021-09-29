using AvailityRegistrationApp.Models;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using static AvailityRegistrationApp.Models.Registration;

namespace AvailityRegistrationApp.Controllers.Data
{
    public class RegistrationController : ApiController
    {
        [HttpPost]
        [Route("api/Registration/joinAvaility")]
        public IHttpActionResult joinAvaility(Registration Registration)
        {
            return Json(RegisterForAvaility(Registration));
        }
    }
}