using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.PHRMS.BLL;
using AH.PHRMS.MODEL;
using AH.PRMS.BLL;
using AH.DUtility;
using AH.DRUGS.MODEL;
using AH.IPDShared.MODEL;
using AH.DRUGS.BLL;
using AH.OPD.BLL;
using AH.HR.MODEL;
using AH.ACCMS.MODEL;
using AH.PatReg.MODEL;
using AH.HR.BLL;
using AH.PatReg.BLL;
using AH.OPD.MODEL;
using AH.ORGMS.BLL;
using AH.IPDShared.BLL;
using AH.ACCMS.BLL;
using AH.INVMS.MODEL;
using AH.INVMS.BLL;
using AH.Shared.MODEL;

namespace AH.PHRMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PHRMSWS" in both code and config file together.
    public class PHRMSWS : IPHRMSWS
    {
        public short SaveDrugCompany(DrugCompany dg)
        {
            return new DrugSetupBLL().SaveDrugCompany(dg);
        }
        public short UpdateDrugCompany(DrugCompany udg)
        {
            return new DrugSetupBLL().UpdateDrugCompany(udg);
        }
        public short SaveDrugGroup(DrugGroup drgr)
        {
            return new DrugSetupBLL().SaveDrugGroup(drgr);
        }
        public short UpdateGroup(DrugGroup ugr)
        {
            return new DrugSetupBLL().UpdateGroup(ugr);
        }
        public short SaveDrugUnit(DrugUnit dunit)
        {
            return new DrugSetupBLL().SaveDrugUnit(dunit);
        }
        public short UpdateDrugUnit(DrugUnit unt)
        {
            return new DrugSetupBLL().UpdateDrugUnit(unt);
        }
        public short SaveDrugPackType(DrugPackType pack)
        {
            return new DrugSetupBLL().SaveDrugPackType(pack);
        }
        public short UpdateDrugPackType(DrugPackType upac)
        {
            return new DrugSetupBLL().UpdateDrugPackType(upac);
        }
        public List<DrugCompany> GetDrugCompany()
        {
            return new DrugSetupBLL().GetDrugCompany();
        }
        public List<DrugGroup> GetDrugGroup()
        {
            return new DrugSetupBLL().GetDrugGroup();
        }
        public List<DrugUnit> GetDrugUnit()
        {
            return new DrugSetupBLL().GetDrugUnit();
        }
        public List<DrugPackType> GetDrugPackType()
        {
            return new DrugSetupBLL().GetDrugPackType();
        }
        public Dictionary<string, string> GetDrugCompany(string type)
        {
            return new DrugSetupBLL().GetDrugCompany(type);
        }
        public Dictionary<string, string> GetDrugGroup(string type)
        {
            return new DrugSetupBLL().GetDrugGroup(type);
        }
        public Dictionary<string, string> GetDrugUnit(string type)
        {
            return new DrugSetupBLL().GetDrugUnit(type);
        }
        public Dictionary<string, string> GetDrugPackType(string type)
        {
            return new DrugSetupBLL().GetDrugPackType(type);
        }
        public short SaveDrugMaster(DrugMaster ms)
        {
            return new DrugSetupBLL().SaveDrugMaster(ms);
        }
        public short UpdateDrugMaster(DrugMaster ums)
        {
            return new DrugSetupBLL().UpdateDrugMaster(ums);
        }
        public List<DrugMaster> GetDrugMaster()
        {
            return new DrugSetupBLL().GetDrugMaster();
        }
        public List<DrugMaster> GetDrugMasterList(string drugName)
        {
            return new DrugSetupBLL().GetDrugMasterList(drugName);
        }
        public short SavePharmacyLocation(Pharmacy loc)
        {
            return new PHRMSSetupBLL().SavePharmacyLocation(loc);
        }
        public short UpdatePharmacyLocation(Pharmacy loc)
        {
            return new PHRMSSetupBLL().UpdatePharmacyLocation(loc);
        }
        public Dictionary<string, string> GetBuildings(string type)
        {
            return new PropertySetupBLL().GetBuildings(type);
        }
        public List<short> GetNumbers(short min, short max)
        {
            return Utility.GetNumbers(min,max);
        }
        public short SaveSupplier(AH.PHRMS.MODEL.Supplier sp)
        {
            return new PHRMSSetupBLL().SaveSupplier(sp);
        }
        public short UpdateSupplier(AH.PHRMS.MODEL.Supplier sp)
        {
            return new PHRMSSetupBLL().UpdateSupplier(sp);
        }
        public List<Pharmacy> GetPharmacyLocation()
        {
            return new PHRMSSetupBLL().GetPharmacyLocation();
        }
        public List<AH.PHRMS.MODEL.Supplier> GetSupplierList()
        {
            return new PHRMSSetupBLL().GetSupplierList();
        }
        public List<AH.PHRMS.MODEL.Supplier> GetSupplierListed(string supname)
        {
            return new PHRMSSetupBLL().GetSupplierListed(supname);
        }
        public short SaveConsumerPurpose(ConsumerPurpose con)
        {
            return new PHRMSSetupBLL().SaveConsumerPurpose(con);
        }
        public short UpdateConsumerPurpose(ConsumerPurpose con)
        {
            return new PHRMSSetupBLL().UpdateConsumerPurpose(con);
        }
        public List<ConsumerPurpose> GetConsumerPurpose()
        {
            return new PHRMSSetupBLL().GetConsumerPurpose();
        }
        public Dictionary<string, string> GetPharmacyLocation(string type)
        {
            return new PHRMSSetupBLL().GetPharmacyLocation(type);
        }
        public string SavePurchaseOrder(AH.PHRMS.MODEL.PurchaseOrder po)
        {
            return new AH.PHRMS.BLL.POBLL().SavePurchaseOrder(po);
        }
        public short SaveDrugDose(DrugDose dr)
        {
            return new DrugSetupBLL().SaveDrugDose(dr);
        }
        public short UpdateDrugDose(DrugDose dr)
        {
            return new DrugSetupBLL().UpdateDrugDose(dr);
        }
        public List<DrugDose> GetDrugDose()
        {
            return new DrugSetupBLL().GetDrugDose();
        }
        public string SaveDrugIssue(DrugIssue di)
        {
            return new DrugIssueBLL().SaveDrugIssue(di);
        }
        public List<OPDDrugs> GetOpdDrugsTkt(string tktno)
        {
            return new OPDDrugsBLL().GetOpdDrugsTkt(tktno);
        }
        public Ticket GetTicket(string tktNo)
        {
            return new OPDBLL().GetTicket(tktNo);
        }
        public short SaveItemRates(AH.PHRMS.MODEL.ItemRates rate)
        {
            return new PHRMSSetupBLL().SaveItemRates(rate);
        }
        public short UpdateItemRates(AH.PHRMS.MODEL.ItemRates urat)
        {
            return new PHRMSSetupBLL().UpdateItemRates(urat);
        }
        public List<AH.PHRMS.MODEL.ItemRates> GetItemRates()
        {
            return new PHRMSSetupBLL().GetItemRates();
        }
        public Dictionary<string, string> GetDrugName(string type)
        {
            return new DrugSetupBLL().GetDrugName(type);
        }
        public string VerifyTicketNo(string tktNo,bool isprescribe)
        {
            return new OPDBLL().VerifyTicketNo(tktNo,isprescribe);
        }
        public List<PharmacyUser> GetUser()
        {
            return new PHRMSSetupBLL().GetUser();
        }
        public short SavePharmacyUsers(PharmacyUser usr)
        {
            return new PHRMSSetupBLL().SavePharmacyUsers(usr);
        }
        public List<DrugMaster> GetDrugListStock(string drugName,string pharmacyid)
        {
            return new PHRMSSetupBLL().GetDrugListStock(drugName,pharmacyid);
        }
        public List<DrugMaster> GetDrugListByGroupName(string groupName)
        {
            return new PHRMSSetupBLL().GetDrugListByGroupName(groupName);
        }
        public List<DrugMaster> GetDrugListByGroupNameForIPD(string groupName)
        {
            return new PHRMSSetupBLL().GetDrugListByGroupNameForIPD(groupName);
        }
        public List<DrugMaster> GetDrugStockByGroup(string groupName)
        {
            return new PHRMSSetupBLL().GetDrugStockByGroup(groupName);
        }
        //public List<DrugMaster> GetDrugStockByCompany(string drugName,string company)
        //{
        //    return new PHRMSSetupBLL().GetDrugStockByCompany(drugName,company);
        //}
        public List<ProductListRO> GetDrugsCompanyWise(string company)
        {
            return new PHRMSReportBLL().GetDrugsCompanyWise(company);
        }
        public List<AH.PHRMS.MODEL.SalesReportRO> GetSalesReport(string issueid)
        {
            return new PHRMSReportBLL().GetSalesReport(issueid);
        }
        public List<AH.PHRMS.MODEL.SalesReportRO> GetSalesReportDet(string startDate, string endDate)
        {
            return new PHRMSReportBLL().GetSalesReportDet(startDate,endDate);
        }
        public StockHelper GetDrugsStock(string drugid, string phrid)
        {
            return new PHRMSSetupBLL().GetDrugsStock(drugid,phrid);
        }
        public List<AH.PHRMS.MODEL.StockListRO> GetDrugStockList(string groupid, string pharmacyid)
        {
            return new PHRMSReportBLL().GetDrugStockList(groupid,pharmacyid);
        }
        public string SaveMaterialReceive(AH.PHRMS.MODEL.MaterialReceive mr)
        {
            return new MaterialReceiveBLL().SaveMaterialReceive(mr);
        }
        public List<AH.PHRMS.MODEL.PurchaseOrder> GetPONumbers(string pharmacyID)
        {
            return new AH.PHRMS.BLL.POBLL().GetPONumbers(pharmacyID);
        }
        public List<AH.PHRMS.MODEL.PurchaseOrder> GetPODetails(string poid, string phrid)
        {
            return new AH.PHRMS.BLL.POBLL().GetPODetails(poid, phrid);
        }
        public List<AH.PHRMS.MODEL.PODetailsRO> GetPOReportDet(string poid)
        {
            return new POReportBLL().GetPOReportDet(poid);
        }
        public int VerifyPOID(string poid)
        {
            return new POReportBLL().VerifyPOID(poid);
        }
        public short SavePOType(POTypes type)
        {
            return new AH.PHRMS.BLL.POBLL().SavePOType(type);
        }
        public List<POTypes> GetPOTypes()
        {
            return new AH.PHRMS.BLL.POBLL().GetPOTypes();
        }
        
        public short ModifyPOType(POTypes type)
        {
            return new AH.PHRMS.BLL.POBLL().ModifyPOType(type);
        }
        public List<AH.PHRMS.MODEL.ProductLedgerRO> GetProductLedger(string prodid, string startDate, string endDate)
        {
            return new POReportBLL().GetProductLedger(prodid,startDate,endDate);
        }
        public short StartDayClose(AH.PHRMS.MODEL.DayEnd odayclose)
        {
            return new AH.PHRMS.BLL.DayCloseBLL().StartDayClose(odayclose);
        }
        public int VerifyDate(string phrid, DateTime day)
        {
            return new AH.PHRMS.BLL.DayCloseBLL().VerifyDate(phrid, day);
        }
        public List<AH.PHRMS.MODEL.MaterialReceive> GetOpeningEntry(string MrrID)
        {
            return new MaterialReceiveBLL().GetOpeningEntry(MrrID);
        }
        public List<AH.PHRMS.MODEL.MaterialReceive> GetMRRNumber()
        {
            return new MaterialReceiveBLL().GetMRRNumber();
        }
        public short UpdateOpeningEntry(AH.PHRMS.MODEL.MaterialReceive mr)
        {
            return new MaterialReceiveBLL().UpdateOpeningEntry(mr);
        }
        public List<AH.PHRMS.MODEL.PODetailsRO> GetPOReportDateWise(string startDate, string endDate)
        {
            return new POReportBLL().GetPOReportDateWise(startDate,endDate);
        }
        public List<AH.PHRMS.MODEL.MaterialReceiveRO> GetMrrReport(string startDate, string endDate)
        {
            return new MaterialReceiveBLL().GetMrrReport(startDate,endDate);
        }
        public List<AH.PHRMS.MODEL.StockListRO> GetDrugStockListDetails(string pharmacyid)
        {
            return new PHRMSReportBLL().GetDrugStockListDetails(pharmacyid);
        }
        public string VerifyOpeningDrugID(string drugid, string pharmacyid)
        {
            return new MaterialReceiveBLL().VerifyOpeningDrugID(drugid,pharmacyid);
        }
        public List<ItemRatesRO> GetItemRatesReport()
        {
            return new PHRMSReportBLL().GetItemRatesReport();

        }
        public List<ItemRatesHistRO> GetItemRatesHistReport(string prodid,string startDate,string endDate)
        {
            return new PHRMSReportBLL().GetItemRatesHistReport(prodid,startDate,endDate);

        }
        public InPatient GetAdmittedPatient(string registrationNo)
        {
            return new IPDSharedBLL().GetAdmittedPatient(registrationNo);

        }
       public string VerifyInPatient(string regno)
        {
            return new IPDSharedBLL().VerifyInPatient(regno);
        }
       public EmployeeMaster GetEmpMaster(string ID)
       {
           return new EmployeeSetUpBLL().GetEmpMaster(ID);
       }
       public Dictionary<string, string> GetDepartments(string type)
       {
           return new AdministrationSetupBLL().GetDepartments(type);
       }
       //public Dictionary<string, string> GetUnit(string type)
       //{
       //    return new AdministrationSetupBLL().GetUnit(type);
       //}
       public Dictionary<string, string> GetUnitDict(string Dept)
       {
           return new AdministrationSetupBLL().GetUnitDict(Dept);
       }

       public string SavePurchaseRequisition(AH.PHRMS.MODEL.PurchaseRequisition opurchase)
       {
           return new AH.PHRMS.BLL.PRSetupBLL().SavePurchaseRequisition(opurchase);

       }
       public List<AH.PHRMS.MODEL.PurchaseRequisition> GetPRID()
       {
           return new AH.PHRMS.BLL.PRSetupBLL().GetPRID();
       }
       public List<AH.PHRMS.MODEL.PurchaseRequisition> GetPRDetails(string prid)
        {
            return new AH.PHRMS.BLL.PRSetupBLL().GetPRDetails(prid);
        }
       public string SaveIssueReturn(AH.PHRMS.MODEL.IssueReturn oret)
        {
            return new DrugIssueBLL().SaveIssueReturn(oret);
        }
        public List<DrugIssue> GetIssueDetails(string issueID)
        {
            return new DrugIssueBLL().GetIssueDetails(issueID);
        }

        public string SavePurchaseReturn(AH.PHRMS.MODEL.PurchaseReturn oret)
        {
            return new MaterialReceiveBLL().SavePurchaseReturn(oret);
        }
        public List<AH.PHRMS.MODEL.PurchaseOrder> GetPOList(string poid)
        {
            return new AH.PHRMS.BLL.POBLL().GetPOList(poid);
        }
        public List<AH.PHRMS.MODEL.PurchaseOrder> GetPONum()
        {
            return new AH.PHRMS.BLL.POBLL().GetPONum();
        }
        public List<ConsumptionForm> GetConsumption()
        {
            return new DrugSetupBLL().GetConsumption();
        }
        public string SaveDrugConsumption(ConsumptionForm odrug)
        {
            return new DrugSetupBLL().SaveDrugConsumption(odrug);
        }
        public short ModifyDrugConsumption(ConsumptionForm odrug)
        {
            return new DrugSetupBLL().ModifyDrugConsumption(odrug);
        }
        public Dictionary<string, string> GetDeptUnitDic(string DeptGrp, string deptid)
        {
            return new AdministrationSetupBLL().GetDeptUnitDic(DeptGrp, deptid);
        }
        public Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr)
        {
            return new AdministrationSetupBLL().GetDepartmentsetupDic(type, deptgr);
        }
        public List<CostCategoryTreeview> GetCostcategory(string control, string Where, string Where1)
        {
            return new CollectionSummaryBLL().GetCostcategoryTreeview(control, Where, Where1);
        }
        public List<CostCategoryTreeview> GetCostcenter(string control, string Where, string Where1)
        {
            return new CollectionSummaryBLL().GetCostcenterTreeview(control, Where, Where1);
        }
        public List<NurseDemandRequisition> GetDRID()
        {
            return new AH.PHRMS.BLL.PRSetupBLL().GetDRID();
        }
        public List<NurseDemandRequisition> GetReqDetForIPDIssue(string drid)
        {
            return new AH.PHRMS.BLL.PRSetupBLL().GetReqDetForIPDIssue(drid);
        }
        public Patient GetPatient(string pId)
        {
            return new PatientRegistrationBLL().GetPatient(pId);
        }
        public List<Patient> GetPatientDetails(string name, string cell)
        {
            return new PatientRegistrationBLL().GetPatientDetails(name, cell);
        }
        public List<AH.PHRMS.MODEL.MaterialReceiveRO> GetOpeningReport()
        {
            return new MaterialReceiveBLL().GetOpeningReport();
        }
        public List<AH.PHRMS.MODEL.MaterialReceiveRO> GetDrugsByExpireDate(string startDate, string endDate)
        {
            return new MaterialReceiveBLL().GetDrugsByExpireDate(startDate,endDate);
        }
        public List<DrugMaster> GetDrugMasterListCompanyWise(string drugName,string company)
        {
            return new DrugSetupBLL().GetDrugMasterListCompanyWise(drugName,company);
        }
        public List<DrugDose> GetDrugDoseListByDrugName(string patage, string drugname)
        {
            return new DrugsListBLL().GetDrugDoseListByDrugName(patage,drugname);
        }
        public List<DrugDose> GetDrugDoseListByGroupName(string patage, string groupname)
        {
            return new DrugsListBLL().GetDrugDoseListByGroupName(patage,groupname);
        }
        public short SaveTermsandCondition(AH.PHRMS.MODEL.TermsAndConditions oterms)
        {
            return new AH.PHRMS.BLL.POBLL().SaveTermsandCondition(oterms);
        }
        public List<AH.PHRMS.MODEL.TermsAndConditions> GetTermsandCondition()
        {
            return new AH.PHRMS.BLL.POBLL().GetTermsandCondition();
        }
        public short ModifyTermsandCondition(AH.PHRMS.MODEL.TermsAndConditions oterms)
        {
            return new AH.PHRMS.BLL.POBLL().ModifyTermsandCondition(oterms);
        }
        public List<AH.PHRMS.MODEL.POTermsConditionRO> GetPOTermsConditions(string poid)
        {
            return new POReportBLL().GetPOTermsConditions(poid);
        }
        public List<DrugIssue> GetIssueDetailsByRegID(string regid)
        {
            return new DrugIssueBLL().GetIssueDetailsByRegID(regid);
        }
        public List<DrugMaster> GetDrugMasterByCompany(string drugcompany)
        {
            return new DrugSetupBLL().GetDrugMasterByCompany(drugcompany);
        }
        public List<AH.PHRMS.MODEL.MrrReportRO> GetMrrReportByMrID(string mrid)
        {
            return new PHRMSReportBLL().GetMrrReportByMrID(mrid);
        }
        public List<AH.PHRMS.MODEL.MaterialReceive> GetMrrDetailsForPurchaseReturn(string mrrid)
        {
            return new MaterialReceiveBLL().GetMrrDetailsForPurchaseReturn(mrrid);
        }
        public int VarifyDrugForReturn(string mrrid,string drugid)
        {
            return new MaterialReceiveBLL().VarifyDrugForReturn(mrrid,drugid);
        }
        public List<AH.PHRMS.MODEL.PRReportRO> GetPRreport(string prid)
        {
            return new PHRMSReportBLL().GetPRreport(prid);
        }
        public List<AH.PHRMS.MODEL.PurchaseRequisition> GetPRDetSearch()
        {
            return new AH.PHRMS.BLL.PRSetupBLL().GetPRDetSearch();
        }
        public List<AH.PHRMS.MODEL.PurchaseRequisition> GetPRSearchDetails(string prid)
        {
            return new AH.PHRMS.BLL.PRSetupBLL().GetPRSearchDetails(prid);
        }
        public int VarifyPurchaseReqNo(string prid)
        {
            return new AH.PHRMS.BLL.PRSetupBLL().VarifyPurchaseReqNo(prid);
        }
        public AccountsPayment GetTicketFees(string userID, string date)
        {
            return new DrugIssueBLL().GetTicketFees(userID,date);
        }
        public short InsertUserCloseRegister(AccountsPayment tktFee)
        {
            return new DrugIssueBLL().InsertUserCloseRegister(tktFee);
        }
        public Dictionary<string, string> GetSupplierLedger(string Ledgergroup)
        {
            return new CollectionSummaryBLL().GetSupplierLedger(Ledgergroup);
        }
        public List<DrugCompany> GetDrugCompanyDictionary()
        {
            return new DrugSetupBLL().GetDrugCompanyDictionary();
        }
        public List<DrugMaster> GetDrugListCompanyWise(string company)
        {
            return new DrugSetupBLL().GetDrugListCompanyWise(company);
        }
        public List<AH.PHRMS.MODEL.PurchaseRequisition> GetRequisitionTrack(string pharmacyid, string startDate, string endDate)
        {
            return new PHRMSSetupBLL().GetRequisitionTrack(pharmacyid,startDate,endDate);
        }
        public List<AH.PHRMS.MODEL.PurchaseOrder> GetPOTracking(string pharmacyid, string startDate, string endDate)
        {
            return new PHRMSSetupBLL().GetPOTracking(pharmacyid,startDate,endDate);
        }
        public List<AH.PHRMS.MODEL.PurchaseOrder> GetPOTrackingByPrId(string prid)
        {
            return new PHRMSSetupBLL().GetPOTrackingByPrId(prid);
        }
        public List<AH.PHRMS.MODEL.MaterialReceive> GetMrrTracking(string pharmacyid, string startDate, string endDate)
        {
            return new PHRMSSetupBLL().GetMrrTracking(pharmacyid,startDate,endDate);
        }
        public List<AH.PHRMS.MODEL.MaterialReceive> GetMrrTrackingByPONo(string poid)
        {
            return new PHRMSSetupBLL().GetMrrTrackingByPONo(poid);
        }
        public List<DrugRoute> GetDrugRoute()
        {
            return new DrugSetupBLL().GetDrugRoute();
        }
        public string SaveDrugRoute(DrugRoute odrug)
        {
            return new DrugSetupBLL().SaveDrugRoute(odrug);
        }
        public short ModifyDrugRoute(DrugRoute odrug)
        {
            return new DrugSetupBLL().ModifyDrugRoute(odrug);
        }
        public int VarifyDuplicateBatch(string phrid,string drugid,string batchno)
        {
            return new MaterialReceiveBLL().VarifyDuplicateBatch(phrid,drugid,batchno);
        }
        public int VarifyExpireDate(string phrid, string drugid)
        {
            return new MaterialReceiveBLL().VarifyExpireDate(phrid,drugid);
        }
        public string SaveDemandRequisition(AH.PHRMS.MODEL.DemandRequisition odr)
        {
            return new AH.PHRMS.BLL.DRSetupBLL().SaveDemandRequisition(odr);
        }
        public string SaveTransferRequisition(AH.PHRMS.MODEL.TransferRequisition otr)
        {
            return new AH.PHRMS.BLL.TRSetupBLL().SaveTransferRequisition(otr);
        }
        public List<PharmacyUser> GetUserByID(string userid)
        {
            return new PHRMSSetupBLL().GetUserByID(userid);
        }
        public List<AH.PHRMS.MODEL.TransferRequisition> GetTRID(string pharmacy)
        {
            return new AH.PHRMS.BLL.TRSetupBLL().GetTRID(pharmacy);
        }
        public List<AH.PHRMS.MODEL.TransferRequisition> GetTRDetails(string trid)
        {
            return new AH.PHRMS.BLL.TRSetupBLL().GetTRDetails(trid);
        }
        public List<AH.PHRMS.MODEL.MaterialReceive> GetDrugDetailsBatch(string trid, string drugid, string pharmacyid)
        {
            return new AH.PHRMS.BLL.TRSetupBLL().GetDrugDetailsBatch(trid, drugid, pharmacyid);
        }
        public string SaveTransferReceive(AH.PHRMS.MODEL.TransferReceive otr)
        {
            return new AH.PHRMS.BLL.TRSetupBLL().SaveTransferReceive(otr);
        }
        public List<AH.INVMS.MODEL.WarehouseConfig> GetWarehouse()
        {
            return new AH.INVMS.BLL.InventorySetupBLL().GetWarehouse();
        }
        public List<AH.INVMS.MODEL.WarehouseConfig> GetWarehouseTypewise(string phr,string str)
        {
            return new AH.INVMS.BLL.InventorySetupBLL().GetWarehouseTypewise(phr,str);
        }
        public List<DrugMaster> GetDrugStockByPharmacy(string drugName, string pharmacy)
        {
            return new PHRMSSetupBLL().GetDrugStockByPharmacy(drugName,pharmacy);
        }
        public List<AH.PHRMS.MODEL.TransferRequisition> GetTRDetSearch()
        {
            return new AH.PHRMS.BLL.TRSetupBLL().GetTRDetSearch();
        }
        public List<WarehouseConfig> GetWhTypeforCentral(string warehouse, string type)
        {
            return new AH.INVMS.BLL.InventorySetupBLL().GetWhTypeforCentral(warehouse,type);
        }
        public List<AH.PHRMS.MODEL.SalesReportRO> GetSalRetReport(string issueid)
        {
            return new PHRMSReportBLL().GetSalRetReport(issueid);
        }
        public List<AH.PHRMS.MODEL.SalesReportRO> GetSalRetReportDet(string startDate, string endDate)
        {
            return new PHRMSReportBLL().GetSalRetReportDet(startDate, endDate);
        }
    }
}
