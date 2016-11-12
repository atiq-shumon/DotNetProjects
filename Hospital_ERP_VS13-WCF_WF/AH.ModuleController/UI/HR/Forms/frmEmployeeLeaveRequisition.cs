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
    public partial class frmEmployeeLeaveRequisition : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmEmployeeLeaveRequisition()
        {
            InitializeComponent();
        }

        private void frmEmployeeLeaveRegister_Load(object sender, EventArgs e)
        {
            FormatGrid();
            RefreshGrid();

            cboYear.DisplayMember = "Value";
            cboYear.ValueMember = "Key";
            cboYear.DataSource = new BindingSource(Utility.GetNumbers(2015, 2030), null);
            cboYear.Text = DateTime.Now.ToString("yyyy");

            cboLeaveType.DisplayMember = "Value";
            cboLeaveType.ValueMember = "Key";
            cboLeaveType.DataSource = new BindingSource(hmsSC.GetLeaveID("D"), null);

            cboLeaveCause.DisplayMember = "Value";
            cboLeaveCause.ValueMember = "Key";
            cboLeaveCause.DataSource = new BindingSource(Utility.GetLeaveCauses(), null);
            txtEmp.Focus();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<SalaryCycle> oSal = hmsSC.GetMonthByYear(cboYear.SelectedValue.ToString()).ToList();
            if (oSal.Count > 0)
            {
                cboMonth.DisplayMember = "Month";
                cboMonth.ValueMember = "Month";
                cboMonth.DataSource = oSal;

                cboMonth.Text = DateTime.Now.ToString("MMM-yyyy");
            }
            else
                cboMonth.DataSource = null;
        }
        private EmpLeaveRegister PopulateLeaveRegister()
        {
            EmpLeaveRegister oEmpLeaveRegis = new EmpLeaveRegister();

            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtEmp.Text);

            if (txtEmp.Text == oEmpMas.EmpId)
            {
                oEmpMas.EmpId = txtEmp.Text;
                oEmpLeaveRegis.EmployeeMaster = oEmpMas;
                oEmpLeaveRegis.year = cboYear.SelectedValue.ToString();
                oEmpLeaveRegis.SalCycleId = cboMonth.SelectedValue.ToString();

                LeaveType oLvTp = new LeaveType();
                oLvTp.TypeID = cboLeaveType.SelectedValue.ToString();
                oEmpLeaveRegis.LeaveType = oLvTp;

                if (txtStartDate.Text != "  /  /")
                {
                    oEmpLeaveRegis.StartDate = DateTime.ParseExact(txtStartDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
                }
                else
                {
                    oEmpLeaveRegis.StartDate = null;
                }
                if (txtEndDate.Text != "  /  /")
                {
                    oEmpLeaveRegis.EndDate = DateTime.ParseExact(txtEndDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
                }
                else
                {
                    oEmpLeaveRegis.EndDate = null;
                }
                oEmpLeaveRegis.LeaveCauseFlag = cboLeaveCause.SelectedValue.ToString();
                oEmpLeaveRegis.AddrtessWhileOnLeave = txtAddress.Text;
                oEmpLeaveRegis.ResponsibilityHolderID = cboResponsibility.SelectedValue.ToString();
                oEmpLeaveRegis.ReportingPersonID = "";
                oEmpLeaveRegis.ApprovedByID = "";
                oEmpLeaveRegis.ApprovedByHR = "";
                oEmpLeaveRegis.ReptPrsnAppFlag = "0";
                oEmpLeaveRegis.DeptAppFlag = "0";
                oEmpLeaveRegis.HrAppFlag = "0";
                oEmpLeaveRegis.NotificationFlag = "0";
                oEmpLeaveRegis.CancelCauseRptPrsn = "0";
                oEmpLeaveRegis.CancelCauseID = "0";
                oEmpLeaveRegis.CancelCauseIDHr = "0";
                oEmpLeaveRegis.Remarks = " ";
                oEmpLeaveRegis.RemarksHR = " ";
                oEmpLeaveRegis.LeaveDocPath = "C";
                

                EntryParameter ep = new EntryParameter();
                ep.CompanyID = Utility.CompanyID;
                ep.EntryBy = Utility.UserId;
                ep.UpdateBy = Utility.UserId;
                ep.LocationID = Utility.LocationID;
                ep.MachineID = Utility.MachineID;
                oEmpLeaveRegis.EntryParameter = ep;
            }
            else
            {
                MessageBox.Show("Invalid EmployeeID", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return oEmpLeaveRegis;
        }

        private void RefreshGrid()
        {
            if (txtEmp.Text != "")
            {
                LoadListView(txtEmp.Text);
            }
        }
        private void FormatGrid()
        {
            lvEmpLeaveRegis.CheckBoxes = false;
            lvEmpLeaveRegis.Columns.Add("EmpId", 0, HorizontalAlignment.Left);
            lvEmpLeaveRegis.Columns.Add("Employee", 250, HorizontalAlignment.Left);
            lvEmpLeaveRegis.Columns.Add("Year", 70, HorizontalAlignment.Center);
            lvEmpLeaveRegis.Columns.Add("Leave Type", 100, HorizontalAlignment.Left);
            lvEmpLeaveRegis.Columns.Add("Start Date", 100, HorizontalAlignment.Center);
            lvEmpLeaveRegis.Columns.Add("End Date", 100, HorizontalAlignment.Center);
            lvEmpLeaveRegis.Columns.Add("Leave Cause", 0, HorizontalAlignment.Center);
            lvEmpLeaveRegis.Columns.Add("Address", 200, HorizontalAlignment.Left);
            lvEmpLeaveRegis.Columns.Add("Responsibility Holder ID", 0, HorizontalAlignment.Left);
            lvEmpLeaveRegis.Columns.Add("Responsibility Holder", 200, HorizontalAlignment.Left);
            lvEmpLeaveRegis.Columns.Add("Serial", 0, HorizontalAlignment.Left);
        }

        private void LoadListView(string oLvRegis)
        {
            lvEmpLeaveRegis.Items.Clear();
            List<EmpLeaveRegister> oEmpLvRegis = hmsSC.GetLeaveRegister(txtEmp.Text).ToList();
            foreach (EmpLeaveRegister oEmpLvReg in oEmpLvRegis)
            {
                ListViewItem itm = new ListViewItem(oEmpLvReg.EmployeeMaster.EmpId);
                itm.SubItems.Add(oEmpLvReg.EmployeeMaster.Name);
                itm.SubItems.Add(oEmpLvReg.year);
                itm.SubItems.Add(oEmpLvReg.LeaveType.TypeID);
                itm.SubItems.Add(oEmpLvReg.StartDate.ToString());
                itm.SubItems.Add(oEmpLvReg.EndDate.ToString());
                itm.SubItems.Add(oEmpLvReg.LeaveCauseFlag);
                itm.SubItems.Add(oEmpLvReg.AddrtessWhileOnLeave);
                itm.SubItems.Add(oEmpLvReg.ResponsibilityHolderID);
                itm.SubItems.Add(oEmpLvReg.ResponsibilityHolderName);
                itm.SubItems.Add(oEmpLvReg.Serial);  
                lvEmpLeaveRegis.Items.Add(itm);
            }
        }
        private void lvEmpLeaveRegis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmpLeaveRegis.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvEmpLeaveRegis.SelectedItems[0];        
                txtEmp.Text = itm.SubItems[0].Text;
                cboYear.Text = itm.SubItems[2].Text;
                cboLeaveType.Text = itm.SubItems[3].Text;
                txtStartDate.Text = itm.SubItems[4].Text;
                txtEndDate.Text = itm.SubItems[5].Text;
                cboLeaveCause.SelectedValue = itm.SubItems[6].Text.ToString();
                txtAddress.Text = itm.SubItems[7].Text;
                cboResponsibility.SelectedValue = itm.SubItems[8].Text.ToString();
                txtserial.Text = itm.SubItems[10].Text.ToString();
            }         
        }
        private void txtEmp_Leave(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtEmp.Text);
            if (txtEmp.Text == "")
            {
                lblInfo.Text = "";
                return;
            }
            if (txtEmp.Text != "")
            {
                if (txtEmp.Text == oEmpMas.EmpId)
                {

                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Designation.DesignationId.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Department.DepartmentTitle.ToString();
                    lblDeptId.Text = oEmpMas.Department.DepartmentID;
                    txtReportingPersonID.Text = oEmpMas.EmployeeJobInformation.ReportingPerson.ToString();
                    txtReportingPersonTitle.Text = oEmpMas.EmployeeJobInformation.ReportingPersonName.ToString();
                    txtDeptHeadID.Text = oEmpMas.EmployeeJobInformation.DeptHead.ToString();
                    txtDeptHeadTitle.Text = oEmpMas.EmployeeJobInformation.DeptHeadName.ToString();
                    if (lblDeptId.Text != "")
                    {
                        cboResponsibility.DisplayMember = "Value";
                        cboResponsibility.ValueMember = "Key";
                        cboResponsibility.DataSource = new BindingSource(hmsSC.GetEmployeeDic(lblDeptId.Text.ToString()), null);
                    }

                }

                else
                {
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadListView(txtEmp.Text);
        }

        private void lvEmpLeaveRegis_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            lblInfo.Text = "";
            txtStartDate.Text = null;
            txtEndDate.Text = null;
            if (lvEmpLeaveRegis.Items.Count > 0)
            {
                lvEmpLeaveRegis.Items.Clear();
            }
        }
   
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmp", "cboYear", "cboMonth", "cboLeaveType", "cboLeaveCause", "txtStartDate", "txtEndDate", "txtAddress", "cboResponsibility" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (txtStartDate.Text == "  /  /" || txtEndDate.Text == "  /  /")
            {
                MessageBox.Show("Date cannot be empty");
                return;
            }
            try
            {
                    EmpLeaveRegister oEmpLvRegis = this.PopulateLeaveRegister();                
                      string i = hmsSC.SaveEmpLeaveRegister(oEmpLvRegis);

                      if (i != "0")
                      {
                          MessageBox.Show(i, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      }
                      else if (i == "0")
                      {
                          MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                          RefreshGrid();
                          btnSearch_Click(sender, e);
                          txtStartDate.Text = null;
                          txtEndDate.Text = null;
                          txtAddress.Text = "";
                         
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

        private EmpLeaveRegister UpdateLeaveRegister()
        {     
            EmpLeaveRegister oEmpLeaveRegis = new EmpLeaveRegister();

            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtEmp.Text);

            if (txtEmp.Text == oEmpMas.EmpId)
            {
                oEmpLeaveRegis.Mode = "0";
                oEmpMas.EmpId = txtEmp.Text;
                oEmpLeaveRegis.EmployeeMaster = oEmpMas;
                oEmpLeaveRegis.year = cboYear.SelectedValue.ToString();

                LeaveType oLvTp = new LeaveType();
                oLvTp.TypeID = cboLeaveType.SelectedValue.ToString();
                oEmpLeaveRegis.LeaveType = oLvTp;

                if (txtStartDate.Text != "  /  /")
                {
                    oEmpLeaveRegis.StartDate = DateTime.ParseExact(txtStartDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
                }
                else
                {
                    oEmpLeaveRegis.StartDate = null;
                }
                if (txtEndDate.Text != "  /  /")
                {
                    oEmpLeaveRegis.EndDate = DateTime.ParseExact(txtEndDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
                }
                else
                {
                    oEmpLeaveRegis.EndDate = null;
                }
                oEmpLeaveRegis.LeaveCauseFlag = cboLeaveCause.SelectedValue.ToString();
                oEmpLeaveRegis.AddrtessWhileOnLeave = txtAddress.Text;
                oEmpLeaveRegis.ResponsibilityHolderID = cboResponsibility.SelectedValue.ToString();
                oEmpLeaveRegis.ReportingPersonID = "";
                oEmpLeaveRegis.ApprovedByID = "";
                oEmpLeaveRegis.ApprovedByHR = "";
                oEmpLeaveRegis.ReptPrsnAppFlag = "0";
                oEmpLeaveRegis.DeptAppFlag = "0";
                oEmpLeaveRegis.HrAppFlag = "0";
                oEmpLeaveRegis.NotificationFlag = "0";
                oEmpLeaveRegis.CancelCauseRptPrsn = " ";
                oEmpLeaveRegis.CancelCauseID = " ";
                oEmpLeaveRegis.CancelCauseIDHr = " ";
                oEmpLeaveRegis.Remarks = " ";
                oEmpLeaveRegis.RemarksHR = " ";
                oEmpLeaveRegis.LeaveDocPath = "C";
                oEmpLeaveRegis.Serial = txtserial.Text.ToString();

                EntryParameter ep = new EntryParameter();
                ep.CompanyID = Utility.CompanyID;
                ep.EntryBy = Utility.UserId;
                ep.UpdateBy = Utility.UserId;
                ep.LocationID = Utility.LocationID;
                ep.MachineID = Utility.MachineID;
                oEmpLeaveRegis.EntryParameter = ep;

            }
            else
            {
                MessageBox.Show("Invalid EmployeeID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return oEmpLeaveRegis;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmp", "cboYear", "cboMonth", "cboLeaveType", "cboLeaveCause", "txtStartDate", "txtEndDate", "txtAddress", "cboResponsibility" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
                EmpLeaveRegister oEmpLeaveRegis = this.UpdateLeaveRegister();
                short i = hmsSC.UpdateLeaveRegister(oEmpLeaveRegis);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    btnSearch_Click(sender, e);
                    txtStartDate.Text = null;
                    txtEndDate.Text = null;
                    txtAddress.Text = "";
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.EmployeeLeaveRegister;
            vr.ViewReport();
        }

        private void txtAddress_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.isEnterTabAllow = false;
            }
            else
            {
                this.isEnterTabAllow = true;
            }
        }
    }
}
