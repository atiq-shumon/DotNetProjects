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
    public partial class frmDiagnosticTestFeeSetup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        private List<TestFee> oTestFees;
        public string DepartmentID { set; get; }
        public string GroupID { set; get; }
        public string MainID { set; get; }
        public string DetailID { set; get; }
        public frmDiagnosticTestFeeSetup()
        {
            InitializeComponent();
        }

        private void frmTestFeeSetup_Load(object sender, EventArgs e)
        {
            try
            {
                cboDeptID.DisplayMember = "Value";
                cboDeptID.ValueMember = "Key";
                cboDeptID.DataSource = new BindingSource(dmsSC.GetDepartments("D"), null);

                cboFeeCatID.DisplayMember = "Value";
                cboFeeCatID.ValueMember = "Key";
                cboFeeCatID.DataSource = new BindingSource(dmsSC.GetFeecatDict("D"), null);

                FormatGrid(dgvTestFeeGrid);

                if (DepartmentID != null)
                {
                    cboDeptID.SelectedValue = DepartmentID.ToString();
                    cboGroupID.SelectedValue = GroupID.ToString();
                    cboMainID.SelectedValue = MainID.ToString();
                    UnassignCheck.Checked = true;
                    // LoadUnassignedListView(cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString());
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


        private void FormatGrid(DataGridView dgv)
        {
            this.dgvTestFeeGrid.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvTestFeeGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dgvTestFeeGrid.Columns.Add(chk);
            chk.HeaderText = "Select";
            chk.Name = "chk";
            chk.Visible = true;
            chk.Width = 65;
            dgv.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn TestCode = new DataGridViewTextBoxColumn();
            TestCode.Name = "TestCode";
            TestCode.DataPropertyName = "TestCode";
            TestCode.Width = 80;
            TestCode.ReadOnly = true;
            dgv.Columns.Add(TestCode);

            DataGridViewTextBoxColumn TestName = new DataGridViewTextBoxColumn();
            TestName.Name = "TestName";
            TestName.DataPropertyName = "TestName";
            TestName.Width = 460;
            TestName.ReadOnly = true;
            dgv.Columns.Add(TestName);

            DataGridViewTextBoxColumn FeeCat = new DataGridViewTextBoxColumn();
            FeeCat.Name = "FeeCat";
            FeeCat.DataPropertyName = "FeeCat";
            FeeCat.Width = 0;
            FeeCat.ReadOnly = true;
            FeeCat.Visible = false;
            dgv.Columns.Add(FeeCat);

            DataGridViewTextBoxColumn Fee = new DataGridViewTextBoxColumn();
            Fee.Name = "Fee";
            Fee.DataPropertyName = "Fee";
            Fee.Width = 120;
            Fee.ReadOnly = false;
            dgv.Columns.Add(Fee);

            DataGridViewTextBoxColumn DeptFee = new DataGridViewTextBoxColumn();
            DeptFee.Name = "DeptFee";
            DeptFee.DataPropertyName = "DeptFee";
            DeptFee.Width = 100;
            DeptFee.ReadOnly = false;
            dgv.Columns.Add(DeptFee);

            DataGridViewTextBoxColumn RefdFee = new DataGridViewTextBoxColumn();
            RefdFee.Name = "RefdFee";
            RefdFee.DataPropertyName = "RefdFee";
            RefdFee.Width = 100;
            RefdFee.ReadOnly = false;
            dgv.Columns.Add(RefdFee);

            DataGridViewTextBoxColumn DocFee = new DataGridViewTextBoxColumn();
            DocFee.Name = "DocFee";
            DocFee.DataPropertyName = "DocFee";
            DocFee.Width = 100;
            DocFee.ReadOnly = false;
            dgv.Columns.Add(DocFee);

            DataGridViewTextBoxColumn Vat = new DataGridViewTextBoxColumn();
            Vat.Name = "Vat";
            Vat.DataPropertyName = "Vat";
            Vat.Width = 80;
            Vat.ReadOnly = false;
            dgv.Columns.Add(Vat);

            DataGridViewTextBoxColumn Disc = new DataGridViewTextBoxColumn();
            Disc.Name = "Disc";
            Disc.DataPropertyName = "Disc";
            Disc.Width = 80;
            Disc.ReadOnly = false;
            dgv.Columns.Add(Disc);

            DataGridViewTextBoxColumn Pnl = new DataGridViewTextBoxColumn();
            Pnl.Name = "Pnl";
            Pnl.DataPropertyName = "Pnl";
            Pnl.Width = 0;
            Pnl.Visible= false;
            dgv.Columns.Add(Pnl);
        }

        private void LoadListView(string Dept,string TestGrp,string TestMain,string Category)
        {
            try
            {
                dgvTestFeeGrid.Rows.Clear();
                int i = 0;
                oTestFees = dmsSC.GetTestFee(cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString(), cboFeeCatID.SelectedValue.ToString()).ToList();
                if (oTestFees.Count > 0)
                {
                    foreach (TestFee oTestFee in oTestFees)
                    {
                        dgvTestFeeGrid.Rows.Add(1);
                        dgvTestFeeGrid.Rows[i].Cells[1].Value = oTestFee.TestSub.TestSubID;
                        dgvTestFeeGrid.Rows[i].Cells[2].Value = oTestFee.TestSub.TestSubTitle;
                        dgvTestFeeGrid.Rows[i].Cells[3].Value = oTestFee.FeeCategory.FeeCategoryID;
                        dgvTestFeeGrid.Rows[i].Cells[4].Value = oTestFee.Fee;
                        dgvTestFeeGrid.Rows[i].Cells[5].Value = oTestFee.DeptFee;
                        dgvTestFeeGrid.Rows[i].Cells[6].Value = oTestFee.RefdFee;
                        dgvTestFeeGrid.Rows[i].Cells[7].Value = oTestFee.DoctorFee;
                        dgvTestFeeGrid.Rows[i].Cells[8].Value = oTestFee.VAT;
                        dgvTestFeeGrid.Rows[i].Cells[9].Value = oTestFee.Discount;
                        dgvTestFeeGrid.Rows[i].Cells[10].Value = oTestFee.TestSub.PanelID;
                        i = i + 1;
                    }
                    dgvTestFeeGrid.AllowUserToAddRows = false;
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
                UnassignCheck.Checked = false;
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

        private void dgvTestFeeGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9)
            {
                double i;
                if (!double.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please Enter Numeric Value", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    return;
                }
            }
        }
     
        private void UnassignCheck_CheckedChanged(object sender, EventArgs e)
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
                    pnlUnassignedTest.Enabled = true;
                    cboDetailID.DisplayMember = "Value";
                    cboDetailID.ValueMember = "Key";
                    cboDetailID.DataSource = new BindingSource(Utility.VerifyDic(dmsSC.GetTestDetailDict("A", cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString())), null);
                }
                else
                {
                    pnlUnassignedTest.Enabled = false;
                    cboDetailID.DisplayMember = "Value";
                    cboDetailID.ValueMember = "Key";
                    cboDetailID.DataSource = new BindingSource(Utility.VerifyDic(dmsSC.GetTestDetailDict("D", cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString())), null);
                    this.btnShow_Click(sender, e);
                }

            }
        }
       
        private TestFee PopulateTestFee()
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

            FeeCategory oFeeCat = new FeeCategory();
            oFeeCat.FeeCategoryID = cboFeeCatID.SelectedValue.ToString();
            tfObj.FeeCategory = oFeeCat;

            for (int i = 0; i < dgvTestFeeGrid.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvTestFeeGrid.Rows[i].Cells[0].Value) == true)
                {
                    string1 += dgvTestFeeGrid.Rows[i].Cells[1].Value +
                                ":" + dgvTestFeeGrid.Rows[i].Cells[3].Value +
                                ":" + dgvTestFeeGrid.Rows[i].Cells[4].Value +
                                ":" + dgvTestFeeGrid.Rows[i].Cells[5].Value +
                                ":" + dgvTestFeeGrid.Rows[i].Cells[6].Value +
                                ":" + dgvTestFeeGrid.Rows[i].Cells[7].Value +
                                ":" + dgvTestFeeGrid.Rows[i].Cells[8].Value +
                                ":" + dgvTestFeeGrid.Rows[i].Cells[9].Value +
                                ":" + dgvTestFeeGrid.Rows[i].Cells[10].Value +
                                ":" + ";";
                }
            }
            tsObj.AllTest = string1;

            tfObj.TestSub = tsObj;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            tfObj.EParameter = ep;

            return tfObj;
        }
        private Boolean CheckUpdate()
        {
            Boolean Chk = false;
            for (int i = 0; i < dgvTestFeeGrid.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvTestFeeGrid.Rows[i].Cells[0].Value) == true)
                {
                    Chk = true;
                }
            }
            return Chk;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDeptID", "cboGroupID", "cboMainID", "cboFeeCatID"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if(CheckUpdate()==false)
                {
                    MessageBox.Show("No Test Selected for Update", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                TestFee tfobj = this.PopulateTestFee();
                short i = dmsSC.UpdateDiagnosticTestFee(tfobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboDeptID.Focus();
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

        private void txtSearchUnAssignedTest_TextChanged(object sender, EventArgs e)
        {
            cboDetailID.SelectedIndex = cboDetailID.FindString(txtSearchUnAssignedTest.Text);
        }
        private TestFee SaveTestFee()
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
        private void btnNewSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDeptID", "cboGroupID", "cboMainID", "cboFeeCatID", "cboDetailID", "txtFee", "txtDeptAmount", "txtReffAmount", "txtDocAmount", "txtVat", "txtDiscount" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            if (cboDetailID.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Please Select a Test!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDeptID.Select();
                return;
            }
            try
            {
                TestFee tfobj = this.SaveTestFee();
                short i = dmsSC.SaveTestFee(tfobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboDeptID.Focus();
                    this.btnShow_Click(sender, e);
                    UnassignCheck.Checked = true;
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

        private void cboGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGroupID.SelectedValue != "")
            {
                cboMainID.DisplayMember = "Value";
                cboMainID.ValueMember = "Key";
                cboMainID.DataSource = new BindingSource(Utility.VerifyDic(dmsSC.GetMainDeptwise("D", cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString())), null);
            }
        }   
     

    }
}
