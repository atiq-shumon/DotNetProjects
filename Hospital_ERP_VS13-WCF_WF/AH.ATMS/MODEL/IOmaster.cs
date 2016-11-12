using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ATMS.MODEL
{
    public class IOmaster
    {
        public string IoRefNo { set; get; }
        public string Storeid { set; get; }
       // public string typeid { set; get; }
        public string WhType { set; get; }
        public string Whid { set; get; }
        public string Grpid { set; get; }
        public string Iodate { set; get; }
        public string Moduletype { set; get; }
        public int  IntMtype { set; get; }
        public string Ioflag { set; get; }
        public string Active { set; get; }
        public string Remarks { set; get; }
        public string ItemCode { set; get; }
        public string ItemName { set; get; }
        public string UnitName { set; get; }
        public string  UnitCode { set; get; }
        public string NursingStationId { set; get; }
        public long  Qty { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
