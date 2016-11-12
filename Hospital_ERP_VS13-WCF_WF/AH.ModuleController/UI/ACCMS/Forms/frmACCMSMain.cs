using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.AccountsMSSR;
using AH.DUtility;
using AH.ModuleController.UI.ACCMS.Reports.ParameterForms;
using AH.ModuleController.UI.ACMS.Forms;
using TreeviewPrinting;
using AH.ModuleController.UI.OPD.Reports.ParameterForms;
using AH.ModuleController.UI.DMS.Reports.ParameterForms;
using AH.ModuleController.UI.FNB.Forms;
namespace AH.ModuleController.UI.ACCMS.Forms
{
    public partial class frmACCMSMain : Form
    {
        public frmACCMSMain()
        {
            InitializeComponent();
        }
        private void frmPatientRegistrationMain_Load(object sender, EventArgs e)
        {
            Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);
            Utility.EnforceSecurity("ACCMS", menuStrip1, pnlPatientRegistration);
            btnCloseModule.Enabled = true;

        }
        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
        private void btnPatientRegistrationModule_Click(object sender, EventArgs e)
        {
            //frmOPDTicketIssue tktFrm = new frmOPDTicketIssue();
            //tktFrm.Show();

        }
        private void btnPatientRegRptManager_Click(object sender, EventArgs e)
        {
            frmACCMSReportManager rptMgr = new frmACCMSReportManager();
            rptMgr.Show();
            //frmPatientRegistrationReport regRpt = new frmPatientRegistrationReport();
            //regRpt.Show();
        }
       
        private void mnuPurposeSetup_Click(object sender, EventArgs e)
        {
            frmCostCenter prps = new frmCostCenter();
            prps.ShowDialog();
        }
       
        private void mnuBranchConfiguration_Click(object sender, EventArgs e)
        {
            frmBranchConfig frmBranch = new frmBranchConfig();
            frmBranch.ShowDialog();
        }
        private void mnuGroupConfiguration_Click(object sender, EventArgs e)
        {
            frmGroupConfig frmGroup = new frmGroupConfig();
            frmGroup.ShowDialog();
        }
        private void mnuLedgerConfiguration_Click(object sender, EventArgs e)
        {
            frmLedger frm = new frmLedger();
            frm.ShowDialog();
        }
        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVoucher frm = new frmVoucher();
            frm.intVoucherType = (int)Utility.VoucherType.vtPayment;
            frm.ShowDialog();
        }
        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVoucher frm = new frmVoucher();
            frm.intVoucherType = (int)Utility.VoucherType.vtReceipt;
            frm.ShowDialog();
        }
        private void journalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVoucher frm = new frmVoucher();
            frm.intVoucherType = (int)Utility.VoucherType.vtJournal;
            frm.ShowDialog();
        }
        private void contraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVoucher frm = new frmVoucher();
            frm.intVoucherType = (int)Utility.VoucherType.vtContra;
            frm.ShowDialog();
        }

        //private void mnuRptTrailBalance_Click(object sender, EventArgs e)
        //{
        //    frmACCMSReportaccounts frm = new frmACCMSReportaccounts();
        //    frm.ShowDialog();

        //}

        private void mnuVoucherWise_Click(object sender, EventArgs e)
        {
            frmACCMSReportvoucher frm = new frmACCMSReportvoucher();
            frm.ShowDialog();
        }

        private void ledgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmACCMSReportLedger frm = new frmACCMSReportLedger();
            frm.strSelection = "Ledger";
            frm.ShowDialog();
        }

        private void groupWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmACCMSReportLedger frm = new frmACCMSReportLedger();
            frm.strSelection = "Group";
            frm.ShowDialog();
        }

        private void mnuFinalAccounts_Click(object sender, EventArgs e)
        {
            frmACCMSReportaccounts frm = new frmACCMSReportaccounts();
            frm.ShowDialog();
        }

        private void voucherTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVoucher frm = new frmVoucher();
           // frm.intVoucherType = (int)Utility.VoucherType.vtPayment;
            frm.ShowDialog();
        }

        private void mnuLedgerOpening_Click(object sender, EventArgs e)
        {
            frmLedgeropn frm = new frmLedgeropn();
            frm.ShowDialog();
        }

      
        private void mnuChangePassword_Click(object sender, EventArgs e)
        {
            frmPasswordReset frm = new frmPasswordReset();
            frm.ShowDialog();
        }

        private void mnuCostCategory_Click(object sender, EventArgs e)
        {
            frmCostCategory frm = new frmCostCategory();
            frm.ShowDialog();
        }

        private void MnuBranchConfig_Click(object sender, EventArgs e)
        {
            frmBranchConfig frmBranch = new frmBranchConfig();
            frmBranch.ShowDialog();
        }

        private void MnuCostCenter_Click(object sender, EventArgs e)
        {
            frmCostCenter frm = new frmCostCenter();
            frm.ShowDialog();
        }

        private void MnuGroupConfigurationItem_Click(object sender, EventArgs e)
        {
            frmTreeView frm = new frmTreeView();
            frm.ShowDialog();
        }

        private void MnuLedgerConfig_Click(object sender, EventArgs e)
        {
            frmLedger frm = new frmLedger();
            frm.ShowDialog();
        }

        private void mnuFxedAssetsConfiguration_Click(object sender, EventArgs e)
        {
            frmFixedAssestsConfig frm = new frmFixedAssestsConfig();
            frm.Show();
        }

        private void mnuLedgerOpnMenu_Click(object sender, EventArgs e)
        {
            frmLedgeropn frm = new frmLedgeropn();
            frm.ShowDialog();
        }

        private void mnuvoucherTransaction_Click(object sender, EventArgs e)
        {
            frmVoucher frm = new frmVoucher();
            frm.Postvoucher = "N";
            frm.ShowDialog();
        }

        private void mnuFinalAccountsMenu_Click(object sender, EventArgs e)
        {
            frmACCMSReportaccounts frm = new frmACCMSReportaccounts();
            frm.ShowDialog();
        }

        private void mnuLedgerWise_Click(object sender, EventArgs e)
        {
            frmACCMSReportLedger frm = new frmACCMSReportLedger();
            frm.strSelection = "Ledger";
            frm.ShowDialog();
        }

        private void mnuroupWise_Click(object sender, EventArgs e)
        {
            frmACCMSReportLedger frm = new frmACCMSReportLedger();
            frm.strSelection = "Group";
            frm.ShowDialog();
        }

        private void mnuvoucher_Click(object sender, EventArgs e)
        {
            frmACCMSReportvoucher frm = new frmACCMSReportvoucher();
            frm.ShowDialog();
        }

        private void mnuRevenueHeadgroup_Click(object sender, EventArgs e)
        {
            frmRevenueHeadGroup frm = new frmRevenueHeadGroup();
            frm.ShowDialog();
        }

        private void revenueHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRevenueHead frm = new frmRevenueHead();
            frm.ShowDialog();

        }

        private void userWidgetMetro1_btnLogout_Clicked(object sender, EventArgs e)
        {
            userWidgetMetro1.Parent.Dispose();
            Utility.isAuthenticated = 0;
            frmLogIn logIn = new frmLogIn("ACCMS");
            logIn.atiqsLogInUserControl1.IsPrefilled = false;
            logIn.ShowDialog();
            logIn.atiqsLogInUserControl1.txtUserID.Text = "";
            logIn.atiqsLogInUserControl1.txtPassword.Text = "";
        }

        private void mnCostCategory_Click(object sender, EventArgs e)
        {
            frmACCMSRReportCostCategory frm = new frmACCMSRReportCostCategory();
            frm.ShowDialog();
        }

        private void mnuCashflow_Click(object sender, EventArgs e)
        {
            frmACCMSRReportCashflow frm = new frmACCMSRReportCashflow();
            frm.strSelection = "Cashflow";
            frm.ShowDialog();
        }

      
        private void mnurptTreeview_Click(object sender, EventArgs e)
        {
            frmACCMSReportMain frm = new frmACCMSReportMain();
            frm.ShowDialog();
        }

        private void btnChartOfAccounts_Click(object sender, EventArgs e)
        {
            frmTreeView frm = new frmTreeView();
            frm.Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {

            try
            {
                frmVoucher frm = new frmVoucher();
                frm.Postvoucher = "N";
                frm.ShowDialog();
               
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

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmACCMSReportMain frm = new frmACCMSReportMain();
            frm.ShowDialog();
        }

        private void btnCloseModule_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mnuVoucherArchive_Click(object sender, EventArgs e)
        {
            frmVoucherArchive frm = new frmVoucherArchive();
            frm.ShowDialog();
        }

        private void mnuBankReconcilation_Click(object sender, EventArgs e)
        {
            frmBankReconcilation frm = new frmBankReconcilation();
            frm.ShowDialog();
        }

        private void mnuPostVoucherTransaction_Click(object sender, EventArgs e)
        {
            frmVoucher frm = new frmVoucher();
            frm.Postvoucher = "Y";
            frm.ShowDialog();
        }

        private void mnuFixedAssetsConfiguration_Click(object sender, EventArgs e)
        {
            frmFixedAssestsConfig frm = new frmFixedAssestsConfig();
            frm.ShowDialog();
        }

        private void mnuFiscalYear_Click(object sender, EventArgs e)
        {
            frmFiscalYear frm = new frmFiscalYear();
            frm.ShowDialog();
        }

        private void mnuCollectionStatement_Click(object sender, EventArgs e)
        {
            frmCollectionStatementsSummary frm = new frmCollectionStatementsSummary();
            frm.ShowDialog();
        }

        private void mnuOPDCollection_Click(object sender, EventArgs e)
        {
            frmReportOPDCollection frm = new frmReportOPDCollection();
            frm.ShowDialog();
        }

        private void mnuIPDCollection_Click(object sender, EventArgs e)
        {
            frmDMSCollectionReport frm = new frmDMSCollectionReport();
            frm.ShowDialog();
        }

        private void mnuFoodItemMaster_Click(object sender, EventArgs e)
        {
            frmFoodMaster objfrm = new frmFoodMaster();
            objfrm.ShowDialog();
        }

       

    }
}
