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
using System.Collections.Generic;
using DSL.POS.Common.Utility;
using DSL.POS.Facade;
using DSL.POS.DTO.DTO;
using DSL.POS.BusinessLogicLayer.Interface;
using DSL.POS.Report;
using DSL.POS.Report.Setup;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

public partial class Report_Sales_SalesReport : System.Web.UI.Page
{
    private ReportDocument oReportDocument = new ReportDocument();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole(ConfigurationManager.AppSettings["generaluserrolename"]))
        {
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx");
        }
        this.txtFromDate.Focus();
        this.RbAllBranch.Attributes.Add("onClick", "doAllBranch()");
        this.RbSpecificBranch.Attributes.Add("onClick", "doSpecificBranch()");
        this.RbAllCategory.Attributes.Add("onClick", "doAllCategory()");
        this.RbSpecificCategory.Attributes.Add("onClick", "doSpecificCategory()");
        this.RbAllSubCategory.Attributes.Add("onClick", "doAllSubCategory()");
        this.RbSpecificSubCategory.Attributes.Add("onClick", "doSpecificSubCategory()");
        this.RbAllBrand.Attributes.Add("onClick", "doAllBrand()");
        this.RbSpecificBrand.Attributes.Add("onClick", "doSpecificBrand()");
        this.RbAllItemSalesRegister.Attributes.Add("onClick", "doAllProduct()");
        this.RbSpecificProduct.Attributes.Add("onClick", "doSpecificProduct()");
        this.txtFromDate.Attributes.Add("onKeyUp", "formatFromDateField()");
        this.txtToDate.Attributes.Add("onKeyUp", "formatToDateField()");
        this.txtFromDate.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtToDate.Attributes.Add("onkeyPress", "FocusControl_byEnter()");

        if (!IsPostBack)
        {
            try
            {
                Facade facade = Facade.GetInstance();
                DropDownListBranch(facade);
                DropDownListBrand(facade);
                DropDownListProCategory(facade);
                DropDownListProductSubCategory(facade);
                DropDownListProduct(facade);
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
        }
        else
        {
        }
        
        
        

    }
    /// <summary>
    /// Fill DropDownList
    /// </summary>
    /// <param name="facade"></param>
    private void DropDownListProduct(Facade facade)
    {
        IProductInfoBL ProductList = facade.GetProductInfoInstance();
        List<ProductInfoDTO> oProductInfoList = ProductList.GetProductInfo();

        int i = 0;
        DDLProductName.Items.Clear();
        DDLProductName.Items.Add("(Select Product Name)");
        this.DDLProductName.Items[i].Value = "00000000-0000-0000-0000-000000000000";
        foreach (ProductInfoDTO newDto in oProductInfoList)
        {
            i++;
            this.DDLProductName.Items.Add(newDto.P_Name);
            this.DDLProductName.Items[i].Value = newDto.PrimaryKey.ToString();
        }
    }
    /// <summary>
    /// Fill DropDownList
    /// </summary>
    /// <param name="facade"></param>
    private void DropDownListBranch(Facade facade)
    {
        IBranchInfoBL BranchList = facade.createBranchBL();
        List<BranchInfoDTO> oBranchInfoList = BranchList.GetBranchInfo();

        int i = 0;
        DDLBranch.Items.Clear();
        DDLBranch.Items.Add("(Select Branch Name)");
        this.DDLBranch.Items[i].Value = "00000000-0000-0000-0000-000000000000";
        foreach (BranchInfoDTO newDto in oBranchInfoList)
        {
            i++;
            this.DDLBranch.Items.Add(newDto.BranchName);
            this.DDLBranch.Items[i].Value = newDto.PrimaryKey.ToString();
        }
    }
    /// <summary>
    /// Fill DropDownList
    /// </summary>
    /// <param name="facade"></param>
    private void DropDownListProCategory(Facade facade)
    {
        IProductCategoryBL ProductCategoryList = facade.createProductCategoryBL();
        List<ProductCategoryInfoDTO> oProCategoryList = ProductCategoryList.GetProductCategoryInfo();

        int i = 0;
        DDLCategory.Items.Clear();
        DDLCategory.Items.Add("(Select Product Category Name)");
        this.DDLCategory.Items[i].Value = "00000000-0000-0000-0000-000000000000";
        foreach (ProductCategoryInfoDTO newDto in oProCategoryList)
        {
            i++;
            this.DDLCategory.Items.Add(newDto.PC_Description);
            this.DDLCategory.Items[i].Value = newDto.PrimaryKey.ToString();
        }
    }
    /// <summary>
    /// Fill DropDownList
    /// </summary>
    /// <param name="facade"></param>
    private void DropDownListProductSubCategory(Facade facade)
    {
        IProductSubCategoryInfoBL ProductSubCategoryList = facade.createProductSubCategoryBL();
        List<ProductSubCategoryInfoDTO> oProSubCategoryList = ProductSubCategoryList.showDataSubCategoryInfo();

        int i = 0;
        DDLSubCategory.Items.Clear();
        DDLSubCategory.Items.Add("(Select Product Sub Category Name)");
        this.DDLSubCategory.Items[i].Value = "00000000-0000-0000-0000-000000000000";
        foreach (ProductSubCategoryInfoDTO newDto in oProSubCategoryList)
        {
            i++;
            this.DDLSubCategory.Items.Add(newDto.PSC_Description);
            this.DDLSubCategory.Items[i].Value = newDto.PrimaryKey.ToString();
        }
    }
    /// <summary>
    /// Fill DropDownList
    /// </summary>
    /// <param name="facade"></param>
    private void DropDownListBrand(Facade facade)
    {
        IProductBrandBL brandList = facade.GetProductBrandDataList();
        List<ProductBrandInfoDTO> oBrandList = brandList.GetProductBrand();

        int i = 0;
        DDLBrand.Items.Clear();
        DDLBrand.Items.Add("(Select Any Brand)");
        this.DDLBrand.Items[i].Value = "00000000-0000-0000-0000-000000000000";
        foreach (ProductBrandInfoDTO newDto in oBrandList)
        {
            i++;
            this.DDLBrand.Items.Add(newDto.PB_Name);
            this.DDLBrand.Items[i].Value = newDto.PrimaryKey.ToString();
        }
    }

    protected void btnReport_Click(object sender, EventArgs e)
    {
        this.lblErrorMessage.Text = "";
        if (this.txtFromDate.Text.Trim() == "")
        {
            this.lblErrorMessage.Text = "Please Insert Start Date.";
            return;
        }
        else if (this.txtToDate.Text.Trim() == "")
        {
            this.lblErrorMessage.Text = "Please Insert End Date.";
            return;
        }
        else if (this.RbSpecificBranch.Checked == true
                && this.DDLBranch.Text == "00000000-0000-0000-0000-000000000000")
        {
            this.lblErrorMessage.Text = "Please Select Branch Name.";
            return;
        }

        else if (this.RbSpecificProduct.Checked == true
           && this.DDLProductName.Text == "00000000-0000-0000-0000-000000000000")
        {
            this.lblErrorMessage.Text = "Please Select Product Name.";
            return;
        }

        else if (this.RbSpecificCategory.Checked == true
                    && this.DDLCategory.Text == "00000000-0000-0000-0000-000000000000")
        {
            this.lblErrorMessage.Text = "Please Select Category Name.";
            return;
        }
        else if (this.RbSpecificSubCategory.Checked == true
                && this.DDLSubCategory.Text == "00000000-0000-0000-0000-000000000000")
        {
            this.lblErrorMessage.Text = "Please Select Sub Category Name.";
            return;
        }
        else if (this.RbSpecificBrand.Checked == true
           && this.DDLBrand.Text == "00000000-0000-0000-0000-000000000000")
        {
            this.lblErrorMessage.Text = "Please Select Brand Name.";
            return;
        }
        else
        {
            this.lblErrorMessage.Text = "";
        }

        ReportSalesRegisterInfo oReportSalesInfo = new ReportSalesRegisterInfo();

        try
        {
            DateTime dtFrom, dtTo;
            string strReportCaption, crPath, strBranchName, strBrnachType, strBranchAddress, strPhone, strEmail,strPrintedBy, DemandStartDate, DemandEndDate;
            strReportCaption = "";
            crPath = "";
            strBranchName = "";
            strBrnachType = "";
            strBranchAddress = "";
            strPhone = "";
            strEmail = "";
            strPrintedBy = "Admin";
            DemandStartDate = this.txtFromDate.Text;
            DemandEndDate = this.txtToDate.Text;
            crPath = "CrysSalesRegister.rpt";
                      
            dtFrom = Convert.ToDateTime(this.txtFromDate.Text);
            dtTo = Convert.ToDateTime(this.txtToDate.Text);
            Guid BranchPk = Guid.NewGuid();
            Guid productCategoryPk = Guid.NewGuid();
            Guid productSubCategoryPk = Guid.NewGuid();
            Guid productBrandPk = Guid.NewGuid();
            Guid productPk = Guid.NewGuid();

            BranchPk = (Guid)TypeDescriptor.GetConverter(BranchPk).ConvertFromString(this.DDLBranch.SelectedValue);
            productCategoryPk = (Guid)TypeDescriptor.GetConverter(productCategoryPk).ConvertFromString(this.DDLCategory.SelectedValue);
            productSubCategoryPk = (Guid)TypeDescriptor.GetConverter(productSubCategoryPk).ConvertFromString(this.DDLSubCategory.SelectedValue);
            productBrandPk = (Guid)TypeDescriptor.GetConverter(productBrandPk).ConvertFromString(this.DDLBrand.SelectedValue);
            productPk = (Guid)TypeDescriptor.GetConverter(productPk).ConvertFromString(this.DDLProductName.SelectedValue);


            DataSet rptDS = new DataSet();
            rptDS = oReportSalesInfo.GetSalesInfo(dtFrom, dtTo, BranchPk, productCategoryPk, productSubCategoryPk, productBrandPk, productPk);

            // Retrieving data in cookies 
            if (Request.Cookies["DPOS"] != null)
            {
                string strBoothID = "";

                if (Request.Cookies["DPOS"]["BoothNo"] != null)
                {

                    strBoothID = Request.Cookies["DPOS"]["BoothNo"];

                    Guid BoothID = Guid.NewGuid();
                    BoothInfoDTO dto = new BoothInfoDTO();
                    // populate dto

                    Facade facade = Facade.GetInstance();

                    // PK keep in local variable 
                    BoothID = (Guid)TypeDescriptor.GetConverter(BoothID).ConvertFromString(strBoothID);

                    //  Get the Booth Information Corresponding Booth No. and keep Booth Info Domain Object
                    dto = facade.getBoothInfo_AllDTO(BoothID);

                    strBranchName = dto.BranchCode.BranchName;
                    strBrnachType = dto.BranchCode.BranchTypeInfoDTO.BT_Name;
                    strBranchAddress = dto.BranchCode.BranchAddress;
                    strPhone = dto.BranchCode.Telephone1 + "," + dto.BranchCode.Telephone2 + "," + dto.BranchCode.Telephone3;
                    strEmail = dto.BranchCode.EMail;
                }
            }
            else
            {
                Response.Redirect("~/Admin/Setup/Booth/BoothRegistration.aspx");
            }

            if (RbAllItemSalesRegister.Checked == true && RbSpecificProduct.Checked == false)
            {
                strReportCaption = lblAllProduct.Text;
            }
            
            if (RbAllItemSalesRegister.Checked == false && RbSpecificProduct.Checked == true)
            {
                strReportCaption = lblSpecificProduct.Text;
            }
            
            string reportPath = Server.MapPath(crPath);
            oReportDocument.Load(reportPath);
            oReportDocument.SetDataSource(rptDS.Tables[0]);
            oReportDocument.SetParameterValue("@ReportCaption", strReportCaption);
            oReportDocument.SetParameterValue("@DemandStartDate", DemandStartDate);
            oReportDocument.SetParameterValue("@DemandEndDate", DemandEndDate);
            oReportDocument.SetParameterValue("@BranchName", strBranchName);
            oReportDocument.SetParameterValue("@BranchType", strBrnachType);
            oReportDocument.SetParameterValue("@BranchAddress", strBranchAddress);
            oReportDocument.SetParameterValue("@BranchPhone", strPhone);
            oReportDocument.SetParameterValue("@BranchEmail", strEmail);
            oReportDocument.SetParameterValue("@PrintedBy", strPrintedBy);
            CommonViewer.CRReportDefinition = oReportDocument;

            Response.Redirect("~/Report/AllCrystalReportViewer/ReportViewer.aspx");
        }
        catch (Exception exp)
        {
            throw exp; 
        }
    }
    protected void btnClose_Click(object sender, EventArgs e)
    {
        Response.Redirect("~\\Report\\Default.aspx");
    }
}
