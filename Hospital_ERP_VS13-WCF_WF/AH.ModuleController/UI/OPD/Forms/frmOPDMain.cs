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
using AH.ModuleController.UI.OPD.Reports.ParameterForms;
using AH.ModuleController.UI.ACMS.Forms;
using AH.ModuleController.UI.INVMS.Forms;

namespace AH.ModuleController.UI.OPD.Forms
{
    public partial class frmOPDMain : Form
    {
        public frmOPDMain()
        {
            InitializeComponent();
        }

        private void frmOPDMain_Load(object sender, EventArgs e)
        {
            //Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidget1, dateWidget1);
            pnlPatientRegistration.Visible = false;
            Utility.EnforceSecurity("OPDMIS", menuStrip1, pnlPatientRegistration);
            Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidget1, dateWidget1);
            pnlPatientRegistration.Visible = true;
            btnClose.Enabled = true;
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
        private void btnOPDTIcketModule_Click(object sender, EventArgs e)
        {
            frmOPDTicketIssue ti = new frmOPDTicketIssue();
            ti.ShowDialog();
        }
        private void mnuPrescriptionPayment_Click(object sender, EventArgs e)
        {
            frmOPDTicketIssue tktFrm = new frmOPDTicketIssue();
            tktFrm.ShowDialog();
            //frmNursingStationFilter ofrm = new frmNursingStationFilter("T");
            //ofrm.Show();
        }

        //private void btnPatientRegistrationModule_Click(object sender, EventArgs e)
        //{
        //    //frmOPDTicketIssue tktFrm = new frmOPDTicketIssue();
        //    //tktFrm.ShowDialog();
        //    frmNursingStationFilter ofrm = new frmNursingStationFilter("Q");
        //    ofrm.Show();
        //}

        private void btnPatientRegRptManager_Click(object sender, EventArgs e)
        {
            frmPrescription pres = new frmPrescription(Utility.UserDepartID, Utility.UserUnitID, Utility.UserId,"");
            pres.ShowDialog();
        }

        private void mnuInvestigationEntry_Click(object sender, EventArgs e)
        {
            //frmInvestigationEntry inves = new frmInvestigationEntry();
            //inves.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReportManager_Click(object sender, EventArgs e)
        {
            //frmOPDReportManager rmo = new frmOPDReportManager();
            //rmo.ShowDialog();


            frmReportManager ofrm = new frmReportManager();
            ofrm.ShowDialog();
           // frmReportOPDCollection ofrmCollectionReport = new frmReportOPDCollection();
           // ofrmCollectionReport.ShowDialog();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mnuPrescriptionEntry_Click(object sender, EventArgs e)
        {
            frmDoctorFilter df = new frmDoctorFilter();
            df.ShowDialog();
        }

        private void mnuNurseRoomAllocation_Click(object sender, EventArgs e)
        {
          // frmNurseRoomAllocation ofrm = new frmNurseRoomAllocation();
         //  ofrm.Show();
        }

        private void mnuOPDDoctor_Click(object sender, EventArgs e)
        {
            frmOPDDoctor ofrm = new frmOPDDoctor();
            ofrm.Show();
        }
        private void mnuAdvices_Click(object sender, EventArgs e)
        {
            //string advices = "01,10,02,03,04,05,06,07,08,09";
           // frmAdvices oad = new frmAdvices(advices);
          //  oad.ShowDialog();
        }

        private void mnuReportManager_Click(object sender, EventArgs e)
        {
            frmReportManager ofrm = new frmReportManager();
            ofrm.Show();
        }

        private void mnuChangePassword_Click(object sender, EventArgs e)
        {
            frmPasswordReset passReset = new frmPasswordReset();
            passReset.ShowDialog();
        }

        private void userWidget1_btnLogout_Clicked(object sender, EventArgs e)
        {
            userWidget1.Parent.Dispose();
            Utility.isAuthenticated = 0;
            frmLogIn logIn = new frmLogIn("OPDMIS");
            logIn.atiqsLogInUserControl1.IsPrefilled = false;
            logIn.ShowDialog();
            logIn.atiqsLogInUserControl1.txtUserID.Text = "";
            logIn.atiqsLogInUserControl1.txtPassword.Text = "";
            //Utility.PositionCenter(logIn, logIn.atiqsLogInUserControl1, 0);
            //logIn.atiqsLogInUserControl1.Reload();
        }

        private void userWidget1_Load(object sender, EventArgs e)
        {

        }

        private void btnOPDQueue_Click(object sender, EventArgs e)
        {
            frmNursingStationFilter ofrm = new frmNursingStationFilter("Q");
            ofrm.Show();
        }

        private void mnuOPDQueue_Click(object sender, EventArgs e)
        {
            frmNursingStationFilter ofrm = new frmNursingStationFilter("Q");
            ofrm.Show();

        }

        private void mnuCollectedTickets_Click(object sender, EventArgs e)
        {
            frmCollectedTickets ofrm = new frmCollectedTickets();
            ofrm.Show();
        }

        private void mnuTicketRefundCancel_Click(object sender, EventArgs e)
        {
            frmTicketRefundAndCancel ofrm = new frmTicketRefundAndCancel();
            ofrm.Show();
        }

        private void mnuCollectionSendToAccounts_Click(object sender, EventArgs e)
        {
            frmCollectionSendToAccounts ofrm = new frmCollectionSendToAccounts();
            ofrm.Show();
        }

        private void mnuOPDAdvice_Click(object sender, EventArgs e)
        {
            frmAdviceSetup ofrm = new frmAdviceSetup();
            ofrm.ShowDialog();
        }

        private void mnuDiseaseCaseSetup_Click(object sender, EventArgs e)
        {
            frmDiseaseCase discase = new frmDiseaseCase();
            discase.ShowDialog();
        }

        private void mnuComplaintsSetup_Click(object sender, EventArgs e)
        {
            frmComplaints com = new frmComplaints();
            com.ShowDialog();
        }

        private void mnuClinicalDiagnosis_Click(object sender, EventArgs e)
        {
            frmClinicalDiagnosis cd = new frmClinicalDiagnosis();
            cd.ShowDialog();
        }

        private void mnuClinicalFindingsGroupSetup_Click(object sender, EventArgs e)
        {
            frmClinicalFindingsGroup cfGrp = new frmClinicalFindingsGroup();
            cfGrp.ShowDialog();
        }

        private void mnuClinicalFindingsSetup_Click(object sender, EventArgs e)
        {
            frmClinicalFindings cf = new frmClinicalFindings();
            cf.ShowDialog();
        }

        private void mnuClinicalFindingsValueSetup_Click(object sender, EventArgs e)
        {
            frmClinicalFindingsValue cfv = new frmClinicalFindingsValue();
            cfv.ShowDialog();
        }

        private void mnuClinicalFindingsValueAssign_Click(object sender, EventArgs e)
        {
            frmClinicalFindingsValueAssign cfvassign = new frmClinicalFindingsValueAssign();
            cfvassign.ShowDialog();
        }

        private void mnuRoomGroupAssign_Click(object sender, EventArgs e)
        {
            frmRoomGrpAssign rmgGrpAssign = new frmRoomGrpAssign();
            rmgGrpAssign.ShowDialog();
        }

        private void mnuPrescriptionEdit_Click(object sender, EventArgs e)
        {
            frmPrescription prsEdit =new  frmPrescription("E");
            prsEdit.ShowDialog();
        }

        private void mnuDemandRequisition_Click(object sender, EventArgs e)
        {
            frmDemandRequisition frmDr = new frmDemandRequisition();
            frmDr.ShowDialog();
        }

               
    }
}
