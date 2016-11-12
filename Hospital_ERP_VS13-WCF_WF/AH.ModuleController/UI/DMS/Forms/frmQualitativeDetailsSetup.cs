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
    public partial class frmQualitativeDetailsSetup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSc = new DMSSR.DMSWSClient();
        public frmQualitativeDetailsSetup()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            lvQualitativeGroup.CheckBoxes = false;
            lvQualitativeGroup.Columns.Add("Group ID", 0, HorizontalAlignment.Center);
            lvQualitativeGroup.Columns.Add("Detail ID", 150, HorizontalAlignment.Center);
            lvQualitativeGroup.Columns.Add("Detail Name", 200, HorizontalAlignment.Left);
            lvQualitativeGroup.Columns.Add("Detail Name(Bangla)", 200, HorizontalAlignment.Left);
            lvQualitativeGroup.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
        }
        private void LoadListView(string Group)
        {
            lvQualitativeGroup.Items.Clear();
            List<QualitativeDetail> macs = dmsSc.GetQtGrpDetails(cboGroup.SelectedValue.ToString()).ToList();
            foreach (QualitativeDetail mac in macs)
            {
                ListViewItem itm = new ListViewItem(mac.Qualitative.GroupID);
                itm.SubItems.Add(mac.DetID);
                itm.SubItems.Add(mac.DetTitle);
                itm.SubItems.Add(mac.DetTitleBeng);
                itm.SubItems.Add(mac.Remarks);
                lvQualitativeGroup.Items.Add(itm);
            }
        }
        private void RefreshGrid()
        {
            LoadListView(cboGroup.SelectedValue.ToString());
        }

        private void frmQualitativeDetailsSetup_Load(object sender, EventArgs e)
        {
            try
            {
                cboGroup.DisplayMember = "Value";
                cboGroup.ValueMember = "Key";
                cboGroup.DataSource = new BindingSource(dmsSc.GetQualitativeGrp("D"), null);
                FormatGrid();
                RefreshGrid();
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
                cboGroup.SelectedValue = itm.SubItems[0].Text;
                txtDetID.Text = itm.SubItems[1].Text;
                txtDetTitle.Text = itm.SubItems[2].Text;
                txtDetNameBeng.Text = itm.SubItems[3].Text;
                txtRemarks.Text = itm.SubItems[4].Text;
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
        private QualitativeDetail PopulateQualitativeDetailsSetup()
        {
            QualitativeDetail mac = new QualitativeDetail();

            Qualitative qua = new Qualitative();
            qua.GroupID = cboGroup.SelectedValue.ToString();
            mac.Qualitative = qua;

            mac.DetID = txtDetID.Text.ToString();
            mac.DetTitle = txtDetTitle.Text;
            mac.DetTitleBeng = txtDetNameBeng.Text;
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
            List<string> vf = new List<string>() { "cboGroup", "txtDetTitle", "txtDetNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                QualitativeDetail oMac = this.PopulateQualitativeDetailsSetup();
                if (Utility.IsDuplicateFoundInList(lvQualitativeGroup, 1, txtDetTitle.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDetTitle.Focus();
                    return;
                }
                else
                {
                    short i = dmsSc.SaveQualitativeGrpDetailsSetup(oMac);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //btnNew.PerformClick();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboGroup", "txtDetTitle", "txtDetNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                QualitativeDetail oMac = this.PopulateQualitativeDetailsSetup();
                short i = dmsSc.UpdateQualitativeGrpDetailsSetup(oMac);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
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

        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void txtDetTitle_TextChanged(object sender, EventArgs e)
        {
            txtDetNameBeng.Text = txtDetTitle.Text;
        }
    }
}
