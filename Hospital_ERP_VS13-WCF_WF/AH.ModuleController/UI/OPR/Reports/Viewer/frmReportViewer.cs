using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.UI.OPR.Reports.ReportUI;
using AH.DUtility;
using CrystalDecisions.CrystalReports.Engine;
using AH.ModuleController.OPRMSSR;



namespace AH.ModuleController.UI.OPR.Reports.Viewer
{
    public partial class frmReportViewer : Form
    {
        private Boolean isPrintDirect = false;
        private String reportTitle = "";
        private String secondParameter = "";
        public ViewerSelector selector;
        public String ReportTitle { set { reportTitle = value; } get { return reportTitle; } }
        public String ReportSecondParameter { set { secondParameter = value; } get { return secondParameter; } }
        public string  StartDate { set; get; }
        public string EndDate { set; get; }
        public string PatientNo { set; get; }
        public string WhereCondition { set; get; }
        public string strParam { set; get; }
        public string strParam1 { set; get; }
        public string strImage { set; get; }
        public int intStatus { set; get; }
        public string strSignature { set; get; }
        
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        public frmReportViewer()
        {
            InitializeComponent();
        }
        public frmReportViewer(Boolean isPrintDirect)
            : this()
        {
            this.isPrintDirect = isPrintDirect;
        }

        #region "Date Range"
        public string GetDateRange()
        {
            //return StartDate.ToString("dd-MM-yyyy") + "    To    " + EndDate.ToString("dd-MM-yyyy");
            return StartDate + "  to  " + EndDate;
        }
        #endregion 
        #region "Labels"
        private void InitialiseLabels(ReportDocument rpt)
        {
            rpt.SetParameterValue("test", "ff");
           
        }
        #endregion
        #region "Commnents"
        //private void ShowReport(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt, Boolean isDirectPrint, string strimage = "", string strSignature = "")
        //{
        //    if (isDirectPrint == true)
        //    {
        //        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
        //        rpt.PrintToPrinter(1, false, 0, 0);

        //    }
        //    else
        //    {
        //        this.Show();
        //        if (strimage != "")
        //        {
        //            if (strimage == null)
        //            {
        //                return;
        //            }
        //            else
        //            {
        //                rpt.SetParameterValue("x", strimage);
        //            }
        //        }
        //        if (strSignature != "")
        //        {
        //            if (strSignature == null)
        //            {
        //                return;
        //            }
        //            else
        //            {
        //                rpt.SetParameterValue("y", strSignature);
        //            }
        //        }
        //    }

        //}
        #endregion
        #region "Showreport"
        private void ShowReport(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt, Boolean isDirectPrint, string strReportTitle = "")
        {
            if (isDirectPrint == true)
            {
                rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                rpt.PrintToPrinter(1, false, 0, 0);
            }
            else
            {
                InitialiseParameterLabels(rpt, strReportTitle);
                this.Show();
            }

        }
        #endregion 
        #region "Paramegterlabels"
        private void InitialiseParameterLabels(ReportDocument rpt, string strReportTitle)
        {
            rpt.SetParameterValue("txtCompanyName", Utility.GetCompanyName);
            rpt.SetParameterValue("txtCompanyAddress", Utility.GetCompanyAddress);
            rpt.SetParameterValue("txtCompanyEmail", Utility.GetCompanyEmail);
            rpt.SetParameterValue("txtCompanyPhone", Utility.GetCompanyPhone);
            rpt.SetParameterValue("txtCompanyWeb", Utility.GetCompanyWeb);
            rpt.SetParameterValue("txtReportTitle", strReportTitle);
        }
        #endregion
        #region "Load"
        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            ReportDocument rpt1;
            try
            {
                List<OperationDetailsRO> obgDetails = accmSc.GetOprDetailsReport(intStatus, StartDate, EndDate).ToList();
                if (obgDetails.Count > 0)
                {

                    switch (selector)
                    {
                        case ViewerSelector.operationDetails:
                            rptOPRInformation rpt = new rptOPRInformation();
                            rpt1 = (ReportDocument)rpt;
                            //InitialiseLabels(rpt1 );
                            InitialiseParameterLabels(rpt1, "");
                            //rpt1.SetDataSource(accClnt.DisplayvoucherReport(" ", Convert.ToInt16(intVoucherType), WhereCondition).ToList());
                            rpt1.SetDataSource(accmSc.GetOprDetailsReport(intStatus, StartDate, EndDate).ToList());
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "Operation Information Report - " + GetDateRange());
                            break;
                    }
                }

                //this.crystalReportViewer1.Cursor = Cursors.Arrow;
                //crystalReportViewer1.MaximumSize.ToString();
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
        #endregion

    }
}
