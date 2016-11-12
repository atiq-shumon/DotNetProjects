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
    public partial class frmQualitativeGroupSetup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSc = new DMSSR.DMSWSClient();
        public frmQualitativeGroupSetup()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            lvQualitativeGroup.CheckBoxes = false;
            lvQualitativeGroup.Columns.Add("Qualitative ID", 150, HorizontalAlignment.Center);
            lvQualitativeGroup.Columns.Add("Qualitative Name", 200, HorizontalAlignment.Left);
            lvQualitativeGroup.Columns.Add("Qualitative Name(Bangla)", 200, HorizontalAlignment.Left);
            lvQualitativeGroup.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvQualitativeGroup.Items.Clear();
            List<Qualitative> macs = dmsSc.GetQualitativeGrpSetup().ToList();
            foreach (Qualitative mac in macs)
            {
                ListViewItem itm = new ListViewItem(mac.GroupID);
                itm.SubItems.Add(mac.GroupTitle);
                itm.SubItems.Add(mac.GroupTitleBeng);
                itm.SubItems.Add(mac.Remarks);
                lvQualitativeGroup.Items.Add(itm);
            }
        }

        private void frmQualitativeGroupSetup_Load(object sender, EventArgs e)
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

        private void lvQualitativeGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvQualitativeGroup.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvQualitativeGroup.SelectedItems[0];
                txtGroupID.Text = itm.SubItems[0].Text;
                txtGroupName.Text = itm.SubItems[1].Text;
                txtGroupNameBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void lvQualitativeGroup_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
        private Qualitative PopulateQualitativeGroupSetup()
        {
            Qualitative mac = new Qualitative();
            mac.GroupID = txtGroupID.Text;
            mac.GroupTitle = txtGroupName.Text;
            mac.GroupTitleBeng = txtGroupNameBeng.Text;
            mac.Remarks = txtRemarks.Text;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            mac.EntryParameter = ep;
            return mac;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtGroupName", "txtGroupNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                Qualitative oMac = this.PopulateQualitativeGroupSetup();
                if (Utility.IsDuplicateFoundInList(lvQualitativeGroup, 1, txtGroupName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGroupName.Focus();
                    return;
                }
                else
                {
                    short i = dmsSc.SaveQualitativeGrpSetup(oMac);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        LoadListView();
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
            List<string> vf = new List<string>() { "txtGroupName", "txtGroupNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                Qualitative oMac = this.PopulateQualitativeGroupSetup();
                short i = dmsSc.UpdateQualitativeGrpSetup(oMac);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
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

        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {
            txtGroupNameBeng.Text = txtGroupName.Text;
        }

    }
}
