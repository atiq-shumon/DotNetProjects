using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiCabAppLib.Models
{
    public class Ride
    {
        public string ID { get; set; }
        public string RequestID { get; set; }

        public string Session { get; set; }
        public string RequestTime { get; set; }
        public string RequestedRideTime { get; set; }
        public string RideSource { get; set; }
        public string RideDestination { get; set; }
        
        public Customer Customer { set; get; }
        public Driver Driver { get; set; }
        public DateTime RideDate { get; set; }
        public string RideStartTime { get; set; }
        public string RideEndTime { get; set; }
        public float Distance { get; set; }


    }
}