using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.INVMSSR;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmIssueType : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();

        public frmIssueType()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            
            lvIssueType.CheckBoxes = false;
            lvIssueType.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lvIssueType.Columns.Add("Name", 275, HorizontalAlignment.Left);
            lvIssueType.Columns.Add("Remarks", 350, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvIssueType.Items.Clear();

            List<IssueType> otype = invSr.GetIssueType().ToList();

            int i = 0;

            foreach (IssueType issue in otype)
            {
                ListViewItem itm = new ListViewItem(issue.ID);
                itm.SubItems.Add(issue.Name);
                itm.SubItems.Add(issue.Remarks);
                lvIssueType.Items.Add(itm);
            }
        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void frmIssueType_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadListView();
            btnEdit.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtTypeName"};
            Control control = Utility.ReqFieldValidator(this, vf);
            
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(Utility.IsDuplicateFoundInList(lvIssueType,1,txtTypeName.Text))
            {
                MessageBox.Show("This Type name has already been added");
                return;
            }
            try
            {
                IssueType gr = this.populateIssueSetup();
                short i = invSr.SaveIssueType(gr);

                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtTypeName.Select();
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
        private IssueType populateIssueSetup()
        {
            IssueType oissue = new IssueType();
            oissue.ID = txtTypeID.Text;
            oissue.Name = txtTypeName.Text;
            oissue.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oissue.EntryParameter = ep;

            return oissue;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtTypeName", "txtRemarks" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                IssueType gr = this.populateIssueSetup();
                short i = invSr.ModifyIssueType(gr);

                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtTypeName.Select();
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

        private void lvIssueType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvIssueType.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvIssueType.SelectedItems[0];
                txtTypeID.Text = itm.SubItems[0].Text;
                txtTypeName.Text = itm.SubItems[1].Text;
                txtRemarks.Text = itm.SubItems[2].Text;
            }
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }
    }
}
