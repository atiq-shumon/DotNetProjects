using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.ATMS.MODEL;
using AH.ATMS.BLL;
using AH.ACCMS.BLL;
using AH.ACCMS.MODEL;
using AH.PRMS.BLL;
using AH.DUtility;
using AH.ORGMS.BLL;


namespace AH.ATMS.Facade
{
    public class ATMSWS : IATMSWS
    {
       // public short SaveDepartment(Department Dept)
       // {
       //     return new AtmsBll().SaveDepartment(Dept);
       // }
       // public short SaveGroup(AssetsGroup group)
       // {
       //     return new AtmsBll().SaveGroup(group);
       // }
       // public List<AssetsGroup> GetAssetsGroupTree()
       // {
       //     return new CollectionBll().GetAssetsGroupTree();
       // }
       // public Dictionary<string, string> Gegroup(string Control, string Where)
       // {
       //     return new CollectionBll().Gegroup(Control, Where);

       // }
       //public short SaveBrand(Brand  Brnd)
       // {
       //     return new AtmsBll().SaveBrand(Brnd);
       // }
       // public List<Brand> GeBrandTree(string Control, string Where)
       //{
       //    return new CollectionBll().GeBrandTree(Control, Where);
       //}
       // public short ProcessGenerated(ProcessGenerated Process)
       // {
       //     return new AtmsBll().ProcessGenerated(Process);
       // }
       // public List<MaterialReceipt> GeAgsinstRefNo(string Control, string Where)
       // {
       //     return new CollectionBll().GeAgsinstRefNo(Control, Where);
       // }
       // public List<MaterialReceipt> DisplayDetailsAgainsrRef(string Control, string Where)
       // {
       //     return new CollectionBll().DisplayDetailsAgainsrRef(Control, Where);
       // }
       //public Dictionary<string, string> GetSupplierID(string Control, string Where)
       
       // {
       //     return new CollectionBll().GetSupplierID(Control, Where);

       // }
       //public string SaveMaterialReceipt(MaterialReceipt mrr)
       //{
       //    return new AtmsBll().SaveMaterialReceipt(mrr);
       //}
       //public short SaveMaterialReceiptTran(string strMrrNo, int vType, string strProductID, string strBarndID, string strModelNo,
       //                                        string strUnit, string strSlNo, string des1, string des2, string des3, double dblQty,
       //                                            double dblRate, double dblAmount, string strExpDate, MaterialReceipt mrr)
       //{
       //    return new AtmsBll().SaveMaterialReceiptTran(strMrrNo, vType, strProductID, strBarndID, strModelNo, strUnit, strSlNo, des1, des2, des3, dblQty, dblRate, dblAmount, strExpDate, mrr);
       //}
       //public Dictionary<string, string> GetDepartment(string Control, string Where)
       //{
       //    return new CollectionBll().GetDepartment(Control, Where);
       //}
       //public short SaveAssetsUser(string strDepID,string strUserID,long lngUerNo,string formName,  AssetsUser assets)
       //{
       //    return new AtmsBll().SaveAssetsUser(strDepID, strUserID, lngUerNo, formName, assets);
       //}
       // public List<AssetsUser> GetLastNo(string Control, string Where)
       //{
       //    return new CollectionBll().GetLastNo(Control, Where);
       //}
       // public List<AssetsUser> GetAssetsUserStatus(string Control, string Where)
       // {
       //     return new CollectionBll().GetAssetsUserStatus(Control, Where);
       // }
       // public List<MaterialReceipt> DisplayBrandDetails(string Control, string Where)
       // {
       //     return new CollectionBll().DisplayBrandDetails(Control, Where);
       // }
       // public short SaveAdditionalInfo(AdditionalInformation Addiinfo)
       // {
       //     return new AtmsBll().SaveAdditionalInfo(Addiinfo);
       // }
       // public short SaveAdditionalCompInfo(AdditionalInformation Addiinfo)
       // {
       //     return new AtmsBll().SaveAdditionalCompInfo(Addiinfo);
       // }
       // public List<AdditionalInformation> DisplayAddInformation(string Control, string Where)
       // {
       //     return new CollectionBll().DisplayAddInformation(Control, Where);
       // }
       // public Dictionary<string, string> GetAssetsUsertoDep(string Control, string Where)
       // {
       //     return new CollectionBll().GetAssetsUsertoDep(Control, Where);
       // }
       // public List<MaterialReceipt> GetTotalQty(string Control, string Where)
       // {
       //     return new CollectionBll().GetTotalQty(Control, Where);
       // }
       // public string SaveMatIssue(AssetsIssue issue)
       // {
       //     return new AtmsBll().SaveMatIssue(issue);
       // }
       // public short SaveMaterialIssueTran(string strIssueNo, int vType, string strProductID, string strBarndID, string strModelNo,
       //                                        string strUnit, string strSlNo, string des1, string des2, string des3, double dblQty,
       //                                            double dblRate, double dblAmount, string strExpDate, AssetsIssue issue)
       // {
       //     return new AtmsBll().SaveMaterialIssueTran(strIssueNo, vType, strProductID, strBarndID, strModelNo, strUnit,
       //                        strSlNo, des1, des2, des3, dblQty, dblRate, dblAmount, strExpDate, issue);
       // }
        public short SaveServiceWarrenty(ServiceWarrenty service)
        {
            return new AtmsBll().SaveServiceWarrenty(service);
        }
        public short DeleteServiceWarrenty(string strTagNo)
        {
            return new AtmsBll().DeleteServiceWarrenty(strTagNo);

        }
        //public List<ServiceWarrenty> GetwarrentyService(string Control, string Where)
        //{
        //    return new CollectionBll().GetwarrentyService(Control, Where);

        //}
        //public List<MaterialReceipt> DisplayvoucherDetails(string Control, string Where)
        //{
        //    return new CollectionBll().DisplayvoucherDetails(Control, Where);
        //}
        //public short UpdatevoucherMaster(AssetsIssue issue)
        //{
        //    return new AtmsBll().UpdatevoucherMaster(issue);
        //}
        //public short UpdatevoucherTran(AssetsIssue Issue)
        //{
        //    return new AtmsBll().UpdatevoucherTran(Issue);
        //}

        //public List<MaterialReceipt> GetMrrNo(string Control, string Where)
        //{
        //    return new CollectionBll().GetMrrNo(Control, Where);
        //}
        ////public Dictionary<string, string> GetMrrNo(string Control, string Where)
        ////{
        ////    return new CollectionBll().GetMrrNo(Control, Where);
        ////}
        //public List<MaterialReceipt> DisplayDetaialstoMrr(string Control, string Where)
        //{
        //    return new CollectionBll().DisplayDetaialstoMrr(Control, Where);
        //}
        //public int UpdateMaterialReceipt(MaterialReceipt mrr)
        //{
        //    return new AtmsBll().UpdateMaterialReceipt(mrr);
        //}

        //public short UpdateMaterialReceiptTran(string strMrrNo, string strTranID, int vType, string strProductID, string strBarndID, string strModelNo,
        //                                       string strUnit, string strSlNo, string des1, string des2, string des3, double dblQty,
        //                                           double dblRate, double dblAmount, string strExpDate, MaterialReceipt mrr)
        //{
        //    return new AtmsBll().UpdateMaterialReceiptTran(strMrrNo, strTranID, vType, strProductID, strBarndID, strModelNo, strUnit, strSlNo, des1, des2, des3,
        //                                                    dblQty, dblRate, dblAmount, strExpDate, mrr);
        //}
        //public List<AssetsIssue> GetAssetsUserInfo(string Control, string Where, string Where1)
        //{
        //    return new CollectionBll().GetAssetsUserInfo(Control, Where, Where1);
        //}
        public List<VoucherRo> DisplayvoucherReport(string Control, int Where, string Where1)
        {
            return new CollectionBll().DisplayvoucherReport(Control, Where, Where1);
        }
        public List<VoucherRo> DisplayvoucherIssueReport(string Control, int Where, string Where1)
        {
            return new CollectionBll().DisplayvoucherIssueReport(Control, Where, Where1);
        }
        public short SaveServiceProviderInfor(ServiceProvider Sp)
        {
            return new AtmsBll().SaveServiceProviderInfor(Sp);
        }
        public short UpdateServiceProviderInfor(ServiceProvider Sp)
        {
            return new AtmsBll().UpdateServiceProviderInfor(Sp);
        }
        public List<ServiceProvider> GetDetailsInformation(string Control, string Where)
        {
            return new AtmsBll().GetDetailsInformation(Control, Where);
        }
        public short SaveServiceDetails(string strSLNo, string strservID, string strServdate, string strReturnDate,
                                          string strExperetdate, string strRemarks, int status, ServiceDetails Sd)
        {
            return new AtmsBll().SaveServiceDetails(strSLNo, strservID, strServdate, strReturnDate, strExperetdate, strRemarks, status, Sd);
        }

        public List<ServiceProvider> GetServiceProviderInfo(string Control, string Where)
        {
            return new AtmsBll().GetServiceProviderInfo(Control, Where);
        }
        public List<ServiceProvider> GetServiceDetailsofSlno(string Control, string Where)
        {
            return new AtmsBll().GetServiceDetailsofSlno(Control, Where);
        }
        public short DeleteServiceDetails(string strSLNo)
        {
            return new AtmsBll().DeleteServiceDetails(strSLNo);
        }
        public Dictionary<string, string> GetServiceProvider(string Control, string Where)
        {
            return new AtmsBll().GetServiceProvider(Control, Where);
        }
        public List<AssetsGroup> GetInvGroup(string Control, string Where)
        {
            return new AtmsBll().GetInvGroup(Control, Where);
        }
        public List<AssetsIssue> GetProductIssue(string Control, string Where)
        {
            return new AtmsBll().GetProductIssue(Control, Where);
        }
     //  public Dictionary<string, string> GetStoreID()
     //  {
     //      return new CollectionBll().GetStoreID();
     //  }

     //  public short SaveTermsNCondition(TermsandCondition tc)
     //  {
     //      return new CollectionBll().SaveTermsNCondition(tc);
     //  }
     //  public short UpdateTermsNCondition(TermsandCondition tc)
     //  {
     //      return new CollectionBll().UpdateTermsNCondition(tc);
     //  }

     //  public List<TermsandCondition> GetTermsNCondtion()
     //  {
     //      return new CollectionBll().GetTermsNCondtion();
     //  }

     //  public short SaveStoreType(StoreType St)
     //  {
     //      return new AtmsBll().SaveStoreType(St);
     //  }
     //  public short UpdateStoreType(StoreType St)
     //  {
     //      return new AtmsBll().UpdateStoreType(St);
     //  }
     //  public List<StoreType> GetStoreType()
     //  {
     //      return new AtmsBll().GetStoreType();
     //  }

     //public short SaveMajorGrp(Majorgroup Mg)
     //  {
     //      return new AtmsBll().SaveMajorGrp(Mg);
     //  }
     // public short Update_Majorgroup(Majorgroup Mg)
     // {
     //     return new AtmsBll().Update_Majorgroup(Mg);
     // }

     //public List<Majorgroup> GetMajorGrp()
     // {
     //     return new AtmsBll().GetMajorGrp();
     // }

     //public Dictionary<string, string> GetStoreTypeofGroup()
     //{
     //    return new AtmsBll().GetStoreTypeofGroup();
     //}

     public short Savewarehousetype(Warehouse Wh)
     {
         return new AtmsBll().Savewarehousetype(Wh);
     }

     public short Updatewarehousetype(Warehouse Wh)
     {
         return new AtmsBll().Updatewarehousetype(Wh);
     }

     public List<Warehouse> GetWarehousetype()
     {
         return new AtmsBll().GetWarehousetype();
     }
     public List<WarehouseConfig> LoadWarehouse()
     {
         return new AtmsBll().LoadWarehouse();
     }
     public short Savewarehouse(WarehouseConfig Wh)
     {
         return new AtmsBll().Savewarehouse(Wh);
     }

     public short Updatewarehouse(WarehouseConfig Wh)
     {
         return new AtmsBll().Updatewarehouse(Wh);
     }
     public List<WarehouseConfig> GetWarehouse()
     {
         return new AtmsBll().GetWarehouse();
     }

    //***********************
     public List<StoreType> GetStoreWhstoretype()
     {
         return new AtmsBll().GetStoreWhstoretype();
     }
     public List<InvGroups> GetStockWHGroup()
     {
         return new AtmsBll().GetStockWHGroup();
     }

     //public List<InvLocation> GetStockWHLocation()
     //{
     //    return new AtmsBll().GetStockWHLocation();
     //}


     public Dictionary<string, string> GetHkwarehouseType(string whtype)
     {
         return new AtmsBll().GetHkwarehouseType(whtype);
     }

     public List<Warehouse> GeHktwarehouse(string where)
     {
         return new AtmsBll().GeHktwarehouse(where);
     }

     public List<HkItem> GethkItem(string strGroup, string strType, string strLocation)
     {
         return new AtmsBll().GethkItem(strGroup, strType, strLocation);
     }

     public string SaveIomaster(IOmaster IOmaster)
     {
         return new AtmsBll().SaveIomaster(IOmaster);
     }
     public short SaveIoDetails(string RefID, string itemCode, double dblqty, int statustype, string strRemarks, string Istatus, IOmaster IOmaster)
     {
         return new AtmsBll().SaveIoDetails(RefID, itemCode, dblqty, statustype, strRemarks, Istatus, IOmaster);
     }
     public List<IOmaster> GetHkDirtyItem(string strWhi, int intstatus)
     {
         return new AtmsBll().GetHkDirtyItem(strWhi, intstatus);
     }
     public List<IOmaster> GetHkArchiveLog(string strWhi)
     {
         return new AtmsBll().GetHkArchiveLog(strWhi);
     }
     public Dictionary<string, string> GetNurseStationDic(string type)
     {
         return new NurseStationBLL().GetNurseStationDic(type);
     }
     public List<WarehouseStoreRO> GetWarehouseStoreReport(string pFadte, string pTdate, string strStoreType)
     {
         return new AtmsBll().GetWarehouseStoreReport(pFadte, pTdate, strStoreType);
     }

     public List<IOmaster> DisplayReceiptInformation(string strStoreType, string where)
     {
         return new AtmsBll().DisplayReceiptInformation(strStoreType,where);
     }
     public List<IOmaster> GetWarehouseItem(string strStoreType)
     {
         return new AtmsBll().GetWarehouseItem(strStoreType);
     }
     public int UpdateIomaster(IOmaster IOmaster)
     {
         return new AtmsBll().UpdateIomaster(IOmaster);

     }
     public short UpdateIoDetails(string RefID, string itemCode, double dblqty, int statustype, string strRemarks, string Istatus, IOmaster IOmaster)
     {
         return new AtmsBll().UpdateIoDetails(RefID, itemCode, dblqty, statustype, strRemarks, Istatus, IOmaster);

     }
     public List<IOmaster> GetWarehouseIssueItem(string strStoreType, string strActive)
     {
         return new AtmsBll().GetWarehouseIssueItem(strStoreType, strActive);
     }
     public List<IOmaster> DisplayIssueInformation(string strStoreType, string where)
     {
         return new AtmsBll().DisplayIssueInformation(strStoreType, where);
     }
     public Dictionary<string, string> LoadCategory()
     {
         return new CollectionSummaryBLL().LoadCategory();
     }
     public List<CostCategoryTreeview> GetCostcenterTreeview(string control, string Where, string Where1)
     {
         return new CollectionSummaryBLL().GetCostcenterTreeview(control, Where, Where1);
     }
     public Dictionary<string, string> GetBuildings(string type)
     {
         return new PropertySetupBLL().GetBuildings(type);
     }
     public Dictionary<string, string> GetDepartments(string type)
     {
         return new AdministrationSetupBLL().GetDepartments(type);
     }
     public List<short> GetNumbers(short min, short max)
     {
         return Utility.GetNumbers(min, max);
     }



    }
}
