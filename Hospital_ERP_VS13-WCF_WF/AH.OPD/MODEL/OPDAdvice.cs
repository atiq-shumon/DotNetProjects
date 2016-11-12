using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.OPD.MODEL
{
    public class OPDAdvice
    {
        public string AdviceID { get; set; }
        public string AdviceDetails { get; set; } 
        public Department Department { get; set; }
        public string Remarks { get; set; }
        public EntryParameter EntryParameter { get; set; }
        
    }
}
