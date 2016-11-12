using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using AH.ModuleController.AccountsMSSR;
using AH.ModuleController.ACMSSR;
using AH.DUtility;
//using AH.Shared.MODEL;


namespace AH.ModuleController.UI.ACMS.Forms
{
    public partial class frmCreateUserGroup : AH.Shared.UI.frmSmartFormStandard
    {
        ACMSSR.ACMSWSClient clnt = new ACMSWSClient();
        public frmCreateUserGroup()
        {
            InitializeComponent();
        }
        UserGroup oUserGroupBO;
        EntryParameter oEntryParameter;
        private void LoadListView()
        {
            lvUserGroup.Items.Clear();
            List<UserGroup> UserGroupBOs = new List<UserGroup>();
            UserGroupBOs = clnt.GetsUserGroups().ToList<UserGroup>();
            foreach (UserGroup fcat in UserGroupBOs)
            {
                ListViewItem itm = new ListViewItem(fcat.GroupID);
                itm.SubItems.Add(fcat.GroupTitle.ToString());
                itm.SubItems.Add(fcat.GroupTitleBang.ToString());
                itm.SubItems.Add(fcat.Remarks.ToString());
                lvUserGroup.Items.Add(itm);
            }
            this.lvUserGroup.View = View.Details;
        }
        private void FormatGrid()
        {
            lvUserGroup.Columns.Add("ID", 100, HorizontalAlignment.Center);
            lvUserGroup.Columns.Add("Group Title", 200, HorizontalAlignment.Center);
            lvUserGroup.Columns.Add("Group Title Bangla", 200, HorizontalAlignment.Left);
            lvUserGroup.Columns.Add("Remarks", 200, HorizontalAlignment.Left);
        }
        private UserGroup PopulateObj()
        {
            oUserGroupBO = new UserGroup();
            oUserGroupBO.GroupID = txtUserGroupID.Text;
            oUserGroupBO.GroupTitle = txtGroupName.Text;
            oUserGroupBO.GroupTitleBang = txtGroupBangla.Text;
            oUserGroupBO.Remarks = txtRemarks.Text;
            oEntryParameter = new EntryParameter();
            oEntryParameter.CompanyID = Utility.CompanyID;
            oEntryParameter.LocationID = Utility.LocationID;
            oEntryParameter.MachineID = Utility.MachineID;
            oEntryParameter.EntryBy = Utility.UserId;
            oUserGroupBO.EntryParameter = oEntryParameter;
            return oUserGroupBO;
        }
        //private void EditObj()
        //{

        //    oUserGroupBO.GroupID = txtUserGroupID.Text;
        //    oUserGroupBO.GroupTitle = txtGroupName.Text;
        //    oUserGroupBO.GroupTitleBang = txtGroupBangla.Text;
        //    oUserGroupBO.Remarks = txtRemarks.Text;
        //}

        private void frmCreateUserGroup_Load(object sender, EventArgs e)
        {
            txtGroupName.Select();
            FormatGrid();
            LoadListView();
            btnSave.Enabled = true;
            btnEdit.Enabled = true;
        }

        private bool EditDelPreRequisit()
        {
            List<string> vf = new List<string>() { "txtGroupName", "txtGroupBangla", "txtUserGroupID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            if (txtUserGroupID.Text == "")
            {
                MessageBox.Show("Plese Select a field to Edit");
                btnNew.PerformClick();
                return false;
            }

            return true;
        }
        private bool SavePreRequisit()
        {
            List<string> vf = new List<string>() { "txtGroupName", "txtGroupBangla"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!SavePreRequisit())
            {
                return;
            }
            if (SavePreRequisit())
            {
                try
                {
                    oUserGroupBO = clnt.SaveUserGroup(PopulateObj());
                     if (oUserGroupBO.EntryParameter.ErrorMessage == "")
                    {
                        LoadListView();
                        btnNew.PerformClick();
                        return;
                    }
                     if (oUserGroupBO.EntryParameter.ErrorMessage != "")
                    {
                        MessageBox.Show(oUserGroupBO.EntryParameter.ErrorMessage.ToString());
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
            btnEdit.Enabled = false;

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (!EditDelPreRequisit())
            {
                return;
            }
            if (EditDelPreRequisit())
            {
                try
                {
                    oUserGroupBO = clnt.EditUserGroup(PopulateObj());
                    if (oUserGroupBO.EntryParameter.ErrorMessage == "")
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListView();
                        btnNew.PerformClick();
                    }
                    if (oUserGroupBO.EntryParameter.ErrorMessage != "")
                    {
                        MessageBox.Show(oUserGroupBO.EntryParameter.ErrorMessage.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void lvUserGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUserGroup.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvUserGroup.SelectedItems[0];
                txtUserGroupID.Text = itm.SubItems[0].Text;
                txtGroupName.Text = itm.SubItems[1].Text;
                txtGroupBangla.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
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
                    oUserGroupBO = clnt.DeleteUserGroup(txtUserGroupID.Text.ToString());
                    if (oUserGroupBO.EntryParameter.ErrorMessage == "")
                    {
                        LoadListView();
                        btnNew.PerformClick();
                    }
                    if (oUserGroupBO.EntryParameter.ErrorMessage != "")
                    {
                        MessageBox.Show(oUserGroupBO.EntryParameter.ErrorMessage.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

        }

        private void lvUserGroup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem itm = lvUserGroup.SelectedItems[0];
            string groupid = itm.SubItems[0].Text;
            string groupname = itm.SubItems[1].Text;
            //frmCreateUser ofrm = new frmCreateUser();
            //ofrm.ReturnValueid = groupid;
            //ofrm.ReturnValuestring = groupname;
            //this.Close();
            //ofrm.Show();
        }

        private void txtGroupName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtGroupBangla.Focus();
            }
        }

        //private void txtGroupBangla_KeyDown(object sender, KeyEventArgs e)
        //{
        //    //txtRemarks.Focus();
        //}

        //private void txtRemarks_KeyDown(object sender, KeyEventArgs e)
        //{
        //    btnSave.Focus();
        //}

        private void txtGroupBangla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRemarks.Focus();
            }
        }

        private void txtRemarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            } 
           // 
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {
            txtGroupBangla.Text = txtGroupName.Text;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

    }
}