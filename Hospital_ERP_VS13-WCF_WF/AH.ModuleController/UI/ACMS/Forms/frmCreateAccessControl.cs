using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using AH.ModuleController.AccountsMSSR;
using AH.ModuleController.ACMSSR;
using AH.DUtility;


namespace AH.ModuleController.UI.ACMS.Forms
{
    public partial class frmCreateAccessControl : AH.Shared.UI.frmSmartFormStandard
    {
        ACMSSR.ACMSWSClient clnt = new ACMSWSClient();
        public frmCreateAccessControl()
        {
            InitializeComponent();
        }
        AccessControl oAccessControlBO = new AccessControl();
        EntryParameter oEntryParameter = new EntryParameter();
        private void LoadUserGroupCombo()
        {
            List<UserGroup> oUserGroupBOs = new List<UserGroup>();
            oUserGroupBOs = clnt.GetsUserGroupCbo().ToList();
            cboUserGroup.DataSource = oUserGroupBOs;
            cboUserGroup.DisplayMember = "GroupTitle";
            cboUserGroup.ValueMember = "GroupID";
        }

        private void LoadUserCombo()
        {
            List<User> oUserBOs = new List<User>();
            oUserBOs = clnt.GetUsersCbo().ToList();
            cboEmpName.DataSource = oUserBOs;
            cboEmpName.DisplayMember = "NickName";
            cboEmpName.ValueMember = "EmpID";
        }
        private void LoadObject()
        {
            List<ObjectSetup> oObjectSetupBOs = new List<ObjectSetup>();
            oObjectSetupBOs = clnt.GetsObjectSetupCbo().ToList();
            cboObject.DataSource = oObjectSetupBOs;
            cboObject.DisplayMember = "ObjName";
            cboObject.ValueMember = "OBJID";
        }
        private void LoadListView()
        {
            lvAccControl.Items.Clear();
            List<AccessControl> oAccessControlBOs = new List<AccessControl>();
            oAccessControlBOs = clnt.GetsAccessControl().ToList();
            foreach (AccessControl fcat in oAccessControlBOs)
            {
                //ListViewItem itm = new ListViewItem(fcat.EmpID);
                //itm.SubItems.Add(fcat.ModuleID.ToString());
                //itm.SubItems.Add(fcat.ObjID.ToString());
                //itm.SubItems.Add(fcat.GrpID.ToString());
                //itm.SubItems.Add(fcat.NickName.ToString());
                //itm.SubItems.Add(fcat.AuthenticationLevel.ToString());
                //itm.SubItems.Add(fcat.Remarks.ToString());
                //lvAccControl.Items.Add(itm);
            }
            this.lvAccControl.View = View.Details;
        }

        private void FormatGrid()
        {
            lvAccControl.Columns.Add("Emp ID", 100, HorizontalAlignment.Center);
            lvAccControl.Columns.Add("Module", 100, HorizontalAlignment.Center);
            lvAccControl.Columns.Add("Obj Name", 100, HorizontalAlignment.Center);
            lvAccControl.Columns.Add("Group", 100, HorizontalAlignment.Center);
            lvAccControl.Columns.Add("Nick Name", 150, HorizontalAlignment.Center);
            lvAccControl.Columns.Add("Authentication Level", 100, HorizontalAlignment.Center);
            lvAccControl.Columns.Add("Remarks", 100, HorizontalAlignment.Center);
        }

        private void LoadModule()
        {
            cboModule.ValueMember = "Key";
            cboModule.DisplayMember = "Value";
            cboModule.DataSource = new BindingSource(Utility.GetModuleNames(), null);
        }
        private void LoadAuthenticationLevel()
        {
            cboAuthLevel.ValueMember = "Key";
            cboAuthLevel.DisplayMember = "Value";
            cboAuthLevel.DataSource = new BindingSource(Utility.GetAuthenticationLevels(), null);
        }
        private void frmCreateAccessControl_Load(object sender, EventArgs e)
        {
            LoadUserGroupCombo();
            LoadUserCombo();
            LoadObject();
            LoadListView();
            FormatGrid();
            LoadModule();
            LoadAuthenticationLevel();
        }
        private AccessControl PopulateObject()
        {
            User oUser = new User();
            oUser.EmpID = cboEmpName.SelectedValue.ToString();;
            oAccessControlBO.User = oUser;

            Module oModule = new Module();
            oModule.ModuleID  = cboModule.SelectedValue.ToString();  
            oAccessControlBO.Module = oModule;

            UserGroup oUsGrp = new UserGroup();
            oUsGrp.GroupID = cboUserGroup.SelectedValue.ToString();
            oAccessControlBO.UserGroup = oUsGrp;

            ObjectSetup oObSet = new ObjectSetup();
            oObSet.ObjID = cboObject.SelectedValue.ToString();  
            oAccessControlBO.ObjectSetup = oObSet;

            oAccessControlBO.AuthenticationLevel = Convert.ToInt16(cboAuthLevel.SelectedValue.ToString());
            oAccessControlBO.Remarks = txtRemarks.Text;
            EntryParameter oEP = new EntryParameter();
            oEP.CompanyID = Utility.CompanyID;
            oEP.LocationID = Utility.LocationID;
            oEP.MachineID = Utility.MachineID;
            oEP.EntryBy = Utility.UserId;
            oAccessControlBO.EntryParameter = oEP;
            return oAccessControlBO;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            oAccessControlBO = clnt.SaveAccessControl(PopulateObject());
            if (oAccessControlBO.ErrorMessage == "")
            {
                LoadListView();
                LoadUserGroupCombo();
                LoadUserCombo();
            }
            if (oAccessControlBO.ErrorMessage != "")
            {
                MessageBox.Show(oAccessControlBO.ErrorMessage.ToString());
            }
        }

        private bool EditDelPreRequisit()
        {
            List<string> vf = new List<string>() { "txtEmpID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            if (txtEmpID.Text == "")
            {
                MessageBox.Show("Plese Select a field to Edit");
                btnNew.PerformClick();
                return false;
            }

            return true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!EditDelPreRequisit())
            {
                return;
            }
            if (EditDelPreRequisit())
            {
                try
                {
                    oAccessControlBO = clnt.DeleteAccessControl(txtEmpID.Text.ToString());
                    if (oAccessControlBO.ErrorMessage == "")
                    {
                        LoadListView();
                        //maketextempty();

                    }
                    if (oAccessControlBO.ErrorMessage != "")
                    {
                        MessageBox.Show(oAccessControlBO.ErrorMessage.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void lvAccControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAccControl.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvAccControl.SelectedItems[0];
                txtEmpID.Text = itm.SubItems[0].Text;
                cboModule.Text = itm.SubItems[1].Text;
                cboObject.Text = itm.SubItems[2].Text;
                cboUserGroup.Text = itm.SubItems[3].Text;
                cboEmpName.Text = itm.SubItems[4].Text;
                //cboALevel.Text = itm.SubItems[5].Text;
                txtRemarks.Text = itm.SubItems[6].Text;
            }
        }

        private void EditObj()
        {
            //oAccessControlBO.EmpID = cboEmpName.SelectedValue.ToString();
            //oAccessControlBO.GrpID = cboUserGroup.SelectedValue.ToString();
            //oAccessControlBO.ObjID = cboObject.SelectedValue.ToString();
            //oAccessControlBO.ModuleID = cboModule.Text.ToString();
            ////oAccessControlBO.AuthenticationLevel = Convert.ToInt16(cboALevel.Text);
            oAccessControlBO.Remarks = txtRemarks.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (!EditDelPreRequisit())
            //{
            //    return;
            //}
            //if (EditDelPreRequisit())
            //{
            //    try
            //    {
            //        EditObj();
            //        oAccessControlBO = new AccessControlBL().EditAccessControl(oAccessControlBO);
            //        if (oAccessControlBO.ErrorMessage == "")
            //        {
            //            LoadListView();
            //           // maketextempty();
            //        }
            //        if (oAccessControlBO.ErrorMessage != "")
            //        {
            //            MessageBox.Show(oAccessControlBO.ErrorMessage.ToString());
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //}
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
