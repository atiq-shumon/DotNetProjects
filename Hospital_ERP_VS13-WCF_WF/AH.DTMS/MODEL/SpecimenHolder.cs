using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.DTMS.MODEL
{
    public class SpecimenHolder
    {
        public string HolderID { set; get; }
        public string HolderTitle { set; get; }
        public string HolderTitleBeng { set; get; }
        public string HolderQuantity { set; get; }
        public string Remarks { set; get; }
        public string Priority { set; get; }
        public ColorCode ColorCode { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
