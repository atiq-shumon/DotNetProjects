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
using System.Drawing.Drawing2D;


namespace AH.ModuleController.UI.FNB.Forms
{
    public partial class frmFoodItem : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();


        public frmFoodItem()
        {
            InitializeComponent();
        }
        private void FormaList()
        {
            lvwFoodItem.CheckBoxes = false;
            lvwFoodItem.Columns.Add("Item ID", 150, HorizontalAlignment.Left );
            lvwFoodItem.Columns.Add("Item Name", 350, HorizontalAlignment.Left );
            lvwFoodItem.Columns.Add("Diet ID", 0, HorizontalAlignment.Left);
            lvwFoodItem.Columns.Add("Cat ID", 0, HorizontalAlignment.Left);
            lvwFoodItem.Columns.Add("Remarks", 400, HorizontalAlignment.Left);
        }
        private bool ValidateFields()
        {

            List<string> vf = new List<string>() { "txtItemName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            if (cboDietCat.Text =="--Select--")
            {
                MessageBox.Show("Cannot Empty");
                cboDietCat.Focus();
            }
            if (cbofoodCat.Text == "--Select--")
            {
                MessageBox.Show("Cannot Empty");
                cbofoodCat.Focus();
            }
            return true;
        }

        private FoodItem PopulateFoodItem()
        {
            FoodItem objFood = new FoodItem();
            if (txtItemID.Text != "")
            {
                objFood.ItemID = txtItemID.Text;
            }
            else
            {
                txtItemID.Text  = "";
            }
            objFood.ItemName = txtItemName.Text;
            objFood.DietCatID = cboDietCat.SelectedValue.ToString();
            objFood.FoodCatID = cbofoodCat.SelectedValue.ToString();
            objFood.Remarks = txtRemarks.Text.ToString();
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objFood.EntryParameter = ep;
            return objFood;
        }
        private void frmFoodItem_Load(object sender, EventArgs e)
        {
            try
            {
                FormaList();
                LoadListViewFood();
                cboDietCat.ValueMember = "key";
                cboDietCat.DisplayMember = "value";
                cboDietCat.DataSource = new BindingSource(fnbs.GetDietCategory(), null);

                cbofoodCat.ValueMember = "key";
                cbofoodCat.DisplayMember = "value";
                cbofoodCat.DataSource = new BindingSource(fnbs.GetFoodCategory(), null);


                GraphicsPath gp = new GraphicsPath();
                gp.AddEllipse(FoodImage.DisplayRectangle);
                FoodImage.Region = new Region(gp);
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
        private void LoadListViewFood()
        {
            try
            {
                lvwFoodItem.Items.Clear();
                List<FoodItem> objfood = fnbs.LoadFoodItem().ToList();
                if (objfood.Count > 0)
                {
                    foreach (FoodItem objDc in objfood)
                    {
                        ListViewItem itm = new ListViewItem(objDc.ItemID);
                        itm.SubItems.Add(objDc.ItemName);
                        itm.SubItems.Add(objDc.DietCatID);
                        itm.SubItems.Add(objDc.FoodCatID);
                        itm.SubItems.Add(objDc.Remarks);
                        lvwFoodItem.Items.Add(itm);
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

                    FoodItem objfood = this.PopulateFoodItem();
                    int i = fnbs.InsertFoodItem(objfood);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadListViewFood();
                        txtItemID.Text = "";
                        txtItemName.Text = "";
                        txtItemName.Focus();
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
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    FoodItem objfood = this.PopulateFoodItem();
                    int i = fnbs.UpdateFoodItem(objfood);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadListViewFood();
                        txtItemID.Text = "";
                        txtItemName.Text = "";
                        txtRemarks.Text = "";
                        btnSave.Enabled = true;
                        btnEdit.Enabled = false;
                        txtItemName.Focus();
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

        private void lvwFoodItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwFoodItem.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwFoodItem.SelectedItems[0];
                txtItemID.Text = itm.SubItems[0].Text;
                txtItemName.Text = itm.SubItems[1].Text;
                cboDietCat.SelectedValue = itm.SubItems[2].Text;
                cbofoodCat.SelectedValue  = itm.SubItems[3].Text;
                txtRemarks.Text = itm.SubItems[4].Text;
                txtItemName.Focus();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

        private void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Return)
            {
                cboDietCat.Focus();
            }
        }

        private void cboDietCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cbofoodCat.Focus();
            }
        }

        private void cbofoodCat_KeyPress(object sender, KeyPressEventArgs e)
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



    }
}
