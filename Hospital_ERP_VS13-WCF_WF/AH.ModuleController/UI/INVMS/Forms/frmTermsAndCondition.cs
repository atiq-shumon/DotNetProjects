using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.INVMSSR;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmTermsandCondition : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        public frmTermsandCondition()
        {
            InitializeComponent();
        }
        #region "FormatGrid"
        private void FormatGrid()
        {
            lvwTerms.CheckBoxes = false;
            lvwTerms.Columns.Add("id", 200, HorizontalAlignment.Left);
            lvwTerms.Columns.Add("Name", 450, HorizontalAlignment.Left);
            lvwTerms.Columns.Add("store Id", 0, HorizontalAlignment.Center);
            lvwTerms.Columns.Add("autoselected", 0, HorizontalAlignment.Left);
            lvwTerms.Columns.Add("bold", 0, HorizontalAlignment.Left);
            lvwTerms.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
            lvwTerms.Columns.Add("Priority", 0, HorizontalAlignment.Left);
            lvwTerms.Columns.Add("Status", 0, HorizontalAlignment.Left);
            
        }
#endregion
        private void frmTermsandCondition_Load(object sender, EventArgs e)
        {
            FormatGrid();
            cboStoreName.ValueMember = "ID";
            cboStoreName.DisplayMember = "Name";
            cboStoreName.DataSource = new BindingSource(invSr.GetStoreLocation(), null);
            LoadListView();
        }
        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "txtTermsCondition" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            return true;
        }
        private TermsAndConditions PopulateTermsNCondition()
        {
            string isAutoSelected, isbold;

            TermsAndConditions objTerms = new TermsAndConditions();
            if (txtTermsID.Text.ToString() != "")
            {
                objTerms.ID = txtTermsID.Text.ToString();
            }
            objTerms.Name = txtTermsCondition.Text.ToString();
            objTerms.NameBeng = txtTermsCondition.Text.ToString();
            if (chkAutoSelected.Checked== true)
            {
                isAutoSelected = "Y";
            }
            else
            {
                isAutoSelected = "N";
            }
            if (chkBold.Checked == true)
            {
                isbold = "Y";
            }
            else
            {
                isbold = "N";
            }
            StoreLocation ostore = new StoreLocation();
            ostore.ID = cboStoreName.SelectedValue.ToString();
            objTerms.StoreLocation = ostore;

            //status = cboStatus.Text.Substring(0, 1);
            objTerms.IsAutoSelected = (isAutoSelected);
            objTerms.IsBold  = (isbold);
            //objTerms.Active =  Convert.ToChar(status);
            objTerms.Remarks = txtRemarks.Text;
            objTerms.Priority = "1";
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objTerms.EntryParameter = ep;
            return objTerms;
        }
        #region "Save"
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            //var strResponse = MessageBox.Show("Do You want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (strResponse == DialogResult.Yes)
            //{
            try
            {
                TermsAndConditions objtc = this.PopulateTermsNCondition();
                short i = invSr.SaveTermsandCondition(objtc);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    cboStoreName.Focus();
                    LoadListView();

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
        private void mclear()
        {
            txtRemarks.Text = "";
            txtTermsCondition.Text = "";
            chkAutoSelected.Checked = false;
            chkBold.Checked = false;
            cboStoreName.Focus();
        }
        private void LoadListView()
        {
            lvwTerms.Items.Clear();
            List<TermsAndConditions> cat = invSr.GetTermsandCondition().ToList();
            if (cat.Count > 0)
            {
                foreach (TermsAndConditions objcat in cat)
                {
                    ListViewItem itm = new ListViewItem(objcat.ID);
                    itm.SubItems.Add(objcat.Name.ToString());
                    itm.SubItems.Add(objcat.StoreLocation.ID);
                    itm.SubItems.Add(objcat.IsAutoSelected.ToString());
                    itm.SubItems.Add(objcat.IsBold.ToString());
                    itm.SubItems.Add(objcat.Remarks.ToString());
                    itm.SubItems.Add(objcat.Priority.ToString());
                  
                    lvwTerms.Items.Add(itm);
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            //var strResponse = MessageBox.Show("Do You want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (strResponse == DialogResult.Yes)
            //{
            try
            {
                TermsAndConditions objtc = this.PopulateTermsNCondition();
                short i = invSr.ModifyTermsandCondition(objtc);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    cboStoreName.Focus();
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
        #endregion
        private void lvwTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwTerms.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
                ListViewItem itm = lvwTerms.SelectedItems[0];
                txtTermsID.Text = itm.SubItems[0].Text;
                txtTermsCondition.Text = itm.SubItems[1].Text;
                cboStoreName.SelectedValue = itm.SubItems[2].Text;
               
                if (itm.SubItems[3].Text=="Y")
                {
                    chkAutoSelected.Checked = true;
                }
                else
                {
                    chkAutoSelected.Checked = false;
                }

                if (itm.SubItems[4].Text == "Y")
                {
                   chkBold.Checked = true;
                }
                else
                {
                    chkBold.Checked = false;
                }
 
                txtRemarks.Text  = itm.SubItems[5].Text;
              
                cboStoreName.Focus();
            }
        }
        #region "Keypress"
        private void cboStoreName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Return)
            {
                txtTermsCondition.Focus();
            }
        }
        private void txtTermsCondition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
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
                if (btnSave.Enabled)
                {
                    btnSave.Focus();
                }
                else
                {
                    btnEdit.Focus();
                }
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }
        #endregion
    }
}
