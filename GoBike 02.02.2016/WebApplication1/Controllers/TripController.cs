using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaxiCabAppLib.Models;
using TaxiCabAppLib.DAL;


namespace WebApplication1.Controllers
{
    public class TripController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        [Route("api/trip/GetAllTripRequests")]
        [HttpGet]
        public List<Trip> GetAllTripRequests()
        {
            return new TripDAL().GetTripRequest();
        }

        [Route("api/trip/GetBookedRequests/{id}")]
        [HttpGet]
        public List<Trip> GetBookedRequests(string id)
        {
            return new TripDAL().GetBookedRequest(id);
        }
        
        [Route("api/trip/GetRunningTrip/{id}")]
        [HttpGet]
        public List<Trip> GetBikersRunningTrip(string logInID)
        {
            return new TripDAL().GetBikersRunningTrip(logInID);
        }

        

        // POST api/<controller>
        [HttpPost]
        [Route("api/trip/PostTripRequest")]
        public string PostTrip([FromBody]Trip trip)
        {
            string tripRequestID = new TripDAL().SaveTripRequest(trip);

            return tripRequestID;
        }

         // POST api/<controller>
        [HttpPost]
        [Route("api/trip/PostBookRequest")]
        public string BookTripRequest([FromBody]Trip trip)
        {
            return new TripDAL().BookTripRequest(trip);
        }


        [HttpPost]
        [Route("api/trip/PostStartTrip")]
        public string StartTrip([FromBody]Trip trip)
        {
            return new TripDAL().StartTrip(trip);
        }

        [HttpPost]
        [Route("api/trip/PostEndTrip")]
        public string EndTrip([FromBody]Trip trip)
        {
            return new TripDAL().EndTrip(trip);
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