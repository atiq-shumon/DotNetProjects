using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.PRMS.MODEL
{
    public class Building
    {
        public Company Company { set; get; }
        public Location Location { set; get; }
        public string BuildingID { set; get; }
        public string BuildingTitle { set; get; }
        public string BuildingTitleBeng { set; get; }
        public short SerialNo { set; get; }
        public short Floors { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
