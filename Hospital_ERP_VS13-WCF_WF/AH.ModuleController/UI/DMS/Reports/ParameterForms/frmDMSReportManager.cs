using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.UI.DMS.Reports.Viewer;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using AH.DUtility;

namespace AH.ModuleController.UI.DMS.Reports.ParameterForms
{
    public partial class frmDMSReportManager : AH.Shared.UI.frmSmartFormReportStandard
    {
        DMSSR.DMSWSClient dmsSRClient = new DMSSR.DMSWSClient();
        public frmDMSReportManager()
        {
            InitializeComponent();
        }
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
        # region TestDeatilsWithFee
        public void TestDetails()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.DMSTestDetails; 
            ofrmReportViewer.DeptID = cboParam2.SelectedValue.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region AllTestDeatils
        public void AllTestDetails()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.TestDetails;
            ofrmReportViewer.DeptID = cboDepartment.SelectedValue.ToString();
            ofrmReportViewer.GroupID = cboGroup.SelectedValue.ToString();
            ofrmReportViewer.MainID = cboTestMain.SelectedValue.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region ResultHeadUnderTest
        public void ResultHeadUnderTest()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.ResultHeadUnderTest;
            ofrmReportViewer.DeptID = cboDepartment.SelectedValue.ToString();
            ofrmReportViewer.GroupID = cboGroup.SelectedValue.ToString();
            ofrmReportViewer.MainID = cboTestMain.SelectedValue.ToString();
            ofrmReportViewer.DetailsID = cboTestDet.SelectedValue.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region AllPanelTest
        public void AllPanelTest()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.AllPanelTest;
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region AllResultHeadWithReffValue
        public void ResultHead()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.ResultHead;
            ofrmReportViewer.SectionID = cboRptSec.SelectedValue.ToString();
            ofrmReportViewer.GroupID = cboRptGrp.SelectedValue.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion

        #region ResultHead
        public void ResHead()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.ResHead;
            ofrmReportViewer.SectionID = cboRptSec.SelectedValue.ToString();
            ofrmReportViewer.GroupID = cboRptGrp.SelectedValue.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region MoneyReceiptReprint
        public void MoneyReceipt()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.DMSMoneyReceipt;
            ofrmReportViewer.MoneyReceiptNo = txtParam1.Text;
            ofrmReportViewer.ViewReport();
        }
        #endregion


        # region EmergencyCollecionMRReprint
        public void EmergencyCollecion()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.EmergencyMR;
            ofrmReportViewer.MoneyReceiptNo = txtParam1.Text;
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region RefundMoneyReceipyReprint
        public void RefundMoneyReceipyReprint()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.RefundMoneyReceipt;
            ofrmReportViewer.MoneyReceiptNo = txtParam1.Text;
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region DuePaymentMoneyReceipt
        public void DueMoneyReceipt()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.DueMoneyReceipt;
            ofrmReportViewer.MoneyReceiptNo = txtParam1.Text;
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region AllDueList
        public void DueList()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.DueList;           
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region TotalCollection
        public void TotalCollection()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.TotalCollection;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region AllCollectionSummary
        public void AllCollectionSummary()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.AllCollectionSummary;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region UserWiseCollection
        public void UserWiseCollection()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.UserWiseCollection;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.EmpId = Utility.UserId;
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region UserWiseCashCollection
        public void UserWiseCashCollection()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.UserWiseCashCollection;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region IntegretedVoucherReport
        public void IntegretedVoucherReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.IntegretedVoucherReport;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.UserID = txtUserID.Text.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion

        #region AllRefundMoneyReceipt
        public void AllRefundMoneyReceipt()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.RefundMoneyReceiptReport;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.UserID = txtUserID.Text.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion

        #region AllCancelMoneyReceipt
        public void AllCancelMoneyReceipt()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.TestCancelReport;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.UserID = txtUserID.Text.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion

        #region TestUnderPanel
        public void TestUnderPanel()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.TestUnderPanel;           
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region DoctorWiseCollectionDetails
        public void DoctorWiseCollectionDetails()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.DoctorWiseDiagnosticCollectionDetails;
            ofrmReportViewer.TicketType = cboTicketType.SelectedValue.ToString();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region DoctorWiseCollectionSummary
        public void DoctorWiseCollectionSummary()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.DoctorWiseDiagnosticCollectionSummary;
            ofrmReportViewer.TicketType = cboTicketType.SelectedValue.ToString();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion

        #region AllTestByHCN
        public void AllTestByHCN()
        {       
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.AllTestByHCN;
            if (dtStartDate.Text != "  /  /")
            {
                ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
                ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
                ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();                
                ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
                ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            }
            ofrmReportViewer.HCN = txtHCNNo.Text.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion

        #region AllTestOfPatient
        public void AllTestOfPatient()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.AllTestOfPatient;          
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.HCN = "";
            ofrmReportViewer.ViewReport();
        }
        #endregion

        #region TestMainWiseCollectionDetails
        public void TestMainWiseCollectionDetails()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.TestMainWiseTestDetails;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Department Wise Test Details With Fee
            if (rdoTestDet.Checked == true)
            {              
              TestDetails();           
            }
            //Test Under Panel
            if (rdoPanelTest.Checked == true)
            {
                TestUnderPanel();
            }

            //All Test Details
            if (rdoAllTestDet.Checked == true)
            {
                if (cboDepartment.SelectedValue != "")
                {
                    if (cboGroup.SelectedValue != null)
                    {
                        if (cboTestMain.SelectedValue != null)
                        {
                            AllTestDetails();
                        }
                    }
                }
            }

            //Result Head Under Test
            if (rdoResultHeadUnderTest.Checked == true)
            {
                if (cboDepartment.SelectedValue != "")
                {
                    if (cboGroup.SelectedValue != null)
                    {
                        if (cboTestMain.SelectedValue != null)
                        {
                            if (cboTestDet.SelectedValue != null)
                            {
                                ResultHeadUnderTest();
                            }
                        }
                    }
                }
            }

            //All Panel Test
            if (rdoAllPanelTest.Checked == true)
            {
                AllPanelTest();
            }

            //All Result Head With Refference Value
            if (rdoResHead.Checked == true)
            {
                if (cboRptSec.SelectedValue != "")
                {
                    if (cboRptGrp.SelectedValue != "")
                    {
                        ResHead();
                    }
                }
            }

            //All Result Head
            if (rdoResultHead.Checked == true)
            {
                if (cboRptSec.SelectedValue != "")
                {
                    if (cboRptGrp.SelectedValue != "")
                    {
                        ResultHead();
                    }
                }
            }
            //Money Receipt
            if (rdoMoneyReceipt.Checked == true)
            {
                MoneyReceipt();
            }
            //Emergency Collection
            if (rdoEmrColl.Checked == true)
            {
                EmergencyCollecion();
            }
            //Due Payment
            if (rdoDuePayment.Checked == true)
            {
                DueMoneyReceipt();
            }
            //Refund Money Receipt
            if (rdoRefundMR.Checked == true)
            {
                RefundMoneyReceipyReprint();
            }
            //Due List
            if (rdoDueList.Checked == true)
            {
                cboDateType.Focus();
                if (cboDateType.Text != "")
                {
                    DueList();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }
            //All Collection Summary
            if (rdoAllCollSummary.Checked == true)
            {
                cboDateType.Focus();
                if (cboDateType.Text != "")
                {
                    AllCollectionSummary();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }

            //Diagnostic Collection
            if (rdoTotalColl.Checked == true)
            {
                cboDateType.Focus();
                if (cboDateType.Text != "")
                {
                    TotalCollection();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }
            //User Wise Collection
            if (rdoUserWiseCollection.Checked == true)
            {
                
                if (cboDateType.Text != "")
                {
                    UserWiseCollection();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }
            //User Wise Cash Collection
            if (rdoUserWiseCash.Checked == true)
            {
                cboDateType.Focus();
                if (cboDateType.Text != "")
                {
                    UserWiseCashCollection();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }
            //Integreted Voucher Report
            if (rdoVoucher.Checked == true)
            {
                if (cboDateType.Text != "")
                {
                    IntegretedVoucherReport();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }

            //All Refund Money Receipt
            if (rdoRefundMRReport.Checked == true)
            {
                if (cboDateType.Text != "")
                {
                    AllRefundMoneyReceipt();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }

            //All Test Cancel Money Receipt
            if (rdoTestCancelMRReport.Checked == true)
            {
                if (cboDateType.Text != "")
                {
                    AllCancelMoneyReceipt();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }
            //Doctor Wise Collection Details
            if (rdoDoctorWiseCollDet.Checked == true)
            {
                if (cboTicketType.SelectedValue != "")
                {
                    if (cboDateType.Text != "")
                    {
                        DoctorWiseCollectionDetails();
                    }
                    else
                        MessageBox.Show("You must Have to Give Date Range");
                }
                else
                    MessageBox.Show("Please Select a Ticket Type to See Total Collection");
                   cboTicketType.Focus();
            }
            //Doctor Wise Collection Summary
            if (rdoDoctorWiseCollSum.Checked == true)
            {
                if (cboTicketType.SelectedValue != "")
                {
                    if (cboDateType.Text != "")
                    {
                        DoctorWiseCollectionSummary();
                    }
                    else
                        MessageBox.Show("You must Have to Give Date Range");
                }
                else
                    MessageBox.Show("Please Select a Ticket Type to See Total Collection");
                cboTicketType.Focus();
            }
            //All Test by HCN
            if (rdoAllTestByHCN.Checked == true)
            {
                if (txtHCNNo.Text != "")
                {
                    AllTestByHCN();
                }
                    else
                        MessageBox.Show("Please Provide HCN");             
            }
            //All Test of Patient
            if (rdoAllTestOfPatient.Checked == true)
            {
                if (cboDateType.Text != "")
                {
                    AllTestOfPatient();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }

            //Test Main Wise Collection Details
            if (rdoTestMainWiseDet.Checked == true)
            {
                if (cboDateType.Text != "")
                {
                    TestMainWiseCollectionDetails();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }

        }    
       
        private void gbReportOption_Enter(object sender, EventArgs e)
        {

        }     
        private void frmDMSReportManager_Load(object sender, EventArgs e)
        {
            rdoAllTestDet.Checked = true;
            cboRptSec.DisplayMember = "Value";
            cboRptSec.ValueMember = "Key";
            cboRptSec.DataSource = new BindingSource(dmsSRClient.GetRptSecDic("D"), null);

            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(dmsSRClient.GetDepartments("D"), null);

            cboParam2.DisplayMember = "Value";
            cboParam2.ValueMember = "Key";
            cboParam2.DataSource = new BindingSource(dmsSRClient.GetDepartments("D"), null);

            cboTicketType.DisplayMember = "Value";
            cboTicketType.ValueMember = "Key";
            cboTicketType.DataSource = new BindingSource(dmsSRClient.GetPrescriptionTypes(), null);
        }      
        public bool CheckDateOPtions()
        {
            if (cboDateType.Text != "")
            {
                if (cboDateType.Text != "None" && cboDateType.Text != "")
                {
                    DateTime startdate = Convert.ToDateTime(dtStartDate.Text);
                    DateTime enddate = Convert.ToDateTime(dtEndDate.Text);
                    if (startdate > enddate)
                    {
                        return false;
                    }
                }

            }
            return true;
        }

      
      
        private void rdoResultHead_CheckedChanged(object sender, EventArgs e)
        {
            pnlResultHead.Visible = true;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = true;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = false;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }

        private void cboRptSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRptSec.SelectedValue != "")
            {
                cboRptGrp.DisplayMember = "Value";
                cboRptGrp.ValueMember = "Key";
                cboRptGrp.DataSource = new BindingSource(dmsSRClient.GetRptgrpDic(cboRptSec.SelectedValue.ToString()), null);
            }
        }

        private void rdoAllTestDet_CheckedChanged(object sender, EventArgs e)
        {
            pnlResultHead.Visible = false;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlTestDeatils.Visible = true;
            gbDateRange.Visible = false;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboGroup.DisplayMember = "Value";
                cboGroup.ValueMember = "Key";
                cboGroup.DataSource = new BindingSource(Utility.VerifyDic(dmsSRClient.GetDiagnGrpDeptWise("D", cboDepartment.SelectedValue.ToString())), null);
                if (cboGroup.SelectedValue != null)
                {
                    cboTestMain.DisplayMember = "Value";
                    cboTestMain.ValueMember = "Key";
                    cboTestMain.DataSource = new BindingSource(Utility.VerifyDic(dmsSRClient.GetMainDeptwise("D", cboDepartment.SelectedValue.ToString(), cboGroup.SelectedValue.ToString())), null);
                }
            }
        }        
        private void rdoPanelTest_CheckedChanged(object sender, EventArgs e)
        {
            pnlResultHead.Visible = false;
            pnlTestDeatils.Visible = false;
            txtParam1.Visible = false;
            lblParam1.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }

        private void rdoResHead_CheckedChanged(object sender, EventArgs e)
        {
            pnlResultHead.Visible = true;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = true;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = false;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }

        private void tabDiagnosticReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabDiagnosticReport.SelectedTab == tabDiagnosticReport.TabPages["tabSetup"])
            {
                rdoTotalColl.Checked = false;
                rdoUserWiseCollection.Checked = false;
                rdoDueList.Checked = false;
                rdoVoucher.Checked = false;
                rdoMoneyReceipt.Checked = false;
                rdoDuePayment.Checked = false;
                rdoRefundMR.Checked = false;
                rdoRefundMRReport.Checked = false;
                rdoTestCancelMRReport.Checked = false;
                lblTicketType.Visible = false;
                cboTicketType.Visible = false;
                pnlTestDet.Visible = false;
                txtHCNNo.Visible = false;
                lblHCN.Visible = false;
            }
            if (tabDiagnosticReport.SelectedTab == tabDiagnosticReport.TabPages["tabCollection"])
            {
                rdoAllTestDet.Checked = false;
                rdoTestDet.Checked = false;
                rdoResultHead.Checked = false;
                rdoResHead.Checked = false;
                rdoPanelTest.Checked = false;
                lblTicketType.Visible = false;
                cboTicketType.Visible = false;
                pnlTestDet.Visible = false;
                txtHCNNo.Visible = false;
                lblHCN.Visible = false;
            }
        }

        private void rdoTotalColl_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlResultHead.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = true;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;

        }

        private void rdoUserWiseCollection_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = true;
            lblEmpID.Visible = true;
            pnlResultHead.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = true;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
            //txtEmpID.Focus();
        }

        private void rdoDueList_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlResultHead.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = true;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
            txtParam1.Focus();
        }

        private void rdoVoucher_CheckedChanged(object sender, EventArgs e)
        {
            pnlResultHead.Visible = false;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = true;
            rdoAll.Visible = true;
            rdoUserWise.Visible = true;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }
        private void rdoMoneyReceipt_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Money Receipt";
            lblParam2.Visible = false;
            lblParam1.Visible = true;
            lblParam3.Visible = false;
            txtParam1.Visible = true;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlResultHead.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = false;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }

        private void rdoDuePayment_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Money Receipt";
            lblParam2.Visible = false;
            lblParam1.Visible = true;
            lblParam3.Visible = false;
            txtParam1.Visible = true;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlResultHead.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = false;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
            
        }

        private void rdoRefundMR_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Money Receipt";
            lblParam2.Visible = false;
            lblParam1.Visible = true;
            lblParam3.Visible = false;
            txtParam1.Visible = true;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlResultHead.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = false;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }

        private void cboDateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region DateLogic
            DateTime _dateTo = DateTime.Parse(DateTime.Now.ToString());
            string sTo = _dateTo.ToString("dd-MM-yyyy");
            dtEndDate.Text = sTo;

            if (cboDateType.Text == "No Date")
            {                
                dtStartDate.Text = "";
                dtEndDate.Text = "";

            }

            if (cboDateType.Text == "Today")
            {
                DateTime _dFrom = _dateTo.AddDays(0);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }
            if (cboDateType.Text == "Last One Week")
            {
                DateTime _dFrom = _dateTo.AddDays(-7);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last One Month")
            {
                DateTime _dFrom = _dateTo.AddDays(-30);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last Three Month")
            {
                DateTime _dFrom = _dateTo.AddMonths(-3);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last Six Month")
            {
                DateTime _dFrom = _dateTo.AddMonths(-6);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last One Year")
            {
                DateTime _dFrom = _dateTo.AddYears(-1);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }
            #endregion
        }

        private void rdoUserWise_CheckedChanged(object sender, EventArgs e)
        {
            lblUserID.Visible = true;
            txtUserID.Visible = true;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
            txtUserID.Focus();
        }

        private void rdoTestDet_CheckedChanged(object sender, EventArgs e)
        {
            lblParam2.Text = "Group";
            lblParam3.Text = "Department";
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam3.Visible = true;
            cboParam1.Visible = false;
            cboParam2.Visible = true;
            txtParam1.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlResultHead.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = false;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            pnlTestDet.Visible = false;
            cboTicketType.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }

        private void rdoRefundMRReport_CheckedChanged(object sender, EventArgs e)
        {
            pnlResultHead.Visible = false;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = true;
            rdoAll.Visible = true;
            rdoUserWise.Visible = true;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }

        private void rdoTestCancelMRReport_CheckedChanged(object sender, EventArgs e)
        {
            pnlResultHead.Visible = false;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = true;
            rdoAll.Visible = true;
            rdoUserWise.Visible = true;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }
        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
            cboDateType.Focus();
        }
        private void rdoDoctorWiseCollDet_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;           
            lblEmpID.Visible = false;
            pnlResultHead.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = true;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            gbDateRange.Visible = true;
            lblTicketType.Visible = true;
            cboTicketType.Visible = true;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }

        private void rdoDoctorWiseCollSum_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlResultHead.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = true;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            gbDateRange.Visible = true;
            lblTicketType.Visible = true;
            cboTicketType.Visible = true;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }

        private void rdoUserWiseCollection_Click(object sender, EventArgs e)
        {
            txtEmpID.Text = Utility.UserId;
        }

        private void rdoVoucher_Click(object sender, EventArgs e)
        {
            rdoAll.Checked = true;
        }

        private void rdoRefundMRReport_Click(object sender, EventArgs e)
        {
            rdoAll.Checked = true;
        }
        private void rdoTestCancelMRReport_Click(object sender, EventArgs e)
        {
            rdoAll.Checked = true;
        }
        private void rdoAllPanelTest_CheckedChanged(object sender, EventArgs e)
        {
            pnlTestDeatils.Visible = false;
            pnlResultHead.Visible = false;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            gbDateRange.Visible = false;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }
        private void txtParam1_TextChanged(object sender, EventArgs e)
        {
            txtParam1.CharacterCasing = CharacterCasing.Upper;
        }

        private void cboTestMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTestMain.SelectedValue != null)
            {
                cboTestDet.DisplayMember = "Value";
                cboTestDet.ValueMember = "Key";
                cboTestDet.DataSource = new BindingSource(dmsSRClient.GetTestDetsDict("D", cboDepartment.SelectedValue.ToString(), cboGroup.SelectedValue.ToString(), cboTestMain.SelectedValue.ToString()), null);
            }
        }
        private void rdoResultHeadUnderTest_CheckedChanged(object sender, EventArgs e)
        {
            pnlResultHead.Visible = false;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlTestDeatils.Visible = true;
            gbDateRange.Visible = false;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = true;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }
        private void rdoAllTestByHCN_CheckedChanged(object sender, EventArgs e)
        {
            pnlResultHead.Visible = false;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = true;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = true;
            lblHCN.Visible = true;
        }
        private void rdoAllTestByHCN_Click(object sender, EventArgs e)
        {
            txtHCNNo.Visible = true;
            lblHCN.Visible = true;
            txtHCNNo.Focus();
        }

        private void txtHCNNo_TextChanged(object sender, EventArgs e)
        {
            txtHCNNo.CharacterCasing = CharacterCasing.Upper;
        }

        private void rdoUserWiseCash_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlResultHead.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = true;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }

        private void rdoAllCollSummary_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlResultHead.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = true;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }

        private void rdoAllTestOfPatient_CheckedChanged(object sender, EventArgs e)
        {
            pnlResultHead.Visible = false;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = true;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }

        private void rdoTestMainWiseDet_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlResultHead.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = true;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }

        private void rdoEmrColl_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "MR No.";
            lblParam2.Visible = false;
            lblParam1.Visible = true;
            lblParam3.Visible = false;
            txtParam1.Visible = true;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            pnlResultHead.Visible = false;
            pnlTestDeatils.Visible = false;
            gbDateRange.Visible = false;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            pnlTestDet.Visible = false;
            txtHCNNo.Visible = false;
            lblHCN.Visible = false;
        }

      
    }
}

