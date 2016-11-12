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
    public partial class frmTestCancelCause : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        public frmTestCancelCause()
        {
            InitializeComponent();
        }

        private TestCancelCause PopulateCauseSetup()
        {
            TestCancelCause oTCanCause = new TestCancelCause();
            oTCanCause.CauseId = txtCauseID.Text;
            oTCanCause.CauseTitle = txtCauseName.Text;
            oTCanCause.CauseTitleBeng = txtCauseNameBeng.Text;
            oTCanCause.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oTCanCause.EntryParameter = ep;

            return oTCanCause;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtCauseName", "txtCauseNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
                if (Utility.IsDuplicateFoundInList(lvCause, 1, txtCauseName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCauseName.Focus();
                    return;
                }
                else
                {
                    TestCancelCause tcats = this.PopulateCauseSetup();
                    short i = dmsSC.SaveTestCancelCause(tcats);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtCauseName.Focus();
                        RefreshGrid();
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


        private void RefreshGrid()
        {
            LoadListView();
        }

        private void FormatGrid()
        {
            lvCause.CheckBoxes = false;
            lvCause.Columns.Add("Cause ID", 100, HorizontalAlignment.Center);
            lvCause.Columns.Add("Cause Name", 200, HorizontalAlignment.Left);
            lvCause.Columns.Add("Cause Name(Bangla)", 200, HorizontalAlignment.Left);
            lvCause.Columns.Add("Remarks", 340, HorizontalAlignment.Left);
        }

        private void LoadListView()
        {
            lvCause.Items.Clear();

            List<TestCancelCause> tfcats = dmsSC.GetCancelCause().ToList();
            int i = 0;
            foreach (TestCancelCause fcat in tfcats)
            {
                ListViewItem itm = new ListViewItem(fcat.CauseId);
                itm.SubItems.Add(fcat.CauseTitle.ToString());
                itm.SubItems.Add(fcat.CauseTitleBeng.ToString());
                itm.SubItems.Add(fcat.Remarks.ToString());
                lvCause.Items.Add(itm);
            }
        }

        private void lvCause_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCause.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvCause.SelectedItems[0];
                txtCauseID.Text = itm.SubItems[0].Text;
                txtCauseName.Text = itm.SubItems[1].Text;
                txtCauseNameBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void frmTestCancelCause_Load(object sender, EventArgs e)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtCauseID", "txtCauseName", "txtCauseNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }          
            try
            {
                TestCancelCause tcats = this.PopulateCauseSetup();
                short i = dmsSC.UpdateCancelCause(tcats);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtCauseName.Focus();
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

        private void lvCause_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtCauseName_TextChanged(object sender, EventArgs e)
        {
            txtCauseNameBeng.Text = txtCauseName.Text;
        }

    }
}
