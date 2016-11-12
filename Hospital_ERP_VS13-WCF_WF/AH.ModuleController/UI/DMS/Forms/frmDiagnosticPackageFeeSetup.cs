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
    public partial class frmDiagnosticPackageFeeSetup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        List<TestFee> oTestFees;
        int Pos;
        public frmDiagnosticPackageFeeSetup()
        {
            InitializeComponent();
        }
        private void FormatGrid(DataGridView dgv)
        {
            this.dgvUnassignedTest.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvUnassignedTest.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dgvUnassignedTest.Columns.Add(chk);
            chk.HeaderText = "Select";
            chk.Name = "chk";
            chk.Visible = true;
            chk.Width = 53;
            dgv.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn ID = new DataGridViewTextBoxColumn();
            ID.Name = "ID";
            ID.DataPropertyName = "ID";
            ID.Width = 70;
            ID.ReadOnly = true;
            dgv.Columns.Add(ID);

            DataGridViewTextBoxColumn TestName = new DataGridViewTextBoxColumn();
            TestName.Name = "TestName";
            TestName.DataPropertyName = "TestName";
            TestName.Width = 345;
            TestName.ReadOnly = true;
            dgv.Columns.Add(TestName);

            DataGridViewTextBoxColumn PnlID = new DataGridViewTextBoxColumn();
            PnlID.Name = "PnlID";
            PnlID.DataPropertyName = "PnlID";
            PnlID.Width = 0;
            PnlID.Visible = false ;
            dgv.Columns.Add(PnlID);
        }

        private void FormatAssociatedGrid()
        {

            dgvAssignedTest.ColumnCount = 11;
            this.dgvAssignedTest.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAssignedTest.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAssignedTest.Columns[0].Name = "Blank";
            dgvAssignedTest.Columns[0].Width = 0;
            dgvAssignedTest.Columns[0].Visible = false;
            dgvAssignedTest.Columns[1].Name = "ID";
            dgvAssignedTest.Columns[1].Width = 50;
            dgvAssignedTest.Columns[1].ReadOnly = true;
            dgvAssignedTest.Columns[2].Name = "TestName";
            dgvAssignedTest.Columns[2].Width = 305;
            dgvAssignedTest.Columns[2].ReadOnly = true;
            dgvAssignedTest.Columns[3].Name = "Fee";
            dgvAssignedTest.Columns[3].Width = 80;
            dgvAssignedTest.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAssignedTest.Columns[4].Name = "DeptFee";
            dgvAssignedTest.Columns[4].Width = 65;
            dgvAssignedTest.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAssignedTest.Columns[5].Name = "RefdFee";
            dgvAssignedTest.Columns[5].Width = 65;
            dgvAssignedTest.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAssignedTest.Columns[6].Name = "DocFee";
            dgvAssignedTest.Columns[6].Width = 60;
            dgvAssignedTest.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAssignedTest.Columns[7].Name = "Vat";
            dgvAssignedTest.Columns[7].Width = 40;
            dgvAssignedTest.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAssignedTest.Columns[8].Name = "Disc";
            dgvAssignedTest.Columns[8].Width = 40;
            dgvAssignedTest.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAssignedTest.Columns[9].Name = "PosSrl";
            dgvAssignedTest.Columns[9].Width = 50;
            dgvAssignedTest.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAssignedTest.Columns[10].Name = "Pnl";
            dgvAssignedTest.Columns[10].Width = 0;
            dgvAssignedTest.Columns[10].Visible = false;
           
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvAssignedTest.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.DefaultCellStyle.ForeColor = Color.Navy;
            btn.UseColumnTextForButtonValue = true;
            btn.Width = 55;
        }

        private void LoadTest()
        {
            try
            {
                dgvUnassignedTest.DataSource = null;
                dgvUnassignedTest.Rows.Clear();
                if (cboDiagPkg.SelectedValue != null)
                {
                    int i = 0;
                    oTestFees = dmsSC.GetAllTestForPackage().ToList();
                    if (oTestFees.Count > 0)
                    {
                        foreach (TestFee oTestFee in oTestFees)
                        {
                            dgvUnassignedTest.Rows.Add(1);
                            dgvUnassignedTest.Rows[i].Cells[1].Value = oTestFee.TestSub.TestSubID;
                            dgvUnassignedTest.Rows[i].Cells[2].Value = oTestFee.TestSub.TestSubTitle;
                            dgvUnassignedTest.Rows[i].Cells[3].Value = oTestFee.TestSub.PanelID;
                            i = i + 1;
                        }
                        dgvUnassignedTest.AllowUserToAddRows = false;
                    }
                    else
                    {
                        return;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }         
        }
        private void frmDiagnosticPackageFeeSetup_Load(object sender, EventArgs e)
        {
            try
            {
                FormatGrid(dgvUnassignedTest);
                FormatAssociatedGrid();

                cboDiagPkg.DisplayMember = "Value";
                cboDiagPkg.ValueMember = "Key";
                cboDiagPkg.DataSource = new BindingSource(dmsSC.GetDiagPackageDict("D"), null);

                LoadTest();
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

        private void btnAddPkg_Click(object sender, EventArgs e)
        {
            frmDiagPackageMaster oDiag = new frmDiagPackageMaster();
            oDiag.ShowDialog();
        }

        private void btnRefreshPkg_Click(object sender, EventArgs e)
        {
            cboDiagPkg.DisplayMember = "Value";
            cboDiagPkg.ValueMember = "Key";
            cboDiagPkg.DataSource = new BindingSource(dmsSC.GetDiagPackageDict("D"), null);
        }
        private void LoadPackageAmount(string Package)
        {
            List<DiagPackage> oDiagPackages = dmsSC.GetDiagPackageAmount(cboDiagPkg.SelectedValue.ToString()).ToList();
            foreach (DiagPackage oDiagPackage in oDiagPackages)
            {
                lblPackageAmountSummary.Text = oDiagPackage.PackageAmount.ToString();
            }
        }    
        private void cboDiagPkg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDiagPkg.SelectedValue != "")
            {
                LoadPackageAmount(cboDiagPkg.SelectedValue.ToString());
                this.btnShow_Click(sender, e);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAssociatedTest(cboDiagPkg.SelectedValue.ToString());
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

        private void txtSearchTest_KeyUp(object sender, KeyEventArgs e)
        {
            PopulateDataToGrid(dgvUnassignedTest, txtSearchTest.Text);
            dgvUnassignedTest.Refresh();       
        }
        private void PopulateDataToGrid(DataGridView dgv, string TestName)
        {
            if (oTestFees != null)
            {
                IEnumerable<TestFee> TestsListLocal;
                if (!(TestName.Length > 0))
                {
                    TestsListLocal = oTestFees;
                }
                else
                {
                    TestsListLocal = oTestFees.Where(x => x.TestSub.TestSubTitle.ToLower().Contains(TestName.ToLower()));
                }
                dgv.DataSource = TestsListLocal.Select(data => new
                {
                    ID = data.TestSub.TestSubID,
                    TestName = data.TestSub.TestSubTitle,
                    PnlID = data.TestSub.PanelID,
                }).ToList();
            }
        }

        private void updateCollectedTestSummary(DataGridView dtv)
        {            
            double sum = 0;
            for (int i = 0; i < dtv.Rows.Count; ++i)
            {                
                    sum += Convert.ToDouble(dtv.Rows[i].Cells[3].Value.ToString());
            }
            lblTestAmountSummary.Text = sum.ToString();           
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvUnassignedTest.RowCount; i++)
                {
                    if (Convert.ToBoolean(dgvUnassignedTest.Rows[i].Cells[0].Value) == true)
                    {
                        if (dgvUnassignedTest[0, i].Value != null)
                        {
                            mAdditem(dgvUnassignedTest[1, i].Value.ToString(), dgvUnassignedTest[2, i].Value.ToString(), dgvUnassignedTest[3, i].Value.ToString());
                        }
                        dgvUnassignedTest.Rows[i].Cells[0].Value = false;
                    }
                    dgvAssignedTest.AllowUserToAddRows = false;
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
        private void mAdditem(string TestDetID, string TestDetTitle,string PanelID)
        {
            int selRaw;
            string strDown = "";
            Boolean blngCheck = false;
            for (int j = 0; j < dgvAssignedTest.RowCount; j++)
            {
                if (dgvAssignedTest[1, j].Value != null)
                {
                    strDown = dgvAssignedTest[1, j].Value.ToString();
                }
                if (TestDetID == strDown.ToString())
                {
                    blngCheck = true;
                }
            }
            if (blngCheck == false)
            {
                dgvAssignedTest.AllowUserToAddRows = true;
                selRaw = Convert.ToInt16(dgvAssignedTest.RowCount.ToString());
                selRaw = selRaw - 1;
                dgvAssignedTest.Rows.Add(1);
                for (int i = 1; i < dgvAssignedTest.Rows.Count; i++)
                {
                    dgvAssignedTest[1, selRaw].Value = TestDetID.ToString();
                    dgvAssignedTest[2, selRaw].Value = TestDetTitle.ToString();
                    dgvAssignedTest[3, selRaw].Value = "0";
                    dgvAssignedTest[4, selRaw].Value = "0";
                    dgvAssignedTest[5, selRaw].Value = "0";
                    dgvAssignedTest[6, selRaw].Value = "0";
                    dgvAssignedTest[7, selRaw].Value = "0";
                    dgvAssignedTest[8, selRaw].Value = "0";
                    dgvAssignedTest[9, selRaw].Value = "0";
                    dgvAssignedTest[10, selRaw].Value = PanelID.ToString();
                }
                dgvAssignedTest.AllowUserToAddRows = false;
            }
            
        }
        private void dgvAssignedTest_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9)
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

        private void dgvAssignedTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dgvAssignedTest.Columns[e.ColumnIndex].Name == "btn")
            {
                if (dgvAssignedTest.CurrentCell != null)
                {
                    int selectedIndex = dgvAssignedTest.CurrentCell.RowIndex;
                    if (selectedIndex > -1)
                    {
                        DialogResult msg = MessageBox.Show("Do You want to Delete?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (msg == DialogResult.Yes)
                        {
                            dgvAssignedTest.Rows.RemoveAt(selectedIndex);
                            dgvAssignedTest.Refresh();
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }
        private TestFee PopulateTesFee()
        {
            string string1 = "";
            TestFee oTestFee = new TestFee();
            TestSub oTest = new TestSub();
            DiagPackage oDiag = new DiagPackage();
            oDiag.PackageID = cboDiagPkg.SelectedValue.ToString();
            oTestFee.DiagPackage = oDiag;

            for (int i = 0; i < dgvAssignedTest.Rows.Count; i++)
            {
                string1 += dgvAssignedTest.Rows[i].Cells[1].Value +
                            ":" + dgvAssignedTest.Rows[i].Cells[3].Value +
                            ":" + dgvAssignedTest.Rows[i].Cells[4].Value +
                            ":" + dgvAssignedTest.Rows[i].Cells[5].Value +
                            ":" + dgvAssignedTest.Rows[i].Cells[6].Value +
                            ":" + dgvAssignedTest.Rows[i].Cells[7].Value +
                            ":" + dgvAssignedTest.Rows[i].Cells[8].Value +
                            ":" + dgvAssignedTest.Rows[i].Cells[9].Value +
                            ":" + dgvAssignedTest.Rows[i].Cells[10].Value +
                            ":" + ";";
            }
            oTest.AllTest = string1;
            oTestFee.TestSub = oTest;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oTestFee.EParameter = ep;

            return oTestFee;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDiagPkg"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dgvAssignedTest.Rows.Count > 0)
            {
                if (Convert.ToDouble(lblTestAmountSummary.Text.ToString()) != Convert.ToDouble(lblPackageAmountSummary.Text.ToString()))
                {
                    MessageBox.Show("Total Fee Must be Same as Package Fee", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            try
            {
                TestFee oTestFee = this.PopulateTesFee();
                short i = dmsSC.SaveDiagnosticTestFeePkg(oTestFee);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAssignedTest.DataSource = null;
                    dgvAssignedTest.Rows.Clear();
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

        private void LoadAssociatedTest(string Package)
        {           
                dgvAssignedTest.DataSource = null;
                dgvAssignedTest.Rows.Clear();
                int i = 0;
                List<TestFee> oTestFees = dmsSC.GetTestFeePkg(cboDiagPkg.SelectedValue.ToString()).ToList();
                if (oTestFees.Count > 0)
                {
                    foreach (TestFee oTestFee in oTestFees)
                    {
                        dgvAssignedTest.Rows.Add(1);
                        dgvAssignedTest.Rows[i].Cells[1].Value = oTestFee.TestSub.TestSubID;
                        dgvAssignedTest.Rows[i].Cells[2].Value = oTestFee.TestSub.TestSubTitle;
                        dgvAssignedTest.Rows[i].Cells[3].Value = oTestFee.Fee.ToString();
                        dgvAssignedTest.Rows[i].Cells[4].Value = oTestFee.DeptFee.ToString();
                        dgvAssignedTest.Rows[i].Cells[5].Value = oTestFee.RefdFee.ToString();
                        dgvAssignedTest.Rows[i].Cells[6].Value = oTestFee.DoctorFee.ToString();
                        dgvAssignedTest.Rows[i].Cells[7].Value = oTestFee.VAT.ToString();
                        dgvAssignedTest.Rows[i].Cells[8].Value = oTestFee.Discount.ToString();
                        dgvAssignedTest.Rows[i].Cells[9].Value = oTestFee.TestSub.PosSerial.ToString();
                        dgvAssignedTest.Rows[i].Cells[10].Value = oTestFee.TestSub.PanelID.ToString();
                        i = i + 1;
                    }
                    lblTestAmountSummary.Text = "";
                    dgvAssignedTest.AllowUserToAddRows = false;
                    updateCollectedTestSummary(dgvAssignedTest);  
                }
                else
                {
                    lblTestAmountSummary.Text = "";                    
                    return;
                }
                dgvAssignedTest.CurrentCell = null;
                dgvAssignedTest.ClearSelection();                                   
                       
        }

        private void dgvAssignedTest_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)
            {
                Pos = e.RowIndex;
                if (e.ColumnIndex == 3)
                {
                    if (dgvAssignedTest.Rows[row].Cells[3].Value.ToString() != "0")
                    {
                        updateCollectedTestSummary(dgvAssignedTest);
                    }
                }
            }
        }



    }
}
