using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.UI.PHRMS.Reports.ParameterForms;
using AH.ModuleController.UI.ACMS.Forms;
using AH.ModuleController.UI.INVMS.Forms;

namespace AH.ModuleController.UI.PHRMS.Forms
{
    public partial class frmPHRMSMain : Form
    {
        
        public frmPHRMSMain()
        {
            InitializeComponent();
        }
        private void frmPHRMSMain_Load(object sender, EventArgs e)
        {
            pnlPatientRegistration.Visible = false;
            Utility.EnforceSecurity("PHRMIS", menuStrip1, pnlPatientRegistration);
            Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);            
            pnlPatientRegistration.Visible = true;
            btnCloseModule.Enabled = true;
        }
        
        private void mnuGroupSetup_Click(object sender, EventArgs e)
        {

        }

        private void sBtnBedFeeSetup_Click(object sender, EventArgs e)
        {
            //frmBedFeeSetup bfee = new frmBedFeeSetup();
            //bfee.ShowDialog();
        }

        private void btnCloseModule_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void mnuPharmacyLocation_Click(object sender, EventArgs e)
        {
            frmPharmacyLocation loc = new frmPharmacyLocation();
            loc.ShowDialog();
        }

        private void mnuSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier sup = new frmSupplier();
            sup.ShowDialog();
        }

        private void mnuPurchaseOrder_Click(object sender, EventArgs e)
        {
            frmPurchaseOrder po = new frmPurchaseOrder();
            po.ShowDialog();
        }

        private void mnuPurchaseOrder_Click_1(object sender, EventArgs e)
        {
            frmPurchaseOrder po = new frmPurchaseOrder();
            po.ShowDialog();
        }


        private void btnPO_Click(object sender, EventArgs e)
        {
            frmPurchaseOrder po = new frmPurchaseOrder();
            po.ShowDialog();
        }

        private void btnOPDSales_Click(object sender, EventArgs e)
        {
            frmDrugIssue di = new frmDrugIssue("0007", "O");
            di.ShowDialog();
        }

        private void btnIPDSales_Click(object sender, EventArgs e)
        {
            frmDrugIssue di = new frmDrugIssue("0061", "I");
            di.ShowDialog();
        }

        private void btnOutCaseSales_Click(object sender, EventArgs e)
        {
            frmDrugIssue di = new frmDrugIssue("0007", "X");
            di.ShowDialog();
        }

        private void mnuItemRateSetup_Click(object sender, EventArgs e)
        {
            frmItemRates rate = new frmItemRates();
            rate.ShowDialog();
        }

        private void mnuPharmacyUser_Click(object sender, EventArgs e)
        {
            frmPharmacyUsers user = new frmPharmacyUsers();
            user.ShowDialog();
        }

        private void reportManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuProductList_Click(object sender, EventArgs e)
        {
            frmPHRMSReportManager rpt = new frmPHRMSReportManager();
            rpt.ShowDialog();
        }

        private void mnuSalesReport_Click(object sender, EventArgs e)
        {
            frmPHRMSReportManager rpt = new frmPHRMSReportManager();
            rpt.ShowDialog();
        }

        private void mnuSalesReportDetails_Click(object sender, EventArgs e)
        {
            frmPHRMSReportManager rptdet = new frmPHRMSReportManager();
            rptdet.ShowDialog();
        }

        private void mnuMaterialReceive_Click(object sender, EventArgs e)
        {
            frmMaterialReceive mrr = new frmMaterialReceive();
            mrr.ShowDialog();
        }

        private void mnuPODetailsReport_Click(object sender, EventArgs e)
        {

            frmPHRMSReportManager rpt = new frmPHRMSReportManager();
            rpt.tabindex = 1;
            
            rpt.ShowDialog();
        }

        private void mnuPOTypes_Click(object sender, EventArgs e)
        {
            frmPOTypes potype = new frmPOTypes();
            potype.ShowDialog();
        }

        private void mnuProductLedger_Click(object sender, EventArgs e)
        {
            frmPHRMSReportManager rpt = new frmPHRMSReportManager();
            rpt.ShowDialog();
        }

        private void mnuOpeningEntry_Click(object sender, EventArgs e)
        {
            frmOpeningEntry open = new frmOpeningEntry("01", "000000");
            open.ShowDialog();

        }

        private void mnuDayEnd_Click(object sender, EventArgs e)
        {
            frmDayClose dclose = new frmDayClose();
            dclose.ShowDialog();
        }

        private void mnuPOReportDateWise_Click(object sender, EventArgs e)
        {
            frmPHRMSReportManager rpt = new frmPHRMSReportManager();
            rpt.ShowDialog();
        }

        private void mnuDrugUnitSetup_Click(object sender, EventArgs e)
        {
            frmDrugUnit unit = new frmDrugUnit();
            unit.ShowDialog();
        }

        private void mnuDrugPacketType_Click(object sender, EventArgs e)
        {
            frmDrugPacketType pack = new frmDrugPacketType();
            pack.ShowDialog();
        }

        private void mnuDrugMaster_Click(object sender, EventArgs e)
        {
            frmDrugMaster master = new frmDrugMaster();
            master.ShowDialog();
        }

        
        private void mnuDrugIssue_Click(object sender, EventArgs e)
        {
            frmDrugIssue di = new frmDrugIssue("01","I");
            di.ShowDialog();
        }

        private void mnuChangePassword_Click(object sender, EventArgs e)
        {
            frmPasswordReset opassword = new frmPasswordReset();
            opassword.ShowDialog();
        }

        private void mnuDrugDoseSetup_Click(object sender, EventArgs e)
        {
            frmDrugDose odrugdose = new frmDrugDose();
            odrugdose.ShowDialog();
        }

        private void mnuDrugCompany_Click(object sender, EventArgs e)
        {
            frmDrugCompany com = new frmDrugCompany();
            com.ShowDialog();
        }

        private void mnuDrugGroup_Click(object sender, EventArgs e)
        {
            frmDrugGroupSetup drgr = new frmDrugGroupSetup();
            drgr.ShowDialog();
        }

        private void mnuConsumption_Click(object sender, EventArgs e)
        {
            frmConsumptionPurpose con = new frmConsumptionPurpose();
            con.ShowDialog();
        }

        private void mnuMedicineStockReport_Click(object sender, EventArgs e)
        {
            frmPHRMSReportManager rpt = new frmPHRMSReportManager();
            rpt.ShowDialog();
        }

        private void userWidgetMetro1_btnLogout_Clicked(object sender, EventArgs e)
        {
            userWidgetMetro1.Parent.Dispose();
            Utility.isAuthenticated = 0;
            frmLogIn logIn = new frmLogIn("PHRMIS");
            logIn.atiqsLogInUserControl1.IsPrefilled = false;
            logIn.ShowDialog();
            logIn.atiqsLogInUserControl1.txtUserID.Text = "";
            logIn.atiqsLogInUserControl1.txtPassword.Text = "";
        }

        private void mnuPurchaseRequisition_Click(object sender, EventArgs e)
        {
            frmPurchaseRequisition oreq = new frmPurchaseRequisition();
            oreq.ShowDialog();
        }

        private void btnPurchaseRequisition_Click(object sender, EventArgs e)
        {
            frmPurchaseRequisition oreq = new frmPurchaseRequisition();
            oreq.ShowDialog();
        }

        private void mnuIssueReturn_Click(object sender, EventArgs e)
        {
            frmIssueReturn oret = new frmIssueReturn();
            oret.ShowDialog();
        }

        private void mnuDrugConsumption_Click(object sender, EventArgs e)
        {
            frmConsumptionForm oconsump = new frmConsumptionForm();
            oconsump.ShowDialog();
        }

        private void mnuPurchaseReturn_Click(object sender, EventArgs e)
        {
            frmPurchaseReturn oret = new frmPurchaseReturn();
            oret.ShowDialog();
        }

        private void mnuOpeningReport_Click(object sender, EventArgs e)
        {
            frmPHRMSReportManager rpt = new frmPHRMSReportManager();
            rpt.ShowDialog();
        }

        private void mnuExpireDateReport_Click(object sender, EventArgs e)
        {
            frmPHRMSReportManager rpt = new frmPHRMSReportManager();
            rpt.ShowDialog();
        }

        private void mnuPurchaseRequisition_Click_1(object sender, EventArgs e)
        {
            frmPurchaseRequisition opurchasereq = new frmPurchaseRequisition();
            opurchasereq.ShowDialog();
        }

        private void mnuMaterialReceive_Click_1(object sender, EventArgs e)
        {
            frmMaterialReceive omaterialreceive = new frmMaterialReceive();
            omaterialreceive.ShowDialog();
        }

        private void mnuDrugIssue_Click_1(object sender, EventArgs e)
        {
            frmDrugIssue odrugissue = new frmDrugIssue("01", "I");
            odrugissue.ShowDialog();
        }

        private void mnuPurchaseOrder_Click_2(object sender, EventArgs e)
        {
            frmPurchaseOrder opurchaseorder = new frmPurchaseOrder();
            opurchaseorder.ShowDialog();
        }

        private void mnuTermsConditions_Click(object sender, EventArgs e)
        {
            frmTermsConditions oterms = new frmTermsConditions();
            oterms.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mnuDrugMaster_Click_1(object sender, EventArgs e)
        {
            frmDrugMaster master = new frmDrugMaster();
            master.ShowDialog();
        }

        private void mnuDrugGroup_Click_1(object sender, EventArgs e)
        {
            frmDrugGroupSetup drgr = new frmDrugGroupSetup();
            drgr.ShowDialog();
        }

        private void mnuDrugCompany_Click_1(object sender, EventArgs e)
        {
            frmDrugCompany ocompany = new frmDrugCompany();
            ocompany.ShowDialog();
        }

        private void mnuDrugUnitSetup_Click_1(object sender, EventArgs e)
        {
            frmDrugUnit odrugunit = new frmDrugUnit();
            odrugunit.ShowDialog();
        }

        private void mnuDrugPacketType_Click_1(object sender, EventArgs e)
        {
            frmDrugPacketType otype = new frmDrugPacketType();
            otype.ShowDialog();
        }

        private void mnuDrugConsumption_Click_1(object sender, EventArgs e)
        {
            frmConsumptionForm oconsform = new frmConsumptionForm();
            oconsform.ShowDialog();
        }

        private void mnuOpdSales_Click(object sender, EventArgs e)
        {
            frmDrugIssue di = new frmDrugIssue("0007", "O");
            di.ShowDialog();
        }

        private void mnuIPDSales_Click(object sender, EventArgs e)
        {
            frmDrugIssue di = new frmDrugIssue("0061", "I");
            di.ShowDialog();
        }

        private void mnuOutCaseSales_Click(object sender, EventArgs e)
        {
            frmDrugIssue di = new frmDrugIssue("0007", "X");
            di.ShowDialog();
        }

        private void mnuCollectionSendToAccount_Click(object sender, EventArgs e)
        {
            frmCollectionSendToAccounts ocollection = new frmCollectionSendToAccounts();
            ocollection.ShowDialog();
        }

        private void mnuTrackingPrPoMrr_Click(object sender, EventArgs e)
        {
            frmTrackingPrPoMr otrack = new frmTrackingPrPoMr();
            otrack.ShowDialog();
        }

        private void mnuDemandRequisition_Click(object sender, EventArgs e)
        {
            frmDemandRequisition odem = new frmDemandRequisition();
            odem.ShowDialog();
        }

        private void mnuDrugRoute_Click(object sender, EventArgs e)
        {
            frmDrugRouteSetup odrugroute = new frmDrugRouteSetup();
            odrugroute.ShowDialog();
        }

        private void mnuVerifyRequisition_Click(object sender, EventArgs e)
        {
            frmVerifyRequisition overify = new frmVerifyRequisition();
            overify.ShowDialog();
        }

        private void mnuTransferReq_Click(object sender, EventArgs e)
        {
            frmTransferRequisition otr = new frmTransferRequisition();
            otr.ShowDialog();
        }

        private void mnuPharmacyTransfer_Click(object sender, EventArgs e)
        {
            frmTransferReceive oreceive = new frmTransferReceive();
            oreceive.ShowDialog();
        }
        
        
    }
}
