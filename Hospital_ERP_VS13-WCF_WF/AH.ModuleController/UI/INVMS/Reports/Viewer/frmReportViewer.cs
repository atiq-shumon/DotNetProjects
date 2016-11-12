using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.UI.INVMS.Reports.ReportUI;
using CrystalDecisions.CrystalReports.Engine;
using AH.ModuleController.INVMSSR;
using AH.DUtility;


namespace AH.ModuleController.UI.InvMS.Reports.Viewer
{
    public partial class frmReportViewer : Form
    {
        private Boolean isPrintDirect = false;
        private String reportTitle = "";
        private String secondParameter = "";
        public ViewerSelector selector;
        public String ReportTitle { set { reportTitle = value; } get { return reportTitle; } }
        public String ReportSecondParameter { set { secondParameter = value; } get { return secondParameter; } }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public string PatientNo { set; get; }
        public string ItemList { set; get; }
        public string ParamDateFrom { set; get; }
        public string ParamDateTo { set; get; }
        public string Group { set; get; }
        public string Store { set; get; }
        public string issueid { set; get; }
        public string POID { set; get; }
        public string MrrID { set; get; }
        public string ProductID { set; get; }
        public string StoreType { set; get; }
        public string PRID { set; get; }
        public string DRID { set; get; }

        

        INVMSSR.INVMSWSClient clnt = new INVMSSR.INVMSWSClient();

        public frmReportViewer()
        {
            InitializeComponent();
        }
        public frmReportViewer(Boolean isPrintDirect)
            : this()
        {
            this.isPrintDirect = isPrintDirect;
        }

        public string GetDateRange()
        {
           
            return StartDate.ToString("dd-MM-yyyy") + "    To    " + EndDate.ToString("dd-MM-yyyy");
        }

        private void InitialiseLabels(ReportDocument rpt)
        {
            
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyName"]).Text = Utility.GetCompanyName;
            //((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyName1"]).Text = Utility.GetCompanyName;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyAddress"]).Text = Utility.GetCompanyAddress;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyEmail"]).Text = Utility.GetCompanyEmail;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyPhone"]).Text = Utility.GetCompanyPhone;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtIT"]).Text = Utility.GetITDvnMsg;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyWeb"]).Text = Utility.GetCompanyWeb;
            
            if (ReportTitle != "")
            {
                ((TextObject)rpt.ReportDefinition.ReportObjects["txtReportTitle"]).Text = this.ReportTitle;
            }
            if (ReportSecondParameter != "")
            {

                ((TextObject)rpt.ReportDefinition.ReportObjects["txtSecondParameter"]).Text = this.secondParameter;
            }
            else
            {
                rpt.ReportDefinition.ReportObjects["txtSecondParameter"].ObjectFormat.EnableSuppress = true;
            }
            
            //TextObject txtItmsg = (TextObject)rpt.Section5.ReportObjects["txtITDvnMsg"];
            //txtItmsg.Text = Utility.GetITDvnMsg;
        }

        private void ShowReport(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt, Boolean isDirectPrint)
        {
            if (isDirectPrint == true)
            {
                //PrintDocument pd = new PrintDocument();
                //pd.PrinterSettings.PrinterName=

                //rpt.PrintOptions.PrinterName = "";

                rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                //rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Cassette;
                rpt.PrintToPrinter(1, false, 0, 0);
                //rpt.PrintToPrinter(1, false, 0, 0);

            }
            else
            {

                this.Show();
            }

        }

        public void ViewReport()
        {
            this.crystalReportViewer1.Cursor = Cursors.WaitCursor;
            ReportDocument rpt1;
            switch (selector)
            {

                case ViewerSelector.ItemList:
                    rptItemStockList oitem = new rptItemStockList();
                    rpt1 = (ReportDocument)oitem;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetItemListGroupWise(Group));
                    crystalReportViewer1.ReportSource = rpt1;

                    ShowReport(rpt1, this.isPrintDirect);
                   
                    break;
                case ViewerSelector.StockDetails:
                    rptItemStockDetails ostock = new rptItemStockDetails();
                    rpt1 = (ReportDocument)ostock;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetStockDetailsStoreWise(Store));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.ProductLedger:
                    rptProductLedger oprod = new rptProductLedger();
                    rpt1 = (ReportDocument)oprod;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetProductLedger(ProductID,ParamDateFrom,ParamDateTo));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.POReportDateWise:
                    rptPOReportDateWise oporpt = new rptPOReportDateWise();
                    rpt1 = (ReportDocument)oporpt;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetPOReportDateWise(ParamDateFrom,ParamDateTo));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.IssueReportDateWise:
                    rptIssueDateWise orpt = new rptIssueDateWise();
                    rpt1 = (ReportDocument)orpt;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetIssueReportDateWise(ParamDateFrom,ParamDateTo));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.IssueReportGroupWise:
                    rptIssueGroupWise orptgroupwise = new rptIssueGroupWise();
                    rpt1 = (ReportDocument)orptgroupwise;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetIssueReportGroupWise(Group,ParamDateFrom, ParamDateTo));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1, this.isPrintDirect);
                    break;
                case ViewerSelector.POReport :
                    rptPOReport oporeport = new rptPOReport();
                    try
                    {
                        if (POID != "")
                        {
                            rpt1 = (ReportDocument)oporeport;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(clnt.GetPOReport(POID));
                            rpt1.Subreports[0].SetDataSource(clnt.GetPOTermsConditions(POID));
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect);
                        }
                    }
                    catch
                    {

                    }
                    break;
                case ViewerSelector.MrrReport :
                    rptMrrReport omrreport = new rptMrrReport();
                    rpt1 = (ReportDocument)omrreport;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetMrrReport(MrrID));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.PrReport:
                    rptPRReport oprreport = new rptPRReport();
                    rpt1 = (ReportDocument)oprreport;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetPRreport(PRID));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.DrReport:
                    rptDRReport odrreport = new rptDRReport();
                    rpt1 = (ReportDocument)odrreport;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetDRreport(DRID));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1, this.isPrintDirect);
                    break;
                case ViewerSelector.OpeningReport :
                     rptOpeningReport openport = new rptOpeningReport();                   
                     rpt1 = (ReportDocument)openport;
                     InitialiseLabels(rpt1);
                     rpt1.SetDataSource(clnt.GetOpeningReport(MrrID));
                     crystalReportViewer1.ReportSource = rpt1;
                     ShowReport(rpt1, this.isPrintDirect);                    
                    break;
                case ViewerSelector.IssueReport :
                    rptSalesVoucher osales = new rptSalesVoucher();
                    try
                    {
                        if (issueid != "")
                        {
                            rpt1 = (ReportDocument)osales;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(clnt.GetSalesReport(issueid));
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect);
                        }
                    }
                    catch
                    {

                    }
                    break;
                case ViewerSelector.StockDetailsReport :
                    rptStockDetailsReport ostkdet = new rptStockDetailsReport();
                    rpt1 = (ReportDocument)ostkdet;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetStockDetailsReport(Group, ParamDateFrom, ParamDateTo));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.POTermsConditions:
                    rptPOTermsCondition oterm = new rptPOTermsCondition();
                    rpt1 = (ReportDocument)oterm;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetPOTermsConditions(POID));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1, this.isPrintDirect);
                    break;
                case ViewerSelector.ItemsStoreTypeGroupWise :
                    rptItemListStoreTypeGroupWise oitmstrgrp = new rptItemListStoreTypeGroupWise();
                    rpt1 = (ReportDocument)oitmstrgrp;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetItemGroupStoretypeWise(StoreType,Group));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1, this.isPrintDirect);
                    break;
                case ViewerSelector.StockReportGroupwise :
                    rptStockReportGroupwise ostockreport = new rptStockReportGroupwise();
                    rpt1 = (ReportDocument)ostockreport;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetStockReportGroupwise(ParamDateFrom, ParamDateTo));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1, this.isPrintDirect);
                    break;
                case ViewerSelector.MrrDetailsReport:
                    rptMrrDetailsReport omrrdet = new rptMrrDetailsReport();
                    rpt1 = (ReportDocument)omrrdet;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetMrrReportDateWise(ParamDateFrom, ParamDateTo));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1, this.isPrintDirect);
                    break;
                //#region PatientRegistrationDeatailsByHCN
                ////Patient Registration Details
                //case ViewerSelector.PetRegDetailsbyHCN:
                //    ReportDocument rptPetReg;
                //    rptPatRegHCN rPetReg = new rptPatRegHCN();
                //    rptPetReg = (ReportDocument)rPetReg;
                //    rPetReg.SetDataSource(clnt.GetPatientRegistartionDetailsbyHCN(WhereCondition));
                //    crystalReportViewer1.ReportSource = rptPetReg;
                //    ShowReport(rptPetReg, this.isPrintDirect);
                //    break;
                //#endregion
                //#region PatientRegistrationDeatailsByDateRange
                ////Patient Registration Details
                //case ViewerSelector.PetRegDetailsbyDateRange:
                //    ReportDocument rptPetRegDR;
                //    rptPatientRegistrationDetails rPetRegDR = new rptPatientRegistrationDetails();
                //    rptPetRegDR = (ReportDocument)rPetRegDR;
                //    InitialiseLabels(rptPetRegDR);
                //    rPetRegDR.SetDataSource(clnt.GetPatientRegistartionDetailsbyDateRange(WhereCondition));
                //    crystalReportViewer1.ReportSource = rptPetRegDR;
                //    ShowReport(rptPetRegDR, this.isPrintDirect);
                //    break;
                //#endregion

            }
            this.crystalReportViewer1.RefreshReport();
            this.crystalReportViewer1.Cursor = Cursors.Arrow;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
         

    }
}
