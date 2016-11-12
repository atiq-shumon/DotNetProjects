using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PRMS.MODEL;
using AH.HR.MODEL;

namespace AH.APPOPD.MODEL
{
    public class OPDDoctor
    {
        public string RoomGroup { get; set; }
        public Room Room { get; set; }
        public Department Department { get; set; }
        public string Unit { get; set; }
        public Doctor Doctor { get; set; }
        public DepartmentUnit DepartmentUnit { get; set; } 
        public string VisStartTime { get; set; }
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
        
        public string DegreeLine1 { get; set; }
        public string DegreeLine2 { get; set; }
        public string DegreeLine3 { get; set; }
        public string DegreeLine4 { get; set; }

        public EntryParameter EntryParameter { set; get; }

        public string Details { get; set; }
    }
}
