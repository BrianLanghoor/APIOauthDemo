using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIOauthDemo.Controllers
{
    [Route("[controller]/[action]")]
    public class ValuesController : Controller
    {
        // /Values/GetNotAuthorized
        [HttpGet]
        public ActionResult GetNotAuthorized()
        {
            return Ok("This call can be called without authorisation");
        }

        // /Values/GetAuthorized
        [Authorize]
        [HttpGet]
        public ActionResult GetAuthorized()
        {
            //User.Claims.F
            return Ok("This call can be called only with authorisation");
        }

        // /Values/GetClaims
        [Authorize]
        [HttpGet]
        public ActionResult GetClaims()
        {
            return Ok(User.Claims);
        }
    }
}