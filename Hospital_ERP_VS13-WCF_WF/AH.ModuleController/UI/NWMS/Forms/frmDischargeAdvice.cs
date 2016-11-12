using AH.DUtility;
using AH.ModuleController.NWMSSR;
using AH.ModuleController.UI.NWMS.Reports.Viewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AH.ModuleController.UI.NWMS.Forms
{
    public partial class frmDischargeAdvice : AH.Shared.UI.frmSmartFormStandard
    {
        NWMSSR.NWMSWSClient nwbnch = new NWMSSR.NWMSWSClient();
        string deptGrpID,dept_ID, unit_ID, doc_ID, bed_ID, mode;
        public frmDischargeAdvice(string deptGrpID,string dept_ID, string unit_ID, string doc_ID, string bed_ID, string mode)
        {
            InitializeComponent();
            this.deptGrpID = deptGrpID;
            this.bed_ID = bed_ID;
            this.dept_ID = dept_ID;
            this.unit_ID = unit_ID;
            this.doc_ID = doc_ID;
            this.mode = mode;
        }

        private void frmDischargeAdvice_Load(object sender, EventArgs e)
        {
            txtNextVisit.Enabled = false;
            txtNextVisitDay.Text = "0";
            txtNextVisitMonth.Text = "0";
            txtNextVisitYear.Text = "0";

            cboDisStatus.DisplayMember = "Value";
            cboDisStatus.ValueMember = "Key";
            cboDisStatus.DataSource = new BindingSource(Utility.GetDischargeStatuses(), null);

            cboDisType.DisplayMember = "Value";
            cboDisType.ValueMember = "Key";
            cboDisType.DataSource = new BindingSource(Utility.GetReleaseTypes(), null);

            cboDepartmentGroup.DisplayMember = "Value";
            cboDepartmentGroup.ValueMember = "Key";
            cboDepartmentGroup.DataSource = new BindingSource(nwbnch.GetDeptGroupDicByType("01"), null);

            if (mode == "D")
            {
                frmLabel.Text = "Discharge Summary and Advice";
                InPatient pat = nwbnch.GetPatRegID(bed_ID);
                txtPatRegNoIPD.Text = pat.RegistrationNo;

                short a = nwbnch.IsDischargeAdvCreated(txtPatRegNoIPD.Text);
                if (a == 0)
                {
                    this.btnFind.PerformClick();
                    //-------------------------------
                    FormatInvestigationsListView();
                    FormatDrugsListView();
                    FormatAdvicesListView();
                    //-------------------------------
                    
                }
                else
                {
                    MessageBox.Show(" Discharge Advice Already Proviede for this Patient", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = false;
                    this.Dispose();
                }     
            }
            if (mode == "E")
            {
                frmLabel.Text = "Edit Discharge Summary and Advice";

                InPatient pat = nwbnch.GetPatRegID(bed_ID);
                txtPatRegNoIPD.Text = pat.RegistrationNo;

                short a = nwbnch.IsDischargeAdvCreated(txtPatRegNoIPD.Text);
                if (a == 1)
                {
                    this.btnFind.PerformClick();
                    //-------------------------------
                    FormatInvestigationsListView();
                    FormatDrugsListView();
                    FormatAdvicesListView();
                    IPDPrescription IPrs = nwbnch.GetDischargeAdvicesForEdit(txtPatRegNoIPD.Text);
                    LoadDetailsForEdit(IPrs);
                }
                else
                {
                    MessageBox.Show("No Discharge Advice Provieded yet for this Patient", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = false;
                    this.Dispose();
                } 
            }
            txtDisDiagnosis.Select();
        }

        private void LoadDetailsForEdit(IPDPrescription prs)
        {

#region Drugs Test Advice
            lvSelectedTests.Items.Clear();
            lvDrugs.Items.Clear();
            lvAdvicePrescription.Items.Clear();

            if (prs.Prescription.CollTests.Length > 0)
            {
                string vCTest = prs.Prescription.CollTests;
                string[] lines = Regex.Split(vCTest, "~");

                for (int i = 0; i < lines.Length; i++)
                {
                    string cTest = lines[i].ToString();
                    string[] parts = Regex.Split(cTest, "`");

                    ListViewItem itm = new ListViewItem(parts[0].ToString());
                    itm.SubItems.Add(parts[1].ToString());
                    itm.SubItems.Add(parts[2].ToString());
                    itm.SubItems.Add(parts[3].ToString());
                    itm.SubItems.Add(parts[4].ToString());
                    itm.SubItems.Add(parts[5].ToString());
                    itm.SubItems.Add(parts[6].ToString());
                    lvSelectedTests.Items.Add(itm);
                }
            }

            if (prs.Prescription.Medicine.Length > 0)
            {
                string MealConcat = "";
                string ATaGlance = "";
                string vMed = prs.Prescription.Medicine;
                string[] lines = Regex.Split(vMed, "~");

                for (int i = 0; i < lines.Length; i++)
                {
                    string Med = lines[i].ToString();
                    string[] parts = Regex.Split(Med, "`");

                    //-------------------------------------------//

                    if (parts[20].ToString() != "") //meal name
                    {
                        if (parts[15].ToString() != "0") //meal time gap id 
                        {
                            if (parts[21].ToString() == "") //meal time gap
                            {
                                MealConcat = parts[22].ToString() + "  " + parts[21].ToString() + parts[20].ToString() + " ";
                            }
                            else
                            {
                                MealConcat = parts[22].ToString() + "  " + parts[21].ToString() + " " + " of " + parts[20].ToString() + " ";
                            }
                        }
                        if (parts[15].ToString() == "0")
                        {
                            MealConcat = parts[22].ToString() + " " + parts[20].ToString() + " ";
                        }
                    }

                    //------------------------------------------//

                    if (parts[16].ToString() == "0")
                    {
                        if (parts[7].ToString() != "")
                        {
                            ATaGlance = parts[19].ToString() + ":" + parts[6].ToString() + "; " +
                                                               "(" + parts[7].ToString() + ")" + parts[8].ToString() + " " + MealConcat + " for " + parts[23].ToString() + " " + parts[24].ToString();
                        }
                        if (parts[7].ToString() == "")
                        {
                            ATaGlance = parts[19].ToString() + ":" + parts[6].ToString() + "; " + parts[8].ToString() + " " + MealConcat + " for " + parts[23].ToString() + " " + parts[24].ToString();
                        }
                    }
                    if (parts[16].ToString() != "0")
                    {
                        if (parts[7].ToString() != "")
                        {
                            ATaGlance = parts[19].ToString() + ":" + parts[6].ToString() + "; " + "(" + parts[7].ToString() + ")" + parts[8].ToString() + " " + MealConcat;
                        }
                        if (parts[7].ToString() == "")
                        {
                            ATaGlance = parts[19].ToString() + ":" + parts[6].ToString() + "; " + parts[8].ToString() + " " + MealConcat;
                        }
                    }

                    //------------------------------------------//

                    ListViewItem itm = new ListViewItem(ATaGlance);
                    itm.SubItems.Add(parts[0].ToString()); // remarks
                    itm.SubItems.Add(parts[1].ToString()); // comp_ID
                    itm.SubItems.Add(parts[2].ToString()); //Group_ID  
                    itm.SubItems.Add(parts[3].ToString()); // unit_ID
                    itm.SubItems.Add(parts[4].ToString()); //drug_type_ID
                    itm.SubItems.Add(parts[5].ToString()); //drug_ID
                    itm.SubItems.Add(parts[6].ToString()); //drug_name
                    itm.SubItems.Add(parts[7].ToString()); //Dose_str
                    itm.SubItems.Add(parts[8].ToString()); //consumptionform
                    itm.SubItems.Add(parts[9].ToString()); //0= hour_Gap
                    itm.SubItems.Add(parts[10].ToString()); //duration
                    itm.SubItems.Add(parts[11].ToString()); //duration_IND
                    itm.SubItems.Add(parts[12].ToString()); //Dose_route_ID 
                    itm.SubItems.Add(parts[13].ToString()); //B_A_Meal 
                    itm.SubItems.Add(parts[14].ToString()); //Meal_indicator 
                    itm.SubItems.Add(parts[15].ToString()); //Meal_T_GAP 
                    itm.SubItems.Add(parts[16].ToString()); //Continue_flag 
                    itm.SubItems.Add(parts[17].ToString()); // 0 = refill 
                    itm.SubItems.Add(parts[18].ToString()); //T_amt
                    itm.SubItems.Add(parts[19].ToString()); //Packname   
                    lvDrugs.Items.Add(itm);
                }
            }

            if (prs.Prescription.Advice.Length > 0)
            {
                string vAdv = prs.Prescription.Advice;
                string[] lines = Regex.Split(vAdv, "~");

                for (int i = 0; i < lines.Length; i++)
                {
                    string Adv = lines[i].ToString();
                    string[] parts = Regex.Split(Adv, "`");

                    ListViewItem itm = new ListViewItem(parts[0].ToString());
                    itm.SubItems.Add(parts[1].ToString());
                    itm.SubItems.Add(parts[2].ToString());
                    itm.SubItems.Add(parts[3].ToString());
                    lvAdvicePrescription.Items.Add(itm);
                }
            }
#endregion Drugs Test Advice
            if (prs.Prescription.Refered.Length > 0)
            {
                string vRefered = prs.Prescription.Refered;
                string[] parts = Regex.Split(vRefered, "`");
                if (parts[0].ToString() != "")
                {
                    txtNextVisit.Text = parts[0].ToString();
                    cboDepartmentGroup.SelectedValue = parts[1].ToString();
                    cboDepartment.SelectedValue = parts[2].ToString();
                    cboUnit.SelectedValue = parts[3].ToString();
                    if (parts[4].ToString() != "0")
                    {
                        cboDoctor.SelectedValue = parts[4].ToString();
                    }
                }
            }

            cboDisStatus.SelectedValue = prs.DischargeStatus;
            cboDisType.SelectedValue = prs.DischargeType;
            txtDisDiagnosis.Text = prs.DischargeDiagnosis ;
            txtCaseSum.Text = prs.CaseSummary ;
            txtHospitalCourse.Text = prs.HospitalCourse;
            txtOperationNote.Text = prs.OperationNote ;
            txtDietAdvice.Text = prs.DietAdvice;

        }

        private void cboDepartmentGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentGroup.SelectedValue != null)
            {
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(nwbnch.GetDepartmentsetupDic(null, cboDepartmentGroup.SelectedValue.ToString()), null);
            }
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(nwbnch.GetDeptUnitDic(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString())), null);
            }
        }

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != null && cboUnit.SelectedValue != null)
            {
                cboDoctor.ValueMember = "Key";
                cboDoctor.DisplayMember = "Value";
                cboDoctor.DataSource = new BindingSource(nwbnch.GetIPDDoctorsDict(cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString()), null);
            }
        }
       
        private void DepartmentCbo()
        {
            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(nwbnch.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical))), null);
        }
        #region ListViewsFormating
        private void FormatInvestigationsListView()
        {
            lvSelectedTests.CheckBoxes = false;
            lvSelectedTests.Columns.Add("Investigation(s)", 374, HorizontalAlignment.Left);
            lvSelectedTests.Columns.Add("DetailID", 0, HorizontalAlignment.Left);
            lvSelectedTests.Columns.Add("Department", 0, HorizontalAlignment.Left);
            lvSelectedTests.Columns.Add("Group", 0, HorizontalAlignment.Left);
            lvSelectedTests.Columns.Add("Main", 0, HorizontalAlignment.Left);
            lvSelectedTests.Columns.Add("ReportGroup", 0, HorizontalAlignment.Left);
            lvSelectedTests.Columns.Add("LabRoom", 0, HorizontalAlignment.Left);
        }

        private void FormatDrugsListView()
        {
            lvDrugs.CheckBoxes = false;
            lvDrugs.Columns.Add("At a Glance", 635, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("Remarks", 100, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("CmpID", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("GID", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("UID", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("TID", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("MID", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("DrugName", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("DQty", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("ConsumptionForm", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("DTHGap", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("Duration", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("DurationInd", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("RouteID", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("B/AMeal", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("MealID", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("MealTimeGapID", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("DurCont", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("Refils", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("TotalMedicine", 0, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("PackTypeName", 0, HorizontalAlignment.Left);
        }

        private void FormatAdvicesListView()
        {
            lvAdvicePrescription.Items.Clear();
            lvAdvicePrescription.Columns.Add("Advice ID", 0, HorizontalAlignment.Left);
            lvAdvicePrescription.Columns.Add("Advice(s)", 450, HorizontalAlignment.Left);
            lvAdvicePrescription.Columns.Add("Department", 0, HorizontalAlignment.Left);
            lvAdvicePrescription.Columns.Add("Additional Information", 200, HorizontalAlignment.Left);
        }
        #endregion ListViewsFormating
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
                    txtDeptGrpID.Text = deptGrpID;
                    txtDepartmentId.Text = dept_ID;
                    txtUnitId.Text = unit_ID;
                    txtDoctorId.Text = doc_ID;
                    IPDDoctor Doc = nwbnch.GetDoctorsDetails(txtDoctorId.Text);

                    txtDoctorName.Text = Doc.Name;
                    txtVisitingFee.Text = Convert.ToString(Doc.IPDVisitingFee);
                    txtDocVisitingFee.Text = Convert.ToString(Doc.DoctorsVisitingFee);

                    txtPatRegNoIPD.Enabled = false;
                    btnFind.Enabled = false;
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
            int daysleft1 =  ts.Days - (ageY * 365);
            int ageM = (daysleft1 / 30);
            int daysleft2 = daysleft1 - (ageM * 30);
            int ageD = daysleft2;
            txtAgeY.Text = ageY.ToString();
            txtAgeM.Text = ageM.ToString();
            txtAgeD.Text = ageD.ToString();

            txtPrescriptionNumber.Text = pat.ReferenceNo;
            txtHCN.Text = pat.HCN;
            txtBedTitle.Text = pat.Bed.BedTitle;
            txtBedNo.Text = pat.Bed.BedNo;
            txtBedType.Text = Convert.ToString(pat.Bed.BedType.Title);
            txtBedTypeID.Text = Convert.ToString(pat.Bed.BedType.ID);
            txtRoonNo.Text = Convert.ToString(pat.Room.RoomTitle);
            txtRoomID.Text = Convert.ToString(pat.Room.RoomID);
            txtFloorNo.Text = pat.Room.Floor;
            txtBedFecilityID.Text = pat.Bed.BedType.BedFacility.ID;
            txtStaffId.Text = pat.StaffID;
            txtNurseStn.Text = pat.NurseStation.NurseStationID;

            //txtDepartmentId.Text = pat.Department.DepartmentID;
            //txtUnitId.Text = pat.DepartmentUnit.UnitId;
            //txtDoctorId.Text = pat.Doctor.ID;
            //txtDoctorName.Text = pat.Department.DepartmentUnitHead;

        }
        private void btnOtherAdvice_Click(object sender, EventArgs e)
        {
            if (txtPatRegNoIPD.Text != "")
            {
                frmAddToDischargeAdvice ad = new frmAddToDischargeAdvice(AddFromPrescription(), 2, txtAgeY.Text);
                ad.onSaveButtonClicked = new frmAddToDischargeAdvice.SaveButtonClick(AddToPrescription);
                ad.ShowDialog();
            }
        }

        private void btnAddInvestigation_Click(object sender, EventArgs e)
        {
            if (txtPatRegNoIPD.Text != "")
            {
                frmAddToDischargeAdvice ad = new frmAddToDischargeAdvice(AddFromPrescription(), 0, txtAgeY.Text);
                ad.onSaveButtonClicked = new frmAddToDischargeAdvice.SaveButtonClick(AddToPrescription);
                ad.ShowDialog();
            }
        }

        private void btnAddDrugs_Click(object sender, EventArgs e)
        {
            if (txtPatRegNoIPD.Text != "")
            {
                frmAddToDischargeAdvice ad = new frmAddToDischargeAdvice(AddFromPrescription(), 1, txtAgeY.Text);
                ad.onSaveButtonClicked = new frmAddToDischargeAdvice.SaveButtonClick(AddToPrescription);
                ad.ShowDialog();
            }
        }

#region GetSelected

        private Prescription AddFromPrescription()
        {
            Prescription oPrescription = new Prescription();
            oPrescription.TestsList = GetSelectedTests().ToArray();
            oPrescription.DrugsList = GetSelectedMedicines().ToArray();
            oPrescription.AdvicesList = GetSelectedAdvices().ToArray();
            return oPrescription;
        }
        private List<TestSub> GetSelectedTests()
        {
            List<TestSub> oTests = new List<TestSub>();
            for (int i = 0; i < lvSelectedTests.Items.Count; i++)
            {
                TestSub oTest = new TestSub();
                oTest.TestSubTitle = lvSelectedTests.Items[i].SubItems[0].Text;
                oTest.TestSubID = lvSelectedTests.Items[i].SubItems[1].Text;

                Department dp = new Department();
                dp.DepartmentID = lvSelectedTests.Items[i].SubItems[2].Text;
                oTest.TestDepartment = dp;

                TestGroup oTestGroup = new TestGroup();
                oTestGroup.GroupId = lvSelectedTests.Items[i].SubItems[3].Text;
                oTest.TestGroup = oTestGroup;

                oTest.TestMainID = lvSelectedTests.Items[i].SubItems[4].Text;

                ReportGroup oReportGroup = new ReportGroup();
                oReportGroup.ReportGroupID = lvSelectedTests.Items[i].SubItems[5].Text;
                oTest.ReportGroup = oReportGroup;

                Room rm = new Room();
                rm.RoomID = lvSelectedTests.Items[i].SubItems[6].Text;
                oTest.Room = rm;

                oTests.Add(oTest);
            }
            return oTests;
        }
        private List<DrugDose> GetSelectedMedicines()
        {
            List<DrugDose> oMedicines = new List<DrugDose>();
            for (int i = 0; i < lvDrugs.Items.Count; i++)
            {
                DrugDose oMedicine = new DrugDose();
                DrugMaster oDrugMaster = new DrugMaster();

                oDrugMaster.PropertiesString = lvDrugs.Items[i].Text;       //At A Glance
                oDrugMaster.Remarks = lvDrugs.Items[i].SubItems[1].Text;    //Remarks

                DrugCompany oDrugCompany = new DrugCompany();
                oDrugCompany.ID = lvDrugs.Items[i].SubItems[2].Text;     //CmpID
                oDrugMaster.DrugCompany = oDrugCompany;

                DrugGroup oDrugGroup = new DrugGroup();
                oDrugGroup.ID = lvDrugs.Items[i].SubItems[3].Text;    //GID
                oDrugMaster.DrugGroup = oDrugGroup;

                DrugUnit oDrugUnit = new DrugUnit();
                oDrugUnit.ID = lvDrugs.Items[i].SubItems[4].Text;   //UID
                oDrugMaster.DrugUnit = oDrugUnit;

                DrugPackType oDrugPackType = new DrugPackType();
                oDrugPackType.ID = lvDrugs.Items[i].SubItems[5].Text;    //TID
                oDrugPackType.Name = lvDrugs.Items[i].SubItems[20].Text;    //PackTypeName
                oDrugMaster.DrugPackType = oDrugPackType;

                oDrugMaster.ID = lvDrugs.Items[i].SubItems[6].Text;     //MID
                oDrugMaster.Name = lvDrugs.Items[i].SubItems[7].Text;   //Mname
                oMedicine.DoseStr = Convert.ToString(lvDrugs.Items[i].SubItems[8].Text);    //DQty

                ConsumptionForm oConsumptionForm = new ConsumptionForm();
                oConsumptionForm.Name = lvDrugs.Items[i].SubItems[9].Text;  // Consumption form

                oMedicine.Dur_Ind_Name = lvDrugs.Items[i].SubItems[11].Text;     //Duration
                oMedicine.DurationIndicator = Convert.ToChar(lvDrugs.Items[i].SubItems[12].Text);   //Duration Indicator ID
                oMedicine.RouteID = lvDrugs.Items[i].SubItems[13].Text;     // RouteID
                oMedicine.BeforeAfterMeal = Convert.ToChar(lvDrugs.Items[i].SubItems[14].Text);     //BeforeAfterID
                oMedicine.MealID = Convert.ToChar(lvDrugs.Items[i].SubItems[15].Text);      //MealID
                oMedicine.MealTimeGapID = lvDrugs.Items[i].SubItems[16].Text;           //MealTimeGapID
                oMedicine.DurationContinue = lvDrugs.Items[i].SubItems[17].Text;        //Duration Continue?            
                oDrugMaster.CalculatedQty = float.Parse(lvDrugs.Items[i].SubItems[19].Text);     // Total Medicine       

                oMedicine.ConsumptionForm = oConsumptionForm;
                oMedicine.DrugMaster = oDrugMaster;
                oMedicines.Add(oMedicine);
            }
            return oMedicines;
        }
        private List<OPDAdvice> GetSelectedAdvices()
        {
            List<OPDAdvice> Advices = new List<OPDAdvice>();

            for (int i = 0; i < lvAdvicePrescription.Items.Count; i++)
            {
                OPDAdvice oOPDAdvice = new OPDAdvice();
                oOPDAdvice.AdviceID = lvAdvicePrescription.Items[i].SubItems[0].Text;
                oOPDAdvice.AdviceDetails = lvAdvicePrescription.Items[i].SubItems[1].Text;

                Department dp = new Department();
                dp.DepartmentID = lvAdvicePrescription.Items[i].SubItems[2].Text;

                oOPDAdvice.Department = dp;
                oOPDAdvice.Remarks = lvAdvicePrescription.Items[i].SubItems[3].Text;
                Advices.Add(oOPDAdvice);
            }
            return Advices;
        }

#endregion GetSelected                                                   

#region AddDataTo

        private void AddToPrescription(Prescription oPres, object sender, EventArgs e)
        {
            List<TestSub> oTest = oPres.TestsList.ToList();
            List<DrugDose> oDrugs = oPres.DrugsList.ToList();
            List<OPDAdvice> oAdvice = oPres.AdvicesList.ToList();
            AddDataToInvestigationView(oTest, sender, e);
            AddDataToDrugView(oDrugs, sender, e);
            AddDataToAdviceView(oAdvice, sender, e);
        }
        private void AddDataToInvestigationView(List<TestSub> tests, object sender, EventArgs e)
        {
            try
            {
                lvSelectedTests.Items.Clear();
                foreach (TestSub ts in tests)
                {
                    ListViewItem itm = new ListViewItem(ts.TestSubTitle);
                    itm.SubItems.Add(ts.TestSubID);
                    itm.SubItems.Add(ts.TestDepartment.DepartmentID);
                    itm.SubItems.Add(ts.TestGroup.GroupId);
                    itm.SubItems.Add(ts.TestMainID);
                    itm.SubItems.Add(ts.ReportGroup.ReportGroupID);
                    itm.SubItems.Add(ts.Room.RoomID);
                    lvSelectedTests.Items.Add(itm);
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
        private void AddDataToDrugView(List<DrugDose> oDrugs, object sender, EventArgs e)
        {
            try
            {
                lvDrugs.Items.Clear();
                foreach (DrugDose med in oDrugs)
                {
                    ListViewItem itm = new ListViewItem(med.DrugMaster.PropertiesString); //At a Glance
                    itm.SubItems.Add(med.DrugMaster.Remarks); //Remarks
                    itm.SubItems.Add(med.DrugMaster.DrugCompany.ID); //CmpID
                    itm.SubItems.Add(med.DrugMaster.DrugGroup.ID); //GID
                    itm.SubItems.Add(med.DrugMaster.DrugUnit.ID); //UID
                    itm.SubItems.Add(med.DrugMaster.DrugPackType.ID); //TID
                    itm.SubItems.Add(med.DrugMaster.ID); //MID
                    itm.SubItems.Add(med.DrugMaster.Name); // Mname
                    itm.SubItems.Add(med.DoseStr); //DoseQty
                    itm.SubItems.Add(med.ConsumptionForm.Name);  // Consumption form
                    itm.SubItems.Add("0"); //DTHGap
                    itm.SubItems.Add(med.Dur_Ind_Name); //Duration
                    itm.SubItems.Add(med.DurationIndicator.ToString()); //DurationInd
                    itm.SubItems.Add(med.RouteID); //RouteID
                    itm.SubItems.Add(med.BeforeAfterMeal.ToString()); //B/AMeal
                    itm.SubItems.Add(med.MealID.ToString()); //MealID
                    itm.SubItems.Add(med.MealTimeGapID); //MealTimeGapID
                    itm.SubItems.Add(med.DurationContinue); //DurCont
                    itm.SubItems.Add("0"); //Refills
                    itm.SubItems.Add(med.DrugMaster.TotalQty.ToString()); // Total drugs
                    itm.SubItems.Add(med.DrugMaster.DrugPackType.Name); // PackTypeName
                    lvDrugs.Items.Add(itm);
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
        private void AddDataToAdviceView(List<OPDAdvice> oAdvice, object sender, EventArgs e)
        {
            try
            {
                lvAdvicePrescription.Items.Clear();
                foreach (OPDAdvice oa in oAdvice)
                {
                    ListViewItem itm = new ListViewItem(oa.AdviceID);
                    itm.SubItems.Add(oa.AdviceDetails);
                    itm.SubItems.Add(oa.Department.DepartmentID);
                    itm.SubItems.Add(oa.Remarks);
                    lvAdvicePrescription.Items.Add(itm);
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

#endregion AddDataTo  

       private void btnSave_Click(object sender, EventArgs e)
       {
           if (mode == "D")
           {
               DialogResult dr = MessageBox.Show("Do you want to save Discharge Advice ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
               if (dr == DialogResult.Yes)
               {
                   List<string> vf = new List<string>() { "txtPatRegNoIPD", "cboDisStatus", "cboDisType"};
                   Control control = Utility.ReqFieldValidator(this, vf);
                   if (control != null)
                   {
                       MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       control.Focus();
                       return;
                   }
                   try
                   {
                       if (lvSelectedTests.Items.Count > 0 || lvDrugs.Items.Count > 0 || lvAdvicePrescription.Items.Count > 0)
                       {
                           IPDPrescription tcats = this.PopulatePrescription();
                           short i = nwbnch.SaveDischargeAdvices(tcats);
                           if (i == 0)
                           {
                               MessageBox.Show("Data insertion failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           }
                           else
                           {
                               MessageBox.Show("Data insertion Successful", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                               string tempRegID = "";
                               tempRegID = txtPatRegNoIPD.Text;
                               btnNew.PerformClick();
                             //  dischargeAdvice(tempRegID);
                               DischargeSummary(tempRegID);
                               this.Dispose();
                           }
                       }
                       //else
                       //{
                       //    MessageBox.Show("Please provide some Drugs or Tests", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       //}
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
           }

           if (mode == "E")
           {
               DialogResult dr = MessageBox.Show("Do you want to edit Discharge Advice ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
               if (dr == DialogResult.Yes)
               {
                   List<string> vf = new List<string>() { "txtPatRegNoIPD", "cboDisStatus", "cboDisType" };
                   Control control = Utility.ReqFieldValidator(this, vf);
                   if (control != null)
                   { 
                       MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       control.Focus();
                       return;
                   }
                   try
                   {
                       if (lvSelectedTests.Items.Count > 0 || lvDrugs.Items.Count > 0 || lvAdvicePrescription.Items.Count > 0)
                       {
                           IPDPrescription tcats = this.PopulatePrescription();
                           short i = nwbnch.EditDischargeAdvices(tcats);
                           if (i == 0)
                           {
                               MessageBox.Show("Data insertion failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           }
                           else
                           {
                               MessageBox.Show("Data insertion Successful", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                               string tempRegID = "";
                               tempRegID = txtPatRegNoIPD.Text;
                               btnNew.PerformClick();
                             //  dischargeAdvice(tempRegID);
                               DischargeSummary(tempRegID);
                               this.Dispose();
                           }
                       }
                       //else
                       //{
                       //    MessageBox.Show("Please provide some Drugs or Tests", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       //}
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
           }
       }

       public void dischargeAdvice(string RegID)
       {
           frmReportViewer ofrmRpt = new frmReportViewer();
           ofrmRpt.selector = ViewerSelector.DischargeAdvice;
           ofrmRpt.ParamField = RegID;
           ofrmRpt.ViewReport();
       }
       public void DischargeSummary(string RegID)
       {
           frmReportViewer ofrmRpt = new frmReportViewer();
           ofrmRpt.selector = ViewerSelector.DischargeSummary;
           ofrmRpt.ParamField = RegID;
           ofrmRpt.ViewReport();
       }

       private IPDPrescription PopulatePrescription()
       {
           IPDPrescription Iprs = new IPDPrescription();
           Prescription prs = new Prescription();
           InPatient ipat = new InPatient();

           ipat.HCN = txtHCN.Text;
           ipat.RegistrationNo = txtPatRegNoIPD.Text;

           Department dpt = new Department();
           dpt.DepartmentID = txtDepartmentId.Text;

           DepartmentGroup dptGrp = new DepartmentGroup();
           dptGrp.DepartmentGroupID = txtDeptGrpID.Text;
           dpt.DepartmentGroup = dptGrp;

           ipat.Department = dpt;

           DepartmentUnit dptUni = new DepartmentUnit();
           dptUni.UnitId = txtUnitId.Text;
           ipat.DepartmentUnit = dptUni;

           Doctor doc = new Doctor();
           doc.ID = txtDoctorId.Text;
           ipat.Doctor = doc;

           Room rm = new Room();
           rm.Floor = txtFloorNo.Text;
           rm.RoomID = txtRoomID.Text;
           ipat.Room = rm;

           Bed bed = new Bed();
           bed.BedNo = txtBedNo.Text;
           BedType bdtyp = new BedType();
           bdtyp.ID = txtBedTypeID.Text;
           bed.BedType = bdtyp;


           BedFacility bdfcilty = new BedFacility();
           bdfcilty.ID = txtBedFecilityID.Text;
           bed.Facility = bdfcilty;
           ipat.Bed = bed;

           NurseStation nsstn = new NurseStation();
           nsstn.NurseStationID = txtNurseStn.Text;
           ipat.NurseStation = nsstn;

           Iprs.DietAdvice = txtDietAdvice.Text;

           Iprs.DischargeStatus = cboDisStatus.SelectedValue.ToString();
           Iprs.DischargeType = cboDisType.SelectedValue.ToString();
           Iprs.DischargeDiagnosis = txtDisDiagnosis.Text;
           Iprs.CaseSummary = txtCaseSum.Text;
           Iprs.HospitalCourse = txtHospitalCourse.Text;
           Iprs.OperationNote = txtOperationNote.Text;

           if (txtNextVisit.Text != "  /  /")
           {
               prs.NextVisitDate = DateTime.ParseExact(txtNextVisit.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
           }
           if (txtNextVisit.Text == "  /  /")
           {
               prs.NextVisitDate = null;
           }

           Iprs.RefDeptGrp = cboDepartmentGroup.SelectedValue.ToString();

           if (/*cboDepartment.SelectedValue != "" ||*/ cboDepartment.Text != "--")
           {
               Department odept = new Department();
               odept.DepartmentID = cboDepartment.SelectedValue.ToString();
               prs.RefDeptID = odept;
           }
           else
           {
               Department odept = new Department();
               odept.DepartmentID = "0";
               prs.RefDeptID = odept;
           }

           if (cboUnit.SelectedValue != null)
           {
               DepartmentUnit deptUnit = new DepartmentUnit();
               deptUnit.UnitId = cboUnit.SelectedValue.ToString();
               prs.RefUnitID = deptUnit;
           }
           else
           {
               DepartmentUnit deptUnit = new DepartmentUnit();
               deptUnit.UnitId = "0";
               prs.RefUnitID = deptUnit;
           }
           if (cboDoctor.SelectedValue != null)
           {
               Doctor odoc = new Doctor();
               odoc.ID = cboDoctor.SelectedValue.ToString();
               prs.RefDocID = odoc;
           }
           else
           {
               Doctor odoc = new Doctor();
               odoc.ID = "0";
               prs.RefDocID = odoc;
           } 


           #region Commented
           /*          /////////////////////////////////// Clinical Diagnosis
           string clinicalDiagnosis = "";
           foreach (ListViewItem itemRow in lvCollectedClinicalDiagnosis.Items)
           {
               clinicalDiagnosis += itemRow.SubItems[0].Text + ":"
                                 + itemRow.SubItems[2].Text;
               clinicalDiagnosis += ";";
           }

           prs.ClinicalDiagnosis = clinicalDiagnosis;

           ////////////////////////////////////Complaints
           string complaints = "";
           foreach (ListViewItem itemRow in lvComplaints.Items)
           {
               complaints += itemRow.SubItems[0].Text + ":"
                          + itemRow.SubItems[2].Text;
               complaints += ";";

           }

           prs.Complaints = complaints;
           ////////////////////////////////////Other Complaints
           string Ocomplaints = "";
           foreach (ListViewItem itemRow in lvOtherComplaints.Items)
           {
               Ocomplaints += itemRow.SubItems[0].Text + ":"
                           + itemRow.SubItems[2].Text;
               Ocomplaints += ";";

           }

           prs.OtherComplaints = Ocomplaints; */
#endregion Commented
           //------------------ Add Advice ----------------------------

           string AddAdvice = "";
           foreach (ListViewItem itemRow in lvAdvicePrescription.Items)
           {
               AddAdvice += itemRow.SubItems[0].Text + "`"
                         + itemRow.SubItems[3].Text + "`";
               AddAdvice += "~";
           }
           prs.Advice = AddAdvice;

           //------------------ End Add Advice ----------------------- 
         

           /////////////////////////////////////// Tests
           string colltests = "";
           foreach (ListViewItem itemRow in lvSelectedTests.Items)
           {
               colltests += itemRow.SubItems[6].Text + "`"
                         +  itemRow.SubItems[5].Text + "`"
                         +  itemRow.SubItems[2].Text + "`"
                         +  itemRow.SubItems[3].Text + "`"
                         +  itemRow.SubItems[4].Text + "`"
                         +  itemRow.SubItems[1].Text + "`";
               colltests += "~";
           }
           prs.CollTests = colltests;

           ///////////////////////////////////////Drugs 
           string drugs = "";
           foreach (ListViewItem itemRow in lvDrugs.Items)
           {
               //comp:grp:unit:pack type:drug id:dose Qty:Dose Times:Times Indicator:hourGap
               //:Dose Route:b/a meal:MealTimeGap:Meal Indicator:mealIndicator:Duration:duration Indicator:Refill:Remarks
               //              "000001,000002,0002,0003,0000003,2,3,D,0,
               //              ,,0,,3,D,0,"

               drugs += itemRow.SubItems[2].Text + "`"  //DRUG_COMP_ID ,
                       + itemRow.SubItems[3].Text + "`"  //GrID 
                       + itemRow.SubItems[4].Text + "`" //UID   
                       + itemRow.SubItems[5].Text + "`" //TID  
                       + itemRow.SubItems[6].Text + "`" //MID 
                       + itemRow.SubItems[8].Text + "`"//DOSE_STR 
                       + "0" + "`"// HOUR_GAP
                       + itemRow.SubItems[13].Text + "`"   //DOSE_ROUTE_ID 
                       + itemRow.SubItems[14].Text + "`"     // B_A_MEAL 
                       + itemRow.SubItems[16].Text + "`"     //MEAL_T_GAP 
                       + itemRow.SubItems[15].Text + "`"    //MEAL_INDICATOR 
                       + itemRow.SubItems[17].Text + "`"     //continue_flag
                       + itemRow.SubItems[11].Text + "`"    //DURATION
                       + itemRow.SubItems[12].Text + "`"     //DUR_IND 
                       + "0" + "`"   //REFILLS ,
                       + itemRow.SubItems[19].Text + "`"
                       + (string.IsNullOrEmpty(itemRow.SubItems[1].Text) ? " " : itemRow.SubItems[1].Text) + "`"; // Remarks

               drugs += "~";
           }
           prs.Medicine = drugs;

           IPDDoctor oIPDDOc = new IPDDoctor();
           oIPDDOc.IPDVisitingFee = Convert.ToDouble(txtVisitingFee.Text);
           oIPDDOc.DoctorsVisitingFee = Convert.ToDouble(txtDocVisitingFee.Text);
           Iprs.IPDDoctor = oIPDDOc;

           EntryParameter ep = new EntryParameter();
           ep.EntryBy = Utility.UserId;
           ep.CompanyID = Utility.CompanyID;
           ep.LocationID = Utility.LocationID;
           ep.MachineID = Utility.MachineID;
           prs.EntryParameter = ep;

           Iprs.Patient = ipat;
           Iprs.Prescription = prs;

           return Iprs;
       }

       private void btnNew_Click(object sender, EventArgs e)
       {
           txtNurseStn.Text = "";
           txtPatRegNoIPD.ReadOnly = false;
           txtPatRegNoIPD.Enabled = true;
           btnFind.Enabled = true;
           lvSelectedTests.Items.Clear();
           lvDrugs.Items.Clear();
           lvAdvicePrescription.Items.Clear();
           txtDOB.Text = string.Empty;
           txtDoctorId.Text = string.Empty;
           txtDoctorName.Text = string.Empty;
           txtHCN.Text = string.Empty;
           txtPatName.Text = string.Empty;
           txtPatRegNoIPD.Text = string.Empty;
           txtPatRegNoIPD.Enabled = true;
           btnFind.Enabled = true;
           btnSave.Enabled = true;
       }

       private void txtNextVisitYear_Leave(object sender, EventArgs e)
       {
           if (txtNextVisitYear.Text == "")
           {
               txtNextVisitYear.Text = "0";
           }
       }

       private void txtNextVisitMonth_Leave(object sender, EventArgs e)
       {
           if (txtNextVisitMonth.Text == "")
           {
               txtNextVisitMonth.Text = "0";
           }
       }

       private void txtNextVisitDay_Leave(object sender, EventArgs e)
       {
           if (txtNextVisitDay.Text == "")
           {
               txtNextVisitDay.Text = "0";
           }
       }

       private void txtNextVisitYear_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
           {
               e.Handled = true;
           }
       }

       private void txtNextVisitMonth_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
           {
               e.Handled = true;
           }
       }

       private void txtNextVisitDay_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
           {
               e.Handled = true;
           }
       }

       private void txtNextVisitYear_KeyUp(object sender, KeyEventArgs e)
       {
           if (txtNextVisitYear.Text != "" && txtNextVisitYear.Text != "0")
           {
               txtNextVisit.Text = Utility.DateGenerator(DateTime.Now, int.Parse(txtNextVisitYear.Text), int.Parse(txtNextVisitMonth.Text), int.Parse(txtNextVisitDay.Text), 0).ToString("dd/MM/yyyy");
           }
       }

       private void txtNextVisitMonth_KeyUp(object sender, KeyEventArgs e)
       {
           if (txtNextVisitMonth.Text != "" && txtNextVisitMonth.Text != "0")
           {
               txtNextVisit.Text = Utility.DateGenerator(DateTime.Now, int.Parse(txtNextVisitYear.Text), int.Parse(txtNextVisitMonth.Text), int.Parse(txtNextVisitDay.Text), 0).ToString("dd/MM/yyyy");
           } 
       }

       private void txtNextVisitDay_KeyUp(object sender, KeyEventArgs e)
       {
           if (txtNextVisitDay.Text != "" && txtNextVisitDay.Text != "0")
           {
               txtNextVisit.Text = Utility.DateGenerator(DateTime.Now, int.Parse(txtNextVisitYear.Text), int.Parse(txtNextVisitMonth.Text), int.Parse(txtNextVisitDay.Text), 0).ToString("dd/MM/yyyy");
           }
       }

       private void btnDietAdvice_Click(object sender, EventArgs e)
       {

       }

       private void txtNextVisit_TextChanged(object sender, EventArgs e)
       {
            if (txtNextVisit.Text != "" && txtNextVisit.Text.Length == 10 && DateTime.Parse(txtNextVisit.Text) >= DateTime.Today)
           {
               DateTime now = DateTime.Today;
               DateTime NextVisitDate = DateTime.ParseExact(txtNextVisit.Text, "dd/MM/yyyy", null);

               TimeSpan ts =NextVisitDate - now.Date;
               int Y = (ts.Days / 365);
               int daysleft1 = ts.Days - (Y * 365);
               int M = (daysleft1 / 30);
               int daysleft2 = daysleft1 - (M * 30);
               int D = daysleft2;

               txtNextVisitYear.Text = Y.ToString();
               txtNextVisitMonth.Text = M.ToString();
               txtNextVisitDay.Text = D.ToString();
           }
           else
           {
               txtNextVisitYear.Text = "0";
               txtNextVisitMonth.Text = "0";
               txtNextVisitDay.Text = "0";
           }
       }

       private void txtDisDiagnosis_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
           {
               e.Handled = true;
           }
       }

       private void txtCaseSum_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
           {
               e.Handled = true;
           }
       }

       private void txtHospitalCourse_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
           {
               e.Handled = true;
           }
       }

       private void txtOperationNote_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
           {
               e.Handled = true;
           }
       }
       private void txtDietAdvice_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
           {
               e.Handled = true;
           }
       }
    }
}
