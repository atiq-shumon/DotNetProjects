using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiCabAppLib.Models
{
    public class AddressType
    {
       public Int32 TypeID{set;get;}  
       public string TypeName{set;get;} 
       public string AddressTypeDescription{set;get;}

       public EntryParameter EntryPamameter { set; get; }
    }
}
