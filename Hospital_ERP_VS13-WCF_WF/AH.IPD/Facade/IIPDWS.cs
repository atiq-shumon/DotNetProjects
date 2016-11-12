using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.IPD.MODEL;
using AH.HR.BLL;
using AH.Shared.MODEL;
using AH.PatReg.MODEL;
using AH.PRMS.MODEL;
using AH.PHRMS.MODEL;
using AH.DTMS.MODEL;
using AH.OPRMS.MODEL;
//using AH.NWMS.MODEL;
using AH.IPDShared.MODEL;
using AH.DMS.MODEL;
using AH.INVMS.MODEL;

namespace AH.IPD.Facade
    {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIPDWS" in both code and config file together.
    [ServiceContract ()]
    public interface IIPDWS
    {
      /**********************IPDSetUpBLL**************************************/

        [OperationContract]
       short SaveDeliveryType(DeliveryType tipd);

        [OperationContract]
       short UpdateDelType(DeliveryType uipd);

      
        [OperationContract]
        List<DeliveryType> GetDeliveryType();

        [OperationContract]
        int VerifyDelivery(string delid);

        [OperationContract]
       short SaveAdmissionReason(AdmissionReason admr);

        [OperationContract]
       List<AdmissionReason> GetAdmReason();
        [OperationContract]
        short UpdateAdmissionReason(AdmissionReason admr);

        [OperationContract(Name="GetAdmReasonDict")]
       Dictionary<string, string> GetAdmReason(string type);

        [OperationContract]
       short SaveAdmReasonAss(AdmReasonAssign admass);

        [OperationContract]
        List<AdmReasonAssign> GetAdmReasonAss();

        [OperationContract (Name = "GetAdmResonDeptWise")]
       List<AdmReasonAssign> GetAdmReasonAss(string departmentID);

        [OperationContract(Name = "GetAdmReasonDeptWiseDict")]
        Dictionary<string, string> GetAdmReason(string type, string departmentID);

        [OperationContract]
         int GetMinStayingDays(string admReason);

       // [OperationContract]
       //Dictionary<string, string> GetDeptUnitAssigned(string type, string deptid);



    /******************IPDBLL********************************/
         [OperationContract]
         string saveAdmission(InPatient adm);

         [OperationContract]
         InPatient GetAdmittedPatient(string RegistrationNo);

         [OperationContract]
         List<OPDPayment> GetAdvPay(string regno);

         [OperationContract]
         string SaveAdvanpay(InPatient adv);

         [OperationContract]
         string SaveBedTransfer(InPatient trans);

         [OperationContract]
         double GetTotalAmount(string RegistrationNo);

         [OperationContract]
         string SaveDeptTransfer(InPatient tradept);

         [OperationContract]
         List<InPatient> GetBedHist(string regno);

         [OperationContract]
         List<InPatient> GetDeptHistory(string regno);

         [OperationContract]
         string VerifyInPatient(string regNo);

         [OperationContract]
         List<RevenueHead> GetDepartmentRevenue(string regno);

         // Reff's 
         [OperationContract]
         Dictionary<string, string> GetDeptUnitDic(string deptgrp, string deptid);

         [OperationContract]
         Dictionary<string, string> GetWards(string type);

        

         [OperationContract]
         Dictionary<string, string> GetNurse(string type);

       // reff from pat reg
         [OperationContract]
         Patient GetPatient(string pId);

         [OperationContract]
        string VerifyPatientNo(string patNo);

        
         [OperationContract]
         List<BedCharges> GetBedRateSetup(string bedCategoryTypeId, string headgroup);

         //Addmission-Report//
         [OperationContract]
         List<AdmissionReportRO> GetAdmissionMoneyReceipt(string moneyReceiptNo);

         [OperationContract]
         short SaveAdmissionReffType(AdmissionReference delType);

         [OperationContract]
         List<AdmissionReference> GetAdmReffType();

         [OperationContract]
         short UpdateAdmissionReffType(AdmissionReference delType);

         [OperationContract]
         Dictionary<string, string> GetAdmReffTypeDic(string type);

         [OperationContract]
         List<InPatient> GetDepartmentHead(string deptID, string unitID);

         [OperationContract]
         InPatient GetPatientDetails(string presID);
        //====Reff-OPD=====//
         [OperationContract]
         string VerifyTicketNo(string prescriptionNo, bool isPrescribed);

         [OperationContract]
         InPatient GetPatientDetailsForDis(string regID);

         [OperationContract]
         InPatient GetPatientAdvancePayment(string regID);

         [OperationContract]
         string SavePatientForDischarge(InPatient adm);

         //report//
         [OperationContract]
         List<DischargeReportRO> GetPatDischargeBillSummary(string regID);
         //=====//

         [OperationContract]
         string VerifyHcnNo(string hcn);

         [OperationContract]
         string VerifyPatientDepartment(string regno, string deptID, string unitID);

         [OperationContract]
         short SavePatientAdmissionCancel(InPatient adm);

         [OperationContract]
          short SaveCancelReason(CancelReasonSetup canRes);
          
         [OperationContract]
         Dictionary<string, string> GetAdmCancelReasonDic(string canRes);

         [OperationContract]
         short UpdateCancelReason(CancelReasonSetup canRes);

         [OperationContract]
         List<CancelReasonSetup> GetCancelReason();

         [OperationContract]
         string CheckPatStayingTime(string regID);
      
         [OperationContract]
         InPatient GetPatRegID(string bedID);

         [OperationContract]
         InPatient GetPatientEmergencyContactDetails(string hcn);

         [OperationContract]
         InPatient GetPatientAdressInformation(string hcn);

         [OperationContract]
         short SavePackageMaster(PackageSetup pkg);

         [OperationContract]
         List<PackageSetup> GetPackageMaster();

         [OperationContract]
         short UpdatePackageMaster(PackageSetup pkg);

        [OperationContract]
        Dictionary<string, string> GetPackageMasteDic(string type);

        [OperationContract]
        List<InPatient> GetAdmittedPatientList();

        [OperationContract]
        double GetTotalAmountForDischarge(string RegistrationNo);
         
        /**********************Refd Bed Fee Setup**************************/
        [OperationContract]
        short SaveBedFee(BedCharges tbd);
        [OperationContract]
        short UpdateBedFee(BedCharges ubd);
        [OperationContract]
        List<BedCharges> GetBedRate(string bedtype, string bedFacilityTypeId);
        [OperationContract]
        int VerifyBedTestFee(string bedtype, string bedCategoryTypeId);

        [OperationContract(Name = "GetBedtypeDict")]
        Dictionary<string, string> GetBedtype(string type);

        [OperationContract(Name = "GetBuildingDict")]
        Dictionary<string, string> GetBuildings(string type);

        [OperationContract]
        List<BedCharges> GetBedRates();
        [OperationContract]
        Dictionary<string, string> GetRevHdGrps(string type);
        [OperationContract]
        Dictionary<string, string> GetRevenueHeads(string type, string headgr);

        [OperationContract]
        Dictionary<string, string> GetBedfacility(string type);
        [OperationContract]
        Bed GetBedInfoByBedID(string bedID);

        //************Reff PRMS******************//
        [OperationContract]
        List<Bed> GetBedSets(string bedtype, string bedstatus);

        [OperationContract]
        List<Bed> GetNurseBeds(string nsstn, string level);

        [OperationContract]
        List<Bed> GetLevelWiseBeds(string nstn,string level_no);
        //===============Reff PHRMS====================//
        [OperationContract]
        List<DrugIssue> GetIssueDetailsByRegID(string regid);
        //====================Reff DMS================//
        [OperationContract]
        List<TestFee> GetDmrTestsForIPD(string RegNo);
         //======================Reff OPRMS=========================//
        [OperationContract]
        List<CalenderOT> GetRegDetailsFromOperarion(string strControl, string Where);

        [OperationContract]
        bool GetOperationStatus(string strRegNo);
        //====================================================================//
        [OperationContract]
         InPatient GetPatientInfoByBedID(string bedID);
        //=====================IPD Report==================================//
        [OperationContract]
         List<PatientDischargeBillDetailsRO> GetPatDischargeBillDetails(string regID);

        [OperationContract]
        List<AdvanceDepositRO> GetAdvPayment(string regno);
         //======================Reff IPDShared==========================//
     
        [OperationContract]
        Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr);

        [OperationContract]
        List<AdmissionReportRO> GetAdmittedPatReportList(DateTime fromDate, DateTime toDate);

         [OperationContract]
         short InsertUserCloseRegister(AccountsPayment oAccount);

         [OperationContract]
         AccountsPayment GetCollectionToTransferAcc(string userID);

         [OperationContract]
         List<AdmissionReportRO> GetAdmissionCard(string moneyReceiptNo);

         [OperationContract]
         Dictionary<string, string> GetNurseStationDic(string type);

         [OperationContract]
         List<IPDDoctor> GetIPDVisitingFeeDetails(string reg_ID);
           //=========================IPD Patient Certificate==========================//
         [OperationContract]
         string SavePatientDeath(PatientDeath death);
         [OperationContract]
         Dictionary<string, string> GetOPDDoctorsDict(string deptID, string UnitID);

         [OperationContract]
         List<IPDDeathRO> DeathCertificate(string regID);

         [OperationContract]
         string SaveChildBirth(IPDBirth birth);

         [OperationContract]
         List<IPDBirthCertificateRO> BirthCertificate(string regID);
        //=======================EMP=============================//
         [OperationContract]
         List<EmergencyCollectionMR> GetEmerDetailsForIPD(string Prescription);

        //==========================IPD Shared=====================//
         [OperationContract]
         List<IPDDoctor> GetIPDDoctorsList();

         [OperationContract]
         Dictionary<string, string> GetIPDDoctorsDict(string deptID, string UnitID);
         [OperationContract]
         Dictionary<string, string> GetDeptGroupDicByType(string type);

         [OperationContract]
         Dictionary<string, string> GetOPDDoctorDict(string DeptID, string UnitID);

         [OperationContract]
         short InsertIPDDoctors(IPDDoctor oIPDDOc);

         [OperationContract]
         List<ItemOrder> GetBillableItemDetails(string regID);
    
       }
    }
