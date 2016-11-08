using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiCabAppLib.Models
{
    public class LogIn
    {
       public Int32 LogInID{set;get;}
       public string LogInType{set;get;}
       public string UserName{set;get;} 
       public string Password{set;get;}
       public EntryParameter EntryParameter{set;get;}

    }
}
