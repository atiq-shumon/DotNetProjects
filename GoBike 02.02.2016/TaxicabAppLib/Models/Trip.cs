using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaxiCabAppLib.Models
{
    public class Trip
    {
        public Int32 TripRequestID { set; get; }
       public Int32 TripID{set;get;}
       public Customer Customer{set;get;}
       public Biker Biker{set;get;}
       public string Location{set;get;}
       public string Destination{set;get;}
       public string LocationCoOrdinate{set;get;}
       public DateTime RequestedTime{set;get;}
       public DateTime StartTime { set; get; }
       public DateTime EndTime { set; get; }
       public char IsReserved{set;get;}
       public Bill Bill { set; get; }
       public EntryParameter EntryParameter{set;get;} 
    
    }
}
