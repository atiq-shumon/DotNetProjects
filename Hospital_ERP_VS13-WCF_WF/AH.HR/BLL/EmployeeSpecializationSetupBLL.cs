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
    public class EmployeeSpecializationSetupBLL
    {
        public short SaveDocSetup(Doctor tdoc)
        {
            return new EmployeeSpecializationSetupDAL().SaveDocSetup(tdoc);
        }
        public short UpdateDocSetup(Doctor udoc)
        {
            return new EmployeeSpecializationSetupDAL().UpdateDocSetup(udoc);
        }
        public List<Doctor> GetDoctors()
        {
            return new EmployeeSpecializationSetupDAL().GetDoctors();
        }
        //public Dictionary<string, string> GetDoctorTypes()
        //{
        //    return DUtility.Utility.GetDoctorTypes();
        //}
        public Dictionary<string, string> GetDoctors(string type)
        {
            Dictionary<string, string> tdoc = new Dictionary<string, string>();
            tdoc.Add("", "--Select--");
            foreach (Doctor dc in new EmployeeSpecializationSetupDAL().GetDoctors())
            {
                tdoc.Add(dc.ID, dc.Name);
            }
            return tdoc;
        }


        public List<Doctor> GetDoctorSetup(string deptid, string unitid)
        {
            return new EmployeeSpecializationSetupDAL().GetDoctorSetup(deptid, unitid);
        }
        public Dictionary<string, string> GetDoctorSetup(string type, string deptid, string unitid)
        {
            Dictionary<string, string> tdoc = new Dictionary<string, string>();
            tdoc.Add("", "--Select--");
            foreach (Doctor dc in new EmployeeSpecializationSetupDAL().GetDoctorSetup(deptid, unitid))
            {
                tdoc.Add(dc.ID, dc.Name);
            }
            return tdoc;

        }
        public List<Doctor> GetDoctorByDept(string deptid)
        {
            return new EmployeeSpecializationSetupDAL().GetDoctorByDept(deptid);
        }
        public Dictionary<string, string> GetDoctorByDept(string type, string deptid)
        {
            Dictionary<string, string> tdoc = new Dictionary<string, string>();
            tdoc.Add("", "--Select--");
            foreach (Doctor dc in new EmployeeSpecializationSetupDAL().GetDoctorByDept(deptid))
            {
                tdoc.Add(dc.ID, dc.Name);
            }
            return tdoc;

        }

        public short SaveNurse(Nurse nrs)
        {
            return new EmployeeSpecializationSetupDAL().SaveNurse(nrs);
        }
        public short ModifyNurse(Nurse nrs)
        {
            return new EmployeeSpecializationSetupDAL().ModifyNurse(nrs);
        }
        public List<Nurse> GetNurse()
        {
            return new EmployeeSpecializationSetupDAL().GetNurse();
        }
        public Dictionary<string, string> GetNurse(string type)
        {
            Dictionary<string, string> nurs = new Dictionary<string, string>();
            nurs.Add("", "--Select--");

            foreach (Nurse nrs in new EmployeeSpecializationSetupDAL().GetNurse())
            {
                nurs.Add(nrs.ID, nrs.Name);
            }
            return nurs;
        }


        public List<EmployeeMasterRO> GetEmployee(string Dept, string Unit)
        {
            return new EmployeeSpecializationSetupDAL().GetEmployee(Dept, Unit);
        }

        public Dictionary<string, string> GetEmpDic(string Dept, string Unit)
        {
            Dictionary<string, string> emp = new Dictionary<string, string>();
            emp.Add("", "--Select--");
            foreach (EmployeeMasterRO em in new EmployeeSpecializationSetupDAL().GetEmployee(Dept, Unit))
            {
                emp.Add(em.EmpId, em.EmpName);
            }
            return emp;
        }
        public List<EmployeeMasterRO> GetEmployees(string Desig, string Dept, string Unit)
        {
            return new EmployeeSpecializationSetupDAL().GetEmployees(Desig, Dept, Unit);
        }

        public Dictionary<string, string> GetEmployeesDic(string Desig, string Dept, string Unit)
        {
            Dictionary<string, string> emp = new Dictionary<string, string>();
            emp.Add("", "--Select--");
            foreach (EmployeeMasterRO em in new EmployeeSpecializationSetupDAL().GetEmployees(Desig, Dept, Unit))
            {
                emp.Add(em.EmpId, em.EmpName);
            }
            return emp;
        }



    }
}
