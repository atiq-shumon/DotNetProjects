using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.DUtility;
using System.Globalization;
using AH.ModuleController.NWMSSR;
using AH.ModuleController.UI.OPD.Forms;

namespace AH.ModuleController.UI.NWMS.Forms
{
    public partial class frmAddToDischargeAdvice : AH.Shared.UI.frmSmartFormStandard
    {
        NWMSSR.NWMSWSClient nwbnch = new NWMSSR.NWMSWSClient();
        public delegate void SaveButtonClick(Prescription prescription, object sender, EventArgs e);
        public SaveButtonClick onSaveButtonClicked;

        private Prescription oPrescription;
        private Prescription tempPrescription;
        private int tab;

        //-------------------------Drugs------------------//
        private string patAge = "0";
        private string MealNameGrid = "";
        private string MealTGapGrid = "";
        private string MealBorAGrid = "";
        private string DurationIndGrid = "";

        double TotalDose = 0;
        double TotalDuration = 0;
        private string cBF = "";
        private string cLunch = "";
        private string cDinner = "";
        private string cCombination = "";
        //-------------------------Drugs------------------//
        List<Complaints> complaintsList;
        List<Complaints> otherComplaintsList;
        List<ClinicalDiagnosis> diagnosisList;
        List<TestSub> testsList;
        List<TestFee> testsListAll;
        List<DrugDose> drugsList;
        List<OPDAdvice> AdvicesList;
        private List<DrugDose> oDrugDoses = new List<DrugDose>();

        public frmAddToDischargeAdvice(Prescription tempPrescription, int tab, string age)
        {
            InitializeComponent();
            this.tempPrescription = tempPrescription;
            this.tab = tab;
            this.patAge = age;
        }

        private void frmAddToDischargeAdvice_Load(object sender, EventArgs e)
        {
            dgvMedicine.ReadOnly = false;
            if (tab == 0) smartTab1.SelectedIndex = 0;
            if (tab == 1) smartTab1.SelectedIndex = 1;
            if (tab == 2) smartTab1.SelectedIndex = 2;
            
#region LoadLIST&GRID
            LoadCategory();     
            //------------Test-------------//
            
            FormatListGroup();
            FormatListAddItems();
            FormatListCheckedAddItems();

            //-------------Drugs-----------//
           
            txtDrugID.Focus();
            txtDrugID.Select();
            lbl1.Visible = false;
            lbTDrugs.Visible = false;
            rdoMeal.Checked = true;
            FormatListMedicine();
            FormatGridDrugs(dgvMedicine);
            dgvMedicine.Visible = false;
           
            //-----------Advices----------//
            
            FormatListAdvices();
            FormatListCheckedAdvices();

#endregion LoadLIST&GRID 
         
#region PopulateData
            LoadDepartment();
            LoadConsumptionForm(); 
            PopulateAdvices();
#endregion PopulateData

#region CastingToList&Call
          //  List<Complaints> oComp = tempPrescription.ComplaintsList.ToList();
          //  List<Complaints> oOtherComp = tempPrescription.OtherComplaintsList.ToList();
          //  List<ClinicalDiagnosis> oDiag = tempPrescription.ClinicalDiagnosisList.ToList();
            List<TestSub> oTest = tempPrescription.TestsList.ToList();
            List<DrugDose> oDrugs = tempPrescription.DrugsList.ToList();
            List<OPDAdvice> oAdvice = tempPrescription.AdvicesList.ToList();

            refreshListTest(oTest, sender, e);
            refreshListDrug(oDrugs, sender, e);
            refreshListAdvice(oAdvice, sender, e);

#endregion CastingToList&Call

            chkDosagesNDurationNA.Checked = false;
            chkMealNA.Checked = false;
            chkSearchFromAllTest.Checked = true;
        }
        private void refreshListAdvice(List<OPDAdvice> oAdvice, object sender, EventArgs e)
        {
            foreach (OPDAdvice oa in oAdvice)
            {
                ListViewItem itm = new ListViewItem(oa.AdviceID);
                itm.SubItems.Add(oa.AdviceDetails);
                itm.SubItems.Add(oa.Department.DepartmentID);
                itm.SubItems.Add(oa.Remarks);
                lvSelectedAdvice.Items.Add(itm);
            }
        }
        private void refreshListTest(List<TestSub> oTest, object sender, EventArgs e)
        {
            foreach (TestSub tst in oTest)
            {
                lvAddItems.CheckBoxes = false;
                ListViewItem itm = new ListViewItem();
                itm.SubItems.Add(tst.TestSubTitle);
                itm.SubItems.Add(tst.TestSubID);
                itm.SubItems.Add(tst.TestDepartment.DepartmentID);
                itm.SubItems.Add(tst.TestGroup.GroupId);
                itm.SubItems.Add(tst.TestMainID);
                itm.SubItems.Add(tst.ReportGroup.ReportGroupID);
                itm.SubItems.Add(tst.Room.RoomID);
                lvAddItems.Items.Add(itm);
            }
        }
        private void refreshListDrug(List<DrugDose> oDrugs, object sender, EventArgs e)
        {
            foreach (DrugDose med in oDrugs)
            {
                lstMedicalPres.CheckBoxes = true;
                ListViewItem itm = new ListViewItem();
                itm.SubItems.Add(med.DrugMaster.PropertiesString); //At a Glance
                itm.SubItems.Add(med.DrugMaster.Remarks); //Remarks
                itm.SubItems.Add(med.DrugMaster.DrugCompany.ID); //CmpID
                itm.SubItems.Add(med.DrugMaster.DrugGroup.ID); //GID
                itm.SubItems.Add(med.DrugMaster.DrugUnit.ID); //UID
                itm.SubItems.Add(med.DrugMaster.DrugPackType.ID); //TID
                itm.SubItems.Add(med.DrugMaster.ID); //MID
                itm.SubItems.Add(med.DrugMaster.Name); //Mname
                itm.SubItems.Add(med.DoseStr); //DoseQty
                itm.SubItems.Add(med.ConsumptionForm.Name);  // Consumption form
                itm.SubItems.Add(med.Dur_Ind_Name); //Duration
                itm.SubItems.Add(med.DurationIndicator.ToString()); //DurationInd
                itm.SubItems.Add(med.RouteID); //RouteID
                itm.SubItems.Add(med.BeforeAfterMeal.ToString()); //B/AMeal
                itm.SubItems.Add(med.MealID.ToString()); //MealID
                itm.SubItems.Add(med.MealTimeGapID); //MealTimeGapID
                itm.SubItems.Add(med.DurationContinue); //DurCont
                itm.SubItems.Add(med.DrugMaster.CalculatedQty.ToString()); // Total drugs
                itm.SubItems.Add(med.DrugMaster.DrugPackType.Name); // Pack Type name

                lstMedicalPres.Items.Add(itm);
            }
        }
        private void PopulateAdvices()
        {
            AdvicesList = new List<OPDAdvice>();
            AdvicesList.AddRange(nwbnch.AdviceSetupGET());
            foreach (OPDAdvice oOPD in AdvicesList)
            {
                ListViewItem itm = new ListViewItem("");
                itm.SubItems.Add(Convert.ToString(oOPD.AdviceID));
                itm.SubItems.Add(Convert.ToString(oOPD.AdviceDetails));
                itm.SubItems.Add(Convert.ToString(oOPD.Department.DepartmentID));
                itm.SubItems.Add(Convert.ToString(oOPD.Remarks));
                listAdvicesCheck.Items.Add(itm);
            }
            this.listAdvicesCheck.View = View.Details;
        }
        private void LoadConsumptionForm()
        {
            cboConsumptionForm.DisplayMember = "Value";
            cboConsumptionForm.ValueMember = "Key";
            cboConsumptionForm.DataSource = new BindingSource(nwbnch.getConsumptionForm("D"), null);
        }
        private void LoadCategory()
        {
            cboFeeCatID.DisplayMember = "Value";
            cboFeeCatID.ValueMember = "Key";
            cboFeeCatID.DataSource = new BindingSource(nwbnch.GetFeecatDict("D"), null);
        }
        private void FormatListGroup()
        {
            lvGroup.CheckBoxes = false;
            lvGroup.Columns.Add("GroupID", 0, HorizontalAlignment.Left);
            lvGroup.Columns.Add("Group", 280, HorizontalAlignment.Left);
        }
        private void FormatListAddItems()
        {
            lvAddItems.CheckBoxes = false;
            lvAddItems.Columns.Add("No", 0, HorizontalAlignment.Left);
            lvAddItems.Columns.Add("Detail", 280, HorizontalAlignment.Left);
            lvAddItems.Columns.Add("DetailID", 0, HorizontalAlignment.Left);
            lvAddItems.Columns.Add("Department", 0, HorizontalAlignment.Left);
            lvAddItems.Columns.Add("Group", 0, HorizontalAlignment.Left);
            lvAddItems.Columns.Add("Main", 0, HorizontalAlignment.Left);
            lvAddItems.Columns.Add("ReportGroup", 0, HorizontalAlignment.Left);
            lvAddItems.Columns.Add("LabRoom", 0, HorizontalAlignment.Left);
        }
        private void FormatListCheckedAddItems()
        {
            testChkBox.Columns.Add("Details", 344, HorizontalAlignment.Left);
            testChkBox.Columns.Add("DetailID", 0, HorizontalAlignment.Left);
            testChkBox.Columns.Add("Department", 0, HorizontalAlignment.Left);
            testChkBox.Columns.Add("Group", 0, HorizontalAlignment.Left);
            testChkBox.Columns.Add("Main", 0, HorizontalAlignment.Left);
            testChkBox.Columns.Add("ReportGroup", 0, HorizontalAlignment.Left);
            testChkBox.Columns.Add("LabRoom", 0, HorizontalAlignment.Left);
        }

        private void FormatListMedicine()
        {
            lstMedicalPres.Columns.Add("", 0, HorizontalAlignment.Center);
            lstMedicalPres.Columns.Add("At A Glance", 534, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("Remarks", 100, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("CmpID", 0, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("GID", 0, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("UID", 0, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("TID", 0, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("MID", 0, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("DrugName", 0, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("DQty", 0, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("ConsumptionForm", 0, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("Duration", 0, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("DRtID", 0, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("RoutID", 0, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("BeforeAfterID", 0, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("MealID", 0, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("MealTimeGapID", 0, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("DurCont", 0, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("TotalMedicine", 100, HorizontalAlignment.Left);
            lstMedicalPres.Columns.Add("PackTypeName", 0, HorizontalAlignment.Left);
        }

        #region FormatGridDrugs
        private void FormatGridDrugs(DataGridView dtv)
        {
            dtv.Height = 400;
            dtv.Width = 800;
            dtv.AutoGenerateColumns = false;
            #region DrugID
            DataGridViewTextBoxColumn colDrugId = new DataGridViewTextBoxColumn();
            colDrugId.Name = "DRUGID";
            colDrugId.DataPropertyName = "DRUGID";
            colDrugId.Width = 0;
            colDrugId.Visible = false;
            colDrugId.ReadOnly = true;
            dtv.Columns.Add(colDrugId);
            #endregion DrugID
            #region DrugName
            DataGridViewTextBoxColumn colDrugTitle = new DataGridViewTextBoxColumn();
            colDrugTitle.Name = "Drug Name";
            colDrugTitle.DataPropertyName = "DRUGNAME";
            //colDrugTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colDrugTitle.Width = 250;
            colDrugTitle.Visible = true;
            colDrugTitle.ReadOnly = true;
            colDrugTitle.DefaultCellStyle.Font = new Font("Tahoma", 8.25F);
            dtv.Columns.Add(colDrugTitle);
            #endregion DrugName
            #region CompanyID
            DataGridViewTextBoxColumn colCompanyID = new DataGridViewTextBoxColumn();
            colCompanyID.Name = "COMPANYID";
            colCompanyID.DataPropertyName = "COMPANYID";
            colCompanyID.Width = 0;
            colCompanyID.Visible = false;
            dtv.Columns.Add(colCompanyID);
            #endregion
            #region CompanyName
            DataGridViewTextBoxColumn colCompanyTitle = new DataGridViewTextBoxColumn();
            colCompanyTitle.Name = "Company";
            colCompanyTitle.DataPropertyName = "COMPANYNAME";
            colCompanyTitle.Width = 110;
            colCompanyTitle.Visible = true;
            colCompanyTitle.ReadOnly = true;
            colCompanyTitle.DefaultCellStyle.Font = new Font("Tahoma", 8.25F);
            dtv.Columns.Add(colCompanyTitle);
            #endregion
            #region GroupID
            DataGridViewTextBoxColumn colGroupID = new DataGridViewTextBoxColumn();
            colGroupID.Name = "GROUPID";
            colGroupID.DataPropertyName = "GROUPID";
            colGroupID.Width = 0;
            colGroupID.Visible = false;
            dtv.Columns.Add(colGroupID);
            #endregion
            #region GroupName
            DataGridViewTextBoxColumn colGroupTitle = new DataGridViewTextBoxColumn();
            colGroupTitle.Name = "Group";
            colGroupTitle.DataPropertyName = "GROUPNAME";
            //colGroupTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colGroupTitle.Width = 250;
            colGroupTitle.Visible = true;
            colGroupTitle.ReadOnly = true;
            colGroupTitle.DefaultCellStyle.Font = new Font("Tahoma", 8.25F);
            dtv.Columns.Add(colGroupTitle);
            #endregion
            #region TypeID
            DataGridViewTextBoxColumn colTypeID = new DataGridViewTextBoxColumn();
            colTypeID.Name = "TYPEID";
            colTypeID.DataPropertyName = "TYPEID";
            colTypeID.Width = 0;
            colTypeID.Visible = false;
            dtv.Columns.Add(colTypeID);
            #endregion
            #region PackName
            DataGridViewTextBoxColumn colPackName = new DataGridViewTextBoxColumn();
            colPackName.Name = "UnitPack";
            colPackName.DataPropertyName = "PACKNAME";
            //  colPackName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colPackName.Width = 130;
            colPackName.DefaultCellStyle.Font = new Font("Tahoma", 8.25F);
            colPackName.Visible = true;
            colPackName.ReadOnly = true;
            dtv.Columns.Add(colPackName);
            #endregion
            #region UnitID
            DataGridViewTextBoxColumn colUnitID = new DataGridViewTextBoxColumn();
            colUnitID.Name = "UNITID";
            colUnitID.DataPropertyName = "UNITID";
            colUnitID.Width = 0;
            colUnitID.Visible = false;
            dtv.Columns.Add(colUnitID);
            #endregion
            #region UnitName
            DataGridViewTextBoxColumn colUnitName = new DataGridViewTextBoxColumn();
            colUnitName.Name = "Unit";
            colUnitName.DataPropertyName = "UNITNAME";
            //colUnitName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colUnitName.Width = 0;
            colUnitName.Visible = false;
            dtv.Columns.Add(colUnitName);
            #endregion
            #region Dose
            DataGridViewTextBoxColumn colDoseDrug = new DataGridViewTextBoxColumn();
            colDoseDrug.Name = "DOSEDRUG";
            colDoseDrug.DataPropertyName = "DOSEDRUG";
            colDoseDrug.Width = 0;
            colDoseDrug.Visible = false;
            dtv.Columns.Add(colDoseDrug);
            #endregion
            #region RouteID
            DataGridViewTextBoxColumn colRouteID = new DataGridViewTextBoxColumn();
            colRouteID.Name = "ROUTEID";
            colRouteID.DataPropertyName = "ROUTEID";
            colRouteID.Width = 0;
            colRouteID.Visible = false;
            dtv.Columns.Add(colRouteID);
            #endregion
            #region BeforeAfterMeal
            DataGridViewTextBoxColumn colBeforAftMeal = new DataGridViewTextBoxColumn();
            colBeforAftMeal.Name = "BEFOREAFTERMEAL";
            colBeforAftMeal.DataPropertyName = "BEFOREAFTERMEAL";
            colBeforAftMeal.Width = 0;
            colBeforAftMeal.Visible = false;
            dtv.Columns.Add(colBeforAftMeal);
            #endregion
            #region MealTimeGap
            DataGridViewTextBoxColumn colMealTimeGap = new DataGridViewTextBoxColumn();
            colMealTimeGap.Name = "MEALTIMEGAP";
            colMealTimeGap.DataPropertyName = "MEALTIMEGAP";
            colMealTimeGap.Width = 0;
            colMealTimeGap.Visible = false;
            dtv.Columns.Add(colMealTimeGap);
            #endregion
            #region MealName
            DataGridViewTextBoxColumn colMealName = new DataGridViewTextBoxColumn();
            colMealName.Name = "MEALNAME";
            colMealName.DataPropertyName = "MEALNAME";
            colMealName.Width = 0;
            colMealName.Visible = false;
            dtv.Columns.Add(colMealName);
            #endregion
            #region DurationPeriod
            DataGridViewTextBoxColumn colDurationPeriod = new DataGridViewTextBoxColumn();
            colDurationPeriod.Name = "DurationPeriod";
            colDurationPeriod.DataPropertyName = "DurationPeriod";
            colDurationPeriod.Width = 0;
            colDurationPeriod.Visible = false;
            dtv.Columns.Add(colDurationPeriod);
            #endregion
            #region DurationPeriodInd
            DataGridViewTextBoxColumn colDurationIndicator = new DataGridViewTextBoxColumn();
            colDurationIndicator.Name = "DurationInd";
            colDurationIndicator.DataPropertyName = "DurationInd";
            colDurationIndicator.Width = 0;
            colDurationIndicator.Visible = false;
            dtv.Columns.Add(colDurationIndicator);
            #endregion
            #region ConsumptionForm
            DataGridViewTextBoxColumn ConsumptionForm = new DataGridViewTextBoxColumn();
            ConsumptionForm.Name = "CONSUMPTIONFORM";
            ConsumptionForm.DataPropertyName = "CONSUMPTIONFORM";
            ConsumptionForm.Width = 0;
            ConsumptionForm.Visible = false;
            dtv.Columns.Add(ConsumptionForm);
            #endregion
            #region StockQty
            DataGridViewTextBoxColumn colStockQty = new DataGridViewTextBoxColumn();
            colStockQty.Name = "Stock";
            colStockQty.DataPropertyName = "Stock";
            colStockQty.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colStockQty.Visible = true;
            colStockQty.ReadOnly = true;
            colStockQty.DefaultCellStyle.Font = new Font("Tahoma", 8.25F);
            dtv.Columns.Add(colStockQty);
            #endregion
        }
        #endregion FormatGridDrugs

        private void FormatListAdvices()
        {
            listAdvicesCheck.Columns.Add(" ", 20, HorizontalAlignment.Center);
            listAdvicesCheck.Columns.Add("Advice ID", 0, HorizontalAlignment.Left);
            listAdvicesCheck.Columns.Add("Advices", 700, HorizontalAlignment.Left);
            listAdvicesCheck.Columns.Add("Additional Advice", 0, HorizontalAlignment.Left);
            listAdvicesCheck.Columns.Add("Flag", 0, HorizontalAlignment.Left);
            listAdvicesCheck.Columns.Add("Department", 0, HorizontalAlignment.Left);
            listAdvicesCheck.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
        }
        private void FormatListCheckedAdvices()
        {
            lvSelectedAdvice.CheckBoxes = false;
            lvSelectedAdvice.Columns.Add("Advice ID", 0, HorizontalAlignment.Left);
            lvSelectedAdvice.Columns.Add("Advices", 380, HorizontalAlignment.Left);
            lvSelectedAdvice.Columns.Add("Department", 0, HorizontalAlignment.Left);
            lvSelectedAdvice.Columns.Add("Additional Information", 200, HorizontalAlignment.Left);
        }

        private void LoadDepartment()
        {
            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(nwbnch.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Ancillary))), null);
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

        private void cboGroupID_Click(object sender, EventArgs e)
        {
            if (cboDepartment.Items.Count > 1 && cboGroupID.Items.Count > 0)
            {
                LoadGroupList(cboDepartment.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString());
            }
        }

        private void cboGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.Items.Count > 1 && cboGroupID.Items.Count > 0)
            {
                LoadGroupList(cboDepartment.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString());
            }
        }

        private void cboFeeCatID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chkSearchFromAllTest_CheckedChanged(sender, e);
        }
        private void LoadGroupList(string deptid, string groupid)
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

        private void chkSearchFromAllTest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchFromAllTest.Checked == true)
            {
                populateAllTest();
            }
            else
            {
                testChkBox.Items.Clear();
            }
        }
        private void populateAllTest()
        {
            testChkBox.Items.Clear();
            testsListAll = new List<TestFee>();
            testsListAll.AddRange(nwbnch.GetAllMappingTest("C", cboFeeCatID.SelectedValue.ToString()).ToList());
            foreach (TestFee tg in testsListAll)
            {
                ListViewItem itm = new ListViewItem(tg.TestSub.TestSubTitle);
                itm.SubItems.Add(tg.TestSub.TestSubID);
                itm.SubItems.Add(tg.TestSub.TestDepartment.DepartmentID);
                itm.SubItems.Add(tg.TestSub.TestGroup.GroupId);
                itm.SubItems.Add(tg.TestSub.TestMainID);
                itm.SubItems.Add(tg.TestSub.ReportGroup.ReportGroupID);
                itm.SubItems.Add(tg.TestSub.SpecimenCollectionRoom.RoomID);
                testChkBox.Items.Add(itm);
            }
            this.testChkBox.Focus();
        }

        private void lvGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchInvestigation.Text = string.Empty;
            testChkBox.Items.Clear();
            if (lvGroup.SelectedItems.Count > 0)
            {
                LoadTestList(cboDepartment.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), lvGroup.SelectedItems[0].SubItems[0].Text);
            }
        }
        private void LoadTestList(string deptid, string group, string main)
        {
            PopulateTests(deptid, group, main);
        }
        private void PopulateTests(string deptid, string group, string main)
        {
            testsList = new List<TestSub>();
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
            if (chkSearchFromAllTest.Checked == true)
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
            }
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
                ListViewItem itm = new ListViewItem(tg.TestSub.TestSubTitle);
                itm.SubItems.Add(tg.TestSub.TestSubID);
                itm.SubItems.Add(tg.TestSub.TestDepartment.DepartmentID);
                itm.SubItems.Add(tg.TestSub.TestGroup.GroupId);
                itm.SubItems.Add(tg.TestSub.TestMainID);
                itm.SubItems.Add(tg.TestSub.ReportGroup.ReportGroupID);
                itm.SubItems.Add(tg.TestSub.SpecimenCollectionRoom.RoomID);
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

        private void testChkBox_MouseDoubleClick(object sender, MouseEventArgs e)
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

                    //    if (testChkBox.Items[i].SubItems[10].Text != "" && testChkBox.Items[i].SubItems[10].Text != null)
                     ///   {
                        //    if (Convert.ToDouble(testChkBox.Items[i].SubItems[10].Text) > 0)
                         //   {
                                itm.SubItems.Add(testChkBox.Items[i].SubItems[0].Text);
                                itm.SubItems.Add(testChkBox.Items[i].SubItems[1].Text);
                                itm.SubItems.Add(testChkBox.Items[i].SubItems[2].Text);
                                itm.SubItems.Add(testChkBox.Items[i].SubItems[3].Text);
                                itm.SubItems.Add(testChkBox.Items[i].SubItems[4].Text);
                                itm.SubItems.Add(testChkBox.Items[i].SubItems[5].Text);
                                itm.SubItems.Add(testChkBox.Items[i].SubItems[6].Text);
                                lvAddItems.Items.Add(itm);
                         //   }
                       // }
                    }
                }
            }
            txtSearchInvestigation.Text = "";
        }

        private void btnAddTestItems_Click(object sender, EventArgs e)
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

                     //   if (testChkBox.Items[i].SubItems[10].Text != "" && testChkBox.Items[i].SubItems[10].Text != null)
                      //  {
                          //  if (Convert.ToDouble(testChkBox.Items[i].SubItems[10].Text) > 0)
                          //  {
                                itm.SubItems.Add(testChkBox.Items[i].SubItems[0].Text);
                                itm.SubItems.Add(testChkBox.Items[i].SubItems[1].Text);
                                itm.SubItems.Add(testChkBox.Items[i].SubItems[2].Text);
                                itm.SubItems.Add(testChkBox.Items[i].SubItems[3].Text);
                                itm.SubItems.Add(testChkBox.Items[i].SubItems[4].Text);
                                itm.SubItems.Add(testChkBox.Items[i].SubItems[5].Text);
                                itm.SubItems.Add(testChkBox.Items[i].SubItems[6].Text);
                                lvAddItems.Items.Add(itm);
                          //  }
                      //  }
                    }
                }
            }
            txtSearchInvestigation.Text = "";

        }

        private void btnRemoveTestItems_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in lvAddItems.SelectedItems)
            {
                lvAddItems.Items.Remove(eachItem);
            }
        }

        private void txtGenericName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.dgvMedicine.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (txtGenericName.Text.Length > 1)
                {
                    List<DrugDose> oMedicines = new List<DrugDose>();
                    drugsList = new List<DrugDose>();
                    drugsList.AddRange(nwbnch.GetDrugDoseListByGroupName(this.patAge, txtGenericName.Text).ToList<DrugDose>());

                    if (drugsList.Count > 0)
                    {
                        dgvMedicine.Visible = true;
                        dgvMedicine.DataSource = drugsList.Select(data => new
                        {
                            DRUGID = data.DrugMaster.ID,
                            DRUGNAME = data.DrugMaster.Name,
                            COMPANYID = data.DrugMaster.DrugCompany.ID,
                            COMPANYNAME = data.DrugMaster.DrugCompany.Name,
                            GROUPID = data.DrugMaster.DrugGroup.ID,
                            GROUPNAME = data.DrugMaster.DrugGroup.Name,
                            TYPEID = data.DrugMaster.DrugPackType.ID,
                            PACKNAME = data.DrugMaster.DrugPackType.Name,
                            UNITID = data.DrugMaster.DrugUnit.ID,
                            UNITNAME = data.DrugMaster.DrugUnit.Name,
                            DOSEDRUG = data.DoseStr,
                            ROUTEID = data.RouteID,
                            BEFOREAFTERMEAL = data.BeforeAfterMeal,
                            MEALTIMEGAP = data.MealTimeGap,
                            MEALNAME = data.MealName,
                            DURATIONPERIOD = data.DurationPeriod,
                            DURATIONIND = data.DurationIndicator,
                            CONSUMPTIONFORM = data.ConsumptionForm.ID,
                            Stock = data.DrugMaster.StockQty
                        }).ToList();
                        this.dgvMedicine.Focus();
                    }
                }
            }
        }
        private void txtDrugID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.dgvMedicine.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDrugID.Text.Length > 1)
                {
                    LoadDataMed();
                }
            }
        }
        private void LoadDataMed()
        {
            PopulateDataTodgvMedicine(dgvMedicine, txtDrugID.Text);
        }
        private void PopulateDataTodgvMedicine(DataGridView dgvMedicine, string drugsTitle)
        {
            List<DrugDose> oMedicines = new List<DrugDose>();
            drugsList = new List<DrugDose>();
            drugsList.AddRange(nwbnch.GetDrugDoseListByDrugName(this.patAge, txtDrugID.Text).ToList<DrugDose>());
            if (drugsList.Count > 0)
            {
                dgvMedicine.Visible = true;
                dgvMedicine.DataSource = drugsList.Select(data => new
                {
                    DRUGID = data.DrugMaster.ID,
                    DRUGNAME = data.DrugMaster.Name,
                    COMPANYID = data.DrugMaster.DrugCompany.ID,
                    COMPANYNAME = data.DrugMaster.DrugCompany.Name,
                    GROUPID = data.DrugMaster.DrugGroup.ID,
                    GROUPNAME = data.DrugMaster.DrugGroup.Name,
                    TYPEID = data.DrugMaster.DrugPackType.ID,
                    PACKNAME = data.DrugMaster.DrugPackType.Name,
                    UNITID = data.DrugMaster.DrugUnit.ID,
                    UNITNAME = data.DrugMaster.DrugUnit.Name,
                    DOSEDRUG = data.DoseStr,
                    ROUTEID = data.RouteID,
                    BEFOREAFTERMEAL = data.BeforeAfterMeal,
                    MEALTIMEGAP = data.MealTimeGap,
                    MEALNAME = data.MealName,
                    DURATIONPERIOD = data.DurationPeriod,
                    DURATIONIND = data.DurationIndicator,
                    CONSUMPTIONFORM = data.ConsumptionForm.ID,
                    Stock = data.DrugMaster.StockQty
                }).ToList();

                this.dgvMedicine.Focus();
            }
        }

        private void dgvMedicine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (dgvMedicine.Rows.Count > 0)
                {
                    lbTDrugs.Text = "";
                    populateDataFromGrid();
                    TotalDose = 0;
                    checkDoseTotal();
                    checkDuration();
                    double Final = TotalDose * TotalDuration;
                    lbTDrugs.Text = Convert.ToString(Final);
                    lbTDrugs.Visible = true;
                    lbl1.Visible = true;
                }
            }
        }
        private void checkDoseTotal()
        {
            int totalPlus = 0;
            if (txtDosages.Text != "" && txtDosages.Text.Contains("0+0+0") == false)
            {
                string Dose = txtDosages.Text;
                Char[] letters = Dose.ToCharArray();
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i].ToString() == "+")
                    {
                        totalPlus = totalPlus + 1;
                    }
                }
                TotalDose = 0;
                for (int i = 0; i <= totalPlus; i++)
                {

                    if (CheckDosePattern(txtDosages.Text.Split('+')[i]))
                    {
                        double TDose = Calculatetotaldose(txtDosages.Text.Split('+')[i]);
                        TotalDose = TotalDose + TDose;
                    }
                }
            }
        }
        private bool CheckDosePattern(string fraction)
        {
            for (int i = 0; i < fraction.Length; i++)
            {
                if (fraction[i].ToString() == ".")
                {
                    for (int j = i + 1; j < fraction.Length; j++)
                    {
                        if (fraction[i].ToString() == fraction[j].ToString() || fraction == "")
                        {
                            MessageBox.Show("Invalid Dose Pattern!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtDosages.Focus();
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        double Calculatetotaldose(string fraction)
        {
            double result;
            if (double.TryParse(fraction, out result))
            {
                return result;
            }
            else
            {
                return Convert.ToDouble(fraction);
            }
        }
        private void checkDuration()
        {
            if (cbContinue.Checked != true)
            {
                if (txtDurationPeriod.Text == "")
                {
                    MessageBox.Show("Provide Duration Period", Utility.MessageCaptionMsg,
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtDurationPeriod.Text != "")
                {
                    double Duration = Calculatetotaldose(txtDurationPeriod.Text);
                    if (rdoDay.Checked == true)
                    {
                        TotalDuration = Convert.ToDouble(Duration) * 1;
                    }
                    if (rdoWeek.Checked == true)
                    {
                        TotalDuration = Convert.ToDouble(Duration) * 7;
                    }
                    if (rdoMonth.Checked == true)
                    {
                        TotalDuration = Convert.ToDouble(Duration) * 30;
                    }
                    if (rdoYear.Checked == true)
                    {
                        TotalDuration = Convert.ToDouble(Duration) * 365;
                    }
                }
            }
        }
        private void dgvMedicine_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            populateDataFromGrid();
        }
        private void populateDataFromGrid()
        {
            int position = 0;
            if (dgvMedicine.RowCount == 0)
            {
                txtDrugMain.Text = "";
                hideGrid();
                return;
            }
            position = dgvMedicine.CurrentRow.Index;
            txtGroup.Text = dgvMedicine.Rows[position].Cells["GROUPID"].Value.ToString();
            txtUnitID.Text = dgvMedicine.Rows[position].Cells["UNITID"].Value.ToString();
            txtPackID.Text = dgvMedicine.Rows[position].Cells["TYPEID"].Value.ToString();
            txtDrugID.Text = dgvMedicine.Rows[position].Cells["DRUGID"].Value.ToString();
            txtDrugMain.Text = dgvMedicine.Rows[position].Cells["Drug Name"].Value.ToString();
            txtCompanyName.Text = dgvMedicine.Rows[position].Cells["COMPANYID"].Value.ToString();
            txtPackName.Text = dgvMedicine.Rows[position].Cells["UnitPack"].Value.ToString();
            txtUnitName.Text = dgvMedicine.Rows[position].Cells["Unit"].Value.ToString();
            txtRouteID.Text = dgvMedicine.Rows[position].Cells["ROUTEID"].Value.ToString();

            cboConsumptionForm.SelectedValue = dgvMedicine.Rows[position].Cells["CONSUMPTIONFORM"].Value.ToString();

            LoadChekBoxDrugDose(dgvMedicine.Rows[position].Cells["DOSEDRUG"].Value.ToString());
            LoadChekBoxDuration(dgvMedicine.Rows[position].Cells["DurationPeriod"].Value.ToString(),
                                dgvMedicine.Rows[position].Cells["DurationInd"].Value.ToString());
            LoadChekBoxMeal(dgvMedicine.Rows[position].Cells["MEALNAME"].Value.ToString(),
                            dgvMedicine.Rows[position].Cells["MEALTIMEGAP"].Value.ToString(),
                            dgvMedicine.Rows[position].Cells["BEFOREAFTERMEAL"].Value.ToString());
            txtStock.Text = dgvMedicine.Rows[position].Cells["Stock"].Value.ToString();
            hideGrid();
            txtDurationPeriod.Focus();
        }

        private void LoadChekBoxDrugDose(string DoseCheckboxMake)
        {
            if (DoseCheckboxMake != "" && DoseCheckboxMake != "0")
            {
                string doseBF = "";
                string doseLunch = "";
                string doseDinner = "";

                doseBF = DoseCheckboxMake.Split('+')[0];
                doseLunch = DoseCheckboxMake.Split('+')[1];
                doseDinner = DoseCheckboxMake.Split('+')[2];
                if (doseBF == "0")
                {
                    cbBF.Checked = false;
                }
                if (doseBF != "0")
                {
                    cbBF.Checked = true;
                }
                if (doseLunch == "0")
                {
                    cbLunch.Checked = false;
                }
                if (doseLunch != "0")
                {
                    cbLunch.Checked = true;
                }
                if (doseDinner == "0")
                {
                    cbDinner.Checked = false;
                }
                if (doseDinner != "0")
                {
                    cbDinner.Checked = true;
                }
                txtDosages.Text = DoseCheckboxMake;
            }
        }
        private void LoadChekBoxDuration(string DurationTextValue, string DurationRadioValue)
        {
            if (cbContinue.Checked == false)
            {
                if (DurationTextValue != "")
                {
                    txtDurationPeriod.Text = DurationTextValue;
                    if (DurationRadioValue.ToUpper() == "D")
                    {
                        rdoDay.Checked = true;
                        rdoMonth.Checked = false;
                        rdoYear.Checked = false;
                        rdoWeek.Checked = false;
                        DurationIndGrid = "Day";
                    }
                    if (DurationRadioValue.ToUpper() == "W")
                    {
                        rdoDay.Checked = false;
                        rdoMonth.Checked = false;
                        rdoYear.Checked = false;
                        rdoWeek.Checked = true;
                        DurationIndGrid = "Week";
                    }
                    if (DurationRadioValue.ToUpper() == "M")
                    {
                        rdoDay.Checked = false;
                        rdoMonth.Checked = true;
                        rdoYear.Checked = false;
                        rdoWeek.Checked = false;
                        DurationIndGrid = "Month";
                    }
                    if (DurationRadioValue.ToUpper() == "Y")
                    {
                        rdoDay.Checked = false;
                        rdoMonth.Checked = false;
                        rdoYear.Checked = true;
                        rdoWeek.Checked = false;
                        DurationIndGrid = "Year";
                    }
                }
            }
        }
        private void LoadChekBoxMeal(string MealName, string MealTGap, string MealBA)
        {
            if (MealName != "")
            {
                if (MealName.ToUpper() == "B")
                {
                    rdoBreakFast.Checked = true;
                    rdoLunch.Checked = false;
                    rdoDinner.Checked = false;
                    rdoMeal.Checked = false;
                    MealNameGrid = "BreakFast";
                }
                if (MealName.ToUpper() == "L")
                {
                    rdoBreakFast.Checked = false;
                    rdoLunch.Checked = true;
                    rdoDinner.Checked = false;
                    rdoMeal.Checked = false;
                    MealNameGrid = "Lunch";
                }
                if (MealName.ToUpper() == "D")
                {
                    rdoBreakFast.Checked = false;
                    rdoLunch.Checked = false;
                    rdoDinner.Checked = true;
                    rdoMeal.Checked = false;
                    MealNameGrid = "Dinner";
                }
                if (MealName.ToUpper() == "M")
                {
                    rdoBreakFast.Checked = false;
                    rdoLunch.Checked = false;
                    rdoDinner.Checked = false;
                    rdoMeal.Checked = true;
                    MealNameGrid = "Meal";
                }

                if (MealNameGrid != "")
                {
                    if (MealBA.ToUpper() == "B")
                    {
                        rdoBefore.Checked = true;
                        rdoAfter.Checked = false;
                        rdoDuring.Checked = false;
                    }
                    if (MealBA.ToUpper() == "A")
                    {
                        rdoBefore.Checked = false;
                        rdoAfter.Checked = true;
                        rdoDuring.Checked = false;
                    }
                    if (MealBA.ToUpper() == "D")
                    {
                        rdoBefore.Checked = false;
                        rdoAfter.Checked = false;
                        rdoDuring.Checked = true;
                    }
                    if (MealTGap == "15")
                    {
                        rdo15m.Checked = true;
                        rdo30min.Checked = false;
                        rdo45min.Checked = false;
                        rdo1hour.Checked = false;
                        rdo15hour.Checked = false;
                        rdo2Hour.Checked = false;
                        rdoNA.Checked = false;

                    }
                    if (MealTGap == "30")
                    {
                        rdo15m.Checked = false;
                        rdo30min.Checked = true;
                        rdo45min.Checked = false;
                        rdo1hour.Checked = false;
                        rdo15hour.Checked = false;
                        rdo2Hour.Checked = false;
                        rdoNA.Checked = false;

                    }
                    if (MealTGap == "45")
                    {
                        rdo15m.Checked = false;
                        rdo30min.Checked = false;
                        rdo45min.Checked = true;
                        rdo1hour.Checked = false;
                        rdo15hour.Checked = false;
                        rdo2Hour.Checked = false;
                        rdoNA.Checked = false;

                    }
                    if (MealTGap == "60")
                    {
                        rdo15m.Checked = false;
                        rdo30min.Checked = false;
                        rdo45min.Checked = false;
                        rdo1hour.Checked = true;
                        rdo15hour.Checked = false;
                        rdo2Hour.Checked = false;
                        rdoNA.Checked = false;

                    }
                    if (MealTGap == "90")
                    {
                        rdo15m.Checked = false;
                        rdo30min.Checked = false;
                        rdo45min.Checked = false;
                        rdo1hour.Checked = false;
                        rdo15hour.Checked = true;
                        rdo2Hour.Checked = false;
                        rdoNA.Checked = false;
                    }
                    if (MealTGap == "120")
                    {
                        rdo15m.Checked = false;
                        rdo30min.Checked = false;
                        rdo45min.Checked = false;
                        rdo1hour.Checked = false;
                        rdo15hour.Checked = false;
                        rdo2Hour.Checked = true;
                        rdoNA.Checked = false;
                    }
                    if (MealTGap == "")
                    {
                        rdo15m.Checked = false;
                        rdo30min.Checked = false;
                        rdo45min.Checked = false;
                        rdo1hour.Checked = false;
                        rdo15hour.Checked = false;
                        rdo2Hour.Checked = false;
                        rdoNA.Checked = true;
                    }
                }
            }
        }
        private void hideGrid()
        {
            dgvMedicine.ClearSelection();
            dgvMedicine.DataSource = null;
            dgvMedicine.Visible = false;
        }

        private void chkDosagesNDurationNA_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDosagesNDurationNA.Checked == true)
            {
                gbDosages.Enabled = false;
                gbDuration.Enabled = false;
            }
            if (chkDosagesNDurationNA.Checked == false)
            {
                gbDosages.Enabled = true;
                gbDuration.Enabled = true;
            }
        }

        private void btnIncBF_Click(object sender, EventArgs e)
        {
            double BFinc = 0;
            double Binc = 0;
            if (txtDosages.Text != "")
            {
                BFinc = Convert.ToDouble(txtDosages.Text.Split('+')[0]);
                string Blinc = txtDosages.Text.Split('+')[1];
                string Bdinc = txtDosages.Text.Split('+')[2];
                Binc = Convert.ToDouble(BFinc) + 1;
                txtDosages.Text = Convert.ToString(Binc) + "+" + Blinc + "+" + Bdinc;
                CalculateTotalDose();
            }
        }
        private void CalculateTotalDose()
        {
            if (chkDosagesNDurationNA.Checked == false)
            {
                if (txtDurationPeriod.Text != "0")
                {
                    TotalDuration = 0;
                    if (cbContinue.Checked == false && cboConsumptionForm.Text == "pcs")
                    {
                        checkDoseTotal();
                        if (CheckDurationText())
                        {
                            checkDuration();
                            double Final = TotalDose * TotalDuration;
                            lbTDrugs.Text = Convert.ToString(Final);
                            lbTDrugs.Visible = true;
                            lbl1.Visible = true;
                        }
                    }
                    if (cbContinue.Checked == false && cboConsumptionForm.Text != "pcs")
                    {
                        lbTDrugs.Text = "1";
                        lbTDrugs.Visible = true;
                        lbl1.Visible = true;
                    }
                    if (cbContinue.Checked == true)
                    {
                        lbTDrugs.Text = "0";
                        lbTDrugs.Visible = false;
                        lbl1.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please provide Valid Duration Period", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private bool CheckDurationText()
        {
            if (txtDurationPeriod.Text == "")
            {
                txtDurationPeriod.Focus();
                return false;
            }
            return true;
        }

        private void btnIncL_Click(object sender, EventArgs e)
        {
            double Blinc = 0;
            double Binc = 0;
            if (txtDosages.Text != "")
            {
                string BFinc = txtDosages.Text.Split('+')[0];
                Blinc = Convert.ToDouble(txtDosages.Text.Split('+')[1]);
                string Bdinc = txtDosages.Text.Split('+')[2];
                Binc = Convert.ToDouble(Blinc) + 1;
                txtDosages.Text = BFinc + "+" + Binc + "+" + Bdinc;
                CalculateTotalDose();
            }
        }

        private void btnIncD_Click(object sender, EventArgs e)
        {
            double Bdinc = 0;
            double Binc = 0;
            if (txtDosages.Text != "")
            {
                string BFinc = txtDosages.Text.Split('+')[0];
                string Blinc = txtDosages.Text.Split('+')[1];
                Bdinc = Convert.ToDouble(txtDosages.Text.Split('+')[2]);
                Binc = Convert.ToDouble(Bdinc) + 1;
                txtDosages.Text = BFinc + "+" + Blinc + "+" + Convert.ToString(Binc);
                CalculateTotalDose();
            }
        }

        private void cbBF_CheckedChanged(object sender, EventArgs e)
        {
            MakestringCBCombination();
        }

        private void cbLunch_CheckedChanged(object sender, EventArgs e)
        {
            MakestringCBCombination();
        }

        private void cbDinner_CheckedChanged(object sender, EventArgs e)
        {
            MakestringCBCombination();
        }
        private void MakestringCBCombination()
        {
            if (cbBF.Checked == true)
            {
                cBF = "1";
            }
            if (cbBF.Checked == false)
            {
                cBF = "0";
            }
            if (cbLunch.Checked == true)
            {
                cLunch = "1";
            }
            if (cbLunch.Checked == false)
            {
                cLunch = "0";
            }
            if (cbDinner.Checked == true)
            {
                cDinner = "1";
            }
            if (cbDinner.Checked == false)
            {
                cDinner = "0";
            }

            cCombination = cBF + "+" + cLunch + "+" + cDinner;
            if (cbBF.Checked == false && cbLunch.Checked == false && cbDinner.Checked == false) //["cbBF.Checked == false && cbLunch.Checked == false && cbDinner.Checked == false" added on 3rd february 2015]
            {
                txtDosages.Text = cCombination;
                MessageBox.Show("please provide the doses", Utility.MessageCaptionMsg,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDosages.Focus();
            }
            else
            {
                txtDosages.Text = cCombination;
            }
        }

        private void txtDosages_Leave(object sender, EventArgs e)
        {
            if (txtDrugID.Text != "")
            {
                if (Utility.IsDosePatternValid(txtDosages.Text) == false)
                {
                    MessageBox.Show("Invalid Dose Pattern", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDosages.Focus();
                }
            }
        }

        private void txtDosages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDrugMain.Text != "")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void cboConsumptionForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDrugMain.Text != "")
            {
                CalculateTotalDose();
            }
        }

        private void cbContinue_CheckedChanged(object sender, EventArgs e)
        {
            HideUnhideDuration();
        }
        private void HideUnhideDuration()
        {
            if (cbContinue.Checked == true)
            {
                txtDurationPeriod.Visible = false;
                rdoDay.Visible = false;
                rdoMonth.Visible = false;
                rdoYear.Visible = false;
                rdoWeek.Visible = false;

                rdoDay.Checked = false;
                rdoMonth.Checked = false;
                rdoYear.Checked = false;
                rdoWeek.Checked = false;

                txtDurationPeriod.Text = "";
                lbl1.Visible = false;
                lbTDrugs.Visible = false;
                lbTDrugs.Text = "0";
            }
            if (cbContinue.Checked == false)
            {
                txtDurationPeriod.Visible = true;
                rdoDay.Visible = true;
                rdoMonth.Visible = true;
                rdoYear.Visible = true;
                rdoWeek.Visible = true;
                lbl1.Visible = true;
                lbTDrugs.Visible = true;
            }
        }

        private void txtDurationPeriod_TextChanged(object sender, EventArgs e)
        {
            if (chkDosagesNDurationNA.Checked == false)
            {
                if (txtDrugMain.Text != "")
                {
                    CalculateTotalDose();
                }
            }
        }

        private void txtDurationPeriod_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtDrugMain.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtDurationPeriod.Select();
                }
            }
        }

        private void txtDurationPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDrugMain.Text != "")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtDurationPeriod_Leave(object sender, EventArgs e)
        {
            if (txtDrugMain.Text != "")
            {
                CalculateTotalDose();
            }
        }

        private void rdoDay_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDurationPeriod.Text != "" && txtDurationPeriod.Text != "0")
            {
                CalculateTotalDose();
            }
            else
            {
                txtDurationPeriod.Select();
            }
        }

        private void rdoWeek_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDurationPeriod.Text != "" && txtDurationPeriod.Text != "0")
            {
                CalculateTotalDose();
            }
            else
            {
                txtDurationPeriod.Select();
            }
        }

        private void rdoMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDurationPeriod.Text != "" && txtDurationPeriod.Text != "0")
            {
                CalculateTotalDose();
            }
            else
            {
                txtDurationPeriod.Select();
            }

        }

        private void rdoYear_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDurationPeriod.Text != "" && txtDurationPeriod.Text != "0")
            {
                CalculateTotalDose();
            }
            else
            {
                txtDurationPeriod.Select();
            }
        }

        private void chkMealNA_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMealNA.Checked == true)
            {
                gbBeforeAfter.Enabled = false;
                gbMealName.Enabled = false;
                gbMealTime.Enabled = false;

                rdoBefore.Checked = false;
                rdoAfter.Checked = false;
                rdoDuring.Checked = false;

                rdoMeal.Checked = false;
                rdoBreakFast.Checked = false;
                rdoLunch.Checked = false;
                rdoDinner.Checked = false;

                rdo15m.Checked = false;
                rdo30min.Checked = false;
                rdo45min.Checked = false;
                rdo1hour.Checked = false;
                rdo15hour.Checked = false;
                rdo2Hour.Checked = false;

                rdoNA.Checked = false;
            }
            if (chkMealNA.Checked == false)
            {
                gbBeforeAfter.Enabled = true;
                gbMealName.Enabled = true;
                gbMealTime.Enabled = true;

                rdoAfter.Checked = true;
                rdoMeal.Checked = true;
                rdoNA.Checked = true;
            }
        }

        private void rdoBefore_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalDose();
        }

        private void rdoAfter_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalDose();
        }

        private void rdoDuring_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalDose();
        }

        private void rdoBreakFast_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalDose();
        }

        private void rdoLunch_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalDose();
        }

        private void rdoDinner_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalDose();
        }

        private void rdoMeal_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalDose();
        }

        private void rdo15m_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalDose();
        }

        private void rdo30min_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalDose();
        }

        private void rdo45min_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalDose();
        }

        private void rdo2Hour_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalDose();
        }

        private void rdo15hour_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalDose();
        }

        private void rdo1hour_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalDose();
        }

        private void rdoNA_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalDose();
        }

        private void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDrugID.Text != "" && txtDrugMain.Text != "" && txtDrugID.Text != null && txtDrugMain.Text != null)
            {
                if (chkDosagesNDurationNA.Checked == false)
                {
                    if (!Utility.IsDosePatternValid(txtDosages.Text))
                    {
                        return;
                    }
                }

                ChekDurationAdd();
                ChekMealAdd();
                if (CheckDurationCondition())
                {
                    if (chkDosagesNDurationNA.Checked == false)
                    {
                        if (cbContinue.Checked == false && cboConsumptionForm.Text == "pcs")
                        {
                            lbTDrugs.Text = "";
                            checkDoseTotal();
                            checkDuration();
                            double Final = TotalDose * TotalDuration;
                            lbTDrugs.Text = Convert.ToString(Final);
                        }
                        if (cbContinue.Checked == false && cboConsumptionForm.Text != "pcs")
                        {
                            lbTDrugs.Text = "";
                            //checkDoseTotal();
                            //checkDuration();
                            double Final = 1;
                            lbTDrugs.Text = Convert.ToString(Final);
                        }
                        if (cbContinue.Checked == true)
                        {

                        }
                    }

                    MakeGridObject();
                    LoadDrugsGridObject();
                    for (int i = 0; i < lstMedicalPres.Items.Count; i++)
                    {
                        lstMedicalPres.Items[i].Checked = true;
                    }
                    this.lstMedicalPres.View = View.Details;
                    oDrugDoses.Clear();
                    txtGenericName.Text = "";
                    txtDrugID.Text = string.Empty;
                    txtDrugMain.Text = string.Empty;
                    txtDosages.Text = string.Empty;
                    txtRemarks.Text = string.Empty;
                    cbContinue.Checked = false;

                    lbTDrugs.Text = string.Empty;
                    txtDurationPeriod.Text = string.Empty;

                    txtDrugID.Select();
                }
            }
            else
            {
                txtDrugID.Select();
            }
        }

        private void ChekDurationAdd()
        {
            DurationIndGrid = "";
            if (rdoDay.Checked == true)
            {
                DurationIndGrid = "Day";
            }
            if (rdoWeek.Checked == true)
            {
                DurationIndGrid = "Week";
            }
            if (rdoMonth.Checked == true)
            {
                DurationIndGrid = "Month";
            }
            if (rdoYear.Checked == true)
            {
                DurationIndGrid = "Year";
            }
        }

        private void ChekMealAdd()
        {
            MealNameGrid = "";
            MealBorAGrid = "";
            MealTGapGrid = "";

            if (rdoBreakFast.Checked == true)
            {
                MealNameGrid = "BreakFast";
            }
            if (rdoLunch.Checked == true)
            {
                MealNameGrid = "Lunch";
            }
            if (rdoDinner.Checked == true)
            {
                MealNameGrid = "Dinner";
            }

            if (rdoMeal.Checked == true)
            {
                MealNameGrid = "Meal";
            }

            if (rdoBefore.Checked == true)
            {
                MealBorAGrid = "Before";
            }
            if (rdoAfter.Checked == true)
            {
                MealBorAGrid = "After";
            }
            if (rdoDuring.Checked == true)
            {
                MealBorAGrid = "During";
            }

            if (chkMealNA.Checked == true)
            {
                MealBorAGrid = "";
                MealNameGrid = "";
                MealTGapGrid = "";
            }

            if (rdo15m.Checked == true)
            {
                MealTGapGrid = "15 minutes";
            }

            if (rdo30min.Checked == true)
            {
                MealTGapGrid = "30 minutes";
            }

            if (rdo45min.Checked == true)
            {
                MealTGapGrid = "45 minutes";
            }

            if (rdo1hour.Checked == true)
            {
                MealTGapGrid = "60 minutes";
            }
            if (rdo15hour.Checked == true)
            {
                MealTGapGrid = "90 minutes";
            }
            if (rdo15hour.Checked == true)
            {
                MealTGapGrid = "120 minutes";
            }
            if (rdoNA.Checked == true)
            {
                MealTGapGrid = "";
            }
        }
        private bool CheckDurationCondition()
        {
            if (chkDosagesNDurationNA.Checked == false)
            {
                if (cbContinue.Checked == false)
                {
                    if (txtDurationPeriod.Text == "" && rdoDay.Checked == false && rdoWeek.Checked == false && rdoMonth.Checked == false && rdoYear.Checked == false)
                    {
                        MessageBox.Show("Invalid Duration Condition", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDurationPeriod.Focus();
                        return false;
                    }
                    if (txtDurationPeriod.Text != "" && rdoDay.Checked == false && rdoWeek.Checked == false && rdoMonth.Checked == false && rdoYear.Checked == false)
                    {
                        MessageBox.Show("Invalid Duration Condition, Provide Duration Idicator", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDurationPeriod.Focus();
                        return false;
                    }
                    if (txtDurationPeriod.Text == "" && (rdoDay.Checked == true || rdoWeek.Checked == true || rdoMonth.Checked == true || rdoYear.Checked == true))
                    {
                        MessageBox.Show("Invalid Duration Condition, Provide Duration Idicator", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDurationPeriod.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        private void MakeGridObject()
        {
            #region DosageDurationNA True
            if (chkDosagesNDurationNA.Checked == true)
            {
                string MealConcat = "";
                if (!AddPreRequisit() || !MedicineUniqueCheck())
                {
                    return;
                }
                DrugDose oDrugDose = new DrugDose();
                DrugMaster oDrugMaster = new DrugMaster();

                DrugGroup oDrugGroup = new DrugGroup();
                oDrugGroup.ID = txtGroup.Text;
                oDrugMaster.DrugGroup = oDrugGroup;

                oDrugMaster.Name = txtDrugMain.Text;
                oDrugMaster.ID = txtDrugID.Text;

                DrugUnit oDrugUnit = new DrugUnit();
                oDrugUnit.ID = txtUnitID.Text;
                oDrugUnit.Name = txtUnitName.Text;
                oDrugMaster.DrugUnit = oDrugUnit;

                DrugPackType oDrugPackType = new DrugPackType();
                oDrugPackType.ID = txtPackID.Text;
                oDrugPackType.Name = txtPackName.Text;

                DrugCompany oDrugCompany = new DrugCompany();
                oDrugCompany.ID = txtCompanyName.Text;
                oDrugMaster.DrugCompany = oDrugCompany;

                oDrugDose.RouteID = txtRouteID.Text;
                oDrugDose.DoseStr = "";

                ConsumptionForm oConsumptionForm = new ConsumptionForm();
                oConsumptionForm.Name = "";

                #region Meal
                if (chkMealNA.Checked == false)
                {
                    if (MealNameGrid == "" && MealBorAGrid != "")
                    {
                        MessageBox.Show("Please Provide Meal Name", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (MealBorAGrid == "" && MealTGapGrid != "")
                    {
                        MessageBox.Show("Please Provide Meal Before or After", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (MealNameGrid != "")
                    {
                        oDrugDose.MealName = MealNameGrid;
                        oDrugDose.MealID = Convert.ToChar(oDrugDose.MealName.Substring(0, 1));

                        if (MealBorAGrid != "")
                        {
                            oDrugDose.B_A_MealName = MealBorAGrid;
                            oDrugDose.BeforeAfterMeal = Convert.ToChar(oDrugDose.B_A_MealName.Substring(0, 1));
                        }
                        if (MealTGapGrid != "")
                        {
                            oDrugDose.MealTimeGap = MealTGapGrid;
                            oDrugDose.MealTimeGapID = oDrugDose.MealTimeGap.Substring(0, 2);
                        }
                        if (MealTGapGrid == "")
                        {
                            oDrugDose.MealTimeGap = "";
                        }
                    }
                }
                if (chkMealNA.Checked == true)
                {
                    oDrugDose.MealName = "";
                    oDrugDose.MealID = Convert.ToChar("N");
                    oDrugDose.B_A_MealName = "";
                    oDrugDose.BeforeAfterMeal = Convert.ToChar("N");
                    oDrugDose.MealTimeGap = "";
                    oDrugDose.MealTimeGapID = "0";
                }

                if (chkMealNA.Checked == false)
                {
                    if (oDrugDose.MealName != "") //breakfast
                    {
                        if (oDrugDose.MealTimeGapID != "0") //min or M
                        {
                            if (oDrugDose.MealTimeGap == "") //30
                            {
                                MealConcat = oDrugDose.B_A_MealName + "  " + oDrugDose.MealTimeGap +
                                                            oDrugDose.MealName + " ";
                            }
                            else
                            {
                                MealConcat = oDrugDose.B_A_MealName + "  " + oDrugDose.MealTimeGap + " " + " of " +
                                     oDrugDose.MealName + " ";
                            }
                        }
                        if (oDrugDose.MealTimeGapID == "0")
                        {
                            MealConcat = "";
                        }
                    }
                }
                if (chkMealNA.Checked == true)
                {
                    MealConcat = oDrugDose.B_A_MealName + "" + oDrugDose.MealTimeGap +
                                                            oDrugDose.MealName + "";
                }
                #endregion

                #region duration
                DurationIndGrid = "N";
                oDrugDose.Dur_Ind_Name = DurationIndGrid;
                oDrugDose.DurationContinue = "N";
                oDrugDose.DurationIndicator = Convert.ToChar("N");
                oDrugDose.DurationPeriod = "-1";

                #endregion duration

                if (oDrugDose.DurationContinue == "0")
                {
                    oDrugMaster.PropertiesString = oDrugPackType.Name + ":" + oDrugMaster.Name + "; " + "(" +
                                          oDrugDose.DoseStr + ")" + oConsumptionForm.Name + " " + MealConcat + " for " + oDrugDose.DurationPeriod + " " + oDrugDose.Dur_Ind_Name;
                }
                if (oDrugDose.DurationContinue != "0")
                {
                    oDrugMaster.PropertiesString = oDrugPackType.Name + ":" + oDrugMaster.Name + "; " +
                                          oDrugDose.DoseStr + oConsumptionForm.Name + " " + MealConcat;
                }
                oDrugMaster.Remarks = txtRemarks.Text;
                oDrugMaster.CalculatedQty = float.Parse("0");
                oDrugDose.ConsumptionForm = oConsumptionForm;
                oDrugMaster.DrugPackType = oDrugPackType;
                oDrugDose.DrugMaster = oDrugMaster;
                oDrugDoses.Add(oDrugDose);

            }
            #endregion DosageDurationNA True


            #region DosageDurationNA False
            if (chkDosagesNDurationNA.Checked == false)
            {
                string MealConcat = "";
                if (!AddPreRequisit() || !DurationCondition() || !MedicineUniqueCheck())
                {
                    return;
                }
                DrugDose oDrugDose = new DrugDose();
                DrugMaster oDrugMaster = new DrugMaster();

                DrugGroup oDrugGroup = new DrugGroup();
                oDrugGroup.ID = txtGroup.Text;
                oDrugMaster.DrugGroup = oDrugGroup;

                oDrugMaster.Name = txtDrugMain.Text;
                oDrugMaster.ID = txtDrugID.Text;

                DrugUnit oDrugUnit = new DrugUnit();
                oDrugUnit.ID = txtUnitID.Text;
                oDrugUnit.Name = txtUnitName.Text;
                oDrugMaster.DrugUnit = oDrugUnit;

                DrugPackType oDrugPackType = new DrugPackType();
                oDrugPackType.ID = txtPackID.Text;
                oDrugPackType.Name = txtPackName.Text;
                // oDrugMaster.DrugPackType = oDrugPackType;

                DrugCompany oDrugCompany = new DrugCompany();
                oDrugCompany.ID = txtCompanyName.Text;
                oDrugMaster.DrugCompany = oDrugCompany;

                oDrugDose.RouteID = txtRouteID.Text;
                oDrugDose.DoseStr = txtDosages.Text;

                ConsumptionForm oConsumptionForm = new ConsumptionForm();
                oConsumptionForm.Name = cboConsumptionForm.Text;

                #region Meal
                if (chkMealNA.Checked == false)
                {
                    if (MealNameGrid == "" && MealBorAGrid != "")
                    {
                        MessageBox.Show("Please Provide Meal Name", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (MealBorAGrid == "" && MealTGapGrid != "")
                    {
                        MessageBox.Show("Please Provide Meal Before or After", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (MealNameGrid != "")
                    {
                        oDrugDose.MealName = MealNameGrid;
                        oDrugDose.MealID = Convert.ToChar(oDrugDose.MealName.Substring(0, 1));

                        if (MealBorAGrid != "")
                        {
                            oDrugDose.B_A_MealName = MealBorAGrid;
                            oDrugDose.BeforeAfterMeal = Convert.ToChar(oDrugDose.B_A_MealName.Substring(0, 1));
                        }
                        if (MealTGapGrid != "")
                        {
                            oDrugDose.MealTimeGap = MealTGapGrid;
                            oDrugDose.MealTimeGapID = oDrugDose.MealTimeGap.Substring(0, 2);
                        }
                        if (MealTGapGrid == "")
                        {
                            oDrugDose.MealTimeGap = "";
                        }
                    }
                }
                if (chkMealNA.Checked == true)
                {
                    oDrugDose.MealName = "";
                    oDrugDose.MealID = Convert.ToChar("N");
                    oDrugDose.B_A_MealName = "";
                    oDrugDose.BeforeAfterMeal = Convert.ToChar("N");
                    oDrugDose.MealTimeGap = "";
                    oDrugDose.MealTimeGapID = "0";
                }

                if (chkMealNA.Checked == false)
                {
                    if (oDrugDose.MealName != "") //breakfast
                    {
                        if (oDrugDose.MealTimeGapID != "0") //min or M
                        {
                            if (oDrugDose.MealTimeGap == "") //30
                            {
                                MealConcat = oDrugDose.B_A_MealName + "  " + oDrugDose.MealTimeGap +
                                                            oDrugDose.MealName + " ";
                            }
                            else
                            {
                                MealConcat = oDrugDose.B_A_MealName + "  " + oDrugDose.MealTimeGap + " " + " of " +
                                     oDrugDose.MealName + " ";
                            }
                        }
                        if (oDrugDose.MealTimeGapID == "0")
                        {
                            MealConcat = "";
                        }
                    }
                }
                if (chkMealNA.Checked == true)
                {
                    MealConcat = oDrugDose.B_A_MealName + "" + oDrugDose.MealTimeGap +
                                                            oDrugDose.MealName + "";
                }
                #endregion

                #region duration
                if (cbContinue.Checked == true)
                {
                    DurationIndGrid = "Continue";
                    oDrugDose.Dur_Ind_Name = DurationIndGrid;
                    oDrugDose.DurationContinue = "1";
                    oDrugDose.DurationIndicator = Convert.ToChar("0");
                    oDrugDose.DurationPeriod = "0";
                }
                if (cbContinue.Checked == false)
                {
                    oDrugDose.DurationPeriod = txtDurationPeriod.Text;
                    if (oDrugDose.DurationPeriod == "" && oDrugDose.Dur_Ind_Name == null)
                    {
                        MessageBox.Show("Invalid Duration Condition", Utility.MessageCaptionMsg,
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (oDrugDose.DurationPeriod == "")
                        {
                            txtDurationPeriod.Focus();
                        }
                        return;
                    }
                    if (oDrugDose.DurationPeriod != "" && rdoDay.Checked == false && rdoWeek.Checked == false && rdoMonth.Checked == false && rdoYear.Checked == false)
                    {
                        MessageBox.Show("Invalid Duration Condition, Provide Duration Idicator", Utility.MessageCaptionMsg,
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDurationPeriod.Text = "";
                        return;
                    }

                    oDrugDose.Dur_Ind_Name = DurationIndGrid;
                    oDrugDose.DurationIndicator = Convert.ToChar(DurationIndGrid.Substring(0, 1));
                    oDrugDose.DurationPeriod = txtDurationPeriod.Text;// +" " + oDrugDose.Dur_Ind_Name;
                    oDrugDose.DurationContinue = "0";
                }
                #endregion

                if (oDrugDose.DurationContinue == "0")
                {
                    oDrugMaster.PropertiesString = oDrugPackType.Name + ":" + oDrugMaster.Name + "; " + "(" +
                                          oDrugDose.DoseStr + ")" + oConsumptionForm.Name + " " + MealConcat + " for " + oDrugDose.DurationPeriod + " " + oDrugDose.Dur_Ind_Name;
                }
                if (oDrugDose.DurationContinue != "0")
                {
                    oDrugMaster.PropertiesString = oDrugPackType.Name + ":" + oDrugMaster.Name + "; " + "(" +
                                          oDrugDose.DoseStr + ")" + oConsumptionForm.Name + " " + MealConcat;// +" ; " + oDrugDose.DurationPeriod;
                }
                oDrugMaster.Remarks = txtRemarks.Text;
                oDrugMaster.CalculatedQty = float.Parse(lbTDrugs.Text.ToString());
                oDrugDose.ConsumptionForm = oConsumptionForm;
                oDrugMaster.DrugPackType = oDrugPackType;
                oDrugDose.DrugMaster = oDrugMaster;
                oDrugDoses.Add(oDrugDose);
            }
            #endregion DosageDurationNA False

        }
        private bool AddPreRequisit()
        {
            List<string> vf = new List<string>() { "txtDrugMain", "txtDrugID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            return true;
        }

        private bool DurationCondition()
        {
            if (cbContinue.Checked == true &&
                (rdoDay.Checked == true || rdoMonth.Checked == true || rdoYear.Checked == true ||
                 txtDurationPeriod.Text.Trim() != ""))
            {
                MessageBox.Show("You Can not Provide Duration Value because you have Selected CONTIUE as Duration !!",
                                    Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool MedicineUniqueCheck()
        {
            for (int i = 0; i < lstMedicalPres.Items.Count; i++)
            {
                if (txtDrugID.Text == Convert.ToString(lstMedicalPres.Items[i].SubItems[7].Text.ToString()))
                {
                    lstMedicalPres.Items[i].Remove();
                    return true;
                }
            }
            return true;
        }
        private void LoadDrugsGridObject()
        {
            foreach (DrugDose lvMed in oDrugDoses)
            {
                ListViewItem itm = new ListViewItem();
                itm.SubItems.Add(lvMed.DrugMaster.PropertiesString); //At A Glance
                itm.SubItems.Add(lvMed.DrugMaster.Remarks); //Remarks
                itm.SubItems.Add(lvMed.DrugMaster.DrugCompany.ID); //CmpID
                itm.SubItems.Add(lvMed.DrugMaster.DrugGroup.ID); //GID
                itm.SubItems.Add(lvMed.DrugMaster.DrugUnit.ID); //UID
                itm.SubItems.Add(lvMed.DrugMaster.DrugPackType.ID); //TID
                itm.SubItems.Add(lvMed.DrugMaster.ID); //MID
                itm.SubItems.Add(lvMed.DrugMaster.Name);//DrugName
                itm.SubItems.Add(lvMed.DoseStr); //DoseQty
                itm.SubItems.Add(lvMed.ConsumptionForm.Name); // Consumption Form

                itm.SubItems.Add(lvMed.DurationPeriod); //Duration
                itm.SubItems.Add(lvMed.DurationIndicator.ToString()); //DRtID

                itm.SubItems.Add(lvMed.RouteID); //RoutID
                itm.SubItems.Add(lvMed.BeforeAfterMeal.ToString()); //BeforeAfterID
                itm.SubItems.Add(lvMed.MealID.ToString()); //MealID
                itm.SubItems.Add(lvMed.MealTimeGapID); //MealTimeGapID

                itm.SubItems.Add(lvMed.DurationContinue); //DurCont

                itm.SubItems.Add(lvMed.DrugMaster.CalculatedQty.ToString()); //Total Medicine Checking condition
                itm.SubItems.Add(lvMed.DrugMaster.DrugPackType.Name); //PackTypeName
                lstMedicalPres.Items.Add(itm);
            }
        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            lbTDrugs.Text = string.Empty;
            txtDurationPeriod.Text = string.Empty;
            txtDrugID.Text = string.Empty;
            txtDrugMain.Text = string.Empty;
            txtDosages.Text = string.Empty;
            txtRemarks.Text = string.Empty;

            txtDrugID.Focus();
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

        private void lstMedicalPres_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listViewSelectedItem(lstMedicalPres);
        }

        private void lstMedicalPres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMedicalPres.SelectedItems.Count > 0)
            {
                int index = lstMedicalPres.SelectedIndices.Count;
                ListViewItem itm = lstMedicalPres.SelectedItems[0];
                DrugDose oDrugDose = new DrugDose();

                txtRemarks.Text = itm.SubItems[2].Text;
                txtCompanyName.Text = itm.SubItems[3].Text;
                txtGroup.Text = itm.SubItems[4].Text;
                txtUnitID.Text = itm.SubItems[5].Text;
                txtPackID.Text = itm.SubItems[6].Text;
                txtPackName.Text = itm.SubItems[19].Text;
                txtDrugID.Text = itm.SubItems[7].Text;
                txtDrugMain.Text = itm.SubItems[8].Text;
                if (itm.SubItems[9].Text != "")
                {
                    chkDosagesNDurationNA.Checked = false;

                    txtDosages.Text = itm.SubItems[9].Text;
                    cboConsumptionForm.Text = itm.SubItems[10].Text;
                    if (itm.SubItems[11].Text == "0")
                    {
                        cbContinue.Checked = true;
                    }
                    if (itm.SubItems[11].Text != "0")
                    {
                        cbContinue.Checked = false;
                        txtDurationPeriod.Text = itm.SubItems[11].Text;
                    }

                    txtRouteID.Text = itm.SubItems[13].Text;
                    LoadChekBoxDrugDose(itm.SubItems[9].Text);
                    LoadChekBoxDuration(itm.SubItems[11].Text, itm.SubItems[12].Text);
                    if (itm.SubItems[14].Text != "N")
                    {
                        chkMealNA.Checked = false;
                        LoadChekBoxMeal(itm.SubItems[15].Text, itm.SubItems[16].Text, itm.SubItems[14].Text);
                    }
                    if (itm.SubItems[14].Text == "N")
                    {
                        chkMealNA.Checked = true;
                    }

                }
                if (itm.SubItems[9].Text == "")
                {
                    chkDosagesNDurationNA.Checked = true;

                    txtDosages.Text = "";
                    cboConsumptionForm.SelectedIndex = 1;
                    txtDurationPeriod.Text = "";
                    txtRouteID.Text = itm.SubItems[13].Text;
                    if (itm.SubItems[14].Text != "N")
                    {
                        LoadChekBoxMeal(itm.SubItems[15].Text, itm.SubItems[16].Text, itm.SubItems[14].Text);
                    }
                    if (itm.SubItems[14].Text == "N")
                    {
                        chkMealNA.Checked = true;
                    }

                }

            }
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            txtDrugID.Text = string.Empty;
            txtDrugMain.Text = string.Empty;
            txtDosages.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            txtGenericName.Text = string.Empty;

            foreach (ListViewItem eachItem in lstMedicalPres.SelectedItems)
            {
                lstMedicalPres.Items.Remove(eachItem);
            }
        }

        private void smartTab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (smartTab1.SelectedIndex == 0)
            {
               this.txtSearchInvestigation.Select();
            }

            if (smartTab1.SelectedIndex == 1)
            {
                this.txtGenericName.Select();
            }
            if (smartTab1.SelectedIndex == 2)
            {
                this.txtSearchAdvices.Select();
            }
        
        }

        private void btnToAdviceFrm_Click(object sender, EventArgs e)
        {
            frmAdviceSetup ofrm = new frmAdviceSetup();
            ofrm.ShowDialog();
        }

        private void btnToAdviceFrmRefresh_Click(object sender, EventArgs e)
        {
            PopulateAdvices();
        }

        private void txtSearchAdvices_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearchAdvices.Text != "")
            {
                if (listAdvicesCheck.Items.Count > 0)
                    PopulateAdvicesToGrid(listAdvicesCheck, txtSearchAdvices.Text);
            }
            else
            {
                PopulateAdvices();
            }
        }
        private void PopulateAdvicesToGrid(ListView listAdvicesCheck, string AdviceTitle)
        {
            IEnumerable<OPDAdvice> AdviceListLocal;
            if (AdviceTitle.Length == 0)
            {
                AdviceListLocal = AdvicesList;
            }
            else
            {
                AdviceListLocal = AdvicesList.Where(x => x.AdviceDetails.ToLower().Contains(AdviceTitle.ToLower()));
            }
            listAdvicesCheck.Items.Clear();
            foreach (OPDAdvice oAdv in AdviceListLocal)
            {
                ListViewItem itm = new ListViewItem("");
                itm.SubItems.Add(Convert.ToString(oAdv.AdviceID));
                itm.SubItems.Add(Convert.ToString(oAdv.AdviceDetails));
                itm.SubItems.Add(Convert.ToString(oAdv.Department.DepartmentID));
                itm.SubItems.Add(Convert.ToString(oAdv.Remarks));
                listAdvicesCheck.Items.Add(itm);
            }
        }

        private void btnAdvDrctAddToDB_Click(object sender, EventArgs e)
        {
            if (Utility.IsDuplicateFoundInList(listAdvicesCheck, 2, txtSearchAdvices.Text))
            {
                MessageBox.Show("This Advice Already Exists");
                return;
            }
            try
            {
                if (txtSearchAdvices.Text != "")
                {
                    short i = nwbnch.AdviceSetupInsert(PopulateOPDAdvice());

                    if (i == 0)
                    {
                        MessageBox.Show("Advice Saving Failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        PopulateAdvices();
                        if (listAdvicesCheck.Items.Count > 0)
                            PopulateAdvicesToGrid(listAdvicesCheck, txtSearchAdvices.Text);
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
        private OPDAdvice PopulateOPDAdvice()
        {
            OPDAdvice oOpd = new OPDAdvice();

            oOpd.AdviceDetails = txtSearchAdvices.Text;

            Department odept = new Department();
            odept.DepartmentID = Utility.UserDepartID.ToString(); ;
            oOpd.Department = odept;

            oOpd.Remarks = txtRemarks.Text;

            EntryParameter oep = new EntryParameter();
            oep.EntryBy = Utility.UserId;
            oep.CompanyID = Utility.CompanyID;
            oep.LocationID = Utility.LocationID;
            oep.MachineID = Utility.MachineID;
            oOpd.EntryParameter = oep;

            return oOpd;

        }

        private void listAdvicesCheck_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < listAdvicesCheck.Items.Count; i++)
            {
                if (listAdvicesCheck.Items[i].Checked == true)
                {
                    DuplicateCheckAdv(listAdvicesCheck.Items[i].SubItems[1].Text);
                    ListViewItem itm = new ListViewItem(listAdvicesCheck.Items[i].SubItems[1].Text);
                    itm.SubItems.Add(listAdvicesCheck.Items[i].SubItems[2].Text);
                    itm.SubItems.Add(listAdvicesCheck.Items[i].SubItems[3].Text);
                    itm.SubItems.Add(txtAdditionalAdvices.Text);
                    lvSelectedAdvice.Items.Add(itm);
                    listAdvicesCheck.Items[i].Checked = false;
                }

            }
            txtAdditionalAdvices.Text = "";
        }
        private void DuplicateCheckAdv(string advID)
        {
            if (lvSelectedAdvice.Items.Count < 0)
            {
                return;
            }
            else
            {
                for (int i = 0; i < lvSelectedAdvice.Items.Count; i++)
                {
                    if (lvSelectedAdvice.Items[i].SubItems[0].Text == advID)
                    {
                        lvSelectedAdvice.Items[i].Remove();
                    }
                }
            }
        }

        private void txtAdditionalAdvices_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void btnAddAdvices_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listAdvicesCheck.Items.Count; i++)
            {
                if (listAdvicesCheck.Items[i].Checked == true)
                {
                    DuplicateCheckAdv(listAdvicesCheck.Items[i].SubItems[1].Text);
                    ListViewItem itm = new ListViewItem(listAdvicesCheck.Items[i].SubItems[1].Text);
                    itm.SubItems.Add(listAdvicesCheck.Items[i].SubItems[2].Text);
                    itm.SubItems.Add(listAdvicesCheck.Items[i].SubItems[3].Text);
                    itm.SubItems.Add(txtAdditionalAdvices.Text);
                    lvSelectedAdvice.Items.Add(itm);
                    listAdvicesCheck.Items[i].Checked = false;
                }
            }
            txtAdditionalAdvices.Text = "";
        }

        private void btnRemoveAdvices_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in lvSelectedAdvice.SelectedItems)
            {
                lvSelectedAdvice.Items.Remove(eachItem);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (onSaveButtonClicked != null)
                    onSaveButtonClicked(GenerateTempPrescription(), sender, e);
                this.Dispose();
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private Prescription GenerateTempPrescription()
        {
            oPrescription = new Prescription();
            oPrescription.TestsList = GetSelectedTests().ToArray();
            oPrescription.DrugsList = GetSelectedMedicines().ToArray();
            oPrescription.AdvicesList = GetSelectedAdvices().ToArray();
            return oPrescription;
        }
        private List<TestSub> GetSelectedTests()
        {
            List<TestSub> tests = new List<TestSub>();

            for (int j = 0; j < lvAddItems.Items.Count; j++)
            {
                TestSub test = new TestSub();
                test.TestSubTitle = lvAddItems.Items[j].SubItems[1].Text;
                test.TestSubID = lvAddItems.Items[j].SubItems[2].Text;

                Department dp = new Department();
                dp.DepartmentID = lvAddItems.Items[j].SubItems[3].Text;
                test.TestDepartment = dp;

                TestGroup tg = new TestGroup();
                tg.GroupId = lvAddItems.Items[j].SubItems[4].Text;
                test.TestGroup = tg;

                test.TestMainID = lvAddItems.Items[j].SubItems[5].Text;

                ReportGroup rpt = new ReportGroup();
                rpt.ReportGroupID = lvAddItems.Items[j].SubItems[6].Text;
                test.ReportGroup = rpt;

                Room rm = new Room();
                rm.RoomID = lvAddItems.Items[j].SubItems[7].Text;
                test.Room = rm;

                tests.Add(test);
            }
            return tests;
        }
        private List<DrugDose> GetSelectedMedicines()
        {
            List<DrugDose> oMedicines = new List<DrugDose>();

            for (int i = 0; i < lstMedicalPres.Items.Count; i++)
            {
                DrugDose oMedicine = new DrugDose();
                DrugMaster oDrugMaster = new DrugMaster();

                oDrugMaster.PropertiesString = lstMedicalPres.Items[i].SubItems[1].Text; //At A Glance
                oDrugMaster.Remarks = lstMedicalPres.Items[i].SubItems[2].Text; //Remarks

                DrugCompany oDrugCompany = new DrugCompany();
                oDrugCompany.ID = lstMedicalPres.Items[i].SubItems[3].Text; //CmpID
                oDrugMaster.DrugCompany = oDrugCompany;

                DrugGroup oDrugGroup = new DrugGroup();
                oDrugGroup.ID = lstMedicalPres.Items[i].SubItems[4].Text; //GID
                oDrugMaster.DrugGroup = oDrugGroup;

                DrugUnit oDrugUnit = new DrugUnit();
                oDrugUnit.ID = lstMedicalPres.Items[i].SubItems[5].Text; //UID
                oDrugMaster.DrugUnit = oDrugUnit;

                DrugPackType oDrugPackType = new DrugPackType();
                oDrugPackType.ID = lstMedicalPres.Items[i].SubItems[6].Text; //TID
                oDrugPackType.Name = lstMedicalPres.Items[i].SubItems[19].Text; //TName
                oDrugMaster.DrugPackType = oDrugPackType;

                oDrugMaster.ID = lstMedicalPres.Items[i].SubItems[7].Text; //MID
                oDrugMaster.Name = lstMedicalPres.Items[i].SubItems[8].Text; //DrugName

                oMedicine.DoseStr = Convert.ToString(lstMedicalPres.Items[i].SubItems[9].Text);//DQty
                ConsumptionForm oConsumptionForm = new ConsumptionForm();
                oConsumptionForm.Name = lstMedicalPres.Items[i].SubItems[10].Text; // Consumption form

                oMedicine.Dur_Ind_Name = lstMedicalPres.Items[i].SubItems[11].Text; //Duration
                oMedicine.DurationIndicator = Convert.ToChar(lstMedicalPres.Items[i].SubItems[12].Text); //Duration Indicator ID
                oMedicine.RouteID = lstMedicalPres.Items[i].SubItems[13].Text;// RouteID
                oMedicine.BeforeAfterMeal = Convert.ToChar(lstMedicalPres.Items[i].SubItems[14].Text); //BeforeAfterID
                oMedicine.MealID = Convert.ToChar(lstMedicalPres.Items[i].SubItems[15].Text); //MealID
                oMedicine.MealTimeGapID = lstMedicalPres.Items[i].SubItems[16].Text; //MealTimeGapID
                oMedicine.DurationContinue = lstMedicalPres.Items[i].SubItems[17].Text; //Duration Continue?            
                oDrugMaster.TotalQty = float.Parse(lstMedicalPres.Items[i].SubItems[18].Text, CultureInfo.InvariantCulture.NumberFormat);  // Total No of Medicine

                oMedicine.ConsumptionForm = oConsumptionForm;
                oMedicine.DrugMaster = oDrugMaster;
                oMedicines.Add(oMedicine);
            }

            return oMedicines;
        }
        private List<OPDAdvice> GetSelectedAdvices()
        {
            List<OPDAdvice> Advices = new List<OPDAdvice>();

            for (int i = 0; i < lvSelectedAdvice.Items.Count; i++)
            {
                OPDAdvice oAdvice = new OPDAdvice();
                oAdvice.AdviceID = lvSelectedAdvice.Items[i].SubItems[0].Text;
                oAdvice.AdviceDetails = lvSelectedAdvice.Items[i].SubItems[1].Text;

                Department dp = new Department();
                dp.DepartmentID = lvSelectedAdvice.Items[i].SubItems[2].Text;
                oAdvice.Department = dp;

                oAdvice.Remarks = lvSelectedAdvice.Items[i].SubItems[3].Text;
                Advices.Add(oAdvice);
            }
            return Advices;
        }

        private void frmAddToDischargeAdvice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( lvAddItems.Items.Count > 0 ||lstMedicalPres.Items.Count > 0 || lvSelectedAdvice.Items.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Want to continue WITHOUT adding DATA to Discharge Advice ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    this.Dispose();
                }
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                this.Dispose();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (lvAddItems.Items.Count > 0 || lstMedicalPres.Items.Count > 0 || lvSelectedAdvice.Items.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Want to continue WITHOUT adding DATA to Discharge Advice ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    this.Dispose();
                }
            }
            else
            {
                this.Dispose();
            } 
        }

        private void lvAddItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listViewSelectedItem(lvAddItems);
        }

        private void lvSelectedAdvice_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listViewSelectedItem(lvSelectedAdvice);
        }
    }
}
