using System;
using System.Data;
using System.Configuration;
using System.Web;
using DSL.POS.DTO.Common.DTO;
namespace DSL.POS.DTO.DTO
{
    /// <summary>
    /// Summary description for ProductInfoDto
    /// </summary>
    public class ProductInfoDTO : CommonDTO
    {
        private Guid _PC_PK;
        private Guid _PSC_PK;
        private Guid _PB_PK;
        private Guid _PU_PK;

        private string _P_Code;
        private string _P_Name;
        private string _P_Style;
        private decimal _P_SalesPrice;
        private decimal _P_CostPrice;
        private decimal _P_Tax;
        private decimal _P_VAT;
        private decimal _P_Discount;
        private decimal _P_MinLevel;
        private decimal _P_MaxLevel;
        private decimal _P_ReorderLevel;
        private Boolean _P_Status;
        private DateTime _P_SalesPriceDate;
        private DateTime _P_CostPriceDate;
        private Boolean _P_Warranty;
        private int _P_WarrantyMonth;


        public Guid PC_PrimaryKey
        {
            set { _PC_PK = value; }
            get { return _PC_PK; }
        }
        public Guid PSC_PrimaryKey
        {
            set { _PSC_PK = value; }
            get { return _PSC_PK; }
        }
        public Guid PB_PrimaryKey
        {
            set { _PB_PK = value; }
            get { return _PB_PK; }
        }
        public Guid PU_PrimaryKey
        {
            set { _PU_PK = value; }
            get { return _PU_PK; }
        }


        public string P_Code
        {
            set { _P_Code = value; }
            get { return _P_Code; }
        }

        public string P_Name
        {
            set { _P_Name = value; }
            get { return _P_Name; }
        }

        public string P_Style
        {
            set { _P_Style = value; }
            get { return _P_Style; }
        }

        public decimal P_SalesPrice
        {
            set { _P_SalesPrice = value; }
            get { return _P_SalesPrice; }
        }
        public decimal P_CostPrice
        {
            set { _P_CostPrice = value; }
            get { return _P_CostPrice; }
        }

        public decimal P_Tax
        {
            set { _P_Tax = value; }
            get { return _P_Tax; }
        }

        public decimal P_VAT
        {
            set { _P_VAT = value; }
            get { return _P_VAT; }
        }

        public decimal P_Discount
        {
            set { _P_Discount = value; }
            get { return _P_Discount; }
        }

        public decimal P_MinLevel
        {
            set { _P_MinLevel = value; }
            get { return _P_MinLevel; }
        }

        public decimal P_MaxLevel
        {
            set { _P_MaxLevel = value; }
            get { return _P_MaxLevel; }
        }

        public decimal P_ReorderLevel
        {
            set { _P_ReorderLevel = value; }
            get { return _P_ReorderLevel; }
        }

        public Boolean P_Status
        {
            set { _P_Status = value; }
            get { return _P_Status; }
        }

        public DateTime P_SalesPriceDate
        {
            set { _P_SalesPriceDate = value; }
            get { return _P_SalesPriceDate; }
        }

        public DateTime P_CostPriceDate
        {
            set { _P_CostPriceDate = value; }
            get { return _P_CostPriceDate; }
        }

        public Boolean P_Warranty
        {
            set { _P_Warranty = value; }
            get { return _P_Warranty; }
        }

        public int P_WarrantyMonth
        {
            set { _P_WarrantyMonth = value; }
            get { return _P_WarrantyMonth; }
        }


        public ProductInfoDTO()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}