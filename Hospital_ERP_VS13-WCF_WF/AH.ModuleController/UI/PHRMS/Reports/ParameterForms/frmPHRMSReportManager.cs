using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.PHRMSSR;
using AH.ModuleController.UI.PHRMS.Reports.Viewer;
using System.Globalization;

namespace AH.ModuleController.UI.PHRMS.Reports.ParameterForms
{
    public partial class frmPHRMSReportManager : AH.Shared.UI.frmSmartFormReportStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        public int tabindex;
        
        public frmPHRMSReportManager()
        {
            InitializeComponent();
        }
        private void rdoInvestigationReport_CheckedChanged(object sender, EventArgs e)
        {
          

            
        }
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


        public void ProductList()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.ProductReport;
            ofrmReportViewer.Company = cboCompany.SelectedValue.ToString();
            ofrmReportViewer.ViewReport();
        }

        public void SalesReport()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.SalesReport;
            ofrmReportViewerOPD.ReportTitle = "Sales Receipt";
            ofrmReportViewerOPD.issueid = txtIssueID.Text;
            //ofrmReportViewerOPD.StartDate = Convert.ToDateTime(dtStartDate.Text);
            //ofrmReportViewerOPD.EndDate = Convert.ToDateTime(dtEndDate.Text);
            //ofrmReportViewerOPD.ReportTitle = "";
            //ofrmReportViewerOPD.ReportSecondParameter = ofrmReportViewerOPD.GetDateRange();
            //ofrmReportViewerOPD.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            //ofrmReportViewerOPD.ParamDateTo = Convert.ToString(dtEndDate.Text);
            ofrmReportViewerOPD.ViewReport();

        }
        public void SalesRetReport()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.SalesRetReport;
            ofrmReportViewerOPD.ReportTitle = "Sales Return Receipt";
            ofrmReportViewerOPD.issueid = txtIssueID.Text;
            //ofrmReportViewerOPD.StartDate = Convert.ToDateTime(dtStartDate.Text);
            //ofrmReportViewerOPD.EndDate = Convert.ToDateTime(dtEndDate.Text);
            //ofrmReportViewerOPD.ReportTitle = "";
            //ofrmReportViewerOPD.ReportSecondParameter = ofrmReportViewerOPD.GetDateRange();
            //ofrmReportViewerOPD.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            //ofrmReportViewerOPD.ParamDateTo = Convert.ToString(dtEndDate.Text);
            ofrmReportViewerOPD.ViewReport();

        }
        public void SalesDetReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.SalesDetReport;
            
            //ofrmReportViewer.issueid = txtIssueID.Text;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportTitle = "Sales Details";
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewer.ParamDateTo = Convert.ToString(dtEndDate.Text);
            ofrmReportViewer.ViewReport();
        }
        public void SalesRetDetReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.SalesRetDetReport;

            //ofrmReportViewer.issueid = txtIssueID.Text;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportTitle = "Sales Return Details";
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewer.ParamDateTo = Convert.ToString(dtEndDate.Text);
            ofrmReportViewer.ViewReport();
        }
        public void StockList()
        {
            
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.StockList;
            ofrmReportViewer.ReportTitle = "Medicine Stock";
            ofrmReportViewer.Group = cboCompany.SelectedValue.ToString();
            ofrmReportViewer.Pharmacy =  cboParam2.SelectedValue.ToString();
            ofrmReportViewer.ViewReport();
        }
        public void StockDetails()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.StockDetailsReport;
            ofrmReportViewer.ReportTitle = "Stock Details Report";
            ofrmReportViewer.Pharmacy = cboParam2.SelectedValue.ToString();
            ofrmReportViewer.ViewReport();
        }
        public void PODetails()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.PODetails;
            ofrmReportViewer.ReportTitle = "PURCHASE ORDER";
            ofrmReportViewer.POID = txtIssueID.Text;
           // ofrmReportViewer.Pharmacy = cboParam2.SelectedValue.ToString();
            ofrmReportViewer.ViewReport();

        }
        public void POReportDateWise()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.POReportDateWise;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportTitle = "PO Report (Datewise)";
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
        private void MrrDetailsReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.MrrDetailsReport;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportTitle = "GRN Details Report";
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewer.ParamDateTo = Convert.ToString(dtEndDate.Text);
            ofrmReportViewer.ViewReport();

        }
        private void OpeningReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.OpeningReport;
            ofrmReportViewer.ReportTitle = "Opening Report";
            ofrmReportViewer.ViewReport();
        }
        private void MrrReportByMrId()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.MrrReport;
            ofrmReportViewer.ReportTitle = "GRN Report";
            ofrmReportViewer.MrrID = txtParam1.Text;
            ofrmReportViewer.ViewReport();
        }
        private void PRReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.PRReport;
            ofrmReportViewer.ReportTitle = "PR Report";
            ofrmReportViewer.PRID = txtParam1.Text;
            ofrmReportViewer.ViewReport();
        }
        private void ExpireDateReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.ExpireDateReport;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportTitle = "ExpireDate Report";
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewer.ParamDateTo = Convert.ToString(dtEndDate.Text);
            ofrmReportViewer.ViewReport();
        }
        private void ItemRatesReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.ItemRatesReport;
            ofrmReportViewer.ReportTitle = "Item Rates Report";
            ofrmReportViewer.ViewReport();

        }
        private void ItemRatesHistoryReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.ItemRatesHistReport;
            ofrmReportViewer.ProductID = txtIssueID.Text;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportTitle = "Item Rates History Report";
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewer.ParamDateTo = Convert.ToString(dtEndDate.Text);

            ofrmReportViewer.ViewReport();
        }


      



        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabSelection.SelectedIndex == 0)
                {

                    if (rdoProductList.Checked == true)
                    {
                        ProductList();
                    }
                    if (rdoStockDetails.Checked == true)
                    {

                        StockDetails();
                    }
                    if (rdoStockList.Checked == true)
                    {
                        StockList();
                    }

                }
                else if (tabSelection.SelectedIndex == 1)
                {
                    if (rdoPRReport.Checked == true)
                    {
                        PRReport();
                    }
                    if (rdoPODetails.Checked == true)
                    {
                        if (phrSr.VerifyPOID(txtIssueID.Text) != 0)
                        {
                            PODetails();
                        }
                        else
                        {
                            MessageBox.Show("Please put a valid POID");
                            txtIssueID.Text = string.Empty;
                            return;
                        }
                    }
                    if (rdoPOReportDateWise.Checked == true)
                    {
                        POReportDateWise();

                    }
                    if (rdoOpeningReport.Checked == true)
                    {
                        OpeningReport();
                    }
                    if (rdoMrrReport.Checked == true)
                    {
                        MrrReportByMrId();
                    }
                    if (rdoMrrDetailsReport.Checked == true)
                    {
                        MrrDetailsReport();

                    }
                }
                else if (tabSelection.SelectedIndex == 2)
                {
                    if (rdoSales.Checked == true)
                    {
                        SalesReport();
                    }

                    if (rdoSalesDetails.Checked == true)
                    {
                        SalesDetReport();
                    }
                    if(rdoSalesRetReport.Checked == true)
                    {
                        SalesRetReport();
                    }
                    if(rdoSalesRetDetails.Checked == true)
                    {
                        SalesRetDetReport();
                    }
                }
                else if (tabSelection.SelectedIndex == 3)
                {
                    if (rdoProductLedger.Checked == true)
                    {
                        //if (string.IsNullOrEmpty(txtParam2.Text))
                        //{
                        //    MessageBox.Show("Product ID can not be empty");
                        //    return;
                            
                        //}
                        ProductLedger();
                    }



                    if (rdoItemRates.Checked == true)
                    {

                        ItemRatesReport();
                    }
                    if (rdoItemRatesHistory.Checked == true)
                    {
                        ItemRatesHistoryReport();

                    }

                    if (rdoExpireDate.Checked == true)
                    {
                        ExpireDateReport();
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

        private void frmDRSReportManager_Load(object sender, EventArgs e)
        {

            cboParam2.DisplayMember = "WhName";
            cboParam2.ValueMember = "Whid";
            cboParam2.DataSource = new BindingSource(phrSr.GetWarehouseTypewise("1","0"), null);

            tabSelection.SelectedIndex = tabindex;

            dgvProductList.Visible = false;

            cboDateType.SelectedIndex = 0;

            cboDateTypefrom.SelectedIndex = 0;

            rdoProductList.Checked = true;
           
            rdoSales.Checked = true;
            rdoSalesDetails.Checked = true;
            rdoStockList.Checked = true;

            rdoPODetails.Checked = true;

            rdoPOReportDateWise.Checked = true;

            rdoMrrDetailsReport.Checked = true;

            rdoStockDetails.Checked = true;

            rdoProductLedger.Checked = true;

            rdoItemRates.Checked = true;

            rdoItemRatesHistory.Checked = true;

            rdoOpeningReport.Checked = true;

            rdoExpireDate.Checked = true;

            rdoMrrReport.Checked = true;

            rdoPRReport.Checked = true;
            
            FormatData(dgvProductList);
            FormatDataGrid(dgvProductList);
            txtIssueID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductName.ReadOnly = true;
            
            //{
            //    FormatData(dgvProductList);
            //    //FormatDataGrid(dgvProductList);
                
            //    txtIssueID.Select();
            //}
            
        }

        private void rdoSpecimen_CheckedChanged(object sender, EventArgs e)
        {
           

            lblParam1.Text = "Issue ID";

            lblParam2.Visible = false;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            txtIssueID.Visible = true;
            cboCompany.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = true;
            txtParam1.Visible = false;
            txtProductName.Visible = false;
            dgvProductList.Visible = false;
            cboCompany.Visible = false;
            gbDateRange.Enabled = false;
            gbNextDateRange.Enabled = false;
            lblParam2.Visible = false;
        }

        private void rdoSpecimenDet_CheckedChanged(object sender, EventArgs e)
        {
            //lblParam4.Text = "Issue ID";
            lblParam2.Visible = false;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            txtParam1.Visible = false;
            txtIssueID.Visible = false;
            cboCompany.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = false;
            txtProductName.Visible = false;
            dgvProductList.Visible = false;
            cboCompany.Visible = false;
            gbDateRange.Enabled = true;
            lblParam2.Visible = false;
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

        private void rdoStockList_CheckedChanged(object sender, EventArgs e)
        {
           


        }

        private void rdoPODetails_CheckedChanged(object sender, EventArgs e)
        {
            
            

        }
        private void FormatData(DataGridView dtv)
        {
            dtv.Height = 270;
            dtv.Width = 210;

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
            Name.Width = 200;
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
            dtv.Columns[1].Width = 200;
            dtv.Columns[1].Visible = true;
            dtv.Columns[1].DefaultCellStyle.Font = new Font("Garamond", 10, FontStyle.Italic);
            dtv.Columns[1].DefaultCellStyle.BackColor = Color.Beige;


        }
        
        private void populateDataToGrid(DataGridView dtv, string drugname)
        {
           
            dgvProductList.Visible = true;
           
            List<DrugMaster> list = new List<DrugMaster>();
            
            list.AddRange(phrSr.GetDrugMasterList(drugname).ToList());
            dgvProductList.DataSource = list.Select(data => new { ID = data.ID, Name = data.Name }).ToList();
            this.dgvProductList.Focus();
        }
        private void rdoProductLedger_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void txtIssueID_KeyDown(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.Enter)
            //{
            //    int number2;

            //    if (e.KeyCode == Keys.Enter)
            //    {
            //        if (int.TryParse(txtIssueID.Text, out number2))
            //        {
            //            gbDateRange.Select();
            //        }
            //        else
            //        {
            //            populateDataToGrid(dgvProductList, txtIssueID.Text);
            //            dgvProductList.Focus();
            //        }
            //        if (dgvProductList.Rows.Count == 0)
            //        {
            //            dgvProductList.Visible = false;
            //            txtIssueID.Select();
            //            txtProductName.Text = string.Empty;
                        
            //        }
            //    }
            //}
            //if (e.KeyCode == Keys.Down)
            //{
            //    if (txtIssueID.Text.Length == 0)
            //    {
            //        MessageBox.Show("Please put a valid name",Utility.MessageCaptionMsg,MessageBoxButtons.OK);
            //        txtIssueID.Select();
            //        return;

            //    }
            //    populateDataToGrid(dgvProductList, txtIssueID.Text);
            //    dgvProductList.Focus();
            //}
        }
        private void setvaluesFromList(DataGridView dtv, object sender)
        {
            if (rdoProductLedger.Checked == true)
            {
                if (dtv.Rows.Count > 0)
                {
                    int currentRow = dtv.CurrentRow.Index;
                    currentRow--;

                    txtParam2.Text = dtv["ID", currentRow + 1].Value.ToString();
                    txtProductName.Text = dtv["NAME", currentRow + 1].Value.ToString();
                    dtv.Visible = false;
                    txtParam2.Focus();
                }
                else
                {
                    dtv.Visible = false;
                    txtParam2.Focus();
                }
            }

        }       

        private void dgvProductList_KeyPress(object sender, KeyPressEventArgs e)
        {
            setvaluesFromList(dgvProductList, sender);
        }

        private void pnlMain_MouseClick(object sender, MouseEventArgs e)
        {
            dgvProductList.Visible = false;
            txtIssueID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtIssueID.Select();
        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdoProductLedger.Checked == true)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvProductList.Rows[e.RowIndex];
                    txtParam2.Text = row.Cells["ID"].Value.ToString();
                    txtProductName.Text = row.Cells["Name"].Value.ToString();
                    dgvProductList.Visible = false;
                    txtParam2.Focus();
                }
            }
            
        }

        private void rdoPOReportDateWise_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdoMrrDetailsReport_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdoStockDetails_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdoItemRates_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdoItemRatesHistory_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            dgvProductList.Visible = false;
        }

        private void rdoOpeningReport_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cboDateTypefrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime _dateTo = DateTime.Parse(DateTime.Now.ToString());
            string sTo = _dateTo.ToString("dd-MM-yyyy");
            dtStartDay.Text = sTo;

            if (cboDateType.Text == "Select Date")
            {
                DateTime _dFrom = DateTime.Parse(DateTime.Now.ToString());
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;
            }

            if (cboDateTypefrom.Text == "Next One Month")
            {
                DateTime _dFrom = _dateTo.AddDays(+30);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtEndDay.Text = sdFrom;

            }

            if (cboDateTypefrom.Text == "Next One Week")
            {
                DateTime _dFrom = _dateTo.AddDays(+7);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtEndDay.Text = sdFrom;

            }

            if (cboDateTypefrom.Text == "Next Six Month")
            {
                DateTime _dFrom = _dateTo.AddMonths(+6);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtEndDay.Text = sdFrom;

            }

            if (cboDateTypefrom.Text == "Next One Year")
            {
                DateTime _dFrom = _dateTo.AddYears(+1);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtEndDay.Text = sdFrom;

            }
        }

        private void rdoExpireDate_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdoMrrReport_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rdoPRReport_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void smartTab1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdoProductList_CheckedChanged(object sender, EventArgs e)
        {

            lblParam1.Text = "Company";
            lblParam1.Visible = true;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            cboCompany.Visible = true;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam4.Visible = false;
            txtParam1.Visible = false;
            txtParam2.Visible = false;
            txtIssueID.Visible = false;
            gbDateRange.Enabled = false;
            gbNextDateRange.Enabled = false;
            txtProductName.Visible = false;
            dgvProductList.Visible = false;

            cboCompany.DisplayMember = "Value";
            cboCompany.ValueMember = "Key";
            cboCompany.DataSource = new BindingSource(phrSr.GetDrugCompDic("D"), null);
        }

        private void rdoStockList_CheckedChanged_1(object sender, EventArgs e)
        {
            lblParam2.Text =  "Pharmacy";
            lblParam1.Text =  "Group Name";

            lblParam2.Visible = true;
            lblParam3.Visible = false;
            txtParam2.Visible = false;
            lblParam4.Visible = false;
            txtIssueID.Visible = false;
            cboCompany.Visible = false;
            cboParam2.Visible = true;
            cboParam3.Visible = false;
            lblParam1.Visible = true;
            cboCompany.Visible = true;
            gbDateRange.Enabled = false;
            txtParam1.Visible = false;
            txtProductName.Visible = false;
            dgvProductList.Visible = false;
            lblParam2.Visible = true;
            lblParam5.Visible = false;
            txtProductName.Visible = false;


            cboCompany.DisplayMember = "Value";
            cboCompany.ValueMember = "Key";
            cboCompany.DataSource = new BindingSource(phrSr.GetDrugGroupDic("D"), null);

            //cboCompany.DisplayMember = "Value";
            //cboCompany.ValueMember = "Key";
            //cboCompany.DataSource = new BindingSource(phrSr.GetPharmacyName("D"), null);
        }

        private void rdoStockDetails_CheckedChanged_1(object sender, EventArgs e)
        {
            lblParam2.Text = "Pharmacy";


            lblParam1.Visible = false;
            lblParam2.Visible = true;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            txtIssueID.Visible = false;
            txtParam2.Visible = false;
            cboCompany.Visible = false;
            cboParam2.Visible = true;
            cboParam3.Visible = false;
            lblParam1.Visible = false;
            cboCompany.Visible = false;
            gbDateRange.Enabled = false;
            gbNextDateRange.Enabled = false;
            txtProductName.Visible = false;
            dgvProductList.Visible = false;
            lblParam2.Visible = true;
            lblParam5.Visible = false;
            txtProductName.Visible = false;
            txtParam1.Visible = false;
        }

        private void rdoPRReport_CheckedChanged_1(object sender, EventArgs e)
        {
            lblParam1.Text = "PR ID :";

            txtParam1.Location = cboCompany.Location;
            this.txtParam1.Size = new System.Drawing.Size(173, 100);

            lblParam1.Visible = true;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            lblParam5.Visible = false;
            txtParam1.Visible = true;
            txtIssueID.Visible = false;
            cboCompany.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            txtParam2.Visible = false;
            lblParam1.Visible = true;
            //cboParam1.Visible = false;
            gbDateRange.Enabled = false;
            txtProductName.Visible = false;
            dgvProductList.Visible = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;

            txtParam1.Text = string.Empty;
        }

        private void rdoPODetails_CheckedChanged_1(object sender, EventArgs e)
        {
            lblParam1.Text = "PO ID :";

            this.txtIssueID.Size = new System.Drawing.Size(173, 100);
            //lblParam2.Text = "Pharmacy";
            //txtIssueID.Text = string.Empty;

            //cboParam2.DisplayMember = "Value";
            //cboParam2.ValueMember = "Key";
            //cboParam2.DataSource = new BindingSource(phrSr.GetPharmacyName("D"), null);


            dgvProductList.Visible = false;
            lblParam2.Visible = false;
            txtIssueID.Visible = true;
            txtParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            txtParam1.Visible = false;
            cboCompany.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = true;
            cboCompany.Visible = false;
            txtProductName.Visible = false;
            dgvProductList.Visible = false;
            gbDateRange.Enabled = false;
            txtIssueID.Location = cboCompany.Location;
            txtIssueID.Text = string.Empty;


            // txtIssueID.Location = cboCompany.Location;
            //cboParam3.DisplayMember = "ID";
            //cboParam3.DataSource = phrSr.GetPONumbers();

            
        }

        private void rdoPOReportDateWise_CheckedChanged_1(object sender, EventArgs e)
        {
            lblParam2.Visible = false;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            txtIssueID.Visible = false;
            txtProductName.Visible = false;
            cboCompany.Visible = false;
            txtParam2.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = false;
            cboCompany.Visible = false;
            gbDateRange.Enabled = true;
            gbNextDateRange.Visible = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            txtParam1.Visible = false;
        }

        private void rdoOpeningReport_CheckedChanged_1(object sender, EventArgs e)
        {
            lblParam2.Visible = false;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            txtParam2.Visible = false;
            txtIssueID.Visible = false;
            txtProductName.Visible = false;
            cboCompany.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = false;
            cboCompany.Visible = false;
            gbDateRange.Enabled = false;
            gbNextDateRange.Enabled = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            txtParam1.Visible = false;
        }

        private void rdoMrrReport_CheckedChanged_1(object sender, EventArgs e)
        {
            lblParam1.Text = "GRN NO :";

            txtParam1.Location = cboCompany.Location;
            this.txtParam1.Size = new System.Drawing.Size(173, 100);

            lblParam1.Visible = true;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            lblParam5.Visible = false;
            txtParam1.Visible = true;
            txtIssueID.Visible = false;
            cboCompany.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            txtParam2.Visible = false;
            lblParam1.Visible = true;
            //cboParam1.Visible = false;
            gbDateRange.Enabled = false;
            txtProductName.Visible = false;
            dgvProductList.Visible = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;

            txtParam1.Text = string.Empty;
        }

        private void rdoMrrDetailsReport_CheckedChanged_1(object sender, EventArgs e)
        {
            lblParam2.Visible = false;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            txtIssueID.Visible = false;
            txtProductName.Visible = false;
            txtParam2.Visible = false;
            cboCompany.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = false;
            cboCompany.Visible = false;
            gbDateRange.Enabled = true;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            txtParam1.Visible = false;
        }

        private void rdoSales_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Issue ID";

            lblParam2.Visible = false;
            lblParam2.Visible = false;
            txtParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            txtIssueID.Visible = true;
            cboCompany.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = true;
            txtParam1.Visible = false;
            txtProductName.Visible = false;
            dgvProductList.Visible = false;
            cboCompany.Visible = false;
            gbDateRange.Enabled = false;
            gbNextDateRange.Enabled = false;
            lblParam2.Visible = false;
        }

        private void rdoSalesDetails_CheckedChanged(object sender, EventArgs e)
        {
            lblParam2.Visible = false;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            txtParam2.Visible = false;
            txtIssueID.Visible = false;
            txtProductName.Visible = false;
            cboCompany.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = false;
            cboCompany.Visible = false;
            gbDateRange.Enabled = true;
            gbNextDateRange.Visible = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            txtParam1.Visible = false;
        }

        private void rdoProductLedger_CheckedChanged_1(object sender, EventArgs e)
        {

            txtParam2.Select();
            lblParam1.Text = "Product ID";
            lblParam2.Text = "Product Name";

            //txtIssueID.Width = txtIssueID.Width - 160;
            //txtProductName.Width = txtProductName.Width - 70;

            txtParam2.Location = cboCompany.Location;
            txtProductName.Location = cboParam2.Location;
            dgvProductList.Location = cboParam3.Location;


            lblParam2.Visible = true;
            lblParam2.Visible = true;
            txtIssueID.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            txtParam2.Visible = true;
            txtProductName.Visible = true;
            cboCompany.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = true;
            cboCompany.Visible = false;
            gbDateRange.Enabled = true;
            lblParam2.Visible = true;
            lblParam5.Visible = false;
            txtParam1.Visible = false;
            txtParam2.Text = string.Empty;
            //cboCompany.DisplayMember = "Value";
            //cboCompany.ValueMember = "Key";
            //cboCompany.DataSource = new BindingSource(phrSr.GetMedicineName("D"), null);
        }

        private void rdoItemRates_CheckedChanged_1(object sender, EventArgs e)
        {
            lblParam2.Visible = false;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            txtIssueID.Visible = false;
            txtProductName.Visible = false;
            cboCompany.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = false;
            cboCompany.Visible = false;
            gbDateRange.Enabled = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            txtParam1.Visible = false;
        }

        private void rdoItemRatesHistory_CheckedChanged_1(object sender, EventArgs e)
        {
            txtIssueID.Select();
            lblParam1.Text = "Product ID";
            lblParam2.Text = "Product Name";

            //txtIssueID.Width = txtIssueID.Width - 160;
            //txtProductName.Width = txtProductName.Width - 70;

            txtIssueID.Location = cboCompany.Location;
            txtProductName.Location = cboParam2.Location;
            dgvProductList.Location = cboParam3.Location;


            txtParam1.Visible = false;
            lblParam2.Visible = true;
            lblParam2.Visible = true;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            txtIssueID.Visible = true;
            txtProductName.Visible = true;
            cboCompany.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = true;
            cboCompany.Visible = false;
            gbDateRange.Enabled = true;
            lblParam2.Visible = true;
            lblParam5.Visible = false;

        }

        private void rdoExpireDate_CheckedChanged_1(object sender, EventArgs e)
        {
            lblParam2.Visible = false;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            txtIssueID.Visible = false;
            txtProductName.Visible = false;
            cboCompany.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = false;
            cboCompany.Visible = false;
            gbDateRange.Enabled = true;
            gbNextDateRange.Enabled = true;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            txtParam1.Visible = false;
        }

        private void rdoPOTerms_CheckedChanged(object sender, EventArgs e)
        {

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
        public static string ConvertTo_ProperCase(string text)
        {
            TextInfo txt = new CultureInfo("en-US", false).TextInfo;
            return txt.ToUpper(text.ToLower());
        }

        private void txtIssueID_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = txtIssueID.SelectionStart;
            txtIssueID.Text = ConvertTo_ProperCase(txtIssueID.Text);
            txtIssueID.SelectionStart = x;
            if (e.KeyChar == (char)Keys.Return)
            {
                btnPrint.Select();
            }
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
                        populateDataToGrid(dgvProductList, txtParam2.Text);
                        dgvProductList.Focus();
                    }
                    if (dgvProductList.Rows.Count == 0)
                    {
                        dgvProductList.Visible = false;
                        txtParam2.Select();
                        txtProductName.Text = string.Empty;

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
                populateDataToGrid(dgvProductList, txtParam2.Text);
                dgvProductList.Focus();
            }
        }

        private void txtParam2_TextChanged(object sender, EventArgs e)
        {
            txtProductName.Text = string.Empty;
        }

        private void rdoSalesRetReport_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Issue ID";

            lblParam2.Visible = false;
            lblParam2.Visible = false;
            txtParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            txtIssueID.Visible = true;
            cboCompany.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = true;
            txtParam1.Visible = false;
            txtProductName.Visible = false;
            dgvProductList.Visible = false;
            cboCompany.Visible = false;
            gbDateRange.Enabled = false;
            gbNextDateRange.Enabled = false;
            lblParam2.Visible = false;
        }

        private void rdoSalesRetDetails_CheckedChanged(object sender, EventArgs e)
        {
            lblParam2.Visible = false;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            lblParam4.Visible = false;
            txtParam2.Visible = false;
            txtIssueID.Visible = false;
            txtProductName.Visible = false;
            cboCompany.Visible = false;
            cboParam2.Visible = false;
            cboParam3.Visible = false;
            lblParam1.Visible = false;
            cboCompany.Visible = false;
            gbDateRange.Enabled = true;
            gbNextDateRange.Visible = false;
            lblParam2.Visible = false;
            lblParam5.Visible = false;
            txtParam1.Visible = false;
        }

    }
}
