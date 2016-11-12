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
using AH.ModuleController.UI.OPR.Reports.ParameterForms;

namespace AH.ModuleController.UI.OPR.Forms
{
    public partial class frmOPRMain : Form
    {
        public frmOPRMain()
        {
            InitializeComponent();
            //timermain.Start();
        }

         private void frmAPMSMain_Load(object sender, EventArgs e){

             Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);
             Utility.EnforceSecurity("OPRMS", menuStrip1, pnlPatientRegistration);
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
             //frmAppointment frmAppoint = new frmAppointment();
             //frmAppoint.ShowDialog();

         }

         private void mnuDoctorWeekDays_Click(object sender, EventArgs e)
         {
             //frmDoctorWeekDays frmWeekDays = new frmDoctorWeekDays();
             //frmWeekDays.ShowDialog();
         }

         private void mnuDoctorDutyTiming_Click(object sender, EventArgs e)
         {
             //frmDoctorDutyTiming frmDocDT = new frmDoctorDutyTiming();
             //frmDocDT.ShowDialog();
         }

         private void btnAppointmentRegistration_Click(object sender, EventArgs e)
         {
             //frmAppointment frmAppoint = new frmAppointment();
             //frmAppoint.ShowDialog();
         }

         private void btnDoctorDutyTiming_Click(object sender, EventArgs e)
         {
             //frmDoctorDutyTiming frmDocDT = new frmDoctorDutyTiming();
             //frmDocDT.ShowDialog();
         }

         private void mnuOprtheater_Click(object sender, EventArgs e)
         {
             //frmOprtheterNew frm = new frmOprtheterNew();
             //frm.ShowDialog();
         }

         private void mnuPanelSetup_Click(object sender, EventArgs e)
         {
             frmOPRGrade frm = new frmOPRGrade();
             frm.ShowDialog();
         }

         private void anestToolStripMenuItem_Click(object sender, EventArgs e)
         {
             frmOPRAnesthesiaGroup frm = new frmOPRAnesthesiaGroup();
             frm.ShowDialog();
         }

         private void anesthesiaMaster_Click(object sender, EventArgs e)
         {
             frmOPRanesthesiaMaster frm = new frmOPRanesthesiaMaster();
             frm.ShowDialog();
         }

         private void opearationMasterToolStripMenuItem_Click(object sender, EventArgs e)
         {
             frmOPRMaster frm = new frmOPRMaster();
             frm.ShowDialog();
         }

         private void bedConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
         {
             frmBedConfiguration frm = new frmBedConfiguration();
             frm.ShowDialog();
         }

       
         private void mnuDoctorsCategory_Click(object sender, EventArgs e)
         {
             frmDoctorsCategoryConfig frm = new frmDoctorsCategoryConfig();
             frm.ShowDialog();
         }

         private void mnuOperationtype_Click(object sender, EventArgs e)
         {
             frmOperationType frm = new frmOperationType();
             frm.ShowDialog();
         }

         private void mnuOperationtheater_Click(object sender, EventArgs e)
         {
             frmOprtheter frm = new frmOprtheter();
             frm.ShowDialog();
         }

            

         private void mnuOTscheduling_Click(object sender, EventArgs e)
         {
         //    frmOTCalender frm = new frmOTCalender("", DateTime.Now.ToString());
         //    frm.ShowDialog();
         }

         private void mnuChecklistItem_Click(object sender, EventArgs e)
         {
             frmChecklistitem frm = new frmChecklistitem();
             frm.ShowDialog();
         }

         private void mnuPatientChecklist_Click(object sender, EventArgs e)
         {
             frmChecklistconfig frm = new frmChecklistconfig();
             frm.ShowDialog();
         }

         private void btnDashBoard_Click(object sender, EventArgs e)
         {
             frmOPRDashboard frm = new frmOPRDashboard();
             frm.ShowDialog();
         }

         private void timermain_Tick(object sender, EventArgs e)
         {
             frmReminder frm = new frmReminder();
             frm.Show();
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
             frmLogIn logIn = new frmLogIn("OPRMS");
             logIn.atiqsLogInUserControl1.IsPrefilled = false;
             logIn.ShowDialog();
             logIn.atiqsLogInUserControl1.txtUserID.Text = "";
             logIn.atiqsLogInUserControl1.txtPassword.Text = "";
         }

         private void mnuPackageItem_Click(object sender, EventArgs e)
         {
             frmPackageItemConfig frm = new frmPackageItemConfig();
             frm.ShowDialog();

         }

         private void mnuPackageConfig_Click(object sender, EventArgs e)
         {
            frmPackageConfiguration frm = new frmPackageConfiguration();
             frm.ShowDialog();
        }

         private void mnuOTmap_Click(object sender, EventArgs e)
         {
             frmOtMap frm = new frmOtMap();
             frm.ShowDialog();
         }

         private void btnOTtheater_Click(object sender, EventArgs e)
         {
             frmOprtheter frm = new frmOprtheter();
             frm.ShowDialog();
         }

         private void btnOtScheduling_Click(object sender, EventArgs e)
         {
             frmOtMap frm = new frmOtMap();
             frm.ShowDialog();
         }

         private void btnDashBoard_Click_1(object sender, EventArgs e)
         {
             frmOPRDashboard frm = new frmOPRDashboard();
             frm.ShowDialog();
         }

         private void mnuDashBoard_Click(object sender, EventArgs e)
         {
             frmOPRDashboard frm = new frmOPRDashboard();
             frm.ShowDialog();
         }

         private void mnuOperationInformation_Click(object sender, EventArgs e)
         {
             frmOPRReportsoperation frm = new frmOPRReportsoperation();
             frm.ShowDialog();
         }

         private void mnuOprInfor_Click(object sender, EventArgs e)
         {
             frmOPRInformation frm = new frmOPRInformation();
             frm.ShowDialog();
         }

         private void mnupackageMaster_Click(object sender, EventArgs e)
         {
             frmOpPackrMaster frm = new frmOpPackrMaster();
             frm.ShowDialog();
         }

         //private void mnuPanelSetup_Click(object sender, EventArgs e)
         //{
         //    frmOPRtheater frm = new frmOPRtheater();
         //    frm.ShowDialog();
         //}

         //private void mnuOprtheater_Click(object sender, EventArgs e)
         //{
         //    frmOPRtheater frm = new frmOPRtheater();
         //    frm.ShowDialog();
         //}
         

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
