using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.UI.FNB.Reports;
using AH.ModuleController.UI.INVMS.Forms;
using AH.ModuleController.UI.ACMS.Forms;
using AH.ModuleController.UI.DIET.Forms;

namespace AH.ModuleController.UI.FNB.Forms
{
    public partial class frmFNBMain : Form
    {
        public frmFNBMain()
        {
            InitializeComponent();
        }

        private void frmPatientRegistrationMain_Load(object sender, EventArgs e)
        {
            Utility.EnforceSecurity("FNBMS", menuStrip1, pnlFnB);
            Utility.InitialiseMainForm(this, pnlFnB, pnlModuleName, userWidgetMetro1, dateWidget1);
            btnClose.Enabled = true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //private void mnuResetPassword_Click(object sender, EventArgs e)
        //{
        //    frmPasswordReset frmPasswordReset = new frmPasswordReset();
        //    frmPasswordReset.ShowDialog();
        //}

        private void mnuResetPassword_Click(object sender, EventArgs e)
        {
            frmPasswordReset frmPasswordReset = new frmPasswordReset();
            frmPasswordReset.ShowDialog();
        }

        private void userWidgetMetro1_btnLogout_Clicked(object sender, EventArgs e)
        {
            userWidgetMetro1.Parent.Dispose();
            Utility.isAuthenticated = 0;
            frmLogIn logIn = new frmLogIn("FNBMIS");
            logIn.atiqsLogInUserControl1.IsPrefilled = false;
            logIn.ShowDialog();
            logIn.atiqsLogInUserControl1.txtUserID.Text = "";
            logIn.atiqsLogInUserControl1.txtPassword.Text = "";
        }
       

        private void mnuReceiptSetup_Click(object sender, EventArgs e)
        {
            frmFnBReceived objFrm = new frmFnBReceived();
            objFrm.ShowDialog();
        }

        private void mnusetmenu_Click(object sender, EventArgs e)
        {
            frmSetmenu objFrm = new frmSetmenu();
            objFrm.ShowDialog();
        }

        

        

        private void mnuFoodItem_Click(object sender, EventArgs e)
        {
            frmFoodMaster objfrm = new frmFoodMaster();
            objfrm.ShowDialog();
        }

        private void mnuFoodMenuSetup_Click(object sender, EventArgs e)
        {
            frmFoodMenuSetup objfrm = new frmFoodMenuSetup();
            objfrm.ShowDialog();
        }

                    
       
        private void mnuMealSetupConfig_Click(object sender, EventArgs e)
        {
            frmMealSetupConfig objfrm = new frmMealSetupConfig();
            objfrm.ShowDialog();
        }

       

        private void mnuSetmenuVisitors_Click(object sender, EventArgs e)
        {
            frmVisitors frm = new frmVisitors();
            frm.ShowDialog();
        }

        private void mnuRegister_Click(object sender, EventArgs e)
        {
            frmEmpMealRegister objfrm = new frmEmpMealRegister();
            objfrm.intAttncheck = 0;
            objfrm.ShowDialog();
        }

        private void mnuWeeklyChart_Click(object sender, EventArgs e)
        {
            frmWeeklyChart frm = new frmWeeklyChart();
            frm.ShowDialog();
        }

        private void mnuCollectionTrasfer_Click(object sender, EventArgs e)
        {
            frmCollectionSendToAccounts frm = new frmCollectionSendToAccounts();
            frm.ShowDialog();
        }

        private void btnVisitors_Click(object sender, EventArgs e)
        {
            frmVisitors frm = new frmVisitors();
            frm.ShowDialog();
        }

        private void btnCollectionTransfer_Click(object sender, EventArgs e)
        {
            frmCollectionSendToAccounts frm = new frmCollectionSendToAccounts();
            frm.ShowDialog();
        }

       
        private void SetMenuItemSetup_Click(object sender, EventArgs e)
        {
            frmMenuItemSetup objfrm = new frmMenuItemSetup();
            objfrm.ShowDialog();

        }

        private void SetmenuConfig_Click(object sender, EventArgs e)
        {
            frmWeeklySetmenu objfrm = new frmWeeklySetmenu();
            objfrm.ShowDialog();
        }

        private void fNBReports_Click(object sender, EventArgs e)
        {
            frmFNBreport frm = new frmFNBreport();
            frm.ShowDialog();
        }

        private void mnuMealIssued_Click(object sender, EventArgs e)
        {
            frmMealIssued frm = new frmMealIssued();
            frm.ShowDialog();
        }

        private void btnMealRegister_Click(object sender, EventArgs e)
        {
            frmEmpMealRegister frm = new frmEmpMealRegister();
            frm.ShowDialog();
        }

      

        private void mnuFoodCategory_Click(object sender, EventArgs e)
        {
         
            frmFoodCategory objfrm = new frmFoodCategory();
            objfrm.ShowDialog();
        
        }

        private void mnuServiceSetup_Click(object sender, EventArgs e)
        {
            frmFoodService objfrm = new frmFoodService();
            objfrm.ShowDialog();
        }

        private void mnuFoodMenuType_Click(object sender, EventArgs e)
        {
          
            frmfoodMenutype objfrm = new frmfoodMenutype();
            objfrm.ShowDialog();
   
        }

        private void mnuTotalAttendance_Click(object sender, EventArgs e)
        {
            frmEmpMealRegister objfrm = new frmEmpMealRegister();
            objfrm.intAttncheck = 1;
            objfrm.ShowDialog();
        }

        private void mnuDR_Click(object sender, EventArgs e)
        {

            frmDemandRequisition frm = new frmDemandRequisition();
            frm.ShowDialog();
        }

        private void mnuVerifyDR_Click(object sender, EventArgs e)
        {
            frmVerifyRequisition vr = new frmVerifyRequisition();
            vr.ShowDialog();
        }

        private void mnuItemIssue_Click(object sender, EventArgs e)
        {
            frmFoodInventoriesVoucher frm = new frmFoodInventoriesVoucher();
            frm.Vtype = 1; // Mrr
            frm.ShowDialog();
        }

        private void mnuItemDamage_Click(object sender, EventArgs e)
        {
            frmFoodInventoriesVoucher frm = new frmFoodInventoriesVoucher();
            frm.Vtype = 2; // Damage
            frm.ShowDialog();
        }

        private void mnuItemReturn_Click(object sender, EventArgs e)
        {
            frmFoodInventoriesVoucher frm = new frmFoodInventoriesVoucher();
            frm.Vtype = 3; // Item Return
            frm.ShowDialog();
        }

        private void mnuIssue_Click(object sender, EventArgs e)
        {
            frmFoodInventoriesVoucher frm = new frmFoodInventoriesVoucher();
            frm.Vtype = 4; // Item Issue
            frm.ShowDialog();
        }

        private void mnuDietOrder_Click(object sender, EventArgs e)
        {
            frmTotalOrderList frmList = new frmTotalOrderList();
            frmList.ShowDialog();
        }

        private void mnuSubmenuType_Click(object sender, EventArgs e)
        {
            frmDietSubType frm = new frmDietSubType();
            frm.ShowDialog();

        }

        private void mnuWeekleyDietSetup_Click(object sender, EventArgs e)
        {
            frmWeeklyDietSetup frm = new frmWeeklyDietSetup();
            frm.ShowDialog();
        }

        private void mnuDietCategory_Click(object sender, EventArgs e)
        {
            frmDietCategory frm = new frmDietCategory();
            frm.ShowDialog();
        }

       

       

      

      

       
       

      

     

     


       

       

    }
}
