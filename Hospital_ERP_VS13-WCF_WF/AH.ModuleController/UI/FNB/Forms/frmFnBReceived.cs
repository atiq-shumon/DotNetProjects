using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.ModuleController.FNBSR;
using AH.DUtility;




namespace AH.ModuleController.UI.FNB.Forms
{
    public partial class frmFnBReceived : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        public frmFnBReceived()
        {
            InitializeComponent();
        }

        private void frmFnBReceived_Load(object sender, EventArgs e)
        {
            Format_Grid();
            FormaList();
            cboGroupName.ValueMember = "Key";
            cboGroupName.DisplayMember = "Value";
            cboGroupName.DataSource = new BindingSource(fnbs.GetStockGroup(), null);
            LoadListView();
        }

        private void LoadListView()
        {
            lvwfnbReceived.Items.Clear();
            List<Material_Receipt> Io = fnbs.GetpopulatedList().ToList();
            if (Io.Count > 0)
            {
                foreach (Material_Receipt objmr in Io)
                {
                    ListViewItem itm = new ListViewItem(objmr.MrrNo);
                    itm.SubItems.Add(objmr.MrrDate.ToString());
                    lvwfnbReceived.Items.Add(itm);
                }
            }
        }
        private void Display(string strRefNo)
        {
            List<Material_Receipt> objReceipt = fnbs.DisplayDetailsAgainsrRef(strRefNo).ToList();
            int i;
            int k = 0;
            DG.Rows.Clear();
            i = objReceipt.Count();
            DG.Rows.Add(i);
            foreach (Material_Receipt mrr in objReceipt)
            {
                DG.Rows[k].Cells[0].Value = mrr.ProductID.ToString();
                DG.Rows[k].Cells[1].Value = mrr.ProductName.ToString();
                DG.Rows[k].Cells[2].Value = mrr.Unitcode.ToString();
                DG.Rows[k].Cells[3].Value = mrr.UnitName.ToString();
                DG.Rows[k].Cells[4].Value = mrr.BrandID.ToString();
                //DG.Rows[k].Cells[3].Value = mrr.BrandName.ToString();
                DG.Rows[k].Cells[5].Value = mrr.ModelID.ToString();
                //DG.Rows[k].Cells[6].Value = mrr.ModelName.ToString();
                DG.Rows[k].Cells[6].Value = mrr.Quantity.ToString();
                DG.Rows[k].Cells[7].Value = mrr.Rate.ToString();
                DG.Rows[k].Cells[8].Value = (mrr.Quantity * mrr.Rate);
                k = k + 1;
            }
        }
        public DataGridViewButtonColumn Create_Grid_Column_button(string pname, string htext, string btext, int cwidth, Boolean true_false,
        DataGridViewContentAlignment Align, Boolean read_only)
        {
            DataGridViewButtonColumn col0 = new DataGridViewButtonColumn();
            col0.DataPropertyName = pname;
            col0.HeaderText = htext;
            col0.Text = btext;
            col0.DefaultCellStyle.ForeColor = Color.Red;
            col0.DefaultCellStyle.BackColor = Color.White;
            col0.Visible = true_false;
            col0.DefaultCellStyle.Alignment = Align;
            col0.Width = cwidth;
            col0.ReadOnly = read_only;
            return col0;
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
        private void Format_Grid()
        {
            DG.Columns.Add(Create_Grid_Column("Item Code", "Item Code", 0, false, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Item Name", "Item Name", 370, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Unit Code", "Unit Code", 0, false, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Unit Name", "Unit Name", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Brand Code", "Brand Code", 0, false, DataGridViewContentAlignment.TopLeft, true));
            //DG.Columns.Add(Create_Grid_Column("Brand Name", "Brand Name", 135, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Model Code", "Model Code", 0, false, DataGridViewContentAlignment.TopLeft, true));
            //DG.Columns.Add(Create_Grid_Column("Model Name", "Model Name", 135, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Qty.", "Qty.", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Rate", "Rate", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Amount", "Amount", 100, true, DataGridViewContentAlignment.TopLeft, true));
            //DG.Columns.Add(Create_Grid_Column_button("Del", "Del", "Del", 70, true, DataGridViewContentAlignment.TopCenter, true));
        }
        private void mLaodAgainstRef(string strGroupID)
        {
            cboAgainstRefNo.ValueMember = "MrrNo";
            cboAgainstRefNo.DisplayMember = "MrrNo";
            cboAgainstRefNo.DataSource = fnbs.GetMaterialRefNo(strGroupID).ToList();

        }

        private void cboAgainstRefNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAgainstRefNo.Text != "--Select--")
            {
                Display(cboAgainstRefNo.SelectedValue.ToString());
            }
        }

        private void cboGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGroupName.Text != "--Select--")
            {
                mLaodAgainstRef(cboGroupName.SelectedValue.ToString());
            }
        }
        private bool ValidateFields()
        {

            List<string> vf = new List<string>() { "txtBranchName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            return true;
        }
        private Material_Receipt PopulateReceipt()
        {
            Material_Receipt objMrr = new Material_Receipt();
            objMrr.MrrNo = txtMrrNo.Text;
            objMrr.Groupcode = cboGroupName.SelectedValue.ToString();
            objMrr.MrrDate = dtevDate.Text;
            objMrr.AgainstRefNo = cboAgainstRefNo.SelectedValue.ToString();
            objMrr.Notes = txtRemarks.Text.ToString();

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objMrr.EntryParameter = ep;
            return objMrr;
        }


        private void FormaList()
        {
            lvwfnbReceived.CheckBoxes = false;
            lvwfnbReceived.Columns.Add("Reference No", 100, HorizontalAlignment.Center);
            lvwfnbReceived.Columns.Add("Receiving Date", 120, HorizontalAlignment.Center);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int k=0;
            if (ValidateFields() == false)
            {
                return;
            }
            var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (strResponse == DialogResult.Yes)
            {

                Material_Receipt objR = this.PopulateReceipt();
                string i = fnbs.SaveMrr(objR);
                if (i == "0")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i != "0")
                {
                    string strProductCode = "", strUnitCode = "", strBrandCode = "", strModelNo = "";
                    double dblQty = 0, dblRate = 0, dblNetAmount = 0;
                    for (int K = 0; K < DG.Rows.Count - 1;K++ )
                    {
                        strProductCode = DG.Rows[K].Cells[0].Value.ToString();
                        strUnitCode = DG.Rows[K].Cells[2].Value.ToString();
                        strBrandCode = DG.Rows[K].Cells[4].Value.ToString();
                        strModelNo = DG.Rows[K].Cells[5].Value.ToString();
                        dblQty = Convert.ToDouble(DG.Rows[K].Cells[6].Value);
                        dblRate = Convert.ToDouble(DG.Rows[K].Cells[7].Value);
                        dblNetAmount = Convert.ToDouble(DG.Rows[K].Cells[8].Value);
                        k = fnbs.SaveMrrTrans(i, strProductCode, strUnitCode, strBrandCode, strModelNo, dblQty, dblRate, dblNetAmount, objR);
                    }

                    if (k > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtMrrNo.Focus();
                        //LoadListView();
                    }
                }
            }
        }
        private void DisplayMaterialReceipt(string strMrrNo)
        {
            List<Material_Receipt> objReceipt = fnbs.Displaymaterialreceipt(strMrrNo).ToList();
            int i;
            int k = 0;
            DG.Rows.Clear();
            i = objReceipt.Count();
            DG.Rows.Add(i);
            foreach (Material_Receipt mrr in objReceipt)
            {

                cboGroupName.Enabled = false;
                cboAgainstRefNo.Enabled = false;
                cboGroupName.SelectedValue = mrr.Groupcode;
                cboAgainstRefNo.Text = mrr.AgainstRefNo;
                dtevDate.Text = mrr.MrrDate;
                txtMrrNo.Text = mrr.MrrNo.ToString();
                txtRemarks.Text = mrr.Notes;
                DG.Rows[k].Cells[0].Value = mrr.ProductID.ToString();
                DG.Rows[k].Cells[1].Value = mrr.ProductName.ToString();
                DG.Rows[k].Cells[2].Value = mrr.Unitcode.ToString();
                DG.Rows[k].Cells[3].Value = mrr.UnitName.ToString();
                DG.Rows[k].Cells[4].Value = mrr.BrandID.ToString();
                //DG.Rows[k].Cells[3].Value = mrr.BrandName.ToString();
                DG.Rows[k].Cells[5].Value = mrr.ModelID.ToString();
                //DG.Rows[k].Cells[6].Value = mrr.ModelName.ToString();
                DG.Rows[k].Cells[6].Value = mrr.Quantity.ToString();
                DG.Rows[k].Cells[7].Value = mrr.Rate.ToString();
                DG.Rows[k].Cells[8].Value = (mrr.Quantity * mrr.Rate);
                k = k + 1;
            }
        }
        private void lvwfnbReceived_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwfnbReceived.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwfnbReceived.SelectedItems[0];
                DisplayMaterialReceipt(itm.SubItems[0].Text);
                //btnSave.Enabled = false;
                //btnEdit.Enabled = false;
                dtevDate.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (ValidateFields() == false)
            {
                return;
            }
            var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (strResponse == DialogResult.Yes)
            {

                Material_Receipt objR = this.PopulateReceipt();
                short i = fnbs.UpdateMrr(objR);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i != 0)
                {
                    string strProductCode = "", strUnitCode = "", strBrandCode = "", strModelNo = "";
                    double dblQty = 0, dblRate = 0, dblNetAmount = 0;
                    for (int K = 0; K < DG.Rows.Count - 1; K++)
                    {
                        strProductCode = DG.Rows[K].Cells[0].Value.ToString();
                        strUnitCode = DG.Rows[K].Cells[2].Value.ToString();
                        strBrandCode = DG.Rows[K].Cells[4].Value.ToString();
                        strModelNo = DG.Rows[K].Cells[5].Value.ToString();
                        dblQty = Convert.ToDouble(DG.Rows[K].Cells[6].Value);
                        dblRate = Convert.ToDouble(DG.Rows[K].Cells[7].Value);
                        dblNetAmount = Convert.ToDouble(DG.Rows[K].Cells[8].Value);
                        k = fnbs.UpdateMrrTrans(txtMrrNo.Text.ToString(), strProductCode, strUnitCode, strBrandCode, strModelNo, dblQty, dblRate, dblNetAmount, objR);
                    }

                    if (k > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtMrrNo.Focus();
                        //LoadListView();
                    }
                }
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //     fnbs.number();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string conn = "User ID=agh_fnbms; password=aghit; Data Source=HOSPITALERP;";
        //    //OracleConnection gcnmain = new OracleConnection();
        //    using (OracleConnection gcnmain = new OracleConnection(conn))
        //    {
        //      if (gcnmain.State==ConnectionState.Open)
        //      {
        //          gcnmain.Close();
        //      }
        //      try
        //      {
        //          gcnmain.Open();
        //          MessageBox.Show("ok");
        //      }
        //        catch (Exception ex)
        //      {
        //          MessageBox.Show("CC");
        //      }

        //    }

        //}
    }
}
