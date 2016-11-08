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

        public List<Customer> GetAllCustomers()
        {
            return new CustomerDAL().GetCustomer();
        }

        
        [Route("api/Customer/GetAllCustomers/{id}")]
        [HttpGet]
        public IEnumerable<Customer> GetAllCustomers(string id)
        {
            return new CustomerDAL().GetCustomer(id);
            //return Get().Where(Customer=>Customer.ID==id);
        }

        // POST api/<controller>
        [HttpPost]
        [Route("api/Customer/PostCustomer")]
        public string PostCustomer([FromBody]Customer customer)
        {
            string customerID = new CustomerDAL().SaveCustomer(customer);

            return customerID;
        }

        [HttpPost]
        [Route("api/Customer/Postlogin")]
        public Session LoginCustomer([FromBody]Customer customer)
        {
            try
            {
                Session session = new CustomerDAL().LoginCustomer(customer.CellPhone, customer.LogIn.Password);
                return session;
            }
            catch (Exception ex) {
                return new Session();
            }
           
        }

        [HttpPost]
        [Route("api/Customer/LogoutCustomer")]
        public string LogoutCustomer([FromBody]Customer customer)
        {
            string yesNo = "";
                //new CustomerDAL().LogoutCustomer(customer.Session, customer.ID);

            return yesNo;
        }

        [HttpPost]
        [Route("api/Customer/PostCC")]
        public string SaveCustomerCC(CC cc)
        {
            return new CustomerDAL().SaveCustomerCC(cc).ToString();
        }

        [Route("api/Customer/GetCustomerCC/{id}")]
        [HttpGet]
        public List<CC> GetCustomerCC(string id)
        {
            return new CustomerDAL().GetCustomerCC(id);
            //return Get().Where(Customer=>Customer.ID==id);
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