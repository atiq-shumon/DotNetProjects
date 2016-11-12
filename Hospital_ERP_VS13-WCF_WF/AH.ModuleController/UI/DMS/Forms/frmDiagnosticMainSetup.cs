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
    public partial class frmDiagnosticMainSetup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        public string DepartmentID{ set; get; }
        public string GroupID { set; get; }
        public frmDiagnosticMainSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboGroupID", "cboDeptID", "txtMainTitle", "txtMainTitleBeng"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                TestMain tmobj = this.PopulateTestMain();
                short i = dmsSC.SaveTestMain(tmobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    cboDeptID.Focus();
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
            lvDiagMain.CheckBoxes = false;
            lvDiagMain.Columns.Add("Main ID", 80, HorizontalAlignment.Center);
            lvDiagMain.Columns.Add("Main Name", 150, HorizontalAlignment.Left);
            lvDiagMain.Columns.Add("Main Name(Bangla)", 150, HorizontalAlignment.Left);
            lvDiagMain.Columns.Add("Group ID", 0, HorizontalAlignment.Left);
            lvDiagMain.Columns.Add("Group Name", 130, HorizontalAlignment.Left);
            lvDiagMain.Columns.Add("Department ID",0, HorizontalAlignment.Left);
            lvDiagMain.Columns.Add("Department", 130, HorizontalAlignment.Left);
            lvDiagMain.Columns.Add("Remarks", 200, HorizontalAlignment.Left);

        }

        private TestMain PopulateTestMain()
        {
            TestMain tmObj = new TestMain();
            tmObj.TestMainID = txtMainID.Text;
            tmObj.TestMainTitle = txtMainTitle.Text;
            tmObj.Remarks = txtRemarks.Text;
            tmObj.TestMainTitleBeng = txtMainTitleBeng.Text;
            TestGroup tg = new TestGroup();
            tg.GroupId = cboGroupID.SelectedValue.ToString();
            tmObj.TestGroup = tg; 
            
            Department dept = new Department();
            dept.DepartmentID= cboDeptID.SelectedValue.ToString();
            tmObj.TestDepartment = dept;
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            tmObj.EntryParameter = ep;

            return tmObj;
        }

        private void frmDiagnosticMainSetup_Load(object sender, EventArgs e)
        {
            try
            {
                cboDeptID.DisplayMember = "Value";
                cboDeptID.ValueMember = "Key";
                cboDeptID.DataSource = new BindingSource(dmsSC.GetDepartments("D"), null);

                FormatGrid();
                LoadListView();

                if (DepartmentID != null)
                {
                    cboDeptID.SelectedValue = DepartmentID;
                    cboGroupID.SelectedValue = GroupID;
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
        private void LoadListView()
        {
            lvDiagMain.Items.Clear();

            List<TestMain> tmain = dmsSC.GetTestMain().ToList();
            foreach (TestMain tm in tmain)
            {
                ListViewItem itm = new ListViewItem(tm.TestMainID);
                itm.SubItems.Add(tm.TestMainTitle);
                itm.SubItems.Add(tm.TestMainTitleBeng);
                itm.SubItems.Add(tm.TestGroup.GroupId.ToString());
                itm.SubItems.Add(tm.TestGroup.GroupTitle.ToString());
                itm.SubItems.Add(tm.TestDepartment.DepartmentID.ToString());
                itm.SubItems.Add(tm.TestDepartment.DepartmentTitle.ToString());
                itm.SubItems.Add(tm.Remarks);
                lvDiagMain.Items.Add(itm);
            }

        }

        private void cboDeptID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDeptID.SelectedValue != "")
            {
                cboGroupID.DisplayMember = "Value";
                cboGroupID.ValueMember = "Key";
                cboGroupID.DataSource = new BindingSource(Utility.VerifyDic(dmsSC.GetDiagnGrpDeptWise("D", cboDeptID.SelectedValue.ToString())), null);
            }
        }

        private void lvDiagMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDiagMain.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDiagMain.SelectedItems[0];
                txtMainID.Text = itm.SubItems[0].Text;
                txtMainTitle.Text = itm.SubItems[1].Text;
                txtMainTitleBeng.Text = itm.SubItems[2].Text;
                cboGroupID.SelectedValue = itm.SubItems[3].Text;
                cboDeptID.SelectedValue  = itm.SubItems[5].Text;
               
                txtRemarks.Text = itm.SubItems[7].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboGroupID", "cboDeptID", "txtMainTitle", "txtMainTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dmsSC.VerifyTestMain(txtMainID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMainID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                TestMain tmain = this.PopulateTestMain();
                short i = dmsSC.UpdateTestMain(tmain);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    txtMainTitle.Focus();
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

        private void lvDiagMain_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboDeptID.SelectedValue != "" && cboGroupID.SelectedValue != null)
                {
                    lvDiagMain.Items.Clear();

                    List<TestMain> tmain = dmsSC.GetMainDeptGroupwiseList(cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString()).ToList();
                    foreach (TestMain tm in tmain)
                    {
                        ListViewItem itm = new ListViewItem(tm.TestMainID);
                        itm.SubItems.Add(tm.TestMainTitle);
                        itm.SubItems.Add(tm.TestMainTitleBeng);
                        itm.SubItems.Add(tm.TestGroup.GroupId.ToString());
                        itm.SubItems.Add(tm.TestGroup.GroupTitle.ToString());
                        itm.SubItems.Add(tm.TestDepartment.DepartmentID.ToString());
                        itm.SubItems.Add(tm.TestDepartment.DepartmentTitle.ToString());
                        itm.SubItems.Add(tm.Remarks);
                        lvDiagMain.Items.Add(itm);
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

        private void txtMainTitle_TextChanged(object sender, EventArgs e)
        {
            txtMainTitleBeng.Text = txtMainTitle.Text;
        }
    }
}
