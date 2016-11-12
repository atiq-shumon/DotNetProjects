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
using AH.ModuleController.UI.DRS.Reports.ParameterForms;
using AH.ModuleController.UI.ACMS.Forms;
using AH.ModuleController.UI.INVMS.Forms;

namespace AH.ModuleController.UI.DRS.Forms
{
    public partial class frmDRSMain : Form
    {
        public frmDRSMain()
        {
            InitializeComponent();
        }

        private void frmPatientRegistrationMain_Load(object sender, EventArgs e)
        {
           
                pnlPatientRegistration.Visible = false;
                Utility.EnforceSecurity("DRSMIS", menuStrip1, pnlPatientRegistration);
                Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);
                pnlPatientRegistration.Visible = true;
                lblDepartmentID.Text = Utility.UserDepartment;
                btnClose.Enabled = true;
          

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }



        private void btnPatientRegRptManager_Click(object sender, EventArgs e)
        {       
                frmResultEntryFilter resF = new frmResultEntryFilter();
                resF.lblDeptID.Text = lblDepartmentID.Text;
                resF.ShowDialog();
        }



        private void btnSpecimenCollection_Click(object sender, EventArgs e)
        {       
                frmSpecimenCollection spcColl = new frmSpecimenCollection("S","O");
                spcColl.ShowDialog();       
        }

        private void specimenSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmSpecimenSetup spcsetup = new frmSpecimenSetup();
            //spcsetup.ShowDialog();
        }

        private void mnuReportGroup_Click(object sender, EventArgs e)
        {
            //frmReportGroup rptgrp = new frmReportGroup();
            //rptgrp.ShowDialog();
        }

        private void mnuResultHead_Click(object sender, EventArgs e)
        {
            //frmResHead reshd = new frmResHead();
            //reshd.ShowDialog();
        }

        private void mnuResultHeadGroup_Click(object sender, EventArgs e)
        {
            //frmResHeadGroup reshdgrp = new frmResHeadGroup();
            //reshdgrp.ShowDialog();
        }

        private void mnuResultHeadUnit_Click(object sender, EventArgs e)
        {
            //frmResHeadUnit resunit = new frmResHeadUnit();
            //resunit.ShowDialog();
        }

        private void mnuSpecimenCollection_Click(object sender, EventArgs e)
        {
            //frmSpecimenCollection spcColl = new frmSpecimenCollection();
            //spcColl.ShowDialog();
        }

        private void mnuDiagnosticResultEntry_Click(object sender, EventArgs e)
        {
            //frmDiagnosticResultEntry resEntry = new frmDiagnosticResultEntry();
            //resEntry.Show();
        }

        private void mnuSpecimenHolder_Click(object sender, EventArgs e)
        {
            //frmSpecimenHolder spchold = new frmSpecimenHolder();
            //spchold.ShowDialog();
        }

        private void btnReportDelivery_Click(object sender, EventArgs e)
        {
            frmReportDelivery rptDelv = new frmReportDelivery();
            rptDelv.ShowDialog();
        }

        private void btnDiagnosticResultVerification_Click(object sender, EventArgs e)
        {
            //string i = "v";
                //frmResultEntryFilter resF = new frmResultEntryFilter(i);
                //resF.ShowDialog();
                frmVerifiedReport frmVerReport = new frmVerifiedReport("d");
                frmVerReport.lblDeptID.Text = lblDepartmentID.Text;
                frmVerReport.Show();        
        }

        private void btnCloseModule_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReportManager_Click(object sender, EventArgs e)
        {           
                frmDRSReportManager drsMgr = new frmDRSReportManager();
                drsMgr.Show();        
        }

        private void mnuLabelReprint_Click(object sender, EventArgs e)
        {
            frmLabelReprint lblreprint = new frmLabelReprint();
            lblreprint.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //private void mnuResetPassword_Click(object sender, EventArgs e)
        //{
        //    frmPasswordReset frmPasswordReset = new frmPasswordReset();
        //    frmPasswordReset.ShowDialog();
        //}

        private void mnuResetPassword_Click(object sender, EventArgs e)
        {
            frmPasswordReset frmPasswordReset = new frmPasswordReset();
            frmPasswordReset.ShowDialog();
        }

        private void userWidgetMetro1_btnLogout_Clicked(object sender, EventArgs e)
        {
            userWidgetMetro1.Parent.Dispose();
            Utility.isAuthenticated = 0;
            frmLogIn logIn = new frmLogIn("DRSMIS");
            logIn.atiqsLogInUserControl1.IsPrefilled = false;
            logIn.ShowDialog();
            logIn.atiqsLogInUserControl1.txtUserID.Text = "";
            logIn.atiqsLogInUserControl1.txtPassword.Text = "";
        }

        private void mnuSpecimenSetup_Click(object sender, EventArgs e)
        {

        }

        private void mnuSpecimenLabelReceived_Click(object sender, EventArgs e)
        {
            frmSpecimenReceived frmSpcReceived = new frmSpecimenReceived("mode");
            frmSpcReceived.ShowDialog();
        }

        private void btnSpecimenReceive_Click(object sender, EventArgs e)
        {        
                frmSpecimenReceived frmSpcReceived = new frmSpecimenReceived("S");
                frmSpcReceived.ShowDialog();       
        }

        private void btnReportFinalised_Click(object sender, EventArgs e)
        {
 
                frmFinilisedReport frmFinalised = new frmFinilisedReport("r");
                frmFinalised.lblDeptID.Text = lblDepartmentID.Text;
                frmFinalised.ShowDialog();   
        }

        private void mnuGramStain_Click(object sender, EventArgs e)
        {
            //frmStainReportResultEntry frmStain = new frmStainReportResultEntry("Pathology","MicroBiology","Stain Report","0012","0021","0004");
            //frmStain.ShowDialog();
        }

        private void mnuStainReport_Click(object sender, EventArgs e)
        {
            frmStainReportResultEntry frmStain = new frmStainReportResultEntry("Pathology", "MicroBiology", "Stain Report", "0012", "0021", "0004","E");
            frmStain.ShowDialog();
        }

     
        private void mnuStainReportVerification_Click(object sender, EventArgs e)
        {
            frmStainReportResultEntry frmStain = new frmStainReportResultEntry("Pathology", "MicroBiology", "Stain Report", "0012", "0021", "0004", "V");
            frmStain.ShowDialog();
        }

        private void mnuFinaliseStainReport_Click(object sender, EventArgs e)
        {
            frmStainReportResultEntry frmStain = new frmStainReportResultEntry("Pathology", "MicroBiology", "Stain Report", "0012", "0021", "0004", "F");
            frmStain.ShowDialog();
        }

        private void mnuCultureAndSensiRpt_Click(object sender, EventArgs e)
        {
            frmMicroBiologyResultEntry frmMicroBio = new frmMicroBiologyResultEntry("Pathology", "MicroBiology", "Culture and Sensitivity Report", "0012", "0020", "0004", "E");
            frmMicroBio.ShowDialog();

        }

        private void mnuCultAndSensiVerify_Click(object sender, EventArgs e)
        {
            frmMicroBiologyResultEntry frmMicroBio = new frmMicroBiologyResultEntry("Pathology", "MicroBiology", "Culture and Sensitivity Report", "0012", "0020", "0004", "V");
            frmMicroBio.ShowDialog();
        }

        private void mnuCultAndSenFinal_Click(object sender, EventArgs e)
        {
            frmMicroBiologyResultEntry frmMicroBio = new frmMicroBiologyResultEntry("Pathology", "MicroBiology", "Culture and Sensitivity Report", "0012", "0020", "0004", "F");
            frmMicroBio.ShowDialog();
        }

        private void mnuCulAndSensiGrowthEntry_Click(object sender, EventArgs e)
        {
            frmMicroBiologyResultEntry frmMicroBio = new frmMicroBiologyResultEntry("Pathology", "MicroBiology", "Culture and Sensitivity Report", "0012", "0020", "0004", "E");
            frmMicroBio.ShowDialog();
        }

        private void mnuCulAndSensiGrowthVeri_Click(object sender, EventArgs e)
        {
            frmMicroBiologyResultEntry frmMicroBio = new frmMicroBiologyResultEntry("Pathology", "MicroBiology", "Culture and Sensitivity Report", "0012", "0020", "0004", "V");
            frmMicroBio.ShowDialog();
        }

        private void mnuCulAndSensiGrowthFinal_Click(object sender, EventArgs e)
        {
            frmMicroBiologyResultEntry frmMicroBio = new frmMicroBiologyResultEntry("Pathology", "MicroBiology", "Culture and Sensitivity Report", "0012", "0020", "0004", "F");
            frmMicroBio.ShowDialog();
        }

        private void btnBulkReportPrint_Click(object sender, EventArgs e)
        {         
                frmBulkReportPrint frmBulkRptPrint = new frmBulkReportPrint();
                frmBulkRptPrint.lblDeptID.Text = lblDepartmentID.Text;
                frmBulkRptPrint.ShowDialog();
        
        }

        private void mnuUserReportAccess_Click(object sender, EventArgs e)
        {
            frmUserAccess frmUserAccess = new frmUserAccess();         
            frmUserAccess.ShowDialog();
        }

        private void mnuPrintingInterface_Click(object sender, EventArgs e)
        {
            frmReportPrintInterface frmPrint = new frmReportPrintInterface();
            frmPrint.ShowDialog();
        }

        private void mnuDemandRequisition_Click(object sender, EventArgs e)
        {
            frmDemandRequisition DR = new frmDemandRequisition();
            DR.ShowDialog();
        }

        private void mnuSampleCancellation_Click(object sender, EventArgs e)
        {
            frmSpecimenCancellation frmCan = new frmSpecimenCancellation();
            frmCan.ShowDialog();
        }

        private void btnReportPrint_Click(object sender, EventArgs e)
        {  
                frmReportPrintInterface frmPrint = new frmReportPrintInterface();
                frmPrint.ShowDialog();       

        }

        private void mnuPrintWorkSheet_Click(object sender, EventArgs e)
        {
            frmWorkSheet frmWorkSheet = new frmWorkSheet("w");
            frmWorkSheet.lblDeptID.Text = lblDepartmentID.Text;
            frmWorkSheet.ShowDialog();
        }

        private void mnuPrintPatientLabel_Click(object sender, EventArgs e)
        {
            frmPrintPatientLabel frmPrint = new frmPrintPatientLabel();
            frmPrint.ShowDialog();
        }

        private void mnuMrLifeCycle_Click(object sender, EventArgs e)
        {
            frmMoneyReceiptLifeCycle frmLifeCycle = new frmMoneyReceiptLifeCycle("D");
            frmLifeCycle.ShowDialog();
        }

    }
}
