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
    public partial class frmPanelSetup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        public frmPanelSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtPanelName", "txtPanelNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                GroupPanel tpobj = this.PopulateTestPanel();
                short i = dmsSC.SaveTestPanel(tpobj);
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
            lvPanel.CheckBoxes = false;
            lvPanel.Columns.Add("Panel ID", 150, HorizontalAlignment.Center);
            lvPanel.Columns.Add("Panel Name", 200, HorizontalAlignment.Left);
            lvPanel.Columns.Add("Panel Name(Bangla)", 200, HorizontalAlignment.Left);
            lvPanel.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
        }
        private GroupPanel PopulateTestPanel()
        {
            GroupPanel tpObj = new GroupPanel();
            tpObj.PanelID = txtPanelID.Text;
            tpObj.PanelTitle = txtPanelName.Text;
            tpObj.PanelTitleBeng = txtPanelNameBeng.Text;
            tpObj.Remarks = txtRemarks.Text;
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            tpObj.EntryParam = ep;
            return tpObj;
        }
        private void frmPanelSetup_Load(object sender, EventArgs e)
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
            lvPanel.Items.Clear();
            List<GroupPanel> panel = dmsSC.GetPanelSetup().ToList();
            int i = 0;
            foreach (GroupPanel pnl in panel)
            {
                ListViewItem itm = new ListViewItem(pnl.PanelID);
                itm.SubItems.Add(pnl.PanelTitle);
                itm.SubItems.Add(pnl.PanelTitleBeng);
                itm.SubItems.Add(pnl.Remarks);
                lvPanel.Items.Add(itm);

            }
        }

        private void lvPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPanel.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvPanel.SelectedItems[0];
                txtPanelID.Text = itm.SubItems[0].Text;
                txtPanelName.Text = itm.SubItems[1].Text;
                txtPanelNameBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtPanelName", "txtPanelNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                GroupPanel tpobj = this.PopulateTestPanel();
                short i = dmsSC.UpdateTestPanel(tpobj);
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

        private void lvPanel_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtPanelName_TextChanged(object sender, EventArgs e)
        {
            txtPanelNameBeng.Text = txtPanelName.Text;
        }
    }
}
