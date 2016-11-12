using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.HR.MODEL
{
   public class LeaveDaysSetup:Staff
    {
       public LeaveType LeaveType { set; get; }
       public string year { set; get; }
       public string days { set; get; }
       public string ReqDays { set; get; }
       public string ReqWithin { set; get; }
       public string Reamrks { set; get; }
    }
}
