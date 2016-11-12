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
using AH.ModuleController.UI.ACMS.Forms;
using AH.ModuleController.UI.IPD.Forms;
using AH.ModuleController.UI.INVMS.Forms;
using AH.ModuleController.UI.NWMS.Reports.ParameterForms;
namespace AH.ModuleController.UI.NWMS.Forms
{
    public partial class frmNWMSMain : Form
    {
        public frmNWMSMain()
        {
            InitializeComponent();
            //timermain.Start();
        }

        private void frmNWMSMain_Load(object sender, EventArgs e)
        {
             pnlPatientRegistration.Visible = false;
             Utility.EnforceSecurity("NWMS", menuStrip1, pnlPatientRegistration);
             Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);
             pnlPatientRegistration.Visible = true;
             btnCloseModule.Enabled = true;
        }

         private void btnCloseModule_Click(object sender, EventArgs e)
         {
             this.Dispose();
         }

         private void btnAppointmentRegistration_Click(object sender, EventArgs e)
         {
             frmInteractiveBedInformation frmInteractive = new frmInteractiveBedInformation("","","","","N");
             frmInteractive.ShowDialog();
         }

         private void btnDoctorDutyTiming_Click(object sender, EventArgs e)
         {
             //frmDoctorDutyTiming frmDocDT = new frmDoctorDutyTiming();
             //frmDocDT.ShowDialog();
         }

         private void mnuChangePassword_Click(object sender, EventArgs e)
         {
             frmPasswordReset frm = new frmPasswordReset();
             frm.ShowDialog();
         }

         private void userWidgetMetro1_btnLogout_Clicked(object sender, EventArgs e)
         {
             userWidgetMetro1.Parent.Dispose();
             Utility.isAuthenticated = 0;
             frmLogIn logIn = new frmLogIn("NWMS");
             logIn.atiqsLogInUserControl1.IsPrefilled = false;
             logIn.ShowDialog();
             logIn.atiqsLogInUserControl1.txtUserID.Text = "";
             logIn.atiqsLogInUserControl1.txtPassword.Text = "";
         }

         private void mnuDoctorVisiting_Click(object sender, EventArgs e)
         {
             
         }

         private void mnuIPDRequisition_Click(object sender, EventArgs e)
         {
             frmInteractiveBedInformation frmInteractive = new frmInteractiveBedInformation("","","","","N");
             frmInteractive.ShowDialog();
         }

         private void mnuDemandRequisition_Click(object sender, EventArgs e)
         {
             frmDemandRequisition frmDr = new frmDemandRequisition();
             frmDr.ShowDialog();
         }

         private void mnuReportManager_Click(object sender, EventArgs e)
         {
             frmNWMSReport nsRpt = new frmNWMSReport();
             nsRpt.ShowDialog();

         }

         private void mnuIPDDoctorSetup_Click(object sender, EventArgs e)
         {
            /* frmIPDDoctorSetup frmIDoc = new frmIPDDoctorSetup();
             frmIDoc.ShowDialog();*/
         }

         private void mnuDischargeAdvice_Click(object sender, EventArgs e)
         {
             
         }

         private void mnuSaveDischargeAdvice_Click(object sender, EventArgs e)
         {
             frmIPDDoctorFilter frmIPDPrs = new frmIPDDoctorFilter("D");
             frmIPDPrs.ShowDialog();
         }

         private void mnuEditDischargeAdvice_Click(object sender, EventArgs e)
         {
             frmIPDDoctorFilter frmIPDPrs = new frmIPDDoctorFilter("E");
             frmIPDPrs.ShowDialog();

         }

         private void mnuSaveVisitingDetails_Click(object sender, EventArgs e)
         {
             frmIPDDoctorFilter frmIPDPrs = new frmIPDDoctorFilter("V");
             frmIPDPrs.ShowDialog();
         }

         private void mnuEditVisitingDetails_Click(object sender, EventArgs e)
         {
             frmIPDDoctorFilter frmIPDPrs = new frmIPDDoctorFilter("VE");
             frmIPDPrs.ShowDialog();
         }

    }
}
