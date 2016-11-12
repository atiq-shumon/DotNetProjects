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
using AH.ModuleController.UI.PatientRegistration.Forms;
using AH.ModuleController.UI.OPD.Forms;
using AH.ModuleController.UI.DMS.Forms;
using AH.ModuleController.UI.HR.Forms;
using AH.ModuleController.UI.PRMS.Forms;
using AH.ModuleController.UI.DRS.Forms;
using AH.ModuleController.UI.ACCMS.Forms;
using AH.ModuleController.UI.ACMS.Forms;
using AH.ModuleController.UI.ADMS.Forms;
using AH.ModuleController.UI.PHRMS.Forms;
using AH.ModuleController.UI.APMS.Forms;
using AH.ModuleController.UI.INVMS.Forms;
using AH.ModuleController.UI.OPR.Forms;
using AH.ModuleController.UI.NWMS.Forms;
using AH.ModuleController.UI.ATMS.Forms;
using AH.ModuleController.UI.FNB.Forms;
using AH.ModuleController.UI.DIET.Forms;
using AH.ModuleController.UI.IPD.Forms;
using AH.ModuleController.UI.EPMS.Forms;
using AH.ModuleController.ACMSSR;



//using AH.ModuleController.UI.OPD.Forms;



namespace AH.ModuleController
{
    public partial class frmLogIn : Form
    {
        private string moduleName;
        ACMSSR.ACMSWSClient clnt = new ACMSWSClient();
        public frmLogIn(string moduleName)
        {
            this.moduleName = moduleName;
            if (Utility.isAuthenticated == 1)
            {
                // atiq_s_User_LoginControl1.Parent.Dispose();

                loadForms();
            }
            InitializeComponent();

        }

        //protected override void OnCreateControl()
        //{
        //    //Rectangle screenRect = Screen.GetBounds(Bounds);
        //    //// get the Screen Boundy
        //    //ClientSize = new Size((int)(screenRect.Width / 2),

        //    //(int)(screenRect.Height / 2)); // set the size of the form
        //    //atiqsLogInUserControl1.Location = new
        //    //Point((screenRect.Width / 2 - ClientSize.Width / 2) + 50,

        //    //(screenRect.Height / 2 - ClientSize.Height / 2) + 50); // Center the Location of
        //    base.OnCreateControl();
        //}

        private void Form3_Load(object sender, EventArgs e)
        {



        }



        private void loadForms()
        {
            if (moduleName == Utility.Module.RegMIS.ToString())
            {
                frmPatientRegistrationMain frmMain = new frmPatientRegistrationMain();
                frmMain.ShowDialog();
            }

            if (moduleName == Utility.Module.OPDMIS.ToString())
            {

                frmOPDMain frmMain = new frmOPDMain();
                frmMain.ShowDialog();
            }
            if (moduleName == Utility.Module.DMSMIS.ToString())
            {

                frmDMSMain frmMain = new frmDMSMain();
                frmMain.ShowDialog();
            }
            if (moduleName == Utility.Module.APMS.ToString())
            {

                frmAPMSMain frmMain = new frmAPMSMain();
                frmMain.ShowDialog();
            }
            if (moduleName == Utility.Module.DRSMIS.ToString())
            {

                frmDRSMain frmMain = new frmDRSMain();
                frmMain.ShowDialog();
            }
            if (moduleName == Utility.Module.IPDMIS.ToString())
            {

                frmIPDMain frmMain = new frmIPDMain();
                frmMain.Show();
            }

            if (moduleName == Utility.Module.PRMIS.ToString())
            {

                frmPRMSMain frmMain = new frmPRMSMain();
                frmMain.ShowDialog();
            }
            if (moduleName == Utility.Module.HRMMIS.ToString())
            {

                frmHRMMain frmMain = new frmHRMMain();
                frmMain.ShowDialog();
            }
            if (moduleName == Utility.Module.RPTMIS.ToString())
            {
                //frmMISMain frmMain = new frmMISMain();
                //frmMain.Show();

            }
            if (moduleName == Utility.Module.ACCMS.ToString())
            {
                frmACCMSMain frmMain = new frmACCMSMain();
                frmMain.Show();
            }
            if (moduleName == Utility.Module.ACMS.ToString())
            {
                frmACMSMain frmMain = new frmACMSMain();
                frmMain.Show();
            }
            if (moduleName == Utility.Module.ADMIS.ToString())
            {
                frmADMSMain frmMain = new frmADMSMain();
                frmMain.ShowDialog();
            }
            if (moduleName == Utility.Module.PHRMIS.ToString())
            {
                frmPHRMSMain frmMain = new frmPHRMSMain();
                frmMain.ShowDialog();
            }
            if (moduleName == Utility.Module.INVMS.ToString())
            {
                frmInvMSMain frmMain = new frmInvMSMain();
                frmMain.ShowDialog();
            }
            if (moduleName == Utility.Module.OPRMIS.ToString())
            {
                frmOPRMain frmMain = new frmOPRMain();
                frmMain.ShowDialog();
            }
            if (moduleName == Utility.Module.NWMS.ToString())
            {
                frmNWMSMain frmMain = new frmNWMSMain();
                frmMain.ShowDialog();
            }
            if (moduleName == Utility.Module.ATMS.ToString())
            {
                frmATMSMain frmMain = new frmATMSMain();
                frmMain.ShowDialog();
            }
            if (moduleName == Utility.Module.FnBMS.ToString())
            {
                frmFNBMain frmMain = new frmFNBMain();
                frmMain.ShowDialog();
            }
            if (moduleName == Utility.Module.DIETMIS.ToString())
            {
                frmDIETMain frmMain = new frmDIETMain();
                frmMain.ShowDialog();
            }
            if (moduleName == Utility.Module.EPMS.ToString())
            {
                frmEPMSMain frmMain = new frmEPMSMain();
                frmMain.ShowDialog();
            }
        }

        private void atiqsLogInUserControl1_btnLonIn_Clicked(object sender, EventArgs e)
        {

        }

        private void atiqsLogInUserControl1_btnLogIn_Clicked(object sender, EventArgs e)
        {

        }

        private void atiqsLogInUserControl1_Load(object sender, EventArgs e)
        {

            //if (atiqsLogInUserControl1.IsPrefilled)
            //{
            //    if (moduleName != Utility.Module.INVMS.ToString())
            //    {
            //        atiqsLogInUserControl1.txtUserID.Text = "1000";
            //        atiqsLogInUserControl1.txtPassword.Text = "321";
            //    }

            //}

            atiqsLogInUserControl1.txtModuleName.Text = moduleName;
            Utility.CenterObject(atiqsLogInUserControl1);
        }

        private void atiqsLogInUserControl1_btnLogIn_Clicked_1(object sender, EventArgs e)
        {
            //opdS
            Utility.UserId = atiqsLogInUserControl1.UserID;
            string userId = atiqsLogInUserControl1.UserID;
            string password = atiqsLogInUserControl1.Password;
            atiqsLogInUserControl1.lblMismatch.Text = "Please wait while verifying password";
            try
            {
                User user = clnt.GetUser(userId);
                if (userId != user.EmpID)
                {
                    atiqsLogInUserControl1.lblMismatch.Text = "Invalid User ID!!  Please try again.";
                    atiqsLogInUserControl1.txtUserID.Focus();
                    return;
                }
                if (password == Utility.Decrypt(user.UserPassw, user.EmpID))
                {
                    atiqsLogInUserControl1.lblMismatch.Text = "";
                    Utility.UserName = user.NickName;
                    Utility.UserImageID = user.PhotoPath;
                    Utility.UserDepartID = user.Department.DepartmentID;
                    Utility.UserDepartment = user.Department.DepartmentTitle;
                    Utility.UserDesignationID = user.Designation.DesignationId;
                    Utility.UserUnitID = user.DepartmentUnit.UnitId;
                    Utility.UserDesignation = user.Designation.DesignationTitle;
                    Utility.UserDepartmentGroupID = user.Department.DepartmentGroup.DepartmentGroupID;
                    Utility.UserDepartmentGroupTiitle = user.Department.DepartmentGroup.DepartmentGroupTitle;
                    Utility.CompanyID = "1";
                    Utility.LocationID = "1";
                    Utility.MachineID = Utility.TruncateLongString(Utility.GetMachineName(), 14);
                    Utility.UserUnitID = user.DepartmentUnit.UnitId;
                    Utility.UserUnitTitle = user.DepartmentUnit.UnitTitle;
                    //  Utility.LogInType=user.
                    Utility.isAuthenticated = 1;


                    List<ACMSSR.AccessList> accessList = clnt.GetUserObjectList(userId).ToList();
                    Utility.AccessLists.Clear();
                    foreach (ACMSSR.AccessList l in accessList)
                    {
                        DUtility.AccessList lst = new DUtility.AccessList();
                        lst.ModuleID = l.ModuleID;
                        lst.ObjID = l.ObjID;
                        lst.RoleID = l.RoleID;
                        lst.RoleName = l.RoleName;
                        Utility.AccessAdd(lst);

                    }












                    //List<DUtility.AccessList> listOfY = clnt.GetUserObjectList(userId).Cast<DUtility.AccessList>().ToList();

                    // List<DUtility.AccessList> listOfY = clnt.GetUserObjectList(userId).ToList().ConvertAll(x => x);

                    // Utility.AccessLists = listOfY;
                    //var moduels = Utility.AccessLists.GroupBy(x => x.ModuleID).Select(y => y.First());
                    //foreach (string module in moduels)
                    //{ 
                    //  MessageBox.Show
                    //}
                    // List<Y> listOfY = listOfX.Cast<Y>().ToList()



                    //var moduels = modules.GroupBy(x => x.ModuleID).Select(y => y.First());

                    //()
                    // List<Stock> kitchenAppliances = stock
                    //.Where(item => item.Type == "Kitchen Appliance")
                    //.ToList();

                    //new List<string>() { "btnReceiptionModule", "btnCathlabModule", "btnRadiologyModule", "btnOperationTheatreModule", "btnBloodBankModule" };
                    //  List<string> modules = new List<string>() { Utility.GetModuleMapping("APPMIS") };
                    //, "btnPatientRegistrationModule", "btnAppointmentModule", "btnOutPatientModule"
                    //, "btnInPatientModule", "btnCoronaryCareUnitModule", "btnIncentiveCareUnitModule", "btnCathlabModule", "btnRadiologyModule", "btnOperationTheatreModule", "btnBloodBankModule", "btnDMSModule", "btnPharmacyModule" };
                    //foreach (Module module in modules) Utility.ModuleAdd(Utility.GetModuleMapping(module.ModuleID));

                    //foreach (string m in Utility.Modules)
                    //{
                    //    frmMainModuleController.Controls.Find(m, true)[0].Enabled = false;

                    //}

                    //Utility.ModuleAdd("btnReceiptionModule");
                    ////Utility.ModuleAdd("btnPatientRegistrationModule");
                    //Utility.ModuleAdd("btnAppointmentModule");
                    ////Utility.ModuleAdd("btnOutPatientModule");
                    //Utility.ModuleAdd("btnInPatientModule");
                    atiqsLogInUserControl1.Parent.Dispose();
                    loadForms();
                }
                else
                {
                    //MessageBox.Show("User ID and Password mismatch!!" + Utility.CrLf + "            Please try again.", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    atiqsLogInUserControl1.lblMismatch.Text = "Password mismatch!!  Please try again.";
                    atiqsLogInUserControl1.txtUserID.Focus();
                    return;
                }
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            // CheckDateFormat();
        }


    }

}