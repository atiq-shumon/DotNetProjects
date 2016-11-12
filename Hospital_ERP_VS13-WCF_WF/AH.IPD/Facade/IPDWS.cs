using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.IPD.BLL;
using AH.HR.BLL;
using AH.PRMS.BLL;
using AH.PRMS.MODEL;
using AH.IPD.MODEL;
using AH.Shared.MODEL;
using AH.PatReg.MODEL;
using AH.IPDShared.MODEL;
using AH.PatReg.BLL;
using AH.ORGMS.BLL;
using AH.OPD.BLL;
using AH.IPDShared.BLL;
using AH.ACCMS.BLL;
using AH.PHRMS.MODEL;
using AH.PHRMS.BLL;
using AH.DTMS.MODEL;
using AH.DMS.BLL;
using AH.OPRMS.MODEL;
using AH.OPRMS.BLL;
//using AH.NWMS.MODEL;
//using AH.NWMS.BLL;
using AH.DMS.MODEL;
using AH.INVMS.MODEL;



namespace AH.IPD.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IPDWS" in both code and config file together.
    public class IPDWS : IIPDWS
    {
        /*******************IPDSetupBLL**********************/

        public short SaveDeliveryType(DeliveryType tipd)
        {
            return new IPDSetupBLL().SaveDeliveryType(tipd);
        }
        public short UpdateDelType(DeliveryType uipd)
        {
            return new IPDSetupBLL().UpdateDelType (uipd);
        }
      
        public List<DeliveryType> GetDeliveryType()
        {
            return new IPDSetupBLL().GetDeliveryType();
        }
        public int VerifyDelivery(string delid)
         {
             return new IPDSetupBLL().VerifyDelivery(delid);
         }
      
        public short SaveAdmissionReason(AdmissionReason admr)
        {
            return new IPDSetupBLL().SaveAdmissionReason(admr);
        }
        public short UpdateAdmissionReason(AdmissionReason admr)
        {
            return new IPDSetupBLL().UpdateAdmissionReason(admr);
        }
        public List<AdmissionReason> GetAdmReason()
        {
            return new IPDSetupBLL().GetAdmReason();
        }
        public Dictionary<string, string> GetAdmReason(string type)
        {
            return new IPDSetupBLL().GetAdmReason(type);
        }
        public short SaveAdmReasonAss(AdmReasonAssign admass)
        {
            return new IPDSetupBLL().SaveAdmReasonAss(admass);
        }
        public List<AdmReasonAssign> GetAdmReasonAss()
        {
            return new IPDSetupBLL().GetAdmReasonAss();
        }
        public List<AdmReasonAssign> GetAdmReasonAss(string departmentID)
        {
            return new IPDSetupBLL().GetAdmReasonAss(departmentID);
        }
        public Dictionary<string, string> GetAdmReason(string type, string departmentID)
        {
            return new IPDSetupBLL().GetAdmReason(type, departmentID);
        }
        public int GetMinStayingDays(string admReason)
        {
            return new IPDSetupBLL().GetMinStayingDays(admReason);
        }
        public Dictionary<string, string> GetDeptUnitDic(string deptgrp, string deptid)
        {
            return new IPDSetupBLL().GetDeptUnitDic(deptgrp, deptid);
        }

        /******************IPDBLL********************************/

        public string saveAdmission(InPatient adm)
        {
            return new IPDBLL().saveAdmission(adm);
        }
        public InPatient GetAdmittedPatient(string RegistrationNo)
        {
            return new IPDSharedBLL().GetAdmittedPatient(RegistrationNo);
        }
        public List<OPDPayment> GetAdvPay(string regno)
        {
            return new IPDBLL().GetAdvPay(regno);
        }
        public string SaveAdvanpay(InPatient adv)
        {
            return new IPDBLL().SaveAdvanpay(adv);
        }
        public string SaveBedTransfer(InPatient trans)
        {
            return new IPDBLL().SaveBedTransfer(trans);
        }
        public double GetTotalAmount(string RegistrationNo)
        {
            return new IPDBLL().GetTotalAmount(RegistrationNo);
        }
        public string SaveDeptTransfer(InPatient tradept)
        {
            return new IPDBLL().SaveDeptTransfer(tradept);
        }
        public List<InPatient> GetBedHist(string regno)
        {
            return new IPDBLL().GetBedHist(regno);
        }
        public List<InPatient> GetDeptHistory(string regno)
        {
            return new IPDBLL().GetDeptHistory(regno);
        }
        public string VerifyInPatient(string regNo)
        {
            return new IPDSharedBLL().VerifyInPatient(regNo);
        }
        public List<RevenueHead> GetDepartmentRevenue(string regno)
        {
            return new IPDBLL().GetDepartmentRevenue(regno);
        }

       // Reff's
       
        public Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr)
        {
            return new AdministrationSetupBLL().GetDepartmentsetupDic(type, deptgr);
        }
      
        public Dictionary<string, string> GetWards(string type)
        {
            return new PropertySetupBLL().GetWards(type);
        } 

        //=======================================Reff: PRMS=====================================//

        public List<Bed> GetLevelWiseBeds(string nstn, string level_no)
        {
            return new PropertySetupBLL().GetLevelWiseBeds(nstn,level_no);
        }
        public List<Bed> GetNurseBeds(string nsstn, string level)
        {
            return new PropertySetupBLL().GetNurseBeds(nsstn, level);
        }

        public List<Bed> GetBedSets(string bedtype, string bedstatus)
        {
            return new PropertySetupBLL().GetBedSets(bedtype, bedstatus);
        }
         //
       public Dictionary<string, string> GetNurse(string type)
       {
           return new EmployeeSpecializationSetupBLL().GetNurse(type);
       }


       // reff from pat reg

       public Patient GetPatient(string pId)
       {
           return new PatientRegistrationBLL().GetPatient(pId);
       }

       public string VerifyPatientNo(string patNo)
       {
           return new PatientRegistrationBLL().VerifyPatientNo(patNo);
       }
       
        /// <ADMS>
        ///ADMS 
        /// </ADMS>
        /// <param name="?"></param>
        /// <returns></returns>
       public List<BedCharges> GetBedRateSetup(string bedCategoryTypeId, string headgroup)
       {
           return new BedFeesBLL().GetBedRateSetup(bedCategoryTypeId, headgroup);
       } 

        //Addmission-Report//

        public List<AdmissionReportRO> GetAdmissionMoneyReceipt(string moneyReceiptNo)
        {
            return new IPDAdmissionRepotBLL().GetAdmissionMoneyReceipt(moneyReceiptNo);
        }

        public short SaveAdmissionReffType(AdmissionReference delType)
        {
            return new IPDSetupBLL().SaveAdmissionReffType(delType);
        }
        public List<AdmissionReference> GetAdmReffType()
        {
            return new IPDSetupBLL().GetAdmReffType();
        }
        public short UpdateAdmissionReffType(AdmissionReference delType)
        {
            return new IPDSetupBLL().UpdateAdmissionReffType(delType);
        }
        public Dictionary<string, string> GetAdmReffTypeDic(string type)
        {
            return new IPDSetupBLL().GetAdmReffTypeDic(type);
        }
        public List<InPatient> GetDepartmentHead(string deptID, string unitID)
        {
            return new IPDBLL().GetDepartmentHead(deptID, unitID);
        }
        public InPatient GetPatientDetails(string presID)
        {
            return new IPDSharedBLL().GetPatientDetails(presID);
        }
        public InPatient GetPatientDetailsForDis(string regID)
        {
            return new IPDBLL().GetPatientDetailsForDis(regID);
        }
        public List<AdmissionReportRO> GetAdmittedPatReportList(DateTime fromDate, DateTime toDate)
        {
            return new IPDAdmissionRepotBLL().GetAdmittedPatReportList(fromDate, toDate);
        }
        //====Reff-OPD=====//
        public string VerifyTicketNo(string prescriptionNo, bool isPrescribed)
        {
            return new OPDBLL().VerifyTicketNo(prescriptionNo, isPrescribed);
        }

        public InPatient GetPatientAdvancePayment(string regID)
        {
            return new IPDBLL().GetPatientAdvancePayment(regID);
        }

        public string SavePatientForDischarge(InPatient adm)
        {
            return new IPDBLL().SavePatientForDischarge(adm);
        }
        //Report//
        public List<DischargeReportRO> GetPatDischargeBillSummary(string regID)
        {
            return new IPDDischargeReportBLL().GetPatDischargeBillSummary(regID);
        }
        public string VerifyHcnNo(string hcn)
        {
            return new IPDBLL().VerifyHcnNo(hcn);
        }
        //
        public string VerifyPatientDepartment(string regno, string deptID, string unitID)
        {
            return new IPDBLL().VerifyPatientDepartment(regno, deptID, unitID);
        }
        public short SavePatientAdmissionCancel(InPatient adm)
        {
            return new IPDBLL().SavePatientAdmissionCancel(adm);
        }

        //===============17-12-2014==========================//
        public short SaveCancelReason(CancelReasonSetup canRes)
        {
            return new IPDSetupBLL().SaveCancelReason(canRes);
        }

        public Dictionary<string, string> GetAdmCancelReasonDic(string canRes)
        {
            return new IPDSetupBLL().GetAdmCancelReasonDic(canRes);
        }
        public short UpdateCancelReason(CancelReasonSetup canRes)
        {
            return new IPDSetupBLL().UpdateCancelReason(canRes);
        }
        public List<CancelReasonSetup> GetCancelReason()
        {
            return new IPDSetupBLL().GetCancelReason();
        }

        public string CheckPatStayingTime(string regID)
        {
            return new IPDBLL().CheckPatStayingTime(regID);
        }
     
        public InPatient GetPatRegID(string bedID)
        {
            return new IPDSharedBLL().GetPatRegID(bedID);
        }
        public InPatient GetPatientEmergencyContactDetails(string hcn)
        {
            return new IPDBLL().GetPatientEmergencyContactDetails(hcn);
        }
        public InPatient GetPatientAdressInformation(string hcn)
        {
            return new IPDBLL().GetPatientAdressInformation(hcn);
        }
        public short SavePackageMaster(PackageSetup pkg)
        {
            return new IPDSetupBLL().SavePackageMaster(pkg);
        }
        public List<PackageSetup> GetPackageMaster()
        {
            return new IPDSetupBLL().GetPackageMaster();
        }
        public short UpdatePackageMaster(PackageSetup pkg)
        {
            return new IPDSetupBLL().UpdatePackageMaster(pkg);
        }
        public Dictionary<string, string> GetPackageMasteDic(string type)
        {
            return new IPDSetupBLL().GetPackageMasteDic(type);
        }
        public List<InPatient> GetAdmittedPatientList()
        {
            return new IPDSharedBLL().GetAdmittedPatientList();
        }
        public double GetTotalAmountForDischarge(string RegistrationNo)
        {
            return new IPDBLL().GetTotalAmountForDischarge(RegistrationNo);
        }


        /////  ================Refd Bed Fee Setup===========//////////////////
        public short SaveBedFee(BedCharges tbd)
        {
            return new BedFeesBLL().SaveBedFee(tbd);
        }
        public short UpdateBedFee(BedCharges ubd)
        {
            return new BedFeesBLL().UpdateBedFee(ubd);
        }
        public List<BedCharges> GetBedRate(string bedtype, string bedFacilityTypeId)
        {
            return new BedFeesBLL().GetBedRate(bedtype, bedFacilityTypeId);
        }
        public int VerifyBedTestFee(string bedtype, string bedCategoryTypeId)
        {
            return new BedFeesBLL().VerifyBedTestFee(bedtype, bedCategoryTypeId);
        }
        public Dictionary<string, string> GetBedtype(string type)
        {
            return new PropertySetupBLL().GetBedtype(type);
        }
        public Dictionary<string, string> GetBuildings(string type)
        {
            return new PropertySetupBLL().GetBuildings(type);
        }

        public List<BedCharges> GetBedRates()
        {
            return new BedFeesBLL().GetBedRates();
        }

        public Bed GetBedInfoByBedID(string bedID)
        {
            return new BedFeesBLL().GetBedInfoByBedID(bedID);
        }
        //=============Refd ACCMS===================//
        public Dictionary<string,string>GetRevHdGrps(string type)
        {
           return new RevenueSetupBLL().GetRevHdGrps(type);
        }
         public Dictionary<string,string>GetRevenueHeads(string type, string headgr)
        {
           return new RevenueSetupBLL().GetRevenueHeads(type,headgr);
        }
         public Dictionary<string, string> GetBedfacility(string type)
         {
             return new PropertySetupBLL().GetBedfacility(type);
         }
        //======================Reff PHRMS=========================================//
         public List<DrugIssue> GetIssueDetailsByRegID(string regid)
         {
             return new DrugIssueBLL().GetIssueDetailsByRegID(regid);
         }
         public Dictionary<string, string> GetNurseStationDic(string type)
         {
             Dictionary<string, string> nurseDic = new Dictionary<string, string>();
             foreach (NurseStation nurse in new NurseStationBLL().GetNurseStation())
             {
                 nurseDic.Add(nurse.NurseStationID, nurse.NurseStationTitle);
             }
             return nurseDic;
         }

        //====================Reff DMS======================================//
         public List<TestFee> GetDmrTestsForIPD(string RegNo)
         {
             return new DiagnosticMRBLL().GetDmrTestsForIPD(RegNo);
         }
        //======================Reff OPRMS=================================//
         public List<CalenderOT> GetRegDetailsFromOperarion(string strControl, string Where)
         {
             return new OPRSetupBLL().GetRegDetailsFromOperarion(strControl, Where);
         }
         public bool GetOperationStatus(string strRegNo)
         {
             return new OPRSetupBLL().GetOperationStatus(strRegNo);
         }

         public InPatient GetPatientInfoByBedID(string bedID)
         {
             return new IPDBLL().GetPatientInfoByBedID(bedID);
         }
        //=====================IPD Report==================================//
         public List<PatientDischargeBillDetailsRO> GetPatDischargeBillDetails(string regID)
         {
             return new IPDDischargeReportBLL().GetPatDischargeBillDetails(regID);
         }
         public List<AdvanceDepositRO> GetAdvPayment(string regno)
         {
             return new IPDDischargeReportBLL().GetAdvPayment(regno);
         }
        //============IPDShared===================================//
       
         public AccountsPayment GetCollectionToTransferAcc(string userID)
         {
             return new IPDBLL().GetCollectionToTransferAcc(userID);
         }
         public short InsertUserCloseRegister(AccountsPayment oAccount)
         {
             return new IPDBLL().InsertUserCloseRegister(oAccount);
         }
         public List<AdmissionReportRO> GetAdmissionCard(string moneyReceiptNo)
         {
             return new IPDAdmissionRepotBLL().GetAdmissionCard(moneyReceiptNo);
         }
         public List<IPDDoctor> GetIPDVisitingFeeDetails(string reg_ID)
         {
             return new IPDSharedBLL().GetIPDVisitingFeeDetails(reg_ID);
         }
        //=========================IPD Patient Certificate==========================//
         public string SavePatientDeath(PatientDeath death)
         {
             return new IPDCertificateBLL().SavePatientDeath(death);
         }
         public Dictionary<string, string> GetOPDDoctorsDict(string deptID, string UnitID)
         {
             return new OPDBLL().GetOPDDoctorsDict(deptID, UnitID);
         }
         public List<IPDDeathRO> DeathCertificate(string regID)
         {
             return new IPDReportBLL().DeathCertificate(regID);
         }
         public string SaveChildBirth(IPDBirth birth)
         {
             return new IPDCertificateBLL().SaveChildBirth(birth);
         }
         public List<IPDBirthCertificateRO> BirthCertificate(string regID)
         {
             return new IPDReportBLL().BirthCertificate(regID);
         }
      //====================EMP==============================//
         public List<EmergencyCollectionMR> GetEmerDetailsForIPD(string Prescription)
         {
             return new EmergencyCollectionBLL().GetEmerDetailsForIPD(Prescription);
         }
        //=========================IPD Shared==========================//

         public Dictionary<string, string> GetIPDDoctorsDict(string deptID, string UnitID)
         {
             return new IPDSharedBLL().GetIPDDoctorsDict(deptID, UnitID);
         }

         public List<IPDDoctor> GetIPDDoctorsList()
         {
             return new IPDSharedBLL().GetIPDDoctorsList();
         }  
         public Dictionary<string, string> GetDeptGroupDicByType(string type)
         {
             return new AdministrationSetupBLL().GetDeptGroupDicByType(type);
         }

         public Dictionary<string, string> GetOPDDoctorDict(string DeptID, string UnitID)
         {
             return new EmployeeSpecializationSetupBLL().GetEmpDic(DeptID, UnitID);
         }
         public short InsertIPDDoctors(IPDDoctor oIPDDOc)
         {
             return new IPDSharedBLL().InsertIPDDoctors(oIPDDOc);
         }
         public List<ItemOrder> GetBillableItemDetails(string regID)
         {
             return new IPDBLL().GetBillableItemDetails(regID);
         }
    }
}
