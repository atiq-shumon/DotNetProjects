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
    public partial class frmMonthlyAttendance : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string EmpID { set; get; }
        public string EmpName { set; get; }
        public string Designation { set; get; }
        public string DeptGroup { set; get; }
        public string Department { set; get; }
        public string Unit { set; get; }
        DateTime date = DateTime.Now;
        public frmMonthlyAttendance()
        {
            InitializeComponent();
        }
        private void frmMonthlyAttendance_Load(object sender, EventArgs e)
        {
            FormatGrid();

            if(EmpID !=null)
            {
                txtEmpID.Text = EmpID;
                txtEmpName.Text = EmpName;
                txtDesignation.Text = Designation;
                txtDeptGrp.Text = DeptGroup;
                txtDepartment.Text = Department;
                txtUnit.Text = Unit;
            }
            
        var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
        var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
        dtStartDate.Text = firstDayOfMonth.ToString("dd/MM/yyyy");
        dtEndDate.Text = lastDayOfMonth.ToString("dd/MM/yyyy");

        this.btnShow_Click(sender, e);
        }
        private void FormatGrid()
        {
            dgvAttendence.ColumnCount = 5;
            this.dgvAttendence.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAttendence.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12);

            dgvAttendence.Columns[0].Name = "Date";
            dgvAttendence.Columns[0].ReadOnly = true;
            dgvAttendence.Columns[0].Width = 150;

            dgvAttendence.Columns[1].Name = "Day";
            dgvAttendence.Columns[1].ReadOnly = true;
            dgvAttendence.Columns[1].Width = 100;

            dgvAttendence.Columns[2].Name = "In Time";
            dgvAttendence.Columns[2].ReadOnly = true;
            dgvAttendence.Columns[2].Width = 100;
            dgvAttendence.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

            dgvAttendence.Columns[3].Name = "Out Time";
            dgvAttendence.Columns[3].ReadOnly = true;
            dgvAttendence.Columns[3].Width = 100;
            dgvAttendence.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

            dgvAttendence.Columns[4].Name = "Status";
            dgvAttendence.Columns[4].ReadOnly = true;
            dgvAttendence.Columns[4].Width = 100;     

        }

        private void LoadAttendance(string EmpID, string StartDate, string EndDate)
        {
            dgvAttendence.Rows.Clear();
            int i = 0;
            List<Attendence> oAttendences = new List<Attendence>();
            oAttendences = hmsSC.GetMonthlyAttndence(txtEmpID.Text.ToString(), dtStartDate.Text.ToString(), dtEndDate.Text.ToString()).ToList();
            if (oAttendences.Count > 0)
            {
                foreach (Attendence oAttendence in oAttendences)
                {
                    dgvAttendence.Rows.Add(1);
                    dgvAttendence.Rows[i].Cells[0].Value = oAttendence.AttendenceDate.ToString();
                    dgvAttendence.Rows[i].Cells[1].Value = oAttendence.Day.ToString();
                    if (oAttendence.InTime.ToString() != "")
                    {
                        dgvAttendence.Rows[i].Cells[2].Value = Convert.ToDateTime(oAttendence.InTime.ToString()).ToString("hh:mm tt");
                    }
                    else
                        dgvAttendence.Rows[i].Cells[2].Value = "";
                    if (oAttendence.OutTime.ToString() != "")
                    {
                        dgvAttendence.Rows[i].Cells[3].Value = Convert.ToDateTime(oAttendence.OutTime.ToString()).ToString("hh:mm tt");
                    }
                    dgvAttendence.Rows[i].Cells[4].Value = oAttendence.Status;
                    i = i + 1;
                }
            }
            dgvAttendence.CurrentCell = null;
            dgvAttendence.ClearSelection();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(txtEmpID.Text !="")
            {
                LoadAttendance(txtEmpID.Text.ToString(), dtStartDate.Text.ToString(), dtEndDate.Text.ToString());
                dgvAttendence.CurrentCell = null;
                dgvAttendence.ClearSelection();
            }
        }


    }
}
