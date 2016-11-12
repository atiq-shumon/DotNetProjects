using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.PRMS.MODEL;

namespace AH.HR.MODEL
{
    public class Doctor : Staff
    {
       
        public string Doctype { set; get; }
        public string Degree1 { set; get; }
        public string Degree2 { set; get; }
        public string Degree3 { set; get; }
        public string Degree4 { set; get; }
        public string Signature { set; get; }
        public Room Room { set; get; }
        public string AvailableDays { set; get; }
        public string AvailableDaysBeng { set; get; }
        


    }
}
