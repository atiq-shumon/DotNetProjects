using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.ModuleController.FNBSR;
using AH.DUtility;
using System.Collections.Generic;
using System;



namespace AH.ModuleController.UI.FNB.Forms
{
    public partial class frmFoodCategory : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        public frmFoodCategory()
        {
            InitializeComponent();
        }

        #region "Format List"
        private void FormaList()
        {
            lvwFoodCategory.CheckBoxes = false;
            lvwFoodCategory.Columns.Add("Category ID", 130, HorizontalAlignment.Left );
            lvwFoodCategory.Columns.Add("Food Category Name", 380, HorizontalAlignment.Left);
            lvwFoodCategory.Columns.Add("Remarks", 330, HorizontalAlignment.Left);
        }
        #endregion
        #region "LoadListview"
        private void LoadListView()
        {
            lvwFoodCategory.Items.Clear();
            List<FoodCategory> Io = fnbs.LoadFoodCategory().ToList();
            if (Io.Count > 0)
            {
                foreach (FoodCategory objDc in Io)
                {
                    ListViewItem itm = new ListViewItem(objDc.FoodID);
                    itm.SubItems.Add(objDc.FoodcatName);
                    itm.SubItems.Add(objDc.Remarks);
                    lvwFoodCategory.Items.Add(itm);
                }
            }
        }
        #endregion
        #region "PopulateFoodCat"
        private FoodCategory  PopulateFoodCat()
        {
            FoodCategory objFoodcat = new FoodCategory();
            if (txtFoodID.Text != "")
            {
                objFoodcat.FoodID  = txtFoodID.Text;
            }
            else
            {
                objFoodcat.FoodID = "";
            }
            objFoodcat.FoodcatName = txtFoodCategory.Text;

            if (txtRemarks.Text  !="")
            {
                objFoodcat.Remarks = txtRemarks.Text;
            }
            else
            {
                objFoodcat.Remarks = "";
            }

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objFoodcat.EntryParameter = ep;
            return objFoodcat;
        }
        #endregion
        #region  "Validationfields"
        private bool ValidateFields()
        {

            List<string> vf = new List<string>() { "txtFoodCategory" };
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
        #region "Click"
        private void btnSave_Click(object sender, System.EventArgs e)
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

                    FoodCategory objcat = this.PopulateFoodCat();
                    int i = fnbs.InsertFoodcat(objcat);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadListView();
                        txtFoodID.Text = "";
                        txtFoodCategory.Text = "";
                        txtFoodCategory.Focus();
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

        private void btnEdit_Click(object sender, System.EventArgs e)
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

                    FoodCategory objcat = this.PopulateFoodCat();
                    int i = fnbs.UpdateFoodcat(objcat);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadListView();
                        txtFoodID.Text = "";
                        txtFoodCategory.Text = "";
                        txtFoodCategory.Focus();
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
        private void btnNew_Click(object sender, System.EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }
        #endregion
        #region "Load"
        private void frmFoodCategory_Load(object sender, System.EventArgs e)
        {
            FormaList();
            LoadListView();
        }
        #endregion
        #region  "SlectedChanged"
        private void lvwFoodCategory_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lvwFoodCategory.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwFoodCategory.SelectedItems[0];
                txtFoodID.Text = itm.SubItems[0].Text;
                txtFoodCategory.Text = itm.SubItems[1].Text;
                txtRemarks.Text = itm.SubItems[2].Text;
                txtFoodCategory.Focus();
            }
        }
        #endregion
        #region "Keypress"
        private void txtFoodCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Return)
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
