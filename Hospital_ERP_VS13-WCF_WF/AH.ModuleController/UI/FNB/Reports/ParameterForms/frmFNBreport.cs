using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.UI.FNB.Reports.Viewer;
using AH.ModuleController.UI.FNB.Reports.ParameterForms;
namespace AH.ModuleController.UI.FNB.Reports
{
    public partial class frmFNBreport : AH.Shared.UI.frmSmartFormReportStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        private const string mskdate = "  /  /";

        public frmFNBreport()
        {
            InitializeComponent();
        }

        private void frmFNBreport_Load(object sender, EventArgs e)
        {
            tvReport.Nodes.Clear();
            tvReport.Nodes.Add("Reports");
            tvReport.Nodes[0].Nodes.Add("Food Item");
            tvReport.Nodes[0].Nodes.Add("Collection From Staff");
            tvReport.Nodes[0].Nodes.Add("Collection From Visitors");
            //tvReport.Nodes[0].Nodes.Add("Collection From Staff");
            tvReport.Nodes[0].Nodes.Add("Issue  Report For Staff");
            tvReport.Nodes[0].Nodes.Add("User Wise Sales Report");
            tvReport.Nodes[0].Nodes.Add("Inventory Report");
            tvReport.Nodes[0].Nodes.Add("Meal Register");
            tvReport.Nodes[0].Nodes[6].Nodes.Add("Month Wise Meal Register");


            tvReport.ExpandAll();

            cboDate.SelectedIndex = 0;
            mskFDate.Text =  DateTime.Now.ToString("dd/MM/yyyy");
            mskTDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
            cbofoodCat.ValueMember = "key";
            cbofoodCat.DisplayMember = "value";
            cbofoodCat.DataSource = new BindingSource(fnbs.GetFoodCategory(), null);
        }

        private void tvReport_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strTreeName = tvReport.SelectedNode.Text;
            if (strTreeName.ToString() == "Food Item")
            {
                cbofoodCat.Enabled = true;
                GrpSelection.Visible = false;
                grpCardNo.Visible = false;
                GrpDate.Visible = false;
                grpuserWiseSelection.Visible = false;
            }
            else if (strTreeName.ToString() == "Daily Collection")
            {
                cbofoodCat.Enabled = false;
                GrpDate.Visible = true;
                GrpSelection.Visible = true;
                grpCardNo.Visible = false;
                grpuserWiseSelection.Visible = false;

            }
            else if (strTreeName.ToString() == "Collection From Staff")             
            {
                cbofoodCat.Enabled = false;
                GrpSelection.Visible = true;
                GrpDate.Visible = true;
                grpCardNo.Visible = false;
                grpuserWiseSelection.Visible = false;
            }

            else if (strTreeName.ToString() == "Issue  Report For Staff")
            {
                cbofoodCat.Enabled = false;
                GrpSelection.Visible = false;
                grpuserWiseSelection.Visible = false;
                grpCardNo.Visible = false;
                GrpDate.Visible = true;
            }

            else if (strTreeName.ToString() == "Collection From Visitors")
            {
                cbofoodCat.Enabled = false;
                GrpSelection.Visible = true;
                grpuserWiseSelection.Visible = false;
               // GrpSelection.Visible = false;
                radSumm.Checked = true;
                GrpDate.Visible = true;
                grpCardNo.Visible = false;
            }

            else if (strTreeName.ToString() == "User Wise Sales Report")
            {
                cbofoodCat.Enabled = false;
                GrpSelection.Visible = false;
                grpuserWiseSelection.Visible = true;
                GrpDate.Visible = true;
                radAll.Checked = true;
               // grpCardNo.Visible = true;
            }

            else if (strTreeName.ToString() == "Inventory Report")
            {
                cbofoodCat.Enabled = false;
                GrpSelection.Visible = false;
                grpuserWiseSelection.Visible = false;
                GrpDate.Visible = true;
                radAll.Checked = false;
                // grpCardNo.Visible = true;
            }

            else if (strTreeName.ToString() == "Month Wise Meal Register")
            {
                frmRptMealRegister frm = new frmRptMealRegister();
                frm.ShowDialog();
                
            }



        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            string strTreeName = tvReport.SelectedNode.Text;
            int intSelection = 0;

            if (tvReport.SelectedNode.Text != "Food Item")
            {
                if (cboDate.Text == "--Select--")
                {
                    MessageBox.Show("Please Select the date");
                    cboDate.Focus();
                    return;
                }
            }


            if (mskFDate.Text == mskdate)
            {
                mskFDate.Focus(); 
                return;
            }

            if (mskTDate.Text == mskdate)
            {
                mskTDate.Focus();
                return;
            }

          
            if (radSumm.Checked== true)
            {
                intSelection = 1;
            }
            if (radDetails.Checked == true)
            {
                intSelection = 2;
            }

            if (strTreeName.ToString() == "Food Item")
            {
                frmReportViewer frm = new frmReportViewer();
                frm.selector = ViewerSelector.Fooditems;
                frm.Where = cbofoodCat.SelectedValue.ToString();
                frm.intSelection = intSelection;
                frm.ShowDialog();
            }
            else if (strTreeName.ToString() == "Daily Collection")
            {
                frmReportViewer frm = new frmReportViewer();
                frm.selector = ViewerSelector.Dailycollection;
                frm.strFromDate = mskFDate.Value.ToString("dd/MM/yyyy");
                frm.strToDate = mskTDate.Value.ToString("dd/MM/yyyy");
                frm.intSelection = intSelection;
                frm.ShowDialog();
            }
            else if (strTreeName.ToString() == "Collection From Staff")
            {
                frmReportViewer frm = new frmReportViewer();
                frm.selector = ViewerSelector.CollectionFromStaff;
                frm.strFromDate = mskFDate.Value.ToString("dd/MM/yyyy");
                frm.strToDate = mskTDate.Value.ToString("dd/MM/yyyy");
                frm.intSelection = intSelection;
                frm.ShowDialog();
            }

            else if (strTreeName.ToString() == "Issue  Report For Staff")
            {
                frmReportViewer frm = new frmReportViewer();
                frm.selector = ViewerSelector.IssueStaff;
                frm.strFromDate = mskFDate.Value.ToString("dd/MM/yyyy");
                frm.strToDate = mskTDate.Value.ToString("dd/MM/yyyy");
                frm.intSelection = intSelection;
                frm.ShowDialog();
            }
            else if (strTreeName.ToString() == "Collection From Visitors")
            {
                frmReportViewer frm = new frmReportViewer();
                frm.selector = ViewerSelector.ColelctionFromVisitors;
                frm.strFromDate = mskFDate.Value.ToString("dd/MM/yyyy");
                frm.strToDate = mskTDate.Value.ToString("dd/MM/yyyy");
                frm.intSelection = intSelection;
                frm.ShowDialog();
            }

            else if (strTreeName.ToString() == "User Wise Sales Report")
            {
               

                if (radAll.Checked == true)
                {
                    frmReportViewer frm = new frmReportViewer();
                    frm.selector = ViewerSelector.UserwiseCollection;
                    frm.strFromDate = mskFDate.Value.ToString("dd/MM/yyyy") ;
                    frm.strToDate = mskTDate.Value.ToString("dd/MM/yyyy");
                    frm.intSelection = intSelection;
                    frm.Where = "0";
                    frm.ShowDialog();
                }
                else
                {
                    frmReportViewer frm = new frmReportViewer();
                    frm.selector = ViewerSelector.UserwiseCollection;
                    frm.strFromDate = mskFDate.Value.ToString("dd/MM/yyyy");
                    frm.strToDate = mskTDate.Value.ToString("dd/MM/yyyy");
                    frm.intSelection = intSelection;
                    frm.Where = txtUserID.Text.ToString();
                    frm.ShowDialog();
                }

            }

            else if (strTreeName.ToString() == "Inventory Report")
            {
                frmReportViewer frm = new frmReportViewer();
                frm.selector = ViewerSelector.Inventory;
                frm.strFromDate = mskFDate.Value.ToString("dd/MM/yyyy");
                frm.strToDate = mskTDate.Value.ToString("dd/MM/yyyy");
                frm.intSelection = intSelection;
                frm.ShowDialog();
            }



        }

       

        private void cbofoodCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnPrint.Focus();
            }
        }

        private void cboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cboDate.Text=="Today’s")
            {
                grpSelDate.Visible = false;
                mskFDate.Visible = false;
                mskTDate.Visible = false;
                lblFDate.Visible = false;
                lblTdate.Visible = false;
                mskFDate.Value = DateTime.Now;
                mskTDate.Value = DateTime.Now;
            }
            else if (cboDate.Text == "Yesterday")
            {
                grpSelDate.Visible = false;
                mskFDate.Visible = false;
                mskTDate.Visible = false;
                lblFDate.Visible = false;
                lblTdate.Visible = false;
                DateTime dteLastMonth = DateTime.Now.AddDays(-1);
                mskFDate.Text = dteLastMonth.ToString();
                mskTDate.Text = dteLastMonth.ToString();

            }
            else if (cboDate.Text == "Last week")
            {
                grpSelDate.Visible = false;
                mskFDate.Visible = false;
                mskTDate.Visible = false;
                lblFDate.Visible = false;
                lblTdate.Visible = false;
                DateTime dteLastDay= DateTime.Now.AddDays(-7);
                var firstDayOfMonth = DateTime.Now;
                //mskFDate.Text = dteLastDay.ToString();
                //mskTDate.Text = firstDayOfMonth.ToString();

                mskFDate.Value = dteLastDay;
                mskTDate.Value = firstDayOfMonth;
            }

            else if (cboDate.Text == "Last Month")
            {
                grpSelDate.Visible = false;
                mskFDate.Visible = false;
                mskTDate.Visible = false;
                lblFDate.Visible = false;
                lblTdate.Visible = false;
                DateTime dteLastMonth = DateTime.Now.AddMonths(-1);
                var firstDayOfMonth = new DateTime(dteLastMonth.Year, dteLastMonth.Month, 1);
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                //mskFDate.Text = firstDayOfMonth.ToString();
                //mskTDate.Text = lastDayOfMonth.ToString();
                mskFDate.Value = firstDayOfMonth;
                mskTDate.Value = lastDayOfMonth;
            }

            else if (cboDate.Text == "This Month")
            {
                grpSelDate.Visible = false;
                mskFDate.Visible = false;
                mskTDate.Visible = false;
                lblFDate.Visible = false;
                lblTdate.Visible = false;
                DateTime dteLastMonth = DateTime.Now;
                var firstDayOfMonth = new DateTime(dteLastMonth.Year, dteLastMonth.Month, 1);
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                mskFDate.Value  = firstDayOfMonth;
                mskTDate.Value = lastDayOfMonth;
            }

            else if (cboDate.Text == "Date")
            {
                grpSelDate.Visible = true;
                mskFDate.Visible = true;
                mskTDate.Visible = true;
                lblFDate.Visible = true;
                lblTdate.Visible = true;
            }


        }

        private void radIndividual_CheckedChanged(object sender, EventArgs e)
        {
            if (radIndividual.Checked == true)
            {
                grpCardNo.Visible = true;
            }
            else
            {
                grpCardNo.Visible = false;
            }

        }

        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
           
             grpCardNo.Visible = false;
           
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkDate.Checked==true)
            //{
            //    cboDate.Visible = true;
            //    label3.Visible = true;
            //    mskFDate.Visible = false;
            //    mskTDate.Visible = false;
            //}
            //else
            //{
            //    cboDate.Visible = false;
            //    label3.Visible = false;
            //    mskFDate.Visible = false;
            //    mskTDate.Visible = false;
            //}



        }

        private void mskFDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Return)
            {
                mskTDate.Focus();
            }

        }

        private void mskTDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnPrint.Focus();
            }
        }

        

       


      









       

    }
}
