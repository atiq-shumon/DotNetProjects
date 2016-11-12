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
using System.Globalization;
using System.Diagnostics;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmDepartmentHeadSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string DeptType { set; get; }
        public string DeptGrp { set; get; }
        public string Dept { set; get; }
        public string Unit { set; get; }
        List<EmployeeMaster> oEmpMass;
        public frmDepartmentHeadSetup()
        {
            InitializeComponent();
        }

        private void frmDepartmentHeadSetup_Load(object sender, EventArgs e)
        {
            FormatGrid(dgvInitialGrid);
            FormatAssociatedGrid();

            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);
            if (DeptType != null)
            {
                cboDepartmentType.SelectedValue = DeptType.ToString();
                if (DeptGrp != null)
                {
                    cboDepartmentGroup.SelectedValue = DeptGrp.ToString();
                    if (Dept != null)
                    {
                        cboDepartment.SelectedValue = Dept.ToString();
                        if (Unit != null)
                        {
                            cboUnit.SelectedValue = Unit.ToString();
                        }
                    }
                }
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
            ID.Width = 70;
            dgv.Columns.Add(ID);

            DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
            Name.Name = "Name";
            Name.DataPropertyName = "Name";
            Name.Width = 217;
            dgv.Columns.Add(Name);           
        }
        private void FormatAssociatedGrid()
        {
            dgvAssociatedGrid.ColumnCount = 4;
            this.dgvAssociatedGrid.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAssociatedGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAssociatedGrid.Columns[0].Name = "Blank";
            dgvAssociatedGrid.Columns[0].Width = 0;
            dgvAssociatedGrid.Columns[0].Visible = false;
            dgvAssociatedGrid.Columns[1].Name = "ID";
            dgvAssociatedGrid.Columns[1].Width = 55;
            dgvAssociatedGrid.Columns[1].ReadOnly = true;
            dgvAssociatedGrid.Columns[2].Name = "Name";
            dgvAssociatedGrid.Columns[2].Width = 215;
            dgvAssociatedGrid.Columns[2].ReadOnly = true;
            dgvAssociatedGrid.Columns[3].Name = "DOJ";
            dgvAssociatedGrid.Columns[3].Width = 150;
            

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvAssociatedGrid.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.DefaultCellStyle.ForeColor = Color.Navy;
            btn.UseColumnTextForButtonValue = true;
            btn.Width = 50;
        }
        private void LoadListView(string DeptGroup,string Department, string Unit)
        {
            try
            {
                dgvInitialGrid.Rows.Clear();
                int i = 0;
                oEmpMass = hmsSC.GetEmpInfoForAttndence(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString()).ToList();
                if (oEmpMass.Count > 0)
                {
                    foreach (EmployeeMaster oEmp in oEmpMass)
                    {
                        dgvInitialGrid.Rows.Add(1);
                        dgvInitialGrid.Rows[i].Cells[1].Value = oEmp.EmpId;
                        dgvInitialGrid.Rows[i].Cells[2].Value = oEmp.Name;                        
                        i = i + 1;
                    }
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDepartment", "cboUnit" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            LoadListView(cboDepartmentGroup.SelectedValue.ToString(),cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString());
            LoadDeptHead(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {           
            for (int i = 0; i < dgvInitialGrid.RowCount; i++)
            {
                if (Convert.ToBoolean(dgvInitialGrid.Rows[i].Cells[0].Value) == true)
                {
                    if (dgvInitialGrid[0, i].Value != null)
                    {
                        mAdditem(dgvInitialGrid[1, i].Value.ToString(), dgvInitialGrid[2, i].Value.ToString(),
                                dtJoiningDate.Text.ToString());
                    }
                    dgvInitialGrid.Rows[i].Cells[0].Value = false;
                }
                dgvAssociatedGrid.AllowUserToAddRows = false;

            }           
        }
        private void mAdditem(string EmpID, string EmpTitle, string JoiningDate)
        {
            int selRaw;
            string strDown = "";           
            Boolean blngCheck = false;
            for (int j = 0; j < dgvAssociatedGrid.RowCount; j++)
            {
                if (dgvAssociatedGrid[1, j].Value != null)
                {
                    strDown = dgvAssociatedGrid[1, j].Value.ToString();                    
                }
                if (EmpID == strDown.ToString())
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
                    dgvAssociatedGrid[3, selRaw].Value = dtJoiningDate.Text.ToString();
                }

            }
        }

        private void dgvAssociatedGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAssociatedGrid.Columns[e.ColumnIndex].Name == "btn")
            {
                if (dgvAssociatedGrid.CurrentCell != null)
                {
                    int selectedIndex = dgvAssociatedGrid.CurrentCell.RowIndex;
                    if (selectedIndex > -1)
                    {
                        dgvAssociatedGrid.Rows.RemoveAt(selectedIndex);
                        dgvAssociatedGrid.Refresh();
                    }
                }
            }      
        }

        private EmployeeJobInformation PopulateDepartmentHead()
        {
            string string1 = "";
            EmployeeJobInformation oEmpJobInfo = new EmployeeJobInformation();
            EmployeeMaster oEmployeeMaster = new EmployeeMaster();

            DepartmentGroup oDeptGrp = new DepartmentGroup();
            oDeptGrp.DepartmentGroupID = cboDepartmentGroup.SelectedValue.ToString();
            oEmpJobInfo.DepartmentGroup = oDeptGrp;
           
            Department oDept = new Department();
            oDept.DepartmentID = cboDepartment.SelectedValue.ToString();
            oEmpJobInfo.Department = oDept;

            DepartmentUnit oDeptUnit = new DepartmentUnit();
            oDeptUnit.UnitId = cboUnit.SelectedValue.ToString();
            oEmpJobInfo.DepartmentUnit = oDeptUnit;

            for (int i = 0; i < dgvAssociatedGrid.Rows.Count; i++)
            {
                string1 += dgvAssociatedGrid.Rows[i].Cells[1].Value +                           
                            ":" + dgvAssociatedGrid.Rows[i].Cells[3].Value +
                            ":" + ";";
            }
            oEmpJobInfo.HeadString = string1;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oEmployeeMaster.EntryParameter = ep;
            oEmpJobInfo.EmployeeMaster = oEmployeeMaster;

            return oEmpJobInfo;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDepartmentGroup", "cboDepartment", "cboUnit"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dgvAssociatedGrid.Rows.Count == 0)
            {
                MessageBox.Show("Head Name is not Assigned", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvAssociatedGrid.Rows.Count>1)
            {
                MessageBox.Show("Two Person Can't be the Head", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {

                EmployeeJobInformation oEmpJobInfo = this.PopulateDepartmentHead();
                short i = hmsSC.SaveDeptHeadInfo(oEmpJobInfo);
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

        private void LoadDeptHead(string DeptGroup, string Department, string Unit)
        {
            try
            {
                dgvAssociatedGrid.Rows.Clear();
                int i = 0;
               List<EmployeeJobInformation> oEmpJobInfo = hmsSC.GetDeptHead(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString()).ToList();
                if (oEmpMass.Count > 0)
                {
                    foreach (EmployeeJobInformation oEmp in oEmpJobInfo)
                    {
                        dgvAssociatedGrid.Rows.Add(1);
                        dgvAssociatedGrid.Rows[i].Cells[1].Value = oEmp.EmployeeMaster.EmpId;
                        dgvAssociatedGrid.Rows[i].Cells[2].Value = oEmp.EmployeeMaster.Name;
                        dgvAssociatedGrid.Rows[i].Cells[3].Value = oEmp.DOJAsHead;
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
        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(sender, e);
        }

    }
}
