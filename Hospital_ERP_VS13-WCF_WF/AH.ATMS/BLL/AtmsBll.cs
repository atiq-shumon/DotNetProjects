using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AH.ATMS.DAL;
using AH.ATMS.MODEL;
using AH.ACCMS.DAL;
using AH.ACCMS.MODEL;
using System.Threading.Tasks;



namespace AH.ATMS.BLL
{
    public class AtmsBll
    {
       //public short SaveDepartment(Department Dept)
       // {
       //     return new AtmsDAL().SaveDepartment(Dept);
       // }
       // public short SaveGroup(AssetsGroup group)
       //{
       //    return new AtmsDAL().SaveGroup(group);

       //}
       // public short SaveBrand(Brand  Brnd)
       // {
       //     return new AtmsDAL().SaveBrand(Brnd);
       // }
       // public short ProcessGenerated(ProcessGenerated Process)
       // {
       //     return new AtmsDAL().ProcessGenerated(Process);
       // }
       //  public string  SaveMaterialReceipt(MaterialReceipt mrr)
       // {
       //     return new AtmsDAL().SaveMaterialReceipt(mrr);
       // }
       //  public short  SaveMaterialReceiptTran(string strMrrNo,int vType,string strProductID,string strBarndID,string strModelNo,
       //                                         string strUnit,string strSlNo,string des1,string des2,string des3,double dblQty,
       //                                             double dblRate,double dblAmount,string strExpDate, MaterialReceipt mrr)
       //  {
       //      return new AtmsDAL().SaveMaterialReceiptTran(strMrrNo, vType, strProductID, strBarndID, strModelNo, strUnit, strSlNo, des1, des2, des3, dblQty, dblRate, dblAmount, strExpDate, mrr);
       //  }
       //  public short SaveAssetsUser(string strDepID,string strUserID,long lngUerNo,string formName,  AssetsUser assets)
       //  {
       //      return new AtmsDAL().SaveAssetsUser(strDepID, strUserID, lngUerNo, formName, assets);
       //  }
       //  public short SaveAdditionalInfo(AdditionalInformation Addiinfo)
       //  {
       //      return new AtmsDAL().SaveAdditionalInfo(Addiinfo); 
       //  }
       //  public short SaveAdditionalCompInfo(AdditionalInformation Addiinfo)
       //  {
       //      return new AtmsDAL().SaveAdditionalCompInfo(Addiinfo);
       //  }
       //  public string SaveMatIssue(AssetsIssue issue)
       //  {
       //      return new AtmsDAL().SaveMatIssue(issue);
       //  }
       //  public short SaveMaterialIssueTran(string strIssueNo, int vType, string strProductID, string strBarndID, string strModelNo,
       //                                        string strUnit, string strSlNo, string des1, string des2, string des3, double dblQty,
       //                                            double dblRate, double dblAmount, string strExpDate, AssetsIssue  Issue)
       //  {
       //      return new AtmsDAL().SaveMaterialIssueTran(strIssueNo, vType, strProductID, strBarndID, strModelNo, strUnit,
       //                         strSlNo, des1, des2, des3, dblQty, dblRate, dblAmount, strExpDate, Issue);
       //  }
         public short SaveServiceWarrenty(ServiceWarrenty service)
         {
             return new AtmsDAL().SaveServiceWarrenty(service);
         }

        public short DeleteServiceWarrenty(string strTagNo)
         {
             return new AtmsDAL().DeleteServiceWarrenty(strTagNo);
         }
     //   public short UpdatevoucherMaster(AssetsIssue issue)
     //   {
     //       return new AtmsDAL().UpdatevoucherMaster(issue);
     //   }
     //   public short UpdatevoucherTran(AssetsIssue Issue)
     //   {
     //       return new AtmsDAL().UpdatevoucherTran(Issue);
     //   }
     //   public int UpdateMaterialReceipt(MaterialReceipt mrr)
     //   {
     //       return new AtmsDAL().UpdateMaterialReceipt(mrr);
     //   }

     //   public short UpdateMaterialReceiptTran(string strMrrNo, string strTranID, int vType, string strProductID, string strBarndID, string strModelNo,
     //                                          string strUnit, string strSlNo, string des1, string des2, string des3, double dblQty,
     //                                              double dblRate, double dblAmount, string strExpDate, MaterialReceipt mrr)
     //   {
     //       return new AtmsDAL().UpdateMaterialReceiptTran(strMrrNo, strTranID, vType, strProductID, strBarndID, strModelNo, strUnit, strSlNo, des1, des2, des3,
     //                                                       dblQty, dblRate, dblAmount, strExpDate, mrr);
     //   }
        public short SaveServiceProviderInfor(ServiceProvider Sp)
        {
            return new AtmsDAL().SaveServiceProviderInfor(Sp);
        }

        public short UpdateServiceProviderInfor(ServiceProvider Sp)
        {
            return new AtmsDAL().UpdateServiceProviderInfor(Sp);
        }
        public List<ServiceProvider> GetDetailsInformation(string Control, string Where)
        {
            return new AtmsDAL().GetDetailsInformation(Control, Where);
        }
        public short SaveServiceDetails(string strSLNo, string strservID, string strServdate, string strReturnDate,
                                        string strExperetdate, string strRemarks, int status, ServiceDetails Sd)
        {
            return new AtmsDAL().SaveServiceDetails(strSLNo, strservID, strServdate, strReturnDate, strExperetdate, strRemarks, status, Sd);
        }
        public Dictionary<string, string> GetServiceProvider(string Control, string Where)
        {
            Dictionary<string, string> objService = new Dictionary<string, string>();
            foreach (ServiceProvider Service in new AtmsDAL().GetServiceProvider(Control, Where))
            {
                objService.Add(Service.ID, Service.ServiceProviderName);
            }
            return objService;

        }
        public List<ServiceProvider> GetServiceProviderInfo(string Control, string Where)
        {
            return new AtmsDAL().GetServiceProviderInfo(Control, Where);
        }
        public List<ServiceProvider> GetServiceDetailsofSlno(string Control, string Where)
        {
            return new AtmsDAL().GetServiceDetailsofSlno(Control, Where);
        }
        public short DeleteServiceDetails(string strSLNo)
        {
            return new AtmsDAL().DeleteServiceDetails(strSLNo);
        }
        public List<AssetsGroup> GetInvGroup(string Control, string Where)
        {
            return new AtmsDAL().GetInvGroup(Control, Where);
        }
        public List<AssetsIssue> GetProductIssue(string Control, string Where)
        {
            return new AtmsDAL().GetProductIssue(Control, Where);
        }
     //  public short SaveStoreType(StoreType St)
     //  {
     //      return new AtmsDAL().SaveStoreType(St);
     //  }
     //  public short UpdateStoreType(StoreType St)
     //  {
     //      return new AtmsDAL().UpdateStoreType(St);
     //  }
     //  public List<StoreType> GetStoreType()
     //  {
     //      return new AtmsDAL().GetStoreType();
     //  }

     // public short SaveMajorGrp(Majorgroup Mg)
     //  {
     //      return new AtmsDAL().SaveMajorGrp(Mg);
     //  }
     // public short Update_Majorgroup(Majorgroup Mg)
     // {
     //     return new AtmsDAL().Update_Majorgroup(Mg);
     // }

     //public List<Majorgroup> GetMajorGrp()
     // {
     //     return new AtmsDAL().GetMajorGrp();
     // }

     //public Dictionary<string, string> GetStoreTypeofGroup()
     //{
     //    Dictionary<string, string> objService = new Dictionary<string, string>();
     //    foreach (Majorgroup Mg in new AtmsDAL().GetStoreTypeofGroup())
     //    {
     //        objService.Add(Mg.storeTypeID, Mg.Name);
     //    }
     //    return objService;

     //}

     public short Savewarehousetype(Warehouse Wh)
     {
         return new AtmsDAL().Savewarehousetype(Wh);
     }

     public short Updatewarehousetype(Warehouse Wh)
     {
         return new AtmsDAL().Updatewarehousetype(Wh);
     }

     public List<Warehouse> GetWarehousetype()
     {
         return new AtmsDAL().GetWarehousetype();
     }

     public short Savewarehouse(WarehouseConfig Wh)
     {
         return new AtmsDAL().Savewarehouse(Wh);
     }

     public short Updatewarehouse(WarehouseConfig Wh)
     {
         return new AtmsDAL().Updatewarehouse(Wh);
     }
     public List<WarehouseConfig> GetWarehouse()
     {
         return new AtmsDAL().GetWarehouse();
     }
     public List<WarehouseConfig> LoadWarehouse()
     {
         return new AtmsDAL().LoadWarehouse();
     }

      //**********************
     public List<StoreType> GetStoreWhstoretype()
     {
         return new AtmsDAL().GetStoreWhstoretype();
     }
     public List<InvGroups> GetStockWHGroup()
     {
         return new AtmsDAL().GetStockWHGroup();
     }

     //public List<InvLocation> GetStockWHLocation()
     //{
     //    return new AtmsDAL().GetStockWHLocation();
     //}

     //public List<Warehouseconfig> GetHkwarehouseType()
     //{
     //    return new AtmsDAL().GetHkwarehouseType();
     //}

     public Dictionary<string, string> GetHkwarehouseType(string whtype)
     {
         Dictionary<string, string> objWH = new Dictionary<string, string>();
         foreach (WarehouseConfig wh in new AtmsDAL().GetHkwarehouseType(whtype))
         {
             objWH.Add(wh.Typeid, wh.TypeName);
         }
         return objWH;
     }
     

    public List<Warehouse> GeHktwarehouse(string where)
    {
        return new AtmsDAL().GeHktwarehouse(where);
    }
    public List<HkItem> GethkItem(string strGroup,string strType,string strLocation)
     {
         return new AtmsDAL().GethkItem(strGroup,strType,strLocation);
     }
    public string SaveIomaster(IOmaster IOmaster)
    {
        return new AtmsDAL().SaveIomaster(IOmaster);
    }
    public short SaveIoDetails(string RefID, string itemCode, double dblqty, int statustype, string strRemarks, string Istatus, IOmaster IOmaster)
    {
        return new AtmsDAL().SaveIoDetails(RefID, itemCode, dblqty, statustype, strRemarks, Istatus, IOmaster);
    }
    public List<IOmaster> GetHkDirtyItem(string strWhi, int intstatus)
    {
        return new AtmsDAL().GetHkDirtyItem(strWhi, intstatus);
    }

    public List<IOmaster> GetHkArchiveLog(string strWhi)
    {
        return new AtmsDAL().GetHkArchiveLog(strWhi);
    }
    public List<WarehouseStoreRO> GetWarehouseStoreReport(string pFadte, string pTdate, string  strStoreType)
    {
        return new AtmsDAL().GetWarehouseStoreReport(pFadte, pTdate, strStoreType);
    }

    public List<IOmaster> DisplayReceiptInformation(string strStoreType, string where)
    {
        return new AtmsDAL().DisplayReceiptInformation(strStoreType,where);
    }
    public List<IOmaster> GetWarehouseItem(string strStoreType)
    {
        return new AtmsDAL().GetWarehouseItem(strStoreType);
    }

    public int UpdateIomaster(IOmaster IOmaster)
    {
        return new AtmsDAL().UpdateIomaster(IOmaster);
        }

    public short UpdateIoDetails(string RefID, string itemCode, double dblqty, int statustype, string strRemarks, string Istatus, IOmaster IOmaster)
    {
        return new AtmsDAL().UpdateIoDetails(RefID, itemCode, dblqty, statustype, strRemarks, Istatus, IOmaster);

    }
    public List<IOmaster> GetWarehouseIssueItem(string strStoreType, string strActive)
    {
        return new AtmsDAL().GetWarehouseIssueItem(strStoreType, strActive);
    }

    public List<IOmaster> DisplayIssueInformation(string strStoreType, string where)
    {
        return new AtmsDAL().DisplayIssueInformation(strStoreType, where);
    }

    public Dictionary<string, string> LoadCategory()
    {
        Dictionary<string, string> obgcategory = new Dictionary<string, string>();
        foreach (CostCategory objcat in new CollectionSummaryDAL().LoadCategory())
        {
            obgcategory.Add(objcat.Categorycode, objcat.Categoryname);
        }
        return obgcategory;

    }
    public List<CostCategoryTreeview> GetCostcenterTreeview(string control, string Where, string Where1)
    {
        return new CollectionSummaryDAL().GetCostcenterTreeview(control, Where, Where1);
    }
   


   }
}
