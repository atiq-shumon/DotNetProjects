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
    public partial class frmAppointmentSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmAppointmentSetup()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> GetAppointmentTemplateType()
        {
            Dictionary<string, string> locAppointment = new Dictionary<string, string>();
            locAppointment.Add("G", "General Employee");
            locAppointment.Add("P", "Physician");
            locAppointment.Add("C", "Contructual");
            locAppointment.Add("D", "Level-D");          
            return locAppointment;
        }

        private void frmAppointmentSetup_Load(object sender, EventArgs e)
        {
            try
            {
                cboAppType.DisplayMember = "Value";
                cboAppType.ValueMember = "Key";
                cboAppType.DataSource = new BindingSource(GetAppointmentTemplateType(), null);

                cboDepartmentType.DisplayMember = "Value";
                cboDepartmentType.ValueMember = "Key";
                cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);

                cboJobType.DisplayMember = "Value";
                cboJobType.ValueMember = "Key";
                cboJobType.DataSource = new BindingSource(Utility.GetJobTypes(), null);

                cboRecruitmentType.DisplayMember = "Value";
                cboRecruitmentType.ValueMember = "Key";
                cboRecruitmentType.DataSource = new BindingSource(Utility.GetRecruitmentTypes(), null);

                FormatGrid();
                RefreshGrid();
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

        private void txtCCList_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void txtAddressBeng_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void txtComplianceWith_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void cboDepartmentGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboDepartmentGroup.SelectedValue != null)
                {
                    cboDepartment.DisplayMember = "Value";
                    cboDepartment.ValueMember = "Key";
                    cboDepartment.DataSource = new BindingSource(hmsSC.GetDepartmentsetupDic(null, cboDepartmentGroup.SelectedValue.ToString()), null);
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

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {  
            try
            {
                if (cboDepartment.SelectedValue != "")
                {
                    cboUnit.DisplayMember = "Value";
                    cboUnit.ValueMember = "Key";
                    cboUnit.DataSource = new BindingSource(Utility.VerifyDic(hmsSC.GetDeptUnitDic(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString())), null);
                }
                cboDesignation.DisplayMember = "Value";
                cboDesignation.ValueMember = "Key";            
                cboDesignation.DataSource = new BindingSource(hmsSC.GetOrganogramDesig(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString()), null);  
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

        private void FormatGrid()
        {
            lvAppointment.CheckBoxes = false;
            lvAppointment.Columns.Add("Template", 100, HorizontalAlignment.Center);
            lvAppointment.Columns.Add("Issue Date", 100, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("Department Type", 0, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("Department Group", 0, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("Department", 0, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("Unit", 0, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("DesigID", 0, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("Designation", 200, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("Job Nature", 0, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("Recruitment Type", 0, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("Contract Period", 100, HorizontalAlignment.Center);
            lvAppointment.Columns.Add("Contract Upto", 100, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("DOJ Within", 100, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("Effect From", 100, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("Consolidate Amt", 150, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("Probation Period", 100, HorizontalAlignment.Center);
            lvAppointment.Columns.Add("Name", 250, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("NameBeng", 0, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("Address", 0, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("AddressBeng", 0, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("Compliance", 0, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("CCList", 0, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("HR Manager", 0, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("PreparedBY", 0, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("HR Manager Name", 0, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("PreparedBYName", 0, HorizontalAlignment.Left);
            lvAppointment.Columns.Add("ReffNumber", 0, HorizontalAlignment.Left);
        }

        private Appointment PopulateAppointmentSetup()
        {
            Appointment oAppointment = new Appointment();
            EmployeeJobInformation oEmpJobInfo = new EmployeeJobInformation();
            oAppointment.RefferenceNumber = txtReffNumber.Text.ToString();
            oAppointment.AppointTemplType = cboAppType.SelectedValue.ToString();
            oAppointment.IssueDate = dtIssueDate.Text.ToString();
            oAppointment.Name = txtName.Text.ToString();
            oAppointment.Address = txtAddress.Text.ToString();
            oAppointment.NameBeng=txtNameBeng.Text.ToString();
            oAppointment.AddressBeng = txtAddressBeng.Text.ToString();

            DepartmentGroup oDeptGrp = new DepartmentGroup();
            oDeptGrp.DepartmentGroupID = cboDepartmentGroup.SelectedValue.ToString();
            oEmpJobInfo.DepartmentGroup = oDeptGrp;

            Department oDept = new Department();
            oDept.DepartmentID = cboDepartment.SelectedValue.ToString();
            oEmpJobInfo.Department = oDept;

            DepartmentUnit oDeptUnit = new DepartmentUnit();
            oDeptUnit.UnitId = cboUnit.SelectedValue.ToString();
            oEmpJobInfo.DepartmentUnit = oDeptUnit;

            Designation oDesig = new Designation();
            oDesig.DesignationId = cboDesignation.SelectedValue.ToString();
            oEmpJobInfo.Designation = oDesig;

            oEmpJobInfo.JobType = cboJobType.SelectedValue.ToString();
            oEmpJobInfo.RecruitmentType = cboRecruitmentType.SelectedValue.ToString();

            oAppointment.EmployeeJobInformation = oEmpJobInfo;

            oAppointment.ContractPeriod = txtContractPeriod.Text.ToString();
            oAppointment.ContractUpto = dtContractUpto.Text.ToString();
            oAppointment.DOJWithin = dtDOJWithin.Text.ToString();
            oAppointment.EffectFrom = dtEffectFrom.Text.ToString();
            oAppointment.ConssolidateAmount = txtConsolidateAmount.Text.ToString();
            oAppointment.ProbationPeriod = txtProbationPeriod.Text.ToString();
            oAppointment.ComplianceWith = txtComplianceWith.Text.ToString();
            oAppointment.CCList = txtCCList.Text.ToString();
            oAppointment.HRManagerID = txtHRManager.Text.ToString();
            oAppointment.PreparedBy = txtPreparedBy.Text.ToString();


            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oAppointment.EntryParameter = ep;
            return oAppointment;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboAppType", "dtIssueDate", "txtName", "txtAddress","cboDepartmentGroup", "cboDepartment", "cboUnit", "cboDesignation", "cboJobType", "cboRecruitmentType", "txtContractPeriod", "dtContractUpto", "dtDOJWithin", "dtEffectFrom", "txtConsolidateAmount", "txtProbationPeriod",  "txtCCList", "txtHRManager", "txtPreparedBy"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dtContractUpto.Text == "  /  /")
            {
                MessageBox.Show("Contract Date cannot be empty");
                dtContractUpto.Focus();
                return;
            }
            if (dtDOJWithin.Text == "  /  /")
            {
                MessageBox.Show("Joining Date cannot be empty");
                dtDOJWithin.Focus();
                return;
            }
            if (dtEffectFrom.Text == "  /  /")
            {
                MessageBox.Show("Job Effective Date cannot be empty");
                dtEffectFrom.Focus();
                return;
            }
            try
            {
                Appointment oAppointment = this.PopulateAppointmentSetup();
                short i = hmsSC.SaveAppointmentSetup(oAppointment);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
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

        private void RefreshGrid()
        {
            LoadListView(txtReffNumber.Text.ToString());
        }

        private void LoadListView(string ReffNumber)
        {
            try
            {
                lvAppointment.Items.Clear();
                List<Appointment> oAppointments = hmsSC.GetAppointmentSetup(txtReffNumber.Text.ToString()).ToList();
                foreach (Appointment oAppointment in oAppointments)
                {
                    ListViewItem itm = new ListViewItem(oAppointment.AppointTemplType);
                    itm.SubItems.Add(oAppointment.IssueDate.ToString());
                    itm.SubItems.Add(oAppointment.EmployeeJobInformation.DepartmentGroup.DepartmentType.TypeID);
                    itm.SubItems.Add(oAppointment.EmployeeJobInformation.DepartmentGroup.DepartmentGroupID);
                    itm.SubItems.Add(oAppointment.EmployeeJobInformation.Department.DepartmentID);
                    itm.SubItems.Add(oAppointment.EmployeeJobInformation.DepartmentUnit.UnitId);
                    itm.SubItems.Add(oAppointment.EmployeeJobInformation.Designation.DesignationId);
                    itm.SubItems.Add(oAppointment.EmployeeJobInformation.Designation.DesignationTitle);
                    itm.SubItems.Add(oAppointment.EmployeeJobInformation.JobType);
                    itm.SubItems.Add(oAppointment.EmployeeJobInformation.RecruitmentType);
                    itm.SubItems.Add(oAppointment.ContractPeriod);
                    itm.SubItems.Add(oAppointment.ContractUpto.ToString());
                    itm.SubItems.Add(oAppointment.DOJWithin);
                    itm.SubItems.Add(oAppointment.EffectFrom);
                    itm.SubItems.Add(oAppointment.ConssolidateAmount);
                    itm.SubItems.Add(oAppointment.ProbationPeriod);
                    itm.SubItems.Add(oAppointment.Name);
                    itm.SubItems.Add(oAppointment.NameBeng);
                    itm.SubItems.Add(oAppointment.Address);
                    itm.SubItems.Add(oAppointment.AddressBeng);
                    itm.SubItems.Add(oAppointment.ComplianceWith);
                    itm.SubItems.Add(oAppointment.CCList);
                    itm.SubItems.Add(oAppointment.HRManagerID);
                    itm.SubItems.Add(oAppointment.PreparedBy);
                    itm.SubItems.Add(oAppointment.HRManagerName);
                    itm.SubItems.Add(oAppointment.PreparedByName);
                    itm.SubItems.Add(oAppointment.RefferenceNumber);
                    lvAppointment.Items.Add(itm);
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadListView(txtReffNumber.Text.ToString());
        }

        private void lvAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAppointment.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvAppointment.SelectedItems[0];
                cboAppType.SelectedValue = itm.SubItems[0].Text;
                dtIssueDate.Text = itm.SubItems[1].Text;
                cboDepartmentType.SelectedValue = itm.SubItems[2].Text;
                cboDepartmentGroup.SelectedValue = itm.SubItems[3].Text;
                cboDepartment.SelectedValue = itm.SubItems[4].Text;
                cboUnit.SelectedValue = itm.SubItems[5].Text;
                cboDesignation.SelectedValue = itm.SubItems[6].Text;
                cboJobType.SelectedValue = itm.SubItems[8].Text;
                cboRecruitmentType.SelectedValue = itm.SubItems[9].Text;
                txtContractPeriod.Text = itm.SubItems[10].Text;
                dtContractUpto.Text = itm.SubItems[11].Text;
                dtDOJWithin.Text = itm.SubItems[12].Text;
                dtEffectFrom.Text = itm.SubItems[13].Text;
                txtConsolidateAmount.Text = itm.SubItems[14].Text;
                txtProbationPeriod.Text = itm.SubItems[15].Text;
                txtName.Text = itm.SubItems[16].Text;
                txtNameBeng.Text = itm.SubItems[17].Text;
                txtAddress.Text = itm.SubItems[18].Text;
                txtAddressBeng.Text = itm.SubItems[19].Text;
                txtComplianceWith.Text = itm.SubItems[20].Text;
                txtCCList.Text = itm.SubItems[21].Text;
                txtHRManager.Text = itm.SubItems[22].Text;
                txtPreparedBy.Text = itm.SubItems[23].Text;
                txtHRManagerName.Text = itm.SubItems[24].Text;
                txtPreparedByName.Text = itm.SubItems[25].Text;
                txtReffNumber.Text = itm.SubItems[26].Text;
            }
        }

        private void lvAppointment_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboAppType", "dtIssueDate", "txtName", "txtAddress", "cboDepartmentGroup", "cboDepartment", "cboUnit", "cboDesignation", "cboJobType", "cboRecruitmentType", "txtContractPeriod", "dtContractUpto", "dtDOJWithin", "dtEffectFrom", "txtConsolidateAmount", "txtProbationPeriod", "txtCCList", "txtHRManager", "txtPreparedBy" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dtContractUpto.Text == "  /  /")
            {
                MessageBox.Show("Contract Date cannot be empty");
                dtContractUpto.Focus();
                return;
            }
            if (dtDOJWithin.Text == "  /  /")
            {
                MessageBox.Show("Joining Date cannot be empty");
                dtDOJWithin.Focus();
                return;
            }
            if (dtEffectFrom.Text == "  /  /")
            {
                MessageBox.Show("Job Effective Date cannot be empty");
                return;
            }
            try
            {
                Appointment oAppointment = this.PopulateAppointmentSetup();
                short i = hmsSC.UpdateAppointmentSetup(oAppointment);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnSearch_Click(sender, e);
                    btnNew.PerformClick();
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

        private void txtHRManager_Leave(object sender, EventArgs e)
        {
            try
            {
                EmployeeMaster oEmpMas = new EmployeeMaster();
                oEmpMas = hmsSC.GetEmpMaster(txtHRManager.Text);
                if (txtHRManager.Text != "")
                {
                    if (txtHRManager.Text == oEmpMas.EmpId)
                    {
                        txtHRManagerName.Text = oEmpMas.FirstName;
                    }

                    else
                    {
                        MessageBox.Show("Invalid Employee ID!!!Please Enter Correct ID", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtHRManagerName.Text = "";
                        txtHRManager.Focus();
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

        private void txtPreparedBy_Leave(object sender, EventArgs e)
        {
            try
            {
                EmployeeMaster oEmpMas = new EmployeeMaster();
                oEmpMas = hmsSC.GetEmpMaster(txtPreparedBy.Text);
                if (txtPreparedBy.Text != "")
                {
                    if (txtPreparedBy.Text == oEmpMas.EmpId)
                    {
                        txtPreparedByName.Text = oEmpMas.FirstName;
                    }

                    else
                    {
                        MessageBox.Show("Invalid Employee ID!!!Please Enter Correct ID", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPreparedByName.Text = "";
                        txtHRManager.Focus();
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
        private void txtContractPeriod_Leave(object sender, EventArgs e)
        {
            if (dtEffectFrom.Text != "  /  /")
            {
                if (txtContractPeriod.Text != "")
                {
                    DateTime ct = Convert.ToDateTime(dtEffectFrom.Text);
                    int Period = Convert.ToInt32(txtContractPeriod.Text);
                    DateTime future = ct.AddMonths(Period);
                    dtContractUpto.Text = future.ToString("dd/MM/yyyy");
                }
            }
        }

    }
}
