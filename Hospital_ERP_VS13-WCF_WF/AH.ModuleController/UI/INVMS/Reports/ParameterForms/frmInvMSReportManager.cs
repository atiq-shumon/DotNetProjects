using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.INVMSSR;
using AH.ModuleController.UI.InvMS.Reports.Viewer;
using System.Globalization;

namespace AH.ModuleController.UI.InvMS.Reports.ParameterForms
{
    public partial class frmInvMSReportManager : AH.Shared.UI.frmSmartFormReportStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        public frmInvMSReportManager()
        {
            InitializeComponent();
        }


        #region ViewerObjects

        private void ItemList()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.ItemList;
            ofrmReportViewer.Group = cboParam5.SelectedValue.ToString();
            ofrmReportViewer.ReportTitle = "Groupwise Item List";
            ofrmReportViewer.ViewReport();
        }

        private void ItemListStoreTypeGroupWise()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.ItemsStoreTypeGroupWise;
            ofrmReportViewer.StoreType = cboParam4.SelectedValue.ToString();
            ofrmReportViewer.Group = cboParam3.SelectedValue.ToString();
            ofrmReportViewer.ReportTitle = "Item List";
            ofrmReportViewer.ViewReport();
        }
        private void StockDetails()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.StockDetails;
            ofrmReportViewer.Store = cboParam1.SelectedValue.ToString();
            ofrmReportViewer.ReportTitle = "Stock Details Report";
            ofrmReportViewer.ViewReport();
        }
        private void StockReportGroupwise()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.StockReportGroupwise;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportTitle = "Stock Report";
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewer.ParamDateTo = Convert.ToString(dtEndDate.Text);
            ofrmReportViewer.ViewReport();
        }
        private void ProductLedger()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.ProductLedger;
            ofrmReportViewer.ProductID = txtParam2.Text;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportTitle = "PRODUCT LEDGER";
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewer.ParamDateTo = Convert.ToString(dtEndDate.Text);
            ofrmReportViewer.ViewReport();
        }
        private void StockDetailsReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.StockDetailsReport;
            ofrmReportViewer.Group = cboParam5.SelectedValue.ToString();
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportTitle = "Stock Summary";
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewer.ParamDateTo = Convert.ToString(dtEndDate.Text);
            ofrmReportViewer.ViewReport();

        }
        private void POReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.POReport;
            ofrmReportViewer.POID = txtParam1.Text;
            ofrmReportViewer.ReportTitle = "PURCHASE ORDER";
            ofrmReportViewer.ViewReport();
        }
        private void PRReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.PrReport;
            ofrmReportViewer.PRID = txtParam1.Text;
            ofrmReportViewer.ReportTitle = "Purchase Requisition(PR)";
            ofrmReportViewer.ViewReport();
        }
        private void DRReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.DrReport;
            ofrmReportViewer.DRID = txtParam1.Text;
            ofrmReportViewer.ReportTitle = "Demand Requisition";
            ofrmReportViewer.ViewReport();
        }
        private void POReportDateWise()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.POReportDateWise;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportTitle = "PO Report";
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewer.ParamDateTo = Convert.ToString(dtEndDate.Text);
            ofrmReportViewer.ViewReport();

        }
        private void IssueReportDateWise()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.IssueReportDateWise;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportTitle = "Issue Report (Datewise)";
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewer.ParamDateTo = Convert.ToString(dtEndDate.Text);
            ofrmReportViewer.ViewReport();
        }
        private void IssueReportGroupWise()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.IssueReportGroupWise;
            ofrmReportViewer.Group = cboParam5.SelectedValue.ToString();
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportTitle = "Issue Report (Groupwise)";
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewer.ParamDateTo = Convert.ToString(dtEndDate.Text);
            ofrmReportViewer.ViewReport();
        }
        private void MrrReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.MrrReport;
            ofrmReportViewer.MrrID = txtParam1.Text;
            ofrmReportViewer.ReportTitle = "GRN Report";
            ofrmReportViewer.ViewReport();
        }
        private void OpeningReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.OpeningReport;
            ofrmReportViewer.MrrID = txtParam1.Text;
            ofrmReportViewer.ReportTitle = "Store Opening Report";
            ofrmReportViewer.ViewReport();
        }

        private void IssueReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.IssueReport;
            ofrmReportViewer.issueid = txtParam1.Text;
            ofrmReportViewer.ReportTitle = "Issue Report";
            ofrmReportViewer.ViewReport();
        }
        private void POTermsCondition()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.POTermsConditions;
            ofrmReportViewer.POID = txtParam1.Text;
            //ofrmReportViewer.ReportTitle = "PURCHASE ORDER";
            ofrmReportViewer.ViewReport();
        }

        private void GRNReportDateWise()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.MrrDetailsReport;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportTitle = "GRN Report Details";
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewer.ParamDateTo = Convert.ToString(dtEndDate.Text);
            ofrmReportViewer.ViewReport();
        }

        #endregion

        #region PrintViewReport
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabselector.SelectedIndex == 0)
                {
                    if (rdoItemList.Checked == true)
                    {
                        ItemList();
                        //rdoItemList.Checked = false;
                    }
                    if (rdoItemStrtypeGrpwise.Checked == true)
                    {
                        ItemListStoreTypeGroupWise();
                        //rdoProductLedger.Checked = false;
                    }
                    rdoProductLedger.Checked = false;
                }
                if (tabselector.SelectedIndex == 1)
                {
                    if (rdoDrReport.Checked == true)
                    {
                        DRReport();
                    }
                    if (rdoPOReport.Checked == true)
                    {
                        POReport();
                        //rdoPOReport.Checked = false;
                    }
                    if (rdoPrReport.Checked == true)
                    {
                        PRReport();
                        //rdoPrReport.Checked = false;
                    }
                    if (rdoPOReportDateWise.Checked == true)
                    {
                        POReportDateWise();
                        //rdoPOReportDateWise.Checked = false;
                    }
                    if (rdoMrrReport.Checked == true)
                    {
                        MrrReport();
                        // rdoMrrReport.Checked = false;
                    }
                    if (rdoGRNReport.Checked == true)
                    {
                        GRNReportDateWise();
                        //rdoGRNReport.Checked = false;
                    }
                    if (rdoOpeningReport.Checked == true)
                    {
                        OpeningReport();

                    }
                }
                if (tabselector.SelectedIndex == 2)
                {
                    if (rdoIssueReportDatewise.Checked == true)
                    {
                        IssueReportDateWise();
                    }
                    if (rdoIssueReportGroupwise.Checked == true)
                    {
                        IssueReportGroupWise();
                    }

                    if (rdoIssueReport.Checked == true)
                    {
                        IssueReport();
                    }
                }
                if (tabselector.SelectedIndex == 3)
                {
                    if (rdoStockReport.Checked == true)
                    {
                        StockDetails();
                    }
                    if (rdoStockDetailsReport.Checked == true)
                    {
                        StockDetailsReport();
                    }
                    if (rdoStockReportGroupwise.Checked == true)
                    {
                        StockReportGroupwise();
                    }
                    if (rdoProductLedger.Checked == true)
                    {
                        if (string.IsNullOrEmpty(txtParam2.Text))
                        {
                            MessageBox.Show("Item ID can not be empty");
                            return;
                        }
                        ProductLedger();
                    }
                }
                if (tabselector.SelectedIndex == 4)
                {
                    if (rdoPOTerms.Checked == true)
                    {
                        POTermsCondition();
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
        #endregion

        #region GetDateOption

        public bool CheckDateOPtions()
        {
            if (cboDateType.Text != "")
            {
                if (cboDateType.Text != "None" && cboDateType.Text != "")
                {
                    DateTime startdate = Convert.ToDateTime(dtStartDate.Text);
                    DateTime enddate = Convert.ToDateTime(dtEndDate.Text);
                    if (startdate > enddate)
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        private void cboDateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime _dateTo = DateTime.Parse(DateTime.Now.ToString());
            string sTo = _dateTo.ToString("dd-MM-yyyy");
            dtEndDate.Text = sTo;
            if (cboDateType.Text == "Select Date")
            {
                DateTime _dFrom = DateTime.Parse(DateTime.Now.ToString());
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;
            }
            if (cboDateType.Text == "Last One Month")
            {
                DateTime _dFrom = _dateTo.AddDays(-30);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last Three Month")
            {
                DateTime _dFrom = _dateTo.AddMonths(-3);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last Six Month")
            {
                DateTime _dFrom = _dateTo.AddMonths(-6);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last One Year")
            {
                DateTime _dFrom = _dateTo.AddYears(-1);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }
        }
        #endregion

        #region GridFormat

        private void FormatData(DataGridView dtv)
        {
            dtv.Height = 250;
            dtv.Width = 300;

            dtv.AutoGenerateColumns = false;
            dtv.EditMode = DataGridViewEditMode.EditProgrammatically;

            //dtv.Location = new Point(cboParam3.Location.X, cboParam3.Location.Y);

            DataGridViewTextBoxColumn ID = new DataGridViewTextBoxColumn();
            ID.Name = "ID";
            ID.DataPropertyName = "ID";
            ID.Width = 0;
            ID.Visible = false;
            dtv.Columns.Add(ID);

            DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
            Name.Name = "Name";
            Name.DataPropertyName = "Name";
            Name.Width = 300;
            dtv.Columns.Add(Name);

        }
        private void FormatDataGrid(DataGridView dtv)
        {
            dtv.ColumnHeadersVisible = true;
            dtv.AllowUserToAddRows = false;
            dtv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtv.AutoGenerateColumns = false;

            //dtv.Location = new Point(txtSupplierName.Location.X, txtSupplierName.Location.Y);

            dtv.Columns[0].Name = "ID";
            dtv.Columns[0].DataPropertyName = "ID";
            dtv.Columns[0].Width = 0;
            dtv.Columns[0].Visible = false;
            dtv.Columns[0].DefaultCellStyle.Font = new Font("Garamond", 10, FontStyle.Italic);

            dtv.Columns[1].Name = "Name";
            dtv.Columns[1].DataPropertyName = "Name";
            dtv.Columns[1].Width = 300;
            dtv.Columns[1].Visible = true;
            dtv.Columns[1].DefaultCellStyle.Font = new Font("Garamond", 10, FontStyle.Italic);
            dtv.Columns[1].DefaultCellStyle.BackColor = Color.Beige;


        }

        private void setvaluesFromList(DataGridView dtv, object sender)
        {
            if (rdoItemList.Checked == true)
            {
                if (dtv.Rows.Count > 0)
                {
                    int currentRow = dtv.CurrentRow.Index;
                    currentRow--;

                    txtParam1.Text = dtv["ID", currentRow + 1].Value.ToString();
                    txtParam3.Text = dtv["NAME", currentRow + 1].Value.ToString();
                    dtv.Visible = false;
                    txtParam1.Focus();
                }
                else
                {
                    dtv.Visible = false;
                    txtParam1.Focus();
                }
            }
            if(rdoItemStrtypeGrpwise.Checked == true)
            {
                if (dtv.Rows.Count > 0)
                {
                    int currentRow = dtv.CurrentRow.Index;
                    currentRow--;

                    txtParam1.Text = dtv["ID", currentRow + 1].Value.ToString();
                    txtParam3.Text = dtv["NAME", currentRow + 1].Value.ToString();
                    dtv.Visible = false;
                    txtParam1.Focus();
                }
                else
                {
                    dtv.Visible = false;
                    txtParam1.Focus();
                }
            }
            if (rdoProductLedger.Checked == true)
            {
                if (dtv.Rows.Count > 0)
                {
                    int currentRow = dtv.CurrentRow.Index;
                    currentRow--;

                    txtParam2.Text = dtv["ID", currentRow + 1].Value.ToString();
                    txtParam3.Text = dtv["NAME", currentRow + 1].Value.ToString();
                    dtv.Visible = false;
                    txtParam2.Focus();
                }
                else
                {
                    dtv.Visible = false;
                    txtParam2.Focus();
                }
            }
            //if(rdoStockDetailsReport.Checked == true)
            //{
            //    if (dtv.Rows.Count > 0)
            //    {
            //        int currentRow = dtv.CurrentRow.Index;
            //        currentRow--;

            //        txtParam1.Text = dtv["ID", currentRow + 1].Value.ToString();
            //        txtParam3.Text = dtv["NAME", currentRow + 1].Value.ToString();
            //        dtv.Visible = false;
            //        txtParam1.Focus();
            //    }
            //    else
            //    {
            //        dtv.Visible = false;
            //        txtParam1.Focus();
            //    }
            //}
        }

        private void dgvItemList_KeyPress(object sender, KeyPressEventArgs e)
        {
            setvaluesFromList(dgvItemList, sender);
        }

        private void dgvItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdoItemList.Checked == true)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvItemList.Rows[e.RowIndex];
                    txtParam1.Text = row.Cells["ID"].Value.ToString();
                    txtParam3.Text = row.Cells["Name"].Value.ToString();
                    dgvItemList.Visible = false;
                    txtParam1.Focus();
                }
            }
            if(rdoItemStrtypeGrpwise.Checked == true)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvItemList.Rows[e.RowIndex];
                    txtParam1.Text = row.Cells["ID"].Value.ToString();
                    txtParam3.Text = row.Cells["Name"].Value.ToString();
                    dgvItemList.Visible = false;
                    txtParam1.Focus();
                }
            }
            if (rdoProductLedger.Checked == true)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvItemList.Rows[e.RowIndex];
                    txtParam2.Text = row.Cells["ID"].Value.ToString();
                    txtParam3.Text = row.Cells["Name"].Value.ToString();
                    dgvItemList.Visible = false;
                    txtParam2.Focus();
                }

            }
            //if(rdoStockDetailsReport.Checked == true)
            //{
            //    if (e.RowIndex >= 0)
            //    {
            //        DataGridViewRow row = this.dgvItemList.Rows[e.RowIndex];
            //        txtParam1.Text = row.Cells["ID"].Value.ToString();
            //        txtParam3.Text = row.Cells["Name"].Value.ToString();
            //        dgvItemList.Visible = false;
            //        txtParam1.Focus();
            //    }
            //}
        }

        #endregion

        #region FormLoad
        private void frmInvMSReportManager_Load(object sender, EventArgs e)
        {
            dgvItemList.Visible = false;

            cboDateType.SelectedIndex = 0;

            rdoItemList.Checked = true;

            rdoStockReport.Checked = true;

            rdoProductLedger.Checked = true;

            rdoPOReportDateWise.Checked = true;

            rdoIssueReportDatewise.Checked = true;

            rdoPOReport.Checked = true;

            rdoMrrReport.Checked = true;

            rdoOpeningReport.Checked = true;

            rdoIssueReport.Checked = true;

            rdoStockDetailsReport.Checked = true;

            rdoPOTerms.Checked = true;

            rdoPrReport.Checked = true;

            rdoStockReportGroupwise.Checked = true;

            FormatData(dgvItemList);
            FormatDataGrid(dgvItemList);
            txtParam1.Text = string.Empty;
            lblParam2.Text = string.Empty;

            
            
            //txtParam2.ReadOnly = true;
        }

        #endregion

        #region GetItemList

        private void populateDataToGrid(DataGridView dtv, string groupname)
        {

            dgvItemList.Visible = true;

            List<GroupDetails> list = new List<GroupDetails>();

            list.AddRange(invSr.GetGroupList(groupname).ToList());
            dgvItemList.DataSource = list.Select(data => new { ID = data.ID, Name = data.Name }).ToList();
            this.dgvItemList.Focus();
        }



        private void pnlMain_MouseClick(object sender, MouseEventArgs e)
        {
            dgvItemList.Visible = false;
            txtParam1.Text = string.Empty;
            lblParam2.Text = string.Empty;
            txtParam1.Select();
        }




       

        private void txtParam1_KeyDown(object sender, KeyEventArgs e)
        {
            if (rdoProductLedger.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int number2;

                    if (e.KeyCode == Keys.Enter)
                    {
                        if (int.TryParse(txtParam1.Text, out number2))
                        {
                            gbDateRange.Select();
                        }
                        else
                        {
                            populateDataToGrid(dgvItemList, txtParam1.Text);
                            dgvItemList.Focus();
                        }

                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (txtParam1.Text.Length == 0)
                    {
                        MessageBox.Show("Please put a valid name", Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                        txtParam1.Select();
                        return;

                    }
                    populateDataToGrid(dgvItemList, txtParam1.Text);
                    dgvItemList.Focus();
                }
            }
            
        }

        private void txtParam1_TextChanged(object sender, EventArgs e)
        {
            txtParam3.Text = string.Empty;
        }
        #endregion
       
        #region ProductLedger
        private void populateDataToList(DataGridView dtv, string itemname,string storeid)
        {

            dgvItemList.Visible = true;

            List<ItemMaster> list = new List<ItemMaster>();

            list.AddRange(invSr.GetItemsByName(itemname,storeid).ToList());
            if (list.Count > 0)
            {
                dgvItemList.DataSource = list.Select(data => new { ID = data.ID, Name = data.Name }).ToList();
                this.dgvItemList.Focus();
            }
            else
            {
                dgvItemList.Visible = false;
                MessageBox.Show("There is no item in this store");
                return;
            }
        }
        private void rdoProductLedger_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void txtParam2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int number2;

                if (e.KeyCode == Keys.Enter)
                {
                    if (int.TryParse(txtParam2.Text, out number2))
                    {
                        gbDateRange.Select();
                    }
                    else
                    {
                        populateDataToList(dgvItemList, txtParam2.Text,cboParam2.SelectedValue.ToString());
                        dgvItemList.Focus();
                    }

                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (txtParam2.Text.Length == 0)
                {
                    MessageBox.Show("Please put a valid name", Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                    txtParam2.Select();
                    return;

                }
                populateDataToList(dgvItemList, txtParam2.Text, cboParam2.SelectedValue.ToString());
                dgvItemList.Focus();
            }
        }
       

        private void txtParam2_TextChanged(object sender, EventArgs e)
        {
            txtParam3.Text = string.Empty;
        }
        #endregion

        #region POReportDateWise
        private void rdoPOReportDateWise_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            lblParam6.Visible = false;
            lblParam7.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            cboParam5.Visible = false;
            lblParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam4.Visible = false;
            gbDateRange.Enabled = true;
            txtParam2.Visible = false;
            dgvItemList.Visible = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;

        }
        #endregion

        #region GetIssueReportDateWise
        private void rdoIssueReportDatewise_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            lblParam6.Visible = false;
            lblParam7.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam4.Visible = false;
            cboParam5.Visible = false;
            gbDateRange.Enabled = true;
            txtParam2.Visible = false;
            dgvItemList.Visible = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;
        }
        #endregion

        #region POReport
        private void rdoPOReport_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "PO ID :";

            this.txtParam1.Size = new System.Drawing.Size(173, 100);

            lblParam1.Visible = true;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            lblParam6.Visible = false;
            lblParam7.Visible = false;
            txtParam1.Visible = true;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = true;
            cboParam1.Visible = false;
            cboParam4.Visible = false;
            cboParam5.Visible = false;
            gbDateRange.Enabled = false;
            txtParam2.Visible = false;
            dgvItemList.Visible = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            lblParam6.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;

            txtParam1.Text = string.Empty;
        }
        #endregion

        #region MrrReport
        private void rdoMrrReport_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "GRN NO :";

            this.txtParam1.Size = new System.Drawing.Size(173, 100);

            lblParam1.Visible = true;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            lblParam6.Visible = false;
            txtParam1.Visible = true;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            cboParam4.Visible = false;
            cboParam5.Visible = false;
            lblParam1.Visible = true;
            cboParam1.Visible = false;
            gbDateRange.Enabled = false;
            txtParam2.Visible = false;
            dgvItemList.Visible = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            lblParam6.Visible = false;
            lblParam7.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;
            txtParam1.Text = string.Empty;

            
        }
        #endregion

        #region OpeningReport
        private void rdoOpeningReport_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Opening ID :";

            this.txtParam1.Size = new System.Drawing.Size(173, 100);

            lblParam1.Visible = true;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            lblParam6.Visible = false;
            txtParam1.Visible = true;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            cboParam4.Visible = false;
            cboParam5.Visible = false;
            lblParam1.Visible = true;
            cboParam1.Visible = false;
            gbDateRange.Enabled = false;
            txtParam2.Visible = false;
            dgvItemList.Visible = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            lblParam6.Visible = false;
            lblParam7.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;
        }
        #endregion

        #region IssueReport
        private void rdoIssueReport_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Issue No :";

            this.txtParam1.Size = new System.Drawing.Size(173, 100);

            lblParam1.Visible = true;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            lblParam6.Visible = false;
            lblParam7.Visible = false;
            txtParam1.Visible = true;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            cboParam4.Visible = false;
            cboParam5.Visible = false;
            lblParam1.Visible = true;
            cboParam1.Visible = false;
            gbDateRange.Enabled = false;
            txtParam2.Visible = false;
            dgvItemList.Visible = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            lblParam6.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;

            txtParam1.Text = string.Empty;
        }
        #endregion

        #region StockDetails

        private void rdoStockReport_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Store Location :";

            lblParam1.Visible = true;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            lblParam6.Visible = false;
            lblParam7.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = true;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            cboParam4.Visible = false;
            cboParam5.Visible = false;
            lblParam1.Visible = true;
            cboParam1.Visible = true;
            gbDateRange.Enabled = false;
            txtParam2.Visible = false;
            dgvItemList.Visible = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            lblParam6.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;

            //cboTransferStore.DisplayMember = "WhName";
            //cboTransferStore.ValueMember = "Whid";
            //cboTransferStore.DataSource = new BindingSource(invSr.GetWarehouseTypewise("0", "1"), null);

            cboParam1.ValueMember = "Whid";
            cboParam1.DisplayMember = "WhName";
            cboParam1.DataSource = new BindingSource(invSr.GetWarehouseTypewise("0", "1"), null);
        }
        #endregion

        #region StockDetailsReport
        private void rdoStockDetailsReport_CheckedChanged(object sender, EventArgs e)
        {
            //txtParam1.Select();
            //txtParam1.Text = string.Empty;
            //txtParam3.Text = string.Empty;
            //this.txtParam1.Size = new System.Drawing.Size(120, 100);


            lblParam1.Text = "Store Type :";
            lblParam2.Text = "Major Group :";
            lblParam3.Text = "Minor Group :";

            //cboParam4.Location = cboParam1.Location;
            cboParam4.Location = new System.Drawing.Point(620, 10);
            //cboParam3.Location = cboParam2.Location;
            cboParam3.Location = new System.Drawing.Point(620, 40);
            //cboParam5.Location = new System.Drawing.Point(390, 80);
            cboParam5.Location = new System.Drawing.Point(620, 70);
            lblParam3.Location = new System.Drawing.Point(520, 80);

            //txtParam1.Location = cboParam1.Location;
            //txtParam3.Location = new Point(520, 20);
            //dgvItemList.Location = cboParam2.Location;

            lblParam1.Visible = true;
            lblParam2.Visible = true;
            lblParam6.Visible = false;
            lblParam7.Visible = false;
            lblParam3.Visible = true;
            lblParam4.Visible = false;
            txtParam1.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = true;
            cboParam4.Visible = true;
            cboParam5.Visible = true;
            lblParam1.Visible = true;
            cboParam1.Visible = false;
            gbDateRange.Enabled = true;
            lblParam2.Visible = true;
            lblParam3.Visible = true;
            lblParam5.Visible = false;
            

            cboParam4.ValueMember = "strTypeID";
            cboParam4.DisplayMember = "TypeTitle";
            cboParam4.DataSource = invSr.GetStoreType().ToList();

            cboParam4.SelectedIndexChanged += cboParam4_SelectedIndexChanged;
            cboParam3.SelectedIndexChanged += cboParam3_SelectedIndexChanged;
        }
        #endregion

        #region POTermsConditions
        private void rdoPOTerms_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "PO ID :";

            txtParam1.Location = cboParam1.Location;
            this.txtParam1.Size = new System.Drawing.Size(173, 100);


            lblParam1.Visible = true;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            lblParam6.Visible = false;
            lblParam7.Visible = false;
            txtParam1.Visible = true;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            cboParam4.Visible = false;
            cboParam5.Visible = false;
            lblParam1.Visible = true;
            cboParam1.Visible = false;
            gbDateRange.Enabled = false;
            txtParam2.Visible = false;
            dgvItemList.Visible = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            lblParam6.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;

            txtParam1.Text = string.Empty;
        }
        #endregion

        #region GetItemListGroupWise
        private void rdoItemList_CheckedChanged(object sender, EventArgs e)
        {
            //txtParam1.Select();
            //txtParam1.Text = string.Empty;
            //txtParam3.Text = string.Empty;
            //this.txtParam1.Size = new System.Drawing.Size(120, 100);


            lblParam1.Text = "Store Type :";
            lblParam2.Text = "Major Group :";
            lblParam3.Text = "Minor Group :";

            cboParam4.Location = new System.Drawing.Point(620, 20);
            //cboParam4.Location = cboParam1.Location;
            //cboParam3.Location = cboParam2.Location;
            cboParam3.Location = new System.Drawing.Point(620, 50);
            cboParam5.Location = new System.Drawing.Point(620, 80);
            lblParam3.Location = new System.Drawing.Point(520, 80);

            lblParam1.Visible = true;
            lblParam2.Visible = true;
            lblParam6.Visible = false;
            lblParam3.Visible = true;
            lblParam4.Visible = false;
            lblParam7.Visible = false;
            txtParam1.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = true;
            cboParam4.Visible = true;
            cboParam5.Visible = true;
            lblParam1.Visible = true;
            cboParam1.Visible = false;
            gbDateRange.Enabled = true;
            lblParam2.Visible = true;
            lblParam3.Visible = true;
            lblParam5.Visible = false;

            cboParam4.ValueMember = "strTypeID";
            cboParam4.DisplayMember = "TypeTitle";
            cboParam4.DataSource = invSr.GetStoreType().ToList();

            cboParam4.SelectedIndexChanged += cboParam4_SelectedIndexChanged;
            cboParam3.SelectedIndexChanged += cboParam3_SelectedIndexChanged;
        }
       
        #endregion


        #region ItemListStoreType&GroupWise
        private void rdoItemStrtypeGrpwise_CheckedChanged(object sender, EventArgs e)
        {

            //cboParam4.Location = cboParam1.Location;
            cboParam4.Location = new System.Drawing.Point(620, 10);
            lblParam7.Location = lblParam1.Location;

            //cboParam3.Location = cboParam2.Location;
            cboParam3.Location = new System.Drawing.Point(620, 40);
            lblParam3.Location = lblParam2.Location;

            lblParam7.Text = "Store Type :";
            lblParam3.Text = "Major Group :";           

            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam6.Visible = false;
            lblParam3.Visible = true;
            lblParam4.Visible = false;
            txtParam1.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = true;
            cboParam5.Visible = false;
            cboParam4.Visible = true;
            lblParam1.Visible = false;
            cboParam1.Visible = false;
            gbDateRange.Enabled = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            lblParam7.Visible = true;

            cboParam4.ValueMember = "strTypeID";
            cboParam4.DisplayMember = "TypeTitle";
            cboParam4.DataSource = new BindingSource(invSr.GetStoreType(), null);

            cboParam4.SelectedIndexChanged += cboParam4_SelectedIndexChanged;

           


        }
        

        #endregion
        private void cboParam3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboParam3.SelectedValue != null)
            {
                cboParam5.DisplayMember = "Name";
                cboParam5.ValueMember = "ID";
                cboParam5.DataSource = invSr.GetGroupByMajorGrp(cboParam4.SelectedValue.ToString(), cboParam3.SelectedValue.ToString());
            }
        }

        private void cboParam4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboParam3.ValueMember = "MajorgrpID";
            cboParam3.DisplayMember = "Name";
            cboParam3.DataSource = invSr.GetMajorGrpByStrtype(cboParam4.SelectedValue.ToString());
        }
        #region PRReport
        private void rdoPrReport_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "PR ID :";

            this.txtParam1.Size = new System.Drawing.Size(173, 100);

            lblParam1.Visible = true;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            lblParam6.Visible = false;
            lblParam7.Visible = false;
            txtParam1.Visible = true;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = true;
            cboParam1.Visible = false;
            cboParam4.Visible = false;
            cboParam5.Visible = false;
            gbDateRange.Enabled = false;
            txtParam2.Visible = false;
            dgvItemList.Visible = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            lblParam6.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;
            

            txtParam1.Text = string.Empty;
        }
        #endregion

        #region StockReportGroupwise
        private void rdoStockReportGroupwise_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            lblParam6.Visible = false;
            lblParam7.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            cboParam5.Visible = false;
            lblParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam4.Visible = false;
            gbDateRange.Enabled = true;
            txtParam2.Visible = false;
            dgvItemList.Visible = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;
        }
        #endregion

        #region IssueReportGroupwise
        private void rdoIssueReportGroupwise_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Store Type :";
            lblParam2.Text = "Major Group :";
            lblParam3.Text = "Minor Group :";

            cboParam4.Location = new System.Drawing.Point(620, 20);
            cboParam3.Location = new System.Drawing.Point(620, 50);
            cboParam5.Location = new System.Drawing.Point(620, 80);
            lblParam3.Location = new System.Drawing.Point(520, 80);

            lblParam1.Visible = true;
            lblParam2.Visible = true;
            lblParam6.Visible = false;
            lblParam3.Visible = true;
            lblParam4.Visible = false;
            lblParam7.Visible = false;
            txtParam1.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = true;
            cboParam4.Visible = true;
            cboParam5.Visible = true;
            lblParam1.Visible = true;
            cboParam1.Visible = false;
            gbDateRange.Enabled = true;
            lblParam2.Visible = true;
            lblParam3.Visible = true;
            lblParam5.Visible = false;

            cboParam4.ValueMember = "strTypeID";
            cboParam4.DisplayMember = "TypeTitle";
            cboParam4.DataSource = invSr.GetStoreType().ToList();

            cboParam4.SelectedIndexChanged += cboParam4_SelectedIndexChanged;
            cboParam3.SelectedIndexChanged += cboParam3_SelectedIndexChanged;
        }
        #endregion

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdoGRNReport_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            lblParam6.Visible = false;
            lblParam7.Visible = false;
            txtParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            cboParam5.Visible = false;
            lblParam1.Visible = false;
            cboParam1.Visible = false;
            cboParam4.Visible = false;
            gbDateRange.Enabled = true;
            txtParam2.Visible = false;
            dgvItemList.Visible = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;
        }

        private void rdoProductLedger_CheckedChanged_1(object sender, EventArgs e)
        {
            txtParam2.Select();
            txtParam2.Text = string.Empty;
            txtParam3.Text = string.Empty;
            this.txtParam2.Size = new System.Drawing.Size(120, 100);

            lblParam1.Text = "Store :";
            lblParam2.Text = "Item ID :";
            lblParam3.Text = "Item Name :";

            cboParam2.Location = new System.Drawing.Point(620, 10);
            //txtParam2.Location = cboParam2.Location;   
            txtParam2.Location = new Point(620, 50);
            txtParam3.Location = new Point(620, 80);
            dgvItemList.Location = txtParam3.Location;

            cboParam2.ValueMember = "strTypeID";
            cboParam2.DisplayMember = "TypeTitle";
            cboParam2.DataSource = new BindingSource(invSr.LoadStoreType(), null);

            lblParam1.Visible = true;
            lblParam2.Visible = true;
            lblParam3.Visible = true;
            lblParam4.Visible = false;
            lblParam6.Visible = false;
            lblParam7.Visible = false;
            txtParam1.Visible = false;
            txtParam2.Visible = true;
            txtParam3.Visible = true;
            cboParam1.Visible = false;
            cboParam2.Visible = true;
            cboParam3.Visible = false;
            cboParam4.Visible = false;
            cboParam5.Visible = false;
            lblParam1.Visible = true;
            cboParam1.Visible = false;
            gbDateRange.Enabled = true;
            lblParam2.Visible = true;
            lblParam5.Visible = false;
        }

        private void rdoDrReport_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "DR ID :";

            this.txtParam1.Size = new System.Drawing.Size(173, 100);

            lblParam1.Visible = true;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            lblParam6.Visible = false;
            lblParam7.Visible = false;
            txtParam1.Visible = true;
            cboParam1.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = true;
            cboParam1.Visible = false;
            cboParam4.Visible = false;
            cboParam5.Visible = false;
            gbDateRange.Enabled = false;
            txtParam2.Visible = false;
            dgvItemList.Visible = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            lblParam6.Visible = false;
            txtParam2.Visible = false;
            txtParam3.Visible = false;

            txtParam1.Text = string.Empty;
            
        }
        public static string ConvertTo_ProperCase(string text)
        {
            TextInfo txt = new CultureInfo("en-US", false).TextInfo;
            return txt.ToUpper(text.ToLower());
        }

        private void txtParam1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = txtParam1.SelectionStart;
            txtParam1.Text = ConvertTo_ProperCase(txtParam1.Text);
            txtParam1.SelectionStart = x;
            if (e.KeyChar == (char)Keys.Return)
            {
                btnPrint.Select();
            }
        }

    }
}
