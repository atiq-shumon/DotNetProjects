using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AH.DUtility;
using AH.ModuleController.OPDSR;
using CrystalDecisions.CrystalReports.Engine;
using AH.ModuleController.UI.NWMS.Reports.ReportUI;
using CrystalDecisions.Shared;

namespace AH.ModuleController.UI.NWMS.Reports.Viewer
{
    public partial class frmReportViewer : Form
    {
        NWMSSR.NWMSWSClient clnt = new NWMSSR.NWMSWSClient();
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
        public string ParamField { set; get; }
        public string ParamDateFrom { set; get; }
        public string ParamDateTo { set; get; }
        public string ParamField2 { set; get; }

        //public string PatientNo { set; get; }
        //public string MoneyReceiptNo { set; get; }
        //public string TicketNo { set; get; }
        //public string ReportFor { set; get; }
        //public string GroupID { set; get; }
        //public string DeptID { set; get; }
        //public string MainID { set; get; }
        //public string DetailsID { set; get; }
        public string WhereCondition { set; get; }


#endregion
       
        public frmReportViewer(Boolean isPrintDirect) : this()
        {
            this.isPrintDirect = isPrintDirect;
        }

        public string GetDateRange()
        {
            return StartDate.ToString("dd-MM-yyyy") + "    To    " + EndDate.ToString("dd-MM-yyyy");
        }
        private void InitialiseLabels(ReportDocument rpt)
        {
            //((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyName"]).Text = Utility.GetCompanyName;
            //((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyAddress"]).Text = Utility.GetCompanyAddress;
            //((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyEmail"]).Text = Utility.GetCompanyEmail;
            //((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyPhone"]).Text = Utility.GetCompanyPhone;
            //((TextObject)rpt.ReportDefinition.ReportObjects["txtIT"]).Text = Utility.GetITDvnMsg;
            //((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyWeb"]).Text = Utility.GetCompanyWeb;

            //if (ReportTitle != "")
            //{
            //    ((TextObject)rpt.ReportDefinition.ReportObjects["txtReportTitle"]).Text = this.ReportTitle;
            //}

            //if (ReportSecondParameter != "")
            //{
            //    ((TextObject)rpt.ReportDefinition.ReportObjects["txtSecondParameter"]).Text = this.secondParameter;
            //}

            //else
            //{
            //    rpt.ReportDefinition.ReportObjects["txtSecondParameter"].ObjectFormat.EnableSuppress = true;
            //}
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
                #region AdmtdPatDetails
                case ViewerSelector.DischargeSummary:
                    ReportDocument rptIPDPat;
                    rptIPDDischargeSummary oRptIPDPat = new rptIPDDischargeSummary();
                    rptIPDPat = (ReportDocument)oRptIPDPat;
                    InitialiseLabels(rptIPDPat);
                    rptIPDPat.SetDataSource(clnt.GetDischargeSummary(ParamField));
                    crystalReportViewer1.ReportSource = rptIPDPat;
                    ShowReport(rptIPDPat, this.isPrintDirect = false);
                    break;
                #endregion

                #region dischargeAdvice
                case ViewerSelector.DischargeAdvice:
                    ReportDocument rptPatDisAdv;
                    rptIPDDischargeAdvice oRptPatDisAdv = new rptIPDDischargeAdvice();
                    rptPatDisAdv = (ReportDocument)oRptPatDisAdv;
                    InitialiseLabels(rptPatDisAdv);
                    rptPatDisAdv.SetDataSource(clnt.DischargeAdvice(ParamField));
                    crystalReportViewer1.ReportSource = rptPatDisAdv;
                    ShowReport(rptPatDisAdv, this.isPrintDirect = false);
                    break;
                #endregion
            }
            this.crystalReportViewer1.RefreshReport();
        }
    }
}
