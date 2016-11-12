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
    public partial class frmBranchConfig : AH.Shared.UI.frmSmartFormStandard
    {
        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();
        public frmBranchConfig()
        {
            InitializeComponent();
        }

        #region "Validationfields"
        private bool ValidateFields()
        {
            
            List<string> vf = new List<string>() { "txtBranchName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            return true;
        }
        #endregion
        #region "PoulatedBranch"
        private Branch  PopulateBranch()
        {
            int intFlag = 0;
            if (cboInactive.Text == "Yes")
            {
                intFlag = 1;
            }

            Branch branch = new Branch();
            branch.BranchID = txtBranchID.Text;
            branch.BranchName = txtBranchName.Text;
            branch.Address1  = txtAddress1.Text;
            branch.Address2  = txtAddress2.Text;
            branch.CountryName   = txtCountry.Text;
            branch.PhoneNo  = txtTelephone.Text;
            branch.Fax  = txtFax.Text;
            branch.Comments  = txtCommnets.Text;
            branch.BranchFlag =(Int16) intFlag;
           
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            branch.EntryParameter = ep;
            return branch;
        }
        #endregion
        #region "Save"
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (ValidateFields() == false)
                {
                    return;
                }
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    Branch branch = this.PopulateBranch();
                    short i = accmSc.SaveBranchSetup(branch);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtBranchName.Focus();
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
        #endregion
        #region "LaodCombo"
        private void mLoadCombo()
        {
            cboInactive.Items.Clear();
            cboInactive.Items.Add("No");
            cboInactive.Items.Add("Yes"); 
        }
        #endregion
        #region "Listview"
        private void FormatGrid()
        {
            LvwBranchList.CheckBoxes = false;
            LvwBranchList.Columns.Add("Branch Id", 260, HorizontalAlignment.Center);
            LvwBranchList.Columns.Add("Branch Name", 290, HorizontalAlignment.Left);
            LvwBranchList.Columns.Add("Address1",290, HorizontalAlignment.Left);
            LvwBranchList.Columns.Add("Address2", 290, HorizontalAlignment.Left);
            LvwBranchList.Columns.Add("Country", 0, HorizontalAlignment.Left);
            LvwBranchList.Columns.Add("Phone", 0, HorizontalAlignment.Left);
            LvwBranchList.Columns.Add("Fax", 0, HorizontalAlignment.Left);
            LvwBranchList.Columns.Add("Status", 0, HorizontalAlignment.Left);
            LvwBranchList.Columns.Add("Commnets", 0, HorizontalAlignment.Left);
            LvwBranchList.Columns.Add("Flag", 0, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            LvwBranchList.Items.Clear();
            //MessageBox.Show("7");
            List<Branch> branch = accmSc.GetBranch().ToList();
            //MessageBox.Show("8");
            if (branch.Count > 0)
            {
                foreach (Branch bo in branch)
                {
                    int i;
                    i = bo.BranchFlag;
                    ListViewItem itm = new ListViewItem(bo.BranchID);
                    itm.SubItems.Add(bo.BranchName);
                    itm.SubItems.Add(bo.Address1);
                    itm.SubItems.Add(bo.Address2);
                    //MessageBox.Show("9");
                    itm.SubItems.Add(bo.CountryName);
                    itm.SubItems.Add(bo.PhoneNo);
                    itm.SubItems.Add(bo.Fax);
                    itm.SubItems.Add(bo.BranchFlag.ToString());
                    //MessageBox.Show("10");
                    itm.SubItems.Add(bo.Comments);
                    itm.SubItems.Add(bo.intDefaultFlag.ToString());
                    //itm.SubItems.Add(bo.intDefaultFlag);
                    LvwBranchList.Items.Add(itm);
                }

            }
        }
        #endregion
        #region "FormLoad"
        private void frmBranchConfig_Load(object sender, EventArgs e)
        {
            try
            {
                txtBranchName.Select();
                //MessageBox.Show("1");
                mLoadCombo();
                //MessageBox.Show("2");
                cboInactive.Text = "No";
                FormatGrid();
                //MessageBox.Show("3");
                LoadListView();
                //MessageBox.Show("4");
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
        #endregion
        #region "Change"
        private void LvwBranchList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvwBranchList.SelectedItems.Count > 0)
            {
                ListViewItem itm = LvwBranchList.SelectedItems[0];
                txtBranchID.Text = itm.SubItems[0].Text;
                txtBranchName.Text =itm.SubItems[1].Text;
                txtAddress1.Text =itm.SubItems[2].Text;
                txtAddress2.Text = itm.SubItems[3].Text;
                txtCountry.Text = itm.SubItems[4].Text;
                txtTelephone.Text = itm.SubItems[5].Text;
                txtFax.Text = itm.SubItems[6].Text;
                if (int.Parse(itm.SubItems[7].Text) == 0)
                {
                    cboInactive.Text = "No";
                }
                else
                {
                    cboInactive.Text = "Yes";
                }
                txtCommnets.Text = itm.SubItems[8].Text;
                txtBranchName.Focus();
                
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidateFields() == false)
                {
                    return;
                }
                var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    Branch branch = this.PopulateBranch();
                    short i = accmSc.UpdateBranchSetup(branch);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtBranchName.Focus();
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if ((Int32.Parse(LvwBranchList.FocusedItem.SubItems[9].Text)) == 1)
            //{
            //    MessageBox.Show("Default Branch Cannot be Delete","Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    Branch branch = this.PopulateBranch();
            //    short i = accmSc.DeleteBranch(branch);
            //    if (i == 0)
            //    {
            //        MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else if (i > 0)
            //    {
            //        MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        btnNew.PerformClick();
            //        txtBranchName.Focus();
            //        LoadListView();
            //    }
            //}
        }
        #endregion

    }
}
