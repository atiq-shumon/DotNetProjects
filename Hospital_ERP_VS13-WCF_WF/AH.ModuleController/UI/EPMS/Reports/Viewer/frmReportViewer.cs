using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using AH.BLayer.DMS;
using AH.ModuleController.UI.EPMS.Reports.ReportUI;
using AH.DUtility;
using CrystalDecisions.CrystalReports.Engine;
using AH.ModuleController.DMSSR;


namespace AH.ModuleController.UI.EPMS.Reports.Viewer
{
    public partial class frmReportViewer : Form
    {
        #region Declaration
        public Boolean isPrintDirect = false;
        private String reportTitle = "";
        private String secondParameter = "";
        public ViewerSelector selector;
        public String ReportTitle { set { reportTitle = value; } get { return reportTitle; } }
        public String ReportSecondParameter { set { secondParameter = value; } get { return secondParameter; } }
        public DateTime StartDate { set; get; }
        public string Sdate { set; get; }
        public string Edate { set; get; }
        public DateTime EndDate { set; get; }
        public string PatientNo { set; get; }
        public string MoneyReceiptNo { set; get; }
        public string TicketNo { set; get; }
        public string ReportFor { set; get; }
        public string GroupID { set; get; }
        public string SectionID { set; get; }
        public string DeptID { set; get; }
        public string MainID { set; get; }
        public string DetailsID { set; get; }
        public string EmpId { set; get; }
        public string UserID { set; get; }
        public string TicketType { set; get; }
        public string HCN { set; get; }
        public string WhereCondition { set; get; }
        DMSSR.DMSWSClient dmsSRClient = new DMSSR.DMSWSClient();
        #endregion
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
        private void InitialiseLabels2(ReportDocument rpt)
        {

            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyName1"]).Text = Utility.GetCompanyName;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyAddress1"]).Text = Utility.GetCompanyAddress;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyEmail1"]).Text = Utility.GetCompanyEmail;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyPhone1"]).Text = Utility.GetCompanyPhone;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtIT"]).Text = Utility.GetITDvnMsg;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyWeb1"]).Text = Utility.GetCompanyWeb;
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

        public void ViewReport()
        {
            try
            {
                switch (selector)
                {                                      

                    #region EmergencyCollectionMoneyReceipt
                    case ViewerSelector.EmergencyMR:
                        ReportDocument rptEmrMR;
                        rptEmergencyCollectionMoneyReceipt rEmrCollMR = new rptEmergencyCollectionMoneyReceipt();
                        List<EmergencyCollectionRO> oEmers = dmsSRClient.GetEmergencyMoneyReceiptReport(MoneyReceiptNo).ToList();
                        if (oEmers.Count > 0)
                        {
                            rptEmrMR = (ReportDocument)rEmrCollMR;
                            InitialiseLabels(rptEmrMR);
                            //InitialiseLabels2(rptEmrMR);
                            rptEmrMR.SetDataSource(oEmers);
                            crystalReportViewer1.ReportSource = rptEmrMR;
                            ShowReport(rptEmrMR, this.isPrintDirect);
                        }
                        else
                            MessageBox.Show("This MR Has No Collection..", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    #endregion   
               
                    #region EmergencyPrescriptionMoneyReceipt
                    case ViewerSelector.EmergencyPrescription:
                        ReportDocument rptEmrPres;
                        rptEmergencyPrescriptionMoneyReceipt rEmrPresMR = new rptEmergencyPrescriptionMoneyReceipt();
                        List<EmergencyMasterRO> oEmerMrs = dmsSRClient.GetEmergencyPrescription(MoneyReceiptNo).ToList();
                        if (oEmerMrs.Count > 0)
                        {
                            rptEmrPres = (ReportDocument)rEmrPresMR;
                            InitialiseLabels(rptEmrPres);
                            rptEmrPres.SetDataSource(oEmerMrs);
                            crystalReportViewer1.ReportSource = rptEmrPres;
                            ShowReport(rptEmrPres, this.isPrintDirect);
                        }
                        else
                            MessageBox.Show("Invalid Prescription!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.RefreshReport();
            this.crystalReportViewer1.RefreshReport();
        }
    }
}
