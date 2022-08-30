using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.BOs;
using BLL.Services;
//using BLL.Services;
using Crud.Auth;
using System.Web.Http.Cors;


namespace Crud.Controllers
{
    [EnableCors("*", "*", "*")]

    public class EUser1Controller : ApiController
        
    {
        
        [ValidUser]

        [Route("api/eusers1/")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var data = EUser1Service.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/eusers1/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = EUser1Service.GetOnly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/eusers1/create")]
        [HttpPost]
        public HttpResponseMessage Create(EUser1Model st)
        {
            var data = EUser1Service.Create(st);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/eusers1/update")]
        [HttpPost]
        public HttpResponseMessage Update(EUser1Model user)
        {
            var data = EUser1Service.Update(user);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/eusers1/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {


            var data1 = EUser1Service.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data1);
        }
    }   
}
