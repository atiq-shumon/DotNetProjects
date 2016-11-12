using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.IPDSR;

namespace  AH.ModuleController.UI.IPD.Forms
{
    public partial class frmAdmReasonAssign : AH.Shared.UI.frmSmartFormStandard
    {
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        public frmAdmReasonAssign()
        {
            InitializeComponent();
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
             List<string> vf = new List<string>() { "cboAdmResAssign" };
            Control control = Utility.ReqFieldValidator(this,vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvAdmResAssign, 1, cboDepartment.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboDepartment.Focus();
                    return;
                }

                AdmReasonAssign admass = this.PopulateAdmResAss();
                short i = ipdSc.SaveAdmReasonAss(admass);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    cboDepartment.Select();
                    LoadListView(cboDepartment.SelectedValue.ToString());
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
        //private void RefreshGrid(string departmentID)
        //{
        //    LoadListView(departmentID);
        //}
        private void FormatGrid()
        {
            lvAdmResAssign.CheckBoxes = false;
            lvAdmResAssign.Columns.Add("Department ID", 150, HorizontalAlignment.Center);
            lvAdmResAssign.Columns.Add("Department Name", 300, HorizontalAlignment.Center);
            lvAdmResAssign.Columns.Add("Reason ID", 150, HorizontalAlignment.Center);
            lvAdmResAssign.Columns.Add("Reason Name", 300, HorizontalAlignment.Center);

        }
        private void LoadListView(string departmentID)
        {
            lvAdmResAssign.Items.Clear();

            List<AdmReasonAssign> admns = ipdSc.GetAdmReasonAss().ToList();
           // int i = 0;
            foreach (AdmReasonAssign adm in admns)
            {
                ListViewItem itm = new ListViewItem(adm.Department.DepartmentID);
                itm.SubItems.Add(adm.Department.DepartmentTitle);
                itm.SubItems.Add(adm.AdmissionReason.ID);
                itm.SubItems.Add(adm.AdmissionReason.Title);             
                lvAdmResAssign.Items.Add(itm);

            }

        }

        private AdmReasonAssign PopulateAdmResAss()
        {
            AdmReasonAssign admrobj = new AdmReasonAssign();

            AdmissionReason admr = new AdmissionReason();
            admr.ID = cboAdmResAssign.SelectedValue.ToString();
            admrobj.AdmissionReason = admr;

            Department dpt = new Department();
            dpt.DepartmentID = cboDepartment.SelectedValue.ToString();
            admrobj.Department = dpt;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            admrobj.EntryParameter = ep;

            return admrobj;
        }

        private void frmAdmReasonAssign_Load(object sender, EventArgs e)
        {
            PatientAdmissionUtility obj = new PatientAdmissionUtility();       
            obj.ComboDepartment(cboDepartment);

           
            cboAdmResAssign.DisplayMember = "Value";
            cboAdmResAssign.ValueMember = "Key";
            cboAdmResAssign.DataSource = new BindingSource(Utility.VerifyDic(ipdSc.GetAdmReasonDict("E")), null);

            FormatGrid();
            btnNew.PerformClick();
            cboDepartment.Select();
            LoadListView(cboDepartment.SelectedValue.ToString());
            //LoadListView();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListView(cboDepartment.SelectedValue.ToString());
        }

        private void lvAdmResAssign_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvAdmResAssign.SelectedItems.Count > 0)
                {
                    ListViewItem itm = lvAdmResAssign.SelectedItems[0];
                    cboDepartment.SelectedValue = itm.SubItems[0].Text;
                    cboAdmResAssign.SelectedValue = itm.SubItems[2].Text;
                }
                btnSave.Enabled = false;
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

    }
}
