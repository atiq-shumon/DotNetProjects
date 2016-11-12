using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AH.DUtility;
using AH.ModuleController.OPDSR;
using CrystalDecisions.CrystalReports.Engine;
using AH.ModuleController.UI.OPD.Reports.ReportUI;
using CrystalDecisions.Shared;

namespace AH.ModuleController.UI.OPD.Reports.Viewer
{
    public partial class frmReportViewer : Form
    {
        #region Declaration
        private Boolean isPrintDirect = false;
        private String reportTitle = "";
        private String secondParameter = "";
        public ViewerSelector selector;
        public String ReportTitle { set { reportTitle = value; } get { return reportTitle; } }
        public String ReportSecondParameter { set { secondParameter = value; } get { return secondParameter; } }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public string ParamField { set; get; }
        public string ParamDateFrom { set; get; }
        public string ParamDateTo { set; get; }
        public string ParamField2 { set; get; }

        public string PatientNo { set; get; }
        public string MoneyReceiptNo { set; get; }
        public string TicketNo { set; get; }
        public string ReportFor { set; get; }
        public string GroupID { set; get; }
        public string DeptID { set; get; }
        public string MainID { set; get; }
        public string DetailsID { set; get; }
        public string WhereCondition { set; get; }

        OPDSR.OPDWSClient clnt = new OPDWSClient();
        #endregion
        public frmReportViewer()
        {
            InitializeComponent();
        }
        public frmReportViewer(Boolean isPrintDirect) : this()
        {
            this.isPrintDirect = isPrintDirect;
        }

        public string GetDateRange()
        {
            return StartDate.ToString("dd-MM-yyyy") + "    To    " + EndDate.ToString("dd-MM-yyyy");
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

        private void ShowReport(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt, Boolean isDirectPrint)
        {
            if (isDirectPrint == true)
            {
                rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                rpt.PrintToPrinter(1, false, 0, 0);
            }
            else
            {
                this.Show();
            }
        }       

        public void ViewReport()
        {
             switch (selector)
                {
                    #region OPDNurseRoomAllRO
                    //OPD Ticket Details 
                    case ViewerSelector.OPDNurRoomAlloc:
                        ReportDocument rptOpdNrRAll;
                        rptOPDNurseRomAlloc rOpdNrRAll = new rptOPDNurseRomAlloc();
                        rptOpdNrRAll = (ReportDocument)rOpdNrRAll;
                        InitialiseLabels(rptOpdNrRAll);
                        rptOpdNrRAll.SetDataSource(clnt.GetNurseRoomRO());
                        crystalReportViewer1.ReportSource = rptOpdNrRAll;
                        ShowReport(rptOpdNrRAll, this.isPrintDirect);
                        break;
                    #endregion

                    #region OPDDrRoomAllRO
                    //OPD Ticket Details 
                    case ViewerSelector.OPDCollectionDoctor:
                        ReportDocument rptOpdDrRAll;
                        rptOPDDocRoomsAlloc rOpdDrRAll = new rptOPDDocRoomsAlloc();
                        rptOpdDrRAll = (ReportDocument)rOpdDrRAll;
                        InitialiseLabels(rptOpdDrRAll);
                        rptOpdDrRAll.SetDataSource(clnt.GetDocRoomAllRO());
                        //rptOpdDrRAll.SetDataSource(clnt.GetsOPDDoctorName());
                        crystalReportViewer1.ReportSource = rptOpdDrRAll;
                        ShowReport(rptOpdDrRAll, this.isPrintDirect);
                        break;
                    #endregion

                    #region OPDMRCollectionDetails
                    case ViewerSelector.OPDMRCollections:
                        ReportDocument rptOpdTicket;
                        rptOPDMRCollectionDetails rOpdTick = new rptOPDMRCollectionDetails();
                        rptOpdTicket = (ReportDocument)rOpdTick;
                        InitialiseLabels(rptOpdTicket);
                        rptOpdTicket.SetDataSource(clnt.GetOPDTicketDetails(ParamDateFrom, ParamDateTo));
                        crystalReportViewer1.ReportSource = rptOpdTicket;
                        ShowReport(rptOpdTicket, this.isPrintDirect);
                        break;
                    #endregion

                    #region OPDMRCollectionSummary
                    case ViewerSelector.OPDMRCollSumm:
                        ReportDocument rptOPDCollsum;
                        rptOPDMRCollectionSummary rOPDColl = new rptOPDMRCollectionSummary();
                        rptOPDCollsum = (ReportDocument)rOPDColl;
                        InitialiseLabels(rptOPDCollsum);
                        rptOPDCollsum.SetDataSource(clnt.GetOPDCollSummary(ParamDateFrom, ParamDateTo));
                        crystalReportViewer1.ReportSource = rptOPDCollsum;
                        ShowReport(rptOPDCollsum, this.isPrintDirect);
                        break;
                    #endregion

                    #region OPDMoneyReceipt
                    //OPD Ticket Details 
                    case ViewerSelector.OPDMR:
                        ReportDocument rptOpdMR;
                        // rptOPDMoneyReceipt rOPDMR = new rptOPDMoneyReceipt();
                        rptOPDMoneyReceiptNew rOPDMR = new rptOPDMoneyReceiptNew();
                        rptOpdMR = (ReportDocument)rOPDMR;
                        InitialiseLabels(rptOpdMR);
                        rptOpdMR.SetDataSource(clnt.GetOPDTicketMR(ParamField));
                        crystalReportViewer1.ReportSource = rptOpdMR;
                        // ShowReport(rptOpdMR, this.isPrintDirect );
                        ShowReport(rptOpdMR, this.isPrintDirect = true);
                        break;
                    #endregion

                    #region OPDRefundMR
                    case ViewerSelector.OPDRefundMR:
                        ReportDocument rptOPDRefundMR;
                        //rptOPDRefundReceipt rOPDRefundMR = new rptOPDRefundReceipt();
                        rptOPDRefundReceiptNew rOPDRefundMR = new rptOPDRefundReceiptNew();
                        rptOPDRefundMR = (ReportDocument)rOPDRefundMR;
                        InitialiseLabels(rptOPDRefundMR);
                        rptOPDRefundMR.SetDataSource(clnt.GetOPDRefundTicketMR(ParamField));
                        crystalReportViewer1.ReportSource = rptOPDRefundMR;
                        //ShowReport(rptOPDRefundMR, this.isPrintDirect);
                        ShowReport(rptOPDRefundMR, this.isPrintDirect = true);
                        break;
                    #endregion

                    #region OPDVoucher
                    case ViewerSelector.OPDVoucher:
                        ReportDocument rptOpdVoucher;
                        rptOPDVoucher rOPDVou = new rptOPDVoucher();
                        List<OPDTicketRO> oOpdVous = clnt.GetOPDVoucher(ParamField, ParamDateFrom, ParamDateTo).ToList();
                        if (oOpdVous.Count > 0)
                        {
                            rptOpdVoucher = (ReportDocument)rOPDVou;
                            InitialiseLabels(rptOpdVoucher);
                            rptOpdVoucher.SetDataSource(oOpdVous);
                            crystalReportViewer1.ReportSource = rptOpdVoucher;
                            ShowReport(rptOpdVoucher, this.isPrintDirect);
                        }
                        else
                        {
                            MessageBox.Show("No Data Found", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;

                    #endregion

                    #region OPDPrescription
                    case ViewerSelector.OPDPrescription:
                        ReportDocument rptOpdPres;
                        rptOPDPrescription rOPDPres = new rptOPDPrescription();
                        rptOpdPres = (ReportDocument)rOPDPres;
                        InitialiseLabels(rptOpdPres);
                        rptOpdPres.SetDataSource(clnt.GetOPDPrescription(ParamField));
                        crystalReportViewer1.ReportSource = rptOpdPres;
                        ShowReport(rptOpdPres, this.isPrintDirect);
                        break;
                    #endregion

                    #region OPDDepartment
                    case ViewerSelector.OPDDepartment:
                        ReportDocument rptOpdDept;
                        rptOPDDepartment rOPDep = new rptOPDDepartment();
                        rptOpdDept = (ReportDocument)rOPDep;
                        InitialiseLabels(rptOpdDept);
                        rptOpdDept.SetDataSource(clnt.GetOPDDepartment(ParamField, ParamDateFrom, ParamDateTo));
                        crystalReportViewer1.ReportSource = rptOpdDept;
                        ShowReport(rptOpdDept, this.isPrintDirect);
                        break;
                    #endregion

                    #region OPDDepartmentNDoct
                    case ViewerSelector.OPDDepatmentNDoctorsFee:
                        ReportDocument rOPDepDoc;
                        rptOPDCollectionDoctNDeptWise rOPDepDocFee = new rptOPDCollectionDoctNDeptWise();
                        rOPDepDoc = (ReportDocument)rOPDepDocFee;
                        InitialiseLabels(rOPDepDoc);
                        rOPDepDoc.SetDataSource(clnt.GetOPDDepartment(ParamField, ParamDateFrom, ParamDateTo));
                        crystalReportViewer1.ReportSource = rOPDepDoc;
                        ShowReport(rOPDepDoc, this.isPrintDirect);
                        break;
                    #endregion

                    #region OPDDoctor
                    case ViewerSelector.OPDDoctor:
                        ReportDocument rptOpdDoct;
                        rptOPDDoctor rOPDdoc = new rptOPDDoctor();
                        rptOpdDoct = (ReportDocument)rOPDdoc;
                        InitialiseLabels(rptOpdDoct);
                        rptOpdDoct.SetDataSource(clnt.GetOPDMRDoctor(ParamField, ParamField2, ParamDateFrom, ParamDateTo));
                        //rptOpdDoct.SetDataSource(clnt.GetsOPD());
                        crystalReportViewer1.ReportSource = rptOpdDoct;
                        ShowReport(rptOpdDoct, this.isPrintDirect);
                        break;
                    #endregion

                    #region OPDDoctorCons
                    case ViewerSelector.OPDDoctorConsFee:
                        ReportDocument rptOpdDoctCons;
                        rptOPDDocCons rOPDdocCons = new rptOPDDocCons();
                        rptOpdDoctCons = (ReportDocument)rOPDdocCons;
                        InitialiseLabels(rptOpdDoctCons);
                        rOPDdocCons.SetDataSource(clnt.GetOPDMRDoctor(ParamField, ParamField2, ParamDateFrom, ParamDateTo));
                        crystalReportViewer1.ReportSource = rptOpdDoctCons;
                        ShowReport(rOPDdocCons, this.isPrintDirect);
                        break;
                    #endregion

                    #region HRDoctorList
                    case ViewerSelector.HRDoctorList:
                        ReportDocument rptHRDoct;
                        rptOPDDepartment rHRDoct = new rptOPDDepartment();
                        rptHRDoct = (ReportDocument)rHRDoct;
                        InitialiseLabels(rptHRDoct);
                        rptHRDoct.SetDataSource(clnt.GetOPDTicketMR(WhereCondition));
                        crystalReportViewer1.ReportSource = rHRDoct;
                        ShowReport(rptHRDoct, this.isPrintDirect);
                        break;
                    #endregion
                }
                this.crystalReportViewer1.RefreshReport();
        }

        private void frmReportViewerOPD_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.RefreshReport();
            this.crystalReportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
           // this.reportViewer1.RefreshReport();
        }
    }
}
