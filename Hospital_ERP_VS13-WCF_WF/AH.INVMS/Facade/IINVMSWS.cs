using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.INVMS.MODEL;
using AH.HR.MODEL;
using AH.ACCMS.MODEL;
using AH.Shared.MODEL;


namespace AH.INVMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IINVMSWS" in both code and config file together.
    [ServiceContract]
    public interface IINVMSWS
    {
        [OperationContract]
        short SaveCompanyDetails(CompanySetup ocompany);
        [OperationContract]
        List<AH.INVMS.MODEL.CompanySetup> GetCompanyDetails();
        [OperationContract]
        short ModifyCompanyDetails(CompanySetup ocompany);
        [OperationContract]
        short SaveGroupDetails(GroupDetails ogroup);
        [OperationContract]
        List<AH.INVMS.MODEL.GroupDetails> GetGroupDetails();
        [OperationContract]
        short ModifyGroupDetails(GroupDetails ogroup);
        [OperationContract]
        short SaveUnitDetails(Units ounit);
        [OperationContract]
        List<AH.INVMS.MODEL.Units> GetUnitSetup();
        [OperationContract]
        short ModifyUnitDetails(Units ounit);
        [OperationContract]
        short SavePacketType(PacketType otype);
        [OperationContract]
        List<AH.INVMS.MODEL.PacketType> GetPacketType();
        [OperationContract]
        short ModifyPacketType(PacketType otype);
        [OperationContract]
        short SaveModelDetails(ModelSetup omodel);
        [OperationContract]
        List<AH.INVMS.MODEL.ModelSetup> GetModelDetails();
        [OperationContract]
        short ModifyModelDetails(ModelSetup omodel);
        [OperationContract]
        short SaveBrandDetails(BrandSetup obrand);
        [OperationContract]
        List<AH.INVMS.MODEL.BrandSetup> GetBrandDetails();
        [OperationContract]
        short ModifyBrandDetails(BrandSetup obrand);
        [OperationContract]
        short SaveSupplier(Supplier osupplier);
        [OperationContract]
        List<Supplier> GetSupplierList();
        [OperationContract]
        List<Supplier> GetSupplierByName(string suppliername);
        [OperationContract]
        short ModifySupplierList(Supplier osupplier);
        [OperationContract]
        short SaveItemMaster(ItemMaster omaster);
        [OperationContract]
        List<ItemMaster> GetItemMaster();
        [OperationContract]
        List<ItemMaster> GetItemMasterByGroup(string grpid);
        [OperationContract]
        List<ItemMaster> GetItemsByName(string itemname, string storeid);
        [OperationContract]
        short ModifyItemMaster(ItemMaster omaster);
        [OperationContract]
        List<AH.INVMS.MODEL.GroupDetails> GetGroupList(string groupname);
        [OperationContract]
        List<ItemListRO> GetItemListGroupWise(string groupid);
        [OperationContract]
        short SaveStoreLocation(StoreLocation ostore);
        [OperationContract]
        short ModifyStoreLocation(StoreLocation ostore);
        [OperationContract]
        List<StoreLocation> GetStoreLocation();
        [OperationContract]
        List<short> GetNumbers(short min, short max);
        [OperationContract(Name = "GetBuildingDict")]
        Dictionary<string, string> GetBuildings(string type);
        [OperationContract]
        string SaveDemandRequisition(DemandRequisition odemand);
        [OperationContract]
        Dictionary<string, string> GetDepartments(string type);
        //[OperationContract(Name = "GetDepartmentUnit")]
        //Dictionary<string, string> GetUnit(string type);
        [OperationContract]
        Dictionary<string, string> GetUnitDict(string Dept);
        [OperationContract]
        string SavePurchaseRequisition(PurchaseRequisition opurchase);
        [OperationContract]
        List<DemandRequisition> GetDrID();
        [OperationContract]
        List<DemandRequisition> GetDrNODeptUnitwise(string deptid, string unitid, string startDate, string endDate);
        [OperationContract]
        List<DemandRequisition> GetDrDetails(string drid);
        [OperationContract]
        string SavePurchaseOrder(PurchaseOrder opurchaseorder);
        [OperationContract]
        List<PurchaseRequisition> GetPRDetails(string prid);
        [OperationContract]
        List<PurchaseRequisition> GetPRID();
        [OperationContract]
        string SaveMrrDetails(MaterialReceive omatreceive);
        [OperationContract]
        List<PurchaseOrder> GetPONumbers();
        [OperationContract]
        List<PurchaseOrder> GetPODetails(string poid);
        [OperationContract]
        short SaveItemRates(ItemRates rate);
        [OperationContract]
        List<ItemRates> GetItemRates();
        [OperationContract]
        string SaveItemIssue(ItemIssue oitems);
        [OperationContract]
        short StartDayClose(DayEnd odayclose);
        [OperationContract]
        int VerifyDate(string strid, DateTime day);
        [OperationContract]
        List<MaterialReceive> GetOpeningEntry(string MrrID);
        [OperationContract]
        List<MaterialReceive> GetMRRNumber();
        [OperationContract]
        string VerifyOpeningItemID(string itemid, string storeid);
        [OperationContract]
        short SaveIssueRequisition(IssueRequisition oissue);
        [OperationContract]
        List<Stock> GetStockDetails(string itemname, string storeid);
        [OperationContract]
        List<StockListRO> GetStockDetailsStoreWise(string storeid);
        [OperationContract]
        List<IssueRequisition> GetIRNumbers();
        [OperationContract]
        List<IssueRequisition> GetIRDetails(string irid);
        [OperationContract]
        List<ProductLedgerRO> GetProductLedger(string prodid, string startDate, string endDate);
        [OperationContract]
        List<PODetailsRO> GetPOReportDateWise(string startDate, string endDate);
        [OperationContract]
        List<IssueReportRO> GetIssueReportDateWise(string startDate, string endDate);
        [OperationContract]
        short SaveStoreUser(StoreUser ouser);
        [OperationContract]
        List<StoreUser> GetStoreUser();
        [OperationContract]
        short SaveIssueType(IssueType otype);
        [OperationContract]
        short ModifyIssueType(IssueType otype);
        [OperationContract]
        List<IssueType> GetIssueType();
        [OperationContract]
        short SaveCostCenter(CostCenter ocost);
        [OperationContract]
        short ModifyCostCenter(CostCenter ocost);
        [OperationContract]
        List<CostCenter> GetCostCenter();
        [OperationContract]
        EmployeeMaster GetEmpMaster(string ID);
        [OperationContract]
        List<CostCenter> GetCostCenterByIssueType(string issuetype);
        [OperationContract]
        List<PODetailsRO> GetPOReport(string poid);
        [OperationContract]
        List<MrrReportRO> GetMrrReport(string mrid);
        [OperationContract]
        List<MrrReportRO> GetOpeningReport(string mrid);
        [OperationContract]
        List<CostCategoryTreeview> GetCostcategory(string control, string Where, string Where1);
        [OperationContract]
        List<CostCategoryTreeview> GetAccountCostcenter(string control, string Where, string Where1);
        [OperationContract]
        string SavePurchaseReturn(PurchaseReturn oret);
        [OperationContract]
        string SaveIssueReturn(IssueReturn oret);
        [OperationContract]
        List<MaterialReceive> GetMrrDetails(string MrrID);
        [OperationContract]
        short SaveAssetTrackerMaster(AssetTrackerMaster oasset);
        [OperationContract]
        List<ServiceProviderSCM> GetServiceProvider(string Control, string Where);
        [OperationContract]
        Dictionary<string, string> GetServiceProviderInfo(string Control, string Where);
        [OperationContract]
        List<AssetTrackerMaster> GetAssetTrackerSerialNo(string itemid);
        [OperationContract]
        short SaveStoreType(StoreTypeSCM St);
        [OperationContract]
        short UpdateStoreType(StoreTypeSCM St);
        [OperationContract]
        List<StoreTypeSCM> GetStoreType();
        [OperationContract]
        short SaveMajorGrp(Majorgroup Mg);

        [OperationContract]
        short Update_Majorgroup(Majorgroup Mg);

        [OperationContract]
        List<Majorgroup> GetMajorGrp();
        [OperationContract]
        Dictionary<string, string> GetStoreTypeofGroup();
        [OperationContract]
        List<SalesReportRO> GetSalesReport(string issueid);
        [OperationContract]
        List<GroupDetails> GetGroupByMajorGrp(string strtype, string majorgrp);
        [OperationContract]
        List<Majorgroup> GetMajorGrpByStrtype(string strtype);
        [OperationContract]
        List<ItemIssue> GetIssueDetails(string issueid);
        [OperationContract]
        List<StoreLocation> GetStoreLocByType(string strtype);
        [OperationContract]
        List<StockDetailsReportRO> GetStockDetailsReport(string grpid, string startDate, string endDate);
        [OperationContract]
        short SaveTermsandCondition(TermsAndConditions oterms);
        [OperationContract]
        short ModifyTermsandCondition(TermsAndConditions oterms);
        [OperationContract]
        List<TermsAndConditions> GetTermsandCondition();
        [OperationContract]
        List<POTermsConditionRO> GetPOTermsConditions(string poid);
        [OperationContract]
        Dictionary<string, string> GetDeptUnitDic(string DeptGrp, string deptid);
        [OperationContract]
        Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr);
        [OperationContract]
        List<AssetTrackerMaster> GetAssetSerialNoForIssueReturn(string issueid, string itemid);
        [OperationContract]
        List<ItemListGrpStrWiseRO> GetItemGroupStoretypeWise(string storetype, string majorgroup);
        [OperationContract]
        List<Warehouse> GeHktwarehouse(string where);
        [OperationContract]
        short Savewarehousetype(Warehouse Wh);
        [OperationContract]
        short Updatewarehousetype(Warehouse Wh);
        [OperationContract]
        List<Warehouse> GetWarehousetype();
        [OperationContract]
        short Savewarehouse(WarehouseConfig Wh);
        [OperationContract]
        short Updatewarehouse(WarehouseConfig Wh);
        [OperationContract]
        List<WarehouseConfig> GetWarehouse();
        [OperationContract]
        List<WarehouseConfig> LoadWarehouse();
        [OperationContract]
        List<CostCategoryTreeview> GetCostcenterTreeview(string control, string Where, string Where1);
        [OperationContract]
        Dictionary<string, string> GetNurseStationDic(string type);
        [OperationContract]
        Dictionary<string, string> LoadCategory();
        [OperationContract]
        Dictionary<string, string> GetSupplierLedger(string Ledgergroup);
        [OperationContract]
        List<DemandRequisition> GetRequisitionVerifiedBy(string deptid, string unitid,string userid);
        [OperationContract]
        short VerifyDemandRequisition(DemandRequisition odemand);
        [OperationContract]
        List<PurchaseRequisition> GetRequisitionTrack(string storeid, string startDate, string endDate);
        [OperationContract]
        List<PurchaseOrder> GetPOTracking(string storeid, string startDate, string endDate);
        [OperationContract]
        List<MaterialReceive> GetMrrTracking(string storeid, string startDate, string endDate);
        [OperationContract]
        List<PurchaseOrder> GetPOTrackingByPrId(string prid);
        [OperationContract]
        List<MaterialReceive> GetMrrTrackingByPONo(string poid);
        [OperationContract]
        List<MaterialReceive> GetMrrDetailsForPurchaseReturn(string mrrid);
        [OperationContract]
        int VarifyItemForReturn(string mrrid,string itemid);
        [OperationContract]
        List<ItemMaster> GetItemStockList(string grpid);
        [OperationContract]
        int VarifyDemandReqNo(string drid);
        [OperationContract]
        List<DemandRequisition> GetDrDetailsDeptUnitWise(string deptid, string unitid);
        [OperationContract]
        int VarifyPurchaseReqNo(string prid);
        [OperationContract]
        List<PurchaseRequisition> GetPrDetailsDeptUnitWise(string storetypeid);
        [OperationContract]
        List<PRReportRO> GetPRreport(string prid);
        [OperationContract]
        List<StockReportGroupwiseRO> GetStockReportGroupwise(string startDate, string endDate);
        [OperationContract]
        List<IssueReportRO> GetIssueReportGroupWise(string groupid, string startDate, string endDate);
        [OperationContract]
        List<PurchaseOrder> GetPORecord(string itemid);
        [OperationContract]
        List<ItemMaster> GetItemStockListAll();
        [OperationContract]
        List<ItemOrder> GetItemDetailsBatch(string itemid, string drid);
        [OperationContract]
        List<StoreTypeSCM> LoadStoreType();
        [OperationContract]
        List<ItemMaster> GetItemsForOpening(string itemname, string storeid);
        [OperationContract]
        short ModifyPurchaseRequisition(PurchaseRequisition opurchase);
        [OperationContract]
        int VarifyPRForModify(string prid);
        [OperationContract]
        List<PurchaseRequisition> GetPRDetailsForPR(string prid);
        [OperationContract]
        List<MaterialReceiveRO> GetMrrReportDateWise(string startDate, string endDate);
        [OperationContract]
        List<DRReportRO> GetDRreport(string drid);
        [OperationContract]
        int VarifyPOForModify(string poid);
        [OperationContract]
        List<DemandRequisition> GetDrVerifiedbyList(string verifyid);
        [OperationContract]
        List<WarehouseConfig> GetWarehouseTypewise(string phr,string str);
        [OperationContract]
        List<WarehouseConfig> GetWhTypeforCentral(string warehouse, string type);
        [OperationContract]
        string SaveTransferRequisition(TransferRequisition otr);
        [OperationContract]
        List<WarehouseConfig> GetWhTypeforSCM(string warehouse, string type);
        [OperationContract]
        List<ItemMaster> GetItemsByNameForTransfer(string itemname, string storeid);
        [OperationContract]
        string SaveTransferReceive(AH.INVMS.MODEL.TransferReceive otr);
        [OperationContract]
        List<AH.INVMS.MODEL.TransferRequisition> GetTRID(string store);
        [OperationContract]
        List<AH.INVMS.MODEL.TransferRequisition> GetTRDetails(string trid);
        [OperationContract]
        List<AH.INVMS.MODEL.MaterialReceive> GetItemDetBatchTransfer(string trid, string itemid, string storeid);
        [OperationContract]
        List<ItemOrder> GetItemStockForNS(string grpid, string strid);
        [OperationContract]
        List<AH.INVMS.MODEL.TransferRequisition> GetTRDetSearch();
    }
}
