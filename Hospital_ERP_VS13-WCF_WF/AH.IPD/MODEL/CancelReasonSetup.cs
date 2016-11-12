using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AH.IPD.MODEL
{
    public class CancelReasonSetup
    {
        public string ID { set; get; }
        public string Title { set; get; }
        public string TitleBeng { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
