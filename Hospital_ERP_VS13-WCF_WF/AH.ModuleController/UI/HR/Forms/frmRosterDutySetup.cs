using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using AH.DUtility;
using AH.ModuleController.HRSR;
using System.Drawing.Drawing2D;
using System.IO;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmRosterDutySetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string DepartmentType { set; get; }
        public string DepartmentGroup { set; get; }
        public string Department { set; get; }
        public string Unit { set; get; }
        public string Year { set; get; }
        public string Month { set; get; }
        public string DutyDate { set; get; }
        public string Mode { set; get; }

        private List<EmployeeMaster> oEmpMass;
        public frmRosterDutySetup()
        {
            InitializeComponent();
        }

        private void frmRosterDutySetup_Load(object sender, EventArgs e)
        {
            FormatGrid(dgvInitialGrid);
            FormatAssociatedGrid();

            

            cboYear.DisplayMember = "Value";
            cboYear.ValueMember = "Key";
            cboYear.DataSource = new BindingSource(Utility.GetNumbers(2015, 2025), null);
            cboYear.Text = DateTime.Now.ToString("yyyy");

            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);

            cboShift.DisplayMember = "Value";
            cboShift.ValueMember = "Key";
            cboShift.DataSource = new BindingSource(hmsSC.GetShiftDict("D"), null);

            if (DepartmentType != null)
            {
                cboYear.Text = Year.ToString();
                cboMonth.SelectedValue = Month.ToString();

                if (DutyDate != null)
                {
                    string month = DateTime.Parse(cboMonth.Text).ToString("MMMM");
                    int i = DateTime.ParseExact(month, "MMMM", System.Globalization.CultureInfo.CurrentCulture).Month;
                    dtStartDate.Text = Convert.ToDateTime(DutyDate + "/" + i + "/" + cboYear.Text).ToString("dd/MM/yyyy");
                    dtEndDate.Text = Convert.ToDateTime(DutyDate + "/" + i + "/" + cboYear.Text).ToString("dd/MM/yyyy");
                }

                cboDepartmentType.SelectedValue = DepartmentType.ToString();
                cboDepartmentGroup.SelectedValue = DepartmentGroup.ToString();
                cboDepartment.SelectedValue = Department.ToString();
                cboUnit.SelectedValue = Unit.ToString();
                if (Mode=="A")
                {
                    rdoAll.Checked = true;
                }
                if (Mode == "B")
                {
                    rdoDeptGrp.Checked = true;
                }
                if (Mode == "C")
                {
                    rdoGrpDeptUnit.Checked = true;
                }
                this.btnShow_Click(sender, e);            
            }
           
        }

        private void cboDepartmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentType.SelectedValue != null)
            {
                cboDepartmentGroup.DisplayMember = "Value";
                cboDepartmentGroup.ValueMember = "Key";
                cboDepartmentGroup.DataSource = new BindingSource(hmsSC.GetDeptGroupDicByType(cboDepartmentType.SelectedValue.ToString()), null);
            }
        }

        private void cboDepartmentGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentGroup.SelectedValue != null)
            {
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(hmsSC.GetDepartmentsetupDic(null, cboDepartmentGroup.SelectedValue.ToString()), null);
            }
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(hmsSC.GetDeptUnitDic(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString())), null);
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonth.DisplayMember = "Value";
            cboMonth.ValueMember = "Key";
            cboMonth.DataSource = new BindingSource(hmsSC.GetMonth(cboYear.SelectedValue.ToString()), null);

            cboMonth.Text = DateTime.Now.ToString("MMM-yyyy");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDepartmentGroup", "cboDepartment", "cboUnit"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (rdoAll.Checked == true)
            {
                LoadListView("A", cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString());
                LoadRosterDuty("A", cboYear.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), dtStartDate.Text.ToString(), dtEndDate.Text.ToString());
            }
            if (rdoDeptGrp.Checked == true)
            {
                LoadListView("B", cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString());
                LoadRosterDuty("B", cboYear.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), dtStartDate.Text.ToString(), dtEndDate.Text.ToString());
            }
            if (rdoGrpDeptUnit.Checked == true)
            {
                LoadListView("C", cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString());
                LoadRosterDuty("C", cboYear.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), dtStartDate.Text.ToString(), dtEndDate.Text.ToString());
            }
            
            
        }
        private void FormatGrid(DataGridView dgv)
        {
            this.dgvInitialGrid.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvInitialGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dgvInitialGrid.Columns.Add(chk);
            chk.HeaderText = "Select";
            chk.Name = "chk";
            chk.Visible = true;
            chk.Width = 53;
            dgv.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn ID = new DataGridViewTextBoxColumn();
            ID.Name = "ID";
            ID.DataPropertyName = "ID";
            ID.Width = 55;
            ID.ReadOnly = true;
            dgv.Columns.Add(ID);

            DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
            Name.Name = "Name";
            Name.DataPropertyName = "Name";
            Name.Width = 310;
            Name.ReadOnly = true;
            dgv.Columns.Add(Name);

            DataGridViewTextBoxColumn DesigID = new DataGridViewTextBoxColumn();
            DesigID.Name = "DesigID";
            DesigID.DataPropertyName = "DesigID";
            DesigID.Width = 0;
            DesigID.Visible = false;
            dgv.Columns.Add(DesigID);

            DataGridViewTextBoxColumn Designation = new DataGridViewTextBoxColumn();
            Designation.Name = "Designation";
            Designation.DataPropertyName = "Designation";
            Designation.Width = 210;
            Designation.ReadOnly = true;
            dgv.Columns.Add(Designation);

            DataGridViewTextBoxColumn DeptGrp = new DataGridViewTextBoxColumn();
            DeptGrp.Name = "DeptGrp";
            DeptGrp.DataPropertyName = "DeptGrp";
            DeptGrp.Width =0;
            DeptGrp.Visible = false;
            dgv.Columns.Add(DeptGrp);

            DataGridViewTextBoxColumn Dept = new DataGridViewTextBoxColumn();
            Dept.Name = "Dept";
            Dept.DataPropertyName = "Dept";
            Dept.Width = 0;
            Dept.Visible = false;
            dgv.Columns.Add(Dept);

            DataGridViewTextBoxColumn Unit = new DataGridViewTextBoxColumn();
            Unit.Name = "Unit";
            Unit.DataPropertyName = "Unit";
            Unit.Width = 0;
            Unit.Visible = false;
            dgv.Columns.Add(Unit);
        }
        private void FormatAssociatedGrid()
        {
            dgvAssociatedGrid.ColumnCount = 11;
            this.dgvAssociatedGrid.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAssociatedGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAssociatedGrid.Columns[0].Name = "Blank";
            dgvAssociatedGrid.Columns[0].Width = 0;
            dgvAssociatedGrid.Columns[0].Visible = false;
            dgvAssociatedGrid.Columns[1].Name = "ID";
            dgvAssociatedGrid.Columns[1].Width = 55;
            dgvAssociatedGrid.Columns[1].ReadOnly = true;
            dgvAssociatedGrid.Columns[2].Name = "Name";
            dgvAssociatedGrid.Columns[2].Width = 210;
            dgvAssociatedGrid.Columns[2].ReadOnly = true;
            dgvAssociatedGrid.Columns[3].Name = "DesigID";
            dgvAssociatedGrid.Columns[3].Width = 0;
            dgvAssociatedGrid.Columns[3].Visible = false;
            dgvAssociatedGrid.Columns[4].Name = "Designation";
            dgvAssociatedGrid.Columns[4].Width = 190;
            dgvAssociatedGrid.Columns[4].ReadOnly = true;
            dgvAssociatedGrid.Columns[5].Name = "ShiftID";
            dgvAssociatedGrid.Columns[5].Width = 0;
            dgvAssociatedGrid.Columns[5].Visible = false;
            dgvAssociatedGrid.Columns[6].Name = "Shift";
            dgvAssociatedGrid.Columns[6].Width = 110;
            dgvAssociatedGrid.Columns[6].ReadOnly = true ;
            dgvAssociatedGrid.Columns[7].Name = "DutyDate";
            dgvAssociatedGrid.Columns[7].Width = 105;
            dgvAssociatedGrid.Columns[7].ReadOnly = true;
            dgvAssociatedGrid.Columns[8].Name = "DeptGrp";
            dgvAssociatedGrid.Columns[8].Width = 0;
            dgvAssociatedGrid.Columns[8].Visible = false;
            dgvAssociatedGrid.Columns[9].Name = "Dept";
            dgvAssociatedGrid.Columns[9].Width = 0;
            dgvAssociatedGrid.Columns[9].Visible = false;
            dgvAssociatedGrid.Columns[10].Name = "Unit";
            dgvAssociatedGrid.Columns[10].Width = 0;
            dgvAssociatedGrid.Columns[10].Visible = false;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvAssociatedGrid.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.DefaultCellStyle.ForeColor = Color.Navy;
            btn.UseColumnTextForButtonValue = true;
            btn.Width = 60;
        }
        private void LoadListView(string Mode,string DeptGroup,string Department,string Unit)
        {
            try
            {
                dgvInitialGrid.Rows.Clear();
                int i = 0;
                oEmpMass = hmsSC.GetEmpInfoForRoster(Mode.ToString(), cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString()).ToList();
                if (oEmpMass.Count > 0)
                {
                    foreach (EmployeeMaster oEmp in oEmpMass)
                    {
                        dgvInitialGrid.Rows.Add(1);
                        dgvInitialGrid.Rows[i].Cells[1].Value = oEmp.EmpId;
                        dgvInitialGrid.Rows[i].Cells[2].Value = oEmp.Name;
                        dgvInitialGrid.Rows[i].Cells[3].Value = oEmp.Designation.DesignationId;
                        dgvInitialGrid.Rows[i].Cells[4].Value = oEmp.Designation.DesignationTitle;
                        dgvInitialGrid.Rows[i].Cells[5].Value = oEmp.Department.DepartmentGroup.DepartmentGroupID;
                        dgvInitialGrid.Rows[i].Cells[6].Value = oEmp.Department.DepartmentID;
                        dgvInitialGrid.Rows[i].Cells[7].Value = oEmp.DepartmentUnit.UnitId;
                        i = i + 1;
                    }
                    dgvInitialGrid.AllowUserToAddRows = false;
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }      
        }
        private void LoadRosterDuty(string Mode,string Year,string Month,string DeptGroup,string Department, string Unit,string StartDate,string EndDate)
        {
            try
            {
                dgvAssociatedGrid.Rows.Clear();
                int i = 0;
                oEmpMass = hmsSC.GetOneDayRoster(Mode.ToString(), cboYear.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), dtStartDate.Text.ToString(), dtEndDate.Text.ToString()).ToList();
                if (oEmpMass.Count > 0)
                {
                    foreach (EmployeeMaster oEmp in oEmpMass)
                    {
                        dgvAssociatedGrid.Rows.Add(1);
                        dgvAssociatedGrid.Rows[i].Cells[1].Value = oEmp.EmpId;
                        dgvAssociatedGrid.Rows[i].Cells[2].Value = oEmp.Name;
                        dgvAssociatedGrid.Rows[i].Cells[3].Value = oEmp.Designation.DesignationId;
                        dgvAssociatedGrid.Rows[i].Cells[4].Value = oEmp.Designation.DesignationTitle;
                        dgvAssociatedGrid.Rows[i].Cells[5].Value = oEmp.Shift.ShiftID;
                        dgvAssociatedGrid.Rows[i].Cells[6].Value = oEmp.Shift.ShiftTitle;
                        dgvAssociatedGrid.Rows[i].Cells[7].Value = oEmp.Shift.DutyDate;
                        dgvAssociatedGrid.Rows[i].Cells[8].Value = oEmp.Department.DepartmentGroup.DepartmentGroupID;
                        dgvAssociatedGrid.Rows[i].Cells[9].Value = oEmp.Department.DepartmentID ;
                        dgvAssociatedGrid.Rows[i].Cells[10].Value = oEmp.DepartmentUnit.UnitId;
                        i = i + 1;
                    }
                    dgvAssociatedGrid.AllowUserToAddRows = false;
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cboShift.SelectedValue.ToString()=="")
            {
                MessageBox.Show("Please Select a Shift", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboShift.Focus();
                return;
            }
            for (int i = 0; i < dgvInitialGrid.RowCount; i++)
            {
                if (Convert.ToBoolean(dgvInitialGrid.Rows[i].Cells[0].Value) == true)
                {
                    DateTime StartDate = dtStartDate.Value;
                    DateTime EndDate = dtEndDate.Value;
                    int intDay = StartDate.Day;
                    int intEndDay = EndDate.Day;

                    int daysDiff = ((TimeSpan)(EndDate - StartDate)).Days + 1;

                    for (int j = intDay; j <= intEndDay; j++)
                    {
                        if (dgvInitialGrid[0, i].Value != null)
                        {
                            mAdditem(dgvInitialGrid[1, i].Value.ToString(), dgvInitialGrid[2, i].Value.ToString(),
                                    StartDate.ToString("dd/MM/yyyy"), cboShift.SelectedValue.ToString(),
                                    dgvInitialGrid[3, i].Value.ToString(), dgvInitialGrid[4, i].Value.ToString(),
                                    dgvInitialGrid[5, i].Value.ToString(), dgvInitialGrid[6, i].Value.ToString(),
                                    dgvInitialGrid[7, i].Value.ToString());
                        }
                        dgvInitialGrid.Rows[i].Cells[0].Value = false;
                        StartDate =StartDate.AddDays(1);
                    }
                    dgvAssociatedGrid.AllowUserToAddRows = false;

                    }
                                
            }           
        }

        private void mAdditem(string EmpID, string EmpTitle,string DutyDate,string Shift,string DesignationID,string DesignationTitle,string DeptGrp,string Dept,string Unit)
        {
            int selRaw;
            string strDown = "";
            string strDate = "";
            string strShift = "";
            Boolean blngCheck = false;
            for (int j = 0; j < dgvAssociatedGrid.RowCount; j++)
            {
                if (dgvAssociatedGrid[1, j].Value != null)
                {
                    strDown = dgvAssociatedGrid[1, j].Value.ToString();
                    strDate = dgvAssociatedGrid[7, j].Value.ToString();
                    strShift = dgvAssociatedGrid[5, j].Value.ToString();
                }
                if (EmpID == strDown.ToString() && DutyDate == strDate.ToString() && Shift == strShift.ToString())
                {
                    blngCheck = true;
                }
            }
            if (blngCheck == false)
            {
                dgvAssociatedGrid.AllowUserToAddRows = true;
                selRaw = Convert.ToInt16(dgvAssociatedGrid.RowCount.ToString());
                selRaw = selRaw - 1;
                dgvAssociatedGrid.Rows.Add(1);
                for (int i = 1; i < dgvAssociatedGrid.Rows.Count; i++)
                {
                    dgvAssociatedGrid[1, selRaw].Value = EmpID.ToString();
                    dgvAssociatedGrid[2, selRaw].Value = EmpTitle.ToString();
                    dgvAssociatedGrid[3, selRaw].Value = DesignationID.ToString();
                    dgvAssociatedGrid[4, selRaw].Value = DesignationTitle.ToString();
                    dgvAssociatedGrid[5, selRaw].Value = cboShift.SelectedValue.ToString();
                    dgvAssociatedGrid[6, selRaw].Value = cboShift.Text.ToString();
                    dgvAssociatedGrid[7, selRaw].Value = DutyDate.ToString();
                    dgvAssociatedGrid[8, selRaw].Value = DeptGrp.ToString();
                    dgvAssociatedGrid[9, selRaw].Value = Dept.ToString();
                    dgvAssociatedGrid[10, selRaw].Value = Unit.ToString();
                }

            }
        }
        private void dgvAssociatedGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            try
            {
                if (dgvAssociatedGrid.Columns[e.ColumnIndex].Name == "btn")
                {
                    if (dgvAssociatedGrid.CurrentCell != null)
                    {
                        int selectedIndex = dgvAssociatedGrid.CurrentCell.RowIndex;
                        if (selectedIndex > -1)
                        {
                            DialogResult msg = MessageBox.Show("Do You want to Delete?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if (msg == DialogResult.Yes)
                            {
                                dgvAssociatedGrid.Rows.RemoveAt(selectedIndex);
                                dgvAssociatedGrid.Refresh(); // if needed
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

        private void txtSearchText_KeyUp(object sender, KeyEventArgs e)
        {
            PopulateDataToGrid(dgvInitialGrid, txtSearchText.Text);
            dgvInitialGrid.Refresh();      
        }
        private void PopulateDataToGrid(DataGridView dgv, string EmployeeName)
        {
            if (oEmpMass != null)
            {
                IEnumerable<EmployeeMaster> TestsListLocal;
                if (!(EmployeeName.Length > 0))
                {
                    TestsListLocal = oEmpMass;
                }
                else
                {
                    TestsListLocal = oEmpMass.Where(x => x.Name.ToLower().Contains(EmployeeName.ToLower()));
                }
                dgv.DataSource = TestsListLocal.Select(data => new
                {
                    ID = data.EmpId,
                    Name = data.Name,
                    DesigID=data.Designation.DesignationId,
                    Designation=data.Designation.DesignationTitle
                }).ToList();
            }
        }

        private EmployeeMaster PopulateRosterDuty()
        {
            string string1 = "";
            int i = 0;
            int l = 0;
            int m = 0;
            EmployeeMaster oEmployeeMaster = new EmployeeMaster();
            SalaryCycle oSalaryCycle = new SalaryCycle();
            oSalaryCycle.Month = cboMonth.SelectedValue.ToString();
            oSalaryCycle.Year = cboYear.SelectedValue.ToString();
            oEmployeeMaster.SalaryCycle = oSalaryCycle;
            Department oDept = new Department();
            DepartmentGroup oDeptGrp = new DepartmentGroup();
            oDeptGrp.DepartmentGroupID = cboDepartmentGroup.SelectedValue.ToString();
            oDept.DepartmentGroup = oDeptGrp;
            oDept.DepartmentID = cboDepartment.SelectedValue.ToString();
            oEmployeeMaster.Department = oDept;
            DepartmentUnit oDeptUnit = new DepartmentUnit();
            oDeptUnit.UnitId = cboUnit.SelectedValue.ToString();
            oEmployeeMaster.DepartmentUnit = oDeptUnit;
            Shift oShift = new Shift();
            oShift.StartDate = dtStartDate.Text.ToString();
            oShift.EndDate = dtEndDate.Text.ToString();
            if(rdoAll.Checked==true)
            {
                oShift.Mode = "A";
            }
            if (rdoDeptGrp.Checked == true)
            {
                oShift.Mode = "B";
            }
            if (rdoGrpDeptUnit.Checked == true)
            {
                oShift.Mode = "C";
            }
            oEmployeeMaster.Shift = oShift;

            int row = dgvAssociatedGrid.Rows.Count;
            double j = Math.Floor(Convert.ToDouble(row / 3));
            double k = row - Math.Floor(Convert.ToDouble(row / 3)) - Math.Floor(Convert.ToDouble(row / 3));
            for (i = 0; i < j; i++)
             {                
                     string1 += dgvAssociatedGrid.Rows[i].Cells[1].Value +
                                 ":" + dgvAssociatedGrid.Rows[i].Cells[3].Value +
                                 ":" + dgvAssociatedGrid.Rows[i].Cells[5].Value +
                                 ":" + dgvAssociatedGrid.Rows[i].Cells[7].Value +
                                 ":" + dgvAssociatedGrid.Rows[i].Cells[8].Value +
                                 ":" + dgvAssociatedGrid.Rows[i].Cells[9].Value +
                                 ":" + dgvAssociatedGrid.Rows[i].Cells[10].Value +
                                 ":" + ";";               
            }
            string1 = string1  + "~";
            double Ln1 = string1.Length;
            l = i;
            for (i = l; i < j+j; i++)
            {               
                    string1 += dgvAssociatedGrid.Rows[i].Cells[1].Value +
                                ":" + dgvAssociatedGrid.Rows[i].Cells[3].Value +
                                ":" + dgvAssociatedGrid.Rows[i].Cells[5].Value +
                                ":" + dgvAssociatedGrid.Rows[i].Cells[7].Value +
                                ":" + dgvAssociatedGrid.Rows[i].Cells[8].Value +
                                ":" + dgvAssociatedGrid.Rows[i].Cells[9].Value +
                                ":" + dgvAssociatedGrid.Rows[i].Cells[10].Value +
                                ":" + ";";
               
            }
            string1 = string1  + "~";
            double Ln2 = string1.Length;
            m = i;
            
                for (i = m; i < dgvAssociatedGrid.Rows.Count; i++)
                {
                    string1 += dgvAssociatedGrid.Rows[i].Cells[1].Value +
                                ":" + dgvAssociatedGrid.Rows[i].Cells[3].Value +
                                ":" + dgvAssociatedGrid.Rows[i].Cells[5].Value +
                                ":" + dgvAssociatedGrid.Rows[i].Cells[7].Value +
                                ":" + dgvAssociatedGrid.Rows[i].Cells[8].Value +
                                ":" + dgvAssociatedGrid.Rows[i].Cells[9].Value +
                                ":" + dgvAssociatedGrid.Rows[i].Cells[10].Value +
                                ":" + ";";

                }
                string1 = string1 + "~";
                double Ln3 = string1.Length;
          
            oEmployeeMaster.RosterString = string1;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oEmployeeMaster.EntryParameter = ep;

            return oEmployeeMaster;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboYear", "cboMonth", "cboDepartment", "cboUnit" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dgvAssociatedGrid.Rows.Count==0)
            {
                MessageBox.Show("No Duty Time is Prepared", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                EmployeeMaster oEmployeeMaster = this.PopulateRosterDuty();
                short i = hmsSC.SaveRosterDuty(oEmployeeMaster);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAssociatedGrid.Rows.Clear();
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

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(sender, e);
        }

        private void btnAddShiftTiming_Click(object sender, EventArgs e)
        {
            frmShiftTimingSetup oShift = new frmShiftTimingSetup();
            oShift.ShowDialog();
        }
        private void btnRefreshShiftTiming_Click(object sender, EventArgs e)
        {
            cboShift.DisplayMember = "Value";
            cboShift.ValueMember = "Key";
            cboShift.DataSource = new BindingSource(hmsSC.GetShiftDict("D"), null);     
        }
        private void btnAddRoster_Click(object sender, EventArgs e)
        {
            this.btnAdd_Click(sender, e);
        }

        private void chkList_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int rcont = 0; rcont < dgvInitialGrid.Rows.Count; rcont++)
                {
                    if (chkList.Checked == true)
                    {
                        Convert.ToBoolean(dgvInitialGrid.Rows[rcont].Cells["chk"].Value = true);
                    }
                    else
                    {
                        Convert.ToBoolean(dgvInitialGrid.Rows[rcont].Cells["chk"].Value = false);
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

        //private void dtDutyDate_Leave(object sender, EventArgs e)
        //{
        //    //if(CheckHoliday(dtStartDate.Text.ToString())==true)
        //    //{
        //    //    MessageBox.Show("This day is a public holiday", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //    return;
        //    //}
        //    this.btnShow_Click(sender, e);
        //}
        //private Boolean CheckHoliday(string Holiday)
        //{
        //    List<HolidayCalenderRO> oHols = hmsSC.GetHolidayCalenderForReport(cboYear.SelectedValue.ToString()).ToList();
        //    foreach (HolidayCalenderRO oHol in oHols)
        //    {
        //        if(oHol.HolidayDate==Holiday)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}   

    }
}
