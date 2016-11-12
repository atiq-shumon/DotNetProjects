using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.ModuleController.FNBSR;
using AH.DUtility;
using System.Collections.Generic;
using AH.ModuleController.UI.FNB.Reports.Viewer;
using AH.Shared.UI;
using System;

namespace AH.ModuleController.UI.FNB.Forms
{
    public partial class frmVisitorsDetails : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        List<Visitors> Vo;
        public frmVisitorsDetails()
        {
            InitializeComponent();
        }


        private void FormaList()
        {
            lvwVisitorsDetails.CheckBoxes = false;
            lvwVisitorsDetails.Columns.Add("Trans. No", 200, HorizontalAlignment.Left);
            lvwVisitorsDetails.Columns.Add("Invoice No", 200, HorizontalAlignment.Left);
            lvwVisitorsDetails.Columns.Add("Trans. Date", 120, HorizontalAlignment.Left);
            lvwVisitorsDetails.Columns.Add("Net.Amount ", 130, HorizontalAlignment.Left);
            lvwVisitorsDetails.Columns.Add("Card No ", 0, HorizontalAlignment.Left);
            lvwVisitorsDetails.Columns.Add("Entry.by ", 200, HorizontalAlignment.Left);
        }

        private void frmVisitorsDetails_Load(object sender, System.EventArgs e)
        {
            try
            {
                FormaList();
                LoadListView();
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

        private void LoadListView()
        {
            try
            {
                lvwVisitorsDetails.Items.Clear();
                Vo = fnbs.GetvisitorsHistory(Utility.UserId.ToString()).ToList();
                if (Vo.Count > 0)
                {
                    foreach (Visitors objvs in Vo)
                    {
                        double dblNetPaid;
                        dblNetPaid = Math.Round(Convert.ToDouble(objvs.NetPaid), 0);
                        ListViewItem itm = new ListViewItem(objvs.TransNo);
                        itm.SubItems.Add(objvs.InvoiceNo.ToString());
                        itm.SubItems.Add(objvs.entryDate.ToString());
                        itm.SubItems.Add(dblNetPaid.ToString());
                        itm.SubItems.Add(objvs.empID.ToString());
                        itm.SubItems.Add(objvs.entryby);
                        lvwVisitorsDetails.Items.Add(itm);
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

        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            if (lvwVisitorsDetails.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvwVisitorsDetails.SelectedItems[0];
                frmReportViewer frm = new frmReportViewer();
                frm.selector = ViewerSelector.visitortSlip;
                frm.Where = itm.SubItems[1].Text.ToString();
                frm.CallName = "Visitors";
                EmployeeMaster oEmpMas = new EmployeeMaster();
                //EmployeeJobInformation oEmpJobInfo = new EmployeeJobInformation();
                oEmpMas = fnbs.GetEmpMaster(itm.SubItems[5].Text.ToString());
                if (itm.SubItems[5].Text.ToString() == oEmpMas.EmpId)
                {
                    frm.where1  = oEmpMas.FirstName;
                }
                else
                {
                    frm.where1 = "";
                }

                //frm.CallName = "";
                frm.ShowDialog();
               
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(Vo, txtSearch.Text);
        }

        private void SearchListView(IEnumerable<Visitors> tests, string searchString )
        {

            try
            {
                IEnumerable<Visitors> query;
                if (tests != null)
                {
                    query = (from test in tests
                             where test.TransNo.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                             select test);


                    lvwVisitorsDetails.Items.Clear();
                    foreach (Visitors objvs in query)
                    {
                        ListViewItem itm = new ListViewItem(objvs.TransNo);
                        itm.SubItems.Add(objvs.InvoiceNo.ToString());
                        itm.SubItems.Add(objvs.entryDate.ToString());
                        itm.SubItems.Add(objvs.entryby);
                        itm.SubItems.Add(objvs.NetPaid.ToString());
                        lvwVisitorsDetails.Items.Add(itm);
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmReportViewer frm = new frmReportViewer();
            frm.selector = ViewerSelector.test ;
            frm.ShowDialog();
        }


        

        private void btnShow_Click(object sender, EventArgs e)
        {
            
           try
            {
                lvwVisitorsDetails.Items.Clear();
                Vo = fnbs.GetvisitorsHistoryDateRange(Utility.UserId.ToString(), dteFDate.Value.ToShortDateString(), dteTDate.Value.ToShortDateString()).ToList();
                if (Vo.Count > 0)
                {
                    foreach (Visitors objvs in Vo)
                    {
                        double dblNetPaid;
                        dblNetPaid = Math.Round(Convert.ToDouble(objvs.NetPaid), 0);
                        ListViewItem itm = new ListViewItem(objvs.TransNo);
                        itm.SubItems.Add(objvs.InvoiceNo.ToString());
                        itm.SubItems.Add(objvs.entryDate.ToString());
                        itm.SubItems.Add(dblNetPaid.ToString());
                        itm.SubItems.Add(objvs.empID.ToString());
                        itm.SubItems.Add(objvs.entryby);
                        lvwVisitorsDetails.Items.Add(itm);
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





    }
}
