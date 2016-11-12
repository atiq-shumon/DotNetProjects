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
    public partial class frmEmployeeDegreeSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmEmployeeDegreeSetup()
        {
            InitializeComponent();
        }

        private void txtEmpID_Leave(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (txtEmpID.Text == "")
            {
                lblInfo.Text = "";
                return;
            }
            if (txtEmpID.Text != "")
            {
                EmployeeMaster oEmpMas = new EmployeeMaster();
                oEmpMas = hmsSC.GetEmpMaster(txtEmpID.Text);
                if (txtEmpID.Text == oEmpMas.EmpId)
                {

                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Designation.DesignationId.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Department.DepartmentTitle.ToString();
                }

                else
                {
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmEmployeeDegreeSetup_Load(object sender, EventArgs e)
        {
            FormatGrid();
            txtEmpID.Focus();
        }
        private void FormatGrid()
        {
            lvEmployeeDegree.CheckBoxes = false;
            lvEmployeeDegree.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lvEmployeeDegree.Columns.Add("Name", 250, HorizontalAlignment.Left);
            lvEmployeeDegree.Columns.Add("Degree Line 1", 200, HorizontalAlignment.Left);
            lvEmployeeDegree.Columns.Add("Degree Line 2", 150, HorizontalAlignment.Left);
            lvEmployeeDegree.Columns.Add("Degree Line 3", 150, HorizontalAlignment.Left);
            lvEmployeeDegree.Columns.Add("Degree Line 4", 150, HorizontalAlignment.Left);          
        }
        private void LoadEmployeeDegree(string EmpID)
        {
            lvEmployeeDegree.Items.Clear();
            List<EmployeeDegree> oEmpDegrees = hmsSC.GetEmployeeDegreeSetup(txtEmpID.Text).ToList();

            foreach (EmployeeDegree oEmpDegree in oEmpDegrees)
            {
                ListViewItem itm = new ListViewItem(oEmpDegree.EmployeeID.ToString());              
                itm.SubItems.Add(oEmpDegree.EmployeeName.ToString());
                itm.SubItems.Add(oEmpDegree.DegreeLine1.ToString());
                itm.SubItems.Add(oEmpDegree.DegreeLine2.ToString());
                itm.SubItems.Add(oEmpDegree.DegreeLine3.ToString());
                itm.SubItems.Add(oEmpDegree.DegreeLine4.ToString());              
                lvEmployeeDegree.Items.Add(itm);

            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(txtEmpID.Text !="")
            {
                LoadEmployeeDegree(txtEmpID.Text.ToString());
            }
        }

        private EmployeeDegree populateEmployeeDegree()
        {
            EmployeeDegree oEmpDegree = new EmployeeDegree();
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtEmpID.Text);
            if (txtEmpID.Text == oEmpMas.EmpId)
            {
                oEmpDegree.EmployeeID = txtEmpID.Text.ToString();
                oEmpDegree.DegreeLine1 = txtDegreeLine1.Text.ToString();
                oEmpDegree.DegreeLine2 = txtDegreeLine2.Text;
                oEmpDegree.DegreeLine3 = txtDegreeLine3.Text;
                oEmpDegree.DegreeLine4 = txtDegreeLine4.Text;              

                EntryParameter ep = new EntryParameter();
                ep.EntryBy = Utility.UserId;
                ep.UpdateBy = ep.EntryBy;
                ep.CompanyID = Utility.CompanyID;
                ep.LocationID = Utility.LocationID;
                ep.MachineID = Utility.MachineID;

                oEmpDegree.EntryParameter = ep;
            }
            else
            {
                MessageBox.Show("Invalid EmployeeID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return oEmpDegree;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmpID", "txtDegreeLine1"};
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }            
            try
            {
                EmployeeDegree oEmpDegree = this.populateEmployeeDegree();
                short i = hmsSC.SaveEmployeeDegreeSetup(oEmpDegree);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnShow_Click(sender, e);
                    txtDegreeLine1.Text = "";
                    txtDegreeLine2.Text = "";
                    txtDegreeLine3.Text = "";
                    txtDegreeLine4.Text = "";                   
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
            List<string> vf = new List<string>() { "txtEmpID", "txtDegreeLine1"};
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                EmployeeDegree oEmpDegree = this.populateEmployeeDegree();
                short i = hmsSC.UpdateEmployeeDegreeSetup(oEmpDegree);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnShow_Click(sender, e);
                    txtDegreeLine1.Text = "";
                    txtDegreeLine2.Text = "";
                    txtDegreeLine3.Text = "";
                    txtDegreeLine4.Text = "";
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

        private void lvEmployeeDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmployeeDegree.SelectedItems.Count > 0)
            {
                ListViewItem itm1 = lvEmployeeDegree.SelectedItems[0];
                txtEmpID.Text = itm1.SubItems[0].Text;
                txtDegreeLine1.Text = itm1.SubItems[2].Text;
                txtDegreeLine2.Text = itm1.SubItems[3].Text;
                txtDegreeLine3.Text = itm1.SubItems[4].Text;
                txtDegreeLine4.Text = itm1.SubItems[5].Text;
               
            }
        }

        private void lvEmployeeDegree_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            lblInfo.Text = "";
            if (lvEmployeeDegree.Items.Count > 0)
            {
                lvEmployeeDegree.Items.Clear();
            }
        }
     
    }
}
