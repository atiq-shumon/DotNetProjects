using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using AH.DUtility;
using AH.ModuleController.UI.DRS.Reports.ReportUI;
using AH.ModuleController.DRSSR;

namespace AH.ModuleController.UI.DRS.Reports.Viewer
{
    public partial class frmReportViewer : Form
    {
        DRSWSClient drsClnt = new DRSWSClient();
        public frmReportViewer()
        {
            InitializeComponent();
        }
        #region Declaration
        public Boolean isPrintDirect = false;
        private String reportTitle = "";
        private String secondParameter = "";
        public ViewerSelector selector;
        public String ReportTitle { set { reportTitle = value; } get { return reportTitle; } }
        public String ReportSecondParameter { set { secondParameter = value; } get { return secondParameter; } }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public string PatientNo { set; get; }
        public string MoneyReceiptNo { set; get; }
        public string TicketNo { set; get; }
        public string ReportFor { set; get; }
        public string GroupID { set; get; }
        public string DeptID { set; get; }
        public string MainID { set; get; }
        public string DetailsID { set; get; }
        public string TransactionNo { set; get; }
        public string RptSectionID { set; get; }
        public string RptGroupID { set; get; }
        public string ToDate { set; get; }
        public string FromDate { set; get; }
        public string MachineID { set; get; }
        public string TestDetailID { set; get; }

        #endregion
       
        public frmReportViewer(Boolean isPrintDirect): this()
        {
            this.isPrintDirect = isPrintDirect;
        }

        private string GetDateRange()
        {
            return StartDate.ToString("dd-MM-yyyy") + "    To    " + EndDate.ToString("dd-MM-yyyy");
        }

        private void InitialiseLabels(ReportDocument rpt)
        {

            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyName"]).Text = Utility.GetCompanyName;
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
        }

        private void ShowReport(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt, Boolean isDirectPrint)
        {
            if (isDirectPrint == true)
            {
                rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                rpt.PrintToPrinter(1, false, 0, 0);
            }
            else
            {
                this.Show();
            }

        }
        private void OpenPdfFile()
        {
            try
            {

                Process.Start(@"C:\TFA.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please install MicrosoftOffice/Pdf Reader to view files", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //public void ViewReport()
        //{
        //    switch (selector)
        //    {
        //        #region TestDetails
        //        //Test Deatails
        //        case ViewerSelector.InvestigationReport:
        //            ReportDocument rpt1;
        //            rptDRSInvestigationReport rDM = new rptDRSInvestigationReport();
        //            rpt1 = (ReportDocument)rDM;
        //            //InitialiseLabels(rpt1);
        //            rpt1.SetDataSource(drsClnt.GetInvestigationReport(TransactionNo));
        //            crystalReportViewer1.ReportSource = rpt1;
        //            ShowReport(rpt1, this.isPrintDirect);
        //            break;
        //        #endregion



        //    }
        //    this.crystalReportViewer1.RefreshReport();
        //}

        public void ViewReport()
        {
            try
            {
                switch (selector)
                {
                    #region TestDetails
                    case ViewerSelector.InvestigationReport:
                        ReportDocument rpt1;
                        rptDRSInvestigationReport rDM = new rptDRSInvestigationReport();
                        rpt1 = (ReportDocument)rDM;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(drsClnt.GetInvestigationReport(TransactionNo));
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect);
                        break;
                    #endregion


                    #region InvestigationReportPreview
                    case ViewerSelector.InvestigationReportPreview:
                        ReportDocument rptPreview;
                        rptDRSInvestigationReport rDMPreview = new rptDRSInvestigationReport();
                        rptPreview = (ReportDocument)rDMPreview;
                        InitialiseLabels(rptPreview);
                        rptPreview.SetDataSource(drsClnt.GetInvestigationReportPreview(TransactionNo, RptSectionID, RptGroupID));
                        crystalReportViewer1.ReportSource = rptPreview;
                        ShowReport(rptPreview, this.isPrintDirect);
                        break;
                    #endregion

                    #region Investigation BulkReportPrint
                    //Test Deatails
                    case ViewerSelector.InvestBulkReportPrint:
                        ReportDocument Brpt;
                        rptDRSInvestigationReport BRpts = new rptDRSInvestigationReport();
                        Brpt = (ReportDocument)BRpts;
                        InitialiseLabels(Brpt);
                        Brpt.SetDataSource(drsClnt.GetBulkReportPrint(RptSectionID, RptGroupID, ToDate, FromDate));
                        crystalReportViewer1.ReportSource = Brpt;
                        ShowReport(Brpt, this.isPrintDirect);
                        break;
                    #endregion

                    #region Stain BulkReportPrint
                    //Test Deatails
                    case ViewerSelector.StainBulkReportPrint:
                        ReportDocument Srpt;
                        rptStainReport SRpts = new rptStainReport();
                        Srpt = (ReportDocument)SRpts;
                        InitialiseLabels(Srpt);
                        Srpt.SetDataSource(drsClnt.GetBulkReportPrint(RptSectionID, RptGroupID, ToDate, FromDate));
                        crystalReportViewer1.ReportSource = Srpt;
                        ShowReport(Srpt, this.isPrintDirect);
                        break;
                    #endregion

                    #region Cunture and Sensetivity BulkReportPrint
                    case ViewerSelector.CultureBulkReportPrint:
                        ReportDocument Crpt;
                        rptCultureAndSensiReport CRpts = new rptCultureAndSensiReport();
                        Crpt = (ReportDocument)CRpts;
                        InitialiseLabels(Crpt);
                        Crpt.SetDataSource(drsClnt.MBioBulkReportPrint(RptSectionID, RptGroupID, ToDate, FromDate));
                        Crpt.Subreports[0].SetDataSource(drsClnt.GetMicroBioResultA2(RptSectionID, RptGroupID, ToDate, FromDate));
                        Crpt.Subreports[1].SetDataSource(drsClnt.GetMicroBioResultB2(RptSectionID, RptGroupID, ToDate, FromDate));
                        Crpt.Subreports[2].SetDataSource(drsClnt.GetMicroBioResultC2(RptSectionID, RptGroupID, ToDate, FromDate));
                        crystalReportViewer1.ReportSource = Crpt;
                        ShowReport(Crpt, this.isPrintDirect);

                        break;
                    #endregion

                    #region Specimen
                    case ViewerSelector.SpecimenReport:
                        ReportDocument rptspr1;
                        SpecimenCollectionLbl rSpDM = new SpecimenCollectionLbl();
                        rptspr1 = (ReportDocument)rSpDM;
                        //InitialiseLabels(rptspr1);
                        rptspr1.SetDataSource(drsClnt.GetSpecimensReprint(TransactionNo));
                        crystalReportViewer1.ReportSource = rptspr1;

                        ShowReport(rptspr1, this.isPrintDirect);
                        break;
                    #endregion

                    #region StainReport
                    //Test Deatails
                    case ViewerSelector.StainReport:
                        ReportDocument stainRpt;
                        rptStainReport rptStn = new rptStainReport();
                        stainRpt = (ReportDocument)rptStn;
                        InitialiseLabels(stainRpt);
                        stainRpt.SetDataSource(drsClnt.GetInvestigationReport(TransactionNo));
                        crystalReportViewer1.ReportSource = rptStn;
                        ShowReport(stainRpt, this.isPrintDirect);
                        break;
                    #endregion
                 
                    #region SpecimenDet
                    case ViewerSelector.SpecimenDetailsReport:
                        ReportDocument rptSpd;
                        SpecimenCollLblDet rSpD = new SpecimenCollLblDet();
                        rptSpd = (ReportDocument)rSpD;
                        //InitialiseLabels(rptSpd);
                        rptSpd.SetDataSource(drsClnt.GetSpecimens(TransactionNo));
                        //crystalReportViewer1.ReportSource = rptSpd;
                        //rptSpd.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                        //rptSpd.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                        //DiskFileDestinationOptions objDiskOpt = new DiskFileDestinationOptions();
                        //crystalReportViewer1.ReportSource = rptSpd;                
                        crystalReportViewer1.ReportSource = rSpD;
                        ShowReport(rptSpd, isPrintDirect);
                        //try
                        //{
                        //    objDiskOpt.DiskFileName = @"C:\TFA.pdf";
                        //    rptSpd.ExportOptions.DestinationOptions = objDiskOpt;
                        //    rptSpd.Export();
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show("Close Previous Report Properly");
                        //    return;
                        //}
                        //OpenPdfFile();
                      //  Pdf.PrintPDFs(@"C:\TFA.pdf");
                       // rptSpd.PrintToPrinter();
                        

                        //  ShowReport(rptSpd, this.isPrintDirect);
                        break;
                        
                    #endregion

                    #region GetSpecimensReprint
                    case ViewerSelector.SpecimenDetailsReportPreView:
                        ReportDocument rptSpd1;
                        SpecimenCollLblDet rSpD1 = new SpecimenCollLblDet();
                        rptSpd1 = (ReportDocument)rSpD1;
                        //InitialiseLabels(rptSpd);
                        rptSpd1.SetDataSource(drsClnt.GetSpecimensReprint(TransactionNo));
                        //crystalReportViewer1.ReportSource = rptSpd;
                        //rptSpd.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                        //rptSpd.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                        //DiskFileDestinationOptions objDiskOpt = new DiskFileDestinationOptions();
                        //crystalReportViewer1.ReportSource = rptSpd;                
                        crystalReportViewer1.ReportSource = rSpD1;
                        ShowReport(rptSpd1, isPrintDirect);
                        //try
                        //{
                        //    objDiskOpt.DiskFileName = @"C:\TFA.pdf";
                        //    rptSpd.ExportOptions.DestinationOptions = objDiskOpt;
                        //    rptSpd.Export();
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show("Close Previous Report Properly");
                        //    return;
                        //}
                        //OpenPdfFile();
                      //  Pdf.PrintPDFs(@"C:\TFA.pdf");
                       // rptSpd.PrintToPrinter();
                        

                        //  ShowReport(rptSpd, this.isPrintDirect);
                        break;
                        
                    #endregion



                    #region WorkShhet
                    case ViewerSelector.WorkSheet:
                        ReportDocument CulRptW;
                        rptWorkSheet rptCulW = new rptWorkSheet();
                        CulRptW = (ReportDocument)rptCulW;
                        InitialiseLabels(CulRptW);
                        CulRptW.SetDataSource(drsClnt.GetWorkSheet(TransactionNo, RptSectionID));
                        crystalReportViewer1.ReportSource = rptCulW;
                        ShowReport(CulRptW, this.isPrintDirect);
                        break;
                    #endregion


                    #region CultureAndSesitivityMultiColumnReport
                    //Test Deatails
                    case ViewerSelector.multicolumn:

                        int counts = drsClnt.GetMicroBioResCnt(TransactionNo);
                        if (counts < 40)
                        {
                            ReportDocument CulRpt2;
                            rptCSMultiColumn rptCul1 = new rptCSMultiColumn();
                            CulRpt2 = (ReportDocument)rptCul1;
                            InitialiseLabels(CulRpt2);
                            CulRpt2.SetDataSource(drsClnt.GetMicroBioReport(TransactionNo));
                            CulRpt2.Subreports[0].SetDataSource(drsClnt.GetMicroBioResultAA(TransactionNo));
                            CulRpt2.Subreports[1].SetDataSource(drsClnt.GetMicroBioResultBB(TransactionNo));
                            crystalReportViewer1.ReportSource = rptCul1;
                            ShowReport(CulRpt2, this.isPrintDirect);
                        }
                        if (counts > 40)
                        {
                            ReportDocument CulRpt;
                            rptCultureAndSensiReport rptCul = new rptCultureAndSensiReport();
                            CulRpt = (ReportDocument)rptCul;
                            InitialiseLabels(CulRpt);
                            CulRpt.SetDataSource(drsClnt.GetMicroBioReport(TransactionNo));
                            CulRpt.Subreports[0].SetDataSource(drsClnt.GetMicroBioResultA(TransactionNo));
                            CulRpt.Subreports[1].SetDataSource(drsClnt.GetMicroBioResultB(TransactionNo));
                            CulRpt.Subreports[2].SetDataSource(drsClnt.GetMicroBioResultC(TransactionNo));
                            crystalReportViewer1.ReportSource = rptCul;
                            ShowReport(CulRpt, this.isPrintDirect);
                        }
                        break;
                    #endregion

                    #region Patient Label Print
                    //Test Deatails
                    case ViewerSelector.printPatientLabel:
                        ReportDocument Prpt;
                        rptPrintPatientLabel PRpts = new rptPrintPatientLabel();
                        Prpt = (ReportDocument)PRpts;
                        //  InitialiseLabels(Prpt);
                        Prpt.SetDataSource(drsClnt.PatientListForLabelPrintReport(TransactionNo, RptGroupID));
                        crystalReportViewer1.ReportSource = PRpts;
                        ShowReport(Prpt, this.isPrintDirect);
                        break;
                    #endregion

                    #region CultureAndSesitivityReportPreview
                    //Test Deatails
                    case ViewerSelector.MicroBioReportPreview:

                        int cnt = drsClnt.GetMicroBioResCnt(TransactionNo);
                        if (cnt < 40)
                        {
                            ReportDocument CulRptPre;
                            rptCSMultiColumn rptCulPre = new rptCSMultiColumn();
                            CulRptPre = (ReportDocument)rptCulPre;
                            InitialiseLabels(CulRptPre);
                            CulRptPre.SetDataSource(drsClnt.GetMicroBioReportPreview(TransactionNo));
                            CulRptPre.Subreports[0].SetDataSource(drsClnt.GetMicroBioResultAPreview(TransactionNo));
                            CulRptPre.Subreports[1].SetDataSource(drsClnt.GetMicroBioResultBPreview(TransactionNo));
                            crystalReportViewer1.ReportSource = rptCulPre;
                            ShowReport(CulRptPre, this.isPrintDirect);
                        }
                        if (cnt > 40)
                        {
                            ReportDocument CulRpt;
                            rptCultureAndSensiReport rptCul = new rptCultureAndSensiReport();
                            CulRpt = (ReportDocument)rptCul;
                            InitialiseLabels(CulRpt);
                            CulRpt.SetDataSource(drsClnt.GetMicroBioReportPreview(TransactionNo));
                            CulRpt.Subreports[0].SetDataSource(drsClnt.GetMicroBioResultA(TransactionNo));
                            CulRpt.Subreports[1].SetDataSource(drsClnt.GetMicroBioResultB(TransactionNo));
                            CulRpt.Subreports[2].SetDataSource(drsClnt.GetMicroBioResultC(TransactionNo));
                            crystalReportViewer1.ReportSource = rptCul;
                            ShowReport(CulRpt, this.isPrintDirect);
                        }
                        break;
                    #endregion

                    #region StainReportPreview
                    //Test Deatails
                    case ViewerSelector.StainReportPreview:
                        ReportDocument stainRptPre;
                        rptStainReport rptStnPre = new rptStainReport();
                        stainRptPre = (ReportDocument)rptStnPre;
                        InitialiseLabels(stainRptPre);
                        stainRptPre.SetDataSource(drsClnt.GetInvestigationReportPreview(TransactionNo, RptSectionID, RptGroupID));
                        crystalReportViewer1.ReportSource = rptStnPre;
                        ShowReport(stainRptPre, this.isPrintDirect);
                        break;
                    #endregion

                }
                this.crystalReportViewer1.RefreshReport();
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }     
        
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

    }
}
