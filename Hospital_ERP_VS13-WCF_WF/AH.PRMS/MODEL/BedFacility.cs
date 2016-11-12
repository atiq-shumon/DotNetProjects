using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.PRMS.MODEL
{
    public class BedFacility
    {
        public string ID { set; get; }
        public string Title { set; get; }
        public string TitleBeng { set; get; }
        public short TV { set; get; }
        public short Fridge { set; get; }
        public short Sofa { set; get; }
        public short Internet { set; get; }
        public short Newspaper { set; get; }
        public short Corridor { set; get; }
        public short Veranda { set; get; }
        public short Almirah { set; get; }
        public short XtraBed { set; get; }
        public short MaxAllowedPerson { set; get; }
        public short AC { set; get; }
        public short WashRoom { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
