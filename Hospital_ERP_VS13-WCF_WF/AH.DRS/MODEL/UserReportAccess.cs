using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.DTMS.MODEL;

namespace AH.DRS.MODEL
{
   public class UserReportAccess
    {
       public string UserID { get; set; }
       public string UserName { get; set; }
       public ReportGroup ReportGroup { set; get; }
       public EntryParameter EntryParameter { set; get; }

    }
}
