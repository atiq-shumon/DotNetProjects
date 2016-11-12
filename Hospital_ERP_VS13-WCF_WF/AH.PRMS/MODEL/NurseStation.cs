using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.PRMS.MODEL
{
    public class NurseStation
    {
        public string NurseStationID { get; set; }
        public string NurseStationTitle { get; set; }
        public string NurseStationTitleBangla { get; set; }
        public string Remarks { get; set; }
        public int FloorNo { get; set; }
        public string IntercomNo { get; set; }
        public Room Room { get; set; }
        public EntryParameter EntryParameter { set; get; } 
    }
}
