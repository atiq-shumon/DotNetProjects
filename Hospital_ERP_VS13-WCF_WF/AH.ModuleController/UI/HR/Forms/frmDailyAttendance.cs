using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.HRSR;
using AH.DUtility;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmDailyAttendance : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmDailyAttendance()
        {
            InitializeComponent();
        }

        private void frmDailyAttendance_Load(object sender, EventArgs e)
        {
            FormatGrid();

            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);
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

        private void FormatGrid()
        {
            dgvAttendence.ColumnCount = 15;
            this.dgvAttendence.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAttendence.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12);

            dgvAttendence.Columns[0].Name = "Emp Id";
            dgvAttendence.Columns[0].ReadOnly = true;
            dgvAttendence.Columns[0].Width = 70;

            dgvAttendence.Columns[1].Name = "Name";
            dgvAttendence.Columns[1].ReadOnly = true;
            dgvAttendence.Columns[1].Width = 205;

            dgvAttendence.Columns[2].Name = "DeptGrpID";
            dgvAttendence.Columns[2].Visible = false;
            dgvAttendence.Columns[2].Width = 0;

            dgvAttendence.Columns[3].Name = "Dept Grp";
            dgvAttendence.Columns[3].ReadOnly = true;
            dgvAttendence.Columns[3].Width = 180;

            dgvAttendence.Columns[4].Name = "DeptID";
            dgvAttendence.Columns[4].Visible = false;
            dgvAttendence.Columns[4].Width = 0;

            dgvAttendence.Columns[5].Name = "Department";
            dgvAttendence.Columns[5].ReadOnly = true;
            dgvAttendence.Columns[5].Width = 150;

            dgvAttendence.Columns[6].Name = "UnitID";
            dgvAttendence.Columns[6].Visible = false;
            dgvAttendence.Columns[6].Width = 0;

            dgvAttendence.Columns[7].Name = "Unit";
            dgvAttendence.Columns[7].ReadOnly = true;
            dgvAttendence.Columns[7].Width = 150;

            dgvAttendence.Columns[8].Name = "DesigID";
            dgvAttendence.Columns[8].Visible = false;
            dgvAttendence.Columns[8].Width = 0;

            dgvAttendence.Columns[9].Name = "Designation";
            dgvAttendence.Columns[9].ReadOnly = true;
            dgvAttendence.Columns[9].Width = 200;

            dgvAttendence.Columns[10].Name = "Date";
            dgvAttendence.Columns[10].Visible = false;
            dgvAttendence.Columns[10].Width = 0;

            dgvAttendence.Columns[11].Name = "Day";
            dgvAttendence.Columns[11].Visible = false;
            dgvAttendence.Columns[11].Width = 0;

            dgvAttendence.Columns[12].Name = "In Time";
            dgvAttendence.Columns[12].ReadOnly = true;
            dgvAttendence.Columns[12].Width = 85;
            dgvAttendence.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

            dgvAttendence.Columns[13].Name = "Out Time";
            dgvAttendence.Columns[13].ReadOnly = true;
            dgvAttendence.Columns[13].Width = 85;
            dgvAttendence.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

            dgvAttendence.Columns[14].Name = "Status";
            dgvAttendence.Columns[14].ReadOnly = true;
            dgvAttendence.Columns[14].Width = 70;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvAttendence.Columns.Add(btn);
            btn.HeaderText = "Show";
            btn.Text = "Show History";
            btn.Name = "btn";
            btn.DefaultCellStyle.ForeColor = Color.Navy;
            btn.UseColumnTextForButtonValue = true;
            btn.Width = 80;
      
        }
        private void LoadAttendance(string Mode,string DeptGrp,string Date)
        {
            dgvAttendence.Rows.Clear();
            int i = 0;
            List<Attendence> oAttendences = new List<Attendence>();
            oAttendences = hmsSC.GetDailyAttndence("A", cboDepartmentGroup.SelectedValue.ToString(), "", "", dtStartDate.Text.ToString(), dtEnddate.Text.ToString()).ToList();
            if (oAttendences.Count > 0)
            {
                foreach (Attendence oAttendence in oAttendences)
                {
                    dgvAttendence.Rows.Add(1);
                    dgvAttendence.Rows[i].Cells[0].Value = oAttendence.EmpId;
                    dgvAttendence.Rows[i].Cells[1].Value = oAttendence.Name;
                    dgvAttendence.Rows[i].Cells[2].Value = oAttendence.DeptGrp;
                    dgvAttendence.Rows[i].Cells[3].Value = oAttendence.DeptGrpTitle;
                    dgvAttendence.Rows[i].Cells[4].Value = oAttendence.DeptId;
                    dgvAttendence.Rows[i].Cells[5].Value = oAttendence.DeptTitle;
                    dgvAttendence.Rows[i].Cells[6].Value = oAttendence.UnitId;
                    dgvAttendence.Rows[i].Cells[7].Value = oAttendence.UnitTitle;
                    dgvAttendence.Rows[i].Cells[8].Value = oAttendence.DesigId;
                    dgvAttendence.Rows[i].Cells[9].Value = oAttendence.DesigTitle;
                    dgvAttendence.Rows[i].Cells[10].Value = oAttendence.AttendenceDate.ToString();
                    dgvAttendence.Rows[i].Cells[11].Value = oAttendence.Day;
                    if (oAttendence.InTime.ToString() != "")
                    {
                        dgvAttendence.Rows[i].Cells[12].Value = Convert.ToDateTime(oAttendence.InTime.ToString()).ToString("hh:mm tt");
                    }
                    else
                        dgvAttendence.Rows[i].Cells[12].Value = "";
                    if (oAttendence.OutTime.ToString() != "")
                    {
                        dgvAttendence.Rows[i].Cells[13].Value = Convert.ToDateTime(oAttendence.OutTime.ToString()).ToString("hh:mm tt");
                    }
                    else
                        dgvAttendence.Rows[i].Cells[13].Value = "";
                    dgvAttendence.Rows[i].Cells[14].Value = oAttendence.Status;
                    i = i + 1;
                }
            }
            dgvAttendence.CurrentCell = null;
            dgvAttendence.ClearSelection();
        }

        private void LoadAttendanceDeptUnit(string Mode, string DeptGrp,string Dept,string Unit,string Date)
        {
            dgvAttendence.Rows.Clear();
            int i = 0;
            List<Attendence> oAttendences = new List<Attendence>();
            oAttendences = hmsSC.GetDailyAttndence("B", cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), dtStartDate.Text.ToString(), dtEnddate.Text.ToString()).ToList();
            if (oAttendences.Count > 0)
            {
                foreach (Attendence oAttendence in oAttendences)
                {
                    dgvAttendence.Rows.Add(1);
                    dgvAttendence.Rows[i].Cells[0].Value = oAttendence.EmpId;
                    dgvAttendence.Rows[i].Cells[1].Value = oAttendence.Name;
                    dgvAttendence.Rows[i].Cells[2].Value = oAttendence.DeptGrp;
                    dgvAttendence.Rows[i].Cells[3].Value = oAttendence.DeptGrpTitle;
                    dgvAttendence.Rows[i].Cells[4].Value = oAttendence.DeptId;
                    dgvAttendence.Rows[i].Cells[5].Value = oAttendence.DeptTitle;
                    dgvAttendence.Rows[i].Cells[6].Value = oAttendence.UnitId;
                    dgvAttendence.Rows[i].Cells[7].Value = oAttendence.UnitTitle;
                    dgvAttendence.Rows[i].Cells[8].Value = oAttendence.DesigId;
                    dgvAttendence.Rows[i].Cells[9].Value = oAttendence.DesigTitle;
                    dgvAttendence.Rows[i].Cells[10].Value = oAttendence.AttendenceDate.ToString();
                    dgvAttendence.Rows[i].Cells[11].Value = oAttendence.Day;
                    if (oAttendence.InTime.ToString() != "")
                    {
                        dgvAttendence.Rows[i].Cells[12].Value = Convert.ToDateTime(oAttendence.InTime.ToString()).ToString("hh:mm tt");
                    }
                    else
                        dgvAttendence.Rows[i].Cells[12].Value = "";

                    if (oAttendence.OutTime.ToString() != "")
                    {
                        dgvAttendence.Rows[i].Cells[13].Value = Convert.ToDateTime(oAttendence.OutTime.ToString()).ToString("hh:mm tt");
                    }
                    else
                        dgvAttendence.Rows[i].Cells[13].Value = "";
                    dgvAttendence.Rows[i].Cells[14].Value = oAttendence.Status;
                    i = i + 1;
                }
            }
            dgvAttendence.CurrentCell = null;
            dgvAttendence.ClearSelection();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadAttendance("A", cboDepartmentGroup.SelectedValue.ToString(),dtStartDate.Text.ToString());
        }
        private void btnNewShow_Click(object sender, EventArgs e)
        {
            LoadAttendanceDeptUnit("B", cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), dtStartDate.Text.ToString());
        }

        private void dgvAttendence_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAttendence.Columns[e.ColumnIndex].Name == "btn")
            {
                if (dgvAttendence.CurrentCell != null)
                {
                    int selectedIndex = dgvAttendence.CurrentCell.RowIndex;
                    if (selectedIndex > -1)
                    {
                        frmMonthlyAttendance oEmployee = new frmMonthlyAttendance();
                        oEmployee.EmpID = dgvAttendence.Rows[e.RowIndex].Cells[0].Value.ToString();
                        oEmployee.EmpName = dgvAttendence.Rows[e.RowIndex].Cells[1].Value.ToString();
                        oEmployee.Designation = dgvAttendence.Rows[e.RowIndex].Cells[9].Value.ToString();
                        oEmployee.DeptGroup = dgvAttendence.Rows[e.RowIndex].Cells[3].Value.ToString();
                        oEmployee.Department = dgvAttendence.Rows[e.RowIndex].Cells[5].Value.ToString();
                        oEmployee.Unit = dgvAttendence.Rows[e.RowIndex].Cells[7].Value.ToString();
                        oEmployee.ShowDialog();
                    }
                }
            }  
        }

    }
}
