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
using AH.ModuleController.UI.ACMS.Reports.ParameterForms;

namespace AH.ModuleController.UI.ACMS.Forms
{
    public partial class frmACMSMain : Form
    {
        public frmACMSMain()
        {
            InitializeComponent();
        }
       
        private void btnPatientRegistrationModule_Click(object sender, EventArgs e)
        {
            //frmOPDTicketIssue tktFrm = new frmOPDTicketIssue();
            //tktFrm.Show();

        }

        private void btnPatientRegRptManager_Click(object sender, EventArgs e)
        {
            //frmPatientRegistrationReport regRpt = new frmPatientRegistrationReport();
            //regRpt.Show();
        }

        private void mnuPurposeSetup_Click(object sender, EventArgs e)
        {
            //frmPurposeSetup prps = new frmPurposeSetup();
            //prps.ShowDialog();
        }

        private void btnCloseModule_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmACMSMain_Load(object sender, EventArgs e)
        {
            pnlPatientRegistration.Visible = false;
            Utility.EnforceSecurity("ACMS", menuStrip1, pnlPatientRegistration);
            Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);
            pnlPatientRegistration.Visible = true;
            
            btnClose.Enabled = true;
        }

        private void mnuGroupSetup_Click(object sender, EventArgs e)
        {
            frmCreateUserGroup ug = new frmCreateUserGroup();
            ug.ShowDialog();
        }

        private void mnuSecQ_Click(object sender, EventArgs e)
        {
            frmCreateSecurityQuestion csq = new frmCreateSecurityQuestion();
            csq.ShowDialog();
        }

        private void mnuObjSetup_Click(object sender, EventArgs e)
        {
            frmCreateObject co = new frmCreateObject();
            co.ShowDialog();
        }

        private void mnuUserSetup_Click(object sender, EventArgs e)
        {
            frmCreateUser cu = new frmCreateUser();
            cu.ShowDialog();
        }

        private void mnuAccessControl_Click(object sender, EventArgs e)
        {
            frmCreateAccessControl cac = new frmCreateAccessControl();
            cac.ShowDialog();
        }

        private void mnuUGOM_Click(object sender, EventArgs e)
        {
            //frmGrpObjMap fgom = new frmGrpObjMap();
            //fgom.ShowDialog();
        }

        private void mnuUserAssign_Click(object sender, EventArgs e)
        {
            //frmAssignUser fAU = new frmAssignUser();
            //fAU.ShowDialog();
        }

        private void accessControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmACMSReportManager ofrm = new frmACMSReportManager();
            ofrm.Show();
        }

        private void mnuPanelSetup_Click(object sender, EventArgs e)
        {
            //frmCreateAccessControl ofrm = new frmCreateAccessControl();
            //ofrm.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccessLevel ofrm = new frmAccessLevel();
            ofrm.ShowDialog();
        }

        private void userModule_Click(object sender, EventArgs e)
        {
            frmGetUserModule ofrmUserModule = new frmGetUserModule();
            ofrmUserModule.Show();
        }

        private void moduleObject_Click(object sender, EventArgs e)
        {
            frmUserObject ofrmModuleObject = new frmUserObject();
            ofrmModuleObject.Show();
        }

        //private void mnuResetPassword_Click(object sender, EventArgs e)
        //{
        //    frmPasswordReset ofrmPasswordReset = new frmPasswordReset();
        //    ofrmPasswordReset.ShowDialog();
        //}

        private void mnuUserGroupObjectMapping_Click(object sender, EventArgs e)
        {
            frmGrpObjMap fgom = new frmGrpObjMap();
            fgom.ShowDialog();
        }

        private void mnuAssignUser_Click(object sender, EventArgs e)
        {
            frmAssignUser fAU = new frmAssignUser();
            fAU.ShowDialog();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mnuResetPassword_Click(object sender, EventArgs e)
        {
            frmPasswordReset ofrmPasswordReset = new frmPasswordReset();
            ofrmPasswordReset.ShowDialog();
        }

        private void utitlityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuFormatPassword_Click(object sender, EventArgs e)
        {
            frmFormatPassword frmFormatPass = new frmFormatPassword();
            frmFormatPass.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void userWidgetMetro1_btnLogout_Clicked(object sender, EventArgs e)
        {
            userWidgetMetro1.Parent.Dispose();
            Utility.isAuthenticated = 0;
            frmLogIn logIn = new frmLogIn("ACMS");
            logIn.atiqsLogInUserControl1.IsPrefilled = false;
            logIn.ShowDialog();
            logIn.atiqsLogInUserControl1.txtUserID.Text = "";
            logIn.atiqsLogInUserControl1.txtPassword.Text = "";
        }
    
    }
}
