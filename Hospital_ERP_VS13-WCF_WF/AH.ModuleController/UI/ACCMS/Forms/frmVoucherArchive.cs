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

namespace AH.ModuleController.UI.ACCMS.Forms
{
    public partial class frmVoucherArchive : AH.Shared.UI.frmSmartFormStandard
    {
        List<VoucherTransaction> objTran;
        AccountsMSSR.ACCMSWSClient accmsc = new AccountsMSSR.ACCMSWSClient();

        public frmVoucherArchive()
        {
            InitializeComponent();
        }

        #region "Ledger Information"
        private void GetLedgerInformation(string strControl)
        {
            cboLedgerName.ValueMember = "Key";
            cboLedgerName.DisplayMember = "Value";
            cboLedgerName.DataSource = new BindingSource(accmsc.GetLedgerInformation(strControl), null);
        }
        #endregion
        #region "Grid Column"
        private void grid_column()
        {
            DG.Columns.Add(Create_Grid_Column("Voucher No", "Voucher No", 120, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Ledger Code", "Leger Code", 100,false , DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Ledger Name", "Leger Name", 180, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Vou. Date", "Vou. Date", 80, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Checque No", "Checque No", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Cheque Date", "Cheque Date", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Drawn On", "Drawn On", 120, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Ref. No", "Ref. No", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Dr", "Dr", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Cr", "Cr", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("vtype", "vtype", 100, false, DataGridViewContentAlignment.TopLeft, false));
            DG.Columns.Add(Create_Grid_Column("Primary Group", "Primary Group", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column_button("Edit", "Edit", "Edit", 40, true, DataGridViewContentAlignment.TopCenter, true));
            DG.Columns.Add(Create_Grid_Column_button("Del", "Del", "Del", 40, true, DataGridViewContentAlignment.TopCenter, false));
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
        public DataGridViewButtonColumn Create_Grid_Column_button(string pname, string htext, string btext, int cwidth, Boolean true_false,
           DataGridViewContentAlignment Align, Boolean read_only)
        {
            DataGridViewButtonColumn col0 = new DataGridViewButtonColumn();
            col0.DataPropertyName = pname;
            col0.HeaderText = htext;
            col0.Text = btext;
            col0.DefaultCellStyle.ForeColor = Color.Red;
            col0.DefaultCellStyle.BackColor = Color.Pink;
            col0.Visible = true_false;
            col0.DefaultCellStyle.Alignment = Align;
            col0.Width = cwidth;
            col0.ReadOnly = read_only;
            return col0;
        }
        #endregion
        #region "Load"
        private void frmVoucherArchive_Load(object sender, EventArgs e)
        {
            try
            {
                grid_column();
                GetLedgerInformation("Ledger");
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
        #region "Keyup/Changed/Click"
        private void cboLedgerName_KeyUp(object sender, KeyEventArgs e)
        {
              int index;
            string actual;
            string found;
            if ((e.KeyCode == Keys.Back) ||
                    (e.KeyCode == Keys.Left) ||
                    (e.KeyCode == Keys.Right) ||
                    (e.KeyCode == Keys.Up) ||
                    (e.KeyCode == Keys.Down) ||
                    (e.KeyCode == Keys.Delete) ||
                    (e.KeyCode == Keys.PageUp) ||
                    (e.KeyCode == Keys.PageDown) ||
                    (e.KeyCode == Keys.Home) ||
                    (e.KeyCode == Keys.End))
            {
                return;
            }

            // Store the actual text that has been typed.
            actual = this.cboLedgerName.Text;

            // Find the first match for the typed value.
            index = this.cboLedgerName.FindString(actual);

            // Get the text of the first match.
            if (index > -1)
            {
                found = this.cboLedgerName.Items[index].ToString();

                // Select this item from the list.
                this.cboLedgerName.SelectedIndex = index;

                // Select the portion of the text that was automatically
                // added so that additional typing replaces it.
                this.cboLedgerName.SelectionStart = actual.Length;
                this.cboLedgerName.SelectionLength = found.Length;
            }
        }
        private void chkLedger_CheckedChanged(object sender, EventArgs e)
        {
            chkVoucher.Checked = false;
            if (chkLedger.Checked==true )
            {
                cboLedgerName.Enabled = true ;
            }
            else
            {
                cboLedgerName.Enabled=false;
            }

        }
        private void chkVoucher_CheckedChanged(object sender, EventArgs e)
        {

            chkLedger.Checked = false;
            if (chkVoucher.Checked == true)
            {
                txtVoucherNo.Enabled = true;
            }
            else
            {
                txtVoucherNo.Enabled = false;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string where = "";
            int intCount = 0;
            int i = 0;
            double dblDr = 0, dblCr = 0;

            try
            {
                lblDrTotal.Text = "0";
                lblCrTotal.Text = "0";
                DG.Rows.Clear();
                objTran = null;
                string strPost = "N";
                if (radPost.Checked == true)
                    strPost = "Y";

                if (radAll.Checked == true && chkLedger.Checked == false && chkVoucher.Checked == false)
                {
                    objTran = accmsc.GetArchieve("All", "", 0, dteFdate.Text.ToString(), dteTdate.Text.ToString(), strPost).ToList();
                    intCount = objTran.Count;
                }
                else if (radPayment.Checked == true && chkLedger.Checked == false && chkVoucher.Checked == false)
                {
                    objTran = accmsc.GetArchieve("Vouchertype", "", 1, dteFdate.Text, dteTdate.Text, strPost).ToList();
                    intCount = objTran.Count;
                }
                else if (radReceipt.Checked == true && chkLedger.Checked == false && chkVoucher.Checked == false)
                {
                    objTran = accmsc.GetArchieve("Vouchertype", "", 2, dteFdate.Text, dteTdate.Text, strPost).ToList();
                    intCount = objTran.Count;
                }
                else if (radJournal.Checked == true && chkLedger.Checked == false && chkVoucher.Checked == false)
                {
                    objTran = accmsc.GetArchieve("Vouchertype", "", 3, dteFdate.Text, dteTdate.Text, strPost).ToList();
                    intCount = objTran.Count;
                }
                else if (radContra.Checked == true && chkLedger.Checked == false && chkVoucher.Checked == false)
                {
                    objTran = accmsc.GetArchieve("Vouchertype", "", 4, dteFdate.Text, dteTdate.Text, strPost).ToList();
                    intCount = objTran.Count;
                }
                else if (radAccounts.Checked == true && chkLedger.Checked == false && chkVoucher.Checked == false)
                {
                    objTran = accmsc.GetArchieve("Integretedvoucher", "", 0, dteFdate.Text, dteTdate.Text, strPost).ToList();
                    intCount = objTran.Count;
                }
                else if (radIPD.Checked == true && chkLedger.Checked == false && chkVoucher.Checked == false)
                {
                    objTran = accmsc.GetArchieve("Integretedvoucher", "", 1, dteFdate.Text, dteTdate.Text, strPost).ToList();
                    intCount = objTran.Count;
                }
                else if (radOPD.Checked == true && chkLedger.Checked == false && chkVoucher.Checked == false)
                {
                    objTran = accmsc.GetArchieve("Integretedvoucher", "", 2, dteFdate.Text, dteTdate.Text, strPost).ToList();
                    intCount = objTran.Count;
                }
                else if (radPharmacy.Checked == true && chkLedger.Checked == false && chkVoucher.Checked == false)
                {
                    objTran = accmsc.GetArchieve("Integretedvoucher", "", 3, dteFdate.Text, dteTdate.Text, strPost).ToList();
                    intCount = objTran.Count;
                }
                else if (radHrm.Checked == true && chkLedger.Checked == false && chkVoucher.Checked == false)
                {
                    objTran = accmsc.GetArchieve("Integretedvoucher", "", 4, dteFdate.Text, dteTdate.Text, strPost).ToList();
                    intCount = objTran.Count;
                }
                else if (radInvestigation.Checked == true && chkLedger.Checked == false && chkVoucher.Checked == false)
                {
                    objTran = accmsc.GetArchieve("Integretedvoucher", "", 5, dteFdate.Text, dteTdate.Text, strPost).ToList();
                    intCount = objTran.Count;
                }
                else if (radFoodBeverage.Checked == true && chkLedger.Checked == false && chkVoucher.Checked == false)
                {
                    objTran = accmsc.GetArchieve("Integretedvoucher", "", 6, dteFdate.Text, dteTdate.Text, strPost).ToList();
                    intCount = objTran.Count;
                }

                else if (chkLedger.Checked == true)
                {
                    where = cboLedgerName.SelectedValue.ToString();
                    objTran = accmsc.GetArchieve("Ledgercode", where, 0, dteFdate.Text, dteTdate.Text, strPost).ToList();
                    intCount = objTran.Count;
                }
                else if (chkVoucher.Checked == true)
                {
                    where = txtVoucherNo.Text.ToString();
                    objTran = accmsc.GetArchieve("VoucherNo", where, 0, dteFdate.Text, dteTdate.Text, strPost).ToList();
                    intCount = objTran.Count;
                }
                else if (radPost.Checked == true)
                {
                    where = "Y";
                    objTran = accmsc.GetArchieve("PU", where, 0, dteFdate.Text, dteTdate.Text, strPost).ToList();
                    intCount = objTran.Count;
                }
                else if (radUnpost.Checked == true)
                {
                    where = "N";
                    objTran = accmsc.GetArchieve("PU", where, 0, dteFdate.Text, dteTdate.Text, strPost).ToList();
                    intCount = objTran.Count;
                }



                if (intCount > 0)
                {
                    DG.Rows.Add(intCount);
                    foreach (VoucherTransaction vt in objTran)
                    {
                        DG.Rows[i].Cells[0].Value = vt.strRefNo;
                        DG.Rows[i].Cells[1].Value = vt.LedgerCode;
                        DG.Rows[i].Cells[2].Value = vt.strLedgerName;
                        DG.Rows[i].Cells[3].Value = vt.strVoucherDate;
                        DG.Rows[i].Cells[4].Value = vt.strChequeNo;
                        DG.Rows[i].Cells[5].Value = vt.strChequedate;
                        DG.Rows[i].Cells[6].Value = vt.strDrawnon;
                        DG.Rows[i].Cells[7].Value = vt.ModuleRefNo;
                        DG.Rows[i].Cells[8].Value = vt.dblDebitamount.ToString();
                        dblDr = dblDr + Convert.ToDouble(vt.dblDebitamount.ToString());
                        DG.Rows[i].Cells[9].Value = vt.dblCreditAmount.ToString();
                        dblCr = dblCr + Convert.ToDouble(vt.dblDebitamount.ToString());
                        DG.Rows[i].Cells[10].Value = Convert.ToInt16(vt.vintVoucherType.ToString());
                        DG.Rows[i].Cells[11].Value = vt.Primarygroup.ToString();
                        if (i % 2 == 0)
                        {
                            DG.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else
                        {
                            DG.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        }

                        i = i + 1;
                    }
                    lblDrTotal.Text = dblDr.ToString();
                    lblCrTotal.Text = dblCr.ToString();

                    //foreach (DataGrid item in DG.Rows)
                    //{
                    //    if ((item.index % 2) == 0)
                    //        item.BackColor = Color.Yellow;
                    //    else
                    //        item.BackColor = Color.LightBlue;
                    //}
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
        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strVoucher = "";
            int vType = 0;
            int selRowIndex = e.RowIndex;
            if (e.ColumnIndex ==12)
            {
                if (DG.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    if (radPost.Checked == true)
                    {
                        MessageBox.Show("Cannnot Edit, Because It is already Posted");
                        return;
                    }
                    strVoucher = DG.Rows[e.RowIndex].Cells[0].Value.ToString();
                    vType = Convert.ToInt16(DG.Rows[e.RowIndex].Cells[10].Value.ToString());
                    frmVoucher frm = new frmVoucher();
                    frm.GetArchievDisplay(strVoucher, vType);
                    frm.ShowDialog();
                }
            }
            if(e.ColumnIndex==13)
            {
                //if (DG.Rows[e.RowIndex].Cells[0].Value != null)
                //{
                //    strVoucher = DG.Rows[e.RowIndex].Cells[0].Value.ToString();
                //    {
                //        vType = Convert.ToInt16(DG.Rows[e.RowIndex].Cells[10].Value.ToString());
                //        var strResponse = MessageBox.Show("Do U want to Delete?", "Delete Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //        if (strResponse == DialogResult.Yes)
                //        {
                //            short i = accmsc.DeleteVoucher(strVoucher, vType);
                //            if (i == 0)
                //            {
                //                MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //            }
                //            else if (i > 0)
                //            {
                //                MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //                btnSearch.PerformClick();
                //            }
                //        }
                //    }
                //}
                MessageBox.Show("Cannot Delete");
                return;

            }
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void radUnpost_CheckedChanged(object sender, EventArgs e)
        {
            DG.Rows.Clear();
        }

        private void radPost_CheckedChanged(object sender, EventArgs e)
        {
            DG.Rows.Clear();
        }
    }
}
