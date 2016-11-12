using AH.DUtility;
using AH.ModuleController.OPDSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AH.ModuleController.UI.OPD.Forms
{
    public partial class frmVistedPatientList : AH.Shared.UI.frmSmartFormStandard
    {
        OPDSR.OPDWSClient opdSc = new OPDSR.OPDWSClient();

        private string doctorID;
        private string departmentID;
        private string unitId;

        public frmVistedPatientList(string departmentID, string unitId, string doctorID)
        {
            InitializeComponent();
            this.doctorID = doctorID;
            this.departmentID = departmentID;
            this.unitId = unitId;
        }
        private void frmVistedPatientList_Load(object sender, EventArgs e)
        {
            lblRecord.Text = string.Empty;
            listViewFormate();
            List<OPDTicketRO> lstkt = opdSc.GetOPDVisitedPatList(departmentID, unitId, doctorID).ToList();

            if (lstkt.Count > 0 )
            {
                LoadPatientsList(lstkt);
                lblRecord.Text = string.Empty;
            }
            if (lstkt.Count == 0)
            {
                lblRecord.Text = "Sorry, No Record Found";
            }
        }

        private void listViewFormate()
        {
            lvTicketList.CheckBoxes = false;
            lvTicketList.Columns.Add("Ticket No", 125, HorizontalAlignment.Left);
            lvTicketList.Columns.Add("HCN", 125, HorizontalAlignment.Left);
            lvTicketList.Columns.Add("Age", 100, HorizontalAlignment.Left);
            lvTicketList.Columns.Add("Serial", 60, HorizontalAlignment.Left);
            lvTicketList.Columns.Add("Ticket Fee", 100, HorizontalAlignment.Left);
            lvTicketList.Columns.Add("Consultants Fee", 120, HorizontalAlignment.Left);
            lvTicketList.Columns.Add("Date", 110, HorizontalAlignment.Left);
        }
        private void LoadPatientsList(List<OPDTicketRO> lstkt)
        {
            lvTicketList.Items.Clear();
            foreach (OPDTicketRO tkt in lstkt)
            {
                ListViewItem itm = new ListViewItem(tkt.TicketNo);
                itm.SubItems.Add(tkt.HCN);
                itm.SubItems.Add(tkt.Age);
                itm.SubItems.Add(tkt.PatSerial);
                itm.SubItems.Add(Convert.ToString(tkt.TicketFee));
                itm.SubItems.Add(Convert.ToString(tkt.Consult_fee));
                itm.SubItems.Add(tkt.EntryDate);
                lvTicketList.Items.Add(itm);
            }
        }
    }
}
