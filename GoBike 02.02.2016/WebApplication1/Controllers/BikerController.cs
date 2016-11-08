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
        [Route("api/Biker/GetAllBikers")]
        [HttpGet]

        public List<Biker> Get()
        {
            return new BikerDAL().GetBiker();
        }

        [HttpGet]
        [Route("api/Biker/GetAllBikers/{id}")]

        public IEnumerable<Biker> Get(string id)
        {
            return new BikerDAL().GetBiker(id);
            //return Get().Where(Customer=>Customer.ID==id);
        }

        // POST api/<controller>
        [HttpPost]
        [Route("api/Biker/PostBiker")]
        public string Post([FromBody]Biker biker)
        {
           return new BikerDAL().SaveBiker(biker);
        }

        [HttpPost]
        [Route("api/Biker/PostLoginBiker")]
        public Session LoginDriver([FromBody]Biker biker)
        {
            Session session = new BikerDAL().LoginBiker(biker.CellPhone, biker.LogIn.Password);

            return session;
        }

        //[HttpPost]
        //[Route("api/Driver/LogoutDriver")]
        //public string LogoutCustomer([FromBody]Driver driver)
        //{
        //    string yesNo = new DriverDAL().LogoutDriver(driver.Session, driver.ID);

        //    return yesNo;
        //}
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