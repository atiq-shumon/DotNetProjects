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
    public partial class frmDiagnosticGroupSetup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        public string DepartmentId { set; get; }
        public frmDiagnosticGroupSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtGroupTitle", "cboDeptID", "txtGroupTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            //string i =  new  PatientRegistrationBLL().Save(txtPatientName.Text, txtFatherName.Text);
            try
            {
                TestGroup tgObj = this.PopulateTestGroup();
                short i = dmsSC.SaveTestGroup(tgObj);

                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    txtGroupID.Focus();
                    RefreshGrid();
                    btnShow_Click(sender, e);
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
            lvDiagGrp.CheckBoxes = false;
            lvDiagGrp.Columns.Add("Group ID", 100, HorizontalAlignment.Center);
            lvDiagGrp.Columns.Add("Group Name", 200, HorizontalAlignment.Left);
            lvDiagGrp.Columns.Add("Group Name(Bangla)", 200, HorizontalAlignment.Left);
            lvDiagGrp.Columns.Add("Department Name", 130, HorizontalAlignment.Left);
            //lvDiagGrp.Columns.Add("Department Name",130,HorizontalAlignment.Center);
            lvDiagGrp.Columns.Add("Remarks", 250, HorizontalAlignment.Left);


        }

        private TestGroup PopulateTestGroup()
        {

            TestGroup tgObj = new TestGroup();
            tgObj.GroupId = txtGroupID.Text;
            tgObj.GroupTitle = txtGroupTitle.Text;
            tgObj.GroupTitleBeng = txtGroupTitleBeng.Text;
            tgObj.Remarks = txtRemarks.Text;

            Department dept = new Department();
            dept.DepartmentID = cboDeptID.SelectedValue.ToString();
            tgObj.Department = dept;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            tgObj.EParameter = ep;

            //paep.Name = cboNamePrefixes.Text + " " + txtPatientName.Text;
            //patObj.NameBeng = txtNameBeng.Text;
            //patObj.FathersName = cboNamePrefiexesFat.Text + " " + txtFatherName.Text;
            //patObj.FathersNameBeng = txtFatherNameBeng.Text;
            //patObj.MothersName = cboNamePrefiexesMot.Text + " " + txtMotherName.Text;


            return tgObj;
        }
        private void smartLabel4_Click(object sender, EventArgs e)
        {

        }

        private void frmDiagnosticGroupSetup_Load(object sender, EventArgs e)
        {
            try
            {
                cboDeptID.DisplayMember = "Value";
                cboDeptID.ValueMember = "Key";
                cboDeptID.DataSource = new BindingSource(dmsSC.GetDepartments("D"), null);

                FormatGrid();
                LoadListView();
                if (DepartmentId != null)
                {
                    cboDeptID.SelectedValue = DepartmentId;
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
            lvDiagGrp.Items.Clear();

            List<TestGroup> tgrp = dmsSC.GetDiagnGrp().ToList();
            int i = 0;
            foreach (TestGroup tg in tgrp)
            {
                ListViewItem itm = new ListViewItem(tg.GroupId);
                itm.SubItems.Add(tg.GroupTitle);
                itm.SubItems.Add(tg.GroupTitleBeng);
                itm.SubItems.Add(tg.Department.DepartmentTitle);
                itm.SubItems.Add(tg.Remarks);
                lvDiagGrp.Items.Add(itm);
            }
        }

        private void lvDiagGrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDiagGrp.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDiagGrp.SelectedItems[0];
                txtGroupID.Text = itm.SubItems[0].Text;
                txtGroupTitle.Text = itm.SubItems[1].Text;
                txtGroupTitleBeng.Text = itm.SubItems[2].Text;
                cboDeptID.Text = itm.SubItems[3].Text;
                txtRemarks.Text = itm.SubItems[4].Text;

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtGroupTitle", "cboDeptID", "txtGroupTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }


            if (dmsSC.VerifyTestGroup(txtGroupID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGroupID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                TestGroup tgObj = this.PopulateTestGroup();
                short i = dmsSC.UpdateGroup(tgObj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    txtGroupTitle.Focus();
                    RefreshGrid();
                    btnShow_Click(sender, e);
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

        private void txtGroupID_Click(object sender, EventArgs e)
        {


        }

        private void lvDiagGrp_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
        private void clear()
        {
            txtGroupTitle.Text = "";
            txtGroupID.Text = "";
            txtGroupTitleBeng.Text = "";
            txtRemarks.Text = "";
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboDeptID.SelectedValue != "")
                {
                    lvDiagGrp.Items.Clear();
                    clear();

                    List<TestGroup> tgrp = dmsSC.GetDiagnGrpTest(cboDeptID.SelectedValue.ToString()).ToList();
                    foreach (TestGroup tg in tgrp)
                    {
                        ListViewItem itm = new ListViewItem(tg.GroupId);
                        itm.SubItems.Add(tg.GroupTitle);
                        itm.SubItems.Add(tg.GroupTitleBeng);
                        itm.SubItems.Add(tg.Department.DepartmentTitle);
                        itm.SubItems.Add(tg.Remarks);
                        lvDiagGrp.Items.Add(itm);
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

        private void txtGroupTitle_TextChanged(object sender, EventArgs e)
        {
            txtGroupTitleBeng.Text = txtGroupTitle.Text;
        }
    }
}
