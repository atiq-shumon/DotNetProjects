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
using AH.ModuleController.UI.DMS.Reports.ParameterForms;
using AH.ModuleController.UI.ACMS.Forms;
using AH.ModuleController.UI.HR.Forms;
using AH.ModuleController.UI.DMS.Forms;
using AH.ModuleController.UI.INVMS.Forms;
using AH.ModuleController.UI.EPMS.Reports.ParameterForms;
using AH.ModuleController.UI.DRS.Forms;



namespace AH.ModuleController.UI.EPMS.Forms
{
    public partial class frmEPMSMain : Form
    {
        public frmEPMSMain()
        {
            InitializeComponent();
        }

        private void frmEPMSMain_Load(object sender, EventArgs e)
        {
            pnlPatientRegistration.Visible = false;
            Utility.EnforceSecurity("EPMS", menuStrip1, pnlPatientRegistration);
            Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);
            pnlPatientRegistration.Visible = true;
            btnClose.Enabled = true;
           
        }
     
        private void btnReportManager_Click(object sender, EventArgs e)
        {
            frmEmergencyReportManager oEmer = new frmEmergencyReportManager();
            oEmer.ShowDialog();
        }

        private void mnuChangePassword_Click(object sender, EventArgs e)
        {
            frmPasswordReset oPassRes = new frmPasswordReset();
            oPassRes.ShowDialog();
        }

        private void userWidgetMetro1_btnLogout_Clicked(object sender, EventArgs e)
        {
            userWidgetMetro1.Parent.Dispose();
            Utility.isAuthenticated = 0;
            frmLogIn logIn = new frmLogIn("DMSMIS");
            logIn.atiqsLogInUserControl1.IsPrefilled = false;
            logIn.ShowDialog();
            logIn.atiqsLogInUserControl1.txtUserID.Text = "";
            logIn.atiqsLogInUserControl1.txtPassword.Text = "";
        }
       
        private void mnuLeaveRequisition_Click(object sender, EventArgs e)
        {
            frmEmployeeLeaveRequisition oLeaveReq = new frmEmployeeLeaveRequisition();
            oLeaveReq.ShowDialog();
        }

        private void mnuLeaveReqstHead_Click(object sender, EventArgs e)
        {
            frmLeaveRequestListOfHead oReqHead = new frmLeaveRequestListOfHead();
            oReqHead.ShowDialog();
        }

        private void mnuLeaveRegister_Click(object sender, EventArgs e)
        {
            frmEmployeeLeaveRegister oLeaveRegister = new frmEmployeeLeaveRegister();
            oLeaveRegister.ShowDialog();
        }             
        private void mnuDemandRequisiotion_Click_1(object sender, EventArgs e)
        {
            frmDemandRequisition oDemand = new frmDemandRequisition();
            oDemand.ShowDialog();
        }
        private void mnuVeriftDeReq_Click(object sender, EventArgs e)
        {
            frmVerifyRequisition oVerify = new frmVerifyRequisition();
            oVerify.ShowDialog();
        }      
        private void btnEmergencyMR_Click(object sender, EventArgs e)
        {
            frmEmergencyCollectionEntry oEmerBilling = new frmEmergencyCollectionEntry();
            oEmerBilling.ShowDialog();
        }
        private void mnuEmerCollHead_Click(object sender, EventArgs e)
        {
            frmEmeregencyCollectionHead oEmer = new frmEmeregencyCollectionHead();
            oEmer.ShowDialog();
        }

        private void mnuEmergencyBilling_Click(object sender, EventArgs e)
        {
            frmEmergencyCollectionEntry oEmerBilling = new frmEmergencyCollectionEntry();
            oEmerBilling.ShowDialog();
        }

        private void mnuEmergencyReport_Click(object sender, EventArgs e)
        {
            frmEmergencyReportManager oEmer = new frmEmergencyReportManager();
            oEmer.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mnuEmerRegister_Click(object sender, EventArgs e)
        {
            frmEmergencyMaster oEmer = new frmEmergencyMaster();
            oEmer.ShowDialog();
        }

        private void btnEmergencyPatientRegister_Click(object sender, EventArgs e)
        {
            frmEmergencyMaster oEmer = new frmEmergencyMaster();
            oEmer.ShowDialog();
        }

        private void btnEmergencyDiagnosticColl_Click(object sender, EventArgs e)
        {
            frmDiagnosticBilling oDiag = new frmDiagnosticBilling("E");
            oDiag.ShowDialog();
        }

        private void btnEmergencyCollectionPayment_Click(object sender, EventArgs e)
        {
            frmSpecimenCollection oSpecimen = new frmSpecimenCollection("12","E");
            oSpecimen.ShowDialog();
           
        }

        private void mnuEmerCollPayment_Click(object sender, EventArgs e)
        {
            frmEmergencyCollectionPayment oCollPayment = new frmEmergencyCollectionPayment();
            oCollPayment.ShowDialog();
        }
    }
}

