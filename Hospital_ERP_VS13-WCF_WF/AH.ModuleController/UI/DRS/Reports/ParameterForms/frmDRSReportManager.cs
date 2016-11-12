using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.UI.DRS.Reports.Viewer;
using AH.DUtility;

namespace AH.ModuleController.UI.DRS.Reports.ParameterForms
{
    public partial class frmDRSReportManager : AH.Shared.UI.frmSmartFormReportStandard
    {
        public frmDRSReportManager()
        {
            InitializeComponent();
        }
        DRSSR.DRSWSClient dsrClnt = new DRSSR.DRSWSClient();
        private void rdoInvestigationReport_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Report ID :";
            lblParam1.Visible = true;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            txtMoneyRecNo.Visible = true;
            txtSpecimanNo.Visible = false;
            txt3.Visible = false;          
            gbDateRange.Enabled = false;
            txtMoneyRecNo.Focus();
        }

        public void InvestigationReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.InvestigationReport;
            ofrmReportViewer.TransactionNo = txtMoneyRecNo.Text;
            ofrmReportViewer.ViewReport();
        }
        public void StainReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.StainReport ;
            ofrmReportViewer.TransactionNo = txtMoneyRecNo.Text;
            ofrmReportViewer.ViewReport();
        }
        public void CulAndSensiReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.CultureAndSensiReport ;
            ofrmReportViewer.TransactionNo = txtMoneyRecNo.Text;
            ofrmReportViewer.ViewReport();
        }

        public void CulAndSensiMultiColumnReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.multicolumn;
            ofrmReportViewer.TransactionNo = txtMoneyRecNo.Text;
            ofrmReportViewer.ViewReport();
        }
        public void SpecimenReport(bool param)
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.SpecimenReport;
            ofrmReportViewer.TransactionNo = txtSpecimanNo.Text;
            ofrmReportViewer.isPrintDirect = param;
            ofrmReportViewer.ViewReport();
        }
        public void SpecimenDetReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.SpecimenDetailsReportPreView;
            ofrmReportViewer.TransactionNo = txt3.Text;
            ofrmReportViewer.ViewReport();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rdoInvestigationReport.Checked == true)
            {
                if (dsrClnt.PathologyReportVerify(txtMoneyRecNo.Text) == "0")
                {
                    MessageBox.Show("You Select Worng Report Group For this Report ID,Please Check!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);              
                    return;
                }  
                InvestigationReport();
            }
            if (rdoSpecimen.Checked == true)
            {
                SpecimenReport(false);
            }

            if (rdoSpecimenDet.Checked == true)
            {
                if (dsrClnt.verifyMrno(txt3.Text) == "0")
                {
                    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt3.Select();                       
                    return;
                }
                SpecimenDetReport();
            }
            if (rdStainReport.Checked == true)
            {
                if (dsrClnt.PathologyReportVerify(txtMoneyRecNo.Text) == "0")
                {
                    MessageBox.Show("You Select Worng Report Group For this Report ID,Please Check!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }  
                StainReport();
            }
            if (rdoCultAndSensiReport.Checked == true)
            {
                if (dsrClnt.MBIOReportVerify(txtMoneyRecNo.Text) == "0")
                {
                    MessageBox.Show("You Select Worng Report Group For this Report ID,Please Check!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }  
               // CulAndSensiReport();
                CulAndSensiMultiColumnReport();
            }

            if (rdoBtnMultiColumn.Checked == true)
            {
                if (dsrClnt.MBIOReportVerify(txtMoneyRecNo.Text) == "0")
                {
                    MessageBox.Show("You Select Worng Report Group For this Report ID,Please Check!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CulAndSensiMultiColumnReport();
            }
                 
        }

        private void frmDRSReportManager_Load(object sender, EventArgs e)
        {
            rdoSpecimenDet.Checked = true;
            txt3.Select();
        }

        private void rdoSpecimen_CheckedChanged(object sender, EventArgs e)
        {
            lblParam2.Text = "Money Receipt No :";

            lblParam2.Visible = true;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtMoneyRecNo.Visible = false;
            txtSpecimanNo.Visible = true;
            txt3.Visible = false;
            gbDateRange.Enabled = false;
            lblParam2.Visible = true;
        }

        private void rdoSpecimenDet_CheckedChanged(object sender, EventArgs e)
        {
            lblParam3.Text = "Money Receipt No :";
            lblParam3.Visible = true;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            txtMoneyRecNo.Visible = false;
            txtSpecimanNo.Visible = false;
            txt3.Visible = true;
            gbDateRange.Enabled = false;
            txt3.Focus();       
           
        }

        private void rdStainReport_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Report ID :";
            lblParam1.Visible = true;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            txtMoneyRecNo.Visible = true;
            txtSpecimanNo.Visible = false;
            txt3.Visible = false;
            gbDateRange.Enabled = false;
            txtMoneyRecNo.Focus();
        }

        private void rdoCultAndSensiReport_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Report ID :";
            lblParam1.Visible = true;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            txtMoneyRecNo.Visible = true;
            txtSpecimanNo.Visible = false;
            txt3.Visible = false;
            gbDateRange.Enabled = false;
            txtMoneyRecNo.Focus();
        }

        private void txt3_Leave(object sender, EventArgs e)
        {
            txt3.Text = txt3.Text.ToUpper();
        }

        private void txtMoneyRecNo_Leave(object sender, EventArgs e)
        {
            txtMoneyRecNo.Text = txtMoneyRecNo.Text.ToUpper();
        }

        private void txtSpecimanNo_Leave(object sender, EventArgs e)
        {
            txtSpecimanNo.Text = txtSpecimanNo.Text.ToUpper();
        }

        private void txt3_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void rdoBtnMultiColumn_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Report ID :";
            lblParam1.Visible = true;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            txtMoneyRecNo.Visible = true;
            txtSpecimanNo.Visible = false;
            txt3.Visible = false;
            gbDateRange.Enabled = false;
            txtMoneyRecNo.Focus();
        }
    }
}
