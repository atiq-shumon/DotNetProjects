using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.DMS.MODEL
{
    public class TestSetupRO
    {
        #region Property
        public string TMainID { get; set; }
        public string TMainTitle { get; set; }
        public string TDetID { get; set; }
        public string GroupID { get; set; }
        public string GroupTitle { get; set; }
        public string Grp_Title_Beng { get; set; }
        public string GroupRemarks { get; set; }
        public string DeptID { get; set; }
        public string DepertmentName { get; set; }
        public string Fee_Cat_ID { get; set; }
        public string Cat_Title { get; set; }
        public string Cat_Title_Beng { get; set; }
        public string CatRemarks { get; set; }
        public double TestFee { get; set; }
        public string DepartmentAmount { get; set; }
        public string Reff_Dept_Amt { get; set; }
        public string DoctorRefAmount { get; set; }
        public double VAT { get; set; }
        public double Discount { get; set; }
        public string TestName { get; set; }
        public string TestDetails { get; set; }
        public string ShortCode { get; set; }
        public string EntryBy { get; set; }
        public string UpdateBy { get; set; }
        public string Update_Date { get; set; }
        public string ReportGroupID { set; get; }
        public string ReportGroupTitle { set; get; }
        public string LabRoom { set; get; }
        public string SpcCollRoom { set; get; }
        public string SpcTitle { set; get; }
        public string SpcConTitle { set; get; }
        public string SpcConQty { set; get; }
        public string TestMethodTitle { set; get; }
        public string PanelId { set; get; }
        public string PanelTitle { set; get; }
        public string TestCatID { set; get; }
        #endregion
    }
}
