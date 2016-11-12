using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
namespace AH.OPRMS.MODEL
{
   public class Operation
    {
        public string ID { set; get; }
        public string Title { set; get; }
        public string TitleBeng { set; get; }
        public string Remarks { set; get; }
        //public int  Status { set; get; }
        public string  Status { set; get; }
        public bool  blngStatus { set; get; }

        public EntryParameter EntryParameter { set; get; }
    }
}
