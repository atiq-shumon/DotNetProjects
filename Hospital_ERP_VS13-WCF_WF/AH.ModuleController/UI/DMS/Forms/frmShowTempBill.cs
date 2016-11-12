using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.DMSSR;

namespace AH.ModuleController.UI.DMS.Forms
{
    public partial class frmShowTempBill : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSr = new DMSSR.DMSWSClient();
        string entryby;

        public frmShowTempBill()
        {
            InitializeComponent();
            lvDraftList.Items.Add("");

        }
        private void FormatGrid()
        {
            lvDraftList.CheckBoxes = false;
            lvDraftList.Columns.Add("Time", 170, HorizontalAlignment.Left);
            lvDraftList.Columns.Add("Draft No", 70, HorizontalAlignment.Left);
            lvDraftList.Columns.Add("HCN", 150, HorizontalAlignment.Left);
            lvDraftList.Columns.Add("TicketNo", 190, HorizontalAlignment.Left);
            lvDraftList.Columns.Add("Patient Name", 180, HorizontalAlignment.Left);
            lvDraftList.Columns.Add("Fee", 70, HorizontalAlignment.Left);
        }
        private void LoadListView(string entryby)
        {
            lvDraftList.Items.Clear();

            List<DiagnosticMR> diag = dmsSr.GetDraftList(entryby).ToList();

            foreach (DiagnosticMR dg in diag)
            {
                ListViewItem itm = new ListViewItem(dg.Date.ToString());
                itm.SubItems.Add(dg.DraftNo);
                itm.SubItems.Add(dg.Patient.HCN);
                itm.SubItems.Add(dg.Prescription.TicketNo);
                itm.SubItems.Add(dg.Patient.Name);
                itm.SubItems.Add(dg.test.Fee.ToString());
                lvDraftList.Items.Add(itm);

            }
        }


        private void frmShowTempBill_Load(object sender, EventArgs e)
        {
            txtEntryBy.Text = Utility.UserId;
            FormatGrid();
            LoadListView(txtEntryBy.Text);
        }

        private void cboPatientSearch_Click(object sender, EventArgs e)
        {


        }

        private void lvDraftList_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void lvDraftList_DoubleClick(object sender, EventArgs e)
        {

            //var item = sender as ListView;
            //string oldvalue = item.Items[0].Text;
            //item.Items[0].Text = textBox1.Text;
        }
    }
}
