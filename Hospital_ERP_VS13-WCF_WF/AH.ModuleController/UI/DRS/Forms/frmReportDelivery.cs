using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
//using AH.DRS.MODEL;
//using AH.Shared.MODEL;
using AH.ModuleController.DRSSR;
using AH.Shared;



namespace AH.ModuleController.UI.DRS.Forms
{
    public partial class frmReportDelivery : AH.Shared.UI.frmSmartFormStandard
    {
        DRSSR.DRSWSClient drsSc = new DRSSR.DRSWSClient();
        public frmReportDelivery()
        {
            InitializeComponent();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmReportDelivery_Load(object sender, EventArgs e)
        {
            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(drsSc.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Ancillary))), null);
           // cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(drsSc.GetDepartmentsGroupWise("D", Utility.GetDeptCategoryCode(Utility.DeptCategoryCode.Technical))), null);

            FormatGrid();
            RefreshGrid(cboRptGroup.SelectedValue.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //frmDiagnosticResultEntry resE = new frmDiagnosticResultEntry();
            //resE.lbdDepartment.Text = cboDepartment.Text;
            //resE.txtDepartment.Text = cboDepartment.SelectedValue.ToString();
            //resE.lblReportGroup.Text = cboRptGroup.Text;
            //resE.txtReportGroup.Text = cboRptGroup.SelectedValue.ToString();
            //resE.Show();
            //this.Dispose();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboRptGroup.DisplayMember = "Value";
            cboRptGroup.ValueMember = "key";
            cboRptGroup.DataSource = new BindingSource(Utility.VerifyDic(drsSc.GetRptgrpDictByDept("D", cboDepartment.SelectedValue.ToString())), null);
        }
        private void FormatGrid()
        {
            lvUndeliveryList.CheckBoxes = false;

            lvUndeliveryList.Columns.Add("SpecimenCollection ID",200,HorizontalAlignment.Left);
            lvUndeliveryList.Columns.Add("HCN",200,HorizontalAlignment.Left);
            lvUndeliveryList.Columns.Add("Patient Name", 380, HorizontalAlignment.Left);
        }
        private void LoadListView(string rptgr)
        {
           // lvUndeliveryList.Clear();
           // lvUndeliveryList.Items.Clear();
           // List<SpecimenCollection> spccol ;

           // if (rptgr.Length != 0 && rptgr.Length != null)
           // {
           //     spccol = drsSc.GetUndeliveredList(rptgr,"").ToList<SpecimenCollection>();
           // }
           // else
           // {
           //     return;
           // }
           //// int i = 0;

           // foreach (SpecimenCollection spc in spccol)
           // {
           //     ListViewItem itm = new ListViewItem(spc.SpecimenCollectionID);
           //     itm.SubItems.Add(spc.Patient.HCN);
           //     itm.SubItems.Add(spc.Patient.Name);
           //     lvUndeliveryList.Items.Add(itm);
           // }

        }
        private void RefreshGrid(string rptgr)
        {
            LoadListView(rptgr);
        }

        private void cboPatientMr_Click(object sender, EventArgs e)
        {
            lvUndeliveryList.Clear();
            LoadListView(cboRptGroup.SelectedValue.ToString());
        }

    }
}
