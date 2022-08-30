using BLL.BOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Crud.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AuthController : ApiController
    {
        
        [Route("api/login")]
        [HttpPost]
        //[Authorize]
        public HttpResponseMessage Login(EmployeeModel obj)
        {
            var data = AuthService.Authenticate(obj.eUserName, obj.ePassword);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }
        [Route("api/logout")]
        [HttpPost]
        public HttpResponseMessage Logout(TokenModel obj)
        {
            var data = AuthService.Logout(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
