using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.AccountsMSSR;
using AH.DUtility;
namespace AH.ModuleController.UI.ACCMS.Forms
{
    public partial class frmCostCategory : AH.Shared.UI.frmSmartFormStandard
    {
        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();
        public frmCostCategory()
        {
            InitializeComponent();
        }

        #region "Validatefields"
        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "txtCategoryName" };
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
        #region "Category"
        private CostCategory PopulatecostCategory()
        {

            CostCategory objcategory = new CostCategory();
            if (txtCategorycode.Text.ToString() != "")
            {
                objcategory.Categorycode = txtCategorycode.Text.ToString();
            }
            objcategory.Categoryname = txtCategoryName.Text.ToString();

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objcategory.EntryParameter = ep;
            return objcategory;
        }
        #endregion
        #region "Save"
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            { 
            
            if (ValidateFields() == false)
            {
                return;
            }
            //var strResponse = MessageBox.Show("Do You want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (strResponse == DialogResult.Yes)
            //{

                CostCategory objcat = this.PopulatecostCategory();
                short i = accmSc.SaveCategorySetup(objcat);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtCategoryName.Focus();
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
        #endregion
        #region "Load"
        private void LoadListView()
        {
            lvwCategory.Items.Clear();
            List<CostCategory> cat = accmSc.GetCostCategory().ToList();
            if (cat.Count > 0)
            {
                foreach (CostCategory objcat in cat)
                {
                    ListViewItem itm = new ListViewItem(objcat.Categorycode);
                    itm.SubItems.Add(objcat.Categoryname.ToString());
                    lvwCategory.Items.Add(itm);
                }

            }
        }
        private void FormatGrid()
        {
            lvwCategory.CheckBoxes = false;
            lvwCategory.Columns.Add("Category Id", 260, HorizontalAlignment.Center);
            lvwCategory.Columns.Add("Category Name", 390, HorizontalAlignment.Left);
        }
        private void frmCostCategory_Load(object sender, EventArgs e)
        {
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
        #region "Edit/New"
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            { 
            
            if (ValidateFields() == false)
            {
                return;
            }
            //var strResponse = MessageBox.Show("Do You want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (strResponse == DialogResult.Yes)
            //{

                CostCategory objcat = this.PopulatecostCategory();
                short i = accmSc.UpdateCategorySetup(objcat);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtCategoryName.Focus();
                    LoadListView();
                    btnSave.Enabled = true;
                    btnEdit.Enabled = false;
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
            txtCategoryName.Focus();
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }
        #endregion
        #region "Category"
        private void txtCategoryName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (txtCategoryName.Text.Length > 1 && txtCategoryName.Text.Substring(txtCategoryName.Text.Length - 1, 1) == " ")
            {
                // convert first character to upper case after space
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
            }
            else if (txtCategoryName.Text.Length == 0)
            {
                // convert first character typed in texbox to upper case
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());

            }
            
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSave.Focus();
            }
        }
        #endregion 
        #region "Changed"
        private void lvwCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwCategory.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
                ListViewItem itm = lvwCategory.SelectedItems[0];
                txtCategorycode.Text = itm.SubItems[0].Text;
                txtCategoryName.Text = itm.SubItems[1].Text;
                txtCategoryName.Focus();
            }
        }
        #endregion
        #region "Delete"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                var strResponse = MessageBox.Show("Do U want to Delete?", "Delete Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    CostCategory objcat = this.PopulatecostCategory();
                    try
                    {
                        short i = accmSc.DeleteCategorySetup(lvwCategory.FocusedItem.SubItems[0].Text, objcat);
                        if (i == 0)
                        {
                            MessageBox.Show("Transaction Found Cannot Delete", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i > 0)
                        {
                            MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnNew.PerformClick();
                            //txtGroupName.Focus();
                            LoadListView();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Transaction Found Cannot Delete");
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

      
        //static string PropercaseFirst(string s)
        //{
        //    // Check for empty string.
        //    if (string.IsNullOrEmpty(s))
        //    {
        //        return string.Empty;
        //    }
        //    // Return char and concat substring.
        //    return char.ToUpper(s[0]) + s.Substring(1);
        //}
        //private void txtCategoryName_KeyUp(object sender, KeyEventArgs e)
        //{
        //    PropercaseFirst(txtCategoryName.Text);
        //}
    }
}
