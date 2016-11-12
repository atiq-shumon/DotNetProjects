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
using AH.ModuleController;


namespace AH.ModuleController
{
    public partial class frmMainModuleController : Form
    {
        
        public frmMainModuleController()
        {

           
              
               InitializeComponent();
            
          
        }

        

        private void frmMainModuleController_Load(object sender, EventArgs e)
        {


              pnlModuleContainer.Visible = false;
                Utility.CenterObject(pnlModuleContainer);

                //lblDate.Text = DateTime.Today.ToLongDateString();

                frmLabel.Left = pnlModuleContainer.Left + pnlModuleContainer.Width / 3;
                //System.Threading.Thread.Sleep(10000);
                pnlModuleContainer.Visible = true;
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmSmartFormStandard f = new frmSmartFormStandard();
            //f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //f2.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

      


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTopClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pnlModuleContainer_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnPatientRegistrationModule_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.RegMIS.ToString());
        }

        private void btnOutPatientModule_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.OPDMIS.ToString());

        }

        private void btnReceiptionModule_Click(object sender, EventArgs e)
        {
            populateLogIn("Receiption");
        }

        private void populateLogIn(string moduleName)
        {
            try
            {
            frmLogIn login = new frmLogIn(moduleName);
            
            login.atiqsLogInUserControl1.ModuleName = moduleName;
            login.atiqsLogInUserControl1.IsPrefilled = true;
            if (Utility.isAuthenticated == 0)
            {
               
                login.Show();
                
            }
            else
            {
               
            }
            login.atiqsLogInUserControl1.Left = login.Width / 2 - login.atiqsLogInUserControl1.Width/2;
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
            
       }

        private void btnInPatientModule_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.IPDMIS.ToString());
        }

        private void btnPathologyModule_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.DMSMIS.ToString());
        }

        private void btnDRS_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.DRSMIS.ToString());
        }

        private void btnHCMModule_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.HRMMIS.ToString());
        }

        private void btnPRMSModule_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.PRMIS.ToString());
        }

        private void btnMISReports_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.RPTMIS.ToString());
        }

        private void btnSystemAdministrationModule_Click(object sender, EventArgs e)
        {

        }

        private void btnACCMS_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.ACCMS.ToString());
        }

        private void frmMainModuleController_Activated(object sender, EventArgs e)
        {
           // List<DUtility.AccessList> moduels = Utility.AccessLists.GroupBy(x => x.ModuleID).Select(y => y.First()).ToList();

           
            //foreach (string m in Utility.Modules)
            //{
            //    this.Controls.Find(m, true)[0].Enabled = false;

            //}
        }

        private void btnSystemAdmin_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.ACMS.ToString());
        }

        private void btnAdminisrationModule_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.ADMIS.ToString());
        }

        private void btnPharmacyModule_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.PHRMIS.ToString());
        }

        private void btnAppointmentModule_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.APMS.ToString());
        }

        private void frmMainModuleController_Click(object sender, EventArgs e)
        {
           // MenuEnableDisable();
        }


        private void MenuEnableDisable() {
            foreach (string module in Utility.modulesList)
            {
                this.Controls.Find(Utility.GetModuleMapping(module), true)[0].Enabled = false;
            }
            List<string> moduels = Utility.AccessLists.Select(x => x.ModuleID).Distinct().ToList();
            if (moduels.Count > 0)
            {

                foreach (string m in moduels)
                {
                    this.Controls.Find(Utility.GetModuleMapping(m), true)[0].Enabled = true;

                }
            }
        
        }

        private void btnInventoryModule_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.INVMS.ToString());
        }

        private void btnOperationTheatreModule_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.OPRMIS.ToString());
        }

        private void btnRosterDutyModule_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNursingWorkbenchModule_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.NWMS.ToString());
        }

        private void btnATMSModule_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.ATMS.ToString());
        }

        private void btnCanteenModule_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.FnBMS.ToString());
        }

        private void btnDIETModule_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.DIETMIS.ToString());
        }

        private void btnEPMSModule_Click(object sender, EventArgs e)
        {
            populateLogIn(Utility.Module.EPMS.ToString());
        }

    }
}
