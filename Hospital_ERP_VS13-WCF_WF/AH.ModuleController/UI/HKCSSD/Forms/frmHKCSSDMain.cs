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
//using AH.ModuleController.UI.HKCSSD.Reports;
//using AH.ModuleController.UI.ACMS.Forms;

namespace AH.ModuleController.UI.HKCSSD.Forms
{
    public partial class frmHKCSSDMain : Form
    {
        public frmHKCSSDMain()
        {
            InitializeComponent();
        }

        private void frmPatientRegistrationMain_Load(object sender, EventArgs e)
        {
           pnlPatientRegistration.Visible = false;
            //Utility.EnforceSecurity("FNBMIS", menuStrip1, pnlPatientRegistration);
            Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);
           pnlPatientRegistration.Visible = true;
           btnClose.Enabled = true;
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }



        private void btnPatientRegRptManager_Click(object sender, EventArgs e)
        {
            //frmResultEntryFilter resF = new frmResultEntryFilter();
            //resF.ShowDialog();
        }



        private void btnSpecimenCollection_Click(object sender, EventArgs e)
        {
            //frmSpecimenCollection spcColl = new frmSpecimenCollection("S");
            //spcColl.ShowDialog();
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
            //frmReportDelivery rptDelv = new frmReportDelivery();
            //rptDelv.ShowDialog();
        }

        private void btnDiagnosticResultVerification_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCloseModule_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReportManager_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuLabelReprint_Click(object sender, EventArgs e)
        {
           
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
          
        }

        private void userWidgetMetro1_btnLogout_Clicked(object sender, EventArgs e)
        {
            userWidgetMetro1.Parent.Dispose();
            Utility.isAuthenticated = 0;
            frmLogIn logIn = new frmLogIn("FNBMIS");
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
            
        }

        private void btnSpecimenReceive_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReportFinalised_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuGramStain_Click(object sender, EventArgs e)
        {
           
        }

        


       

       

    }
}
