using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.DIETSR;
using AH.DUtility;
using AH.ModuleController.UI.DIET.Forms;
using AH.ModuleController.UI.ACMS.Forms;
//using AH.ModuleController.UI.DIET.Reports.ParameterForms;
//using AH.ModuleController.UI.ATMS.Reports.ParameterForms;
//using AH.ModuleController.UI.ATMS.Forms;

namespace AH.ModuleController.UI.DIET.Forms
{
    public partial class frmDIETMain : Form
    {
        public frmDIETMain()
        {
            InitializeComponent();
        }
        private void frmPatientRegistrationMain_Load(object sender, EventArgs e)
        {
            Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);
            Utility.EnforceSecurity("DIETMIS", menuStrip1, pnlPatientRegistration);
            btnCloseModule.Enabled = true;

        }
        private void userWidgetMetro1_btnLogout_Clicked(object sender, EventArgs e)
        {
            userWidgetMetro1.Parent.Dispose();
            Utility.isAuthenticated = 0;
            frmLogIn logIn = new frmLogIn("DIETMIS");
            logIn.atiqsLogInUserControl1.IsPrefilled = false;
            logIn.ShowDialog();
            logIn.atiqsLogInUserControl1.txtUserID.Text = "1000";
            logIn.atiqsLogInUserControl1.txtPassword.Text = "123";
        }

        private void btnCloseModule_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mnuPatDietAssign_Click(object sender, EventArgs e)
        {
            frmPatientListDietAssign frm = new frmPatientListDietAssign();
            frm.ShowDialog();
            
        }
        private void mnuPatDietOrder_Click(object sender, EventArgs e)
        {
            frmPatientListDietAssignDetails frm = new frmPatientListDietAssignDetails("A");
            frm.ShowDialog();
        }

        private void mnuChangePassword_Click(object sender, EventArgs e)
        {
            frmPasswordReset frmPasswordReset = new frmPasswordReset();
            frmPasswordReset.ShowDialog();
        }

        private void mnuOrderDelevered_Click(object sender, EventArgs e)
        {
            frmPatientListDietAssignDetails frm = new frmPatientListDietAssignDetails("B");
            frm.ShowDialog();
        }

        private void mnuServedFood_Click(object sender, EventArgs e)
        {
            frmPatientListDietAssignDetails frm = new frmPatientListDietAssignDetails("C");
            frm.ShowDialog();

        }

        private void mnuTotalOrderList_Click(object sender, EventArgs e)
        {
            frmTotalOrderList frm = new frmTotalOrderList();
            frm.ShowDialog();
        }

        private void mnuPatientInformation_Click(object sender, EventArgs e)
        {
            frmAdmittedPatientInfo frm = new frmAdmittedPatientInfo();
            //frmAdmPatList frm = new frmAdmPatList();
            frm.ShowDialog();
        }

        private void mnuDietSubType_Click(object sender, EventArgs e)
        {
            frmDietSubType frm = new frmDietSubType();
            frm.ShowDialog();
        }

        private void mnuWeeklyDietSetup_Click(object sender, EventArgs e)
        {
            frmWeeklyDietSetup frm = new frmWeeklyDietSetup();
            frm.ShowDialog();
        }

    }
}
