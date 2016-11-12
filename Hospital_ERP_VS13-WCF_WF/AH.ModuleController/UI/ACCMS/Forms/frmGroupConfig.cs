using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.AccountsMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.ACCMS.Forms
{
    public partial class frmGroupConfig : AH.Shared.UI.frmSmartFormStandard
    {
        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();
        public string strUnder { set; get; }
        public string strindex {set;get;}
        public string strMode { set; get; }

        List<GroupsConfig> grp;

        public frmGroupConfig()
        {
            InitializeComponent();
        }
        #region "Listview"
        private void LoadModule()
        {
            cboUnder.ValueMember = "Key";
            cboUnder.DisplayMember = "Value";
            cboUnder.DataSource = new BindingSource(accmSc.GetGroups("D"), null);
            lstLedger.ValueMember = "Key";
            lstLedger.DisplayMember = "Value";
            lstLedger.DataSource = new BindingSource(accmSc.GetGroups("D"), null);
        
        }
        private void FormatGrid()
        {
            lvwGroupList.CheckBoxes = false;
            lvwGroupList.Columns.Add("Serial No", 0, HorizontalAlignment.Center);
            lvwGroupList.Columns.Add("Group Name", 280, HorizontalAlignment.Left);
            lvwGroupList.Columns.Add("Group Parent", 290, HorizontalAlignment.Left);
            lvwGroupList.Columns.Add("Default Name", 290, HorizontalAlignment.Left);
            lvwGroupList.Columns.Add("Gr Level", 0, HorizontalAlignment.Left);
            lvwGroupList.Columns.Add("Default Group", 0, HorizontalAlignment.Left);
            lvwGroupList.Columns.Add("CashFlowType", 0, HorizontalAlignment.Left);
            lvwGroupList.Columns.Add("Primary Type", 0, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvwGroupList.Items.Clear();

            grp = accmSc.GetGroupsConfiguration().ToList();
            int i = 0;
            foreach (GroupsConfig grps in grp)
            {
                ListViewItem itm = new ListViewItem(grps.Lngsllno.ToString());
                itm.SubItems.Add(grps.GrName);
                itm.SubItems.Add(grps.GrParent);
                if (grps.GrDefaultName != "")
                {
                    itm.SubItems.Add(grps.GrDefaultName);
                }
                else
                {
                    itm.SubItems.Add("");
                }
                if (grps.Grlevel.ToString() != "")
                {
                    itm.SubItems.Add(grps.Grlevel.ToString());
                }
                else
                {
                    itm.SubItems.Add("");
                }
                if (grps.GrDefaultgroup.ToString() != "")
                {
                    itm.SubItems.Add(grps.GrDefaultgroup.ToString());
                }
                else
                {
                    itm.SubItems.Add("");
                }
                if (grps.GrCashFlow.ToString() != "")
                {
                    itm.SubItems.Add(grps.GrCashFlow.ToString());
                }
                else
                {
                    itm.SubItems.Add("");
                }
                if (grps.GrPrimaryType.ToString() != "")
                {
                    itm.SubItems.Add(grps.GrPrimaryType.ToString());
                }
                else
                {
                    itm.SubItems.Add("");
                }
                lvwGroupList.Items.Add(itm);
            }
        }
        #endregion
        #region "Populated"
        private GroupsConfig PopulateGroups()
        {
            GroupsConfig objgroups = new GroupsConfig();
            objgroups.GrName = txtGroupName.Text;
            objgroups.GrUnder = cboUnder.Text;
            objgroups.GrNature = cboNature.Text;
            objgroups.GrCashFlow = cboCashFlowType.Text;
            if (txtSlNo.Text != "")
            {
                objgroups.Lngsllno = long.Parse(txtSlNo.Text);
            }

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objgroups.EntryParameter = ep;
            return objgroups;
        }
        #endregion
        #region "Validation"
        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "txtGroupName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            if (cboUnder.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboUnder.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboUnder.Focus();
                return false;
            }
            if (cboNature.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboNature.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNature.Focus();
                return false;
            }
            return true;
        }
#endregion
        #region "Load"
        private void frmGroupConfig_Load(object sender, EventArgs e)
        {
            if (strMode == "Edit")
            {
                chkEdit.Checked = true;
            }
            else
            {
                chkEdit.Checked = false;
            }

            
            txtGroupName.Select();
            LoadModule();
            FormatGrid();
            LoadListView();
            if (strUnder.ToString() != "")
            {
                lblUnder.Text = strUnder.ToString();
                cboUnder.Text = strUnder.ToString();
            }
            List<GroupsConfig> objgroup = new List<GroupsConfig>();
            objgroup = accmSc.GetgroupDetails(strUnder.ToString()).ToList();
            foreach (GroupsConfig grp in objgroup)
            {
                //cboUnder1.Text = strUnder.ToString();
                if (Convert.ToInt16(grp.GrPrimaryType) == 1)
                {
                    cboNature.Text = "Assets";
                }
                else if (Convert.ToInt16(grp.GrPrimaryType) == 2)
                {
                    cboNature.Text = "Liabilities";
                }
                else if (Convert.ToInt16(grp.GrPrimaryType) == 3)
                {
                    cboNature.Text = "Income";
                }
                else if (Convert.ToInt16(grp.GrPrimaryType) == 4)
                {
                    cboNature.Text = "Expenses";
                }
            }

        }
        #endregion
        #region "Selected index"
        private void lvwGroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwGroupList.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true ;
                btnSave.Enabled = false;
                ListViewItem itm = lvwGroupList.SelectedItems[0];
                lblUnder.Text = itm.SubItems[2].Text;
                txtSlNo.Text = itm.SubItems[0].Text;
                txtGroupName.Text = itm.SubItems[1].Text;
                if (Convert.ToInt32(itm.SubItems[4].Text) == 1)
                {
                    cboUnder.Text = "";
                    cboUnder.Text = "Primary";
                    ChkPrimary.Checked = true;
                    ChkPrimary.Enabled = false;
                    cboNature.Text = itm.SubItems[2].Text;
                }
                else
                {
                    ChkPrimary.Checked = false;
                    ChkPrimary.Enabled = true;
                    cboUnder.Text = "";
                    cboUnder.Text = itm.SubItems[2].Text;
                }
                if (Convert.ToInt32(itm.SubItems[7].Text) == 1)
                {
                    cboNature.Text = "";
                    cboNature.Text = "Assets";
                }
                else if (Convert.ToInt32(itm.SubItems[7].Text) == 2)
                {
                    cboNature.Text = "";
                    cboNature.Text = "Liabilities";
                }
                else if (Convert.ToInt32(itm.SubItems[7].Text) == 3)
                {
                    cboNature.Text = "";
                    cboNature.Text = "Income";
                }
                else if (Convert.ToInt32(itm.SubItems[7].Text) == 4)
                {
                    cboNature.Text = "";
                    cboNature.Text = "Expenses";
                }

                if (Convert.ToInt32(itm.SubItems[5].Text) == 1)
                {
                    cboUnder.Enabled = false;
                    cboNature.Enabled = false;
                }
                else
                {
                    cboUnder.Enabled = true;
                    cboNature.Enabled = true;
                }

                switch  (Convert.ToInt32(itm.SubItems[6].Text))
                {
                    case 1:
                        cboCashFlowType.Text = "Operating Activities";
                        break;
                    case 2:
                        cboCashFlowType.Text = "Investing Activities";
                        break; 
                    case 3:
                        cboCashFlowType.Text = "Financing Activities";
                        break;
                    case 4:
                        cboCashFlowType.Text = "End of List";
                        break;
                }

              
            }
        }
        private void ChkPrimary_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPrimary.Checked == true)
            {
               cboUnder.Text = null;
               cboUnder.Text = "Primary";
               cboUnder.Enabled = false;
            }
            else
            {
                cboUnder.Text = "";
                cboUnder.Enabled = true;
            }
        }
        #endregion
        #region "button"
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            txtGroupName.Select();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    GroupsConfig objGrp = this.PopulateGroups();

                    if (Utility.IsDuplicateFoundInList(lvwGroupList, 1, txtGroupName.Text) == true)
                    {
                        MessageBox.Show("Cannot Inssert Duplicate Value", "AGH Accounts");
                        return;
                    }

                    short i = accmSc.SaveGroupSetup(objGrp);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        //MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtGroupName.Text = "";
                        txtGroupName.Focus();
                        LoadListView();
                    }
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
        private void btnTreeView_Click(object sender, EventArgs e)
        {
            frmTreeView frm = new frmTreeView();
            frm.Show();

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    GroupsConfig objGrp = this.PopulateGroups();
                    short i = accmSc.UpdateGroupSetup(objGrp);

                    if (i == 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        //MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListView();
                        //btnNew.PerformClick();
                        txtGroupName.Text = "";
                        txtGroupName.Focus();
                    }
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((Int32.Parse(lvwGroupList.FocusedItem.SubItems[5].Text)) == 1)
            {
                MessageBox.Show("You cann't delete Default Group");
            }
            else
            {
                try
                {
                    var strResponse = MessageBox.Show("Do U want to Delete?", "Delete Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (strResponse == DialogResult.Yes)
                    {
                        GroupsConfig objGrp = this.PopulateGroups();
                        short i = accmSc.DeleteGroupSetup(objGrp);
                        if (i == 0)
                        {
                            MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i > 0)
                        {
                            MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnNew.PerformClick();
                            txtGroupName.Focus();
                            LoadListView();
                        }
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
            

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            grpSerach.Visible = true;
            txtLedger.Text = "";
            //lstLedger.ValueMember = "Key";
            //lstLedger.DisplayMember = "Value";
            //lstLedger.DataSource = new BindingSource(accmSc.GetGroups("D"), null);
            txtLedger.Focus();
        }
        #endregion
        #region "Keypress"
        private void txtLedger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (lstLedger.SelectedItem != null)
                {
                    lstLedger.SelectedIndex = lstLedger.SelectedIndex - 1;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (lstLedger.Items.Count - 1 > lstLedger.SelectedIndex)
                {
                    lstLedger.SelectedIndex = lstLedger.SelectedIndex + 1;
                }
            }
        }
        private void cboUnder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.F))
            {
                grpSerach.Visible = true;
                txtLedger.Focus();
            }
        }
        private void txtLedger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (lstLedger.Items.Count > 0)
                {
                    if (lstLedger.SelectedIndex == -1)
                    {
                        txtLedger.Text = lstLedger.Items[0].ToString();
                    }
                    else
                    {
                        txtLedger.Text = lstLedger.Text;
                    }
                    cboUnder.SelectedValue = txtLedger.Text;
                    cboNature.Focus();
                    lstLedger.Visible = false;
                    grpSerach.Visible = false;
                }
            }
        }
        private void txtLedger_TextChanged(object sender, EventArgs e)
        {
            {
                lstLedger.Visible = true;
                lstLedger.SelectedIndex = lstLedger.FindString(txtLedger.Text);
            }
        }
        private void lstLedger_DoubleClick(object sender, EventArgs e)
        {
            txtLedger.Text = lstLedger.Text;
            cboUnder.SelectedValue = txtLedger.Text;
            lstLedger.Visible = false;
            grpSerach.Visible = false;
            cboNature.Focus();
        }
        private void txtGroupName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (txtGroupName.Text.Length > 1 && txtGroupName.Text.Substring(txtGroupName.Text.Length - 1, 1) == " ")
            {
                // convert first character to upper case after space
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
            }
            else if (txtGroupName.Text.Length == 0)
            {
                // convert first character typed in texbox to upper case
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());

            }
            
            if (e.KeyChar == (char)Keys.Return)
            {
                if (cboUnder.Visible)
                {
                    cboUnder.Focus();
                }
                else
                {
                    btnSave.Focus();
                }
            }
        }
        private void cboUnder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboNature.Focus();
            }
        }
        private void cboNature_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboCashFlowType.Focus();
            }
        }
        private void cboCashFlowType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSave.Focus();
            }
        }
        #endregion
        #region "Click"
        private void lblClose_Click(object sender, EventArgs e)
        {
            grpSerach.Visible = false;
        }
        #endregion
        #region "Searchlist"
        private void SearchListView(IEnumerable<GroupsConfig> tests, string searchString = "")
        {
            IEnumerable<GroupsConfig> query;
            if (!(searchString.Length > 0))
            {
                query = tests;
            }
            else
            {
                query = (from test in tests
                         where test.GrName.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                         select test);

            }
            lvwGroupList.Items.Clear();
            foreach (GroupsConfig grps in query)
            {
                ListViewItem itm = new ListViewItem(grps.Lngsllno.ToString());
                itm.SubItems.Add(grps.GrName);
                itm.SubItems.Add(grps.GrParent);
                itm.SubItems.Add(grps.GrDefaultName);
                itm.SubItems.Add(grps.Grlevel.ToString());
                itm.SubItems.Add(grps.GrDefaultgroup.ToString());
                itm.SubItems.Add(grps.GrCashFlow.ToString());
                itm.SubItems.Add(grps.GrPrimaryType.ToString());
                lvwGroupList.Items.Add(itm);
            }
        }
        #endregion
        #region"Keyup/Changed"
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(grp, txtSearch.Text);
        }
        private void chkEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEdit.Checked == true)
            {
                this.Width = 880;
                this.Height = 553;
                pnlMain.Width = 869;
                pnlMain.Height = 399;
                btnNew.Location = new Point(174, 458);
                btnNew.Location = new Point(288, 458);
                btnSave.Location = new Point(402, 458);
                btnEdit.Location = new Point(516, 458);
                btnDelete.Location = new Point(631, 459);
                btnClose.Location = new Point(744, 458);

            }
            else
            {
                this.Width = 869;
                this.Height = 262;
                pnlMain.Width = 869;
                pnlMain.Height =97 ;

                btnNew.Location = new Point(288, 170);
                btnSave.Location = new Point(402, 170);
                btnEdit.Location = new Point(516, 170);
                btnDelete.Location = new Point(630, 529);
               // btnTreeView.Location = new Point(631, 171);
                btnClose.Location = new Point(744, 529);
            }
        }
        private void txtGroupName_KeyUp(object sender, KeyEventArgs e)
        {
            PropercaseFirst(txtGroupName.Text);
        }
        #endregion 
        #region "ProperCase"
        static string PropercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
        #endregion

    }
}
