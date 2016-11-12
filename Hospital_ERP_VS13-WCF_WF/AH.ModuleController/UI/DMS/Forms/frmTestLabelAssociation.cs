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
    public partial class frmTestLabelAssociation : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        List<TestSub> oTests;
        private int CheckSave = 0;
        public frmTestLabelAssociation()
        {
            InitializeComponent();
        }
        private void frmTestLabelAssociation_Load(object sender, EventArgs e)
        {
            try
            {
                cboDeptID.DisplayMember = "Value";
                cboDeptID.ValueMember = "Key";
                cboDeptID.DataSource = new BindingSource(dmsSC.GetDepartments("D"), null);

                cboLabelGroup.DisplayMember = "Value";
                cboLabelGroup.ValueMember = "Key";
                cboLabelGroup.DataSource = new BindingSource(Utility.GetNumbers(1, 10), null);

                FormatGrid(dgvTestDetails);
                FormatAssociatedGrid();
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

        private void cboMainID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMainID.SelectedValue != null)
            {
                dgvTestDetails.DataSource = null;
                txtTestDetails.Text = "";
                cboTestDet.DisplayMember = "Value";
                cboTestDet.ValueMember = "Key";
                cboTestDet.DataSource = new BindingSource(dmsSC.GetTestDetsDict("D", cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString()), null);
                LoadGridView(cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString());
            }
        }

        private void FormatGrid(DataGridView dgv)
        {
            this.dgvTestDetails.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvTestDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dgvTestDetails.Columns.Add(chk);
            chk.HeaderText = "Select";
            chk.Name = "chk";
            chk.Visible=true;
            chk.Width = 53;
            dgv.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn TestID = new DataGridViewTextBoxColumn();
            TestID.Name = "TestID";
            TestID.DataPropertyName = "TestID";
            TestID.Width = 0;
            TestID.Visible = false;
            dgv.Columns.Add(TestID);

            DataGridViewTextBoxColumn TestName = new DataGridViewTextBoxColumn();
            TestName.Name = "TestName";
            TestName.DataPropertyName = "TestName";
            TestName.Width = 500;
            dgv.Columns.Add(TestName);
        }
        private void FormatAssociatedGrid()
        {
            dgvAssociatedTestDetails.ColumnCount = 5;
            this.dgvAssociatedTestDetails.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAssociatedTestDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAssociatedTestDetails.Columns[0].Name = "Blank";
            dgvAssociatedTestDetails.Columns[0].Width = 0;
            dgvAssociatedTestDetails.Columns[0].Visible = false;
            dgvAssociatedTestDetails.Columns[1].Name = "Test ID";
            dgvAssociatedTestDetails.Columns[1].Width = 0;
            dgvAssociatedTestDetails.Columns[1].Visible = false;
            dgvAssociatedTestDetails.Columns[2].Name = "Test Name";
            dgvAssociatedTestDetails.Columns[2].Width = 400;
            dgvAssociatedTestDetails.Columns[2].ReadOnly = true;
            dgvAssociatedTestDetails.Columns[3].Name = "Label Group";
            dgvAssociatedTestDetails.Columns[3].Width = 110;
            dgvAssociatedTestDetails.Columns[4].Name = "Priority";
            dgvAssociatedTestDetails.Columns[4].Width = 100;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvAssociatedTestDetails.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.DefaultCellStyle.ForeColor = Color.Navy;
            btn.UseColumnTextForButtonValue = true;
            btn.Width = 50;
        }

        private void LoadGridView(string Dept, string Group, string TestMain)
        {
            try
            {
                dgvTestDetails.Rows.Clear();
                int i = 0;
                oTests = dmsSC.GetTestDets(cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString()).ToList();
                if (oTests.Count > 0)
                {
                    foreach (TestSub oTest in oTests)
                    {
                        dgvTestDetails.Rows.Add(1);
                        dgvTestDetails.Rows[i].Cells[1].Value = oTest.TestSubID;
                        dgvTestDetails.Rows[i].Cells[2].Value = oTest.TestSubTitle;
                        i = i + 1;
                    }
                    dgvTestDetails.AllowUserToAddRows = false;
                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvTestDetails.RowCount; i++)
                {
                    if (Convert.ToBoolean(dgvTestDetails.Rows[i].Cells[0].Value) == true)
                    {
                        if (dgvTestDetails[0, i].Value != null)
                        {
                            mAdditem(dgvTestDetails[1, i].Value.ToString(), dgvTestDetails[2, i].Value.ToString());
                        }
                        dgvTestDetails.Rows[i].Cells[0].Value = false;
                    }
                    dgvAssociatedTestDetails.AllowUserToAddRows = false;
                }
                CheckSave = 1;
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
        private void mAdditem(string TestDetID, string TestDetTitle)
        {
            int selRaw;
            string strDown = "";
            Boolean blngCheck = false;
            for (int j = 0; j < dgvAssociatedTestDetails.RowCount; j++)
            {
                if (dgvAssociatedTestDetails[1, j].Value != null)
                {
                    strDown = dgvAssociatedTestDetails[1, j].Value.ToString();
                }
                if (TestDetID == strDown.ToString())
                {
                    blngCheck = true;
                }
            }
            if (blngCheck == false)
            {
                dgvAssociatedTestDetails.AllowUserToAddRows = true;
                selRaw = Convert.ToInt16(dgvAssociatedTestDetails.RowCount.ToString());
                selRaw = selRaw - 1;
                dgvAssociatedTestDetails.Rows.Add(1);
                for (int i = 1; i < dgvAssociatedTestDetails.Rows.Count; i++)
                {
                    dgvAssociatedTestDetails[1, selRaw].Value = TestDetID.ToString();
                    dgvAssociatedTestDetails[2, selRaw].Value = TestDetTitle.ToString();
                    dgvAssociatedTestDetails[3, selRaw].Value = cboLabelGroup.SelectedValue.ToString();
                    dgvAssociatedTestDetails[4, selRaw].Value = "1";
                }              
            }           
        }
        private void dgvAssociatedTestDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAssociatedTestDetails.Columns[e.ColumnIndex].Name == "btn")
            {
                if (dgvAssociatedTestDetails.CurrentCell != null)
                {
                    int selectedIndex = dgvAssociatedTestDetails.CurrentCell.RowIndex;
                    if (selectedIndex > -1)
                    {
                        dgvAssociatedTestDetails.Rows.RemoveAt(selectedIndex);
                        dgvAssociatedTestDetails.Refresh();
                    }
                }
            }      
        }

        private TestSub PopulateTestForLabel()
        {
            string string1 = "";         
            TestSub oTestSub = new TestSub();
            TestGroup oTestGrp = new TestGroup();
            Department oDept = new Department();
            oDept.DepartmentID = cboDeptID.SelectedValue.ToString();
            oTestSub.TestDepartment = oDept;
            oTestGrp.GroupId = cboGroupID.SelectedValue.ToString();
            oTestSub.TestGroup = oTestGrp;

            oTestSub.TestMainID = cboMainID.SelectedValue.ToString();
            oTestSub.TestSubID = cboTestDet.SelectedValue.ToString();

            for (int i = 0; i < dgvAssociatedTestDetails.Rows.Count; i++)
            {
                string1 += dgvAssociatedTestDetails.Rows[i].Cells[1].Value + ":" + dgvAssociatedTestDetails.Rows[i].Cells[3].Value + ":" + dgvAssociatedTestDetails.Rows[i].Cells[4].Value + ":" + ";";
            }
            oTestSub.AllTest = string1;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;            
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oTestSub.EntryParameter = ep;

            return oTestSub;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDeptID", "cboGroupID", "cboMainID", "cboTestDet"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {

                TestSub oTestSub = this.PopulateTestForLabel();
                short i = dmsSC.SaveLabelTestAssociation(oTestSub);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CheckSave = 0;
                    dgvAssociatedTestDetails.Rows.Clear();
                    this.btnShow_Click(sender, e);
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAssociatedTestDetails.Rows.Clear();
                int i = 0;
                if (cboTestDet.SelectedValue != null)
                {
                    List<TestSub> oTests = dmsSC.GetTestLabel(cboTestDet.SelectedValue.ToString()).ToList();
                    if (oTests.Count > 0)
                    {
                        foreach (TestSub oTest in oTests)
                        {
                            dgvAssociatedTestDetails.Rows.Add(1);
                            dgvAssociatedTestDetails.Rows[i].Cells[1].Value = oTest.TestSubID;
                            dgvAssociatedTestDetails.Rows[i].Cells[2].Value = oTest.TestSubTitle;
                            dgvAssociatedTestDetails.Rows[i].Cells[3].Value = oTest.LabelGroup;
                            dgvAssociatedTestDetails.Rows[i].Cells[4].Value = oTest.Priority;
                            i = i + 1;
                        }
                        dgvAssociatedTestDetails.AllowUserToAddRows = false;
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

        private void cboTestDet_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(sender, e);
        }

        private void txtTestDetails_KeyUp(object sender, KeyEventArgs e)
        {          
            PopulateDataToGrid(dgvTestDetails, txtTestDetails.Text);
            dgvTestDetails.Refresh();          
        }
        private void PopulateDataToGrid(DataGridView dgv, string TestDetTitle)
        {
            if (oTests != null)
            {
                IEnumerable<TestSub> TestsListLocal;
                if (!(TestDetTitle.Length > 0))
                {
                    TestsListLocal = oTests;
                }
                else
                {
                    TestsListLocal = oTests.Where(x => x.TestSubTitle.ToLower().Contains(TestDetTitle.ToLower()));
                }
                dgv.DataSource = TestsListLocal.Select(data => new
                {
                    TestID = data.TestSubID,
                    TestName = data.TestSubTitle
                }).ToList();
            }
        }

        private void btnNewClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckSave == 1)
                {
                    DialogResult msg = MessageBox.Show("File is not Saved,Do You want to Save Now???", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (msg == DialogResult.Yes)
                    {
                        btnSave.PerformClick();
                        this.Dispose();
                    }
                    if (msg == DialogResult.No)
                    {
                        this.Dispose();
                    }
                }
                if (CheckSave == 0)
                {
                    this.Dispose();
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

        private void chkTestList_CheckedChanged(object sender, EventArgs e)
        {
            for (int rcont = 0; rcont < dgvTestDetails.Rows.Count; rcont++)
            {
                if (chkTestList.Checked == true)
                {
                    Convert.ToBoolean(dgvTestDetails.Rows[rcont].Cells["chk"].Value = true);
                }
                else
                {
                    Convert.ToBoolean(dgvTestDetails.Rows[rcont].Cells["chk"].Value = false);
                }
              
            }
        }

        private void txtSearchTest_TextChanged(object sender, EventArgs e)
        {
            cboTestDet.SelectedIndex = cboTestDet.FindString(txtSearchTest.Text);
        }

        private void dgvAssociatedTestDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                double i;
                if (!double.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please Enter Numeric Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    return;
                }
            }
        }

    }
}
