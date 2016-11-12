using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.INVMS.MODEL
{
    public class DRReportRO
    {
        public string DRID { set; get; }
        public string DepartmentID { set; get; }
        public string DEPARTMENTNAME { set; get; }
        public string DEPTUNITID { set; get; }
        public string DEPTUNITNAME { set; get; }
        public string ItemID { set; get; }
        public string ItemName { set; get; }
        public string UnitID { set; get; }
        public string UnitName { set; get; }
        public string CompanyID { set; get; }
        public string CompanyName { set; get; }
        public string GroupID { set; get; }
        public string GroupName { set; get; }
        public string BrandID { set; get; }
        public string BrandName { set; get; }
        public string ModelID { set; get; }
        public string ModelName { set; get; }
        public DateTime RequisitionDate { set; get; }
        public float DemandQty { set; get; }
        public float STOCK { set; get; }
        public string RaisedReqByName { set; get; }
        public string VerifiedReqByName { set; get; }
        public string RaisedDesigName { set; get; }
        public string VerifiedDesigName { set; get; }
        public string Remarks { set; get; }
    }
}
