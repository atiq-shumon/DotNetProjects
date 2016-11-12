using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PRMS.MODEL;
using AH.HR.MODEL;
using AH.HR.DAL;
using AH.Shared.MODEL;

namespace AH.HR.BLL
{
    public class ReportSetupBLL
    {       
        public List<RptDepartment> GetRptDepartment()
        {
           return new ReportSetupDAL().GetRptDepartment();          
        }
        public List<RptLeaveDays> RptGetLeave(string oLvTpSet)
        {
            return new ReportSetupDAL().RptGetLeave(oLvTpSet);
        }
       public List<RptDepartment> GetDepartmentTree()
        {
            return new ReportSetupDAL().GetDepartmentTree();
        }
    }
}
