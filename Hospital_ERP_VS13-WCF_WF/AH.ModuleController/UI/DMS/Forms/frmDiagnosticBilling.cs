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
using AH.Shared.UI;
using AH.ModuleController.UI.DMS.Reports.Viewer;
using System.Threading.Tasks;


namespace AH.ModuleController.UI.DMS.Forms
{
    public partial class frmDiagnosticBilling : AH.Shared.UI.frmSmartFormStandard
    {
        private string FormType;
        DMSSR.DMSWSClient dmsSR = new DMSSR.DMSWSClient();
        List<TestFee> oTestFees;
        private string TicketType = "";
        public string HCN { set; get; }
        public string EmrTicketNo { set; get; }
        public frmDiagnosticBilling(string mode)
        {            
            InitializeComponent();
            FormType = mode;
        }
        private void frmDiagnosticBilling_Load(object sender, EventArgs e)
        {
            try
            {
                cboFeeCatID.DisplayMember = "Value";
                cboFeeCatID.ValueMember = "Key";
                cboFeeCatID.DataSource = new BindingSource(dmsSR.GetFeecatDict("D"), null);

                cboDiagnosticTestGroup.DisplayMember = "Value";
                cboDiagnosticTestGroup.ValueMember = "Key";
                cboDiagnosticTestGroup.DataSource = new BindingSource(dmsSR.GetDiagnGrpDict("D"), null);

                cboTicketType.DisplayMember = "Value";
                cboTicketType.ValueMember = "Key";
                cboTicketType.DataSource = new BindingSource(Utility.GetPrescriptionTypes(), null);

                cboReffOrg.DisplayMember = "Value";
                cboReffOrg.ValueMember = "Key";
                cboReffOrg.DataSource = new BindingSource(dmsSR.GetReffdOrgDic("D"), null);

                lblTestCount.Text = "0";
                lblTestAmountSummary.Text = "0";

                dgvGetData.Visible = false;
                FormatGrid(dgvGetData);
                FormatCollectedTestDataGrid(dtgvCollectedTest);
                FormSelector();
                if(HCN !=null)
                {
                    txtHCNNo.Text = HCN;
                    cboPatientSearch_Click(sender, e);
                }
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }

        }
        private void LoadTest(string Catagory,string TestDetails)
        {
            oTestFees = dmsSR.GetAllMappingTestLike(cboFeeCatID.SelectedValue.ToString(), txtSubCode.Text.ToString()).ToList();        
        }
        private void LoadPackageTest(string Package)
        {
            oTestFees = dmsSR.GetAllPackageTest(cboDiagPkg.SelectedValue.ToString()).ToList();
        }
        private void FormSelector()
        {
            cboTicketType.SelectedValue = FormType;
            txtTicketNo.Focus();
            if (FormType == "S" || FormType == "X" || FormType == "E")
            {
                lblDepartment.Visible = false;
                lblUnit.Visible = false;
                txtDepartmentName.Visible = false;
                txtUnitTitle.Visible = false;
                lblMobileNo.Visible = true;
                txtMobileNo.Visible = true;
                btnSearch.Visible = true;
                btnAdvanceSearch.Visible = false;
            }
        }
        private void FormatGrid(DataGridView dtv)
        {
            dtv.Height = 270;
            dtv.Width = 1200;
            dtv.Location = new Point(txtSubCode.Location.X, txtSubCode.Location.Y + 23);
            dtv.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn labRoomID = new DataGridViewTextBoxColumn();
            labRoomID.Name = "RoomID";
            labRoomID.DataPropertyName = "RoomID";
            labRoomID.Width = 0;
            labRoomID.Visible = false;
            dtv.Columns.Add(labRoomID);

            DataGridViewTextBoxColumn RoomTitle = new DataGridViewTextBoxColumn();
            RoomTitle.Name = "RoomTitle";
            RoomTitle.DataPropertyName = "RoomTitle";
            RoomTitle.Width = 0;
            RoomTitle.Visible = false;
            dtv.Columns.Add(RoomTitle);

            DataGridViewTextBoxColumn labPersonID = new DataGridViewTextBoxColumn();
            labPersonID.Name = "ID";
            labPersonID.DataPropertyName = "ID";
            labPersonID.Width = 0;
            labPersonID.Visible = false;
            dtv.Columns.Add(labPersonID);

            DataGridViewTextBoxColumn DeptCode = new DataGridViewTextBoxColumn();
            DeptCode.Name = "DepartmentID";
            DeptCode.DataPropertyName = "DepartmentID";
            DeptCode.Width = 0;
            DeptCode.Visible = false;
            dtv.Columns.Add(DeptCode);

            DataGridViewTextBoxColumn TestDepartmentTitle = new DataGridViewTextBoxColumn();
            TestDepartmentTitle.Name = "DepartmentTitle";
            TestDepartmentTitle.DataPropertyName = "DepartmentTitle";
            TestDepartmentTitle.Width = 0;
            TestDepartmentTitle.Visible = false;
            dtv.Columns.Add(TestDepartmentTitle);

            DataGridViewTextBoxColumn rptGroupID = new DataGridViewTextBoxColumn();
            rptGroupID.Name = "reportGroupID";
            rptGroupID.DataPropertyName = "reportGroupID";
            rptGroupID.Width = 0;
            rptGroupID.Visible = false;
            dtv.Columns.Add(rptGroupID);

            DataGridViewTextBoxColumn dtvtestGroupID = new DataGridViewTextBoxColumn();
            dtvtestGroupID.Name = "grp_id";
            dtvtestGroupID.DataPropertyName = "grp_id";
            dtvtestGroupID.Width = 0;
            dtvtestGroupID.Visible = false;
            dtv.Columns.Add(dtvtestGroupID);

            DataGridViewTextBoxColumn grp_title = new DataGridViewTextBoxColumn();
            grp_title.Name = "grp_title";
            grp_title.DataPropertyName = "grp_title";
            grp_title.Width = 0;
            grp_title.Visible = false;
            dtv.Columns.Add(grp_title);

            DataGridViewTextBoxColumn dtvtestSubID = new DataGridViewTextBoxColumn();
            dtvtestSubID.Name = "Sub Code";
            dtvtestSubID.DataPropertyName = "TestSubID";
            dtvtestSubID.Width = 80;
            dtv.Columns.Add(dtvtestSubID);

            DataGridViewTextBoxColumn dtvtestName = new DataGridViewTextBoxColumn();
            dtvtestName.Name = "Title";
            dtvtestName.DataPropertyName = "TestSubTitle";
            dtvtestName.Width = 350;
            dtv.Columns.Add(dtvtestName);

            DataGridViewTextBoxColumn dtvFee = new DataGridViewTextBoxColumn();
            dtvFee.Name = "Fee";
            dtvFee.DataPropertyName = "Fee";
            dtvFee.Width = 90;
            dtv.Columns.Add(dtvFee);

            DataGridViewTextBoxColumn dtvRefd = new DataGridViewTextBoxColumn();
            dtvRefd.Name = "RefdFee";
            dtvRefd.DataPropertyName = "RefdFee";
            dtvRefd.Width = 0;
            dtvRefd.Visible = false;
            dtv.Columns.Add(dtvRefd);

            DataGridViewTextBoxColumn DeptFee = new DataGridViewTextBoxColumn();
            DeptFee.Name = "DeptFee";
            DeptFee.DataPropertyName = "DeptFee";
            DeptFee.Width = 0;
            DeptFee.Visible = false;
            dtv.Columns.Add(DeptFee);

            DataGridViewTextBoxColumn DoctorFee = new DataGridViewTextBoxColumn();
            DoctorFee.Name = "DoctorFee";
            DoctorFee.DataPropertyName = "DoctorFee";
            DoctorFee.Width = 0;
            DoctorFee.Visible = false;
            dtv.Columns.Add(DoctorFee);

            DataGridViewTextBoxColumn MainCode = new DataGridViewTextBoxColumn();
            MainCode.Name = "TestMainID";
            MainCode.DataPropertyName = "TestMainID";
            MainCode.Width = 0;
            MainCode.Visible = false;
            dtv.Columns.Add(MainCode);

            DataGridViewTextBoxColumn MainTitle = new DataGridViewTextBoxColumn();
            MainTitle.Name = "Main Title";
            MainTitle.DataPropertyName = "TestMainTitle";
            MainTitle.Width = 200;
            dtv.Columns.Add(MainTitle);

            DataGridViewTextBoxColumn discount = new DataGridViewTextBoxColumn();
            discount.Name = "discount";
            discount.DataPropertyName = "discount";
            discount.Width = 0;
            discount.Visible = false;
            dtv.Columns.Add(discount);

            DataGridViewTextBoxColumn vat = new DataGridViewTextBoxColumn();
            vat.Name = "vat";
            vat.DataPropertyName = "vat";
            vat.Width = 0;
            vat.Visible = false;
            dtv.Columns.Add(vat);

            DataGridViewTextBoxColumn PanelCode = new DataGridViewTextBoxColumn();
            PanelCode.Name = "PanelID";
            PanelCode.DataPropertyName = "PanelID";
            PanelCode.Width = 0;
            PanelCode.Visible = false;
            dtv.Columns.Add(PanelCode);


            DataGridViewTextBoxColumn Panel = new DataGridViewTextBoxColumn();
            Panel.Name = "PanelTitle";
            Panel.DataPropertyName = "PanelTitle";
            Panel.Width = 180;
            dtv.Columns.Add(Panel);

            DataGridViewTextBoxColumn LabRoomID = new DataGridViewTextBoxColumn();
            LabRoomID.Name = "LabRoomID";
            LabRoomID.DataPropertyName = "LabRoomID";
            LabRoomID.Width = 0;
            LabRoomID.Visible = false;
            dtv.Columns.Add(LabRoomID);

            DataGridViewTextBoxColumn FeeCatagoryID = new DataGridViewTextBoxColumn();
            FeeCatagoryID.Name = "FeeCatagoryID";
            FeeCatagoryID.DataPropertyName = "FeeCatagoryID";
            FeeCatagoryID.Width = 0;
            FeeCatagoryID.Visible = false;
            dtv.Columns.Add(FeeCatagoryID);

            DataGridViewTextBoxColumn Catagory = new DataGridViewTextBoxColumn();
            Catagory.Name = "Catagory";
            Catagory.DataPropertyName = "Catagory";
            Catagory.Width = 0;
            Catagory.Visible = false;
            dtv.Columns.Add(Catagory);

            DataGridViewTextBoxColumn Active = new DataGridViewTextBoxColumn();
            Active.Name = "Active";
            Active.DataPropertyName = "Active";
            Active.Width = 0;
            Active.Visible = false;
            dtv.Columns.Add(Active);
          
        }
        private void FormatCollectedTestDataGrid(DataGridView dtv)
        {
            dtv.ColumnHeadersVisible = true;
            dtv.AllowUserToAddRows = false;
            dtv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtv.AutoGenerateColumns = false;
            dtv.ColumnCount = 24;
            dtv.Columns[0].Name = "labRoomID";
            dtv.Columns[0].DataPropertyName = "labRoomID";
            dtv.Columns[0].Width = 0;
            dtv.Columns[0].Visible = false;
            dtv.Columns[1].Name = "labPersonID";
            dtv.Columns[1].DataPropertyName = "labPersonID";
            dtv.Columns[1].Width = 0;
            dtv.Columns[1].Visible = false;
            dtv.Columns[2].Name = "reportGroupID";
            dtv.Columns[2].DataPropertyName = "reportGroupID";
            dtv.Columns[2].Width = 0;
            dtv.Columns[2].Visible = false;
            dtv.Columns[3].Name = "DepartmentID";
            dtv.Columns[3].DataPropertyName = "DepartmentID";
            dtv.Columns[3].Width = 0;
            dtv.Columns[3].Visible = false;
            dtv.Columns[4].Name = "DepartmentTitle";
            dtv.Columns[4].DataPropertyName = "DepartmentTitle";
            dtv.Columns[4].Width = 120;
            dtv.Columns[5].Name = "GroupCode";
            dtv.Columns[5].DataPropertyName = "GroupCode";
            dtv.Columns[5].Width = 0;
            dtv.Columns[5].Visible = false;
            dtv.Columns[6].Name = "Group";
            dtv.Columns[6].DataPropertyName = "Group";
            dtv.Columns[6].Width = 100;
            dtv.Columns[7].Name = "MainCode";
            dtv.Columns[7].DataPropertyName = "MainCode";
            dtv.Columns[7].Width = 0;
            dtv.Columns[7].Visible = false;
            dtv.Columns[8].Name = "Code";
            dtv.Columns[8].DataPropertyName = "TestCode";
            dtv.Columns[8].Width = 60;
            dtv.Columns[9].Name = "Room";
            dtv.Columns[9].DataPropertyName = "RoomTitle";
            dtv.Columns[9].Width = 150;
            dtv.Columns[10].Name = "Test Name";
            dtv.Columns[10].DataPropertyName = "TestName";
            dtv.Columns[10].DefaultCellStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dtv.Columns[10].Width = 340;
            dtv.Columns[11].Name = "Main Name";
            dtv.Columns[11].DataPropertyName = "MainName";
            dtv.Columns[11].Width = 120;
            dtv.Columns[11].DefaultCellStyle.ForeColor = Color.Red;
            dtv.Columns[11].DefaultCellStyle.Font = new Font("Verdana", 8, FontStyle.Italic);
            dtv.Columns[12].Name = "Charge";
            dtv.Columns[12].DataPropertyName = "Charge";
            dtv.Columns[12].Width = 90;
            dtv.Columns[12].DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dtv.Columns[13].Name = "deptfee";
            dtv.Columns[13].DataPropertyName = "deptfee";
            dtv.Columns[13].Width = 0;
            dtv.Columns[13].Visible = false;
            dtv.Columns[14].Name = "refdfee";
            dtv.Columns[14].DataPropertyName = "refdfee";
            dtv.Columns[14].Width = 0;
            dtv.Columns[14].Visible = false;
            dtv.Columns[15].Name = "DoctorFee";
            dtv.Columns[15].DataPropertyName = "DoctorFee";
            dtv.Columns[15].Width = 0;
            dtv.Columns[15].Visible = false;
            dtv.Columns[16].Name = "Disc";
            dtv.Columns[16].DataPropertyName = "discount";
            dtv.Columns[16].Width = 0;
            dtv.Columns[16].Visible = false;
            dtv.Columns[17].Name = "vat";
            dtv.Columns[17].DataPropertyName = "vat";
            dtv.Columns[17].Width = 0;
            dtv.Columns[17].Visible = false;
            dtv.Columns[18].Name = "PanelID";
            dtv.Columns[18].DataPropertyName = "PanelID";
            dtv.Columns[18].Width = 0;
            dtv.Columns[18].Visible = false;
            dtv.Columns[19].Name = "PanelTitle";
            dtv.Columns[19].DataPropertyName = "PanelTitle";
            dtv.Columns[19].Width = 0;
            dtv.Columns[19].Visible = false;
            dtv.Columns[20].Name = "LabRoom";
            dtv.Columns[20].DataPropertyName = "LabRoom";
            dtv.Columns[20].Width = 0;
            dtv.Columns[20].Visible = false;
            dtv.Columns[21].Name = "FeeCatagoryID";
            dtv.Columns[21].DataPropertyName = "FeeCatagoryID";
            dtv.Columns[21].Width = 0;
            dtv.Columns[21].Visible = false;
            dtv.Columns[22].Name = "Catagory";
            dtv.Columns[22].DataPropertyName = "Catagory";
            dtv.Columns[22].Width = 80;
            dtv.Columns[23].Name = "Active";
            dtv.Columns[23].DataPropertyName = "Active";
            dtv.Columns[23].Width = 0;
            dtv.Columns[23].Visible = false;           

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dtv.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.DefaultCellStyle.ForeColor = Color.Navy;
            btn.UseColumnTextForButtonValue = true;
            btn.Width = 50;
        }

        private void LoadOPDTests(DataGridView dtv, string prescriptionNo, string feeCategory, string status)
        {
            dtgvCollectedTest.Rows.Clear();
            List<TestFee> oTests = new List<TestFee>();
            oTests.AddRange(dmsSR.GetPrescriptionTests(prescriptionNo, feeCategory, status));

           foreach (TestFee data in oTests)
            {
                string[] row = new string[] { data.TestSub.SpecimenCollectionRoom.RoomID, txtLabPersonID.Text, data.TestSub.ReportGroup.ReportGroupID, data.TestSub.TestDepartment.DepartmentID, data.TestSub.TestDepartment.DepartmentTitle, data.TestSub.TestGroup.GroupId, data.TestSub.TestGroup.GroupTitle, data.TestSub.TestMainID, data.TestSub.TestSubID, data.TestSub.SpecimenCollectionRoom.RoomTitle.ToString(), data.TestSub.TestSubTitle, data.TestSub.TestMainTitle, data.Fee.ToString(), data.DeptFee.ToString(), data.DoctorFee.ToString(), data.RefdFee.ToString(), data.Discount.ToString(), data.VAT.ToString(), data.TestSub.PanelID.ToString(), txtPanelTitle.Text, data.TestSub.LabRoom.RoomID,data.FeeCategory.FeeCategoryID,data.FeeCategory.FeeCategoryTitle,data.EParameter.Active};
                if (data.EParameter.Active.ToString() == "0")
                {
                    AddRowsToCollection(dtgvCollectedTest, row);
                    dtgvCollectedTest.Rows[Convert.ToInt32(data.EParameter.Active)].DefaultCellStyle.BackColor = Color.LightGray;
                }
                if (data.EParameter.Active.ToString() == "1")
                {
                    AddRowsToCollection(dtgvCollectedTest, row);                    
                }
                updateCollectedTestSummary(dtgvCollectedTest);
                txtSubCode.Enabled = false;
            }
        }
        public static bool IsNumeric(object Expression)
        {
            double retNum;
            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        //private List<TestFee> SearchTestDetails(string group, string detail)
        //{
        //    List<TestFee> filteredTests=new List<TestFee>();

        //    if (IsNumeric(detail)==true)
        //    {
        //        filteredTests = oTestFees.Where(x => (x.TestSub.TestGroup.GroupId == group && x.TestSub.TestSubID == detail)).ToList();
        //    }
        //    else if (detail.Length > 0)
        //    {
        //        filteredTests = oTestFees.Where(x => (x.TestSub.TestGroup.GroupId == group && x.TestSub.TestSubTitle.ToUpper().Contains(detail.ToUpper()))).ToList();
        //    }
        //    else
        //    {
        //        filteredTests = oTestFees.Where(x => (x.TestSub.TestGroup.GroupId == group)).ToList();
        //    }
        //    return filteredTests;
        //}

        private List<TestFee> SearchTestDetails(string detail)
        {
            List<TestFee> filteredTests = new List<TestFee>();

            if (IsNumeric(detail) == true)
            {
                filteredTests = oTestFees.Where(x => (x.TestSub.TestSubID == detail)).ToList();
            }
            else if (detail.Length > 0)
            {
                filteredTests = oTestFees.Where(x => (x.TestSub.TestSubTitle.ToUpper().Contains(detail.ToUpper().ToString()))).ToList();
                if(filteredTests.Count==0)
                {
                    txtSubCode.Text = "";
                    txtTestSubTitle.Text = "";
                    txtFee.Text = "";
                }
            }
            else
            {
                filteredTests = oTestFees.ToList();
            }
            return filteredTests;
        }      
        private void PopulateDataToGrid(DataGridView dtv, string detail)
        {
            dtv.Visible = true;
            List<TestFee> SearchedTests = SearchTestDetails(detail);
            if (SearchedTests.Count > 0)
            {
                foreach (TestFee obj in SearchedTests)
                {
                    dtv.DataSource = SearchedTests.Select(data => new
                    {
                        data.TestSub.SpecimenCollectionRoom.RoomID,
                        data.TestSub.SpecimenCollectionRoom.RoomTitle,
                        data.TestSub.Technologist.ID,
                        data.TestSub.TestDepartment.DepartmentID,
                        data.TestSub.TestDepartment.DepartmentTitle,
                        data.TestSub.ReportGroup.ReportGroupID,
                        grp_id=data.TestSub.TestGroup.GroupId,
                        grp_title=data.TestSub.TestGroup.GroupTitle,
                        data.TestSub.TestSubID,
                        data.TestSub.TestSubTitle,
                        data.Fee,
                        data.RefdFee,
                        data.DeptFee,
                        data.DoctorFee,
                        data.TestSub.TestMainID,
                        data.TestSub.TestMainTitle,
                        data.Discount,
                        data.VAT,
                        data.TestSub.PanelID,
                        data.TestSub.PanelTitle,
                        LabRoomID = data.TestSub.LabRoom.RoomID,
                        FeeCatagoryID = data.FeeCategory.FeeCategoryID,
                        Catagory = data.FeeCategory.FeeCategoryTitle,
                        Active = data.EParameter.Active,
                    }).ToList();
                }
            }
            else
            {
                dtv.Visible = false;
            }
        }
     
        //private void PopulateDataToGrid(DataGridView dtv, string group, string detail)
        //{
        //    dtv.Visible = true;          
        //    List<TestFee> SearchedTests=SearchTestDetails(group,detail);
        //    if (SearchedTests.Count > 0)
        //    {
        //        foreach (TestFee obj in SearchedTests)
        //        {
        //            dtv.DataSource = SearchedTests.Select(data => new
        //            {                       
        //                data.TestSub.SpecimenCollectionRoom.RoomID,
        //                data.TestSub.SpecimenCollectionRoom.RoomTitle,
        //                data.TestSub.Technologist.ID,
        //                data.TestSub.TestDepartment.DepartmentID,
        //                data.TestSub.TestDepartment.DepartmentTitle,
        //                data.TestSub.ReportGroup.ReportGroupID,
        //                data.TestSub.TestGroup.GroupId,
        //                data.TestSub.TestSubID,
        //                data.TestSub.TestSubTitle,
        //                data.Fee,
        //                data.RefdFee,
        //                data.DeptFee,
        //                data.DoctorFee,
        //                data.TestSub.TestMainID,
        //                data.TestSub.TestMainTitle,
        //                data.Discount,
        //                data.VAT,
        //                data.TestSub.PanelID,
        //                data.TestSub.PanelTitle,
        //                LabRoomID = data.TestSub.LabRoom.RoomID,
        //                FeeCatagoryID = data.FeeCategory.FeeCategoryID,
        //                Catagory = data.FeeCategory.FeeCategoryTitle,
        //                Active = data.EParameter.Active,
        //            }).ToList();
        //        }
        //    }
        //    else
        //    {
        //        dtv.Visible = false;
        //    }
        //}
        private void updateCollectedTestSummary(DataGridView dtv)
        {
            lblTestCount.Text = dtv.RowCount.ToString();
            double sum = 0;
            for (int i = 0; i < dtv.Rows.Count; ++i)
            {
                if (dtv.Rows[i].Cells[23].Value.ToString() == "1")
                {
                    sum += Convert.ToDouble(dtv.Rows[i].Cells[12].Value.ToString()) - Convert.ToDouble(dtv.Rows[i].Cells[16].Value.ToString());
                }
            }
            lblTestAmountSummary.Text = sum.ToString();
            lblMinimumPayableAmount.Text = (sum * 0.75).ToString();
            txtDisc.Text = "0";
            txtDisc.Text = "0";
        }
        private void txtSubCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (PackageCheck.Checked == false)
                {
                    if ((txtSubCode.Text.Length == 0) && (e.KeyCode == Keys.Space))
                    {
                        cboDiagnosticTestGroup.Select();
                    }
                    if ((txtSubCode.Text.Length > 0) && (e.KeyCode == Keys.Enter) && Utility.IsNumeric(txtSubCode.Text))
                    {
                        if (IsTestAlreadyAdded(dtgvCollectedTest, txtSubCode.Text))
                        {
                            MessageBox.Show("Same Test Already Added", DUtility.Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                            return;
                        }
                        else
                        {
                            List<TestFee> tsfees = SearchTestDetails(txtSubCode.Text);
                            if (tsfees.Count == 1)
                            {
                                SetValuesDirectly(tsfees[0]);
                            }
                            else
                            {
                                MessageBox.Show("Invalid Test Code", DUtility.Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                                txtTestSubTitle.Text = "";
                                txtFee.Text = "";
                                return;
                            }
                            string[] row = new string[] { txtSpcRoomID.Text, txtLabPersonID.Text, txtReportGroupID.Text, txtDeptCode.Text, txtDepartmentTitle.Text, txtGroupCode.Text.ToString(), txtGroupTitle.Text, txtMainCode.Text, txtSubCode.Text, txtSpcRoomTitle.Text, txtTestSubTitle.Text, txtTestMainTitle.Text, txtFee.Text, txtDeptAmt.Text, txtRefdAmt.Text, txtDocAmt.Text, txtDisc.Text, txtVat.Text, txtPanelCode.Text, txtPanelTitle.Text, txtLabRoom.Text, txtFeeCatID.Text, txtFeeCatTitle.Text, txtActive.Text };
                            for (int i = 0; i < dtgvCollectedTest.Rows.Count; i++)
                            {
                                if (dtgvCollectedTest.Rows[i].Cells[21].Value.ToString() == "P")
                                {
                                    MessageBox.Show("Cannot Add Single Test With Package", DUtility.Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                                    txtTestSubTitle.Text = "";
                                    txtFee.Text = "";
                                    return;
                                }
                            }
                            for (int i = 0; i < dtgvCollectedTest.Rows.Count; i++)
                            {
                                List<TestFee> list = dmsSR.GetPanelTests(dtgvCollectedTest.Rows[i].Cells[18].Value.ToString()).ToList();
                                foreach (TestFee obj in list)
                                {
                                    if (obj.TestSub.TestSubID == txtSubCode.Text)
                                    {
                                        MessageBox.Show("Same Test Already Exists in Panel", DUtility.Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                                        txtTestSubTitle.Text = "";
                                        txtFee.Text = "";
                                        return;
                                    }
                                }
                            }
                            List<TestFee> oTestFees = dmsSR.GetPanelTests(txtPanelCode.Text).ToList();
                            foreach (TestFee obj in oTestFees)
                            {
                                for (int i = 0; i < dtgvCollectedTest.Rows.Count; i++)
                                {
                                    if (obj.TestSub.TestSubID == dtgvCollectedTest.Rows[i].Cells[8].Value.ToString())
                                    {
                                        MessageBox.Show("Panel Test Conflicting with Individual Test", DUtility.Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                                        txtTestSubTitle.Text = "";
                                        txtFee.Text = "";
                                        return;
                                    }
                                }
                            }
                            AddRowsToCollection(dtgvCollectedTest, row);
                            updateCollectedTestSummary(dtgvCollectedTest);
                            return;
                        }
                    }

                    if (e.KeyCode == Keys.Enter)
                    {
                        if (txtSubCode.Text.Length > 1)
                        {
                            lblSearch.Visible = false;
                            PopulateDataToGrid(dgvGetData, txtSubCode.Text);
                            this.dgvGetData.Focus();
                        }
                        else
                        {
                            lblSearch.Visible = true;
                            txtSubCode.Focus();
                        }

                    }
                    if (e.KeyCode == Keys.Down)
                    {
                        if (txtSubCode.Text.Length == 0)
                        {
                            MessageBox.Show("Please Put a Valid Code", DUtility.Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                            return;
                        }
                        PopulateDataToGrid(dgvGetData, txtSubCode.Text);

                        if (dgvGetData.RowCount == 0)
                        {
                            txtFee.Text = "";
                            return;
                        }
                        this.dgvGetData.Visible = true;

                        this.dgvGetData.Focus();
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
        private void ClearAfterAddTest()
        {
            txtSubCode.Text = "";
            txtMainCode.Text = "";
            txtFee.Text = "";
            txtTestSubTitle.Text = "";            
        }
        private void dgvGetData_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                SetValuesFromGrid(dgvGetData, sender);
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
        private void SetValuesDirectly(TestFee singleTest)
        {
            txtSpcRoomID.Text = singleTest.TestSub.SpecimenCollectionRoom.RoomID.ToString();
            txtSpcRoomTitle.Text = singleTest.TestSub.SpecimenCollectionRoom.RoomTitle.ToString();
            txtDeptCode.Text = singleTest.TestSub.TestDepartment.DepartmentID.ToString();
            txtDepartmentTitle.Text = singleTest.TestSub.TestDepartment.DepartmentTitle.ToString();
            txtReportGroupID.Text = singleTest.TestSub.ReportGroup.ReportGroupID.ToString();
            txtGroupCode.Text = singleTest.TestSub.TestGroup.GroupId.ToString();
            txtGroupTitle.Text = singleTest.TestSub.TestGroup.GroupTitle.ToString();
            txtSubCode.Text = singleTest.TestSub.TestSubID.ToString();
            txtTestSubTitle.Text = singleTest.TestSub.TestSubTitle.ToString();
            txtMainCode.Text = singleTest.TestSub.TestMainID.ToString();
            txtTestMainTitle.Text = singleTest.TestSub.TestMainTitle.ToString();
            txtFee.Text = singleTest.Fee.ToString();
            txtDeptAmt.Text = singleTest.DeptFee.ToString();
            txtRefdAmt.Text = singleTest.RefdFee.ToString();
            txtDocAmt.Text = singleTest.DoctorFee.ToString();
            txtDisc.Text = singleTest.Discount.ToString();
            txtVat.Text = singleTest.VAT.ToString();
            txtPanelCode.Text = singleTest.TestSub.PanelID.ToString();
            txtPanelTitle.Text = singleTest.TestSub.PanelTitle.ToString();
            txtLabRoom.Text = singleTest.TestSub.LabRoom.RoomID.ToString();
            txtFeeCatID.Text = singleTest.FeeCategory.FeeCategoryID;
            txtFeeCatTitle.Text = singleTest.FeeCategory.FeeCategoryTitle;
            txtActive.Text = singleTest.EParameter.Active;
        }
        private void SetValuesFromGrid(DataGridView dtv, object sender)
        {
            if (dtv.Rows.Count > 0)
            {
               int currentRow = dtv.CurrentRow.Index;              
                        txtSpcRoomID.Text = dtv["RoomID", currentRow].Value.ToString();
                        txtSpcRoomTitle.Text = dtv["RoomTitle", currentRow].Value.ToString();
                        txtDeptCode.Text = dtv["DepartmentID", currentRow].Value.ToString();
                        txtDepartmentTitle.Text = dtv["DepartmentTitle", currentRow].Value.ToString();
                        txtReportGroupID.Text = dtv["reportGroupID", currentRow].Value.ToString();
                        txtGroupCode.Text = dtv["grp_id", currentRow].Value.ToString();
                        txtGroupTitle.Text = dtv["grp_title", currentRow].Value.ToString();
                        txtSubCode.Text = dtv["Sub Code", currentRow].Value.ToString();
                        txtTestSubTitle.Text = dtv["Title", currentRow].Value.ToString();
                        txtMainCode.Text = dtv["TestMainID", currentRow].Value.ToString();
                        txtTestMainTitle.Text = dtv["Main Title", currentRow].Value.ToString();
                        txtFee.Text = dtv["Fee", currentRow].Value.ToString();
                        txtDeptAmt.Text = dtv["deptfee", currentRow].Value.ToString();
                        txtRefdAmt.Text = dtv["refdfee", currentRow].Value.ToString();
                        txtDocAmt.Text = dtv["DoctorFee", currentRow].Value.ToString();
                        txtDisc.Text = dtv["discount", currentRow].Value.ToString();

                        txtVat.Text = dtv["vat", currentRow].Value.ToString();

                        txtPanelCode.Text = dtv["PanelID", currentRow].Value.ToString();
                        txtPanelTitle.Text = dtv["PanelTitle", currentRow].Value.ToString();
                        txtLabRoom.Text = dtv["LabRoomID", currentRow].Value.ToString();
                        txtFeeCatID.Text = dtv["FeeCatagoryID", currentRow].Value.ToString();
                        txtFeeCatTitle.Text = dtv["Catagory", currentRow].Value.ToString();
                        txtActive.Text = dtv["Active", currentRow].Value.ToString();

                        dtv.Visible = false;
                        txtSubCode.Focus();                                
            }
            else
            {
                dtv.Visible = false;
                txtSubCode.Focus();
            }
        }
        private void AddRowsToCollection(DataGridView dtv, string[] row)
        {
            DataGridViewRow rw = new DataGridViewRow();
            dtv.Rows.Insert(0, row);
            ClearAfterAddTest();

        }
        private void AddRowsForTest(DataGridView dtv, string[] Value)
        {
            DataGridViewRow rw = new DataGridViewRow();
            dtv.Rows.Insert(0, Value);
            ClearAfterAddTest();
        }
        private Boolean IsTestAlreadyAdded(DataGridView dtv, string sCode)
        {
            if (dtv.RowCount < 0)
            {
                return false;
            }
            foreach (DataGridViewRow rw in dtv.Rows)
            {
                if (rw.Cells["Code"].Value.ToString() == sCode)
                {
                    return true;
                }
            }
            return false;
        }
        private object PaymentObject(AH.Shared.MODEL.OPDPayment payment)
        {
            OPDPayment paymentObject = new OPDPayment();
            paymentObject.Advance = payment.Advance;
            paymentObject.Amount = payment.Amount;
            paymentObject.CompanyID = payment.CompanyID;
            paymentObject.ConsultantFee = payment.ConsultantFee;
            paymentObject.Department = payment.Department;
            paymentObject.DepartmentUnit = payment.DepartmentUnit;
            paymentObject.DeptAmount = payment.DeptAmount;
            paymentObject.Discount = payment.Discount;
            paymentObject.EntryBy = payment.EntryBy;
            paymentObject.EntryDate = payment.EntryDate;
            paymentObject.EntryName = payment.EntryName;
            paymentObject.HCN = payment.HCN;
            paymentObject.LocationID = payment.LocationID;
            paymentObject.MachineID = payment.MachineID;
            paymentObject.NetAmount = payment.NetAmount;
            paymentObject.PaymentDate = payment.PaymentDate;
            paymentObject.PaymentType = payment.PaymentType;
            paymentObject.PreviousDue = payment.PreviousDue;
            paymentObject.PurposeID = payment.PurposeID;
            paymentObject.PurposeTitle = payment.PurposeTitle;
            paymentObject.ReffDept = payment.ReffDept;
            paymentObject.ReffDeptAmount = payment.ReffDeptAmount;
            paymentObject.ReffDeptUnit = payment.ReffDeptUnit;
            paymentObject.RefferedFee = payment.RefferedFee;
            paymentObject.RegistrationNo = payment.RegistrationNo;
            paymentObject.Staff = payment.Staff;
            paymentObject.TransactionNo = payment.TransactionNo;
            paymentObject.VAT = payment.VAT;
            paymentObject.Amount = payment.AmountGiven;
            paymentObject.AmountGiven = payment.AmountGiven;
            paymentObject.PaymentString = payment.PaymentString; 

            return paymentObject;
        }
        private void clear()
        {
            txtRegistrationNo.Text = "";
            txtPatientName.Text = "";
            txtAgeYears.Text = "";
            txtAgeMonths.Text = "";
            txtAgeDays.Text = "";
            txtAgeHours.Text = "";
            txtSex.Text = "";
            txtDepartmentName.Text = "";
            txtUnitTitle.Text = "";
            txtPresentAddress.Text = "";
            txtDoctorName.Text = "";
            txtMobileNo.Text = "";
            txtMoneyReceiptNo.Text = "";
            lblMinimumPayableAmount.Text = ""; 
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtHCNNo", "txtPatientName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (FormType == "X")
            {
                List<string> vfs = new List<string>() { "cboReffOrg", "cboReffDoc" };
                Control control1 = Utility.ReqFieldValidator(this, vfs);
                if (control1 != null)
                {
                    MessageBox.Show(Utility.getFMS(control1.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control1.Focus();
                    return;
                }
            }           
            if (dtgvCollectedTest.RowCount <= 0)
            {
                MessageBox.Show("Please Add Tests First", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubCode.Focus();
                return;
            }

            if (dmsSR.VerifyPatientNo(txtHCNNo.Text) == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHCNNo.Focus();
                return;
            }
            string label = "Diagnostic Money Receipt Issue";
            string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.DiagnosticColl);
            string patNo = txtHCNNo.Text;
            string patName = txtPatientName.Text;
            string department = txtPatDeptCode.Text;
            string departmentUnit = txtDeptUnit.Text;
            string reffDepartment = txtDeptCode.Text;
            string departmentReffUnit = txtDeptUnit.Text;
            decimal departmentAmount = 0;
            decimal reffDepartmentAmount = 0;
            string amount = lblTestAmountSummary.Text;
            string advance = "0";
            string vat = "0";
            string discount = "0";
            string discountBy = "0";
            string paymentType = "0";
            DateTime updateDate = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));

            if (cboTicketType.SelectedValue.ToString() == "E")
            {
                try
                {
                    OPDPayment paymentObject = new OPDPayment();
                    paymentObject.Advance = 0;
                    paymentObject.Amount = Convert.ToDecimal(lblTestAmountSummary.Text);
                    paymentObject.CompanyID = Utility.CompanyID;
                    paymentObject.ConsultantFee = 0;
                    paymentObject.Department = txtPatDeptCode.Text;
                    paymentObject.DepartmentUnit = txtPatDeptUnit.Text;
                    paymentObject.DeptAmount = 0;
                    paymentObject.Discount = 0;
                    paymentObject.EntryBy = Utility.UserId;
                    paymentObject.EntryDate = DateTime.Now;
                    paymentObject.EntryName = Utility.UserId;
                    paymentObject.HCN = "0124";
                    paymentObject.LocationID = Utility.LocationID;
                    paymentObject.MachineID = Utility.MachineID;
                    paymentObject.NetAmount = Convert.ToDecimal(lblTestAmountSummary.Text);
                    paymentObject.PaymentDate = DateTime.Now;
                    paymentObject.PaymentType = "I";
                    paymentObject.PreviousDue = 0;
                    paymentObject.PurposeID = Utility.GetPurposeCode(Utility.PurposeCode.DiagnosticColl);
                    paymentObject.PurposeTitle = "Test";
                    paymentObject.ReffDept = txtPatDeptCode.Text;
                    paymentObject.ReffDeptAmount = 0;
                    paymentObject.ReffDeptUnit = txtPatDeptUnit.Text;
                    paymentObject.RefferedFee = 0;
                    paymentObject.RegistrationNo = "0124";
                    paymentObject.Staff = "012";
                    paymentObject.TransactionNo = "012";
                    paymentObject.VAT = 0;
                    paymentObject.PaymentString = "0";

                    DiagnosticMR diagMrObj = this.PopulateDiagnosticMr(paymentObject);
                    string i = dmsSR.SaveDiagnosticMR(diagMrObj);

                    txtMoneyReceiptNo.Text = i;
                    printMR(txtMoneyReceiptNo.Text);
                    btnNew.PerformClick();
                    cboTicketType.Text = TicketType.ToString();
                    lblTestCount.Text = "0";
                    lblTestAmountSummary.Text = "0";
                    lblMinimumPayableAmount.Text = "0";
                    txtTicketNo.Focus();
                    txtRegistrationNo.Focus();
                    dtgvCollectedTest.Rows.Clear();
                    txtHCNNo.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
           
            if (cboTicketType.SelectedValue.ToString() != "E")
            {
                frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, amount, advance, vat.ToString(),
                                                discount, discountBy, department, reffDepartment, departmentUnit, departmentReffUnit, 
                                                departmentAmount, reffDepartmentAmount, updateDate, paymentType, 0, true);
                frm.onSaveButtonClicked = new frmPayment.SaveButtonClick(PaymentData);
                frm.ShowDialog();
            }
        }
        private void PaymentData(AH.Shared.MODEL.OPDPayment payment)
        {
            try
            {              
                DiagnosticMR diagMrObj = this.PopulateDiagnosticMr((OPDPayment)PaymentObject(payment));
                string i = dmsSR.SaveDiagnosticMR(diagMrObj);
                txtMoneyReceiptNo.Text = i;
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            printMR(txtMoneyReceiptNo.Text);
            btnNew.PerformClick();
            cboTicketType.Text = TicketType.ToString();
            lblTestCount.Text = "0";
            lblTestAmountSummary.Text = "0";
            lblMinimumPayableAmount.Text = "0";
            txtTicketNo.Focus();
            txtRegistrationNo.Focus();
            dtgvCollectedTest.Rows.Clear();          
            txtHCNNo.Focus();
        }
        private void printMR(string mrNo)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.DMSMoneyReceipt;
            vr.MoneyReceiptNo = mrNo;
            //vr.isPrintDirect = true;
            vr.ViewReport();         
        }
        private DiagnosticMR PopulateDiagnosticMr(OPDPayment payment)
        {
            DiagnosticMR diagMr = new DiagnosticMR();

            Ticket tkt = new Ticket();
            tkt.TicketNo = txtTicketNo.Text;
            tkt.TicketType = cboTicketType.SelectedValue.ToString();
            diagMr.Prescription = tkt;
            if (PackageCheck.Checked==true)
            {
                diagMr.PackageID = cboDiagPkg.SelectedValue.ToString();
            }
            else
            {
                diagMr.PackageID = "";
            }
            InPatient pat = new InPatient();
            pat.HCN = txtHCNNo.Text;
            pat.RegistrationNo = txtRegistrationNo.Text;

            Department dept = new Department();
            dept.DepartmentID = txtPatDeptCode.Text;
            pat.Department = dept;

            DepartmentUnit deptUnit = new DepartmentUnit();
            deptUnit.UnitId = txtPatDeptUnit.Text;
            pat.DepartmentUnit = deptUnit;

            AH.ModuleController.DMSSR.Age patientAge = new AH.ModuleController.DMSSR.Age();
            patientAge.Year = int.Parse(txtAgeYears.Text);
            patientAge.Month = int.Parse(txtAgeMonths.Text);
            patientAge.Day = int.Parse(txtAgeDays.Text);
            patientAge.Hour = int.Parse(txtAgeHours.Text);
            pat.AgeBreakDown = patientAge;

            Bed patBed = new Bed();
            patBed.BedID = txtBedNo.Text;

            Ward patWard = new Ward();
            patWard.WardID = "0";
            patBed.Ward = patWard;

            pat.Bed = patBed;

            pat.StaffID = txtStaffID.Text;

            EntryParameter ep = new EntryParameter();

            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;

            diagMr.EntryParameter = ep;

            diagMr.Patient = pat;

            SpecimenHolder spcCollector = new SpecimenHolder();
            spcCollector.HolderID = txtSpecimenCollectorID.Text;

            diagMr.SampleCollector = spcCollector;
            NursingTestOrder oNurstn = new NursingTestOrder();

            if (FormType == "I" || FormType == "O")
            {
                RefdOrg oRefdOrg = new RefdOrg();
                oRefdOrg.OrgID = "0";
                diagMr.RefdOrg = oRefdOrg;
                Doctor doc = new Doctor();
                doc.ID = txtDoctorID.Text;
                diagMr.Doctor = doc;
                diagMr.Remarks = "";                
            }
            if (FormType == "X" || FormType == "E")
            {
                RefdOrg oRefdOrg = new RefdOrg();
                oRefdOrg.OrgID = cboReffOrg.SelectedValue.ToString();
                diagMr.RefdOrg = oRefdOrg;

                Doctor doc = new Doctor();
                doc.ID = cboReffDoc.SelectedValue.ToString();
                diagMr.Doctor = doc;

                diagMr.Remarks = "";
            }
            if (FormType == "E")
            {
                oNurstn.NursingStationID = "12";
            }
            if (FormType == "S")
            {
                RefdOrg oRefdOrg = new RefdOrg();
                oRefdOrg.OrgID = "0";
                diagMr.RefdOrg = oRefdOrg;

                Doctor doc = new Doctor();
                doc.ID = "0";
                diagMr.Doctor = doc;

                diagMr.Remarks = txtRemarks.Text.ToString();
            }
            if (FormType != "E")
            {
                oNurstn.NursingStationID = "0";
            }
            diagMr.Patient = pat;

            diagMr.DRNo = txtDRNo.Text;
           
            diagMr.NursingTestOrder = oNurstn;

            List<TestFee> tests = new List<TestFee>();
            string string1 = "";

            foreach (DataGridViewRow dr in dtgvCollectedTest.Rows)
            {
                TestFee dt = new TestFee();
                TestSub ts = new TestSub();
                LabRoom lr = new LabRoom();
                LabTechnologist lt = new LabTechnologist();
                FeeCategory oFeeCat = new FeeCategory();               
                SpecimenCollectionRoom oSpc = new SpecimenCollectionRoom();
                oSpc.RoomID = dr.Cells["labRoomID"].Value.ToString();
                ts.SpecimenCollectionRoom = oSpc;
                lt.ID = "0";               
                ts.Technologist = lt;
                ReportGroup rpg = new ReportGroup();
                rpg.ReportGroupID = dr.Cells["reportGroupID"].Value.ToString();
                ts.ReportGroup = rpg;
                Department tstdept = new Department();
                tstdept.DepartmentID = dr.Cells["DepartmentID"].Value.ToString();
                ts.TestDepartment = tstdept;
                TestGroup tsttg = new TestGroup();
                tsttg.GroupId = dr.Cells["GroupCode"].Value.ToString();
                ts.TestGroup = tsttg;
                ts.TestMainID = dr.Cells["MainCode"].Value.ToString();
                ts.TestSubID = dr.Cells["Code"].Value.ToString();
                ts.PanelID = dr.Cells["PanelID"].Value.ToString();
                dt.TestSub = ts;

                oFeeCat.FeeCategoryID = dr.Cells["FeeCatagoryID"].Value.ToString();
                dt.FeeCategory = oFeeCat;

                dt.Fee = decimal.Parse(dr.Cells["Charge"].Value.ToString());
                dt.DeptFee = decimal.Parse(dr.Cells["deptfee"].Value.ToString());
                dt.RefdFee = decimal.Parse(dr.Cells["refdfee"].Value.ToString());
                dt.DoctorFee = decimal.Parse(dr.Cells["DoctorFee"].Value.ToString());
                dt.Discount = decimal.Parse(dr.Cells["Disc"].Value.ToString());
                dt.VAT = decimal.Parse(dr.Cells["vat"].Value.ToString());              
                lr.RoomID = dr.Cells["LabRoom"].Value.ToString();
                dt.DiscountType = "0";
                dt.DiscountReff = "0";
                dt.DiscountAuthority = "0";
                EntryParameter oEntry = new EntryParameter();
                oEntry.Active = dr.Cells["Active"].Value.ToString();
                dt.EParameter = oEntry;
                diagMr.test = dt;
                ts.LabRoom = lr;
                if (dr.Cells["Active"].Value.ToString() == "1")
                {
                    string1 += dt.TestSub.SpecimenCollectionRoom.RoomID + ":" + (dt.TestSub.Technologist.ID == "" ? "0" : dt.TestSub.Technologist.ID) + ":" + dt.TestSub.ReportGroup.ReportGroupID + ":" + dt.TestSub.TestDepartment.DepartmentID + ":" + dt.TestSub.TestGroup.GroupId + ":" + dt.TestSub.TestMainID + ":" + dt.TestSub.TestSubID + ":" + dt.TestSub.PanelID + ":" + dt.FeeCategory.FeeCategoryID + ":" + dt.Fee + ":" + dt.DeptFee + ":" + dt.RefdFee + ":" + dt.DoctorFee + ":" + dt.Discount + ":" + dt.VAT + ":" + dt.TestSub.LabRoom.RoomID + ";";
                }
            }
            diagMr.TestString1 = string1;
          
            diagMr.DiagnosticPayment = payment;
            
            return diagMr;
        }
        private string GetSearchText(string mode)
        {
            string searchText = "";
            switch (mode)
            {
                case "O": searchText = txtTicketNo.Text; 
                    break;
                case "I": searchText = txtRegistrationNo.Text;
                    break;
                case "X": searchText = txtHCNNo.Text;
                    break;
                case "S": searchText = txtHCNNo.Text;
                    break;
                case "E": searchText = txtHCNNo.Text;
                    break;
                case "F": searchText = txtHCNNo.Text;
                    break;

            }

            return searchText;
        }

        private void cboPatientSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormType == "O" && txtTicketNo.Text == "")
                {
                    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPrescriptionNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTicketNo.Select(); return;
                }
                if (FormType == "E" && txtHCNNo.Text == "")
                {
                    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPrescriptionNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTicketNo.Select(); 
                    return;
                }
                else if (FormType == "I" && txtRegistrationNo.Text == "")
                {
                    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidRegistrationNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRegistrationNo.Select(); return;

                }
                else if ((FormType != "O") && (FormType != "I") && (FormType != "E") && txtHCNNo.Text == "")
                {
                    if (txtMobileNo.Text == "")
                    {
                        MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHCNNo.Select();
                        return;
                    }

                }
                if (FormType == "O")
                {
                    string msg = string.Empty;
                    string vrfy = dmsSR.VarifyTicketNo(txtTicketNo.Text, true);
                    if (vrfy != "1")
                    {
                        MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTicketNo.Select();
                        btnNew.PerformClick();
                        dtgvCollectedTest.Rows.Clear();
                        return;
                    }

                }

                if ((FormType != "O") && (FormType != "I") && txtHCNNo.Text != "")
                {
                    if (dmsSR.VerifyPatientNo(txtHCNNo.Text) == "")
                    {
                        MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        clear();
                        txtHCNNo.Focus();
                        return;
                    };
                }
                string searchText = GetSearchText(FormType);
                Patient pat;

                if (FormType == "O")
                {
                    Ticket tkt = dmsSR.GetTicket(searchText);
                    LoadPatientet(tkt);
                    LoadOPDTests(dtgvCollectedTest, tkt.TicketNo, "01", "0");
                    txtPatDeptCode.Enabled = false;
                    txtPatDeptUnit.Enabled = false;
                    txtDoctorID.Enabled = false;
                }
                if (FormType == "E")
                {
                    pat = dmsSR.GetPatient(txtHCNNo.Text, "E");
                    LoadPatient(pat);                   
                }
                //if (FormType == "I")
                //{
                //    string vrfy = dmsSR.VerifyInPatient(txtRegistrationNo.Text);
                //    if (vrfy.Length > 0)
                //    {
                //        MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        txtRegistrationNo.Focus();
                //        return;
                //    }
                //    InPatient oPat = dmsSR.GetAdmittedPatient(txtRegistrationNo.Text);
                //    LoadPatientDetails(oPat);
                //    LoadIPDTests(dtgvCollectedTest, txtRegistrationNo.Text, txtDRNo.Text);
                //}
                if ((FormType != "O") && (FormType != "I") && (FormType != "E") && txtHCNNo.Text != "")
                {
                    pat = dmsSR.GetPatient(searchText, FormType);
                    LoadPatient(pat);
                    List<DiagnosticMR> oDiagMRs = dmsSR.GetDueByHCN(txtHCNNo.Text.ToString()).ToList();
                    if (oDiagMRs.Count > 0)
                    {
                        //MessageBox.Show("You Have Some Previous Due", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnDue.Visible = true;
                        btnDue.Focus();
                    }
                    if (oDiagMRs.Count == 0)
                    {
                        btnDue.Visible = false;
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
        //private void LoadPatientDetails(InPatient opat)
        //{
        //    txtHCNNo.Text = opat.HCN;
        //    txtPatientName.Text = opat.Name;
        //    AH.DUtility.Age age = Utility.CalculateAge(opat.DOB);
        //    txtAgeYears.Text = age.Year.ToString();
        //    txtAgeMonths.Text = age.Month.ToString();
        //    txtAgeDays.Text = age.Day.ToString();
        //    txtAgeHours.Text = "0";
        //    txtSex.Text = opat.Sex;
        //    txtDoctorID.Text = opat.Doctor.ID;
        //    txtDoctorName.Text = opat.Department.DepartmentUnitHead;
        //    txtPatDeptCode.Text = opat.Department.DepartmentID;
        //    txtPatDeptUnit.Text = opat.DepartmentUnit.UnitId;
        //    txtUnitTitle.Text = opat.DepartmentUnit.UnitTitle;
        //    txtDepartmentName.Text = opat.Department.DepartmentTitle;
        //    txtBedNo.Text = opat.Bed.BedNo;
        //    txtBed.Text = opat.Bed.BedType.Title + "(" + opat.Bed.BedType.BedFacility.Title + ")" +"-"+ opat.Bed.BedTitle;
        //    txtPresentAddress.Text = opat.Present_H_R_B + Utility.CrLf + Utility.CrLf + opat.PresentThana + ", " + opat.PresentDistrict;
        //    //txtMoneyReceiptNo.Text = opat.Payment.TransactionNo;
        //}
        private void LoadPatient(Patient pat)
        {
            txtPatientName.Text = pat.Name;
            DUtility.Age age = Utility.CalculateAge(pat.DOB);
            txtAgeYears.Text = age.Year.ToString();
            txtAgeMonths.Text = age.Month.ToString();
            txtAgeDays.Text = age.Day.ToString();
            txtAgeHours.Text = "0";
            txtSex.Text = pat.Sex;
            txtMobileNo.Text = pat.CellPhone;
            txtHCNNo.Text = pat.HCN;
            txtPresentAddress.Text = pat.Present_H_R_B + Utility.CrLf + Utility.CrLf + pat.PresentThana + ", " + pat.PresentDistrict;
            txtTicketNo.Text = EmrTicketNo.ToString();
        }

        private void LoadPatientet(Ticket tkt)
        {
            txtPatientName.Text = tkt.Patient.Name;
            txtSex.Text = tkt.Patient.Sex;
            txtHCNNo.Text = tkt.Patient.HCN;
            txtAgeYears.Text = tkt.PatientAge.Year.ToString();
            txtAgeMonths.Text = tkt.PatientAge.Month.ToString();
            txtAgeDays.Text = tkt.PatientAge.Day.ToString();
            txtAgeHours.Text = tkt.PatientAge.Hour.ToString();
            txtPatDeptCode.Text = tkt.TicketDepartment.DepartmentID;
            txtDepartmentName.Text = tkt.TicketDepartment.DepartmentTitle;
            txtPatDeptUnit.Text = tkt.Patient.DepartmentUnit.UnitId;
            txtUnitTitle.Text = tkt.Patient.DepartmentUnit.UnitTitle;
            txtDoctorID.Text = tkt.Doctor.ID;
            txtDoctorName.Text = tkt.Doctor.Name;
            txtPresentAddress.Text = tkt.Patient.Present_H_R_B + Utility.CrLf + Utility.CrLf + tkt.Patient.PresentThana + ", " + tkt.Patient.PresentDistrict;
        }
        private void cboTicketSearch_Click(object sender, EventArgs e)
        {
            LoadTicket(txtTicketNo.Text);
        }
        private void LoadTicket(string ticketNo)
        {
            Ticket tkt = dmsSR.GetTicket(ticketNo);
            txtHCNNo.Text = tkt.Patient.HCN;
            txtPatientName.Text = tkt.Patient.Name;
            txtSex.Text = tkt.Patient.Sex;
            txtDeptCode.Text = tkt.Patient.Department.DepartmentID;
            txtDeptUnit.Text = tkt.Patient.DepartmentUnit.UnitId;
            txtDoctorID.Text = tkt.Doctor.ID;
            AH.DUtility.Age age = Utility.CalculateAge(tkt.Patient.DOB);
            txtAgeYears.Text = age.Year.ToString();
            txtAgeMonths.Text = age.Month.ToString();
            txtAgeDays.Text = age.Day.ToString();
            txtDepartmentName.Text = tkt.Patient.Department.DepartmentTitle;
            txtDoctorName.Text = tkt.Doctor.Name;
            txtPresentAddress.Text = tkt.Patient.Present_H_R_B + Utility.CrLf + Utility.CrLf + tkt.Patient.PresentThana + ", " + tkt.Patient.PresentDistrict;
        }

        private void ShowHideIndoor(short mode)
        {
            //switch (mode)
            //{
            //    case 0:
            //        smartLabel17.Visible = false;
            //        smartLabel18.Visible = false;
            //        txtBed.Visible = false;
            //        txtWard.Visible = false;
            //        break;
            //    case 1:
            //        smartLabel17.Visible = false;
            //        smartLabel18.Visible = true;
            //        txtBed.Visible = true;
            //        txtWard.Visible = false;
            //        break;
            //}

        }
        private void FormatForm(string mode)
        {
            switch (mode)
            {
                case "O":
                    txtTicketNo.Visible = true;
                    txtRegistrationNo.Visible = false;
                    txtTicketNo.Top = txtHCNNo.Top;
                    txtTicketNo.Left = txtHCNNo.Left;
                    txtTicketNo.Size = new Size(txtHCNNo.Size.Width, txtHCNNo.Size.Height);
                    smartLabel2.Text = "Prescription No";
                    txtHCNNo.Visible = false;
                    txtTicketNo.Text = "";
                    txtSubCode.Enabled = false;
                    lblDepartment.Visible = true;
                    lblUnit.Visible = true;
                    txtDepartmentName.Visible = true;
                    txtUnitTitle.Visible = true;
                    lblDoctor.Visible = true;
                    txtDoctorName.Visible = true;
                    lblReffOrg.Visible = false;
                    cboReffOrg.Visible = false;
                    cboReffDoc.Visible = false;
                    btnAddReffOrg.Visible = false;
                    btnRefreshOrg.Visible = false;
                    btnAddReffDoc.Visible = false;
                    btnRefreshDoc.Visible = false;
                    lblRemarks.Visible = false;
                    txtRemarks.Visible = false;
                    btnAdvanceSearch.Visible = false;                    
                    ShowHideIndoor(0);
                    txtTicketNo.Select();
                    break;              
                case "X":
                    smartLabel2.Text = "HCN No";
                    txtRegistrationNo.Visible = false;
                    txtTicketNo.Visible = false;
                    txtHCNNo.Visible = true;
                    txtHCNNo.Text = "";
                    txtHCNNo.Select();
                    txtSubCode.Enabled = true;
                    lblDepartment.Visible = false;
                    lblUnit.Visible = false;
                    txtDepartmentName.Visible = false;
                    txtUnitTitle.Visible = false;
                    lblDoctor.Visible = true;
                    txtDoctorName.Visible = false;
                    lblReffOrg.Visible = true;
                    cboReffOrg.Visible = true;
                    cboReffDoc.Visible = true;
                    btnAddReffOrg.Visible = true;
                    btnRefreshOrg.Visible = true;
                    btnAddReffDoc.Visible = true;
                    btnRefreshDoc.Visible = true;
                    lblRemarks.Visible = false;
                    txtRemarks.Visible = false;
                    btnAdvanceSearch.Visible = false;
                    break;
                case "S":
                    ShowHideIndoor(0);
                    smartLabel2.Text = "HCN No";
                    txtHCNNo.Visible = true;
                    txtRegistrationNo.Visible = false;
                    txtTicketNo.Visible = false;
                    txtSubCode.Enabled = true;
                    lblDepartment.Visible = false;
                    lblUnit.Visible = false;
                    txtDepartmentName.Visible = false;
                    txtUnitTitle.Visible = false;
                    lblDoctor.Visible = false;
                    txtDoctorName.Visible = false;
                    lblReffOrg.Visible = false;
                    cboReffOrg.Visible = false;
                    cboReffDoc.Visible = false;
                    btnAddReffOrg.Visible = false;
                    btnRefreshOrg.Visible = false;
                    btnAddReffDoc.Visible = false;
                    btnRefreshDoc.Visible = false;
                    lblRemarks.Visible = true;
                    txtRemarks.Visible = true;
                    btnAdvanceSearch.Visible = false;
                    txtHCNNo.Select();
                    break;
                case "E":
                    ShowHideIndoor(0);
                    smartLabel2.Text = "HCN No";
                    txtHCNNo.Visible = true;
                    txtRegistrationNo.Visible = false;
                    txtTicketNo.Visible = false;
                    txtSubCode.Enabled = true;
                    lblDepartment.Visible = false;
                    lblUnit.Visible = false;
                    txtDepartmentName.Visible = false;
                    txtUnitTitle.Visible = false;
                    lblDoctor.Visible = true;
                    txtDoctorName.Visible = false;
                    lblReffOrg.Visible = true;
                    cboReffOrg.Visible = true;
                    cboReffDoc.Visible = true;
                    btnAddReffOrg.Visible = true;
                    btnRefreshOrg.Visible = true;
                    btnAddReffDoc.Visible = true;
                    btnRefreshDoc.Visible = true;
                    lblRemarks.Visible = false;
                    txtRemarks.Visible = false;
                    btnAdvanceSearch.Visible = false;
                    txtHCNNo.Select();
                    break;
                case "F":
                    ShowHideIndoor(0);
                    smartLabel2.Text = "Prescription No";
                    txtHCNNo.Visible = true;
                    txtRegistrationNo.Visible = false;
                    txtTicketNo.Visible = false;
                    txtSubCode.Enabled = true;
                    lblDepartment.Visible = false;
                    lblUnit.Visible = false;
                    txtDepartmentName.Visible = false;
                    txtUnitTitle.Visible = false;
                    lblDoctor.Visible = true;
                    txtDoctorName.Visible = false;
                    lblReffOrg.Visible = true;
                    cboReffOrg.Visible = true;
                    cboReffDoc.Visible = true;
                    btnAddReffOrg.Visible = true;
                    btnRefreshOrg.Visible = true;
                    btnAddReffDoc.Visible = true;
                    btnRefreshDoc.Visible = true;
                    txtHCNNo.Select();
                    break;
            }

        }
        private void cboTicketType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDue.Visible = false;
            if (cboTicketType.SelectedValue != "")
            {
                TicketType = cboTicketType.Text;
                string lbl = "Diagnostic Billing For :-";
                frmLabel.Text = lbl + cboTicketType.Text;
                FormatForm(cboTicketType.SelectedValue.ToString());
                
                this.FormType = cboTicketType.SelectedValue.ToString();
                FormSelector();
                dtgvCollectedTest.Rows.Clear();
                clear();
                txtMoneyReceiptNo.Text = "";
                lblMinimumPayableAmount.Text = "";               
            }
        }
        private void cboDiagnosticTestGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSubCode.Text = "";
                txtSubCode.Focus();
            }
        }
        private void dgvGetData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SetValuesFromGrid(dgvGetData, sender);
        }   
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtTicketNo", "txtPatientName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {

                DiagnosticMR tspobj = this.PopulateDiagMrDetail();
                short i = dmsSR.SaveDiagnosticMRDraft(tspobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private DiagnosticMR PopulateDiagMrDetail()
        {
            DiagnosticMR dmr = new DiagnosticMR();
            dmr.DraftNo = txtDraftNo.Text;

            Ticket tkt = new Ticket();
            tkt.TicketNo = txtTicketNo.Text;
            tkt.TicketType = cboTicketType.SelectedValue.ToString();
            dmr.Prescription = tkt;

            Doctor doc = new Doctor();
            doc.ID = txtDoctorID.Text;
            dmr.Doctor = doc;

            Department dpt = new Department();
            dpt.DepartmentID = txtPatDeptCode.Text;

            DepartmentUnit unt = new DepartmentUnit();
            unt.UnitId = txtPatDeptUnit.Text;

            InPatient pat = new InPatient();
            pat.HCN = txtHCNNo.Text;
            pat.RegistrationNo = txtRegistrationNo.Text;
            pat.StaffID = "0";
            pat.Department = dpt;
            pat.DepartmentUnit = unt;
            dmr.Patient = pat;
            dmr.DRNo = txtDRNo.Text;

            NursingTestOrder oNurstn = new NursingTestOrder();
            oNurstn.NursingStationID = "0";
            dmr.NursingTestOrder = oNurstn;
           
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            dmr.EntryParameter = ep;

            List<TestFee> tests = new List<TestFee>();

            foreach (DataGridViewRow dr in dtgvCollectedTest.Rows)
            {
                TestFee dt = new TestFee();
                TestSub ts = new TestSub();
                FeeCategory ofeeCat = new FeeCategory();
                Room lr = new Room();
                LabTechnologist lt = new LabTechnologist();
                lt.ID = "";
                lr.RoomID = dr.Cells["labRoomID"].Value.ToString();
                ts.Room = lr;
                ts.Technologist = lt;
                ReportGroup rpg = new ReportGroup();
                rpg.ReportGroupID = dr.Cells["reportGroupID"].Value.ToString();
                ts.ReportGroup = rpg;
                ts.TestDepartment.DepartmentID = dr.Cells["DepartmentID"].Value.ToString();
                ts.TestGroup.GroupId = dr.Cells["GroupCode"].Value.ToString();
                ts.TestMainID = dr.Cells["MainCode"].Value.ToString();
                ts.TestSubID = dr.Cells["Code"].Value.ToString();
                dt.TestSub = ts;



                ofeeCat.FeeCategoryID = "01";
                dt.FeeCategory = ofeeCat;



                dt.Fee = decimal.Parse(dr.Cells["Charge"].Value.ToString());
                dt.DeptFee = decimal.Parse(dr.Cells["deptfee"].Value.ToString());
                dt.RefdFee = decimal.Parse(dr.Cells["refdfee"].Value.ToString());
                dt.DoctorFee = decimal.Parse(dr.Cells["DoctorFee"].Value.ToString());
                dt.Discount = decimal.Parse(dr.Cells["Disc"].Value.ToString());
                tests.Add(dt);
            }

            dmr.Tests = tests.ToArray<TestFee>();

            return dmr;
        }

        private void txtHCNNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (FormType == "X" || FormType == "S" || FormType == "E" || FormType == "F")
            {
                if (txtHCNNo.Text.Length == Utility.ScanLength)
                {
                    cboPatientSearch_Click(sender, e);
                }
            }
        }
        private void txtTicketNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTicketNo.Text.Length == Utility.ScanLength)
            {
                cboPatientSearch_Click(sender, e);
            }
        }

        private void txtRegistrationNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtRegistrationNo.Text.Length == Utility.ScanLength)
            {
                cboPatientSearch_Click(sender, e);
            }
        }

        private void btnDeleteTest_Click(object sender, EventArgs e)
        {
            int selectedIndex = dtgvCollectedTest.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                dtgvCollectedTest.Rows.RemoveAt(selectedIndex);
                dtgvCollectedTest.Refresh(); // if needed
                updateCollectedTestSummary(dtgvCollectedTest);
            }
        }

        private void dgvGetData_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SetValuesFromGrid(dgvGetData, sender);
        }
        private void dtgvCollectedTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgvCollectedTest.Columns[e.ColumnIndex].Name == "btn")
                {
                    if (dtgvCollectedTest.CurrentCell != null)
                    {
                        int selectedIndex = dtgvCollectedTest.CurrentCell.RowIndex;
                        if (selectedIndex > -1)
                        {
                            DialogResult msg = MessageBox.Show("Do You want to Delete?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if (msg == DialogResult.Yes)
                            {
                                dtgvCollectedTest.Rows.RemoveAt(selectedIndex);
                                dtgvCollectedTest.Refresh(); // if needed
                                updateCollectedTestSummary(dtgvCollectedTest);
                            }
                            else
                            {
                                return;
                            }
                           
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
        private void pnlMain_Click(object sender, EventArgs e)
        {
            dgvGetData.Visible = false;
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSubCode_KeyDown(sender, e);
                txtSubCode.Focus();
            }
        }
        private void txtDisc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSubCode_KeyDown(sender, e);
                txtSubCode.Focus();
            }
        }
        private void LoadIPDTests(DataGridView dtv, string RegNo,string DRNo)
        {
            dtgvCollectedTest.Rows.Clear();
            List<TestFee> oTests = new List<TestFee>();
            oTests.AddRange(dmsSR.GetIPDTests(RegNo, DRNo));
            foreach (TestFee data in oTests)
            {
                string[] row = new string[] { data.TestSub.SpecimenCollectionRoom.RoomID, txtLabPersonID.Text, data.TestSub.ReportGroup.ReportGroupID, data.TestSub.TestDepartment.DepartmentID, data.TestSub.TestDepartment.DepartmentTitle, data.TestSub.TestGroup.GroupId, data.TestSub.TestGroup.GroupTitle, data.TestSub.TestMainID, data.TestSub.TestSubID, data.TestSub.SpecimenCollectionRoom.RoomTitle.ToString(), data.TestSub.TestSubTitle, data.TestSub.TestMainTitle, data.Fee.ToString(), data.DeptFee.ToString(), data.DoctorFee.ToString(), data.RefdFee.ToString(), data.Discount.ToString(), data.VAT.ToString(), data.TestSub.PanelID.ToString(), data.TestSub.PanelTitle.ToString(), data.TestSub.LabRoom.RoomID,data.FeeCategory.FeeCategoryID,data.FeeCategory.FeeCategoryTitle,data.EParameter.Active };
                if (data.EParameter.Active.ToString() == "0")
                {
                    AddRowsToCollection(dtgvCollectedTest, row);
                    dtgvCollectedTest.Rows[Convert.ToInt32(data.EParameter.Active)].DefaultCellStyle.BackColor = Color.LightGray;
                }
                if (data.EParameter.Active.ToString() == "1")
                {
                    AddRowsToCollection(dtgvCollectedTest, row);
                }
                updateCollectedTestSummary(dtgvCollectedTest);
            }
            //updateCollectedTestSummary(dtgvCollectedTest);
        }
             
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<Patient> pats = dmsSR.GetPatientByPhone("", txtMobileNo.Text.ToString()).ToList();
                if (pats.Count > 0)
                {
                    foreach (Patient opat in pats)
                    {
                        txtHCNNo.Text = opat.HCN;
                        //LoadPatient(opat);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Mobile Number", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHCNNo.Text = "";
                    txtPatientName.Text = "";
                    txtAgeYears.Text = "";
                    txtAgeMonths.Text = "";
                    txtAgeDays.Text = "";
                    txtAgeHours.Text = "";
                    txtSex.Text = "";
                    txtPresentAddress.Text = "";
                    txtMobileNo.Focus();
                    return;
                }
                cboPatientSearch_Click(sender, e);
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

        private void dtgvCollectedTest_Click(object sender, EventArgs e)
        {
            dgvGetData.Visible = false;
        }

        private void cboReffOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboReffDoc.DisplayMember = "Value";
            cboReffDoc.ValueMember = "Key";
            cboReffDoc.DataSource = new BindingSource(dmsSR.GetReffdDocDic(cboReffOrg.SelectedValue.ToString()), null);
        }

        private void btnAddReffOrg_Click(object sender, EventArgs e)
        {
            frmReffdOrgSetup oReffOrg = new frmReffdOrgSetup();
            oReffOrg.ShowDialog();
        }
        private void btnRefreshOrg_Click(object sender, EventArgs e)
        {
            cboReffOrg.DisplayMember = "Value";
            cboReffOrg.ValueMember = "Key";
            cboReffOrg.DataSource = new BindingSource(dmsSR.GetReffdOrgDic("D"), null);
        }

        private void btnAddReffDoc_Click(object sender, EventArgs e)
        {
            frmReffdDocSetup oReffDoc = new frmReffdDocSetup();
            oReffDoc.ReffOrg = cboReffOrg.SelectedValue.ToString();
            oReffDoc.ShowDialog();
        }

        private void btnRefreshDoc_Click(object sender, EventArgs e)
        {
            cboReffDoc.DisplayMember = "Value";
            cboReffDoc.ValueMember = "Key";
            cboReffDoc.DataSource = new BindingSource(dmsSR.GetReffdDocDic(cboReffOrg.SelectedValue.ToString()), null);
        }
        private void btnAddFeeCat_Click(object sender, EventArgs e)
        {
            frmFeeCategory oFeeCat = new frmFeeCategory();
            oFeeCat.ShowDialog();
        }
        private void btnRefreshFeeCat_Click(object sender, EventArgs e)
        {
            cboFeeCatID.DisplayMember = "Value";
            cboFeeCatID.ValueMember = "Key";
            cboFeeCatID.DataSource = new BindingSource(dmsSR.GetFeecatDict("D"), null);
        }
        private void cboFeeCatID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDiagnosticTestGroup.SelectedValue != null)
            {
                LoadTest(cboDiagnosticTestGroup.SelectedValue.ToString(), cboFeeCatID.SelectedValue.ToString());
            }
        }

        private void dgvGetData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                SetValuesFromGrid(dgvGetData, sender);
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
        private void txtHCNNo_TextChanged(object sender, EventArgs e)
        {
            txtHCNNo.CharacterCasing = CharacterCasing.Upper;
        }
      
        private void cboDiagnosticTestGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFeeCatID.SelectedValue != null)
            {
                LoadTest(cboDiagnosticTestGroup.SelectedValue.ToString(), cboFeeCatID.SelectedValue.ToString());
            }
        }

        private void btnDue_Click(object sender, EventArgs e)
        {
            frmDueListByHCN oDueList = new frmDueListByHCN();
            oDueList.HCN = txtHCNNo.Text.ToString();
            oDueList.PatName = txtPatientName.Text.ToString();
            oDueList.ShowDialog();
        }

        private void btnTestCancel_Click(object sender, EventArgs e)
        {
            frmTestCancel oTestCancel = new frmTestCancel();
            oTestCancel.ShowDialog();
        }

        private void txtTicketNo_TextChanged(object sender, EventArgs e)
        {
            txtTicketNo.CharacterCasing = CharacterCasing.Upper;
        }

        private void PackageCheck_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender is CheckBox)
                {
                    CheckBox checkbox = sender as CheckBox;
                    if (checkbox.Checked)
                    {
                        cboFeeCatID.Enabled = false;
                        dgvGetData.Visible = false;
                        txtSubCode.Enabled = false;
                        cboDiagPkg.Enabled = true;
                        cboDiagPkg.DisplayMember = "Value";
                        cboDiagPkg.ValueMember = "Key";
                        cboDiagPkg.DataSource = new BindingSource(dmsSR.GetDiagPackageDict("D"), null);
                        if (cboDiagPkg.SelectedValue != "")
                        {
                            LoadPackageTest(cboDiagPkg.SelectedValue.ToString());
                        }
                    }
                    else
                    {
                        cboFeeCatID.Enabled = true;
                        cboDiagPkg.Enabled = false;
                        txtSubCode.Enabled = true;
                        LoadTest(cboFeeCatID.SelectedValue.ToString(), txtSubCode.Text.ToString());
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
            try
            {
                if (cboDiagPkg.SelectedValue != null)
                {
                    if (cboDiagPkg.Enabled==true)
                    {
                    if (PackageCheck.Checked == true && dtgvCollectedTest.Rows.Count > 0)
                    {
                        MessageBox.Show("Cannot Add Two Package in Same Collection", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboDiagPkg.SelectedValue = txtPackageID.Text.ToString();
                        return;
                    }
                    foreach (TestFee obj in oTestFees)
                    {
                        dtgvCollectedTest.DataSource = null;
                        dtgvCollectedTest.Rows.Clear();
                        int i = 0;
                        if (oTestFees.Count > 0)
                        {
                            txtPackageID.Text = cboDiagPkg.SelectedValue.ToString();

                            foreach (TestFee oTestFee in oTestFees)
                            {
                                dtgvCollectedTest.Rows.Add(1);
                                dtgvCollectedTest.Rows[i].Cells[0].Value = oTestFee.TestSub.LabRoom.RoomID;
                                dtgvCollectedTest.Rows[i].Cells[1].Value = oTestFee.TestSub.Technologist.ID;
                                dtgvCollectedTest.Rows[i].Cells[2].Value = oTestFee.TestSub.ReportGroup.ReportGroupID;
                                dtgvCollectedTest.Rows[i].Cells[3].Value = oTestFee.TestSub.TestDepartment.DepartmentID;
                                dtgvCollectedTest.Rows[i].Cells[4].Value = oTestFee.TestSub.TestDepartment.DepartmentTitle;
                                dtgvCollectedTest.Rows[i].Cells[5].Value = oTestFee.TestSub.TestGroup.GroupId;
                                dtgvCollectedTest.Rows[i].Cells[6].Value = oTestFee.TestSub.TestGroup.GroupTitle;
                                dtgvCollectedTest.Rows[i].Cells[7].Value = oTestFee.TestSub.TestMainID;
                                dtgvCollectedTest.Rows[i].Cells[8].Value = oTestFee.TestSub.TestSubID;
                                dtgvCollectedTest.Rows[i].Cells[9].Value = oTestFee.TestSub.SpecimenCollectionRoom.RoomTitle;
                                dtgvCollectedTest.Rows[i].Cells[10].Value = oTestFee.TestSub.TestSubTitle;
                                dtgvCollectedTest.Rows[i].Cells[11].Value = oTestFee.TestSub.TestMainTitle;
                                dtgvCollectedTest.Rows[i].Cells[12].Value = oTestFee.Fee;
                                dtgvCollectedTest.Rows[i].Cells[13].Value = oTestFee.DeptFee;
                                dtgvCollectedTest.Rows[i].Cells[14].Value = oTestFee.RefdFee;
                                dtgvCollectedTest.Rows[i].Cells[15].Value = oTestFee.DoctorFee;
                                dtgvCollectedTest.Rows[i].Cells[16].Value = oTestFee.Discount;
                                dtgvCollectedTest.Rows[i].Cells[17].Value = oTestFee.VAT;
                                dtgvCollectedTest.Rows[i].Cells[18].Value = oTestFee.TestSub.PanelID;
                                dtgvCollectedTest.Rows[i].Cells[19].Value = oTestFee.TestSub.PanelTitle;
                                dtgvCollectedTest.Rows[i].Cells[20].Value = oTestFee.TestSub.LabRoom.RoomID;
                                dtgvCollectedTest.Rows[i].Cells[21].Value = oTestFee.FeeCategory.FeeCategoryID;
                                dtgvCollectedTest.Rows[i].Cells[22].Value = oTestFee.FeeCategory.FeeCategoryTitle;
                                dtgvCollectedTest.Rows[i].Cells[23].Value = oTestFee.EParameter.Active;
                                i = i + 1;
                            }
                            dtgvCollectedTest.AllowUserToAddRows = false;
                            updateCollectedTestSummary(dtgvCollectedTest);
                        }
                        else
                        {
                            return;
                        }
                        dtgvCollectedTest.CurrentCell = null;
                        dtgvCollectedTest.ClearSelection();
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

        private void cboDiagPkg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDiagPkg.SelectedValue != null)
            {
                if (cboDiagPkg.SelectedValue != "")
                {
                    LoadPackageTest(cboDiagPkg.SelectedValue.ToString());
                }
            }
        }

      

    }
}
