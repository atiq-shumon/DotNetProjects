using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.DRUGS.MODEL;
using AH.OPD.BLL;
using AH.DTMS.MODEL;
using AH.PRMS.BLL;
using AH.PRMS.MODEL;
using AH.PHRMS.BLL;
using AH.PHRMS.MODEL;
using AH.IPDShared.MODEL;
using AH.IPDShared.BLL;
using AH.NWMS.MODEL;
using AH.OPD.MODEL;
using AH.INVMS.MODEL;
using AH.INVMS.BLL;

namespace AH.NWMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INWMSWS" in both code and config file together.
    [ServiceContract]
    public interface INWMSWS
    {

    //    [OperationContract]
    //    string VerifyInPatient(string Regno);
    //    [OperationContract]
    //    Patient GetPatreg(string Regno);
    //    [OperationContract]
    //    List<DrugDose> GetMedicineListOPD(string MedicineName, string PatAge); 

        [OperationContract]
        IPDDoctor GetDoctorsDetails(string DocID);

        [OperationContract]
        List<DrugDose> GetDrugs(string age, string name, string drugID);

        //[OperationContract(Name = "GetDeptGroupWise")]
        //Dictionary<string, string> GetDepartmentsetup(string type, string deptgr);

        [OperationContract(Name = "GetDiagnGrpDeptWise")]
        Dictionary<string, string> GetDiagnGrp(string type, string department);

        [OperationContract]
        Dictionary<string, string> GetDeptUnitDic(string deptgrp, string deptid);

        [OperationContract]
        Dictionary<string, string> GetOPDDoctorsDict(string deptID, string UnitID);

        [OperationContract]
        string GetDrRoom(string DocID);

        [OperationContract]
        List<TestMain> GetTestMain(string department, string group);

        [OperationContract]
        List<TestSub> GetTestDetails(string deptid, string group, string main);

        [OperationContract]
        List<DrugDose> GetMedicineListOPD(string MedicineName, string PatAge);

        [OperationContract]
        List<DrugDose> GetDrugDoseList(string patage);

        [OperationContract]
        InPatient GetAdmittedPatient(string RegistrationNo);

        [OperationContract]
        short SaveNurseRequisition(NurseRequisition nrq);

        [OperationContract]
        string VerifyInPatient(string regNo);

        [OperationContract]
        List<DrugDose> GetDrugDoseListForAll();

        [OperationContract]
        InPatient GetPatRegID(string bedID);

        [OperationContract]
        short ChangeBedStatus(Bed bdst);

        [OperationContract]
        List<NWMSReceiveRequisition> ReceiveRequisition(string regId);
        [OperationContract]
        List<NWMSReceiveRequisition> ReceiveReqTest(string regId);

        [OperationContract]
        short SaveDrugReqRcv(NWMSReceiveRequisition DrugRcv);

        [OperationContract]
        List<TestSub> GetTestDets(string deptid, string group, string main);

        [OperationContract]
        List<DrugIssue> GetIssueDetails(string issueID);

        [OperationContract]
        short CheckIssueIDforRcv(string issue_id);
        [OperationContract]
        short VerifyIssueID(string issue_id, string Reg_id);

        [OperationContract]
        Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr);

       /* [OperationContract]
        OPDDoctorCallQ GetPatHealthInfo(string Hcn);*/
        [OperationContract]
        short AdviceSetupInsert(OPDAdvice oAdvice);
        [OperationContract]
        short SaveIPDPrescription(IPDPrescription prs);
        [OperationContract]
        short EditIPDPrescription(IPDPrescription Iprs);

        [OperationContract]
        List<Complaints> GetComplaints();

        [OperationContract]
        List<ClinicalDiagnosis> GetClinicalDiagnosis();

        [OperationContract]
        Dictionary<string, string> getConsumptionForm(string type);

        [OperationContract]
        List<DrugDose> GetDrugDoseByDrugIPD(string patage, string drugname);
        [OperationContract]
        List<DrugDose> GetDrugDoseByGroupNameIPD(string patage, string groupname);


        [OperationContract]
        List<DrugDose> GetDrugDoseListByDrugName(string patage, string groupname);

        [OperationContract]
        List<DrugDose> GetDrugDoseListByGroupName(string patage, string groupname);

        [OperationContract]
        List<OPDAdvice> AdviceSetupGET();

        [OperationContract]
        List<IPDPrescription> GetPrescribedDrugs(string regId);

        [OperationContract]
        List<IPDPrescription> GetPrescribedTests(string regId);

        [OperationContract]
        List<TestFee> GetAllMappingTest(string mode, string FeeCatagory);

        [OperationContract(Name = "GetFeecatDict")]
        Dictionary<string, string> GetFeecats(string type);
        [OperationContract]
        List<DrugDose> GetAllProvidedDrugs(string regID);

        [OperationContract]
        short InsertIPDDoctors(IPDDoctor oIPDDOc);

        [OperationContract]
        Dictionary<string, string> GetDeptGroupDicByType(string type);

        [OperationContract]
        Dictionary<string, string> GetOPDDoctorDict(string DeptID, string UnitID);

        [OperationContract]
        List<IPDDoctor> GetIPDDoctorsList();
        
        [OperationContract]
        List<IPDDoctor> GetIPDVisitingFeeDetails(string reg_ID);
       
        [OperationContract]
        short CancelIPDDrugs(NurseRequisition nrq);
        [OperationContract]

        short SaveDischargeAdvices(IPDPrescription prs);

        [OperationContract]
        Dictionary<string, string> GetIPDDoctorsDict(string deptID, string UnitID);

        [OperationContract]
        short IsDischargeAdvCreated(string regId);
        [OperationContract]
        IPDPrescription GetDischargeAdvicesForEdit(string regId);
        [OperationContract]
        short EditDischargeAdvices(IPDPrescription Iprs);

        [OperationContract]
        List<GroupDetails> GetGroupByMajorGrp(string strtype, string majorgrp);
       // [OperationContract]
       // List<ItemMaster> GetItemMasterByGroup(string grpid);
       // [OperationContract]
       // List<ItemMaster> GetItemStockForNS(string strid, string grpid);
        [OperationContract]
        List<ItemOrder> GetItemStockForNS(string grpid, string strid);

        [OperationContract]
        short IssueFromNurseStn(NurseRequisition nrq);

        [OperationContract]
        IPDPrescription GetIPDPrescriptionForEdit(string visit_no, string Reg_ID);

        [OperationContract]
        short IsDrugReqDone(string visit_id, string drug_id);

#region Report
        [OperationContract]
        List<NWMSReportRO> GetDischargeSummary(string reg_ID);

        [OperationContract]
        List<NWMSReportRO> DischargeAdvice(string reg_ID);

     
#endregion Report
    }
}
