using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AH.ModuleController.UI.ACCMS.Reports.ParameterForms
{
    public partial class frmACCMSReportMain : AH.Shared.UI.frmSmartFormReportStandard
    {
        public frmACCMSReportMain()
        {
            InitializeComponent();
           
        }
       
        private void treeview_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strTreeName = treeview.SelectedNode.Text;
            //switch (treeview.SelectedNode.Text)
            //{
                //case "Ledger Name":
                //frmACCMSReportLedger frm = new frmACCMSReportLedger();
                //frm.strSelection = "Ledger";
                //frm.ShowDialog();
            //    break ;
            //    case "Group Name":
            //    frmACCMSReportLedger frm1 = new frmACCMSReportLedger();
            //    frm1.strSelection = "Group";
            //    frm1.ShowDialog();
            //    break;


            //}
            if (strTreeName.ToString() == "Ledger Wise")
            {
                frmACCMSReportLedger frm = new frmACCMSReportLedger();
                frm.strSelection = "Ledger";
                frm.ShowDialog();
                //treeview.Selected = false;
            }
            else if (strTreeName.ToString() == "Group Wise")
            {
                frmACCMSReportLedger frm1 = new frmACCMSReportLedger();
                frm1.strSelection = "Group";
                frm1.ShowDialog();
            }
            else if (strTreeName.ToString() == "Voucher Wise")
            {
                frmACCMSReportvoucher frm = new frmACCMSReportvoucher();
                frm.ShowDialog();
            }
            else if (strTreeName.ToString() == "Final Accounts")
            {
                frmACCMSReportaccounts frm = new frmACCMSReportaccounts();
                frm.ShowDialog();
            }
            else if (strTreeName.ToString() == "Cost  Category")
            {
                frmACCMSRReportCostCategory frm = new frmACCMSRReportCostCategory();
                frm.ShowDialog();
            }
            else if (strTreeName.ToString() == "Cash Flow")
            {
                frmACCMSRReportCashflow frm = new frmACCMSRReportCashflow();
                frm.strSelection = "Cashflow";
                frm.ShowDialog();
            }
            else if (strTreeName.ToString() == "Revenue")
            {
                frmACCMSRReportHospitalColl frm = new frmACCMSRReportHospitalColl();
                frm.strSelection = "Revenue";
                frm.ShowDialog();
            }
            else if (strTreeName.ToString() == "Accounts Payable")
            {
                frmACCMSReportLedger frm = new frmACCMSReportLedger();
                frm.strSelection = "Payable";
                frm.ShowDialog();
            }
            else if (strTreeName.ToString() == "Bank Reconcilation")
            {
                frmACCMSReportBankReconcilation frm = new frmACCMSReportBankReconcilation();
                frm.ShowDialog();
            }
            
        
        }

        private void frmACCMSReportMain_Load(object sender, EventArgs e)
        {
            this.Left  = 400;
            treeview.Nodes.Clear();
            treeview.Nodes.Add("Reports");
            treeview.Nodes[0].Nodes.Add("Ledger Wise");
            treeview.Nodes[0].Nodes.Add("Group Wise");
            treeview.Nodes[0].Nodes.Add("Voucher Wise");
            //tvReport.Nodes[0].Nodes.Add("Collection From Staff");
            treeview.Nodes[0].Nodes.Add("Final Accounts");
            treeview.Nodes[0].Nodes.Add("Cost  Category");
            treeview.Nodes[0].Nodes.Add("Cash Flow");
            treeview.Nodes[0].Nodes.Add("Accounts Payable");
            treeview.Nodes[0].Nodes.Add("Bank Reconcilation");
            treeview.Nodes.Add("Hospital Revenue");
            treeview.Nodes[1].Nodes.Add("Revenue");
            treeview.ExpandAll();
        }

        




    }
}
