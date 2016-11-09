using System;
using System.Data;
using System.Configuration;
using System.Web;
using DSL.POS.BusinessLogicLayer.Interface;
using DSL.POS.BusinessLogicLayer.Imp;
using DSL.POS.DTO.DTO;


namespace DSL.POS.Facade
{
    /// <summary>
    /// Summary description for ProductFacade
    /// </summary>
    /// 

    public class Facade
    {
        private static Facade ProFacade = new Facade();

        public static Facade GetInstance()
        {
            return ProFacade;
        }


        public IProductUnitBL GetPUBLImp()
        {
            return ProductUnitBLImpl.GetInstance();
        }

        public IBranchInfoBL createBranchBL()
        {
            return BranchInfoBLImpl.GetInstance();
        }

        public BranchInfoDTO getBranchInfoDTO(Guid pk)
        {
            return BranchInfoBLImpl.loadBranchInfoDTO(pk);
        }

        public IProductCategoryBL createProductCategoryBL()
        {
            return ProductCategoryBLImp.GetInstance();
        }

        public IProductSubCategoryInfoBL createProductSubCategoryBL()
        {
            return ProductSubCategoryInfoBLImp.GetInstance();
        }
        
        public ISupplierInfoBL createSupplierBL()
        {
            return SupplierInfoBLImp.getInstanceSupplierInfoBLImp();
        }

        public SupplierInfoDTO getSupplierInfo(Guid pk)
        {
            return SupplierInfoBLImp.loadSupplierInfoDto(pk);
        }

        public IMemberInfoBL createMemberBL()
        {
            return MemberInfoBLImp.getInstanceMemberInfoBLImp();
        }

        public MemberInfoDTO getMemberInfo(Guid pk)
        {
            return MemberInfoBLImp.loadMemberInfoDto(pk);
        }

        public SupplierInfoDTO getSupplierInfoByCode(string suppCode)
        {
            return SupplierInfoBLImp.getSupplierPKByCode(suppCode);
        }


        /// <summary>
        /// get Member Primary Code corresponding Member Code
        /// </summary>
        /// <param name="strCode"></param>
        /// <returns></returns>
        public Guid getMemberPKInfoByCode(string strCode)
        {
            MemberInfoBLImp oMemberInfoBLImp = new MemberInfoBLImp();
            return oMemberInfoBLImp.getMemberPKByCode(strCode);
        }

        public ISalesInfoBL createSalesBL()
        {
            return SalesInfoBLImp.getInstanceSalesInfoBLImp();
        }
        
        public ISalesReturnInfoBL  createSalesReturnBL()
        {
            return SalesReturnInfoBLImp.getInstanceSalesReturnInfoBLImp();
        }      


        public IPurchaseInfoBL createPurchaseBL()
        {
            return PurchaseInfoBLImp.getInstancePurchaseInfoBLImp();
        }

        public IBranchTypeInfoBL createBranchTypeBL()
        {
            return BranchTypeInfoBLImp.getInstanceBranchTypeInfoBLImp();
        }

        public BranchTypeInfoDTO getBranchTypeInfo(Guid id)
        {
            return BranchTypeInfoBLImp.loadBranchTypeInfoDto(id);
        }

        public IBoothInfoBL createBoothInfoBL()
        {
            return BoothInfoBLImp.getInstanceBoothInfoBLImp();
        }

        public BoothInfoDTO getBoothInfoDTO(Guid id)
        {
            return BoothInfoBLImp.loadBoothInfoDto(id);
        }
        /// <summary>
        ///  get Booth, Branch & BranchType Information corresponding BoothPrimaryKey 
        /// </summary>
        /// <param name="BoothPK"></param>
        /// <returns>BoothInfoDTO</returns>
        public BoothInfoDTO getBoothInfo_AllDTO(Guid BoothPK)
        {
            return BoothInfoBLImp.loadBoothInfo_AllDTO(BoothPK);
        }

        /// <summary>
        /// Get BoothInformation corresponding Booth Code
        /// </summary>
        /// <param name="shrot BoothCode"></param>
        /// <returns>BoothInfoDTO</returns>
        public BoothInfoDTO getBoothInfoByCodeDTO(short BoothCode)
        {
            return BoothInfoBLImp.GetDataBoothInfoByCode(BoothCode);
        }

        public IProductBrandBL GetProductBrandDataList()
        {
            return ProductBrandBLImp.GetInstance();
        }

        public ProductInfoDTO GetProductInfoDTO(Guid pk)
        {
            return ProductInfoBLImp.LoadProductInfoDTO(pk);
        }
        public IProductInfoBL GetProductInfoInstance()
        {
            return ProductInfoBLImp.GetInstance();            
        }

        public IProductBrandBL GetPBBlImp()
        {
            return ProductBrandBLImp.GetInstance();
        }
                
        public IProductInfoBL GetPBLImp()
        {
            return ProductInfoBLImp.GetInstance();
        }

        /// <summary>
        /// Find Product Primary Key corresponding Product Code
        /// </summary>
        /// <param name="strCode"></param>
        /// <returns></returns>
        public Guid getProductPKInfoByCode(string strCode)
        {
            ProductInfoBLImp oProductInfoBLImp = new ProductInfoBLImp();
            return oProductInfoBLImp.getProductPKByCode(strCode);
        }


        
        public IProductUnitBL GetProductUnitDataList()
        {
            return ProductUnitBLImpl.GetInstance();
        }

        public ProductCategoryInfoDTO GetProductCategoryInfo(Guid guid)
        {
            return ProductCategoryBLImp.LoadCategoryInfo(guid);
        }

        public ProductSubCategoryInfoDTO GetProductsubCategoryInfo(Guid guid)
        {
            return ProductSubCategoryInfoBLImp.LoadSubCategoryInfo(guid);
        }

        public ProductBrandInfoDTO GetProductBrandInfo(Guid guid)
        {
            return ProductBrandBLImp.LoadProductBrandInfo(guid);
        }

        public ProductUnitInfoDTO GetProductUnitInfo(Guid guid)
        {
            return ProductUnitBLImpl.LoadProductUnitInfo(guid);
        }
        //public SalesMainInfoDTO GetSalesInfoDTO(string strInvoice)
        //{
        //    try
        //    {
        //        SalesInfoBLImp oSalesInfoBLImp = new SalesInfoBLImp();
        //        return oSalesInfoBLImp.GetSalesReturnInfoByInvoiceNo(strInvoice);
                
        //    }
        //    catch (Exception exp)
        //    {
        //        throw exp;
        //    }
        //}

        public SalesReturnMainDTO  GetSalesReturnInfoDTO(string strInvoice)
        {
            try
            {
                SalesReturnInfoBLImp oSalesReturnInfoBLImp = new SalesReturnInfoBLImp();
                return oSalesReturnInfoBLImp.GetSalesReturnInfoByInvoiceNo(strInvoice);

            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
        public IPurchaseReturnInfoBL  createPurchaseReturnBL()
        {
            return PurchaseReturnInfoBLImp.getInstancePurchaseReturnInfoBLImp(); 
        }
        public PurchaseReturnMainDTO GetPurchaseReturnInfoDTO(string strGRNNo)
        {
            try
            {
                PurchaseReturnInfoBLImp oPurchaseReturnInfoBLImp = new PurchaseReturnInfoBLImp();
                return oPurchaseReturnInfoBLImp.GetPurchaseReturnInfoByGRNNo(strGRNNo);
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
        }
        public IOpeningBalanceBL createOpeningBalanceBL()
        {
            return OpeningBalanceBLImp.getInstanceOpeningBalanceBLImp();
        }
        protected Facade()
        {
            //
            // TODO: Add constructor logic here
            //
        }

    }
}
