using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.BOs;
using BLL.Services;

namespace Crud.Controllers
{
    
    public class EDonationController : ApiController
    {

        [Route("api/edonation/")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var data = EDonationService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/edonation/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = EDonationService.GetOnly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/edonation/create")]
        [HttpPost]
        public HttpResponseMessage Create(EDonationModel st)
        {
            var data = EDonationService.Create(st);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/edonation/update")]
        [HttpPost]
        public HttpResponseMessage Update(EDonationModel user)
        {
            var data = EDonationService.Update(user);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/edonation/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {


            var data1 = EDonationService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data1);
        }
    }
}
