using AH.DUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.NWMSSR;
using AH.Shared.UI;
using AH.ModuleController.UI.NWMS.Forms;
using AH.ModuleController.UI.DRS.Forms;


namespace AH.ModuleController.UI.NWMS
{
    public partial class frmNurseRequisition : AH.Shared.UI.frmSmartFormStandard
    {
        NWMSSR.NWMSWSClient nwbnch = new NWMSSR.NWMSWSClient();

        private string bedID;
        List<TestFee> testsListAll;
        List<ItemOrder> AccessoriesListAll;
        public frmNurseRequisition(string bedID)
        {
            InitializeComponent();
            this.bedID = bedID;
        }
        private void frmNurseRequisition_Load(object sender, EventArgs e)
        {
            txtAccessoriesBillTotal.Text = "0";
            LoadCategory();
            //chkSearchFromAllTest.Checked = true;
            InPatient pat = nwbnch.GetPatRegID(bedID);
            txtPatRegNoIPD.Text = pat.RegistrationNo;
            this.btnFind.PerformClick();
          //  txtNurseStn.Text = pat.NurseStation.NurseStationID;
            txtSearchInvestigation.ReadOnly = true;
            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(nwbnch.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Ancillary)), null);
            FormateProvidedDrugs();
            FormateProvidedTests();
            FormatGridView(dgvMedicine);
            FormateDoctorsListView();
            FormatdgvMedReceive();
            FormatdgvTestReceive();
            FormatdgvIssueDetails();
            FormatGrid();
            FormatGrids();
            FormatCheckedList();
            FormatDrugsCheckedList();
            FormatGridItemDetails();
            FormatGridlvItemMaster();
            this.btnDrugHistory_Click(sender, e);
            this.btnTestHistory_Click(sender, e);
            chkSearchFromAllTest.Checked = true;
         //   txtNurseStn.Text = pat.NurseStation.NurseStationID;
        }
        private void LoadCategory()
        {
            cboFeeCatID.DisplayMember = "Value";
            cboFeeCatID.ValueMember = "Key";
            cboFeeCatID.DataSource = new BindingSource(nwbnch.GetFeecatDict("D"), null);
        }
        private void FormateDoctorsListView()
        {
            lvIPDDoctors.Columns.Add("Department ID", 0, HorizontalAlignment.Left);//1
            lvIPDDoctors.Columns.Add("Department", 200, HorizontalAlignment.Left);//2
            lvIPDDoctors.Columns.Add("Unit ID", 0, HorizontalAlignment.Left);//3
            lvIPDDoctors.Columns.Add("Unit", 200, HorizontalAlignment.Left);//4
            lvIPDDoctors.Columns.Add("Doctor ID", 0, HorizontalAlignment.Left);//5
            lvIPDDoctors.Columns.Add("Doctor", 471, HorizontalAlignment.Left);//6
            lvIPDDoctors.Columns.Add("Visiting Fee", 100, HorizontalAlignment.Left);//7
            lvIPDDoctors.Columns.Add("Visit Number", 150, HorizontalAlignment.Left);//8
            lvIPDDoctors.Columns.Add("Visiting Date", 180, HorizontalAlignment.Left);//9
        }
        private void FormateProvidedTests()
        {
            lvProvidedTests.CheckBoxes = false;
            lvProvidedTests.Columns.Add("Visit Number", 100, HorizontalAlignment.Left);//0
            lvProvidedTests.Columns.Add("Main ID", 0, HorizontalAlignment.Left);//1
            lvProvidedTests.Columns.Add("Main Title", 171, HorizontalAlignment.Left);//2
            lvProvidedTests.Columns.Add("Detail ID", 0, HorizontalAlignment.Left);//3
            lvProvidedTests.Columns.Add("Detail Title", 300, HorizontalAlignment.Left);//4
        }

        private void FormateProvidedDrugs()
        {
            lvProvidedDrugs.CheckBoxes = false;
            lvProvidedDrugs.Columns.Add("Visit Number", 110, HorizontalAlignment.Left);//0
            lvProvidedDrugs.Columns.Add("Drug ID", 100, HorizontalAlignment.Left);//1
            lvProvidedDrugs.Columns.Add("Drug Name", 210, HorizontalAlignment.Left);//2
            lvProvidedDrugs.Columns.Add("Group ID", 0, HorizontalAlignment.Left);//3
            lvProvidedDrugs.Columns.Add("Total", 50, HorizontalAlignment.Left);//4
            lvProvidedDrugs.Columns.Add("Remaining", 68, HorizontalAlignment.Left);//5
        }
        private void lvProvidedDrugs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProvidedDrugs.SelectedItems.Count >0)
            {
                ListViewItem itm = lvProvidedDrugs.SelectedItems[0];
                txtVisitNumber.Text = itm.SubItems[0].Text;
                txtDrugName.Text = itm.SubItems[2].Text;
                txtDrugID.Text = itm.SubItems[1].Text;
                txtPrsDrugsQty.Text = itm.SubItems[4].Text;
                btnFindDrug.PerformClick();

              //  dgvMedicine.CurrentCell = dgvMedicine.Rows[0].Cells[9];
               // dgvMedicine.BeginEdit(true);
              //  dgvMedicine.CurrentCell = dgvMedicine.("Quantity", 9);
            }
        }  

        private void FormatdgvTestReceive()
        {
            dgvTestReceive.AutoGenerateColumns = false;
            dgvTestReceive.ColumnCount = 15;

            dgvTestReceive.Columns[0].Name = "Requisition ID";
            dgvTestReceive.Columns[0].ReadOnly = true;
            dgvTestReceive.Columns[0].Width = 150;
            dgvTestReceive.Columns[0].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvTestReceive.Columns[1].Name = "Test Main ID";
            dgvTestReceive.Columns[1].ReadOnly = true;
            dgvTestReceive.Columns[1].Width = 0;
            dgvTestReceive.Columns[1].Visible = false;

            dgvTestReceive.Columns[2].Name = "Test Main Title";
            dgvTestReceive.Columns[2].ReadOnly = true;
            dgvTestReceive.Columns[2].Width = 150;
            dgvTestReceive.Columns[2].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvTestReceive.Columns[3].Name = "Test Sub ID";
            dgvTestReceive.Columns[3].ReadOnly = true;
            dgvTestReceive.Columns[3].Width = 0;
            dgvTestReceive.Columns[3].Visible = false;

            dgvTestReceive.Columns[4].Name = "Test Sub Title";
            dgvTestReceive.Columns[4].ReadOnly = true;
            dgvTestReceive.Columns[4].Width = 300;
            dgvTestReceive.Columns[4].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvTestReceive.Columns[5].Name = "Room ID";
            dgvTestReceive.Columns[5].ReadOnly = true;
            dgvTestReceive.Columns[5].Width = 0;
            dgvTestReceive.Columns[5].Visible = false;

            dgvTestReceive.Columns[6].Name = "Report Group ID";
            dgvTestReceive.Columns[6].ReadOnly = true;
            dgvTestReceive.Columns[6].Width = 0;
            dgvTestReceive.Columns[6].Visible = false;

            dgvTestReceive.Columns[7].Name = "Report Group Title";
            dgvTestReceive.Columns[7].ReadOnly = true;
            dgvTestReceive.Columns[7].Width = 200;
            dgvTestReceive.Columns[7].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvTestReceive.Columns[8].Name = "Department ID";
            dgvTestReceive.Columns[8].ReadOnly = true;
            dgvTestReceive.Columns[8].Width = 0;
            dgvTestReceive.Columns[8].Visible = false;

            dgvTestReceive.Columns[9].Name = "Department Title";
            dgvTestReceive.Columns[9].ReadOnly = true;
            dgvTestReceive.Columns[9].Width = 150;
            dgvTestReceive.Columns[9].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvTestReceive.Columns[10].Name = "Group ID";
            dgvTestReceive.Columns[10].ReadOnly = true;
            dgvTestReceive.Columns[10].Width = 0;
            dgvTestReceive.Columns[10].Visible = false;

            dgvTestReceive.Columns[11].Name = "Group Title";
            dgvTestReceive.Columns[11].ReadOnly = true;
            dgvTestReceive.Columns[11].Width = 150;
            dgvTestReceive.Columns[11].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvTestReceive.Columns[12].Name = "Diagnostic MR";
            dgvTestReceive.Columns[12].ReadOnly = true;
            dgvTestReceive.Columns[12].Width = 150;
            dgvTestReceive.Columns[12].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvTestReceive.Columns[13].Name = "Section ID";
            dgvTestReceive.Columns[13].ReadOnly = true;
            dgvTestReceive.Columns[13].Visible = false;
            dgvTestReceive.Columns[13].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvTestReceive.Columns[14].Name = "Result ID";
            dgvTestReceive.Columns[14].ReadOnly = true;
            dgvTestReceive.Columns[14].Visible = false;
            dgvTestReceive.Columns[14].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvTestReceive.Columns.Add(CreateGridColumnButtonFormat("Status Preview", "View Status")); 
        }
        public DataGridViewButtonColumn CreateGridColumnButtonFormat(string name, string buttonText)
        {
            DataGridViewButtonColumn oButton = new DataGridViewButtonColumn();
            oButton.HeaderText = "Result Preview";
            oButton.Name = name;
            oButton.Text = buttonText;
            oButton.UseColumnTextForButtonValue = true;
            return oButton;
        }
        private void FormatdgvMedReceive()
        {
            dgvMedReceive.AutoGenerateColumns = false;
            dgvMedReceive.ColumnCount = 14;

            dgvMedReceive.Columns[0].Name = "Requisition ID";
            dgvMedReceive.Columns[0].ReadOnly = true;
            dgvMedReceive.Columns[0].Width = 150;
          //  dgvMedReceive.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvMedReceive.Columns[0].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvMedReceive.Columns[1].Name = "Drug ID";
            dgvMedReceive.Columns[1].ReadOnly = true;
            dgvMedReceive.Columns[1].Width = 0;
            dgvMedReceive.Columns[1].Visible = false;
            dgvMedReceive.Columns[2].Name = "Drug Name";
            dgvMedReceive.Columns[2].ReadOnly = true;
            dgvMedReceive.Columns[2].Width = 300;
           // dgvMedReceive.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvMedReceive.Columns[2].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvMedReceive.Columns[3].Name = "Company ID";
            dgvMedReceive.Columns[3].ReadOnly = true;
            dgvMedReceive.Columns[3].Width = 0;
            dgvMedReceive.Columns[3].Visible = false;
            dgvMedReceive.Columns[4].Name = "Company Name";
            dgvMedReceive.Columns[4].ReadOnly = true;
            dgvMedReceive.Columns[4].Width = 300;
          //  dgvMedReceive.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvMedReceive.Columns[4].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvMedReceive.Columns[5].Name = "Group ID";
            dgvMedReceive.Columns[5].ReadOnly = true;
            dgvMedReceive.Columns[5].Width = 0;
            dgvMedReceive.Columns[5].Visible = false;
            dgvMedReceive.Columns[6].Name = "Group Name";
            dgvMedReceive.Columns[6].ReadOnly = true;
            dgvMedReceive.Columns[6].Width = 0;
            dgvMedReceive.Columns[6].Visible = false;

            dgvMedReceive.Columns[7].Name = "Unit ID";
            dgvMedReceive.Columns[7].ReadOnly = true;
            dgvMedReceive.Columns[7].Width = 0;
            dgvMedReceive.Columns[7].Visible = false;
            dgvMedReceive.Columns[8].Name = "Unit Name";
            dgvMedReceive.Columns[8].ReadOnly = true;
            dgvMedReceive.Columns[8].Width = 150;
           // dgvMedReceive.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvMedReceive.Columns[8].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvMedReceive.Columns[9].Name = "Type ID";
            dgvMedReceive.Columns[9].ReadOnly = true;
            dgvMedReceive.Columns[9].Width = 0;
            dgvMedReceive.Columns[9].Visible = false;
            dgvMedReceive.Columns[10].Name = "Type Name";
            dgvMedReceive.Columns[10].ReadOnly = true;
            dgvMedReceive.Columns[10].Width = 0;
            dgvMedReceive.Columns[10].Visible = false;

            dgvMedReceive.Columns[11].Name = "Requisition Qty";
            dgvMedReceive.Columns[11].ReadOnly = true;
            dgvMedReceive.Columns[11].Width = 148;
          //  dgvMedReceive.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvMedReceive.Columns[11].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvMedReceive.Columns[12].Name = "Received Qty";
            dgvMedReceive.Columns[12].ReadOnly = true;
            dgvMedReceive.Columns[12].Width = 150;
          //  dgvMedReceive.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvMedReceive.Columns[12].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvMedReceive.Columns[13].Name = "Remaining Qty";
            dgvMedReceive.Columns[13].ReadOnly = true;
            dgvMedReceive.Columns[13].Width = 150;
           // dgvMedReceive.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvMedReceive.Columns[13].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);
        }

        private void FormatdgvIssueDetails()
        {
            dgvIssueDetails.AutoGenerateColumns = false;
            dgvIssueDetails.ColumnCount = 20;

            dgvIssueDetails.Columns[0].Name = "Pharmacy ID";
            dgvIssueDetails.Columns[0].ReadOnly = true;
            dgvIssueDetails.Columns[0].Width = 150;
            dgvIssueDetails.Columns[0].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvIssueDetails.Columns[1].Name = "Pharmacy Name";
            dgvIssueDetails.Columns[1].ReadOnly = true;
            dgvIssueDetails.Columns[1].Visible = false;
            dgvIssueDetails.Columns[1].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvIssueDetails.Columns[2].Name = "Issue ID";
            dgvIssueDetails.Columns[2].ReadOnly = true;
            dgvIssueDetails.Columns[2].Width = 200;
            dgvIssueDetails.Columns[2].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvIssueDetails.Columns[3].Name = "Requisition ID";
            dgvIssueDetails.Columns[3].ReadOnly = true;
            dgvIssueDetails.Columns[3].Width = 200;
            dgvIssueDetails.Columns[3].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvIssueDetails.Columns[4].Name = "Drug ID";
            dgvIssueDetails.Columns[4].ReadOnly = true;
            dgvIssueDetails.Columns[4].Visible = false;
            dgvIssueDetails.Columns[5].Name = "Drug Name";
            dgvIssueDetails.Columns[5].ReadOnly = true;
            dgvIssueDetails.Columns[5].Width = 400;
            dgvIssueDetails.Columns[5].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvIssueDetails.Columns[6].Name = "Company ID";
            dgvIssueDetails.Columns[6].ReadOnly = true;
            dgvIssueDetails.Columns[6].Visible = false;
            dgvIssueDetails.Columns[7].Name = "Company Name";
            dgvIssueDetails.Columns[7].ReadOnly = true;
            dgvIssueDetails.Columns[7].Visible = false;
            dgvIssueDetails.Columns[7].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvIssueDetails.Columns[8].Name = "Group ID";
            dgvIssueDetails.Columns[8].ReadOnly = true;
            dgvIssueDetails.Columns[8].Visible = false;
            dgvIssueDetails.Columns[9].Name = "Group Name";
            dgvIssueDetails.Columns[9].ReadOnly = true;
            dgvIssueDetails.Columns[9].Visible = false;

            dgvIssueDetails.Columns[10].Name = "Unit ID";
            dgvIssueDetails.Columns[10].ReadOnly = true;
            dgvIssueDetails.Columns[10].Visible = false;
            dgvIssueDetails.Columns[11].Name = "Unit Name";
            dgvIssueDetails.Columns[11].ReadOnly = true;
            dgvIssueDetails.Columns[11].Visible = false;
            dgvIssueDetails.Columns[11].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvIssueDetails.Columns[12].Name = "Type ID";
            dgvIssueDetails.Columns[12].ReadOnly = true;
            dgvIssueDetails.Columns[12].Visible = false;
            dgvIssueDetails.Columns[13].Name = "Type Name";
            dgvIssueDetails.Columns[13].ReadOnly = true;
            dgvIssueDetails.Columns[13].Visible = false;

            dgvIssueDetails.Columns[14].Name = "Issue Qty";
            dgvIssueDetails.Columns[14].ReadOnly = true;
            dgvIssueDetails.Columns[14].Width = 198;
            dgvIssueDetails.Columns[14].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvIssueDetails.Columns[15].Name = "Receive Qty";
            dgvIssueDetails.Columns[15].ReadOnly = false;
            dgvIssueDetails.Columns[15].Visible = false;
            dgvIssueDetails.Columns[15].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvIssueDetails.Columns[16].Name = "Return Qty";
            dgvIssueDetails.Columns[16].ReadOnly = true;
            dgvIssueDetails.Columns[16].Visible = false;
            dgvIssueDetails.Columns[16].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvIssueDetails.Columns[17].Name = "Issue Date";
            dgvIssueDetails.Columns[17].ReadOnly = true;
            dgvIssueDetails.Columns[17].Visible = false;
            dgvIssueDetails.Columns[17].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvIssueDetails.Columns[18].Name = "Issue Type";
            dgvIssueDetails.Columns[18].ReadOnly = true;
            dgvIssueDetails.Columns[18].Visible = false;
            dgvIssueDetails.Columns[18].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvIssueDetails.Columns[19].Name = "Batch No";
            dgvIssueDetails.Columns[19].ReadOnly = true;
            dgvIssueDetails.Columns[19].Width = 200;
            dgvIssueDetails.Columns[19].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

        }


//------------------------------------ Add Drugs Part Start------------------------------------------------------------------------------------------//

        #region AddDrugs
        private void FormatGridView(DataGridView dtv)
        {
            dgvMedicine.ReadOnly = false;
            dtv.AutoGenerateColumns = false;
            #region CompanyID
            DataGridViewTextBoxColumn colCompanyID = new DataGridViewTextBoxColumn();
            colCompanyID.Name = "COMPANYID";
            colCompanyID.DataPropertyName = "COMPANYID";
            colCompanyID.Width = 0;
            colCompanyID.Visible = false;
            dtv.Columns.Add(colCompanyID);
            #endregion
            #region GroupID
            DataGridViewTextBoxColumn colGroupID = new DataGridViewTextBoxColumn();
            colGroupID.Name = "GROUPID";
            colGroupID.DataPropertyName = "GROUPID";
            colGroupID.Width = 0;
            colGroupID.Visible = false;
            colCompanyID.ReadOnly = true;
            dtv.Columns.Add(colGroupID);
            #endregion
            #region UnitID
            DataGridViewTextBoxColumn colUnitID = new DataGridViewTextBoxColumn();
            colUnitID.Name = "UNITID";
            colUnitID.DataPropertyName = "UNITID";
            colUnitID.Width = 0;
            colUnitID.Visible = false;
            dtv.Columns.Add(colUnitID);
            #endregion
            #region TypeID
            DataGridViewTextBoxColumn colTypeID = new DataGridViewTextBoxColumn();
            colTypeID.Name = "TYPEID";
            colTypeID.DataPropertyName = "TYPEID";
            colTypeID.Width = 0;
            colTypeID.Visible = false;
            dtv.Columns.Add(colTypeID);
            #endregion

            DataGridViewTextBoxColumn colDrugId = new DataGridViewTextBoxColumn();
            colDrugId.DefaultCellStyle.Font = new Font("Tahoma", 8.25F);
            colDrugId.Name = "DRUGID";
            colDrugId.DataPropertyName = "DRUGID";
            colDrugId.Width = 80;
            colDrugId.ReadOnly = true;
            //colDrugId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colDrugId.Visible = true;
            dtv.Columns.Add(colDrugId);

            DataGridViewTextBoxColumn colDrugTitle = new DataGridViewTextBoxColumn(); 
            colDrugTitle.DefaultCellStyle.Font = new Font("Tahoma", 8.25F);
            colDrugTitle.Name = "DrugName";
            colDrugTitle.DataPropertyName = "DRUGNAME";
            colDrugTitle.Width = 100;
            colDrugTitle.Visible = true;
            colDrugTitle.ReadOnly = true;
            dtv.Columns.Add(colDrugTitle);

            #region CompanyName
            DataGridViewTextBoxColumn colCompanyTitle = new DataGridViewTextBoxColumn();
            colCompanyTitle.DefaultCellStyle.Font = new Font("Tahoma", 8.25F);
            colCompanyTitle.Name = "Company";
            colCompanyTitle.DataPropertyName = "COMPANYNAME";
            //colCompanyTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colCompanyTitle.Width = 130;
            colCompanyTitle.Visible = true;
            colCompanyTitle.ReadOnly = true;
            dtv.Columns.Add(colCompanyTitle);
            #endregion

            #region PackName
            DataGridViewTextBoxColumn colPackName = new DataGridViewTextBoxColumn();
            colPackName.DefaultCellStyle.Font = new Font("Tahoma", 8.25F);
            colPackName.Name = "UnitPackType";
            colPackName.DataPropertyName = "PACKName";
           //colPackName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colPackName.Visible = false;
            colPackName.Width = 0;
            colPackName.ReadOnly = true;
            dtv.Columns.Add(colPackName);
            #endregion

            #region UnitName
            DataGridViewTextBoxColumn colUnitName = new DataGridViewTextBoxColumn();
            colUnitName.DefaultCellStyle.Font = new Font("Tahoma", 8.25F);
            colUnitName.Name = "Unit";
            colUnitName.DataPropertyName = "UNITNAME";
            colUnitName.Width = 0;
            colUnitName.Visible = false;
            dtv.Columns.Add(colUnitName);
            #endregion

            //#region StockQuantity
            //DataGridViewTextBoxColumn colStockQuantity = new DataGridViewTextBoxColumn();
            //colStockQuantity.DefaultCellStyle.Font = new Font("Tahoma", 8.25F);
            //colStockQuantity.Name = "StockQty";
            //colStockQuantity.DataPropertyName = "StockQty";
            //colStockQuantity.Width = 100;
            //colStockQuantity.Visible = true;
            //dtv.Columns.Add(colStockQuantity);
            //#endregion

            #region Quantity
            DataGridViewTextBoxColumn colQty = new DataGridViewTextBoxColumn();
            colQty.DefaultCellStyle.Font = new Font("Tahoma", 8.25F);
            colQty.Name = "Quantity";
            colQty.DataPropertyName = "Quantity";
            colQty.Width = 100;
            colQty.Visible = true;
            colQty.MaxInputLength = 4;
            dtv.Columns.Add(colQty);
            #endregion       
        }

        List<DrugDose> drugsList;
        private void FormatDrugsCheckedList()
        {
            lstMedicalPres.CheckBoxes = false;
            lstMedicalPres.Columns.Add("Company ID", 0, HorizontalAlignment.Left);//0
            lstMedicalPres.Columns.Add("Group ID", 0, HorizontalAlignment.Left);//1
            lstMedicalPres.Columns.Add("Unit ID", 0, HorizontalAlignment.Left);//2
            lstMedicalPres.Columns.Add("Pack Type ID", 0, HorizontalAlignment.Left);//3
            lstMedicalPres.Columns.Add("Drug ID", 0, HorizontalAlignment.Left);//4
            lstMedicalPres.Columns.Add("Drug's Name", 250, HorizontalAlignment.Left);//5
            lstMedicalPres.Columns.Add("Company Name", 0, HorizontalAlignment.Left);//6
            lstMedicalPres.Columns.Add("Drug Pack Type Name", 0, HorizontalAlignment.Left);//7
            lstMedicalPres.Columns.Add("Drug Unit Name", 0, HorizontalAlignment.Left);//8
            lstMedicalPres.Columns.Add("Requisition Qty", 100, HorizontalAlignment.Left);//9
            lstMedicalPres.Columns.Add("Remaining Qty", 0, HorizontalAlignment.Left);//10
            lstMedicalPres.Columns.Add("Doc Visit No", 0, HorizontalAlignment.Left);//11
        }

        private void PopulateDrugs()
        {
            List<DrugDose> oMedicines = new List<DrugDose>();
            drugsList = new List<DrugDose>();
            drugsList.AddRange(nwbnch.GetDrugDoseList(txtAgeY.Text).ToList<DrugDose>());
            dgvMedicine.Visible = true;
            dgvMedicine.DataSource = drugsList.Select(data => new
            {
                COMPANYID = data.DrugMaster.DrugCompany.ID,
                GROUPID = data.DrugMaster.DrugGroup.ID,
                UNITID = data.DrugMaster.DrugUnit.ID,
                TYPEID = data.DrugMaster.DrugPackType.ID,
                DRUGID = data.DrugMaster.ID,
                DRUGNAME = data.DrugMaster.Name,
                COMPANYNAME = data.DrugMaster.DrugCompany.Name,
                PACKNAME = data.DrugMaster.DrugPackType.Name,
                UNITNAME = data.DrugMaster.DrugUnit.Name,
            }).ToList();
            this.dgvMedicine.Focus();
        }

        private void txtDrugName_KeyUp(object sender, KeyEventArgs e)
        {
           /* //if (txtPatRegNoIPD.Text != "")
            if (txtPatRegNoIPD.Text.Length > 0 )
            {
                //PopulateDataTodgvMedicine(dgvMedicine, txtDrugName.Text);
                PopulateDataTodgvMedicine2();
            }
            else
            {
                this.txtDrugName.Focus();
            }*/
        }
        private void btnFindDrug_Click(object sender, EventArgs e)
        {
            if (txtDrugName.Text.Length > 1)
            {
                PopulateDataTodgvMedicine2();
               // PopulateDataToGrid(); 
            }
            else
            {
                this.txtDrugName.Focus();
            }
        }
        private void PopulateDataTodgvMedicine2()
        {
            string age = txtAgeY.Text;
            string drugsTitle = txtDrugName.Text;
            string drugID = txtDrugID.Text;

            List<DrugDose> oMedicines = new List<DrugDose>();
            int i = 0;
            dgvMedicine.Rows.Clear();
            oMedicines.AddRange(nwbnch.GetDrugDoseByDrugIPD(age, txtDrugName.Text).ToList<DrugDose>());
            if (oMedicines.Count != 0)
            {
                foreach (DrugDose oDrugDose in oMedicines)
                {
                    dgvMedicine.Rows.Add(1);
                    dgvMedicine.Rows[i].Cells["COMPANYID"].Value = oDrugDose.DrugMaster.DrugCompany.ID;
                    dgvMedicine.Rows[i].Cells["GROUPID"].Value = oDrugDose.DrugMaster.DrugGroup.ID;
                    dgvMedicine.Rows[i].Cells["UNITID"].Value = oDrugDose.DrugMaster.DrugUnit.ID;
                    dgvMedicine.Rows[i].Cells["TYPEID"].Value = oDrugDose.DrugMaster.DrugPackType.ID;
                    dgvMedicine.Rows[i].Cells["DRUGID"].Value = oDrugDose.DrugMaster.ID;
                    dgvMedicine.Rows[i].Cells["DrugName"].Value = oDrugDose.DrugMaster.Name;
                    dgvMedicine.Rows[i].Cells["Company"].Value = oDrugDose.DrugMaster.DrugCompany.Name;
                    dgvMedicine.Rows[i].Cells["UnitPackType"].Value = oDrugDose.DrugMaster.DrugPackType.Name;
                    dgvMedicine.Rows[i].Cells["Unit"].Value = oDrugDose.DrugMaster.DrugUnit.Name;
                    //dgvMedicine.Rows[i].Cells["StockQty"].Value = 0; //oDrugDose.DrugMaster.StockQty;
                    dgvMedicine.Rows[i].Cells["Quantity"].Value = "";
                    i = i + 1;
                }
            }
        }

        //private void PopulateDataToGrid()
        //{
        //    string age = txtAgeY.Text;
        //    string drugsTitle = txtDrugName.Text;
        //    string drugID = txtDrugID.Text;
        //    List<DrugDose> oMedicines = new List<DrugDose>();
        //   // int i = 0;
        //    dgvMedicine.Rows.Clear();
        //    oMedicines.AddRange(nwbnch.GetDrugs(age,drugsTitle,drugID).ToList());
        //    if (oMedicines.Count != 0)
        //    {
        //        foreach (DrugDose data in oMedicines)
        //        {
        //            string[] row = new string[] { data.DrugMaster.DrugCompany.ID, data.DrugMaster.DrugGroup.ID, data.DrugMaster.DrugUnit.ID, data.DrugMaster.DrugPackType.ID, data.DrugMaster.ID, 
        //                                        data.DrugMaster.Name, data.DrugMaster.DrugCompany.Name, data.DrugMaster.DrugPackType.Name, data.DrugMaster.DrugUnit.Name,"0"};
        //            AddRows(dgvMedicine, row);                 
        //        }
        //    }
         
        //}

        private void AddRows(DataGridView dtv, string[] row)
        {
            dtv.Rows.Insert(0,row);
        }

        private void PopulateDataTodgvMedicine(DataGridView dgvMedicine, string drugsTitle)
        {
            IEnumerable<DrugDose> drugsListLocal;
            if (!(drugsTitle.Length > 0))
            {
                drugsListLocal = drugsList;
            }
            else
            {
                drugsListLocal = drugsList.Where(x => x.DrugMaster.Name.ToLower().Contains(drugsTitle.ToLower()));
            }
            dgvMedicine.DataSource = drugsListLocal.Select(data => new
            {
                COMPANYID = data.DrugMaster.DrugCompany.ID,
                GROUPID = data.DrugMaster.DrugGroup.ID,
                UNITID = data.DrugMaster.DrugUnit.ID,
                TYPEID = data.DrugMaster.DrugPackType.ID,
                DRUGID = data.DrugMaster.ID,
                DRUGNAME = data.DrugMaster.Name,
                COMPANYNAME = data.DrugMaster.DrugCompany.Name,
                PACKNAME = data.DrugMaster.DrugPackType.Name,
                UNITNAME = data.DrugMaster.DrugUnit.Name,
            }).ToList();
        }
        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtDrugID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
           // string searchWithinThis = txtTotalDrugs.Text;
          //  if (searchWithinThis.StartsWith("00") || searchWithinThis.StartsWith("0") || searchWithinThis == " ")
         //   {
         //       return;
         //   }

            if (dgvMedicine.Rows.Count > 0)
            {
                ListViewItem lvItem;
                foreach (DataGridViewRow row in dgvMedicine.SelectedRows)
                {
                    if ((row.Cells["Quantity"].Value.ToString() != "") /*&& (Convert.ToDouble(row.Cells["Quantity"].Value)<= Convert.ToDouble(txtPrsDrugsQty.Text))*/)
                    {
                        if (CheckForValidGroupID(row.Cells["DRUGID"].Value.ToString()) == true)
                        {
                            DuplicateCheck(row.Cells["DRUGID"].Value.ToString());
                            lvItem = new ListViewItem(row.Cells["CompanyID"].Value.ToString());//0
                            lvItem.SubItems.Add(row.Cells["GROUPID"].Value.ToString());//1
                            lvItem.SubItems.Add(row.Cells["UNITID"].Value.ToString());//2
                            lvItem.SubItems.Add(row.Cells["TYPEID"].Value.ToString());//3
                            lvItem.SubItems.Add(row.Cells["DRUGID"].Value.ToString());//4
                            lvItem.SubItems.Add(row.Cells["DrugName"].Value.ToString());//5
                            lvItem.SubItems.Add(row.Cells["Company"].Value.ToString());//6
                            lvItem.SubItems.Add(row.Cells["UnitPackType"].Value.ToString());//7
                            lvItem.SubItems.Add(row.Cells["Unit"].Value.ToString());//8
                            lvItem.SubItems.Add(row.Cells["Quantity"].Value.ToString());//txtTotalDrugs.Text);//9 req qty
                            lvItem.SubItems.Add(row.Cells["Quantity"].Value.ToString());//txtTotalDrugs.Text);//10 rem qty
                            lvItem.SubItems.Add(txtVisitNumber.Text);      //doctors visit number
                            lstMedicalPres.Items.Add(lvItem);
                        }
                        dgvMedicine.Rows.Clear();
                        txtDrugName.Text = "";
                        txtDrugID.Text = "";
                        txtVisitNumber.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Please provide Valid Drugs Quantity", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private bool CheckForValidGroupID(string p)
        {
            if(p != txtDrugID.Text)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void DuplicateCheck(string drugID)
        {
            if (lstMedicalPres.Items.Count < 0)
            {
                return;
            }
            else
            {
                for (int i = 0; i < lstMedicalPres.Items.Count; i++)
                {
                    if (lstMedicalPres.Items[i].SubItems[4].Text == drugID)
                    {
                        lstMedicalPres.Items[i].Remove();
                    }
                }
            }
        }

        private void btnCancelDrug_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in lstMedicalPres.SelectedItems)
            {
                lstMedicalPres.Items.Remove(eachItem);
            }
        }

        private void txtTotalDrugs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        #endregion AddDrugs

// --------------------------------------------------- Add Drugs Part End --------------------------------------------------------------------------- //

// --------------------------------------------------- Add Test Part Start -------------------------------------------------------------------------- //

        #region AddTests
        List<TestSub> testsList;
        private void FormatGrid()
        {
            lvGroup.CheckBoxes = false;
            lvGroup.Columns.Add("GroupID", 0, HorizontalAlignment.Left);
            lvGroup.Columns.Add("Group", 280, HorizontalAlignment.Left);
        }
        private void FormatGrids()
        {
            lvAddItems.CheckBoxes = false;
            lvAddItems.Columns.Add("No", 0, HorizontalAlignment.Left);//0

            lvAddItems.Columns.Add("Detail", 227, HorizontalAlignment.Left);//1
            lvAddItems.Columns.Add("DetailID", 0, HorizontalAlignment.Left);
            lvAddItems.Columns.Add("Department", 0, HorizontalAlignment.Left);
            lvAddItems.Columns.Add("Group", 0, HorizontalAlignment.Left);
            lvAddItems.Columns.Add("Main", 0, HorizontalAlignment.Left);
            lvAddItems.Columns.Add("ReportGroup", 0, HorizontalAlignment.Left);
            lvAddItems.Columns.Add("LabRoom", 0, HorizontalAlignment.Left);//7

            lvAddItems.Columns.Add("Spc Room ID", 0, HorizontalAlignment.Left);   //8
            lvAddItems.Columns.Add("Panel Id", 0, HorizontalAlignment.Left);    //9
            lvAddItems.Columns.Add("Fee Cat", 0, HorizontalAlignment.Left);  //10
            lvAddItems.Columns.Add("Fee", 100, HorizontalAlignment.Left);       //11
            lvAddItems.Columns.Add("Dept Fee", 0, HorizontalAlignment.Left);        //12
            lvAddItems.Columns.Add("Ref Dept Fee", 0, HorizontalAlignment.Left); //13
            lvAddItems.Columns.Add("Doc Fee ", 0, HorizontalAlignment.Left);     //14
            lvAddItems.Columns.Add("Discount", 0, HorizontalAlignment.Left); //15
            lvAddItems.Columns.Add("Vat", 0, HorizontalAlignment.Left);     //16

            lvAddItems.Columns.Add("Visit Number", 0, HorizontalAlignment.Left);     //17


        }
        private void FormatCheckedList()
        {
            testChkBox.Columns.Add("Details", 410, HorizontalAlignment.Left);   //0
            testChkBox.Columns.Add("DetailID", 0, HorizontalAlignment.Left);    //1
            testChkBox.Columns.Add("Department", 0, HorizontalAlignment.Left);  //2
            testChkBox.Columns.Add("Group", 0, HorizontalAlignment.Left);       //3
            testChkBox.Columns.Add("Main", 0, HorizontalAlignment.Left);        //4
            testChkBox.Columns.Add("ReportGroup", 0, HorizontalAlignment.Left); //5
            testChkBox.Columns.Add("LabRoom", 0, HorizontalAlignment.Left);     //6

            testChkBox.Columns.Add("Spc Room ID", 0, HorizontalAlignment.Left); //7
            testChkBox.Columns.Add("Panel Id", 0, HorizontalAlignment.Left);    //8
            testChkBox.Columns.Add("Fee Cat", 0, HorizontalAlignment.Left);     //9
            testChkBox.Columns.Add("Fee", 0, HorizontalAlignment.Left);         //10
            testChkBox.Columns.Add("Dept Fee", 0, HorizontalAlignment.Left);    //11
            testChkBox.Columns.Add("Ref Dept Fee", 0, HorizontalAlignment.Left);//12
            testChkBox.Columns.Add("Doc Fee ", 0, HorizontalAlignment.Left);    //13
            testChkBox.Columns.Add("Discount", 0, HorizontalAlignment.Left);    //14
            testChkBox.Columns.Add("Vat", 0, HorizontalAlignment.Left);         //15
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboGroupID.DisplayMember = "Value";
                cboGroupID.ValueMember = "Key";
                cboGroupID.DataSource = new BindingSource(Utility.VerifyDic(nwbnch.GetDiagnGrpDeptWise("D", cboDepartment.SelectedValue.ToString())), null);
            }
            else
            {
                return;
            }
            lvGroup.Items.Clear();
            testChkBox.Items.Clear();
        }

        private void cboGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.Items.Count > 1 && cboDepartment.Text != "--Select--" && cboGroupID.Items.Count > 0)
            {
                LoadListView(cboDepartment.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString());
            }
        }

        private void LoadListView(string deptid, string groupid)
        {
            lvGroup.Items.Clear();
            List<TestMain> tgroup;

            if (deptid.Length != 0 || groupid.Length != 0)
            {
                tgroup = nwbnch.GetTestMain(deptid, groupid).ToList();
            }
            else
            {
                return;
            }
            foreach (TestMain tg in tgroup)
            {
                ListViewItem itm = new ListViewItem(tg.TestMainID);
                itm.SubItems.Add(tg.TestMainTitle);
                lvGroup.Items.Add(itm);
            }
        }

        private void lvGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            testChkBox.Items.Clear();
            if (lvGroup.SelectedItems.Count > 0)
            {
                PopulateTests(cboDepartment.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), lvGroup.SelectedItems[0].SubItems[0].Text);
            }
        }
        private void cboGroupID_Click(object sender, EventArgs e)
        {
            if (cboDepartment.Items.Count > 1 && cboDepartment.Text != "--Select--" && cboGroupID.Items.Count > 0)
            {
                LoadListView(cboDepartment.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString());
            }
        }

        private void PopulateTests(string deptid, string group, string main)
        {
            testsList = new List<TestSub>();
            //testsList.AddRange(nwbnch.GetTestDetails(deptid, group, main).ToList());
            testsList.AddRange(nwbnch.GetTestDets(deptid, group, main).ToList());
            
            foreach (TestSub tg in testsList)
            {
                ListViewItem itm = new ListViewItem(tg.TestSubTitle);
                itm.SubItems.Add(tg.TestSubID);
                itm.SubItems.Add(tg.TestDepartment.DepartmentID);
                itm.SubItems.Add(tg.TestGroup.GroupId);
                itm.SubItems.Add(tg.TestMainID);
                itm.SubItems.Add(tg.ReportGroup.ReportGroupID);
                itm.SubItems.Add(tg.SpecimenCollectionRoom.RoomID);
                testChkBox.Items.Add(itm);
            }
            this.testChkBox.Focus();
        }
        private void txtSearchInvestigation_KeyUp(object sender, KeyEventArgs e)
        {
            //if (cboDepartment.SelectedValue != "" && lvGroup.Items.Count > 0 && lvGroup.SelectedItems.Count > 0)
            //{
            //    PopulateDataTotestChkBox(testChkBox, txtSearchInvestigation.Text);
            //}

          /*  if (chkSearchFromAllTest.Checked == true)
            {
                PopulateAllTestTotestChkBox(testChkBox, txtSearchInvestigation.Text);
            }
            else
            {
                if (cboDepartment.SelectedValue != "" && lvGroup.Items.Count > 0 && lvGroup.SelectedItems.Count > 0)
                {
                    PopulateDataTotestChkBox(testChkBox, txtSearchInvestigation.Text);
                }
                else
                {
                    MessageBox.Show("Please Select Dapartment and Group ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }*/
        }
        private void PopulateAllTestTotestChkBox(ListView testChkBox, string testTitle)
        {
            IEnumerable<TestFee> testsListAllLocal;
            if (!(testTitle.Length > 0))
            {
                testsListAllLocal = testsListAll;
            }
            else
            {
                testsListAllLocal = testsListAll.Where(x => x.TestSub.TestSubTitle.ToLower().Contains(testTitle.ToLower()));
            }
            testChkBox.Items.Clear();
            foreach (TestFee tg in testsListAllLocal)
            {
                ListViewItem itm = new ListViewItem(tg.TestSub.TestSubTitle); //0
                itm.SubItems.Add(tg.TestSub.TestSubID);
                itm.SubItems.Add(tg.TestSub.TestDepartment.DepartmentID);
                itm.SubItems.Add(tg.TestSub.TestGroup.GroupId);
                itm.SubItems.Add(tg.TestSub.TestMainID);
                itm.SubItems.Add(tg.TestSub.ReportGroup.ReportGroupID);
                itm.SubItems.Add(tg.TestSub.LabRoom.RoomID);


                itm.SubItems.Add(tg.TestSub.SpecimenCollectionRoom.RoomID);//7
                itm.SubItems.Add(tg.TestSub.PanelID);
                itm.SubItems.Add(tg.FeeCategory.FeeCategoryID);
                itm.SubItems.Add(tg.Fee.ToString());//10
                itm.SubItems.Add(tg.DeptFee.ToString());
                itm.SubItems.Add(tg.RefdFee.ToString());
                itm.SubItems.Add(tg.DoctorFee.ToString());
                itm.SubItems.Add(tg.Discount.ToString());//14
                itm.SubItems.Add(tg.VAT.ToString());

                testChkBox.Items.Add(itm);
            }
        }
        private void PopulateDataTotestChkBox(ListView testChkBox, string testTitle)
        {
            IEnumerable<TestSub> testsListLocal;
            if (!(testTitle.Length > 0))
            {
                testsListLocal = testsList;
            }
            else
            {
                testsListLocal = testsList.Where(x => x.TestSubTitle.ToLower().Contains(testTitle.ToLower()));
            }
            testChkBox.Items.Clear();
            foreach (TestSub tg in testsListLocal)
            {
                ListViewItem itm = new ListViewItem(tg.TestSubTitle);
                itm.SubItems.Add(tg.TestSubID);
                itm.SubItems.Add(tg.TestDepartment.DepartmentID);
                itm.SubItems.Add(tg.TestGroup.GroupId);
                itm.SubItems.Add(tg.TestMainID);
                itm.SubItems.Add(tg.ReportGroup.ReportGroupID);
                itm.SubItems.Add(tg.SpecimenCollectionRoom.RoomID);
                testChkBox.Items.Add(itm);
            }
        }
        private void DuplicateCheckTest(string advID)
        {
            if (lvAddItems.Items.Count < 0)
            {
                return;
            }
            else
            {
                for (int i = 0; i < lvAddItems.Items.Count; i++)
                {
                    if (lvAddItems.Items[i].SubItems[2].Text == advID)
                    {
                        lvAddItems.Items[i].Remove();
                    }
                }
            }
        }
        private int ValidVisitOrNot(string visit_No)
        {
            int a=0;
            if (lvAddItems.Items.Count == 0)
            {
                a=0;
            }
            else
            {
                for (int i = 0; i < lvAddItems.Items.Count; i++)
                {
                    if (lvAddItems.Items[i].SubItems[17].Text == visit_No)
                    {
                        a = 1;
                    }
                    else
                    {
                        a = 2;
                    }
                }
            }
            return a;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region old
            /*int cnt = lvAddItems.Items.Count;

            for (int i = 0; i < testChkBox.Items.Count; i++)
            {
                if (testChkBox.Items[i].Checked == true)
                {
                    short flg = 0;
                    for (int j = 0; j < lvAddItems.Items.Count; j++)
                    {
                        if (lvAddItems.Items[j].SubItems[2].Text == testChkBox.Items[i].SubItems[1].Text)
                        {
                            flg = 1;
                        }
                    }
                    if (flg == 0)
                    {
                        cnt++;
                        ListViewItem itm = new ListViewItem(cnt.ToString());
                        itm.SubItems.Add(testChkBox.Items[i].SubItems[0].Text);
                        itm.SubItems.Add(testChkBox.Items[i].SubItems[1].Text);
                        itm.SubItems.Add(testChkBox.Items[i].SubItems[2].Text);
                        itm.SubItems.Add(testChkBox.Items[i].SubItems[3].Text);
                        itm.SubItems.Add(testChkBox.Items[i].SubItems[4].Text);
                        itm.SubItems.Add(testChkBox.Items[i].SubItems[5].Text);
                        itm.SubItems.Add(testChkBox.Items[i].SubItems[6].Text); //lab room

                        itm.SubItems.Add(testChkBox.Items[i].SubItems[7].Text); // spc rm id
                        itm.SubItems.Add(testChkBox.Items[i].SubItems[8].Text); //pnl id
                        itm.SubItems.Add(testChkBox.Items[i].SubItems[9].Text); //fee cat
                        itm.SubItems.Add(testChkBox.Items[i].SubItems[10].Text); //
                        itm.SubItems.Add(testChkBox.Items[i].SubItems[11].Text);
                        itm.SubItems.Add(testChkBox.Items[i].SubItems[12].Text);
                        itm.SubItems.Add(testChkBox.Items[i].SubItems[13].Text);
                        itm.SubItems.Add(testChkBox.Items[i].SubItems[14].Text);
                        itm.SubItems.Add(testChkBox.Items[i].SubItems[15].Text);

                        lvAddItems.Items.Add(itm);
                    }
                }
            }
            txtSearchInvestigation.Text = "";*/
            #endregion old

            if (txtVisitNumber.Text != "")
            {
                for (int i = 0; i < testChkBox.Items.Count; i++)
                {
                    if (testChkBox.Items[i].Checked == true)
                    {
                        if (Utility.IsDuplicateFoundInList(lvAddItems, 2, testChkBox.Items[i].SubItems[1].Text))
                        {
                            // MessageBox.Show("This Complain Already exists!!");
                            //txtSearchInvestigation.Select();
                        }
                        else
                        {
                            ListViewItem itm = new ListViewItem(testChkBox.Items[i].SubItems[0].Text);

                           if (ValidVisitOrNot(txtVisitNumber.Text) == 1 || ValidVisitOrNot(txtVisitNumber.Text) == 0)
                           {
                                if (testChkBox.Items[i].SubItems[10].Text != "" && testChkBox.Items[i].SubItems[10].Text != null)
                                {

                                    if (Convert.ToDouble(testChkBox.Items[i].SubItems[10].Text) > 0)
                                    {
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[0].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[1].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[2].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[3].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[4].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[5].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[6].Text); //lab room

                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[7].Text); // spc rm id
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[8].Text); //pnl id
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[9].Text); //fee cat
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[10].Text); // fee
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[11].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[12].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[13].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[14].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[15].Text);
                                        itm.SubItems.Add(txtVisitNumber.Text); //17 doc visit number

                                        lvAddItems.Items.Add(itm);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cannot add from different Visit Number", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("This Investigation is not Provided By Doctor", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtSearchInvestigation.Text = "";
            txtVisitNumber.Text = "";
        }
        private void lvAddItems_DoubleClick(object sender, EventArgs e)
        {
            listViewSelectedItem(lvAddItems);
        }
        private void listViewSelectedItem(ListView lstVw)
        {
            for (int i = lstVw.Items.Count - 1; i >= 0; i--)
            {
                if (lstVw.Items[i].Selected)
                {
                    lstVw.Items[i].Remove();
                }
            }
        }
        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in lvAddItems.SelectedItems)
            {
                lvAddItems.Items.Remove(eachItem);
            }
        }
        #endregion AddTests

//----------------------------------------------------- Add Tests Part End -------------------------------------------------------------------------- //

        private void btnNext_Click(object sender, EventArgs e)
        {
            smartTab1.SelectedIndex = 1;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            smartTab1.SelectedIndex = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtPatRegNoIPD", "txtPatName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (lstMedicalPres.Items.Count > 0 || lvAddItems.Items.Count > 0)
            {
                try
                {
                    NurseRequisition requsition = this.PopulateRequisition();
                    short i = nwbnch.SaveNurseRequisition(requsition);
                    if (i == 0)
                    {
                        MessageBox.Show("Data Insertion Failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Data Insertion Successful", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                      //  testChkBox.Items.Clear();
                      //  lstDrugName.Items.Clear();
                      //  lstMedicalPres.Items.Clear();
                      //  lvAddItems.Items.Clear();
                      //  this.frmNurseRequisition_Load(sender, e);
                      //  this.Dispose();
                        LoadAfterRequisition();
                        btnDrugHistory_Click(sender, e);
                        btnTestHistory_Click(sender, e);  
                   
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
            else
            {
                MessageBox.Show("Can not proceed without Drugs or Tests ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtPatRegNoIPD_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPatRegNoIPD.Text.Length == Utility.ScanLength)
            {
                btnFind_Click(sender,e);      
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtPatRegNoIPD.Text != "")
            {
                string vrfy = nwbnch.VerifyInPatient(txtPatRegNoIPD.Text);
                if (vrfy.Length > 0)
                {
                    MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnNew.PerformClick();
                    txtPatRegNoIPD.Focus();
                    return;
                }     
                InPatient pat = nwbnch.GetAdmittedPatient(txtPatRegNoIPD.Text);
                txtNurseStn.Text = pat.NurseStation.NurseStationID;
                LoadPatient(pat);
                if (txtDOB.Text != "")
                {
                   // PopulateDrugs();
                    txtPatRegNoIPD.Enabled = false;
                    btnFind.Enabled = false;
                }
               GetPrsDrugs();
               GetPrsTests();
               LoadDoctorsVisitList();
            }
        }

        private void LoadAfterRequisition()
        {
            lvProvidedDrugs.Items.Clear();
            dgvMedicine.Rows.Clear();
            lstMedicalPres.Items.Clear();
            lvProvidedTests.Items.Clear();
            testChkBox.Items.Clear();
            lvAddItems.Items.Clear();
            dgvMedReceive.Rows.Clear();
            dgvTestReceive.Rows.Clear();
            dgvIssueDetails.Rows.Clear();
            GetPrsDrugs();
            GetPrsTests();
            LoadDoctorsVisitList();

        }
        private void LoadDoctorsVisitList()
        {
            List<IPDDoctor> oIPDDoc = nwbnch.GetIPDVisitingFeeDetails(txtPatRegNoIPD.Text).ToList();
            lvIPDDoctors.Items.Clear();
            if (oIPDDoc.Count > 0)
            {
                foreach (IPDDoctor doc in oIPDDoc)
                {
                    ListViewItem itm = new ListViewItem(doc.Department.DepartmentID);
                    itm.SubItems.Add(doc.Department.DepartmentTitle);
                    itm.SubItems.Add(doc.DepartmentUnit.UnitId);
                    itm.SubItems.Add(doc.DepartmentUnit.UnitTitle);
                    itm.SubItems.Add(doc.ID);
                    itm.SubItems.Add(doc.Name);
                    itm.SubItems.Add(Convert.ToString(doc.IPDVisitingFee));
                    itm.SubItems.Add(doc.VisitNo);
                    itm.SubItems.Add(Convert.ToString(doc.EntryParameter.EntryDate.ToString("dd/MM/yyyy HH:mm:ss")));
                    lvIPDDoctors.Items.Add(itm);
                }
            }
        }

        private void GetPrsDrugs()
        {
            lvProvidedDrugs.Items.Clear();
            List<IPDPrescription> oMedicines = new List<IPDPrescription>();
            oMedicines = nwbnch.GetPrescribedDrugs(txtPatRegNoIPD.Text).ToList();
            if (oMedicines.Count > 0 )
            {
                foreach (IPDPrescription oPrsDrugs in oMedicines)
                {
                    if (oPrsDrugs.Drugs.DrugMaster.RemainingQty > 0)
                    {
                        ListViewItem itm = new ListViewItem(oPrsDrugs.DocVisitID);
                        itm.SubItems.Add(oPrsDrugs.Drugs.DrugMaster.ID);
                        itm.SubItems.Add(oPrsDrugs.Drugs.DrugMaster.Name);
                        itm.SubItems.Add(oPrsDrugs.Drugs.DrugMaster.DrugGroup.ID);
                        itm.SubItems.Add(oPrsDrugs.Drugs.DrugMaster.CalculatedQty.ToString());
                        itm.SubItems.Add(oPrsDrugs.Drugs.DrugMaster.RemainingQty.ToString());
                        lvProvidedDrugs.Items.Add(itm);
                    }
                }
            }
        }

        private void GetPrsTests()
        {
            lvProvidedTests.Items.Clear();
            List<IPDPrescription> oTests = new List<IPDPrescription>();
            oTests = nwbnch.GetPrescribedTests(txtPatRegNoIPD.Text).ToList();
            if (oTests.Count > 0)
            {
                foreach (IPDPrescription oPrsTests in oTests)
                {
                    ListViewItem itm = new ListViewItem(oPrsTests.DocVisitID);
                    itm.SubItems.Add(oPrsTests.Tests.TestMainID);
                    itm.SubItems.Add(oPrsTests.Tests.TestMainTitle);
                    itm.SubItems.Add(oPrsTests.Tests.TestSubID);
                    itm.SubItems.Add(oPrsTests.Tests.TestSubTitle);
                    lvProvidedTests.Items.Add(itm);
                }
            }
        }
        private void LoadPatient(InPatient pat)
        {
            txtPatRegNoIPD.Text = pat.RegistrationNo;
            txtPatName.Text = pat.Name;
            txtDOB.Text = pat.DOB.ToString("dd/MM/yyyy");

            DateTime now = DateTime.Today;
            DateTime birthDate = DateTime.ParseExact(txtDOB.Text, "dd/MM/yyyy", null);
            //get the difference in years
            TimeSpan ts = now.Date - birthDate.Date;
            int ageY = (ts.Days / 365);
            int daysleft1 = ts.Days - (ageY * 365);
            int ageM = (daysleft1 / 30);
            int daysleft2 = daysleft1 - (ageM * 30);
            int ageD = daysleft2;
            txtAgeY.Text = ageY.ToString();
            txtAgeM.Text = ageM.ToString();
            txtAgeD.Text = ageD.ToString();
            txtAgeH.Text = ageD.ToString();

            txtPrescriptionNumber.Text = pat.ReferenceNo;
            txtHCN.Text = pat.HCN;
            txtBedTitle.Text = pat.Bed.BedTitle;
            txtBedNo.Text = pat.Bed.BedNo;
            txtBedType.Text = Convert.ToString(pat.Bed.BedType.Title);
            txtBedTypeID.Text = Convert.ToString(pat.Bed.BedType.ID);
            txtRoonNo.Text = Convert.ToString(pat.Room.RoomTitle);
            txtRoomID.Text = Convert.ToString(pat.Room.RoomID);
            txtWardID.Text = "0";
            txtFloorNo.Text = pat.Room.Floor;
            txtBedFecilityID.Text = pat.Bed.BedType.BedFacility.ID;
            txtStaffId.Text = pat.StaffID;
            txtNurseStn.Text = pat.NurseStation.NurseStationID;
            txtDepartmentId.Text = pat.Department.DepartmentID;
            txtUnitId.Text = pat.DepartmentUnit.UnitId;
            txtDoctorId.Text = pat.Doctor.ID;
            txtDoctorName.Text = pat.Department.DepartmentUnitHead;
        }
        private NurseRequisition PopulateRequisition()
        {
            NurseRequisition rq = new NurseRequisition();
            InPatient oInPatient = new InPatient();

            oInPatient.HCN = txtHCN.Text;
           // oInPatient.ReferenceNo = txtPrescriptionNumber.Text;
           // oInPatient.StaffID = txtStaffId.Text;

            Department odpt = new Department();
            odpt.DepartmentID = txtDepartmentId.Text;
            oInPatient.Department = odpt;

            DepartmentUnit odptu = new DepartmentUnit();
            odptu.UnitId = txtUnitId.Text;
            oInPatient.DepartmentUnit = odptu;

            Doctor oDoctor = new Doctor();
            oDoctor.ID = txtDoctorId.Text;
            oInPatient.Doctor = oDoctor;

            oInPatient.RegistrationNo = txtPatRegNoIPD.Text;
            oInPatient.Remarks = txtRemarks.Text;

            Bed  oBed= new Bed();
            oBed.BedID = txtBedNo.Text;
            oInPatient.Bed = oBed;

            NurseStation oNsstn = new NurseStation();
            oNsstn.NurseStationID = txtNurseStn.Text;
            oInPatient.NurseStation = oNsstn;

            oInPatient.ReferenceNo = txtPrescriptionNumber.Text;

            AH.ModuleController.NWMSSR.Age oAge = new AH.ModuleController.NWMSSR.Age();
            oAge.Year = Convert.ToInt32(txtAgeY.Text);
            oAge.Month = Convert.ToInt32(txtAgeM.Text);
            oAge.Day = Convert.ToInt32(txtAgeD.Text);
            oAge.Hour = Convert.ToInt32(txtAgeH.Text);

            oInPatient.Age =oAge;
            rq.Patient = oInPatient;

            double netAmount = 0.0;

            foreach (ListViewItem itemRow in lvAddItems.Items)
            {
                string a = itemRow.SubItems[1].Text;
                double one = Convert.ToDouble(itemRow.SubItems[11].Text.ToString());
                double two = Convert.ToDouble(itemRow.SubItems[15].Text.ToString());
                netAmount += (Convert.ToDouble(itemRow.SubItems[11].Text) - Convert.ToDouble(itemRow.SubItems[15].Text));
            }

            rq.testsNetFee = netAmount;

            /////////////////////////////////////////////Drugs 
            string drugs = "";
            foreach (ListViewItem itemRow in lstMedicalPres.Items)
            {
                drugs += itemRow.SubItems[0].Text + "`"   //DRUG_COMP_ID ,
                      +  itemRow.SubItems[1].Text + "`"   //GrID 
                      +  itemRow.SubItems[2].Text + "`"   //UID   
                      +  itemRow.SubItems[3].Text + "`"   //TID  
                      +  itemRow.SubItems[4].Text + "`"   //Drug ID
                      +  itemRow.SubItems[9].Text + "`"   //DRQty 
                      +  itemRow.SubItems[10].Text + "`" //RQty 
                      +  itemRow.SubItems[11].Text + "`";
                drugs += "~";
            }
            rq.drugs = drugs;
            ///////////////////////////////////////////Drugs end


            ///////////////////////////////////////////////Tests
            string colltests = "";
            foreach (ListViewItem itemRow in lvAddItems.Items)
            {
               colltests += itemRow.SubItems[7].Text  + "`"  //Lab Room ID -1
                          + itemRow.SubItems[6].Text  + "`"  //Rpt Grp ID -2
                          + itemRow.SubItems[3].Text  + "`"  //Dept ID -3
                          + itemRow.SubItems[4].Text  + "`"  //Group ID -4
                          + itemRow.SubItems[5].Text  + "`"  //Test Main ID -5
                          + itemRow.SubItems[2].Text  + "`"  //Test det ID -6 

                          + itemRow.SubItems[8].Text  + "`"   //Spc Room ID -7
                          + itemRow.SubItems[9].Text  + "`"   //Panel ID -8
                          + itemRow.SubItems[10].Text + "`"  //Fee Cat ID -9
                          + itemRow.SubItems[11].Text + "`"  //Fee -10
                          + itemRow.SubItems[12].Text + "`"  //Dept Fee -11
                          + itemRow.SubItems[13].Text + "`"  //Reff Dept Fee -12
                          + itemRow.SubItems[14].Text + "`"  //Doc fee -13
                          + itemRow.SubItems[15].Text + "`"  //Disc -14
                          + itemRow.SubItems[16].Text + "`"  //Vat -15
                          + itemRow.SubItems[17].Text + "`";  //Visit_no -16
                colltests += "~";
            }
            rq.tests = colltests;

            ////////////////////////////////////////////Tests end

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            rq.EntryParameter = ep;

            return rq;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            testChkBox.Items.Clear();
            lstDrugName.Items.Clear();
            lstMedicalPres.Items.Clear();
            lvAddItems.Items.Clear();
            txtDOB.Text = string.Empty;
            txtDoctorId.Text = string.Empty;
            txtDoctorName.Text = string.Empty;
            txtHCN.Text = string.Empty;
            txtPatName.Text = string.Empty;
            txtPatRegNoIPD.Text = string.Empty;
            txtPatRegNoIPD.Enabled = true;
            btnFind.Enabled = true;
            chkSearchFromAllTest.Checked = true;
        }

        #region ReceiveDrugs
        private void btnDrugHistory_Click(object sender, EventArgs e)
        {
            dgvMedReceive.Rows.Clear();
            int i = 0;
            List<NWMSReceiveRequisition> oMedicines = new List<NWMSReceiveRequisition>();
            oMedicines = nwbnch.ReceiveRequisition(txtPatRegNoIPD.Text).ToList();
            if (oMedicines.Count > 0)
            {
                foreach (NWMSReceiveRequisition oRcv in oMedicines)
                {
                    dgvMedReceive.Rows.Add(1);                                     
                    dgvMedReceive.Rows[i].Cells[0].Value  = oRcv.RequisitionID;
                    dgvMedReceive.Rows[i].Cells[1].Value  = oRcv.Drugs.DrugMaster.ID;
                    dgvMedReceive.Rows[i].Cells[2].Value  = oRcv.Drugs.DrugMaster.Name;
                    dgvMedReceive.Rows[i].Cells[3].Value  = oRcv.Drugs.DrugMaster.DrugCompany.ID;
                    dgvMedReceive.Rows[i].Cells[4].Value  = oRcv.Drugs.DrugMaster.DrugCompany.Name;
                    dgvMedReceive.Rows[i].Cells[5].Value  = oRcv.Drugs.DrugMaster.DrugGroup.ID;
                    dgvMedReceive.Rows[i].Cells[6].Value  = oRcv.Drugs.DrugMaster.DrugGroup.Name;
                    dgvMedReceive.Rows[i].Cells[7].Value  = oRcv.Drugs.DrugMaster.DrugUnit.ID;
                    dgvMedReceive.Rows[i].Cells[8].Value  = oRcv.Drugs.DrugMaster.DrugUnit.Name;
                    dgvMedReceive.Rows[i].Cells[9].Value  = oRcv.Drugs.DrugMaster.DrugPackType.ID;
                    dgvMedReceive.Rows[i].Cells[10].Value = oRcv.Drugs.DrugMaster.DrugPackType.Name;
                    dgvMedReceive.Rows[i].Cells[11].Value = oRcv.RequisitionQty;
                    dgvMedReceive.Rows[i].Cells[12].Value = oRcv.ReceivedQty;
                    dgvMedReceive.Rows[i].Cells[13].Value = oRcv.RemainingQty;
                    i = i + 1;
                }
            }
        }

        private void btnReceived_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtPatRegNoIPD", "txtHCN", "txtIssueID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (dgvIssueDetails.SelectedRows.Count > 0)
                {
                    NWMSReceiveRequisition drugsRcv = populateReceivedData();      
                    short i = nwbnch.SaveDrugReqRcv(drugsRcv);
                    if (i == 0)
                    {
                        MessageBox.Show("Data Insertion Failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Data Insertion Successful", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnDrugHistory_Click(sender, e);
                        dgvIssueDetails.Rows.Clear();
                        txtIssueID.Text = string.Empty;
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
                return;
            }
        }

        private NWMSReceiveRequisition populateReceivedData()
        {
            NWMSReceiveRequisition drugsRcv = new NWMSReceiveRequisition();
            InPatient oInPatient = new InPatient();
            oInPatient.HCN = txtHCN.Text;
            oInPatient.RegistrationNo = txtPatRegNoIPD.Text;
            drugsRcv.Patient = oInPatient;

            NurseStation oNsstn = new NurseStation();
            oNsstn.NurseStationID = txtNurseStn.Text;
            oInPatient.NurseStation = oNsstn;

            Bed bd = new Bed();
            bd.BedNo = Convert.ToString(txtBedNo.Text);

            BedType bedType = new BedType();
            bedType.Title = Convert.ToString(txtBedType.Text);
            bd.BedType = bedType;

            oInPatient.Bed = bd;

            Room rm = new Room();
            rm.RoomID = Convert.ToString(txtRoomID.Text);
            oInPatient.Room = rm;

            drugsRcv.pharmacyID = dgvIssueDetails.Rows[0].Cells["Pharmacy ID"].Value.ToString();
            drugsRcv.RequisitionID = dgvIssueDetails.Rows[0].Cells["Requisition ID"].Value.ToString();
            drugsRcv.IssueID = dgvIssueDetails.Rows[0].Cells["Issue ID"].Value.ToString();

            string IssueDetails = "";
            int k = 0;
            foreach (DataGridViewRow row in dgvIssueDetails.Rows)
            {
                IssueDetails += dgvIssueDetails.Rows[k].Cells["Drug ID"].Value.ToString() + "`"
                             + dgvIssueDetails.Rows[k].Cells["Company ID"].Value.ToString() + "`"
                             + dgvIssueDetails.Rows[k].Cells["Group ID"].Value.ToString() + "`"
                             + dgvIssueDetails.Rows[k].Cells["Unit ID"].Value.ToString() + "`"
                             + dgvIssueDetails.Rows[k].Cells["Type ID"].Value.ToString() + "`"
                             + dgvIssueDetails.Rows[k].Cells["Batch No"].Value.ToString() + "`"
                             + dgvIssueDetails.Rows[k].Cells["Issue Qty"].Value.ToString() + "`"
                             + dgvIssueDetails.Rows[k].Cells["Receive Qty"].Value.ToString() + "`"
                             + dgvIssueDetails.Rows[k].Cells["Return Qty"].Value.ToString() + "`";
                IssueDetails += "~";
                k = k + 1;
            }
 
            drugsRcv.IssueDetails = IssueDetails;
            drugsRcv.ReceiveStatus = "0";
                       
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
                    
            drugsRcv.EntryParameter = ep;    
            return drugsRcv;
        }

        private void btnSearchIssueDet_Click(object sender, EventArgs e)
        {
            if (txtIssueID.Text != "" && txtIssueID.Text.Length == 11)
            {
                string issue_id = txtIssueID.Text;
                string registration_id =txtPatRegNoIPD.Text;
                short b = nwbnch.VerifyIssueID(issue_id, registration_id);
                if(b == 1)
                {
                    short c = nwbnch.CheckIssueIDforRcv(issue_id);
                    if (c == 0)
                    {
                        dgvIssueDetails.Rows.Clear();
                        int i = 0;
                        List<DrugIssue> oDrugIssues = new List<DrugIssue>();
                        oDrugIssues = nwbnch.GetIssueDetails(txtIssueID.Text).ToList();
                        if (oDrugIssues.Count > 0)
                        {
                            foreach (DrugIssue oRcv in oDrugIssues)
                            {
                                dgvIssueDetails.Rows.Add(1);
                                dgvIssueDetails.Rows[i].Cells[0].Value = oRcv.Warehouse.TypeID;
                                dgvIssueDetails.Rows[i].Cells[1].Value = oRcv.Warehouse.TypeName;
                                dgvIssueDetails.Rows[i].Cells[2].Value = oRcv.ID;
                                dgvIssueDetails.Rows[i].Cells[3].Value = oRcv.DRID;
                                dgvIssueDetails.Rows[i].Cells[4].Value = oRcv.DrugMaster.ID;
                                dgvIssueDetails.Rows[i].Cells[5].Value = oRcv.DrugMaster.Name;
                                dgvIssueDetails.Rows[i].Cells[6].Value = oRcv.DrugMaster.DrugCompany.ID;
                                dgvIssueDetails.Rows[i].Cells[7].Value = oRcv.DrugMaster.DrugCompany.Name;
                                dgvIssueDetails.Rows[i].Cells[8].Value = oRcv.DrugMaster.DrugGroup.ID;
                                dgvIssueDetails.Rows[i].Cells[9].Value = oRcv.DrugMaster.DrugGroup.Name;
                                dgvIssueDetails.Rows[i].Cells[10].Value = oRcv.DrugMaster.DrugUnit.ID;
                                dgvIssueDetails.Rows[i].Cells[11].Value = oRcv.DrugMaster.DrugUnit.Name;
                                dgvIssueDetails.Rows[i].Cells[12].Value = oRcv.DrugMaster.DrugPackType.ID;
                                dgvIssueDetails.Rows[i].Cells[13].Value = oRcv.DrugMaster.DrugPackType.Name;
                                dgvIssueDetails.Rows[i].Cells[14].Value = oRcv.IssueQty;
                                dgvIssueDetails.Rows[i].Cells[15].Value = "0";
                                dgvIssueDetails.Rows[i].Cells[16].Value = "0";
                                dgvIssueDetails.Rows[i].Cells[17].Value = oRcv.IssueDate.ToString("dd/MM/yyyy");
                                dgvIssueDetails.Rows[i].Cells[18].Value = oRcv.IssueType;
                                dgvIssueDetails.Rows[i].Cells[19].Value = oRcv.BatchID;

                                i = i + 1;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Already Received", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIssueID.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("The Issue ID isn't for this patient ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIssueID.Focus();
                }
                
            }
        }

        private void dgvIssueDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 15)
            {
                double i;
                if (!double.TryParse(Convert.ToString(e.FormattedValue), out i))
                {                              
                    e.Cancel = true;
                    MessageBox.Show("Enter Numeric Value", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    double issueQ = 0 ;
                    issueQ = Convert.ToDouble(dgvIssueDetails.CurrentRow.Cells["Issue Qty"].Value.ToString());

                    if (Convert.ToDouble(e.FormattedValue) > issueQ)
                    {
                        e.Cancel = true;
                        MessageBox.Show("Receive quantity can not be greater than Issue quantity", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        dgvIssueDetails.CurrentRow.Cells["Return Qty"].Value = Convert.ToString(issueQ - Convert.ToDouble(e.FormattedValue));
                        return;
                    }
                }
            }
        }
        #endregion ReceiveDrugs

        private void btnTestHistory_Click(object sender, EventArgs e)
        {
            dgvTestReceive.Rows.Clear();
            int i = 0;
            List<NWMSReceiveRequisition> oTests = new List<NWMSReceiveRequisition>();
            oTests = nwbnch.ReceiveReqTest(txtPatRegNoIPD.Text).ToList();
            
            if (oTests.Count > 0)
            {
                foreach (NWMSReceiveRequisition oRcvT in oTests)
                {
                    dgvTestReceive.Rows.Add(1);
                    dgvTestReceive.Rows[i].Cells[0].Value = oRcvT.RequisitionID;
                    dgvTestReceive.Rows[i].Cells[1].Value = oRcvT.Tests.TestMainID;
                    dgvTestReceive.Rows[i].Cells[2].Value = oRcvT.Tests.TestMainTitle;
                    dgvTestReceive.Rows[i].Cells[3].Value = oRcvT.Tests.TestSubID;
                    dgvTestReceive.Rows[i].Cells[4].Value = oRcvT.Tests.TestSubTitle;
                    dgvTestReceive.Rows[i].Cells[5].Value = oRcvT.Tests.LabRoom.RoomID;
                    dgvTestReceive.Rows[i].Cells[6].Value = oRcvT.Tests.ReportGroup.ReportGroupID;
                    dgvTestReceive.Rows[i].Cells[7].Value = oRcvT.Tests.ReportGroup.ReportGroupTitle;
                    dgvTestReceive.Rows[i].Cells[8].Value = oRcvT.Tests.TestDepartment.DepartmentID;
                    dgvTestReceive.Rows[i].Cells[9].Value = oRcvT.Tests.TestDepartment.DepartmentTitle;
                    dgvTestReceive.Rows[i].Cells[10].Value = oRcvT.Tests.TestGroup.GroupId;
                    dgvTestReceive.Rows[i].Cells[11].Value = oRcvT.Tests.TestGroup.GroupTitle;
                    dgvTestReceive.Rows[i].Cells[12].Value = oRcvT.DiagMR;
                    dgvTestReceive.Rows[i].Cells[13].Value = oRcvT.DiagSecID;
                    dgvTestReceive.Rows[i].Cells[14].Value = oRcvT.DiagResultID;
                    i = i + 1;
                }
            }
        }

         private void dgvMedicine_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                double i;
                if (!double.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("Enter Numeric Value", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                else
                {
                    //double qty = 0;
                   // qty = Convert.ToDouble(dgvMedicine.CurrentRow.Cells["Quantity"].Value.ToString());
                   // double issueQ = 0;
                  //  issueQ = Convert.ToDouble(dgvIssueDetails.CurrentRow.Cells["Issue Qty"].Value.ToString());

                    string searchWithinThis = Convert.ToString(e.FormattedValue);
                   // if (searchWithinThis.StartsWith("00") || searchWithinThis.StartsWith("0") || searchWithinThis == " ")
                   // {
                   //     return;
                  //  }

                    if (searchWithinThis.StartsWith("00") || searchWithinThis.StartsWith("0") || searchWithinThis.StartsWith(" ") || searchWithinThis.StartsWith("-"))//(Convert.ToDouble(e.FormattedValue) > issueQ)
                    {
                        e.Cancel = true;
                        MessageBox.Show("Not a valid quantity", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                   // else
                   //  {
                   //     dgvMedicine.CurrentRow.Cells["Return Qty"].Value = Convert.ToString(issueQ - Convert.ToDouble(e.FormattedValue));
                  //      return;
                  //  }
                }
            }
        }
        private void testChkBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*  int cnt = lvAddItems.Items.Count;
              for (int i = 0; i < testChkBox.Items.Count; i++)
              {
                  if (testChkBox.Items[i].Checked == true)
                  {
                      short flg = 0;
                      for (int j = 0; j < lvAddItems.Items.Count; j++)
                      {
                          if (lvAddItems.Items[j].SubItems[2].Text == testChkBox.Items[i].SubItems[1].Text)
                          {
                              flg = 1;
                          }
                      }
                      if (flg == 0)
                      {
                          cnt++;
                          ListViewItem itm = new ListViewItem(cnt.ToString());
                          itm.SubItems.Add(testChkBox.Items[i].SubItems[0].Text);
                          itm.SubItems.Add(testChkBox.Items[i].SubItems[1].Text);
                          itm.SubItems.Add(testChkBox.Items[i].SubItems[2].Text);
                          itm.SubItems.Add(testChkBox.Items[i].SubItems[3].Text);
                          itm.SubItems.Add(testChkBox.Items[i].SubItems[4].Text);
                          itm.SubItems.Add(testChkBox.Items[i].SubItems[5].Text);
                          itm.SubItems.Add(testChkBox.Items[i].SubItems[6].Text);
                          lvAddItems.Items.Add(itm);
                      }
                  }
              }
              txtSearchInvestigation.Text = "";*/

            if (txtVisitNumber.Text != "")
            {
                for (int i = 0; i < testChkBox.Items.Count; i++)
                {
                    if (testChkBox.Items[i].Checked == true)
                    {
                        if (Utility.IsDuplicateFoundInList(lvAddItems, 2, testChkBox.Items[i].SubItems[1].Text))
                        {
                            // MessageBox.Show("This Complain Already exists!!");
                            //txtSearchInvestigation.Select();
                        }
                        else
                        {
                            ListViewItem itm = new ListViewItem(testChkBox.Items[i].SubItems[0].Text);
                            if (ValidVisitOrNot(txtVisitNumber.Text) == 1 || ValidVisitOrNot(txtVisitNumber.Text) == 0)
                            {
                                if (testChkBox.Items[i].SubItems[10].Text != "" && testChkBox.Items[i].SubItems[10].Text != null)
                                {
                                    if (Convert.ToDouble(testChkBox.Items[i].SubItems[10].Text) > 0)
                                    {
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[0].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[1].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[2].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[3].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[4].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[5].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[6].Text); //lab room

                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[7].Text); // spc rm id
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[8].Text); //pnl id
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[9].Text); //fee cat
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[10].Text); // fee
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[11].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[12].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[13].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[14].Text);
                                        itm.SubItems.Add(testChkBox.Items[i].SubItems[15].Text);
                                        itm.SubItems.Add(txtVisitNumber.Text); //17 doc visit number
                                        lvAddItems.Items.Add(itm);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cannot add from different Visit Number", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("This Investigation is not Provided By Doctor", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtSearchInvestigation.Text = "";
            txtVisitNumber.Text = "";
        }       

         private void populateAllTest()
         {
             testChkBox.Items.Clear();
             testsListAll = new List<TestFee>();
             //if (cboGroupID.SelectedValue.ToString() == "01")
             //{
             //    testsListAll.AddRange(nwbnch.GetAllMappingTest("A", cboFeeCatID.SelectedValue.ToString()).ToList());
             //}
             //if (cboGroupID.SelectedValue.ToString() == "02")
             //{
             //    testsListAll.AddRange(nwbnch.GetAllMappingTest("B", cboFeeCatID.SelectedValue.ToString()).ToList());
             //}
           //  testsListAll.AddRange(nwbnch.GetAllMappingTest(cboFeeCatID.SelectedValue.ToString()).ToList());
             testsListAll.AddRange(nwbnch.GetAllMappingTest("C", cboFeeCatID.SelectedValue.ToString()).ToList());
             foreach (TestFee tg in testsListAll)
             {
                 ListViewItem itm = new ListViewItem(tg.TestSub.TestSubTitle);
                 itm.SubItems.Add(tg.TestSub.TestSubID);
                 itm.SubItems.Add(tg.TestSub.TestDepartment.DepartmentID);
                 itm.SubItems.Add(tg.TestSub.TestGroup.GroupId);
                 itm.SubItems.Add(tg.TestSub.TestMainID);
                 itm.SubItems.Add(tg.TestSub.ReportGroup.ReportGroupID);
                 itm.SubItems.Add(tg.TestSub.LabRoom.RoomID);

                 itm.SubItems.Add(tg.TestSub.SpecimenCollectionRoom.RoomID);
                 itm.SubItems.Add(tg.TestSub.PanelID);
                 itm.SubItems.Add(tg.FeeCategory.FeeCategoryID);
                 itm.SubItems.Add(tg.Fee.ToString()); //10
                 itm.SubItems.Add(tg.DeptFee.ToString());
                 itm.SubItems.Add(tg.RefdFee.ToString());
                 itm.SubItems.Add(tg.DoctorFee.ToString());
                 itm.SubItems.Add(tg.Discount.ToString()); //14
                 itm.SubItems.Add(tg.VAT.ToString());
                 testChkBox.Items.Add(itm);
             }
             this.testChkBox.Focus();
         }

         private void chkSearchFromAllTest_CheckedChanged(object sender, EventArgs e)
         {
             if (chkSearchFromAllTest.Checked == true)
             {
                 txtVisitNumber.Text = "";
                 populateAllTest();
             }
             else
             {
                 testChkBox.Items.Clear();
             }
         }

         private void cboFeeCatID_SelectedIndexChanged(object sender, EventArgs e)
         {
             this.chkSearchFromAllTest_CheckedChanged(sender, e);
         }

         private void lvProvidedTests_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (lvProvidedTests.SelectedItems.Count > 0)
             {
                 ListViewItem itm = lvProvidedTests.SelectedItems[0];
                 txtSearchInvestigation.Text = itm.SubItems[4].Text;
                 txtVisitNumber.Text = itm.SubItems[0].Text;
                 txtTestID.Text = itm.SubItems[3].Text;
             }
         }
        
         private void txtSearchInvestigation_TextChanged(object sender, EventArgs e)
         {
               if (txtSearchInvestigation.Text != "" || txtSearchInvestigation.Text != null)
               {
                   if (chkSearchFromAllTest.Checked == true)
                   {
                       PopulateAllTestTotestChkBox(testChkBox, txtSearchInvestigation.Text);
                   }
                   //else
                   //{
                   //    if (cboDepartment.SelectedValue != "" && lvGroup.Items.Count > 0 && lvGroup.SelectedItems.Count > 0)
                   //    {
                   //        PopulateDataTotestChkBox(testChkBox, txtSearchInvestigation.Text);
                   //    }
                   //    else
                   //    {
                   //        MessageBox.Show("Please Select Dapartment and Group ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   //    }
                   //}
               }
         }

         private void txtTestID_TextChanged(object sender, EventArgs e)
         {
             if (txtSearchInvestigation.Text != "" || txtSearchInvestigation.Text != null && txtTestID.Text != "" || txtTestID.Text != null)
             {
                 IEnumerable<TestFee> testsListAllLocal;
                 if (!(txtTestID.Text.Length > 0))
                 {
                     testsListAllLocal = testsListAll;
                 }
                 else
                 {
                     testsListAllLocal = testsListAll.Where(x => x.TestSub.TestSubID.Contains(txtTestID.Text));
                 }
                 testChkBox.Items.Clear();
                 foreach (TestFee tg in testsListAllLocal)
                 {
                     ListViewItem itm = new ListViewItem(tg.TestSub.TestSubTitle); //0
                     itm.SubItems.Add(tg.TestSub.TestSubID);
                     itm.SubItems.Add(tg.TestSub.TestDepartment.DepartmentID);
                     itm.SubItems.Add(tg.TestSub.TestGroup.GroupId);
                     itm.SubItems.Add(tg.TestSub.TestMainID);
                     itm.SubItems.Add(tg.TestSub.ReportGroup.ReportGroupID);
                     itm.SubItems.Add(tg.TestSub.LabRoom.RoomID);

                     itm.SubItems.Add(tg.TestSub.SpecimenCollectionRoom.RoomID);//7
                     itm.SubItems.Add(tg.TestSub.PanelID);
                     itm.SubItems.Add(tg.FeeCategory.FeeCategoryID);
                     itm.SubItems.Add(tg.Fee.ToString());//10
                     itm.SubItems.Add(tg.DeptFee.ToString());
                     itm.SubItems.Add(tg.RefdFee.ToString());
                     itm.SubItems.Add(tg.DoctorFee.ToString());
                     itm.SubItems.Add(tg.Discount.ToString());//14
                     itm.SubItems.Add(tg.VAT.ToString());

                     testChkBox.Items.Add(itm);
                 }
             }
         }

         private void dgvMedicine_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.Enter)
             {
                 btnAddDrug.PerformClick();
             }
         }
          
         private void dgvMedicine_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (Convert.ToInt32(e.KeyChar) == 13)
             {
                 btnAddDrug.PerformClick();
             }
         }

         private void button1_Click(object sender, EventArgs e)
         {
             frmIPDPatDocVisitDetails of = new frmIPDPatDocVisitDetails();
             of.ShowDialog();
         }


         private void btnSpcmnColl_Click(object sender, EventArgs e)
         {
             frmSpecimenCollection frmSpcmn = new frmSpecimenCollection(txtNurseStn.Text,"I");
             frmSpcmn.ShowDialog();
         }

         private void dgvTestReceive_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             if (e.ColumnIndex == 15 && e.RowIndex != -1)
             {
                 frmMoneyReceiptLifeCycle frm = new frmMoneyReceiptLifeCycle(dgvTestReceive.Rows[e.RowIndex].Cells[e.ColumnIndex-3].Value.ToString());
                 frm.ShowDialog();
             }
         }

         private void smartTab2_MouseClick(object sender, MouseEventArgs e)
         {
             if (smartTab2.SelectedIndex == 3)
             {
                 cboStoreGroup.DisplayMember = "Name";
                 cboStoreGroup.ValueMember = "ID";
                 cboStoreGroup.DataSource = nwbnch.GetGroupByMajorGrp("01", "01");     
             }
         }


         private void FormatGridlvItemMaster()
         {
             lvPatAccessories.CheckBoxes = false;
             lvPatAccessories.Columns.Add("StrID", 0, HorizontalAlignment.Left);//0
             lvPatAccessories.Columns.Add("Batch", 0, HorizontalAlignment.Left);
             lvPatAccessories.Columns.Add("Mrr", 0, HorizontalAlignment.Left);
             lvPatAccessories.Columns.Add("Item ID", 0, HorizontalAlignment.Left);
             lvPatAccessories.Columns.Add("Item Name", 369, HorizontalAlignment.Left);
             lvPatAccessories.Columns.Add("Unit ID", 0, HorizontalAlignment.Left);
             lvPatAccessories.Columns.Add("Unit", 0, HorizontalAlignment.Left);
             lvPatAccessories.Columns.Add("Group ID", 0, HorizontalAlignment.Left);
             lvPatAccessories.Columns.Add("Comp ID", 0, HorizontalAlignment.Left);
             lvPatAccessories.Columns.Add("Brand ID", 0, HorizontalAlignment.Left);
             lvPatAccessories.Columns.Add("Model ID", 0, HorizontalAlignment.Left);
             lvPatAccessories.Columns.Add("Store ID", 0, HorizontalAlignment.Left);
             lvPatAccessories.Columns.Add("MajorGroup ID", 0, HorizontalAlignment.Left);
             lvPatAccessories.Columns.Add("Quantity", 100, HorizontalAlignment.Left);
             lvPatAccessories.Columns.Add("RetQuantity", 0, HorizontalAlignment.Left);
             lvPatAccessories.Columns.Add("Rate", 0, HorizontalAlignment.Left);
             lvPatAccessories.Columns.Add("TotalPrice", 100, HorizontalAlignment.Left); //16
             lvPatAccessories.Columns.Add("Vat", 0, HorizontalAlignment.Left);
             lvPatAccessories.Columns.Add("Disc", 0, HorizontalAlignment.Left);//18
         }
         private void FormatGridItemDetails()
         {
             dgvItemDetails.AutoGenerateColumns = false;
             dgvItemDetails.ColumnCount = 12;

             dgvItemDetails.Columns[0].Name = "Batch";
             dgvItemDetails.Columns[0].ReadOnly = true;
             dgvItemDetails.Columns[0].Visible = false;

             dgvItemDetails.Columns[1].Name = "Mrr";
             dgvItemDetails.Columns[1].ReadOnly = true;
             dgvItemDetails.Columns[1].Visible = false;

             dgvItemDetails.Columns[2].Name = "Item ID";
             dgvItemDetails.Columns[2].ReadOnly = true;
             dgvItemDetails.Columns[2].Visible = false;
             dgvItemDetails.Columns[2].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

             dgvItemDetails.Columns[3].Name = "Item Name";
             dgvItemDetails.Columns[3].ReadOnly = true;
             dgvItemDetails.Columns[3].Width = 360;
             dgvItemDetails.Columns[3].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

             dgvItemDetails.Columns[4].Name = "UnitID";
             dgvItemDetails.Columns[4].ReadOnly = true;
             dgvItemDetails.Columns[4].Visible = false;

             dgvItemDetails.Columns[5].Name = "GroupID";
             dgvItemDetails.Columns[5].ReadOnly = true;
             dgvItemDetails.Columns[5].Visible = false;

             dgvItemDetails.Columns[6].Name = "CompanyID";
             dgvItemDetails.Columns[6].ReadOnly = true;
             dgvItemDetails.Columns[6].Visible = false;

             dgvItemDetails.Columns[7].Name = "BrandID";
             dgvItemDetails.Columns[7].ReadOnly = true;
             dgvItemDetails.Columns[7].Visible = false;

             dgvItemDetails.Columns[8].Name = "ModelID";
             dgvItemDetails.Columns[8].ReadOnly = true;
             dgvItemDetails.Columns[8].Visible = false;

             #region Commented
             /*  

            dgvItemDetails.Columns[2].Name = "Item NameBeng";
            dgvItemDetails.Columns[2].ReadOnly = true;
            dgvItemDetails.Columns[2].Visible = false;
            dgvItemDetails.Columns[2].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);
     
            dgvItemDetails.Columns[5].Name = "Packet";
            dgvItemDetails.Columns[5].ReadOnly = true;
            dgvItemDetails.Columns[5].Visible = false;
            dgvItemDetails.Columns[5].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvItemDetails.Columns[6].Name = "Unit";
            dgvItemDetails.Columns[6].ReadOnly = true;
            dgvItemDetails.Columns[6].Width = 100;
            
            dgvItemDetails.Columns[9].Name = "ReorderQuantity";
            dgvItemDetails.Columns[9].ReadOnly = true;
            dgvItemDetails.Columns[9].Visible = false;

            dgvItemDetails.Columns[10].Name = "ReorderCycle";
            dgvItemDetails.Columns[10].ReadOnly = true;
            dgvItemDetails.Columns[10].Visible = false;
            dgvItemDetails.Columns[11].Name = "Priority";
            dgvItemDetails.Columns[11].ReadOnly = true;
            dgvItemDetails.Columns[11].Visible = false;
            dgvItemDetails.Columns[11].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvItemDetails.Columns[12].Name = "SerialPriority";
            dgvItemDetails.Columns[12].ReadOnly = true;
            dgvItemDetails.Columns[12].Visible = false;
            dgvItemDetails.Columns[13].Name = "Remarks";
            dgvItemDetails.Columns[13].ReadOnly = true;
            dgvItemDetails.Columns[13].Visible = false;

            dgvItemDetails.Columns[14].Name = "IsExpireDate";
            dgvItemDetails.Columns[14].ReadOnly = true;
            dgvItemDetails.Columns[14].Visible = false;
            dgvItemDetails.Columns[14].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvItemDetails.Columns[15].Name = "IsSerial";
            dgvItemDetails.Columns[15].ReadOnly = false;
            dgvItemDetails.Columns[15].Visible = false;
            dgvItemDetails.Columns[15].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvItemDetails.Columns[16].Name = "IsBillable";
            dgvItemDetails.Columns[16].ReadOnly = true;
            dgvItemDetails.Columns[16].Visible = false;
            dgvItemDetails.Columns[16].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvItemDetails.Columns[17].Name = "IsWarranty";
            dgvItemDetails.Columns[17].ReadOnly = true;
            dgvItemDetails.Columns[17].Visible = false;
            dgvItemDetails.Columns[17].DefaultCellStyle.Font = new Font("Tahoma", 8.25F); */
             #endregion Commented

             dgvItemDetails.Columns[9].Name = "Unit";
             dgvItemDetails.Columns[9].ReadOnly = true;
             dgvItemDetails.Columns[9].Width = 100;
             dgvItemDetails.Columns[9].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

             dgvItemDetails.Columns[10].Name = "Stock Quantity";
             dgvItemDetails.Columns[10].ReadOnly = true;
             dgvItemDetails.Columns[10].Width = 100;
             dgvItemDetails.Columns[10].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

             dgvItemDetails.Columns[11].Name = "Rate";
             dgvItemDetails.Columns[11].ReadOnly = true;
             dgvItemDetails.Columns[11].Width = 100;
             dgvItemDetails.Columns[11].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

             #region Quantity
             DataGridViewTextBoxColumn colQty = new DataGridViewTextBoxColumn();
             colQty.DefaultCellStyle.Font = new Font("Tahoma", 8.25F);
             colQty.Name = "Quantity";
             colQty.DataPropertyName = "Quantity";
             colQty.Width = 100;
             colQty.Visible = true;
             colQty.MaxInputLength = 3;
             dgvItemDetails.Columns.Add(colQty);
             #endregion

         }
         private void cboStoreGroup_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (cboStoreGroup.SelectedValue != "")
             {
                // LoadGridViewByGroup(cboStoreGroup.SelectedValue.ToString());
                 LoadGridViewByGroup(cboStoreGroup.SelectedValue.ToString());
             }
         }
         private void LoadGridViewByGroup(string grpid)
         {
             AccessoriesListAll = new List<ItemOrder>();
             int i = 0;
             dgvItemDetails.Rows.Clear();
             AccessoriesListAll.AddRange(nwbnch.GetItemStockForNS(grpid, "0064").ToList<ItemOrder>());

             if (AccessoriesListAll.Count != 0)
             {
                 foreach (ItemOrder oItm in AccessoriesListAll)
                 {
                     dgvItemDetails.Rows.Add(1);
                     dgvItemDetails.Rows[i].Cells["Batch"].Value = oItm.Batch;
                     dgvItemDetails.Rows[i].Cells["Mrr"].Value = oItm.MRRID;
                     dgvItemDetails.Rows[i].Cells["Item ID"].Value = oItm.ItemMaster.ID;
                     dgvItemDetails.Rows[i].Cells["Item Name"].Value = oItm.ItemMaster.Name;
                     dgvItemDetails.Rows[i].Cells["UnitID"].Value = oItm.ItemMaster.Units.ID;
                     dgvItemDetails.Rows[i].Cells["GroupID"].Value = oItm.ItemMaster.GroupDetails.ID;
                     dgvItemDetails.Rows[i].Cells["CompanyID"].Value = oItm.ItemMaster.Company.ID;
                     dgvItemDetails.Rows[i].Cells["BrandID"].Value = oItm.ItemMaster.BrandSetup.ID;
                     dgvItemDetails.Rows[i].Cells["ModelID"].Value = oItm.ItemMaster.ModelSetup.ID;
                     dgvItemDetails.Rows[i].Cells["Unit"].Value = oItm.ItemMaster.Units.Name;
                     dgvItemDetails.Rows[i].Cells["Stock Quantity"].Value = oItm.ItemMaster.StockQty;
                     dgvItemDetails.Rows[i].Cells["Rate"].Value = oItm.ItemMaster.Urate;
                     dgvItemDetails.Rows[i].Cells["Quantity"].Value = "";
                     i = i + 1;
                 }
             }
#region
             /*   List<ItemOrder> dmas = new List<ItemOrder>();
             int i = 0;
             dgvItemDetails.Rows.Clear();
             dmas.AddRange(nwbnch.GetItemStockForNS(grpid, "0064").ToList<ItemOrder>());

             if (dmas.Count != 0)
             {
                 foreach (ItemOrder oItm in dmas)
                 {
                     dgvItemDetails.Rows.Add(1);
                     dgvItemDetails.Rows[i].Cells["Batch"].Value = oItm.Batch;
                     dgvItemDetails.Rows[i].Cells["Mrr"].Value = oItm.MRRID;
                     dgvItemDetails.Rows[i].Cells["Item ID"].Value = oItm.ItemMaster.ID;
                     dgvItemDetails.Rows[i].Cells["Item Name"].Value = oItm.ItemMaster.Name;
                     dgvItemDetails.Rows[i].Cells["UnitID"].Value = oItm.ItemMaster.Units.ID;
                     dgvItemDetails.Rows[i].Cells["GroupID"].Value = oItm.ItemMaster.GroupDetails.ID;
                     dgvItemDetails.Rows[i].Cells["CompanyID"].Value = oItm.ItemMaster.Company.ID;
                     dgvItemDetails.Rows[i].Cells["BrandID"].Value = oItm.ItemMaster.BrandSetup.ID;
                     dgvItemDetails.Rows[i].Cells["ModelID"].Value = oItm.ItemMaster.ModelSetup.ID;
                     dgvItemDetails.Rows[i].Cells["Unit"].Value = oItm.ItemMaster.Units.Name;
                     dgvItemDetails.Rows[i].Cells["Stock Quantity"].Value = oItm.ItemMaster.StockQty;
                     dgvItemDetails.Rows[i].Cells["Rate"].Value = oItm.ItemMaster.Urate;
                     dgvItemDetails.Rows[i].Cells["Quantity"].Value = "";
                     i = i + 1;
                 }
             }*/
#endregion
         
         }

         private void btnAddAccessoriesBilling_Click(object sender, EventArgs e)
         {
             double costTotal = 0;
              
             if (dgvItemDetails.Rows.Count > 0)
             {
                 ListViewItem lvItem;
                 foreach (DataGridViewRow row in dgvItemDetails.SelectedRows)
                 {
                     if ((row.Cells["Quantity"].Value.ToString() != "") && (row.Cells["Rate"].Value.ToString() != ""))
                     {
                        ItemDuplicateCheck(row.Cells["Item ID"].Value.ToString());

                        lvItem = new ListViewItem("0064");//0 str id
                        lvItem.SubItems.Add(row.Cells["Batch"].Value.ToString());   //1 Product Id
                        lvItem.SubItems.Add(row.Cells["Mrr"].Value.ToString()); //2     mrr
                        lvItem.SubItems.Add(row.Cells["Item ID"].Value.ToString());   //3 Product Id
                        lvItem.SubItems.Add(row.Cells["Item Name"].Value.ToString()); //4 
                        lvItem.SubItems.Add(row.Cells["UnitID"].Value.ToString());    //5 PROD_UNIT_ID       
                        lvItem.SubItems.Add(row.Cells["Unit"].Value.ToString());//6
                        lvItem.SubItems.Add(row.Cells["GroupID"].Value.ToString());   //7 PROD_GRP_ID        
                        lvItem.SubItems.Add(row.Cells["CompanyID"].Value.ToString()); //8 PROD_COMP_ID       
                        lvItem.SubItems.Add(row.Cells["BrandID"].Value.ToString());   //9 PROD_BRND_ID       
                        lvItem.SubItems.Add(row.Cells["ModelID"].Value.ToString());   //10 PROD_MODEL_ID      
                        lvItem.SubItems.Add("01");//11  STR_TYPE_ID        
                        lvItem.SubItems.Add("01");//12  PROD_MAJOR_GRP_ID  
                        lvItem.SubItems.Add(row.Cells["Quantity"].Value.ToString());//13  QTY                
                        lvItem.SubItems.Add("0");//14
                        lvItem.SubItems.Add(row.Cells["Rate"].Value.ToString());//15 URATE              
                        lvItem.SubItems.Add(Convert.ToString((Convert.ToDecimal(row.Cells["Quantity"].Value.ToString())*Convert.ToDecimal(row.Cells["Rate"].Value.ToString()))));//16 //Price

                        costTotal = costTotal + Convert.ToDouble((Convert.ToDecimal(row.Cells["Quantity"].Value.ToString()) * Convert.ToDecimal(row.Cells["Rate"].Value.ToString())));
                        txtAccessoriesBillTotal.Text = Convert.ToString(Convert.ToDouble(txtAccessoriesBillTotal.Text) + costTotal);
                            
                        lvItem.SubItems.Add("0");//17 vat 
                        lvItem.SubItems.Add("0");//18 disc
                        lvPatAccessories.Items.Add(lvItem);
                     }
                     LoadGridViewByGroup(cboStoreGroup.SelectedValue.ToString());
                 }
             }

         }
         private void ItemDuplicateCheck(string itemID)
         {
             if (lvPatAccessories.Items.Count < 0)
             {
                 return;
             }
             else
             {
                 for (int i = 0; i < lvPatAccessories.Items.Count; i++)
                 {
                     if (lvPatAccessories.Items[i].SubItems[0].Text == itemID)
                     {
                         lvPatAccessories.Items[i].Remove();
                     }
                 }
             }
         }

         private void btnRmvAccessoriesBilling_Click(object sender, EventArgs e)
         {
             double ExcludeCost = 0;
             foreach (ListViewItem eachItem in lvPatAccessories.SelectedItems)
             {
                 ExcludeCost = Convert.ToDouble((Convert.ToDecimal(eachItem.SubItems[16].Text)));
                 txtAccessoriesBillTotal.Text = Convert.ToString(Convert.ToDouble(txtAccessoriesBillTotal.Text) - ExcludeCost);
                 lvPatAccessories.Items.Remove(eachItem);
             }
         }

         private void lvPatAccessories_DoubleClick(object sender, EventArgs e)
         {
            // listViewSelectedItem(lvPatAccessories);
         }

         private void dgvItemDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
         {
             if (e.ColumnIndex == 12)
             {
                 double i;
                 if (!double.TryParse(Convert.ToString(e.FormattedValue), out i))
                 {
                     e.Cancel = true;
                     MessageBox.Show("Enter Numeric Value", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     return;
                 }
                 else
                 
                 {
                     double qty = 0;
                     qty = Convert.ToDouble(dgvItemDetails.CurrentRow.Cells["Stock Quantity"].Value.ToString());
                     double issueQ = 0;
                     issueQ = Convert.ToDouble(e.FormattedValue);

                     if (qty >= issueQ)
                     {
                         string searchWithinThis = Convert.ToString(e.FormattedValue);
                         // if (searchWithinThis.StartsWith("00") || searchWithinThis.StartsWith("0") || searchWithinThis == " ")
                         // {
                         //     return;
                         //  }
                         if (searchWithinThis.StartsWith("00") || searchWithinThis.StartsWith("0") || searchWithinThis.StartsWith(" ") || searchWithinThis.StartsWith("-"))//(Convert.ToDouble(e.FormattedValue) > issueQ)
                         {
                             e.Cancel = true;
                             MessageBox.Show("Not a valid quantity", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                             return;
                         }
                         // else
                         //  {
                         //     dgvMedicine.CurrentRow.Cells["Return Qty"].Value = Convert.ToString(issueQ - Convert.ToDouble(e.FormattedValue));
                         //      return;
                         //  }
                     }
                     else
                     {
                         MessageBox.Show("Issue quantity can not be greater than stock quantity", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }
                 }
             }
         }

         private void btnIssueAccessories_Click(object sender, EventArgs e)
         {
             List<string> vf = new List<string>() { "txtPatRegNoIPD", "txtPatName" };
             Control control = Utility.ReqFieldValidator(this, vf);
             if (control != null)
             {
                 MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 control.Focus();
                 return;
             }
             if (lvPatAccessories.Items.Count > 0 )
             {
                 try
                 {
                     NurseRequisition requsition = this.PopulateIssueDetails();
                     short i = nwbnch.IssueFromNurseStn(requsition);
                     if (i == 0)
                     {
                         MessageBox.Show("Data Insertion Failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }
                     else
                     {
                         MessageBox.Show("Data Insertion Successful", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                         lvPatAccessories.Items.Clear();
                         cboStoreGroup.SelectedIndex = 0;
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
             else
             {
                 MessageBox.Show("Can not proceed without issued items ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
         }

         private NurseRequisition PopulateIssueDetails()
         {
             NurseRequisition rq = new NurseRequisition();
             InPatient oInPatient = new InPatient();

             rq.StoreID = "0064";
             oInPatient.HCN = txtHCN.Text;

             Department odpt = new Department();
             odpt.DepartmentID = txtDepartmentId.Text;
             
             DepartmentGroup odptG = new DepartmentGroup();
             odptG.DepartmentGroupID = "03";
             odpt.DepartmentGroup = odptG;

             oInPatient.Department = odpt;

             DepartmentUnit odptu = new DepartmentUnit();
             odptu.UnitId = txtUnitId.Text;
             oInPatient.DepartmentUnit = odptu;

             oInPatient.RegistrationNo = txtPatRegNoIPD.Text;
             oInPatient.Remarks = txtRemarks.Text;

             Bed oBed = new Bed();
             oBed.BedID = txtBedNo.Text;
            
             BedType oBedT = new BedType();
             oBedT.ID = txtBedTypeID.Text;
             oBed.BedType = oBedT;

             oInPatient.Bed = oBed;

             Room oRoom = new Room();
             oRoom.RoomID = txtRoomID.Text;
             oInPatient.Room = oRoom;

             Ward owrd = new Ward();
             owrd.WardID = txtWardID.Text;
             oInPatient.Ward = owrd;

             NurseStation oNsstn = new NurseStation();
             oNsstn.NurseStationID = txtNurseStn.Text;
             oInPatient.NurseStation = oNsstn;

             rq.Patient = oInPatient;

             double tBill = 0;
             ///////////////////////////////////////////////Tests
             string IssueDetail = "";
             foreach (ListViewItem itemRow in lvPatAccessories.Items)
             {
                IssueDetail += itemRow.SubItems[0].Text + "`"  //str ID -1
                             + itemRow.SubItems[1].Text + "`"  //Batch  ID -2
                             + itemRow.SubItems[2].Text + "`"  //Mrr ID -3
                             + itemRow.SubItems[3].Text + "`"  //Product ID -4
                             + itemRow.SubItems[11].Text + "`"  //STR_TYPE_ID -5
                             + itemRow.SubItems[5].Text + "`"  //PROD_UNIT_ID -6 

                             + itemRow.SubItems[7].Text + "`"   //Group -7
                             + itemRow.SubItems[8].Text + "`"   //Comp -8
                             + itemRow.SubItems[9].Text + "`"  //Brand -9
                             + itemRow.SubItems[10].Text + "`"  //Model -10
                             + itemRow.SubItems[11].Text + "`"  //strType -11
                             + itemRow.SubItems[12].Text + "`"  //major group -12
                             + itemRow.SubItems[13].Text + "`"  //qty -13
                             + itemRow.SubItems[14].Text + "`"  //Ret Qty -14
                             + itemRow.SubItems[15].Text + "`"  //Urate -15
                             + itemRow.SubItems[17].Text + "`"  //vat -16
                             + itemRow.SubItems[18].Text + "`";  //Disc -17
                 IssueDetail += "~";
                 tBill = tBill + Convert.ToDouble(itemRow.SubItems[16].Text);
             }
             rq.IssueDetails = IssueDetail;
             ////////////////////////////////////////////Tests end

             rq.AccessoriesBill = Convert.ToString(tBill);

             EntryParameter ep = new EntryParameter();
             ep.EntryBy = Utility.UserId;
             ep.CompanyID = Utility.CompanyID;
             ep.LocationID = Utility.LocationID;
             ep.MachineID = Utility.MachineID;
             rq.EntryParameter = ep;

             return rq;
         }

         private void btnDrugsCancel_Click(object sender, EventArgs e)
         {
             if(lvProvidedDrugs.Items.Count >0)
             {
                 List<string> vf = new List<string>() { "txtPatRegNoIPD", "txtPatName" };
                 Control control = Utility.ReqFieldValidator(this, vf);
                 if (control != null)
                 {
                     MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     control.Focus();
                     return;
                 }
                try
                {
                    NurseRequisition CancelDrugDetails = this.PopulateDrgCnclDet();
                    short i = nwbnch.CancelIPDDrugs(CancelDrugDetails);
                    if (i == 0)
                    {
                        MessageBox.Show("Data Update Failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (i == 2)
                    {
                        MessageBox.Show("Drug already issued", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtDrugName.Text = string.Empty;
                        txtDrugID.Text = string.Empty;
                        dgvMedicine.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Data Update Successful", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAfterRequisition();
                        btnDrugHistory_Click(sender, e);
                        btnTestHistory_Click(sender, e);

                        txtDrugName.Text = string.Empty;
                        txtDrugID.Text = string.Empty;
                        dgvMedicine.Rows.Clear();
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
         }

         private NurseRequisition PopulateDrgCnclDet()
         {
            NurseRequisition rq = new NurseRequisition();

            /////////////////////////////////////////////Drugs 
            string drugs = "";
            foreach (ListViewItem itemRow in lvProvidedDrugs.SelectedItems)
            {
                drugs += itemRow.SubItems[0].Text + "`"   // visit id ,
                      +  itemRow.SubItems[1].Text + "`"   // drug id 
                      +  itemRow.SubItems[3].Text + "`"   // group id    
                      +  itemRow.SubItems[4].Text + "`"   // total ammount 
                      +  itemRow.SubItems[5].Text + "`"  ; // remaining
                drugs += "~";
            }
            rq.drugs = drugs;

            ///////////////////////////////////////////Drugs end
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            rq.EntryParameter = ep;

            return rq;
         }

         private void txtIssueID_KeyUp(object sender, KeyEventArgs e)
         {
             if (txtIssueID.Text.ToUpper().Length == Utility.ScanLength)
             {
                 txtIssueID.Text = txtIssueID.Text.ToUpper();
             }
         }

         private void txtSearchAcccessories_KeyUp(object sender, KeyEventArgs e)
         {
             if (txtSearchAcccessories.Text != "")
             {
                 GetSimilerAcccessories(dgvItemDetails, txtSearchAcccessories.Text);
             }
             else
             {
                 LoadGridViewByGroup(cboStoreGroup.SelectedValue.ToString());
             }
         }

         private void GetSimilerAcccessories(DataGridView dgvItemDetails, string SearchingStr)
         {
               dgvItemDetails.Rows.Clear();
               IEnumerable<ItemOrder> AccessoriesListLocal;
               int i = 0;
               if (!(SearchingStr.Length > 0))
               {
                   AccessoriesListLocal = AccessoriesListAll;
               }
               else
               {
                   AccessoriesListLocal = AccessoriesListAll.Where(x => x.ItemMaster.Name.ToLower().Contains(SearchingStr.ToLower()));
               }
               foreach (ItemOrder oItm in AccessoriesListLocal)
               {
                   dgvItemDetails.Rows.Add(1);
                   dgvItemDetails.Rows[i].Cells["Batch"].Value = oItm.Batch;
                   dgvItemDetails.Rows[i].Cells["Mrr"].Value = oItm.MRRID;
                   dgvItemDetails.Rows[i].Cells["Item ID"].Value = oItm.ItemMaster.ID;
                   dgvItemDetails.Rows[i].Cells["Item Name"].Value = oItm.ItemMaster.Name;
                   dgvItemDetails.Rows[i].Cells["UnitID"].Value = oItm.ItemMaster.Units.ID;
                   dgvItemDetails.Rows[i].Cells["GroupID"].Value = oItm.ItemMaster.GroupDetails.ID;
                   dgvItemDetails.Rows[i].Cells["CompanyID"].Value = oItm.ItemMaster.Company.ID;
                   dgvItemDetails.Rows[i].Cells["BrandID"].Value = oItm.ItemMaster.BrandSetup.ID;
                   dgvItemDetails.Rows[i].Cells["ModelID"].Value = oItm.ItemMaster.ModelSetup.ID;
                   dgvItemDetails.Rows[i].Cells["Unit"].Value = oItm.ItemMaster.Units.Name;
                   dgvItemDetails.Rows[i].Cells["Stock Quantity"].Value = oItm.ItemMaster.StockQty;
                   dgvItemDetails.Rows[i].Cells["Rate"].Value = oItm.ItemMaster.Urate;
                   dgvItemDetails.Rows[i].Cells["Quantity"].Value = "";
                   i = i + 1;
               }
         }

         private void btnSaveVisitingDetails_Click(object sender, EventArgs e)
         {
             frmIPDPrescription Iprs = new frmIPDPrescription(txtBedNo.Text,"V");
             Iprs.ShowDialog();

             GetPrsDrugs();
             GetPrsTests();
             LoadDoctorsVisitList();

         }

         private void btnEditVisitingDetails_Click(object sender, EventArgs e)
         {
             frmIPDPrescription Iprs = new frmIPDPrescription(txtBedNo.Text,"VE");
             Iprs.ShowDialog();

             GetPrsDrugs();
             GetPrsTests();
             LoadDoctorsVisitList();
         }
    }
}