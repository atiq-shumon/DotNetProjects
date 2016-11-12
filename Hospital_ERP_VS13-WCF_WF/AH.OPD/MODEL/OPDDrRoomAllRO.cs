using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.OPD.MODEL
{
    public class OPDDrRoomAllRO
    {
        public string ROOM_ID { get; set; }
        public string RoomNo { get; set; }
        public string ROOM_GRP { get; set; }
        public string VisStartTime { set; get; }
        public string VisEndTime { get; set; }
        public string VisFirst { get; set; }
        public string DrVisFirst { get; set; }
        public string VisSecond { get; set; }
        public string DrVisSecond { get; set; }
        public string VisThird { get; set; }
        public string DrVisThird { get; set; }
        public string VisFourth { get; set; }
        public string DrVisFourth { get; set; }
        public string RptVisit { get; set; }
        public string DrRptVisit { get; set; }
        public string VisitCycle { get; set; }
        public string MaxPatBar { get; set; }
        public string AvgPatMin { get; set; }
        public string DOC_ID { get; set; }
        public string DoctorName { get; set; }
        public string EntryBy { get; set; }
        public string ENTRY_DATE { get; set; }
        public string Department { get; set; }
        public string Unit { get; set; }
    }
}
