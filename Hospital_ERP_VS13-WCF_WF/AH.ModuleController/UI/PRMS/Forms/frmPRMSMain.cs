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

namespace AH.ModuleController.UI.PRMS.Forms
{
    public partial class frmPRMSMain : Form
    {
        public frmPRMSMain()
        {
            InitializeComponent();
        }

        private void frmPRMSMain_Load(object sender, EventArgs e)
        {
            Utility.CenterObject(pnlPatientRegistration);
            //Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);
            //Utility.EnforceSecurity("PRMIS", menuStrip1, pnlPatientRegistration);
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnPatientRegistrationModule_Click(object sender, EventArgs e)
        {
            //frmDiagnosticBilling diagBilling = new frmDiagnosticBilling();
            //diagBilling.Show();

        }

        

      

        private void mnuGroupSetup_Click(object sender, EventArgs e)
        {

        }

        private void mnuDiagDetailSetup_Click(object sender, EventArgs e)
        {
            //frmDiagnosticDetailSetup diagdetsetup = new frmDiagnosticDetailSetup();
            //diagdetsetup.Show();
        }

        private void mnuDiagDetSetup_Click(object sender, EventArgs e)
        {
            //frmDiagnosticFeeSetup diagfeesetup = new frmDiagnosticFeeSetup();
            //diagfeesetup.Show();
        }

        private void mnuDiagMainSetup_Click(object sender, EventArgs e)
        {
            //frmDiagnosticMainSetup diagmainsetup = new frmDiagnosticMainSetup();
            //diagmainsetup.Show();
        }

        private void mnuBedFacilites_Click(object sender, EventArgs e)
        {
            frmBedFacilites bedfac = new frmBedFacilites();
            bedfac.ShowDialog();
        }

        private void mnuBedRates_Click(object sender, EventArgs e)
        {

        }

        private void mnuBedSetup_Click(object sender, EventArgs e)
        {
            frmBedSetup bedsetup = new frmBedSetup();
            bedsetup.ShowDialog();
        }

        private void mnuBedType_Click(object sender, EventArgs e)
        {
            frmBedType bedtype = new frmBedType();
            bedtype.ShowDialog();
        }

        private void mnuWardSetup_Click(object sender, EventArgs e)
        {
            frmWardSetup wardsetup = new frmWardSetup();
            wardsetup.ShowDialog();
        }

        private void mnuRoomSetup_Click(object sender, EventArgs e)
        {
            frmRoomSetup roomsetup = new frmRoomSetup();
            roomsetup.ShowDialog();
        }

        private void mnuRoomType_Click(object sender, EventArgs e)
        {
            frmRoomType roomtype = new frmRoomType();
            roomtype.ShowDialog();
        }

        private void mnuBedFeeSetup_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCloseModule_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnWardSetup_Click(object sender, EventArgs e)
        {
            frmWardSetup wardsetup = new frmWardSetup();
            wardsetup.ShowDialog();
        }

        private void btnRoomSetup_Click(object sender, EventArgs e)
        {
            frmRoomSetup roomsetup = new frmRoomSetup();
            roomsetup.ShowDialog();
        }

        private void btnBedSetup_Click(object sender, EventArgs e)
        {
            frmBedSetup bedsetup = new frmBedSetup();
            bedsetup.ShowDialog();
        }

        private void btnBedFeeSetup_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuNurseStation_Click(object sender, EventArgs e)
        {
            frmNurseStationSetup ons = new frmNurseStationSetup();
            ons.ShowDialog();
        }


    }
}
