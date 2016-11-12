using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.OPDSR;
using AH.ModuleController.UI.OPD.Reports.Viewer;
using System.Text.RegularExpressions;

namespace AH.ModuleController.UI.OPD.Forms
{
    public partial class frmPrescription : AH.Shared.UI.frmSmartFormStandard
    { 
        OPDSR.OPDWSClient opdsr = new OPDSR.OPDWSClient();
        string Edit = "";
        string DiagnosticTest;

        private string doctorID;
        private string departmentID;
        private string unitId;

        private string DrRoomNo = "";
        int time = 1;
        List<Complaints> complaintsList;
        List<ClinicalDiagnosis> diagnosisList;
        public string strAdvice { get; set; }
        private string[] id;

        //-----------CF--------------------
        List<ClinicalFindings> oCfTrees = new List<ClinicalFindings>();
        List<string> oCategories = new List<string>();
        List<string> oGroups = new List<string>();
        List<ClinicalFindingsValueAssign> cfv;
        //--------------------

        public frmPrescription(string Edit)
        {
            InitializeComponent();
            this.Edit = "E";
        }
        public frmPrescription(string departmentID,string unitId,string doctorID, string DocRoom)
        {
            DrRoomNo = DocRoom;

            this.doctorID = doctorID;
            this.departmentID = departmentID;
            this.unitId = unitId;

            InitializeComponent();
            txtDepartment.Text = departmentID;
            txtDepartmentUnit.Text = unitId;
            txtDoctorID.Text = doctorID;
        }

        private void chkReferTo_CheckedChanged(object sender, EventArgs e)
        {
            if(chkReferTo.Checked == true)
            {
                cboDepartment.Enabled = true;
                cboUnit.Enabled = true;
                cboDoctor.Enabled = true;
            }
            if (chkReferTo.Checked == false)
            {
                cboDepartment.Enabled = false;
                cboUnit.Enabled = false;
                cboDoctor.Enabled = false;
            }
        } 
        private void btnAddInvestigation_Click(object sender, EventArgs e)
        {
            if (txtPatientName.Text == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPrescriptionNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPatientName.Focus();
                return;
            };

          //  frmInvestigationEntry ie = new frmInvestigationEntry(GetAddedTests());
          //  ie.onAddAllButtonClicked = new frmInvestigationEntry.AddAllClick(AddDataToDiagnosticView);
          //  ie.ShowDialog();

            frmAddToPrescription ad = new frmAddToPrescription(AddFromPrescription(), 3, txtAgeYears.Text, txtDepartment.Text, txtDepartmentUnit.Text);
            ad.onSaveButtonClicked = new frmAddToPrescription.SaveButtonClick(AddToPrescription);
            ad.ShowDialog();
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
       
        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            if (txtPrescriptionNo.Text == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPrescriptionNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrescriptionNo.Focus();
                return;
            };
            string msg = opdsr.VerifyTicketNo(txtPrescriptionNo.Text, false);
            if (Edit == "E")
            {
                if(msg == " Shown to Doctor")
                {
                    disablechk();
                    Ticket pat = opdsr.GetTicket(txtPrescriptionNo.Text);
                    LoadPatient(pat);
                    txtPrescriptionNo.Select();
                    Prescription prs = opdsr.GetPrescriptionForEdit(txtPrescriptionNo.Text);
                    Casting(prs);
                }
            }
            else
            {
                if (msg == "1")
                {
                    disablechk();
                    Ticket pat = opdsr.GetTicket(txtPrescriptionNo.Text);

                    LoadPatient(pat);
                    txtPrescriptionNo.Select();
                }
                else
                {
                    MessageBox.Show(msg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrescriptionNo.Focus();
                    return;
                }
            }

           
        }

        private void Casting(Prescription prs)
        {
            lvComplaints.Items.Clear();
            lvClinicalFindings.Items.Clear();
            lvCollectedClinicalDiagnosis.Items.Clear();
            lvSelectedTests.Items.Clear();
            lvDrugs.Items.Clear();
            lvAdvicePrescription.Items.Clear();

            if (prs.Complaints.Length > 0)
            {
                string vComp = prs.Complaints;
                string[] lines = Regex.Split(vComp, "~");

                for (int i = 0; i < lines.Length; i++)
                {
                    string complaints = lines[i].ToString();
                    string[] parts = Regex.Split(complaints, "`");

                    ListViewItem itm = new ListViewItem(parts[0].ToString()); 
                                 itm.SubItems.Add(parts[1].ToString());
                                 itm.SubItems.Add(parts[2].ToString());
                                 lvComplaints.Items.Add(itm);
                }
            }
            if (prs.ClinicalFindings.Length > 0)
            {
                string vCF = prs.ClinicalFindings;
                string[] lines = Regex.Split(vCF, "~");

                for (int i = 0; i < lines.Length; i++)
                {
                    string CF = lines[i].ToString();
                    string[] parts = Regex.Split(CF, "`");

                    ListViewItem itm = new ListViewItem(parts[0].ToString());
                    itm.SubItems.Add(parts[1].ToString());
                    itm.SubItems.Add(parts[2].ToString());
                    itm.SubItems.Add(parts[3].ToString());
                    itm.SubItems.Add(parts[4].ToString());
                    lvClinicalFindings.Items.Add(itm);
                }
            }

            if (prs.ClinicalDiagnosis.Length > 0)
            {
                string vCDiag = prs.ClinicalDiagnosis;
                string[] lines = Regex.Split(vCDiag, "~");

                for (int i = 0; i < lines.Length; i++)
                {
                    string ClinicalDiag = lines[i].ToString();
                    string[] parts = Regex.Split(ClinicalDiag, "`");

                    ListViewItem itm = new ListViewItem(parts[0].ToString());
                    itm.SubItems.Add(parts[1].ToString());
                    itm.SubItems.Add(parts[2].ToString());
                    lvCollectedClinicalDiagnosis.Items.Add(itm);
                }
            }
            if (prs.CollTests.Length > 0)
            {
                string vCTest = prs.CollTests;
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

            if (prs.Medicine.Length > 0)
            {
                string MealConcat = "";
                string ATaGlance = "";
                string vMed = prs.Medicine;
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
                                MealConcat = parts[22].ToString() + "  " + parts[21].ToString() +
                                                            parts[20].ToString() + " ";
                            }
                            else
                            {
                                MealConcat = parts[22].ToString() + "  " + parts[21].ToString() + " " + " of " +
                                     parts[20].ToString() + " ";
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

            if (prs.Advice.Length > 0)
            {
                string vAdv = prs.Advice;
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
          
            //if (prs.comorbidIllness.Length > 0)
            //{
            //    string vComorbid = prs.comorbidIllness;
            //    string[] parts = Regex.Split(vComorbid, "`");

            //    assignValue(parts[0].ToString(), parts[1].ToString(), chkAllergy, chkAllergy1, txtAllergy);
            //    assignValue(parts[2].ToString(), parts[3].ToString(), chkAsthma, chkAsthma1, txtAsthma);
            //    assignValue(parts[4].ToString(), parts[5].ToString(), chkDiabetes, chkDiabetes1, txtDiabetes);
            //    assignValue(parts[6].ToString(), parts[7].ToString(), chkHypertension, chkHypertension1, txtHypertension);
            //    assignValue(parts[8].ToString(), parts[9].ToString(), chkHeartDisease, chkHeartDisease1, txtHeartDisease);
            //    assignValue(parts[10].ToString(), parts[11].ToString(), chkKidneyDisease, chkKidneyDisease1, txtKidneyDisease);
            //    assignValue(parts[12].ToString(), parts[13].ToString(), chkOtherDisease, chkOtherDisease1, txtOtherDisease);
            //    assignValue(parts[14].ToString(), parts[15].ToString(), chkPMedHis, chkPMedHis1, txtPMedHis);
            //    assignValue(parts[16].ToString(), parts[17].ToString(), chkPSurgHis, chkPSurgHis1, txtPSurgHis);
            //    assignValue(parts[18].ToString(), parts[19].ToString(), chkFamilyHis, chkFamilyHis1, txtFamilyHis);
            //}

            //if (prs.paediatricHis.Length > 0)
            //{
            //    string vPaediatric = prs.paediatricHis;
            //    string[] parts = Regex.Split(vPaediatric, "`");

            //    assignValuePaed(parts[0].ToString(), parts[1].ToString(), rdoAntenatalN, rdoAntenatalAbN , txtAntenatal);
            //    assignValuePaed(parts[2].ToString(), parts[3].ToString(), rdoNatalN, rdoNatalCS, txtNatal);
            //    assignValuePaed(parts[4].ToString(), parts[5].ToString(), rdoPostNUn, rdoPostNCom, txtPostNatal);

              //  assignValuePaed2(parts[6].ToString(), parts[7].ToString(), chkExFeed, txtExFeedHis);
            //    assignValuePaed2(parts[8].ToString(), parts[9].ToString(), chkCompFeed, txtCompFeedHis1);
            //    assignValuePaed2(parts[8].ToString(), parts[10].ToString(), chkCompFeed, txtCompFeedHis2);
            //    assignValuePaed2(parts[11].ToString(), parts[12].ToString(), chkPresentFeed,txtPresFeed);

            //    assignValuePaed(parts[13].ToString(), parts[14].ToString(), rdoMSTNAppro, rdoMSTNDelay, txtMSTNDev);
            //    assignValuePaed(parts[15].ToString(), parts[16].ToString(), rdoImmuUTD, rdoImmuMiss, txtImmu);
            //    assignValuePaed3(parts[17].ToString(), parts[18].ToString(), rdoEecoHis , txtEcoHis);
            //}


            if (prs.Refered.Length > 0)
            {
                string vRefered = prs.Refered;
                string[] parts = Regex.Split(vRefered, "`");
                if (parts[0].ToString() !="0")
                {
                    chkReferTo.Checked = true;
                    cboDepartment.SelectedValue = parts[0].ToString();
                    cboUnit.SelectedValue = parts[1].ToString();
                    if (parts[2].ToString() != "0")
                    {
                        cboDoctor.SelectedValue = parts[2].ToString();
                    }
                }
               
            }
        }
        private void FormatGrids()
        {
            lvTicketList.CheckBoxes = false;
            lvTicketList.Columns.Add("Patient Name", 160, HorizontalAlignment.Left);
            
            lvTicketList.Columns.Add("Prescription No", 150, HorizontalAlignment.Left);
            lvTicketList.Columns.Add("HCN", 150, HorizontalAlignment.Left);
            //lvTicketList.Columns.Add("Patient Name", 150, HorizontalAlignment.Left);
            lvTicketList.Columns.Add("TStatus", 50, HorizontalAlignment.Left);
       }
        //private void FormatOPDHistory()
        //{
        //    lstOpdHistory.Columns.Add("Visit", 100, HorizontalAlignment.Center);
        //    lstOpdHistory.Columns.Add("Pathological", 100, HorizontalAlignment.Center);
        //    lstOpdHistory.Columns.Add("Admission", 100, HorizontalAlignment.Center);
        //}
        private void LoadTicket(string doctorID)
        {
            lvTicketList.Items.Clear();
            //List<Ticket> tkt = opdsr.GetPrescriptionList(doctorID).ToList();
            List<Ticket> tkt = opdsr.GetPatDoc(doctorID).ToList();

           
            foreach (Ticket tck in tkt)
            {
                if (tck.TicketStatus == "V")
                {
                    ListViewItem itm = new ListViewItem(tck.Patient.Name);
                    itm.SubItems.Add(tck.TicketNo);
                    itm.SubItems.Add(tck.Patient.HCN);
                    // itm.SubItems.Add(tck.Patient.Name);//..........................
                    itm.SubItems.Add(tck.TicketStatus);
                    lvTicketList.Items.Add(itm);
                    if (itm.SubItems[3].Text.ToString() == "V")
                    {
                        itm.SubItems[0].BackColor = Color.Red;
                    }
                }
            }
            //for (int j = 0; i < lvTicketList.Items.Count; j++)
            //{
            //    if (lvTicketList.Items[j].SubItems[3].Text.ToString()=="V")
            //    {
            //        lvTicketList.Items[j].SubItems[0].BackColor = Color.Red;
            //    }
            //}
        }

        private void disablechk()
        {
            chkAllergy1.Checked = false;
            chkAllergy1.ForeColor = Color.Black;
            txtAllergy.Text = string.Empty ;

           // chkGastric.Checked = false;
           // chkGastric.ForeColor = Color.Black;

            chkAsthma1.Checked = false;
            chkAsthma1.ForeColor = Color.Black;

            chkDiabetes1.Checked = false;
            chkDiabetes1.ForeColor = Color.Black;

            chkHypertension1.Checked = false;
            chkHypertension1.ForeColor = Color.Black;

           // cboPressure.SelectedIndex = 0;
            //cboPressure.ForeColor = Color.Black;

            chkHeartDisease1.Checked = false;
            chkHeartDisease1.ForeColor = Color.Black;

            chkKidneyDisease1.Checked = false;
            chkKidneyDisease1.ForeColor = Color.Black;

          //  chkTuberculosis.Checked = false;
           // chkTuberculosis.ForeColor = Color.Black;
        }

        private void LoadPatient(Ticket pat)
        {

            Patient oP = new Patient();
            txtPrescriptionNo.Text = pat.TicketNo;
            txtPatientName.Text = pat.Patient.Name;
            txtHCN.Text = pat.Patient.HCN;
            txtSex.Text = pat.Patient.Sex;
            txtDepartment.Text = pat.Patient.Department.DepartmentID;
            txtDepartmentUnit.Text = pat.Patient.DepartmentUnit.UnitId;
            txtAgeYears.Text = pat.PatientAge.Year.ToString();
            txtAgeMonths.Text = pat.PatientAge.Month.ToString();
            txtAgeDays.Text = pat.PatientAge.Day.ToString();
            txtAgeHours.Text = pat.PatientAge.Hour.ToString();
            txtDepartment.Text = pat.TicketDepartment.DepartmentID;
            txtDepartmentName.Text = pat.TicketDepartment.DepartmentTitle;
            txtDoctorID.Text = pat.Doctor.ID;
            txtDoctorName.Text = pat.Doctor.Name;
            txtDiseaseCase.Text = pat.Patient.CaseID;

            lblPatientName.Text = pat.Patient.Name + " (" + txtSex.Text + " )" + "\r\n" + Utility.GetAgeStr(short.Parse(txtAgeYears.Text), short.Parse(txtAgeMonths.Text), short.Parse(txtAgeDays.Text), short.Parse(txtAgeHours.Text));
            //lblPatientName.Text = txtPatientName.Text + " (" + txtSex.Text + ")" + "\r\n" + Utility.GetAgeStr(short.Parse(txtAgeYears.Text), short.Parse(txtAgeMonths.Text), short.Parse(txtAgeDays.Text), short.Parse(txtAgeHours.Text));

            //lblDeptDoctor.Text = txtDepartmentName.Text + "\r\n" + txtDoctorID.Text + " " + txtDoctorName.Text; // txtDoctorName.Text;
            lblDeptDoctor.Text = txtDepartmentName.Text + "\r\n" + txtDoctorName.Text; // txtDoctorName.Text;

            lblComplaints.Text = pat.Patient.CaseID;
            txtHeightM.Text = pat.OPDCallQ.Height;
            txtWeightM.Text = pat.OPDCallQ.Weight;
            

            if (txtHeightM.Text != "0" && txtWeightM.Text != "0")
            {
                CalculateBmi();
            }
            else
            {
                txtBMI.Text = "0";
            }

            if (pat.OPDCallQ.Bp.Contains("/") == true)
            {
                string Bp1 = pat.OPDCallQ.Bp.Split('/')[0];
                string Bp2 = pat.OPDCallQ.Bp.Split('/')[1];
                txtBP.Text = Bp1;
                txtBpP2.Text = Bp2;
            }
            else
            {
                txtBP.Text = pat.OPDCallQ.Bp;
                txtBpP2.Text = pat.OPDCallQ.Bp;
            }
            txtTemp.Text = pat.OPDCallQ.Temparature;
            txtSPOTWO.Text = pat.OPDCallQ.SPOTWO;
            txtOFC.Text = pat.OPDCallQ.OFC;

            if(txtHeightM.Text !="" && txtWeightM.Text != "")
            {
              //  txtBSA.Text = Convert.ToString();
                txtBSA.Text = Convert.ToString(Math.Round(Math.Sqrt((Convert.ToDouble(txtHeightM.Text) * Convert.ToDouble(txtWeightM.Text)) / 3600),3));
               
            }
            if (txtHeightM.Text == "" && txtWeightM.Text == "")
            {
                txtHeightM.Text = "0"; 
                txtWeightM.Text = "0";
                txtBSA.Text = Convert.ToString(Math.Round(Math.Sqrt((Convert.ToDouble(txtHeightM.Text) * Convert.ToDouble(txtWeightM.Text)) / 3600), 3));
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
#region comment
         /*   
            if (pat.OPDCallQ.Allergy != "0" && pat.OPDCallQ.Allergy != null &&  pat.OPDCallQ.Allergy != "")
            {
                chkAllergy1.Checked = true;
                txtAllergy1.Text = pat.OPDCallQ.Allergy;
                chkAllergy1.ForeColor = Color.Red;
                chkAllergy.Checked = true;
                txtAllergy.Text = pat.OPDCallQ.Allergy;
                chkAllergy.ForeColor = Color.Red;
            }
            if (pat.OPDCallQ.Allergy == "0" || pat.OPDCallQ.Allergy == null || pat.OPDCallQ.Allergy == "")
            {
                chkAllergy1.Checked = false;
                txtAllergy1.Text = string.Empty;
                chkAllergy1.ForeColor = Color.Black;
                chkAllergy.Checked = false;
                chkAllergy.ForeColor = Color.Black;
                txtAllergy.Text = string.Empty;
            }
         //   chk(chkGastric1, pat.OPDCallQ.Gastric);
            chk(chkAsthma1, pat.OPDCallQ.Asthma);
            chk(chkDiabetes1, pat.OPDCallQ.Diabetes);

            //------------------------------------------
           // chk(chkGastric, pat.OPDCallQ.Gastric);
            chk(chkAsthma, pat.OPDCallQ.Asthma);
            chk(chkDiabetes, pat.OPDCallQ.Diabetes);

            //------------------------------------------

            if (pat.OPDCallQ.Pressure == "N" || pat.OPDCallQ.Pressure == null || pat.OPDCallQ.Pressure == "")
            {
                rdoPNor.Checked = true;
                cboPressure.SelectedIndex = 0;
                cboPressure.ForeColor = Color.Red;
            }
            if (pat.OPDCallQ.Pressure == "H")
            {
                rdoPHigh.Checked = true;
                cboPressure.SelectedIndex = 1;
                cboPressure.ForeColor = Color.Red;
            }
            if (pat.OPDCallQ.Pressure == "L")
            {
                rdoPLow.Checked = true;
                cboPressure.SelectedIndex = 2;
                cboPressure.ForeColor = Color.Red;
            }

            chk(chkHeartDisease1, pat.OPDCallQ.HeartDisease);
            chk(chkKidneyDisease1, pat.OPDCallQ.KidneyDisease);
          //  chk(chkTuberculosis1, pat.OPDCallQ.Tuberculosis);

            //-------------------------------------------------
            chk(chkHeartDisease, pat.OPDCallQ.HeartDisease);
            chk(chkKidneyDisease, pat.OPDCallQ.KidneyDisease);
            //  chk(chkTuberculosis, pat.OPDCallQ.Tuberculosis);*/
#endregion comment
           // if (Edit != "E")
           // {
                assignValue(pat.OPDCallQ.Allergy, pat.OPDCallQ.AllergyText, chkAllergy, chkAllergy1, txtAllergy);
                assignValue(pat.OPDCallQ.Asthma, pat.OPDCallQ.AsthmaText, chkAsthma, chkAsthma1, txtAsthma);
                assignValue(pat.OPDCallQ.Diabetes, pat.OPDCallQ.DiabetesText, chkDiabetes, chkDiabetes1, txtDiabetes);
                assignValue(pat.OPDCallQ.Pressure, pat.OPDCallQ.PressureText, chkHypertension, chkHypertension1, txtHypertension);
                assignValue(pat.OPDCallQ.HeartDisease, pat.OPDCallQ.HeartDiseaseText, chkHeartDisease, chkHeartDisease1, txtHeartDisease);
                assignValue(pat.OPDCallQ.KidneyDisease, pat.OPDCallQ.KidneyDiseaseText, chkKidneyDisease, chkKidneyDisease1, txtKidneyDisease);
                assignValue(pat.OPDCallQ.Others, pat.OPDCallQ.OthersText, chkOtherDisease, chkOtherDisease1, txtOtherDisease);

                assignValue(pat.OPDCallQ.PastMedicalHistory, pat.OPDCallQ.PastMedicalHistoryText, chkPMedHis, chkPMedHis1, txtPMedHis);
                assignValue(pat.OPDCallQ.PastSurgicalHistory, pat.OPDCallQ.PastSurgicalHistoryText, chkPSurgHis, chkPSurgHis1, txtPSurgHis);
                assignValue(pat.OPDCallQ.FamilyHistory, pat.OPDCallQ.FamilyHistoryText, chkFamilyHis, chkFamilyHis1, txtFamilyHis);

                PatHisValue(pat.PaediatricHistory.Antenatal, pat.PaediatricHistory.AntenatalText, rdoAntenatalN, rdoAntenatalAbN, txtAntenatal);
                PatHisValue(pat.PaediatricHistory.Natal, pat.PaediatricHistory.NatalText, rdoNatalN, rdoNatalCS, txtNatal);
                PatHisValue(pat.PaediatricHistory.PostNatal, pat.PaediatricHistory.PostNatalText, rdoPostNUn, rdoPostNCom, txtPostNatal);

                PatHisValue2(pat.PaediatricHistory.ExclusiveFeed,pat.PaediatricHistory.ExclusiveFeedText, chkExFeed, txtExFeedHis);
                PatHisValue2(pat.PaediatricHistory.CompFeed, pat.PaediatricHistory.CompFeedText, chkCompFeed, txtCompFeedHis1);
                PatHisValue2(pat.PaediatricHistory.CompFeed, pat.PaediatricHistory.CompFeedWText, chkCompFeed, txtCompFeedHis2);
                PatHisValue2(pat.PaediatricHistory.PresentFeed, pat.PaediatricHistory.PresentFeedText, chkPresentFeed, txtPresFeed);

                PatHisValue(pat.PaediatricHistory.MileStoneOfDev, pat.PaediatricHistory.MileStoneOfDevText, rdoMSTNAppro, rdoMSTNDelay, txtMSTNDev);
                PatHisValue(pat.PaediatricHistory.Immunization, pat.PaediatricHistory.ImmunizationText, rdoImmuUTD, rdoImmuMiss, txtImmu);
                PatHisValue3(pat.PaediatricHistory.SocioEcoHistory, pat.PaediatricHistory.SocioEcoHistoryText, rdoEecoHis, txtEcoHis);

                PatHisValue2(pat.GynHistory.Gyn, pat.GynHistory.GynText, chkGyn, txtGyn);
                PatHisValue2(pat.GynHistory.Obs, pat.GynHistory.ObsText, chkObs, txtObs);
          //  }

           
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }

        private void PatHisValue3(string value, string text, RadioButton a,  TextBox t)
        {
            if (value == "1")
            {
                a.Checked = true;
                t.Text = text;
            }
            else
            {
                a.Checked = false;
                t.Text = "";
            }
        }
        private void PatHisValue(string value, string text,RadioButton a, RadioButton b,  TextBox t)
        {
            if (value == "1")
            {
                a.Checked = true;
                b.Checked = false;
                t.Text = text;
            }
            else if (value == "2")
            {
                a.Checked = false;
                b.Checked = true;
                t.Text = text;
            }
            else if (value == "0")
            {
                a.Checked = false;
                b.Checked = false;
                t.Text = "";
            }
            else
            {
                a.Checked = false;
                b.Checked = false;
                t.Text = "";
            }
        }


        private void PatHisValue2(string value, string text, CheckBox chkbox1, TextBox txtbox)
        {
            if (value == "1")
            {
                chkbox1.Checked = true;
               
                txtbox.Text = text;
            }
            else if (value == "0")
            {
                chkbox1.Checked = false;
               
                txtbox.Text = "";
            }
            else
            {
                chkbox1.Checked = false;
               
                txtbox.Text = "";
            }
        }

        private void assignValuePaed(string value, string text, RadioButton a, RadioButton b, TextBox t)
        {
            if (value == "0")
            {
                a.Checked = false;
                b.Checked = false;
                t.Text = "";
            }
            else if (value == "1")
            {
                a.Checked = true;
                b.Checked = false;
                t.Text = text;
            }
            else if (value == "2")
            {
                a.Checked = false;
                b.Checked = true;
                t.Text = text;
            }
            else
            {
                a.Checked = false;
                b.Checked = false;
                t.Text = "";
            }
        }
        private void assignValuePaed3(string value, string text, RadioButton a, TextBox t)
        {
            if (value == "0")
            {
                a.Checked = false;
                t.Text = "";
            }
            else if (value == "1")
            {
                a.Checked = true;
                t.Text = text;
            }
            else
            {
                a.Checked = false;
                t.Text = "";
            }
        }
        private void assignValuePaed2(string value, string text, CheckBox a, TextBox t)
        {
            if (value == "0")
            {
                a.Checked = false;
                t.Text = "";
            }
            else if (value == "1")
            {
                a.Checked = true;
                t.Text = text;
            }
            else
            {
                a.Checked = false;
                t.Text = "";
            }
        }

        private void assignValue(string value, string text, CheckBox chkbox1, CheckBox chkbox2, TextBox txtbox)
        {
            if (value == "1")
            {
                chkbox1.Checked = true;
                chkbox2.Checked = true;
                txtbox.Text = text;
            }
            else if (value == "0")
            {
                chkbox1.Checked = false;
                chkbox2.Checked = false;
                txtbox.Text = "";
            }
            else
            {
                chkbox1.Checked = false;
                chkbox2.Checked = false;
                txtbox.Text = "";
            }
        }
        private void chk(CheckBox chk, string value)
        {
            if (value == "1")
            {
                chk.Checked = true;
                chk.ForeColor = Color.Red;
            }
            else if (value == "0")
            {
                chk.Checked = false;
            }
            else
            {
                chk.Checked = false;
            }
        }

        private void CalculateBmi()
        {
            if (txtHeightM.Text != "" && txtWeightM.Text != "") 
            {
                double HeightCM2M = Math.Round((Double.Parse(txtHeightM.Text) * (0.01)), 3);
                double WeightKG = Math.Round((Double.Parse(txtWeightM.Text)), 3);  
                double bmi = Math.Round((WeightKG / (Math.Pow(HeightCM2M,2))),3);
                txtBMI.Text = Convert.ToString(bmi);
                BMIStatus(bmi);
            }
        }

        private void BMIStatus(double bmi)
        {
            if (bmi < 18.5)
            {
                lblBMIStatus.Text = "UnderWeight";
                lblBMIStatus.ForeColor = Color.Red;
            }
            if (bmi >= 18.5 && bmi <= 24.9)
            {
                lblBMIStatus.Text = "Normal";
                lblBMIStatus.ForeColor = Color.Green;
            }
            if (bmi >= 25.0 && bmi <= 29.9)
            {
                lblBMIStatus.Text = "OverWeight";
                lblBMIStatus.ForeColor = Color.YellowGreen;
            }
            if (bmi >= 30 && bmi <= 39.9)
            {
                lblBMIStatus.Text = "Obese";
                lblBMIStatus.ForeColor = Color.Red;
            }
            if (bmi >= 40.0)
            {
                lblBMIStatus.Text = "Extremely Obese";
                lblBMIStatus.ForeColor = Color.DarkRed;
            }
        }
        private void FormatGrid()
        {
            lvSelectedTests.CheckBoxes = false;
            lvSelectedTests.Columns.Add("Investigation(s)", 400, HorizontalAlignment.Left);
            lvSelectedTests.Columns.Add("DetailID",0,HorizontalAlignment.Left);
            lvSelectedTests.Columns.Add("Department",0, HorizontalAlignment.Left);
            lvSelectedTests.Columns.Add("Group",0, HorizontalAlignment.Left);
            lvSelectedTests.Columns.Add("Main",0, HorizontalAlignment.Left);
            lvSelectedTests.Columns.Add("ReportGroup", 0, HorizontalAlignment.Left);
            lvSelectedTests.Columns.Add("LabRoom", 0, HorizontalAlignment.Left);
        }
        private void FormatListClinicalDiagnosis()
        {
            lvCollectedClinicalDiagnosis.CheckBoxes = false;
            lvCollectedClinicalDiagnosis.Columns.Add("DiagID",0, HorizontalAlignment.Center);
            lvCollectedClinicalDiagnosis.Columns.Add("Diagnosis(s)", 200, HorizontalAlignment.Left);
            lvCollectedClinicalDiagnosis.Columns.Add("Additional Information", 200, HorizontalAlignment.Left);
        }

        private void FormatGrid1()
        {
            lvAdvicePrescription.Items.Clear();
            lvAdvicePrescription.Columns.Add("Advice ID", 0, HorizontalAlignment.Left);
            lvAdvicePrescription.Columns.Add("Advice(s)", 450, HorizontalAlignment.Left);
            lvAdvicePrescription.Columns.Add("Department", 0, HorizontalAlignment.Left);
            lvAdvicePrescription.Columns.Add("Additional Information", 200, HorizontalAlignment.Left);
        }
        private void FormatListComplaints()
        {
            lvComplaints.CheckBoxes = false;
            lvComplaints.Columns.Add("ID", 0, HorizontalAlignment.Center);
            lvComplaints.Columns.Add("Complaints(s)", 200, HorizontalAlignment.Left);
            lvComplaints.Columns.Add("Additional Information", 200, HorizontalAlignment.Left);
        }
        private void FormatListOComplaints()
        {
            lvOtherComplaints.CheckBoxes = false;
            lvOtherComplaints.Columns.Add("ID", 0, HorizontalAlignment.Center);
            lvOtherComplaints.Columns.Add("Complaints(s)", 216, HorizontalAlignment.Left);
            lvOtherComplaints.Columns.Add("Additional Information", 100, HorizontalAlignment.Left);
        }
        private void FormatListOCF()
        {
            lvClinicalFindings.CheckBoxes = false;
            lvClinicalFindings.Columns.Add("CFID", 0, HorizontalAlignment.Left);
            lvClinicalFindings.Columns.Add("Finding(s)", 140, HorizontalAlignment.Left);
            lvClinicalFindings.Columns.Add("CFValID", 0, HorizontalAlignment.Left);
            lvClinicalFindings.Columns.Add("Value", 120, HorizontalAlignment.Left);
            lvClinicalFindings.Columns.Add("Details", 140, HorizontalAlignment.Left);
        }
        private void FormatComplaintGridView(DataGridView dtv)
        {
            dtv.AutoGenerateColumns = false;
            dtv.Height = 300;
            dtv.Width = 300;

            DataGridViewTextBoxColumn DiagID = new DataGridViewTextBoxColumn();
            DiagID.Name = "ID";
            DiagID.DataPropertyName = "ID";
            DiagID.Width = 0;
            dtv.Columns.Add(DiagID);

            DataGridViewTextBoxColumn DiagTitle = new DataGridViewTextBoxColumn();
            DiagTitle.Name = "ComplaintTitle";
            DiagTitle.DataPropertyName = "ComplaintTitle";
            DiagTitle.Width = 298;
            dtv.Columns.Add(DiagTitle);
        }
        private void FormatComplaintData(DataGridView dtv)
        {
            dtv.ColumnHeadersVisible = true;
            dtv.AllowUserToAddRows = false;
            dtv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtv.AutoGenerateColumns = false;

            dtv.Columns[0].Name = "ID";
            dtv.Columns[0].DataPropertyName = "ID";
            dtv.Columns[0].Width = 0;
            dtv.Columns[0].Visible = false;
            dtv.Columns[0].DefaultCellStyle.Font = new Font("Garamond", 10, FontStyle.Italic);

            dtv.Columns[1].Name = "ComplaintTitle";
            dtv.Columns[1].DataPropertyName = "ComplaintTitle";
            dtv.Columns[1].Width = 298;
            dtv.Columns[1].DefaultCellStyle.Font = new Font("Garamond", 12, FontStyle.Italic);

        }
        private void frmPrescription_Load(object sender, EventArgs e)
        {
            if (Edit == "E")
            {
                frmLabel.Text = "Edit Prescription";
                btnVisitedPatList.Visible = false;
                btnCancelTicket.Visible = false;
            }
            if (Edit != "E")
            {
                frmLabel.Text = "Prescription";
                btnVisitedPatList.Visible = true;
                btnCancelTicket.Visible = true;

            }
            txtNextVisit.ReadOnly = true;
            chkReferTo.Checked = false;
            cboUnit.Enabled = false;
            cboDepartment.Enabled = false;
            cboDoctor.Enabled = false;
            lblStartTime.Text = "";
            lblEndTime.Text = "";

            cboTicketType.DisplayMember = "Value";
            cboTicketType.ValueMember = "Key";
            cboTicketType.DataSource = new BindingSource(Utility.VerifyDic(opdsr.GetPrescriptionType("G")), null);

            //dgvClinicalDiag.Visible = false;

            cboTicketType.Enabled = false;

            txtNextVisitDay.Text = "0";
            txtNextVisitMonth.Text = "0";
            txtNextVisitYear.Text = "0";

            FormatListPres();
            FormatGrids();
            FormatGrid();
            FormatGrid1();
            LoadTicket(doctorID);
            txtPrescriptionNo.Select();

            ListViewItem itm = new ListViewItem("15 october 2014");
            itm.SubItems.Add("OPD Doctor Visiting on 13 October 2014");
            itm.SubItems.Add("Admission on 05 November 2014");
            //lstOpdHistory.Items.Add(itm);
           // FormatGridView(dgvClinicalDiag);
           //  FormatData(dgvClinicalDiag);
           // FormatComplaintGridView(dgvComplaints);
          //  FormatComplaintData(dgvComplaints);

            //FormatComplaintDGV(dgvComplaints);
            FormatListClinicalDiagnosis();
            FormatListComplaints();
            FormatListOComplaints();
            FormatListOCF();
            PopulateComplaints();
            PopulateDiagnosis();
            //txtHCN.Visible = true;

            //---------color---------------//
            lblFree.LinkColor = Color.DeepSkyBlue;
            lblBusy.LinkColor = Color.DeepSkyBlue;
            lblVisit.LinkColor = Color.DeepSkyBlue;
            //---------color---------------//


            //==================================
            cboCaseID.DisplayMember = "Value";
            cboCaseID.ValueMember = "Key";
            cboCaseID.DataSource = new BindingSource(opdsr.GetDiseaseDict(""), null);
            //==================================
            DepartmentCbo();
        }
        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDoctor.DisplayMember = "Value";
            cboDoctor.ValueMember = "Key";
            cboDoctor.DataSource = new BindingSource(Utility.VerifyDic(opdsr.GetOPDDoctorsDict(cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString())), null);
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(opdsr.GetDeptUnitDic(Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical), cboDepartment.SelectedValue.ToString())), null);
            }
            else
            {
                return;
            } 
        }
        private void DepartmentCbo()
        {
            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(opdsr.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical))), null);
        }
        public void OPDPrescription(string ticketNO)
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.OPDPrescription;
            ofrmReportViewerOPD.ParamField = ticketNO;
            ofrmReportViewerOPD.ViewReport();
            ofrmReportViewerOPD.TopMost = true;
            ofrmReportViewerOPD.Activate();
           // if(ofrmReportViewerOPD. ==true)
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Edit == "")
            {
                DialogResult dr = MessageBox.Show("Do you want to save Prescription ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    List<string> vf = new List<string>() { "txtPrescriptionNo" };
                    Control control = Utility.ReqFieldValidator(this, vf);
                    if (control != null)
                    {
                        MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control.Focus();
                        return;
                    }
                    try
                    {
                        if (lvComplaints.Items.Count > 0)
                        {
                            Prescription tcats = this.PopulatePrescription();
                            string i = opdsr.SavePrescription(tcats);
                            if (i == "0")
                            {
                                MessageBox.Show("Data insertion failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                OPDDoctorCall oOPDDocCall = this.DoctorCallObject("B");
                                if (oOPDDocCall.Department.DepartmentID != "" && oOPDDocCall.DepartmentUnit.UnitId != "" && oOPDDocCall.Prescription.TicketNo != "")
                                {
                                    timer1.Stop();
                                    oOPDDocCall = opdsr.InsUpdDocCall(oOPDDocCall);
                                    lblFree.LinkColor = Color.LimeGreen;
                                    lblBusy.LinkColor = Color.DeepSkyBlue;
                                    lblVisit.LinkColor = Color.DeepSkyBlue;
                                }
                                else
                                {
                                    MessageBox.Show("Department, Doctor and Prescription Number is required!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                string tempPrescription = "";
                                tempPrescription = txtPrescriptionNo.Text;

                                LoadTicket(doctorID);
                                RefreshGrid();
                                txtPrescriptionNo.Text = "";
                                lblBMIStatus.Text = "";
                                lblComplaints.Text = "";
                                lblDeptDoctor.Text = "";
                                lblPatientName.Text = "";

                                this.btnNew.PerformClick();


                                OPDPrescription(tempPrescription);

                                ////txtPrescriptionNo.Select();
                                //LoadTicket(doctorID);
                                //RefreshGrid();
                                //txtPrescriptionNo.Text = "";
                                //lblBMIStatus.Text = "";
                                //lblComplaints.Text = "";
                                //lblDeptDoctor.Text = "";
                                //lblPatientName.Text = "";

                                //this.btnNew.PerformClick();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please provide the complaints", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else
            {
                DialogResult dr = MessageBox.Show("Want to Edit Prescription ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    List<string> vf = new List<string>() { "txtPrescriptionNo" };
                    Control control = Utility.ReqFieldValidator(this, vf);
                    if (control != null)
                    {
                        MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control.Focus();
                        return;
                    }
                    try
                    {
                        if (lvComplaints.Items.Count > 0)
                        {
                            Prescription tcats = this.PopulatePrescription();
                            string i = opdsr.EditPrescription(tcats);
                            if (i == "0")
                            {
                                MessageBox.Show("Data insertion failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                OPDDoctorCall oOPDDocCall = this.DoctorCallObject("B");
                                if (oOPDDocCall.Department.DepartmentID != "" && oOPDDocCall.DepartmentUnit.UnitId != "" && oOPDDocCall.Prescription.TicketNo != "")
                                {
                                    timer1.Stop();
                                    oOPDDocCall = opdsr.InsUpdDocCall(oOPDDocCall);
                                    lblFree.LinkColor = Color.LimeGreen;
                                    lblBusy.LinkColor = Color.DeepSkyBlue;
                                    lblVisit.LinkColor = Color.DeepSkyBlue;
                                }
                                else
                                {
                                    MessageBox.Show("Department, Doctor and Prescription Number is required!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                string tempPrescription = "";
                                tempPrescription = txtPrescriptionNo.Text;

                                LoadTicket(doctorID);
                                RefreshGrid();
                                txtPrescriptionNo.Text = "";
                                lblBMIStatus.Text = "";
                                lblComplaints.Text = "";
                                lblDeptDoctor.Text = "";
                                lblPatientName.Text = "";

                                this.btnNew.PerformClick();

                                OPDPrescription(tempPrescription);
                                //LoadTicket(doctorID);
                                //RefreshGrid();
                                //txtPrescriptionNo.Text = "";
                                //lblBMIStatus.Text = "";
                                //lblComplaints.Text = "";
                                //lblDeptDoctor.Text = "";
                                //lblPatientName.Text = "";

                                //this.btnNew.PerformClick();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please provide the complaints", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void RefreshGrid()
        {
            lvSelectedTests.Items.Clear();
            lvCollectedClinicalDiagnosis.Items.Clear();
            lvComplaints.Items.Clear();
            lvOtherComplaints.Items.Clear();
            lvDrugs.Items.Clear();
            lvAdvicePrescription.Items.Clear();
            lvClinicalFindings.Items.Clear();
        }
        private void FormatListPres()
        {  
            //21 column
            lvDrugs.CheckBoxes = false;
            lvDrugs.Columns.Add("At a Glance", 450, HorizontalAlignment.Left); //0
            lvDrugs.Columns.Add("Remarks", 200, HorizontalAlignment.Left);//1
            lvDrugs.Columns.Add("CmpID", 0, HorizontalAlignment.Left);//2
            lvDrugs.Columns.Add("GID", 0, HorizontalAlignment.Left);//3
            lvDrugs.Columns.Add("UID",0, HorizontalAlignment.Left);//4
            lvDrugs.Columns.Add("TID",0, HorizontalAlignment.Left);//5
            lvDrugs.Columns.Add("MID", 0, HorizontalAlignment.Left);  //6        
            lvDrugs.Columns.Add("DrugName", 0, HorizontalAlignment.Left);//7
            lvDrugs.Columns.Add("DQty", 0, HorizontalAlignment.Left);//8
            lvDrugs.Columns.Add("ConsumptionForm", 0, HorizontalAlignment.Left);//9
            lvDrugs.Columns.Add("DTHGap", 0, HorizontalAlignment.Left);//10
            lvDrugs.Columns.Add("Duration", 0, HorizontalAlignment.Left);//11
            lvDrugs.Columns.Add("DurationInd", 0, HorizontalAlignment.Left);//12
            lvDrugs.Columns.Add("RouteID", 0, HorizontalAlignment.Left);//13
            lvDrugs.Columns.Add("B/AMeal", 0, HorizontalAlignment.Left);//14
            lvDrugs.Columns.Add("MealID", 0, HorizontalAlignment.Left);//15
            lvDrugs.Columns.Add("MealTimeGapID", 0, HorizontalAlignment.Left);//16
            lvDrugs.Columns.Add("DurCont", 0, HorizontalAlignment.Left);//17
            lvDrugs.Columns.Add("Refils", 0, HorizontalAlignment.Left);//18
            lvDrugs.Columns.Add("TotalMedicine", 0, HorizontalAlignment.Left);//19
            lvDrugs.Columns.Add("PackTypeName", 0, HorizontalAlignment.Left); //20
        }
        private Prescription PopulatePrescription()
        {
            #region Common
            Prescription prs = new Prescription();          
            prs.TicketNo = txtPrescriptionNo.Text;
            prs.TicketType = cboTicketType.Text;
            prs.Height =txtHeightM.Text;
            prs.Weight =txtWeightM.Text;
            prs.Bp = (txtBP.Text+ "/" + txtBpP2.Text).ToString();
            prs.Temparature =txtTemp.Text;
            if(txtNextVisit.Text != "  /  /")
            {
                prs.NextVisitDate = DateTime.ParseExact(txtNextVisit.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            }
            if (txtNextVisit.Text == "  /  /")
            {
                prs.NextVisitDate = null;
            }
            prs.NextVisitAfterDay = Int32.Parse(txtNextVisitDay.Text);
            prs.NextVisitAfterMonth = Int32.Parse(txtNextVisitMonth.Text);
            prs.NextVisitAfterYear = Int32.Parse(txtNextVisitYear.Text);

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
           
            if (cboUnit.SelectedValue != null )
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

            Department dpt = new Department();
            dpt.DepartmentID = txtDepartment.Text;
            prs.TicketDepartment = dpt;

            Doctor doc = new Doctor();
            doc.ID = txtDoctorID.Text;
            doc.Name = txtDoctorName.Text;
            prs.Doctor = doc;

            /////////////////////////////////////// Tests
            string colltests = "";
            foreach (ListViewItem itemRow in lvSelectedTests.Items)
            {
                colltests += itemRow.SubItems[6].Text + "`" 
                          + itemRow.SubItems[5].Text + "`"
                          + itemRow.SubItems[2].Text + "`" 
                          + itemRow.SubItems[3].Text + "`"
                          + itemRow.SubItems[4].Text + "`"
                          + itemRow.SubItems[1].Text + "`";
                colltests += "~";
            }
            prs.CollTests = colltests;

            /////////////////////////////////// Clinical Diagnosis
            string clinicalDiagnosis = "";
            foreach (ListViewItem itemRow in lvCollectedClinicalDiagnosis.Items)
            {
                clinicalDiagnosis += itemRow.SubItems[0].Text + "`"
                                  + itemRow.SubItems[2].Text + "`";
                clinicalDiagnosis += "~";                
            }
            
            prs.ClinicalDiagnosis = clinicalDiagnosis;

            ////////////////////////////////////Complaints
            string complaints = "";
            foreach (ListViewItem itemRow in lvComplaints.Items)
            {
                complaints += itemRow.SubItems[0].Text + "`"
                           + itemRow.SubItems[2].Text + "`";
                complaints += "~";

            }
            
            prs.Complaints = complaints;
            ////////////////////////////////////Other Complaints
            string Ocomplaints = "";
            foreach (ListViewItem itemRow in lvOtherComplaints.Items)
            {
                Ocomplaints += itemRow.SubItems[0].Text + "`"
                            + itemRow.SubItems[2].Text + "`";
                Ocomplaints += "~";

            }

            prs.OtherComplaints = Ocomplaints;

            ////////////////////////////////////ClinicalFindings
            string Ocf = "";
            foreach (ListViewItem itemRow in lvClinicalFindings.Items)
            {
                Ocf += itemRow.SubItems[0].Text + "`"
                    +  itemRow.SubItems[2].Text + "`"
                    + itemRow.SubItems[4].Text + "`";
                Ocf += "~";

            }
            prs.ClinicalFindings = Ocf;
            //------------------ Add Advice ----------------------------
            string AddAdvice = "";
            foreach (ListViewItem itemRow in lvAdvicePrescription.Items)
            {
                AddAdvice += itemRow.SubItems[0].Text + "`"
                          +  itemRow.SubItems[3].Text + "`";
                AddAdvice += "~";
            }
            prs.Advice = AddAdvice;

            //------------------ End Add Advice -----------------------
            ///////////////////////////////////////Drugs 
            string drugs = "";
            foreach (ListViewItem itemRow in lvDrugs.Items)
            {
                //comp:grp:unit:pack type:drug id:dose Qty:Dose Times:Times Indicator:hourGap
                //:Dose Route:b/a meal:MealTimeGap:Meal Indicator:mealIndicator:Duration:duration Indicator:Refill:Remarks
                //              "000001,000002,0002,0003,0000003,2,3,D,0,
                //              ,,0,,3,D,0,"

                drugs +=  itemRow.SubItems[2].Text + "`"  //DRUG_COMP_ID ,
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
            #endregion
            Patient pat = new Patient();
            pat.HCN = txtHCN.Text;
            pat.Name = txtPatientName.Text; //...............................................
            pat.StaffID = "03";
           
            DepartmentUnit unt = new DepartmentUnit();
            unt.UnitId = txtDepartmentUnit.Text;
            pat.DepartmentUnit = unt;

            prs.Patient = pat;

            AH.ModuleController.OPDSR.Age patAge = new AH.ModuleController.OPDSR.Age();
            patAge.Year = int.Parse(txtAgeYears.Text);
            patAge.Month = int.Parse(txtAgeMonths.Text);
            patAge.Day = int.Parse(txtAgeDays.Text);
            patAge.Hour = int.Parse(txtAgeHours.Text);
            prs.PatientAge = patAge;

            //OPDDoctorCallQ Qobj = new OPDDoctorCallQ();

            //Qobj.Allergy = chk1(chkAllergy);
            //Qobj.AllergyText = chk2(chkAllergy, txtAllergy);

            //Qobj.Asthma = chk1(chkAsthma);
            //Qobj.AsthmaText = chk2(chkAsthma, txtAsthma);

            //Qobj.Diabetes = chk1(chkDiabetes);
            //Qobj.DiabetesText = chk2(chkDiabetes, txtDiabetes);

            //Qobj.Pressure = chk1(chkHypertension);
            //Qobj.PressureText = chk2(chkHypertension, txtHypertension);

            //Qobj.HeartDisease = chk1(chkHeartDisease);
            //Qobj.HeartDiseaseText = chk2(chkHeartDisease, txtHeartDisease);

            //Qobj.KidneyDisease = chk1(chkKidneyDisease);
            //Qobj.KidneyDiseaseText = chk2(chkKidneyDisease, txtKidneyDisease);

            //Qobj.Others = chk1(chkOtherDisease);
            //Qobj.OthersText = chk2(chkOtherDisease, txtOtherDisease);

           // prs.OPDDoctorCallQ = Qobj;

            string comorbidIllness = "";
            comorbidIllness  +=chk1(chkAllergy) + "`"
                             + chk2(chkAllergy, txtAllergy) + "`"
                             + chk1(chkAsthma) + "`"
                             + chk2(chkAsthma, txtAsthma) + "`"
                             + chk1(chkDiabetes) + "`"
                             + chk2(chkDiabetes, txtDiabetes) + "`"
                             + chk1(chkHypertension) + "`"
                             + chk2(chkHypertension, txtHypertension) + "`"
                             + chk1(chkHeartDisease) + "`"
                             + chk2(chkHeartDisease, txtHeartDisease) + "`"
                             + chk1(chkKidneyDisease) + "`"
                             + chk2(chkKidneyDisease, txtKidneyDisease) + "`"
                             + chk1(chkOtherDisease) + "`"
                             + chk2(chkOtherDisease, txtOtherDisease) + "`" 
                             + chk1(chkPMedHis) + "`"
                             + chk2(chkPMedHis,txtPMedHis) + "`"
                             + chk1(chkPSurgHis) + "`"
                             + chk2(chkPSurgHis, txtPSurgHis) + "`"
                             + chk1(chkFamilyHis) + "`"
                             + chk2(chkFamilyHis, txtFamilyHis) + "`";
            comorbidIllness += "~";

            prs.comorbidIllness = comorbidIllness;

            string PaediatricHis = "";
            PaediatricHis += chkPBH(rdoAntenatalN, rdoAntenatalAbN) + "`"
                             + chkPBHText(rdoAntenatalN, rdoAntenatalAbN, txtAntenatal) + "`"

                             + chkPBH(rdoNatalN, rdoNatalCS) + "`"
                             + chkPBHText(rdoNatalN, rdoNatalCS, txtNatal) + "`"

                             + chkPBH(rdoPostNUn, rdoPostNCom) + "`"
                             + chkPBHText(rdoPostNUn, rdoPostNCom, txtPostNatal) + "`"

                             + chk1(chkExFeed) + "`"
                             + chk2(chkExFeed, txtExFeedHis) + "`"

                             + chk1(chkCompFeed) + "`"
                             + chk2(chkCompFeed, txtCompFeedHis1) + "`"
                             + chk2(chkCompFeed, txtCompFeedHis2) + "`"

                             + chk1(chkPresentFeed) + "`"
                             + chk2(chkPresentFeed, txtPresFeed) + "`"

                             + chkPBH(rdoMSTNAppro,rdoMSTNDelay) + "`"
                             + chkPBHText(rdoMSTNAppro, rdoMSTNDelay,txtMSTNDev) + "`"

                             + chkPBH(rdoImmuUTD,rdoImmuMiss) + "`"
                             + chkPBHText(rdoImmuUTD, rdoImmuMiss,txtImmu) + "`"

                             + chkPBH3(rdoEecoHis) + "`"
                             + chkPBH3Text(rdoEecoHis, txtEcoHis) + "`";
            PaediatricHis += "~";

            prs.paediatricHis = PaediatricHis;


            string GynHistory = "";
            GynHistory += chk1(chkGyn) + "`"
                       +  chk2(chkGyn, txtGyn) + "`"
                       +  chk1(chkObs) + "`"
                       +  chk2(chkObs, txtObs) + "`";
            GynHistory += "~";

            prs.GynHis = GynHistory;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            prs.EntryParameter = ep;

            return prs;
        }
        private void chkExFeed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExFeed.Checked == true)
            {
                txtExFeedHis.Enabled = true;
            }
            if(chkExFeed.Checked == false)
            {
                txtExFeedHis.Enabled = false;
            }
        }

        private void chkCompFeed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCompFeed.Checked == true)
            {
               txtCompFeedHis1.Enabled = true;
               txtCompFeedHis2.Enabled = true;
            }
            if (chkCompFeed.Checked == false)
            {
               txtCompFeedHis1.Enabled = false;
               txtCompFeedHis2.Enabled = false;
            }
        }

        private void chkPresentFeed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPresentFeed.Checked == true)
            {
                txtPresFeed.Enabled = true;
            }
            if (chkPresentFeed.Checked == false)
            {
                txtPresFeed.Enabled = false;
            }
        }
        private string chkPBH3(RadioButton a)
        {
            string val = "";
           
            if (a.Checked == true)
            {
                val = "1";
               
            }
            if (a.Checked == false)
            {
                val = "0";
              
            }
            return val;
        }
        private string chkPBH3Text(RadioButton a, TextBox textBox)
        {
            string val = "";
            string text = "";
            if (a.Checked == true)
            {
                text = textBox.Text;

            }
            if (a.Checked == false)
            {
                text = "";

            }
            return text;
        }
        private string chkPBH(RadioButton a, RadioButton b)
        {
            string val = "";
            if (a.Checked == true )
            {
                val = "1";
            }

            if ( b.Checked == true)
            {
                val = "2";
            }
            else if (a.Checked == false && b.Checked == false)
            {
                val = "0";
            }
            return val;
        }

        private string chkPBHText(RadioButton a, RadioButton b, TextBox txt)
        {
            string val = "";
            string text = "";

            if (a.Checked == true || b.Checked == true)
            {
                val = "1";
                text = txt.Text;
            }

            else if (a.Checked == false && b.Checked == false)
            {
                val = "0";
                text = "";
            }
            return text;
        }

        private string chk1(CheckBox chk)
        {
            string val = "";
            if (chk.Checked == true)
            {
                val = "1";
            }
            else if (chk.Checked == false)
            {
                val = "0";
            }
            return val;
        }
        private string chk2(CheckBox chk, TextBox txt)
        {
            string val = "";
            string text = "";

            if (chk.Checked == true)
            {
                val = "1";
                text = txt.Text;
            }
            else if (chk.Checked == false)
            {
                val = "0";
                text = "";
            }
            return text;
        }

        private void PutNewPrescription()
        {
            txtPatientName.Text = string.Empty;
            txtSex.Text = string.Empty;
            txtHCN.Text = string.Empty;
            txtDepartmentUnit.Text = string.Empty;
            txtAgeYears.Text = string.Empty;
            txtAgeMonths.Text = string.Empty;
            txtAgeDays.Text = string.Empty;
            txtAgeHours.Text = string.Empty;
            txtDepartment.Text = string.Empty;
            txtDepartmentName.Text = string.Empty;
            txtDoctorID.Text = string.Empty;
            txtDoctorName.Text = string.Empty;
            txtDiseaseCase.Text = string.Empty;
        }
        private void lvTicketList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTicketList.SelectedItems.Count > 0)
            {
                lblVisit.LinkColor = Color.Red;
                ListViewItem itm = lvTicketList.SelectedItems[0];
                txtPrescriptionNo.Text = itm.SubItems[1].Text;  
            }
            if (txtPrescriptionNo.Text.Length == Utility.ScanLength)
            {
                btnPatientSearch_Click(sender, e);
                this.lblVisit_Click(sender, e);
               // lblVisit_Click(sender, e);
            }
        }
        private void txtPrescriptionNo_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtPrescriptionNo.Text.ToUpper().Length == Utility.ScanLength)
            {
                btnPatientSearch_Click(sender, e);
            }

        }

        private void btnAddDrugs_Click(object sender, EventArgs e)
        {
            if (txtPatientName.Text == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPrescriptionNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPatientName.Focus();
                return;
            };
            frmAddToPrescription ad = new frmAddToPrescription(AddFromPrescription(), 4, txtAgeYears.Text, txtDepartment.Text, txtDepartmentUnit.Text);
            ad.onSaveButtonClicked = new frmAddToPrescription.SaveButtonClick(AddToPrescription);
            ad.ShowDialog();
        }
        private void AddToPrescription(Prescription oPres, object sender, EventArgs e)
        {
            List<Complaints> oComp = oPres.ComplaintsList.ToList();
            List<Complaints> oOtherComp = oPres.OtherComplaintsList.ToList();
            List<ClinicalFindingsValueAssign> oCF = oPres.CFValAssignList.ToList();
            List<ClinicalDiagnosis> oDiag = oPres.ClinicalDiagnosisList.ToList();
            List<TestSub> oTest = oPres.TestsList.ToList();
            List<DrugDose> oDrugs = oPres.DrugsList.ToList();
            List<OPDAdvice> oAdvice = oPres.AdvicesList.ToList();

            AddDataToComplaintsView(oComp, sender, e);
            AddDataToOComplaintsView(oOtherComp, sender, e);
            AddDataToClinicalFindingsView(oCF, sender, e);
            AddDataToClinicalDiagnosisView(oDiag, sender, e);
            AddDataToInvestigationView(oTest, sender, e);
            AddDataToDrugView(oDrugs, sender, e);
            AddDataToAdviceView(oAdvice, sender, e);
        }
        private void AddDataToClinicalFindingsView(List<ClinicalFindingsValueAssign> oCF, object sender, EventArgs e)
        {
            try
            {
                lvClinicalFindings.Items.Clear();
                foreach (ClinicalFindingsValueAssign lvcf in oCF)
                {
                    ListViewItem itm = new ListViewItem(lvcf.FindingsID); //cfid
                    itm.SubItems.Add(lvcf.FindingsTitle); //cfTitle
                    itm.SubItems.Add(lvcf.FindingsValID); //cfChkid
                    itm.SubItems.Add(lvcf.FindingsValTitle); //title
                    itm.SubItems.Add(lvcf.FindingsValDetails); //additional
                    lvClinicalFindings.Items.Add(itm);
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

        private void FormatGridView(DataGridView dtv)
        {
            dtv.AutoGenerateColumns = false;
            dtv.Height = 300;
            dtv.Width = 300;

            DataGridViewTextBoxColumn DiagID = new DataGridViewTextBoxColumn();
            DiagID.Name = "DiagID";
            DiagID.DataPropertyName = "DiagID";
            DiagID.Width = 0;
            dtv.Columns.Add(DiagID);

            DataGridViewTextBoxColumn DiagTitle = new DataGridViewTextBoxColumn();
            DiagTitle.Name = "Diagnostic Title";
            DiagTitle.DataPropertyName = "DiagTitle";
            DiagTitle.Width = 298;
            dtv.Columns.Add(DiagTitle);
         }
        private void FormatData(DataGridView dtv)
        {
            dtv.ColumnHeadersVisible = true;
            dtv.AllowUserToAddRows = false;
            dtv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtv.AutoGenerateColumns = false;

            dtv.Columns[0].Name = "DiagID";
            dtv.Columns[0].DataPropertyName = "DiagID";
            dtv.Columns[0].Width = 0;
            dtv.Columns[0].Visible = false;
            dtv.Columns[0].DefaultCellStyle.Font = new Font("Garamond", 10, FontStyle.Italic);


            dtv.Columns[1].Name = "Diagnosis";
            dtv.Columns[1].DataPropertyName = "DiagTitle";
            dtv.Columns[1].Width = 298;
            dtv.Columns[1].DefaultCellStyle.Font = new Font("Garamond", 12, FontStyle.Italic);

        }
        private void FormatComplaintDGV(DataGridView dtv)
        {
            dtv.ColumnHeadersVisible = true;
            dtv.AllowUserToAddRows = false;
            dtv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtv.AutoGenerateColumns = false;

            dtv.Columns[0].Name = "ID";
            dtv.Columns[0].DataPropertyName = "ID";
            dtv.Columns[0].Width = 0;
            dtv.Columns[0].Visible = false;
            dtv.Columns[0].DefaultCellStyle.Font = new Font("Garamond", 10, FontStyle.Italic);


            dtv.Columns[1].Name = "ComplaintTitle";
            dtv.Columns[1].DataPropertyName = "ComplaintTitle";
            dtv.Columns[1].Width = 298;
            dtv.Columns[1].DefaultCellStyle.Font = new Font("Garamond", 12, FontStyle.Italic);

        }
        private Boolean IsAlreadyAdded(ListView dtv, string sDiagTitle)
        {
            if (dtv.Items.Count < 0)
            {
                return false;
            }
            foreach (ListViewItem item in dtv.Items)
            {
                if (item.SubItems[1].Text == sDiagTitle)
                {
                    return true;
                }               
            }
            return false;
        }
        
        private void PopulateDiagnosis()
        {
            diagnosisList = new List<ClinicalDiagnosis>();
            diagnosisList.AddRange(opdsr.GetClinicalDiagnosis());
        }
        private void PopulateDiagnosisToGrid(DataGridView dtv, string diagnosisTitle)
        {
            dtv.Visible = true;
            IEnumerable<ClinicalDiagnosis> DiagnosisListLocal;
            if (!(diagnosisTitle.Length > 0))
            {
                DiagnosisListLocal = diagnosisList;
            }
            else
            {
                DiagnosisListLocal = diagnosisList.Where(x => x.DiagTitle.ToLower().Contains(diagnosisTitle.ToLower()));
            }
            dtv.DataSource = DiagnosisListLocal.Select(data => new
            {
                data.DiagID,
                data.DiagTitle
            }).ToList();            
        }
        private void PopulateComplaints()
        {
            complaintsList = new List<Complaints>();
            complaintsList.AddRange(opdsr.GetComplaints());  
        }
        private void PopulateDataToComplaintsGrid(DataGridView dtv, string complaintsTitle)
        {
            dtv.Visible = true;
            IEnumerable<Complaints> complaintsListLocal;

            if (!(complaintsTitle.Length > 0))
            {
                complaintsListLocal = complaintsList;
            }
            else
            {
                // complaintsListLocal = complaintsList.Where(x=>x.ComplaintTitle.StartsWith(complaintsTitle, StringComparison.OrdinalIgnoreCase));   //// this is not workable to search for a substring in anywhere in a string
                complaintsListLocal = complaintsList.Where(x => x.ComplaintTitle.ToLower().Contains(complaintsTitle.ToLower()));            //// this is workable to search for a substring in anywhere in a string
            }
            dtv.DataSource = complaintsListLocal.Select(data => new 
            { 
                data.ID, 
                data.ComplaintTitle 
            }) .ToList();
         }
        private void txtDiagTitle_KeyUp(object sender, KeyEventArgs e)
        {
            //if (txtPatientName.Text == "")
            //{
            //    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPrescriptionNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtPatientName.Focus();
            //    return;
            //};
            //PopulateDiagnosisToGrid(dgvClinicalDiag, txtDiagTitle.Text);
        }
        private void AddClinicalDiagnosisItemsToListView()
        {
            //if (IsAlreadyAdded(lvCollectedClinicalDiagnosis, txtDiagTitle.Text) == true)
            //{
            //    MessageBox.Show("Already Added"); txtDiagTitle.Text = ""; 
            //    return;
            //}
            //ListViewItem itm = new ListViewItem(txtDiagnosisCode.Text);
            //itm.SubItems.Add(txtDiagTitle.Text);
            ////itm.SubItems.Add(txtDiagTitle.Text);
            //lvCollectedClinicalDiagnosis.Items.Add(itm);
            //txtDiagTitle.Text = "";
            //txtDiagTitle.Visible = true;
        }
        private void SetValuesFromGrid(DataGridView dtv, object sender, Boolean isKeyPressed)
        {
            //if (dtv.Rows.Count > 0)
            //{
            //    int currentRow = dtv.CurrentRow.Index;
            //    txtDiagnosisCode.Text = dtv["DiagID", currentRow].Value.ToString();
            //    txtDiagTitle.Text = dtv["Diagnosis", currentRow].Value.ToString();
            //    AddClinicalDiagnosisItemsToListView();
            //    dtv.Visible = false;
            //    txtDiagTitle.Visible = true;
            //    txtDiagTitle.Focus();
            //}
            //else
            //{
            //    dtv.Visible = false;
            //    txtDiagTitle.Focus();
            //}
        }

        private void AddComplaintsToListView()
        {
        //    if (IsAlreadyAdded(lvComplaints, txtComplaintsTitle.Text) == true)
        //    {
        //        MessageBox.Show("Already Added"); 
        //        txtComplaintsTitle.Text = ""; 
        //        return;
        //    }
            
        //    ListViewItem itm = new ListViewItem(txtComplaintCode.Text);
        //    itm.SubItems.Add(txtComplaintsTitle.Text);
        //    lvComplaints.Items.Add(itm);
        //    txtComplaintsTitle.Text = "";
        //    lvComplaints.Visible = true;
        }
        private void SetComplaintFromGrid(DataGridView dtv, object sender, Boolean isKeyPressed)
        {
            //if (dtv.Rows.Count > 0)
            //{
            //    int currentRow = dtv.CurrentRow.Index;
            //    txtComplaintCode.Text = dtv["ID", currentRow].Value.ToString();
            //    txtComplaintsTitle.Text = dtv["ComplaintTitle", currentRow].Value.ToString();
            //    AddComplaintsToListView();
            //    dtv.Visible = false;
            //    lvComplaints.Visible = true;
            //    txtComplaintsTitle.Focus();
            //}
            //else
            //{
            //    dgvComplaints.Visible = false;
            //    txtComplaintsTitle.Focus();
            //}
        }
        
        
        private void lvCollectedClinicalDiagnosis_DoubleClick(object sender, EventArgs e)
        {
            listViewSelectedItem(lvCollectedClinicalDiagnosis);
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
        private void lvSelectedTests_DoubleClick(object sender, EventArgs e)
        {
            listViewSelectedItem(lvSelectedTests);
        }
        private void lvDrugs_DoubleClick(object sender, EventArgs e)
        {
            listViewSelectedItem(lvDrugs);         
        }
        private void txtComplaintsTitle_KeyUp(object sender, KeyEventArgs e)
        {
             //if (txtPatientName.Text == "")
             //{
             //    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPrescriptionNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
             //    txtPatientName.Focus();
             //    return;
             //};
             //   PopulateDataToComplaintsGrid(dgvComplaints, txtComplaintsTitle.Text);
        }  
        private List<PatHistoryTree> Orderby(List<PatHistoryTree> oPatTrees)
        {
            oPatTrees.OrderBy(x => x.VisitAndDept);
            return oPatTrees;
        }
        private int j = 0;
        private string hcntemp = "";
        public  readonly Random rand = new Random();
        private Color GetRandomColour()
        {
            return Color.FromArgb(this.rand.Next(256), this.rand.Next(256), this.rand.Next(256));
        }
        List<PatHistoryTree> oPatTrees = new List<PatHistoryTree>();


//---------------------------------Previous code for patient history tree view--------------------------------------------------------------------------------
        /*private void tabNewPrescription_MouseClick(object sender, MouseEventArgs e)
        {
            string aaa = tabNewPrescription.TabPages.IndexOf(tbRx).ToString();

            if (this.tabNewPrescription.SelectedTab == this.tabNewPrescription.TabPages["tbRx"])
            {
                TreeGenerate();
            }
        }
        
        private void TreeGenerate()
        {
            if(hcntemp !=txtHCN.Text)
            {
                j = 0;
                hcntemp = txtHCN.Text;
            }
            
                if (j == 0)
                {
                    treePatientHistory.DataSource = null;
                    treePatientHistory.RemoveAllGroups();
                    string HCN = txtHCN.Text;
                    hcntemp = HCN;
                    if (HCN == "")
                    {
                        MessageBox.Show("Please Select a Patient to Find History");
                        lvTicketList.Focus();
                        return;
                    }
                    oPatTrees = opdsr.GetsTree(HCN).ToList();
                    if (oPatTrees.Count <= 0)
                    {
                        MessageBox.Show("No History available for this Patient");
                        return;
                    }
                    Orderby(oPatTrees);

                    treePatientHistory.ExpandAll();

                    treePatientHistory.DataSource = oPatTrees;

                    treePatientHistory.SetLeafData("Result", "ResultDetails", "ResultDetails", 0, 0);

                    treePatientHistory.AddGroup("Date", "VisitAndDept", "VisitAndDept", "VisitAndDept", 0, 0);

                    treePatientHistory.AddGroup("Tree", "TreeGroup", "TreeGroup", "TreeGroup", 0, 0);

                    treePatientHistory.AddGroup("Name", "Name", "Name", "Name", 0, 0);

                    treePatientHistory.BuildTree();

                    j = oPatTrees.Count;

                    for (int i = 0; i < treePatientHistory.Nodes.Count; i++)
                    {
                        treePatientHistory.Nodes[i].ForeColor = Color.DarkRed;
                        treePatientHistory.Nodes[i].NodeFont = new Font("Callibri", 8, FontStyle.Bold);

                        for (int p = 0; p < treePatientHistory.Nodes[i].Nodes.Count; p++)
                        {
                            treePatientHistory.Nodes[i].Nodes[p].ForeColor = GetRandomColour();
                            treePatientHistory.Nodes[i].Nodes[p].NodeFont = new Font("Callibri", 8, FontStyle.Bold);
                        }
                    }
                    return;
                }
                if (j > 0)
                {
                    //treePatientHistory.DataSource = null;
                    treePatientHistory.RemoveAllGroups();
                    treePatientHistory.DataSource = oPatTrees;
                    Orderby(oPatTrees);

                    treePatientHistory.ExpandAll();

                    treePatientHistory.DataSource = oPatTrees;

                    treePatientHistory.SetLeafData("Result", "ResultDetails", "ResultDetails", 0, 0);

                    treePatientHistory.AddGroup("Date", "VisitAndDept", "VisitAndDept", "VisitAndDept", 0, 0);

                    treePatientHistory.AddGroup("Tree", "TreeGroup", "TreeGroup", "TreeGroup", 0, 0);

                    treePatientHistory.AddGroup("Name", "Name", "Name", "Name", 0, 0);

                    treePatientHistory.BuildTree();

                    j = oPatTrees.Count;
                    for (int i = 0; i < treePatientHistory.Nodes.Count; i++)
                    {
                        treePatientHistory.Nodes[i].ForeColor = Color.DarkRed;
                        treePatientHistory.Nodes[i].NodeFont = new Font("Callibri", 8, FontStyle.Bold);

                        for (int p = 0; p < treePatientHistory.Nodes[i].Nodes.Count; p++)
                        {
                            treePatientHistory.Nodes[i].Nodes[p].ForeColor = GetRandomColour();
                            treePatientHistory.Nodes[i].Nodes[p].NodeFont = new Font("Callibri", 8, FontStyle.Bold);
                        }
                    }
                }
        }
        */
        //-----------------------------------------End of Previous code for patient history tree view------------------------------------------------------------------------

//-----------------------------------------Code for patient history tree view------------------------------------------------------------------------
        private void tabNewPrescription_MouseClick(object sender, EventArgs e)
        {
            treePatientHistory1.DataSource = null;
          //  TreeGenerate();
            return;
        }
        private void TreeGenerate()
        {
            #region Comment tree
            string HCN = txtHCN.Text;
            hcntemp = HCN;   
            treePatientHistory1.DataSource = null;
            treePatientHistory1.RemoveAllGroups();
            oPatTrees = opdsr.GetsTree(HCN).ToList();
            if (oPatTrees.Count <= 0)
            {
                MessageBox.Show("No History available for this Patient",Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Orderby(oPatTrees);
            treePatientHistory1.ExpandAll();
            treePatientHistory1.DataSource = oPatTrees;
            treePatientHistory1.SetLeafData("Result", "ResultDetails", "ResultDetails", 0, 0);
            treePatientHistory1.AddGroup("Date", "VisitAndDept", "VisitAndDept", "VisitAndDept", 0, 0);
            treePatientHistory1.AddGroup("Tree", "TreeGroup", "TreeGroup", "TreeGroup", 0, 0);
            treePatientHistory1.AddGroup("Name", "Name", "Name", "Name", 0, 0);
            treePatientHistory1.BuildTree();

            for (int i = 0; i < treePatientHistory1.Nodes.Count; i++)
            {
                treePatientHistory1.Nodes[i].ForeColor = Color.DarkRed;
                treePatientHistory1.Nodes[i].NodeFont = new Font("Callibri", 8, FontStyle.Bold);

                for (int p = 0; p < treePatientHistory1.Nodes[i].Nodes.Count; p++)
                {
                    treePatientHistory1.Nodes[i].Nodes[p].ForeColor = Color.DarkBlue;//GetRandomColour();
                    treePatientHistory1.Nodes[i].Nodes[p].NodeFont = new Font("Callibri", 8, FontStyle.Bold);
                }
            }
#endregion
        }
//-----------------------------------------End of code for patient history tree view-------------------------------------------------------------
                
        private void dgvComplaints_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // SetComplaintFromGrid(dgvComplaints, sender, false);
        }
        private void dgvComplaints_KeyDown(object sender, KeyEventArgs e) 
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    SetComplaintFromGrid(dgvComplaints, sender, false); 
            //}
        }
        private void lstVComplaints_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listViewSelectedItem(lvComplaints);
        }
        private void dgvClinicalDiag_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          //  SetValuesFromGrid(dgvClinicalDiag, sender, false);
        }
        private void lvCollectedClinicalDiagnosis_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listViewSelectedItem(lvCollectedClinicalDiagnosis);
        }
        private void dgvClinicalDiag_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //SetValuesFromGrid(dgvClinicalDiag, sender, false);
            }
        }
       
        private void lstVComplaints_DoubleClick(object sender, EventArgs e)
        {
            listViewSelectedItem(lvComplaints);
        }
        

        private OPDDoctorCall DoctorCallObject(string Status)
        {
            OPDDoctorCall oOPDDoctorCall = new OPDDoctorCall();
            Department oDepartment = new Department();
            DepartmentUnit oDepartmentUnit = new DepartmentUnit();
            Doctor oDoctor = new Doctor();
            Prescription oPrescription = new Prescription();

            oDepartment.DepartmentID = txtDepartment.Text;
            oOPDDoctorCall.Department = oDepartment;
            oDepartmentUnit.UnitId = txtDepartmentUnit.Text;
            oOPDDoctorCall.DepartmentUnit = oDepartmentUnit;
            oDoctor.ID = txtDoctorID.Text;
            oOPDDoctorCall.Doctor = oDoctor;
            oOPDDoctorCall.NurseID = "420";
            oOPDDoctorCall.NStationID = "421";
            oOPDDoctorCall.RoomNo = DrRoomNo;
            if (Status != "F")
            {
                oPrescription.TicketNo = txtPrescriptionNo.Text;
            }
            if (Status == "F")
            {
                oPrescription.TicketNo = "";
            }
            
            oOPDDoctorCall.Prescription = oPrescription;
            oOPDDoctorCall.Status = Status;
            oOPDDoctorCall.EntryDate = Convert.ToString( DateTime.Today);
            return oOPDDoctorCall;
        }
        
        private void lblBusy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // && oOPDDocCall.Prescription.TicketNo != ""
            OPDDoctorCall oOPDDocCall = this.DoctorCallObject("B");
            if (oOPDDocCall.Department.DepartmentID != "" && oOPDDocCall.DepartmentUnit.UnitId != "")
            {
                oOPDDocCall = opdsr.InsUpdDocCall(oOPDDocCall);
                lblFree.LinkColor = Color.DeepSkyBlue;
                lblBusy.LinkColor = Color.Goldenrod;
                lblVisit.LinkColor = Color.DeepSkyBlue;
            }
            else
            {
                MessageBox.Show(" Department, Doctor and Prescription Number is required !", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void lblVisit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OPDDoctorCall oOPDDocCall = this.DoctorCallObject("V");
            if (oOPDDocCall.Department.DepartmentID != "" && oOPDDocCall.DepartmentUnit.UnitId != "" && oOPDDocCall.Prescription.TicketNo != "")
            {
                lblStartTime.Text = DateTime.Now.ToShortTimeString();
                timer1.Start();
                oOPDDocCall = opdsr.InsUpdDocCall(oOPDDocCall);
                lblFree.LinkColor = Color.DeepSkyBlue;
                lblBusy.LinkColor = Color.DeepSkyBlue;
                lblVisit.LinkColor = Color.OrangeRed;
            }
            else
            {
                MessageBox.Show(" Department, Doctor and Prescription Number is required !", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void lblFree_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OPDDoctorCall oOPDDocCall = this.DoctorCallObject("F");
            if (oOPDDocCall.Department.DepartmentID != "" && oOPDDocCall.DepartmentUnit.UnitId != "" )
            {
                oOPDDocCall = opdsr.InsUpdDocCall(oOPDDocCall);
                lblFree.LinkColor = Color.Green;
                lblBusy.LinkColor = Color.DeepSkyBlue;
                lblVisit.LinkColor = Color.DeepSkyBlue;
            }
            else
            {
                MessageBox.Show(" Department, Doctor and Prescription Number is required !", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void lvTicketList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OPDDoctorCall oOPDDocCall = this.DoctorCallObject("V");

            if (oOPDDocCall.Department.DepartmentID != "" && oOPDDocCall.DepartmentUnit.UnitId != "" && oOPDDocCall.Prescription.TicketNo != "")
            {
                oOPDDocCall = opdsr.InsUpdDocCall(oOPDDocCall);
                lblFree.LinkColor = Color.DeepSkyBlue;
                lblBusy.LinkColor = Color.DeepSkyBlue;
                lblVisit.LinkColor = Color.OrangeRed;
            }
            else
            {
                MessageBox.Show(" Department, Doctor and Prescription Number is required !", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void lblRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {             
            LoadTicket(doctorID);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time + 1;
            lblEndTime.Text = Convert.ToString(time) + " Minute";
        }

       private void frmPrescription_Paint(object sender, PaintEventArgs e)
       {
            //if (strAdvice != "")
            //txtAdvice.Text = strAdvice;
       }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (txtPrescriptionNo.Text != "")
            {
                DialogResult dr = MessageBox.Show("Do you want to open a new prescription ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    txtNextVisitDay.Text = "0";
                    txtNextVisitMonth.Text = "0";
                    txtNextVisitYear.Text = "0";

                    txtWeightM.Text = string.Empty;
                    txtWeightS.Text = string.Empty;
                    txtBMI.Text = string.Empty;
                    lblBMIStatus.Text = string.Empty;
                    txtBP.Text = string.Empty;
                    txtBpP2.Text = string.Empty;
                    txtTemp.Text = string.Empty;

                    timer1.Stop();
                    lvComplaints.Items.Clear();
                    lvClinicalFindings.Items.Clear();
                    lvSelectedTests.Items.Clear();
                    lvCollectedClinicalDiagnosis.Items.Clear();
                    lvDrugs.Items.Clear();
                    lvAdvicePrescription.Items.Clear();

                    lblPatientName.Text = "Patient Name" ;
                    lblDeptDoctor.Text  = "Doctor's Name" ;
                    lblComplaints.Text  = "Complaints" ;

                    this.Dispose();
                    this.Refresh();
                }
            }
            else
            {
                txtNextVisitDay.Text = "0";
                txtNextVisitMonth.Text = "0";
                txtNextVisitYear.Text = "0";

                txtWeightM.Text = string.Empty;
                txtWeightS.Text = string.Empty;
                txtBMI.Text = string.Empty;
                lblBMIStatus.Text = string.Empty;
                txtBP.Text = string.Empty;
                txtBpP2.Text = string.Empty;
                txtTemp.Text = string.Empty;

                timer1.Stop();
                lvComplaints.Items.Clear();
                lvClinicalFindings.Items.Clear();
                lvSelectedTests.Items.Clear();
                lvCollectedClinicalDiagnosis.Items.Clear();
                lvDrugs.Items.Clear();
                lvAdvicePrescription.Items.Clear();

                lblPatientName.Text = "Patient Name";
                lblDeptDoctor.Text = "Doctor's Name";
                lblComplaints.Text = "Complaints";
            }
        }

        private void lvAdvicePrescription_DoubleClick(object sender, EventArgs e)
        {
            listViewSelectedItem(lvAdvicePrescription);
        }

        private void btnAddAdvice_Click(object sender, EventArgs e)
        {
            if (txtPatientName.Text == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPrescriptionNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPatientName.Focus();
                return;
            };

            frmAddToPrescription ad = new frmAddToPrescription(AddFromPrescription(), 5, txtAgeYears.Text, txtDepartment.Text, txtDepartmentUnit.Text);
            ad.onSaveButtonClicked = new frmAddToPrescription.SaveButtonClick(AddToPrescription);
            ad.ShowDialog();
            
        /*  string advices="" ;//= "3,4,5,6";
            //List<String> arString = new List<string>();
            //lvAdvicePrescription.Items.Clear();
            for (int i = 0; i < lvAdvicePrescription.Items.Count;i++ )
            {
                advices += lvAdvicePrescription.Items[i].SubItems[0].Text+",";
            }
            frmAdvices ie = new frmAdvices(advices);
            ie.onAddAdviceButtonClicked = new frmAdvices.AddAdviceClick(AddDataToAdviceView);
            ie.ShowDialog(); */
        }

        private void tabNewPrescription_MouseClick(object sender, MouseEventArgs e)
        {
            if (tabNewPrescription.SelectedIndex == 2)
            {
                if (txtPatientName.Text == "")
                {
                    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPrescriptionNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPatientName.Focus();
                    return;
                }
                else
                {
                    PatHisTree();
                  //  treePatientHistory1.DataSource = null;
                  //  TreeGenerate();
                  //  return;
                }
            }
        }

        private void btnToComplaintsFrm_Click(object sender, EventArgs e)
        {
            frmComplaints com = new frmComplaints();
            com.ShowDialog();
        }

        private void btnToDiagnosisFrm_Click(object sender, EventArgs e)
        {
            frmClinicalDiagnosis cd = new frmClinicalDiagnosis();
            cd.ShowDialog();
        }

        private void btnToAdviceFrm_Click(object sender, EventArgs e)
        {
            frmAdviceSetup ofrm = new frmAdviceSetup();
            ofrm.ShowDialog();
        }

        private void btnRefreshComp_Click(object sender, EventArgs e)
        {
            //lvComplaints.Items.Clear();
            //SetComplaintFromGrid(dgvComplaints, sender, false);
        }

        private void dgvComplaints_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void hideGrid1()
        {
            //dgvComplaints.ClearSelection();
            //dgvComplaints.DataSource = null;
            //dgvComplaints.Visible = false;
        }
        private void hideGrid2()
        {
            //dgvClinicalDiag.ClearSelection();
            //dgvClinicalDiag.DataSource = null;
            //dgvClinicalDiag.Visible = false;
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            if (txtPatientName.Text == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPrescriptionNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPatientName.Focus();
                return;
            };

            frmAddToPrescription ad = new frmAddToPrescription(AddFromPrescription(), 0, txtAgeYears.Text, txtDepartment.Text, txtDepartmentUnit.Text);
            ad.onSaveButtonClicked = new frmAddToPrescription.SaveButtonClick(AddToPrescription);
            ad.ShowDialog();   
        }
        private Prescription AddFromPrescription()
        {
            Prescription oPrescription = new Prescription();
            oPrescription.ComplaintsList = GetSelectedComplaints().ToArray();
            oPrescription.OtherComplaintsList = GetSelectedOComplaints().ToArray();
            oPrescription.CFValAssignList = GetSelectedClinicalFindings().ToArray();
            oPrescription.ClinicalDiagnosisList = GetSelectedClinicalDiagnosis().ToArray();
            oPrescription.TestsList = GetSelectedTests().ToArray();
            oPrescription.DrugsList = GetSelectedMedicines().ToArray();
            oPrescription.AdvicesList = GetSelectedAdvices().ToArray();
            return oPrescription;
        }
        private List<ClinicalFindingsValueAssign> GetSelectedClinicalFindings()
        {
            List<ClinicalFindingsValueAssign> OCFVals = new List<ClinicalFindingsValueAssign>();
            for (int i = 0; i < lvClinicalFindings.Items.Count; i++)
            {
                ClinicalFindingsValueAssign OCFVal = new ClinicalFindingsValueAssign();
                OCFVal.FindingsID = lvClinicalFindings.Items[i].SubItems[0].Text;
                OCFVal.FindingsTitle = lvClinicalFindings.Items[i].SubItems[1].Text;
                OCFVal.FindingsValID = lvClinicalFindings.Items[i].SubItems[2].Text;
                OCFVal.FindingsValTitle = lvClinicalFindings.Items[i].SubItems[3].Text;
                OCFVal.FindingsValDetails = lvClinicalFindings.Items[i].SubItems[4].Text;
                OCFVals.Add(OCFVal);
            }
            return OCFVals;
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

        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            /*if (txtPatientName.Text == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPrescriptionNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPatientName.Focus();
                return;
            };

            frmAddToPrescription ad = new frmAddToPrescription(GetSelectedComplaints(), GetSelectedClinicalDiagnosis());
            ad.onSaveButtonClicked = new frmAddToPrescription.SaveButtonClick(AddDataToComplaintsView, AddDataToClinicalDiagnosisView);
            ad.ShowDialog();*/

            if (txtPatientName.Text == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPrescriptionNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPatientName.Focus();
                return;
            };

            frmAddToPrescription ad = new frmAddToPrescription(AddFromPrescription(), 2, txtAgeYears.Text, txtDepartment.Text, txtDepartmentUnit.Text);
            ad.onSaveButtonClicked = new frmAddToPrescription.SaveButtonClick(AddToPrescription);
            ad.ShowDialog();
        }
        private List<ClinicalDiagnosis> GetSelectedClinicalDiagnosis()
        {
            List<ClinicalDiagnosis> Diagnosis = new List<ClinicalDiagnosis>();
            for (int i = 0; i < lvCollectedClinicalDiagnosis.Items.Count; i++)
            {
                ClinicalDiagnosis oDiagnosis = new ClinicalDiagnosis();
                oDiagnosis.DiagID =lvCollectedClinicalDiagnosis.Items[i].SubItems[0].Text;
                oDiagnosis.DiagTitle = lvCollectedClinicalDiagnosis.Items[i].SubItems[1].Text;
                oDiagnosis.Remarks = lvCollectedClinicalDiagnosis.Items[i].SubItems[2].Text;
                Diagnosis.Add(oDiagnosis);
            }
            return Diagnosis;
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

        private void pnlTop_Click(object sender, EventArgs e)
        {
            hideGrid1();
            hideGrid2();
        }

        private void txtComplaintsTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                //this.dgvComplaints.Focus();
            }
        }

        private void txtDiagTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
               // this.dgvClinicalDiag.Focus();
            }
        }

        private void txtHeightM_TextChanged(object sender, EventArgs e)
        {
            if (txtHeightM.Text != "0" && txtHeightM.Text != "")
            {
                string HeightF = "", HeightI = "";
                string temp = Convert.ToString((Double.Parse(txtHeightM.Text) * 0.393701)); // cm to feet
                double inch2feet = Math.Round((Convert.ToDouble(temp) / 12), 4);
                string newHeight = Convert.ToString(inch2feet);
                if (newHeight.Contains(".") == true)
                {
                    HeightF = newHeight.Split('.')[0];
                    string HeightI2 = "." + newHeight.Split('.')[1];
                    HeightI = Convert.ToString(Math.Round((Convert.ToDouble(HeightI2) * 12), 1));         
                }

              //  txtHeightS.Text = HeightF + "." + HeightI;

                txtHeightS.Text = Convert.ToString(Math.Round((Convert.ToDouble(txtHeightM.Text) * 0.032808),4));
            }
            else
            {
                txtHeightS.Text = "0";
            }
            
        }
        private void txtWeightM_TextChanged(object sender, EventArgs e)
        {
            if (txtWeightM.Text != "0" && txtWeightM.Text != "")
            {
                double WinKG = Math.Round((Double.Parse(txtWeightM.Text)), 3);
                double KG2Pound = Math.Round((WinKG * 2.20462),3);
                txtWeightS.Text = Convert.ToString(KG2Pound);

               // txtWeightS.Text = Convert.ToString(Math.Round((Double.Parse(txtWeightM.Text) * 2.20462), 3)); // kg to pound
            }
            else
            {
                txtWeightS.Text = "0";
            }
        }

        private void txtNextVisitDay_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtNextVisitDay.Text !="" && txtNextVisitDay.Text !="0")
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
        private void txtNextVisitYear_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtNextVisitYear.Text != "" && txtNextVisitYear.Text != "0")
            {
                txtNextVisit.Text = Utility.DateGenerator(DateTime.Now, int.Parse(txtNextVisitYear.Text), int.Parse(txtNextVisitMonth.Text), int.Parse(txtNextVisitDay.Text), 0).ToString("dd/MM/yyyy");
            }
        }

        public void dateCalculation()
        {
            if (txtNextVisit.Text.Length == 10)
            {
                //............date calculation..........//
                DateTime now = DateTime.Today;
                DateTime NextVisitDate = DateTime.ParseExact(txtNextVisit.Text, "dd/MM/yyyy", null);
                //get the difference in years
                TimeSpan ts = NextVisitDate.Date - now.Date;
                int ageY = (ts.Days / 365);
                int daysleft1 = ts.Days - (ageY * 365);
                int ageM = (daysleft1 / 30);
                int daysleft2 = daysleft1 - (ageM * 30);
                int ageD = daysleft2;

                txtNextVisitYear.Text = ageY.ToString();
                txtNextVisitMonth.Text = ageM.ToString();
                txtNextVisitDay.Text = ageD.ToString();
            }
        }

        private void txtNextVisit_Leave(object sender, EventArgs e)
        {
            //if (txtNextVisit.Text.Length == 10)
            //{
            //    dateCalculation();
            //}
        }

        private void txtNextVisit_KeyUp(object sender, KeyEventArgs e)
        {
            //if (txtNextVisit.Text.Length == 10)
            //{
            //    dateCalculation();
            //}
        }

        private void btnOtherComplaints_Click(object sender, EventArgs e)
        {
            if (txtPatientName.Text == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPrescriptionNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPatientName.Focus();
                return;
            };

            frmAddToPrescription ad = new frmAddToPrescription(AddFromPrescription(), 0, txtAgeYears.Text, txtDepartment.Text, txtDepartmentUnit.Text);
            ad.onSaveButtonClicked = new frmAddToPrescription.SaveButtonClick(AddToPrescription);
            ad.ShowDialog(); 
        }

        private void lblVisit_Click(object sender, EventArgs e)
        {
            OPDDoctorCall oOPDDocCall = this.DoctorCallObject("V");
            if (oOPDDocCall.Department.DepartmentID != "" && oOPDDocCall.DepartmentUnit.UnitId != "" && oOPDDocCall.Prescription.TicketNo != "")
            {
                lblStartTime.Text = DateTime.Now.ToShortTimeString();
                timer1.Start();
                oOPDDocCall = opdsr.InsUpdDocCall(oOPDDocCall);
                lblFree.LinkColor = Color.DeepSkyBlue;
                lblBusy.LinkColor = Color.DeepSkyBlue;
                lblVisit.LinkColor = Color.Red;
            }
            else
            {
                MessageBox.Show(" Department, Doctor and Prescription Number is required !", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
     
        #region checkedChange1
      /*  private void chkAllergy1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllergy1.Checked == true)
            {
                txtAllergy1.Enabled = true;
            }
            else
            {
                txtAllergy1.Enabled = false;
                txtAllergy1.Text = string.Empty;
            }
        }*/

       /* private void chkGastric1_CheckedChanged(object sender, EventArgs e)
        {
          /*  if (chkGastric1.Checked == true)
            {
                rdoGYes.Checked = true;
                rdoGNo.Checked = false;
            }
            if (chkGastric1.Checked == false)
            {
                rdoGYes.Checked = false;
                rdoGNo.Checked = true;
            }*/

       // }*/

       /* private void chkAsthma1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAsthma1.Checked == true)
            {
                rdoAYes.Checked = true;
                rdoANo.Checked = false;
            }
            if (chkAsthma1.Checked == false)
            {
                rdoAYes.Checked = false;
                rdoANo.Checked = true;
            }
        }*/

      /*  private void chkDiabetes1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiabetes1.Checked == true)
            {
                rdoDYes.Checked = true;
                rdoDNo.Checked = false;
            }
            if (chkDiabetes1.Checked == false)
            {
                rdoDYes.Checked = false;
                rdoDNo.Checked = true;
            }
        }*/

     /*   private void chkHeartDisease1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHeartDisease1.Checked == true)
            {
                rdoHDYes.Checked = true;
                rdoHDNo.Checked = false;
            }
            if (chkHeartDisease1.Checked == false)
            {
                rdoHDYes.Checked = false;
                rdoHDNo.Checked = true;
            }
        }*/

      //*  private void chkKidneyDisease1_CheckedChanged(object sender, EventArgs e)
    /*    {
            if (chkKidneyDisease1.Checked == true)
            {
                rdoKDYes.Checked = true;
                rdoKDNo.Checked = false;
            }
            if (chkKidneyDisease1.Checked == false)
            {
                rdoKDYes.Checked = false;
                rdoKDNo.Checked = true;
            }
        }*/

    /*    private void chkTuberculosis1_CheckedChanged(object sender, EventArgs e)
        {
           /* if (chkTuberculosis1.Checked == true)
            {
                rdoTYes.Checked = true;
                rdoTNo.Checked = false;
            }
            if (chkTuberculosis1.Checked == false)
            {
                rdoTYes.Checked = false;
                rdoTNo.Checked = true;
            }*/
      //  }*/*/
     /*   private void chkPressure1_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkPressure1.Checked)
            {
                chkPressure1.Checked = true;
            }
        }*/
        #endregion checkedChange1

        private void cboDoctor_Leave(object sender, EventArgs e)
        {
        //    if (cboDoctor.SelectedValue.ToString() == txtDoctorID.Text)
        //    {
        //        MessageBox.Show("Can not Refer to the same doctor", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        cboDoctor.Focus();
        //    }
        }
        private void cboDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboDoctor.SelectedValue.ToString() == txtDoctorID.Text)
            //{
            //    MessageBox.Show("Can not Refer to the same doctor", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    cboDoctor.Focus();
            //}
        }

        private void btnCFValue_Click(object sender, EventArgs e)
        {
            if (txtPatientName.Text == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPrescriptionNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPatientName.Focus();
                return;
            };

            frmAddToPrescription ad = new frmAddToPrescription(AddFromPrescription(), 1, txtAgeYears.Text, txtDepartment.Text, txtDepartmentUnit.Text);
            ad.onSaveButtonClicked = new frmAddToPrescription.SaveButtonClick(AddToPrescription);
            ad.ShowDialog(); 
        }

        private void txtNextVisitYear_Leave(object sender, EventArgs e)
        {
            if(txtNextVisitYear.Text == "")
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

        private void chkAllergy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllergy.Checked == true)
            {
                txtAllergy.Enabled = true;
            }
            else
            {
                txtAllergy.Enabled = false;
            }
        }

        private void chkAsthma_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAsthma.Checked == true)
            {
                txtAsthma.Enabled = true;
            }
            else
            {
                txtAsthma.Enabled = false;
            }
        }

        private void chkDiabetes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiabetes.Checked == true)
            {
                txtDiabetes.Enabled = true;
            }
            else
            {
                txtDiabetes.Enabled = false;
            }
        }

        private void chkHypertension_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHypertension.Checked == true)
            {
                txtHypertension.Enabled = true;
            }
            else
            {
                txtHypertension.Enabled = false;
            }
        }

        private void chkHeartDisease_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHeartDisease.Checked == true)
            {
                txtHeartDisease.Enabled = true;
            }
            else
            {
                txtHeartDisease.Enabled = false;
            }
        }

        private void chkKidneyDisease_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKidneyDisease.Checked == true)
            {
                txtKidneyDisease.Enabled = true;
            }
            else
            {
                txtKidneyDisease.Enabled = false;
            }
        }

        private void chkOtherDisease_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOtherDisease.Checked == true)
            {
               txtOtherDisease.Enabled = true;
            }
            else
            {
                txtOtherDisease.Enabled = false;
            }
        }

        private void chkPMedHis_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPMedHis.Checked == true)
            {
                txtPMedHis.Enabled = true;
            }
            else
            {
                txtPMedHis.Enabled = false;
            }

        }

        private void chkPSurgHis_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPSurgHis.Checked == true)
            {
                txtPSurgHis.Enabled = true;
            }
            else
            {
                txtPSurgHis.Enabled = false;
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvClinicalFindings_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listViewSelectedItem(lvClinicalFindings);     
        }

        private void chkFamilyHis_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFamilyHis.Checked == true)
            {
                txtFamilyHis.Enabled = true;
            }
            else
            {
                txtFamilyHis.Enabled = false;
            }
        }

        private void btnVisitedPatList_Click(object sender, EventArgs e)
        {
            frmVistedPatientList oVisPat = new frmVistedPatientList(departmentID,unitId,doctorID);
            oVisPat.ShowDialog();
        }

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            if (lvTicketList.SelectedItems.Count > 0)
            {
                if (txtPrescriptionNo.Text != "" && txtHCN.Text != "")
                {
                    ListViewItem itm = lvTicketList.SelectedItems[0];
                    string tempTicket = itm.SubItems[1].Text;

                    short i = opdsr.ChangeTktStatusFrmDoc(tempTicket, doctorID);
                    if (i == 0)
                    {
                        MessageBox.Show("Cancellation Failed. Please Try Again.", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        txtPrescriptionNo.Text = "";
                        lblBMIStatus.Text = "";
                        lblComplaints.Text = "";
                        lblPatientName.Text = "";
                        RefreshGrid();
                        LoadTicket(doctorID);
                    }
                }
            }
        }

        private void lvTicketList_MouseClick(object sender, MouseEventArgs e)
        {
            //ContextMenuStrip mnu = new ContextMenuStrip();
            //ToolStripMenuItem mnuCancel = new ToolStripMenuItem("Cancel from Queue");
            //ToolStripMenuItem mnuExit = new ToolStripMenuItem("Exit");
          
            ////Add to main context menu
            //mnu.Items.AddRange(new ToolStripItem[] { mnuCancel, mnuExit });

            ////Assign to listview
            //lvTicketList.ContextMenuStrip = mnu;

            //mnu.ItemClicked += new ToolStripItemClickedEventHandler(mnu_ItemClicked);

        }
        void mnu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            if (e.ClickedItem.Text == "Cancel from Queue")
            {
                if (lvTicketList.SelectedItems.Count > 0)
                {
                    if (txtPrescriptionNo.Text != "" && txtHCN.Text != "")
                    {
                        ListViewItem itm = lvTicketList.SelectedItems[0];
                        string tempTicket = itm.SubItems[1].Text;

                        short i = opdsr.ChangeTktStatusFrmDoc(tempTicket, doctorID);
                        if (i == 0)
                        {
                            MessageBox.Show("Cancellation Failed. Please Try Again.", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i > 0)
                        {
                            txtPrescriptionNo.Text = "";
                            lblBMIStatus.Text = "";
                            lblComplaints.Text = "";
                            lblPatientName.Text = "";
                            RefreshGrid();
                            LoadTicket(doctorID);
                        }
                    }
                }
            }
            if (e.ClickedItem.Text == "Exit")
            {
                //Do nothing
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

        }

        private void txtAllergy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtAsthma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtDiabetes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtHypertension_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtHeartDisease_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtKidneyDisease_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtOtherDisease_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtPMedHis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtPSurgHis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtFamilyHis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtAntenatal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtNatal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtPostNatal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtExFeedHis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtCompFeedHis1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtCompFeedHis2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtPresFeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtMSTNDev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtImmu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtEcoHis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void chkObs_CheckedChanged(object sender, EventArgs e)
        {
            if (chkObs.Checked == true)
            {
                txtObs.Enabled = true;
            }
            else
            {
                txtObs.Enabled = false;
            }
        }

        private void chkGyn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGyn.Checked == true)
            {
                txtGyn.Enabled = true;
            }
            else
            {
                txtGyn.Enabled = false;
            }
        }

        private void txtGyn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtObs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void PatHisTree()
        {
           // string tempUnit = "";
            if (txtHCN.Text != "")
            {
                PatientsHistoryTree.Nodes.Clear();
                List<OPDPrescriptionReportNewRO> oPatTreeNew = new List<OPDPrescriptionReportNewRO>();

                oPatTreeNew = opdsr.GetOPDPatTree(txtHCN.Text).ToList();

                for (int i = 0; i < oPatTreeNew.Count; i++)
                {
                    PatientsHistoryTree.Nodes.Add(oPatTreeNew[i].VisitDate);
                    PatientsHistoryTree.Nodes[i].ForeColor = Color.DarkViolet;
                    PatientsHistoryTree.Nodes[i].NodeFont =new  Font("Tahoma", 12F);
                    PatientsHistoryTree.Nodes[i].Expand();

                    List<OPDPrescriptionReportNewRO> leafOne = oPatTreeNew.Where(x => x.VisitDate == oPatTreeNew[i].VisitDate && x.UnitName == oPatTreeNew[i].UnitName).ToList();
                        
                    for (int j = 0; j < leafOne.Count; j++)
                    {
                            PatientsHistoryTree.Nodes[i].Nodes.Add(leafOne[j].UnitName);
                            PatientsHistoryTree.Nodes[i].Nodes[j].ForeColor = Color.Blue;
                            PatientsHistoryTree.Nodes[i].Nodes[j].NodeFont = new Font("Tahoma", 11F);
                            PatientsHistoryTree.Nodes[i].Nodes[j].Expand();
                           
                       List<OPDPrescriptionReportNewRO> leafTwo = new List<OPDPrescriptionReportNewRO>();
                       
                       leafTwo = oPatTreeNew.Where(x => x.VisitDate == oPatTreeNew[i].VisitDate && x.UnitName == leafOne[j].UnitName ).ToList();

                       for (int k = 0; k < leafTwo.Count; k++)
                       {
                           PatientsHistoryTree.Nodes[i].Nodes[j].Nodes.Add(leafTwo[k].ComplaintsTitle);
                          // PatientsHistoryTree.Nodes[i].Nodes[j].Nodes[k].NodeFont = new Font("Tahoma", 11F);

                           PatientsHistoryTree.Nodes[i].Nodes[j].Nodes.Add(leafTwo[k].ClinicalFindings);
                          // PatientsHistoryTree.Nodes[i].Nodes[j].Nodes[k].NodeFont = new Font("Tahoma", 11F);

                           PatientsHistoryTree.Nodes[i].Nodes[j].Nodes.Add(leafTwo[k].Diagnosis);
                        //   PatientsHistoryTree.Nodes[i].Nodes[j].Nodes[k].NodeFont = new Font("Tahoma", 11F);

                           PatientsHistoryTree.Nodes[i].Nodes[j].Nodes.Add(leafTwo[k].TestDetailsName);
                         //  PatientsHistoryTree.Nodes[i].Nodes[j].Nodes[k].NodeFont = new Font("Tahoma", 11F);

                           PatientsHistoryTree.Nodes[i].Nodes[j].Nodes.Add(leafTwo[k].Medicine);
                         //  PatientsHistoryTree.Nodes[i].Nodes[j].Nodes[k].NodeFont = new Font("Tahoma", 11F);

                           PatientsHistoryTree.Nodes[i].Nodes[j].Nodes.Add(leafTwo[k].Advice);

                          // PatientsHistoryTree.Nodes[i].Nodes[j].Nodes[k].NodeFont = new Font("Tahoma", 11F);
                       }
                     //  tempUnit = leafOne[j].UnitName; 
                    }
                }
            }
        }

        private void frmPrescription_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lvComplaints.Items.Count > 0 || lvClinicalFindings.Items.Count > 0 ||
                           lvCollectedClinicalDiagnosis.Items.Count > 0 || lvSelectedTests.Items.Count > 0 ||
                               lvDrugs.Items.Count > 0 || lvAdvicePrescription.Items.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Do you want to close WITHOUT saving Prescription ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
            if (lvComplaints.Items.Count > 0 || lvClinicalFindings.Items.Count > 0 ||
                           lvCollectedClinicalDiagnosis.Items.Count > 0 || lvSelectedTests.Items.Count > 0 ||
                               lvDrugs.Items.Count > 0 || lvAdvicePrescription.Items.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Do you want to close WITHOUT saving Prescription ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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

        private void lvAdvicePrescription_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
 
    }
}