using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.ComponentModel;
using System.Globalization;
using System.Collections.Generic;
using DSL.POS.Facade;
using DSL.POS.DTO.DTO;
using DSL.POS.BusinessLogicLayer.Interface;
using DSL.POS.Common.Utility;

public partial class ui_setup_ProductInfo : System.Web.UI.Page
{
    ClsErrorHandle cls = new ClsErrorHandle();
    Utility uti = new Utility();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole(ConfigurationManager.AppSettings["poweruserrolename"]))
        {
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx");
        }
        if (!IsPostBack)
        {
            this.ddlProductCategory.Focus();
            this.ddlProductCategory.Attributes.Add("onkeypress", "clickbtn('" + btnClickProductCategory.ClientID + "')");
            ddlProductSubCategory.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            ddlProductBrand.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            txtProductName.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            txtStyle.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            txtSalesPriceDate.Attributes.Add("onKeyUp", "formatSalesPriceDateField()");
            txtCostPriceDate.Attributes.Add("onKeyUp", "formatCostPriceDateField()");  
            txtSalesPrice.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            txtSalesPriceDate.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            txtTax.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            txtVat.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            txtMinLevel.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            txtMaxLevel.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            txtCostPrice.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            txtCostPriceDate.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            txtDiscount.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            ddlProductUnit.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            txtReorderLevel.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            txtWarrantyMonth.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            chkWarranty.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            chkStatus.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            
            
            try
            {
                //Response.Write("it's not");
                //this.txtSalesPriceDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                //this.txtCostPriceDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

                Facade facade = Facade.GetInstance();

                DropDownListCategory(facade);

                DropDownListSubCategory(facade);

                DropDownListBrand(facade);

                DropDownListUnit(facade);

            }
            catch (Exception Exp)
            {
                lblErrorMessage.Text = cls.ErrorString(Exp);
            }
        }
        else
        {
            //Response.Write("not not");
        }
    }

    private void DropDownListUnit(Facade facade)
    {
        IProductUnitBL unitList = facade.GetProductUnitDataList();
        List<ProductUnitInfoDTO> oUnitList = unitList.GetProductUnitInfo();
        
        int i = 0;
        ddlProductUnit.Items.Clear();
        ddlProductUnit.Items.Add("(Select any unit)");
        this.ddlProductUnit.Items[i].Value = "";
        foreach (ProductUnitInfoDTO newDto in oUnitList)
        {
            i++;
            this.ddlProductUnit.Items.Add(newDto.PU_Name);
            this.ddlProductUnit.Items[i].Value = newDto.PrimaryKey.ToString();
        }
    }

    private void DropDownListBrand(Facade facade)
    {
        IProductBrandBL brandList = facade.GetProductBrandDataList();
        List<ProductBrandInfoDTO> oBrandList = brandList.GetProductBrand();
        
        int i = 0;
        ddlProductBrand.Items.Clear();
        ddlProductBrand.Items.Add("(Select any brand)");
        this.ddlProductBrand.Items[i].Value = "";
        foreach (ProductBrandInfoDTO newDto in oBrandList)
        {
            i++;
            this.ddlProductBrand.Items.Add(newDto.PB_Name);
            this.ddlProductBrand.Items[i].Value = newDto.PrimaryKey.ToString();
        }
    }

    private void DropDownListSubCategory(Facade facade)
    {
        IProductSubCategoryInfoBL subCategoryList = facade.createProductSubCategoryBL();
        List<ProductSubCategoryInfoDTO> oSubCategoryList = subCategoryList.showDataSubCategoryInfo();

        int i = 0;
        ddlProductSubCategory.Items.Clear();
        ddlProductSubCategory.Items.Add("(Select any sub category)");
        this.ddlProductSubCategory.Items[i].Value = "";
        foreach (ProductSubCategoryInfoDTO newDto in oSubCategoryList)
        {
            i++;
            this.ddlProductSubCategory.Items.Add(newDto.PSC_Description);
            this.ddlProductSubCategory.Items[i].Value = newDto.PrimaryKey.ToString();
        }
    }

    private void DropDownListCategory(Facade facade)
    {
        IProductCategoryBL categoryList = facade.createProductCategoryBL();
        List<ProductCategoryInfoDTO> oCategoryList = categoryList.showData();
        //uti.DropDownListFillUp(this.ddlProductCategory, dto, oProductCategoryInfoDTOList);

        int i = 0;
        ddlProductCategory.Items.Clear();
        ddlProductCategory.Items.Add("(Select any category)");
        this.ddlProductCategory.Items[i].Value = "";
        foreach (ProductCategoryInfoDTO newDto in oCategoryList)
        {
            i++;
            this.ddlProductCategory.Items.Add(newDto.PC_Description);
            this.ddlProductCategory.Items[i].Value = newDto.PrimaryKey.ToString();
        }
    }
      
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lblErrorMessage.Text.Length != 0)
            {
                this.lblErrorMessage.Text = "";
            }

            ProductInfoDTO pDTO = Populate();

            IProductInfoBL facade = Facade.GetInstance().GetPBLImp();
            facade.AddProductInfo(pDTO);

            this.lblErrorMessage.Text = "Data Save Successfully.";
            
            this.hfPrimaryKey.Value = "";
            this.txtProductCode.Text = "";
            this.ddlProductCategory.SelectedValue = "";
            this.ddlProductSubCategory.SelectedValue = "";
            this.ddlProductBrand.SelectedValue = "";
            this.ddlProductUnit.SelectedValue = "";
            this.txtProductName.Text = "";
            this.txtStyle.Text = "";
            this.txtSalesPrice.Text = "";
            this.txtSalesPriceDate.Text = "";
            this.txtVat.Text = "";
            this.txtTax.Text = "";
            this.txtMaxLevel.Text = "";
            this.txtMinLevel.Text = "";
            this.txtCostPrice.Text = "";
            this.txtCostPriceDate.Text = "";
            this.txtDiscount.Text = "";
            this.txtReorderLevel.Text = "";
            this.txtWarrantyMonth.Text = "";
            this.chkWarranty.Checked = false;
            this.chkStatus.Checked = false;
            this.btnSave.Text = "Save";
            GridView1.DataBind();

        }
        catch(Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }
    /// <summary>
    /// All information set in domain class and return an object
    /// </summary>
    /// <returns></returns>
    private ProductInfoDTO Populate()
    {
        try
        {
            ProductInfoDTO pDTO = new ProductInfoDTO();
            
            if (this.hfPrimaryKey.Value.ToString() != "")
            {
                pDTO.PrimaryKey = (Guid)TypeDescriptor.GetConverter(pDTO.PrimaryKey).ConvertFromString(this.hfPrimaryKey.Value);
            }
            if (this.ddlProductCategory.SelectedValue == "")
            {
                throw new Exception("Invalid category.");
            }
            //if (this.ddlProductSubCategory.SelectedValue == "")
            //{
            //    throw new Exception("Invalid sub category.");
            //}
            //if (this.ddlProductBrand.SelectedValue == "")
            //{
            //    throw new Exception("Invalid brand.");
            //}
            //if (this.ddlProductUnit.SelectedValue == "")
            //{
            //    throw new Exception("Invalid unit.");
            //}

            Guid nullGuid = Guid.NewGuid();
            nullGuid = (Guid)TypeDescriptor.GetConverter(nullGuid).ConvertFromString("00000000-0000-0000-0000-000000000000");

            string  strPSC_PK = (string)this.ddlProductSubCategory.SelectedValue;
            string  strPB_PK = (string)this.ddlProductBrand.SelectedValue;
            string  strPU_PK = (string)this.ddlProductUnit.SelectedValue;
            
            pDTO.PC_PrimaryKey = (Guid)TypeDescriptor.GetConverter(pDTO.PC_PrimaryKey).ConvertFromString(this.ddlProductCategory.SelectedValue);
            pDTO.PSC_PrimaryKey = strPSC_PK == string.Empty ? nullGuid :(Guid)TypeDescriptor.GetConverter(pDTO.PSC_PrimaryKey).ConvertFromString(strPSC_PK);
            pDTO.PB_PrimaryKey = strPB_PK == string.Empty ? nullGuid :(Guid)TypeDescriptor.GetConverter(pDTO.PB_PrimaryKey).ConvertFromString(strPB_PK);
            pDTO.PU_PrimaryKey = strPU_PK == string.Empty ? nullGuid : (Guid)TypeDescriptor.GetConverter(pDTO.PU_PrimaryKey).ConvertFromString(strPU_PK);

            pDTO.P_Code = this.txtProductCode.Text;
            pDTO.P_Name = this.txtProductName.Text;
            pDTO.P_Style = this.txtStyle.Text;
            pDTO.P_SalesPrice = this.txtSalesPrice.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtSalesPrice.Text);
            pDTO.P_CostPrice=this.txtCostPrice.Text==string.Empty ? 0 : Convert.ToDecimal(this.txtCostPrice.Text);
            pDTO.P_Tax = this.txtTax.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtTax.Text);
            pDTO.P_VAT = this.txtVat.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtVat.Text);
            pDTO.P_Discount = this.txtDiscount.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtDiscount.Text);
            pDTO.P_MinLevel = this.txtMinLevel.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtMinLevel.Text);
            pDTO.P_MaxLevel = this.txtMaxLevel.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtMaxLevel.Text);
            pDTO.P_ReorderLevel = this.txtReorderLevel.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtReorderLevel.Text);
            pDTO.P_Status = this.chkStatus.Checked;

            pDTO.P_SalesPriceDate = this.txtSalesPriceDate.Text == string.Empty ? DateTime.Now.Date : Convert.ToDateTime(this.txtSalesPriceDate.Text);
            pDTO.P_CostPriceDate = this.txtCostPriceDate.Text == string.Empty ? DateTime.Now.Date : Convert.ToDateTime(this.txtCostPriceDate.Text);
            pDTO.P_Warranty = this.chkWarranty.Checked;
            pDTO.P_WarrantyMonth = this.txtWarrantyMonth.Text==string.Empty ? 0 : Convert.ToInt32(this.txtWarrantyMonth.Text);
            pDTO.EntryBy = Constants.DEFULT_USER;
            pDTO.EntryDate = DateTime.Today;

            return pDTO;
        }
        catch(Exception Exp)
        {
            throw Exp;
        }
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow)
        //{
        //    try
        //    {
        //        Button b = (Button)e.Row.FindControl("Button1");
        //        b.Attributes.Add("onclick", "javascript:return " +
        //        "confirm('Are you sure you want to delete this record " +
        //        DataBinder.Eval(e.Row.DataItem, "P_Code") + "')");
        //    }
        //    catch (Exception Exp)
        //    {
        //        lblErrorMessage.Text = cls.ErrorString(Exp);
        //    }
        //}
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //try
        //{
        //    int index = e.RowIndex;
        //    GridViewRow row = GridView1.Rows[index];

        //    ProductInfoDTO pDto = new ProductInfoDTO();

        //    DataKey dk = GridView1.DataKeys[index];
        //    this.hfPrimaryKey.Value = dk.Value.ToString();
        //    pDto.PrimaryKey = (Guid)TypeDescriptor.GetConverter(pDto.PrimaryKey).ConvertFromString(this.hfPrimaryKey.Value);

        //    IProductInfoBL facade = Facade.GetInstance().GetPBLImp();
        //    facade.DelProductInfo(pDto);
        //    this.hfPrimaryKey.Value = "";
        //    GridView1.DataBind();
        //}
        //catch (Exception Exp)
        //{
        //    lblErrorMessage.Text = cls.ErrorString(Exp);
        //}
    }

    protected void GridView1_BeforeEditing(object sender, GridViewEditEventArgs e)
    {
        e.Cancel = true;
    }

    
    /// <summary>
    /// DDLPopulate method set primary key in domain class use for dropdown list Product Category .
    /// </summary>
    /// <returns></returns>
    private ProductInfoDTO DDLPopulate()
    {
        try
        {
            ProductInfoDTO ddlDTO = new ProductInfoDTO();

            if (this.hfPrimaryKey.Value.ToString() != "")
            {
                ddlDTO.PrimaryKey = (Guid)TypeDescriptor.GetConverter(ddlDTO.PrimaryKey).ConvertFromString(this.hfPrimaryKey.Value);
            }
            if (this.ddlProductCategory.SelectedValue != "")
            {
                ddlDTO.PC_PrimaryKey = (Guid)TypeDescriptor.GetConverter(ddlDTO.PC_PrimaryKey).ConvertFromString(this.ddlProductCategory.SelectedValue);
            }
            else
            {
                return null  ;
            }
            return ddlDTO;
        }
        catch (Exception Exp)
        {
            throw Exp;
        }
       
    }
    
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "Edit")
            {
                ProductInfoDTO pDto = new ProductInfoDTO();

                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];

                DataKey dk = GridView1.DataKeys[index];
                this.hfPrimaryKey.Value = dk.Value.ToString();

                Facade facade = Facade.GetInstance();

                DropDownListSubCategory(facade);

                pDto = facade.GetProductInfoDTO((Guid)TypeDescriptor.GetConverter(pDto.PrimaryKey).ConvertFromString(this.hfPrimaryKey.Value));
                this.txtProductCode.Text = pDto.P_Code;
                this.txtProductName.Text = pDto.P_Name;
                this.txtStyle.Text = pDto.P_Style;
                this.txtSalesPrice.Text = pDto.P_SalesPrice.ToString();
                this.txtCostPrice.Text = pDto.P_CostPrice.ToString();
                this.txtTax.Text = pDto.P_Tax.ToString();
                this.txtVat.Text = pDto.P_VAT.ToString();
                this.txtDiscount.Text = pDto.P_Discount.ToString();
                this.txtMinLevel.Text = pDto.P_MinLevel.ToString();
                this.txtMaxLevel.Text = pDto.P_MaxLevel.ToString();
                this.txtReorderLevel.Text = pDto.P_ReorderLevel.ToString();
                this.chkStatus.Checked = pDto.P_Status;
                this.txtSalesPriceDate.Text = pDto.P_SalesPriceDate.ToString("MM/dd/yyyy");
                this.txtCostPriceDate.Text = pDto.P_CostPriceDate.ToString("MM/dd/yyyy");
                this.chkWarranty.Checked = pDto.P_Warranty;
                this.txtWarrantyMonth.Text = pDto.P_WarrantyMonth.ToString();
                this.btnSave.Text = "Update";

                ProductCategoryInfoDTO pcDto = new ProductCategoryInfoDTO();
                pcDto = facade.GetProductCategoryInfo((Guid)pDto.PC_PrimaryKey);
                this.ddlProductCategory.SelectedValue = pcDto.PrimaryKey.ToString();

                ProductSubCategoryInfoDTO pscDto = new ProductSubCategoryInfoDTO();
                pscDto = facade.GetProductsubCategoryInfo((Guid)pDto.PSC_PrimaryKey);
                if (pscDto.PrimaryKey.ToString() == "00000000-0000-0000-0000-000000000000")
                {
                    this.ddlProductSubCategory.SelectedValue = "";
                }
                else 
                    this.ddlProductSubCategory.SelectedValue = pscDto.PrimaryKey.ToString();

                ProductBrandInfoDTO pbDto = new ProductBrandInfoDTO();
                pbDto = facade.GetProductBrandInfo((Guid)pDto.PB_PrimaryKey);
                if (pbDto.PrimaryKey.ToString() == "00000000-0000-0000-0000-000000000000")
                {
                    this.ddlProductBrand.SelectedValue = "";
                }
                else 
                    this.ddlProductBrand.SelectedValue = pbDto.PrimaryKey.ToString();

                ProductUnitInfoDTO puDto = new ProductUnitInfoDTO();
                puDto = facade.GetProductUnitInfo((Guid)pDto.PU_PrimaryKey);
                if (puDto.PrimaryKey.ToString() == "00000000-0000-0000-0000-000000000000")
                {
                    this.ddlProductUnit.SelectedValue = "";
                }
                else 
                    this.ddlProductUnit.SelectedValue = puDto.PrimaryKey.ToString();

            }
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~\\Default.aspx");
    }
    protected void btnClickProductCategory_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.ddlProductCategory.SelectedValue == "")
            {
                return;
            }

            ProductInfoDTO pddlDTO = DDLPopulate();

            Facade facade = Facade.GetInstance();

            IProductSubCategoryInfoBL subCategoryList = facade.createProductSubCategoryBL();
            List<ProductSubCategoryInfoDTO> oArrayList = subCategoryList.showDataSubCategoryInfoByPC(pddlDTO.PC_PrimaryKey);

            int i = 0;
            ddlProductSubCategory.Items.Clear();
            ddlProductSubCategory.Items.Add("(Select any sub category)");
            this.ddlProductSubCategory.Items[i].Value = "";
            foreach (ProductSubCategoryInfoDTO newDto in oArrayList)
            {
                i++;
                this.ddlProductSubCategory.Items.Add(newDto.PSC_Description);
                this.ddlProductSubCategory.Items[i].Value = newDto.PrimaryKey.ToString();
            }
        }
        catch (Exception exp)
        {
            lblErrorMessage.Text = cls.ErrorString(exp);
        }
        finally
        {
            ScriptManager1.SetFocus(ddlProductSubCategory);
        }
            
    }
    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        lblErrorMessage.Text = "Data Deleted Successfully";
    }
}
