using AH.DUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.DRSSR;
using System.Linq;

namespace AH.ModuleController.UI.DRS.Forms
{
    public partial class frmSpecimenLabelList : AH.Shared.UI.frmSmartFormStandard
    {       
        DRSSR.DRSWSClient drsSc = new DRSSR.DRSWSClient();
        private string deptId, reportGroupId;
       
        List<SpecimenCollection> spccol = new List<SpecimenCollection>();
        List<SpecimenCollection> spccolList = new List<SpecimenCollection>();

        public frmSpecimenLabelList(string deptId,string reportGroupId)
        {           
            InitializeComponent();
            this.deptId = deptId;
            this.reportGroupId = reportGroupId;           
        }
        private void frmSpecimenLabelList_Load(object sender, EventArgs e)
        {                 
            FormatGrid();
            if (deptId == "" && reportGroupId == "")
            {
                LoadListView();
            }
            else
            {
                LoadListView(deptId, reportGroupId);
            }
        }
        private void FormatGrid()
        {
            lvSpecimenLabelList.CheckBoxes = false;
            lvSpecimenLabelList.Columns.Add("Patient Name",200, HorizontalAlignment.Left);
            lvSpecimenLabelList.Columns.Add("SpecimenCollection ID", 150, HorizontalAlignment.Left);
            lvSpecimenLabelList.Columns.Add("Money Receipt", 150, HorizontalAlignment.Left);
            lvSpecimenLabelList.Columns.Add("HCN", 150, HorizontalAlignment.Left);
            lvSpecimenLabelList.Columns.Add("Date", 200, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvSpecimenLabelList.Items.Clear();           
            spccol = drsSc.GetDiagnosticMoneyReceiptList().ToList();
            foreach (SpecimenCollection spc in spccol)
            {
                ListViewItem itm = new ListViewItem(spc.Patient.Name);
                itm.SubItems.Add(spc.SpecimenCollectionID);
                itm.SubItems.Add(spc.DiagnosticMR.MRNo);
                itm.SubItems.Add(spc.Patient.HCN);              
                itm.SubItems.Add(spc.EntryParameter.EntryDate.ToString());
                lvSpecimenLabelList.Items.Add(itm);
            }

        }
        private void LoadListView(string deptId,string reportGroupID)
        {
            lvSpecimenLabelList.Items.Clear();           
            spccolList = drsSc.GetSpecimenList(deptId, reportGroupID).ToList();
            foreach (SpecimenCollection spc in spccolList)
            {
                ListViewItem itm = new ListViewItem(spc.Patient.Name);
                itm.SubItems.Add(spc.SpecimenCollectionID);
                itm.SubItems.Add(spc.DiagnosticMR.MRNo);
                itm.SubItems.Add(spc.Patient.HCN);
                itm.SubItems.Add(spc.EntryParameter.EntryDate.ToString());
                lvSpecimenLabelList.Items.Add(itm);
            }

        }
        private void lvSpecimenLabelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSpecimenLabelList.SelectedItems.Count > 0 && spccol.Count>0)
            {
                ListViewItem itm = lvSpecimenLabelList.SelectedItems[0];
                frmSpecimenCollection frmSpc = new frmSpecimenCollection(itm.SubItems[2].Text,"O");
               // frmSpc.frmLabel.Text = "Diagnostic Money Receipt List";
                frmSpc.ShowDialog();
                this.Dispose();
            }
            if (lvSpecimenLabelList.SelectedItems.Count > 0 && spccolList.Count>0)
            {
                ListViewItem itm = lvSpecimenLabelList.SelectedItems[0];
                frmSpecimenReceived frmSpc = new frmSpecimenReceived(itm.SubItems[1].Text);              
                frmSpc.ShowDialog();
                this.Dispose();
            }
            
        }

    }
}
