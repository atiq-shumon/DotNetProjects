using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.Shared.MODEL;
using AH.IPDShared.BLL;
using AH.IPDShared.MODEL;
using AH.DRUGS.BLL;
using AH.DRUGS.MODEL;
using AH.OPD.BLL;
using AH.DTMS.BLL;
using AH.DTMS.MODEL;
using AH.PRMS.BLL;
using AH.PRMS.MODEL;
using AH.PHRMS.BLL;
using AH.PHRMS.MODEL;
using AH.NWMS.BLL;
using AH.NWMS.MODEL;
using AH.OPD.MODEL;
using AH.HR.BLL;
using AH.HR.MODEL;
using AH.ORGMS.BLL;
using AH.INVMS.MODEL;
using AH.INVMS.BLL;

namespace AH.NWMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NWMSWS" in both code and config file together.
    public class NWMSWS : INWMSWS
    {
        //public string VerifyInPatient(string Regno)
        //{
        //    return new IPDBLL().VerifyInPatient(Regno);
        //}

        //public  Patient GetPatreg(string Regno)
        //{
        //    return new IPDBLL().GetPatreg(Regno);
        //}

        //public List<DrugDose> GetMedicineListOPD(string drugid, string PatAge)
        //{
        //    return new OPDDrugsBLL().GetMedicineListOPD(drugid, PatAge);
        //}

        public IPDDoctor GetDoctorsDetails(string DocID)
        {
            return new IPDSharedBLL().GetDoctorsDetails(DocID);
        }

        public List<DrugDose> GetDrugs(string age, string name, string drugID)
        {
            return new NWMSBLL().GetDrugs(age, name, drugID);
        }

        public Dictionary<string, string> GetDeptGroupDicByType(string type)
        {
            return new AdministrationSetupBLL().GetDeptGroupDicByType(type);
        }

        public Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr)
        {
            return new OPDBLL().GetDepartmentsetupDic(type, deptgr);
        }

        public Dictionary<string, string> GetDeptUnitDic(string deptgrp, string deptid)
        {
            return new OPDBLL().GetDeptUnitDic(deptgrp, deptid);
        }

        public Dictionary<string, string> GetOPDDoctorsDict(string deptID, string UnitID)
        {
            return new OPDBLL().GetOPDDoctorsDict(deptID, UnitID);
        }

        public string GetDrRoom(string DocID)
        {
            return new OPDBLL().GetDrRoom(DocID);
        } 

        public Dictionary<string, string> GetDiagnGrp(string type, string department)
        {
            return new DiagnosticSetupBLL().GetDiagnGrp(type, department);
        }

        public List<TestMain> GetTestMain(string department, string group)
        {
            return new OPDBLL().GetTestMain(department, group);
        }

        public List<TestSub> GetTestDetails(string deptid, string group, string main)
        {
            return new OPDBLL().GetTestDetails(deptid, group, main);
        }
        public short AdviceSetupInsert(OPDAdvice oAdvice)
        {
            return new OPDBLL().AdviceSetupInsert(oAdvice);
        }
        public List<DrugDose> GetMedicineListOPD(string drugid, string PatAge)
        {
            return new OPDDrugsBLL().GetMedicineListOPD(drugid, PatAge);
        }

        public List<DrugDose> GetDrugDoseList(string patage)
        {
            return new DrugsListBLL().GetDrugDoseList(patage);
        }

        public InPatient GetAdmittedPatient(string RegistrationNo)
        {
           return new IPDSharedBLL().GetAdmittedPatient(RegistrationNo);
        }

        public short SaveNurseRequisition(NurseRequisition nrq)
        {
            return new NWMSBLL().SaveNurseRequisition(nrq);
        }
        public string VerifyInPatient(string regNo)
        {
            return new IPDSharedBLL().VerifyInPatient(regNo);
        }

        public List<DrugDose> GetDrugDoseListForAll()
        {
            return new DrugsListBLL().GetDrugDoseListForAll();
        }

        public InPatient GetPatRegID(string bedID)
        {
            return new IPDSharedBLL().GetPatRegID(bedID);
        }

        public short ChangeBedStatus(Bed bdst)
        {
            return new NWMSBLL().ChangeBedStatus(bdst);
        }

        public List<NWMSReceiveRequisition> ReceiveRequisition(string regId)
        {
            return new NWMSBLL().ReceiveRequisition(regId);
        }

        public List<NWMSReceiveRequisition> ReceiveReqTest(string regId)
        {
            return new NWMSBLL().ReceiveReqTest(regId);
        }

        public short SaveDrugReqRcv(NWMSReceiveRequisition DrugRcv)
        {
            return new NWMSBLL().SaveDrugReqRcv(DrugRcv);
        }

        public List<TestSub> GetTestDets(string deptid, string group, string main)
        {
            return new DiagnosticSetupBLL().GetTestDets(deptid, group, main);
        }

        public short CheckIssueIDforRcv(string issue_id)
        {
            return new NWMSBLL().CheckIssueIDforRcv(issue_id);
        }
        public short VerifyIssueID(string issue_id, string Reg_id)
        {
            return new NWMSBLL().VerifyIssueID(issue_id, Reg_id);
        }

        public List<DrugIssue> GetIssueDetails(string issueID)
        {
            return new DrugIssueBLL().GetIssueDetails(issueID);
        }

      /*  public OPDDoctorCallQ GetPatHealthInfo(string Hcn)
        {
            return new NWMSBLL().GetPatHealthInfo(Hcn);
        }*/

        public short SaveIPDPrescription(IPDPrescription prs)
        {
            return new IPDPrescriptionBLL().SaveIPDPrescription(prs);
        }
        public short EditIPDPrescription(IPDPrescription Iprs)
        {
            return new IPDPrescriptionBLL().EditIPDPrescription(Iprs);
        }

        public List<Complaints> GetComplaints()
        {
            return new OPDBLL().GetComplaints();
        }

        public List<ClinicalDiagnosis> GetClinicalDiagnosis()
        {
            return new OPDBLL().GetClinicalDiagnosis();
        }

        public Dictionary<string, string> getConsumptionForm(string type)
        {
            return new DrugSetupBLL().getConsumptionForm(type);
        }

        public List<DrugDose> GetDrugDoseByDrugIPD(string patage, string drugname)
        {
            return new DrugsListBLL().GetDrugDoseByDrugIPD(patage, drugname);
        }
        public List<DrugDose> GetDrugDoseByGroupNameIPD(string patage, string groupname)
        {
            return new DrugsListBLL().GetDrugDoseByGroupNameIPD(patage, groupname);
        }
        public List<DrugDose> GetDrugDoseListByDrugName(string patage, string drugname)
        {
            return new DrugsListBLL().GetDrugDoseListByDrugName(patage, drugname);
        }
        public List<DrugDose> GetDrugDoseListByGroupName(string patage, string groupname)
        {
            return new DrugsListBLL().GetDrugDoseListByGroupName(patage, groupname);
        }

        public List<OPDAdvice> AdviceSetupGET()
        {
            return new OPDBLL().AdviceSetupGET();
        }

        public List<IPDPrescription> GetPrescribedDrugs(string regId)
        {
            return new IPDPrescriptionBLL().GetPrescribedDrugs(regId);
        }

        public List<IPDPrescription> GetPrescribedTests(string regId)
        {
            return new IPDPrescriptionBLL().GetPrescribedTests(regId);
        }

        public List<TestFee> GetAllMappingTest(string mode,string FeeCatagory)
        {
            return new DiagnosticSetupBLL().GetAllMappingTest(mode,FeeCatagory);
        }

        public Dictionary<string, string> GetFeecats(string type)
        {
            return new DiagnosticSetupBLL().GetFeecats(type);
        }

        public short InsertIPDDoctors(IPDDoctor oIPDDOc)
        {
            return new IPDSharedBLL().InsertIPDDoctors(oIPDDOc);
        }

        public Dictionary<string, string> GetOPDDoctorDict(string DeptID, string UnitID)
        {
            return new EmployeeSpecializationSetupBLL().GetEmpDic(DeptID, UnitID);
        }

        public List<IPDDoctor> GetIPDDoctorsList()
        {
            return new IPDSharedBLL().GetIPDDoctorsList();
        }

        public List<IPDDoctor> GetIPDVisitingFeeDetails(string reg_ID)
        {
            return new IPDSharedBLL().GetIPDVisitingFeeDetails(reg_ID);
        }

        public short CancelIPDDrugs(NurseRequisition nrq)
        {
            return new NWMSBLL().CancelIPDDrugs(nrq);
        }

        public short SaveDischargeAdvices(IPDPrescription prs)
        {
            return new IPDPrescriptionBLL().SaveDischargeAdvices(prs);
        }

        public Dictionary<string, string> GetIPDDoctorsDict(string deptID, string UnitID)
        {
            return new IPDSharedBLL().GetIPDDoctorsDict(deptID, UnitID);
        }

        public List<DrugDose> GetAllProvidedDrugs(string regID)
        {
            return new NWMSBLL().GetAllProvidedDrugs(regID);
        }

        public short IsDischargeAdvCreated(string regId)
        {
            return new IPDPrescriptionBLL().IsDischargeAdvCreated(regId);
        }
        public IPDPrescription GetDischargeAdvicesForEdit(string regId)
        {
            return new IPDPrescriptionBLL().GetDischargeAdvicesForEdit(regId);
        }

        public short EditDischargeAdvices(IPDPrescription Iprs)
        {
            return new IPDPrescriptionBLL().EditDischargeAdvices(Iprs);
        }

        public List<GroupDetails> GetGroupByMajorGrp(string strtype, string majorgrp)
        {
            return new InventorySetupBLL().GetGroupByMajorGrp(strtype, majorgrp);
        }

      //  public List<ItemMaster> GetItemMasterByGroup(string grpid)
      //  {
      //      return new InventorySetupBLL().GetItemMasterByGroup(grpid);
      //  }

      //  public List<ItemMaster> GetItemStockForNS(string grpid, string strid)
      //  {
      //      return new InventorySetupBLL().GetItemStockForNS(grpid, strid);
      //  }

        public List<ItemOrder> GetItemStockForNS(string grpid, string strid)
        {
            return new InventorySetupBLL().GetItemStockForNS(grpid, strid);
        }


        public short IssueFromNurseStn(NurseRequisition nrq)
        {
            return new NWMSBLL().IssueFromNurseStn(nrq);
        }

        public IPDPrescription GetIPDPrescriptionForEdit(string visit_no, string Reg_ID)
        {
            return new IPDPrescriptionBLL().GetIPDPrescriptionForEdit(visit_no, Reg_ID);
        }

        public short IsDrugReqDone(string visit_id, string drug_id)
        {
            return new IPDPrescriptionBLL().IsDrugReqDone(visit_id, drug_id);
        }

#region Report
        public List<NWMSReportRO> GetDischargeSummary(string reg_ID)
        {
            return new NwmsReportBLL().GetDischargeSummary(reg_ID);
        }
        public List<NWMSReportRO> DischargeAdvice(string reg_ID)
        {
            return new NwmsReportBLL().DischargeAdvice(reg_ID);
        }

#endregion Report
    }
}
