using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ATMS.MODEL
{
    public class AssetsIssue
    {
        public string IssueNo { set; get; }
        public string Issudate { set; get; }
        public string Receiptdate { set; get; }
        public string Groupcode { set; get; }
        public string brandCode { set; get; }
        public string brandName { set; get; }
        public string ProductID { set; get; }
        public string ProductName { set; get; }
        public double dblQty { set; get; }
        public double dblIssue { set; get; }
        public string UnitID { set; get; }
        public string UnitName { set; get; }
        public string ModelId { set; get; }
        public string ModelName { set; get; }
        public string FormName { set; get; }
        public string Notes { set; get; }
        public string TagNo { set; get; }
        public string DepID { set; get; }
        public string DepName { set; get; }
        public string AssetsUser { set; get; }
        public int intVtype { set; get; }
        public string WarrentyDate { set; get; }
        public string EmpID { set; get; }
        public string SerialNo { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
