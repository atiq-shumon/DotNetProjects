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
using System.Drawing.Imaging;
using AH.ModuleController.UI.HR.Reports.Viewer;


namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmEmployeeInfo : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmEmployeeInfo()
        {
            InitializeComponent();
        }

        private void frmEmployeeInfo_Load(object sender, EventArgs e)
        {
            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(hmsSC.GetDeptDictionary("D"), null);

            FormatGrid();
            rdoName.Checked = true;
        }

        private void rdoName_Click(object sender, EventArgs e)
        {
            lblName.Enabled = true;
            txtName.Enabled = true;
            txtName.Focus();
            lblDept.Enabled = false;
            cboDepartment.Enabled = false;
        }
        private void rdeoDepartment_Click(object sender, EventArgs e)
        {
            lblName.Enabled = false;
            txtName.Enabled = false;
            lblDept.Enabled = true;
            cboDepartment.Enabled = true;
        }
        private void FormatGrid()
        {
            dgvInfo.ColumnCount = 14;
            dgvInfo.Columns[0].Name = "Emp Id";
            dgvInfo.Columns[0].Width = 60;
            dgvInfo.Columns[0].ReadOnly = true;
            dgvInfo.Columns[1].Name = "Name";
            dgvInfo.Columns[1].Width = 200;
            dgvInfo.Columns[1].ReadOnly = true;
            dgvInfo.Columns[2].Name = "Department";
            dgvInfo.Columns[2].Width = 100;
            dgvInfo.Columns[2].ReadOnly = true;
            dgvInfo.Columns[3].Name = "designation";
            dgvInfo.Columns[3].Width = 110;
            dgvInfo.Columns[3].ReadOnly = true;
            dgvInfo.Columns[4].Name = "Religion";
            dgvInfo.Columns[4].Width = 50;
            dgvInfo.Columns[4].ReadOnly = true;
            dgvInfo.Columns[5].Name = "Gender";
            dgvInfo.Columns[5].Width = 50;
            dgvInfo.Columns[5].ReadOnly = true;
            dgvInfo.Columns[6].Name = "B.Grp";
            dgvInfo.Columns[6].Width = 50;
            dgvInfo.Columns[6].ReadOnly = true;
            dgvInfo.Columns[7].Name = "Maritial Status";
            dgvInfo.Columns[7].Width = 80;
            dgvInfo.Columns[7].ReadOnly = true;
            dgvInfo.Columns[8].Name = "Nationality";
            dgvInfo.Columns[8].Width = 80;
            dgvInfo.Columns[8].ReadOnly = true;
            dgvInfo.Columns[9].Name = "Job Type";
            dgvInfo.Columns[9].Width = 80;
            dgvInfo.Columns[9].ReadOnly = true;
            dgvInfo.Columns[10].Name = "Email";
            dgvInfo.Columns[10].Width = 100;
            dgvInfo.Columns[10].ReadOnly = true;
            dgvInfo.Columns[11].Name = "Phone No";
            dgvInfo.Columns[11].Width = 80;
            dgvInfo.Columns[11].ReadOnly = true;
            dgvInfo.Columns[12].Name = "DOB";
            dgvInfo.Columns[12].Width = 70;
            dgvInfo.Columns[12].ReadOnly = true;
            dgvInfo.Columns[13].Name = "DOJ";
            dgvInfo.Columns[13].Width = 70;
            dgvInfo.Columns[13].ReadOnly = true;
        }
        private void LoadGridView(string mode, string dept)
        {
            dgvInfo.Rows.Clear();
            int i = 0;
            List<EmployeeMasterRO> oEmps = new List<EmployeeMasterRO>();
            if (rdoName.Checked == true)
            {
                oEmps = hmsSC.GetEmployeeInfo("NAME", txtName.Text.ToString()).ToList();
            }
            if (rdeoDepartment.Checked == true)
            {
                oEmps = hmsSC.GetEmployeeInfo("DEPT", cboDepartment.SelectedValue.ToString()).ToList();
            }
            if (oEmps.Count > 0)
            {
                foreach (EmployeeMasterRO oEmp in oEmps)
                {
                    dgvInfo.Rows.Add(1);
                    dgvInfo.Rows[i].Cells[0].Value = oEmp.EmpId;
                    dgvInfo.Rows[i].Cells[1].Value = oEmp.EmpName;
                    dgvInfo.Rows[i].Cells[2].Value = oEmp.DeptId;
                    dgvInfo.Rows[i].Cells[3].Value = oEmp.DesigId;
                    dgvInfo.Rows[i].Cells[4].Value = oEmp.Religion;
                    dgvInfo.Rows[i].Cells[5].Value = oEmp.Sex;
                    dgvInfo.Rows[i].Cells[6].Value = oEmp.BloodGroup;
                    dgvInfo.Rows[i].Cells[7].Value = oEmp.MaritialStatus;
                    dgvInfo.Rows[i].Cells[8].Value = oEmp.Nationality;
                    dgvInfo.Rows[i].Cells[9].Value = oEmp.JobType;
                    dgvInfo.Rows[i].Cells[10].Value = oEmp.Email;
                    dgvInfo.Rows[i].Cells[11].Value = oEmp.CellPhone;
                    dgvInfo.Rows[i].Cells[12].Value = oEmp.DOB.ToString("dd/MM/yyyy");
                    dgvInfo.Rows[i].Cells[13].Value = oEmp.DOJ.ToString("dd/MM/yyyy");                  
                    i = i + 1;
                }
            }
            else
            {
                MessageBox.Show("NO Record Found!!!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdoName.Checked == true) 
            {
                LoadGridView("NAME", txtName.Text.ToString());
            }
            if (rdeoDepartment.Checked == true)
            {
                LoadGridView("DEPT", cboDepartment.SelectedValue.ToString());
            }
        }
        private void dgvInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string ColumnName = dgvInfo.Columns[0].HeaderCell.Value.ToString();
                string ID = dgvInfo.Rows[e.RowIndex].Cells[0].Value.ToString();

                frmEmployeeMaster oPay = new frmEmployeeMaster();
                for (int i = 0; i < dgvInfo.Rows.Count; i++)
                {
                    oPay.EmpId = dgvInfo.Rows[i].Cells[0].Value.ToString();
                    if (oPay.EmpId == ID)
                    {
                        oPay.EmpId = ID;
                        oPay.ShowDialog();
                    }
                }
            }
        }

    }
}
