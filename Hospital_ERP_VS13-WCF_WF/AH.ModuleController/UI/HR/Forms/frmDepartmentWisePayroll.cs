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
    public partial class frmDepartmentWisePayroll : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmDepartmentWisePayroll()
        {
            InitializeComponent();
        }

        private void frmDepartmentWisePayroll_Load(object sender, EventArgs e)
        {
            FormatGrid();
            cboYear.DisplayMember = "Value";
            cboYear.ValueMember = "Key";
            cboYear.DataSource = new BindingSource(Utility.GetNumbers(2015, 2025), null);

            cboYear.Text = DateTime.Now.ToString("yyyy");
            rdoDeptGrp.Checked = true;

            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);
                 
        }

        private void FormatGrid()
        {
            dgvInfo.ColumnCount = 27;
            this.dgvInfo.DefaultCellStyle.Font = new Font("Tahoma", 8);
            dgvInfo.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8);
            dgvInfo.Columns[0].Name = "ID";
            dgvInfo.Columns[0].ReadOnly = true;
            dgvInfo.Columns[0].Width = 45;
            dgvInfo.Columns[1].Name = "Name";
            dgvInfo.Columns[1].ReadOnly = true;
            dgvInfo.Columns[1].Width = 190;
            dgvInfo.Columns[2].Name = "Designation";
            dgvInfo.Columns[2].ReadOnly = true;
            dgvInfo.Columns[2].Width = 180;
            dgvInfo.Columns[3].Name = "Department";
            dgvInfo.Columns[3].ReadOnly = true;
            dgvInfo.Columns[3].Width = 210;
            dgvInfo.Columns[4].Name = "Basic";
            dgvInfo.Columns[4].ReadOnly = true;
            dgvInfo.Columns[4].Width = 80;
            dgvInfo.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvInfo.Columns[5].Name = "HRA";
            dgvInfo.Columns[5].ReadOnly = true;
            dgvInfo.Columns[5].Width = 80;
            dgvInfo.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvInfo.Columns[6].Name = "MA";
            dgvInfo.Columns[6].ReadOnly = true;
            dgvInfo.Columns[6].Width = 60;
            dgvInfo.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvInfo.Columns[7].Name = "TA";
            dgvInfo.Columns[7].ReadOnly = true;
            dgvInfo.Columns[7].Width = 80;
            dgvInfo.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;                      
            dgvInfo.Columns[8].Name = "OT";
            dgvInfo.Columns[8].ReadOnly = true;
            dgvInfo.Columns[8].Width = 60;
            dgvInfo.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvInfo.Columns[9].Name = "Arear";
            dgvInfo.Columns[9].ReadOnly = true;
            dgvInfo.Columns[9].Width = 80;
            dgvInfo.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvInfo.Columns[10].Name = "Others";
            dgvInfo.Columns[10].ReadOnly = true;
            dgvInfo.Columns[10].Width = 80;
            dgvInfo.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvInfo.Columns[11].Name = "IncomeTax";
            dgvInfo.Columns[11].ReadOnly = true;
            dgvInfo.Columns[11].Width = 80;
            dgvInfo.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;           
            dgvInfo.Columns[12].Name = "Food Amount";
            dgvInfo.Columns[12].ReadOnly = true;
            dgvInfo.Columns[12].Width = 60;
            dgvInfo.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvInfo.Columns[13].Name = "PF";
            dgvInfo.Columns[13].ReadOnly = true;
            dgvInfo.Columns[13].Width = 50;            
            dgvInfo.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvInfo.Columns[14].Name = "Advance";
            dgvInfo.Columns[14].ReadOnly = true;
            dgvInfo.Columns[14].Width = 60;
            dgvInfo.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvInfo.Columns[15].Name = "Loan";
            dgvInfo.Columns[15].ReadOnly = true;
            dgvInfo.Columns[15].Width = 60;
            dgvInfo.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvInfo.Columns[16].Name = "Absent";
            dgvInfo.Columns[16].ReadOnly = true;
            dgvInfo.Columns[16].Width = 60;          
            dgvInfo.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvInfo.Columns[17].Name = "LWP";
            dgvInfo.Columns[17].ReadOnly = true;
            dgvInfo.Columns[17].Width =60;
            dgvInfo.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvInfo.Columns[18].Name = "Extra Mobile Bill";
            dgvInfo.Columns[18].ReadOnly = true;
            dgvInfo.Columns[18].Width = 60;
            dgvInfo.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvInfo.Columns[19].Name = "Others";
            dgvInfo.Columns[19].ReadOnly = true;
            dgvInfo.Columns[19].Width = 60;
            dgvInfo.Columns[20].Name = "Total Addition";
            dgvInfo.Columns[20].ReadOnly = true;
            dgvInfo.Columns[20].Width = 100;
            dgvInfo.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvInfo.Columns[21].Name = "Total Deduction";
            dgvInfo.Columns[21].ReadOnly = true;
            dgvInfo.Columns[21].Width = 100;
            dgvInfo.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvInfo.Columns[22].Name = "Gross";
            dgvInfo.Columns[22].ReadOnly = true;
            dgvInfo.Columns[22].Width = 100;
            dgvInfo.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvInfo.Columns[23].Name = "DeptType";
            dgvInfo.Columns[23].Visible = false;
            dgvInfo.Columns[23].Width = 0;
            dgvInfo.Columns[24].Name = "DeptGrp";
            dgvInfo.Columns[24].Visible = false;
            dgvInfo.Columns[24].Width = 0;
            dgvInfo.Columns[25].Name = "Dept";
            dgvInfo.Columns[25].Visible = false;
            dgvInfo.Columns[25].Width = 0;
            dgvInfo.Columns[26].Name = "Unit";
            dgvInfo.Columns[26].Visible = false;
            dgvInfo.Columns[26].Width = 0;
           
        }

        private void LoadGridView(string Mode,string DeptGrp,string Dept,string Unit,string Month)
        {
            dgvInfo.Rows.Clear();
            int i = 0;           
            List<PayrollRO> oPays = new List<PayrollRO>();
            oPays = hmsSC.ShowPayrollDetails(Mode.ToString(),cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), cboMonth.SelectedValue.ToString()).ToList();
            if (oPays.Count > 0)
            {
                foreach (PayrollRO oPay in oPays)
                {
                    dgvInfo.Rows.Add(1);
                    dgvInfo.Rows[i].Cells[0].Value = oPay.EmpId;
                    dgvInfo.Rows[i].Cells[1].Value = oPay.EmpName;
                    dgvInfo.Rows[i].Cells[2].Value = oPay.DesigId;
                    dgvInfo.Rows[i].Cells[3].Value = oPay.FormatDept;
                    dgvInfo.Rows[i].Cells[4].Value = oPay.Basic;
                    dgvInfo.Rows[i].Cells[5].Value = oPay.HouseRent;
                    dgvInfo.Rows[i].Cells[6].Value = oPay.MedicalAllowance;
                    dgvInfo.Rows[i].Cells[7].Value = oPay.Transport;
                    dgvInfo.Rows[i].Cells[8].Value = oPay.Overtime;
                    dgvInfo.Rows[i].Cells[9].Value = oPay.Arear;
                    dgvInfo.Rows[i].Cells[10].Value = oPay.Others;   
                    dgvInfo.Rows[i].Cells[11].Value = oPay.IncomeTax;
                    dgvInfo.Rows[i].Cells[12].Value = oPay.Lunch;
                    dgvInfo.Rows[i].Cells[13].Value = oPay.ProvidentFund;                    
                    dgvInfo.Rows[i].Cells[14].Value = oPay.Advance;
                    dgvInfo.Rows[i].Cells[15].Value = oPay.Loan;
                    dgvInfo.Rows[i].Cells[16].Value = oPay.Absent;
                    dgvInfo.Rows[i].Cells[17].Value = oPay.LeaveWithoutPay;
                    dgvInfo.Rows[i].Cells[18].Value = oPay.MobileBillDeduce;
                    dgvInfo.Rows[i].Cells[19].Value = oPay.OthersDed;
                    dgvInfo.Rows[i].Cells[20].Value = oPay.Addition;
                    dgvInfo.Rows[i].Cells[21].Value = oPay.Deduction;
                    dgvInfo.Rows[i].Cells[22].Value = oPay.GrossPay;
                    dgvInfo.Rows[i].Cells[23].Value = oPay.DeptType;
                    dgvInfo.Rows[i].Cells[24].Value = oPay.DeptGrp;
                    dgvInfo.Rows[i].Cells[25].Value = oPay.DeptId;
                    dgvInfo.Rows[i].Cells[26].Value = oPay.UnitId;
                    
                    i = i + 1;
                }
            }         
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDepartmentType", "cboDepartmentGroup", "cboDepartment", "cboUnit", "cboYear", "cboMonth"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (rdoAll.Checked == true)
            {
                LoadGridView("A",cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), cboMonth.SelectedValue.ToString());
            }
            if (rdoDeptGrp.Checked == true)
            {
                LoadGridView("B",cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), cboMonth.SelectedValue.ToString());
            }
            if (rdoGrpDeptUnit.Checked == true)
            {
                LoadGridView("C",cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), cboMonth.SelectedValue.ToString());
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.DepartmentWisePayroll;
            vr.strParam = cboMonth.SelectedValue.ToString();
            vr.strParam1 = cboDepartment.SelectedValue.ToString();
            vr.ViewReport();
        }      
        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvInfo.Rows.Clear();
        }
        private void dgvInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string ColumnName = dgvInfo.Columns[0].HeaderCell.Value.ToString();
                string ID = dgvInfo.Rows[e.RowIndex].Cells[0].Value.ToString();

                frmPayrollUpdate oPay = new frmPayrollUpdate();
                for (int i = 0; i < dgvInfo.Rows.Count; i++)
                {
                    oPay.EmpId = dgvInfo.Rows[i].Cells[0].Value.ToString();
                    if (oPay.EmpId == ID)
                    {
                        oPay.EmpId = ID;
                        oPay.DeptType = dgvInfo.Rows[i].Cells[23].Value.ToString();
                        oPay.DeptGrp = dgvInfo.Rows[i].Cells[24].Value.ToString();
                        oPay.Dept = dgvInfo.Rows[i].Cells[25].Value.ToString();
                        oPay.Unit = dgvInfo.Rows[i].Cells[26].Value.ToString();
                        oPay.Month = cboMonth.SelectedValue.ToString();
                        oPay.Gross = dgvInfo.Rows[i].Cells[22].Value.ToString();
                        oPay.ShowDialog();
                    }
                }
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonth.DisplayMember = "Value";
            cboMonth.ValueMember = "Key";
            cboMonth.DataSource = new BindingSource(hmsSC.GetMonth(cboYear.SelectedValue.ToString()), null);

            cboMonth.Text = DateTime.Now.ToString("MMM-yyyy");
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
        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(sender, e);
        }

       
    }
}
