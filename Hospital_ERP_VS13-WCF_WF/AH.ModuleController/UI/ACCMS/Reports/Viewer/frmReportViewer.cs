using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.UI.ACCMS.Reports.ReportUI;
using AH.DUtility;
using CrystalDecisions.CrystalReports.Engine;
using AH.ModuleController.AccountsMSSR;


namespace AH.ModuleController.UI.ACCMS.Reports.Viewer
{
    public partial class frmReportViewer : Form
    {
        public string strRefNo { get; set; }
        ACCMSWSClient accClnt = new ACCMSWSClient();
        #region Declaration
        private Boolean isPrintDirect = false;
        private String reportTitle = "";
        private String secondParameter = "";
        public ViewerSelector selector;
        public String ReportTitle { set { reportTitle = value; } get { return reportTitle; } }
        public String ReportSecondParameter { set { secondParameter = value; } get { return secondParameter; } }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public string PatientNo { set; get; }
        public string MoneyReceiptNo { set; get; }
        public string TicketNo { set; get; }
        public string ReportFor { set; get; }
        public string TransactionNo { set; get; }
        public int intVoucherType { set; get; }
        public string WhereCondition { set; get; }
        public string LedgerName { set; get; }
        public string strFromDate { set; get; }
        public string strToDate { set; get; }
        public string strBranchID { set; get; }
        public string strControls { set; get; }
        public int  Where1 { set; get; }
        public string Where2 { set; get; }

        #endregion
                public frmReportViewer()
        {
            InitializeComponent();
        }

        public frmReportViewer(Boolean isPrintDirect)
            : this()
        {
            this.isPrintDirect = isPrintDirect;
        }


        #region "DateRange"
        public string GetDateRange()
        {
            return StartDate.ToString("dd-MM-yyyy") + "    To    " + EndDate.ToString("dd-MM-yyyy");
        }
        #endregion
        #region "Initialization"
        private void InitialiseLabels(ReportDocument rpt)
        {

            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyName"]).Text = Utility.GetCompanyName;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyAddress"]).Text = Utility.GetCompanyAddress;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyEmail"]).Text = Utility.GetCompanyEmail;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyPhone"]).Text = Utility.GetCompanyPhone;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtIT"]).Text = Utility.GetITDvnMsg;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyWeb"]).Text = Utility.GetCompanyWeb;
            if (ReportTitle != "")
            {
                ((TextObject)rpt.ReportDefinition.ReportObjects["txtReportTitle"]).Text = this.ReportTitle;
            }
            if (ReportSecondParameter != "")
            {
                ((TextObject)rpt.ReportDefinition.ReportObjects["txtSecondParameter"]).Text = this.secondParameter;
            }
            else
            {
                rpt.ReportDefinition.ReportObjects["txtSecondParameter"].ObjectFormat.EnableSuppress = true;
            }
           
        }
        #endregion
        #region "ParameterLabels"
        private void InitialiseParameterLabels(ReportDocument rpt,string strReportTitle)
        {
            rpt.SetParameterValue("txtCompanyName", Utility.GetCompanyName);
            rpt.SetParameterValue("txtCompanyAddress", Utility.GetCompanyAddress);
            rpt.SetParameterValue("txtCompanyEmail", Utility.GetCompanyEmail);
            rpt.SetParameterValue("txtCompanyPhone", Utility.GetCompanyPhone);
            rpt.SetParameterValue("txtCompanyWeb", Utility.GetCompanyWeb);
            rpt.SetParameterValue("txtReportTitle", strReportTitle);
        }
        #endregion
        #region "ShowReport"
        private void ShowReport(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt, Boolean isDirectPrint,string strReportTitle="")
        {
            if (isDirectPrint == true)
            {
                rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                rpt.PrintToPrinter(1, false, 0, 0);
            }
            else
            {
                //InitialiseParameterLabels(rpt, strReportTitle);
                this.Show();
            }

        }
        #endregion
        #region "Viewreport"
        public void ViewReport()
        {
            switch (selector)
            {
                #region ACCMSCollDetails
                case ViewerSelector.CollectionDetails:
                    ReportDocument rpt2;
                    rptCollectionDetails rDC = new rptCollectionDetails();
                    rpt2 = (ReportDocument)rDC;
                    InitialiseLabels(rpt2);
                    rpt2.SetDataSource(accClnt.GetCollectionDetails(WhereCondition));
                    crystalReportViewer1.ReportSource = rpt2;
                    ShowReport(rpt2, this.isPrintDirect);
                    break;
                #endregion
                #region ACCMSCollSummary
                case ViewerSelector.CollectionSummary:
                    ReportDocument rptd;
                    rptCollectionSummary rCr = new rptCollectionSummary();
                    rpt2 = (ReportDocument)rCr;
                    InitialiseLabels(rpt2);
                    rpt2.SetDataSource(accClnt.GetsSummary(WhereCondition));
                    crystalReportViewer1.ReportSource = rpt2;
                    ShowReport(rpt2, this.isPrintDirect);
                    break;
                #endregion

            }
            this.crystalReportViewer1.RefreshReport();
        }
        #endregion
        #region "Load"
        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            ReportDocument rpt1;
            double dbltotal = 0;
            double dblDr=0;
            double dblCr=0;
            string strVoucherName="";
          
            double dblIncome = 0;
            double dblexpenses = 0;
            double dblprofit = 0;
            try
            {
                switch (selector)
                {
                    case ViewerSelector.LedgerSingle:
                        rptLedgerIndividual rpt = new rptLedgerIndividual();
                        rpt1 = (ReportDocument)rpt;
                        InitialiseLabels(rpt1);
                        //InitialiseParameterLabels(rpt1);
                        this.reportTitle = "Individual Ledger Report";
                        rpt1.SetDataSource(accClnt.GetLedgerReports(strRefNo));
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "Individual Ledger Report");
                        break;
                    case ViewerSelector.TrailBalance:
                        if (Where1 == 1)
                        {
                            List<TrailBalanceRO> objTrail = accClnt.GetTraiBalanceReports(strFromDate, strToDate, WhereCondition).ToList();
                            foreach (TrailBalanceRO trailBal in objTrail)
                            {
                                dbltotal = trailBal.dblOpening;
                                //+ trailBal.dblDebitAmount + trailBal.dblCreditAmount;
                                if (dbltotal < 0)
                                {
                                    dblDr = dblDr + dbltotal;
                                }
                                if (dbltotal > 0)
                                {
                                    dblCr = dblCr + dbltotal;
                                }
                            }
                            if (dblDr < dblCr)
                            {
                                dblDr = Math.Abs(dblDr) - dblCr;
                            }
                            else
                            {
                                dblDr = dblDr + dblCr;
                            }
                            if (objTrail.Count > 1)
                            {
                                rptAccTrailBalance rptTrail = new rptAccTrailBalance();
                                rpt1 = (ReportDocument)rptTrail;
                                this.reportTitle = "Trial Balance";
                                this.secondParameter = strFromDate + " to " + strToDate;
                                InitialiseLabels(rpt1);
                                //InitialiseParameterLabels(rpt1);
                                rpt1.SetDataSource(accClnt.DisplayTrailBalance("ZDiff in Opening Balances", dblDr));
                                crystalReportViewer1.ReportSource = rpt1;
                                ShowReport(rpt1, this.isPrintDirect, "Trial Balance - " + strFromDate + " to " + strToDate);
                            }
                            break;
                        }
                        else
                        {
                            List<TrailBalanceRO> objTrail = accClnt.GetTraiBalanceReportsLedger(strFromDate, strToDate, WhereCondition).ToList();
                            foreach (TrailBalanceRO trailBal in objTrail)
                            {
                                dbltotal = trailBal.dblOpening;
                                //+ trailBal.dblDebitAmount + trailBal.dblCreditAmount;
                                if (dbltotal < 0)
                                {
                                    dblDr = dblDr + dbltotal;
                                }
                                if (dbltotal > 0)
                                {
                                    dblCr = dblCr + dbltotal;
                                }
                            }
                            if (dblDr < dblCr)
                            {
                                dblDr = Math.Abs(dblDr) - dblCr;
                            }
                            else
                            {
                                dblDr = dblDr + dblCr;
                            }
                            if (objTrail.Count > 1)
                            {
                                rptAccTrailBalanceLedger rptTrail = new rptAccTrailBalanceLedger();
                                rpt1 = (ReportDocument)rptTrail;
                                this.reportTitle = "Trial Balance";
                                this.secondParameter = strFromDate + " to " + strToDate;
                                InitialiseLabels(rpt1);
                                //InitialiseParameterLabels(rpt1);
                                rpt1.SetDataSource(accClnt.DisplayTrailBalance("ZDiff in Opening Balances", dblDr));
                                crystalReportViewer1.ReportSource = rpt1;
                                ShowReport(rpt1, this.isPrintDirect, "Trial Balance - " + strFromDate + " to " + strToDate);
                            }
                            break;
                        }


                    case ViewerSelector.VoucherReport:

                        List<VoucherRO> objv = accClnt.GetIndividualVoucherReports(strFromDate, strToDate, strBranchID, intVoucherType, strControls, WhereCondition, Where2).ToList();
                        if (objv.Count > 0)
                        {
                            rptIndividualVoucher rptVoucher = new rptIndividualVoucher();
                            rpt1 = (ReportDocument)rptVoucher;
                            if (intVoucherType == (int)Utility.VoucherType.vtPayment)
                            {
                                strVoucherName = "Payment Voucher";
                            }
                            else if (intVoucherType == (int)Utility.VoucherType.vtReceipt)
                            {
                                strVoucherName = "Receipt Voucher";
                            }
                            else if (intVoucherType == (int)Utility.VoucherType.vtJournal)
                            {
                                strVoucherName = "Journal Voucher";
                            }
                            else if (intVoucherType == (int)Utility.VoucherType.vtPayment)
                            {
                                strVoucherName = "Contra Voucher";
                            }

                            this.reportTitle = strVoucherName.ToString();
                            this.secondParameter = "";
                            InitialiseLabels(rpt1);

                            rpt1.SetDataSource(accClnt.GetIndividualVoucherReports(strFromDate, strToDate, strBranchID, intVoucherType, strControls, WhereCondition, Where2).ToList());
                            crystalReportViewer1.ReportSource = rpt1;

                            ShowReport(rpt1, this.isPrintDirect, strVoucherName.ToString());
                        }
                        break;

                    case ViewerSelector.Pvoucher:

                        List<VoucherRO> obpv = accClnt.GetIndividualVoucherReports(strFromDate, strToDate, strBranchID, intVoucherType, strControls, WhereCondition, Where2).ToList();
                        if (obpv.Count > 0)
                        {
                            if (intVoucherType == (int)Utility.VoucherType.vtJournal)
                            {
                                rptIndividualVoucherPreviewJV rptVoucher = new rptIndividualVoucherPreviewJV();
                                rpt1 = (ReportDocument)rptVoucher;
                            }
                            else
                            {
                                rptIndividualVoucherPreview rptVoucher = new rptIndividualVoucherPreview();
                                rpt1 = (ReportDocument)rptVoucher;
                            }

                            if (intVoucherType == (int)Utility.VoucherType.vtPayment)
                            {
                                strVoucherName = "Payment Voucher";
                            }
                            else if (intVoucherType == (int)Utility.VoucherType.vtReceipt)
                            {
                                strVoucherName = "Receipt Voucher";
                            }
                            else if (intVoucherType == (int)Utility.VoucherType.vtJournal)
                            {
                                strVoucherName = "Journal Voucher";
                            }
                            else if (intVoucherType == (int)Utility.VoucherType.vtPayment)
                            {
                                strVoucherName = "Contra Voucher";
                            }
                            this.reportTitle = strVoucherName.ToString();
                            this.secondParameter = "";
                            InitialiseLabels(rpt1);

                            rpt1.SetDataSource(accClnt.GetIndividualVoucherReports(strFromDate, strToDate, strBranchID, intVoucherType, strControls, WhereCondition, Where2).ToList());
                            crystalReportViewer1.ReportSource = rpt1;

                            ShowReport(rpt1, this.isPrintDirect, strVoucherName.ToString());
                        }
                        break;


                    case ViewerSelector.LedgerReport:
                        List<LedgerRO> obgDetails1 = accClnt.GetLedgerDetailsReport(WhereCondition, strBranchID, strFromDate, strToDate, "Ledger").ToList();
                        if (obgDetails1.Count > 0)
                        {
                            rptLedgerDetials rptLedger = new rptLedgerDetials();
                            rpt1 = (ReportDocument)rptLedger;
                            //this.reportTitle = LedgerName;
                            this.reportTitle = "Ledger Report";
                            this.secondParameter = strFromDate + " to " + strToDate;
                            InitialiseLabels(rpt1);
                            //InitialiseParameterLabels(rpt1);
                            rpt1.SetDataSource(accClnt.GetLedgerDetailsReport(WhereCondition, strBranchID, strFromDate, strToDate, "Ledger"));
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, LedgerName + strFromDate + " to " + strToDate);
                        }
                        break;
                    case ViewerSelector.GroupReport:
                        List<LedgerRO> obgDetails = accClnt.GetLedgerDetailsReport(WhereCondition, strBranchID, strFromDate, strToDate, "Group").ToList();
                        if (obgDetails.Count > 0)
                        {
                            rptGroupDetails rptgroup = new rptGroupDetails();
                            rpt1 = (ReportDocument)rptgroup;
                            this.reportTitle = "Group";
                            this.secondParameter = strFromDate + " to " + strToDate;
                            InitialiseLabels(rpt1);


                            rpt1.SetDataSource(accClnt.GetLedgerDetailsReport(WhereCondition, strBranchID, strFromDate, strToDate, "Group"));
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, LedgerName + strFromDate + " to " + strToDate);
                        }
                        break;
                    case ViewerSelector.BalanceSheet:

                        List<BalanceSheetRO> objbal = accClnt.GetBalanceSheetReports(strFromDate, strToDate, WhereCondition).ToList();
                        //foreach (BalanceSheetRO rptbal in objbal)
                        //{
                        //    if  (Convert.ToInt16(rptbal.intPrimaryType)==1)
                        //    {
                        //        dblassetsAmount = Math.Abs(dblassetsAmount) + Math.Abs(rptbal.gr_amount);
                        //    }
                        //    else if (Convert.ToInt16(rptbal.intPrimaryType) == 2)
                        //    {
                        //        dblLiabilitiesAmount = Math.Abs(dblLiabilitiesAmount) + Math.Abs(rptbal.gr_amount);
                        //    }
                        //}
                        //if (dblassetsAmount < dblLiabilitiesAmount)
                        //{
                        //    intprimarytype=1;
                        //    dbltotalAmount = dblassetsAmount - dblLiabilitiesAmount;
                        //    dbltotalAmount = (dbltotalAmount * -1);
                        //}
                        //else if(dblassetsAmount > dblLiabilitiesAmount)
                        //{
                        //    intprimarytype=2;
                        //    dbltotalAmount = dblLiabilitiesAmount - dblassetsAmount;
                        //}
                        //List<InccomeExpensesRO> objinc = accClnt.GetIncomeExpensesReports("Income", WhereCondition, strFromDate, strToDate, 3).ToList();
                        //foreach (InccomeExpensesRO rptinc in objinc)
                        //{
                        //    dblIncome = dblIncome + Math.Abs(rptinc.dblIncome);
                        //}

                        //List<InccomeExpensesRO> objExp = accClnt.GetIncomeExpensesReports("Expenses", WhereCondition, strFromDate, strToDate, 4).ToList();
                        //foreach (InccomeExpensesRO rptinc in objExp)
                        //{
                        //    dblexpenses = dblexpenses + Math.Abs(rptinc.dblExpenses);
                        //}
                        //dblprofit = dblIncome - dblexpenses;

                        if (objbal.Count > 0)
                        {
                            DateTime dtePreviousMonth;
                            DateTime dteCurrentMonth;
                            dtePreviousMonth = Convert.ToDateTime(strToDate);
                            string strPreviousdate = (dtePreviousMonth.AddYears(-1).ToString("MMMM,dd yyyy")).ToString().ToUpper();
                            dteCurrentMonth = Convert.ToDateTime(strToDate);
                            string strCurrentDate = dteCurrentMonth.ToString("MMMM,dd yyyy").ToUpper().ToUpper();

                            rptBalanceSheetNew rptBal = new rptBalanceSheetNew();
                            rpt1 = (ReportDocument)rptBal;

                            this.reportTitle = "Balance Sheet Report";
                            this.secondParameter = strFromDate + " to " + strToDate;
                            InitialiseLabels(rpt1);

                            rpt1.SetDataSource(accClnt.GetBalanceSheetReports(strFromDate, strToDate, WhereCondition));
                            //rpt1.SetDataSource(accClnt.DisplayBalanceSheet(WhereCondition, strFromDate, strToDate, "Profit+ Loss Accounts", intprimarytype, dbltotalAmount));
                            crystalReportViewer1.ReportSource = rpt1;
                            rpt1.SetParameterValue("CurrentDate", strCurrentDate);
                            rpt1.SetParameterValue("Previousmonth", strPreviousdate);
                            ShowReport(rpt1, this.isPrintDirect, " Balance Sheet Report -" + strFromDate + " to " + strToDate);
                        }
                        break;
                    case ViewerSelector.ProfitLoss:
                        List<ProfitlossRO> objProfit = accClnt.GetProfitLossReports("", WhereCondition, strFromDate, strToDate, 0).ToList();
                        foreach (ProfitlossRO rptbal in objProfit)
                        {
                            if (rptbal.primaryType == 3)
                            {
                                dblIncome = dblIncome + Math.Abs(rptbal.amount);
                            }
                            else if (rptbal.primaryType == 4)
                            {
                                dblexpenses = dblexpenses + Math.Abs(rptbal.amount);
                            }

                            dblprofit = dblIncome - dblexpenses;
                        }

                        if (objProfit.Count > 0)
                        {
                            DateTime dtePreviousMonth;
                            DateTime dteCurrentMonth;
                            dtePreviousMonth = Convert.ToDateTime(strToDate);
                            string strPreviousdate = (dtePreviousMonth.AddYears(-1).ToString("MMMM,dd yyyy")).ToString().ToUpper();
                            dteCurrentMonth = Convert.ToDateTime(strToDate);
                            string strCurrentDate = dteCurrentMonth.ToString("MMMM,dd yyyy").ToUpper().ToUpper();

                            rptProfitLossNew rptProfit = new rptProfitLossNew();
                            //rptIncomeExpense rptProfit = new rptIncomeExpense();
                            rpt1 = (ReportDocument)rptProfit;

                            this.reportTitle = "Profit & Loss";
                            this.secondParameter = strFromDate + " to " + strToDate;
                            InitialiseLabels(rpt1);


                            rpt1.SetDataSource(accClnt.GetProfitLossReports("", WhereCondition, strFromDate, strToDate, 0).ToList());
                            crystalReportViewer1.ReportSource = rpt1;
                            rpt1.SetParameterValue("INCOME", dblIncome);
                            rpt1.SetParameterValue("EXpenses", dblexpenses);
                            rpt1.SetParameterValue("ProfitLoss", dblprofit);
                            rpt1.SetParameterValue("CURRENTDATE", strCurrentDate);
                            rpt1.SetParameterValue("PREVIOUSDATE", strPreviousdate);
                            ShowReport(rpt1, this.isPrintDirect, " Profit & Loss -" + strFromDate + " to " + strToDate);
                        }
                        break;

                    case ViewerSelector.FixedAssetsReport:
                        List<FixedAssetsRO> objFxd = accClnt.GetFixedAssetsRo(strFromDate, strToDate, Where2).ToList();

                        if (objFxd.Count > 0)
                        {
                            rptFixedAssetSchedule rptProfit = new rptFixedAssetSchedule();
                            rpt1 = (ReportDocument)rptProfit;

                            this.reportTitle = "Fixed Asset Schedule";
                            this.secondParameter = strFromDate + " to " + strToDate;
                            InitialiseLabels(rpt1);


                            rpt1.SetDataSource(accClnt.GetFixedAssetsRo(strFromDate, strToDate, Where2).ToList());
                            crystalReportViewer1.ReportSource = rpt1;
                            rpt1.SetParameterValue("fromdate", strFromDate);
                            rpt1.SetParameterValue("ToDate", strToDate);
                            ShowReport(rpt1, this.isPrintDirect, " Fixed Asset Schedule " + strFromDate + " to " + strToDate);
                        }
                        break;

                    case ViewerSelector.Treeview:
                        List<TreeviewRO> objTreeview = accClnt.GetTreeview("").ToList();
                        if (objTreeview.Count > 0)
                        {
                            rptTreeview rptTreeview = new rptTreeview();
                            rpt1 = (ReportDocument)rptTreeview;
                            this.reportTitle = "Chart of Accounts";
                            this.secondParameter = "";
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(accClnt.GetTreeview("").ToList());
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "Chart of Accounts");
                        }
                        break;
                    case ViewerSelector.CategoryReport:
                        List<CostCategoryRO> objCat = accClnt.GetCostCategoryReport("CostCategory", WhereCondition, strBranchID, strFromDate, strToDate).ToList();
                        if (objCat.Count > 0)
                        {
                            rptCostCategory rptCostCategoy = new rptCostCategory();
                            rpt1 = (ReportDocument)rptCostCategoy;
                            this.reportTitle = "Cost Category";
                            this.secondParameter = strFromDate + " to " + strToDate;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(accClnt.GetCostCategoryReport("CostCategory", WhereCondition, strBranchID, strFromDate, strToDate));
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "Cost Category up to: " + strFromDate + " to " + strToDate);
                        }
                        break;
                    case ViewerSelector.CategoryLedgerReport:
                        List<CostCategoryRO> objCatLedger = accClnt.GetCostCategoryReport("Ledger", WhereCondition, strBranchID, strFromDate, strToDate).ToList();
                        if (objCatLedger.Count > 0)
                        {
                            rptCostCategoryLedger rptCostCategoy = new rptCostCategoryLedger();
                            rpt1 = (ReportDocument)rptCostCategoy;
                            this.reportTitle = "Ledger Wise Cost Category";
                            this.secondParameter = strFromDate + " to " + strToDate;
                            InitialiseLabels(rpt1);

                            rpt1.SetDataSource(accClnt.GetCostCategoryReport("Ledger", WhereCondition, strBranchID, strFromDate, strToDate));
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "Ledger Wise Cost Category up to: " + strFromDate + " to " + strToDate);
                        }
                        break;

                    case ViewerSelector.Cashflow:
                        double dblOpening = 0;

                        List<CashflowRO> objCashflow = accClnt.GetCashflowReport("Cashflow", WhereCondition, strBranchID, strFromDate, strToDate).ToList();
                        if (objCashflow.Count > 0)
                        {
                            List<CashflowRO> objOpning = accClnt.GetCashOpening(strFromDate, strToDate).ToList();
                            if (objOpning.Count > 0)
                            {
                                foreach (CashflowRO ro in objOpning)
                                {
                                    dblOpening = dblOpening + Convert.ToDouble(ro.CashflowOpening);
                                }
                            }

                            DateTime dtePreviousMonth;
                            DateTime dteCurrentMonth;
                            dtePreviousMonth = Convert.ToDateTime(strToDate);
                            string strPreviousdate = (dtePreviousMonth.AddYears(-1).ToString("MMMM,dd yyyy")).ToString().ToUpper();
                            dteCurrentMonth = Convert.ToDateTime(strToDate);
                            string strCurrentDate = dteCurrentMonth.ToString("MMMM,dd yyyy").ToUpper().ToUpper();

                            rptCashflow rptCashflow = new rptCashflow();
                            rpt1 = (ReportDocument)rptCashflow;

                            this.reportTitle = "Cashflow";
                            this.secondParameter = strFromDate + " to " + strToDate;
                            InitialiseLabels(rpt1);

                            rpt1.SetDataSource(accClnt.GetCashflowReport("Cashflow", WhereCondition, strBranchID, strFromDate, strToDate));
                            crystalReportViewer1.ReportSource = rpt1;
                            rpt1.SetParameterValue("CurrentDate", strCurrentDate);
                            rpt1.SetParameterValue("PreviousPeriod", strPreviousdate);
                            rpt1.SetParameterValue("opening", dblOpening);
                            ShowReport(rpt1, this.isPrintDirect, "Cash Flow up to: " + strFromDate + " to " + strToDate);
                        }
                        break;
                    case ViewerSelector.BankReconcilation:
                        List<BankReconcilationRO> objBank = accClnt.GetBankReconcilationRpt(WhereCondition, strFromDate, strToDate, "").ToList();
                        if (objBank.Count > 0)
                        {
                            rptBankReconcilation rptBankRecon = new rptBankReconcilation();
                            rpt1 = (ReportDocument)rptBankRecon;
                            this.reportTitle = "Bank Reconcilation of " + Where2  ;
                            this.secondParameter = strFromDate + " to " + strToDate;
                            InitialiseLabels(rpt1);

                            rpt1.SetDataSource(accClnt.GetBankReconcilationRpt(WhereCondition, strFromDate, strToDate, "").ToList());
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "Bank Reconcilation " + strFromDate + " to " + strToDate);
                        }
                        break;

                    case ViewerSelector.FixedAssetsDetails:
                        List<FixedAssetsDetailsRO> objDet = accClnt.GetFixedAssetsDetailsRo(strFromDate, strToDate).ToList();
                        if (objDet.Count > 0)
                        {
                            rptFixedAssetsDetails rptFixedAssetsDetails = new rptFixedAssetsDetails();
                            rpt1 = (ReportDocument)rptFixedAssetsDetails;
                            this.reportTitle = "Fixed Assets Details";
                            this.secondParameter = strFromDate + " to " + strToDate;
                            InitialiseLabels(rpt1);

                            rpt1.SetDataSource(accClnt.GetFixedAssetsDetailsRo(strFromDate, strToDate).ToList());
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "Fixed Assets Details " + strFromDate + " to " + strToDate);
                        }
                        break;

                    case ViewerSelector.Payable:
                        List<LedgerRO> obgPayable = accClnt.GetLedgerDetailsReport(WhereCondition, strBranchID, strFromDate, strToDate, "Ledger").ToList();
                        if (obgPayable.Count > 0)
                        {
                            rptAccPayable rptLedger = new rptAccPayable();
                            rpt1 = (ReportDocument)rptLedger;
                            //this.reportTitle = LedgerName;
                            this.reportTitle = "Accounts Payable";
                            this.secondParameter = strFromDate + " to " + strToDate;
                            InitialiseLabels(rpt1);
                            //InitialiseParameterLabels(rpt1);
                            rpt1.SetDataSource(accClnt.GetLedgerDetailsReport(WhereCondition, strBranchID, strFromDate, strToDate, "Ledger"));
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, LedgerName + strFromDate + " to " + strToDate);
                        }
                        break;


                    case ViewerSelector.Revenue:
                        string strhead = "";
                        if (Where1 == 3)
                        {
                            strhead = "Accounts Payable ";
                        }
                        else
                        {
                            strhead = "Hospital Collection ";
                        }

                        if (WhereCondition == "Details")
                        {
                            List<CollectionRO> objcoll = accClnt.GetCollectionHospital(Where1, strFromDate, strToDate, strBranchID).ToList();
                            if (objcoll.Count > 0)
                            {
                                rptHospitalCollection rptCashflow = new rptHospitalCollection();
                                rpt1 = (ReportDocument)rptCashflow;

                                this.reportTitle = strhead;
                                this.secondParameter = strFromDate + " to " + strToDate;
                                InitialiseLabels(rpt1);


                                rpt1.SetDataSource(accClnt.GetCollectionHospital(Where1, strFromDate, strToDate, strBranchID).ToList());
                                crystalReportViewer1.ReportSource = rpt1;
                                ShowReport(rpt1, this.isPrintDirect, strhead + strFromDate + " to " + strToDate);
                            }
                            break;
                        }
                        else
                        {
                            if (WhereCondition == "Summarry")
                            {
                                List<CollectionRO> objcoll = accClnt.GetCollectionHospital(Where1, strFromDate, strToDate, strBranchID).ToList();
                                if (objcoll.Count > 0)
                                {
                                    rptHospitalCollectionSumm rptCashflow = new rptHospitalCollectionSumm();
                                    rpt1 = (ReportDocument)rptCashflow;
                                    this.reportTitle = strhead;
                                    this.secondParameter = strFromDate + " to " + strToDate;
                                    InitialiseLabels(rpt1);

                                    rpt1.SetDataSource(accClnt.GetCollectionHospital(Where1, strFromDate, strToDate, strBranchID).ToList());
                                    crystalReportViewer1.ReportSource = rpt1;
                                    ShowReport(rpt1, this.isPrintDirect, strhead + strFromDate + " to " + strToDate);
                                }
                                break;
                            }
                        }

                        break;

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
        #region "Keydown"
        private void frmReportViewer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.P))
            {
              
                //ReportDocument rpt1;
                //rptIndividualVoucher rptVoucher = new rptIndividualVoucher();
                //rpt1 = (ReportDocument)rptVoucher;
                //rpt1.PrintToPrinter(1, false, 0, 0);
                // printDocument1.PrinterSettings
                PrintDialog printDialog = new PrintDialog();
                //printDialog.ShowDialog();
                // Allow the user to choose the page range he or she would
                // like to print.
                printDialog.AllowSomePages = true;
                // Show the help button.
               // printDialog.ShowHelp = true;
                // Set the Document property to the PrintDocument for 
                // which the PrintPage Event has been handled. To display the
                // dialog, either this property or the PrinterSettings property 
                // must be set 
                //printDialog.Document = docToPrint;
                //DialogResult result = printDialog.ShowDialog();
                //// If the result is OK then print the document.
                //if (result == DialogResult.OK)
                //{
                    // docToPrint.Print();
                    //crystalReportViewer1.PrintReport();
                    crystalReportViewer1.PrintReport();
                //}


            }
        }
        #endregion


    }
}
