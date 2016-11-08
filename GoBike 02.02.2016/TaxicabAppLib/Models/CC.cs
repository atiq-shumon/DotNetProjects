using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiCabAppLib.Models
{
    public class CC
    {
        public Int32 ID {set;get;}
        public Customer Customer{set;get;}
        public string CCName{set;get;}
        public string Expire{set;get;}
        public string CCCode{set;get;}
        public CCType CCType { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
