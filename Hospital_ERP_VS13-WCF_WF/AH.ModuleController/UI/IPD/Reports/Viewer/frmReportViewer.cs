using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using AH.DUtility;
using AH.ModuleController.IPDSR;
using AH.ModuleController.UI.IPD.Reports.ReportUI;

namespace AH.ModuleController.UI.IPD.Reports.Viewer
{
    public partial class frmReportViewer : Form
    {
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        public frmReportViewer()
        {
            InitializeComponent();
        }
        #region Declaration
        private Boolean isPrintDirect = false;
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
        #endregion

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

        public void ViewReport()
        {
            try
            {
                switch (selector)
                {
                    #region AddmissionMoneyReceipt
                    case ViewerSelector.AddmissionMoneyReceipt:
                        ReportDocument rpt1;
                        rptAdmissionMoneyReceiptReport rDM = new rptAdmissionMoneyReceiptReport();
                        rpt1 = (ReportDocument)rDM;
                        InitialiseLabels(rpt1);                    
                        rpt1.SetDataSource(ipdSc.GetAdmissionMoneyReceipt(TransactionNo).ToList());                   
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect);
                      
                        break;
                    #endregion
                    #region AddmissionCard
                    case ViewerSelector.AdmissionCard:
                        ReportDocument rAdmCard;
                        rptAdmissionCard rAdm = new rptAdmissionCard();
                        rAdmCard = (ReportDocument)rAdm;
                        /// InitialiseLabels(rAdmCard);
                        rAdmCard.SetDataSource(ipdSc.GetAdmissionCard(TransactionNo).ToList());
                        crystalReportViewer1.ReportSource = rAdmCard;
                        ShowReport(rAdmCard, this.isPrintDirect);
                        break;
                    #endregion
                    #region DischargeBillSummary
                    case ViewerSelector.DischargeBillSummary:
                        ReportDocument rptDis1;
                        rptDischargeBillSummaryReport oDisBilSum = new rptDischargeBillSummaryReport();
                        rptDis1 = (ReportDocument)oDisBilSum;
                        InitialiseLabels(rptDis1);
                        rptDis1.SetDataSource(ipdSc.GetPatDischargeBillSummary(TransactionNo).ToList());
                        rptDis1.Subreports[0].SetDataSource(ipdSc.GetAdvPayment(TransactionNo));
                        //if (rptDis1.Rows.Count > 0)
                        //{
                            crystalReportViewer1.ReportSource = rptDis1;
                            ShowReport(rptDis1, this.isPrintDirect);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("No data found");
                        //}
                        break;
                    #endregion

                    #region DischargeBillDetails
                    case ViewerSelector.DischargeBillDetails:
                        ReportDocument rptDisDetails;
                        rptPatientDischargeBillDetails oDisBilDetails = new rptPatientDischargeBillDetails();
                        rptDisDetails = (ReportDocument)oDisBilDetails;
                        InitialiseLabels(rptDisDetails);
                        rptDisDetails.SetDataSource(ipdSc.GetPatDischargeBillDetails(TransactionNo).ToList());
                        crystalReportViewer1.ReportSource = rptDisDetails;
                        ShowReport(rptDisDetails, this.isPrintDirect);
                        break;
                    #endregion

                    #region AdmittedPatientReport
                    case ViewerSelector.AdmittedPatientReport:
                        ReportDocument Adrpt;
                        rptAdmittedPatList rptAdm = new rptAdmittedPatList();
                        Adrpt = (ReportDocument)rptAdm;
                        InitialiseLabels(Adrpt);
                        Adrpt.SetDataSource(ipdSc.GetAdmittedPatReportList(StartDate, EndDate).ToList());
                        crystalReportViewer1.ReportSource = Adrpt;
                        ShowReport(Adrpt, this.isPrintDirect);
                        break;
                    #endregion
                    #region BirthCertificate
                    case ViewerSelector.BirthCertificate:
                        ReportDocument rptBirth;
                        rptBirthCertificate rptBirthD = new rptBirthCertificate();
                        rptBirth = (ReportDocument)rptBirthD;
                        InitialiseLabels(rptBirthD);
                        rptBirth.SetDataSource(ipdSc.BirthCertificate(TransactionNo).ToList());
                        crystalReportViewer1.ReportSource = rptBirth;
                        ShowReport(rptBirth, this.isPrintDirect);
                        break;
                    #endregion
                    #region DeathCertificate
                    case ViewerSelector.DeathCertificate:
                        ReportDocument rptDeath;
                        rptDeathCertificate rptDeatils = new rptDeathCertificate();
                        rptDeath = (ReportDocument)rptDeatils;
                        InitialiseLabels(rptDeatils);
                        rptDeath.SetDataSource(ipdSc.DeathCertificate(TransactionNo).ToList());
                        crystalReportViewer1.ReportSource = rptDeath;
                        ShowReport(rptDeath, this.isPrintDirect);
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

    }
}
