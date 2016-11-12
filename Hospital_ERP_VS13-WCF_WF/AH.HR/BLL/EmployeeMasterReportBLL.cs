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
    public class EmployeeMasterReportBLL
    {
        public List<EmployeeMasterRO> RptGetEmpMaster(string EmpMaster, string oLvTpSet, string Param)
        {
            return new EmployeeMasterReportDAL().RptGetEmpMaster(EmpMaster, oLvTpSet, Param);
        }
        public List<EmployeeMasterRO> RptGetAllEmployeeMas(string DeptType, string DeptGrp, string Dept, string Unit)
        {
            return new EmployeeMasterReportDAL().RptGetAllEmployeeMas(DeptType, DeptGrp, Dept, Unit);
        }
        public List<EmployeeMasterRO> RptGetAllEmployee()
        {
            return new EmployeeMasterReportDAL().RptGetAllEmployee();
        }
        public List<EmployeeMasterRO> GetEmployeeInfo(string mode, string param)
        {
            return new EmployeeMasterReportDAL().GetEmployeeInfo(mode, param);
        }
        public List<EmployeeMasterRO> GetEmpJoiningReport(string Mode, string DeptGroup, string Dept,string Unit,string StartDate,string EndDate)
        {
            return new EmployeeMasterReportDAL().GetEmpJoiningReport(Mode, DeptGroup, Dept, Unit, StartDate, EndDate);
        }
        public List<EmployeeMasterRO> GetEmpResigReport(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate)
        {
            return new EmployeeMasterReportDAL().GetEmpResigReport(Mode, DeptGroup, Dept, Unit, StartDate, EndDate);
        }
        public List<EmployeeMasterRO> GetEmpConfDateReport(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate)
        {
            return new EmployeeMasterReportDAL().GetEmpConfDateReport(Mode, DeptGroup, Dept, Unit, StartDate, EndDate);
        }
        public List<EmployeeMasterRO> GetEmpOthersReport(string Mode, string DeptGroup, string Dept, string Unit,string DropType,string StartDate, string EndDate)
        {
            return new EmployeeMasterReportDAL().GetEmpOthersReport(Mode, DeptGroup, Dept, Unit,DropType,StartDate, EndDate);
        }
    }
}
