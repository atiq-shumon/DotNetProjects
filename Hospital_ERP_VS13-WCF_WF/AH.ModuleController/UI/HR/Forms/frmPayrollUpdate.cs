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

namespace AH.ModuleController.UI.HR.Forms
{

    public partial class frmPayrollUpdate : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string EmpId { set; get; }
        public string Gross { set; get; }
        public string DeptType { set; get; }
        public string DeptGrp { set; get; }
        public string Dept { set; get; }
        public string Unit { set; get; }
        public string Month { set; get; }

        public frmPayrollUpdate()
        {
            InitializeComponent();
        }

        private void frmPayrollUpdate_Load(object sender, EventArgs e)
        {
            FormatGrid();
            
            cboYear.DisplayMember = "Value";
            cboYear.ValueMember = "Key";
            cboYear.DataSource = new BindingSource(Utility.GetNumbers(2010, 2025), null);

            cboYear.Text = DateTime.Now.ToString("yyyy");

            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);

            RefreshGrid(); 
                             
        }

        private void FormatGrid()
        {
            dgvPayroll.ColumnCount = 4;
            this.dgvPayroll.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvPayroll.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12);
            dgvPayroll.Columns[0].Name = "Head Title";
            dgvPayroll.Columns[0].Width = 150;
            dgvPayroll.Columns[1].Name = "Amount";
            dgvPayroll.Columns[1].Width = 193;
            dgvPayroll.Columns[2].Name = "Head Type";
            dgvPayroll.Columns[2].Width = 0;
            dgvPayroll.Columns[2].Visible = false;
            dgvPayroll.Columns[3].Name = "Id";
            dgvPayroll.Columns[3].Width = 0;
            dgvPayroll.Columns[3].Visible = false;
        }
        private void LoadGridView(string Emp,string DeptGrp,string Dept,string Unit,string Month, string Year)
        {
            dgvPayroll.Rows.Clear();
            int i = 0;
            double gr = 0;
            List<PayrollRO> oPays = new List<PayrollRO>();
            oPays = hmsSC.GetPayrollForUpdate(txtEmpId.Text, cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboYear.SelectedValue.ToString()).ToList();
            if (oPays.Count > 0)
            {
                foreach (PayrollRO oPay in oPays)
                {
                    dgvPayroll.Rows.Add(1);
                    dgvPayroll.Rows[i].Cells[0].Value = oPay.HeadTitle;                  
                    dgvPayroll.Rows[i].Cells[1].Value = oPay.Amount;
                    if (oPay.GradeCOnsFlag == "1")
                    {
                        dgvPayroll.Rows[i].Cells[0].ReadOnly = true;
                        dgvPayroll.Rows[i].Cells[1].ReadOnly = true;
                    }
                    dgvPayroll.Rows[i].Cells[2].Value = oPay.HeadType;
                    if (dgvPayroll.Rows[i].Cells[2].Value.ToString()=="A")
                    {
                        dgvPayroll.Rows[i].Cells[1].Style.BackColor = Color.LightGoldenrodYellow;
                    }
                    if (dgvPayroll.Rows[i].Cells[2].Value.ToString() == "D")
                    {
                        dgvPayroll.Rows[i].Cells[1].Style.BackColor = Color.LightSkyBlue;
                    }
                    dgvPayroll.Rows[i].Cells[3].Value = oPay.SalHeadId;
                    gr = oPay.GrossPay;
                    i = i + 1;
                }              
                txtGross.Text = Convert.ToString(gr);
                txtGross.ReadOnly = true;
            }
            else
            {
                txtGross.Text = "";
            }
        }
        private void RefreshGrid()
        {
            if (EmpId != null)
            {
                txtEmpId.Text = EmpId;
                cboDepartmentType.SelectedValue = DeptType;
                cboDepartmentGroup.SelectedValue = DeptGrp;
                cboDepartment.Text = Dept;
                cboUnit.Text = Unit;
                cboMonth.SelectedValue = Month;
                txtGross.Text = Gross;               
                LoadGridView(txtEmpId.Text,cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(),cboUnit.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboYear.SelectedValue.ToString());
            }
            if (EmpId == null)
            {
                return;
            }
        }
        private PayrollRO PopulatePayroll(string Head,double Amount,string headiid,string HeadType)
        {
            PayrollRO oPay = new PayrollRO();
            oPay.EmpId = txtEmpId.Text;
            oPay.Month= cboMonth.SelectedValue.ToString();
            oPay.HeadTitle = Head.ToString();
            oPay.SalHeadId = headiid.ToString();
            oPay.Amount = Amount;
            oPay.HeadType = HeadType.ToString();
            
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oPay.EntryParameter = ep;

            return oPay;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Head = "";
                double Amount = 0;
                string headiid = "";
                string HeadType = "";
                string i = "";
                List<string> vf = new List<string>() { "cboDepartment" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }
                if (dgvPayroll.Rows.Count == 0)
                {
                    MessageBox.Show("No Records Found for Saving..", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                for (int j = 0; j < dgvPayroll.Rows.Count; j++)
                {
                    Head = dgvPayroll.Rows[j].Cells[0].Value.ToString();
                    Amount = Convert.ToDouble(dgvPayroll.Rows[j].Cells[1].Value.ToString());
                    HeadType = dgvPayroll.Rows[j].Cells[2].Value.ToString();
                    headiid = dgvPayroll.Rows[j].Cells[3].Value.ToString();
                    PopulatePayroll(Head, Amount, headiid, HeadType);
                    PayrollRO oPay = this.PopulatePayroll(Head, Amount, headiid, HeadType);
                    i = hmsSC.SaveUpdatedPayroll(oPay);
                }
                if (i == "0")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (i != "0")
                {
                    MessageBox.Show(i, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPayroll.Rows.Clear();
                }
                LoadGridView(txtEmpId.Text, cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboYear.SelectedValue.ToString());
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
        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {         
                cboMonth.DisplayMember = "Value";
                cboMonth.ValueMember = "Key";
                cboMonth.DataSource = new BindingSource(hmsSC.GetMonth(cboYear.SelectedValue.ToString()), null);
                cboMonth.Text = DateTime.Now.ToString("MMM-yyyy");          
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

            if (txtEmpId.Text != "")
            {
                LoadGridView(txtEmpId.Text, cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), cboMonth.SelectedValue.ToString(), cboYear.SelectedValue.ToString());
            }
        }
     
        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvPayroll.Rows.Clear();
            lblInfo.Text = "";
        }
        private void dgvPayroll_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                double i;

                if (!double.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please Enter Numeric Value", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        private void dgvPayroll_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double Addition = 0;
                double Deduction = 0;
                double Gross = 0;

                for (int i = 0; i < dgvPayroll.Rows.Count - 1; i++)
                {
                    if (dgvPayroll.Rows[i].Cells[1].Value != null)
                    {
                        if (dgvPayroll.Rows[i].Cells[2].Value != null)
                        {
                            if (dgvPayroll.Rows[i].Cells[2].Value.ToString() == "A")
                            {
                                Addition += Convert.ToInt32(dgvPayroll.Rows[i].Cells["Amount"].Value);
                            }
                            if (dgvPayroll.Rows[i].Cells[2].Value.ToString() == "D")
                            {
                                Deduction += Convert.ToInt32(dgvPayroll.Rows[i].Cells["Amount"].Value);
                            }
                            Gross = Addition - Deduction;
                        }
                        txtGross.Text = Convert.ToString(Gross);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(sender, e);
        }

        private void txtEmpId_Leave(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtEmpId.Text);
            if (txtEmpId.Text == "")
            {
                lblInfo.Text = "";
                return;
            }
            if (txtEmpId.Text != "")
            {
                if (txtEmpId.Text == oEmpMas.EmpId)
                {
                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Designation.DesignationId.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Department.DepartmentTitle.ToString();
                }

                else
                {
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmpId.Focus();
                }
            }
        }

       
    }
}
