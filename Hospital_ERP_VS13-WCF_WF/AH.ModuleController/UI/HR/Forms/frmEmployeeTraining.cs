using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.HRSR;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmEmployeeTraining : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string EmpId { set; get; }

        public frmEmployeeTraining()
        {
            InitializeComponent();
        }

        private void frmEmployeeTraning_Load(object sender, EventArgs e)
        {
            FormatGrid();
            RefreshGrid();
            txtEmp.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmp", "txtTrainingType", "txtTrainingTitle", "txtOrganizationName", "dtStartDate","txtSubject", "txtGrade" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dtStartDate.Text == "  /  /")
            {
                MessageBox.Show("Start Date cannot be empty");
                return;
            }
            if (dtEndDate.Text == "  /  /")
            {
                MessageBox.Show("End Date cannot be empty");
                return;
            }
            try
            {             
                    EmployeeTraining oEmpTran = this.populateEmployeeTraining();
                    short i = hmsSC.SaveEmployeeTraining(oEmpTran);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);                      
                        btnSearch_Click(sender, e);
                        dtStartDate.Text = null;
                        dtEndDate.Text = null;
                        txtTrainingType.Text = "";
                        txtTrainingTitle.Text = "";
                        txtOrganizationName.Text = ""; 
                        txtProvidedBy.Text = "";
                        txtSubject.Text = "";
                        txtGrade.Text = "";
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
        private EmployeeTraining populateEmployeeTraining()
        {
            EmployeeTraining oEmpTraning = new EmployeeTraining();
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtEmp.Text);
            if (txtEmp.Text == oEmpMas.EmpId)
            {           
            oEmpMas.EmpId = txtEmp.Text.ToString();
            oEmpTraning.EmployeeMaster = oEmpMas;
            oEmpTraning.Serial = txtSerial.Text.ToString();
            oEmpTraning.TrainingTitle = txtTrainingTitle.Text;
            oEmpTraning.TrainingType = txtTrainingType.Text;
            oEmpTraning.OrganizationName = txtOrganizationName.Text;
            oEmpTraning.ProvidedBy = txtProvidedBy.Text;
            oEmpTraning.Subject = txtSubject.Text;
            if (dtStartDate.Text != "  /  /")
            {
                oEmpTraning.StartDate = DateTime.ParseExact(dtStartDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            }
            if (dtEndDate.Text != "  /  /")
            {
                oEmpTraning.EndDate = DateTime.ParseExact(dtEndDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            }
            else
            {
                oEmpTraning.EndDate = null;
            }
            oEmpTraning.Grade = txtGrade.Text; 
            oEmpTraning.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = ep.EntryBy;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;

            oEmpTraning.EntryParameter = ep;
            }
            else
            {
                MessageBox.Show("Invalid EmployeeID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return oEmpTraning;
        }

        private void FormatGrid()
        {
            lvEmployeeTraining.CheckBoxes = false;           
            lvEmployeeTraining.Columns.Add("TrainingTitle", 200, HorizontalAlignment.Left);//2
            lvEmployeeTraining.Columns.Add("Type", 0, HorizontalAlignment.Left);//2
            lvEmployeeTraining.Columns.Add("OrganizationName", 200, HorizontalAlignment.Left);//4
            lvEmployeeTraining.Columns.Add("Subject", 200, HorizontalAlignment.Left);//6
            lvEmployeeTraining.Columns.Add("StartDate", 200, HorizontalAlignment.Left);//7
            lvEmployeeTraining.Columns.Add("EndDate", 200, HorizontalAlignment.Left);//8
            lvEmployeeTraining.Columns.Add("Grade", 200, HorizontalAlignment.Left);//9
            lvEmployeeTraining.Columns.Add("Remarks", 200, HorizontalAlignment.Left);//10
            lvEmployeeTraining.Columns.Add("Serial", 0, HorizontalAlignment.Left);//10
        }

        private void LoadListView(string emp)
        {
            lvEmployeeTraining.Items.Clear();

            List<EmployeeTraining> oEmpTraning = new List<EmployeeTraining>();

            oEmpTraning = hmsSC.GetEmpTraining(txtEmp.Text).ToList();

            foreach (EmployeeTraining et in oEmpTraning)
            {
                ListViewItem itm = new ListViewItem(et.TrainingTitle.ToString());//0              
                itm.SubItems.Add(et.TrainingType.ToString());//2
                itm.SubItems.Add(et.OrganizationName.ToString());//4
                itm.SubItems.Add(et.Subject.ToString());//6
                itm.SubItems.Add(et.StartDate.ToString());//7
                itm.SubItems.Add(et.EndDate.ToString());//8
                itm.SubItems.Add(et.Grade.ToString());//9
                itm.SubItems.Add(et.Remarks.ToString());//10
                itm.SubItems.Add(et.Serial.ToString());//10
                lvEmployeeTraining.Items.Add(itm);

            }

        }

        private void RefreshGrid()
        {
            if (EmpId != "")
            {
                txtEmp.Text = EmpId;
                LoadListView(txtEmp.Text);
            }
            if (EmpId == "")
            {
                return;
            }

        } 

        private void btnEdit_Click(object sender, EventArgs e) //update
        {

            List<string> vf = new List<string>() { "txtEmp", "txtTrainingType", "txtTrainingTitle", "txtOrganizationName", "dtStartDate", "txtSubject", "txtGrade" };

            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dtStartDate.Text == "  /  /")
            {
                MessageBox.Show("Start Date cannot be empty");
                return;
            }
            if (dtEndDate.Text == "  /  /")
            {
                MessageBox.Show("End Date cannot be empty");
                return;
            }
            try
            {
                EmployeeTraining oEmpTraning = this.populateEmployeeTraining();
                short i = hmsSC.UpdateEmployeeTraining(oEmpTraning);

                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                    btnSearch_Click(sender, e);
                    dtStartDate.Text = null;
                    dtEndDate.Text = null;
                    txtTrainingType.Text = "";
                    txtTrainingTitle.Text = "";
                    txtOrganizationName.Text = "";
                    txtProvidedBy.Text = "";
                    txtSubject.Text = "";
                    txtGrade.Text = "";
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

        private void lvEmployeeTraining_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmployeeTraining.SelectedItems.Count > 0)
            {
                ListViewItem itm1 = lvEmployeeTraining.SelectedItems[0];
                txtTrainingTitle.Text = itm1.SubItems[0].Text;
                txtTrainingType.Text = itm1.SubItems[1].Text;
                txtOrganizationName.Text = itm1.SubItems[2].Text;
                txtSubject.Text = itm1.SubItems[3].Text;
                dtStartDate.Text = itm1.SubItems[4].Text;
                dtEndDate.Text = itm1.SubItems[5].Text;
                txtGrade.Text = itm1.SubItems[6].Text;
                txtRemarks.Text = itm1.SubItems[7].Text;
                txtSerial.Text = itm1.SubItems[8].Text;

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
                }

                else
                {
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void lvEmployeeTraining_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            lblInfo.Text = "";
            if (lvEmployeeTraining.Items.Count > 0)
            {
                lvEmployeeTraining.Items.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtEmp.Text);
            if (txtEmp.Text != "")
            {
                if (txtEmp.Text == oEmpMas.EmpId)
                {
                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Designation.DesignationId.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Department.DepartmentTitle.ToString();
                }
                LoadListView(txtEmp.Text);
            }
        }
     
        }

    }

