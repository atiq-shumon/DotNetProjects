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
using AH.ModuleController.UI.InvMS.Reports.ParameterForms;
using AH.ModuleController.UI.ACMS.Forms;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmInvMSMain : Form
    {
        public frmInvMSMain()
        {
            InitializeComponent();
        }
        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {

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

               private void mnuGroupSetup_Click(object sender, EventArgs e)
        {
            frmGroupSetup ogroup = new frmGroupSetup();
            ogroup.ShowDialog();
        }

        private void mnuSecQ_Click(object sender, EventArgs e)
        {
            //frmCreateSecurityQuestion csq = new frmCreateSecurityQuestion();
            //csq.ShowDialog();
        }

        private void mnuObjSetup_Click(object sender, EventArgs e)
        {
            //frmCreateObject co = new frmCreateObject();
            //co.ShowDialog();
        }

        private void mnuUserSetup_Click(object sender, EventArgs e)
        {
            //frmCreateUser cu = new frmCreateUser();
            //cu.ShowDialog();
        }

        private void mnuAccessControl_Click(object sender, EventArgs e)
        {
            //frmCreateAccessControl cac = new frmCreateAccessControl();
            //cac.ShowDialog();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            //frmACMSReportManager ofrm = new frmACMSReportManager();
            //ofrm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void mnuPanelSetup_Click(object sender, EventArgs e)
        {
            //frmCreateAccessControl ofrm = new frmCreateAccessControl();
            //ofrm.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAccessLevel ofrm = new frmAccessLevel();
            //ofrm.Show();
        }

        private void userModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmGetUserModule ofrmUserModule = new frmGetUserModule();
            //ofrmUserModule.Show();
        }

        private void moduleObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmUserObject ofrmModuleObject = new frmUserObject();
            //ofrmModuleObject.Show();
        }

        private void mnuResetPassword_Click(object sender, EventArgs e)
        {
            //frmPasswordReset ofrmPasswordReset = new frmPasswordReset();
            //ofrmPasswordReset.ShowDialog();   
        }

        private void frmInvMSMain_Load(object sender, EventArgs e)
        {
            pnlPatientRegistration.Visible = false;
            Utility.EnforceSecurity("SCMMS", menuStrip1, pnlPatientRegistration);
            Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);            
            pnlPatientRegistration.Visible = true;
            btnCloseModule.Enabled = true;
        }

        private void mnuSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier osupplier = new frmSupplier();
            osupplier.ShowDialog();
        }

      

        private void mnuItemList_Click(object sender, EventArgs e)
        {
            frmInvMSReportManager oitem = new frmInvMSReportManager();
            oitem.ShowDialog();
        }

        private void mnuStoreLocation_Click(object sender, EventArgs e)
        {
            frmStoreLocation ostore = new frmStoreLocation();
            ostore.ShowDialog();
        }
      

        private void mnuItemRates_Click(object sender, EventArgs e)
        {
            frmItemRates orate = new frmItemRates();
            orate.ShowDialog();
        }

        

        private void mnuIssueRequisition_Click(object sender, EventArgs e)
        {
            frmIssueRequisition oreq = new frmIssueRequisition("O");
            oreq.ShowDialog();
        }

        private void mnuStockDetails_Click(object sender, EventArgs e)
        {
            frmInvMSReportManager oitem = new frmInvMSReportManager();
            oitem.ShowDialog();
        }

        private void mnuProductLedger_Click(object sender, EventArgs e)
        {
            frmInvMSReportManager oitem = new frmInvMSReportManager();
            oitem.ShowDialog();
        }

        private void mnuPOReportDateWise_Click(object sender, EventArgs e)
        {
            frmInvMSReportManager oitem = new frmInvMSReportManager();
            oitem.ShowDialog();
        }

        private void mnuTreeView_Click(object sender, EventArgs e)
        {
            frmTreeView otree = new frmTreeView();
            otree.ShowDialog();
        }

        private void mnuStoreUser_Click(object sender, EventArgs e)
        {
            frmStoreUserSetup ostore = new frmStoreUserSetup();
            ostore.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void mnuDemandRequisition_Click(object sender, EventArgs e)
        {
            frmDemandRequisition odemand = new frmDemandRequisition();
            odemand.ShowDialog();
        }

        private void mnuPurchaseRequisition_Click(object sender, EventArgs e)
        {
            frmPurchaseRequisition oreq = new frmPurchaseRequisition();
            oreq.ShowDialog();
        }

        private void mnuMaterialReceive_Click(object sender, EventArgs e)
        {
            frmMaterialReceive omaterial = new frmMaterialReceive();
            omaterial.ShowDialog();
        }

        private void mnuItemIssue_Click(object sender, EventArgs e)
        {
            frmItemIssue issue = new frmItemIssue("01", "01");
            issue.ShowDialog();
        }

        private void mnuPurchaseOrder_Click(object sender, EventArgs e)
        {
            frmPurchaseOrder opurchase = new frmPurchaseOrder();
            opurchase.ShowDialog();
        }

        

        

        private void mnuCompanySetup_Click(object sender, EventArgs e)
        {
            frmCompanySetup ocompany = new frmCompanySetup();
            ocompany.ShowDialog();
        }

        
        private void mnuUnitSetup_Click(object sender, EventArgs e)
        {
            frmUnitDetails ounit = new frmUnitDetails();
            ounit.ShowDialog();
        }

      

        private void mnuTypeSetup_Click_1(object sender, EventArgs e)
        {
            frmPacketType opack = new frmPacketType();
            opack.ShowDialog();
        }

        private void mnuItemMaster_Click(object sender, EventArgs e)
        {
            frmItemMaster omaster = new frmItemMaster();
            omaster.ShowDialog();
        }

        private void mnuModelSetup_Click(object sender, EventArgs e)
        {
            frmModelSetup omodel = new frmModelSetup();
            omodel.ShowDialog();
        }

        private void mnuBrandSetup_Click(object sender, EventArgs e)
        {
            frmBrandSetup obrand = new frmBrandSetup();
            obrand.ShowDialog();
        }

        private void mnuIssueType_Click(object sender, EventArgs e)
        {
            frmIssueType oissuetype = new frmIssueType();
            oissuetype.ShowDialog();
        }
        private void mnuCostCenter_Click(object sender, EventArgs e)
        {
            frmCostCenter ocost = new frmCostCenter();
            ocost.ShowDialog();
        }

        private void mnuChangePassword_Click(object sender, EventArgs e)
        {
            frmPasswordReset opass = new frmPasswordReset();
            opass.ShowDialog();
        }

        private void mnuOpeningReport_Click(object sender, EventArgs e)
        {
            frmInvMSReportManager orpt = new frmInvMSReportManager();
            orpt.ShowDialog();
        }

        private void mnuMrrReport_Click(object sender, EventArgs e)
        {
            frmInvMSReportManager orpt = new frmInvMSReportManager();
            orpt.ShowDialog();
        }

        private void mnuIssueReport_Click(object sender, EventArgs e)
        {
            frmInvMSReportManager orpt = new frmInvMSReportManager();
            orpt.ShowDialog();
        }

        private void userWidgetMetro1_btnLogout_Clicked(object sender, EventArgs e)
        {
            userWidgetMetro1.Parent.Dispose();
            Utility.isAuthenticated = 0;
            frmLogIn logIn = new frmLogIn("SCMMIS");
            logIn.atiqsLogInUserControl1.IsPrefilled = false;
            logIn.ShowDialog();
            logIn.atiqsLogInUserControl1.txtUserID.Text = "";
            logIn.atiqsLogInUserControl1.txtPassword.Text = "";
        }

        private void mnuDayEndSetup_Click(object sender, EventArgs e)
        {
            frmDayEnd oclose = new frmDayEnd();
            oclose.ShowDialog();
        }

        private void mnuPurchaseReturn_Click(object sender, EventArgs e)
        {
            frmPurchaseReturn oret = new frmPurchaseReturn();
            oret.ShowDialog();
        }

        private void mnuAssetTracking_Click(object sender, EventArgs e)
        {
            frmAssetTracker oasset = new frmAssetTracker("");
            oasset.ShowDialog();
        }

        private void mnuStoreType_Click(object sender, EventArgs e)
        {
            frmStoreType ostoretype = new frmStoreType();
            ostoretype.ShowDialog();
        }

       
        private void mnuIssueReturn_Click(object sender, EventArgs e)
        {
            frmIssueReturn oissuereturn = new frmIssueReturn();
            oissuereturn.ShowDialog();
        }

        

        private void mnuMajorGroup_Click(object sender, EventArgs e)
        {
            frmMajorGroup omajorgrp = new frmMajorGroup();
            omajorgrp.ShowDialog();
        }

        private void mnuTermsandConditions_Click(object sender, EventArgs e)
        {
            frmTermsandCondition oterms = new frmTermsandCondition();
            oterms.ShowDialog();
        }

        private void mnuSubStoreConfiguration_Click(object sender, EventArgs e)
        {
            frmWarehouseConfig owarehouseconfig = new frmWarehouseConfig();
            owarehouseconfig.ShowDialog();
        }

        private void mnuSubStoreType_Click(object sender, EventArgs e)
        {
            frmWarehouseType owarehousetype = new frmWarehouseType();
            owarehousetype.ShowDialog();
        }

       

        private void mnuRequisitionVerify_Click_1(object sender, EventArgs e)
        {
            frmVerifyRequisition overifyreq = new frmVerifyRequisition();
            overifyreq.ShowDialog();
        }

        private void mnuTrackingPrPoMrr_Click(object sender, EventArgs e)
        {
            frmTrackingPrPoMr otrack = new frmTrackingPrPoMr();
            otrack.ShowDialog();
        }

        private void mnuGroupwiseItemList_Click(object sender, EventArgs e)
        {
            frmItemStockList otrackgrpwiseitem = new frmItemStockList();
            otrackgrpwiseitem.ShowDialog();
        }

        private void mnuOpeningEntry_Click(object sender, EventArgs e)
        {
            frmOpeningEntry oentry = new frmOpeningEntry("000000", "01");
            oentry.ShowDialog();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            frmItemIssue obtnissue = new frmItemIssue("01", "01");
            obtnissue.ShowDialog();
        }

        private void btnRequisition_Click(object sender, EventArgs e)
        {
            frmPurchaseRequisition obtnreq = new frmPurchaseRequisition();
            obtnreq.ShowDialog();
        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            frmPurchaseOrder obtnpo = new frmPurchaseOrder();
            obtnpo.ShowDialog();

        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            frmMaterialReceive obtnmrr = new frmMaterialReceive();
            obtnmrr.ShowDialog();
        }

        private void btnCloseModule_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mnuPOModify_Click(object sender, EventArgs e)
        {
            frmPOModify opoedit = new frmPOModify();
            opoedit.ShowDialog();
        }

        private void btnDemandReq_Click(object sender, EventArgs e)
        {
            frmDemandRequisition odr = new frmDemandRequisition();
            odr.ShowDialog();
        }

        private void mnuTransferRequisition_Click(object sender, EventArgs e)
        {
            frmTransferRequisition otr = new frmTransferRequisition();
            otr.ShowDialog();
        }

        private void mnuTransferReceive_Click(object sender, EventArgs e)
        {
            frmTransferReceive otrReceive = new frmTransferReceive();
            otrReceive.ShowDialog();
        }

       

        
       
       
    }
}
