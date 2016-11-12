using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.UI.FNB.Reports.ReportsUI;
using AH.DUtility;
using CrystalDecisions.CrystalReports.Engine;
using AH.ModuleController.FNBSR;

namespace AH.ModuleController.UI.FNB.Reports.Viewer
{
    public partial class frmReportViewer : Form
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        public ViewerSelector selector;
        private Boolean isPrintDirect = false;
        public string strFromDate { set; get; }
        public string strToDate { set; get; }
        public string Where,CallName,where1;

        private String reportTitle = "";
        public String ReportTitle { set { reportTitle = value; } get { return reportTitle; } }
        private String secondParameter = "";
        public  int intSelection;
        public String ReportSecondParameter { set { secondParameter = value; } get { return secondParameter; } }
        public frmReportViewer()
        {
            InitializeComponent();
        }
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
        private void InitialiseParameterLabels(ReportDocument rpt, string strReportTitle)
        {
            rpt.SetParameterValue("txtCompanyName", Utility.GetCompanyName);
            rpt.SetParameterValue("txtCompanyAddress", Utility.GetCompanyAddress);
            rpt.SetParameterValue("txtCompanyEmail", Utility.GetCompanyEmail);
            rpt.SetParameterValue("txtCompanyPhone", Utility.GetCompanyPhone);
            rpt.SetParameterValue("txtCompanyWeb", Utility.GetCompanyWeb);
            rpt.SetParameterValue("txtReportTitle", strReportTitle);
        }
        private void ShowReport(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt, Boolean isDirectPrint, string strReportTitle = "")
        {
            if (isDirectPrint == true)
            {
                rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                rpt.PrintToPrinter(1, false, 0, 0);
            }
            //else
            //{
            //    InitialiseParameterLabels(rpt, strReportTitle);
            //    this.Show();
            //}

        }
        private void frmReportViewer_Load(object sender, EventArgs e)
        {
             ReportDocument rpt1;
            switch (selector)
            {
                case ViewerSelector.Fooditems:
                    List<FoodItemRO> objFood = fnbs.GetFoodItem(Where).ToList();
                    if (objFood.Count > 0)
                    {
                        rptFoodItem rptFood = new rptFoodItem();
                        rpt1 = (ReportDocument)rptFood;
                        this.reportTitle = "Item List";
                        this.secondParameter = "";
                        InitialiseLabels(rpt1);
                        //InitialiseParameterLabels(rpt1, "Food Item List");
                        rpt1.SetDataSource(fnbs.GetFoodItem(Where).ToList());
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "Item List" + "");
                    }
                    break;

                case ViewerSelector.visitortSlip:
                    List<VisitorsSlipRO> obvs = fnbs.GetVisitorsSlipRo(CallName, Where).ToList();
                    if (obvs.Count > 0)
                    {
                        rptVisitorsSlip rptVs = new rptVisitorsSlip();
                        rpt1 = (ReportDocument)rptVs;
                        this.reportTitle = "Cash Memo";
                        this.secondParameter = "";
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(fnbs.GetVisitorsSlipRo(CallName, Where).ToList());
                        rpt1.SetParameterValue("Name", where1);
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "Cash Memo" + "");
                    }
                        break;
                    
        
                case ViewerSelector.BarcodeLevel:
                    rptBarcode rptBarcode = new rptBarcode();
                    rpt1 = (ReportDocument)rptBarcode;
                    rpt1.SetParameterValue("CardNo", Where);
                    crystalReportViewer1.ReportSource = rpt1;
                    ShowReport(rpt1, this.isPrintDirect, " "+ "");
                    break;

                case ViewerSelector.Dailycollection:
                    List<DailyCollectionRO> ds =fnbs.LoadDailyCollection("","Daily Collection",strFromDate,strToDate).ToList();
                    if (ds.Count > 0)
                    {
                        if (intSelection == 1)
                        {
                            rptDailyCollectionSumm rptDailyColl = new rptDailyCollectionSumm();
                            rpt1 = (ReportDocument)rptDailyColl;
                        }
                        else
                        {
                            rptDailyCollectionDetails rptDailyColl = new rptDailyCollectionDetails();
                            rpt1 = (ReportDocument)rptDailyColl;
                        }
                        this.reportTitle = "Daily Collection";
                        this.ReportSecondParameter = strFromDate + " to " + strToDate;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(fnbs.LoadDailyCollection("", "Daily Collection", strFromDate, strToDate).ToList());

                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, " " + "");
                    }
                    break;
                case ViewerSelector.ColelctionFromVisitors:
                    List<VisitorsSlipRO> ds1 = fnbs.GetVisitorsCollection("", "VisitorsNew", strFromDate, strToDate).ToList();
                    {
                        if (ds1.Count > 0)
                        {
                            if (intSelection == 1)
                            {
                                rptFoodItemSumm rptFoodItemColl = new rptFoodItemSumm();
                                rpt1 = (ReportDocument)rptFoodItemColl;
                            }
                            else
                            {
                                rptFoodItemDetails rptFoodItemColl = new rptFoodItemDetails();
                                rpt1 = (ReportDocument)rptFoodItemColl;
                            }


                            this.reportTitle = "Visitors Collection";
                            this.ReportSecondParameter = strFromDate + " to " + strToDate;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(fnbs.GetVisitorsCollection("", "VisitorsNew", strFromDate, strToDate).ToList());

                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, " " + "");
                        }
                    }
                    break;

                case ViewerSelector.CollectionFromStaff:

                    List<DailyCollectionRO> ds2 = fnbs.LoadStaffCollection("", "Staff Collection", strFromDate, strToDate).ToList();
                    {
                        if (ds2.Count > 0)
                        {
                            if (intSelection == 1)
                            {
                                rptDailyCollectionSumm rptDailyColl = new rptDailyCollectionSumm();
                                rpt1 = (ReportDocument)rptDailyColl;
                            }
                            else
                            {
                                rptStaffCollectionDetails rptDailyColl = new rptStaffCollectionDetails();
                                rpt1 = (ReportDocument)rptDailyColl;
                            }
                            this.reportTitle = "Collection From Staff";
                            this.ReportSecondParameter = strFromDate + " to " + strToDate;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(fnbs.LoadStaffCollection("", "Staff Collection", strFromDate, strToDate).ToList());

                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, " " + "");
                        }
                    }
                    break;

                case ViewerSelector.IssueStaff:
                    List<DailyCollectionRO> ds3 = fnbs.LoadStaffIssuesd("", "Staff Issued", strFromDate, strToDate).ToList();
                    {
                        if (ds3.Count > 0)
                        {
                            rptStaffIssue rptIssue = new rptStaffIssue();
                            rpt1 = (ReportDocument)rptIssue;

                            this.reportTitle = "Food Issue ";
                            this.ReportSecondParameter = strFromDate + " to " + strToDate;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(fnbs.LoadStaffIssuesd("", "Staff Issued", strFromDate, strToDate).ToList());

                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, " " + "");
                        }
                    }
                    break;

                case ViewerSelector.UserwiseCollection:
                    List<DailyCollectionRO> ds4 = fnbs.LoadUserwiseCollection(Where, "User Wise Collection", strFromDate, strToDate).ToList();
                    {
                        if (ds4.Count > 0)
                        {
                            rptUserWiseCollection rptUserColl = new rptUserWiseCollection();
                            rpt1 = (ReportDocument)rptUserColl;

                            this.reportTitle = "User Wise Collection ";
                            this.ReportSecondParameter = strFromDate + " to " + strToDate;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(fnbs.LoadUserwiseCollection(Where, "User Wise Collection", strFromDate, strToDate).ToList());

                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, " " + "");
                        }
                    }
                    break;

              


            }
        }












    }
}
