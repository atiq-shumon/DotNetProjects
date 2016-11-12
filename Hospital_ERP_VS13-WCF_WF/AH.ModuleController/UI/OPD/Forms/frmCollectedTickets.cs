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
    public partial class frmCollectedTickets : AH.Shared.UI.frmSmartFormStandard
    {
        OPDSR.OPDWSClient opdSc = new OPDSR.OPDWSClient();
        public frmCollectedTickets()
        {
            InitializeComponent();
        }
        private void frmCollectedTickets_Load(object sender, EventArgs e)
        {
            txtUserId.ReadOnly = true;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            txtUserId.Text = ep.EntryBy;
            dtpDate.Text =Convert.ToString(DateTime.Today);
            listViewFormate();
        }
        private void listViewFormate()
        {
            lvTicketList.CheckBoxes = false;
            lvTicketList.Columns.Add("Ticket No", 150, HorizontalAlignment.Left);
            lvTicketList.Columns.Add("HCN", 150, HorizontalAlignment.Left);
            lvTicketList.Columns.Add("Ticket Status",0, HorizontalAlignment.Left);
            lvTicketList.Columns.Add("Ticket Fee", 130, HorizontalAlignment.Left);
            lvTicketList.Columns.Add("Account Flag", 123, HorizontalAlignment.Left);
        }
        private void btnShowTicketList_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text != "" && dtpDate.Text != "")
            {
                lvTicketList.Items.Clear();
                List<Ticket> lstkt = opdSc.GetTicketList( txtUserId.Text,  dtpDate.Text).ToList();
                if (lstkt.Count != 0)
                {
                    foreach (Ticket tkt in lstkt)
                    {
                        ListViewItem itm = new ListViewItem(tkt.TicketNo);
                        itm.SubItems.Add(tkt.Patient.HCN);

                        if (tkt.TicketStatus == "N")
                            itm.SubItems.Add("New");
                        if (tkt.TicketStatus == "V")
                            itm.SubItems.Add("Visiting");
                        if (tkt.TicketStatus == "S")
                            itm.SubItems.Add("Shown");
                        if (tkt.TicketStatus == "R")
                            itm.SubItems.Add("Refunded");
                        if (tkt.TicketStatus == "C")
                            itm.SubItems.Add("Canceled");

                        itm.SubItems.Add(Convert.ToString(tkt.TicketFee));
                        itm.SubItems.Add(tkt.acc_close_flag);
                        lvTicketList.Items.Add(itm);
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, No Record Found");
                }
            }
        }

       }
}
