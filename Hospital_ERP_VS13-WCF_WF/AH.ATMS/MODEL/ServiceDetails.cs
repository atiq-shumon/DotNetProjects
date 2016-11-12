using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
namespace AH.ATMS.MODEL
{
    public class ServiceDetails
    {
        public string SerialNo = "";
        public string ServiceID = "";
        public string ServiceDate = "";
        public string ReturnDate = "";
        public string ExpireRetDate = "";
        public string Remarks = "";
        public string Priority = "";
        public EntryParameter EntryParameter { set; get; }
     
    }
}
