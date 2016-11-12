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
using System.Threading;
using System.Drawing.Imaging;
using AH.ModuleController.UI.HR.Reports.Viewer;
namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmEmployeeMedicalInformation : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string EmpId { set; get; }
        public frmEmployeeMedicalInformation()
        {
            InitializeComponent();
        }

        private void txtEmp_Leave(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtEmpID.Text);
            if (txtEmpID.Text == "")
            {
                lblInfo.Text = "";
                return;
            }
            if (txtEmpID.Text != "")
            {
                if (txtEmpID.Text == oEmpMas.EmpId)
                {
                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Designation.DesignationId.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Department.DepartmentTitle.ToString();
                }

                else
                {
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmEmployeeMedicalInformation_Load(object sender, EventArgs e)
        {
            cboBloodGrp.DisplayMember = "Value";
            cboBloodGrp.ValueMember = "Key";
            cboBloodGrp.DataSource = new BindingSource(Utility.GetBloodGroups(), null);
            txtEmpID.Focus();
            FormatGrid();
            RefreshGrid();
        }

        private void FormatGrid()
        {
            lvEmployeeMedicalInformation.CheckBoxes = false;           
            lvEmployeeMedicalInformation.Columns.Add("Serial", 0, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("Eye Sight", 150, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("Height", 100, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("Weight", 100, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("Disabilities", 200, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("Diabitics", 0, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("B.Grp", 100, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("BP", 100, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("X-Ray", 200, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("ECG", 200, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("Date", 0, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("Mark", 200, HorizontalAlignment.Left);
        }
        private void LoadListView(string emp)
        {
            lvEmployeeMedicalInformation.Items.Clear();

            List<EmployeeMedicalInfo> oEmpMed = hmsSC.GetEmployeeMedicalInformation(txtEmpID.Text).ToList();

            foreach (EmployeeMedicalInfo et in oEmpMed)
            {
                ListViewItem itm = new ListViewItem(et.MedicalReportSerial.ToString());             
                itm.SubItems.Add(et.EyeSight.ToString());
                itm.SubItems.Add(et.Height.ToString());
                itm.SubItems.Add(et.weight.ToString());
                itm.SubItems.Add(et.Disabilities.ToString());
                itm.SubItems.Add(et.IsDiabetics.ToString());
                itm.SubItems.Add(et.BloodGrp.ToString());
                itm.SubItems.Add(et.BP.ToString());
                itm.SubItems.Add(et.XrayReport.ToString());
                itm.SubItems.Add(et.EcgReport.ToString());
                itm.SubItems.Add(et.ReportDate.ToString());
                itm.SubItems.Add(et.Mark.ToString());
                lvEmployeeMedicalInformation.Items.Add(itm);
            }

        }
        private void RefreshGrid()
        {
            if (EmpId != "")
            {
                txtEmpID.Text = EmpId;
                LoadListView(txtEmpID.Text);
            }
            if (EmpId == "")
            {
                return;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtEmpID.Text);
            if (txtEmpID.Text != "")
            {
                if (txtEmpID.Text == oEmpMas.EmpId)
                {
                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Designation.DesignationId.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Department.DepartmentTitle.ToString();
                }
                LoadListView(txtEmpID.Text);
            }
        }

        private void lvEmployeeMedicalInformation_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            lblInfo.Text = "";
            if (lvEmployeeMedicalInformation.Items.Count > 0)
            {
                lvEmployeeMedicalInformation.Items.Clear();
            }
            
        }

        private void lvEmployeeMedicalInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmployeeMedicalInformation.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvEmployeeMedicalInformation.SelectedItems[0];
                txtSerial.Text = itm.SubItems[0].Text;
                txtEyeSight.Text = itm.SubItems[1].Text;
                txtHeight.Text = itm.SubItems[2].Text;
                txtWeight.Text = itm.SubItems[3].Text;
                txtDisabilities.Text = itm.SubItems[4].Text;
                if (itm.SubItems[5].Text == "1")
                {
                    chkDiabitics.Checked = true;
                }
                if (itm.SubItems[5].Text == "0")
                {
                    chkDiabitics.Checked = false;
                }
                cboBloodGrp.Text = itm.SubItems[6].Text;
                txtBP.Text = itm.SubItems[7].Text;
                txtXrayReport.Text = itm.SubItems[8].Text;
                txtEcgReport.Text = itm.SubItems[9].Text;
                txtReportDate.Text =Convert.ToDateTime(itm.SubItems[10].Text.ToString()).ToString();
                txtMark.Text = itm.SubItems[11].Text;

            }
        }

        private EmployeeMedicalInfo populateEmployeeMedicalInformation()
        {
            EmployeeMedicalInfo oEmpMedInfo = new EmployeeMedicalInfo();
            EmployeeMaster oEmpMas = new EmployeeMaster();          
                oEmpMas.EmpId = txtEmpID.Text.ToString();
                oEmpMedInfo.EmployeeMaster = oEmpMas;
                oEmpMedInfo.MedicalReportSerial = txtSerial.Text.ToString();
                oEmpMedInfo.EyeSight = txtEyeSight.Text.ToString();
                oEmpMedInfo.Height = txtHeight.Text.ToString();
                oEmpMedInfo.weight = txtWeight.Text.ToString();
                oEmpMedInfo.Disabilities = txtDisabilities.Text.ToString();
                if (chkDiabitics.Checked == true)
                {
                    oEmpMedInfo.IsDiabetics = "1";                   
                }
                if (chkDiabitics.Checked == false)
                {
                    oEmpMedInfo.IsDiabetics = "0";                   
                }
                oEmpMedInfo.BloodGrp = cboBloodGrp.SelectedValue.ToString();
                oEmpMedInfo.BP = txtBP.Text.ToString();
                oEmpMedInfo.XrayReport = txtXrayReport.Text.ToString();
                oEmpMedInfo.EcgReport = txtEcgReport.Text.ToString();
                if (txtReportDate.Text != "  /  /")
                {
                    oEmpMedInfo.ReportDate = txtReportDate.Text.ToString();
                }
                oEmpMedInfo.Mark = txtMark.Text.ToString();
                EntryParameter ep = new EntryParameter();
                ep.EntryBy = Utility.UserId;
                ep.UpdateBy = ep.EntryBy;
                ep.CompanyID = Utility.CompanyID;
                ep.LocationID = Utility.LocationID;
                ep.MachineID = Utility.MachineID;

                oEmpMedInfo.EntryParameter = ep;  
         
                return oEmpMedInfo;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmpID", "txtEyeSight", "txtHeight", "txtWeight", "cboBloodGrp", "txtBP" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (txtReportDate.Text == "  /  /")
            {
                MessageBox.Show("Report Date cannot be empty");
                return;
            }
            try
            {
                EmployeeMedicalInfo oEmpMedInfo = this.populateEmployeeMedicalInformation();
                short i = hmsSC.SaveEmployeeMedicalInformation(oEmpMedInfo);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                    btnSearch_Click(sender, e);
                    txtEyeSight.Text = "";
                    txtHeight.Text = "";
                    txtWeight.Text = "";
                    txtDisabilities.Text = "";
                    txtXrayReport.Text = "";
                    txtEcgReport.Text = "";
                    txtBP.Text = "";
                    txtReportDate.Text = "";
                    txtMark.Text = "";
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
            List<string> vf = new List<string>() { "txtEmpID", "txtEyeSight", "txtHeight", "txtWeight", "cboBloodGrp", "txtBP" };

            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                EmployeeMedicalInfo oEmpMedInfo = this.populateEmployeeMedicalInformation();
                short i = hmsSC.UpdateEmployeeMedicalInformation(oEmpMedInfo);

                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSearch_Click(sender, e);
                    txtEyeSight.Text = "";
                    txtHeight.Text = "";
                    txtWeight.Text = "";
                    txtDisabilities.Text = "";
                    txtXrayReport.Text = "";
                    txtEcgReport.Text = "";
                    txtBP.Text = "";
                    txtReportDate.Text = "";
                    txtMark.Text = "";
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

        private void txtXrayReport_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void txtEcgReport_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
