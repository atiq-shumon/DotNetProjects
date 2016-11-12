using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.ATMS.MODEL;
using AH.ACCMS.MODEL;

namespace AH.ATMS.Facade
{
    
    [ServiceContract]
    public interface IATMSWS
    {
        //[OperationContract]
        //short SaveDepartment(Department Dept);
        //[OperationContract]
        //short SaveGroup(AssetsGroup group);
        //[OperationContract]
        //List<AssetsGroup> GetAssetsGroupTree();
        //[OperationContract]
        //Dictionary<string, string> Gegroup(string Control, string Where);
        //[OperationContract]
        //short SaveBrand(Brand Brnd);
        //[OperationContract]
        //List<Brand> GeBrandTree(string Control, string Where);
        //[OperationContract]
        //short ProcessGenerated(ProcessGenerated Process);
        //[OperationContract]
        //List<MaterialReceipt> GeAgsinstRefNo(string Control, string Where);
        //[OperationContract]
        //List<MaterialReceipt> DisplayDetailsAgainsrRef(string Control, string Where);
        //[OperationContract]
        //Dictionary<string, string> GetSupplierID(string Control, string Where);
        //[OperationContract]
        //string SaveMaterialReceipt(MaterialReceipt mrr);
        //[OperationContract]
        //short SaveMaterialReceiptTran(string strMrrNo, int vType, string strProductID, string strBarndID, string strModelNo,
        //                                      string strUnit, string strSlNo, string des1, string des2, string des3, double dblQty,
        //                                          double dblRate, double dblAmount, string strExpDate, MaterialReceipt mrr);
        //[OperationContract]
        //Dictionary<string, string> GetDepartment(string Control, string Where);
        //[OperationContract]
        //short SaveAssetsUser(string strDepID, string strUserID, long lngUerNo, string formName, AssetsUser assets);
        //[OperationContract]
        //List<AssetsUser> GetLastNo(string Control, string Where);
        //[OperationContract]
        //List<AssetsUser> GetAssetsUserStatus(string Control, string Where);
        //[OperationContract]
        //List<MaterialReceipt> DisplayBrandDetails(string Control, string Where);
        //[OperationContract]
        //short SaveAdditionalInfo(AdditionalInformation Addiinfo);
        //[OperationContract]
        //short SaveAdditionalCompInfo(AdditionalInformation Addiinfo);
        //[OperationContract]
        //List<AdditionalInformation> DisplayAddInformation(string Control, string Where);
        //[OperationContract]
        //Dictionary<string, string> GetAssetsUsertoDep(string Control, string Where);
        //[OperationContract]
        //List<MaterialReceipt> GetTotalQty(string Control, string Where);
        //[OperationContract]
        //string SaveMatIssue(AssetsIssue issue);
        //[OperationContract]
        //short SaveMaterialIssueTran(string strIssueNo, int vType, string strProductID, string strBarndID, string strModelNo,
        //                                      string strUnit, string strSlNo, string des1, string des2, string des3, double dblQty,
        //                                          double dblRate, double dblAmount, string strExpDate, AssetsIssue issue);
        [OperationContract]
        short SaveServiceWarrenty(ServiceWarrenty service);
        [OperationContract]
        short DeleteServiceWarrenty(string strTagNo);
        //[OperationContract]
        //List<ServiceWarrenty> GetwarrentyService(string Control, string Where);
        //[OperationContract]
        //List<MaterialReceipt> DisplayvoucherDetails(string Control, string Where);
        //[OperationContract]
        //short UpdatevoucherMaster(AssetsIssue issue);
        //[OperationContract]
        //short UpdatevoucherTran(AssetsIssue Issue);
        //[OperationContract]
        ////Dictionary<string, string> GetMrrNo(string Control, string Where);
        //List<MaterialReceipt> GetMrrNo(string Control, string Where);
        //[OperationContract]
        //List<MaterialReceipt> DisplayDetaialstoMrr(string Control, string Where);
        //[OperationContract]
        //int UpdateMaterialReceipt(MaterialReceipt mrr);
        //[OperationContract]
        //short UpdateMaterialReceiptTran(string strMrrNo, string strTranID, int vType, string strProductID, string strBarndID, string strModelNo,
        //                                       string strUnit, string strSlNo, string des1, string des2, string des3, double dblQty,
        //                                           double dblRate, double dblAmount, string strExpDate, MaterialReceipt mrr);
        //[OperationContract]
        //List<AssetsIssue> GetAssetsUserInfo(string Control, string Where, string Where1);
        [OperationContract]
        List<VoucherRo> DisplayvoucherReport(string Control, int  Where, string Where1);
        [OperationContract]
        List<VoucherRo> DisplayvoucherIssueReport(string Control, int Where, string Where1);
        [OperationContract]
        short SaveServiceProviderInfor(ServiceProvider Sp);
        [OperationContract]
        short UpdateServiceProviderInfor(ServiceProvider Sp);
        [OperationContract]
        List<ServiceProvider> GetDetailsInformation(string Control, string Where);
        [OperationContract]
        short SaveServiceDetails(string strSLNo, string strservID, string strServdate, string strReturnDate,
                                           string strExperetdate, string strRemarks, int status, ServiceDetails Sd);

        [OperationContract]
        //Dictionary<string, string> GetServiceProviderInfo(string Control, string Where);
        //[OperationContract]
        List<ServiceProvider> GetServiceProviderInfo(string Control, string Where);
        [OperationContract]
        List<ServiceProvider> GetServiceDetailsofSlno(string Control, string Where);
        [OperationContract]
        short DeleteServiceDetails(string strSLNo);
        [OperationContract]
        Dictionary<string, string> GetServiceProvider(string Control, string Where);
        [OperationContract]
        List<AssetsGroup> GetInvGroup(string Control, string Where);
        [OperationContract]
        List<AssetsIssue> GetProductIssue(string Control, string Where);
        //[OperationContract]
        //Dictionary<string, string> GetStoreID();
        //[OperationContract]
        //short SaveTermsNCondition(TermsandCondition tc);
        //[OperationContract]
        //short UpdateTermsNCondition(TermsandCondition tc);
        //[OperationContract]
        //List<TermsandCondition> GetTermsNCondtion();
        //[OperationContract]
        //short SaveStoreType(StoreType St);
        //[OperationContract]
        //short UpdateStoreType(StoreType St);
        //[OperationContract]
        //List<StoreType> GetStoreType();
        //[OperationContract]
        //short SaveMajorGrp(Majorgroup Mg);
        //[OperationContract]
        //short Update_Majorgroup(Majorgroup Mg);
        //[OperationContract]
        //List<Majorgroup> GetMajorGrp();
        //[OperationContract]
        //Dictionary<string, string> GetStoreTypeofGroup();
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
        List<StoreType> GetStoreWhstoretype();
        [OperationContract]
        List<InvGroups> GetStockWHGroup();
        //[OperationContract]
        //List<InvLocation> GetStockWHLocation();
        [OperationContract]
        Dictionary<string, string> GetHkwarehouseType(string whtype);
        [OperationContract]
        List<Warehouse> GeHktwarehouse(string where);
        [OperationContract]
        List<HkItem> GethkItem(string strGroup, string strType, string strLocation);
        [OperationContract]
        string SaveIomaster(IOmaster IOmaster);
        [OperationContract]
        short SaveIoDetails(string RefID, string itemCode, double dblqty, int statustype, string strRemarks,string Istatus, IOmaster IOmaster);
        [OperationContract]
        List<IOmaster> GetHkDirtyItem(string strWhi, int intstatus);
        [OperationContract]
        List<IOmaster> GetHkArchiveLog(string strWhi);
        [OperationContract]
        Dictionary<string, string> GetNurseStationDic(string type);
        [OperationContract]
        List<WarehouseStoreRO> GetWarehouseStoreReport(string pFadte, string pTdate, string strStoreType);
        [OperationContract]
        List<IOmaster> DisplayReceiptInformation(string strStoreType, string where);
        [OperationContract]
        List<IOmaster> GetWarehouseItem(string strStoreType);
        [OperationContract]
        short UpdateIoDetails(string RefID, string itemCode, double dblqty, int statustype, string strRemarks, string Istatus, IOmaster IOmaster);
        [OperationContract]
        int UpdateIomaster(IOmaster IOmaster);
        [OperationContract]
        List<IOmaster> GetWarehouseIssueItem(string strStoreType, string strActive);
        [OperationContract]
        List<IOmaster> DisplayIssueInformation(string strStoreType, string where);
        [OperationContract]
        Dictionary<string, string> LoadCategory();
        [OperationContract]
        List<CostCategoryTreeview> GetCostcenterTreeview(string control, string Where, string Where1);
        [OperationContract(Name = "GetBuildingDict")]
        Dictionary<string, string> GetBuildings(string type);
        [OperationContract(Name = "GetDepartmentDict")]
        Dictionary<string, string> GetDepartments(string type);
        [OperationContract]
        List<short> GetNumbers(short min, short max);


    }
}
