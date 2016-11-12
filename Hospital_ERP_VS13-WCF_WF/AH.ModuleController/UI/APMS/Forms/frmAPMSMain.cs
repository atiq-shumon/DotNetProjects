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

namespace AH.ModuleController.UI.APMS.Forms
{
    public partial class frmAPMSMain : Form
    {
        public frmAPMSMain()
        {
            InitializeComponent();
        }

         private void frmAPMSMain_Load(object sender, EventArgs e){
         
                 pnlPatientRegistration.Visible = false;
                 Utility.EnforceSecurity("APPMIS", menuStrip1, pnlPatientRegistration);
                 Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);
                 pnlPatientRegistration.Visible = true;
                 btnCloseModule.Enabled = true;
          

         }

         //private void mnuGroupSetup_Click(object sender, EventArgs e)
         //{
         //    frmDoctorWeekDays frmDoctorWeekDays = new frmDoctorWeekDays();
         //    frmDoctorWeekDays.ShowDialog();
         //}

         private void sBtnBedFeeSetup_Click(object sender, EventArgs e)
         {
             //frmBedFeeSetup bfee = new frmBedFeeSetup();
             //bfee.ShowDialog();
         }

         private void btnCloseModule_Click(object sender, EventArgs e)
         {
             this.Dispose();
         }



         private void mnuAppointmentRegistration_Click(object sender, EventArgs e)
         {
         
                 frmAppointmentRegis frmAppoint = new frmAppointmentRegis();
                 frmAppoint.ShowDialog();
         
         }

         private void mnuDoctorWeekDays_Click(object sender, EventArgs e)
         {
             //frmDoctorWeekDays frmWeekDays = new frmDoctorWeekDays();
             //frmWeekDays.ShowDialog();
         }

         private void mnuDoctorDutyTiming_Click(object sender, EventArgs e)
         {
               frmCreateDoctorSchedule frmDocDT = new frmCreateDoctorSchedule();
               frmDocDT.ShowDialog();
         
         }

         private void btnAppointmentRegistration_Click(object sender, EventArgs e)
         {         
                 //frmAppoint.ShowDialog();
                 frmAppointmentRegis frmAppoint = new frmAppointmentRegis();
                 frmAppoint.ShowDialog();
           
         }

         private void btnDoctorDutyTiming_Click(object sender, EventArgs e)
         {            
                 frmCreateDoctorSchedule frmDocDT = new frmCreateDoctorSchedule();
                 frmDocDT.ShowDialog();
     
         }

         private void mnuClose_Click(object sender, EventArgs e)
         {
             this.Dispose();
         }

         private void mnuResetPassword_Click(object sender, EventArgs e)
         {
           
                 frmPasswordReset frmPasswordReset = new frmPasswordReset();
                 frmPasswordReset.ShowDialog();
    
         }

         private void newPatientRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
         {
             frmPasswordReset frmPasswordReset = new frmPasswordReset();
             frmPasswordReset.ShowDialog();
         }

         private void userWidgetMetro1_btnLogout_Clicked(object sender, EventArgs e)
         {
             userWidgetMetro1.Parent.Dispose();
             Utility.isAuthenticated = 0;
             frmLogIn logIn = new frmLogIn("APPMIS");
             logIn.atiqsLogInUserControl1.IsPrefilled = false;
             logIn.ShowDialog();
             logIn.atiqsLogInUserControl1.txtUserID.Text = "1000";
             logIn.atiqsLogInUserControl1.txtPassword.Text = "123";
         }

         private void mnuFile_Click(object sender, EventArgs e)
         {

         }

         private void mnuUtility_Click(object sender, EventArgs e)
         {

         }

         private void patientListForHCNToolStripMenuItem_Click(object sender, EventArgs e)
         {
            
                 frmPatientListForHcn frmPatLstHcn = new frmPatientListForHcn();
                 frmPatLstHcn.ShowDialog();
         
         }

         private void mnuPatientInformation_Click(object sender, EventArgs e)
         {
            
                 frmAdmittedPatientList frmAdmittedPatList = new frmAdmittedPatientList();
                 frmAdmittedPatList.ShowDialog();
          
         }

         private void mnuDemandRequisition_Click(object sender, EventArgs e)
         {
    
                 frmDemandRequisition dr = new frmDemandRequisition();
                 dr.ShowDialog();
         

         }

         private void userWidgetMetro1_Load(object sender, EventArgs e)
         {

         }

         private void btnIPDPatientSearch_Click(object sender, EventArgs e)
         {
           
                 frmAdmittedPatientList frmAdmittedPatList = new frmAdmittedPatientList();
                 frmAdmittedPatList.ShowDialog();
   
         }

         private void btnHcnPendingList_Click(object sender, EventArgs e)
         {
           
                 frmPatientListForHcn frmPatLstHcn = new frmPatientListForHcn();
                 frmPatLstHcn.ShowDialog();
         

         }


         //private void mnuFeeCategroy_Click(object sender, EventArgs e)
         //{
         //    frmDoctorVSTcal frm = new frmDoctorVSTcal();
         //    frm.ShowDialog();
         //}

         //private void mnuFeeCategroy_Click(object sender, EventArgs e)
         //{
         //    frmDoctorVSTcal frmDoctorVSTcal = new frmDoctorVSTcal();
         //    frmDoctorVSTcal.ShowDialog();

         //}

         //private void mnuDiagMainSetup_Click(object sender, EventArgs e)
         //{
         //    frmAppointmentVisitReg frmAppVisitReg = new frmAppointmentVisitReg();
         //    frmAppVisitReg.ShowDialog();
         //}
    }
}
