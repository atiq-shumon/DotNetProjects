using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaxiCabAppLib.Models;
using TaxiCabAppLib.DAL;

namespace TaxiCabApp.Controllers
{
    public class CustomerController : ApiController
    {
        // GET api/<controller>
        [Route("api/Customer/GetAllCustomers")]
        [HttpGet]
       
        public List<Customer> Get()
        {
            return new CustomerDAL().GetCustomer();
        }

        [HttpGet]
        [Route("api/Customer/GetAllCustomers/{id}")]
       
        public IEnumerable<Customer> Get(string id)
        {
            return new CustomerDAL().GetCustomer(id);
            //return Get().Where(Customer=>Customer.ID==id);
        }

        // POST api/<controller>
        [HttpPost]
        [Route("api/Customer/SaveCustomer")]
        public HttpResponseMessage Post([FromBody]Customer customer)
        {
            string customerID = new CustomerDAL().SaveCustomer(customer);
           
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost]
        [Route("api/Customer/LoginCustomer")]
        public string LoginCustomer([FromBody]Customer customer)
        {
            string session = new CustomerDAL().LoginCustomer(customer.ID, customer.Password);

            return session;
        }

        [HttpPost]
        [Route("api/Customer/LogoutCustomer")]
        public string LogoutCustomer([FromBody]Customer customer)
        {
            string yesNo = new CustomerDAL().LogoutCustomer(customer.Session, customer.ID);

            return yesNo;
        }
        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}