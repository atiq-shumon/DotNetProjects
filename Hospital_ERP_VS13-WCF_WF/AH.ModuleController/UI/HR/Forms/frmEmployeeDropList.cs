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
    public partial class frmEmployeeDropList : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmEmployeeDropList()
        {
            InitializeComponent();
        }
        private void frmEmployeeDropList_Load(object sender, EventArgs e)
        {
            cboDropType.DisplayMember = "Value";
            cboDropType.ValueMember = "Key";
            cboDropType.DataSource = new BindingSource(Utility.GetDropTypes(),null);

            FormatGrid();
            //RefreshGrid();
        }
        private void FormatGrid()
        {
            lvDropList.CheckBoxes = false;
            lvDropList.Columns.Add("ID", 80, HorizontalAlignment.Center);
            lvDropList.Columns.Add("Name", 250, HorizontalAlignment.Left);
            lvDropList.Columns.Add("Drop Type", 150, HorizontalAlignment.Left);
            lvDropList.Columns.Add("Drop Date", 180, HorizontalAlignment.Left);
            lvDropList.Columns.Add("Drop Effective Date", 180, HorizontalAlignment.Left);
            lvDropList.Columns.Add("Serial", 0, HorizontalAlignment.Left);
            lvDropList.Columns.Add("Remarks", 290, HorizontalAlignment.Left);
            lvDropList.Columns.Add("Verified By", 0, HorizontalAlignment.Left);
            lvDropList.Columns.Add("Verified By Name", 0, HorizontalAlignment.Left);
        }
        private EmployeeDropList PopulateDropList()
        {
            EmployeeDropList oDropList = new EmployeeDropList();
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas.EmpId = txtEmpID.Text.ToString();
            oDropList.EmployeeMaster = oEmpMas;
            oDropList.DropTypeID = cboDropType.SelectedValue.ToString();
            oDropList.DropDate = dtDropDate.Text.ToString();
            oDropList.DropEffectiveDate = dtDropEffectiveDate.Text.ToString();
            oDropList.FinalizeBy = "0";
            oDropList.Remarks = txtRemarks.Text.ToString();
            oDropList.ListSerial = txtListSerial.Text.ToString();
            oDropList.VerifiedBy = txtVerifiedBy.Text.ToString();

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oDropList.EntryParameter = ep;
            return oDropList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmpID", "cboDropType" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                  EmployeeDropList oDropList = this.PopulateDropList();
                  short i = hmsSC.SaveEmployeeDropList(oDropList);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid(cboDropType.SelectedValue.ToString());
                        txtEmpID.Text = "";
                        lblInfo.Text = "";
                        txtVerifiedBy.Text = "";
                        txtVerifiedByName.Text = "";
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
        private void RefreshGrid(string DropType)
        {
            LoadListView(cboDropType.SelectedValue.ToString());
        }
        private void LoadListView(string DropType)
        {
            lvDropList.Items.Clear();
            List<EmployeeDropList> oDropLists = hmsSC.GetDropListByType(cboDropType.SelectedValue.ToString()).ToList();
            foreach (EmployeeDropList oDropList in oDropLists)
            {
                ListViewItem itm = new ListViewItem(oDropList.EmployeeMaster.EmpId);
                itm.SubItems.Add(oDropList.EmployeeMaster.Name);
                itm.SubItems.Add(oDropList.DropTypeID.ToString());
                itm.SubItems.Add(oDropList.DropDate.ToString());
                itm.SubItems.Add(oDropList.DropEffectiveDate.ToString());
                itm.SubItems.Add(oDropList.ListSerial);
                itm.SubItems.Add(oDropList.Remarks);
                itm.SubItems.Add(oDropList.VerifiedBy);
                itm.SubItems.Add(oDropList.VerifiedByName);
                lvDropList.Items.Add(itm);
            }

        }

        private void lvDropList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDropList.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDropList.SelectedItems[0];
                txtEmpID.Text = itm.SubItems[0].Text;
                txtName.Text = itm.SubItems[1].Text;
                cboDropType.Text = itm.SubItems[2].Text.ToString();
                dtDropDate.Text = itm.SubItems[3].Text;
                dtDropEffectiveDate.Text = itm.SubItems[4].Text;
                txtListSerial.Text = itm.SubItems[5].Text;
                txtRemarks.Text = itm.SubItems[6].Text;
                txtVerifiedBy.Text = itm.SubItems[7].Text;
                txtVerifiedByName.Text = itm.SubItems[8].Text;
            }
        }

        private void lvDropList_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmpID", "cboDropType" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                EmployeeDropList oDropList = this.PopulateDropList();
                short i = hmsSC.UpdateEmployeeDropList(oDropList);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid(cboDropType.SelectedValue.ToString());
                    txtEmpID.Text = "";
                    lblInfo.Text = "";
                    txtVerifiedBy.Text = "";
                    txtVerifiedByName.Text = "";
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

        private void txtEmpID_Leave(object sender, EventArgs e)
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
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnNew.PerformClick();
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadListView(cboDropType.SelectedValue.ToString());
        }

        private void txtVerifiedBy_Leave(object sender, EventArgs e)
        {
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtVerifiedBy.Text);
            if (txtVerifiedBy.Text != "")
            {
                if (txtVerifiedBy.Text == oEmpMas.EmpId)
                {
                    txtVerifiedByName.Text = oEmpMas.FirstName;
                }

                else
                {
                    MessageBox.Show("Invalid Employee ID!!!Please Enter Correct ID", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtVerifiedByName.Text = "";
                    txtVerifiedBy.Focus();
                }
            }
        }

    }
}
