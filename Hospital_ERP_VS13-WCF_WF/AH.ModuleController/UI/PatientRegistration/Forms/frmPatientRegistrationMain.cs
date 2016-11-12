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
using AH.ModuleController.UI.PatientRegistration.ParameterForms;
using AH.ModuleController.UI.ACMS.Forms;

namespace AH.ModuleController.UI.PatientRegistration.Forms
{
    public partial class frmPatientRegistrationMain : Form
    {
        public frmPatientRegistrationMain()
        {
            InitializeComponent();
        }

        private void frmPatientRegistrationMain_Load(object sender, EventArgs e)
        {
            pnlPatientRegistration.Visible = false;
            Utility.EnforceSecurity("RegMIS", menuStrip1, pnlPatientRegistration);
            Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);
            pnlPatientRegistration.Visible = true;
            btnCloseModule.Enabled = true;
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnPatientRegistrationModule_Click(object sender, EventArgs e)
        {
            frmPatientRegistration prObj = new frmPatientRegistration();
            prObj.ShowDialog();
        }

        private void btnPatientRegRptManager_Click(object sender, EventArgs e)
        {
            frmPetRegReportManager regRpt = new frmPetRegReportManager();
            regRpt.Show();
        }

        private void mnuNewPatientRegistration_Click(object sender, EventArgs e)
        {
            frmPatientRegistration prObj = new frmPatientRegistration();
            prObj.ShowDialog();
        }      

        private void mnuChangePassword_Click(object sender, EventArgs e)
        {
            frmPasswordReset passReset = new frmPasswordReset();
            passReset.ShowDialog();
        }

        private void mnuPatientSearch_Click(object sender, EventArgs e)
        {
            //frmPatientSearch srch = new frmPatientSearch();
            //srch.ShowDialog();
            frmPatientDetails ps = new frmPatientDetails();
            ps.ShowDialog();
        }

        private void mnuCloseModule_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mnuReportManager_Click(object sender, EventArgs e)
        {
            frmPetRegReportManager regRpt = new frmPetRegReportManager();
            regRpt.Show();
        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            //frmPatientSearch srch = new frmPatientSearch();
            //srch.ShowDialog();

            frmPatientDetails ps = new frmPatientDetails();
            ps.ShowDialog();
        }
        private void mnuStaffTypeSetup_Click(object sender, EventArgs e)
        {
            frmStaffTypeSetup typeSetup = new frmStaffTypeSetup();
            typeSetup.ShowDialog();
        }

        private void btnCloseModule_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mnuCorporateTypeSetup_Click(object sender, EventArgs e)
        {
            frmCorporateType corptype = new frmCorporateType();
            corptype.ShowDialog();
        }

        private void userWidgetMetro1_btnLogout_Clicked(object sender, EventArgs e)
        {
            userWidgetMetro1.Parent.Dispose();
            Utility.isAuthenticated = 0;
            frmLogIn logIn = new frmLogIn("RegMIS");
            logIn.atiqsLogInUserControl1.IsPrefilled = false;
            logIn.ShowDialog();
            logIn.atiqsLogInUserControl1.txtUserID.Text = "";
            logIn.atiqsLogInUserControl1.txtPassword.Text = "";
        }

    }
}
