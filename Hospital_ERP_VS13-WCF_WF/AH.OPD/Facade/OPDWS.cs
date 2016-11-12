using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.HR.BLL;
using AH.HR.MODEL;
using AH.OPD.BLL;
using AH.DUtility;
using AH.PatReg.BLL;
using AH.OPD.MODEL;
using AH.DTMS.BLL;
using AH.DTMS.MODEL;
using AH.Shared.MODEL;
using AH.DRUGS.MODEL;
using AH.DRUGS.BLL;
using AH.PRMS.BLL;
using AH.PRMS.MODEL;
using AH.ORGMS.BLL;
using AH.APPOPD.MODEL;
using AH.APPOPD.BLL;
using AH.IPDShared.BLL;


namespace AH.OPD.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OPDWS_" in both code and config file together.
    public class OPDWS : IOPDWS
    {
        public Dictionary<string, string> GetOPDDoctorDict(string DeptID, string UnitID)
        {
            return new OPDBLL().GetOPDDoctorDict(DeptID, UnitID);
            //return new AdministrationSetupBLL().GetEmpDic(Utility.GetDesignationGroupCode(Utility.DesignationGroupCode.Doctor), DeptID, UnitID);
        }

        public Dictionary<string, string> GetOPDRoomsDict(string BuildingID, string RmType)
        {
            return new OPDBLL().GetOPDRoomsDict(BuildingID, RmType);
        }


        //Fauzul 20 Aug 2014
        public List<OPDDrRoomAllRO> GetDocRoomAllRO()
        {
            return new OPDBLL().GetDocRoomAllRO();
        }

        public List<OPDNurseRoomAllRO> GetNurseRoomRO()
        {
            return new OPDBLL().GetNurseRoomRO();
        }
        //Fauzul 10 Aug 2014
        public List<Room> GETs_Room_No(string RoomGro)
        {
            return new OPDBLL().GETs_Room_No(RoomGro);
        }

        //Fauzul 05 Aug 2014
        public List<Ticket> GetPatDoc(string docid)
        {
            return new OPDBLL().GetPatDoc(docid);
        }

        //Fauzul 04 Aug 2014
        //public List<OPDDoctor> GetOPDDoctors(string DeptID, string UnitID)
        //{
        //    return new OPDBLL().GetOPDDoctors(DeptID, UnitID);
        //}
        public Dictionary<string, string> GetOPDDoctorsDict(string deptID, string UnitID)
        {
            return new OPDBLL().GetOPDDoctorsDict(deptID, UnitID);
        }

        public List<OPDDoctorCallQ> InsDrRoom(string NID)
        {
            return new OPDBLL().InsDrRoom(NID);
        }

        //Fauzul 2 Aug 2014
        public List<Room> UpdateRoomGroup(Room oRoom)
        {
            return new OPDBLL().UpdateRoomGroup(oRoom);
        }

        public List<Room> test()
        { 
            return new OPDBLL().test();
        }

        public short InsertRoomGroup(OPDRoomGrpAssign oRoom)
        {
            return new OPDBLL().InsertRoomGroup(oRoom);
        }

        public List<OPDRoomGrpAssign> GetRoomGroup(string RoomGrp)
        {
            return new OPDBLL().GetRoomGroup(RoomGrp);
        }

        public List<OPDRoomGrpAssign> GetRoomGroup()
        {
            return new OPDBLL().GetRoomGroup();          
        }

        //Fauzul 16 July 2014
        public string GetDrRoom(string DocID)
        {
            return new OPDBLL().GetDrRoom(DocID);
        }

        //Fauzul 10 Jul 2014
        public Dictionary<string, string> GetNurses(string type)
        {
            return new EmployeeSpecializationSetupBLL().GetNurse("D");
        }


        //Fauzul 09 Jul 2014
        public string ChkPatOldNew(string DocID, string p_hcn)
        {
            return new OPDBLL().ChkPatOldNew(DocID, p_hcn);
        }

        //Fauzul 03 July 2014
        public List<OPDNurseRoomAllocation> GetNurseRoom()
        {
            return new OPDBLL().GetNurseRoom();
        }

        public List<OPDNurseRoomAllocation> InsertNurseRoom(OPDNurseRoomAllocation oOPDNurseRoomAllocation)
        {
            return new OPDBLL().InsertNurseRoom(oOPDNurseRoomAllocation);

        }

        //Fauzul 28 Jun 2014
        public List<OPDTicketRO> ChangePatientStatus(string TicketNo, string RoomNo, string DocID)
        {
            return new OPDReportBLL().ChangePatientStatus(TicketNo, RoomNo, DocID);
        }

        //Fauzul 28 Jun 2014
        public List<OPDDoctorCallQ> GetsOPDDoctorName()
        {
            return new OPDReportBLL().GetsOPDDoctorName();
        }
        //Fauzul 28 Jun 2014
        public List<OPDTicketRO> GetsOPDDocRoomNo(string RoomNo, string DocID)
        {
            return new OPDReportBLL().GetsOPDDocRoomNo(RoomNo, DocID);
        }

        public OPDDoctorCall InsUpdDocCall(OPDDoctorCall oOPDDoctorCall)
        {
            return new OPDBLL().InsUpdDocCall(oOPDDoctorCall);
        }

        //public Dictionary<string, string> GetDepartments(string type)
        //{
        //    return new AdministrationSetupBLL().GetDepartments(type);
        //}

        //public Dictionary<string, string> GetDepartmentsetup(string type, string deptgr)
        //{
        //    return new OPDBLL().GetDepartmentsetup(type, deptgr);   
        //}
        public Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr)
        {
            return new OPDBLL().GetDepartmentsetupDic(type, deptgr);
        }

        //public Dictionary<string, string> GetUnits()
        //{
        //    return new AdministrationSetupBLL().GetUnits();
        //}
        public Dictionary<string, string> GetDoctors(string dept, string unit)
        {
            return new OPDBLL().GetDoctors(dept, unit);
        }

        //public Dictionary<string, string> GetCases()
        //{
        //    return new OPDBLL().GetCases();
        //}

        public Dictionary<string, string> GetPrescriptionTypes()
        {
            return new OPDBLL().GetPrescriptionTypes();
        }

        public Age CalculateAge(DateTime dob)
        {
            return new OPDBLL().CalculateAge(dob);
        }

        public string VerifyPatientNo(string patNo)
        {
            return new PatientRegistrationBLL().VerifyPatientNo(patNo);
        }

        public Patient GetPatient(string pId)
        {
            return new PatientRegistrationBLL().GetPatient(pId);
        }

        public string SaveOPDTicket(Ticket tkt)
        {
            return new OPDBLL().SaveOPDTicket(tkt);
        }

        public List<RptTicket> GetTickets(string patientNo, string tktNo)
        {
            return new OPDBLL().GetTickets(patientNo, tktNo);
        }
        public List<DiseaseCase> getDiseaseGroup()
        {
            return new OPDBLL().getDiseaseGroup();
        }
        public Dictionary<string, string> getDiseaseGroupDic(string type)
        {
            return new OPDBLL().getDiseaseGroupDic(type);
        }

        public List<DiseaseCase> GetDiseaseCase()
        {
            return new OPDBLL().GetDiseaseCase();
        }

        public short SaveDisease(DiseaseCase tDept)
        {
            return new OPDBLL().SaveDisease(tDept);
        }

        public short UpdateDisease(DiseaseCase tDept)
        {
            return new OPDBLL().UpdateDisease(tDept);
        }

        public Dictionary<string, string> GetDiseaseCase(string type)
        {
            return new OPDBLL().GetDiseaseCase(type);
        }

        public Dictionary<string, string> GetUnitDict(string Dept)
        {
            return new AdministrationSetupBLL().GetUnitDict(Dept);
        }

        public Dictionary<string, string> GetDoctors(string type)
        {
            return new EmployeeSpecializationSetupBLL().GetDoctors(type);
        }

        /// <summary>
        ///  unit doc dictionary
        /// </summary>
        /// <param name="type"></param>
        /// <param name="deptid"></param>
        /// <returns></returns>
        //public Dictionary<string, string> GetDeptUnitAssigned(string type, string deptid)
        //{
        //    return new AdministrationSetupBLL().GetUnitDictionary(type, deptid);
        //}

        public Dictionary<string, string> GetDeptUnitDic(string deptgrp, string deptid)
        {
            return new OPDBLL().GetDeptUnitDic(deptgrp, deptid);
        }


        public Dictionary<string, string> GetDoctorSetup(string type, string deptid, string unitid)
        {
            return new EmployeeSpecializationSetupBLL().GetDoctorSetup(type, deptid, unitid);
        }

        //public List<TestGroup> GetDiagnGrp(string department)
        //{
        //    return new OPDBLL().GetDiagnGrp(department);
        //}
        public Dictionary<string, string> GetDiagnGrp(string type, string department)
        {
            return new DiagnosticSetupBLL().GetDiagnGrp(type, department);
        }

        public List<TestMain> GetTestMain(string department, string group)
        {
            return new OPDBLL().GetTestMain(department, group);
        }

        public Dictionary<string, string> GetTestMain(string type)
        {
            return new DiagnosticSetupBLL().GetTestMain(type);
        }

        public List<TestSub> GetTestDetails(string deptid, string group, string main)
        {
            return new OPDBLL().GetTestDetails(deptid, group, main);
        }

        public Dictionary<string, string> GetTestMain(string type, string department, string group)
        {
            return new DiagnosticSetupBLL().GetTestMain(type, department, group);
        }

        public Ticket GetTicket(string tktNo)
        {
            return new OPDBLL().GetTicket(tktNo);
        }

        public Dictionary<string, string> GetDoctorByDept(string type, string deptid)
        {
            return new EmployeeSpecializationSetupBLL().GetDoctorByDept(type, deptid);
        }

       // -------------------------Save Prescription-------------------------------------
        public string SavePrescription(Prescription prs)
        {
            return new OPDBLL().SavePrescription(prs);
        }
        public string EditPrescription(Prescription prs)
        {
            return new OPDBLL().EditPrescription(prs);
        }

        //-------------------------------------------------------------------------------
        public Dictionary<string, string> GetPrescriptionTypes(string type)
        {
            return Utility.GetPrescriptionTypes();
        }

        public List<OPDPrescriptionReportNewRO> GetOPDPrescription(string whereCondition)
        {
            return new OPDReportBLL().GetOPDPrescription(whereCondition);
        }

        public List<OPDTicketRO> GetOPDTicketMR(string WhereCondition)
        {
            return new OPDReportBLL().GetOPDTicketMR(WhereCondition);
        }
        public List<OPDTicketRO> GetOPDRefundTicketMR(string TicketNo)
        {
            return new OPDReportBLL().GetOPDRefundTicketMR(TicketNo);
        }

        //public Dictionary<string, string> GetTestDetails(string type, string deptid, string group, string main)
        //{
        //    return new DiagnosticSetupBLL().GetTestDetails(type,deptid,group,main);
        //}

        public List<Ticket> GetPrescriptionList(string docid)
        {
            return new OPDBLL().GetPrescriptionList(docid);
        }
#region ClinicalFindingsNew(09/07/15)
        public short SaveClinicalFindingsGrp(ClinicalFindingsGroup cfGrp)
        {
            return new OPDBLL().SaveClinicalFindingsGrp(cfGrp);
        }
        public short UpdateClinicalFindingsGrp(ClinicalFindingsGroup cfGrp)
        {
            return new OPDBLL().UpdateClinicalFindingsGrp(cfGrp);
        }
        public List<ClinicalFindingsGroup> GetClinicalFindingsGroups()
        {
            return new OPDBLL().GetClinicalFindingsGroups();
        }
        public List<ClinicalFindingsGroup> GetClinicalFindingsGroup(string cfGrpTitle)
        {
            return new OPDBLL().GetClinicalFindingsGroup(cfGrpTitle);
        }
        public Dictionary<string, string> GetClinicalFindingsGroupDict(string type)
        {
            return new OPDBLL().GetClinicalFindingsGroupDict(type);
        }
        public Dictionary<string, string> GetClinicalFindingsDict(string type)
        {
            return new OPDBLL().GetClinicalFindingsDict(type);
        }
        public short SaveClinicalFindings(ClinicalFindings cf)
        {
            return new OPDBLL().SaveClinicalFindings(cf);
        }
        public List<ClinicalFindings> GetCfTree()
        {
            return new OPDBLL().GetCfTree();
        }
        public short UpdateClinicalFindings(ClinicalFindings cf)
        {
            return new OPDBLL().UpdateClinicalFindings(cf);
        }
        public List<ClinicalFindings> GetClinicalFindings()
        {
            return new OPDBLL().GetClinicalFindings();
        }
        public List<ClinicalFindings> GetClinicalFinding(string cfTitle)
        {
            return new OPDBLL().GetClinicalFinding(cfTitle);
        }

        public List<ClinicalFindings> GetClinicalFindingByGroup(string cfGrpID)
        {
            return new OPDBLL().GetClinicalFindingByGroup(cfGrpID);
        }
        public List<ClinicalFindings> GetClinicalFindingByGroupNParent(string cfGrpID, string cfParentID)
        {
            return new OPDBLL().GetClinicalFindingByGroupNParent(cfGrpID, cfParentID);
        }

        public short SaveClinicalFindingsValue(ClinicalFindingsValues cfv)
        {
            return new OPDBLL().SaveClinicalFindingsValue(cfv);
        }

        public List<ClinicalFindingsValues> GetClinicalFindingsValues()
        {
            return new OPDBLL().GetClinicalFindingsValues();
        }

        public List<ClinicalFindingsValues> GetClinicalFindingsValue(string findingsvaltitle)
        {
            return new OPDBLL().GetClinicalFindingsValue(findingsvaltitle);
        }
        public short UpdateClinicalFindingsValue(ClinicalFindingsValues cfv)
        {
            return new OPDBLL().UpdateClinicalFindingsValue(cfv);
        }

        public short SaveCFAssignedValue(ClinicalFindingsValueAssign cfvalA)
        {
            return new OPDBLL().SaveCFAssignedValue(cfvalA);
        }

        public Dictionary<string, string> getCFAssignedValueDict(string cfID)
        {
            return new OPDBLL().getCFAssignedValueDict(cfID);
        }

        public List<ClinicalFindingsValueAssign> getCFAssignedValue(string cfID)
        {
            return new OPDBLL().getCFAssignedValue(cfID);
        }

#endregion ClinicalFindingsNew(09/07/15) 
      

        public short SaveClinicalDiagnosis(ClinicalDiagnosis cl)
        {
            return new OPDBLL().SaveClinicalDiagnosis(cl);
        }

        public short UpdateClinicalDiagnosis(ClinicalDiagnosis cl)
        {
            return new OPDBLL().UpdateClinicalDiagnosis(cl);
        }

        public List<ClinicalDiagnosis> GetClinicalDiagnosis()
        {
            return new OPDBLL().GetClinicalDiagnosis();
        }
        public List<ClinicalDiagnosis> GetClinicalDiagnos(string diagtitle)
        {
            return new OPDBLL().GetClinicalDiagnos(diagtitle);
        }

        //public List<DrugDose> GetMedicineList(string MedicineName)
       // {
         //   return new DrugSetupBLL().GetMedicineList(MedicineName);
       // }
        public List<DrugDose> GetMedicineListOPD(string drugid, string PatAge)
        {
            return new OPDDrugsBLL().GetMedicineListOPD(drugid, PatAge);
        }

        public short SaveComplaint(Complaints com)
        {
            return new OPDBLL().SaveComplaint(com);
        }

        public short UpdateComplaint(Complaints com)
        {
            return new OPDBLL().UpdateComplaint(com);
        }

        public List<Complaints> GetComplaints()
        {
            return new OPDBLL().GetComplaints();
        }
        public List<Complaints> GetComplaints(string comptitle)
        {
            return new OPDBLL().GetComplaints(comptitle);
        }

        public List<PatHistoryTree> GetsTree(string HCN)
        {
            return new OPDBLL().GetsTree(HCN);
        }

        public List<OPDTicketRO> GetOPDTicketDetails(string ParamDateFrom, string ParamDateTo)
        {
            return new OPDReportBLL().GetOPDTicketDetails(ParamDateFrom, ParamDateTo);
        }

        public List<OPDTicketRO> GetOPDDepartment(string DepertmentName, string ParamDateFrom, string ParamDateTo)
        {
            return new OPDReportBLL().GetOPDDepartment(DepertmentName, ParamDateFrom, ParamDateTo);
        }

        public List<OPDTicketRO> GetOPDMRDoctor(string doctorid, string deptid, string ParamDateFrom, string ParamDateTo)
        {
            return new OPDReportBLL().GetOPDMRDoctor(doctorid, deptid, ParamDateFrom, ParamDateTo);
        }

        public List<OPDTicketRO> GetsOPD()
        {
            return new OPDReportBLL().GetsOPD();
        }

        //public List<OPDTicketRO> GetsOPD(string TicketNo)
        //{
        //    return new OPDReportBLL().GetsOPD(TicketNo);
        //}
        public List<Department> GetsDepartmentName()
        {
            return new OPDReportBLL().GetsDepartmentName();
        }

        public List<Doctor> GetDoctorNames()
        {
            return new OPDReportBLL().GetDoctorNames();
        }
        public List<OPDDoctor> InsertDoctorRoom(OPDDoctor oDoctorRoomSetup)
        {
            return new OPDBLL().InsertDoctorRoom(oDoctorRoomSetup);              
        }

        public List<OPDDoctor> GetOPDDoctors()
        {
            return new OPDDoctorsBLL().GetOPDDoctors();            
        }

        public List<OPDDoctor> GetDocRoomNo(string DoctorID)
        {
            return new OPDBLL().GetDocRoomNo(DoctorID);
        }

        public Dictionary<string,string> GetRooms(string type)
        {
            return new PropertySetupBLL().GetRooms(type);
        }
        //public Dictionary<string, string> GetDoctors(string type)
        //{
        //    return new AdministrationSetupBLL().GetDoctors(type);
        //}

       // public List<Department> GetDeptCat(string deptcat)
       // {
       //     return new AdministrationSetupBLL().GetDepartment(deptcat);
       // }

       // public List<Department> GetDeptGroupCode(DeptGroupCode c)
       // {
       //     return new AdministrationSetupBLL().GetDeptGroupCode(deptcat);
      //  }

       //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        public short AdviceSetupInsert(OPDAdvice oAdvice)
        {
            return new OPDBLL().AdviceSetupInsert(oAdvice);
        }
        public short AdviceSetupUpdate(OPDAdvice oAdvice)
        {
            return new OPDBLL().AdviceSetupUpdate(oAdvice);
        }

        public List<OPDAdvice> AdviceSetupGET()
        {
            return new OPDBLL().AdviceSetupGET();
        }

        public List<OPDAdvice> GetAdviceDetails(string adviceID, string deptid)
        {
            return new OPDBLL().GetAdviceDetails(adviceID, deptid);
        }

        //''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public string VerifyTicketNo(string tktno,bool isPrescribed)
        {
            return new OPDBLL().VerifyTicketNo(tktno, isPrescribed);
        }

        public List<OpdAppointment> Appointment(string hcn)
        {
            return new AppointmentBLL().Appointment(hcn);
        }

        public List<DrugDose> GetDrugDoseList(string patage)
        {
            return new DrugsListBLL().GetDrugDoseList(patage);
        }

        public Dictionary<string, string> getConsumptionForm(string type)
        {
            return new DrugSetupBLL().getConsumptionForm(type);
        }

        public Dictionary<string, string> GetNurseStationDic(string type)
        {
            return new NurseStationBLL().GetNurseStationDic(type);
        }
        public List<OPDDoctorCallQ> GetDoctorsList(string nsStnID)
        {
            return new OPDBLL().GetDoctorsList(nsStnID);
        }
        public short UpdateCallQ(OPDDoctorCallQ Q)
        {
            return new OPDBLL().UpdateCallQ(Q);
        }
        public OPDDoctorCallQ GetPatHealthInfo(string Ticket)
        {
            return new OPDBLL().GetPatHealthInfo(Ticket);
        }
        public List<Ticket> GetTicketList(string userID, string date)
        {
            return new OPDBLL().GetTicketList(userID, date);
        }
        public Ticket GetTicketStatusForRefundOrCancel(string ticket)
        {
            return new OPDBLL().GetTicketStatusForRefundOrCancel(ticket);
        }
        public short CancelTicket(string ticketNo, string user_id)
        {
            return new OPDBLL().CancelTicket(ticketNo,user_id);
        }
        public string RefundTicket(Ticket tkt)
        {
            return new OPDBLL().RefundTicket(tkt);
        }
        //public Ticket GetTicketFees(string userID, string date)
        public AccountsPayment GetTicketFees(string userID, string date)
        {
            return new OPDBLL().GetTicketFees(userID, date);
        }

        public short InsertUserCloseRegister(AccountsPayment tktFee)//(Ticket tktFee)
        {
            return new OPDBLL().InsertUserCloseRegister(tktFee);
        }

        public List<OPDTicketRO> GetOPDVoucher(string user_id, string ParamDateFrom, string ParamDateTo)
        //public List<AccountsPayment> GetOPDVoucher(string user_id, string ParamDateFrom, string ParamDateTo)
        {
            return new OPDReportBLL().GetOPDVoucher(user_id, ParamDateFrom, ParamDateTo);
        }

        public List<TestSub> GetTestDets(string deptid, string group, string main)
        {
            return new DiagnosticSetupBLL().GetTestDets(deptid, group, main);
        }

        public List<DrugDose> GetDrugDoseListByDrugName(string patage, string drugname)
        {
            return new DrugsListBLL().GetDrugDoseListByDrugName( patage, drugname);
        }

        public List<TestFee> GetAllMappingTest(string mode,string FeeCatagory)
        {
            return new DiagnosticSetupBLL().GetAllMappingTest(mode,FeeCatagory);
        }

        public Dictionary<string, string> GetFeecats(string type)
        {
            return new DiagnosticSetupBLL().GetFeecats(type);
        }

        public List<DrugDose> GetDrugDoseListByGroupName(string patage, string groupname)
        {
            return new DrugsListBLL().GetDrugDoseListByGroupName(patage, groupname);
        }

        public Prescription GetPrescriptionForEdit(string tkt_no)
        {
            return new OPDBLL().GetPrescriptionForEdit(tkt_no);
        }

        public List<OPDTicketRO> GetOPDCollSummary(string ParamDateFrom, string ParamDateTo)
        {
            return new OPDReportBLL().GetOPDCollSummary(ParamDateFrom, ParamDateTo);
        }

        public List<OPDTicketRO> GetOPDVisitedPatList(string dept_id, string unit_id, string doc_id)
        {
            return new OPDReportBLL().GetOPDVisitedPatList(dept_id, unit_id, doc_id);
        }
        public short ChangeTktStatusFrmDoc(string ticketNo, string DocID)
        {
            return new OPDReportBLL().ChangeTktStatusFrmDoc(ticketNo, DocID);
        }
        public List<OPDPrescriptionReportNewRO> GetOPDPatTree(string HCN)
        {
            return new OPDBLL().GetOPDPatTree(HCN);
        }
       
    }
}