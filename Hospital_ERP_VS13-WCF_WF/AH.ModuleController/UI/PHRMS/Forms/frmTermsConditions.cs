using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.PHRMSSR;

namespace AH.ModuleController.UI.PHRMS.Forms
{
    public partial class frmTermsConditions : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        public frmTermsConditions()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            lvwTerms.CheckBoxes = false;
            lvwTerms.Columns.Add("id", 200, HorizontalAlignment.Left);
            lvwTerms.Columns.Add("Name", 450, HorizontalAlignment.Left);
            
            lvwTerms.Columns.Add("autoselected", 0, HorizontalAlignment.Left);
            lvwTerms.Columns.Add("bold", 0, HorizontalAlignment.Left);
            lvwTerms.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
            lvwTerms.Columns.Add("Priority", 0, HorizontalAlignment.Left);
            lvwTerms.Columns.Add("Status", 0, HorizontalAlignment.Left);

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmTermsConditions_Load(object sender, EventArgs e)
        {
            FormatGrid();
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
                short i = phrSr.SaveTermsandCondition(objtc);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
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
            if (chkAutoSelected.Checked == true)
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
            

            //status = cboStatus.Text.Substring(0, 1);
            objTerms.IsAutoSelected = (isAutoSelected);
            objTerms.IsBold = (isbold);
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
        private void LoadListView()
        {
            lvwTerms.Items.Clear();
            List<TermsAndConditions> cat = phrSr.GetTermsandCondition().ToList();
            if (cat.Count > 0)
            {
                foreach (TermsAndConditions objcat in cat)
                {
                    ListViewItem itm = new ListViewItem(objcat.ID);
                    itm.SubItems.Add(objcat.Name.ToString());
                    
                    itm.SubItems.Add(objcat.IsAutoSelected.ToString());
                    itm.SubItems.Add(objcat.IsBold.ToString());
                    itm.SubItems.Add(objcat.Remarks.ToString());
                    itm.SubItems.Add(objcat.Priority.ToString());

                    lvwTerms.Items.Add(itm);
                }
            }
        }

        private void lvwTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwTerms.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
                ListViewItem itm = lvwTerms.SelectedItems[0];
                txtTermsID.Text = itm.SubItems[0].Text;
                txtTermsCondition.Text = itm.SubItems[1].Text;
                

                if (itm.SubItems[2].Text == "Y")
                {
                    chkAutoSelected.Checked = true;
                }
                else
                {
                    chkAutoSelected.Checked = false;
                }

                if (itm.SubItems[3].Text == "Y")
                {
                    chkBold.Checked = true;
                }
                else
                {
                    chkBold.Checked = false;
                }

                txtRemarks.Text = itm.SubItems[4].Text;

               
            }
        }

        #region "Keypress"

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
                short i = phrSr.ModifyTermsandCondition(objtc);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
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

    }
}
