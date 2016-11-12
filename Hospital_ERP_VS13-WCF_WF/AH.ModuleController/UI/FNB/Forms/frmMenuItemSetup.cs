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
using System.IO;

namespace AH.ModuleController.UI.FNB.Forms
{
    public partial class frmMenuItemSetup : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        List<FoodMaster> objfood;
        public frmMenuItemSetup()
        {
            InitializeComponent();
        }

        private void FormaList()
        {
            lvwMenuItemSetup.CheckBoxes = true;
            lvwMenuItemSetup.Columns.Add("Food ID", 100, HorizontalAlignment.Left );
            lvwMenuItemSetup.Columns.Add("Food Name", 500, HorizontalAlignment.Left);
            lvwMenuItemSetup.Columns.Add("Food Rate", 150, HorizontalAlignment.Left);

            lvwFoodList.CheckBoxes = false;
            lvwFoodList.Columns.Add("Menu ID", 80, HorizontalAlignment.Left);
            lvwFoodList.Columns.Add("Menu Name", 250, HorizontalAlignment.Left);
            lvwFoodList.Columns.Add("Type ID", 0, HorizontalAlignment.Left);
            lvwFoodList.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
            
        }

        #region "Event"
        private void frmMenuItemSetup_Load(object sender, EventArgs e)
        {
            try
            {
                FormaList();
                cboMenuId.ValueMember = "Key";
                cboMenuId.DisplayMember = "Value";
                cboMenuId.DataSource = new BindingSource(fnbs.GetFoodMenuItemSetup(), null);

                cbotypeId.ValueMember = "Key";
                cbotypeId.DisplayMember = "Value";
                cbotypeId.DataSource = new BindingSource(fnbs.GetFoodTypeSetup(), null);

                LoadFoodItemsetup();
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
        private void Calculatetotal()
        {
            double dblAmount = 0;
            for (int i = 0; i < lvwMenuItemSetup.Items.Count; i++)
            {
                if (lvwMenuItemSetup.Items[i].Checked == true)
                {
                    dblAmount = dblAmount + Convert.ToDouble(lvwMenuItemSetup.Items[i].SubItems[2].Text);
                }
            }
            txtNetAmount.Text = dblAmount.ToString();
        }
        private void LoadFoodItemsetup()
        {
            lvwMenuItemSetup.Items.Clear();
            objfood = fnbs.LoadFoodMaster().ToList();
            if (objfood.Count > 0)
            {
                foreach (FoodMaster objFm in objfood)
                {
                    ListViewItem itm = new ListViewItem(objFm.FoodID);
                    itm.SubItems.Add(objFm.FoodName);
                    itm.SubItems.Add(objFm.Price.ToString());
                    lvwMenuItemSetup.Items.Add(itm);
                }
            }

        }
        private void SearchListView(IEnumerable<FoodMaster> tests, string searchString = "")
        {
            IEnumerable<FoodMaster> query;
            if (!(searchString.Length > 0))
            {
                query = tests;
            }
            else
            {
                query = (from test in tests
                         where test.CatID.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                         select test);

            }
            lvwMenuItemSetup.Items.Clear();
            foreach (FoodMaster objFm in query)
            {
                ListViewItem itm = new ListViewItem(objFm.FoodID);
                itm.SubItems.Add(objFm.FoodName);
                itm.SubItems.Add(objFm.Price.ToString());
                lvwMenuItemSetup.Items.Add(itm);
              
            }
        }
        private void cboMenuId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboMenuId.Text.ToString() != "--Select--")
            //{
            //    LoadFoodItemsetup();
            //    SearchListView(objfood, cboMenuId.SelectedValue.ToString());
            //}
        }
        private void lvwMenuItemSetup_ItemCheck(object sender, ItemCheckEventArgs e)
        {
          
        }
        private void lvwMenuItemSetup_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            Calculatetotal();
        }
        private bool ValidateFields()
        {

            //List<string> vf = new List<string>() { "txtDietCategory" };
            //Control control = Utility.ReqFieldValidator(this, vf);
            //if (control != null)
            //{
            //    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    control.Focus();
            //    return false;
            //}
            if (cboMenuId.Text =="--Select--")
            {
                MessageBox.Show("Cannot Empty");
                cboMenuId.Focus();
                return false;
            }
            if (cbotypeId.Text == "--Select--")
            {
                MessageBox.Show("Cannot Empty");
                cbotypeId.Focus();
                return false;
            }

            return true;
        }
        private void LoadListView()
        {
            lvwFoodList.Items.Clear();
            List<FoodMenuItemSetup> Io = fnbs.LoadFoodItemrate().ToList();
            {
                foreach (FoodMenuItemSetup objitem in Io)
                {
                    ListViewItem itm = new ListViewItem(objitem.FoodMenuID);
                    itm.SubItems.Add(objitem.FoodMenuName);
                    itm.SubItems.Add(objitem.FoodTypeID);
                    itm.SubItems.Add(objitem.Remarks);
                    lvwFoodList.Items.Add(itm);
                }
            }
        }
        private FoodMenuItemSetup PopulatefoodMenu()
        {
            FoodMenuItemSetup objItem = new FoodMenuItemSetup();
          
           objItem.FoodMenuID = cboMenuId.SelectedValue.ToString();
           objItem.FoodTypeID = cbotypeId.SelectedValue.ToString();
           
            if (txtRemarks.Text != "")
            {
                objItem.Remarks = txtRemarks.Text;
            }
            else
            {
                objItem.Remarks = "";
            }

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objItem.EntryParameter = ep;
            return objItem;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int j=0;
            string strFoodID = "";
            double dblRate = 0;
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    FoodMenuItemSetup objcat = this.PopulatefoodMenu();

                    for (int i = 0; i < lvwMenuItemSetup.Items.Count; i++)
                    {
                        if (lvwMenuItemSetup.Items[i].Checked == true)
                        {
                            strFoodID = lvwMenuItemSetup.Items[i].SubItems[0].Text.ToString();
                            dblRate = Convert.ToDouble(lvwMenuItemSetup.Items[i].SubItems[2].Text);
                            j = fnbs.InsertFoodRateItem(strFoodID, dblRate, objcat);
                        }
                    }

                    //int i = fnbs.InsertDietcat(objcat);
                    if (j == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadListView();
                        txtRemarks.Text = "";
                        cboMenuId.Focus();
                        LoadFoodItemsetup();
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
            int j = 0;
            if (ValidateFields() == false)
            {
                return;
            }
            var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (strResponse == DialogResult.Yes)
            {

                FoodMenuItemSetup objcat = this.PopulatefoodMenu();

                string strFoodID = "";
                double dblRate = 0;
                int k = fnbs.UpdateFoodRateItem(strFoodID, dblRate, objcat);
                if (k > 0)
                {
                    for (int i = 0; i < lvwMenuItemSetup.Items.Count; i++)
                    {
                        if (lvwMenuItemSetup.Items[i].Checked == true)
                        {
                            strFoodID = lvwMenuItemSetup.Items[i].SubItems[0].Text.ToString();
                            dblRate = Convert.ToDouble(lvwMenuItemSetup.Items[i].SubItems[2].Text);
                            j = fnbs.InsertFoodRateItem(strFoodID, dblRate, objcat);
                        }
                    }
                }

                //int i = fnbs.InsertDietcat(objcat);
                if (j == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    LoadListView();
                    txtRemarks.Text = "";
                    cboMenuId.Focus();
                    LoadFoodItemsetup();
                    btnSave.Enabled = true;
                    btnEdit.Enabled = false;

                }

            }
        }
        private void lvwFoodList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwFoodList.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                cboMenuId.Enabled = false;
                for (int i = 0; i < lvwMenuItemSetup.Items.Count; i++)
                {
                        lvwMenuItemSetup.Items[i].Checked = false;
                    
                }

                ListViewItem itm = lvwFoodList.SelectedItems[0];
                cboMenuId.SelectedValue  = itm.SubItems[0].Text;
                cbotypeId.SelectedValue = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
                cbotypeId.Focus();
                List<FoodMenuItemSetup> objFIS = fnbs.DisplayFoodItemrate(itm.SubItems[0].Text).ToList();
                foreach (FoodMenuItemSetup fs in objFIS)
                {
                    ListViewItem itm1 = new ListViewItem(fs.FoodItemID);
                    for (int i = 0; i < lvwMenuItemSetup.Items.Count; i++)
                    {
                        if (fs.FoodItemID.ToString() == lvwMenuItemSetup.Items[i].Text)
                        {
                            lvwMenuItemSetup.Items[i].Checked = true;
                        }
                    }

                }


            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            cboMenuId.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            for (int i = 0; i < lvwMenuItemSetup.Items.Count; i++)
            {
                 lvwMenuItemSetup.Items[i].Checked = false;
            }
        }
        #endregion

        private void btnType_Click(object sender, EventArgs e)
        {
            frmFoodMenuSetup frm = new frmFoodMenuSetup();
            frm.ShowDialog();
        }

        private void btnTypeRefresh_Click(object sender, EventArgs e)
        {
            cboMenuId.ValueMember = "Key";
            cboMenuId.DisplayMember = "Value";
            cboMenuId.DataSource = new BindingSource(fnbs.GetFoodMenuItemSetup(), null);
        }

        private void btnType1_Click(object sender, EventArgs e)
        {
            frmfoodMenutype frm = new frmfoodMenutype();
            frm.ShowDialog();
        }

        private void btnTypeRefresh1_Click(object sender, EventArgs e)
        {
            cbotypeId.ValueMember = "Key";
            cbotypeId.DisplayMember = "Value";
            cbotypeId.DataSource = new BindingSource(fnbs.GetFoodTypeSetup(), null);
        }

    }
}
