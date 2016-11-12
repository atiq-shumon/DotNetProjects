using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.UI.PatientRegistration.Reports.ReportUI;
using CrystalDecisions.CrystalReports.Engine;
using AH.ModuleController.PatientRegistrationSR;
using AH.DUtility;


namespace AH.ModuleController.UI.PatientRegistration.Reports.Viewer
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
        public string WhereCondition { set; get; }

        PatientRegistrationSR.PatientRegistrationWSClient clnt = new PatientRegistrationSR.PatientRegistrationWSClient();

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
                //case ViewerSelector.PatientRegistrationReport:
                //    rptRegisteredPatient rpt = new rptRegisteredPatient();
                //    rpt1 = (ReportDocument)rpt;
                //    InitialiseLabels(rpt1);
                //    rpt1.SetDataSource(clnt.ViewList());
                //    crystalReportViewer1.ReportSource = rpt1;
                //    ShowReport(rpt1, this.isPrintDirect);
                //    break;
                case ViewerSelector.PatientCard:
                    rptPatientCard ptCard = new rptPatientCard();
                    rpt1 = (ReportDocument)ptCard;
                   // InitialiseLabels(rpt1);
                    rpt1.SetDataSource(clnt.GetPatients(PatientNo));
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1, this.isPrintDirect);
                    break;
                #region PatientRegistrationDeatailsByHCN
                //Patient Registration Details
                case ViewerSelector.PetRegDetailsbyHCN:
                    ReportDocument rptPetReg;
                    rptPatRegHCN rPetReg = new rptPatRegHCN();
                    rptPetReg = (ReportDocument)rPetReg;
                    InitialiseLabels(rptPetReg);
                    rPetReg.SetDataSource(clnt.GetPatientRegistartionDetailsbyHCN(WhereCondition));
                    crystalReportViewer1.ReportSource = rptPetReg;
                    ShowReport(rptPetReg, this.isPrintDirect);
                    break;
                #endregion
                #region PatientRegistrationDeatailsByDateRange
                //Patient Registration Details
                case ViewerSelector.PetRegDetailsbyDateRange:
                    ReportDocument rptPetRegDR;
                    rptPatientRegistrationDetails rPetRegDR = new rptPatientRegistrationDetails();
                    rptPetRegDR = (ReportDocument)rPetRegDR;
                    InitialiseLabels(rptPetRegDR);
                    rPetRegDR.SetDataSource(clnt.GetPatientRegistartionDetailsbyDateRange(WhereCondition));
                    crystalReportViewer1.ReportSource = rptPetRegDR;
                    ShowReport(rptPetRegDR, this.isPrintDirect);
                    break;
                #endregion
            }
            this.crystalReportViewer1.RefreshReport();
            this.crystalReportViewer1.Cursor = Cursors.Arrow;
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
