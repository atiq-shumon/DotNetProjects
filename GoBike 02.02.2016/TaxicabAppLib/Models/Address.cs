using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiCabAppLib.Models
{
    public class Address
    {
         public Int32 AddressID{set;get;}       
         public string Address1{set;get;}
         public string Address2{set;get;}
        public string Road{set;get;}
         public string Thana{set;get;}
        public string City{set;get;}
        public string District{set;get;}
        public string Division{set;get;}
        public AddressType AddressType{set;get;}
        public EntryParameter EntryParameter{set;get;}
    }
}
