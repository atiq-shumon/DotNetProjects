using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.OPD.MODEL
{
    public class Complaints
    {
        public string ID { set; get; }
        public string ComplaintTitle { set; get; }
        public string ComplaintTitleBeng { set; get; }
        public string Remarks { set; get; }
        public Department Department { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
