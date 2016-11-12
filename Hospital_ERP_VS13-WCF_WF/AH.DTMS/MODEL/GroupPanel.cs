using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.DTMS.MODEL
{
    public class GroupPanel
    {
        public string PanelID { set; get; }
        public string PanelTitle { set; get; }
        public string PanelTitleBeng { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParam { set; get; }
    }
}
