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
    public partial class frmEmployeeLeaveRegister : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string EmpID { set; get; }
        public frmEmployeeLeaveRegister()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            dgvLeaveRegister.ColumnCount = 7;
            this.dgvLeaveRegister.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvLeaveRegister.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12);
            dgvLeaveRegister.Columns[0].Name = "Leave Type";
            dgvLeaveRegister.Columns[0].Width = 150;
            dgvLeaveRegister.Columns[0].ReadOnly = true;
            dgvLeaveRegister.Columns[1].Name = "Start Date";
            dgvLeaveRegister.Columns[1].Width = 150;
            dgvLeaveRegister.Columns[1].ReadOnly = true;
            dgvLeaveRegister.Columns[2].Name = "End Date";
            dgvLeaveRegister.Columns[2].Width = 150;
            dgvLeaveRegister.Columns[2].ReadOnly = true;
            dgvLeaveRegister.Columns[3].Name = "Leave Days";
            dgvLeaveRegister.Columns[3].Width = 100;
            dgvLeaveRegister.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLeaveRegister.Columns[3].ReadOnly = true;
            dgvLeaveRegister.Columns[4].Name = "Leave Cause";
            dgvLeaveRegister.Columns[4].Width = 150;
            dgvLeaveRegister.Columns[4].ReadOnly = true;
            dgvLeaveRegister.Columns[5].Name = "Responsibility Holder";
            dgvLeaveRegister.Columns[5].Width = 250;
            dgvLeaveRegister.Columns[5].ReadOnly = true;
            dgvLeaveRegister.Columns[6].Name = "Address";
            dgvLeaveRegister.Columns[6].Width = 207;
            dgvLeaveRegister.Columns[6].ReadOnly = true;
           
        }
        private void LoadEmployeeLeaveDetails(string Year,string Employee)
        {
            dgvLeaveRegister.Rows.Clear();
            int i = 0;
            List<LeaveRO> oPays = hmsSC.GetEmployeeLeaveDetails(Year, Employee).ToList();
            foreach (LeaveRO oPay in oPays)
            {
                dgvLeaveRegister.Rows.Add(1);
                dgvLeaveRegister.Rows[i].Cells[0].Value = oPay.LeaveTypeId;
                dgvLeaveRegister.Rows[i].Cells[1].Value = oPay.StartDate.ToString("dd/MM/yyyy");
                dgvLeaveRegister.Rows[i].Cells[2].Value = oPay.EndDate.ToString("dd/MM/yyyy");
                dgvLeaveRegister.Rows[i].Cells[3].Value = oPay.LeaveDays;
                dgvLeaveRegister.Rows[i].Cells[4].Value = oPay.LeaveCause;
                dgvLeaveRegister.Rows[i].Cells[5].Value = oPay.ResponsibilityHolderName;
                dgvLeaveRegister.Rows[i].Cells[6].Value = oPay.Address;               
                i = i + 1;
            }
        }
        private void LoadEmployeeLeaveSummary(string Year,string Employee)
        {
            List<LeaveRO> oPays = hmsSC.GetEmployeeLeaveSummary(Year, Employee).ToList();
            if (oPays.Count > 0)
            {
                foreach (LeaveRO oPay in oPays)
                {
                    lblCas.Text = oPay.Casual.ToString();
                    lblMed.Text = oPay.Medical.ToString();
                    lblEar.Text = oPay.Earn.ToString();
                    lblMat.Text = oPay.Maternity.ToString();
                    lblPat.Text = oPay.Paternity.ToString();
                    lblCasEnj.Text = oPay.Cas_enj.ToString();
                    lblMedEnj.Text = oPay.Med_enj.ToString();
                    lblEarEnj.Text = oPay.Ear_enj.ToString();
                    lblMatEnj.Text = oPay.Mat_enj.ToString();
                    lblPatEnj.Text = oPay.Pat_enj.ToString();
                    lblCasRem.Text = (Convert.ToDouble(lblCas.Text.ToString()) - Convert.ToDouble(lblCasEnj.Text.ToString())).ToString();
                    lblMedRem.Text = (Convert.ToDouble(lblMed.Text.ToString()) - Convert.ToDouble(lblMedEnj.Text.ToString())).ToString();
                    lblEarRem.Text = (Convert.ToDouble(lblEar.Text.ToString()) - Convert.ToDouble(lblEarEnj.Text.ToString())).ToString();
                    lblMatRem.Text = (Convert.ToDouble(lblMat.Text.ToString()) - Convert.ToDouble(lblMatEnj.Text.ToString())).ToString();
                    lblPatRem.Text = (Convert.ToDouble(lblPat.Text.ToString()) - Convert.ToDouble(lblPatEnj.Text.ToString())).ToString();
                }
            }
            if (oPays.Count == 0)
            {
                List<LeaveRO> oLeavs = hmsSC.GetEmployeeLeaveDays(Year).ToList();
                foreach (LeaveRO oPay in oLeavs)
                {
                    lblCas.Text = oPay.Casual.ToString();
                    lblMed.Text = oPay.Medical.ToString();
                    lblEar.Text = oPay.Earn.ToString();
                    lblMat.Text = oPay.Maternity.ToString();
                    lblPat.Text = oPay.Paternity.ToString();
                    lblCasEnj.Text = oPay.Cas_enj.ToString();
                    lblMedEnj.Text = oPay.Med_enj.ToString();
                    lblEarEnj.Text = oPay.Ear_enj.ToString();
                    lblMatEnj.Text = oPay.Mat_enj.ToString();
                    lblPatEnj.Text = oPay.Pat_enj.ToString();
                    lblCasRem.Text = (Convert.ToDouble(lblCas.Text.ToString()) - Convert.ToDouble(lblCasEnj.Text.ToString())).ToString();
                    lblMedRem.Text = (Convert.ToDouble(lblMed.Text.ToString()) - Convert.ToDouble(lblMedEnj.Text.ToString())).ToString();
                    lblEarRem.Text = (Convert.ToDouble(lblEar.Text.ToString()) - Convert.ToDouble(lblEarEnj.Text.ToString())).ToString();
                    lblMatRem.Text = (Convert.ToDouble(lblMat.Text.ToString()) - Convert.ToDouble(lblMatEnj.Text.ToString())).ToString();
                    lblPatRem.Text = (Convert.ToDouble(lblPat.Text.ToString()) - Convert.ToDouble(lblPatEnj.Text.ToString())).ToString();
                }
            }

        }
        private void frmEmployeeLeaveRegister_Load(object sender, EventArgs e)
        {
            FormatGrid();
            if(EmpID !=null)
            {
                LoadEmployeeLeaveSummary(DateTime.Now.ToString("yyyy"), EmpID.ToString());
                LoadEmployeeLeaveDetails(DateTime.Now.ToString("yyyy"), EmpID.ToString());
            }
            if (EmpID == null)
            {
                LoadEmployeeLeaveSummary(DateTime.Now.ToString("yyyy"), Utility.UserId);
                LoadEmployeeLeaveDetails(DateTime.Now.ToString("yyyy"), Utility.UserId);
            }
        }

    }

}
