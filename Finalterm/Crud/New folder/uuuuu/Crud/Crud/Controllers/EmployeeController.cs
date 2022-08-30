using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.BOs;
using BLL.Services;
using System.Web.Http.Cors;


namespace Crud.Controllers
{
    [EnableCors("*", "*", "*")]

    public class EmployeeController : ApiController
    {
        

        [Route("api/employee/")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var data = EmployeeService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/employee/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = EmployeeService.GetOnly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/employee/create")]
        [HttpPost]
        public HttpResponseMessage Create(EmployeeModel st)
        {
            var data = EmployeeService.Create(st);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/employee/update")]
        [HttpPost]
        public HttpResponseMessage Update(EmployeeModel user)
        {
            var data = EmployeeService.Update(user);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/employee/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {


            var data1 = EmployeeService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data1);
        }
    }
}
