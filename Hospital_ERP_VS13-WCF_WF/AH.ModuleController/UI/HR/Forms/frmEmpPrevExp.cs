using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Linq;
using AH.ModuleController.HRSR;
using AH.DUtility;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmEmpPrevExp : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string EmpId { set; get; }

        public frmEmpPrevExp()
        {
            InitializeComponent();
        }

        private void frmEmpPrevExp_Load(object sender, EventArgs e)
        {        
            FormatGrid();
            RefreshGrid();
            txtEmp.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmp", "txtOrganization", "dtDoj", "dtDor", "txtResignCause", "txtJobDesc" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dtDoj.Text == "  /  /")
            {
                MessageBox.Show("Date of Joining cannot be empty");
                return;
            }
            if (dtDor.Text == "  /  /")
            {
                MessageBox.Show("Date of Resignation cannot be empty");
                return;
            }
            try
            {             
                   EmployeePreviousExperience oEmpPrevExe = this.populateEmployeePreviousExprience();
                    string i = hmsSC.SaveEmployeePreviousExperiencen(oEmpPrevExe);
                    if (i == "0")
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i != "")
                    {
                        MessageBox.Show(i, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);                     
                        btnSearch_Click(sender, e);
                        txtDesignation.Text = "";
                        txtOrganization.Text = "";
                        txtResignCause.Text = "";
                        dtDoj.Text = null;
                        dtDor.Text = null;
                        txtJobDesc.Text = "";
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

        private EmployeePreviousExperience populateEmployeePreviousExprience()
        {
            EmployeePreviousExperience oEmpPrevExe = new EmployeePreviousExperience();
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtEmp.Text);
            if (txtEmp.Text == oEmpMas.EmpId)
            {
            oEmpMas.EmpId = txtEmp.Text.ToString();
            oEmpPrevExe.EmployeeMaster = oEmpMas;
            oEmpPrevExe.serial = txtSerial.Text.ToString();
            oEmpPrevExe.OrganizationName = txtOrganization.Text;
            oEmpPrevExe.Designation = txtDesignation.Text.ToString();
            oEmpPrevExe.JobDesc = txtJobDesc.Text;
            oEmpPrevExe.DoJ = DateTime.ParseExact(dtDoj.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            oEmpPrevExe.DoR = DateTime.ParseExact(dtDor.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            oEmpPrevExe.ResignCause = txtResignCause.Text;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = ep.EntryBy;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;

            oEmpPrevExe.Entryparameter = ep;
            }
            else
            {
                MessageBox.Show("Invalid EmployeeID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return oEmpPrevExe;
        }

        private void FormatGrid()
        {
            lvEmployeePreviousExprience.CheckBoxes = false;
            lvEmployeePreviousExprience.Columns.Add("OraganizationName", 200, HorizontalAlignment.Left);
            lvEmployeePreviousExprience.Columns.Add("DesignationID", 200, HorizontalAlignment.Left);
            lvEmployeePreviousExprience.Columns.Add("JobDesc", 200, HorizontalAlignment.Left);
            lvEmployeePreviousExprience.Columns.Add("DateOfJoining", 200, HorizontalAlignment.Left);
            lvEmployeePreviousExprience.Columns.Add("DateOfRetire", 200, HorizontalAlignment.Left);
            lvEmployeePreviousExprience.Columns.Add("ResignCause", 200, HorizontalAlignment.Left);
            lvEmployeePreviousExprience.Columns.Add("Serial", 0, HorizontalAlignment.Left);
        }
        private void LoadListView(string emp)
        {
            lvEmployeePreviousExprience.Items.Clear();

            List<EmployeePreviousExperience> oGetEmpPrevExe = hmsSC.GetEmpPreviousExperience(txtEmp.Text).ToList();

            foreach (EmployeePreviousExperience gep in oGetEmpPrevExe)
            {
                ListViewItem itm = new ListViewItem(gep.OrganizationName.ToString()); //.EmployeeMaster.EmpId.ToString()); 0               
                itm.SubItems.Add(gep.Designation.ToString());//3
                itm.SubItems.Add(gep.JobDesc.ToString());//5
                itm.SubItems.Add(gep.DoJ.ToString("dd/MM/yyyy"));//6
                itm.SubItems.Add(gep.DoR.ToString("dd/MM/yyyy"));//7
                itm.SubItems.Add(gep.ResignCause.ToString());//8
                itm.SubItems.Add(gep.serial.ToString());//8
                lvEmployeePreviousExprience.Items.Add(itm);

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmp", "txtOrganization", "dtDoj", "dtDor", "txtResignCause", "txtJobDesc" };

            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dtDoj.Text == "  /  /")
            {
                MessageBox.Show("Date of Joining cannot be empty");
                return;
            }
            if (dtDor.Text == "  /  /")
            {
                MessageBox.Show("Date of Resignation cannot be empty");
                return;
            }
            try
            {
                EmployeePreviousExperience oEmpPrevExp = this.populateEmployeePreviousExprience();
                short i = hmsSC.UpdateEmployeePreviousExperience(oEmpPrevExp);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);                      
                        btnSearch_Click(sender, e);
                        txtDesignation.Text = "";
                        txtOrganization.Text = "";
                        txtResignCause.Text = "";
                        dtDoj.Text = null;
                        dtDor.Text = null;
                        txtJobDesc.Text = "";
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

        private void lvEmployeePreviousExprience_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmployeePreviousExprience.SelectedItems.Count > 0)
            {
                ListViewItem itm1 = lvEmployeePreviousExprience.SelectedItems[0];
                txtOrganization.Text = itm1.SubItems[0].Text;
                txtDesignation.Text = itm1.SubItems[1].Text;         
                txtJobDesc.Text = itm1.SubItems[2].Text;
                dtDoj.Text = itm1.SubItems[3].Text;
                dtDor.Text = itm1.SubItems[4].Text;
                txtResignCause.Text = itm1.SubItems[5].Text;
                txtSerial.Text = itm1.SubItems[6].Text;
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

        private void lvEmployeePreviousExprience_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            lblInfo.Text = "";
            dtDoj.Text = null;
            dtDor.Text = null;
            if (lvEmployeePreviousExprience.Items.Count > 0)
            {
                lvEmployeePreviousExprience.Items.Clear();
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

        private void txtOrganization_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void txtJobDesc_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
