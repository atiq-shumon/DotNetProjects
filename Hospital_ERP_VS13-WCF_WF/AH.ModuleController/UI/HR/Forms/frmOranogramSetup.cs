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
    public partial class frmOranogramSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        private List<Designation> oDesigs;
        public frmOranogramSetup()
        {
            InitializeComponent();
        }

        private void frmOranogramSetup_Load(object sender, EventArgs e)
        {
            FormatGrid(dgvInitialGrid);
            FormatAssociatedGrid();
            LoadAllListView();

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

            DataGridViewTextBoxColumn DesigID = new DataGridViewTextBoxColumn();
            DesigID.Name = "DesigID";
            DesigID.DataPropertyName = "DesigID";
            DesigID.Width = 0;
            DesigID.Visible = false;
            dgv.Columns.Add(DesigID);

            DataGridViewTextBoxColumn Designation = new DataGridViewTextBoxColumn();
            Designation.Name = "Designation";
            Designation.DataPropertyName = "Designation";
            Designation.Width = 300;
            Designation.ReadOnly = true;
            dgv.Columns.Add(Designation);

            DataGridViewTextBoxColumn Level = new DataGridViewTextBoxColumn();
            Level.Name = "Level";
            Level.DataPropertyName = "Level";
            Level.Width = 98;
            Level.ReadOnly = true;
            dgv.Columns.Add(Level);

            DataGridViewTextBoxColumn NoOfPost = new DataGridViewTextBoxColumn();
            NoOfPost.Name = "NoOfPost";
            NoOfPost.DataPropertyName = "NoOfPost";
            NoOfPost.Width = 90;
            dgv.Columns.Add(NoOfPost);


        }

        private void FormatAssociatedGrid()
        {
            dgvAssociatedGrid.ColumnCount = 8;
            this.dgvAssociatedGrid.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAssociatedGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAssociatedGrid.Columns[0].Name = "Blank";
            dgvAssociatedGrid.Columns[0].Width = 0;
            dgvAssociatedGrid.Columns[0].Visible = false;
            dgvAssociatedGrid.Columns[1].Name = "Desig ID";
            dgvAssociatedGrid.Columns[1].Width = 0;
            dgvAssociatedGrid.Columns[1].Visible = false;
            dgvAssociatedGrid.Columns[2].Name = "Designation";
            dgvAssociatedGrid.Columns[2].Width = 300;
            dgvAssociatedGrid.Columns[2].ReadOnly = true;
            dgvAssociatedGrid.Columns[3].Name = "Level";
            dgvAssociatedGrid.Columns[3].Width = 100;
            dgvAssociatedGrid.Columns[3].ReadOnly = true;
            dgvAssociatedGrid.Columns[4].Name = "No of Post";
            dgvAssociatedGrid.Columns[4].Width = 110;
            dgvAssociatedGrid.Columns[5].Name = "Department";
            dgvAssociatedGrid.Columns[5].Width = 0;
            dgvAssociatedGrid.Columns[5].Visible = false;
            dgvAssociatedGrid.Columns[6].Name = "DepGrp";
            dgvAssociatedGrid.Columns[6].Width = 0;
            dgvAssociatedGrid.Columns[6].Visible = false;
            dgvAssociatedGrid.Columns[7].Name = "Unit";
            dgvAssociatedGrid.Columns[7].Width = 0;
            dgvAssociatedGrid.Columns[7].Visible = false;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvAssociatedGrid.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.DefaultCellStyle.ForeColor = Color.Navy;
            btn.UseColumnTextForButtonValue = true;
            btn.Width = 50;
        }

        private void LoadAllListView()
        {
            try
            {
                dgvInitialGrid.Rows.Clear();
                int i = 0;
                oDesigs = hmsSC.GetDesignation().ToList();
                if (oDesigs.Count > 0)
                {
                    foreach (Designation ds in oDesigs)
                    {
                        dgvInitialGrid.Rows.Add(1);
                        dgvInitialGrid.Rows[i].Cells[1].Value = ds.DesignationId;
                        dgvInitialGrid.Rows[i].Cells[2].Value = ds.DesignationTitle;
                        dgvInitialGrid.Rows[i].Cells[3].Value = ds.DesignationLevel;
                        dgvInitialGrid.Rows[i].Cells[4].Value = "0";
                        i = i + 1;
                    }
                    //dgvInitialGrid.AllowUserToAddRows = false;
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

        private void txtSearchDesig_KeyUp(object sender, KeyEventArgs e)
        {
            PopulateDataToGrid(dgvInitialGrid, txtSearchDesig.Text);
            dgvInitialGrid.Refresh();     
        }
        private void PopulateDataToGrid(DataGridView dgv, string Designation)
        {
            string Post = "0";
            if (oDesigs != null)
            {
                IEnumerable<Designation> TestsListLocal;
                if (!(Designation.Length > 0))
                {
                    TestsListLocal = oDesigs;
                }
                else
                {
                    TestsListLocal = oDesigs.Where(x => x.DesignationTitle.ToLower().Contains(Designation.ToLower()));
                }
                dgv.DataSource = TestsListLocal.Select(data => new
                {
                    DesigID = data.DesignationId,
                    Designation = data.DesignationTitle,
                    Level = data.DesignationLevel,
                    NoOfPost = Post
                }).ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue.ToString()=="")
            {
                MessageBox.Show("Please Select Department", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDepartment.Focus();
                return;
            }
            for (int i = 0; i < dgvInitialGrid.RowCount; i++)
            {
                if (Convert.ToBoolean(dgvInitialGrid.Rows[i].Cells[0].Value) == true)
                {
                    if (dgvInitialGrid[0, i].Value != null)
                    {
                        mAdditem(dgvInitialGrid[1, i].Value.ToString(), dgvInitialGrid[2, i].Value.ToString(),
                                dgvInitialGrid[3, i].Value.ToString(), dgvInitialGrid[4, i].Value.ToString(), cboDepartment.SelectedValue.ToString(), cboDepartmentGroup.SelectedValue.ToString(), cboUnit.SelectedValue.ToString());
                    }
                    dgvInitialGrid.Rows[i].Cells[0].Value = false;
                }
                dgvAssociatedGrid.AllowUserToAddRows = false;

            }        
        }
        private void mAdditem(string DesigID, string DesigTitle, string Level, string NoOfPost, string Department, string DepartmentGroup,string Unit)
        {
            int selRaw;
            string strDown = "";
            string strDept = "";
            Boolean blngCheck = false;
            for (int j = 0; j < dgvAssociatedGrid.RowCount; j++)
            {
                if (dgvAssociatedGrid[1, j].Value != null)
                {
                    strDown = dgvAssociatedGrid[1, j].Value.ToString();
                    strDept = dgvAssociatedGrid[5, j].Value.ToString();
                }
                if (DesigID == strDown.ToString() && Department == strDept.ToString())
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
                    dgvAssociatedGrid[1, selRaw].Value = DesigID.ToString();
                    dgvAssociatedGrid[2, selRaw].Value = DesigTitle.ToString();
                    dgvAssociatedGrid[3, selRaw].Value = Level.ToString();
                    dgvAssociatedGrid[4, selRaw].Value = NoOfPost.ToString();
                    dgvAssociatedGrid[5, selRaw].Value = Department.ToString();
                    dgvAssociatedGrid[6, selRaw].Value = DepartmentGroup.ToString();
                    dgvAssociatedGrid[7, selRaw].Value = Unit.ToString();
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
        private Organogram PopulateOrganogram()
        {
            string string1 = "";
            Organogram oOrganogram = new Organogram();
            Department oDept = new Department();
            DepartmentGroup oDeptGrp = new DepartmentGroup();
            oDeptGrp.DepartmentGroupID = cboDepartmentGroup.SelectedValue.ToString();
            oDept.DepartmentGroup = oDeptGrp;
            DepartmentType oDeptType = new DepartmentType();
            oDeptType.TypeID = cboDepartmentType.SelectedValue.ToString();
            oDept.DepartmentType = oDeptType;
            oDept.DepartmentID = cboDepartment.SelectedValue.ToString();
            oOrganogram.Department = oDept;
            DepartmentUnit oUnit = new DepartmentUnit();
            oUnit.UnitId = cboUnit.SelectedValue.ToString();
            oOrganogram.DepartmentUnit = oUnit;

            for (int i = 0; i < dgvAssociatedGrid.Rows.Count; i++)
            {
                string1 += dgvAssociatedGrid.Rows[i].Cells[6].Value +
                            ":" + dgvAssociatedGrid.Rows[i].Cells[5].Value +
                            ":" + dgvAssociatedGrid.Rows[i].Cells[1].Value +
                            ":" + dgvAssociatedGrid.Rows[i].Cells[3].Value +
                            ":" + dgvAssociatedGrid.Rows[i].Cells[4].Value +
                            ":" + dgvAssociatedGrid.Rows[i].Cells[7].Value +
                            ":" + ";";
            }
            oOrganogram.DeptDesigString = string1;
            oOrganogram.Remarks = txtRemarks.Text.ToString();

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oOrganogram.EntryParameter = ep;
            return oOrganogram;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDepartmentGroup", "cboDepartment"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }           
            try
            {

                Organogram oOrganogram = this.PopulateOrganogram();
                short i = hmsSC.SaveOrganogram(oOrganogram);
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
        private void LoadOrganogramSetup(string DepartmentGroup,string Department)
        {
            try
            {
                dgvAssociatedGrid.Rows.Clear();
                int i = 0;
                List<Organogram> oOrganograms = hmsSC.GetOrganogramSetup(cboDepartmentGroup.SelectedValue.ToString(),cboDepartment.SelectedValue.ToString(),cboUnit.SelectedValue.ToString()).ToList();
                if (oOrganograms.Count > 0)
                {
                    foreach (Organogram oOrganogram in oOrganograms)
                    {
                        dgvAssociatedGrid.Rows.Add(1);
                        dgvAssociatedGrid.Rows[i].Cells[1].Value = oOrganogram.Designation.DesignationId;
                        dgvAssociatedGrid.Rows[i].Cells[2].Value = oOrganogram.Designation.DesignationTitle;
                        dgvAssociatedGrid.Rows[i].Cells[3].Value = oOrganogram.Designation.DesignationLevel;
                        dgvAssociatedGrid.Rows[i].Cells[4].Value = oOrganogram.NoOfPost;
                        dgvAssociatedGrid.Rows[i].Cells[5].Value = oOrganogram.Department.DepartmentID;
                        dgvAssociatedGrid.Rows[i].Cells[6].Value = oOrganogram.Department.DepartmentGroup.DepartmentGroupID;
                        dgvAssociatedGrid.Rows[i].Cells[7].Value = oOrganogram.DepartmentUnit.UnitId;
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadOrganogramSetup(cboDepartmentGroup.SelectedValue.ToString(),cboDepartment.SelectedValue.ToString());
        }

        private void btnAddDesig_Click(object sender, EventArgs e)
        {
            frmDesignationSetup oDesig = new frmDesignationSetup();
            oDesig.ShowDialog();
        }

        private void btnRefreshDesig_Click(object sender, EventArgs e)
        {
            LoadAllListView();
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

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            frmAssignOrganogram oAssign = new frmAssignOrganogram();
            oAssign.ShowDialog();
        }

        private void btnRefreshDept_Click(object sender, EventArgs e)
        {
            this.cboDepartmentGroup_SelectedIndexChanged(sender, e);
        }

        private void btnRefreshUnit_Click(object sender, EventArgs e)
        {
            this.cboDepartmentGroup_SelectedIndexChanged(sender, e);
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            frmAssignOrganogram oAssign = new frmAssignOrganogram();
            oAssign.ShowDialog();
        }
        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(sender, e);
        }
    }
}
