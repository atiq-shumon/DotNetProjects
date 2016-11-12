using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AH.ATMS.DAL;
using AH.ATMS.MODEL;
using System.Threading.Tasks;


namespace AH.ATMS.BLL
{
   public class CollectionBll
    {
       // public List<AssetsGroup> GetAssetsGroupTree()
       //{
       //    return new CollectionDal().GetAssetsGroupTree();
       //}
       // //public Dictionary<string, string> Gegroup(string Control, string Where)
       // //{
       // //    Dictionary<string, string> obgVoucher = new Dictionary<string, string>();
       // //    foreach (AssetsGroup  objgrp in new CollectionDal().Gegroup(Control,Where));
       // //    {
       // //        obgVoucher.Add(objgrp.)
       // //    }
       // //    return obgVoucher;

       // //}
       // public Dictionary<string, string> Gegroup(string Control, string Where)
       // {
       //     Dictionary<string, string> objGrp = new Dictionary<string, string>();
       //     foreach (AssetsGroup Grp in new CollectionDal().Gegroup(Control, Where))
       //     {
       //         objGrp.Add(Grp.GroupID, Grp.GroupName);
       //     }
       //     return objGrp;

       // }
       // public List<Brand> GeBrandTree(string Control, string Where)
       // {
       //     return new CollectionDal().GeBrandTree(Control, Where);
       // }
       // public List<MaterialReceipt> GeAgsinstRefNo(string Control, string Where)
       // {
       //     return new CollectionDal().GeAgsinstRefNo(Control, Where);
       // }
       //public List<MaterialReceipt> DisplayDetailsAgainsrRef(string Control, string Where)
       // {
       //     return new CollectionDal().DisplayDetailsAgainsrRef(Control, Where);
       // }
       //// public List<Supplier> GetSupplierID(string Control, string Where)
       ////{
       ////    return new CollectionDal().GetSupplierID(Control, Where);

       ////}
       //public Dictionary<string, string> GetSupplierID(string Control, string Where)
       //{
       //    Dictionary<string, string> objSupp = new Dictionary<string, string>();
       //    foreach (Supplier supp in new CollectionDal().GetSupplierID(Control, Where))
       //    {
       //        objSupp.Add(supp.supplierID, supp.supplierName);
       //    }
       //    return objSupp;

       //}
       //public Dictionary<string, string> GetDepartment(string Control, string Where)
       //{
       //    Dictionary<string, string> objUser = new Dictionary<string, string>();
       //    foreach (AssetsUser assets in new CollectionDal().GetDepartment(Control, Where))
       //    {
       //        objUser.Add(assets.DepID, assets.DepName);
       //    }
       //    return objUser;

       //}

       //public List<AssetsUser> GetLastNo(string Control, string Where)
       //{
       //    return new CollectionDal().GetLastNo(Control, Where);
       //}
       //public List<AssetsUser> GetAssetsUserStatus(string Control, string Where)
       //{
       //    return new CollectionDal().GetAssetsUserStatus(Control, Where);
       //}
       //public List<MaterialReceipt> DisplayBrandDetails(string Control, string Where)
       //{
       //    return new CollectionDal().DisplayBrandDetails(Control, Where);
       //}
       //public List<AdditionalInformation> DisplayAddInformation(string Control, string Where)
       //{
       //    return new CollectionDal().DisplayAddInformation(Control, Where);
       //}
       // public Dictionary<string, string> GetAssetsUsertoDep(string Control, string Where)
       //{
       //    Dictionary<string, string> objUser = new Dictionary<string, string>();
       //    foreach (AssetsUser assets in new CollectionDal().GetAssetsUsertoDep(Control, Where))
       //    {
       //        objUser.Add(assets.UserId, assets.UserName);
       //    }
       //    return objUser;
       //}
       // public List<MaterialReceipt> GetTotalQty(string Control, string Where)
       // {
       //     return new CollectionDal().GetTotalQty(Control, Where);
       // }
       // public List<ServiceWarrenty> GetwarrentyService(string Control, string Where)
       // {
       //     return new CollectionDal().GetwarrentyService(Control, Where);
       // }
       // public List<MaterialReceipt> DisplayvoucherDetails(string Control, string Where)
       // {
       //     return new CollectionDal().DisplayvoucherDetails(Control, Where);
       // }

       // public short UpdatevoucherMaster(AssetsIssue issue)
       // {
       //     return new AtmsDAL().UpdatevoucherMaster(issue);
       // }
       // public List<MaterialReceipt> GetMrrNo(string Control, string Where)
       // {
       //     return new CollectionDal().GetMrrNo(Control, Where);
       // }

        //public Dictionary<string, string> GetMrrNo(string Control, string Where)
        //{
        //    Dictionary<string, string> objUser = new Dictionary<string, string>();
        //    foreach (MaterialReceipt assets in new CollectionDal().GetMrrNo(Control, Where))
        //    {
        //        objUser.Add(assets.agiaintRefNo, assets.MrrNo);
        //    }
        //    return objUser;
        //}
        //public List<MaterialReceipt> DisplayDetaialstoMrr(string Control, string Where)
        //{
        //    return new CollectionDal().DisplayDetaialstoMrr(Control, Where);
        //}
        //public List<AssetsIssue> GetAssetsUserInfo(string Control, string Where, string Where1)
        //{
        //    return new CollectionDal().GetAssetsUserInfo(Control, Where, Where1);
        //}
        public List<VoucherRo> DisplayvoucherReport(string Control, int  Where, string Where1)
        {
            return new CollectionDal().DisplayvoucherReport(Control, Where, Where1);
        }

         public List<VoucherRo> DisplayvoucherIssueReport(string Control, int Where, string Where1)
        {
            return new CollectionDal().DisplayvoucherIssueReport(Control, Where, Where1);
        }
         //public Dictionary<string, string> GetStoreID()
         //{
         //    Dictionary<string, string> objUser = new Dictionary<string, string>();
         //    foreach (TermsandCondition objterms in new CollectionDal().GetStoreID())
         //    {
         //        objUser.Add(objterms.storeID, objterms.storeName);
         //    }
         //    return objUser;
         //}

         //public short SaveTermsNCondition(TermsandCondition tc)
         //{
         //    return new AtmsDAL().SaveTermsNCondition(tc);
         //}
         //public short UpdateTermsNCondition(TermsandCondition tc)
         //{
         //    return new AtmsDAL().UpdateTermsNCondition(tc);
         //}

         //public List<TermsandCondition> GetTermsNCondtion()
         //{
         //    return new AtmsDAL().GetTermsNCondtion();
         //}

      
    }
}
