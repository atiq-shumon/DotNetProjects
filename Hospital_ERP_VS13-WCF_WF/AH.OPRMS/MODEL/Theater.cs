using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.OPRMS.MODEL
{
    public class Theater
    {
        public string Buildid { get; set; }
        public string FloorNo { get; set; }
        public string BlockNo { get; set; }
        public string RoomId { get; set; }
        public string Theaterid { get; set; }
        public string Theatertitle { get; set; }
        public string TheatertitleBangla { get; set; }
        public long NoofFacilities { get; set; }
        public string PhoneNo { get; set; }
        public string Inchargeid { get; set; }
        public string Remarks { get; set; }
        public string Active { get; set; }
        public string DepSpe { get; set; }
        public string DepId { get; set; }
        public string DepName { get; set; }
        public EntryParameter EntryParameter { set; get; }

    }
}
