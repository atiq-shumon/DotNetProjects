using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using AH.BLayer.DMS;
using AH.ModuleController.UI.DMS.Reports.ReportUI;
using AH.DUtility;
using CrystalDecisions.CrystalReports.Engine;
using AH.ModuleController.DMSSR;
using AH.ModuleController.UI.EPMS.Reports.ReportUI;


namespace AH.ModuleController.UI.DMS.Reports.Viewer
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
                    #region TestDetailsWithFee
                    case ViewerSelector.DMSTestDetails:
                        ReportDocument rpt1;
                        rptTestDetailsTest rDM = new rptTestDetailsTest();
                        List<TestSetupRO> oTLists = dmsSRClient.GetDetailsTest(DeptID).ToList();
                        if (oTLists.Count > 0)
                        {
                            rpt1 = (ReportDocument)rDM;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(oTLists);
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect);
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    #endregion

                    #region GetTestDetails
                    case ViewerSelector.TestDetails:
                        ReportDocument rptTest;
                        rptAllTestDetails rptAllTest = new rptAllTestDetails();
                        List<TestSetupRO> oAllTest = dmsSRClient.GetTestDetailsReport(DeptID, GroupID, MainID).ToList();
                        if (oAllTest.Count > 0)
                        {
                            rptTest = (ReportDocument)rptAllTest;
                            InitialiseLabels(rptTest);
                            rptTest.SetDataSource(oAllTest);
                            crystalReportViewer1.ReportSource = rptTest;
                            ShowReport(rptTest, this.isPrintDirect);
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    #endregion

                    #region GetResultHeadUnderTest
                    case ViewerSelector.ResultHeadUnderTest:
                        ReportDocument rptResultHd;
                        rptResultHeadUnderTest rptrptResultHeadTest = new rptResultHeadUnderTest();
                        List<ResultHeadRO> orptrptResultHeadTest = dmsSRClient.GetReportResultHd(DetailsID).ToList();
                        if (orptrptResultHeadTest.Count > 0)
                        {
                            rptResultHd = (ReportDocument)rptrptResultHeadTest;
                            InitialiseLabels(rptResultHd);
                            rptResultHd.SetDataSource(orptrptResultHeadTest);
                            crystalReportViewer1.ReportSource = rptResultHd;
                            ShowReport(rptResultHd, this.isPrintDirect);
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    #endregion

                    #region GetTestDetails
                    case ViewerSelector.AllPanelTest:
                        ReportDocument rptPanel;
                        rptAllPanelTest rptPanleTest = new rptAllPanelTest();
                        List<TestSetupRO> oAllPanelTest = dmsSRClient.GetAllPanelTest().ToList();
                        if (oAllPanelTest.Count > 0)
                        {
                            rptPanel = (ReportDocument)rptPanleTest;
                            InitialiseLabels(rptPanel);
                            rptPanel.SetDataSource(oAllPanelTest);
                            crystalReportViewer1.ReportSource = rptPanel;
                            ShowReport(rptPanel, this.isPrintDirect);
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    #endregion

                    #region ResultHeadWithReffValue
                    case ViewerSelector.ResultHead:
                        ReportDocument rptResHead;
                        rptResultHead rptHead = new rptResultHead();
                        List<ResultHeadRO> oResultHeads = dmsSRClient.GetResultHdFReport(SectionID, GroupID).ToList();
                        if (oResultHeads.Count > 0)
                        {
                            rptResHead = (ReportDocument)rptHead;
                            InitialiseLabels(rptResHead);
                            rptResHead.SetDataSource(oResultHeads);
                            crystalReportViewer1.ReportSource = rptResHead;
                            ShowReport(rptResHead, this.isPrintDirect);
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    #endregion

                    #region ResultHead
                    case ViewerSelector.ResHead:
                        ReportDocument rptResultHead;
                        rptResHead rptHd = new rptResHead();
                        List<ResultHeadRO> oResHeads = dmsSRClient.GetResultHeadReport(SectionID, GroupID).ToList();
                        if (oResHeads.Count > 0)
                        {
                            rptResultHead = (ReportDocument)rptHd;
                            InitialiseLabels(rptHd);
                            rptHd.SetDataSource(oResHeads);
                            crystalReportViewer1.ReportSource = rptHd;
                            ShowReport(rptHd, this.isPrintDirect);
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    #endregion

                    #region MoneyReceipt
                    case ViewerSelector.DMSMoneyReceipt:
                        ReportDocument rptMR;
                        rptDMSMoneyReceipt rDMSMR = new rptDMSMoneyReceipt();
                        List<MoneyReceiptRO> oLists = dmsSRClient.GetMoneyReceiptReport(MoneyReceiptNo).ToList();
                        if (oLists.Count > 0)
                        {
                            rptMR = (ReportDocument)rDMSMR;
                            InitialiseLabels(rptMR);
                            InitialiseLabels2(rptMR);
                            rptMR.SetDataSource(oLists);
                            crystalReportViewer1.ReportSource = rptMR;
                            ShowReport(rptMR, this.isPrintDirect);
                        }
                        else
                            MessageBox.Show("This MR Has No Tests..", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    #endregion

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

                    #region RefundMoneyReceipt
                    case ViewerSelector.RefundMoneyReceipt:
                        ReportDocument rptRefundMR;
                        rptRefundMoneyReceipt rptRefMR = new rptRefundMoneyReceipt();
                        List<MoneyReceiptRO> oRefundMR = dmsSRClient.GetRefundMoneyReceiptReport(MoneyReceiptNo).ToList();
                        if (oRefundMR.Count > 0)
                        {
                            rptRefundMR = (ReportDocument)rptRefMR;
                            InitialiseLabels(rptRefundMR);
                            InitialiseLabels2(rptRefundMR);
                            rptRefundMR.SetDataSource(oRefundMR);
                            crystalReportViewer1.ReportSource = rptRefundMR;
                            ShowReport(rptRefundMR, this.isPrintDirect);
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    #endregion

                    #region DueMoneyReceipt
                    case ViewerSelector.DueMoneyReceipt:
                        ReportDocument rptDR;
                        rptDMSDuePaymentMoneyReceipt rptMDR = new rptDMSDuePaymentMoneyReceipt();

                        List<MoneyReceiptRO> oMR = dmsSRClient.GetDuePayment(MoneyReceiptNo).ToList();
                        if (oMR.Count > 0)
                        {
                            rptDR = (ReportDocument)rptMDR;
                            InitialiseLabels(rptMDR);
                            InitialiseLabels2(rptMDR);
                            rptDR.SetDataSource(oMR);
                            crystalReportViewer1.ReportSource = rptDR;
                            ShowReport(rptDR, this.isPrintDirect);
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    #endregion

                    #region DueList
                    case ViewerSelector.DueList:
                        ReportDocument rptD;
                        rptDueList rptDue = new rptDueList();
                        rptD = (ReportDocument)rptDue;
                        InitialiseLabels(rptD);
                        rptD.SetDataSource(dmsSRClient.GetPatientDueList(Sdate, Edate));
                        crystalReportViewer1.ReportSource = rptD;
                        ShowReport(rptD, this.isPrintDirect);

                        break;
                    #endregion

                    #region GetAllCollectionSummary
                    case ViewerSelector.AllCollectionSummary:
                        ReportDocument rptAllCollSummary;
                        rptAllCollectionSummary rptAllColl = new rptAllCollectionSummary();
                        rptAllCollSummary = (ReportDocument)rptAllColl;
                        InitialiseLabels(rptAllCollSummary);
                        rptAllCollSummary.SetDataSource(dmsSRClient.GetAllCollectionSummary(Sdate, Edate));
                        crystalReportViewer1.ReportSource = rptAllCollSummary;
                        ShowReport(rptAllCollSummary, this.isPrintDirect);
                        break;
                    #endregion

                    #region GetTotalCollection
                    case ViewerSelector.TotalCollection:
                        ReportDocument rptTotal;
                        rptTotalCollection rptTotalColl = new rptTotalCollection();
                        rptTotal = (ReportDocument)rptTotalColl;
                        InitialiseLabels(rptTotal);
                        rptTotal.SetDataSource(dmsSRClient.GetTotalCollection(Sdate, Edate));
                        crystalReportViewer1.ReportSource = rptTotal;
                        ShowReport(rptTotal, this.isPrintDirect);
                        break;
                    #endregion

                    #region GetUserWiseCollection
                    case ViewerSelector.UserWiseCollection:
                        ReportDocument rptuserColl;
                        rptUserWiseCollection rptuserWiseColl = new rptUserWiseCollection();
                        rptuserColl = (ReportDocument)rptuserWiseColl;
                        InitialiseLabels(rptuserColl);
                        rptuserColl.SetDataSource(dmsSRClient.GetUserWiseCollection(EmpId, Sdate, Edate));
                        crystalReportViewer1.ReportSource = rptuserColl;
                        ShowReport(rptuserColl, this.isPrintDirect);

                        break;
                    #endregion

                    #region GetUserWiseCashCollection
                    case ViewerSelector.UserWiseCashCollection:
                        ReportDocument rptUserWiseCash;
                        rptUserWiseCashCollection rptUserWiseCashColl = new rptUserWiseCashCollection();
                        rptUserWiseCash = (ReportDocument)rptUserWiseCashColl;
                        InitialiseLabels(rptUserWiseCash);
                        rptUserWiseCash.SetDataSource(dmsSRClient.GetUserWiseCashCollection(Sdate, Edate));
                        crystalReportViewer1.ReportSource = rptUserWiseCash;
                        ShowReport(rptUserWiseCash, this.isPrintDirect);
                        break;
                    #endregion

                    #region GetIntegretedVoucherReport
                    case ViewerSelector.IntegretedVoucherReport:
                        ReportDocument rptVoucher;
                        rptIntegretedVoucherReport rptVouReport = new rptIntegretedVoucherReport();
                        rptVoucher = (ReportDocument)rptVouReport;
                        InitialiseLabels(rptVouReport);
                        rptVouReport.SetDataSource(dmsSRClient.GetIntegretedVoucher(UserID, Sdate, Edate));
                        crystalReportViewer1.ReportSource = rptVouReport;
                        ShowReport(rptVouReport, this.isPrintDirect);

                        break;
                    #endregion

                    #region PatientRegistration
                    //Patient Registration Details
                    //case ViewerSelector.PetRegDetails:
                    //    ReportDocument rptPetReg;
                    //    rptPatientRegistrationDetails rPetReg = new rptPatientRegistrationDetails();
                    //    rptPetReg = (ReportDocument)rPetReg;

                    //    rPetReg.SetDataSource(new PetRegReportBLL().GetPatientRegistartionDetails(WhereCondition));
                    //    reportViewer1.ReportSource = rptPetReg;
                    //    ShowReport(rptPetReg, this.isPrintDirect);
                    //    break;
                    #endregion

                    #region TestUnderPanel

                    case ViewerSelector.TestUnderPanel:
                        ReportDocument rptTestUnderPanel;
                        rptTestUnderPanel oTestPanel = new rptTestUnderPanel();
                        List<TestSetupRO> oTestPanels = dmsSRClient.GetReportPanelTest().ToList();
                        if (oTestPanels.Count > 0)
                        {
                            rptTestUnderPanel = (ReportDocument)oTestPanel;
                            InitialiseLabels(oTestPanel);
                            oTestPanel.SetDataSource(oTestPanels);
                            crystalReportViewer1.ReportSource = oTestPanel;
                            ShowReport(oTestPanel, this.isPrintDirect);
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    #endregion'

                    #region GetAllRefundMoneyReport
                    case ViewerSelector.RefundMoneyReceiptReport:
                        ReportDocument rptRefund;
                        rptAllRefundCollection rptRefundMRReport = new rptAllRefundCollection();
                        rptRefund = (ReportDocument)rptRefundMRReport;
                        InitialiseLabels(rptRefundMRReport);
                        rptRefundMRReport.SetDataSource(dmsSRClient.GetAllRefundMR(UserID, Sdate, Edate));
                        crystalReportViewer1.ReportSource = rptRefundMRReport;
                        ShowReport(rptRefundMRReport, this.isPrintDirect);

                        break;
                    #endregion

                    #region GetAllCancelMoneyReport
                    case ViewerSelector.TestCancelReport:
                        ReportDocument rptCancel;
                        rptAllCancelReport rptCancelMRReport = new rptAllCancelReport();
                        rptCancel = (ReportDocument)rptCancelMRReport;
                        InitialiseLabels(rptCancelMRReport);
                        rptCancelMRReport.SetDataSource(dmsSRClient.GetAllCancelMR(UserID, Sdate, Edate));
                        crystalReportViewer1.ReportSource = rptCancelMRReport;
                        ShowReport(rptCancelMRReport, this.isPrintDirect);

                        break;
                    #endregion

                    #region GetDoctorWiseDiagnosticCollectionDetails

                    case ViewerSelector.DoctorWiseDiagnosticCollectionDetails:
                        ReportDocument rptDoctorWiseColl;
                        rptDoctorWiseDiagnosticCollectionDetails rptDoctorWiseCollection = new rptDoctorWiseDiagnosticCollectionDetails();
                        rptDoctorWiseColl = (ReportDocument)rptDoctorWiseCollection;
                        InitialiseLabels(rptDoctorWiseCollection);
                        rptDoctorWiseCollection.SetDataSource(dmsSRClient.GetDoctorWiseCollection(TicketType, Sdate, Edate));
                        crystalReportViewer1.ReportSource = rptDoctorWiseCollection;
                        ShowReport(rptDoctorWiseCollection, this.isPrintDirect);

                        break;
                    #endregion

                    #region GetDoctorWiseDiagnosticCollectionSummary

                    case ViewerSelector.DoctorWiseDiagnosticCollectionSummary:
                        ReportDocument rptDoctorWiseCollSum;
                        rptDoctorWiseDiagnosticCollectionSummary rptDoctorWiseCollectionSum = new rptDoctorWiseDiagnosticCollectionSummary();
                        rptDoctorWiseCollSum = (ReportDocument)rptDoctorWiseCollectionSum;
                        InitialiseLabels(rptDoctorWiseCollectionSum);
                        rptDoctorWiseCollectionSum.SetDataSource(dmsSRClient.GetDoctorWiseCollection(TicketType, Sdate, Edate));
                        crystalReportViewer1.ReportSource = rptDoctorWiseCollectionSum;
                        ShowReport(rptDoctorWiseCollectionSum, this.isPrintDirect);

                        break;
                    #endregion

                    #region GetAllTestByHCN
                    case ViewerSelector.AllTestByHCN:
                        ReportDocument rptHCN;
                        rptAllTestByHCN rptHCNTest = new rptAllTestByHCN();
                        rptHCN = (ReportDocument)rptHCNTest;
                        InitialiseLabels(rptHCNTest);
                        rptHCNTest.SetDataSource(dmsSRClient.GetAllTestByHCN(HCN, Sdate, Edate));
                        crystalReportViewer1.ReportSource = rptHCNTest;
                        ShowReport(rptHCNTest, this.isPrintDirect);
                        break;
                    #endregion

                    #region GetAllTestofPatient
                    case ViewerSelector.AllTestOfPatient:
                        ReportDocument rptPatient;
                        rptAllTestofPatient rptPatientTest = new rptAllTestofPatient();
                        rptPatient = (ReportDocument)rptPatientTest;
                        InitialiseLabels(rptPatientTest);
                        rptPatientTest.SetDataSource(dmsSRClient.GetAllTestByHCN(HCN, Sdate, Edate));
                        crystalReportViewer1.ReportSource = rptPatientTest;
                        ShowReport(rptPatientTest, this.isPrintDirect);
                        break;
                    #endregion


                    #region TestMainWiseCollectionDetails
                    case ViewerSelector.TestMainWiseTestDetails:
                        ReportDocument rptTestMain;
                        rptTestMainWiseCollectionDetails rptTestMainWiseColl = new rptTestMainWiseCollectionDetails();
                        rptTestMain = (ReportDocument)rptTestMainWiseColl;
                        InitialiseLabels(rptTestMainWiseColl);
                        rptTestMainWiseColl.SetDataSource(dmsSRClient.GetTestMainWiseTestDetails(Sdate, Edate));
                        crystalReportViewer1.ReportSource = rptTestMainWiseColl;
                        ShowReport(rptTestMainWiseColl, this.isPrintDirect);
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

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.RefreshReport();
            this.crystalReportViewer1.RefreshReport();
        }
    }
}
