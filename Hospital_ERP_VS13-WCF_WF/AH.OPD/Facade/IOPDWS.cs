using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.DUtility;
using AH.HR.MODEL;
using AH.OPD.MODEL;
using AH.DTMS.MODEL;
using AH.Shared.MODEL;
using AH.DRUGS.MODEL;
using AH.PRMS.BLL;
using AH.PRMS.MODEL;
using AH.APPOPD.MODEL;

namespace AH.OPD.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOPDWS_" in both code and config file together.
    [ServiceContract]
    public interface IOPDWS
    {
        [OperationContract]
        Dictionary<string, string> GetOPDDoctorDict(string DeptID, string UnitID);

        //[OperationContract]
        //List<OPDDoctor> GetOPDDoctors(string DeptID, string UnitID);
        [OperationContract]
        Dictionary<string, string> GetOPDDoctorsDict(string deptID, string UnitID);

        [OperationContract]
        Dictionary<string, string> GetOPDRoomsDict(string BuildingID, string RmType);

        //Fauzul 20 Aug 2014
        [OperationContract]
        List<OPDNurseRoomAllRO> GetNurseRoomRO();
        [OperationContract]
        List<OPDDrRoomAllRO> GetDocRoomAllRO();
        //10 Aug 2014 Fauzul
        [OperationContract]
        List<Room> GETs_Room_No(string RoomGrp); 
        //Fauzul 05 Aug 2014
        [OperationContract]
        List<Ticket> GetPatDoc(string docid);
        //Fauzul 04 Aug 2014
        
        //[OperationContract]
        //List<OPDDoctor> GetOPDDoctors(string DeptID, string UnitID);
       
        [OperationContract]
        List<OPDDoctorCallQ> InsDrRoom(string NID); 
        //02 Aug 2014 Fauzul
        [OperationContract]
        List<Room> test(); 
        [OperationContract]
        short InsertRoomGroup(OPDRoomGrpAssign oRoom);
        [OperationContract(Name = "GetRoomGroupByID")]
        List<OPDRoomGrpAssign> GetRoomGroup(string RoomGrp);
        [OperationContract]
        List<OPDRoomGrpAssign> GetRoomGroup();
  
        [OperationContract]
        List<Room> UpdateRoomGroup(Room oRoom);
        [OperationContract]
        Dictionary<string, string> GetNurses(string type);   
       // [OperationContract]
        //Dictionary<string, string> GetDepartments(string type);
        [OperationContract]
        Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr);
        //[OperationContract]
        //Dictionary<string, string> GetUnits();
        [OperationContract]
        Dictionary<string, string> GetDoctors(string dept, string unit);
        //[OperationContract]
        //Dictionary<string, string> GetCases();
        [OperationContract]
        Dictionary<string, string> GetPrescriptionTypes();
        [OperationContract]
        Age CalculateAge(DateTime dob);
        [OperationContract]
        string VerifyPatientNo(string patNo);
        [OperationContract]
        Patient GetPatient(string pId);
        [OperationContract]
        string SaveOPDTicket(Ticket tkt);

        [OperationContract]
        List<RptTicket> GetTickets(string patientHCN, string ticketNO);

        [OperationContract]
        string VerifyTicketNo(string tktno, bool isPrescribed);

        [OperationContract]
        List<DiseaseCase> GetDiseaseCase();

        [OperationContract]
        short SaveDisease(DiseaseCase tDept);
        [OperationContract]
        short UpdateDisease(DiseaseCase tDept);
        [OperationContract(Name = "GetDiseaseDict")]
        Dictionary<string, string> GetDiseaseCase(string type);
        [OperationContract(Name = "GetUnitDict")]
        Dictionary<string, string> GetUnitDict(string Dept);

        [OperationContract(Name = "GetDoctorDict")]
        Dictionary<string, string> GetDoctors(string type);
        [OperationContract]
        Dictionary<string, string> GetDeptUnitDic(string deptgrp, string deptid);
        //Dictionary<string, string> GetDeptUnitAssigned(string type, string deptid);
        [OperationContract(Name = "GetDeptUnitWiseDoc")]
        Dictionary<string, string> GetDoctorSetup(string type, string deptid, string unitid);
        //[OperationContract]
        //List<TestGroup> GetDiagnGrp(string department);
        [OperationContract(Name = "GetDiagnGrpDeptWise")]
        Dictionary<string, string> GetDiagnGrp(string type, string department);
        [OperationContract]
        List<TestMain> GetTestMain(string department, string group);
        [OperationContract(Name = "GetMainDict")]
        Dictionary<string, string> GetTestMain(string type);
        [OperationContract]
        List<TestSub> GetTestDetails(string deptid, string group, string main);
        //[OperationContract(Name = "GetTestDetailsWise")]
        //Dictionary<string, string> GetTestDetails(string type, string deptid, string group, string main);
        [OperationContract(Name = "GetMainDeptwise")]
        Dictionary<string, string> GetTestMain(string type, string department, string group);

        [OperationContract]
        Ticket GetTicket(string prescriptionTicketNO);
       

        [OperationContract(Name = "GetDeptWiseDoc")]
        Dictionary<string, string> GetDoctorByDept(string type, string deptid);
        //----------------------Save Prescription-----------------------

        [OperationContract]
        string SavePrescription(Prescription prs);
        [OperationContract]
        string EditPrescription(Prescription prs);

        //--------------------------------------------------------------

        [OperationContract(Name = "GetPrescriptionType")]
        Dictionary<string, string> GetPrescriptionTypes(string type);
        [OperationContract]
        List<OPDPrescriptionReportNewRO> GetOPDPrescription(string whereCondition);
        [OperationContract]
        List<OPDTicketRO> GetOPDTicketMR(string WhereCondition);
        [OperationContract]
        List<Ticket> GetPrescriptionList(string docid);
        

#region ClinicalFindingsNew(09/07/15)
        [OperationContract]
        short SaveClinicalFindingsGrp(ClinicalFindingsGroup cfGrp);
        [OperationContract]
        short UpdateClinicalFindingsGrp(ClinicalFindingsGroup cfGrp);
        [OperationContract]
        List<ClinicalFindingsGroup> GetClinicalFindingsGroups();
        [OperationContract]
        List<ClinicalFindingsGroup> GetClinicalFindingsGroup(string cfGrpTitle);
        [OperationContract]
        Dictionary<string, string> GetClinicalFindingsGroupDict(string type);

        [OperationContract]
        Dictionary<string, string> GetClinicalFindingsDict(string type);
        [OperationContract]
        short SaveClinicalFindings(ClinicalFindings cf);
        [OperationContract]
        List<ClinicalFindings> GetCfTree();
        [OperationContract]
        short UpdateClinicalFindings(ClinicalFindings cf);
        [OperationContract]
        List<ClinicalFindings> GetClinicalFindings();
        [OperationContract]
        List<ClinicalFindings> GetClinicalFinding(string cfTitle);
        [OperationContract]
        List<ClinicalFindings> GetClinicalFindingByGroup(string cfGrpID);
        [OperationContract]
        List<ClinicalFindings> GetClinicalFindingByGroupNParent(string cfGrpID, string cfParentID);
 
        [OperationContract]
        short SaveClinicalFindingsValue(ClinicalFindingsValues cfv);
        [OperationContract]
        List<ClinicalFindingsValues> GetClinicalFindingsValues();
        [OperationContract]
        List<ClinicalFindingsValues> GetClinicalFindingsValue(string findingsvaltitle);
        [OperationContract]
        short UpdateClinicalFindingsValue(ClinicalFindingsValues cfv);
        [OperationContract]
        short SaveCFAssignedValue(ClinicalFindingsValueAssign cfvalA);
        [OperationContract]
        Dictionary<string, string> getCFAssignedValueDict(string cfID);
        [OperationContract]
        List<ClinicalFindingsValueAssign> getCFAssignedValue(string cfID);


#endregion ClinicalFindingsNew(09/07/15) 

        [OperationContract]
        short SaveClinicalDiagnosis(ClinicalDiagnosis cl);
        [OperationContract]
        short UpdateClinicalDiagnosis(ClinicalDiagnosis cl);
        [OperationContract]
        List<ClinicalDiagnosis> GetClinicalDiagnosis();
        [OperationContract]
        List<ClinicalDiagnosis> GetClinicalDiagnos(string diagtitle);
        //[OperationContract]
        //List<DrugDose> GetMedicineList(string MedicineName);
        [OperationContract]
        List<DrugDose> GetMedicineListOPD(string MedicineName, string PatAge);
        [OperationContract]
        short SaveComplaint(Complaints com);
        [OperationContract]
        short UpdateComplaint(Complaints com);
        [OperationContract]
        List<Complaints> GetComplaints();
        [OperationContract(Name = "GetComplaintsUsingLike")]
        List<Complaints> GetComplaints(string comptitle);
        [OperationContract]
        List<PatHistoryTree> GetsTree(string HCN);
        [OperationContract]
        List<OPDTicketRO> GetOPDTicketDetails(string ParamDateFrom, string ParamDateTo);
        [OperationContract]
        List<OPDTicketRO> GetOPDDepartment(string DepertmentName, string ParamDateFrom, string ParamDateTo);
        [OperationContract]
        List<OPDTicketRO> GetOPDMRDoctor(string doctorid, string deptid, string ParamDateFrom, string ParamDateTo);
        [OperationContract]
        List<OPDTicketRO> GetsOPD();
        //[OperationContract]
        //List<OPDTicketRO> GetsOPD(string TicketNo);
        [OperationContract]
        List<Department> GetsDepartmentName();
        [OperationContract]
        List<Doctor> GetDoctorNames();
        //Fauzul 28 Jun 2014
        [OperationContract]
        OPDDoctorCall InsUpdDocCall(OPDDoctorCall oOPDDoctorCall);
        //Fauzul 28 Jun 2014
        [OperationContract]
        List<OPDDoctorCallQ> GetsOPDDoctorName();
        //Fauzul 28 Jun 2014
        [OperationContract]
        List<OPDTicketRO> GetsOPDDocRoomNo(string RoomNo, string DocID);
        //Fauzul 28 Jun 2014
        [OperationContract]
        List<OPDTicketRO> ChangePatientStatus(string TickNo, string RoomNo, string Doc_ID);
        [OperationContract]
        List<OPDDoctor> InsertDoctorRoom(OPDDoctor oDoctorRoomSetup);
        [OperationContract]
        Dictionary<string, string> GetRooms(string type);
       
        [OperationContract]
        List<OPDDoctor> GetOPDDoctors();
        
        [OperationContract]
        List<OPDDoctor> GetDocRoomNo(string DoctorID);
        [OperationContract]
        List<OPDNurseRoomAllocation> GetNurseRoom();
        [OperationContract]
        List<OPDNurseRoomAllocation> InsertNurseRoom(OPDNurseRoomAllocation oOPDNurseRoomAllocation);
        //Fauzul 9 Jul 2014
        [OperationContract]
        string ChkPatOldNew(string DocID, string p_hcn);
        //Fauzul 16 Jul 2014
        [OperationContract]
        string GetDrRoom(string DocID);

       // [OperationContract]
       // List<Department> GetDeptCat(string deptcat);

        // [OperationContract]
        // List<Department> GetDeptCat(string deptcat);

        //[OperationContract]
        //Dictionary<string, string> GetDeptCatagory(string t);
       
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        [OperationContract]
        short AdviceSetupInsert(OPDAdvice oAdvice);
        [OperationContract]
        short AdviceSetupUpdate(OPDAdvice oAdvice);
        [OperationContract]
        List<OPDAdvice> AdviceSetupGET();

        [OperationContract]
        List<OPDAdvice> GetAdviceDetails(string adviceID, string deptid);

        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        [OperationContract]
        List<OpdAppointment> Appointment(string hcn);

        [OperationContract]
        List<DrugDose> GetDrugDoseList(string patage);

        [OperationContract]
        Dictionary<string, string> getConsumptionForm(string type);

        [OperationContract]
        Dictionary<string, string> GetNurseStationDic(string type);

        [OperationContract]
        List<OPDDoctorCallQ> GetDoctorsList(string nsStnID);

        [OperationContract]
        short UpdateCallQ(OPDDoctorCallQ Q);

        [OperationContract]
        OPDDoctorCallQ GetPatHealthInfo(string Ticket);

        [OperationContract]
        List<DiseaseCase> getDiseaseGroup();


        [OperationContract]
        Dictionary<string, string> getDiseaseGroupDic(string type);

        [OperationContract]
        List<Ticket> GetTicketList(string userID, string date);

        [OperationContract]
        Ticket GetTicketStatusForRefundOrCancel(string ticket);

        [OperationContract]
        short CancelTicket(string ticketNo, string user_id);
        [OperationContract]
        string RefundTicket(Ticket tkt);

        [OperationContract]
        // Ticket GetTicketFees(string userID, string date);
        AccountsPayment GetTicketFees(string userID, string date);

        [OperationContract]
        short InsertUserCloseRegister(AccountsPayment tktFee);//(Ticket tktFee);

        [OperationContract]
        List<OPDTicketRO> GetOPDRefundTicketMR(string TicketNo);

        [OperationContract]
        List<OPDTicketRO> GetOPDVoucher(string user_id, string ParamDateFrom, string ParamDateTo);
       // List<AccountsPayment> GetOPDVoucher(string user_id, string ParamDateFrom, string ParamDateTo);

        [OperationContract]
        List<TestSub> GetTestDets(string deptid, string group, string main);

        [OperationContract]
        List<DrugDose> GetDrugDoseListByDrugName(string patage, string drugname);

        [OperationContract]
        List<TestFee> GetAllMappingTest(string mode,string FeeCatagory);

        [OperationContract]
        List<DrugDose> GetDrugDoseListByGroupName(string patage, string groupname);

        [OperationContract(Name = "GetFeecatDict")]
        Dictionary<string, string> GetFeecats(string type);

        [OperationContract]
        Prescription GetPrescriptionForEdit(string tkt_no);

        [OperationContract]
        List<OPDTicketRO> GetOPDCollSummary(string ParamDateFrom, string ParamDateTo);

        [OperationContract]
        List<OPDTicketRO> GetOPDVisitedPatList(string dept_id, string unit_id, string doc_id);

        [OperationContract]
        short ChangeTktStatusFrmDoc(string ticketNo, string DocID);

        [OperationContract]
        List<OPDPrescriptionReportNewRO> GetOPDPatTree(string HCN);
        //[OperationContract]
        //[OperationContract]
        //[OperationContract]
    }
}


