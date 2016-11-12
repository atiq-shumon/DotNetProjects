using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.DMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.DMS.Forms
{
    public partial class frmResHeadUnit : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSc = new DMSSR.DMSWSClient();
        public frmResHeadUnit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtResUnitName", "txtResUnitNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                ResultHeadUnit runitobj = this.PopulateRsUnit();
                short i = dmsSc.SaveRshdUnit(runitobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
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
            lvResUnit.CheckBoxes = false;

            lvResUnit.Columns.Add("Unit ID", 150, HorizontalAlignment.Left);
            lvResUnit.Columns.Add("Unit Name", 200, HorizontalAlignment.Left);
            lvResUnit.Columns.Add("Unit Name(Bangla)", 200, HorizontalAlignment.Left);
            lvResUnit.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
        }
        private ResultHeadUnit PopulateRsUnit()
        {
            ResultHeadUnit runitobj = new ResultHeadUnit();
            runitobj.UnitID = txtResUnitID.Text;
            runitobj.UnitTitle = txtResUnitName.Text;
            runitobj.UnitTitleBeng = txtResUnitNameBeng.Text;
            runitobj.Remarks = txtResRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            runitobj.EntryParameter = ep;

            return runitobj;
        }
        private void frmResHeadUnit_Load(object sender, EventArgs e)
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
            lvResUnit.Items.Clear();

            List<ResultHeadUnit> rsunit = dmsSc.GetResUnit().ToList();
            int i = 0;
            foreach (ResultHeadUnit runit in rsunit)
            {
                ListViewItem itm = new ListViewItem(runit.UnitID);
                itm.SubItems.Add(runit.UnitTitle);
                itm.SubItems.Add(runit.UnitTitleBeng);
                itm.SubItems.Add(runit.Remarks);
                lvResUnit.Items.Add(itm);
            }
        }

        private void lvResUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvResUnit.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvResUnit.SelectedItems[0];
                txtResUnitID.Text = itm.SubItems[0].Text;
                txtResUnitName.Text = itm.SubItems[1].Text;
                txtResUnitNameBeng.Text = itm.SubItems[2].Text;
                txtResRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtResUnitName", "txtResUnitNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dmsSc.VerifyResUnit(txtResUnitID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResUnitID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                ResultHeadUnit runitobj = this.PopulateRsUnit();
                short i = dmsSc.UpdateResUnit(runitobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
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

        private void lvResUnit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtResUnitName_TextChanged(object sender, EventArgs e)
        {
            txtResUnitNameBeng.Text = txtResUnitName.Text;
        }
    }
}
