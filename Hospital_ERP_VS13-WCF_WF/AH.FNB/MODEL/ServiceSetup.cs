using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.FNB.MODEL
{
   public class ServiceSetup
    {
       public string ServiceID { set; get; }
       public string ServiceName { set; get; }
       public string Remarks { set; get; }
       public EntryParameter EntryParameter { set; get; }

    }
}
