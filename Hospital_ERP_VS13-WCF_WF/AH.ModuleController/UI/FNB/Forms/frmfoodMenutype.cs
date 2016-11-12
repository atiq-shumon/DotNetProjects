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
    public partial class frmfoodMenutype : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        public frmfoodMenutype()
        {
            InitializeComponent();
        }
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
        private void LoadListView()
        {
            lvwFoodMenuType.Items.Clear();
            List<FoodMenuType> Io = fnbs.GetFoodMenuType().ToList();
            if (Io.Count > 0)
            {
                foreach (FoodMenuType objFMS in Io)
                {
                    ListViewItem itm = new ListViewItem(objFMS.FoodTypeID);
                    itm.SubItems.Add(objFMS.FoodTypeName);
                    itm.SubItems.Add(objFMS.Remarks);
                    lvwFoodMenuType.Items.Add(itm);
                }
            }
        }

        private FoodMenuType PopulateFoodMenuSetup()
        {
            FoodMenuType objFoodtype = new FoodMenuType();
            if (txtTypeID.Text != "")
            {
                objFoodtype.FoodTypeID  = txtTypeID.Text;
            }
            else
            {
                objFoodtype.FoodTypeID = "";
            }
             objFoodtype.FoodTypeName  = txtFoodMenuName.Text;

            if (txtRemarks.Text != "")
            {
                objFoodtype.Remarks = txtRemarks.Text;
            }
            else
            {
                objFoodtype.Remarks = "";
            }

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objFoodtype.EntryParameter = ep;
            return objFoodtype;
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

                    FoodMenuType objFMS = this.PopulateFoodMenuSetup();
                    int i = fnbs.InsertFoodTypeSetup(objFMS);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadListView();
                        txtFoodMenuName.Text = "";
                        txtTypeID.Text = "";
                        txtRemarks.Text = "";
                        txtFoodMenuName.Focus();
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
            var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (strResponse == DialogResult.Yes)
            {

                FoodMenuType objFMS = this.PopulateFoodMenuSetup();
                int i = fnbs.UpdateFoodTypeSetup(objFMS);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    LoadListView();
                    txtFoodMenuName.Text = "";
                    txtTypeID.Text = "";
                    txtRemarks.Text = "";
                    txtFoodMenuName.Focus();
                    btnSave.Enabled = true;
                    btnEdit.Enabled = false;
                }

            }
        }
        private void FormaList()
        {
            lvwFoodMenuType.CheckBoxes = false;
            lvwFoodMenuType.Columns.Add("Food Menu ID", 100, HorizontalAlignment.Left );
            lvwFoodMenuType.Columns.Add("Food Menu Name", 400, HorizontalAlignment.Left);
            lvwFoodMenuType.Columns.Add("Remarks", 350, HorizontalAlignment.Left);
        }
        private void frmfoodMenutype_Load(object sender, System.EventArgs e)
        {
            FormaList();
            LoadListView();
        }

        private void lvwFoodMenuType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lvwFoodMenuType.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwFoodMenuType.SelectedItems[0];
                txtTypeID.Text = itm.SubItems[0].Text;
                txtFoodMenuName.Text = itm.SubItems[1].Text;
                txtRemarks.Text = itm.SubItems[2].Text;
                txtFoodMenuName.Focus();
            }
        }

        private void txtFoodMenuName_KeyPress(object sender, KeyPressEventArgs e)
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
                btnSave.Focus();
            }
        }
    }
}
