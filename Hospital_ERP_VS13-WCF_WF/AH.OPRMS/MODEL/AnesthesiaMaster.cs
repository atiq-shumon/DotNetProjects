using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AH.Shared.MODEL;

namespace AH.OPRMS.MODEL
{
    public class AnesthesiaMaster
    {
        public string Anesesthesia { set; get; }
        public string GroupID { set; get; }
        public string Anesthesiatitle { set; get; }
        public string AnesthesiatitleBangla { set; get; }
        public string Remarks { set; get; }
        public string Active { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
