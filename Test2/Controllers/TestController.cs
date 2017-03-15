using Stathis.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Test2.Controllers
{
    [RoutePrefix("api/Test")]
    public class TestController : ApiController
    {
        [Route("")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var customerRepo = new CustomerRepository();
            return Request.CreateResponse(HttpStatusCode.OK, customerRepo.GetCustomers());
        }

        [Route("{id:int}")]
        [HttpGet]
        public HttpResponseMessage GetById(int id)
        {
            var customerRepo = new CustomerRepository();
            var customer = customerRepo.GetById(id);
            if (customer==null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
                return Request.CreateResponse(HttpStatusCode.OK, customer);      
        }

        [Route("")]
        [HttpPost]
        public HttpResponseMessage Postitem()
        {
            return Request.CreateResponse(HttpStatusCode.BadRequest,new { Id=99});
        }
    }
}
