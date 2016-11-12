using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.HR.MODEL;
using AH.HR.BLL;
using AH.PRMS.BLL;
using AH.Shared.MODEL;
using AH.ORGMS.BLL;
using AH.ORGMS.MODEL;
namespace AH.HR.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HRWS" in both code and config file together.
    public class HRWS : IHRWS
    {
        public int VerifyDeptSetup(string vdept)
        {
            return new AdministrationSetupBLL().VerifyDeptSetup(vdept);
        }
        public short SaveDept(Department dept)
        {
            return new AdministrationSetupBLL().SaveDept(dept);
        }
        public short UpdateDept(Department tdpt)
        {
            return new AdministrationSetupBLL().UpdateDept(tdpt);
        }
        public int VerifyDeptGr(string groupid)
        {
            return new AdministrationSetupBLL().VerifyDeptGr(groupid);
        }
        public short SaveDeptGroup(DepartmentGroup deptgr)
        {
            return new AdministrationSetupBLL().SaveDeptGroup(deptgr);
        }
        public short UpdateDeptGroup(DepartmentGroup tDptGr)
        {
            return new AdministrationSetupBLL().UpdateDeptGroup(tDptGr);
        }
        public int VerifyDsig(string dsigid)
        {
            return new AdministrationSetupBLL().VerifyDsig(dsigid);
        }
        public short SaveDesignation(Designation tdsig)
        {
            return new AdministrationSetupBLL().SaveDesignation(tdsig);
        }
        public short UpdateDsig(Designation udsig)
        {
            return new AdministrationSetupBLL().UpdateDsig(udsig);
        }
        public int VerifyDesigGr(string groupid)
        {
            return new AdministrationSetupBLL().VerifyDesigGr(groupid);
        }
        public short SaveDesignationGr(DesignationGroup tdsiggr)
        {
            return new AdministrationSetupBLL().SaveDesignationGr(tdsiggr);
        }
        public short UpdateDsigGr(DesignationGroup dsigGr)
        {
            return new AdministrationSetupBLL().UpdateDsigGr(dsigGr);
        }
        public Dictionary<string, string> GetDesignationType(string type)
        {
            return new AdministrationSetupBLL().GetDesignationType(type);
        }
        public List<DeptUnitAss> GetAssignedUnit(string DeptGroup, string Department)
        {
            return new AdministrationSetupBLL().GetAssignedUnit(DeptGroup, Department);
        }
        public int VerifyUnit(string unitid)
        {
            return new AdministrationSetupBLL().VerifyUnit(unitid);
        }
        public short SaveUnit(DepartmentUnit dunit)
        {
            return new AdministrationSetupBLL().SaveUnit(dunit);
        }
        public short UpdateUnit(DepartmentUnit dunit)
        {
            return new AdministrationSetupBLL().UpdateUnit(dunit);
        }
        public List<DepartmentGroup> GetDeptGroup()
        {
            return new AdministrationSetupBLL().GetDeptGroup();
        }
        public Dictionary<string, string> GetDeptGroup(string type)
        {
            return new AdministrationSetupBLL().GetDeptGroup(type);
        }
        public List<Department> GetDepartments()
        {
            return new AdministrationSetupBLL().GetDepartments();
        }      
        public List<Designation> GetDesignation()
        {
            return new AdministrationSetupBLL().GetDesignation();
        }
        public List<DesignationGroup> GetDesignGrp()
        {
            return new AdministrationSetupBLL().GetDesignGrp();
        }
        public Dictionary<string, string> GetDesignGrp(string type)
        {
            return new AdministrationSetupBLL().GetDesignGrp(type);
        }
        public List<DesignationGroup> GetDesignGrpType(string Type)
        {
            return new AdministrationSetupBLL().GetDesignGrpType(Type);
        }
        public List<DepartmentUnit> GetUnit(string Dept)
        {
            return new AdministrationSetupBLL().GetUnit(Dept);
        }
        public List<DepartmentUnit> GetUnits()
        {
            return new AdministrationSetupBLL().GetUnits();
        }
        public List<DeptUnitAss> GetUnitList(string deptid)
        {
            return new AdministrationSetupBLL().GetUnitList(deptid);
        }
        public Dictionary<string, string> GetUnitDictionary(string type,string Dept)
        {
            return new AdministrationSetupBLL().GetUnitDictionary(type, Dept);
        }
        public Dictionary<string, string> GetUnitDict(string Dept)
        {
            return new AdministrationSetupBLL().GetUnitDict(Dept);
        }
        public short SaveDocSetup(Doctor tdoc)
        {
            return new EmployeeSpecializationSetupBLL().SaveDocSetup(tdoc);
        }
       
        public short UpdateDocSetup(Doctor udoc)
        {
            return new EmployeeSpecializationSetupBLL().UpdateDocSetup(udoc);
        }
        public List<Doctor> GetDoctors()
        {
            return new EmployeeSpecializationSetupBLL().GetDoctors();
        }
        public int VerifyDocId(string docid)
        {
            return new AdministrationSetupBLL().VerifyDocId(docid);
        }
        public Dictionary<string, string> GetDesignation(string type)
        {
            return new AdministrationSetupBLL().GetDesignation(type);
        }
        public Dictionary<string, string> GetRooms(string type)
        {
            return new PropertySetupBLL().GetRooms(type);
        }
        public Dictionary<string, string> GetDepartments(string type)
        {
            return new AdministrationSetupBLL().GetDepartments(type);
        }
        public short SaveDeptUnitAss(DeptUnitAss dasign)
        {
            return new AdministrationSetupBLL().SaveDeptUnitAss(dasign);
        }
        public List<DeptUnitAss> GetDeptUnitAssign()
        {
            return new AdministrationSetupBLL().GetDeptUnitAssign();
        }
        public List<DeptUnitAss> GetGroupDeptUnit(string DeptGroup)
        {
            return new AdministrationSetupBLL().GetGroupDeptUnit(DeptGroup);
        }
        public List<DeptUnitAss> GetDeptSetup(string deptgr)
        {
            return new AdministrationSetupBLL().GetDeptSetup(deptgr);
        }
        public Dictionary<string, string> GetDepartmentsetup(string type, string deptgr)
        {
            return new AdministrationSetupBLL().GetDepartmentsetup(type, deptgr);
        }
        public Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr)
        {
            return new AdministrationSetupBLL().GetDepartmentsetupDic(type, deptgr);
        }
        public List<DeptUnitAss> GetDeptUnitAssigned(string DeptGrp,string deptid)
        {
            return new AdministrationSetupBLL().GetDeptUnitAssigned(DeptGrp,deptid);
        }
        public Dictionary<string, string> GetDeptUnitDic(string DeptGrp, string deptid)
        {
            return new AdministrationSetupBLL().GetDeptUnitDic(DeptGrp, deptid);
        }
        public string verifyDeptUnitAssign(string dept, string unit)
        {
            return new AdministrationSetupBLL().verifyDeptUnitAssign(dept,unit);
        }
        public short EditDeptUnitAss(DeptUnitAss dasign)
        {
            return new AdministrationSetupBLL().EditDeptUnitAss(dasign);
        }
        //public Dictionary<string, string> GetDoctorTypes()
        //{
        //    return new EmployeeSpecializationSetupBLL().GetDoctorTypes();
        //}
        public short SaveNurse(Nurse nrs)
        {
            return new EmployeeSpecializationSetupBLL().SaveNurse(nrs);
        }
        public short ModifyNurse(Nurse nrs)
        {
            return new EmployeeSpecializationSetupBLL().ModifyNurse(nrs);
        }
        public List<Nurse> GetNurse()
        {
            return new EmployeeSpecializationSetupBLL().GetNurse();
        }
        public Dictionary<string, string> GetNurse(string type)
        {
            return new EmployeeSpecializationSetupBLL().GetNurse(type);
        }
        public EmployeeMaster GetEmployeeMaster(string ID)
        {
            return new EmployeeSetUpBLL().GetEmployeeMaster(ID);
        }     
        public short SaveEmpMasterJobInfo(EmployeeJobInformation mas)
        {
            return new EmployeeSetUpBLL().SaveEmpMasterJobInfo(mas);
        }
        public List<EmployeeJobInformation> GetEmployeeFringeBenefit()
        {
            return new EmployeeInformationSetupBLL().GetEmployeeFringeBenefit();
        }
        public string UpdateEmployeeMaster(EmployeeMaster mas)
        {
            return new EmployeeSetUpBLL().UpdateEmployeeMaster(mas);
        }
        public List<Department> GetDepartmentsetup(string deptgr)
        {
            return new AdministrationSetupBLL().GetDepartmentsetup(deptgr);
        }
        public List<Designation> GetDesignationGrpWise(string dsigr)
        {
            return new AdministrationSetupBLL().GetDesignationGrpWise(dsigr);
        }
        public Dictionary<string, string> GetDesignationGroupWise(string type, string dsigr)
        {
            return new AdministrationSetupBLL().GetDesignationGroupWise(type,dsigr);
        }

        public short SaveEmpEdu(EmpEducation empedu)
        {
            return new EmployeeSetUpBLL().SaveEmpEdu(empedu);
        }
        public List<EmpEducation> GetEducation()
        {
            return new EmployeeSetUpBLL().GetEducation();
        }

        public short SaveSalaryHeadGroup(SalaryHeadGroup oSalGrp)
        {
            return new PayrollSetupBLL().SaveSalaryHeadGroup(oSalGrp);
        }

        public List<SalaryHeadGroup> GetSalHeadGroup()
        {
            return new PayrollSetupBLL().GetSalHeadGroup();
        }
        public List<SalaryHeadGroup> GetSalHeadGroupSetup(string oSalHdGrp)
        {
            return new PayrollSetupBLL().GetSalHeadGroupSetup(oSalHdGrp);
        }
        public short UpdateSalaryHeadGroup(SalaryHeadGroup oSalGrp)
        {
            return new PayrollSetupBLL().UpdateSalaryHeadGroup(oSalGrp);
        }

        public short SaveSalaryHead(SalaryHead oSalHead)
        {
            return new PayrollSetupBLL().SaveSalaryHead(oSalHead);
        }

        public Dictionary<string, string> GetSalHeadGroup(string type)
        {
            return new PayrollSetupBLL().GetSalHeadGroup(type);
        }
        //public Dictionary<string, string> GetSalaryHead(string type)
        //{
        //    return new PayrollSetupBLL().GetSalaryHead(type);
        //}

        //public Dictionary<string, string> GetSalaryHeadsetup(string type, string oSalHd)
        //{
        //    return new PayrollSetupBLL().GetSalaryHeadsetup(type, oSalHd);
        //}

        public List<SalaryHead> GetSalaryHead()
        {
            return new PayrollSetupBLL().GetSalaryHead();
        }

        public List<SalaryHead> GetSalaryHeadsetup(string oSalHdG, string oSalHdH)
        {
            return new PayrollSetupBLL().GetSalaryHeadsetup(oSalHdG, oSalHdH);
        }

        public short UpdateSalaryHead(SalaryHead oSalHead)
        {
            return new PayrollSetupBLL().UpdateSalaryHead(oSalHead);
        }

        public List<SalaryGradeSetup> GetSalGradeSetup()
        {
            return new PayrollSetupBLL().GetSalGradeSetup();
        }
        public List<SalaryGradeSetup> GetGradeSetup(string level)
        {
            return new PayrollSetupBLL().GetGradeSetup(level);
        }
        public Dictionary<string, string> GetGradeDict(string level)
        {
            return new PayrollSetupBLL().GetGradeDict(level);
        }
        public short SaveSalaryGrade(SalaryGradeSetup oSalGrade)
        {
            return new PayrollSetupBLL().SaveSalaryGrade(oSalGrade);
        }

        public short UpdateGradeSetup(SalaryGradeSetup oSalGrade)
        {
            return new PayrollSetupBLL().UpdateGradeSetup(oSalGrade);
        }

        public Dictionary<string, string> GetGrade(string type)
        {
            return new PayrollSetupBLL().GetGrade(type);
        }

        public List<ScaleMSetup> GetScaleMSetup(string oSclMSetup)
        {
            return new PayrollSetupBLL().GetScaleMSetup(oSclMSetup);
        }
        public short SaveScaleMSetup(ScaleMSetup oSclMSet)
        {
            return new PayrollSetupBLL().SaveScaleMSetup(oSclMSet);
        }

        public short UpdateScaleMSetup(ScaleMSetup oSclMSet)
        {
            return new PayrollSetupBLL().UpdateScaleMSetup(oSclMSet);
        }
        public List<ScaleMSetup> GetScaleMSet()
        {
            return new PayrollSetupBLL().GetScaleMSet();
        }

        public Dictionary<string, string> GetScale(string type)
        {
            return new PayrollSetupBLL().GetScale(type);
        }

        public Dictionary<string, string> GetSalHd(string type)
        {
            return new PayrollSetupBLL().GetSalHd(type);
        }

        public int VerifyScaleSetup(string vscl)
        {
            return new PayrollSetupBLL().VerifyScaleSetup(vscl);
        }
        public List<ScaleDSetup> GetScaleDSetup(string oSalHdG, string oSalM)
        {
            return new PayrollSetupBLL().GetScaleDSetup(oSalHdG, oSalM);
        }

        public short SaveScaleDSetup(ScaleDSetup oSclDSet)
        {
            return new PayrollSetupBLL().SaveScaleDSetup(oSclDSet);
        }

        public short UpdateScaleDSetup(ScaleDSetup oSclDSet)
        {
            return new PayrollSetupBLL().UpdateScaleDSetup(oSclDSet);
        }

        public short SaveStepDetailsSetup(ScaleDSetup oStepDetails)
        {
            return new PayrollSetupBLL().SaveStepDetailsSetup(oStepDetails);
        }

        public List<ScaleMSetup> GetScaleUnderGrade(string oSalHdG)
        {
            return new PayrollSetupBLL().GetScaleUnderGrade(oSalHdG);
        }

        public List<EmployeeMaster> GetEmployeeID()
        {
            return new EmployeeSetUpBLL().GetEmployeeID();
        }

        public short SaveSalaryCycle(SalaryCycle oSalCycle)
        {
            return new PayrollSetupBLL().SaveSalaryCycle(oSalCycle);
        }

        public short UpdateSalaryCycle(SalaryCycle oSalCycle)
        {
            return new PayrollSetupBLL().UpdateSalaryCycle(oSalCycle);
        }

        public List<SalaryCycle> GetSalaryCycle(string Year)
        {
            return new PayrollSetupBLL().GetSalaryCycle(Year);
        }


        public List<SalaryCycle> GetMonthID()
        {
            return new PayrollSetupBLL().GetMonthID();
        }
        public Dictionary<string, string> GetMonthUnderYear(string type)
        {
            return new PayrollSetupBLL().GetMonthUnderYear(type);
        }

        public Dictionary<string, string> GetEmp(string type)
        {
            return new PayrollSetupBLL().GetEmp(type);
        }

        public string SavePayroll(Payroll oPay)
        {
            return new PayrollSetupBLL().SavePayroll(oPay);
        }

        public short SaveLeaveType(LeaveType oLvType)
        {
            return new LeaveSetupBLL().SaveLeaveType(oLvType);
        }

        public List<LeaveType> GetLeaveType()
        {
            return new LeaveSetupBLL().GetLeaveType();
        }

        public List<LeaveType> GetLeaveTypeSetup(string oLvTpSet)
        {
            return new LeaveSetupBLL().GetLeaveTypeSetup(oLvTpSet);
        }

        public short UpdateLeaveType(LeaveType oLvType)
        {
            return new LeaveSetupBLL().UpdateLeaveType(oLvType);
        }

         public Dictionary<string, string> GetLeave(string type)
        {
            return new LeaveSetupBLL().GetLeave(type);
        }


         public List<LeaveDaysSetup> GetLeaveDay(string oLvTpSet)
         {
             return new LeaveSetupBLL().GetLeaveDay(oLvTpSet);
         }
         public short SaveLeaveDays(LeaveDaysSetup oLvDaysSet)
         {
             return new LeaveSetupBLL().SaveLeaveDays(oLvDaysSet);
         }

         public short UpdateLeaveDays(LeaveDaysSetup oLvDaysSet)
         {
             return new LeaveSetupBLL().UpdateLeaveDays(oLvDaysSet);
         }

         public string SaveEmpLeaveRegister(EmpLeaveRegister oEmpLeaveRegis)
         {
             return new LeaveSetupBLL().SaveEmpLeaveRegister(oEmpLeaveRegis);
         }
         public List<EmpLeaveRegister> GetLeaveRegister(string oLvType)
         {
             return new LeaveSetupBLL().GetLeaveRegister(oLvType);
         }

         public short UpdateLeaveRegister(EmpLeaveRegister oEmpLeaveRegis)
         {
             return new LeaveSetupBLL().UpdateLeaveRegister(oEmpLeaveRegis);
         }

         public List<LeaveDaysSetup> GetLeaveDays(string oLvTpSet, string oYear)
         {
             return new LeaveSetupBLL().GetLeaveDays(oLvTpSet, oYear);
         }

         public List<DepartmentGroup> GetGroupUnderCategory(string oGrp)
         {
             return new AdministrationSetupBLL().GetGroupUnderCategory(oGrp);
         }

         public EmployeeMaster GetEmpMaster(string ID)
         {
             return new EmployeeSetUpBLL().GetEmpMaster(ID);
         }

         public short UpdateEmpEdu(EmpEducation EmpEdu)
         {
             return new EmployeeSetUpBLL().UpdateEmpEdu(EmpEdu);
         }

         public short SaveEmployeeJobInformation(EmployeeJobInformation oEmpJobInfo)
        {
            return new EmployeeInformationSetupBLL().SaveEmployeeJobInformation(oEmpJobInfo);
        }

        public Dictionary<string, string> GetEmployeeDictionary(string id, string name)
        {
            return new EmployeeInformationSetupBLL().GetEmployeeDictionary(id,name);
        }
        public List<EmployeeJobInformation> GetEmployeeJobInfo()
        {
            return new EmployeeInformationSetupBLL().GetEmployeeJobInfo();
        }
        public List<EmployeeJobInformation> GetEmployeeJobInformation(string oEmpJobInfo)
        {
            return new EmployeeInformationSetupBLL().GetEmployeeJobInformation(oEmpJobInfo);
        }
        public short UpdateEmployeeJobInformation(EmployeeJobInformation oEmpUpdateJob)
        {
            return new EmployeeInformationSetupBLL().UpdateEmployeeJobInformation(oEmpUpdateJob);
        }
        public EmployeeJobInformation GetEmployeeCurrentJobInformation(string oEmpJobInfo)
        {
            return new EmployeeInformationSetupBLL().GetEmployeeCurrentJobInformation(oEmpJobInfo);
        }
        public List<Payroll> CheckMonth(string ID)
        {
            return new PayrollSetupBLL().CheckMonth(ID);
        }
        public List<RptDepartment> GetRptDepartment()
        {
            return new ReportSetupBLL().GetRptDepartment();
        }
        public List<RptLeaveDays> RptGetLeave(string oLvTpSet)
        {
            return new ReportSetupBLL().RptGetLeave(oLvTpSet);
        }
        public List<EmployeeMasterRO> RptGetEmpMaster(string EmpMaster, string oLvTpSet, string Param)
        {
            return new EmployeeMasterReportBLL().RptGetEmpMaster(EmpMaster, oLvTpSet, Param);
        }
        public List<Department> GetDeptUnderGroup(string oGrp)
        {
            return new AdministrationSetupBLL().GetDeptUnderGroup(oGrp);
        }
        public Dictionary<string, string> GetDeptByGroup(string oDept)
        {
            return new AdministrationSetupBLL().GetDeptByGroup(oDept);
        }
        public List<Designation> GetDesigUnderGroup(string oGrp)
        {
            return new AdministrationSetupBLL().GetDesigUnderGroup(oGrp);
        }

        public List<EmployeeMasterRO> GetEmployee(string Dept, string Unit)
        {
            return new EmployeeSpecializationSetupBLL().GetEmployee(Dept, Unit);
        }
        public List<EmployeeMasterRO> GetEmployees(string Desig, string Dept, string Unit)
        {
            return new EmployeeSpecializationSetupBLL().GetEmployees(Desig, Dept, Unit);
        }
        public Dictionary<string, string> GetEmpDic(string Dept, string Unit)
        {
            return new EmployeeSpecializationSetupBLL().GetEmpDic(Dept, Unit);
        }
        public Dictionary<string, string> GetEmployeesDic(string Desig, string Dept, string Unit)
        {
            return new EmployeeSpecializationSetupBLL().GetEmployeesDic(Desig, Dept, Unit);
        }

        public string SaveEmployeePreviousExperiencen(EmployeePreviousExperience oEmpPrevExp)
        {
            return new EmployeeInformationSetupBLL().SaveEmployeePreviousExperiencen(oEmpPrevExp);
        }

        public List<EmployeePreviousExperience> GetEmployeePreviousExperience()
        {
            return new EmployeeInformationSetupBLL().GetEmployeePreviousExperience();
        }
        public short UpdateEmployeePreviousExperience(EmployeePreviousExperience oEmpUpdatePrevExp)
        {
            return new EmployeeInformationSetupBLL().UpdateEmployeePreviousExperience(oEmpUpdatePrevExp);
        }
        public short SaveEmployeeTraining(EmployeeTraining oEmpTraning)
        {
            return new EmployeeInformationSetupBLL().SaveEmployeeTraining(oEmpTraning);
        }
        public List<EmployeeTraining> GetEmployeeTraining()
        {
            return new EmployeeInformationSetupBLL().GetEmployeeTraining();
        }
        public short UpdateEmployeeTraining(EmployeeTraining oEmpUpdateTran)
        {
            return new EmployeeInformationSetupBLL().UpdateEmployeeTraining(oEmpUpdateTran);
        }

        public List<PayrollRO> GetPayrollDetailsRO(string Payroll, string DeptGrp, string dept, string Unit, string Month)
        {
            return new PayrollReportBLL().GetPayrollDetailsRO(Payroll, DeptGrp, dept, Unit,Month);
        }
        public List<LeaveRO> GetDeptWiseLeaveDetails(string Mode, string year, string DeptGrp, string Dept, string Unit)
        {
            return new LeaveReportBLL().GetDeptWiseLeaveDetails(Mode,year,DeptGrp, Dept, Unit);
        }
        public List<LeaveRO> GetLeaveRegisterDetailsRO(string Emp, string year)
        {
            return new LeaveReportBLL().GetLeaveRegisterDetailsRO(Emp, year);
        }
        public List<PayrollRO> GetPayrollForUpdate(string Emp, string DeptGrp, string Dept, string Unit, string Month, string Year)
        {
            return new PayrollSetupBLL().GetPayrollForUpdate(Emp, DeptGrp, Dept,Unit, Month, Year);
        }
        public string SaveUpdatedPayroll(PayrollRO oPayUp)
        {
            return new PayrollSetupBLL().SaveUpdatedPayroll(oPayUp);
        }
        public List<PayrollRO> ShowPayrollDetails(string Mode, string DeptGrp, string Dept, string Unit, string Month)
        {
            return new PayrollSetupBLL().ShowPayrollDetails(Mode,DeptGrp, Dept, Unit, Month);
        }
        public List<EmployeeMaster> GetEmpID(string dept)
        {
            return new EmployeeSetUpBLL().GetEmpID(dept);
        }
        public Dictionary<string, string> GetEmployeeID(string dept)
        {
            return new EmployeeSetUpBLL().GetEmployeeID(dept);
        }
        //public List<Department> GetDepartmentsetup(string deptgr)
        //{
        //    return new AdministrationSetupBLL().GetDepartmentsetup(deptgr);
        //}

        public Dictionary<string, string> GetDepartmentGroupWise(string deptgr)
        {
            return new AdministrationSetupBLL().GetDepartmentGroupWise(deptgr);
        }            
        public short SaveBenefitType(FringeBenefit oBenType)
        {
            return new EmployeeInformationSetupBLL().SaveBenefitType(oBenType);
        }

        public List<FringeBenefit> GetBenefitType()
        {
            return new EmployeeInformationSetupBLL().GetBenefitType();
        }
        public List<FringeBenefit> CheckBenefitType(string Benefit)
        {
            return new EmployeeInformationSetupBLL().CheckBenefitType(Benefit);
        }
        public Dictionary<string, string> GetBenefitDict(string type)
        {
            return new EmployeeInformationSetupBLL().GetBenefitDict(type);
        }
        public short UpdateBenefitType(FringeBenefit oBenType)
        {
            return new EmployeeInformationSetupBLL().UpdateBenefitType(oBenType);
        }
        public List<Designation> GetDesignationParentWise(string dsigParent)
        {
            return new AdministrationSetupBLL().GetDesignationParentWise(dsigParent);
        }
        public List<LeaveRO> GetLeaveRequestListRptPrsn(string EmpID)
        {
            return new LeaveSetupBLL().GetLeaveRequestListRptPrsn(EmpID);
        }
        public List<LeaveRO> GetLeaveRequestList(string EmpID)
        {
            return new LeaveSetupBLL().GetLeaveRequestList(EmpID);
        }
        public short SaveLeaveCancelCause(LeaveCancelCause oLvCanCaus)
        {
            return new LeaveSetupBLL().SaveLeaveCancelCause(oLvCanCaus);
        }
        public List<LeaveCancelCause> GetLeaveCancelCause()
        {
            return new LeaveSetupBLL().GetLeaveCancelCause();
        }
        public short UpdateLeaveCancelCause(LeaveCancelCause oLvCanCaus)
        {
            return new LeaveSetupBLL().UpdateLeaveCancelCause(oLvCanCaus);
        }
        public Dictionary<string, string> GetLvCanCause(string type)
        {
            return new LeaveSetupBLL().GetLvCanCause(type);
        }
        public short SaveEmployeeDependent(EmployeeDependent oEmpDep)
        {
            return new EmployeeInformationSetupBLL().SaveEmployeeDependent(oEmpDep);
        }
        public List<EmployeeDependent> GetEmployeeDependent()
        {
            return new EmployeeInformationSetupBLL().GetEmployeeDependent();
        }
        public List<EmployeeDependent> GetEmpDependent(string emp)
        {
            return new EmployeeInformationSetupBLL().GetEmpDependent(emp);
        }
        public Dictionary<string, string> GetEmployeeDependent(string type)
        {
            return new EmployeeInformationSetupBLL().GetEmployeeDependent(type);
        }
        public short UpdateEmployeeDependent(EmployeeDependent oEmpDep)
        {
            return new EmployeeInformationSetupBLL().UpdateEmployeeDependent(oEmpDep);
        }
        public List<EmployeeMasterRO> RptGetAllEmployee()
        {
            return new EmployeeMasterReportBLL().RptGetAllEmployee();
        }
        public List<EmployeeMasterRO> GetEmployeeInfo(string mode, string param)
        {
            return new EmployeeMasterReportBLL().GetEmployeeInfo(mode, param);
        }
        public EmpLeaveRegister GetLeaveReg(string oEmp, string oLvType, string Serial)
        {
            return new LeaveSetupBLL().GetLeaveReg(oEmp, oLvType, Serial);
        }
        public List<LeaveRO> GetLeaveRequestListHR()
        {
            return new LeaveSetupBLL().GetLeaveRequestListHR();
        }
        public List<Attendence> ShowAttendence(string Mode, string DeptGrp, string Dept, string Unit, string Month, string Year)
        {
            return new AttendenceSetupBLL().ShowAttendence(Mode,DeptGrp, Dept, Unit, Month, Year);
        }
        public string SaveUpdatedAttendence(Attendence oAttendence)
        {
            return new AttendenceSetupBLL().SaveUpdatedAttendence(oAttendence);
        }

        public List<EmployeeTraining> GetEmpTraining(string emp)
        {
            return new EmployeeInformationSetupBLL().GetEmpTraining(emp);
        }
        public List<EmployeePreviousExperience> GetEmpPreviousExperience(string emp)
        {
            return new EmployeeInformationSetupBLL().GetEmpPreviousExperience(emp);
        }
        public List<EmpEducation> GetEmpEducation(string emp)
        {
            return new EmployeeSetUpBLL().GetEmpEducation(emp);
        }
        public List<SalaryCycle> GetMonthByYear(string year)
        {
            return new PayrollSetupBLL().GetMonthByYear(year);
        }
        public string saveManualPayroll(Payroll oPay)
        {
            return new PayrollSetupBLL().saveManualPayroll(oPay);
        }
        public Dictionary<string, string> GetGroupCategory(string oGrpCat)
        {
            return new AdministrationSetupBLL().GetGroupCategory(oGrpCat);
        }
        public List<EmployeeMasterRO> RptGetAllEmployeeMas(string DeptType, string DeptGrp, string Dept, string Unit)
        {
            return new EmployeeMasterReportBLL().RptGetAllEmployeeMas(DeptType, DeptGrp, Dept, Unit);
        }
        public List<LeaveRO> GetLeaveTemplateRO(string emp = "", string serial = "")
        {
            return new LeaveReportBLL().GetLeaveTemplateRO(emp, serial);
        }
        public List<RptDepartment> GetDepartmentTree()
        {
            return new ReportSetupBLL().GetDepartmentTree();
        }
         public List<DepartmentGroup> GetDeptGroupsByType(string dptType)
        {
            return new AdministrationSetupBLL().GetDeptGroupsByType(dptType);  
        }
         public Dictionary<string, string> GetDeptGroupDicByType(string type)
         {
             return new AdministrationSetupBLL().GetDeptGroupDicByType(type);
         }
         public string SaveSalaryDisbursing(Payroll oPay)
         {
             return new PayrollSetupBLL().SaveSalaryDisbursing(oPay);
         }
         public List<PayrollRO> GetSalaryStatementForBank(string month)
         {
             return new PayrollReportBLL().GetSalaryStatementForBank(month);
         }
         public List<PayrollRO> GetPaySlip(string Month, string EmpId)
         {
             return new PayrollReportBLL().GetPaySlip(Month, EmpId);
         }
         public short SaveEmployeeMedicalInformation(EmployeeMedicalInfo oEmpDep)
         {
             return new EmployeeInformationSetupBLL().SaveEmployeeMedicalInformation(oEmpDep);
         }
         public short UpdateEmployeeMedicalInformation(EmployeeMedicalInfo oEmpDep)
         {
             return new EmployeeInformationSetupBLL().UpdateEmployeeMedicalInformation(oEmpDep);
         }
         public List<EmployeeMedicalInfo> GetEmployeeMedicalInformation(string emp)
         {
             return new EmployeeInformationSetupBLL().GetEmployeeMedicalInformation(emp);
         }
         public short SavePunishmentType(PunishmentType oPunType)
         {
             return new EmployeeInformationSetupBLL().SavePunishmentType(oPunType);
         }
         public short UpdatePunishmentType(PunishmentType oPunType)
         {
             return new EmployeeInformationSetupBLL().UpdatePunishmentType(oPunType);
         }
         public List<PunishmentType> GetPunishmentType()
         {
             return new EmployeeInformationSetupBLL().GetPunishmentType();
         }
         public List<PunishmentType> CheckPunishmentType(string Punishment)
         {
             return new EmployeeInformationSetupBLL().CheckPunishmentType(Punishment);
         }
         public Dictionary<string, string> GetPunishmentDict(string type)
         {
             return new EmployeeInformationSetupBLL().GetPunishmentDict(type);
         }
         public short SaveEmpPunishmentSetup(PunishmentType oPunType)
         {
             return new EmployeeInformationSetupBLL().SaveEmpPunishmentSetup(oPunType);
         }
         public short UpdateEmpPunishmentSetup(PunishmentType oPunType)
         {
             return new EmployeeInformationSetupBLL().UpdateEmpPunishmentSetup(oPunType);
         }
         public List<PunishmentType> GetEmpPunishmentType(string EmpId)
         {
             return new EmployeeInformationSetupBLL().GetEmpPunishmentType(EmpId);
         }
         public List<DistrictThana> GetDistrict()
         {
             return new AdministrationSetupBLL().GetDistrict();
         }
         public Dictionary<string, string> GetDistrictDict(string type)
         {
             return new AdministrationSetupBLL().GetDistrictDict(type);
         }
         public short SaveThana(DistrictThana oDistrictThana)
         {
             return new AdministrationSetupBLL().SaveThana(oDistrictThana);
         }
         public short UpdateThana(DistrictThana oDistrictThana)
         {
             return new AdministrationSetupBLL().UpdateThana(oDistrictThana);
         }
         public List<DistrictThana> GetThana(string District)
         {
             return new AdministrationSetupBLL().GetThana(District);
         }
         public Dictionary<string, string> GetThanaDict(string District)
         {
             return new AdministrationSetupBLL().GetThanaDict(District);
         }
         public List<DistrictThana> GetDistrictAndThana()
         {
             return new AdministrationSetupBLL().GetDistrictAndThana();
         }
         public short SavePostOffice(DistrictThana oDistrictThana)
         {
             return new AdministrationSetupBLL().SavePostOffice(oDistrictThana);
         }
         public short UpdatePostOffice(DistrictThana oDistrictThana)
         {
             return new AdministrationSetupBLL().UpdatePostOffice(oDistrictThana);
         }
         public List<DistrictThana> GetPostOffice(string District, string Thana)
         {
             return new AdministrationSetupBLL().GetPostOffice(District, Thana);
         }
        public Dictionary<string, string> GetPostOfficeDict(string District, string Thana)
         {
             return new AdministrationSetupBLL().GetPostOfficeDict(District, Thana);
         }

//************************* Holiday Setup Related ***********************************//

         public short SaveHolidayType(HolidayType oHolidayType)
         {
             return new HolidaySetupBLL().SaveHolidayType(oHolidayType);
         }
         public short UpdateLHolidayType(HolidayType oHolidayType)
         {
             return new HolidaySetupBLL().UpdateLHolidayType(oHolidayType);
         }
         public List<HolidayType> GetHolidayType()
         {
             return new HolidaySetupBLL().GetHolidayType();
         }
         public Dictionary<string, string> GetHolidayTypeDict(string type)
         {
             return new HolidaySetupBLL().GetHolidayTypeDict(type);
         }
         public short SaveHolidayName(HolidayName oHolidayName)
        {
            return new HolidaySetupBLL().SaveHolidayName(oHolidayName);
        }
        public short UpdateLHolidayName(HolidayName oHolidayName)
        {
            return new HolidaySetupBLL().UpdateLHolidayName(oHolidayName);
        }
        public List<HolidayName> GetHoliday()
        {
            return new HolidaySetupBLL().GetHoliday();
        }
        public List<HolidayName> GetHolidayName(string Type)
        {
            return new HolidaySetupBLL().GetHolidayName(Type);
        }
        public Dictionary<string, string> GetHolidayNameDict(string type)
        {
            return new HolidaySetupBLL().GetHolidayNameDict(type);
        }
        public short SaveHolidayCalender(HolidayCalender oHolidayCalender)
        {
            return new HolidaySetupBLL().SaveHolidayCalender(oHolidayCalender);
        }
        public short UpdateHolidayCalender(HolidayCalender oHolidayCalender)
        {
            return new HolidaySetupBLL().UpdateHolidayCalender(oHolidayCalender);
        }
        public List<HolidayCalender> GetHolidayCalender(string Year, string Type)
        {
            return new HolidaySetupBLL().GetHolidayCalender(Year, Type);
        }
        public List<HolidayCalenderRO> GetHolidayCalenderForReport(string Year)
        {
            return new HolidaySetupBLL().GetHolidayCalenderForReport(Year);
        }
        public short SaveNomineeInformation(Nominee oNominee)
        {
            return new EmployeeInformationSetupBLL().SaveNomineeInformation(oNominee);
        }
        public short UpdateNomineeInformation(Nominee oNominee)
        {
            return new EmployeeInformationSetupBLL().UpdateNomineeInformation(oNominee);
        }
        public List<Nominee> GetNomineeInformation(string EmpID)
        {
            return new EmployeeInformationSetupBLL().GetNomineeInformation(EmpID);
        }
        public List<Nominee> GetNomineeInfo()
        {
            return new EmployeeInformationSetupBLL().GetNomineeInfo();
        }
        public short SaveBankSetup(BankInfo oBank)
        {
            return new AdministrationSetupBLL().SaveBankSetup(oBank);
        }
        public short UpdateBankSetup(BankInfo oBank)
        {
            return new AdministrationSetupBLL().UpdateBankSetup(oBank);
        }
        public List<BankInfo> GetBankSetup()
        {
            return new AdministrationSetupBLL().GetBankSetup();
        }
        public Dictionary<string, string> GetBankDict(string type)
        {
            return new AdministrationSetupBLL().GetBankDict(type);
        }
        public short SavePayrollBase(PayrollBase oPayrollBase)
        {
            return new PayrollSetupBLL().SavePayrollBase(oPayrollBase);
        }
        public List<PayrollBase> GetPayrollBase(string EmpID)
        {
            return new PayrollSetupBLL().GetPayrollBase(EmpID);
        }
        public List<EmployeeMaster> GetEmpGender(string EmpID)
        {
            return new EmployeeInformationSetupBLL().GetEmpGender(EmpID);
        }
        public short SaveShiftSetup(Shift oShift)
        {
            return new AttendenceSetupBLL().SaveShiftSetup(oShift);
        }
        public short UpdateShiftSetup(Shift oShift)
        {
            return new AttendenceSetupBLL().UpdateShiftSetup(oShift);
        }
        public List<Shift> GetShiftSetup()
        {
            return new AttendenceSetupBLL().GetShiftSetup();
        }
        public Dictionary<string, string> GetShiftDict(string type)
        {
            return new AttendenceSetupBLL().GetShiftDict(type);
        }
        public List<EmployeeMaster> GetEmpInfoForAttndence(string DeptGroup, string Department, string Unit)
        {
            return new AttendenceSetupBLL().GetEmpInfoForAttndence(DeptGroup,Department, Unit);
        }
        public List<EmployeeMaster> GetEmpInfoForRoster(string Mode, string DeptGroup, string Department, string Unit)
        {
            return new AttendenceSetupBLL().GetEmpInfoForRoster(Mode, DeptGroup, Department, Unit);
        }
        public short SaveRosterDuty(EmployeeMaster oEmployeeMaster)
        {
            return new AttendenceSetupBLL().SaveRosterDuty(oEmployeeMaster);
        }
        public List<EmployeeMaster> GetRosterDuty(string Mode, string Year, string Month, string DeptGroup, string Department, string Unit)
        {
            return new AttendenceSetupBLL().GetRosterDuty(Mode,Year, Month, DeptGroup, Department, Unit);
        }
        public List<EmployeeMaster> GetOneDayRoster(string Mode, string Year, string Month, string DeptGroup, string Department, string Unit, string StartDate, string EndDate)
        {
            return new AttendenceSetupBLL().GetOneDayRoster(Mode, Year, Month, DeptGroup, Department, Unit, StartDate, EndDate);
        }
        public List<EmployeeMaster> GetRosterDutyDate(string Mode, string Year, string Month, string DeptGroup, string Department, string Unit, string EmpID)
        {
            return new AttendenceSetupBLL().GetRosterDutyDate(Mode,Year, Month, DeptGroup, Department, Unit, EmpID);
        }
        public short SaveDeptHeadInfo(EmployeeJobInformation mas)
        {
            return new EmployeeSetUpBLL().SaveDeptHeadInfo(mas);
        }
        public List<EmployeeJobInformation> GetDeptHead(string DeptGroup, string Dept, string Unit)
        {
            return new EmployeeSetUpBLL().GetDeptHead(DeptGroup, Dept, Unit);
        }
        public short SaveIncomeTax(IncomeTax oIncomeTax)
        {
            return new IncomeTaxSetupBLL().SaveIncomeTax(oIncomeTax);
        }
        public short UpdateIncomeTax(IncomeTax oIncomeTax)
        {
            return new IncomeTaxSetupBLL().UpdateIncomeTax(oIncomeTax);
        }
        public List<IncomeTax> GetIncomeTax(string oIncomeTax)
        {
            return new IncomeTaxSetupBLL().GetIncomeTax(oIncomeTax);
        }
        public List<IncomeTax> GetIncomeTaxInfo(string FiscalYear, string Category)
        {
            return new IncomeTaxSetupBLL().GetIncomeTaxInfo(FiscalYear, Category);
        }
        public short SaveAppointmentSetup(Appointment oAppointment)
        {
            return new AppointmentSetupBLL().SaveAppointmentSetup(oAppointment);
        }
        public short UpdateAppointmentSetup(Appointment oAppointment)
        {
            return new AppointmentSetupBLL().UpdateAppointmentSetup(oAppointment);
        }
        public List<Appointment> GetAppointmentSetup(string ReffNumber)
        {
            return new AppointmentSetupBLL().GetAppointmentSetup(ReffNumber);
        }
        public List<AppointmentRO> GetAppointmentLetter(string ReffNumber)
        {
            return new AppointmentSetupBLL().GetAppointmentLetter(ReffNumber);
        }
        public Dictionary<string, string> GetDesignGrpTypeDict(string type)
        {
            return new AdministrationSetupBLL().GetDesignGrpTypeDict(type);
        }
        public short SaveShiftTimingSetup(Shift oShift)
        {
            return new AttendenceSetupBLL().SaveShiftTimingSetup(oShift);
        }
        public short UpdateShiftTimingSetup(Shift oShift)
        {
            return new AttendenceSetupBLL().UpdateShiftTimingSetup(oShift);
        }
        public List<Shift> GetShiftTimingSetup()
        {
            return new AttendenceSetupBLL().GetShiftTimingSetup();
        }
        public short SaveOrganogram(Organogram oOrganogram)
        {
            return new AdministrationSetupBLL().SaveOrganogram(oOrganogram);
        }
        public List<Organogram> GetOrganogramSetup(string DepartmentGroup, string Department,string Unit)
        {
            return new AdministrationSetupBLL().GetOrganogramSetup(DepartmentGroup,Department,Unit);
        }
        public Dictionary<string, string> GetOrganogramDesig(string DepartmentGroup, string Department, string Unit)
        {
            return new AdministrationSetupBLL().GetOrganogramDesig(DepartmentGroup, Department, Unit);
        }
        public List<Shift> GetShiftTiming(string DeptGroup, string Department, string Unit)
        {
            return new AttendenceSetupBLL().GetShiftTiming(DeptGroup, Department, Unit);
        }
        public short SaveEmployeeDropList(EmployeeDropList oEmployeeDropList)
        {
            return new EmployeeInformationSetupBLL().SaveEmployeeDropList(oEmployeeDropList);
        }
        public short UpdateEmployeeDropList(EmployeeDropList oEmployeeDropList)
        {
            return new EmployeeInformationSetupBLL().UpdateEmployeeDropList(oEmployeeDropList);
        }
        public short UpdateFinalizeDropList(EmployeeDropList oEmployeeDropList)
        {
            return new EmployeeInformationSetupBLL().UpdateFinalizeDropList(oEmployeeDropList);
        }
        public List<EmployeeDropList> GetEmpDropList()
        {
            return new EmployeeInformationSetupBLL().GetEmpDropList();
        }
        public List<EmployeeDropList> GetEmpDropListForFinalize()
        {
            return new EmployeeInformationSetupBLL().GetEmpDropListForFinalize();
        }
        public Dictionary<string, string> GetDeptHeadDic(string DeptGroup)
        {
            return new EmployeeSetUpBLL().GetDeptHeadDic(DeptGroup);
        }
        public List<EmployeeMaster> GetEmpInfoForRptPrsn(string DeptType, string DeptGroup)
        {
            return new AttendenceSetupBLL().GetEmpInfoForRptPrsn(DeptType, DeptGroup);
        }
        public Dictionary<string, string> GetReportingPersonDic(string DeptType, string DeptGroup)
        {
            return new AttendenceSetupBLL().GetReportingPersonDic(DeptType, DeptGroup);
        }
        public List<LeaveRO> GetEmployeeLeaveDetails(string Year, string Employee)
        {
            return new LeaveReportBLL().GetEmployeeLeaveDetails(Year, Employee);
        }
        public List<LeaveRO> GetEmployeeLeaveSummary(string Year, string Employee)
        {
            return new LeaveReportBLL().GetEmployeeLeaveSummary(Year, Employee);
        }
        public List<PayrollRO> GetEmployeeUnderSalary()
        {
            return new PayrollReportBLL().GetEmployeeUnderSalary();
        }
        public List<PayrollRO> GetAccountsPart(string month)
        {
            return new PayrollReportBLL().GetAccountsPart(month);
        }
        public short SaveFoodSubsidySetup(FoodSubsidy oFoodSubsidy)
        {
            return new AdministrationSetupBLL().SaveFoodSubsidySetup(oFoodSubsidy);
        }
        public string UpdateFoodSubsidySetup(FoodSubsidy oFoodSubsidy)
        {
            return new AdministrationSetupBLL().UpdateFoodSubsidySetup(oFoodSubsidy);
        }
        public List<FoodSubsidy> GetFoodSubsidySetup()
        {
            return new AdministrationSetupBLL().GetFoodSubsidySetup();
        }
        public List<LeaveRO> GetEmployeeLeaveDays(string Year)
        {
            return new LeaveReportBLL().GetEmployeeLeaveDays(Year);
        }
        public List<Attendence> GetDailyAttndence(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate)
        {
            return new AttendenceSetupBLL().GetDailyAttndence(Mode, DeptGroup, Dept, Unit, StartDate, EndDate);
        }
        public List<Attendence> GetDailyAbsent(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate)
        {
            return new AttendenceSetupBLL().GetDailyAbsent(Mode, DeptGroup, Dept, Unit, StartDate, EndDate);
        }
        public List<Attendence> GetDailyLate(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate)
        {
            return new AttendenceSetupBLL().GetDailyLate(Mode, DeptGroup, Dept, Unit, StartDate, EndDate);
        }
        public List<LeaveRO> GetDailyLeave(string Mode, string DeptGrp, string Dept, string Unit, string StartDate, string EndDate)
        {
            return new AttendenceSetupBLL().GetDailyLeave(Mode, DeptGrp, Dept, Unit, StartDate, EndDate);
        }
        public List<Attendence> GetMonthlyAttndence(string EmpID, string StartDate, string EndDate)
        {
            return new AttendenceSetupBLL().GetMonthlyAttndence(EmpID, StartDate, EndDate);
        }
        public short SaveEmployeeDegreeSetup(EmployeeDegree oEmpDegree)
        {
            return new EmployeeInformationSetupBLL().SaveEmployeeDegreeSetup(oEmpDegree);
        }
        public short UpdateEmployeeDegreeSetup(EmployeeDegree oEmpDegree)
        {
            return new EmployeeInformationSetupBLL().UpdateEmployeeDegreeSetup(oEmpDegree);
        }
        public List<EmployeeDegree> GetAllEmployeeDegree()
        {
            return new EmployeeInformationSetupBLL().GetAllEmployeeDegree();
        }
        public List<EmployeeDegree> GetEmployeeDegreeSetup(string EmpID)
        {
            return new EmployeeInformationSetupBLL().GetEmployeeDegreeSetup(EmpID);
        }
        public string AttendanceProcess(Attendence oAttendence)
        {
            return new AttendenceSetupBLL().AttendanceProcess(oAttendence);
        }
        public short UpdateAttendanceProcess(Attendence oAttendence)
        {
            return new AttendenceSetupBLL().UpdateAttendanceProcess(oAttendence);
        }
        public FoodSubsidy GetFoodSubsidy(string EmpID)
        {
            return  new AdministrationSetupBLL().GetFoodSubsidy(EmpID);          
        }
        public List<LeaveRO> GetAllLeaveRequisition(string Mode, string Year, string DeptGroup, string Dept, string Unit)
        {
            return new LeaveReportBLL().GetAllLeaveRequisition(Mode, Year, DeptGroup, Dept, Unit);
        }
        public List<EmployeeDropList> GetDropListByType(string DropType)
        {
            return new EmployeeInformationSetupBLL().GetDropListByType(DropType);
        }
        public List<EmployeeDropList> GetEmpDropListForFinalizeByType(string DropType)
        {
            return new EmployeeInformationSetupBLL().GetEmpDropListForFinalizeByType(DropType);
        }
        public List<EmployeeDropList> GetCompletedFinalizedList(string DropType)
        {
            return new EmployeeInformationSetupBLL().GetCompletedFinalizedList(DropType);
        }
        public List<EmployeeMasterRO> GetEmpJoiningReport(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate)
        {
            return new EmployeeMasterReportBLL().GetEmpJoiningReport(Mode, DeptGroup, Dept, Unit, StartDate, EndDate);
        }
        public List<EmployeeMasterRO> GetEmpResigReport(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate)
        {
            return new EmployeeMasterReportBLL().GetEmpResigReport(Mode, DeptGroup, Dept, Unit, StartDate, EndDate);
        }
        public List<EmployeeMasterRO> GetEmpConfDateReport(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate)
        {
            return new EmployeeMasterReportBLL().GetEmpConfDateReport(Mode, DeptGroup, Dept, Unit, StartDate, EndDate);
        }
        public List<EmployeeMasterRO> GetEmpOthersReport(string Mode, string DeptGroup, string Dept, string Unit, string DropType, string StartDate, string EndDate)
        {
            return new EmployeeMasterReportBLL().GetEmpOthersReport(Mode, DeptGroup, Dept, Unit, DropType, StartDate, EndDate);
        }
    }
}
