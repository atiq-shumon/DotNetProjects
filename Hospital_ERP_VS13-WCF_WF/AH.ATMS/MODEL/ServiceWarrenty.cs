using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ATMS.MODEL
{
    public class ServiceWarrenty
    {
        public string TagNo { set; get; }
        public string productCode { set; get; }
        public string productName { set; get; }
        public string voucherDate { set; get; }
        public string  ServiceStartDate { set; get; }
        public string ServiceEndDate { set; get; }
        public string WarrentyDate { set; get; }
        public string RecivedDate { set; get; }
        public string Notes { set; get; }
        public int WarrentyStatus { set; get; }
        public EntryParameter EntryParameter { set; get; }



    }
}
