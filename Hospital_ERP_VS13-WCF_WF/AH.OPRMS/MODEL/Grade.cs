using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.OPRMS.MODEL
{
    public class Grade
    {
        public string GradeId { set; get; }
        public string GradeTitle { set; get; }
        public string TitleBangla { set; get; }
        public string Active { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
        
    }
}
