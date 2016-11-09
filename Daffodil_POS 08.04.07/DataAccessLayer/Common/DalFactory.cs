using System;
using System.Data;
using System.Configuration;
using System.Web;
using DSL.POS.DataAccessLayer.Imp;
using DSL.POS.DataAccessLayer.Interface;

namespace DSL.POS.DataAccessLayer.Common
{
    /// <summary>
    /// Summary description for ProductFacade
    /// </summary>
    /// 

    public class DalFactory
    {
        private static DalFactory ProFacade = new DalFactory();

        public static DalFactory GetInstance()
        {
            return ProFacade;
        }

        public IProductUnitDAL GetpuDALImp()
        {
            return new ProductUnitDALImpl();
        }

        public IBranchInfoDAL createBranchInfoDAL()
        {
            return new BranchInfoDALImpl();
        }

        public IProductCategoryDAL createProductCategoryDAL()
        {
            return new ProductCategoryDALImp();
        }

        public IProductSubCategoryDAL createProductSubCategoryDAL()
        {
            return new ProductSubCategroyDALImp();
        }

        public ISupplierInfoDAL createSupplierInfoDAL()
        {
            return new SupplierInfoDALImp();
        }

        public ISupplierInfoDAL getSupplierInfoDTO()
        {
            return new SupplierInfoDALImp();
        }

        public IMemberInfoDAL GetMemberDataList()
        {
            return new MemberInfoDALImp();
        }

        public IBranchTypeInfoDAL createBranchTypeInfoDAL()
        {
            return new BranchTypeInfoDALImp();
        }

        public IBoothInfoDAL createBoothInfoDAL()
        {
            return new BoothInfoDALImp();
        }


        public IBoothInfoDAL getBoothInfoDTO()
        {
            return new BoothInfoDALImp();
        }

        public IProductBrandDAL GetProductBrandDataList()
        {
            return new ProductBrandDALImp();
        }

        public IProductBrandDAL GetPBDalImp()
        {
            return new ProductBrandDALImp();
        }

        public IProductCategoryDAL GetProductCategoryDataList()
        {
            return new ProductCategoryDALImp();
        }

        public IProductSubCategoryDAL GetProductSubCategoryDataList()
        {
            return new ProductSubCategroyDALImp();
        }
        public ISalesInfoDAL GetSalesInfoDAL()
        {
            return new SalesInfoDALImp();
        }

        public ISalesReturnInfoDAL GetSalesReturnInfoDAL()
        {
            return new SalesReturnInfoDALImp();
        }

        public IPurchaseInfoDAL GetPurchaseInfoDAL()
        {
            return new PurchaseInfoDALImp();
        }

        public IProductInfoDAL GetPDALImp()
        {
            return new ProductInfoDALImp();
        }            
        

        public IProductUnitDAL GetProductUnitDataList()
        {
            return new ProductUnitDALImpl();
        }

        public IPurchaseReturnInfoDAL GetPurchaseReturnInfoDAL()
        {
            return new PurchaseReturnInfoDALImp();
        }
        public IOpeningBalanceDAL createOpeningBalanceInfoDAL()
        {
            return new OpeningBalanceDALImp(); 
        }

        protected DalFactory()
        {
            //
            // TODO: Add constructor logic here
            //
        }

    }
}