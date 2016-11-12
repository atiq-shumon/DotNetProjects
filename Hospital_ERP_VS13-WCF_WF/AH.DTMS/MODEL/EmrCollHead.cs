using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.HR.MODEL;

namespace AH.DTMS.MODEL
{
    public class EmrCollHead
    {
        public DepartmentGroup DepartmentGroup { set; get; }
        public Department Department { set; get; }
        public DepartmentUnit DepartmentUnit { set; get; }
        public string HeadGroupID { set; get; }
        public string HeadID { set; get; }
        public string HeadTitle { set; get; }
        public string HeadTitleBeng { set; get; }
        public double Fee { set; get; }
        public double NetPaid { set; get; }
        public double Qty { set; get; }
        public string SetAsDefault { set; get; }
        public string IsSelectable { set; get; }
        public string PosSerial { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
