using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaxiCabAppLib.DAL;
using TaxiCabAppLib.Models;
namespace WebApplication1.Controllers
{
    public class RideController : ApiController
    {
        // GET api/ride
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/ride/5
        public string Get(int id)
        {
            return "value";
        }

        [Route("api/Ride/RideRequest")]
        [HttpPost]
        public string RideRequest([FromBody]Ride ride)
        {
            return new RideDAL().RequestRide(ride);
        }
        [Route("api/Ride/RideStart")]
        [HttpPost]
        public string RideStart([FromBody]Ride ride)
        {
            return new RideDAL().StartRide(ride);
        }

        [Route("api/Ride/RideEnd")]
        [HttpPost]
        public string RideEnd([FromBody]Ride ride)
        {
            return new RideDAL().EndRide(ride);
        }

        public void Post([FromBody]string value)
        {
        }

        // PUT api/ride/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/ride/5
        public void Delete(int id)
        {
        }
    }
}
