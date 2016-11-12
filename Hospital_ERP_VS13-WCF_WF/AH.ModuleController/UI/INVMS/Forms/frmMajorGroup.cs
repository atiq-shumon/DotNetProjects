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
    public partial class frmMajorGroup : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient atms = new INVMSSR.INVMSWSClient();
        public frmMajorGroup()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            lvwTerms.CheckBoxes = false;
            lvwTerms.Columns.Add("Type id", 0, HorizontalAlignment.Left);
            lvwTerms.Columns.Add("Major ID", 200, HorizontalAlignment.Left);
            lvwTerms.Columns.Add("Name", 450, HorizontalAlignment.Center);
            lvwTerms.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
            lvwTerms.Columns.Add("Status", 0, HorizontalAlignment.Left);

        }
        #region "Save"
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtMajorGroup", "cboStatus" };
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
            //var strResponse = MessageBox.Show("Do You want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (strResponse == DialogResult.Yes)
            //{
            try
            {
                Majorgroup objtc = this.PopulateTermsNCondition();
                short i = atms.SaveMajorGrp(objtc);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    CboStoretype.Focus();
                    LoadListView(CboStoretype.SelectedValue.ToString());

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
            //var strResponse = MessageBox.Show("Do You want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (strResponse == DialogResult.Yes)
            //{
            try
            {
                Majorgroup objtc = this.PopulateTermsNCondition();
                short i = atms.Update_Majorgroup(objtc);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    CboStoretype.Focus();
                    LoadListView(CboStoretype.SelectedValue.ToString());
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
        #region "Load"
        private void LoadListView(string strtype)
        {
            lvwTerms.Items.Clear();
            List<Majorgroup> cat; 
            if(strtype.Length != 0)
            {
                cat =  atms.GetMajorGrpByStrtype(strtype).ToList();
            }
                
            else
            {
                return;
            }
           
                foreach (Majorgroup objcat in cat)
                {
                    ListViewItem itm = new ListViewItem(objcat.StoreType.strTypeID);
                    itm.SubItems.Add(objcat.MajorgrpID.ToString());
                    itm.SubItems.Add(objcat.Name.ToString());
                    itm.SubItems.Add(objcat.Remarks.ToString());
                    itm.SubItems.Add(objcat.Active.ToString());
                    lvwTerms.Items.Add(itm);
                }
            
        }
        private Majorgroup PopulateTermsNCondition()
        {
            string status;

            Majorgroup objTerms = new Majorgroup();
            if (txtmajorId.Text.ToString() != "")
            {
                objTerms.MajorgrpID = txtmajorId.Text.ToString();
            }
            StoreTypeSCM ostore = new StoreTypeSCM();
            ostore.strTypeID = CboStoretype.SelectedValue.ToString();
            objTerms.StoreType = ostore;

            objTerms.Name = txtMajorGroup.Text.ToString();
            status = cboStatus.Text.Substring(0, 1);
            objTerms.Active = Convert.ToChar(status);
            objTerms.Remarks = txtRemarks.Text;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objTerms.EntryParameter = ep;
            return objTerms;
        }
#endregion
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
       

        private void frmMajorGroup_Load(object sender, EventArgs e)
        {
            FormatGrid();
            CboStoretype.ValueMember = "strTypeID";
            CboStoretype.DisplayMember = "TypeTitle";
            CboStoretype.DataSource = new BindingSource(atms.GetStoreType(), null);
            LoadListView(CboStoretype.SelectedValue.ToString());
        }

        private void lvwTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwTerms.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
                ListViewItem itm = lvwTerms.SelectedItems[0];
                CboStoretype.SelectedValue = itm.SubItems[0].Text;
                txtmajorId.Text = itm.SubItems[1].Text;
                txtMajorGroup.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
                if (itm.SubItems[4].Text == "A")
                {
                    cboStatus.Text = "Active";
                }
                else
                {
                    cboStatus.Text = "Inactive";
                }
                CboStoretype.Focus();
            }
        }
        #region "Keypress"
        private void CboStoretype_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Return)
            {
                txtMajorGroup.Focus();
            }
        }
        private void txtMajorGroup_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion 

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void CboStoretype_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListView(CboStoretype.SelectedValue.ToString());
        }
    }
}
