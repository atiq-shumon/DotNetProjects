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
using AH.ModuleController.UI.DRS.Reports.Viewer;
using System.Text.RegularExpressions;


namespace AH.ModuleController.UI.NWMS.Forms
{
    public partial class frmIPDPrescription : AH.Shared.UI.frmSmartFormStandard
    {
        NWMSSR.NWMSWSClient nwbnch = new NWMSSR.NWMSWSClient();
        string deptGrpID,dept_ID, unit_ID, doc_ID, bed_ID, mode;
        //public frmIPDPrescription(string deptGrpID,string dept_ID, string unit_ID, string doc_ID, string bed_ID,string mode)
        //{
        //    InitializeComponent();
        //    this.deptGrpID = deptGrpID;
        //    this.bed_ID = bed_ID;
        //    this.dept_ID = dept_ID;
        //    this.unit_ID = unit_ID;
        //    this.doc_ID = doc_ID;
        //    this.mode = mode;
        //}
        public frmIPDPrescription(string bed_ID, string mode)
        {
            InitializeComponent();
         //   this.deptGrpID = deptGrpID;
            this.bed_ID = bed_ID;
         //   this.dept_ID = dept_ID;
         //   this.unit_ID = unit_ID;
         //   this.doc_ID = doc_ID;
            this.mode = mode;
        }

        private void frmIPDPrescription_Load(object sender, EventArgs e)
        {
            //-------------------------------
            FormatComplaintsListView();
            FormatOComplaintsListView();
            FormatClinicalDiagnosisListView();
            FormatInvestigationsListView();
            FormatDrugsListView();
            FormatAdvicesListView();
            FormatdgvTestReceive();
            FormateAllProvidedDrugs();
            FormateDoctorsListView();
            //-------------------------------

            cboDepartmentGroup.DisplayMember = "Value";
            cboDepartmentGroup.ValueMember = "Key";
            cboDepartmentGroup.DataSource = new BindingSource(nwbnch.GetDeptGroupDicByType("01"), null);

            InPatient pat = nwbnch.GetPatRegID(bed_ID);
            txtPatRegNoIPD.Text = pat.RegistrationNo;
            this.btnFind.PerformClick();

           
        }
        private void FormateDoctorsListView()
        {
            lvIPDDoctors.Columns.Add("Department ID", 0, HorizontalAlignment.Left);//1
            lvIPDDoctors.Columns.Add("Department", 200, HorizontalAlignment.Left);//2
            lvIPDDoctors.Columns.Add("Unit ID", 0, HorizontalAlignment.Left);//3
            lvIPDDoctors.Columns.Add("Unit", 200, HorizontalAlignment.Left);//4
            lvIPDDoctors.Columns.Add("Doctor ID", 0, HorizontalAlignment.Left);//5
            lvIPDDoctors.Columns.Add("Doctor", 472, HorizontalAlignment.Left);//6
            lvIPDDoctors.Columns.Add("Visiting Fee", 0, HorizontalAlignment.Left);//7
            lvIPDDoctors.Columns.Add("Visit Number", 200, HorizontalAlignment.Left);//8
            lvIPDDoctors.Columns.Add("Visiting Date", 300, HorizontalAlignment.Left);//9
        }

        private void FormateAllProvidedDrugs()
        {
            lvAllProvidedDrugs.CheckBoxes = false;
            lvAllProvidedDrugs.Columns.Add("No.", 50, HorizontalAlignment.Left);//1
            lvAllProvidedDrugs.Columns.Add("Generic Name", 462, HorizontalAlignment.Left);//2
            lvAllProvidedDrugs.Columns.Add("Drug Name", 450, HorizontalAlignment.Left);//3
            lvAllProvidedDrugs.Columns.Add("Dose Details", 400, HorizontalAlignment.Left);//4
        }
        private void FormatdgvTestReceive()
        {
            dgvTestReceive.AutoGenerateColumns = false;
            dgvTestReceive.ColumnCount = 15;

            dgvTestReceive.Columns[0].Name = "Requisition ID";
            dgvTestReceive.Columns[0].ReadOnly = true;
            dgvTestReceive.Columns[0].Width = 161;
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
            dgvTestReceive.Columns[4].Width = 200;
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
            dgvTestReceive.Columns[11].Width = 200;
            dgvTestReceive.Columns[11].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvTestReceive.Columns[12].Name = "Diagnostic MR";
            dgvTestReceive.Columns[12].ReadOnly = true;
            dgvTestReceive.Columns[12].Width = 100;
            dgvTestReceive.Columns[12].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvTestReceive.Columns[13].Name = "Section ID";
            dgvTestReceive.Columns[13].ReadOnly = true;
            dgvTestReceive.Columns[13].Visible = false;
            dgvTestReceive.Columns[13].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvTestReceive.Columns[14].Name = "Result ID";
            dgvTestReceive.Columns[14].ReadOnly = true;
            dgvTestReceive.Columns[14].Width = 100;
            dgvTestReceive.Columns[14].DefaultCellStyle.Font = new Font("Tahoma", 8.25F);

            dgvTestReceive.Columns.Add(CreateGridColumnButtonFormat("Result Preview", "View Report")); 

         /*   DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "Result Preview";
            btn.HeaderText = "Result Preview";
            btn.Text = "View";
            btn.ReadOnly = true;
            btn.Width = 150;
            btn.DefaultCellStyle.Font = new Font("Tahoma", 8.25F);
            dgvTestReceive.Columns.Add(btn);
         */                  
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


#region getDataOnFindButtonClick
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
                
                LoadPatient(pat);

                if (txtDOB.Text != "")
                {
                   // txtDeptGrpID.Text = deptGrpID;
                  //  txtDepartmentId.Text = dept_ID;
                  //  txtUnitId.Text = unit_ID;
                  //  txtDoctorId.Text = doc_ID;
                  //  IPDDoctor Doc = nwbnch.GetDoctorsDetails(txtDoctorId.Text);

                  //  txtDoctorName.Text = Doc.Name;
                 //   txtVisitingFee.Text = Convert.ToString( Doc.IPDVisitingFee);
                  //  txtDocVisitingFee.Text = Convert.ToString(Doc.DoctorsVisitingFee);
                    LoadDoctorsVisitList();


                    //--------------------Load Test--------------
                    LoadProvidedTest();
                    LoadAllProvidedDrugs();
                    txtPatRegNoIPD.Enabled = false;
                    btnFind.Enabled = false;
                }
            }
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
        private void LoadAllProvidedDrugs()
        {
            lvAllProvidedDrugs.Items.Clear();
            List<DrugDose> oMedicines = new List<DrugDose>();
            oMedicines = nwbnch.GetAllProvidedDrugs(txtPatRegNoIPD.Text).ToList();
            if (oMedicines.Count > 0)
            {
                foreach (DrugDose oPrsDrugs in oMedicines)
                {
                    ListViewItem itm = new ListViewItem(oPrsDrugs.DrugMaster.ID);
                    itm.SubItems.Add(oPrsDrugs.DrugMaster.DrugGroup.Name);
                    itm.SubItems.Add(oPrsDrugs.DrugMaster.Name);
                    itm.SubItems.Add(oPrsDrugs.B_A_MealName);
                    lvAllProvidedDrugs.Items.Add(itm);
                }
            }
        }

        private void LoadProvidedTest()
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
        private void txtPatRegNoIPD_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPatRegNoIPD.Text.Length == Utility.ScanLength)
            {
                btnFind_Click(sender, e);
            }
        }
        private void LoadPatHealthInfo(OPDDoctorCallQ HealthInfo)
        {
            //---------------------------------------------
            if (HealthInfo.Allergy != "0" && HealthInfo.Allergy != null && HealthInfo.Allergy != "")
            {
                chkAllergy.Checked = true;
                txtAllergy.Text = HealthInfo.Allergy;
            }
            if (HealthInfo.Allergy == "0" || HealthInfo.Allergy == null || HealthInfo.Allergy == "")
            {
                chkAllergy.Checked = false;
                txtAllergy.Text = string.Empty;
            }

            //-----------------------------------------------
           // chk(chkGastric, HealthInfo.Gastric);
            chk(chkAsthma, HealthInfo.Asthma);
            chk(chkDiabetes, HealthInfo.Diabetes);
            //-----------------------------------------------

            if (HealthInfo.Pressure == "N" || HealthInfo.Pressure == null || HealthInfo.Pressure == "")
            {
                cboPressure.SelectedIndex = 0;        
            }
            if (HealthInfo.Pressure == "H")
            {
                cboPressure.SelectedIndex = 1;
            }
            if (HealthInfo.Pressure == "L")
            {
                cboPressure.SelectedIndex = 2;
            }

            //-----------------------------------------------
            chk(chkHeartDisease, HealthInfo.HeartDisease);
            chk(chkKidneyDisease, HealthInfo.KidneyDisease);
           // chk(chkTuberculosis, HealthInfo.Tuberculosis);
            //-----------------------------------------------
            disablechk();
        }

        private void chk(CheckBox chk, string value)
        {
            if (value == "1")
            {
                chk.Checked = true;
                chk.Enabled = false;
            }
            else if (value == "0")
            {
                chk.Checked = false;
                chk.Enabled = false;
            }
            else
            {
                chk.Checked = false;
                chk.Enabled = false;
            }
        }
 
        private void disablechk()
        {
            chkAllergy.Enabled = false;
            txtAllergy.Text = string.Empty;

           // chkGastric.Enabled = false;
            chkAsthma.Enabled = false;
            chkDiabetes.Enabled = false;

            chkPressure.Enabled = false;
            cboPressure.Enabled = false;
            cboPressure.SelectedIndex = 0;

            chkHeartDisease.Enabled = false;
            chkKidneyDisease.Enabled = false;
           // chkTuberculosis.Enabled = false;
        }

        private void enablechk()
        {
            chkAllergy.Checked = false;
            chkAllergy.Enabled = true;
            txtAllergy.Text = string.Empty;

         //   chkGastric.Enabled = true;
          //  chkGastric.Checked = false;

            chkAsthma.Enabled = true;
            chkAsthma.Checked = false;

            chkDiabetes.Enabled = true;
            chkDiabetes.Checked = false;

            chkPressure.Enabled = true;
            chkPressure.Checked = false;
            cboPressure.Enabled = true;
            cboPressure.SelectedIndex = 0;

            chkHeartDisease.Enabled = true;
            chkHeartDisease.Checked = false;

            chkKidneyDisease.Enabled = true;
            chkKidneyDisease.Checked = false;

          //  chkTuberculosis.Enabled = true;
          //  chkTuberculosis.Checked = false;
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

#endregion getDataOnFindButtonClick
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtNurseStn.Text = "";
            txtPatRegNoIPD.ReadOnly = false;
            txtPatRegNoIPD.Enabled = true;
            btnFind.Enabled = true;
            enablechk();
            lvComplaints.Items.Clear();
            lvOtherComplaints.Items.Clear();
            lvCollectedClinicalDiagnosis.Items.Clear();
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
        }

#region ListViewsFormating
        private void FormatComplaintsListView()
        {
            lvComplaints.CheckBoxes = false;
            lvComplaints.Columns.Add("ID", 0, HorizontalAlignment.Center);
            lvComplaints.Columns.Add("Complaints(s)", 120, HorizontalAlignment.Left);
            lvComplaints.Columns.Add("Additional Information", 200, HorizontalAlignment.Left);
        }
        private void FormatOComplaintsListView()
        {
            lvOtherComplaints.CheckBoxes = false;
            lvOtherComplaints.Columns.Add("ID", 0, HorizontalAlignment.Center);
            lvOtherComplaints.Columns.Add("Complaints(s)", 120, HorizontalAlignment.Left);
            lvOtherComplaints.Columns.Add("Additional Information", 200, HorizontalAlignment.Left);
        }
        private void FormatClinicalDiagnosisListView()
        {
            lvCollectedClinicalDiagnosis.CheckBoxes = false;
            lvCollectedClinicalDiagnosis.Columns.Add("DiagID", 0, HorizontalAlignment.Center);
            lvCollectedClinicalDiagnosis.Columns.Add("Diagnosis(s)", 120, HorizontalAlignment.Left);
            lvCollectedClinicalDiagnosis.Columns.Add("Additional Information", 200, HorizontalAlignment.Left);
        }
        private void FormatInvestigationsListView()
        {
            lvSelectedTests.CheckBoxes = false;
            lvSelectedTests.Columns.Add("Investigation(s)", 471, HorizontalAlignment.Left);
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
            lvDrugs.Columns.Add("At a Glance", 694, HorizontalAlignment.Left);
            lvDrugs.Columns.Add("Remarks", 200, HorizontalAlignment.Left);
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
            lvAdvicePrescription.Columns.Add("Advices", 667, HorizontalAlignment.Left);
            lvAdvicePrescription.Columns.Add("Additional Advices", 0, HorizontalAlignment.Left);
            lvAdvicePrescription.Columns.Add("Flag", 0, HorizontalAlignment.Left);
            lvAdvicePrescription.Columns.Add("Department", 0, HorizontalAlignment.Left);
            lvAdvicePrescription.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
        }
#endregion ListViewsFormating

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            //if (txtPatRegNoIPD.Text != "")
            //{
            //    frmIPDAddToPrescription ad = new frmIPDAddToPrescription(AddFromPrescription(), 0, txtAgeY.Text);
            //    ad.onSaveButtonClicked = new frmIPDAddToPrescription.SaveButtonClick(AddToPrescription);
            //    ad.ShowDialog();
            //};
        }
        private void btnOtherComplaints_Click(object sender, EventArgs e)
        {
            //if (txtPatRegNoIPD.Text != "")
            //{
            //    frmIPDAddToPrescription ad = new frmIPDAddToPrescription(AddFromPrescription(), 0, txtAgeY.Text);
            //    ad.onSaveButtonClicked = new frmIPDAddToPrescription.SaveButtonClick(AddToPrescription);
            //    ad.ShowDialog();
            //}
        }
        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            //if (txtPatRegNoIPD.Text != "")
            //{
            //    frmIPDAddToPrescription ad = new frmIPDAddToPrescription(AddFromPrescription(), 0, txtAgeY.Text);
            //    ad.onSaveButtonClicked = new frmIPDAddToPrescription.SaveButtonClick(AddToPrescription);
            //    ad.ShowDialog();
            //}
        }
        private void btnAddInvestigation_Click(object sender, EventArgs e)
        {
            if (txtPatRegNoIPD.Text != "")
            {
                frmIPDAddToPrescription ad = new frmIPDAddToPrescription(AddFromPrescription(), 0, txtAgeY.Text, mode, txtVisitNumber.Text);
                ad.onSaveButtonClicked = new frmIPDAddToPrescription.SaveButtonClick(AddToPrescription);
                ad.ShowDialog();
            }
        }
        
        private void btnAddDrugs_Click(object sender, EventArgs e)
        {
            if (txtPatRegNoIPD.Text != "")
            {
                frmIPDAddToPrescription ad = new frmIPDAddToPrescription(AddFromPrescription(), 1, txtAgeY.Text, mode, txtVisitNumber.Text);
                ad.onSaveButtonClicked = new frmIPDAddToPrescription.SaveButtonClick(AddToPrescription);
                ad.ShowDialog();
            }
        }
        private void btnAddAdvice_Click(object sender, EventArgs e)
        {
            //if (txtPatRegNoIPD.Text != "")
            //{
            //    frmIPDAddToPrescription ad = new frmIPDAddToPrescription(AddFromPrescription(), 3, txtAgeY.Text);
            //    ad.onSaveButtonClicked = new frmIPDAddToPrescription.SaveButtonClick(AddToPrescription);
            //    ad.ShowDialog();
            //}
        }

       private Prescription AddFromPrescription()
       {
            Prescription oPrescription = new Prescription();
            oPrescription.ComplaintsList = GetSelectedComplaints().ToArray();
            oPrescription.OtherComplaintsList = GetSelectedOComplaints().ToArray();
            oPrescription.ClinicalDiagnosisList = GetSelectedClinicalDiagnosis().ToArray();
            oPrescription.TestsList = GetSelectedTests().ToArray();
            oPrescription.DrugsList = GetSelectedMedicines().ToArray();
            oPrescription.AdvicesList = GetSelectedAdvices().ToArray();
            return oPrescription;
       }

#region GetSelected
       private List<Complaints> GetSelectedComplaints()
       {
           List<Complaints> Complaints = new List<Complaints>();
           for (int i = 0; i < lvComplaints.Items.Count; i++)
           {
               Complaints oComplain = new Complaints();
               oComplain.ID = lvComplaints.Items[i].SubItems[0].Text;
               oComplain.ComplaintTitle = lvComplaints.Items[i].SubItems[1].Text;
               oComplain.Remarks = lvComplaints.Items[i].SubItems[2].Text;
               Complaints.Add(oComplain);
           }
           return Complaints;
       }
       private List<Complaints> GetSelectedOComplaints()
       {
           List<Complaints> OComplaints = new List<Complaints>();
           for (int i = 0; i < lvOtherComplaints.Items.Count; i++)
           {
               Complaints oComplain = new Complaints();
               oComplain.ID = lvOtherComplaints.Items[i].SubItems[0].Text;
               oComplain.ComplaintTitle = lvOtherComplaints.Items[i].SubItems[1].Text;
               oComplain.Remarks = lvOtherComplaints.Items[i].SubItems[2].Text;
               OComplaints.Add(oComplain);
           }
           return OComplaints;
       }
       private List<ClinicalDiagnosis> GetSelectedClinicalDiagnosis()
       {
           List<ClinicalDiagnosis> Diagnosis = new List<ClinicalDiagnosis>();
           for (int i = 0; i < lvCollectedClinicalDiagnosis.Items.Count; i++)
           {
               ClinicalDiagnosis oDiagnosis = new ClinicalDiagnosis();
               oDiagnosis.DiagID = lvCollectedClinicalDiagnosis.Items[i].SubItems[0].Text;
               oDiagnosis.DiagTitle = lvCollectedClinicalDiagnosis.Items[i].SubItems[1].Text;
               oDiagnosis.Remarks = lvCollectedClinicalDiagnosis.Items[i].SubItems[2].Text;
               Diagnosis.Add(oDiagnosis);
           }
           return Diagnosis;
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
             //  oOPDAdvice.AdvicePart1 = lvAdvicePrescription.Items[i].SubItems[1].Text;
              // oOPDAdvice.AdvicePart2 = lvAdvicePrescription.Items[i].SubItems[2].Text;
              // oOPDAdvice.Part2ReqFlag = lvAdvicePrescription.Items[i].SubItems[3].Text;

               Department dp = new Department();
               dp.DepartmentID = lvAdvicePrescription.Items[i].SubItems[4].Text;
               oOPDAdvice.Department = dp;

               // oOPDAdvice.Department.DepartmentID= lvAdvicePrescription.Items[i].SubItems[4].Text;
               oOPDAdvice.Remarks = lvAdvicePrescription.Items[i].SubItems[5].Text;
               Advices.Add(oOPDAdvice);
           }
           return Advices;
       }

#endregion GetSelected
       private void AddToPrescription(Prescription oPres, object sender, EventArgs e)
       {
          // List<Complaints> oComp = oPres.ComplaintsList.ToList();
         //  List<Complaints> oOtherComp = oPres.OtherComplaintsList.ToList();
         //  List<ClinicalDiagnosis> oDiag = oPres.ClinicalDiagnosisList.ToList();
           List<TestSub> oTest = oPres.TestsList.ToList();
           List<DrugDose> oDrugs = oPres.DrugsList.ToList();
          // List<OPDAdvice> oAdvice = oPres.AdvicesList.ToList();

          // AddDataToComplaintsView(oComp, sender, e);
         //  AddDataToOComplaintsView(oOtherComp, sender, e);
         //  AddDataToClinicalDiagnosisView(oDiag, sender, e);
           AddDataToInvestigationView(oTest, sender, e);
           AddDataToDrugView(oDrugs, sender, e);
         //  AddDataToAdviceView(oAdvice, sender, e);
       }

#region AddDataTo
       private void AddDataToComplaintsView(List<Complaints> oComp, object sender, EventArgs e)
       {
           try
           {
               lvComplaints.Items.Clear();
               foreach (Complaints lvcomp in oComp)
               {
                   ListViewItem itm = new ListViewItem(lvcomp.ID); //id
                   itm.SubItems.Add(lvcomp.ComplaintTitle); //title
                   itm.SubItems.Add(lvcomp.Remarks); //additional
                   lvComplaints.Items.Add(itm);
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
       private void AddDataToOComplaintsView(List<Complaints> oOtherComp, object sender, EventArgs e)
       {
           try
           {
               lvOtherComplaints.Items.Clear();
               foreach (Complaints lvcomp in oOtherComp)
               {
                   ListViewItem itm = new ListViewItem(lvcomp.ID); //id
                   itm.SubItems.Add(lvcomp.ComplaintTitle); //title
                   itm.SubItems.Add(lvcomp.Remarks); //additional
                   lvOtherComplaints.Items.Add(itm);
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
       private void AddDataToClinicalDiagnosisView(List<ClinicalDiagnosis> oDiag, object sender, EventArgs e)
       {
           try
           {
               lvCollectedClinicalDiagnosis.Items.Clear();
               foreach (ClinicalDiagnosis lvcomp in oDiag)
               {
                   ListViewItem itm = new ListViewItem(lvcomp.DiagID); //id
                   itm.SubItems.Add(lvcomp.DiagTitle); //title
                   itm.SubItems.Add(lvcomp.Remarks); //additional
                   lvCollectedClinicalDiagnosis.Items.Add(itm);
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
                  // itm.SubItems.Add(oa.AdvicePart1);
                  // itm.SubItems.Add(oa.AdvicePart2);
                  // itm.SubItems.Add(oa.Part2ReqFlag);
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
           if (cboDoctor.SelectedValue != "" && cboDoctor.SelectedValue != null && cboDoctor.Text != "(Collection)")
           {
               if (mode == "V")
               {
                   DialogResult dr = MessageBox.Show("Do you want to save IPD Visiting Details ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                   if (dr == DialogResult.Yes)
                   {
                       List<string> vf = new List<string>() { "txtPatRegNoIPD" };
                       Control control = Utility.ReqFieldValidator(this, vf);
                       if (control != null)
                       {
                           MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           control.Focus();
                           return;
                       }
                       try
                       {
                           // if (lvSelectedTests.Items.Count > 0 || lvDrugs.Items.Count > 0)
                           if (txtDoctorId.Text != "")
                           {
                               IPDPrescription tcats = this.PopulatePrescription();
                               short i = nwbnch.SaveIPDPrescription(tcats);
                               if (i == 0)
                               {
                                   MessageBox.Show("Data insertion failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                               }
                               else
                               {
                                   MessageBox.Show("Data insertion Successful", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   btnNew.PerformClick();
                                   this.Dispose();
                               }
                           }

                           else
                           {
                               MessageBox.Show("Select Doctor", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
               }

               if (mode == "VE")
               {
                   DialogResult dr = MessageBox.Show("Do you want to edit IPD Visiting Details ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                   if (dr == DialogResult.Yes)
                   {
                       List<string> vf = new List<string>() { "txtPatRegNoIPD" };
                       Control control = Utility.ReqFieldValidator(this, vf);
                       if (control != null)
                       {
                           MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           control.Focus();
                           return;
                       }
                       try
                       {
                           if (txtDoctorId.Text != "")
                           {
                               IPDPrescription tcats = this.PopulatePrescription();
                               short i = nwbnch.EditIPDPrescription(tcats);
                               if (i == 0)
                               {
                                   MessageBox.Show("Data Update failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                               }
                               else
                               {
                                   MessageBox.Show("Data Update Successful", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   btnNew.PerformClick();
                                   this.Dispose();
                               }
                           }
                           else
                           {
                               MessageBox.Show("Select Doctor", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
               }
           }
           else
           {
               MessageBox.Show("Select Doctor", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
            
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
           //bed.Facility = txtBedFecilityID.Text;
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

           prs.OtherComplaints = Ocomplaints;

           //------------------ Add Advice ----------------------------

           string AddAdvice = "";
           foreach (ListViewItem itemRow in lvAdvicePrescription.Items)
           {
               AddAdvice += itemRow.SubItems[0].Text + ":"
                         + itemRow.SubItems[1].Text + ":"
                         + itemRow.SubItems[2].Text + ":"
                         + itemRow.SubItems[3].Text + ":"
                         + itemRow.SubItems[4].Text + ":"
                         + itemRow.SubItems[5].Text;
               AddAdvice += ";";
           }
           prs.Advice = AddAdvice;

           //------------------ End Add Advice -----------------------  */
#endregion Commented

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

           Iprs.DocVisitID = txtVisitNumber.Text;
           Iprs.Patient = ipat;
           Iprs.Prescription = prs;

           return Iprs;
       }

       private void lvSelectedTests_MouseDoubleClick(object sender, MouseEventArgs e)
       {
         //  listViewSelectedItem(lvSelectedTests);   
       }

       private void lvDrugs_MouseDoubleClick(object sender, MouseEventArgs e)
       {
         //  listViewSelectedItem(lvDrugs);   
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

       private void dgvTestReceive_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
       {
           if (e.ColumnIndex == 15 && e.RowIndex != -1)
           {
             //  printResultPreview(dgvTestReceive.Rows[e.RowIndex].Cells[e.ColumnIndex-2].Value.ToString(), dgvTestReceive.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Value.ToString(), dgvTestReceive.Rows[e.RowIndex].Cells[e.ColumnIndex-8].Value.ToString());

               if (dgvTestReceive.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString() != "")
               {
                   printResult(dgvTestReceive.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString(), dgvTestReceive.Rows[e.RowIndex].Cells[e.ColumnIndex - 9].Value.ToString());
               }
               else
               {
                   MessageBox.Show("Result is not finalised Yet", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }
           }
       }
       private void printResult(string resultId, string reportGrp)
       {
           frmReportViewer vr = new frmReportViewer();
           vr.selector = ViewerSelector.InvestigationReport;
          
           if (reportGrp == "0021")
           {
               vr.selector = ViewerSelector.StainReport;
           }
           else if (reportGrp == "0020")
           {
               vr.selector = ViewerSelector.multicolumn;
           }
           else
           {
               vr.selector = ViewerSelector.InvestigationReport;
           }

           vr.TransactionNo = resultId;
           vr.ViewReport();
       }

       private void lvIPDDoctors_SelectedIndexChanged(object sender, EventArgs e)
       {
           if (lvIPDDoctors.SelectedItems.Count > 0 && mode == "VE")
           {
               txtVisitNumber.Text = string.Empty;

               ListViewItem itm = lvIPDDoctors.SelectedItems[0];
               txtVisitNumber.Text = itm.SubItems[7].Text;
               if (itm.SubItems[4].Text == txtDoctorId.Text)
               {
                   IPDPrescription Iprs =nwbnch.GetIPDPrescriptionForEdit(itm.SubItems[7].Text,txtPatRegNoIPD.Text);
                   LoadDetailsForEdit(Iprs);
                   smartTab1.SelectedIndex = 0;
               }
               else
               {
                   MessageBox.Show("Sorry, Can not change other doctor's visit Details", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }
           }
       }
       private void LoadDetailsForEdit(IPDPrescription prs)
       {
           lvSelectedTests.Items.Clear();
           lvDrugs.Items.Clear();

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

 //-----------------------------------------==================================-----------------------------------------//
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

//-----------------------------------------==================================-----------------------------------------//

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

//-----------------------------------------==================================-----------------------------------------//

                   ListViewItem itm = new ListViewItem(ATaGlance);
                   itm.SubItems.Add(parts[0].ToString()); //remarks
                   itm.SubItems.Add(parts[1].ToString()); //comp_ID
                   itm.SubItems.Add(parts[2].ToString()); //Group_ID  
                   itm.SubItems.Add(parts[3].ToString()); // unit_ID
                   itm.SubItems.Add(parts[4].ToString()); //drug_type_ID
                   itm.SubItems.Add(parts[5].ToString()); //drug_ID
                   itm.SubItems.Add(parts[6].ToString()); //drug_name
                   itm.SubItems.Add(parts[7].ToString()); //Dose_str
                   itm.SubItems.Add(parts[8].ToString()); //consumptionform
                   itm.SubItems.Add(parts[9].ToString()); // 0= hour_Gap
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

       private void cboDoctor_SelectedIndexChanged(object sender, EventArgs e)
       {
           if (cboDoctor.SelectedValue != "" && cboDoctor.SelectedValue != null && cboDoctor.Text != "(Collection)")
           {
               txtDeptGrpID.Text = cboDepartmentGroup.SelectedValue.ToString();
               txtDepartmentId.Text = cboDepartment.SelectedValue.ToString();
               txtUnitId.Text = cboUnit.SelectedValue.ToString();
               txtDoctorId.Text  = cboDoctor.SelectedValue.ToString();
               
               IPDDoctor Doc = nwbnch.GetDoctorsDetails(txtDoctorId.Text);
               txtDoctorName.Text = Doc.Name;
               txtVisitingFee.Text = Convert.ToString(Doc.IPDVisitingFee);
               txtDocVisitingFee.Text = Convert.ToString(Doc.DoctorsVisitingFee);
           }

       }
    }
}
