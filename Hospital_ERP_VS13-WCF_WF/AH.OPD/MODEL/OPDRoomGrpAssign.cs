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
    public class OPDRoomGrpAssign
    {
        public string RoomGroup { get; set; }
        public string RoomID { get; set; }
        public string RoomNO { get; set; }
        public EntryParameter EntryParameter { set; get; }
    }
}
