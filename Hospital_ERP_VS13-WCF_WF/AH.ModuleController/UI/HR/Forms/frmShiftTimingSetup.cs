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
    public partial class frmShiftTimingSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();       
        public frmShiftTimingSetup()
        {
            InitializeComponent();
        }
        private void frmShiftTimingSetup_Load(object sender, EventArgs e)
        {
            FormatGrid(dgvShiftTiming);

            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);

            cboShift.DisplayMember = "Value";
            cboShift.ValueMember = "Key";
            cboShift.DataSource = new BindingSource(hmsSC.GetShiftDict("D"), null);          

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
        private Shift PopulateShiftTimingSetup()
        {
            string string1 = "";
            Shift oShift = new Shift();
            oShift.ShiftID = cboShift.SelectedValue.ToString();

            DepartmentGroup oGroup = new DepartmentGroup();
            oGroup.DepartmentGroupID = cboDepartmentGroup.SelectedValue.ToString();
            oShift.DepartmentGroup = oGroup;

            Department oDept = new Department();
            oDept.DepartmentID = cboDepartment.SelectedValue.ToString();
            oShift.Department = oDept;

            DepartmentUnit oDeptUnit = new DepartmentUnit();
            oDeptUnit.UnitId = cboUnit.SelectedValue.ToString();
            oShift.DepartmentUnit = oDeptUnit;

            for (int i = 0; i < dgvShiftTiming.Rows.Count; i++)
            {
                string1 += dgvShiftTiming.Rows[i].Cells[7].Value +                           
                            "@" + dgvShiftTiming.Rows[i].Cells[10].Value +
                            "@" + dgvShiftTiming.Rows[i].Cells[11].Value +
                            "@" + ";";
            }
            oShift.ShiftString = string1;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oShift.EntryParameter = ep;
            return oShift;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboShiftID", "cboDepartmentGroup", "cboDepartment", "cboUnit", "txtStartTime", "txtEndTime" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                Shift oShift = this.PopulateShiftTimingSetup();
                short i = hmsSC.SaveShiftTimingSetup(oShift);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboShiftID", "cboDepartmentGroup", "cboDepartment", "cboUnit", "txtStartTime", "txtEndTime" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                Shift oShift = this.PopulateShiftTimingSetup();
                short i = hmsSC.UpdateShiftTimingSetup(oShift);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            frmShiftSetup oShift = new frmShiftSetup();
            oShift.ShowDialog();
        }

        private void btnRefreshShift_Click(object sender, EventArgs e)
        {
            cboShift.DisplayMember = "Value";
            cboShift.ValueMember = "Key";
            cboShift.DataSource = new BindingSource(hmsSC.GetShiftDict("D"), null);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDepartmentGroup", "cboDepartment", "cboUnit" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            LoadTiming(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString());
        }

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(sender, e);
        }
        private void FormatGrid(DataGridView dgv)
        {
            this.dgvShiftTiming.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvShiftTiming.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);

            DataGridViewTextBoxColumn DeptType = new DataGridViewTextBoxColumn();
            DeptType.Name = "DeptType";
            DeptType.DataPropertyName = "DeptType";
            DeptType.Width = 0;
            DeptType.Visible = false;
            dgv.Columns.Add(DeptType);

            DataGridViewTextBoxColumn GroupID = new DataGridViewTextBoxColumn();
            GroupID.Name = "GroupID";
            GroupID.DataPropertyName = "GroupID";
            GroupID.Width = 0;
            GroupID.Visible = false;
            dgv.Columns.Add(GroupID);

            DataGridViewTextBoxColumn DeptGroup = new DataGridViewTextBoxColumn();
            DeptGroup.Name = "DeptGroup";
            DeptGroup.DataPropertyName = "DeptGroup";
            DeptGroup.Width = 250;
            DeptGroup.ReadOnly = true;  
            dgv.Columns.Add(DeptGroup);

            DataGridViewTextBoxColumn DeptID = new DataGridViewTextBoxColumn();
            DeptID.Name = "DeptID";
            DeptID.DataPropertyName = "DeptID";
            DeptID.Width = 0;
            DeptID.Visible = false;
            dgv.Columns.Add(DeptID);

            DataGridViewTextBoxColumn Department = new DataGridViewTextBoxColumn();
            Department.Name = "Department";
            Department.DataPropertyName = "Department";
            Department.Width = 282;
            Department.ReadOnly = true; 
            dgv.Columns.Add(Department);

            DataGridViewTextBoxColumn UnitID = new DataGridViewTextBoxColumn();
            UnitID.Name = "UnitID";
            UnitID.DataPropertyName = "UnitID";
            UnitID.Width = 0;
            UnitID.Visible = false;
            dgv.Columns.Add(UnitID);

            DataGridViewTextBoxColumn Unit = new DataGridViewTextBoxColumn();
            Unit.Name = "Unit";
            Unit.DataPropertyName = "Unit";
            Unit.Width = 300;
            Unit.ReadOnly = true; 
            dgv.Columns.Add(Unit);

            DataGridViewTextBoxColumn ShiftID = new DataGridViewTextBoxColumn();
            ShiftID.Name = "ShiftID";
            ShiftID.DataPropertyName = "ShiftID";
            ShiftID.Width = 0;
            ShiftID.Visible = false;
            dgv.Columns.Add(ShiftID);

            DataGridViewTextBoxColumn Shift = new DataGridViewTextBoxColumn();
            Shift.Name = "Shift";
            Shift.DataPropertyName = "Shift";
            Shift.Width = 200;
            Shift.ReadOnly = true; 
            dgv.Columns.Add(Shift);
           
            DataGridViewTextBoxColumn ShiftTiming = new DataGridViewTextBoxColumn();
            ShiftTiming.Name = "ShiftTiming";
            ShiftTiming.DataPropertyName = "ShiftTiming";
            ShiftTiming.Width = 275;
            ShiftTiming.ReadOnly = true; 
            dgv.Columns.Add(ShiftTiming);

            DataGridViewTextBoxColumn StartTime = new DataGridViewTextBoxColumn();
            StartTime.Name = "StartTime";
            StartTime.DataPropertyName = "StartTime";
            StartTime.Width = 0;
            StartTime.Visible = false;
            dgv.Columns.Add(StartTime);

            DataGridViewTextBoxColumn EndTime = new DataGridViewTextBoxColumn();
            EndTime.Name = "EndTime";
            EndTime.DataPropertyName = "EndTime";
            EndTime.Width = 0;
            EndTime.Visible = false;
            dgv.Columns.Add(EndTime);

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvShiftTiming.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.DefaultCellStyle.ForeColor = Color.Navy;
            btn.UseColumnTextForButtonValue = true;
            btn.Width = 60;
        }
        private void LoadTiming(string DeptGroup, string Department, string Unit)
        {
            try
            {
                dgvShiftTiming.Rows.Clear();
                int i = 0;
                List<Shift> oShifts = hmsSC.GetShiftTiming(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(),cboUnit.SelectedValue.ToString()).ToList();
                if (oShifts.Count > 0)
                {
                    foreach (Shift oShift in oShifts)
                    {
                        dgvShiftTiming.Rows.Add(1);
                        dgvShiftTiming.Rows[i].Cells[0].Value = oShift.DepartmentGroup.DepartmentType.TypeID;
                        dgvShiftTiming.Rows[i].Cells[1].Value = oShift.DepartmentGroup.DepartmentGroupID;
                        dgvShiftTiming.Rows[i].Cells[2].Value = oShift.DepartmentGroup.DepartmentGroupTitle;
                        dgvShiftTiming.Rows[i].Cells[3].Value = oShift.Department.DepartmentID;
                        dgvShiftTiming.Rows[i].Cells[4].Value = oShift.Department.DepartmentTitle;
                        dgvShiftTiming.Rows[i].Cells[5].Value = oShift.DepartmentUnit.UnitId;
                        dgvShiftTiming.Rows[i].Cells[6].Value = oShift.DepartmentUnit.UnitTitle;
                        dgvShiftTiming.Rows[i].Cells[7].Value = oShift.ShiftID;
                        dgvShiftTiming.Rows[i].Cells[8].Value = oShift.ShiftTitle;
                        dgvShiftTiming.Rows[i].Cells[9].Value = oShift.ShiftTiming;
                        dgvShiftTiming.Rows[i].Cells[10].Value = oShift.StartTime;
                        dgvShiftTiming.Rows[i].Cells[11].Value = oShift.EndTime;
                        i = i + 1;
                    }
                    dgvShiftTiming.AllowUserToAddRows = false;
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
        private Boolean CheckShift(string Shift)
        {
            for(int k=0;k<dgvShiftTiming.Rows.Count;k++)
            {
                if(Shift==dgvShiftTiming.Rows[k].Cells[7].Value.ToString())
                {
                    MessageBox.Show("Shift Allready Exists!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            return false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {            
            List<string> vf = new List<string>() { "cboDepartmentGroup", "cboDepartment", "cboUnit", "cboShift", "txtStartTime", "txtEndTime" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(CheckShift(cboShift.SelectedValue.ToString())==true)  
            {
                return;
            }
            DateTime dt1 = DateTime.Parse(txtStartTime.Value.ToString("hh : mm tt"));
            DateTime dt2 = DateTime.Parse(txtEndTime.Value.ToString("hh : mm tt"));
                                
                            short rowNo = GetRowNoToAdd(dgvShiftTiming, 9, dt1, dt2);

                            //if (rowNo == -1)
                            //{
                            //    MessageBox.Show("Selected Time Range is Already Assigned!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //    return;
                            //}
                            //else
                            //{   
           // for (int i = 0; i < dgvShiftTiming.Rows.Count; i++)
            //{
                            dgvShiftTiming.Rows[rowNo].Cells[0].Value = cboDepartmentType.SelectedValue.ToString();
                            dgvShiftTiming.Rows[rowNo].Cells[1].Value = cboDepartmentGroup.SelectedValue.ToString();
                            dgvShiftTiming.Rows[rowNo].Cells[2].Value = cboDepartmentGroup.Text.ToString();
                            dgvShiftTiming.Rows[rowNo].Cells[3].Value = cboDepartment.SelectedValue.ToString();
                            dgvShiftTiming.Rows[rowNo].Cells[4].Value = cboDepartment.Text.ToString();
                            dgvShiftTiming.Rows[rowNo].Cells[5].Value = cboUnit.SelectedValue.ToString();
                            dgvShiftTiming.Rows[rowNo].Cells[6].Value = cboUnit.Text.ToString();
                            dgvShiftTiming.Rows[rowNo].Cells[7].Value = cboShift.SelectedValue.ToString();
                            dgvShiftTiming.Rows[rowNo].Cells[8].Value = cboShift.Text.ToString();
                            dgvShiftTiming.Rows[rowNo].Cells[9].Value = dt1.ToString("hh : mm tt") + "-" + dt2.ToString("hh : mm tt");
                            dgvShiftTiming.Rows[rowNo].Cells[10].Value = txtStartTime.Text.ToString();
                            dgvShiftTiming.Rows[rowNo].Cells[11].Value = txtEndTime.Text.ToString();
                // }
            //}
           dgvShiftTiming.AllowUserToAddRows = false;
        }

        private short GetRowNoToAdd(DataGridView dgvShiftTiming, short col, DateTime dt1, DateTime dt2)
        {
            dgvShiftTiming.Rows.Add();  
            short rowNo = 0;
            if (dgvShiftTiming.Rows[0].Cells[col].Value == null)
            {
                rowNo = 0;
            }
            else
            {
                for (short i = 0; i < dgvShiftTiming.Rows.Count && dgvShiftTiming.Rows[i].Cells[col].Value != null; i++)
                {
                    string str = dgvShiftTiming.Rows[i].Cells[col].Value.ToString();
                    DateTime sTime = DateTime.Parse(str.Substring(0, 10).ToString());
                    DateTime eTime = DateTime.Parse(str.Substring(11, 10).ToString());
                    //if (Utility.TimeCompare(dt1, sTime, eTime) || Utility.TimeCompare(dt2, sTime, eTime))
                    //{
                    //    rowNo = -1;
                    //    dgvShiftTiming.Rows.RemoveAt(dgvShiftTiming.Rows.Count - 1);
                    //    return rowNo;                       
                    //}
                    //else
                    //{                        
                        rowNo = i;
                        ++rowNo;
                    //}

                }
            }
           
            return rowNo;
        }
        private void dgvShiftTiming_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvShiftTiming.Columns[e.ColumnIndex].Name == "btn")
            {
                if (dgvShiftTiming.CurrentCell != null)
                {
                    int selectedIndex = dgvShiftTiming.CurrentCell.RowIndex;
                    if (selectedIndex > -1)
                    {
                        dgvShiftTiming.Rows.RemoveAt(selectedIndex);
                        dgvShiftTiming.Refresh();
                    }
                }
            }      
        }

       

    }
}
