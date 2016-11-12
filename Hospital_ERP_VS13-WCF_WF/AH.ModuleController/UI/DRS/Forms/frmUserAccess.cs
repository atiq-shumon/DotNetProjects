using AH.DUtility;
using AH.ModuleController.DRSSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace AH.ModuleController.UI.DRS.Forms
{
    public partial class frmUserAccess : AH.Shared.UI.frmSmartFormStandard
    {
        DRSSR.DRSWSClient drsSc = new DRSSR.DRSWSClient();
        public frmUserAccess()
        {
            InitializeComponent();
        }

        private void frmUserAccess_Load(object sender, EventArgs e)
        {
        
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(drsSc.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Ancillary))), null);
                FormatGrid();
        
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboRptSection.DisplayMember = "Value";
                cboRptSection.ValueMember = "Key";
                cboRptSection.DataSource = new BindingSource(Utility.VerifyDic(drsSc.GetRptSecSetup(cboDepartment.SelectedValue.ToString())), null);
            }
        }

        private void cboRptSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRptSection.SelectedValue != "")
            {
                cboRptGroup.DisplayMember = "Value";
                cboRptGroup.ValueMember = "Key";
                cboRptGroup.DataSource = new BindingSource(drsSc.GetRptgrpDic(cboRptSection.SelectedValue.ToString()), null);
            }
            if (cboDepartment.SelectedValue != null)
            {
                LoadListView(cboDepartment.SelectedValue.ToString(), cboRptSection.SelectedValue.ToString());
            }
        }

        private void txtUID_Leave(object sender, EventArgs e)
        {
            lblInfo.Text = "";

            if (txtUID.Text == "")
            {
                lblInfo.Text = "";
                return;
            }
            if (txtUID.Text != string.Empty)
            {
                AH.ModuleController.DRSSR.EmployeeMaster oEmpMas = drsSc.GetEmpoyee(txtUID.Text);

                if (txtUID.Text == oEmpMas.EmpId)
                {
                    lblInfo.Text = oEmpMas.Department.DepartmentTitle.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Designation.DesignationId.ToString();
                    txtUserName.Text = oEmpMas.FirstName;                   
                }
                else
                {
                    MessageBox.Show("Please put a valid user id", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
               //   txtUID.Select();
                    return;
                }

            }

        }
        private void FormatGrid()
        {
            lstUserAccess.Columns.Add("User ID",100, HorizontalAlignment.Left);
            lstUserAccess.Columns.Add("User Name", 200, HorizontalAlignment.Left);
            lstUserAccess.Columns.Add("DeptID", 0, HorizontalAlignment.Left);
            lstUserAccess.Columns.Add("Department Name", 200, HorizontalAlignment.Left);
            lstUserAccess.Columns.Add("RptSecId", 0, HorizontalAlignment.Left);
            lstUserAccess.Columns.Add("Section Name", 200, HorizontalAlignment.Left);
            lstUserAccess.Columns.Add("RptID",0, HorizontalAlignment.Left);
            lstUserAccess.Columns.Add("Reprt Grpoup", 150, HorizontalAlignment.Left);
            lstUserAccess.Columns.Add("Date", 80, HorizontalAlignment.Left);           

        }
        private void LoadListView(string deptID,string rptSectionID)
        {
            lstUserAccess.Items.Clear();
            List<UserReportAccess> oUserList=new List<UserReportAccess> ();
            oUserList = drsSc.GetUserAccess(deptID, rptSectionID).ToList();

            foreach (UserReportAccess oUser in oUserList)
            {
                ListViewItem itm = new ListViewItem(oUser.UserID);
                itm.SubItems.Add(oUser.UserName);
                itm.SubItems.Add(oUser.ReportGroup.Department.DepartmentID);
                itm.SubItems.Add(oUser.ReportGroup.Department.DepartmentTitle);
                itm.SubItems.Add(oUser.ReportGroup.ReportSection.ReportSectionID);
                itm.SubItems.Add(oUser.ReportGroup.ReportSection.ReportSectionTitle);
                itm.SubItems.Add(oUser.ReportGroup.ReportGroupID);
                itm.SubItems.Add(oUser.ReportGroup.ReportGroupTitle);
                itm.SubItems.Add(oUser.EntryParameter.EntryDate.ToString());          
         
                lstUserAccess.Items.Add(itm);
            }

        }
        private UserReportAccess PopulateUserReportAccess()
        {
            UserReportAccess oUserAccess=new UserReportAccess ();
            oUserAccess.UserID = txtUID.Text;

            ReportGroup oRptGroup = new ReportGroup();
            oRptGroup.ReportGroupID = cboRptGroup.SelectedValue.ToString();

            Department oDept = new Department();
            oDept.DepartmentID = cboDepartment.SelectedValue.ToString();
            oRptGroup.Department = oDept;

            ReportSection oRptSec = new ReportSection();
            oRptSec.ReportSectionID = cboRptSection.SelectedValue.ToString();
            oRptGroup.ReportSection  = oRptSec;

            oUserAccess.ReportGroup = oRptGroup;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oUserAccess.EntryParameter = ep;

            return oUserAccess;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtUID", "cboDepartment", "cboRptSection","cboRptGroup"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lstUserAccess, 6, txtUID.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtUID.Focus();
                    return;
                }
                UserReportAccess oUser = this.PopulateUserReportAccess();
                string  i = drsSc.SaveUserReportAccess(oUser);
                if (i != "1")
                {
                    MessageBox.Show(i, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i=="1")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnPatientSearch.PerformClick();                   
                }
                else
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboDepartment.SelectedValue != null)
                {
                    LoadListView(cboDepartment.SelectedValue.ToString(), cboRptSection.SelectedValue.ToString());
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

        private void lstUserAccess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUserAccess.SelectedItems.Count > 0)
            {
                ListViewItem itm = lstUserAccess.SelectedItems[0];
                txtUID.Text = itm.SubItems[0].Text;
                txtUserName.Text = itm.SubItems[1].Text;
                cboDepartment.Text = itm.SubItems[3].Text;
                cboRptSection.Text = itm.SubItems[5].Text;
                cboRptGroup.Text = itm.SubItems[7].Text;
                txtUID.ReadOnly = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtUID.ReadOnly = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }     
    }
}
