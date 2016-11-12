using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
namespace AH.DTMS.MODEL
{
    public class Machine
    {
        public string MachineID { set; get; }
        public string MachineTitle { set; get; }
        public string MachineTitleBeng { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
