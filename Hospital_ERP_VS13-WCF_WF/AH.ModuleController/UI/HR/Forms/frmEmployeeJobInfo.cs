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
    public partial class frmEmpJobInfo : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        List<EmployeeJobInformation> oEmpjobInformations;
        public string EmpId { set; get; }
        private EmployeeMaster empMater;
        private short callMode;
        public frmEmpJobInfo()
        {
            InitializeComponent();
            callMode = 0;
        }
        public frmEmpJobInfo(EmployeeMaster empMater)
        {
            InitializeComponent();
            this.empMater = empMater;
            callMode = 1;
        }
        private EmployeeJobInformation populateEmpJobInfoSetup()
        {
            string string1 = "";
            int j;
            EmployeeJobInformation oEmpJob = new EmployeeJobInformation();
            if (callMode == 0)
            {
                EmployeeMaster oEmp = new EmployeeMaster();                
                oEmp.EmpId = txtEmpId.Text;               
                oEmpJob.EmployeeMaster = oEmp;
            }
            if (callMode == 1)
            {
                txtEmpId.Enabled = false;
                EmployeeMaster oEmp = new EmployeeMaster();
                oEmp = this.empMater;
                oEmpJob.EmployeeMaster = oEmp;
            }

            Department oDept = new Department();
            oDept.DepartmentID = cboDepartment.SelectedValue.ToString();
            oEmpJob.Department = oDept;

            DepartmentUnit oUnit = new DepartmentUnit();
            oUnit.UnitId = cboUnit.SelectedValue.ToString();
            oEmpJob.DepartmentUnit = oUnit;

            Designation oDesig = new Designation();
            oDesig.DesignationId = cboDesignation.SelectedValue.ToString();
            oEmpJob.Designation = oDesig;

            DepartmentGroup oDeptGrp = new DepartmentGroup();
            oDeptGrp.DepartmentGroupID = cboDepartmentGroup.SelectedValue.ToString();
            oEmpJob.DepartmentGroup = oDeptGrp;
            
            oEmpJob.JobType = cboJobType.SelectedValue.ToString();
            oEmpJob.RecruitmentType = cboRecruitmentType.SelectedValue.ToString();

            if (cboDeptHead.SelectedValue != null)
            {
                oEmpJob.DeptHead = cboDeptHead.SelectedValue.ToString();
            }
            if (cboDeptHead.SelectedValue == null)
            {
                oEmpJob.DeptHead = "";
            }
            if (cboReportingPerson.SelectedValue != null)
            {
                oEmpJob.ReportingPerson = cboReportingPerson.SelectedValue.ToString();
            }
            if (cboReportingPerson.SelectedValue == null)
            {
                oEmpJob.ReportingPerson = "";
            }

            if (dtStartDate.Text != "  /  /")
            {
                oEmpJob.StartDate = DateTime.ParseExact(dtStartDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            }
            else
            {
                oEmpJob.StartDate = null;
            }
            if (dtEndDate.Text != "  /  /")
            {
                oEmpJob.EndDate = DateTime.ParseExact(dtEndDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            }
            else
            {
                oEmpJob.EndDate = null;
            }
            if (dtRetireDate.Text != "  /  /")
            {
                oEmpJob.RetireDate = DateTime.ParseExact(dtRetireDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            }
            else
            {
                oEmpJob.TransferDate = null;
            }
            if (dtTransferDate.Text != "  /  /")
            {
                oEmpJob.TransferDate = DateTime.ParseExact(dtTransferDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            }
            else
            {
                oEmpJob.TransferDate = null;
            }

            oEmpJob.ServiceBookReffNo = txtSerBookReffFlag.Text;
            oEmpJob.JobDesc = txtJobDescription.Text;
            oEmpJob.JobUpdateCauseType = cboJobUpdateCauseType.SelectedValue.ToString();
            oEmpJob.Responsibilities = txtResponsibilities.Text;
            oEmpJob.OfficeOrderNo = txtOfficeOrderNO.Text;
            oEmpJob.SerialNo = txtSerial.Text.ToString();

            if (chkConSclFlag.Checked == true)
            {
                oEmpJob.ConsolidateScaleFlag = "1";
                oEmpJob.ConsolidatedAmount = double.Parse(txtConsolidateAmount.Text);
                oEmpJob.Class = "0";
                oEmpJob.SalGradeID = "0";
                oEmpJob.SalScaleID = "0";
            }
            if (chkConSclFlag.Checked == false)
            {
                oEmpJob.ConsolidateScaleFlag = "0";
                oEmpJob.ConsolidatedAmount = 0;
                oEmpJob.Class = cboLevels.SelectedValue.ToString();
                oEmpJob.SalGradeID = cboGrade.SelectedValue.ToString();
                oEmpJob.SalScaleID = cboScale.SelectedValue.ToString();
            }

            for (j = 0; j < dgvFringeBenefit.Rows.Count; j++)
            {
                string1 += dgvFringeBenefit.Rows[j].Cells[0].Value.ToString() + ":" +
                           dgvFringeBenefit.Rows[j].Cells[2].Value.ToString() + ":" +                          
                           dgvFringeBenefit.Rows[j].Cells[3].Value.ToString() + ":" + ";";
            }

            oEmpJob.BenefitString = string1;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oEmpJob.Entryparameter = ep;

            return oEmpJob;
        }
        private void FormatGrid()
        {
            lvEmployeeJobInformation.CheckBoxes = false;

            lvEmployeeJobInformation.Columns.Add("EmployeeID", 0, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("DepartmentType", 0, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("DepartmentGrp", 0, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("DepartmentID", 0, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("DepartmentTitle", 200, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("UnitID", 0, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("UnitTitle", 200, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("DesignationID", 0, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("DesignationTitle", 150, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("Class", 0, HorizontalAlignment.Left); 
            lvEmployeeJobInformation.Columns.Add("JobType", 0, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("DeptHead", 0, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("DeptHeadName", 200, HorizontalAlignment.Left);  
            lvEmployeeJobInformation.Columns.Add("ReportingPerson", 0, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("ReportingPersonName", 200, HorizontalAlignment.Left);   
            lvEmployeeJobInformation.Columns.Add("StartDate", 0, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("EndDate", 0, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("RetireDate", 0, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("TransferDate", 0, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("ServiceBookReference", 0, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("JobDescription", 0, HorizontalAlignment.Left); 
            lvEmployeeJobInformation.Columns.Add("JobUpdateCauseType", 0, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("Responsibility", 0, HorizontalAlignment.Left);
            lvEmployeeJobInformation.Columns.Add("Office order NO", 0, HorizontalAlignment.Center);
            lvEmployeeJobInformation.Columns.Add("Consolidate Flag", 0, HorizontalAlignment.Center);
            lvEmployeeJobInformation.Columns.Add("Consolidate Amount", 0, HorizontalAlignment.Center);
            lvEmployeeJobInformation.Columns.Add("Grade", 0, HorizontalAlignment.Center);
            lvEmployeeJobInformation.Columns.Add("Scale", 0, HorizontalAlignment.Center);
            lvEmployeeJobInformation.Columns.Add("Serial", 0, HorizontalAlignment.Center);
            lvEmployeeJobInformation.Columns.Add("Recruitment Type", 0, HorizontalAlignment.Center);
            lvEmployeeJobInformation.Columns.Add("Dept Grp", 0, HorizontalAlignment.Center);
        }
        private void CheckDate()
        {            
            CultureInfo ci = CultureInfo.CurrentCulture;
            DateTimeFormatInfo dtfi = ci.DateTimeFormat;

            string[] SystemDateTimePatterns = new string[250];
            int i = 0;
            foreach (string name in dtfi.GetAllDateTimePatterns('d'))
            {
                SystemDateTimePatterns[i] = name;
                i++;
            }

            string[] myDateTimeFormat = { "dd/MM/yyyy","dd-MM-yyyy" };
            if (myDateTimeFormat[0].Equals(SystemDateTimePatterns[0]) || myDateTimeFormat[1].Equals(SystemDateTimePatterns[0]))
            {
                MessageBox.Show("Hi hi");
            }
            else
            {
                MessageBox.Show("Your System DateTime Format is: " + SystemDateTimePatterns[0] + "\n" + "Required DateTime Format: dd/MM/yyyy or dd-MM-yyyy ");
                System.Diagnostics.Process.Start("intl.cpl");
                btnClose.PerformClick();
            }
        }     
        private void frmEmpJobInfo_Load(object sender, EventArgs e)
        {
            oEmpjobInformations = hmsSC.GetEmployeeFringeBenefit().ToList();

            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);

            cboBenefit.DisplayMember = "Value";
            cboBenefit.ValueMember = "Key";
            cboBenefit.DataSource = new BindingSource(hmsSC.GetBenefitDict("D"), null); 
           
            cboLevels.DisplayMember = "Value";
            cboLevels.ValueMember = "Key";
            cboLevels.DataSource = new BindingSource(Utility.GetJobLevels(), null);

            cboJobType.DisplayMember = "Value";
            cboJobType.ValueMember = "Key";
            cboJobType.DataSource = new BindingSource(Utility.GetJobTypes(), null);

            cboRecruitmentType.DisplayMember = "Value";
            cboRecruitmentType.ValueMember = "Key";
            cboRecruitmentType.DataSource = new BindingSource(Utility.GetRecruitmentTypes(), null);          

            cboJobUpdateCauseType.DisplayMember = "Value";
            cboJobUpdateCauseType.ValueMember = "Key";
            cboJobUpdateCauseType.DataSource = new BindingSource(Utility.GetJobStatusUpdateTypes(), null);         

            FormatGrid();
            FormatGridView();
            RefreshGrid();
        }
        private void LoadListView(string oEmp)
        {
            lvEmployeeJobInformation.Items.Clear();

            List<EmployeeJobInformation> oGetEmpJobInfo = hmsSC.GetEmployeeJobInformation(txtEmpId.Text).ToList();
            foreach (EmployeeJobInformation gej in oGetEmpJobInfo)
            {
                ListViewItem itm = new ListViewItem(gej.EmployeeMaster.EmpId.ToString());
                itm.SubItems.Add(gej.Department.DepartmentType.TypeID.ToString());
                itm.SubItems.Add(gej.Department.DepartmentGroup.DepartmentGroupID.ToString());
                itm.SubItems.Add(gej.Department.DepartmentID.ToString());
                itm.SubItems.Add(gej.Department.DepartmentTitle.ToString());
                itm.SubItems.Add(gej.DepartmentUnit.UnitId.ToString());
                itm.SubItems.Add(gej.DepartmentUnit.UnitTitle.ToString());
                itm.SubItems.Add(gej.Designation.DesignationId.ToString());
                itm.SubItems.Add(gej.Designation.DesignationTitle.ToString());

                itm.SubItems.Add(gej.Class.ToString());
                itm.SubItems.Add(gej.JobType.ToString());
                itm.SubItems.Add(gej.DeptHead.ToString());
                itm.SubItems.Add(gej.DeptHeadName.ToString());
                itm.SubItems.Add(gej.ReportingPerson.ToString());
                itm.SubItems.Add(gej.ReportingPersonName.ToString());

                itm.SubItems.Add(gej.StartDate.ToString());
                itm.SubItems.Add(gej.EndDate.ToString());
                itm.SubItems.Add(gej.RetireDate.ToString());
                itm.SubItems.Add(gej.TransferDate.ToString());

                itm.SubItems.Add(gej.ServiceBookReffNo.ToString());
                itm.SubItems.Add(gej.JobDesc.ToString());
                itm.SubItems.Add(gej.JobUpdateCauseType.ToString());
                itm.SubItems.Add(gej.Responsibilities.ToString());

                itm.SubItems.Add(gej.OfficeOrderNo.ToString());
                itm.SubItems.Add(gej.ConsolidateScaleFlag.ToString());
                itm.SubItems.Add(gej.ConsolidatedAmount.ToString());

                itm.SubItems.Add(gej.SalGradeID.ToString());
                itm.SubItems.Add(gej.SalScaleID.ToString());
                itm.SubItems.Add(gej.SerialNo.ToString());
                itm.SubItems.Add(gej.RecruitmentType.ToString());

                lvEmployeeJobInformation.Items.Add(itm);
            }

        }
        private void RefreshGrid()
        {
            if (EmpId != "")
            {
                txtEmpId.Text = EmpId;
                btnSearch_Click(sender, e);
            }
            if (EmpId == "")
            {
                return;
            }

        } 
        private void lvEmployeeJobInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (lvEmployeeJobInformation.SelectedItems.Count > 0)
            {
                ListViewItem itm1 = lvEmployeeJobInformation.SelectedItems[0];

                txtEmpId.Text = itm1.SubItems[0].Text;
                cboDepartmentType.SelectedValue = itm1.SubItems[1].Text;
                cboDepartmentGroup.SelectedValue = itm1.SubItems[2].Text;
                cboDepartment.SelectedValue = itm1.SubItems[3].Text.ToString();
                cboUnit.SelectedValue = itm1.SubItems[5].Text;
                cboDesignation.SelectedValue = itm1.SubItems[7].Text;
                cboLevels.Text= itm1.SubItems[9].Text;
                cboJobType.SelectedValue = itm1.SubItems[10].Text;
                cboDeptHead.SelectedValue = itm1.SubItems[11].Text.ToString();
                cboReportingPerson.SelectedValue = itm1.SubItems[13].Text.ToString();
                dtStartDate.Text = itm1.SubItems[15].Text;
                dtEndDate.Text = itm1.SubItems[16].Text;
                dtRetireDate.Text = itm1.SubItems[17].Text;
                dtTransferDate.Text = itm1.SubItems[18].Text;
                txtSerBookReffFlag.Text = itm1.SubItems[19].Text;
                txtJobDescription.Text = itm1.SubItems[20].Text;
                cboJobUpdateCauseType.SelectedValue = itm1.SubItems[21].Text;
                txtResponsibilities.Text = itm1.SubItems[22].Text;
                txtOfficeOrderNO.Text = itm1.SubItems[23].Text;
                if (itm1.SubItems[24].Text == "1")
                {
                    chkConSclFlag.Checked = true;
                }
                if (itm1.SubItems[24].Text == "0")
                {
                    chkConSclFlag.Checked = false;
                }
                txtConsolidateAmount.Text = itm1.SubItems[25].Text;
                cboGrade.Text = itm1.SubItems[26].Text;
                cboScale.Text = itm1.SubItems[27].Text;
                txtSerial.Text = itm1.SubItems[28].Text;
                cboRecruitmentType.SelectedValue = itm1.SubItems[29].Text;

                dgvFringeBenefit.Rows.Clear();
                List<EmployeeJobInformation> oEmpJobInfoWithBenefit = oEmpjobInformations.Where(x => x.EmployeeMaster.EmpId == txtEmpId.Text && x.SerialNo == txtSerial.Text).ToList();
                foreach (EmployeeJobInformation oEmpJob in oEmpJobInfoWithBenefit)
                {
                    AddRowsToBenefitCollection(dgvFringeBenefit, new string[] { oEmpJob.FringeBenefit.BenID, oEmpJob.FringeBenefit.BenTitle, oEmpJob.FringeBenefit.Amount,oEmpJob.FringeBenefit.EffectiveDate.ToString("dd/MM/yyyy")});
                }
        }
        }      
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDepartmentGroup", "cboDepartment", "cboUnit", "cboDesignation", "cboJobType", "cboJobUpdateCauseType", "dtStartDate", "txtJobDescription", "txtSerBookReffFlag", "cboRecruitmentType", "cboLevels", "cboGrade", "cboScale", "cboJobUpdateCauseType", "cboRecruitmentType" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dtStartDate.Text == "  /  /")
            {
                MessageBox.Show("Job Start Date cannot be empty");
                return;
            }
            try
            {
                EmployeeJobInformation oEmpJobInfo = this.populateEmpJobInfoSetup();
                if (callMode == 0)
                {
                    EmployeeMaster oEmpMas = new EmployeeMaster();
                    oEmpMas = hmsSC.GetEmpMaster(txtEmpId.Text);

                    if (txtEmpId.Text == oEmpMas.EmpId)
                    {                       
                        short i = hmsSC.SaveEmployeeJobInformation(oEmpJobInfo);
                        if (i == 0)
                        {
                            MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i > 0)
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvFringeBenefit.Rows.Clear();
                            btnRefresh_Click(sender, e);
                            btnSearch_Click(sender, e);                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid EmployeeID", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (callMode == 1)
                {
                    
                    short i = hmsSC.SaveEmpMasterJobInfo(oEmpJobInfo);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);                       
                        btnClose.PerformClick();                                             
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmpId", "cboDepartmentGroup", "cboDepartment", "cboUnit", "cboDesignation", "cboJobType", "cboJobUpdateCauseType", "dtStartDate", "txtJobDescription", "txtSerBookReffFlag", "cboRecruitmentType", "cboLevels", "cboGrade", "cboScale", "cboJobUpdateCauseType", "cboRecruitmentType" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                EmployeeJobInformation oEmpJobInfo = this.populateEmpJobInfoSetup();
                DialogResult msg = MessageBox.Show("Do you want to update the information?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg == DialogResult.Yes)
                {
                    short i = hmsSC.UpdateEmployeeJobInformation(oEmpJobInfo);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvFringeBenefit.Rows.Clear();
                        btnRefresh_Click(sender, e);
                        btnSearch_Click(sender, e);                       
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

        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ScaleMSetup> oSalHdGs = new List<ScaleMSetup>();

            oSalHdGs = hmsSC.GetScaleUnderGrade(cboGrade.SelectedValue.ToString()).ToList();
            try
            {
                if (cboGrade != null)
                {
                    cboScale.DisplayMember = "ScaleTitle";
                    cboScale.ValueMember = "ScaleMID";
                    cboScale.DataSource = oSalHdGs;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
                    lblDept.Text = oEmpMas.Department.DepartmentID;                   
                }

                else
                {
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnNew.PerformClick();
                }
            }
        }

        private void chkConSclFlag_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConSclFlag.Checked == true)
             {
                 txtConsolidateAmount.Enabled = true;
                 cboJobType.SelectedValue = "C";
                 cboLevels.SelectedValue = "";
                 cboJobType.Enabled = false;
                 cboLevels.Enabled = false;
                 cboGrade.Enabled = false;
                 cboScale.Enabled = false;
                 lblStarAmt.Visible = true;
                 txtConsolidateAmount.Focus();
             }
             else
             {
                 txtConsolidateAmount.Enabled = false;
                 cboJobType.SelectedValue = "P";
                 cboLevels.Text= "--Select--";
                 cboJobType.Enabled = true;
                 cboLevels.Enabled = true;
                 cboGrade.Enabled = true;
                 cboScale.Enabled = true;
                 lblStarAmt.Visible = false;
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
        private void SearchInformation()
        {
            EmployeeJobInformation oEmpJobInfo = new EmployeeJobInformation();
            oEmpJobInfo = hmsSC.GetEmployeeCurrentJobInformation(txtEmpId.Text);
            cboDepartmentType.SelectedValue = oEmpJobInfo.Department.DepartmentType.TypeID;
            cboDepartmentGroup.SelectedValue = oEmpJobInfo.Department.DepartmentGroup.DepartmentGroupID;
            cboDepartment.SelectedValue = oEmpJobInfo.Department.DepartmentID;
            cboUnit.SelectedValue = oEmpJobInfo.DepartmentUnit.UnitId;
            cboDesignation.SelectedValue = oEmpJobInfo.Designation.DesignationId;
            cboLevels.Text = oEmpJobInfo.Class.ToString();
            cboGrade.Text = oEmpJobInfo.SalGradeID;
            cboScale.Text = oEmpJobInfo.SalScaleID;
            txtOfficeOrderNO.Text = oEmpJobInfo.OfficeOrderNo;
            if (Convert.ToInt16(oEmpJobInfo.ConsolidateScaleFlag) == 1)
            {
                chkConSclFlag.Checked = true;
            }
            else
                chkConSclFlag.Checked = false;
            txtConsolidateAmount.Text =oEmpJobInfo.ConsolidatedAmount.ToString();
            cboJobType.SelectedValue = oEmpJobInfo.JobType;
            cboJobUpdateCauseType.SelectedValue = oEmpJobInfo.JobUpdateCauseType;
            cboDeptHead.SelectedValue = oEmpJobInfo.DeptHead;
            cboReportingPerson.SelectedValue = oEmpJobInfo.ReportingPerson;
            dtStartDate.Text = oEmpJobInfo.StartDate.ToString();
            dtEndDate.Text = oEmpJobInfo.EndDate.ToString();
            dtTransferDate.Text = oEmpJobInfo.TransferDate.ToString();
            dtRetireDate.Text = oEmpJobInfo.RetireDate.ToString();
            txtResponsibilities.Text = oEmpJobInfo.Responsibilities;
            txtJobDescription.Text = oEmpJobInfo.JobDesc;
            txtSerBookReffFlag.Text = oEmpJobInfo.ServiceBookReffNo;
            txtSerial.Text = oEmpJobInfo.SerialNo;
            cboRecruitmentType.SelectedValue = oEmpJobInfo.RecruitmentType;
            dgvFringeBenefit.Rows.Clear();
            List<EmployeeJobInformation> oEmpJobInfoWithBenefit = oEmpjobInformations.Where(x => x.EmployeeMaster.EmpId == txtEmpId.Text && x.SerialNo == txtSerial.Text).ToList();
            foreach (EmployeeJobInformation oEmpJob in oEmpJobInfoWithBenefit)
            {
                if (CheckDuplicate(oEmpJob.FringeBenefit.BenTitle.ToString()) == false)
                {
                    AddRowsToBenefitCollection(dgvFringeBenefit, new string[] { oEmpJob.FringeBenefit.BenID, oEmpJob.FringeBenefit.BenTitle, oEmpJob.FringeBenefit.Amount, oEmpJob.FringeBenefit.EffectiveDate.ToString("dd/MM/yyyy") });
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtEmpId.Text);          
            if (txtEmpId.Text != "")
            {
                if (txtEmpId.Text == oEmpMas.EmpId)
                {
                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Designation.DesignationId.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Department.DepartmentTitle.ToString();                    
                }                
                
                LoadListView(txtEmpId.Text);
                SearchInformation();
            }
        }
        private void lvEmployeeJobInformation_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            dtStartDate.Text = null;
            dtEndDate.Text = null;
            dtRetireDate.Text = null;
            dtTransferDate.Text = null;
            lblInfo.Text = "";
            lblDept.Text = "";
            dgvFringeBenefit.Rows.Clear();
            if (lvEmployeeJobInformation.Items.Count > 0)
            {
                lvEmployeeJobInformation.Items.Clear();
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

                if (ckhDeptHead.Checked == false)
                {
                    cboDeptHead.DisplayMember = "Value";
                    cboDeptHead.ValueMember = "Key";
                    cboDeptHead.DataSource = new BindingSource(hmsSC.GetDeptHeadDic(cboDepartmentGroup.SelectedValue.ToString()), null);
                }

                if (chkRptPrsn.Checked == false)
                {
                    cboReportingPerson.DisplayMember = "Value";
                    cboReportingPerson.ValueMember = "Key";
                    cboReportingPerson.DataSource = new BindingSource(hmsSC.GetReportingPersonDic(cboDepartmentType.SelectedValue.ToString(), cboDepartmentGroup.SelectedValue.ToString()), null);
                }
            }
           
        }
        private void btnAddDeptGrp_Click(object sender, EventArgs e)
        {
            frmDepartmentGroup oDeptGrp = new frmDepartmentGroup();
            if (cboDepartmentType.SelectedValue.ToString() != null)
            {
                oDeptGrp.TypeID = cboDepartmentType.SelectedValue.ToString();
            }
            oDeptGrp.ShowDialog();  
        }
        private void btnRefreshDeptGrp_Click(object sender, EventArgs e)
        {
            if (cboDepartmentType.SelectedValue != null)
            {
                cboDepartmentGroup.DisplayMember = "Value";
                cboDepartmentGroup.ValueMember = "Key";
                cboDepartmentGroup.DataSource = new BindingSource(hmsSC.GetDeptGroupDicByType(cboDepartmentType.SelectedValue.ToString()), null);
            }
        }
        private void btnAddDept_Click(object sender, EventArgs e)
        {
            frmAssignOrganogram oDept = new frmAssignOrganogram();          
            oDept.ShowDialog();   
        }
        private void btnRefreshDept_Click(object sender, EventArgs e)
        {
            if (cboDepartmentGroup.SelectedValue != null)
            {
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(hmsSC.GetDepartmentsetupDic(null, cboDepartmentGroup.SelectedValue.ToString()), null);
            }
        }
        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            frmAssignOrganogram oAssign = new frmAssignOrganogram();
            oAssign.ShowDialog();
        }
        private void btnRefreshUnit_Click(object sender, EventArgs e)
        {
            if (cboDepartment.Text != "--Select--")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(hmsSC.GetDeptUnitDic(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString())), null);
            }
        }

        private void btnAddDesig_Click(object sender, EventArgs e)
        {
            frmOranogramSetup oDesig = new frmOranogramSetup();
            oDesig.ShowDialog();
        }

        private void btnRefreshDesig_Click(object sender, EventArgs e)
        {
            cboDesignation.DisplayMember = "Value";
            cboDesignation.ValueMember = "Key";
            cboDesignation.DataSource = new BindingSource(hmsSC.GetOrganogramDesig(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString()), null);
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            frmSalaryGradeSetup oSalGrade = new frmSalaryGradeSetup();
            if (cboLevels.SelectedValue.ToString() != "")
            {
                oSalGrade.Level = cboLevels.SelectedValue.ToString();
            }
            oSalGrade.ShowDialog();
        }

        private void btnRefreshGrade_Click(object sender, EventArgs e)
        {
            if (cboLevels.SelectedValue != "")
            {
                cboGrade.DisplayMember = "Value";
                cboGrade.ValueMember = "Key";
                cboGrade.DataSource = new BindingSource(hmsSC.GetGradeDict(cboLevels.SelectedValue.ToString()), null);
            }
        }

        private void btnAddStep_Click(object sender, EventArgs e)
        {
            frmScaleMSetup oStep = new frmScaleMSetup();
            if (cboLevels.SelectedValue.ToString() != "")
            {
                oStep.Level = cboLevels.SelectedValue.ToString();
                if (cboGrade.SelectedValue.ToString() != "")
                {                    
                    oStep.GradeID = cboGrade.SelectedValue.ToString();
                }
            }
            oStep.ShowDialog();
        }

        private void btnRefreshStep_Click(object sender, EventArgs e)
        {
            List<ScaleMSetup> oSalHdGs =  hmsSC.GetScaleUnderGrade(cboGrade.SelectedValue.ToString()).ToList();
            try
            {
                if (cboGrade != null)
                {
                    cboScale.DisplayMember = "ScaleTitle";
                    cboScale.ValueMember = "ScaleMID";
                    cboScale.DataSource = oSalHdGs;
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
          private void FormatGridView()
          {
            dgvFringeBenefit.ColumnCount = 4;
            this.dgvFringeBenefit.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvFringeBenefit.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvFringeBenefit.Columns[0].Name = "BenefitID";
            dgvFringeBenefit.Columns[0].ReadOnly = true;
            dgvFringeBenefit.Columns[0].Width = 0;
            dgvFringeBenefit.Columns[0].Visible = false;
            dgvFringeBenefit.Columns[1].Name = "Benefit";
            dgvFringeBenefit.Columns[1].ReadOnly = true;
            dgvFringeBenefit.Columns[1].Width = 250;
            dgvFringeBenefit.Columns[2].Name = "Amount";
            dgvFringeBenefit.Columns[2].ReadOnly = true;
            dgvFringeBenefit.Columns[2].Width = 205;
            dgvFringeBenefit.Columns[3].Name = "Effective Date";
            dgvFringeBenefit.Columns[3].ReadOnly = true;
            dgvFringeBenefit.Columns[3].Width = 180;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvFringeBenefit.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.DefaultCellStyle.ForeColor = Color.Navy;
            btn.UseColumnTextForButtonValue = true;
            btn.Width = 60;

        }
        private void AddRowsToBenefitCollection(DataGridView dtv, string[] row)
        {
            DataGridViewRow rw = new DataGridViewRow();
            dtv.Rows.Insert(0, row);
        }
        private bool CheckDuplicate(string Benefit)
        {
            for (int i = 0; i < dgvFringeBenefit.Rows.Count; i++)
            {
                string strVar = dgvFringeBenefit.Rows[i].Cells[1].Value.ToString();
                if (Benefit == strVar)
                {
                    //MessageBox.Show("Cannot Insert Duplicate Benefit Name", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            return false;
        }
        private void btnAddBenefitToGrid_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboBenefit", "txtEffectiveDate" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (txtEffectiveDate.Text == "  /  /")
            {
                MessageBox.Show("Effective Date cannot be empty");
                return;
            }
            if (txtBenefitAmount.Enabled == true)
            {
                if (txtBenefitAmount.Text == "")
                {
                    MessageBox.Show("Please Provide Amount For This Benefit", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBenefitAmount.Focus();
                    return;
                }
            }
            if (CheckDuplicate(cboBenefit.Text.ToString()) == false)
            {
                AddRowsToBenefitCollection(dgvFringeBenefit, new string[] { cboBenefit.SelectedValue.ToString(), cboBenefit.Text.ToString(), txtBenefitAmount.Text.ToString(), txtEffectiveDate.Text.ToString()});
            }
        }

        private void cboBenefit_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<FringeBenefit> oBenTypes = hmsSC.CheckBenefitType(cboBenefit.SelectedValue.ToString()).ToList();            
            if(oBenTypes.Count>0)
            {
                foreach (FringeBenefit oBen in oBenTypes)
                {
                    if (oBen.isAmount.ToString() == "1")
                    {
                        lblBenefitAmount.Enabled = true;
                        txtBenefitAmount.Enabled = true;
                        lblStar.Visible = true;
                        txtBenefitAmount.Text = "";
                        txtEffectiveDate.Text = "";
                    }
                    if (oBen.isAmount.ToString() == "0")
                    {
                        lblBenefitAmount.Enabled = false;
                        txtBenefitAmount.Enabled = false;
                        lblStar.Visible = false;
                        txtBenefitAmount.Text = "";
                        txtEffectiveDate.Text = "";
                    }
                }
            }
        }

        private void dgvFringeBenefit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int selectedIndex = dgvFringeBenefit.CurrentCell.RowIndex;
            //if (selectedIndex > -1)
            //{
            //    dgvFringeBenefit.Rows.RemoveAt(selectedIndex);
            //    dgvFringeBenefit.Refresh();
            //}
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            oEmpjobInformations = hmsSC.GetEmployeeFringeBenefit().ToList();
        }
        private void dgvFringeBenefit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            int row = e.RowIndex;
            if (dgvFringeBenefit.Rows.Count > 0)
            {
                if (dgvFringeBenefit.CurrentCell != null)
                {
                    int selectedIndex = dgvFringeBenefit.CurrentCell.RowIndex;
                    if (selectedIndex > -1)
                    {
                        cboBenefit.Text = dgvFringeBenefit.Rows[row].Cells[1].Value.ToString();
                        txtBenefitAmount.Text = dgvFringeBenefit.Rows[row].Cells[2].Value.ToString();
                        txtEffectiveDate.Text = dgvFringeBenefit.Rows[row].Cells[3].Value.ToString();
                    }
                }
             }         
                if (dgvFringeBenefit.Columns[e.ColumnIndex].Name == "btn")
                {
                    if (dgvFringeBenefit.CurrentCell != null)
                    {
                        int selectedIndex = dgvFringeBenefit.CurrentCell.RowIndex;
                        if (selectedIndex > -1)
                        {
                            DialogResult msg = MessageBox.Show("Do You want to Delete?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if (msg == DialogResult.Yes)
                            {
                                dgvFringeBenefit.Rows.RemoveAt(selectedIndex);
                                dgvFringeBenefit.Refresh();
                            }
                            else
                            {
                                return;
                            }

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

        private void btnAddBenefit_Click(object sender, EventArgs e)
        {
            frmFringeBenefitSetup oBen = new frmFringeBenefitSetup();
            oBen.ShowDialog();
        }

        private void btnRefreshBenefit_Click(object sender, EventArgs e)
        {
            cboBenefit.DisplayMember = "Value";
            cboBenefit.ValueMember = "Key";
            cboBenefit.DataSource = new BindingSource(hmsSC.GetBenefitDict("D"), null); 
        }

        private void txtJobDescription_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void txtSerBookReffFlag_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
        private void txtResponsibilities_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void cboLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLevels.SelectedValue != "")
            {
                cboGrade.DisplayMember = "Value";
                cboGrade.ValueMember = "Key";
                cboGrade.DataSource = new BindingSource(hmsSC.GetGradeDict(cboLevels.SelectedValue.ToString()), null);
            }
        }
        public object sender { get; set; }

        public EventArgs e { get; set; }

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUnit.SelectedValue != null)
            {
                cboDesignation.DisplayMember = "Value";
                cboDesignation.ValueMember = "Key";
                cboDesignation.DataSource = new BindingSource(hmsSC.GetOrganogramDesig(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString()), null);               
            }            
        }
        private void btnAddHead_Click(object sender, EventArgs e)
        {
            frmDepartmentHeadSetup oDeptHead = new frmDepartmentHeadSetup();
            oDeptHead.DeptType = cboDepartmentType.SelectedValue.ToString();
            oDeptHead.DeptGrp = cboDepartmentGroup.SelectedValue.ToString();
            oDeptHead.Dept = cboDepartment.SelectedValue.ToString();
            oDeptHead.Unit = cboUnit.SelectedValue.ToString();
            oDeptHead.ShowDialog();
        }
        private void btnRefreshHead_Click(object sender, EventArgs e)
        {
            cboDeptHead.DisplayMember = "Value";
            cboDeptHead.ValueMember = "Key";
            cboDeptHead.DataSource = new BindingSource(hmsSC.GetDeptHeadDic(cboDepartmentGroup.SelectedValue.ToString()), null);
        }

        private void chkRptPrsn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRptPrsn.Checked == false)
            {
                cboReportingPerson.DisplayMember = "Value";
                cboReportingPerson.ValueMember = "Key";
                cboReportingPerson.DataSource = new BindingSource(hmsSC.GetReportingPersonDic(cboDepartmentType.SelectedValue.ToString(), cboDepartmentGroup.SelectedValue.ToString()), null);
            }
            if (chkRptPrsn.Checked == true)
            {
                cboReportingPerson.DisplayMember = "Value";
                cboReportingPerson.ValueMember = "Key";
                cboReportingPerson.DataSource = new BindingSource(hmsSC.GetEmp("D"), null);
            }
        }

        private void ckhDeptHead_CheckedChanged(object sender, EventArgs e)
        {
            if (ckhDeptHead.Checked == false)
            {
                cboDeptHead.DisplayMember = "Value";
                cboDeptHead.ValueMember = "Key";
                cboDeptHead.DataSource = new BindingSource(hmsSC.GetDeptHeadDic(cboDepartmentGroup.SelectedValue.ToString()), null);
            }
            if (ckhDeptHead.Checked == true)
            {
                cboDeptHead.DisplayMember = "Value";
                cboDeptHead.ValueMember = "Key";
                cboDeptHead.DataSource = new BindingSource(hmsSC.GetEmp("D"), null);
            }
        }

    }
}
