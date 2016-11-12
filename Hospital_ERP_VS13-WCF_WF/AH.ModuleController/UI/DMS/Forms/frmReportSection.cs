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
    public partial class frmReportSection : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSc = new DMSSR.DMSWSClient();
        public frmReportSection()
        {
            InitializeComponent();
        }

        private void frmReportSection_Load(object sender, EventArgs e)
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
        private void RefreshGrid()
        {
            LoadListView(cboDepartment.SelectedValue.ToString());
        }

        private void FormatGrid()
        {
            lvRepSec.CheckBoxes = false;

            lvRepSec.Columns.Add("Section ID", 150, HorizontalAlignment.Center);
            lvRepSec.Columns.Add("Section Name", 200, HorizontalAlignment.Left);
            lvRepSec.Columns.Add("Section Name(Bangla)", 200, HorizontalAlignment.Left);
            lvRepSec.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
            lvRepSec.Columns.Add("Department ID", 0, HorizontalAlignment.Center);
        }
        private void LoadListView(string Dept)
        {
            try
            {
                lvRepSec.Items.Clear();
                if (cboDepartment.SelectedValue.ToString() != "")
                {
                    List<ReportSection> rptgr = dmsSc.GetReportSectionSetup(cboDepartment.SelectedValue.ToString()).ToList();
                    foreach (ReportSection rpt in rptgr)
                    {
                        ListViewItem itm = new ListViewItem(rpt.ReportSectionID);
                        itm.SubItems.Add(rpt.ReportSectionTitle);
                        itm.SubItems.Add(rpt.ReportSectionTitleBeng);
                        itm.SubItems.Add(rpt.Remarks);
                        itm.SubItems.Add(rpt.Department.DepartmentID);
                        lvRepSec.Items.Add(itm);

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
            if (lvRepSec.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvRepSec.SelectedItems[0];
                txtSectionID.Text = itm.SubItems[0].Text;
                txtSectionName.Text = itm.SubItems[1].Text;
                txtSectionNameBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
                cboDepartment.SelectedValue = itm.SubItems[4].Text;
            }
        }

        private void lvRepGr_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private ReportSection PopulateRepSection()
        {
            ReportSection repobj = new ReportSection();
            repobj.ReportSectionID = txtSectionID.Text;
            repobj.ReportSectionTitle = txtSectionName.Text;
            repobj.ReportSectionTitleBeng = txtSectionNameBeng.Text;
            repobj.Remarks = txtRemarks.Text;

            Department dpt = new Department();
            dpt.DepartmentID = cboDepartment.SelectedValue.ToString();
            repobj.Department = dpt;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            repobj.EntryParameter = ep;



            return repobj;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDepartment", "txtSectionName", "txtSectionNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                ReportSection repobj = this.PopulateRepSection();
                short i = dmsSc.SaveReportSection(repobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtSectionName.Focus();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDepartment", "txtSectionName", "txtSectionNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dmsSc.VerifyReportGroup(txtSectionID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSectionID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                ReportSection repobj = this.PopulateRepSection();
                short i = dmsSc.UpdateReportSection(repobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtSectionName.Focus();
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

        private void txtSectionName_TextChanged(object sender, EventArgs e)
        {
            txtSectionNameBeng.Text = txtSectionName.Text;
        }
    }
}
