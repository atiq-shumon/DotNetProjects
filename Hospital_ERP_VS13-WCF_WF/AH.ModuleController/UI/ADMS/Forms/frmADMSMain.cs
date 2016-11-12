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
using AH.ModuleController.UI.INVMS.Forms;
using AH.ModuleController.UI.HR.Forms;
using AH.ModuleController.UI.ACMS.Forms;

namespace AH.ModuleController.UI.ADMS.Forms
{
    public partial class frmADMSMain : Form
    {
        public frmADMSMain()
        {
            InitializeComponent();
        }

         private void frmADMSMain_Load(object sender, EventArgs e){

             pnlPatientRegistration.Visible = false;
             Utility.EnforceSecurity("ADMIS", menuStrip1, pnlPatientRegistration);
             Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);
             pnlPatientRegistration.Visible = true;
             btnClose.Enabled = true;
       }

         private void mnuGroupSetup_Click(object sender, EventArgs e)
         {

         }

        

         private void btnCloseModule_Click(object sender, EventArgs e)
         {
             
         }

         private void mnuDemandRequisition_Click(object sender, EventArgs e)
         {
             frmDemandRequisition oDemand = new frmDemandRequisition();
             oDemand.ShowDialog();
         }

         

        

         private void btnClose_Click(object sender, EventArgs e)
         {
             this.Dispose();
         }

         private void mnuDemandRequisitionVerification_Click(object sender, EventArgs e)
         {
             frmVerifyRequisition oVR = new frmVerifyRequisition();
             oVR.ShowDialog();
         }

         private void mnuRptPersonApproval_Click(object sender, EventArgs e)
         {
             frmLeaveRequestListofReportingPerson oLRLR = new frmLeaveRequestListofReportingPerson();
             oLRLR.ShowDialog();
         }

         private void mnuLeaveApprovalDeptHead_Click(object sender, EventArgs e)
         {
             frmLeaveRequestListOfHead oLRLH = new frmLeaveRequestListOfHead();
             oLRLH.ShowDialog();
         }

         private void mnuLeaveRequisition_Click(object sender, EventArgs e)
         {
             frmEmployeeLeaveRequisition oLeaveReq = new frmEmployeeLeaveRequisition();
             oLeaveReq.ShowDialog();
         }

         private void mnuLeaveRegister_Click(object sender, EventArgs e)
         {
             frmEmployeeLeaveRegister oleaveReg = new frmEmployeeLeaveRegister();
             oleaveReg.ShowDialog();
         }

         private void userWidgetMetro1_btnLogout_Clicked(object sender, EventArgs e)
         {
             userWidgetMetro1.Parent.Dispose();
             Utility.isAuthenticated = 0;
             frmLogIn logIn = new frmLogIn("ADMIS");
             logIn.atiqsLogInUserControl1.IsPrefilled = false;
             logIn.ShowDialog();
             logIn.atiqsLogInUserControl1.txtUserID.Text = "";
             logIn.atiqsLogInUserControl1.txtPassword.Text = "";
         }

         private void mnuChangePassword_Click(object sender, EventArgs e)
         {
             frmPasswordReset oPassRes = new frmPasswordReset();
             oPassRes.ShowDialog();
         }

         private void mnuRosterDutyCreate_Click(object sender, EventArgs e)
         {
             frmRosterDutySetup oRoster = new frmRosterDutySetup();
             oRoster.ShowDialog();
         }

         private void mnuRosterDutyView_Click(object sender, EventArgs e)
         {
             frmDisplayRosterDuty oMonthly = new frmDisplayRosterDuty();
             oMonthly.ShowDialog();
         }

        

         
          
    }
}
