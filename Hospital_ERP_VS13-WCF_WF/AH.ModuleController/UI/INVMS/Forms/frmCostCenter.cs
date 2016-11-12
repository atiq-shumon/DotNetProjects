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
    public partial class frmCostCenter : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();

        public frmCostCenter()
        {
            InitializeComponent();
        }

        private void frmCostCenter_Load(object sender, EventArgs e)
        {
            cboIssueType.ValueMember = "ID";
            cboIssueType.DisplayMember = "Name";
            cboIssueType.DataSource = new BindingSource(invSr.GetIssueType(), null);

            FormatGrid();
            LoadListView();
        }
        private void FormatGrid()
        {
            
            lvCostCenter.CheckBoxes = false;
            lvCostCenter.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lvCostCenter.Columns.Add("Name", 275, HorizontalAlignment.Left);
            lvCostCenter.Columns.Add("Issue Type", 275, HorizontalAlignment.Left);
            lvCostCenter.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvCostCenter.Items.Clear();

            List<CostCenter> ocost = invSr.GetCostCenter().ToList();

            int i = 0;

            foreach (CostCenter oc in ocost)
            {
                ListViewItem itm = new ListViewItem(oc.CostCenterID);
                itm.SubItems.Add(oc.CostCenterTitle);
                itm.SubItems.Add(oc.IssueType.Name);
                itm.SubItems.Add(oc.Remarks);
                lvCostCenter.Items.Add(itm);
            }
        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtCostCenterName"};
            Control control = Utility.ReqFieldValidator(this, vf);
            
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvCostCenter, 1, txtCostCenterName.Text))
            {
                MessageBox.Show("Already Exist");
                return;
            }
            try
            {
                CostCenter gr = this.populateCostCenter();
                short i = invSr.SaveCostCenter(gr);

                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtCostCenterName.Select();
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
        private CostCenter populateCostCenter()
        {
            CostCenter ocost = new CostCenter();
            ocost.CostCenterID = txtCostCenterID.Text;
            ocost.CostCenterTitle = txtCostCenterName.Text;
            ocost.Remarks = txtRemarks.Text;

            IssueType oissue = new IssueType();
            oissue.ID = cboIssueType.SelectedValue.ToString();
            ocost.IssueType = oissue;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            ocost.EntryParameter = ep;

            return ocost;
        }

        private void lvCostCenter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCostCenter.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvCostCenter.SelectedItems[0];
                
                txtCostCenterID.Text = itm.SubItems[0].Text;
                txtCostCenterName.Text = itm.SubItems[1].Text;
                cboIssueType.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtCostCenterName", "txtRemarks" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                CostCenter gr = this.populateCostCenter();
                short i = invSr.ModifyCostCenter(gr);

                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtCostCenterName.Select();
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
    }
}
