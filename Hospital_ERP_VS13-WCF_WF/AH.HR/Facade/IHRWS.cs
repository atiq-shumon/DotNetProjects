using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.HR.MODEL;
using AH.Shared.MODEL;
using AH.ORGMS.MODEL;

namespace AH.HR.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHRWS" in both code and config file together.
    [ServiceContract]
    public interface IHRWS
    {

        [OperationContract]
        int VerifyDeptSetup(string vdept);
        [OperationContract]
        short SaveDept(Department dept);
        [OperationContract]
        short UpdateDept(Department tdpt);
        [OperationContract]
        int VerifyDeptGr(string groupid);
        [OperationContract]
        short SaveDeptGroup(DepartmentGroup deptgr);
        [OperationContract]       
        short UpdateDeptGroup(DepartmentGroup tDptGr);
        [OperationContract]
        int VerifyDsig(string dsigid);
        [OperationContract]
        short SaveDesignation(Designation tdsig);
        [OperationContract]
        short UpdateDsig(Designation udsig);
        [OperationContract]
        int VerifyDesigGr(string groupid);
        [OperationContract]
        short SaveDesignationGr(DesignationGroup tdsiggr);
        [OperationContract]
        short UpdateDsigGr(DesignationGroup dsigGr);
        [OperationContract]
        List<Designation> GetDesignationGrpWise(string dsigr);
        [OperationContract]
        int VerifyUnit(string unitid);
        [OperationContract]
        short SaveUnit(DepartmentUnit dunit);
        [OperationContract]
        List<DeptUnitAss> GetGroupDeptUnit(string DeptGroup);
        [OperationContract]
        short UpdateUnit(DepartmentUnit dunit);
        [OperationContract]
        List<DepartmentGroup> GetDeptGroup();
        [OperationContract(Name = "GetDeptGroupDictionary")]
        Dictionary<string, string> GetDeptGroup(string type);
        [OperationContract(Name = "GetDeptDictionary")]
        Dictionary<string, string> GetDepartments(string type);
        [OperationContract]       
        List<Department> GetDepartments();
        [OperationContract]
        List<Designation> GetDesignation();
        [OperationContract(Name = "GetDesigDict")]
        Dictionary<string, string> GetDesignation(string type);
        [OperationContract(Name = "GetDesignGrpList")]
        List<DesignationGroup> GetDesignGrp();
        [OperationContract]
        Dictionary<string, string> GetDesignationType(string type);
        [OperationContract(Name = "GetDesignGrpDictionary")]
        Dictionary<string, string> GetDesignGrp(string type);
        [OperationContract]
        List<DesignationGroup> GetDesignGrpType(string Type);
        [OperationContract]
        List<DeptUnitAss> GetUnitList(string deptid);
        [OperationContract]
        List<DepartmentUnit> GetUnit(string Dept);
        [OperationContract]
        List<DepartmentUnit> GetUnits();
        [OperationContract]
        Dictionary<string, string> GetUnitDict(string Dept);
        [OperationContract]
        Dictionary<string, string> GetUnitDictionary(string type, string Dept);
        [OperationContract]
        short SaveDocSetup(Doctor tdoc);
        [OperationContract]
        short UpdateDocSetup(Doctor udoc);
        [OperationContract]
        List<Doctor> GetDoctors();
        [OperationContract]       
        int VerifyDocId(string docid);
        [OperationContract(Name = "GetRoomsDict")]
        Dictionary<string, string> GetRooms(string type);
        [OperationContract]
        short SaveDeptUnitAss(DeptUnitAss dasign);
        [OperationContract]
        List<DeptUnitAss> GetDeptUnitAssign();
        [OperationContract]
        List<Department> GetDepartmentsetup(string deptgr);
        [OperationContract]
        List<DeptUnitAss> GetDeptUnitAssigned(string DeptGrp,string deptid);
        [OperationContract]
        Dictionary<string, string> GetDeptUnitDic(string DeptGrp, string deptid);
        [OperationContract]
        string verifyDeptUnitAssign(string dept, string unit);
        [OperationContract]
        short EditDeptUnitAss(DeptUnitAss dasign);
        //[OperationContract]
        //Dictionary<string, string> GetDoctorTypes();
        [OperationContract]
        short SaveNurse(Nurse nrs);
        [OperationContract]
        short ModifyNurse(Nurse nrs);
        [OperationContract]
        List<Nurse> GetNurse();
        [OperationContract(Name = "GetNurseDict")]
        Dictionary<string, string> GetNurse(string type);      
        [OperationContract]
        short SaveEmpMasterJobInfo(EmployeeJobInformation mas);
        [OperationContract]
        string UpdateEmployeeMaster(EmployeeMaster mas);
        [OperationContract]
        EmployeeMaster GetEmployeeMaster(string ID);
        //[OperationContract (Name = "GetEmpMasterDict")]
        //Dictionary<string, string> GetEmployeeMaster(string type);       
        [OperationContract(Name = "GetDeptGroupWise")]
        Dictionary<string, string> GetDepartmentsetup(string type, string deptgr);
        [OperationContract(Name = "GetDesignationGrDict")]
        Dictionary<string, string> GetDesignationGroupWise(string type, string dsigr);
        [OperationContract]
        List<DeptUnitAss> GetDeptSetup(string deptgr);
        [OperationContract]
        Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr);
        [OperationContract]
        short SaveEmpEdu(EmpEducation empedu);
        [OperationContract]
        List<EmpEducation> GetEducation();
        [OperationContract]
        short SaveSalaryHeadGroup(SalaryHeadGroup oSalGrp);
        [OperationContract]
        List<SalaryHeadGroup> GetSalHeadGroup();
        [OperationContract]
        List<SalaryHeadGroup> GetSalHeadGroupSetup(string oSalHdGrp);
        [OperationContract]
        short UpdateSalaryHeadGroup(SalaryHeadGroup oSalGrp);
        [OperationContract]
        short SaveSalaryHead(SalaryHead oSalHead);
        [OperationContract(Name="GetSalGrp")]
        Dictionary<string, string> GetSalHeadGroup(string type);

        //[OperationContract]
        //Dictionary<string, string> GetSalaryHead(string type);
        //[OperationContract]
        //Dictionary<string, string> GetSalaryHeadsetup(string type, string oSalHd);

        [OperationContract]
        List<SalaryHead> GetSalaryHead();
        [OperationContract]
        List<SalaryHead> GetSalaryHeadsetup(string oSalHdG, string oSalHdH);
        [OperationContract]
        short UpdateSalaryHead(SalaryHead oSalHead);
        [OperationContract]
        short SaveSalaryGrade(SalaryGradeSetup oSalGrade);
        [OperationContract]
        List<SalaryGradeSetup> GetSalGradeSetup();
        [OperationContract]
        List<SalaryGradeSetup> GetGradeSetup(string level);
        [OperationContract]
        Dictionary<string, string> GetGradeDict(string level);
        [OperationContract]
        short UpdateGradeSetup(SalaryGradeSetup oSalGrade);

        [OperationContract(Name = "GetGrade")]
        Dictionary<string, string> GetGrade(string type);
        [OperationContract]
        List<ScaleMSetup> GetScaleMSetup(string oSclMSetup);
        [OperationContract]
        short SaveScaleMSetup(ScaleMSetup oSclMSet);
        [OperationContract]
        short UpdateScaleMSetup(ScaleMSetup oSclMSet);
        [OperationContract]
        List<ScaleMSetup> GetScaleMSet();
        [OperationContract(Name = "GetScale")]
        Dictionary<string, string> GetScale(string type);
        [OperationContract(Name = "GetSalHd")]
        Dictionary<string, string> GetSalHd(string type);
        [OperationContract]
        List<ScaleDSetup> GetScaleDSetup(string oSalHdG, string oSalM);
        [OperationContract]
        short SaveScaleDSetup(ScaleDSetup oSclDSet);
        [OperationContract]
        int VerifyScaleSetup(string vscl);
        [OperationContract]
        short UpdateScaleDSetup(ScaleDSetup oSclDSet);
        [OperationContract]

        short SaveStepDetailsSetup(ScaleDSetup oStepDetails);
        [OperationContract]
        List<ScaleMSetup> GetScaleUnderGrade(string oSalHdG);
        [OperationContract]
         List<EmployeeMaster> GetEmployeeID();
        [OperationContract]
        short SaveSalaryCycle(SalaryCycle oSalCycle);
        [OperationContract]
        short UpdateSalaryCycle(SalaryCycle oSalCycle);
        [OperationContract]
        List<SalaryCycle> GetSalaryCycle(string Year);
        [OperationContract]
        List<SalaryCycle> GetMonthID();
        [OperationContract(Name = "GetMonth")]
        Dictionary<string, string> GetMonthUnderYear(string type);
        [OperationContract]
        string SavePayroll(Payroll oPay);
        [OperationContract(Name = "GetEmp")]
        Dictionary<string, string> GetEmp(string type);
        [OperationContract]
        short SaveLeaveType(LeaveType oLvType);
        [OperationContract]
        List<LeaveType> GetLeaveType();
        [OperationContract]
        List<LeaveType> GetLeaveTypeSetup(string oLvTpSet);
        [OperationContract]
        short UpdateLeaveType(LeaveType oLvType);
        [OperationContract(Name = "GetLeaveID")]
        Dictionary<string, string> GetLeave(string type);
        [OperationContract]
        List<LeaveDaysSetup> GetLeaveDay(string oLvTpSet);
        [OperationContract]
        short SaveLeaveDays(LeaveDaysSetup oLvDaysSet);
        [OperationContract]
        short UpdateLeaveDays(LeaveDaysSetup oLvDaysSet);
        [OperationContract]
        string SaveEmpLeaveRegister(EmpLeaveRegister oEmpLeaveRegis);
        [OperationContract]
        List<EmpLeaveRegister> GetLeaveRegister(string oLvType);
        [OperationContract]
        short UpdateLeaveRegister(EmpLeaveRegister oEmpLeaveRegis);
         [OperationContract]
        List<LeaveDaysSetup> GetLeaveDays(string oLvTpSet, string oYear);
        [OperationContract]
        List<DepartmentGroup> GetGroupUnderCategory(string oGrp);
        [OperationContract]
        Dictionary<string, string> GetGroupCategory(string oGrpCat);
        [OperationContract]
        EmployeeMaster GetEmpMaster(string ID);

        [OperationContract]
        short UpdateEmpEdu(EmpEducation EmpEdu);
        [OperationContract]
        short SaveEmployeeJobInformation(EmployeeJobInformation oEmpJobInfo);
        [OperationContract]        
        List<EmployeeJobInformation> GetEmployeeJobInfo();
        [OperationContract]
        Dictionary<string, string> GetEmployeeDictionary(string id, string name);
        [OperationContract]
        List<EmployeeJobInformation> GetEmployeeJobInformation(string oEmpJobInfo);
        [OperationContract]
        short UpdateEmployeeJobInformation(EmployeeJobInformation oEmpUpdateJob);
        [OperationContract]
        EmployeeJobInformation GetEmployeeCurrentJobInformation(string oEmpJobInfo);
        [OperationContract]
        List<EmployeeJobInformation> GetEmployeeFringeBenefit();
        [OperationContract]
        List<Payroll> CheckMonth(string ID);
        [OperationContract]
        List<RptDepartment> GetRptDepartment();
        [OperationContract]
        List<RptLeaveDays> RptGetLeave(string oLvTpSet);
        [OperationContract]
        List<EmployeeMasterRO> RptGetEmpMaster(string EmpMaster, string oLvTpSet, string Param);
        [OperationContract]
        List<Department> GetDeptUnderGroup(string oGrp);
        [OperationContract]
        List<Designation> GetDesigUnderGroup(string oGrp);
        [OperationContract]
        List<EmployeeMasterRO> GetEmployee(string Dept, string Unit);
        [OperationContract]
        List<EmployeeMasterRO> GetEmployees(string Desig, string Dept, string Unit);
        [OperationContract(Name = "GetEmpDic")]
        Dictionary<string, string> GetEmpDic(string Dept, string Unit);
        [OperationContract(Name = "GetEmployeesDic")]
        Dictionary<string, string> GetEmployeesDic(string Desig, string Dept, string Unit);
        [OperationContract]
        string SaveEmployeePreviousExperiencen(EmployeePreviousExperience oEmpPrevExp);
        [OperationContract]
        List<EmployeePreviousExperience> GetEmployeePreviousExperience();
        [OperationContract]
        short UpdateEmployeePreviousExperience(EmployeePreviousExperience oEmpUpdatePrevExp);
        [OperationContract]
        short SaveEmployeeTraining(EmployeeTraining oEmpTraning);
        [OperationContract]
        List<EmployeeTraining> GetEmployeeTraining();
        [OperationContract]
        short UpdateEmployeeTraining(EmployeeTraining oEmpUpdateTran);
        [OperationContract]
        List<PayrollRO> GetPayrollDetailsRO(string Payroll, string DeptGrp, string dept, string Unit, string Month);
        [OperationContract]
        List<LeaveRO> GetDeptWiseLeaveDetails(string Mode, string year, string DeptGrp, string Dept, string Unit);
        [OperationContract]
        List<LeaveRO> GetLeaveRegisterDetailsRO(string Emp, string year);
        [OperationContract]
        List<PayrollRO> GetPayrollForUpdate(string Emp, string DeptGrp, string Dept, string Unit, string Month, string Year);
        [OperationContract]
        string SaveUpdatedPayroll(PayrollRO oPayUp);
        [OperationContract]
        List<PayrollRO> ShowPayrollDetails(string Mode, string DeptGrp, string Dept, string Unit, string Month);
        [OperationContract]
        List<EmployeeMaster> GetEmpID(string dept);
        [OperationContract(Name="GetEmployeeDic")]
        Dictionary<string, string> GetEmployeeID(string dept);
        [OperationContract]
        Dictionary<string, string> GetDepartmentGroupWise(string deptgr);
        [OperationContract]     
        List<DeptUnitAss> GetAssignedUnit(string DeptGroup, string Department);
        [OperationContract]       
        short SaveBenefitType(FringeBenefit oBenType);
        [OperationContract]
        List<FringeBenefit> GetBenefitType();
        [OperationContract]
        Dictionary<string, string> GetBenefitDict(string type);
        [OperationContract]

        List<FringeBenefit> CheckBenefitType(string Benefit);
        [OperationContract]
        short UpdateBenefitType(FringeBenefit oBenType);
        [OperationContract]
        List<Designation> GetDesignationParentWise(string dsigParent);
        [OperationContract]
        List<LeaveRO> GetLeaveRequestListRptPrsn(string EmpID);
        [OperationContract]
        List<LeaveRO> GetLeaveRequestList(string EmpID);
        [OperationContract]
        short SaveLeaveCancelCause(LeaveCancelCause oLvCanCaus);
        [OperationContract]
        List<LeaveCancelCause> GetLeaveCancelCause();
        [OperationContract]
        short UpdateLeaveCancelCause(LeaveCancelCause oLvCanCaus);
        [OperationContract(Name = "GetLvCanCause")]
        Dictionary<string, string> GetLvCanCause(string type);
        [OperationContract]
        short SaveEmployeeDependent(EmployeeDependent oEmpDep);
        [OperationContract]
        List<EmployeeDependent> GetEmployeeDependent();
        [OperationContract]
        List<EmployeeDependent> GetEmpDependent(string emp);
        [OperationContract]
        short UpdateEmployeeDependent(EmployeeDependent oEmpDep);
        [OperationContract(Name = "GetEmpDependentDic")]
        Dictionary<string, string> GetEmployeeDependent(string type);
        [OperationContract]
        List<EmployeeMasterRO> RptGetAllEmployee();
        [OperationContract]
        List<EmployeeMasterRO> GetEmployeeInfo(string mode, string param);
        [OperationContract]
        EmpLeaveRegister GetLeaveReg(string oEmp, string oLvType, string Serial);
        [OperationContract]
        List<LeaveRO> GetLeaveRequestListHR();
        [OperationContract]
        List<Attendence> ShowAttendence(string Mode, string DeptGrp, string Dept, string Unit, string Month, string Year);
        [OperationContract]
        string SaveUpdatedAttendence(Attendence oAttendence);
        [OperationContract]
        List<EmployeeTraining> GetEmpTraining(string emp);
        [OperationContract]
        List<EmployeePreviousExperience> GetEmpPreviousExperience(string emp);
        [OperationContract]
        List<EmpEducation> GetEmpEducation(string emp);
        [OperationContract]
        List<SalaryCycle> GetMonthByYear(string year);
        [OperationContract]
        string saveManualPayroll(Payroll oPay);
       [OperationContract]
        Dictionary<string, string> GetDeptByGroup(string oDept);
       [OperationContract]
       List<EmployeeMasterRO> RptGetAllEmployeeMas(string DeptType, string DeptGrp, string Dept, string Unit);
        [OperationContract]
        List<LeaveRO> GetLeaveTemplateRO(string emp = "", string serial = "");
        [OperationContract]      
        List<RptDepartment> GetDepartmentTree();
        [OperationContract]
        List<DepartmentGroup> GetDeptGroupsByType(string dptType);
        [OperationContract]
        Dictionary<string, string> GetDeptGroupDicByType(string type);
        [OperationContract]
        string SaveSalaryDisbursing(Payroll oPay);
        [OperationContract]
        List<PayrollRO> GetSalaryStatementForBank(string month);
        [OperationContract]
        List<PayrollRO> GetPaySlip(string Month, string EmpId);
        [OperationContract]
        short SaveEmployeeMedicalInformation(EmployeeMedicalInfo oEmpDep);
        [OperationContract]
        short UpdateEmployeeMedicalInformation(EmployeeMedicalInfo oEmpDep);
        [OperationContract]
        List<EmployeeMedicalInfo> GetEmployeeMedicalInformation(string emp);
        [OperationContract]
        short SavePunishmentType(PunishmentType oPunType);
        [OperationContract]
        short UpdatePunishmentType(PunishmentType oPunType);
        [OperationContract]
        List<PunishmentType> GetPunishmentType();
        [OperationContract]
         List<PunishmentType> CheckPunishmentType(string Punishment);
        [OperationContract]
         Dictionary<string, string> GetPunishmentDict(string type);
        [OperationContract]
        short SaveEmpPunishmentSetup(PunishmentType oPunType);
        [OperationContract]
        short UpdateEmpPunishmentSetup(PunishmentType oPunType);
        [OperationContract]
        List<PunishmentType> GetEmpPunishmentType(string EmpId);
        [OperationContract]
        List<DistrictThana> GetDistrict();
        [OperationContract]
        Dictionary<string, string> GetDistrictDict(string type);
        [OperationContract]
        short SaveThana(DistrictThana oDistrictThana);
        [OperationContract]
        short UpdateThana(DistrictThana oDistrictThana);
        [OperationContract]
        List<DistrictThana> GetThana(string District);
        [OperationContract]
        Dictionary<string, string> GetThanaDict(string District);
        [OperationContract]
        List<DistrictThana> GetDistrictAndThana();
        [OperationContract]
        short SavePostOffice(DistrictThana oDistrictThana);
        [OperationContract]
        short UpdatePostOffice(DistrictThana oDistrictThana);
        [OperationContract]
        List<DistrictThana> GetPostOffice(string District, string Thana);
        [OperationContract]
        Dictionary<string, string> GetPostOfficeDict(string District, string Thana);
         [OperationContract]
        short SaveHolidayType(HolidayType oHolidayType);
        [OperationContract]
        short UpdateLHolidayType(HolidayType oHolidayType);
        [OperationContract]
        List<HolidayType> GetHolidayType();
        [OperationContract]
        Dictionary<string, string> GetHolidayTypeDict(string type);
        [OperationContract]
        short SaveHolidayName(HolidayName oHolidayName);
        [OperationContract]
        short UpdateLHolidayName(HolidayName oHolidayName);
        [OperationContract]
        List<HolidayName> GetHoliday();
        [OperationContract]
        List<HolidayName> GetHolidayName(string Type);
        [OperationContract]
        Dictionary<string, string> GetHolidayNameDict(string type);
        [OperationContract]
        short SaveHolidayCalender(HolidayCalender oHolidayCalender);
        [OperationContract]
        short UpdateHolidayCalender(HolidayCalender oHolidayCalender);
        [OperationContract]
        List<HolidayCalender> GetHolidayCalender(string Year, string Type);
        [OperationContract]
        List<HolidayCalenderRO> GetHolidayCalenderForReport(string Year);
        [OperationContract]
        short SaveNomineeInformation(Nominee oNominee);
        [OperationContract]
        short UpdateNomineeInformation(Nominee oNominee);
        [OperationContract]
        List<Nominee> GetNomineeInformation(string EmpID);
        [OperationContract]
        List<Nominee> GetNomineeInfo();
        [OperationContract]
        short SaveBankSetup(BankInfo oBank);
        [OperationContract]
        short UpdateBankSetup(BankInfo oBank);
        [OperationContract]
        List<BankInfo> GetBankSetup();
        [OperationContract]
        Dictionary<string, string> GetBankDict(string type);
        [OperationContract]
        short SavePayrollBase(PayrollBase oPayrollBase);
        [OperationContract]
        List<PayrollBase> GetPayrollBase(string EmpID);
        [OperationContract]
        List<EmployeeMaster> GetEmpGender(string EmpID);
        [OperationContract]
        short SaveShiftSetup(Shift oShift);
        [OperationContract]
        short UpdateShiftSetup(Shift oShift);
        [OperationContract]
        List<Shift> GetShiftSetup();
        [OperationContract]
        Dictionary<string, string> GetShiftDict(string type);
        [OperationContract]
        List<EmployeeMaster> GetEmpInfoForAttndence(string DeptGroup,string Department,string Unit);
        [OperationContract]
        List<EmployeeMaster> GetEmpInfoForRoster(string Mode, string DeptGroup, string Department, string Unit);
        [OperationContract]
        short SaveRosterDuty(EmployeeMaster oEmployeeMaster);
        [OperationContract]
        List<EmployeeMaster> GetRosterDuty(string Mode, string Year, string Month, string DeptGroup, string Department, string Unit);
        [OperationContract]
        List<EmployeeMaster> GetOneDayRoster(string Mode, string Year, string Month, string DeptGroup, string Department, string Unit, string StartDate, string EndDate);
        [OperationContract]
        List<EmployeeMaster> GetRosterDutyDate(string Mode, string Year, string Month, string DeptGroup, string Department, string Unit, string EmpID);
        [OperationContract]
        short SaveDeptHeadInfo(EmployeeJobInformation mas);
        [OperationContract]
        List<EmployeeJobInformation> GetDeptHead(string DeptGroup, string Dept, string Unit);
        [OperationContract]
        short SaveIncomeTax(IncomeTax oIncomeTax);
        [OperationContract]
        short UpdateIncomeTax(IncomeTax oIncomeTax);
        [OperationContract]
        List<IncomeTax> GetIncomeTax(string oIncomeTax);
        [OperationContract]
        List<IncomeTax> GetIncomeTaxInfo(string FiscalYear, string Category);
        [OperationContract]
        short SaveAppointmentSetup(Appointment oAppointment);
        [OperationContract]
        short UpdateAppointmentSetup(Appointment oAppointment);
        [OperationContract]
        List<Appointment> GetAppointmentSetup(string ReffNumber);
        [OperationContract]
        List<AppointmentRO> GetAppointmentLetter(string ReffNumber);
        [OperationContract]
        Dictionary<string, string> GetDesignGrpTypeDict(string type);
        [OperationContract]
        short SaveShiftTimingSetup(Shift oShift);
        [OperationContract]
        short UpdateShiftTimingSetup(Shift oShift);
        [OperationContract]
        List<Shift> GetShiftTimingSetup();
        [OperationContract]
        short SaveOrganogram(Organogram oOrganogram);
        [OperationContract]
        List<Organogram> GetOrganogramSetup(string DepartmentGroup, string Department,string Unit);
        [OperationContract]
        Dictionary<string, string> GetOrganogramDesig(string DepartmentGroup, string Department, string Unit);
        [OperationContract]
        List<Shift> GetShiftTiming(string DeptGroup, string Department, string Unit);
        [OperationContract]
        short SaveEmployeeDropList(EmployeeDropList oEmployeeDropList);
        [OperationContract]
        short UpdateEmployeeDropList(EmployeeDropList oEmployeeDropList);
        [OperationContract]
        short UpdateFinalizeDropList(EmployeeDropList oEmployeeDropList);
        [OperationContract]
        List<EmployeeDropList> GetEmpDropList();
        [OperationContract]
        List<EmployeeDropList> GetEmpDropListForFinalize();
        [OperationContract]
        Dictionary<string, string> GetDeptHeadDic(string DeptGroup);
        [OperationContract]
        List<EmployeeMaster> GetEmpInfoForRptPrsn(string DeptType, string DeptGroup);
        [OperationContract]
        Dictionary<string, string> GetReportingPersonDic(string DeptType, string DeptGroup);
        [OperationContract]
        List<LeaveRO> GetEmployeeLeaveDetails(string Year, string Employee);
        [OperationContract]
        List<LeaveRO> GetEmployeeLeaveSummary(string Year, string Employee);
        [OperationContract]
        List<PayrollRO> GetEmployeeUnderSalary();
        [OperationContract]
        List<PayrollRO> GetAccountsPart(string month);
        [OperationContract]
        short SaveFoodSubsidySetup(FoodSubsidy oFoodSubsidy);
        [OperationContract]
        string UpdateFoodSubsidySetup(FoodSubsidy oFoodSubsidy);
        [OperationContract]
        List<FoodSubsidy> GetFoodSubsidySetup();
        [OperationContract]
        List<LeaveRO> GetEmployeeLeaveDays(string Year);
        [OperationContract]
        List<Attendence> GetDailyAttndence(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate);
        [OperationContract]
        List<Attendence> GetMonthlyAttndence(string EmpID, string StartDate, string EndDate);
        [OperationContract]
        short SaveEmployeeDegreeSetup(EmployeeDegree oEmpDegree);
        [OperationContract]
        short UpdateEmployeeDegreeSetup(EmployeeDegree oEmpDegree);
        [OperationContract]
        List<EmployeeDegree> GetAllEmployeeDegree();
        [OperationContract]
        List<EmployeeDegree> GetEmployeeDegreeSetup(string EmpID);
        [OperationContract]
        string AttendanceProcess(Attendence oAttendence);
        [OperationContract]
        short UpdateAttendanceProcess(Attendence oAttendence);
        [OperationContract]
        List<Attendence> GetDailyAbsent(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate);
        [OperationContract]
        List<Attendence> GetDailyLate(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate);
        [OperationContract]
        List<LeaveRO> GetDailyLeave(string Mode, string DeptGrp, string Dept, string Unit, string StartDate, string EndDate);
        [OperationContract]
        FoodSubsidy GetFoodSubsidy(string EmpID);
        [OperationContract]
        List<LeaveRO> GetAllLeaveRequisition(string Mode, string Year, string DeptGroup, string Dept, string Unit);
        [OperationContract]
        List<EmployeeDropList> GetDropListByType(string DropType);
        [OperationContract]
        List<EmployeeDropList> GetEmpDropListForFinalizeByType(string DropType);
        [OperationContract]
        List<EmployeeDropList> GetCompletedFinalizedList(string DropType);
        [OperationContract]
        List<EmployeeMasterRO> GetEmpJoiningReport(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate);
        [OperationContract]
        List<EmployeeMasterRO> GetEmpResigReport(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate);
        [OperationContract]
        List<EmployeeMasterRO> GetEmpConfDateReport(string Mode, string DeptGroup, string Dept, string Unit, string StartDate, string EndDate);
        [OperationContract]
        List<EmployeeMasterRO> GetEmpOthersReport(string Mode, string DeptGroup, string Dept, string Unit, string DropType, string StartDate, string EndDate);
    }
}
