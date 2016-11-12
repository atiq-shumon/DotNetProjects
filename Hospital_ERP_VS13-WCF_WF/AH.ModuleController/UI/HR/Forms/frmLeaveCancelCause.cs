using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using AH.DUtility;
using AH.ModuleController.HRSR;
using System.Drawing.Drawing2D;
using System.IO;

using System.Drawing.Imaging;
using AH.ModuleController.UI.HR.Reports.Viewer;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmLeaveCancelCause : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmLeaveCancelCause()
        {
            InitializeComponent();
        }

        private LeaveCancelCause PopulateLeaveCancelCause()
        {
            LeaveCancelCause oLvCanCause = new LeaveCancelCause();
            oLvCanCause.CauseId = txtCauseID.Text;
            oLvCanCause.CauseTitle = txtCauseTitle.Text;
            oLvCanCause.CauseTitleBeng = txtCauseTitleBeng.Text;
            oLvCanCause.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oLvCanCause.EntryParameter = ep;
            return oLvCanCause;

        }
        private void FormatGrid()
        {
            lvLeaveCancelCause.CheckBoxes = false;
            lvLeaveCancelCause.Columns.Add("Cause ID", 100, HorizontalAlignment.Center);
            lvLeaveCancelCause.Columns.Add("Cause Title", 200, HorizontalAlignment.Left);
            lvLeaveCancelCause.Columns.Add("Cause Title(Bangla)", 200, HorizontalAlignment.Left);
            lvLeaveCancelCause.Columns.Add("Remarks", 350, HorizontalAlignment.Left);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtCauseTitle", "txtCauseTitleBeng"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvLeaveCancelCause, 1, txtCauseTitle.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name");
                    txtCauseTitle.Focus();
                    return;
                }
                else
                {
                    LeaveCancelCause oLvCanCause = this.PopulateLeaveCancelCause();
                    short i = hmsSC.SaveLeaveCancelCause(oLvCanCause);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);                       
                        RefreshGrid();
                        txtCauseTitle.Text = "";
                        txtCauseTitleBeng.Text = "";
                        txtRemarks.Text = "";
                        txtCauseTitle.Focus();
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

        private void frmLeaveCancelCause_Load(object sender, EventArgs e)
        {
            FormatGrid();
            RefreshGrid();
            txtCauseTitle.Focus();
        }

        private void LoadListView()
        {
            lvLeaveCancelCause.Items.Clear();
            List<LeaveCancelCause> oLvCancelCauses = new List<LeaveCancelCause>();
            oLvCancelCauses = hmsSC.GetLeaveCancelCause().ToList();
            foreach (LeaveCancelCause oLvCancelCause in oLvCancelCauses)
            {
                ListViewItem itm = new ListViewItem(oLvCancelCause.CauseId);
                itm.SubItems.Add(oLvCancelCause.CauseTitle);
                itm.SubItems.Add(oLvCancelCause.CauseTitleBeng);
                itm.SubItems.Add(oLvCancelCause.Remarks);
                lvLeaveCancelCause.Items.Add(itm);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtCauseID", "txtCauseTitle", "txtCauseTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                LeaveCancelCause oLvCancelCause = this.PopulateLeaveCancelCause();
                short i = hmsSC.UpdateLeaveCancelCause(oLvCancelCause);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    txtCauseTitle.Text = "";
                    txtCauseTitleBeng.Text = "";
                    txtRemarks.Text = "";
                    txtCauseTitle.Focus();
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

        private void lvLeaveCancelCause_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLeaveCancelCause.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvLeaveCancelCause.SelectedItems[0];
                txtCauseID.Text = itm.SubItems[0].Text;
                txtCauseTitle.Text = itm.SubItems[1].Text;
                txtCauseTitleBeng.Text = itm.SubItems[2].Text;              
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void lvLeaveCancelCause_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtCauseTitle_TextChanged(object sender, EventArgs e)
        {
            txtCauseTitleBeng.Text = txtCauseTitle.Text;
        }
    }
}
