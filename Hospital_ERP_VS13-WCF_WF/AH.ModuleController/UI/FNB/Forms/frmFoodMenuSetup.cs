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
    public partial class frmFoodMenuSetup : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
       
        public frmFoodMenuSetup()
        {
            InitializeComponent();
        }
        #region "FormatList"
        private void FormaList()
        {
            lvwFoodMenuSetup.CheckBoxes = false;
            lvwFoodMenuSetup.Columns.Add("Food Menu ID", 100, HorizontalAlignment.Left );
            lvwFoodMenuSetup.Columns.Add("Food Menu Name", 400, HorizontalAlignment.Left);
            lvwFoodMenuSetup.Columns.Add("Rate", 100, HorizontalAlignment.Left);
            lvwFoodMenuSetup.Columns.Add("Remarks", 290, HorizontalAlignment.Left);
        }
        #endregion
        #region "Load Listview"
        private void LoadListView()
        {
            lvwFoodMenuSetup.Items.Clear();
            List<FoodMenuSetup> Io = fnbs.LoadFoodMenuSetup().ToList();
            if (Io.Count > 0)
            {
                foreach (FoodMenuSetup objFMS in Io)
                {
                    ListViewItem itm = new ListViewItem(objFMS.MenuID);
                    itm.SubItems.Add(objFMS.MenuName);
                    itm.SubItems.Add(objFMS.Rate.ToString());
                    itm.SubItems.Add(objFMS.Remarks);
                    lvwFoodMenuSetup.Items.Add(itm);
                }
            }
        }
        #endregion
        #region "PopulateFoodMenu"
        private FoodMenuSetup PopulateFoodMenuSetup()
        {
            FoodMenuSetup objFoodcat = new FoodMenuSetup();
            if (txtMenuID.Text != "")
            {
                objFoodcat.MenuID = txtMenuID.Text;
            }
            else
            {
                objFoodcat.MenuID = "";
            }
            objFoodcat.MenuName = txtMenuName.Text;

            if (txtRemarks.Text != "")
            {
                objFoodcat.Remarks = txtRemarks.Text;
            }
            else
            {
                objFoodcat.Remarks = "";
            }
            if (txtRate.Text.ToString() != "")
            {
                objFoodcat.Rate = Convert.ToDouble(txtRate.Text.ToString());
            }
            else
            {
                objFoodcat.Rate = 0;
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
        #region "Validatefields"
        private bool ValidateFields()
        {

            List<string> vf = new List<string>() { "txtMenuName" };
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
        private void btnNew_Click(object sender, System.EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }
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

                    FoodMenuSetup objFMS = this.PopulateFoodMenuSetup();
                    int i = fnbs.InsertFoodMenuSetup(objFMS);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadListView();
                        txtMenuID.Text = "";
                        txtMenuName.Text = "";
                        txtRemarks.Text = "";
                        txtRate.Text = "";
                        txtMenuName.Focus();
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
                var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    FoodMenuSetup objFMS = this.PopulateFoodMenuSetup();
                    int i = fnbs.UpdateMenuFoodItem(objFMS);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadListView();
                        txtMenuID.Text = "";
                        txtMenuName.Text = "";
                        txtRemarks.Text = "";
                        txtRate.Text = "";
                        txtMenuName.Focus();
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
        #endregion
        #region "Load"
        private void frmFoodMenuSetup_Load(object sender, System.EventArgs e)
        {
            FormaList();
            LoadListView();

        }
        #endregion
        #region "SelectedIndexChanged"
        private void lvwFoodMenuSetup_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lvwFoodMenuSetup.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwFoodMenuSetup.SelectedItems[0];
                txtMenuID.Text = itm.SubItems[0].Text;
                txtMenuName.Text = itm.SubItems[1].Text;
                txtRate.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
                txtMenuName.Focus();
            }
        }
        #endregion
        #region "Keypress"
        private void txtMenuName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Return)
            {
                txtRate.Focus();
            }
        }
        private void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtRemarks.Focus();
            }
        }

    }
}
