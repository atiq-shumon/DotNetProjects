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
using AH.ModuleController.UI.INVMS.Forms;
using AH.ModuleController.UI.EPMS.Forms;



namespace AH.ModuleController.UI.DMS.Forms
{
    public partial class frmDMSMain : Form
    {
        public frmDMSMain()
        {
            InitializeComponent();
        }

        private void frmPatientRegistrationMain_Load(object sender, EventArgs e)
        {
            pnlPatientRegistration.Visible = false;
            Utility.EnforceSecurity("DMSMIS", menuStrip1, pnlPatientRegistration);
            Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);
            pnlPatientRegistration.Visible = true;
            btnClose.Enabled = true;
           
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnPatientRegistrationModule_Click(object sender, EventArgs e)
        {
            frmDiagnosticBilling diagBilling = new frmDiagnosticBilling("O");
            diagBilling.ShowDialog();

        }

        private void mnuGroupSetup_Click(object sender, EventArgs e)
        {
            frmDiagnosticGroupSetup grpSetup = new frmDiagnosticGroupSetup();
            grpSetup.ShowDialog();
        }

        private void mnuDiagDetailSetup_Click(object sender, EventArgs e)
        {
            frmDiagnosticDetailSetup diagdetsetup = new frmDiagnosticDetailSetup();
            diagdetsetup.ShowDialog();
        }

        private void mnuDiagDetSetup_Click(object sender, EventArgs e)
        {
            frmDiagnosticTestFeeSetup diagfeesetup = new frmDiagnosticTestFeeSetup();
            //frmDiagnosticFeeSetup diagfeesetup = new frmDiagnosticFeeSetup();
            diagfeesetup.ShowDialog();
        }

        private void mnuDiagMainSetup_Click(object sender, EventArgs e)
        {
            frmDiagnosticMainSetup diagmainsetup = new frmDiagnosticMainSetup();
            diagmainsetup.ShowDialog();
        }

        private void mnuPanelSetup_Click(object sender, EventArgs e)
        {
            frmPanelSetup pnlsetup = new frmPanelSetup();
            pnlsetup.ShowDialog();
        }

        private void mnuTestCategorySetup_Click(object sender, EventArgs e)
        {
            frmCategorySetup catObj = new frmCategorySetup();
            catObj.ShowDialog();
        }

        private void mnuFeeCategroy_Click(object sender, EventArgs e)
        {
            frmFeeCategory feeCatObj = new frmFeeCategory();
            feeCatObj.ShowDialog();
        }

        private void btnIPDDMR_Click(object sender, EventArgs e)
        {
            frmEmergencyCollectionPayment oEmer = new frmEmergencyCollectionPayment();
            oEmer.ShowDialog();
        }

        private void btnOutCaseDMR_Click(object sender, EventArgs e)
        {
            frmDiagnosticBilling diagBilling = new frmDiagnosticBilling("X");
            diagBilling.ShowDialog();
        }

        private void btnSeftDMR_Click(object sender, EventArgs e)
        {
            frmDiagnosticBilling diagBilling = new frmDiagnosticBilling("S");
            diagBilling.ShowDialog();
        }

        private void mnuDiagTestAssociation_Click(object sender, EventArgs e)
        {
            frmDiagTestAssociation diagTestAss = new frmDiagTestAssociation();
            diagTestAss.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReportManager_Click(object sender, EventArgs e)
        {
            frmDMSReportManager dmsRpt = new frmDMSReportManager();
            dmsRpt.ShowDialog();
        }

        private void specimenSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSpecimenSetup spSetup = new frmSpecimenSetup();
            spSetup.ShowDialog();
        }

        private void reportGroupSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportGroup rg = new frmReportGroup();
            rg.ShowDialog();
        }

        private void panelTestAssociationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPanelTestAssociation ofrm = new frmPanelTestAssociation();
            ofrm.ShowDialog();
        }

        private void mnuResultHeadGroup_Click(object sender, EventArgs e)
        {
            frmResHeadGroup rsHdgrp = new frmResHeadGroup();
            rsHdgrp.ShowDialog();
        }

        private void mnuResultHead_Click(object sender, EventArgs e)
        {
            frmResHead hd = new frmResHead();
            hd.ShowDialog();
        }   
        private void mnuTestCancelCause_Click(object sender, EventArgs e)
        {
            frmTestCancelCause ofrm = new frmTestCancelCause();
            ofrm.ShowDialog();
        }
        private void mnuReport_Click(object sender, EventArgs e)
        {
            frmDMSReportManager ofrm = new frmDMSReportManager();
            ofrm.ShowDialog();
        }

        private void mnuChangePassword_Click(object sender, EventArgs e)
        {
            frmPasswordReset oPassRes = new frmPasswordReset();
            oPassRes.ShowDialog();
        }

        private void mnuOPDDMR_Click(object sender, EventArgs e)
        {
            frmDiagnosticBilling diagBilling = new frmDiagnosticBilling("O");
            diagBilling.ShowDialog();
        }

        private void mnuIPDDMR_Click(object sender, EventArgs e)
        {
            frmDiagnosticBilling diagBilling = new frmDiagnosticBilling("I");
            diagBilling.ShowDialog();
        }

        private void mnuOutCaseDMR_Click(object sender, EventArgs e)
        {
            frmDiagnosticBilling diagBilling = new frmDiagnosticBilling("X");
            diagBilling.ShowDialog();
        }

        private void mnuSelfDMR_Click(object sender, EventArgs e)
        {
            frmDiagnosticBilling diagBilling = new frmDiagnosticBilling("S");
            diagBilling.ShowDialog();
        }

        private void mnuDuePayment_Click(object sender, EventArgs e)
        {
            frmDuePayment ofrm = new frmDuePayment();
            ofrm.ShowDialog();
        }

        private void mnuTestCancel_Click(object sender, EventArgs e)
        {
            frmTestCancel ofrm = new frmTestCancel();
            ofrm.ShowDialog();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void mnuMachineSetup_Click(object sender, EventArgs e)
        {
            frmMachineSetup oMac = new frmMachineSetup();
            oMac.ShowDialog();
        }

        private void mnuQualitativeGroupSetup_Click(object sender, EventArgs e)
        {
            frmQualitativeGroupSetup oQuaGrp = new frmQualitativeGroupSetup();
            oQuaGrp.ShowDialog();
        }

        private void mnuMethodSetup_Click(object sender, EventArgs e)
        {
            frmMethodSetup oMet = new frmMethodSetup();
            oMet.ShowDialog();
        }

        private void mnuColorCodeSetup_Click(object sender, EventArgs e)
        {
            frmColorCodeSetup oCol = new frmColorCodeSetup();
            oCol.ShowDialog();
        }

        private void mnuSpcHol_Click(object sender, EventArgs e)
        {
            frmSpecimenHolder oSpc = new frmSpecimenHolder();
            oSpc.ShowDialog();
        }

        private void mnuReportSectionSetup_Click(object sender, EventArgs e)
        {
            frmReportSection orptsec = new frmReportSection();
            orptsec.ShowDialog();
        }

        private void mnuQualitativeGroupDet_Click(object sender, EventArgs e)
        {
            frmQualitativeDetailsSetup ofrm = new frmQualitativeDetailsSetup();
            ofrm.ShowDialog();
        }

        private void mnuTestMapping_Click(object sender, EventArgs e)
        {
            frmResultHeadMappingWithTest ofrm = new frmResultHeadMappingWithTest();
            //frmTestReasultHeadMap ofrm = new frmTestReasultHeadMap();
            ofrm.ShowDialog();
        }

        private void mnuAccountsPayment_Click(object sender, EventArgs e)
        {
            frmAccountsCollection oAcc = new frmAccountsCollection();
            oAcc.ShowDialog();
        }

        private void mnuTestRefund_Click(object sender, EventArgs e)
        {
            frmTestRefundSetup oTestRefund = new frmTestRefundSetup();
            oTestRefund.ShowDialog();
        }

        private void mnuRefundCause_Click(object sender, EventArgs e)
        {
            frmRefundCauseSetup oRefundCause = new frmRefundCauseSetup();
            oRefundCause.ShowDialog();
        }

        private void mnuTestMapLabel_Click(object sender, EventArgs e)
        {
            frmTestLabelAssociation oTestLabel = new frmTestLabelAssociation();
            oTestLabel.ShowDialog();
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

        private void mnuReffOrgSetup_Click(object sender, EventArgs e)
        {
            frmReffdOrgSetup oReffOrg = new frmReffdOrgSetup();
            oReffOrg.ShowDialog();
        }

        private void mnuReffdDocSetup_Click(object sender, EventArgs e)
        {
            frmReffdDocSetup oReffDoc = new frmReffdDocSetup();
            oReffDoc.ShowDialog();
        }

        private void mnuCollStateSummary_Click(object sender, EventArgs e)
        {
            frmCollectionStatementsSummary oColl = new frmCollectionStatementsSummary();
            oColl.ShowDialog();
        }

        private void mnuDMSCollection_Click(object sender, EventArgs e)
        {
            frmDMSCollectionReport oCollection = new frmDMSCollectionReport();
            oCollection.ShowDialog();
        }

        private void btnDuePayment_Click(object sender, EventArgs e)
        {
            frmDuePayment ofrm = new frmDuePayment();
            ofrm.ShowDialog();
        }

        private void btnTestCancel_Click(object sender, EventArgs e)
        {
            frmTestCancel ofrm = new frmTestCancel();
            ofrm.ShowDialog();
        }

        private void btnTestRefund_Click(object sender, EventArgs e)
        {
            frmTestRefundSetup oTestRefund = new frmTestRefundSetup();
            oTestRefund.ShowDialog();
        }

        private void mnuDemandRequisiotion_Click(object sender, EventArgs e)
        {
            frmDemandRequisition oDemand = new frmDemandRequisition();
            oDemand.ShowDialog();
        }

        private void mnuDemandRequisiotion_Click_1(object sender, EventArgs e)
        {
            frmDemandRequisition oDemand = new frmDemandRequisition();
            oDemand.ShowDialog();
        }

        private void mnuDiagPackageSetup_Click(object sender, EventArgs e)
        {
            frmDiagPackageMaster oDiag = new frmDiagPackageMaster();
            oDiag.ShowDialog();
        }

        private void mnuDiagPkgFeeSetup_Click(object sender, EventArgs e)
        {
            frmDiagnosticPackageFeeSetup oDiagFee = new frmDiagnosticPackageFeeSetup();
            oDiagFee.ShowDialog();
        }

        private void mnuVeriftDeReq_Click(object sender, EventArgs e)
        {
            frmVerifyRequisition oVerify = new frmVerifyRequisition();
            oVerify.ShowDialog();
        }

        private void mnuEmerCollHead_Click(object sender, EventArgs e)
        {
            frmEmeregencyCollectionHead oEmer = new frmEmeregencyCollectionHead();
            oEmer.ShowDialog();
        }

        private void mnuEmergencyDMR_Click(object sender, EventArgs e)
        {
            frmEmergencyBilling oEmer = new frmEmergencyBilling();
            oEmer.ShowDialog();
        }    
      
    }
}

