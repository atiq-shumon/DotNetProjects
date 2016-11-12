using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.HRSR;
using AH.ModuleController.UI.HR.Reports.Viewer;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmAssignOrganogram : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        private List<Department> oDepts;
        private List<DepartmentUnit> oUnits;
        private List<DeptUnitAss> oDeptUnits;
        public string DeptCode;
        public frmAssignOrganogram()
        {
            InitializeComponent();
        }
        private void frmAssignOrganogram_Load(object sender, EventArgs e)
        {
            try
            {
                FormatDeptGrid(dgvDepartment);
                FormatUnitGrid(dgvUnit);
                FormatAssociatedGrid();
                LoadAllDept();
                LoadAllUnit();

                cboDepartmentType.DisplayMember = "Value";
                cboDepartmentType.ValueMember = "Key";
                cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);

                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(hmsSC.GetDeptDictionary("D"), null);
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

        private void cboDepartmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboDepartmentType.SelectedValue != null)
                {
                    cboDepartmentGroup.DisplayMember = "Value";
                    cboDepartmentGroup.ValueMember = "Key";
                    cboDepartmentGroup.DataSource = new BindingSource(hmsSC.GetDeptGroupDicByType(cboDepartmentType.SelectedValue.ToString()), null);
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
        private void FormatDeptGrid(DataGridView dgv)
        {
            this.dgvDepartment.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvDepartment.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dgvDepartment.Columns.Add(chk);
            chk.HeaderText = "Select";
            chk.Name = "chk";
            chk.Visible = true;
            chk.Width = 53;
            dgv.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn DeptID = new DataGridViewTextBoxColumn();
            DeptID.Name = "DeptID";
            DeptID.DataPropertyName = "DeptID";
            DeptID.Width = 0;
            DeptID.Visible = false;
            dgv.Columns.Add(DeptID);

            DataGridViewTextBoxColumn Department = new DataGridViewTextBoxColumn();
            Department.Name = "Department";
            Department.DataPropertyName = "Department";
            Department.Width = 275;
            Department.ReadOnly = true;
            dgv.Columns.Add(Department);
        }
        private void FormatUnitGrid(DataGridView dgv)
        {
            this.dgvUnit.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvUnit.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dgvUnit.Columns.Add(chk);
            chk.HeaderText = "Select";
            chk.Name = "chk";
            chk.Visible = true;
            chk.Width = 53;
            dgv.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn UnitID = new DataGridViewTextBoxColumn();
            UnitID.Name = "UnitID";
            UnitID.DataPropertyName = "UnitID";
            UnitID.Width = 0;
            UnitID.Visible = false;
            dgv.Columns.Add(UnitID);

            DataGridViewTextBoxColumn Unit = new DataGridViewTextBoxColumn();
            Unit.Name = "Unit";
            Unit.DataPropertyName = "Unit";
            Unit.Width = 290;
            Unit.ReadOnly = true;
            dgv.Columns.Add(Unit);
        }
        private void FormatAssociatedGrid()
        {
            dgvAssociatedGrid.ColumnCount = 5;
            this.dgvAssociatedGrid.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAssociatedGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAssociatedGrid.Columns[0].Name = "Blank";
            dgvAssociatedGrid.Columns[0].Width = 0;
            dgvAssociatedGrid.Columns[0].Visible = false;
            dgvAssociatedGrid.Columns[1].Name = "Dept ID";
            dgvAssociatedGrid.Columns[1].Width = 0;
            dgvAssociatedGrid.Columns[1].Visible = false;
            dgvAssociatedGrid.Columns[2].Name = "Department";
            dgvAssociatedGrid.Columns[2].Width = 195;
            dgvAssociatedGrid.Columns[2].ReadOnly = true;
            dgvAssociatedGrid.Columns[3].Name = "Unit ID";
            dgvAssociatedGrid.Columns[3].Width = 0;
            dgvAssociatedGrid.Columns[3].Visible = false;
            dgvAssociatedGrid.Columns[4].Name = "Unit";
            dgvAssociatedGrid.Columns[4].Width = 200;
            dgvAssociatedGrid.Columns[4].ReadOnly = true;
           

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvAssociatedGrid.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.DefaultCellStyle.ForeColor = Color.Navy;
            btn.UseColumnTextForButtonValue = true;
            btn.Width = 50;
        }
        private void LoadAllDept()
        {
            try
            {
                dgvDepartment.Rows.Clear();
                int i = 0;
                oDepts = hmsSC.GetDepartments().ToList();
                if (oDepts.Count > 0)
                {
                    foreach (Department ds in oDepts)
                    {
                        dgvDepartment.Rows.Add(1);
                        dgvDepartment.Rows[i].Cells[1].Value = ds.DepartmentID;
                        dgvDepartment.Rows[i].Cells[2].Value = ds.DepartmentTitle;                      
                        i = i + 1;
                    }                 
                }
                else
                {
                    return;
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
        private void LoadAllUnit()
        {
            try
            {
                dgvUnit.Rows.Clear();
                int i = 0;
                oUnits = hmsSC.GetUnits().ToList();
                if (oUnits.Count > 0)
                {
                    foreach (DepartmentUnit ds in oUnits)
                    {
                        dgvUnit.Rows.Add(1);
                        dgvUnit.Rows[i].Cells[1].Value = ds.UnitId;
                        dgvUnit.Rows[i].Cells[2].Value = ds.UnitTitle;
                        i = i + 1;
                    }
                    //dgvUnit.AllowUserToAddRows = false;
                }
                else
                {
                    return;
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
        private void txtSearchDept_KeyUp(object sender, KeyEventArgs e)
        {
            PopulateDeptToGrid(dgvDepartment, txtSearchDept.Text);
            dgvDepartment.Refresh();  
        }
        private void PopulateDeptToGrid(DataGridView dgv, string Department)
        {
            if (oDepts != null)
            {
                IEnumerable<Department> TestsListLocal;
                if (!(Department.Length > 0))
                {
                    TestsListLocal = oDepts;
                }
                else
                {
                    TestsListLocal = oDepts.Where(x => x.DepartmentTitle.ToLower().Contains(Department.ToLower()));
                }
                dgv.DataSource = TestsListLocal.Select(data => new
                {
                    DeptID = data.DepartmentID,
                    Department = data.DepartmentTitle
                }).ToList();
            }
        }
        private void txtSearchUnit_KeyUp(object sender, KeyEventArgs e)
        {
            PopulateUnitToGrid(dgvUnit, txtSearchUnit.Text);
            dgvUnit.Refresh();  
        }
        private void PopulateUnitToGrid(DataGridView dgv, string Unit)
        {
            if (oUnits != null)
            {
                IEnumerable<DepartmentUnit> TestsListLocal;
                if (!(Unit.Length > 0))
                {
                    TestsListLocal = oUnits;
                }
                else
                {
                    TestsListLocal = oUnits.Where(x => x.UnitTitle.ToLower().Contains(Unit.ToLower()));
                }
                dgv.DataSource = TestsListLocal.Select(data => new
                {
                    UnitID = data.UnitId,
                    Unit = data.UnitTitle
                }).ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //dgvAssociatedGrid.Rows.Clear();
            if (cboDepartmentGroup.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Please Select Department Group", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDepartmentGroup.Focus();
                return;
            }
            for (int j = 0; j < dgvDepartment.RowCount; j++)
            {
                if (Convert.ToBoolean(dgvDepartment.Rows[j].Cells[0].Value) == true)
                {
                    DeptCode = dgvDepartment.Rows[j].Cells[1].Value.ToString();
                    string DeptTitle = dgvDepartment.Rows[j].Cells[2].Value.ToString();
                    for (int i = 0; i < dgvUnit.RowCount; i++)
                    {
                        if (Convert.ToBoolean(dgvUnit.Rows[i].Cells[0].Value) == true)
                        {
                            if (dgvUnit[0, i].Value != null)
                            {
                                mAdditem(dgvUnit[1, i].Value.ToString(), dgvUnit[2, i].Value.ToString(), DeptCode.ToString(), DeptTitle.ToString());
                            }
                            dgvUnit.Rows[i].Cells[0].Value = false;
                        }
                        dgvAssociatedGrid.AllowUserToAddRows = false;

                    }
                }
            }
        }
        private void mAdditem(string UnitID, string UnitTitle,string DeptID,string DeptTitle)
        {
            int selRaw;
            string strUnit = "";
            string strDept = "";
            Boolean blngCheck = false;
            for (int j = 0; j < dgvAssociatedGrid.RowCount; j++)
            {
                if (dgvAssociatedGrid[1, j].Value != null)
                {
                    strDept = dgvAssociatedGrid[1, j].Value.ToString();
                    strUnit = dgvAssociatedGrid[3, j].Value.ToString();                   
                }
                if (UnitID == strUnit.ToString() && DeptID == strDept.ToString())
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
                    dgvAssociatedGrid[1, selRaw].Value = DeptID.ToString();
                    dgvAssociatedGrid[2, selRaw].Value = DeptTitle.ToString(); 
                    dgvAssociatedGrid[3, selRaw].Value = UnitID.ToString();
                    dgvAssociatedGrid[4, selRaw].Value = UnitTitle.ToString();                    
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
                            dgvAssociatedGrid.Rows.RemoveAt(selectedIndex);
                            dgvAssociatedGrid.Refresh();
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
        private DeptUnitAss PopulateDeptUnitAss()
        {
            string string1 = "";
            DeptUnitAss oDeptUnitAss = new DeptUnitAss();
            Department oDept = new Department();
            DepartmentGroup oDeptGrp = new DepartmentGroup();
            oDeptGrp.DepartmentGroupID = cboDepartmentGroup.SelectedValue.ToString();
            oDeptUnitAss.DepartmentGroup = oDeptGrp;
            oDept.DepartmentID = cboDepartment.SelectedValue.ToString();
            oDeptUnitAss.Department = oDept;
                        
            for (int i = 0; i < dgvAssociatedGrid.Rows.Count; i++)
            {                
                string1 += dgvAssociatedGrid.Rows[i].Cells[3].Value +
                            ":" + dgvAssociatedGrid.Rows[i].Cells[1].Value +                           
                            ":" + ";";
            }            
            oDeptUnitAss.UnitAssignString = string1;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oDeptUnitAss.EntryParameter = ep;
            return oDeptUnitAss;
        }
        private Boolean CheckDepartment()
        {
            string DeptValue = "";
            for(int i=0;i<dgvAssociatedGrid.Rows.Count;i++)
            {
                DeptValue = dgvAssociatedGrid.Rows[i].Cells[1].Value.ToString();              
                for(int j=0;j<dgvAssociatedGrid.Rows.Count;j++)
                {
                    if (DeptValue != dgvAssociatedGrid.Rows[j].Cells[1].Value.ToString())
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDepartmentType","cboDepartmentGroup"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (CheckDepartment()==true)
            {
                return;
            }
            try
            {
                DeptUnitAss oDeptUnitAss = this.PopulateDeptUnitAss();
                short i = hmsSC.SaveDeptUnitAss(oDeptUnitAss);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAssociatedGrid.Rows.Clear();
                    this.btnShowUnit_Click(sender, e);
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
        private void LoadAssignedUnit(string DeptGroup)
        {
            try
            {
                dgvAssociatedGrid.Rows.Clear();
                int i = 0;
                oDeptUnits = hmsSC.GetGroupDeptUnit(cboDepartmentGroup.SelectedValue.ToString()).ToList();
                if (oDeptUnits.Count > 0)
                {
                    foreach (DeptUnitAss ds in oDeptUnits)
                    {
                        dgvAssociatedGrid.Rows.Add(1);
                        dgvAssociatedGrid.Rows[i].Cells[1].Value = ds.Department.DepartmentID;
                        dgvAssociatedGrid.Rows[i].Cells[2].Value = ds.Department.DepartmentTitle;
                        dgvAssociatedGrid.Rows[i].Cells[3].Value = ds.DepartmentUnit.UnitId;
                        dgvAssociatedGrid.Rows[i].Cells[4].Value = ds.DepartmentUnit.UnitTitle;
                        i = i + 1;
                    }
                    dgvAssociatedGrid.AllowUserToAddRows = false;
                }
                else
                {
                    return;
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
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAssignedUnit(cboDepartmentGroup.SelectedValue.ToString());
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

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            frmDepartmentSetup oDept = new frmDepartmentSetup();
            oDept.ShowDialog();
        }

        private void btnRefreshDept_Click(object sender, EventArgs e)
        {
            //FormatDeptGrid(dgvDepartment);            
            LoadAllDept();

            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(hmsSC.GetDeptDictionary("D"), null);
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            frmUnitSetup oUnit = new frmUnitSetup();
            oUnit.ShowDialog();
        }
        private void btnRefreshUnit_Click(object sender, EventArgs e)
        {
            LoadAllUnit();
        }
        private void btnAddDeptGrp_Click(object sender, EventArgs e)
        {
            frmDepartmentGroup oDeptGrp = new frmDepartmentGroup();
            oDeptGrp.TypeID = cboDepartmentType.SelectedValue.ToString();
            oDeptGrp.ShowDialog();
        }
        private void btnRefreshDeptGrp_Click(object sender, EventArgs e)
        {
            this.cboDepartmentType_SelectedIndexChanged(sender, e);
        }
        private void LoadUnit(string DeptGroup,string Department)
        {
            try
            {
                dgvAssociatedGrid.Rows.Clear();
                int i = 0;
                oDeptUnits = hmsSC.GetAssignedUnit(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString()).ToList();
                if (oDeptUnits.Count > 0)
                {
                    foreach (DeptUnitAss ds in oDeptUnits)
                    {
                        dgvAssociatedGrid.Rows.Add(1);
                        dgvAssociatedGrid.Rows[i].Cells[1].Value = ds.Department.DepartmentID;
                        dgvAssociatedGrid.Rows[i].Cells[2].Value = ds.Department.DepartmentTitle;
                        dgvAssociatedGrid.Rows[i].Cells[3].Value = ds.DepartmentUnit.UnitId;
                        dgvAssociatedGrid.Rows[i].Cells[4].Value = ds.DepartmentUnit.UnitTitle;
                        i = i + 1;
                    }
                    dgvAssociatedGrid.AllowUserToAddRows = false;
                }
                else
                {
                    return;
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

        private void btnShowUnit_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> vf = new List<string>() { "cboDepartmentGroup", "cboDepartment" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }
                LoadUnit(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString());
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

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int k = 0; k < dgvDepartment.Rows.Count; k++)
            {
                Convert.ToBoolean(dgvDepartment.Rows[k].Cells["chk"].Value = false);
                dgvDepartment.ReadOnly = true;
            }
            for(int k=0;k<dgvDepartment.Rows.Count;k++)
            {
                string strCboDept = "", strGrdDept = "";
                strCboDept = cboDepartment.SelectedValue.ToString();
                strGrdDept = dgvDepartment.Rows[k].Cells[1].Value.ToString();
                if(strCboDept==strGrdDept)
                {
                    Convert.ToBoolean(dgvDepartment.Rows[k].Cells["chk"].Value = true);
                }
            }
        }
    }
}
