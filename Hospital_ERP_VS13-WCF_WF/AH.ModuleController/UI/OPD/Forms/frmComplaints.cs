using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.OPDSR;

namespace AH.ModuleController.UI.OPD.Forms
{
    public partial class frmComplaints : AH.Shared.UI.frmSmartFormStandard
    {
        OPDSR.OPDWSClient opdSc = new OPDSR.OPDWSClient();
        public frmComplaints()
        {
            InitializeComponent();
        }
        List<Complaints> lscom;
        private void btnSave_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "txtComplaintsTitle", "txtComplaintsTitleBeng"};
            Control control = Utility.ReqFieldValidator(this,vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
           
            if (Utility.IsDuplicateFoundInList(lvComplaints, 2, txtComplaintsTitle.Text))
            { 
                MessageBox.Show("This Complain Already exists!!");
                return;
            }
            try
            {
                Complaints com = this.populateComplaints();
                short i = opdSc.SaveComplaint(com);
                if (i == 0)
                {
                    MessageBox.Show("Complaint Saving Failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    btnNew.PerformClick();
                    txtComplaintsTitle.Select();
                }
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private Complaints populateComplaints()
        {
            
            Complaints com = new Complaints();
            com.ID = txtComplaints.Text;
            com.ComplaintTitle = txtComplaintsTitle.Text;
            com.ComplaintTitleBeng = txtComplaintsTitleBeng.Text;
            com.Remarks = txtRemarks.Text;

            Department dpt = new Department();
            dpt.DepartmentID = cboDepartment.SelectedValue.ToString();

            com.Department = dpt;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            com.EntryParameter = ep;

            return com;
        }
        private void FormatGrid()
        {
            lvComplaints.CheckBoxes = false;
            lvComplaints.Columns.Add("Complaint ID",0,HorizontalAlignment.Left);
            lvComplaints.Columns.Add("Complaint Title",400,HorizontalAlignment.Left);
            lvComplaints.Columns.Add("Complaint Title Beng", 0, HorizontalAlignment.Left);
            lvComplaints.Columns.Add("Department",250,HorizontalAlignment.Left);
            lvComplaints.Columns.Add("Remarks", 232, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvComplaints.Items.Clear();
            lscom = opdSc.GetComplaints().ToList();
            //int i = 0;
            foreach (Complaints com in lscom)
            {
                ListViewItem itm = new ListViewItem(com.ID);
                itm.SubItems.Add(com.ComplaintTitle);
                itm.SubItems.Add(com.ComplaintTitleBeng);
                itm.SubItems.Add(com.Department.DepartmentTitle);
                itm.SubItems.Add(com.Remarks);
                lvComplaints.Items.Add(itm);
            }
        }

        private void frmComplaints_Load(object sender, EventArgs e)
        {
            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            //cboDepartment.DataSource = new BindingSource(opdSc.GetDeptGroupWise("D"), null);   
            cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(opdSc.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical))), null);
            FormatGrid();
            LoadListView();
            cboDepartment.Select();
            btnEdit.Enabled = false;
        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void lvComplaints_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvComplaints.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvComplaints.SelectedItems[0];
                txtComplaints.Text = itm.SubItems[0].Text;
                txtComplaintsTitle.Text = itm.SubItems[1].Text;
                txtComplaintsTitleBeng.Text = itm.SubItems[2].Text;
                cboDepartment.Text = itm.SubItems[3].Text;
                txtRemarks.Text = itm.SubItems[4].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtComplaintsTitle", "txtComplaintsTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                control.Focus();
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvComplaints, 2, txtComplaintsTitle.Text))
            {
                MessageBox.Show("This Complain Already exists!!");
                return;
            }
            try
            {
                Complaints com = this.populateComplaints();
                short i = opdSc.UpdateComplaint(com);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();                   
                    txtComplaintsTitle.Select();
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void lvComplaints_Click(object sender, EventArgs e)
        {
           // btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            LoadListView();
            cboDepartment.Select();
        }

        private void txtComplaintsTitle_TextChanged(object sender, EventArgs e)
        {
            txtComplaintsTitleBeng.Text = txtComplaintsTitle.Text;
        }

        private void txtComplaintsTitle_KeyUp(object sender, KeyEventArgs e)
       {
            if (txtComplaintsTitle.Text != "") //&& lvComplaints.Items.Count > 0)
            {
                GetSimilerComplaintList(lvComplaints, txtComplaintsTitle.Text);
            }
            else
            {
                LoadListView();
            }
        }

        private void GetSimilerComplaintList(ListView lvComplaints, string txtComplaintsTitle)
        {
            IEnumerable<Complaints> ComplaintsListLocal;

            if (!(txtComplaintsTitle.Length > 0))
            {
                ComplaintsListLocal = lscom;
            } 
            else
            {
                ComplaintsListLocal = lscom.Where(x => x.ComplaintTitle.ToLower().Contains(txtComplaintsTitle.ToLower()));
                
            }
            lvComplaints.Items.Clear();   
            foreach (Complaints Comp in ComplaintsListLocal)
            {
                ListViewItem itm = new ListViewItem(Comp.ID);
                itm.SubItems.Add(Comp.ComplaintTitle);
                itm.SubItems.Add(Comp.ComplaintTitleBeng);
                itm.SubItems.Add(Comp.Department.DepartmentTitle);
                itm.SubItems.Add(Comp.Remarks);
                lvComplaints.Items.Add(itm);
            }
        }

        private void txtComplaintsTitle_Leave(object sender, EventArgs e)
        {
            if (txtComplaintsTitle.Text != "")
            {
               // txtComplaintsTitle.Text = Utility.ProperCase(txtComplaintsTitle.Text);
            }
        }
    }
}
