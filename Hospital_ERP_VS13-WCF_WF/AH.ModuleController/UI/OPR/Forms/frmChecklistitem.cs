using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.OPRMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.OPR.Forms
{
    public partial class frmChecklistitem : AH.Shared.UI.frmSmartFormStandard
    {
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();

        #region"Checklistitem"
        public frmChecklistitem()
        {
            InitializeComponent();
        }
        #endregion
        #region"Formatgrid"
        private void FormatGrid()
        {
            lvwChecklistItem.CheckBoxes = false;
            lvwChecklistItem.Columns.Add("Item Code", 260, HorizontalAlignment.Left);
            lvwChecklistItem.Columns.Add("Checklist Item", 400, HorizontalAlignment.Left);
        }
        #endregion
        #region "Validationfields"
        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "txtchecklistitem" };
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
        #region "FormLoad"
        private void frmChecklistitem_Load(object sender, EventArgs e)
        {
            //LoadOperationtype();
            try
            {
                FormatGrid();
                LoadListView();
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
        #region "Checklist"
        private ChecklistItem PopulateChecklist()
        {
            ChecklistItem objChecklist = new ChecklistItem();
            if (txtItemCode.Text.ToString() != "")
            {
                objChecklist.itemCode = txtItemCode.Text.ToString();
            }
            objChecklist.itemName = txtchecklistitem.Text.ToString();
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objChecklist.EntryParameter = ep;
            return objChecklist;
        }
        #endregion
        #region "LoadListview"
        private void LoadListView()
        {
            try
            {
                lvwChecklistItem.Items.Clear();
                List<ChecklistItem> objChek = accmSc.GetChekcList().ToList();
                foreach (ChecklistItem bo in objChek)
                {
                    ListViewItem itm = new ListViewItem(bo.itemCode);
                    itm.SubItems.Add(bo.itemName);
                    lvwChecklistItem.Items.Add(itm);
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
        #region "Save/Edit/Delete"
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {

                if (Utility.IsDuplicateFoundInList(lvwChecklistItem, 1, txtchecklistitem.Text) == true)
                {
                    MessageBox.Show("Cannot Insert Duplicate Value", "AGH Operation");
                    return;
                }

                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    ChecklistItem objCheck = this.PopulateChecklist();
                    short i = accmSc.Savedchecklist(objCheck);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtchecklistitem.Focus();
                        LoadListView();
                        btnSave.Enabled = true;
                        btnEdit.Enabled = false;

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

            //if (Utility.IsDuplicateFoundInList(lvwChecklistItem, 1, txtchecklistitem.Text) == true)
            //{
            //    MessageBox.Show("Cannot Insert Duplicate Value", "AGH Operation");
            //    return;
            //}
            try
            {
                var strResponse = MessageBox.Show("Do You want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    ChecklistItem objCheck = this.PopulateChecklist();
                    short i = accmSc.Updatedchecklist(objCheck);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtchecklistitem.Focus();
                        LoadListView();
                        btnSave.Enabled = true;
                        btnEdit.Enabled = false;

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
            var strResponse = MessageBox.Show("Do You want to Delete?", "Delete Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (strResponse == DialogResult.Yes)
            {

                ChecklistItem objCheck = this.PopulateChecklist();
                short i = accmSc.Deletechecklist(objCheck);
                if (i == 0)
                {
                    MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.DeleteMsg , Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtchecklistitem.Focus();
                    LoadListView();

                }
            }

        }
        #endregion
        #region "Changed"
        private void lvwChecklistItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwChecklistItem.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwChecklistItem.SelectedItems[0];
                txtItemCode.Text = itm.SubItems[0].Text;
                txtchecklistitem.Text = itm.SubItems[1].Text;
                txtchecklistitem.Focus();
            }
        }
        #endregion

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            txtchecklistitem.Focus();
        }

        private void txtchecklistitem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Return)
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


    }
}
