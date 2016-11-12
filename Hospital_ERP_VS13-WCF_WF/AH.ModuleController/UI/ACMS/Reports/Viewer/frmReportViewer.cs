using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using AH.ModuleController.ACMSSR;
using AH.ModuleController.UI.ACMS.Reports.ReportUI;

namespace AH.ModuleController.UI.ACMS.Reports.Viewer
{
    public partial class frmReportViewer : Form
    {
        #region Declaration
        private Boolean isPrintDirect = false;
        private String reportTitle = "";
        private String secondParameter = "";
        public ViewerSelector selector;
        public String ReportTitle { set { reportTitle = value; } get { return reportTitle; } }
        public String ReportSecondParameter { set { secondParameter = value; } get { return secondParameter; } }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public string ParamField { set; get; }
        public string ParamDateFrom { set; get; }
        public string ParamDateTo { set; get; }
        public string ParamField2 { set; get; }

        public string PatientNo { set; get; }
        public string MoneyReceiptNo { set; get; }
        public string TicketNo { set; get; }
        public string ReportFor { set; get; }
        public string GroupID { set; get; }
        public string DeptID { set; get; }
        public string MainID { set; get; }
        public string DetailsID { set; get; }
        public string WhereCondition { set; get; }
        //DMSSR.DMSWSClient dmsSRClient = new DMSSR.DMSWSClient();
        #endregion

        ACMSSR.ACMSWSClient clnt = new ACMSWSClient();

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
            switch (selector)
            {
                
                #region AccessControl                
                case ViewerSelector.ACMSAccessControl:
                    ReportDocument rptAccCont;
                    rptAccessControl rAccCont = new rptAccessControl();
                    rptAccCont = (ReportDocument)rAccCont;
                    InitialiseLabels(rptAccCont);
                    rptAccCont.SetDataSource(clnt.GetUserAccessReport(ParamField));
                    ACMSCRViewer.ReportSource = rptAccCont;
                    ShowReport(rptAccCont, this.isPrintDirect);
                    break;
                #endregion

                #region ACModuleReport
                case ViewerSelector.ACReportModuleID:
                    ReportDocument rptAccMCont;
                    rptAccessControlModule rAccMCont = new rptAccessControlModule();
                    rptAccMCont = (ReportDocument)rAccMCont;
                    InitialiseLabels(rptAccMCont);
                    rptAccMCont.SetDataSource(clnt.UACModuleReport(ParamField));
                    ACMSCRViewer.ReportSource = rptAccMCont;
                    ShowReport(rptAccMCont, this.isPrintDirect);
                    break;
                #endregion
                #region ACModuleReport
                case ViewerSelector.ACReportGroup:
                    ReportDocument rptAccGCont;
                    rptAccessControlGroup rAccGCont = new rptAccessControlGroup();
                    rptAccGCont = (ReportDocument)rAccGCont;
                    InitialiseLabels(rptAccGCont);
                    rptAccGCont.SetDataSource(clnt.UACGroupReport(ParamField));
                    ACMSCRViewer.ReportSource = rptAccGCont;
                    ShowReport(rptAccGCont, this.isPrintDirect);
                    break;
                #endregion
                
            }
            this.ACMSCRViewer.RefreshReport();
        }

        private void ACMSCRViewer_Load(object sender, EventArgs e)
        {
            this.ACMSCRViewer.RefreshReport();
            this.ACMSCRViewer.RefreshReport();
        }
    }
}
