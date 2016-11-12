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
    public partial class frmLeaveRequestListOfHR : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string EmpId { set; get; }
        public frmLeaveRequestListOfHR()
        {
            InitializeComponent();
        }
        private void frmLeaveRequestListOfHR_Load(object sender, EventArgs e)
        {
            txtApprovedByID.Text = Utility.UserId;
            txtApprovedName.Text = Utility.UserName;
            FormatGrid();
            LoadGridView();
        }
        private void FormatGrid()
        {
            dgvLeaveReqstList.ColumnCount = 29;
            this.dgvLeaveReqstList.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvLeaveReqstList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvLeaveReqstList.Columns[0].Name = "ID";
            dgvLeaveReqstList.Columns[0].Width = 50;
            dgvLeaveReqstList.Columns[0].ReadOnly = true;

            dgvLeaveReqstList.Columns[1].Name = "Name";
            dgvLeaveReqstList.Columns[1].Width = 210;
            dgvLeaveReqstList.Columns[1].ReadOnly = true;

            dgvLeaveReqstList.Columns[2].Name = "Dept Grp";
            dgvLeaveReqstList.Columns[2].Width = 0;
            dgvLeaveReqstList.Columns[2].ReadOnly = true;
            dgvLeaveReqstList.Columns[2].Visible = false;

            dgvLeaveReqstList.Columns[3].Name = "Dept";
            dgvLeaveReqstList.Columns[3].Width = 0;
            dgvLeaveReqstList.Columns[3].ReadOnly = true;
            dgvLeaveReqstList.Columns[3].Visible = false;

            dgvLeaveReqstList.Columns[4].Name = "Unit";
            dgvLeaveReqstList.Columns[4].Width = 0;
            dgvLeaveReqstList.Columns[4].ReadOnly = true;
            dgvLeaveReqstList.Columns[4].Visible = false;

            dgvLeaveReqstList.Columns[5].Name = "Department";
            dgvLeaveReqstList.Columns[5].Width = 300;
            dgvLeaveReqstList.Columns[5].ReadOnly = true;

            dgvLeaveReqstList.Columns[6].Name = "Designation";
            dgvLeaveReqstList.Columns[6].Width = 200;
            dgvLeaveReqstList.Columns[6].ReadOnly = true;

            dgvLeaveReqstList.Columns[7].Name = "Year";
            dgvLeaveReqstList.Columns[7].Width = 50;
            dgvLeaveReqstList.Columns[7].ReadOnly = true;

            dgvLeaveReqstList.Columns[8].Name = "Leave ID";
            dgvLeaveReqstList.Columns[8].Width = 0;
            dgvLeaveReqstList.Columns[8].Visible = false;

            dgvLeaveReqstList.Columns[9].Name = "Leave Title";
            dgvLeaveReqstList.Columns[9].Width = 100;
            dgvLeaveReqstList.Columns[9].ReadOnly = true;

            dgvLeaveReqstList.Columns[10].Name = "Start Date";
            dgvLeaveReqstList.Columns[10].Width = 90;
            dgvLeaveReqstList.Columns[10].ReadOnly = true;

            dgvLeaveReqstList.Columns[11].Name = "End Date";
            dgvLeaveReqstList.Columns[11].Width = 90;
            dgvLeaveReqstList.Columns[11].ReadOnly = true;

            dgvLeaveReqstList.Columns[12].Name = "Days";
            dgvLeaveReqstList.Columns[12].Width = 50;
            dgvLeaveReqstList.Columns[12].ReadOnly = true;
            dgvLeaveReqstList.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

            dgvLeaveReqstList.Columns[13].Name = "Leave Cause";
            dgvLeaveReqstList.Columns[13].Width = 0;
            dgvLeaveReqstList.Columns[13].Visible = false;

            dgvLeaveReqstList.Columns[14].Name = "Address";
            dgvLeaveReqstList.Columns[14].Width = 0;
            dgvLeaveReqstList.Columns[14].Visible = false;

            dgvLeaveReqstList.Columns[15].Name = "Responsibility Holder";
            dgvLeaveReqstList.Columns[15].Width = 0;
            dgvLeaveReqstList.Columns[15].Visible = false;

            dgvLeaveReqstList.Columns[16].Name = "Approved By Reporting Person";
            dgvLeaveReqstList.Columns[16].Width = 0;
            dgvLeaveReqstList.Columns[16].Visible = false;

            dgvLeaveReqstList.Columns[17].Name = "Approved By Head";
            dgvLeaveReqstList.Columns[17].Width = 0;
            dgvLeaveReqstList.Columns[17].Visible = false;

            dgvLeaveReqstList.Columns[18].Name = "Approved By HR";
            dgvLeaveReqstList.Columns[18].Width = 0;
            dgvLeaveReqstList.Columns[18].Visible = false;

            dgvLeaveReqstList.Columns[19].Name = "Rpt Prsn Appr Flag";
            dgvLeaveReqstList.Columns[19].Width = 0;
            dgvLeaveReqstList.Columns[19].Visible = false;

            dgvLeaveReqstList.Columns[20].Name = "Dept Appr Flag";
            dgvLeaveReqstList.Columns[20].Width = 0;
            dgvLeaveReqstList.Columns[20].Visible = false;

            dgvLeaveReqstList.Columns[21].Name = "HR Appr Flag";
            dgvLeaveReqstList.Columns[21].Width = 0;
            dgvLeaveReqstList.Columns[21].Visible = false;

            dgvLeaveReqstList.Columns[22].Name = "Cancel Cause Rpt Prsn";
            dgvLeaveReqstList.Columns[22].Width = 0;
            dgvLeaveReqstList.Columns[22].Visible = false;

            dgvLeaveReqstList.Columns[23].Name = "Cancel Cause Head";
            dgvLeaveReqstList.Columns[23].Width = 0;
            dgvLeaveReqstList.Columns[23].Visible = false;

            dgvLeaveReqstList.Columns[24].Name = "Cancel Cause HR";
            dgvLeaveReqstList.Columns[24].Width = 0;
            dgvLeaveReqstList.Columns[24].Visible = false;

            dgvLeaveReqstList.Columns[25].Name = "Remarks Head";
            dgvLeaveReqstList.Columns[25].Width = 0;
            dgvLeaveReqstList.Columns[25].Visible = false;

            dgvLeaveReqstList.Columns[26].Name = "Remarks HR";
            dgvLeaveReqstList.Columns[26].Width = 0;
            dgvLeaveReqstList.Columns[26].Visible = false;

            dgvLeaveReqstList.Columns[27].Name = "Serial";
            dgvLeaveReqstList.Columns[27].Width = 0;
            dgvLeaveReqstList.Columns[27].Visible = false;

            dgvLeaveReqstList.Columns[28].Name = "Responsibility Holder";
            dgvLeaveReqstList.Columns[28].Visible = false;
            dgvLeaveReqstList.Columns[28].ReadOnly = true;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvLeaveReqstList.Columns.Add(btn);
            btn.HeaderText = "History";
            btn.Text = "Show History";
            btn.Name = "btn";
            btn.DefaultCellStyle.ForeColor = Color.Navy;
            btn.UseColumnTextForButtonValue = true;
            btn.Width = 100;

            DataGridViewButtonColumn btnApp = new DataGridViewButtonColumn();
            dgvLeaveReqstList.Columns.Add(btnApp);
            btnApp.HeaderText = "Approval";
            btnApp.Text = "Approved Form";
            btnApp.Name = "btnApp";
            btnApp.DefaultCellStyle.ForeColor = Color.Navy;
            btnApp.UseColumnTextForButtonValue = true;
            btnApp.Width = 100;
        }

       private void LoadGridView()
       {
           dgvLeaveReqstList.Rows.Clear();
           int i = 0;
           List<LeaveRO> oPays = hmsSC.GetLeaveRequestListHR().ToList();
           foreach (LeaveRO oPay in oPays)
           {
               dgvLeaveReqstList.Rows.Add(1);
               dgvLeaveReqstList.Rows[i].Cells[0].Value = oPay.EmpId;
               dgvLeaveReqstList.Rows[i].Cells[1].Value = oPay.EmpName;
               dgvLeaveReqstList.Rows[i].Cells[2].Value = oPay.DeptGrpTitle;
               dgvLeaveReqstList.Rows[i].Cells[3].Value = oPay.DeptId;
               dgvLeaveReqstList.Rows[i].Cells[4].Value = oPay.UnitId;
               dgvLeaveReqstList.Rows[i].Cells[5].Value = oPay.FormatDept;
               dgvLeaveReqstList.Rows[i].Cells[6].Value = oPay.DesigId;
               dgvLeaveReqstList.Rows[i].Cells[7].Value = oPay.year;
               dgvLeaveReqstList.Rows[i].Cells[8].Value = oPay.LeaveTypeId;
               dgvLeaveReqstList.Rows[i].Cells[9].Value = oPay.LeaveTypeTitle;
               dgvLeaveReqstList.Rows[i].Cells[10].Value = oPay.StartDate.ToString("dd/MM/yyyy");
               dgvLeaveReqstList.Rows[i].Cells[11].Value = oPay.EndDate.ToString("dd/MM/yyyy");
               dgvLeaveReqstList.Rows[i].Cells[12].Value = oPay.LeaveDays;
               dgvLeaveReqstList.Rows[i].Cells[13].Value = oPay.LeaveCause;
               dgvLeaveReqstList.Rows[i].Cells[14].Value = oPay.Address;
               dgvLeaveReqstList.Rows[i].Cells[15].Value = oPay.ResponsibilityHolder;
               dgvLeaveReqstList.Rows[i].Cells[16].Value = oPay.ApprovedByRptPrsn;
               dgvLeaveReqstList.Rows[i].Cells[17].Value = oPay.ApprovedByHead;
               dgvLeaveReqstList.Rows[i].Cells[18].Value = oPay.ApprovedByHR;
               dgvLeaveReqstList.Rows[i].Cells[19].Value = oPay.RptPrsnFlag;
               dgvLeaveReqstList.Rows[i].Cells[20].Value = oPay.DeptFlag;
               dgvLeaveReqstList.Rows[i].Cells[21].Value = oPay.HrFlag;
               dgvLeaveReqstList.Rows[i].Cells[22].Value = oPay.CancelCauseRptPrsn;
               dgvLeaveReqstList.Rows[i].Cells[23].Value = oPay.CancelCauseHead;
               dgvLeaveReqstList.Rows[i].Cells[24].Value = oPay.CancelCauseHR;
               dgvLeaveReqstList.Rows[i].Cells[25].Value = oPay.RemarksHead;
               dgvLeaveReqstList.Rows[i].Cells[26].Value = oPay.RemarksHR;
               dgvLeaveReqstList.Rows[i].Cells[27].Value = oPay.Serial;
               dgvLeaveReqstList.Rows[i].Cells[28].Value = oPay.ResponsibilityHolderName;
               i = i + 1;
           }
           dgvLeaveReqstList.CurrentCell = null;
           dgvLeaveReqstList.ClearSelection();
       }
        private void frmLeaveRequestListOfHR_Activated(object sender, EventArgs e)
        {
            LoadGridView();
        }
        private void dgvLeaveReqstList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvLeaveReqstList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                int i = 0;
                string ColumnName = dgvLeaveReqstList.Columns[0].HeaderCell.Value.ToString();
                string ID = dgvLeaveReqstList.Rows[e.RowIndex].Cells[0].Value.ToString();
                string serial = dgvLeaveReqstList.Rows[e.RowIndex].Cells[27].Value.ToString();
                frmLeaveApproved oPay = new frmLeaveApproved();
                for (i = 0; i < dgvLeaveReqstList.Rows.Count; i++)
                {
                    if (oPay.EmpId != "")
                    {
                        oPay.EmpId = dgvLeaveReqstList.Rows[i].Cells[0].Value.ToString();
                        oPay.LeaveTypeId = dgvLeaveReqstList.Rows[i].Cells[8].Value.ToString();
                        oPay.Flag = dgvLeaveReqstList.Rows[i].Cells[19].Value.ToString();
                        oPay.LeaveSerial = dgvLeaveReqstList.Rows[i].Cells[27].Value.ToString();
                        if (oPay.EmpId == ID && oPay.LeaveSerial == serial)
                        {
                            oPay.ApprovedByHR = txtApprovedByID.Text.ToString();
                            oPay.ApprovedByHRName = txtApprovedName.Text.ToString();
                            oPay.ShowDialog();
                        }
                    }

                }
            }
        }
        private void dgvLeaveReqstList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLeaveReqstList.Columns[e.ColumnIndex].Name == "btn")
            {
                if (dgvLeaveReqstList.CurrentCell != null)
                {
                    int selectedIndex = dgvLeaveReqstList.CurrentCell.RowIndex;
                    if (selectedIndex > -1)
                    {
                        frmEmployeeLeaveRegister oEmployee = new frmEmployeeLeaveRegister();
                        oEmployee.EmpID = dgvLeaveReqstList.Rows[e.RowIndex].Cells[0].Value.ToString();
                        oEmployee.ShowDialog();
                    }
                }
            }

            if (dgvLeaveReqstList.Columns[e.ColumnIndex].Name == "btnApp")
            {
                if (dgvLeaveReqstList.CurrentCell != null)
                {
                    if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvLeaveReqstList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        int i = 0;
                        string ColumnName = dgvLeaveReqstList.Columns[0].HeaderCell.Value.ToString();
                        string ID = dgvLeaveReqstList.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string serial = dgvLeaveReqstList.Rows[e.RowIndex].Cells[27].Value.ToString();
                        frmLeaveApproved oPay = new frmLeaveApproved();
                        for (i = 0; i < dgvLeaveReqstList.Rows.Count; i++)
                        {
                            if (oPay.EmpId != "")
                            {
                                oPay.EmpId = dgvLeaveReqstList.Rows[i].Cells[0].Value.ToString();
                                oPay.LeaveTypeId = dgvLeaveReqstList.Rows[i].Cells[8].Value.ToString();
                                oPay.Flag = dgvLeaveReqstList.Rows[i].Cells[19].Value.ToString();
                                oPay.LeaveSerial = dgvLeaveReqstList.Rows[i].Cells[27].Value.ToString();
                                if (oPay.EmpId == ID && oPay.LeaveSerial == serial)
                                {
                                    oPay.ApprovedByHR = txtApprovedByID.Text.ToString();
                                    oPay.ApprovedByHRName = txtApprovedName.Text.ToString();
                                    oPay.ShowDialog();
                                }
                            }

                        }
                    }
                }
            }    
        }

          
    }
}
