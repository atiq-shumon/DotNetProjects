using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.UI.ATMS.Reports.ReportsUI;
using AH.DUtility;
using CrystalDecisions.CrystalReports.Engine;
using AH.ModuleController.ATMSSR;

namespace AH.ModuleController.UI.ATMS.Reports.Viewer
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
        public string MoneyReceiptNo { set; get; }
        public string TicketNo { set; get; }
        public string ReportFor { set; get; }
        public string TransactionNo { set; get; }
        public int intVoucherType { set; get; }
        public string WhereCondition { set; get; }
        public string LedgerName { set; get; }
        public string strFromDate { set; get; }
        public string strToDate { set; get; }
        public string strBranchID { set; get; }
        public string strControls { set; get; }
        public int Where1 { set; get; }
        //ACCMSWSClient accClnt = new ACCMSWSClient();
        ATMSSR.ATMSWSClient accClnt = new ATMSSR.ATMSWSClient();
        public frmReportViewer()
        {
            InitializeComponent();
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
        private void InitialiseParameterLabels(ReportDocument rpt, string strReportTitle)
        {
            rpt.SetParameterValue("txtCompanyName", Utility.GetCompanyName);
            rpt.SetParameterValue("txtCompanyAddress", Utility.GetCompanyAddress);
            rpt.SetParameterValue("txtCompanyEmail", Utility.GetCompanyEmail);
            rpt.SetParameterValue("txtCompanyPhone", Utility.GetCompanyPhone);
            rpt.SetParameterValue("txtCompanyWeb", Utility.GetCompanyWeb);
            rpt.SetParameterValue("txtReportTitle", strReportTitle);
        }
        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            ReportDocument rpt1;
            string strVoucher = "";
            try
            {
                switch (selector)
                {
                    case ViewerSelector.itemmrr:
                        rptVoucher rpt = new rptVoucher();
                        rpt1 = (ReportDocument)rpt;
                        //InitialiseLabels(rpt1 );
                        InitialiseParameterLabels(rpt1, "");
                        rpt1.SetDataSource(accClnt.DisplayvoucherReport(" ", Convert.ToInt16(intVoucherType), WhereCondition).ToList());
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "Material Receiving Report");
                        break;
                    case ViewerSelector.StoreInformation:
                        rptWarehouseInformation rptWarehouse = new rptWarehouseInformation();
                        rpt1 = (ReportDocument)rptWarehouse;
                        //InitialiseLabels(rpt1 );
                        InitialiseParameterLabels(rpt1, "");
                        rpt1.SetDataSource(accClnt.GetWarehouseStoreReport(strFromDate, strToDate, WhereCondition).ToList());
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "Store Information- " + strFromDate + " to " + strToDate);
                        break;

                    case ViewerSelector.voucher:
                        if (intVoucherType == 33)
                        {
                            strVoucher = "Material Issue";
                        }
                        else if (intVoucherType == 34)
                        {
                            strVoucher = "Material Damage";
                        }
                        else if (intVoucherType == 31)
                        {
                            strVoucher = "Material Return";
                        }
                        if (intVoucherType == 33)
                        {
                            rptVoucherDetails rptVouch = new rptVoucherDetails();
                            rpt1 = (ReportDocument)rptVouch;
                            //InitialiseLabels(rpt1 );
                            InitialiseParameterLabels(rpt1, "");
                            rpt1.SetDataSource(accClnt.DisplayvoucherIssueReport(" ", Convert.ToInt16(intVoucherType), WhereCondition).ToList());
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, strVoucher);
                            break;
                        }


                        else
                        {
                            rptVoucherDamage rptVouch = new rptVoucherDamage();
                            rpt1 = (ReportDocument)rptVouch;
                            //InitialiseLabels(rpt1 );
                            InitialiseParameterLabels(rpt1, "");
                            rpt1.SetDataSource(accClnt.DisplayvoucherReport(" ", Convert.ToInt16(intVoucherType), WhereCondition).ToList());
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, strVoucher);
                            break;
                        }

                }
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
