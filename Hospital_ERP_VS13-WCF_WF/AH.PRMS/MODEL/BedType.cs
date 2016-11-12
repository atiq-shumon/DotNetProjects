using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.PRMS.MODEL
{
    public class BedType
    {
        public string ID { set; get; }
        public string Title { set; get; }
        public string TitleBeng { set; get; }
        public string Remarks { set; get; }
        public short SerialPriority { set; get; }
        public BedFacility BedFacility { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
