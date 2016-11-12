using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.AccountsMSSR;
using AH.DUtility;
using AH.ModuleController.UI.ACCMS.Reports.ParameterForms;
using AH.ModuleController.UI.ACCMS.Reports.Viewer;

namespace AH.ModuleController.UI.ACCMS.Reports.ParameterForms
{
    public partial class frmACCMSReportFixedAssets : AH.Shared.UI.frmSmartFormReportStandard
    {
        AccountsMSSR.ACCMSWSClient accmsc = new AccountsMSSR.ACCMSWSClient();

        public frmACCMSReportFixedAssets()
        {
            InitializeComponent();
        }
        private DataGridViewTextBoxColumn Create_Grid_Column(string pname, string htext, int cwidth, Boolean true_false, DataGridViewContentAlignment Align,
                                                            Boolean read_only)
        {
            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.DataPropertyName = pname;
            col0.HeaderText = htext;
            col0.DefaultCellStyle.ForeColor = Color.Black;
            col0.DefaultCellStyle.BackColor = Color.White;
            col0.Visible = true_false;
            col0.DefaultCellStyle.Alignment = Align;
            col0.Width = cwidth;
            col0.ReadOnly = read_only;
            return col0;
        }
        private void LaodfxdLedger()
        {
            int icount,k=0;
            List<FixedAssets> objfxd = accmsc.GetFxdDepreciationLedger().ToList();
            icount = objfxd.Count;
            if (icount > 0)
            {
                DGdown.Rows.Add(icount);
                foreach (FixedAssets fxd in objfxd)
                {
                    DGdown.Rows[k].Cells[0].Value = fxd.strLedgerCode;
                    k = k + 1;
                }
            }
        }
        private void grid_column()
        {
            DGdown.Columns.Add(Create_Grid_Column("Ledger Code", "Ledger code", 200, true, DataGridViewContentAlignment.TopLeft, true));
        }
        #region "Print"
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string strLedgerCode = "";
            if (radRegister.Checked == true)
            {
                for (int i = 0; i < DGdown.Rows.Count - 1; i++)
                {
                    strLedgerCode = DGdown.Rows[i].Cells[0].Value.ToString() + ",";
                    short k = accmsc.SaveWrittenDownValue(dtStartDate.Text, dtEndDate.Text, strLedgerCode);
                }
               
                //if (strLedgerCode != ""  )
                //{
                //    int lngLen = (strLedgerCode.Length);
                //    strLedgerCode = strLedgerCode.ToString().Substring(1, lngLen-2);
                //}

                frmReportViewer frm = new frmReportViewer();
                frm.selector = ViewerSelector.FixedAssetsReport;
                //frm.WhereCondition = cboCompany.SelectedValue.ToString();
                frm.Where2 = strLedgerCode;
                frm.strFromDate = dtStartDate.Text;
                frm.strToDate = dtEndDate.Text;
                frm.ShowDialog();
            }
            else
            {
                frmReportViewer frm = new frmReportViewer();
                frm.selector = ViewerSelector.FixedAssetsDetails;
                //frm.WhereCondition = cboCompany.SelectedValue.ToString();
                //frm.Where2 = strLedgerCode;
                frm.strFromDate = dtStartDate.Text;
                frm.strToDate = dtEndDate.Text;
                frm.ShowDialog();
            }
        }
        #endregion
        private void frmACCMSReportFixedAssets_Load(object sender, EventArgs e)
        {
            grid_column();
            LaodfxdLedger();
        }
    }
}
