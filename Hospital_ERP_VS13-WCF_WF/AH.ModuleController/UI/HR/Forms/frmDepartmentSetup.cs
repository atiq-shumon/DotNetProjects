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
using AH.ModuleController.UI.HR.Reports.Viewer;


namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmDepartmentSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();        
        public frmDepartmentSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() {"txtDepartmentName", "txtDeptNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                   Department tdobj = this.PopulateDeptSetup();
                    if (Utility.IsDuplicateFoundInList(lvDept, 1, txtDepartmentName.Text))
                    {
                        MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDepartmentName.Focus();
                        return;
                    }
                else
                {
                    short i = hmsSC.SaveDept(tdobj);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);                                             
                        RefreshGrid();
                        txtDepartmentName.Text = "";
                        txtDeptNameBang.Text = "";
                        txtRemarks.Text = "";
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
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void FormatGrid()
        {
            lvDept.CheckBoxes = false;
            lvDept.Columns.Add("ID", 150, HorizontalAlignment.Center);                   
            lvDept.Columns.Add("Department Name", 410, HorizontalAlignment.Left);
            lvDept.Columns.Add("Department Name(Beng)", 0, HorizontalAlignment.Left);
            lvDept.Columns.Add("Serial", 0, HorizontalAlignment.Center);
            lvDept.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
        }

        private Department PopulateDeptSetup()
        {
            Department tdObj = new Department();
            tdObj.DepartmentID = txtDepartmentID.Text;
            tdObj.DepartmentTitle = txtDepartmentName.Text;
            tdObj.DepartmentTitleBeng = txtDeptNameBang.Text;
            tdObj.Remarks = txtRemarks.Text;

           
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            tdObj.EntryParameter = ep;
            return tdObj;
        }
        private void frmDepartmentSetup_Load(object sender, EventArgs e)
        {                         
            FormatGrid();
            RefreshGrid();
            txtDepartmentName.Focus();
        }
        private void LoadListView()
        {
            lvDept.Items.Clear();
            List<Department> dpt;
            dpt = hmsSC.GetDepartments().ToList();            
            foreach (Department di in dpt)
            {
                ListViewItem itm = new ListViewItem(di.DepartmentID);                            
                itm.SubItems.Add(di.DepartmentTitle);
                itm.SubItems.Add(di.DepartmentTitleBeng);
                itm.SubItems.Add(di.Serial.ToString());
                itm.SubItems.Add(di.Remarks);                
                lvDept.Items.Add(itm);
            }
        }

        private void lvDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDept.SelectedItems.Count > 0)
            {                
                ListViewItem itm = lvDept.SelectedItems[0];
                txtDepartmentID.Text = itm.SubItems[0].Text;
                txtDepartmentName.Text = itm.SubItems[1].Text;
                txtDeptNameBang.Text = itm.SubItems[2].Text;               
                txtRemarks.Text = itm.SubItems[4].Text;
                txtSerial.Text = itm.SubItems[3].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() {"txtDepartmentID","txtDepartmentName", "txtDeptNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (hmsSC.VerifyDeptSetup(txtDepartmentID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDepartmentID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                Department tdobj = this.PopulateDeptSetup();
                if (Utility.IsDuplicateFoundInList(lvDept, 1, txtDepartmentName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDepartmentName.Focus();
                    return;
                }
                else
                {
                    short i = hmsSC.UpdateDept(tdobj);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                        txtDepartmentName.Text = "";
                        txtDeptNameBang.Text = "";
                        txtRemarks.Text = "";
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.departmentList;
            vr.ViewReport();
        }

        private void lvDept_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
        private void txtDepartmentName_TextChanged(object sender, EventArgs e)
        {
            txtDeptNameBang.Text = txtDepartmentName.Text;
        }
    }
}
