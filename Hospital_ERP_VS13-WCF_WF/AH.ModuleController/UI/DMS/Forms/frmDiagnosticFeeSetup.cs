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
    public partial class frmDiagnosticFeeSetup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        public string DepartmentID { set; get; }
        public string GroupID { set; get; }
        public string MainID { set; get; }
        public string DetailID { set; get; }
        private List<TestFee> tsfee;
        private int s;
        public frmDiagnosticFeeSetup()
        {
            InitializeComponent();
        }

        private void grdFeeSetup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDeptID", "cboGroupID", "cboMainID", "cboFeeCatID", "cboDetailID", "txtFee", "txtDeptAmount", "txtReffAmount", "txtDocAmount", "txtVat", "txtDiscount" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dmsSC.VerifyTestFee(cboDetailID.SelectedValue.ToString()) == 1)
            {
                MessageBox.Show(Utility.VerifyMessage, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDeptID.Select();
                return;
            }
            try
            {
                TestFee tfobj = this.PopulateTestFee();
                short i = dmsSC.SaveTestFee(tfobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboDeptID.Focus();
                    RefreshGrid(cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString(), cboFeeCatID.SelectedValue.ToString());
                    DialogResult msg = MessageBox.Show("Result is not Mapping for this Test,Do You want to Map It Now???", "Mapping", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (msg == DialogResult.Yes)
                    {
                        frmResultHeadMappingWithTest oDiagMap = new frmResultHeadMappingWithTest();
                        oDiagMap.DepartmentID = cboDeptID.SelectedValue.ToString();
                        oDiagMap.GroupID = cboGroupID.SelectedValue.ToString();
                        oDiagMap.MainID = cboMainID.SelectedValue.ToString();
                        oDiagMap.DetailID = cboDetailID.SelectedValue.ToString();
                        oDiagMap.ShowDialog();
                    }
                    if (msg == DialogResult.No)
                    {
                        return;
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
        private void RefreshGrid(string deptId, string grpId, string mainId, string feecat)
        {
            LoadListView(deptId, grpId, mainId, feecat);
        }
        private void FormatGrid()
        {
            lvFee.CheckBoxes = false;
            lvFee.Columns.Add("TestName", 350, HorizontalAlignment.Left);
            lvFee.Columns.Add("TestMain", 240, HorizontalAlignment.Left);
            lvFee.Columns.Add("Fee", 100, HorizontalAlignment.Left);
            lvFee.Columns.Add("Dept Amt", 60, HorizontalAlignment.Left);
            lvFee.Columns.Add("RefrDept Amt", 60, HorizontalAlignment.Left);
            lvFee.Columns.Add("Doctor Fee", 60, HorizontalAlignment.Left);
            lvFee.Columns.Add("VAT", 50, HorizontalAlignment.Left);
            lvFee.Columns.Add("Disc", 55, HorizontalAlignment.Left);
            lvFee.Columns.Add("Group ID", 0, HorizontalAlignment.Center);
            lvFee.Columns.Add("Department", 0, HorizontalAlignment.Center);
            lvFee.Columns.Add("Fee Category", 0, HorizontalAlignment.Center);
            lvFee.Columns.Add("PanelID", 0, HorizontalAlignment.Center);
            lvFee.Columns.Add("TestDetID", 0, HorizontalAlignment.Center);
        }

        private TestFee PopulateTestFee()
        {
            TestFee tfObj = new TestFee();

            tfObj.Fee = decimal.Parse(txtFee.Text);
            tfObj.DeptFee = decimal.Parse(txtDeptAmount.Text);
            tfObj.RefdFee = decimal.Parse(txtReffAmount.Text);
            tfObj.DoctorFee = decimal.Parse(txtDocAmount.Text);
            tfObj.VAT = decimal.Parse(txtVat.Text);
            tfObj.Discount = decimal.Parse(txtDiscount.Text);

            TestSub tsObj = new TestSub();
            Department dept = new Department();
            dept.DepartmentID = cboDeptID.SelectedValue.ToString();
            tsObj.TestDepartment = dept;
            TestGroup tg = new TestGroup();
            tg.GroupId = cboGroupID.SelectedValue.ToString();
            tsObj.TestGroup = tg;
            tsObj.TestMainID = cboMainID.SelectedValue.ToString();
            tsObj.TestSubID = cboDetailID.SelectedValue.ToString();

            FeeCategory oFeeCat = new FeeCategory();
            oFeeCat.FeeCategoryID = cboFeeCatID.SelectedValue.ToString();
            tfObj.FeeCategory = oFeeCat;

            tfObj.TestSub = tsObj;


            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            tfObj.EParameter = ep;

            return tfObj;
        }

        private TestFee UpdateTestFee()
        {
            string string1 = "";
            TestFee tfObj = new TestFee();

            TestSub tsObj = new TestSub();
            Department dept = new Department();
            dept.DepartmentID = cboDeptID.SelectedValue.ToString();
            tsObj.TestDepartment = dept;
            TestGroup tg = new TestGroup();
            tg.GroupId = cboGroupID.SelectedValue.ToString();
            tsObj.TestGroup = tg;

            tsObj.TestMainID = cboMainID.SelectedValue.ToString();          

            for (int i = 0; i < lvFee.Items.Count; i++)
            {
                string1 += lvFee.Items[i].SubItems[12].Text +
                            ":" + lvFee.Items[i].SubItems[10].Text +
                            ":" + lvFee.Items[i].SubItems[2].Text +
                            ":" + lvFee.Items[i].SubItems[3].Text +
                            ":" + lvFee.Items[i].SubItems[4].Text +
                            ":" + lvFee.Items[i].SubItems[5].Text +
                            ":" + lvFee.Items[i].SubItems[6].Text +
                            ":" + lvFee.Items[i].SubItems[7].Text +
                            ":" + lvFee.Items[i].SubItems[11].Text +
                            ":" + ";";
            }
            tsObj.AllTest = string1;

            FeeCategory oFeeCat = new FeeCategory();
            oFeeCat.FeeCategoryID = cboFeeCatID.SelectedValue.ToString();
            tfObj.FeeCategory = oFeeCat;

            tfObj.TestSub = tsObj;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            tfObj.EParameter = ep;

            return tfObj;
        }

        private void frmDiagnosticFeeSetup_Load(object sender, EventArgs e)
        {
            cboDeptID.DisplayMember = "Value";
            cboDeptID.ValueMember = "Key";
            cboDeptID.DataSource = new BindingSource(dmsSC.GetDepartments("D"), null);

            cboFeeCatID.DisplayMember = "Value";
            cboFeeCatID.ValueMember = "Key";
            cboFeeCatID.DataSource = new BindingSource(dmsSC.GetFeecatDict("D"), null);

            FormatGrid();
            if (DepartmentID != null)
            {
                cboDeptID.SelectedValue = DepartmentID.ToString();
                cboGroupID.SelectedValue = GroupID.ToString();
                cboMainID.SelectedValue = MainID.ToString();
                UnassignCheck.Checked = true;
                cboDetailID.SelectedValue = DetailID.ToString();
            }

            cboDeptID.Select();
        }
        private void LoadListView(string deptId, string grpId, string mainId, string feecat)
        {
            lvFee.Items.Clear();

            if (deptId.Length != 0 || grpId.Length != 0 || mainId.Length != 0 || feecat.Length != 0)
            {
                tsfee = dmsSC.GetTestFee(deptId, grpId, mainId, feecat).ToList();
            }
            else
            {
                return;
            }
            foreach (TestFee tfee in tsfee)
            {
                ListViewItem itm = new ListViewItem(tfee.TestSub.TestSubTitle);
                itm.SubItems.Add(tfee.TestSub.TestMainTitle);
                itm.SubItems.Add(tfee.Fee.ToString());
                itm.SubItems.Add(tfee.DeptFee.ToString());
                itm.SubItems.Add(tfee.RefdFee.ToString());
                itm.SubItems.Add(tfee.DoctorFee.ToString());
                itm.SubItems.Add(tfee.VAT.ToString());
                itm.SubItems.Add(tfee.Discount.ToString());
                itm.SubItems.Add(tfee.TestSub.TestGroup.GroupId);
                itm.SubItems.Add(tfee.TestSub.TestDepartment.DepartmentID);
                itm.SubItems.Add(tfee.FeeCategory.FeeCategoryID);
                itm.SubItems.Add(tfee.TestSub.PanelID);
                itm.SubItems.Add(tfee.TestSub.TestSubID);
                lvFee.Items.Add(itm);
            }
        }

        private void lvFee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFee.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvFee.SelectedItems[0];
                cboDetailID.Text = itm.SubItems[0].Text;
                cboMainID.Text = itm.SubItems[1].Text;
                txtFee.Text = itm.SubItems[2].Text;
                txtDeptAmount.Text = itm.SubItems[3].Text;
                txtReffAmount.Text = itm.SubItems[4].Text;
                txtDocAmount.Text = itm.SubItems[5].Text;
                txtVat.Text = itm.SubItems[6].Text;
                txtDiscount.Text = itm.SubItems[7].Text;
                cboGroupID.SelectedValue = itm.SubItems[8].Text;
                cboDeptID.SelectedValue = itm.SubItems[9].Text;
                cboFeeCatID.SelectedValue = itm.SubItems[10].Text;
                txtPanleID.Text = itm.SubItems[11].Text;
                cboDetailID.SelectedValue = itm.SubItems[12].Text;
            }
            s =Convert.ToInt32(lvFee.FocusedItem.Index);
            UnassignCheck.Checked = false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDeptID", "cboGroupID", "cboMainID", "cboFeeCatID", "cboDetailID"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                TestFee tfobj = this.UpdateTestFee();
                short i = dmsSC.UpdateDiagnosticTestFee(tfobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboDeptID.Focus();
                    RefreshGrid(cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString(), cboFeeCatID.SelectedValue.ToString());
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

        private void cboDeptID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDeptID.SelectedValue != "")
            {
                cboGroupID.DisplayMember = "Value";
                cboGroupID.ValueMember = "Key";
                cboGroupID.DataSource = new BindingSource(Utility.VerifyDic(dmsSC.GetDiagnGrpDeptWise("D", cboDeptID.SelectedValue.ToString())), null);
                if (cboGroupID.SelectedValue != null)
                {
                    cboMainID.DisplayMember = "Value";
                    cboMainID.ValueMember = "Key";
                    cboMainID.DataSource = new BindingSource(Utility.VerifyDic(dmsSC.GetMainDeptwise("D", cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString())), null);
                }
            }
        }

        private void cboGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGroupID.SelectedValue != "")
            {
                cboMainID.DisplayMember = "Value";
                cboMainID.ValueMember = "Key";
                cboMainID.DataSource = new BindingSource(Utility.VerifyDic(dmsSC.GetMainDeptwise("D", cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString())), null);
            }
        }

        private void cboGroupID_Click(object sender, EventArgs e)
        {
            cboMainID.DisplayMember = "Value";
            cboMainID.ValueMember = "Key";
            if (cboDeptID.Items.Count > 1 && cboGroupID.Items.Count > 0)
            {
                cboMainID.DataSource = new BindingSource(dmsSC.GetMainDeptwise("D", cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString()), null);
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> vf = new List<string>() { "cboDeptID", "cboGroupID", "cboMainID", "cboFeeCatID" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }

                LoadListView(cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString(), cboFeeCatID.SelectedValue.ToString());
                cboDetailID.DisplayMember = "Value";
                cboDetailID.ValueMember = "Key";
                cboDetailID.DataSource = new BindingSource(Utility.VerifyDic(dmsSC.GetTestDetailDict("D", cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString())), null);
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

        private void UnassignCheck_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> vf = new List<string>() { "cboDeptID", "cboGroupID", "cboMainID", "cboFeeCatID" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }

                if (sender is CheckBox)
                {
                    CheckBox checkbox = sender as CheckBox;
                    if (checkbox.Checked)
                    {
                        cboDetailID.DisplayMember = "Value";
                        cboDetailID.ValueMember = "Key";
                        cboDetailID.DataSource = new BindingSource(Utility.VerifyDic(dmsSC.GetTestDetailDict("A", cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString())), null);
                        btnAdd.Enabled = false;
                    }
                    else
                    {
                        cboDetailID.DisplayMember = "Value";
                        cboDetailID.ValueMember = "Key";
                        cboDetailID.DataSource = new BindingSource(Utility.VerifyDic(dmsSC.GetTestDetailDict("D", cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString())), null);
                        btnAdd.Enabled = true;
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

        private void lvFee_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtSearchTest_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(tsfee, txtSearchTest.Text);
        }

        private void SearchListView(IEnumerable<TestFee> oResults, string searchString = "")
        {
            try
            {
                IEnumerable<TestFee> query;
                if (oResults != null)
                {
                    if (!(searchString.Length > 0))
                    {
                        query = oResults;
                    }
                    else
                    {
                        query = (from oRes in oResults
                                 where oRes.TestSub.TestSubTitle.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                                 select oRes);
                    }
                    lvFee.Items.Clear();
                    foreach (TestFee tfee in query)
                    {
                        ListViewItem itm = new ListViewItem(tfee.TestSub.TestSubTitle);
                        itm.SubItems.Add(tfee.TestSub.TestMainTitle);
                        itm.SubItems.Add(tfee.Fee.ToString());
                        itm.SubItems.Add(tfee.DeptFee.ToString());
                        itm.SubItems.Add(tfee.RefdFee.ToString());
                        itm.SubItems.Add(tfee.DoctorFee.ToString());
                        itm.SubItems.Add(tfee.VAT.ToString());
                        itm.SubItems.Add(tfee.Discount.ToString());
                        itm.SubItems.Add(tfee.TestSub.TestGroup.GroupId);
                        itm.SubItems.Add(tfee.TestSub.TestDepartment.DepartmentID);
                        itm.SubItems.Add(tfee.FeeCategory.FeeCategoryID);
                        itm.SubItems.Add(tfee.TestSub.PanelID);
                        itm.SubItems.Add(tfee.TestSub.TestSubID);
                        lvFee.Items.Add(itm);
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFee.Text == "")
            {
                lvFee.Items[s].SubItems[2].Text = "0";
            }
            else
            {
                lvFee.Items[s].SubItems[2].Text = txtFee.Text;
            }
            if (txtDeptAmount.Text == "")
            {
                lvFee.Items[s].SubItems[3].Text = "0";
            }
            else
            {
                lvFee.Items[s].SubItems[3].Text = txtDeptAmount.Text;
            }
            if (txtReffAmount.Text == "")
            {
                lvFee.Items[s].SubItems[4].Text = "0";
            }
            else
            {
                lvFee.Items[s].SubItems[4].Text = txtReffAmount.Text;
            }
            if (txtDocAmount.Text == "")
            {
                lvFee.Items[s].SubItems[5].Text = "0";
            }
            else
            {
                lvFee.Items[s].SubItems[5].Text = txtDocAmount.Text;
            }
            if (txtVat.Text == "")
            {
                lvFee.Items[s].SubItems[6].Text = "0";
            }
            else
            {
                lvFee.Items[s].SubItems[6].Text = txtVat.Text;
            }
            if (txtDiscount.Text == "")
            {
                lvFee.Items[s].SubItems[7].Text = "0";
            }
            else
            {
                lvFee.Items[s].SubItems[7].Text = txtDiscount.Text;
            }
            lvFee.Items[s].BackColor = Color.Lavender;
        }

    }
}
