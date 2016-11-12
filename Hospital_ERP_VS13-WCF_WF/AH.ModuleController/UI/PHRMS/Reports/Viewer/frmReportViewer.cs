using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.UI.PHRMS.Reports.ReportUI;
using CrystalDecisions.CrystalReports.Engine;
using AH.ModuleController.PHRMSSR;
using AH.DUtility;


namespace AH.ModuleController.UI.PHRMS.Reports.Viewer
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
        public string Company { set; get; }
        public string ParamDateFrom { set; get; }
        public string ParamDateTo { set; get; }
        public string Group { set; get; }
        public string Pharmacy { set; get; }
        public string issueid { set; get; }
        public string POID { set; get; }
        public string ProductID { set; get; }
        public string MrrID { set; get; }
        public string PRID { set; get; }
        
        PHRMSSR.PHRMSWSClient clnt = new PHRMSSR.PHRMSWSClient();

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
        private void InitialiseLabels1(ReportDocument rpt)
        {

            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyName1"]).Text = Utility.GetCompanyName;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyAddress1"]).Text = Utility.GetCompanyAddress;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyEmail2"]).Text = Utility.GetCompanyEmail;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyPhone1"]).Text = Utility.GetCompanyPhone;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtIT1"]).Text = Utility.GetITDvnMsg;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyWeb1"]).Text = Utility.GetCompanyWeb;

            if (ReportTitle != "")
            {
                ((TextObject)rpt.ReportDefinition.ReportObjects["txtReportTitle1"]).Text = this.ReportTitle;
            }
            if (ReportSecondParameter != "")
            {

                ((TextObject)rpt.ReportDefinition.ReportObjects["txtSecondParameter1"]).Text = this.secondParameter;
            }
            else
            {
                rpt.ReportDefinition.ReportObjects["txtSecondParameter1"].ObjectFormat.EnableSuppress = true;
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
                
                case ViewerSelector.ProductReport:
                    rptProductList pr = new rptProductList();
                    rpt1 = (ReportDocument)pr;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetDrugsCompanyWise(Company));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1, this.isPrintDirect);
                    break;
                case ViewerSelector.SalesReport:
                    rptSalesVoucher osal = new rptSalesVoucher();
                    try
                    {
                        if (issueid != "")
                        {
                            rpt1 = (ReportDocument)osal;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(clnt.GetSalesReport(issueid).ToList());
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect);
                        }
                    }
                    catch
                    {

                    }
                    break;
                   
                case ViewerSelector.SalesRetDetReport:
                    rptSalesRetReportDetails osaldet = new rptSalesRetReportDetails();
                    rpt1 = (ReportDocument)osaldet;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetSalRetReportDet(ParamDateFrom, ParamDateTo));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.SalesRetReport:
                    rptSalesRetReport osalret = new rptSalesRetReport();
                    try
                    {
                        if (issueid != "")
                        {
                            rpt1 = (ReportDocument)osalret;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(clnt.GetSalRetReport(issueid).ToList());
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect);
                        }
                    }
                    catch
                    {

                    }
                    break;
                case ViewerSelector.StockList:
                    rptMedicineStock ostock = new rptMedicineStock();
                    rpt1 = (ReportDocument)ostock;
                    rpt1.SetDataSource(clnt.GetDrugStockList(Group,Pharmacy));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.PODetails:
                    rptPODetails opodet = new rptPODetails();
                    rpt1 = (ReportDocument)opodet;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetPOReportDet(POID));
                    rpt1.Subreports[0].SetDataSource(clnt.GetPOTermsConditions(POID));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.ProductLedger:
                    rptProductLedger oprodled = new rptProductLedger();
                    rpt1 = (ReportDocument)oprodled;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetProductLedger(ProductID,ParamDateFrom,ParamDateTo));
                    
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.POReportDateWise:
                    rptPODetailsDateWise opodate = new rptPODetailsDateWise();
                    rpt1 = (ReportDocument)opodate;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetPOReportDateWise(ParamDateFrom,ParamDateTo));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.MrrDetailsReport:
                    rptMrrDetailsReport omrrdet = new rptMrrDetailsReport();
                    rpt1 = (ReportDocument)omrrdet;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetMrrReport(ParamDateFrom, ParamDateTo));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1, this.isPrintDirect);
                    break;
                case ViewerSelector.StockDetailsReport:
                    rptMedicineStockDetails omedstock = new rptMedicineStockDetails();
                    rpt1 = (ReportDocument)omedstock;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetDrugStockListDetails(Pharmacy));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.ItemRatesReport:
                    rptItemRates orates = new rptItemRates();
                    rpt1 = (ReportDocument)orates;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetItemRatesReport());
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.ItemRatesHistReport:
                    rptItemRatesHist ohist = new rptItemRatesHist();
                    rpt1 = (ReportDocument)ohist;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetItemRatesHistReport(ProductID,ParamDateFrom,ParamDateTo));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.OpeningReport:
                    rptOpeningReport opnrpt = new rptOpeningReport();
                    rpt1 = (ReportDocument)opnrpt;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetOpeningReport());
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.ExpireDateReport:
                    rptExpireDate oexpdate = new rptExpireDate();
                    rpt1 = (ReportDocument)oexpdate;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetDrugsByExpireDate(ParamDateFrom,ParamDateTo));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.MrrReport :
                    rptMrrReport omrrpt = new rptMrrReport();
                    rpt1 = (ReportDocument)omrrpt;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetMrrReportByMrID(MrrID));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
                    break;
                case ViewerSelector.PRReport :
                    rptPRReport oprreport = new rptPRReport();
                    rpt1 = (ReportDocument)oprreport;
                    InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetPRreport(PRID));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1,this.isPrintDirect);
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
