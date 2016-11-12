using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.ModuleController.HRSR;
using AH.DUtility;


namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmEmployeeEducation : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string EmpId { set; get; }
       
        public frmEmployeeEducation()
        {
            InitializeComponent();
        }
        public EmpEducation AssignValue()
        {
            EmpEducation oEmpEdu = new EmpEducation();
            Staff staff = new Staff();
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtStaffID.Text);

            if (txtStaffID.Text == oEmpMas.EmpId)
            {                
                oEmpMas.EmpId = txtStaffID.Text;
                oEmpEdu.EmployeeMaster = oEmpMas;
                oEmpEdu.serial = txtSerial.Text.ToString();
                staff.Country = cboCountry.SelectedValue.ToString();
                oEmpEdu.PassingYear = cboPassingYear.SelectedValue.ToString();
                oEmpEdu.Institute = txtInstitute.Text;
                oEmpEdu.Class = txtClass.Text;
                oEmpEdu.Staff = staff;
                oEmpEdu.Remarks = txtRemarks.Text;
                oEmpEdu.NameOfDegree = txtDegreeName.Text;

                EntryParameter ep = new EntryParameter();
                ep.CompanyID = Utility.CompanyID;
                ep.EntryBy = Utility.UserId;
                ep.UpdateBy = Utility.UserId;
                ep.LocationID = Utility.LocationID;
                ep.MachineID = Utility.MachineID;
                oEmpEdu.EntryParameter = ep;
            }
            else
            {
                MessageBox.Show("Invalid EmployeeID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return oEmpEdu;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtStaffID", "txtDegreeName", "txtInstitute", "txtClass", "cboPassingYear", "txtCountry" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
                EmpEducation EmpEdu = this.AssignValue();
                 EmployeeMaster oEmpMas = new EmployeeMaster();
                 oEmpMas = hmsSC.GetEmpMaster(txtStaffID.Text);

                 if (txtStaffID.Text == oEmpMas.EmpId)
                 {
                     short i = hmsSC.SaveEmpEdu(EmpEdu);
                     if (i == 0)
                     {
                         MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }
                     else if (i > 0)
                     {
                         MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                         btnSearch_Click(sender, e);
                         txtDegreeName.Text = "";
                         txtInstitute.Text = "";
                         txtClass.Text = "";
                         txtRemarks.Text = "";
                     }
                 }
                 else
                 {
                     MessageBox.Show("Invalid EmployeeID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void LoadListView(string emp)
        {
            lvEmpEdu.Items.Clear();
            List<EmpEducation> oempedus = new List<EmpEducation>();
            oempedus = hmsSC.GetEmpEducation(txtStaffID.Text.ToString()).ToList();
            foreach (EmpEducation empedu in oempedus)
            {
                ListViewItem itm = new ListViewItem(empedu.NameOfDegree);
                itm.SubItems.Add(empedu.PassingYear);
                itm.SubItems.Add(empedu.Institute);
                itm.SubItems.Add(empedu.Class);
                itm.SubItems.Add(empedu.Staff.Country);
                itm.SubItems.Add(empedu.Remarks);
                itm.SubItems.Add(empedu.serial);
                lvEmpEdu.Items.Add(itm);
            }
        }
        private void FormatGrid()
        {
            lvEmpEdu.CheckBoxes = false;
            //lvEmpEdu.Columns.Add("Staff ID", 100, HorizontalAlignment.Center);
            lvEmpEdu.Columns.Add("Name Of Degree", 150, HorizontalAlignment.Center);
            lvEmpEdu.Columns.Add("Passing Year", 100, HorizontalAlignment.Left);
            lvEmpEdu.Columns.Add("Institute", 200, HorizontalAlignment.Left);
            lvEmpEdu.Columns.Add("CGPA", 100, HorizontalAlignment.Left);
            lvEmpEdu.Columns.Add("Country", 150, HorizontalAlignment.Left);
            lvEmpEdu.Columns.Add("Remarks", 200, HorizontalAlignment.Left);
            lvEmpEdu.Columns.Add("Serial", 0, HorizontalAlignment.Left);
        }

        private void frmEmployeeEducation_Load(object sender, EventArgs e)
        {
            cboPassingYear.DisplayMember = "Value";
            cboPassingYear.ValueMember = "Key";
            cboPassingYear.DataSource = new BindingSource(Utility.GetNumbers(1950, 2030), null);

            cboCountry.DisplayMember = "Value";
            cboCountry.ValueMember = "Key";
            cboCountry.DataSource = new BindingSource(Utility.GetCountries(), null);
            FormatGrid();
            RefreshGrid();
            txtStaffID.Focus();
        }
        private void RefreshGrid()
        {
            if (EmpId != "")
            {
                txtStaffID.Text = EmpId;
                LoadListView(txtStaffID.Text);
            }
            if (EmpId == "")
            {
                return;
            }
        } 

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtStaffID", "txtDegreeName", "txtInstitute", "txtClass", "cboPassingYear", "txtCountry" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
                EmpEducation EmpEdu = this.AssignValue();
                short i = hmsSC.UpdateEmpEdu(EmpEdu);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadListView(txtStaffID.Text.ToString());
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSearch_Click(sender, e);
                    txtDegreeName.Text = "";
                    txtInstitute.Text = "";
                    txtClass.Text = "";
                    txtRemarks.Text = "";
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

        private void lvEmpEdu_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (lvEmpEdu.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvEmpEdu.SelectedItems[0];
                //txtStaffID.Text = itm.SubItems[0].Text;
                txtDegreeName.Text = itm.SubItems[0].Text;
                cboPassingYear.Text= itm.SubItems[1].Text;              
                txtInstitute.Text = itm.SubItems[2].Text;
                txtClass.Text = itm.SubItems[3].Text;
                cboCountry.Text = itm.SubItems[4].Text;
                txtRemarks.Text = itm.SubItems[5].Text;
                txtSerial.Text = itm.SubItems[6].Text;

            }       
        }

        private void txtStaffID_Leave(object sender, EventArgs e)
        {
            if (txtStaffID.Text == "")
                {
                    lblInfo.Text = "";
                    return;
                }
            if (txtStaffID.Text != "")
            {
                EmployeeMaster oEmpMas = new EmployeeMaster();
                oEmpMas = hmsSC.GetEmpMaster(txtStaffID.Text);

                if (txtStaffID.Text == oEmpMas.EmpId)
                {
                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Designation.DesignationId.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Department.DepartmentTitle.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void lvEmpEdu_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            lblInfo.Text = "";
            if (lvEmpEdu.Items.Count > 0)
            {
                lvEmpEdu.Items.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtStaffID.Text);
            if (txtStaffID.Text != "")
            {
                if (txtStaffID.Text == oEmpMas.EmpId)
                {
                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Designation.DesignationId.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Department.DepartmentTitle.ToString();
                }
                LoadListView(txtStaffID.Text.ToString());
            }
        }     

    }
}
