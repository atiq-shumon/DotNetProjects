using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.IPDSR;
using AH.ModuleController.UI.IPD.Reports.ParameterForms;
using AH.ModuleController.UI.ACMS.Forms;
using AH.ModuleController.UI.INVMS.Forms;

namespace  AH.ModuleController.UI.IPD.Forms
{
    public partial class frmIPDMain : Form
    {
        public frmIPDMain()
        {
            InitializeComponent();
        }

        private void frmPatientRegistrationMain_Load(object sender, EventArgs e)
        {
           
                pnlPatientRegistration.Visible = false;
                Utility.EnforceSecurity("IPDMIS", menuStrip1, pnlPatientRegistration);
                Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);

                btnDocVisit.Visible = false;
                btnDiagnosticTest.Visible = false;
                pnlPatientRegistration.Visible = true;
                btnCloseModule.Enabled = true;
         

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void mnuDeliveryType_Click(object sender, EventArgs e)
        {
            frmDeliveryType deltype = new frmDeliveryType();
            deltype.ShowDialog();
        }

        private void mnuOperationType_Click(object sender, EventArgs e)
        {
            //frmOperationType ot = new frmOperationType();
            //ot.ShowDialog();
        }

        private void mnuAdmissionReason_Click(object sender, EventArgs e)
        {
            frmAdmissionReasonSetup admr = new frmAdmissionReasonSetup();
            admr.ShowDialog();
        }

        private void mnuAdmReasonAss_Click(object sender, EventArgs e)
        {
            frmAdmReasonAssign admr = new frmAdmReasonAssign();
            admr.ShowDialog();
        }

        private void mnuGeneralAdmission_Click(object sender, EventArgs e)
        {
            frmAdmission frmAdmission = new frmAdmission("G");
            frmAdmission.ShowDialog();
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
           
                frmAdmission frmAdmssion = new frmAdmission("G");
                frmAdmssion.ShowDialog();

        }

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            frmDischarge frmDC = new frmDischarge("D");
            frmDC.ShowDialog();
        }

        private void mnuAdmissionReferenceSetup_Click(object sender, EventArgs e)
        {
            frmAdmissionRefTypeSetup frmAdmRefSetup = new frmAdmissionRefTypeSetup();
            frmAdmRefSetup.ShowDialog();
        }

        private void btnBedTransfer_Click(object sender, EventArgs e)
        {
            frmBedTransfer frmBT = new frmBedTransfer("B");
            frmBT.ShowDialog();
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            frmAdvancePayment frmAdvance = new frmAdvancePayment("B");
            frmAdvance.ShowDialog();
        }

        private void reportManager_Click(object sender, EventArgs e)
        {         
                frmIPDReportManager frmRM = new frmIPDReportManager();
                frmRM.ShowDialog();
        }

        private void btnDepartmentTransfer_Click(object sender, EventArgs e)
        {

            frmDepartmentTransfer frmDT = new frmDepartmentTransfer("D");
            frmDT.ShowDialog();
        }

        private void btnAdmissionCancellation_Click(object sender, EventArgs e)
        {
            frmAdmissionCancel frmCancel = new frmAdmissionCancel();
            frmCancel.ShowDialog();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPatientDetails_Click(object sender, EventArgs e)
        {
           // frmPatientDetails frm = new frmPatientDetails("D");
                frmAdmittedPatientDetails frm = new frmAdmittedPatientDetails("D");
                frm.ShowDialog();
          
        }

        private void admissionCancelReason_Click(object sender, EventArgs e)
        {
           
                frmCancelReasonSetup frmCanRes = new frmCancelReasonSetup();
                frmCanRes.ShowDialog();
          
        }

        private void btnBedInformation_Click(object sender, EventArgs e)
        {
            //frmBedInformation frmBedInfo = new frmBedInformation();
            //frmBedInfo.ShowDialog();

        }

        private void btnInteractiveBedInfo_Click(object sender, EventArgs e)
        {        
                frmInteractiveBedInformation frmInteractive = new frmInteractiveBedInformation("DeptGroup","Dept", "unitId", "DocID", "I");
                frmInteractive.ShowDialog();     
        }

    
        private void btnPackageAdmission_Click(object sender, EventArgs e)
        {
           
                frmAdmission frmAdmssion = new frmAdmission("P");
                frmAdmssion.ShowDialog();
          
        }

        private void mnuPackageSetup_Click(object sender, EventArgs e)
        {
           
                frmPackageSetup frmPackageSetup = new frmPackageSetup();
                frmPackageSetup.ShowDialog();
          
        }

        private void mnuResetPassword_Click(object sender, EventArgs e)
        {
           
                frmPasswordReset frmPasswordReset = new frmPasswordReset();
                frmPasswordReset.ShowDialog();       
        }

        private void userWidgetMetro1_btnLogout_Clicked(object sender, EventArgs e)
        {
            
                userWidgetMetro1.Parent.Dispose();
                Utility.isAuthenticated = 0;
                frmLogIn logIn = new frmLogIn("IPDMIS");
                logIn.atiqsLogInUserControl1.IsPrefilled = false;
                logIn.ShowDialog();
                logIn.atiqsLogInUserControl1.txtUserID.Text = "1000";
                logIn.atiqsLogInUserControl1.txtPassword.Text = "123";
         

        }

    
        private void mnuAdmittedPatientList_Click(object sender, EventArgs e)
        {
            frmAdmittedPatientList frmAdmittedPatList = new frmAdmittedPatientList();
            frmAdmittedPatList.ShowDialog();
          
        }

        private void mnuBedFeeSetup_Click(object sender, EventArgs e)
        {
           
                frmBedFeeSetup frmBedFeeSetup = new frmBedFeeSetup();
                frmBedFeeSetup.ShowDialog();
           
        }

        private void mnuAdmittedPatientDetails_Click(object sender, EventArgs e)
        {
            
                frmAdmittedPatientDetails frmAdmPatDetails = new frmAdmittedPatientDetails("D");
                frmAdmPatDetails.ShowDialog();       
        }

        private void btnCloseModule_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      
        private void mnuBalanceTransferToAccounts_Click(object sender, EventArgs e)
        {
           
                frmCollectionSendToAccounts frmColl = new frmCollectionSendToAccounts();
                frmColl.ShowDialog();
        }

        private void mnuDemandRequisition_Click(object sender, EventArgs e)
        {
           
                frmDemandRequisition dr = new frmDemandRequisition();
                dr.ShowDialog();
           
        }

      
        private void btnPatDeath_Click(object sender, EventArgs e)
        {
            frmPatientDeath patDeath = new frmPatientDeath();
            patDeath.ShowDialog();
        }

        private void mnuBirthCertificate_Click(object sender, EventArgs e)
        {
            frmChildBirth frmchild = new frmChildBirth();
            frmchild.ShowDialog();
        }

        private void mnuIPDDocSetup_Click(object sender, EventArgs e)
        {
            frmIPDDoctorSetup frm = new frmIPDDoctorSetup();
            frm.ShowDialog();
        }

    } 
}
