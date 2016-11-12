using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.ModuleController.INVMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmStoreType : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient atms = new INVMSSR.INVMSWSClient();
        public frmStoreType()
        {
            InitializeComponent();
        }
        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "tctStoreTypeTitle" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            return true;
        }
        #region "Format"
        private void FormatGrid()
        {
            lvwTerms.CheckBoxes = false;
            lvwTerms.Columns.Add("typeid", 200, HorizontalAlignment.Left);
            lvwTerms.Columns.Add("Type Title", 450, HorizontalAlignment.Left);
            lvwTerms.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
            lvwTerms.Columns.Add("Status", 0, HorizontalAlignment.Left);

        }
        private void LoadListView()
        {
            lvwTerms.Items.Clear();
            List<StoreTypeSCM> cat = atms.GetStoreType().ToList();
            if (cat.Count > 0)
            {
                foreach (StoreTypeSCM objcat in cat)
                {
                    ListViewItem itm = new ListViewItem(objcat.strTypeID);
                    itm.SubItems.Add(objcat.TypeTitle.ToString());
                    itm.SubItems.Add(objcat.Remarks.ToString());
                    itm.SubItems.Add(objcat.Active.ToString());
                    lvwTerms.Items.Add(itm);
                }
            }
        }
        #endregion
        private StoreTypeSCM PopulateStoretype()
        {
            string status = "";

            StoreTypeSCM objStore = new StoreTypeSCM();
            if (txtStoreID.Text.ToString() != "")
            {
                objStore.strTypeID = txtStoreID.Text.ToString();
            }
            objStore.TypeTitle = txtStoreTypeTitle.Text.ToString();
            status = cboStatus.Text.Substring(0, 1);
            objStore.Active = Convert.ToChar(status);
            objStore.Remarks = txtRemarks.Text;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objStore.EntryParameter = ep;
            return objStore;
        }
        #region "Save"
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            List<string> vf = new List<string>() { "txtStoreTypeTitle" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    StoreTypeSCM objSt = this.PopulateStoretype();
                    short i = atms.SaveStoreType(objSt);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtStoreTypeTitle.Focus();
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                StoreTypeSCM objst = this.PopulateStoretype();
                short i = atms.UpdateStoreType(objst);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtStoreTypeTitle.Focus();
                    LoadListView();
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
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
        private void lvwTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (lvwTerms.SelectedItems.Count > 0)
              {
                  btnEdit.Enabled = true;
                  btnSave.Enabled = false;
                  ListViewItem itm = lvwTerms.SelectedItems[0];
                  txtStoreID.Text = itm.SubItems[0].Text;
                  txtStoreTypeTitle.Text = itm.SubItems[1].Text;
                  txtRemarks.Text = itm.SubItems[2].Text;
                  if (itm.SubItems[3].Text == "A")
                  {
                      cboStatus.Text = "Active";
                  }
                  else
                  {
                      cboStatus.Text = "Inactive";
                  }
                  txtStoreTypeTitle.Select();
              }
        }
        #endregion
        #region "Load"
        private void frmStoreType_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadListView();
        }
        #endregion
        #region "Keypress"
        private void txtStoreTypeTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Return)
            {
                cboStatus.Focus();
            }
        }
        private void cboStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtRemarks.Focus();
            }
        }
        private void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if(btnSave.Enabled)
                {
                    btnSave.Focus();
                }
                else
                {
                    btnEdit.Focus();
                }
            }
        }
        #endregion

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true ;
            btnEdit.Enabled = false;
            txtStoreTypeTitle.Focus();
        }

    }
}
