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
    public partial class frmResHeadGroup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSc = new DMSSR.DMSWSClient();
        public string DeptID { set; get; }
        public string SecID { set; get; }
        public frmResHeadGroup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() {"cboDepartment","cboSection", "txtHeadGroupName", "txtHeadGroupNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                ResultHeadGroup rshdgrobj = this.PopulateReshdGrp();
                if (Utility.IsDuplicateFoundInList(lvResHdGr, 1, txtHeadGroupName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHeadGroupName.Focus();
                    return;
                }
                else
                {
                    short i = dmsSc.SaveReshdGr(rshdgrobj);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // btnNew.PerformClick();
                        RefreshGrid();
                        RefreshGrid();
                        txtHeadGroupName.Text = "";
                        txtHeadGroupNameBeng.Text = "";
                        txtRemarks.Text = "";
                        chkVisible.Checked = false;
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
            if (cboDepartment.SelectedValue != "")
            {
                if (cboSection.SelectedValue != "")
                {
                    LoadListView(cboDepartment.SelectedValue.ToString(), cboSection.SelectedValue.ToString());
                }
            }
            
        }

        private void FormatGrid()
        {
            lvResHdGr.CheckBoxes = false;
            lvResHdGr.Columns.Add("Group ID", 150, HorizontalAlignment.Left);
            lvResHdGr.Columns.Add("Group Name", 200, HorizontalAlignment.Left);
            lvResHdGr.Columns.Add("Group Name(Bangla)", 200, HorizontalAlignment.Left);
            lvResHdGr.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
            lvResHdGr.Columns.Add("Department", 0, HorizontalAlignment.Left);
            lvResHdGr.Columns.Add("Section", 0, HorizontalAlignment.Left);
            lvResHdGr.Columns.Add("Visible", 0, HorizontalAlignment.Left);
        }
        private ResultHeadGroup PopulateReshdGrp()
        {
            ResultHeadGroup rshdgr = new ResultHeadGroup();
            rshdgr.ResultHeadGroupID = txtHeadGroupID.Text;
            rshdgr.ResultHeadGroupTitle = txtHeadGroupName.Text;
            rshdgr.ResultHeadGroupTitleBeng = txtHeadGroupNameBeng.Text;
            rshdgr.Remarks = txtRemarks.Text;
            if(chkVisible.Checked==true)
            {
                rshdgr.IsVisible = "1";
            }
            if (chkVisible.Checked == false)
            {
                rshdgr.IsVisible = "0";
            }
            Department oDept = new Department();
            oDept.DepartmentID = cboDepartment.SelectedValue.ToString();
            rshdgr.Department = oDept;
            ReportSection oRptSec = new ReportSection();
            oRptSec.ReportSectionID = cboSection.SelectedValue.ToString();
            rshdgr.ReportSection = oRptSec;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            rshdgr.EntryParameter = ep;

            return rshdgr;
        }

        private void frmResHeadGroup_Load(object sender, EventArgs e)
        {
            try
            {
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(dmsSc.GetDepartments("D"), null);
                FormatGrid();
                if (DeptID != null)
                {
                    cboDepartment.SelectedValue = DeptID;
                    if (SecID != null)
                    {
                        cboSection.SelectedValue = SecID;
                    }
                }
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
        private void LoadListView(string Dept,string Section)
        {
            try
            {
                lvResHdGr.Items.Clear();
                if (cboDepartment.SelectedValue != "")
                {
                    if (cboSection.SelectedValue != "")
                    {
                        List<ResultHeadGroup> reshdgr = dmsSc.GetResultHeaddGrp(cboDepartment.SelectedValue.ToString(), cboSection.SelectedValue.ToString()).ToList();
                        foreach (ResultHeadGroup rshd in reshdgr)
                        {
                            ListViewItem itm = new ListViewItem(rshd.ResultHeadGroupID);
                            itm.SubItems.Add(rshd.ResultHeadGroupTitle);
                            itm.SubItems.Add(rshd.ResultHeadGroupTitleBeng);
                            itm.SubItems.Add(rshd.Remarks);
                            itm.SubItems.Add(rshd.Department.DepartmentID);
                            itm.SubItems.Add(rshd.ReportSection.ReportSectionID);
                            itm.SubItems.Add(rshd.IsVisible);
                            lvResHdGr.Items.Add(itm);
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
        private void lvResHdGr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvResHdGr.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvResHdGr.SelectedItems[0];
                txtHeadGroupID.Text = itm.SubItems[0].Text;
                txtHeadGroupName.Text = itm.SubItems[1].Text;
                txtHeadGroupNameBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
                cboDepartment.SelectedValue = itm.SubItems[4].Text;
                cboSection.SelectedValue = itm.SubItems[5].Text;
                if (itm.SubItems[6].Text == "1")
                {
                    chkVisible.Checked = true;
                }
                if (itm.SubItems[6].Text == "0")
                {
                    chkVisible.Checked = false;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtHeadGroupID", "cboDepartment", "cboSection", "txtHeadGroupName", "txtHeadGroupNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dmsSc.VerifyResHdGrp(txtHeadGroupID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHeadGroupID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                ResultHeadGroup rshdgrobj = this.PopulateReshdGrp();
                short i = dmsSc.UpdateReshdGr(rshdgrobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    RefreshGrid();
                    txtHeadGroupName.Text = "";
                    txtHeadGroupNameBeng.Text = "";
                    txtRemarks.Text = "";
                    chkVisible.Checked = false;
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

        private void lvResHdGr_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            lvResHdGr.Items.Clear();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboSection.DisplayMember = "Value";
                cboSection.ValueMember = "Key";
                cboSection.DataSource = new BindingSource(dmsSc.GetRptSecSetup(cboDepartment.SelectedValue.ToString()), null);
            }
        }

        private void cboSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void txtHeadGroupName_TextChanged(object sender, EventArgs e)
        {
            txtHeadGroupNameBeng.Text = txtHeadGroupName.Text;
        }

    }
}
