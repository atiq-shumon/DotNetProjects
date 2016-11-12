using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.INVMS.MODEL;
using AH.Shared.MODEL;
using AH.HR.MODEL;
using AH.ACCMS.MODEL;
using AH.INVMS.BLL;
using AH.PRMS.BLL;
using AH.ORGMS.BLL;
using AH.HR.BLL;
using AH.ACCMS.BLL;
using AH.DUtility;

namespace AH.INVMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "INVMSWS" in both code and config file together.
    public class INVMSWS : IINVMSWS
    {
        public short SaveCompanyDetails(CompanySetup ocompany)
        {
            return new InventorySetupBLL().SaveCompanyDetails(ocompany);
        }
        public List<CompanySetup> GetCompanyDetails()
        {
            return new InventorySetupBLL().GetCompanyDetails();
        }
        public short ModifyCompanyDetails(CompanySetup ocompany)
        {
            return new InventorySetupBLL().ModifyCompanyDetails(ocompany);
        }
        public short SaveGroupDetails(GroupDetails ogroup)
        {
            return new InventorySetupBLL().SaveGroupDetails(ogroup);
        }
        public List<GroupDetails> GetGroupDetails()
        {
            return new InventorySetupBLL().GetGroupDetails();
        }
        public List<GroupDetails> GetGroupList(string groupname)
        {
            return new InventorySetupBLL().GetGroupList(groupname);
        }
        public short ModifyGroupDetails(GroupDetails ogroup)
        {
            return new InventorySetupBLL().ModifyGroupDetails(ogroup);
        }
        public short SaveUnitDetails(Units ounit)
        {
            return new InventorySetupBLL().SaveUnitDetails(ounit);
        }
        public List<Units> GetUnitSetup()
        {
            return new InventorySetupBLL().GetUnitSetup();
        }
        public short ModifyUnitDetails(Units ounit)
        {
            return new InventorySetupBLL().ModifyUnitDetails(ounit);
        }
        public short SavePacketType(PacketType otype)
        {
            return new InventorySetupBLL().SavePacketType(otype);
        }
        public List<PacketType> GetPacketType()
        {
            return new InventorySetupBLL().GetPacketType();
        }
        public short ModifyPacketType(PacketType otype)
        {
            return new InventorySetupBLL().ModifyPacketType(otype);
        }
        public short SaveModelDetails(ModelSetup omodel)
        {
            return new InventorySetupBLL().SaveModelDetails(omodel);
        }
        public List<ModelSetup> GetModelDetails()
        {
            return new InventorySetupBLL().GetModelDetails();
        }
        public short ModifyModelDetails(ModelSetup omodel)
        {
            return new InventorySetupBLL().ModifyModelDetails(omodel);
        }
        public short SaveBrandDetails(BrandSetup obrand)
        {
            return new InventorySetupBLL().SaveBrandDetails(obrand);
        }
        public List<BrandSetup> GetBrandDetails()
        {
            return new InventorySetupBLL().GetBrandDetails();
        }
        public short ModifyBrandDetails(BrandSetup obrand)
        {
            return new InventorySetupBLL().ModifyBrandDetails(obrand);
        }
        public short SaveSupplier(Supplier osupplier)
        {
            return new InventorySetupBLL().SaveSupplier(osupplier);
        }
        public List<Supplier> GetSupplierList()
        {
            return new InventorySetupBLL().GetSupplierList();
        }
        public List<Supplier> GetSupplierByName(string suppliername)
        {
            return new InventorySetupBLL().GetSupplierByName(suppliername);
        }
        public short ModifySupplierList(Supplier osupplier)
        {
            return new InventorySetupBLL().ModifySupplierList(osupplier);
        }
        public short SaveItemMaster(ItemMaster omaster)
        {
            return new InventorySetupBLL().SaveItemMaster(omaster);
        }
        public List<ItemMaster> GetItemMaster()
        {
            return new InventorySetupBLL().GetItemMaster();
        }
        public  List<ItemMaster> GetItemMasterByGroup(string grpid)
        {
            return new InventorySetupBLL().GetItemMasterByGroup(grpid);
        }
        public List<ItemMaster> GetItemsByName(string itemname, string storeid)
        {
            return new InventorySetupBLL().GetItemsByName(itemname,storeid);
        }
        public short ModifyItemMaster(ItemMaster omaster)
        {
            return new InventorySetupBLL().ModifyItemMaster(omaster);
        }
        public List<ItemListRO> GetItemListGroupWise(string groupid)
        {
            return new InventoryReportBLL().GetItemListGroupWise(groupid);
        }
        public short SaveStoreLocation(StoreLocation ostore)
        {
            return new InventorySetupBLL().SaveStoreLocation(ostore);
        }
        public short ModifyStoreLocation(StoreLocation ostore)
        {
            return new InventorySetupBLL().ModifyStoreLocation(ostore);
        }
        public List<StoreLocation> GetStoreLocation()
        {
            return new InventorySetupBLL().GetStoreLocation();
        }
        public List<short> GetNumbers(short min, short max)
        {
            return Utility.GetNumbers(min,max);
        }
        public Dictionary<string, string> GetBuildings(string type)
        {
            return new PropertySetupBLL().GetBuildings(type);
        }
        public string SaveDemandRequisition(DemandRequisition odemand)
        {
            return new DRSetupBLL().SaveDemandRequisition(odemand);
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
        public string SavePurchaseRequisition(PurchaseRequisition opurchase)
        {
            return new PRSetupBLL().SavePurchaseRequisition(opurchase);
        }
        public List<DemandRequisition> GetDrID()
        {
            return new DRSetupBLL().GetDrID();
        }
        public List<DemandRequisition> GetDrNODeptUnitwise(string deptid, string unitid, string startDate, string endDate)
        {
            return new DRSetupBLL().GetDrNODeptUnitwise(deptid,unitid,startDate,endDate);
        }
        public List<DemandRequisition> GetDrDetails(string drid)
        {
            return new DRSetupBLL().GetDrDetails(drid);
        }
        public string SavePurchaseOrder(PurchaseOrder opurchaseorder)
        {
            return new POBLL().SavePurchaseOrder(opurchaseorder);
        }
        public List<PurchaseRequisition> GetPRDetails(string prid)
        {
            return new PRSetupBLL().GetPRDetails(prid);
        }
        public List<PurchaseRequisition> GetPRID()
        {
            return new PRSetupBLL().GetPRID();
        }
        public string SaveMrrDetails(MaterialReceive omatreceive)
        {
            return new MRRSetupBLL().SaveMrrDetails(omatreceive);
        }
        public List<PurchaseOrder> GetPONumbers()
        {
            return new POBLL().GetPONumbers();
        }
        public List<PurchaseOrder> GetPODetails(string poid)
        {
            return new POBLL().GetPODetails(poid);
        }
        public short SaveItemRates(ItemRates rate)
        {
            return new InventorySetupBLL().SaveItemRates(rate);
        }
        public List<ItemRates> GetItemRates()
        {
            return new InventorySetupBLL().GetItemRates();
        }
        public string SaveItemIssue(ItemIssue oitems)
        {
            return new ItemIssueBLL().SaveItemIssue(oitems);
        }
        
        
        public short StartDayClose(DayEnd odayclose)
        {
            return new DayCloseBLL().StartDayClose(odayclose);
        }
        public int VerifyDate(string strid, DateTime day)
        {
            return new DayCloseBLL().VerifyDate(strid,day);
        }
        public List<MaterialReceive> GetOpeningEntry(string MrrID)
        {
            return new MRRSetupBLL().GetOpeningEntry(MrrID);
        }
        public List<MaterialReceive> GetMRRNumber()
        {
            return new MRRSetupBLL().GetMRRNumber();
        }
        public string VerifyOpeningItemID(string itemid, string storeid)
        {
            return new MRRSetupBLL().VerifyOpeningItemID(itemid,storeid);
        }
        public short SaveIssueRequisition(IssueRequisition oissue)
        {
            return new IRSetupBLL().SaveIssueRequisition(oissue);
        }
        public List<Stock> GetStockDetails(string itemname, string storeid)
        {
            return new InventorySetupBLL().GetStockDetails(itemname,storeid);
        }
        public List<StockListRO> GetStockDetailsStoreWise(string storeid)
        {
            return new InventoryReportBLL().GetStockDetailsStoreWise(storeid);
        }
        public List<IssueRequisition> GetIRNumbers()
        {
            return new IRSetupBLL().GetIRNumbers();
        }
        public List<IssueRequisition> GetIRDetails(string irid)
        {
            return new IRSetupBLL().GetIRDetails(irid);
        }
        public List<ProductLedgerRO> GetProductLedger(string prodid, string startDate, string endDate)
        {
            return new InventoryReportBLL().GetProductLedger(prodid,startDate,endDate);
        }
        public List<PODetailsRO> GetPOReportDateWise(string startDate, string endDate)
        {
            return new InventoryReportBLL().GetPOReportDateWise(startDate,endDate);
        }
        public List<IssueReportRO> GetIssueReportDateWise(string startDate, string endDate)
        {
            return new InventoryReportBLL().GetIssueReportDateWise(startDate, endDate);
        }
        public short SaveStoreUser(StoreUser ouser)
        {
            return new InventorySetupBLL().SaveStoreUser(ouser);
        }
        public List<StoreUser> GetStoreUser()
        {
            return new InventorySetupBLL().GetStoreUser();
        }
        public short SaveIssueType(IssueType otype)
        {
            return new ItemIssueBLL().SaveIssueType(otype);
        }
        public short ModifyIssueType(IssueType otype)
        {
            return new ItemIssueBLL().ModifyIssueType(otype);
        }
        public List<IssueType> GetIssueType()
        {
            return new ItemIssueBLL().GetIssueType();
        }
        public short SaveCostCenter(CostCenter ocost)
        {
            return new ItemIssueBLL().SaveCostCenter(ocost);
        }
        public short ModifyCostCenter(CostCenter ocost)
        {
            return new ItemIssueBLL().ModifyCostCenter(ocost);
        }
        public List<CostCenter> GetCostCenter()
        {
            return new ItemIssueBLL().GetCostCenter();
        }
        public EmployeeMaster GetEmpMaster(string ID)
        {
            return new EmployeeSetUpBLL().GetEmpMaster(ID);
        }
        public List<CostCenter> GetCostCenterByIssueType(string issuetype)
        {
            return new ItemIssueBLL().GetCostCenterByIssueType(issuetype);
        }
        public List<PODetailsRO> GetPOReport(string poid)
        {
            return new InventoryReportBLL().GetPOReport(poid);
        }
        public List<MrrReportRO> GetMrrReport(string mrid)
        {
            return new InventoryReportBLL().GetMrrReport(mrid);
        }
        public List<MrrReportRO> GetOpeningReport(string mrid)
        {
            return new InventoryReportBLL().GetOpeningReport(mrid);
        }
        public List<CostCategoryTreeview> GetCostcategory(string control, string Where, string Where1)
        {
            return new CollectionSummaryBLL().GetCostcategoryTreeview(control, Where, Where1);
        }
        public List<CostCategoryTreeview> GetAccountCostcenter(string control, string Where, string Where1)
        {
            return new CollectionSummaryBLL().GetCostcenterTreeview(control, Where, Where1);
        }
        public string SavePurchaseReturn(PurchaseReturn oret)
        {
            return new MRRSetupBLL().SavePurchaseReturn(oret);
        }
        public string SaveIssueReturn(IssueReturn oret)
        {
            return new ItemIssueBLL().SaveIssueReturn(oret);
        }
        public List<MaterialReceive> GetMrrDetails(string MrrID)
        {
            return new MRRSetupBLL().GetMrrDetails(MrrID);
        }
        public short SaveAssetTrackerMaster(AssetTrackerMaster oasset)
        {
            return new MRRSetupBLL().SaveAssetTrackerMaster(oasset);
        }
        public List<ServiceProviderSCM> GetServiceProvider(string Control, string Where)
        {
            return new MRRSetupBLL().GetServiceProvider(Control,Where);
        }
        public Dictionary<string, string> GetServiceProviderInfo(string Control, string Where)
        {
            return new MRRSetupBLL().GetServiceProviderInfo(Control, Where);
        }
        public List<AssetTrackerMaster> GetAssetTrackerSerialNo(string itemid)
        {
            return new ItemIssueBLL().GetAssetTrackerSerialNo(itemid);
        }
        public short SaveStoreType(StoreTypeSCM St)
        {
            return new InventorySetupBLL().SaveStoreType(St);
        }
        public short UpdateStoreType(StoreTypeSCM St)
        {
            return new InventorySetupBLL().UpdateStoreType(St);
        }
        public List<StoreTypeSCM> GetStoreType()
        {
            return new InventorySetupBLL().GetStoreType();
        }

        public short SaveMajorGrp(Majorgroup Mg)
        {
            return new InventorySetupBLL().SaveMajorGrp(Mg);
        }
        public short Update_Majorgroup(Majorgroup Mg)
        {
            return new InventorySetupBLL().Update_Majorgroup(Mg);
        }

        public List<Majorgroup> GetMajorGrp()
        {
            return new InventorySetupBLL().GetMajorGrp();
        }

        public Dictionary<string, string> GetStoreTypeofGroup()
        {
            return new InventorySetupBLL().GetStoreTypeofGroup();
        }
        public List<SalesReportRO> GetSalesReport(string issueid)
        {
            return new InventoryReportBLL().GetSalesReport(issueid);
        }
        public List<GroupDetails> GetGroupByMajorGrp(string strtype,string majorgrp)
        {
            return new InventorySetupBLL().GetGroupByMajorGrp(strtype,majorgrp);
        }
        public List<Majorgroup> GetMajorGrpByStrtype(string strtype)
        {
            return new InventorySetupBLL().GetMajorGrpByStrtype(strtype);
        }
        public List<ItemIssue> GetIssueDetails(string issueid)
        {
            return new ItemIssueBLL().GetIssueDetails(issueid);
        }
        public List<StoreLocation> GetStoreLocByType(string strtype)
        {
            return new InventorySetupBLL().GetStoreLocByType(strtype);
        }
        public List<StockDetailsReportRO> GetStockDetailsReport(string grpid, string startDate, string endDate)
        {
            return new InventoryReportBLL().GetStockDetailsReport(grpid, startDate, endDate);
        }
        public short SaveTermsandCondition(TermsAndConditions oterms)
        {
            return new POBLL().SaveTermsandCondition(oterms);
        }
        public short ModifyTermsandCondition(TermsAndConditions oterms)
        {
            return new POBLL().ModifyTermsandCondition(oterms);
        }
        public List<TermsAndConditions> GetTermsandCondition()
        {
            return new POBLL().GetTermsandCondition();
        }
        public List<POTermsConditionRO> GetPOTermsConditions(string poid)
        {
            return new InventoryReportBLL().GetPOTermsConditions(poid);
        }
        public Dictionary<string, string> GetDeptUnitDic(string DeptGrp, string deptid)
        {
            return new AdministrationSetupBLL().GetDeptUnitDic(DeptGrp, deptid);
        }
        public Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr)
        {
            return new AdministrationSetupBLL().GetDepartmentsetupDic(type, deptgr);
        }
        public List<AssetTrackerMaster> GetAssetSerialNoForIssueReturn(string issueid,string itemid)
        {
            return new ItemIssueBLL().GetAssetSerialNoForIssueReturn(issueid,itemid);
        }
        public List<ItemListGrpStrWiseRO> GetItemGroupStoretypeWise(string storetype,string majorgroup)
        {
            return new InventoryReportBLL().GetItemGroupStoretypeWise(storetype,majorgroup);
        }
        public short Savewarehousetype(Warehouse Wh)
        {
            return new InventorySetupBLL().Savewarehousetype(Wh);
        }

        public short Updatewarehousetype(Warehouse Wh)
        {
            return new InventorySetupBLL().Updatewarehousetype(Wh);
        }

        public List<Warehouse> GetWarehousetype()
        {
            return new InventorySetupBLL().GetWarehousetype();
        }
        public short Savewarehouse(WarehouseConfig Wh)
        {
            return new InventorySetupBLL().Savewarehouse(Wh);
        }

        public short Updatewarehouse(WarehouseConfig Wh)
        {
            return new InventorySetupBLL().Updatewarehouse(Wh);
        }
        public List<WarehouseConfig> GetWarehouse()
        {
            return new InventorySetupBLL().GetWarehouse();
        }
        public List<Warehouse> GeHktwarehouse(string where)
        {
            return new InventorySetupBLL().GeHktwarehouse(where);
        }
        public List<WarehouseConfig> LoadWarehouse()
        {
            return new InventorySetupBLL().LoadWarehouse();
        }
        public List<CostCategoryTreeview> GetCostcenterTreeview(string control, string Where, string Where1)
        {
            return new CollectionSummaryBLL().GetCostcenterTreeview(control, Where, Where1);
        }
        public Dictionary<string, string> GetNurseStationDic(string type)
        {
            return new NurseStationBLL().GetNurseStationDic(type);
        }
        public Dictionary<string, string> LoadCategory()
        {
            return new CollectionSummaryBLL().LoadCategory();
        }
        public Dictionary<string, string> GetSupplierLedger(string Ledgergroup)
        {
            return new CollectionSummaryBLL().GetSupplierLedger(Ledgergroup);
        }
        public List<DemandRequisition> GetRequisitionVerifiedBy(string deptid, string unitid,string userid)
        {
            return new DRSetupBLL().GetRequisitionVerifiedBy(deptid,unitid,userid);
        }
        public short VerifyDemandRequisition(DemandRequisition odemand)
        {
            return new DRSetupBLL().VerifyDemandRequisition(odemand);
        }
        public List<PurchaseRequisition> GetRequisitionTrack(string storeid,string startDate,string endDate)
        {
            return new PRSetupBLL().GetRequisitionTrack(storeid,startDate,endDate);
        }
        public List<PurchaseOrder> GetPOTracking(string storeid,string startDate,string endDate)
        {
            return new PRSetupBLL().GetPOTracking(storeid, startDate, endDate);
        }
        public List<MaterialReceive> GetMrrTracking(string storeid,string startDate,string endDate)
        {
            return new PRSetupBLL().GetMrrTracking(storeid, startDate, endDate);
        }
        public List<PurchaseOrder> GetPOTrackingByPrId(string prid)
        {
            return new PRSetupBLL().GetPOTrackingByPrId(prid);
        }
        public List<MaterialReceive> GetMrrTrackingByPONo(string poid)
        {
            return new PRSetupBLL().GetMrrTrackingByPONo(poid);
        }
        public List<MaterialReceive> GetMrrDetailsForPurchaseReturn(string mrrid)
        {
            return new MRRSetupBLL().GetMrrDetailsForPurchaseReturn(mrrid);
        }
        public int VarifyItemForReturn(string mrrid,string itemid)
        {
            return new MRRSetupBLL().VarifyItemForReturn(mrrid,itemid);
        }
        public List<ItemMaster> GetItemStockList(string grpid)
        {
            return new InventorySetupBLL().GetItemStockList(grpid);
        }
        public int VarifyDemandReqNo(string drid)
        {
            return new DRSetupBLL().VarifyDemandReqNo(drid);
        }
        public List<DemandRequisition> GetDrDetailsDeptUnitWise(string deptid,string unitid)
        {
            return new DRSetupBLL().GetDrDetailsDeptUnitWise(deptid,unitid);
        }
        public int VarifyPurchaseReqNo(string prid)
        {
            return new PRSetupBLL().VarifyPurchaseReqNo(prid);
        }
        public List<PurchaseRequisition> GetPrDetailsDeptUnitWise(string storetypeid)
        {
            return new PRSetupBLL().GetPrDetailsDeptUnitWise(storetypeid);
        }
        public List<PRReportRO> GetPRreport(string prid)
        {
            return new InventoryReportBLL().GetPRreport(prid);
        }
        public List<StockReportGroupwiseRO> GetStockReportGroupwise(string startDate, string endDate)
        {
            return new InventoryReportBLL().GetStockReportGroupwise(startDate,endDate);
        }
        public List<IssueReportRO> GetIssueReportGroupWise(string groupid,string startDate, string endDate)
        {
            return new InventoryReportBLL().GetIssueReportGroupWise(groupid,startDate,endDate);
        }
        public List<PurchaseOrder> GetPORecord(string itemid)
        {
            return new POBLL().GetPORecord(itemid);
        }
        public List<ItemMaster> GetItemStockListAll()
        {
            return new InventorySetupBLL().GetItemStockListAll();
        }
        public List<ItemOrder> GetItemDetailsBatch(string itemid, string drid)
        {
            return new ItemIssueBLL().GetItemDetailsBatch(itemid,drid);
        }
        public List<StoreTypeSCM> LoadStoreType()
        {
            return new InventorySetupBLL().LoadStoreType();
        }
        public List<ItemMaster> GetItemsForOpening(string itemname, string storeid)
        {
            return new InventorySetupBLL().GetItemsForOpening(itemname,storeid);
        }
        public short ModifyPurchaseRequisition(PurchaseRequisition opurchase)
        {
            return new PRSetupBLL().ModifyPurchaseRequisition(opurchase);
        }
        public int VarifyPRForModify(string prid)
        {
            return new PRSetupBLL().VarifyPRForModify(prid);
        }
        public List<PurchaseRequisition> GetPRDetailsForPR(string prid)
        {
            return new PRSetupBLL().GetPRDetailsForPR(prid);
        }
        public List<MaterialReceiveRO> GetMrrReportDateWise(string startDate, string endDate)
        {
            return new MRRSetupBLL().GetMrrReportDateWise(startDate, endDate);
        }
        public List<DRReportRO> GetDRreport(string drid)
        {
            return new InventoryReportBLL().GetDRreport(drid);
        }
        public int VarifyPOForModify(string poid)
        {
            return new POBLL().VarifyPOForModify(poid);
        }
        public List<DemandRequisition> GetDrVerifiedbyList(string verifyid)
        {
            return new DRSetupBLL().GetDrVerifiedbyList(verifyid);
        }
        public List<WarehouseConfig> GetWarehouseTypewise(string phr,string str)
        {
            return new InventorySetupBLL().GetWarehouseTypewise(phr,str);
        }
        public List<WarehouseConfig> GetWhTypeforCentral(string warehouse, string type)
        {
            return new InventorySetupBLL().GetWhTypeforCentral(warehouse,type);
        }
        public string SaveTransferRequisition(TransferRequisition otr)
        {
            return new TRSetupBLL().SaveTransferRequisition(otr);
        }
        public List<WarehouseConfig> GetWhTypeforSCM(string warehouse, string type)
        {
            return new InventorySetupBLL().GetWhTypeforSCM(warehouse,type);
        }
        public List<ItemMaster> GetItemsByNameForTransfer(string itemname, string storeid)
        {
            return new InventorySetupBLL().GetItemsByNameForTransfer(itemname,storeid);
        }
        public string SaveTransferReceive(AH.INVMS.MODEL.TransferReceive otr)
        {
            return new TRSetupBLL().SaveTransferReceive(otr);
        }
        public List<AH.INVMS.MODEL.TransferRequisition> GetTRID(string store)
        {
            return new TRSetupBLL().GetTRID(store);
        }
        public List<AH.INVMS.MODEL.TransferRequisition> GetTRDetails(string trid)
        {
            return new AH.INVMS.BLL.TRSetupBLL().GetTRDetails(trid);
        }
        public List<AH.INVMS.MODEL.MaterialReceive> GetItemDetBatchTransfer(string trid, string itemid, string storeid)
        {
            return new TRSetupBLL().GetItemDetBatchTransfer(trid, itemid, storeid);
        }
        public List<ItemOrder> GetItemStockForNS(string grpid, string strid)
        {
            return new InventorySetupBLL().GetItemStockForNS(grpid,strid);
        }
        public List<AH.INVMS.MODEL.TransferRequisition> GetTRDetSearch()
        {
            return new TRSetupBLL().GetTRDetSearch();
        }
    }
}
