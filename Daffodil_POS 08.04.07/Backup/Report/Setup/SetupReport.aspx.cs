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
using DSL.POS.Facade;
using DSL.POS.DTO.DTO;
using DSL.POS.BusinessLogicLayer.Interface;
using DSL.POS.Report.Setup;
using DSL.POS.Report;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.ComponentModel;

public partial class Report_Setup_SetupReport : System.Web.UI.Page
{
    private ReportDocument oReportDocument = new ReportDocument();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole(ConfigurationManager.AppSettings["generaluserrolename"]))
        {
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx");
        }
        //this.RbAllBranch.Attributes.Add("onClick", "doAllBranch()");
        //this.RbSpecificBranch.Attributes.Add("onClick", "doSpecificBranch()");

    }
    protected void btnReport_Click(object sender, EventArgs e)
    {
       
        ReportSetupInfo oReportSetupInfo = new ReportSetupInfo();
        string crPath, strBranchName, strBrnachType, strBranchAddress, strPhone, strEmail,strPrintedBy;
        crPath = "";
        strBranchName = "";
        strBrnachType = "";
        strBranchAddress = "";
        strPhone = "";
        strEmail = "";
        strPrintedBy = "Admin";
        
        DataSet ds = new DataSet();
        Guid BranchPk = Guid.NewGuid();

        //BranchPk = (Guid)TypeDescriptor.GetConverter(BranchPk).ConvertFromString(this.DDLBranch.SelectedValue);


        try
        {

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
            //else
            //    lblmsg.Text = "call your system admin!";
            //return;
            if (this.RbBranchInformation.Checked == true)
            {
                ds = oReportSetupInfo.getBranchInfo(1);
                crPath = "CrysBranchInfo.rpt";
            }
            else if (this.RbMemberInformation.Checked == true)
            {
                ds = oReportSetupInfo.getMemberInfo(2);
                crPath = "CrysMemberInfo.rpt";
            }
            else if (this.RbSupplierInformation.Checked == true)
            {
                ds = oReportSetupInfo.getSupplierInfo(3);
                crPath = "CrysSupplierInfo.rpt";
            }
            else if (this.RbProductInformation.Checked == true)
            {
                ds = oReportSetupInfo.getProductInfo(4);
                crPath = "CrysAllProductInfo.rpt";
            }
            else if (this.RbProductCategoryInfo.Checked == true)
            {
                ds = oReportSetupInfo.getProductCategoryInfo(5);
                crPath = "CrysProductCategoryInfo.rpt";
            }

            else if (this.RbProductSubCategoryInfo.Checked == true)
            {
                ds = oReportSetupInfo.getProductSubCategoryInfo(6);
                crPath = "CrysProductSubCategoryInfo.rpt";
            }

            else if (this.RbProductUnitInfo.Checked == true)
            {
                ds = oReportSetupInfo.getProductUnitInfo(7);
                crPath = "CrysProductUnitInfo.rpt";
            }

            else if (this.RbBoothInfo.Checked == true)
            {
                ds = oReportSetupInfo.getBoothInfo(8);
                crPath = "CrysBoothInfo.rpt";
            }

            else if (this.RbProductSummary.Checked == true)
            {
                ds = oReportSetupInfo.getProductSummaryInfo(9);
                crPath = "CrysProductSummaryInfo.rpt";
            }
            
            string reportPath = Server.MapPath(crPath);
            oReportDocument.Load(reportPath);
            oReportDocument.SetDataSource(ds.Tables[0]);
            
            oReportDocument.SetParameterValue("@PrintedBy",strPrintedBy);
            oReportDocument.SetParameterValue("@BranchName", strBranchName);
            oReportDocument.SetParameterValue("@BranchType", strBrnachType);
            oReportDocument.SetParameterValue("@BranchAddress", strBranchAddress);
            oReportDocument.SetParameterValue("@BranchPhone", strPhone);
            oReportDocument.SetParameterValue("@BranchEmail", strEmail);
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
        Response.Redirect("/Web/Report/Default.aspx");
    }
}
