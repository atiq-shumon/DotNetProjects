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
using AH.Shared.UI;
using AH.ModuleController.DIETSR;
namespace AH.ModuleController.UI.DIET.Forms
{
    public partial class frmAdmittedPatientInfo : AH.Shared.UI.frmSmartFormStandard
    {
        DIETSR.DIETWSClient dietSC = new DIETSR.DIETWSClient();
        List<InPatient> patLists = new List<InPatient>();
        public frmAdmittedPatientInfo()
        {            
            InitializeComponent();
        }
        private void GridFormat()
        {
            dgvPatList.Columns.Add(FormatGrid("SL.", "SL.",25, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgvPatList.Columns.Add(FormatGrid("AdmissionID", "Adm ID", 80, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgvPatList.Columns.Add(FormatGrid("HCN", "HCN", 80, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgvPatList.Columns.Add(FormatGrid("BedNo", "Bed No", 80, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgvPatList.Columns.Add(FormatGrid("Name", "Name", 180, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgvPatList.Columns.Add(FormatGrid("Age/Sex", "Age/Sex", 205, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgvPatList.Columns.Add(FormatGrid("CurrentDiet", "Current Diet", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgvPatList.Columns.Add(CreateGridColumnButtonFormat("ADD", "ADD/EDIT Diet"));  
            dgvPatList.Columns.Add(FormatGrid("AdmissionDate/Time", "Admission Date/Time", 170, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));         
            dgvPatList.Columns.Add(FormatGrid("DoctorName", "Doctor Name", 180, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgvPatList.Columns.Add(FormatGrid("Discharge Date", "Discharge Date/Time",170, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgvPatList.Columns.Add(FormatGrid("NurseStationID", "NurseStationID", 0, false, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgvPatList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }
        public DataGridViewButtonColumn CreateGridColumnButtonFormat(string name, string buttonText)
        {
            DataGridViewButtonColumn oButton = new DataGridViewButtonColumn();
            oButton.HeaderText = "Add/Edit Diet";
            oButton.Name = name;
            oButton.Text = buttonText;
            oButton.CellTemplate.Style.BackColor = Color.LightCyan;
            oButton.UseColumnTextForButtonValue = true;
            return oButton;
        }
       
        private DataGridViewTextBoxColumn FormatGrid(string pname, string htext, int cwidth, Boolean true_false, string font, int fontsize, DataGridViewContentAlignment Algin)
        {
            DataGridViewTextBoxColumn Deptcolumn = new DataGridViewTextBoxColumn();
            Deptcolumn.DataPropertyName = pname;
            Deptcolumn.HeaderText = htext;
            Deptcolumn.DefaultCellStyle.ForeColor = Color.Black;
            Deptcolumn.DefaultCellStyle.BackColor = Color.White;
            Deptcolumn.Visible = true_false;
            Deptcolumn.DefaultCellStyle.Alignment = Algin;
            Deptcolumn.Width = cwidth;
            Deptcolumn.ReadOnly = true;
            Deptcolumn.DefaultCellStyle.Font = new Font(font, fontsize, FontStyle.Regular);
            DataGridViewCellStyle style =
            dgvPatList.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.LightSteelBlue;
            style.ForeColor = Color.Black;
            style.Font = new Font(dgvPatList.Font, FontStyle.Bold);
            Deptcolumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //Deptcolumn.Selected = false;

            return Deptcolumn;
        }
        private void frmAdmittedPatientInfo_Load(object sender, EventArgs e)
        {
            GridFormat();
            rdoCensus.Checked = true;
            groupBox2.Enabled = false;
            dgvPatList.Rows[0].Selected = false;
            dgvDietList.Visible = false;
            AddGridColumnForDietLst();
            LoadDiet();
            dgvDietList.GridColor = Color.LightSkyBlue;
        }

        private void rdoCensus_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoCensus.Checked==true)
            {
               // List<InPatient> patLists = new List<InPatient>();
                patLists.Clear();
                patLists = dietSC.GetAdmittedAllPatList().ToList();
                lblText.Text = "Total Patient List  :" +""+ patLists.Count.ToString();
                dgvPatList.Columns[8].HeaderText = "Admission Date/Time";
                dgvPatList.Rows.Clear();
                if (patLists.Count > 0)
                {
                    for (int rcont = 0; rcont < patLists.Count; rcont++)
                    {
                        dgvPatList.Rows.Add();
                        dgvPatList[0, rcont].Value = rcont + 1;
                        dgvPatList[1, rcont].Value = patLists[rcont].RegistrationNo;
                        dgvPatList[2, rcont].Value = patLists[rcont].HCN;
                        dgvPatList[3, rcont].Value = patLists[rcont].Bed.BedTitle;
                        dgvPatList[4, rcont].Value = patLists[rcont].Name;
                        dgvPatList[5, rcont].Value = patLists[rcont].AgeFull + "/" + patLists[rcont].Sex;
                        dgvPatList[6, rcont].Value = patLists[rcont].CurrentDietTitle.ToString();
                        dgvPatList[8, rcont].Value = patLists[rcont].AdmissionDate.ToString();
                        dgvPatList[9, rcont].Value = patLists[rcont].Department.DepartmentUnitHead;
                        dgvPatList[11, rcont].Value = patLists[rcont].NurseStation.NurseStationID;
                    }
                    NewAdmission();
                }
                rdoAdmissionDate.Checked = false;
                rdoDischargeDate.Checked = false;
                rdoTransferDate.Checked = false;
            }
            
           
        }

        private void rdoATD_CheckedChanged(object sender, EventArgs e)
        {           
            if (rdoATD.Checked == true)
            {
                groupBox2.Enabled = true;
                dgvPatList.Rows.Clear();
                lblText.Text = "";
            }
        }

        private void rdoAdmissionDate_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoAdmissionDate.Checked==true)
            {             
                dgvPatList.Columns[8].HeaderText = "Admission Date/Time";
                dgvPatList.Columns[7].Visible = true;
             
               // List<InPatient> patLists = new List<InPatient>();
                patLists.Clear();
                patLists = dietSC.GetAdmDateWisePatList(dtpFromDate.Value,dtpToDate.Value).ToList();
                lblText.Text = "Total Admission Between  " + dtpFromDate.Value.ToString("dd/MM/yyyy") + " and " + dtpToDate.Value.ToString("dd/MM/yyyy") + " : " + "" + patLists.Count.ToString();
                dgvPatList.Rows.Clear();
                if (patLists.Count > 0)
                {
                    for (int rcont = 0; rcont < patLists.Count; rcont++)
                    {
                        dgvPatList.Rows.Add();
                        dgvPatList[0, rcont].Value = rcont + 1;
                        dgvPatList[1, rcont].Value = patLists[rcont].RegistrationNo;
                        dgvPatList[2, rcont].Value = patLists[rcont].HCN;
                        dgvPatList[3, rcont].Value = patLists[rcont].Bed.BedTitle;
                        dgvPatList[4, rcont].Value = patLists[rcont].Name;
                        dgvPatList[5, rcont].Value = patLists[rcont].AgeFull + "/" + patLists[rcont].Sex;
                        dgvPatList[6, rcont].Value = patLists[rcont].CurrentDietTitle.ToString();
                        dgvPatList[8, rcont].Value = patLists[rcont].AdmissionDate.ToString();
                        dgvPatList[9, rcont].Value = patLists[rcont].Department.DepartmentUnitHead;
                        dgvPatList[11, rcont].Value = patLists[rcont].NurseStation.NurseStationID;
                    }
                    NewAdmission();
                }
            }
        }

        private void rdoTransferDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTransferDate.Checked == true)
            {             
                dgvPatList.Columns[8].HeaderText = "Bed Transfer Date/Time";
                dgvPatList.Columns[7].Visible = true;
            
                //List<InPatient> patLists = new List<InPatient>();
                patLists.Clear();
                patLists = dietSC.GetBedTransferDateWisePatList(dtpFromDate.Value, dtpToDate.Value).ToList();
                lblText.Text = "Total Bed Transfer Between  " + dtpFromDate.Value.ToString("dd/MM/yyyy") + " and " + dtpToDate.Value.ToString("dd/MM/yyyy") + " : " + "" + patLists.Count.ToString();
                dgvPatList.Rows.Clear();
                if (patLists.Count > 0)
                {
                    for (int rcont = 0; rcont < patLists.Count; rcont++)
                    {
                        dgvPatList.Rows.Add();
                        dgvPatList[0, rcont].Value = rcont + 1;
                        dgvPatList[1, rcont].Value = patLists[rcont].RegistrationNo;
                        dgvPatList[2, rcont].Value = patLists[rcont].HCN;
                        dgvPatList[3, rcont].Value = patLists[rcont].Bed.BedTitle;
                        dgvPatList[4, rcont].Value = patLists[rcont].Name;
                        dgvPatList[5, rcont].Value = patLists[rcont].AgeFull + "/" + patLists[rcont].Sex;
                        dgvPatList[6, rcont].Value = patLists[rcont].CurrentDietTitle.ToString();
                        dgvPatList[8, rcont].Value = patLists[rcont].AdmissionDate.ToString();
                        dgvPatList[9, rcont].Value = patLists[rcont].Department.DepartmentUnitHead;
                        dgvPatList[11, rcont].Value = patLists[rcont].NurseStation.NurseStationID;
                    }
                    NewAdmission();
                }
                
            }
        }

        private void rdoDischargeDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDischargeDate.Checked == true)
            {              
                dgvPatList.Columns[8].HeaderText = "Admission Date/Time";
                dgvPatList.Columns[7].Visible = false;              
              //  List<InPatient> patLists = new List<InPatient>();
                patLists.Clear();
                patLists = dietSC.GetDischargeDateWisePatList(dtpFromDate.Value, dtpToDate.Value).ToList();
                lblText.Text = "Total Discharge Between  " + dtpFromDate.Value.ToString("dd/MM/yyyy") + " and " + dtpToDate.Value.ToString("dd/MM/yyyy") + " : " + "" + patLists.Count.ToString();
                dgvPatList.Rows.Clear();
                if (patLists.Count > 0)
                {
                    for (int rcont = 0; rcont < patLists.Count; rcont++)
                    {
                        dgvPatList.Rows.Add();
                        dgvPatList[0, rcont].Value = rcont + 1;
                        dgvPatList[1, rcont].Value = patLists[rcont].RegistrationNo;
                        dgvPatList[2, rcont].Value = patLists[rcont].HCN;
                        dgvPatList[3, rcont].Value = patLists[rcont].Bed.BedTitle;
                        dgvPatList[4, rcont].Value = patLists[rcont].Name;
                        dgvPatList[5, rcont].Value = patLists[rcont].AgeFull + "/" + patLists[rcont].Sex;
                        dgvPatList[6, rcont].Value = patLists[rcont].CurrentDietTitle.ToString();
                        dgvPatList[8, rcont].Value = patLists[rcont].AdmissionDate.ToString();
                        dgvPatList[9, rcont].Value = patLists[rcont].Department.DepartmentUnitHead;
                        dgvPatList[10, rcont].Value = patLists[rcont].DischargeDate;
                        dgvPatList[11, rcont].Value = patLists[rcont].NurseStation.NurseStationID;
                      
                    }
                }
            }
        }
        private void SearchPatientList()
        {
            if (txtSearchItem.Text.Length == 11)
            {
                patLists = dietSC.GetAdmittedAllPatList().ToList();
                IEnumerable<InPatient> query = patLists;

                if (txtSearchItem.Text.Length == 11)
                {
                    query = (from inPats in patLists
                             where inPats.HCN == txtSearchItem.Text.ToUpper() || inPats.RegistrationNo == txtSearchItem.Text.ToUpper()
                             select inPats);
                }

                dgvPatList.Rows.Clear();
                foreach (InPatient inPat in query)
                {
                    dgvPatList.Rows.Add();
                    dgvPatList[1, 0].Value = inPat.RegistrationNo;
                    dgvPatList[2, 0].Value = inPat.HCN;
                    dgvPatList[3, 0].Value = inPat.Bed.BedTitle;
                    dgvPatList[4, 0].Value = inPat.Name;
                    dgvPatList[5, 0].Value = inPat.AgeFull + "/" + inPat.Sex;
                    dgvPatList[6, 0].Value = inPat.CurrentDietTitle;
                    dgvPatList[8, 0].Value = inPat.AdmissionDate.ToString();
                    dgvPatList[9, 0].Value = inPat.Department.DepartmentUnitHead;
                    dgvPatList[10, 0].Value = inPat.DischargeDate;
                    dgvPatList[11, 0].Value = inPat.NurseStation.NurseStationID;
                }
            }
           
        }
        private void txtSearchItem_Leave(object sender, EventArgs e)
        {
            if (txtSearchItem.Text.Length == 11)
            {
                SearchPatientList();
            }
        }
        private void NewAdmission()
        {
            for (int i = 0; i < patLists.Count; i++)
            {
                if (patLists[i].AdmissionDate.ToString("dd/MM/yyyy") == DateTime.Today.ToString("dd/MM/yyyy"))
                {
                    dgvPatList.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;
                }
                if(dgvPatList.Rows[i].Cells[6].Value!="")
                {
                    dgvPatList.Rows[i].Cells[6].Style.ForeColor = Color.Maroon;                  
                }
            }
        }
        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchItem.Text.Length == 11)
            {
                SearchPatientList();
                lblText.Text = "Search Item  " + dtpFromDate.Value.ToString("dd/MM/yyyy") + " and " + dtpToDate.Value.ToString("dd/MM/yyyy") + " : " + "" + "1";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if(txtSearchItem.Text=="")
            {
                if (rdoCensus.Checked == true)
                {
                    this.rdoCensus_CheckedChanged(sender, e);
                }
                if (rdoAdmissionDate.Checked == true)
                {
                    this.rdoAdmissionDate_CheckedChanged(sender, e);
                }
                if (rdoTransferDate.Checked == true)
                {
                    this.rdoTransferDate_CheckedChanged(sender, e);
                }
                if (rdoDischargeDate.Checked == true)
                {
                    this.rdoDischargeDate_CheckedChanged(sender, e);
                }
            }
            else
            {
                SearchPatientList();
            }
          
        }
        private void AddGridColumnForDietLst()
        {
            dgvDietList.Columns.Add(FormatGrid("SL.", "SL.", 35, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvDietList.Columns.Add(FormatGrid("DietID", "DietID", 0, false, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvDietList.Columns.Add(FormatGrid("DietType", "DietType", 205, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgvDietList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }
        private void LoadDiet()
        {
            List<IPDDiet> diets = new List<IPDDiet>();
            diets = dietSC.GetDietList().ToList();
            for (int rcont = 0; rcont < diets.Count; rcont++)
            {
                dgvDietList.Rows.Add();
                dgvDietList[0, rcont].Value = rcont + 1;
                dgvDietList[1, rcont].Value = diets[rcont].DietTypeID;
                dgvDietList[2, rcont].Value = diets[rcont].DietTypeTitle;
            }

        }
        private IPDDiet PopulateIPDPatientDiet()
        {
            IPDDiet diet = new IPDDiet();

            if (txtDeitID.Text != "" && txtAdmissionID.Text != "" && txtNSID.Text!="")
            {
                diet.DietTypeID = txtDeitID.Text;
                diet.AdmissionID = txtAdmissionID.Text;
                diet.NurseStationID = txtNSID.Text;
            }

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            diet.EntryParameter = ep;

            return diet;

        }
        private void dgvDietList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                txtDeitID.Text = dgvDietList.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString();
             
                try
                {
                    IPDDiet diet = this.PopulateIPDPatientDiet();
                    string i = dietSC.SaveIPDPatientDiet(diet);

                    if (i.Length == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i.Length > 0)
                    {
                        MessageBox.Show("Diet Assign Successful!", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                dgvDietList.Visible = false;
                btnRefresh.PerformClick();
            }
        }

        private void dgvPatList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex != -1)
            {
                txtAdmissionID.Text = dgvPatList.Rows[e.RowIndex].Cells[e.ColumnIndex - 6].Value.ToString();
                txtNSID.Text= dgvPatList.Rows[e.RowIndex].Cells[e.ColumnIndex+4].Value.ToString();
                dgvDietList.Visible = true;
            }
        }

        private void pnlMain_MouseHover(object sender, EventArgs e)
        {
            dgvDietList.Visible = false;
        }

        private void groupBox2_MouseHover(object sender, EventArgs e)
        {
            dgvDietList.Visible = false;
        }

        private void dgvDietList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }           
    }
}
