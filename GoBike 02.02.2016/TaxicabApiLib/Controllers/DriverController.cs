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
    public class DriverController : ApiController
    {
        // GET api/<controller>
        [Route("api/Driver/GetAllDrivers")]
        [HttpGet]

        public List<Driver> Get()
        {
            return new DriverDAL().GetDriver();
        }

        [HttpGet]
        [Route("api/Driver/GetAllDrivers/{id}")]

        public IEnumerable<Customer> Get(string id)
        {
            return new CustomerDAL().GetCustomer(id);
            //return Get().Where(Customer=>Customer.ID==id);
        }

        // POST api/<controller>
        [HttpPost]
        [Route("api/Driver/SaveDriver")]
        public HttpResponseMessage Post([FromBody]Driver driver)
        {
            string driverID = new DriverDAL().SaveDriver(driver);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost]
        [Route("api/Driver/LoginDriver")]
        public string LoginDriver([FromBody]Driver driver)
        {
            string session = new DriverDAL().LoginDriver(driver.ID, driver.Password);

            return session;
        }

        [HttpPost]
        [Route("api/Driver/LogoutDriver")]
        public string LogoutCustomer([FromBody]Driver driver)
        {
            string yesNo = new DriverDAL().LogoutDriver(driver.Session, driver.ID);

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