using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ATMS.MODEL
{
   public  class AdditionalInformation
    {
       public string tagNo { get; set; }
       public string color { get; set; }
       public string condition { get; set; }
       public string ProductCode { get; set; }
       public string manufacturername { get; set; }
       public string serviceprovidername { get; set; }
       public string contactperson { get; set; }
       public string mobileno { get; set; }
       public string componentname { get; set; }
       public string description { get; set; }
       public string notes { get; set; }
       public EntryParameter EntryParameter { set; get; }
    }

}
