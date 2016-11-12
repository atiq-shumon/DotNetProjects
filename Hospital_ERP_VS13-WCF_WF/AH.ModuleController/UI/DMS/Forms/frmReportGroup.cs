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
    public partial class frmReportGroup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSc = new DMSSR.DMSWSClient();
        public frmReportGroup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDepartment","cboSection" ,"txtGroupName", "txtGroupNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                ReportGroup repobj = this.PopulateRepGrp();
                short i = dmsSc.SaveReportGr(repobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtGroupName.Focus();
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
            if (cboDepartment.SelectedValue.ToString() != "")
            {
                if (cboSection.SelectedValue.ToString() != "")
                {
                    LoadListView(cboDepartment.SelectedValue.ToString(), cboSection.SelectedValue.ToString());
                }
            }
        }

        private void FormatGrid()
        {
            lvRepGr.CheckBoxes = false;

            lvRepGr.Columns.Add("Group ID", 150, HorizontalAlignment.Center);
            lvRepGr.Columns.Add("Group Name", 200, HorizontalAlignment.Left);
            lvRepGr.Columns.Add("Group Name(Bangla)", 200, HorizontalAlignment.Left);
            lvRepGr.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
            lvRepGr.Columns.Add("Department ID", 0, HorizontalAlignment.Center);
            lvRepGr.Columns.Add("Section ID", 0, HorizontalAlignment.Center);
        }

        private ReportGroup PopulateRepGrp()
        {
            ReportGroup repobj = new ReportGroup();
            repobj.ReportGroupID = txtGroupID.Text;
            repobj.ReportGroupTitle = txtGroupName.Text;
            repobj.ReportGroupTitleBeng = txtGroupNameBeng.Text;
            repobj.Remarks = txtRemarks.Text;

            Department dpt = new Department();
            dpt.DepartmentID = cboDepartment.SelectedValue.ToString();
            repobj.Department = dpt;

            ReportSection oRpt = new ReportSection();
            oRpt.ReportSectionID = cboSection.SelectedValue.ToString();
            repobj.ReportSection = oRpt;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            repobj.EntryParameter = ep;



            return repobj;
        }

        private void frmReportGroup_Load(object sender, EventArgs e)
        {
            try
            {
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(dmsSc.GetDepartments("D"), null);

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
        private void LoadListView(string Dept,string Sec)
        {
            try
            {
                lvRepGr.Items.Clear();
                if (cboDepartment.SelectedValue != "")
                {
                    if (cboSection.SelectedValue != "")
                    {
                        List<ReportGroup> rptgr = dmsSc.GetRptgrpDet(cboDepartment.SelectedValue.ToString(), cboSection.SelectedValue.ToString()).ToList();
                        foreach (ReportGroup rpt in rptgr)
                        {
                            ListViewItem itm = new ListViewItem(rpt.ReportGroupID);
                            itm.SubItems.Add(rpt.ReportGroupTitle);
                            itm.SubItems.Add(rpt.ReportGroupTitleBeng);
                            itm.SubItems.Add(rpt.Remarks);
                            itm.SubItems.Add(rpt.Department.DepartmentID);
                            itm.SubItems.Add(rpt.ReportSection.ReportSectionID);
                            lvRepGr.Items.Add(itm);
                        }
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

        private void lvRepGr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRepGr.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvRepGr.SelectedItems[0];
                txtGroupID.Text = itm.SubItems[0].Text;
                txtGroupName.Text = itm.SubItems[1].Text;
                txtGroupNameBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
                cboDepartment.SelectedValue = itm.SubItems[4].Text;
                cboSection.SelectedValue = itm.SubItems[5].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDepartment", "cboSection", "txtGroupName", "txtGroupNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dmsSc.VerifyReportGroup(txtGroupID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGroupID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                ReportGroup repobj = this.PopulateRepGrp();
                short i = dmsSc.UpdateReportGr(repobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtGroupName.Focus();
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

        private void lvRepGr_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            lvRepGr.Items.Clear();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboSection.DisplayMember = "Value";
                cboSection.ValueMember = "Key";
                cboSection.DataSource = new BindingSource(dmsSc.GetRptSecSetup(cboDepartment.SelectedValue.ToString()), null);
            }
            //RefreshGrid();
        }

        private void cboSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {
            txtGroupNameBeng.Text = txtGroupName.Text;
        }

    }
}
