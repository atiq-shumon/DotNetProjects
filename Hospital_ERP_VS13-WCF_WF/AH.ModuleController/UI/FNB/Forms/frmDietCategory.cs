using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.ModuleController.FNBSR;
using AH.DUtility;



namespace AH.ModuleController.UI.FNB.Forms
{
    public partial class frmDietCategory : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
            
        public frmDietCategory()
        {
            InitializeComponent();
        }

        #region "Format"
        private void FormaList()
        {

            lvwDietCategory.CheckBoxes = false;
            lvwDietCategory.Columns.Add("Category ID", 100, HorizontalAlignment.Left );
            lvwDietCategory.Columns.Add("Diet Category Name", 370, HorizontalAlignment.Left);
            lvwDietCategory.Columns.Add("Remarks", 350, HorizontalAlignment.Left);
        }
        #endregion
        #region "Loadlistview"
        private void LoadListView()
        {
            lvwDietCategory.Items.Clear();
            List<DietCategory> Io = fnbs.LoadDietCategory().ToList();
            if (Io.Count > 0)
            {
                foreach (DietCategory objDc in Io)
                {
                    ListViewItem itm = new ListViewItem(objDc.dietID);
                    itm.SubItems.Add(objDc.dietcatName);
                    itm.SubItems.Add(objDc.remarks);
                    lvwDietCategory.Items.Add(itm);
                }
            }
        }
        #endregion
        #region "PopulateCat"
        private DietCategory PopulateDietCat()
        {
            DietCategory objDietcat = new DietCategory();
            if (txtDietID.Text != "")
            {
                objDietcat.dietID = txtDietID.Text;
            }
            else
            {
                objDietcat.dietID = "";
            }
            objDietcat.dietcatName = txtDietCategory.Text;
            if (txtRemarks.Text !="")
            {
                objDietcat.remarks = txtRemarks.Text;
            }
            else
            {
                objDietcat.remarks = "";
            }

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objDietcat.EntryParameter = ep;
            return objDietcat;
        }
        #endregion
        #region "Load"
        private void frmDietCategory_Load(object sender, EventArgs e)
        {
            try
            {
                FormaList();
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
        #region "Validationfields"
        private bool ValidateFields()
        {

            List<string> vf = new List<string>() { "txtDietCategory" };
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
        #region "Selectedchanged"
        private void lvwDietCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDietCategory.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwDietCategory.SelectedItems[0];
                txtDietID.Text = itm.SubItems[0].Text;
                txtDietCategory.Text = itm.SubItems[1].Text;
                txtRemarks.Text = itm.SubItems[2].Text;
                txtDietCategory.Focus();
            }
        }
        #endregion
        #region "Click"
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

                    DietCategory objcat = this.PopulateDietCat();
                    int i = fnbs.InsertDietcat(objcat);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadListView();
                        txtDietID.Text = "";
                        txtDietCategory.Text = "";
                        txtDietCategory.Focus();
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
                var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    DietCategory objcat = this.PopulateDietCat();
                    int i = fnbs.UpdateDietcat(objcat);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadListView();
                        txtDietID.Text = "";
                        txtDietCategory.Text = "";
                        txtDietCategory.Focus();
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
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }
        #endregion
        #region "Keypress"
        private void txtDietCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Return)
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
    }
}
