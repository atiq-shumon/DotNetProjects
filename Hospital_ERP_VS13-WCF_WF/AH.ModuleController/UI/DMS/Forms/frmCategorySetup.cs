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
    public partial class frmCategorySetup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        
        public frmCategorySetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtCatName", "txtCatNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
                TestCategory tcats = this.PopulateCatSetup();
                short i = dmsSC.SaveCategory(tcats);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtCatName.Focus();
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

        private void FormatGrid()
        {
            lvCategory.CheckBoxes = false;
            lvCategory.Columns.Add("Category ID", 100, HorizontalAlignment.Center);
            lvCategory.Columns.Add("Category Name", 200, HorizontalAlignment.Left);
            lvCategory.Columns.Add("Category Name(Bangla)", 200, HorizontalAlignment.Left);
            lvCategory.Columns.Add("Remarks", 340, HorizontalAlignment.Left);
        }

        private TestCategory PopulateCatSetup()
        {
            TestCategory tcatobj = new TestCategory();
            tcatobj.TestCategoryID = txtCategoryID.Text;
            tcatobj.TestCategoryTitle = txtCatName.Text;
            tcatobj.TestCategoryTitleBeng = txtCatNameBeng.Text;
            tcatobj.TestCategoryRemarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            tcatobj.EParameter = ep;

            return tcatobj;
        }

        private void frmCategorySetup_Load(object sender, EventArgs e)
        {
            try
            {
                FormatGrid();
                LoadListView();
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }

        }
        private void LoadListView()
        {
            lvCategory.Items.Clear();

            List<TestCategory> tfcats = dmsSC.GetCategories().ToList();
            int i = 0;
            foreach (TestCategory fcat in tfcats)
            {
                ListViewItem itm = new ListViewItem(fcat.TestCategoryID);
                itm.SubItems.Add(fcat.TestCategoryTitle.ToString());
                itm.SubItems.Add(fcat.TestCategoryTitleBeng.ToString());
                itm.SubItems.Add(fcat.TestCategoryRemarks.ToString());
                lvCategory.Items.Add(itm);
            }
        }
        private void lvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvCategory.SelectedItems[0];
                txtCategoryID.Text = itm.SubItems[0].Text;
                txtCatName.Text = itm.SubItems[1].Text;
                txtCatNameBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() {"txtCatName", "txtCatNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dmsSC.VerifyTestCat(txtCategoryID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnNew.PerformClick();
                return;
            }
            try
            {
                TestCategory tcats = this.PopulateCatSetup();
                short i = dmsSC.UpdateCategory(tcats);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtCatName.Focus();
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

        private void lvCategory_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtCatName_TextChanged(object sender, EventArgs e)
        {
            txtCatNameBeng.Text = txtCatName.Text;
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    cboBenefit.DisplayMember = "Value";
        //    cboBenefit.ValueMember = "Key";
        //    cboBenefit.DataSource = dmsSC.GetDmrTest(txtMR.Text).ToList();
        //}
    }
}
