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


public partial class Report_Purchase_PurchaseReport : System.Web.UI.Page
{
    private ReportDocument oReportDocument = new ReportDocument();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Roles.IsUserInRole(ConfigurationManager.AppSettings["generaluserrolename"]))
        {
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx");
        }
        if (!IsPostBack)
        {
            this.txtFromDate.Focus();
            this.RbAllSupplier.Attributes.Add("onClick", "doAllSupplier()");
            this.RbSpecificSupplier.Attributes.Add("onClick", "doSpecificSupplier()");
            this.RbAllCategory.Attributes.Add("onClick", "doAllCategory()");
            this.RbSpecificCategory.Attributes.Add("onClick", "doSpecificCategory()");
            this.RbAllSubCategory.Attributes.Add("onClick", "doAllSubCategory()");
            this.RbSpecificSubCategory.Attributes.Add("onClick", "doSpecificSubCategory()");
            this.RbAllBrand.Attributes.Add("onClick", "doAllBrand()");
            this.RbSpecificBrand.Attributes.Add("onClick", "doSpecificBrand()");
            this.txtFromDate.Attributes.Add("onKeyUp", "formatFromDateField()");
            this.txtToDate.Attributes.Add("onKeyUp", "formatToDateField()");
            this.txtFromDate.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            this.txtToDate.Attributes.Add("onkeyPress", "FocusControl_byEnter()");

            try
            {
                Facade facade = Facade.GetInstance();
                DropDownListSupplier(facade);
                DropDownListBrand(facade);
                DropDownListProCategory(facade);
                DropDownListProductSubCategory(facade);
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
    private void DropDownListSupplier(Facade facade)
    {
        ISupplierInfoBL SupplierInfoList = facade.createSupplierBL();
        List<SupplierInfoDTO> oSupplierInfoList = SupplierInfoList.showDataSupplierInfo();

        int i = 0;
        DDLSupplierName.Items.Clear();
        DDLSupplierName.Items.Add("(Select Supplier Name)");
        this.DDLSupplierName.Items[i].Value = "00000000-0000-0000-0000-000000000000";
        foreach (SupplierInfoDTO newDto in oSupplierInfoList)
        {
            i++;
            this.DDLSupplierName.Items.Add(newDto.SupplierName);
            this.DDLSupplierName.Items[i].Value = newDto.PrimaryKey.ToString();
        }
    }
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
            this.lblErrorMessage.Text = "Please Select Start Date.";
            this.txtFromDate.Focus();
            return;
        }
        else if (this.txtToDate.Text.Trim() == "")
        {
            this.lblErrorMessage.Text = "Please Select End Date.";
            this.txtToDate.Focus();
            return;
        }
        else if (this.RbSpecificSupplier.Checked == true 
                 && this.DDLSupplierName.Text == "00000000-0000-0000-0000-000000000000")
        {
            this.lblErrorMessage.Text = "Please Select Supplier Name.";
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

        ReportPurchaseRegisterInfo oReportPurchaseInfo = new ReportPurchaseRegisterInfo();

        try
        {

            DateTime dtFrom, dtTo;
            string strReportCaption, crPath, strBranchName, strBrnachType, strBranchAddress, strPhone, strEmail,strPrintedBy, DemandStartDate, DemandEndDate ;
            strReportCaption = "";
            crPath = "";
            strBranchName = "";
            strBrnachType = "";
            strBranchAddress = "";
            strPhone = "";
            strEmail = "";
            strPrintedBy = "Admin";
            
            dtFrom = Convert.ToDateTime(this.txtFromDate.Text);
            dtTo = Convert.ToDateTime(this.txtToDate.Text);
            Guid productCategoryPk = Guid.NewGuid();
            Guid productSubCategoryPk = Guid.NewGuid();
            Guid productBrandPk = Guid.NewGuid();
            Guid SupplierPk = Guid.NewGuid();

            productCategoryPk = (Guid)TypeDescriptor.GetConverter(productCategoryPk).ConvertFromString(this.DDLCategory.SelectedValue);
            productSubCategoryPk = (Guid)TypeDescriptor.GetConverter(productSubCategoryPk).ConvertFromString(this.DDLSubCategory.SelectedValue);
            productBrandPk = (Guid)TypeDescriptor.GetConverter(productBrandPk).ConvertFromString(this.DDLBrand.SelectedValue);
            SupplierPk = (Guid)TypeDescriptor.GetConverter(SupplierPk).ConvertFromString(this.DDLSupplierName.SelectedValue);


            DataSet rptDS = new DataSet();
            rptDS = oReportPurchaseInfo.GetPurchaseRegisterInfo(dtFrom, dtTo, productCategoryPk, productSubCategoryPk, productBrandPk, SupplierPk);

            // Retrieving data in cookies 
            if (Request.Cookies["DPOS"] != null)
            {
                string strBoothID = "";

                if (Request.Cookies["DPOS"]["BoothNo"] != null)
                {
                    strBoothID = Request.Cookies["DPOS"]["BoothNo"];

                    Guid  BoothID = Guid.NewGuid();
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
            
            if (RbDailyPurchaseRegister.Checked == true)
            {
                strReportCaption = lblDailyPurchase.Text;
                crPath = "CrysDailyPurchaseRegister.rpt";
            }
            //if (RbSupplierWisePurchase.Checked == true)
            //{
            //    strReportCaption = lblSupplierWisePurchase.Text;
            //    crPath = "CrysSupplierWisePurchase.rpt";
            //}
            //if(RbSWPSummary.Checked == true)
            //{
            //    strReportCaption = lblSupplierWisePurchaseSummary.Text;
            //    crPath = "CrysSuppliserWisePurchaseSummary.rpt";
            //}
            //if (RbSupplierWisePurchase.Checked == true)
            //{
            //    strReportCaption = lblSupplierWisePurchase.Text;
            //    crPath = "CrysSuppliserWisePurchase.rpt";
            //}
            if (RbProductWiseDetails.Checked == true)
            {
                strReportCaption = lblProductwisePurchase.Text;
                crPath = "CrysProductWisePurchaseDetails.rpt";
            }
            DemandStartDate = this.txtFromDate.Text;
            DemandEndDate = this.txtToDate.Text;


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

            Response.Redirect("~\\Report\\AllCrystalReportViewer\\ReportViewer.aspx");
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
