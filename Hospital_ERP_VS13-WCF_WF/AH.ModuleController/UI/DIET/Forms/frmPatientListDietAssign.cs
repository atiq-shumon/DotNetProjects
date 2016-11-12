using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.DIETSR;
using AH.ModuleController.UI.IPD.Forms;

namespace AH.ModuleController.UI.DIET.Forms
{
    public partial class frmPatientListDietAssign : AH.Shared.UI.frmSmartFormStandard
    {
        DIETSR.DIETWSClient dietSC = new DIETSR.DIETWSClient();
        public frmPatientListDietAssign()
        {
            InitializeComponent();
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
            return Deptcolumn;
        }
        
        private void AddGridColumn()
        {          
            dgvPatientList.Columns.Add(FormatGrid("SL.", "SL.", 35, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("AdmissionId", "Admission No", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("PatientName", " Name", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("CellPhone", "Cell Phone", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("Department", "Department", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("Unit", "Unit", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("Bed", "Bed", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("AdmissionDate", "Admission Date", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("dietid", "Assigned Diet", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("PatientType", "Patient Type", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));      

            dgvPatientList.Columns.Add(CreateGridColumnButtonFormat("ADD", "ADD/EDIT Diet"));       
            dgvPatientList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }
        public DataGridViewButtonColumn CreateGridColumnButtonFormat(string name, string buttonText)
        {
            DataGridViewButtonColumn oButton = new DataGridViewButtonColumn();
            oButton.HeaderText = "Add/Edit Diet";
            oButton.Name = name;
            oButton.Text = buttonText;
            oButton.UseColumnTextForButtonValue = true;
            return oButton;

        }
       
        private void frmPatientList_Load(object sender, EventArgs e)
        {
            AddGridColumn();
            PatientAdmissionUtility obj = new PatientAdmissionUtility();
            obj.cboReceivingNurseStation(cboReceivingNurseStation);
            AddGridColumnForDietLst();
            LoadDiet();
            dgvDietList.Visible = false;
          
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboReceivingNurseStation" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            } 
            List<InPatient> patLists = new List<InPatient>();
            patLists = dietSC.GetAdmittedPatientListNSWise(cboReceivingNurseStation.SelectedValue.ToString()).ToList();
            dgvPatientList.Rows.Clear();
            for (int rcont = 0; rcont < patLists.Count; rcont++)
            {
                dgvPatientList.Rows.Add();
                dgvPatientList[0, rcont].Value = rcont + 1;
                dgvPatientList[1, rcont].Value = patLists[rcont].RegistrationNo;
                dgvPatientList[2, rcont].Value = patLists[rcont].Name;
                dgvPatientList[3, rcont].Value = patLists[rcont].CellPhone;
                dgvPatientList[4, rcont].Value = patLists[rcont].Department.DepartmentTitle;
                dgvPatientList[5, rcont].Value = patLists[rcont].DepartmentUnit.UnitTitle;
                dgvPatientList[6, rcont].Value = patLists[rcont].Bed.BedTitle;
                dgvPatientList[7, rcont].Value = patLists[rcont].AdmissionDate.ToString("dd/MM/yyyy");

            }
            LoadAssignedDiet();
            PatientType();
        }
     
        private IPDDiet PopulateIPDPatientDiet()
        {
            IPDDiet diet = new IPDDiet();
            diet.NurseStationID = cboReceivingNurseStation.SelectedValue.ToString();
            if (txtDeitID.Text != "" && txtAdmissionID.Text != "")
            {
                diet.DietTypeID = txtDeitID.Text;
                diet.AdmissionID = txtAdmissionID.Text;
            }
             
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            diet.EntryParameter = ep;

            return diet;

        }
       
    
        private void AddGridColumnForDietLst()
        {
            dgvDietList.Columns.Add(FormatGrid("SL.", "SL.", 35, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvDietList.Columns.Add(FormatGrid("DietID", "DietID", 0, false, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvDietList.Columns.Add(FormatGrid("DietType", "DietType", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
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

   
        private void dgvPatientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10 && e.RowIndex != -1)
            {
                txtAdmissionID.Text = dgvPatientList.Rows[e.RowIndex].Cells[e.ColumnIndex - 9].Value.ToString();
                dgvDietList.Visible = true;
            }
            
        }
        private void LoadAssignedDiet()
        {
            if (dgvPatientList.Rows.Count > 0)
            {
                List<IPDDiet> diets = new List<IPDDiet>();
                diets = dietSC.GetIPDDiet(cboReceivingNurseStation.SelectedValue.ToString()).ToList();
                for (int rcont = 0; rcont < diets.Count; rcont++)
                {
                    for (int i = 0; i < dgvPatientList.Rows.Count; i++)
                    {
                        if (dgvPatientList[1, i].Value.ToString() == diets[rcont].AdmissionID.ToString())
                        {
                            dgvPatientList[8, i].Value = diets[rcont].DietTypeTitle;
                        }
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvPatientList.Rows.Clear();
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
                LoadAssignedDiet();

            }
        }

        private void groupBox4_MouseHover(object sender, EventArgs e)
        {
            dgvDietList.Visible = false;
        }
    
        private void PatientType()
        {
            List<InPatient> oPat = new List<InPatient>();
            oPat = dietSC.GetNewPatient().ToList();
            for (int r = 0; r < oPat.Count; r++)
            {
                for (int rcont = 0; rcont < dgvPatientList.Rows.Count; rcont++)
                {
                    if (dgvPatientList[1, rcont].Value.ToString() == oPat[r].RegistrationNo)
                    {
                        dgvPatientList[9, rcont].Value = "NEW PATIENT";
                    }
                    else
                    {
                        dgvPatientList[9, rcont].Value = "RUNNING PATIENT";
                    }
                }
            }
            if(oPat.Count==0)
            {
                for (int rcont = 0; rcont < dgvPatientList.Rows.Count; rcont++)
                {
                    dgvPatientList[9, rcont].Value = "RUNNING PATIENT";
                }
            }
        }
    
    }
}
