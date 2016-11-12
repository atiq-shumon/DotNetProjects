using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.ATMSSR;
using AH.DUtility;
using AH.ModuleController.UI.ATMS.Forms;
using AH.ModuleController.UI.ATMS.Reports.ParameterForms;
//using AH.ModuleController.UI.ATMS.Reports.ParameterForms;
//using AH.ModuleController.UI.ATMS.Forms;

namespace AH.ModuleController.UI.ATMS.Forms
{
    public partial class frmATMSMain : Form
    {
        public frmATMSMain()
        {
            InitializeComponent();
        }
        private void frmPatientRegistrationMain_Load(object sender, EventArgs e)
        {
            Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);
            Utility.EnforceSecurity("ATMS", menuStrip1, pnlPatientRegistration);
            btnCloseModule.Enabled = true;

        }
        private void userWidgetMetro1_btnLogout_Clicked(object sender, EventArgs e)
        {
            userWidgetMetro1.Parent.Dispose();
            Utility.isAuthenticated = 0;
            frmLogIn logIn = new frmLogIn("ATMS");
            logIn.atiqsLogInUserControl1.IsPrefilled = false;
            logIn.ShowDialog();
            logIn.atiqsLogInUserControl1.txtUserID.Text = "";
            logIn.atiqsLogInUserControl1.txtPassword.Text = "";
        }

        private void btnCloseModule_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mnuDepartment_Click(object sender, EventArgs e)
        {
            //frmDepartment frm = new frmDepartment();
            //frm.ShowDialog();
        }

        private void mnuGroup_Click(object sender, EventArgs e)
        {
            //frmGroup frm = new frmGroup();
            //frm.ShowDialog();
        }

        private void mnuTreeView_Click(object sender, EventArgs e)
        {
            //frmTreeview frm = new frmTreeview();
            //frm.ShowDialog();
        }

        private void mnuMaterialReceipt_Click(object sender, EventArgs e)
        {
            //frmMaterialReceivingReport frm = new frmMaterialReceivingReport();
            //frm.vouchertype = 31;
            //frm.ShowDialog();
        }

        private void mnuAssetsUser_Click(object sender, EventArgs e)
        {
            //frmAssetsUser frm = new frmAssetsUser();
            //frm.ShowDialog();
        }

        private void btnMaterialReceivingReport_Click(object sender, EventArgs e)
        {
            frmServiceProviderInformation frm = new frmServiceProviderInformation();
            //frm.vouchertype = 31;
            frm.ShowDialog(); 
        }

        private void btnAssets_Click(object sender, EventArgs e)
        {
            //frmservic frm = new frmTreeview();
            //frm.ShowDialog(); 
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmATMSReportacms frm = new frmATMSReportacms();
            frm.ShowDialog();
        }

        private void mnuServiceProviderInfor_Click(object sender, EventArgs e)
        {
            frmServiceProviderInformation frm = new frmServiceProviderInformation();
            frm.ShowDialog();
        }

        private void mnuServiceDetails_Click(object sender, EventArgs e)
        {
            frmServiceDetails frm = new frmServiceDetails();
            frm.ShowDialog();
        }

      

        private void mnuTermsNCondition_Click(object sender, EventArgs e)
        {
            //frmTermsandCondition frm = new frmTermsandCondition();
            //frm.ShowDialog();
        }

        private void mnuStoreType_Click(object sender, EventArgs e)
        {
            //frmStoreType frm = new frmStoreType();
            //frm.ShowDialog();
        }

        private void mnuMajorGroup_Click(object sender, EventArgs e)
        {
            //frmMajorGroup frm = new frmMajorGroup();
            //frm.ShowDialog();
        }

        private void mnuWarehouseType_Click(object sender, EventArgs e)
        {
            frmWarehouseType frm = new frmWarehouseType();
            frm.ShowDialog();
        }

        private void mnuWarehouseConfig_Click(object sender, EventArgs e)
        {
            frmWarehouseConfig frm = new frmWarehouseConfig();
            frm.ShowDialog();
        }

        private void mnuItemReceipt_Click(object sender, EventArgs e)
        {
            //frmItemReceipt frm = new frmItemReceipt();
            //frm.ShowDialog();
        }

        private void mnuReceipt_Click(object sender, EventArgs e)
        {
            frmItemReceipt frm = new frmItemReceipt();
            frm.ioFlag = 0; //Receipt
            frm.ModuleName = "H";
            frm.ShowDialog();
        }

        private void mnuIssue_Click(object sender, EventArgs e)
        {
            frmWarehouseIssue frm = new frmWarehouseIssue();
            frm.ioFlag = 1; //Issue
            frm.ModuleName = "H";
            frm.ShowDialog();
        }

        private void mnuCssdReceipt_Click(object sender, EventArgs e)
        {
            frmItemReceipt frm = new frmItemReceipt();
            frm.ioFlag = 3; //Receipt
            frm.ModuleName = "C";
            frm.ShowDialog();
        }

        private void mnuCssdIssue_Click(object sender, EventArgs e)
        {
            frmWarehouseIssue frm = new frmWarehouseIssue();
            frm.ioFlag = 4; //Issue
            frm.ModuleName = "C";
            frm.ShowDialog();
        }

        private void mnuArchievelog_Click(object sender, EventArgs e)
        {
            frmArchieveLog frm = new frmArchieveLog();
            frm.ShowDialog();
        }

        private void mnuMaintainenceHk_Click(object sender, EventArgs e)
        {
            frmArchieveLog frm = new frmArchieveLog();
            frm.ModuleName = "H";
            frm.ShowDialog();
        }

        private void mnuMaintaienceCSSD_Click(object sender, EventArgs e)
        {
            frmArchieveLog frm = new frmArchieveLog();
            frm.ModuleName = "C";
            frm.ShowDialog();
        }

        private void mnuStoreInformation_Click(object sender, EventArgs e)
        {
            frmATMSReportstockinformation frm = new frmATMSReportstockinformation();
            frm.ShowDialog();
        }

        private void mnuProductService_Click(object sender, EventArgs e)
        {
            frmProductServiceInformation frm = new frmProductServiceInformation();
            frm.ShowDialog();
        }

        //private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmArchieveLog frm = new frmArchieveLog();
        //    frm.ModuleName =
        //    frm.ShowDialog();
        //}

       

    }
}
