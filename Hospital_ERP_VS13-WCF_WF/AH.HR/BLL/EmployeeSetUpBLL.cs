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
    public class EmployeeSetUpBLL
    {
        public short SaveEmpEdu(EmpEducation EmpEdu)
        {
            return new EmployeeSetupDAL().SaveEmpEdu(EmpEdu);
        }
        public List<EmpEducation> GetEducation()
        {
            return new EmployeeSetupDAL().GetEducation();
        }
        public List<EmpEducation> GetEmpEducation(string emp)
        {
            return new EmployeeSetupDAL().GetEmpEducation(emp);
        }
        public EmployeeMaster GetEmployeeMaster(string ID)
        {
            return new EmployeeSetupDAL().GetEmployeeMaster(ID);
        }

        public EmployeeMaster GetEmpMaster(string ID)
        {
            return new EmployeeSetupDAL().GetEmpMaster(ID);
        }
        public short SaveEmpMasterJobInfo(EmployeeJobInformation mas)
        {
            return new EmployeeSetupDAL().SaveEmpMasterJobInfo(mas);
        }
        public string UpdateEmployeeMaster(EmployeeMaster mas)
        {
            return new EmployeeSetupDAL().UpdateEmployeeMaster(mas);
        }

        public List<ScaleMSetup> GetScaleUnderGrade(string oSalHdG)
        {
            return new PayrollSetupDAL().GetScaleUnderGrade(oSalHdG);
        }
        public List<EmployeeMaster> GetEmployeeID()
        {
            return new EmployeeSetupDAL().GetEmployeeID();
        }

        public Dictionary<string, string> GetEmp(string type)
        {
            Dictionary<string, string> oEmpDic = new Dictionary<string, string>();
            oEmpDic.Add("", "--Select--");
            foreach (EmployeeMaster oEmp in new EmployeeSetupDAL().GetEmployeeID())
            {
                oEmpDic.Add(oEmp.EmpId, oEmp.EmpNameBeng);
            }

            return oEmpDic;
        }

        public short UpdateEmpEdu(EmpEducation EmpEdu)
        {
            return new EmployeeSetupDAL().UpdateEmpEdu(EmpEdu);
        }
        public List<EmployeeMaster> GetEmpID(string dept)
        {
            return new EmployeeSetupDAL().GetEmpID(dept);
        }

        public Dictionary<string, string> GetEmployeeID(string dept)
        {
            Dictionary<string, string> oEmpDic = new Dictionary<string, string>();
            oEmpDic.Add("", "--Select--");
            foreach (EmployeeMaster oEmp in new EmployeeSetupDAL().GetEmpID(dept))
            {
                oEmpDic.Add(oEmp.EmpId, oEmp.EmpNameBeng);
            }

            return oEmpDic;
        }
        public short SaveDeptHeadInfo(EmployeeJobInformation mas)
        {
            return new EmployeeSetupDAL().SaveDeptHeadInfo(mas);
        }
        public List<EmployeeJobInformation> GetDeptHead(string DeptGroup,string Dept,string Unit)
        {
            return new EmployeeSetupDAL().GetDeptHead(DeptGroup,Dept,Unit);
        }
        public List<EmployeeJobInformation> GetDepartmentHead(string DeptGroup)
        {
            return new EmployeeSetupDAL().GetDepartmentHead(DeptGroup);
        }
        public Dictionary<string, string> GetDeptHeadDic(string DeptGroup)
        {
            Dictionary<string, string> oEmpDic = new Dictionary<string, string>();
            foreach (EmployeeJobInformation oEmp in new EmployeeSetupDAL().GetDepartmentHead(DeptGroup))
            {
                oEmpDic.Add(oEmp.EmployeeMaster.EmpId, oEmp.EmployeeMaster.Name);
            }

            return oEmpDic;
        }
    }
}
