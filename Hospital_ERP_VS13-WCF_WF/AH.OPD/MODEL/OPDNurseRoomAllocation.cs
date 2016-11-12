using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PRMS.MODEL;
using AH.HR.MODEL;
using AH.Shared.MODEL;

namespace AH.OPD.MODEL
{
    public class OPDNurseRoomAllocation
    {
        public string RoomGroup { get; set; }
        public Room Room { get; set; } 
        public Nurse Nurse { get; set; }       
        public EntryParameter EntryParameter { set; get; }
    }
}
