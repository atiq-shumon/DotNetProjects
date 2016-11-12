using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.DMSSR;

namespace AH.ModuleController.UI.DMS.Forms
{
    public partial class frmFeeCategory : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        public frmFeeCategory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtFeeCatName", "txtFeeCatNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
                FeeCategory fcat = this.PopulateFeecat();
                short i = dmsSC.SaveFeeCategory(fcat);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtFeeCatName.Focus();
                    RefreshGrid();
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
        private void RefreshGrid()
        {
            LoadListView();
        }
        private FeeCategory PopulateFeecat()
        {
            FeeCategory fcatobj = new FeeCategory();
            fcatobj.FeeCategoryID = txtFeeCat.Text;
            fcatobj.FeeCategoryTitle = txtFeeCatName.Text;
            fcatobj.FeeCategoryTitleBeng = txtFeeCatNameBeng.Text;
            fcatobj.FeeCategoryRemarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            fcatobj.EParameter = ep;

            return fcatobj;
        }
        private void FormatGrid()
        {
            lvFeeCategory.CheckBoxes = false;

            lvFeeCategory.Columns.Add("Category ID", 150, HorizontalAlignment.Left);
            lvFeeCategory.Columns.Add("Category Name", 200, HorizontalAlignment.Left);
            lvFeeCategory.Columns.Add("Category Name(Bangla)", 200, HorizontalAlignment.Left);
            lvFeeCategory.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
        }
        private void frmFeeCategory_Load(object sender, EventArgs e)
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
        private void LoadListView()
        {
            lvFeeCategory.Items.Clear();

            List<FeeCategory> fcats = dmsSC.GetFeecats().ToList();
            int i = 0;
            foreach (FeeCategory feecat in fcats)
            {
                ListViewItem itm = new ListViewItem(feecat.FeeCategoryID);
                itm.SubItems.Add(feecat.FeeCategoryTitle);
                itm.SubItems.Add(feecat.FeeCategoryTitleBeng);
                itm.SubItems.Add(feecat.FeeCategoryRemarks);
                lvFeeCategory.Items.Add(itm);

            }

        }

        private void lvFeeCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFeeCategory.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvFeeCategory.SelectedItems[0];
                txtFeeCat.Text = itm.SubItems[0].Text;
                txtFeeCatName.Text = itm.SubItems[1].Text;
                txtFeeCatNameBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtFeeCatName", "txtFeeCatNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dmsSC.VerifyFeeCategory(txtFeeCat.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFeeCat.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                FeeCategory fcat = this.PopulateFeecat();
                short i = dmsSC.UpdateFeeCategory(fcat);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtFeeCatName.Focus();
                    RefreshGrid();
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

        private void lvFeeCategory_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtFeeCatName_TextChanged(object sender, EventArgs e)
        {
            txtFeeCatNameBeng.Text = txtFeeCatName.Text;
        }
    }
}
