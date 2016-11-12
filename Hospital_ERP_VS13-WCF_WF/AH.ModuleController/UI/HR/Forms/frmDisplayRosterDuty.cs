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
using System.Globalization;
namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmDisplayRosterDuty : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        private List<EmployeeMaster> oEmpMass;
        private List<EmployeeMaster> oEmpMasters;
        private int i = 0;
        public frmDisplayRosterDuty()
        {
            InitializeComponent();
        }
        private void frmDisplayRosterDuty_Load(object sender, EventArgs e)
        {
            rdoDeptGrp.Checked = true;

            cboYear.DisplayMember = "Value";
            cboYear.ValueMember = "Key";
            cboYear.DataSource = new BindingSource(Utility.GetNumbers(2015, 2025), null);
            cboYear.Text = DateTime.Now.ToString("yyyy");

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

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonth.DisplayMember = "Value";
            cboMonth.ValueMember = "Key";
            cboMonth.DataSource = new BindingSource(hmsSC.GetMonth(cboYear.SelectedValue.ToString()), null);

            cboMonth.Text = DateTime.Now.ToString("MMM-yyyy");                      
        }
        private DataGridViewTextBoxColumn FormatColumns(string pname, string htext, int cwidth, Boolean true_false, string font, int fontsize, DataGridViewContentAlignment Algin)
        {
            DataGridViewTextBoxColumn DutyDatecolumn = new DataGridViewTextBoxColumn();
            DutyDatecolumn.DataPropertyName = pname;
            DutyDatecolumn.HeaderText = htext;
            DutyDatecolumn.DefaultCellStyle.ForeColor = Color.Black;
            DutyDatecolumn.DefaultCellStyle.BackColor = Color.White;
            DutyDatecolumn.Visible = true_false;
            DutyDatecolumn.DefaultCellStyle.Alignment = Algin;
            DutyDatecolumn.Width = cwidth;
            DutyDatecolumn.ReadOnly = true;
            DutyDatecolumn.DefaultCellStyle.Font = new Font(font, fontsize, FontStyle.Regular);
            DutyDatecolumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            return DutyDatecolumn;
        }

        private Boolean mAdditem(string TestDetID)
        {
            string strDown = "";
            for (int j = 0; j < dgvRosterDuty.RowCount; j++)
            {
                if (dgvRosterDuty[0, j].Value != null)
                {
                    strDown = dgvRosterDuty[0, j].Value.ToString();
                    
                }
                if (TestDetID == strDown.ToString())
                {
                    return true;
                   
                }
            }
            return false;
        }

        private void GetGridvalue( string strCardNo, int Row)
        {           
            if (rdoAll.Checked == true)
            {
                oEmpMasters = hmsSC.GetRosterDutyDate("A",cboYear.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), strCardNo.ToString()).ToList();
            }
            if (rdoDeptGrp.Checked == true)
            {
                oEmpMasters = hmsSC.GetRosterDutyDate("B",cboYear.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), strCardNo.ToString()).ToList();
            }
            if (rdoGrpDeptUnit.Checked == true)
            {
                oEmpMasters = hmsSC.GetRosterDutyDate("C",cboYear.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), strCardNo.ToString()).ToList();
            }
          
           foreach (EmployeeMaster oEmpMas in oEmpMasters)
            {
                DateTime DutyDate = Convert.ToDateTime(oEmpMas.Shift.DutyDate.ToString());
                string strDutyDate = DutyDate.Day.ToString("00");
                for (int Col = 3; Col < dgvRosterDuty.Columns.Count; Col++)
                {
                    string strCol = dgvRosterDuty.Columns[Col].HeaderCell.Value.ToString();
                    if (strCol == strDutyDate)
                    {                       
                        dgvRosterDuty.Rows[i].Cells[Col].Value = oEmpMas.Shift.ShiftTitle.ToString().Substring(0, 1);
                           if (dgvRosterDuty.Rows[i].Cells[Col].Value.ToString() == "M")
                            {
                                dgvRosterDuty.Rows[i].Cells[Col].Style.BackColor = Color.DarkKhaki;
                            }
                           if (dgvRosterDuty.Rows[i].Cells[Col].Value.ToString() == "D")
                            {
                                dgvRosterDuty.Rows[i].Cells[Col].Style.BackColor = Color.Green;
                            }
                           if (dgvRosterDuty.Rows[i].Cells[Col].Value.ToString() == "N")
                            {
                                dgvRosterDuty.Rows[i].Cells[Col].Style.BackColor = Color.Gray;
                            }
                           if (dgvRosterDuty.Rows[i].Cells[Col].Value.ToString() == "G")
                            {
                                dgvRosterDuty.Rows[i].Cells[Col].Style.BackColor = Color.Purple;
                            }
                           if (dgvRosterDuty.Rows[i].Cells[Col].Value.ToString() == "O")
                           {
                               dgvRosterDuty.Rows[i].Cells[Col].Style.BackColor = Color.Red;
                           }
                        }                 
                }         
                strCardNo = "";
            }
           dgvRosterDuty.CurrentCell = null;
           dgvRosterDuty.ClearSelection();
        }

        private void LoadRosterDuty(string Mode,string Year, string Month, string DeptGroup, string Department, string Unit)
        {
            dgvRosterDuty.Rows.Clear();            
            string strID = "";           
            oEmpMass = hmsSC.GetRosterDuty(Mode.ToString(),cboYear.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString()).ToList();
            if (oEmpMass.Count > 0)
            {
                foreach (EmployeeMaster oEmp in oEmpMass)
                {
                    if (mAdditem(oEmp.EmpId.ToString())==false)
                    {
                        dgvRosterDuty.Rows.Add(1);
                        dgvRosterDuty.Rows[i].Cells[0].Value = oEmp.EmpId;
                        dgvRosterDuty.Rows[i].Cells[1].Value = oEmp.Name;
                        dgvRosterDuty.Rows[i].Cells[2].Value = oEmp.Designation.DesignationTitle;
                        strID = dgvRosterDuty.Rows[i].Cells[0].Value.ToString();
                        GetGridvalue(dgvRosterDuty.Rows[i].Cells[0].Value.ToString(), i);
                        i = i + 1;
                    }                 
                    dgvRosterDuty.AllowUserToAddRows = false;
                    dgvRosterDuty.CurrentCell = null;
                    dgvRosterDuty.ClearSelection();
                }
                i = 0;
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvRosterDuty.Columns.Clear();
            if (cboMonth.SelectedValue.ToString() != "")
            {
                int j = 1;
                string month = Convert.ToDateTime(cboMonth.SelectedValue.ToString()).ToString("MMM");
                string year = cboYear.SelectedValue.ToString();
                DateTime firstDay = Convert.ToDateTime(DateTime.Parse(month + ", 1 " + year, CultureInfo.InvariantCulture).ToString("dd/MM/yyyy"));
                DateTime lastDay = Convert.ToDateTime(firstDay.AddMonths(1).AddDays(-1).ToString("dd/MM/yyyy"));

                int LastDay = lastDay.Day;
                for (int i = 1; i <= LastDay + 3; i++)
                {
                    if (i == 1)
                    {
                        dgvRosterDuty.Columns.Add(FormatColumns("ID", "ID", 50, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.BottomLeft));
                    }
                    if (i == 2)
                    {
                        dgvRosterDuty.Columns.Add(FormatColumns("Name", "Name", 220, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.BottomLeft));
                    }
                    if (i == 3)
                    {
                        dgvRosterDuty.Columns.Add(FormatColumns("Designation", "Designation", 192, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.BottomLeft));
                    }
                    if (i > 3)
                    {
                        string FirstTwoDigits = j.ToString("00");
                        dgvRosterDuty.Columns.Add(FormatColumns(FirstTwoDigits, FirstTwoDigits, 32, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
                        j = j + 1;
                    }
                }
                if (rdoAll.Checked == true)
                {
                    LoadRosterDuty("A",cboYear.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString());                    
                }
                if (rdoDeptGrp.Checked == true)
                {
                    LoadRosterDuty("B",cboYear.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString());
                }
                if (rdoGrpDeptUnit.Checked == true)
                {
                    LoadRosterDuty("C",cboYear.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString());
                }
            }
        }

        private void btnAddDuty_Click(object sender, EventArgs e)
        {
            frmRosterDutySetup oRosterDuty = new frmRosterDutySetup();
            oRosterDuty.DepartmentType = cboDepartmentType.SelectedValue.ToString();
            oRosterDuty.DepartmentGroup = cboDepartmentGroup.SelectedValue.ToString();
            oRosterDuty.Department = cboDepartment.SelectedValue.ToString();
            oRosterDuty.Unit = cboUnit.SelectedValue.ToString();
            oRosterDuty.Year = cboYear.SelectedValue.ToString();
            oRosterDuty.Month = cboMonth.SelectedValue.ToString();
            if (rdoAll.Checked == true)
            {
                oRosterDuty.Mode = "A";

            }
            if (rdoDeptGrp.Checked == true)
            {
                oRosterDuty.Mode = "B";
            }
            if (rdoGrpDeptUnit.Checked == true)
            {
                oRosterDuty.Mode = "C";
            }
            oRosterDuty.ShowDialog();
        }

        private void dgvRosterDuty_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cboMonth.SelectedValue.ToString() != "")
            {
                string ColumnName = dgvRosterDuty.Columns[e.ColumnIndex].HeaderCell.Value.ToString();
                frmRosterDutySetup oRosterDuty = new frmRosterDutySetup();
                oRosterDuty.DepartmentType = cboDepartmentType.SelectedValue.ToString();
                oRosterDuty.DepartmentGroup = cboDepartmentGroup.SelectedValue.ToString();
                oRosterDuty.Department = cboDepartment.SelectedValue.ToString();
                oRosterDuty.Unit = cboUnit.SelectedValue.ToString();
                oRosterDuty.Year = cboYear.SelectedValue.ToString();
                oRosterDuty.Month = cboMonth.SelectedValue.ToString();
                oRosterDuty.DutyDate = ColumnName.ToString();
                if (rdoAll.Checked == true)
                {
                    oRosterDuty.Mode = "A";
                    
                }
                if (rdoDeptGrp.Checked == true)
                {
                    oRosterDuty.Mode = "B";
                }
                if (rdoGrpDeptUnit.Checked == true)
                {
                    oRosterDuty.Mode = "C";
                }
                oRosterDuty.ShowDialog();
            }
        }
        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(sender, e);
        }
       
    }
}
