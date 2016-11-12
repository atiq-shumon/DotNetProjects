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
    public partial class frmPatientListDietAssignDetails : AH.Shared.UI.frmSmartFormStandard
    {
        DIETSR.DIETWSClient dietSC = new DIETSR.DIETWSClient();
        private string mode;
        public frmPatientListDietAssignDetails(string mode)
        {
            InitializeComponent();
            this.mode = mode;
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
            dgvPatientList.Columns.Add(CreateGridColumnchkFormat("CheckBox", "", 30, true, DataGridViewContentAlignment.MiddleCenter, false, false, "checkbox"));
            dgvPatientList.Columns.Add(FormatGrid("SL.", "SL.", 35, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("AdmissionId", "Admission No", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("PatientName", " Name", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("CellPhone", "Cell Phone", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("Department", "Department", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("Unit", "Unit", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("Bed", "Bed", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("AdmissionDate", "Admission Date", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("dietid", "Assigned Diet", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("dietid", "dietid", 0, false, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("PatientType", "PatientType",100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));

           // dgvPatientList.Columns.Add(CreateGridColumnButtonFormat("ADD", "ADD/EDIT Diet"));       
            dgvPatientList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }
        public DataGridViewCheckBoxColumn CreateGridColumnchkFormat(string pname, string htext, int cwidth, Boolean visibility, DataGridViewContentAlignment Algin, bool IsReadOnly, bool Isfrozen, string columnType)
        {
            DataGridViewCheckBoxColumn Ckbox = new DataGridViewCheckBoxColumn();
            Ckbox.DataPropertyName = pname;
            Ckbox.HeaderText = htext;
            Ckbox.Name = pname;
            Ckbox.DefaultCellStyle.ForeColor = Color.Black;
            Ckbox.DefaultCellStyle.BackColor = Color.White;
            Ckbox.Visible = visibility;
            Ckbox.DefaultCellStyle.Alignment = Algin;
            Ckbox.Width = cwidth - 1;
            Ckbox.ReadOnly = IsReadOnly;
            Ckbox.Frozen = Isfrozen;

            return Ckbox;

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

            cboMealType.DisplayMember = "MealName";
            cboMealType.ValueMember = "MealID";
            cboMealType.DataSource = dietSC.LoadmealSetup();

            if(mode=="B")
            {
                lblBill.Visible = false;
                lblClon.Visible = false;
                txtBill.Visible = false;
                btnAssign.Visible = false;
                frmLabel.Text = "Order Delivery";
            }
            if(mode=="C")
            {
                lblBill.Visible = false;
                lblClon.Visible = false;
                txtBill.Visible = false;
                btnAssign.Visible = false;
                frmLabel.Text = "Served Food";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboReceivingNurseStation", "cboMealType" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            List<InPatient> patLists = new List<InPatient>();
            if(mode=="A")
            {
                patLists.Clear();
                patLists = dietSC.NSWisePatientListDiet(cboReceivingNurseStation.SelectedValue.ToString(), cboDietType.SelectedValue.ToString(), dtpDate.Value, cboMealType.SelectedValue.ToString()).ToList();
            }
            if (mode =="B")
            {
                patLists.Clear();
                patLists = dietSC.OrderdNSWisePatientListDiet(cboReceivingNurseStation.SelectedValue.ToString(), cboDietType.SelectedValue.ToString(), dtpDate.Value, cboMealType.SelectedValue.ToString()).ToList();
            }
            if(mode=="C")
            {
                patLists.Clear();
                patLists = dietSC.ReadyToDelevPatientListDiet(cboReceivingNurseStation.SelectedValue.ToString(), cboDietType.SelectedValue.ToString(), dtpDate.Value, cboMealType.SelectedValue.ToString()).ToList();
            }

            dgvPatientList.Rows.Clear();
            for (int rcont = 0; rcont < patLists.Count; rcont++)
            {
                dgvPatientList.Rows.Add();
                dgvPatientList[1, rcont].Value = rcont + 1;
                dgvPatientList[2, rcont].Value = patLists[rcont].RegistrationNo;
                dgvPatientList[3, rcont].Value = patLists[rcont].Name;
                dgvPatientList[4, rcont].Value = patLists[rcont].CellPhone;
                dgvPatientList[5, rcont].Value = patLists[rcont].Department.DepartmentTitle;
                dgvPatientList[6, rcont].Value = patLists[rcont].DepartmentUnit.UnitTitle;
                dgvPatientList[7, rcont].Value = patLists[rcont].Bed.BedTitle;
                dgvPatientList[8, rcont].Value = patLists[rcont].AdmissionDate.ToString("dd/MM/yyyy");

            }
            LoadAssignedDiet();
            CheckedCheckBox();
            PatientType();
        }
        private void CheckedCheckBox()
        {
            for (int i = 0; i < dgvPatientList.Rows.Count; i++)
            {
                dgvPatientList.Rows[i].Cells[0].Value = true;
            }
        }
        private IPDDiet PopulateIPDPatientDiet()
        {
            IPDDiet diet = new IPDDiet();
            diet.NurseStationID = cboReceivingNurseStation.SelectedValue.ToString();
            diet.DietTypeID = "01";//cboDietType.SelectedValue.ToString();
            diet.DietDateTime = Convert.ToDateTime(dtpDate.Value.ToString("dd/MM/yyyy"));
            MealSetup meal = new MealSetup();
            meal.MealID = cboMealType.SelectedValue.ToString();
            diet.MealSetup = meal;
            if (txtBill.Text != "")
            {
                diet.Bill = Convert.ToInt32(txtBill.Text);
            }
            else
            {
                diet.Bill = Convert.ToInt32(0);
            }

            FoodItem food = new FoodItem();
            food.ItemID = "01";
            diet.FoodItem = food;

            string admission = "";

            for(int i=0;i<dgvPatientList.Rows.Count;i++)                
            {
                if (Convert.ToBoolean(dgvPatientList.Rows[i].Cells[0].Value) == true)
                {
                    admission =admission+dgvPatientList.Rows[i].Cells[2].Value.ToString() + "$" +dgvPatientList.Rows[i].Cells[10].Value.ToString() +"~";
                }
            }       
            diet.AdmissionID = admission;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            diet.EntryParameter = ep;

            return diet;

        }
       
        private void LoadAssignedDiet()
        {
            if (dgvPatientList.Rows.Count > 0)
            {
                List<IPDDiet> diets = new List<IPDDiet>();
                diets = dietSC.GetIPDDiet(cboReceivingNurseStation.SelectedValue.ToString()).ToList();
                for (int rcont = 0; rcont < diets.Count; rcont++)
                {
                    for(int r = 0; r < dgvPatientList.Rows.Count;r++)
                    {
                        if (dgvPatientList[2, r].Value.ToString() == diets[rcont].AdmissionID.ToString())
                        {
                            dgvPatientList[9, r].Value = diets[rcont].DietTypeTitle;
                            dgvPatientList[10, r].Value = diets[rcont].DietTypeID;
                        }
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvPatientList.Rows.Clear();
        }

        private void cboReceivingNurseStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (mode == "A")
            //{
                cboDietType.DisplayMember = "Value";
                cboDietType.ValueMember = "Key";
                cboDietType.DataSource = new BindingSource(dietSC.GetNurseStnWiseDietType(cboReceivingNurseStation.SelectedValue.ToString(),Convert.ToDateTime(dtpDate.Value.ToString("dd/MM/yyyy"))), null);
            //}
           //else
           // {
           //     cboDietType.DataSource = null;
           //     cboDietType.DisplayMember = "Value";
           //     cboDietType.ValueMember = "Key";
           //     cboDietType.DataSource = new BindingSource(dietSC.DietTypeOrderedDelevered(cboReceivingNurseStation.SelectedValue.ToString(),Convert.ToDateTime(dtpDate.Value.ToString("dd-MM-yyyy"))), null);
           // }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboReceivingNurseStation", "cboDietType", "cboMealType"};
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
               
                int  isCheckFlag = 0;
                for (int row = 0; row < dgvPatientList.Rows.Count; row++)
                {
                    if (Convert.ToBoolean(dgvPatientList.Rows[row].Cells[0].Value) == true)
                    {
                        isCheckFlag = 1;
                    }
                }
                if (isCheckFlag != 1)
                {
                    MessageBox.Show("No Patient is selected", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (mode == "A")
                {
                    IPDDiet diet = this.PopulateIPDPatientDiet();
                    string i = dietSC.SaveIPDPatientDietReg(diet);

                    if (i == "0")
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i == "1")
                    {
                        MessageBox.Show("Order Successful!", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnShow.PerformClick();
                    }
                }
                if(mode=="B")
                {
                    IPDDiet diet = this.PopulateIPDPatientDiet();
                    string i = dietSC.UpdateOrderedIPDPatientDietList(diet);

                    if (i == "0")
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i == "1")
                    {
                        MessageBox.Show("Order Delivered Successful!", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnShow.PerformClick();

                    }
                }
                if (mode == "C")
                {
                    IPDDiet diet = this.PopulateIPDPatientDiet();
                    string i = dietSC.UpdateFoodServedtDietList(diet);

                    if (i == "0")
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i == "1")
                    {
                        MessageBox.Show("Food Served Successful!", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnShow.PerformClick();
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

        private void btnAssign_Click(object sender, EventArgs e)
        {
            frmPatientListDietAssign frm = new frmPatientListDietAssign();
            frm.ShowDialog();
            btnShow.PerformClick();
        }
        private void PatientType()
        {
            List<InPatient> oPat = new List<InPatient>();
            oPat = dietSC.GetNewPatient().ToList();
            for (int r = 0; r < oPat.Count; r++)
            {
                for (int rcont = 0; rcont < dgvPatientList.Rows.Count; rcont++)
                {
                    if (dgvPatientList[2, rcont].Value.ToString() == oPat[r].RegistrationNo)
                    {
                        dgvPatientList[11, rcont].Value = "NEW PATIENT";
                    }
                    else
                    {
                        dgvPatientList[11, rcont].Value = "RUNNING PATIENT";
                    }
                }
            }
            if (oPat.Count == 0)
            {
                for (int rcont = 0; rcont < dgvPatientList.Rows.Count; rcont++)
                {
                    dgvPatientList[11, rcont].Value = "RUNNING PATIENT";
                }
            }
        }
    }
}
