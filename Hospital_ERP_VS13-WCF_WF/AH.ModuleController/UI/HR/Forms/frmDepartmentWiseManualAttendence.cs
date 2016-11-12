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
    public partial class frmDepartmentWiseManualAttendence : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmDepartmentWiseManualAttendence()
        {
            InitializeComponent();
        }
        private void frmDepartmentWiseManualAttendence_Load(object sender, EventArgs e)
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
        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonth.DisplayMember = "Value";
            cboMonth.ValueMember = "Key";
            cboMonth.DataSource = new BindingSource(hmsSC.GetMonth(cboYear.SelectedValue.ToString()), null);

            cboMonth.Text = DateTime.Now.ToString("MMM-yyyy");
        }
        private void FormatGrid()
        {
            dgvAttendence.ColumnCount = 12;
            this.dgvAttendence.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAttendence.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12);  
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dgvAttendence.Columns.Add(chk);
            chk.HeaderText = "Check Data";
            chk.Name = "chk";
            chk.ReadOnly = true;
            chk.Visible = false;
            dgvAttendence.Columns[0].Name = "ID";
            dgvAttendence.Columns[0].ReadOnly = true;
            dgvAttendence.Columns[0].Width = 50;
            dgvAttendence.Columns[1].Name = "Name";
            dgvAttendence.Columns[1].ReadOnly = true;
            dgvAttendence.Columns[1].Width = 220;
            dgvAttendence.Columns[2].Name = "Designation";
            dgvAttendence.Columns[2].ReadOnly = true;
            dgvAttendence.Columns[2].Width = 200;
            dgvAttendence.Columns[3].Name = "Department";
            dgvAttendence.Columns[3].ReadOnly = true;
            dgvAttendence.Columns[3].Width = 300;
            dgvAttendence.Columns[4].Name = "Month";
            dgvAttendence.Columns[4].ReadOnly = true;
            dgvAttendence.Columns[4].Width = 70;
            dgvAttendence.Columns[5].Name = "Present";
            dgvAttendence.Columns[5].ReadOnly = true;
            dgvAttendence.Columns[5].Width = 80;
            dgvAttendence.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvAttendence.Columns[6].Name = "Total Leave";
            dgvAttendence.Columns[6].ReadOnly = false;
            dgvAttendence.Columns[6].Width = 95;
            ((DataGridViewTextBoxColumn)dgvAttendence.Columns[6]).MaxInputLength = 2; 
            dgvAttendence.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvAttendence.Columns[7].Name = "With Pay";
            dgvAttendence.Columns[7].ReadOnly = false;
            dgvAttendence.Columns[7].Width = 100;
            ((DataGridViewTextBoxColumn)dgvAttendence.Columns[7]).MaxInputLength = 2; 
            dgvAttendence.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvAttendence.Columns[8].Name = "Without Pay";
            dgvAttendence.Columns[8].ReadOnly = false;
            dgvAttendence.Columns[8].Width = 100;
            ((DataGridViewTextBoxColumn)dgvAttendence.Columns[8]).MaxInputLength = 2; 
            dgvAttendence.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvAttendence.Columns[9].Name = "Absent";
            dgvAttendence.Columns[9].ReadOnly = false;
            dgvAttendence.Columns[9].Width = 90;
            ((DataGridViewTextBoxColumn)dgvAttendence.Columns[9]).MaxInputLength = 2; 
            dgvAttendence.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvAttendence.Columns[10].Visible = false;
            dgvAttendence.Columns[11].Name = "Working Days";
            dgvAttendence.Columns[11].ReadOnly = true;
            dgvAttendence.Columns[11].Width = 120;
            dgvAttendence.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }

        private void LoadGridView(string Mode,string DeptGrp,string Dept,string Unit,string Month, string Year)
        {
            dgvAttendence.Rows.Clear();
            int i = 0;
            List<Attendence> oAttendences = new List<Attendence>();
            oAttendences = hmsSC.ShowAttendence(Mode.ToString(),cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboYear.SelectedValue.ToString()).ToList();
            if (oAttendences.Count > 0)
            {
                foreach (Attendence oAttendence in oAttendences)
                {
                    dgvAttendence.Rows.Add(1);                                     
                    dgvAttendence.Rows[i].Cells[0].Value = oAttendence.EmpId;
                    dgvAttendence.Rows[i].Cells[1].Value = oAttendence.Name;
                    dgvAttendence.Rows[i].Cells[2].Value = oAttendence.DesigId;
                    dgvAttendence.Rows[i].Cells[3].Value = oAttendence.FormatDept;
                    dgvAttendence.Rows[i].Cells[4].Value = oAttendence.SalCycleId;
                    dgvAttendence.Rows[i].Cells[5].Value = oAttendence.PresentDays;
                    dgvAttendence.Rows[i].Cells[6].Value = oAttendence.LeaveDays;
                    dgvAttendence.Rows[i].Cells[7].Value = oAttendence.LeaveWithPayDays;
                    dgvAttendence.Rows[i].Cells[8].Value = oAttendence.LeaveWithoutPayDays;
                    dgvAttendence.Rows[i].Cells[9].Value = oAttendence.AbsentDays;
                    dgvAttendence.Rows[i].Cells[10].Value = oAttendence.CheckBox;
                    dgvAttendence.Rows[i].Cells[11].Value = oAttendence.WorkingDays;
                    i = i + 1;
                }
            }           
        }
        private bool Validation()
        {
            for (int i = 0; i < dgvAttendence.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvAttendence.Rows[i].Cells[9].Value) > Convert.ToInt32(dgvAttendence.Rows[i].Cells[5].Value))
                {
                    dgvAttendence.Rows[i].Cells[9].Value = 0;                    
                    return true;
                }
            }
                return false;
        }
        private bool CheckLeave()
        {
            for (int i = 0; i < dgvAttendence.Rows.Count; i++)
            {
                if ((Convert.ToInt32(dgvAttendence.Rows[i].Cells[7].Value) + Convert.ToInt32(dgvAttendence.Rows[i].Cells[8].Value)) != Convert.ToInt32(dgvAttendence.Rows[i].Cells[6].Value))
                {                    
                    return true;
                }
            }
            return false;
        }
      
        private Attendence PopulateAttendence()
        {
            Attendence oAttendence = new Attendence();         
            int j;
            string string1 = "";
            for (j = 0; j < dgvAttendence.Rows.Count; j++)
            {              
                    oAttendence.EmpId = dgvAttendence.Rows[j].Cells[0].Value.ToString();
                    oAttendence.Year = cboYear.SelectedValue.ToString();
                    oAttendence.SalCycleId = cboMonth.SelectedValue.ToString();

                    int present = Convert.ToInt32(dgvAttendence.Rows[j].Cells[11].Value) - Convert.ToInt32(dgvAttendence.Rows[j].Cells[9].Value) - Convert.ToInt32(dgvAttendence.Rows[j].Cells[6].Value);
                    string1 += dgvAttendence.Rows[j].Cells[0].Value.ToString() + ":" + 
                               dgvAttendence.Rows[j].Cells[9].Value.ToString() + ":" + 
                               present + ":" + 
                               dgvAttendence.Rows[j].Cells[7].Value.ToString() + ":" + 
                               dgvAttendence.Rows[j].Cells[8].Value.ToString() + ":" + ";";

                    EntryParameter ep = new EntryParameter();
                    ep.EntryBy = Utility.UserId;
                    ep.UpdateBy = Utility.UserId;
                    ep.CompanyID = Utility.CompanyID;
                    ep.LocationID = Utility.LocationID;
                    ep.MachineID = Utility.MachineID;
                    oAttendence.EntryParameter = ep;
            }
            oAttendence.AbsentString = string1;
            return oAttendence;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dgvAttendence.Rows.Count==0)
            {
                MessageBox.Show("No Records Found to Save..",Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (Validation() == true)
                {
                    MessageBox.Show("Absent Days Cannot be Greater Than Present Days!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //if(CheckLeave()==true)
                //{
                //    MessageBox.Show("Please Recheck Total Leave Days", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                    Attendence oAttendence = this.PopulateAttendence();                  
                     string i = hmsSC.SaveUpdatedAttendence(oAttendence);
                        if (i != "0")
                        {
                            MessageBox.Show(i, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i == "0")
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.btnShow_Click(sender, e);
                            //LoadGridView(Mode.ToString(),cboDepartmentGroup.SelectedValue.ToString(),cboDepartment.SelectedValue.ToString(),cboUnit.SelectedValue.ToString(),cboMonth.SelectedValue.ToString(), cboYear.SelectedValue.ToString());
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
       
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.btnShow_Click(sender, e);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvAttendence.Rows.Clear();
        }

        private void dgvAttendence_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            try
            {
                for (i = 0; i < dgvAttendence.Rows.Count; i++)
                {                 
                    if (Convert.ToInt32(dgvAttendence.Rows[i].Cells[9].Value) < 0)
                    {
                        dgvAttendence.Rows[i].Cells[10].Value = false;
                    }
                    else
                    {
                        dgvAttendence.Rows[i].Cells[10].Value = true;
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

        private void cboDepartmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentType.SelectedValue != null)
            {
                cboDepartmentGroup.DisplayMember = "Value";
                cboDepartmentGroup.ValueMember = "Key";
                cboDepartmentGroup.DataSource = new BindingSource(hmsSC.GetDeptGroupDicByType(cboDepartmentType.SelectedValue.ToString()), null);
            }
        }
        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(sender, e);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {           
            if (rdoAll.Checked == true)
            {
                LoadGridView("A", cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboYear.SelectedValue.ToString());
            }
            if (rdoDeptGrp.Checked == true)
            {
                LoadGridView("B", cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboYear.SelectedValue.ToString());
            }
            if (rdoGrpDeptUnit.Checked == true)
            {
                LoadGridView("C", cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboYear.SelectedValue.ToString());
            }
        }

        private void dgvAttendence_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9)
            {              
                    double i;
                    if (!double.TryParse(Convert.ToString(e.FormattedValue), out i))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Please Enter Numeric Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
        }
    }
}
