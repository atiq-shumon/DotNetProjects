using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.DMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.DMS.Forms
{
    public partial class frmDueListByHCN : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        public string HCN { set; get; }
        public string PatName { set; get; }
        public frmDueListByHCN()
        {
            InitializeComponent();
        }
        private void FormatGrid(DataGridView dgv)
        {
            this.dgvDetails.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);           
            dgv.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn MRNo = new DataGridViewTextBoxColumn();
            MRNo.Name = "MRNo";
            MRNo.DataPropertyName = "MRNo";
            MRNo.Width = 200;
            MRNo.ReadOnly = true;
            dgv.Columns.Add(MRNo);

            DataGridViewTextBoxColumn NetPaid = new DataGridViewTextBoxColumn();
            NetPaid.Name = "NetPaid";
            NetPaid.DataPropertyName = "NetPaid";
            NetPaid.Width = 150;
            NetPaid.ReadOnly = true;
            dgv.Columns.Add(NetPaid);

            DataGridViewTextBoxColumn Advance = new DataGridViewTextBoxColumn();
            Advance.Name = "Advance";
            Advance.DataPropertyName = "Advance";
            Advance.Width = 150;
            Advance.ReadOnly = true;
            dgv.Columns.Add(Advance);

            DataGridViewTextBoxColumn Due = new DataGridViewTextBoxColumn();
            Due.Name = "Due";
            Due.DataPropertyName = "Due";
            Due.Width = 150;
            Due.ReadOnly = true;
            dgv.Columns.Add(Due);
        }
        private void LoadGridView(string HCN)
        {
            try
            {
                dgvDetails.Rows.Clear();
                int i = 0;
                List<DiagnosticMR> oDiagMRs = dmsSC.GetDueByHCN(txtHCN.Text.ToString()).ToList();
                if (oDiagMRs.Count > 0)
                {
                    foreach (DiagnosticMR oDiag in oDiagMRs)
                    {
                        dgvDetails.Rows.Add(1);
                        dgvDetails.Rows[i].Cells[0].Value = oDiag.MRNo;
                        dgvDetails.Rows[i].Cells[1].Value = oDiag.DiagnosticPayment.NetAmount.ToString();
                        dgvDetails.Rows[i].Cells[2].Value = oDiag.DiagnosticPayment.Advance.ToString();
                        dgvDetails.Rows[i].Cells[3].Value = oDiag.DiagnosticPayment.PreviousDue.ToString();
                        i = i + 1;
                    }
                    dgvDetails.AllowUserToAddRows = false;
                    dgvDetails.CurrentCell = null;
                    dgvDetails.ClearSelection();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void frmDueListByHCN_Load(object sender, EventArgs e)
        {
            try
            {
                FormatGrid(dgvDetails);
                if (HCN != null)
                {
                    txtHCN.Text = HCN;
                    txtName.Text = PatName;
                }
                LoadGridView(txtHCN.Text);
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

    }
}
