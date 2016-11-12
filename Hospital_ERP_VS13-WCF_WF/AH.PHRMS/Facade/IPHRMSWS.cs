using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.PHRMS.MODEL;
using AH.DRUGS.MODEL;
using AH.OPD.MODEL;
//using AH.PatReg.MODEL;
using AH.HR.MODEL;
using AH.ACCMS.MODEL;
using AH.IPDShared.MODEL;
using AH.IPDShared.BLL;
using AH.Shared.MODEL;
using AH.INVMS.MODEL;

namespace AH.PHRMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPHRMSWS" in both code and config file together.
    [ServiceContract]
    public interface IPHRMSWS
    {
        [OperationContract]
        short SaveDrugCompany(DrugCompany dg);
        [OperationContract]
        short UpdateDrugCompany(DrugCompany udg);
        [OperationContract]
        short SaveDrugGroup(DrugGroup drgr);
        [OperationContract]
        short UpdateGroup(DrugGroup ugr);
        [OperationContract]
        short SaveDrugUnit(DrugUnit dunit);
        [OperationContract]
        short UpdateDrugUnit(DrugUnit unt);
        [OperationContract]
        short SaveDrugPackType(DrugPackType pack);
        [OperationContract]
        short UpdateDrugPackType(DrugPackType upac);
        [OperationContract]
        List<DrugCompany> GetDrugCompany();
        [OperationContract]
        List<DrugGroup> GetDrugGroup();
        [OperationContract]
        List<DrugUnit> GetDrugUnit();
        [OperationContract]
        List<DrugPackType> GetDrugPackType();
        [OperationContract(Name = "GetDrugCompDic")]
        Dictionary<string, string> GetDrugCompany(string type);
        [OperationContract(Name = "GetDrugGroupDic")]
        Dictionary<string, string> GetDrugGroup(string type);
        [OperationContract(Name = "GetDrugUnitDic")]
        Dictionary<string, string> GetDrugUnit(string type);
        [OperationContract(Name = "GetDrugPacketDic")]
        Dictionary<string, string> GetDrugPackType(string type);
        [OperationContract]
        short SaveDrugMaster(DrugMaster ms);
        [OperationContract]
        short UpdateDrugMaster(DrugMaster ums);
        [OperationContract]
        List<DrugMaster> GetDrugMaster();
        [OperationContract]
        List<DrugMaster> GetDrugMasterList(string drugName);
        [OperationContract]
        short SavePharmacyLocation(Pharmacy loc);
        [OperationContract]
        short UpdatePharmacyLocation(Pharmacy loc);
        [OperationContract(Name = "GetBuildingDict")]
        Dictionary<string, string> GetBuildings(string type);
        [OperationContract]
        List<short> GetNumbers(short min, short max);
        [OperationContract]
        short SaveSupplier(AH.PHRMS.MODEL.Supplier sp);
        [OperationContract]
        short UpdateSupplier(AH.PHRMS.MODEL.Supplier sp);
        [OperationContract]
        List<Pharmacy> GetPharmacyLocation();
        [OperationContract]
        List<AH.PHRMS.MODEL.Supplier> GetSupplierList();
        [OperationContract]
        List<AH.PHRMS.MODEL.Supplier> GetSupplierListed(string supname);
        [OperationContract]
        short SaveConsumerPurpose(ConsumerPurpose con);
        [OperationContract]
        short UpdateConsumerPurpose(ConsumerPurpose con);
        [OperationContract]
        List<ConsumerPurpose> GetConsumerPurpose();
        [OperationContract(Name = "GetPharmacyName")]
        Dictionary<string, string> GetPharmacyLocation(string type);
        [OperationContract]
        string SavePurchaseOrder(AH.PHRMS.MODEL.PurchaseOrder po);
        [OperationContract]
        short SaveDrugDose(DrugDose dr);
        [OperationContract]
        short UpdateDrugDose(DrugDose dr);
        [OperationContract]
        List<DrugDose> GetDrugDose();
        [OperationContract]
        string SaveDrugIssue(DrugIssue di);
        [OperationContract]
        List<OPDDrugs> GetOpdDrugsTkt(string tktno);
        [OperationContract]
        string VerifyTicketNo(string tktNo,bool isprescribe);
        [OperationContract]
        Ticket GetTicket(string tktNo);
        [OperationContract]
        short SaveItemRates(AH.PHRMS.MODEL.ItemRates rate);
        [OperationContract]
        short UpdateItemRates(AH.PHRMS.MODEL.ItemRates urat);
        [OperationContract]
        List<AH.PHRMS.MODEL.ItemRates> GetItemRates();
        [OperationContract]
        List<PharmacyUser> GetUser();
        [OperationContract]
        short SavePharmacyUsers(PharmacyUser usr);
        [OperationContract(Name = "GetMedicineName")]
        Dictionary<string, string> GetDrugName(string type);
        [OperationContract]
        List<DrugMaster> GetDrugListStock(string drugName,string pharmacyid);
        [OperationContract]
        List<DrugMaster> GetDrugListByGroupName(string groupName);
        [OperationContract]
        List<DrugMaster> GetDrugListByGroupNameForIPD(string groupName);
        [OperationContract]
        List<DrugMaster> GetDrugStockByGroup(string groupName);
        //[OperationContract]
        //List<DrugMaster> GetDrugStockByCompany(string drugName,string company);
        [OperationContract]
        List<ProductListRO> GetDrugsCompanyWise(string company);
        [OperationContract]
        List<AH.PHRMS.MODEL.SalesReportRO> GetSalesReport(string issueid);
        [OperationContract]
        List<AH.PHRMS.MODEL.SalesReportRO> GetSalesReportDet(string startDate, string endDate);
        [OperationContract]
        StockHelper GetDrugsStock(string drugid, string phrid);
        [OperationContract]
        List<AH.PHRMS.MODEL.StockListRO> GetDrugStockList(string groupid, string pharmacyid);
        [OperationContract]
        string SaveMaterialReceive(AH.PHRMS.MODEL.MaterialReceive mr);
        [OperationContract]
        List<AH.PHRMS.MODEL.PurchaseOrder> GetPONumbers(string pharmacyID);
        [OperationContract]
        List<AH.PHRMS.MODEL.PurchaseOrder> GetPODetails(string poid, string phrid);
        [OperationContract]
        List<AH.PHRMS.MODEL.PODetailsRO> GetPOReportDet(string poid);
        [OperationContract]
        int VerifyPOID(string poid);
        [OperationContract]
        short SavePOType(POTypes type);
        [OperationContract]
        List<POTypes> GetPOTypes();
        [OperationContract]
        short ModifyPOType(POTypes type);
        [OperationContract]
        List<AH.PHRMS.MODEL.ProductLedgerRO> GetProductLedger(string prodid, string startDate, string endDate);
        [OperationContract]
        short StartDayClose(AH.PHRMS.MODEL.DayEnd odayclose);
        [OperationContract]
        int VerifyDate(string phrid, DateTime day);
        [OperationContract]
        List<AH.PHRMS.MODEL.MaterialReceive> GetOpeningEntry(string MrrID);
        [OperationContract]
        List<AH.PHRMS.MODEL.MaterialReceive> GetMRRNumber();
        [OperationContract]
        short UpdateOpeningEntry(AH.PHRMS.MODEL.MaterialReceive mr);
        [OperationContract]
        List<AH.PHRMS.MODEL.PODetailsRO> GetPOReportDateWise(string startDate, string endDate);
        [OperationContract]
        List<AH.PHRMS.MODEL.MaterialReceiveRO> GetMrrReport(string startDate, string endDate);
        [OperationContract]
        List<AH.PHRMS.MODEL.StockListRO> GetDrugStockListDetails(string pharmacyid);
        [OperationContract]
        string VerifyOpeningDrugID(string drugid, string pharmacyid);
        [OperationContract]
        List<ItemRatesRO> GetItemRatesReport();
        [OperationContract]
        List<ItemRatesHistRO> GetItemRatesHistReport(string prodid, string startDate, string endDate);
        [OperationContract]
        InPatient GetAdmittedPatient(string registrationNo);
        [OperationContract]
        string VerifyInPatient(string regno);
        [OperationContract]
        EmployeeMaster GetEmpMaster(string ID);
        [OperationContract]
        Dictionary<string, string> GetDepartments(string type);
        //[OperationContract(Name = "GetDepartmentUnit")]
        //Dictionary<string, string> GetUnit(string type);
        [OperationContract]
        Dictionary<string, string> GetUnitDict(string Dept);
        [OperationContract]
        string SavePurchaseRequisition(AH.PHRMS.MODEL.PurchaseRequisition opurchase);
        [OperationContract]
        List<AH.PHRMS.MODEL.PurchaseRequisition> GetPRID();
        [OperationContract]
        List<AH.PHRMS.MODEL.PurchaseRequisition> GetPRDetails(string prid);
        [OperationContract]
        string SaveIssueReturn(AH.PHRMS.MODEL.IssueReturn oret);
        [OperationContract]
        List<DrugIssue> GetIssueDetails(string issueID);
       
        [OperationContract]
        string SavePurchaseReturn(AH.PHRMS.MODEL.PurchaseReturn oret);
        [OperationContract]
        List<AH.PHRMS.MODEL.PurchaseOrder> GetPOList(string poid);
        [OperationContract]
        List<AH.PHRMS.MODEL.PurchaseOrder> GetPONum();
        [OperationContract]
        List<ConsumptionForm> GetConsumption();
        [OperationContract]
        string SaveDrugConsumption(ConsumptionForm odrug);
        [OperationContract]
        short ModifyDrugConsumption(ConsumptionForm odrug);
        [OperationContract]
        Dictionary<string, string> GetDeptUnitDic(string DeptGrp, string deptid);
        [OperationContract]
        Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr);
        [OperationContract]
        List<CostCategoryTreeview> GetCostcategory(string control, string Where, string Where1);
        [OperationContract]
        List<CostCategoryTreeview> GetCostcenter(string control, string Where, string Where1);
        [OperationContract]
        List<NurseDemandRequisition> GetDRID();
        [OperationContract]
        List<NurseDemandRequisition> GetReqDetForIPDIssue(string drid);
        [OperationContract]
        Patient GetPatient(string pId);
        [OperationContract]
        List<Patient> GetPatientDetails(string name, string cell);
        [OperationContract]
        List<AH.PHRMS.MODEL.MaterialReceiveRO> GetOpeningReport();
        [OperationContract]
        List<AH.PHRMS.MODEL.MaterialReceiveRO> GetDrugsByExpireDate(string startDate, string endDate);
        [OperationContract]
        List<DrugMaster> GetDrugMasterListCompanyWise(string drugName, string company);
        [OperationContract]
        List<DrugDose> GetDrugDoseListByDrugName(string patage, string drugname);
        [OperationContract]
        List<DrugDose> GetDrugDoseListByGroupName(string patage, string groupname);
        [OperationContract]
        short SaveTermsandCondition(AH.PHRMS.MODEL.TermsAndConditions oterms);
        [OperationContract]
        List<AH.PHRMS.MODEL.TermsAndConditions> GetTermsandCondition();
        [OperationContract]
        short ModifyTermsandCondition(AH.PHRMS.MODEL.TermsAndConditions oterms);
        [OperationContract]
        List<AH.PHRMS.MODEL.POTermsConditionRO> GetPOTermsConditions(string poid);
        [OperationContract]
        List<DrugIssue> GetIssueDetailsByRegID(string regid);
        [OperationContract]
        List<DrugMaster> GetDrugMasterByCompany(string drugcompany);
        [OperationContract]
        List<AH.PHRMS.MODEL.MrrReportRO> GetMrrReportByMrID(string mrid);
        [OperationContract]
        List<AH.PHRMS.MODEL.MaterialReceive> GetMrrDetailsForPurchaseReturn(string mrrid);
        [OperationContract]
        int VarifyDrugForReturn(string mrrid,string drugid);
        [OperationContract]
        List<AH.PHRMS.MODEL.PRReportRO> GetPRreport(string prid);
        [OperationContract]
        List<AH.PHRMS.MODEL.PurchaseRequisition> GetPRDetSearch();
        [OperationContract]
        List<AH.PHRMS.MODEL.PurchaseRequisition> GetPRSearchDetails(string prid);
        [OperationContract]
        int VarifyPurchaseReqNo(string prid);
        [OperationContract]
        AccountsPayment GetTicketFees(string userID, string date);
        [OperationContract]
        short InsertUserCloseRegister(AccountsPayment tktFee);
        [OperationContract]
        Dictionary<string, string> GetSupplierLedger(string Ledgergroup);
        [OperationContract]
        List<DrugCompany> GetDrugCompanyDictionary();
        [OperationContract]
        List<DrugMaster> GetDrugListCompanyWise(string company);
        [OperationContract]
        List<AH.PHRMS.MODEL.PurchaseRequisition> GetRequisitionTrack(string pharmacyid, string startDate, string endDate);
        [OperationContract]
        List<AH.PHRMS.MODEL.PurchaseOrder> GetPOTracking(string pharmacyid, string startDate, string endDate);
        [OperationContract]
        List<AH.PHRMS.MODEL.PurchaseOrder> GetPOTrackingByPrId(string prid);
        [OperationContract]
        List<AH.PHRMS.MODEL.MaterialReceive> GetMrrTracking(string pharmacyid, string startDate, string endDate);
        [OperationContract]
        List<AH.PHRMS.MODEL.MaterialReceive> GetMrrTrackingByPONo(string poid);
        [OperationContract]
        List<DrugRoute> GetDrugRoute();
        [OperationContract]
        string SaveDrugRoute(DrugRoute odrug);
        [OperationContract]
        short ModifyDrugRoute(DrugRoute odrug);
        [OperationContract]
        int VarifyDuplicateBatch(string phrid, string drugid, string batchno);
        [OperationContract]
        int VarifyExpireDate(string phrid, string drugid);
        [OperationContract]
        string SaveDemandRequisition(AH.PHRMS.MODEL.DemandRequisition odr);
        [OperationContract]
        string SaveTransferRequisition(AH.PHRMS.MODEL.TransferRequisition otr);
        [OperationContract]
        List<PharmacyUser> GetUserByID(string userid);
        [OperationContract]
        List<AH.PHRMS.MODEL.TransferRequisition> GetTRID(string pharmacy);
        [OperationContract]
        List<AH.PHRMS.MODEL.TransferRequisition> GetTRDetails(string trid);
        [OperationContract]
        List<AH.PHRMS.MODEL.MaterialReceive> GetDrugDetailsBatch(string trid, string drugid, string pharmacyid);
        [OperationContract]
        string SaveTransferReceive(AH.PHRMS.MODEL.TransferReceive otr);
        [OperationContract]
        List<AH.INVMS.MODEL.WarehouseConfig> GetWarehouse();
        [OperationContract]
        List<AH.INVMS.MODEL.WarehouseConfig> GetWarehouseTypewise(string phr,string str);
        [OperationContract]
        List<DrugMaster> GetDrugStockByPharmacy(string drugName, string pharmacy);
        [OperationContract]
        List<AH.PHRMS.MODEL.TransferRequisition> GetTRDetSearch();
        [OperationContract]
        List<WarehouseConfig> GetWhTypeforCentral(string warehouse, string type);
        [OperationContract]
        List<AH.PHRMS.MODEL.SalesReportRO> GetSalRetReport(string issueid);
        [OperationContract]
        List<AH.PHRMS.MODEL.SalesReportRO> GetSalRetReportDet(string startDate, string endDate);
    }
}
