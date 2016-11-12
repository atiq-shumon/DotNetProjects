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
using System.IO;
using System.Drawing.Drawing2D;
using System.Threading;

namespace AH.ModuleController.UI.FNB.Forms
{
    public partial class frmFoodInventoriesVoucher : AH.Shared.UI.frmSmartFormStandard
    {

        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();

        private System.Windows.Forms.TreeNode NodeX;
        private const string mcGROUP_PREFIX = "G_";
        private const string mcLEDGER_PREFIX = "L_";
        private string mcPost = "";

        List<FoodItemRO> objFood;
        public int Vtype;
        public frmFoodInventoriesVoucher()
        {
            InitializeComponent();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
        private void grid_column()
        {
            DG.Columns.Add(Create_Grid_Column("Grcode", "GrCode", 0, false, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Gr Name", "Gr Name", 220, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Item Code", "Item Code", 0, false, DataGridViewContentAlignment.TopLeft, false));
            DG.Columns.Add(Create_Grid_Column("Item Name", "Item Name", 400, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Closing Qty", "Closing Qty", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Opening Qty", "Opening Qty", 100, false, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Qty", "Qty", 60, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Rate", "Rate", 80, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Net Total", "Net Total", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column_button("Del", "Del", "Del", 40, true, DataGridViewContentAlignment.TopCenter, true));
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
        private void frmFoodInventoriesVoucher_Load(object sender, EventArgs e)
        {
            grid_column();
            frmLabel.Text = GetVName(Vtype);
            if (Vtype == 3)
            {
                lblIssueRefNo.Visible = true;
                txtIssueRefNo.Visible = true;
            }
            else 
            {
                lblIssueRefNo.Visible = false;
                txtIssueRefNo.Visible = false;
            }

            cbofoodCat.ValueMember = "key";
            cbofoodCat.DisplayMember = "value";
            cbofoodCat.DataSource = new BindingSource(fnbs.GetFoodCategory(), null);
            dteDate.Focus();
            mLoadMonthTree();
            //btnSave.Enabled = false;
            //btnEdit.Enabled = true;
        }


        private static string GetVName(int intVType)
        {
            string strVName = "";
            if (intVType==1)
            {
                strVName= "Material Receipt";
            }
            else if (intVType==2)
            {
                strVName = "Item Damage";
            }
            else if (intVType == 3)
            {
                strVName = "Issue Return";
            }
            else if (intVType == 4)
            {
                strVName = "Item Issue";
            }
            return strVName;

        }


        private static string  GetMonth(int intDay)
        {
            string Month = "";
            if (intDay==1)
            {
                Month= "January";
            }
            else if (intDay==2)
            {
                Month= "February";
            }
            else if (intDay==3)
            {
                Month= "March";
            }
            else if (intDay==4)
            {
                Month = "April";
            }
            else if (intDay==5)
            {
                Month = "May";
            }
            else if (intDay==6)
            {
                Month = "June";
            }
            else if (intDay==7)
            {
                Month = "July";
            }
            else if (intDay==8)
            {
                Month = "August";
            }
            else if (intDay==9)
            {
                Month = "September";
            }
            else if (intDay==10)
            {
                Month = "October";
            }
            else if (intDay==11)
            {
                Month = "November";
            }
            else if (intDay==12)
            {
                Month = "December";
            }
            return Month;
        }
        private void mLoadMonthTree()
        {
           
            string strMonthType = "";
            string strDate = "";
            DateTime dteDate;
            System.Windows.Forms.TreeNode oNodex = null;
            int i = 0;
            //string strSelection;
            ////strSelection = tvNode.SelectedNode.Text;
            this.tvNode.Nodes.Clear();

            for (int intNode = 1; intNode <= 12; intNode++)
            {
                string strMonthName = GetMonth(intNode);
                oNodex = tvNode.Nodes.Add(mcGROUP_PREFIX + strMonthName, strMonthName, "");
                oNodex.Expand();
            }
            List<Inventory> objInv = fnbs.GetMonthVoucher(Vtype).ToList();
            foreach (Inventory inv in objInv)
            {

                int intMonth = Convert.ToDateTime(inv.MrrDate).Month;
                strMonthType = GetMonth(intMonth);
                if (strDate != inv.MrrDate)
                {
                    oNodex = tvNode.Nodes.Find(mcGROUP_PREFIX + strMonthType, true)[0].Nodes.Add(mcGROUP_PREFIX + inv.MrrDate, inv.MrrDate, "closed");
                    dteDate = Convert.ToDateTime(inv.MrrDate);
                    strDate = dteDate.ToString("dd/MM/yyyy");
                }
                oNodex.Expand();
            }

            foreach (Inventory inv in objInv)
            {
                oNodex = tvNode.Nodes.Find(mcGROUP_PREFIX + inv.MrrDate, true)[0].Nodes.Add(mcGROUP_PREFIX + inv.MrrNo, inv.MrrNo, "closed");
                oNodex.Expand();
            }

        }

        private void txtFoodName_KeyUp(object sender, KeyEventArgs e)
        {

            long result;
            int intCheck;
            if (long.TryParse(txtFoodName.Text, out result))
            {
                intCheck = 0;
            }
            else
            {
                intCheck = 1;
            }

            SearchListView(objFood,intCheck, txtFoodName.Text.ToString());
        }

        private void txtFoodName_KeyDown(object sender, KeyEventArgs e)
        {
            DGLedger.Visible = true;
            //txtFoodCode.Text = "";
            //txtFoodName.Text = "";
            if (e.KeyCode == Keys.Up)
            {
                DGLedger.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                DGLedger.Focus();
            }
        }

        private void txtFoodName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
               if (txtFoodName.Text =="")
               {
                   txtFoodCode.Text = "";
                   txtFoodName.Text = "";
                   DGLedger.Visible = false;
                   btnSave.Focus();
                   return;
               }
                
                if (txtFoodCode.Text != "")
                {
                    DGLedger.Focus();
                    if (DGLedger.Rows.Count > 0)
                    {
                        int i = 0;

                        txtFoodName.Text = DGLedger.Rows[i].Cells[1].Value.ToString();
                        txtFoodCode.Text = DGLedger.Rows[i].Cells[0].Value.ToString();
                        //txtFoodName.Text = DGLedger.Rows[i].Cells[2].Value.ToString();
                        txtQty.Focus();
                        DGLedger.Visible = false;
                    }

                }
                else
                {
                    DGLedger.Focus();
                    ////DGLedger.Visible = false;
                    int i = 0;

                    txtFoodName.Text = DGLedger.Rows[i].Cells[1].Value.ToString();
                    txtFoodCode.Text = DGLedger.Rows[i].Cells[0].Value.ToString();
                    //txtFoodName.Text = DGLedger.Rows[i].Cells[2].Value.ToString();
                    txtQty.Focus();
                    DGLedger.Visible = false;

                }
            }
        }

       


        private void  mEnabled(bool blnEnabled)        
        {
            txtQty.Enabled = blnEnabled;
            txtFoodName.Enabled = blnEnabled;

        }

        private void SearchListView(IEnumerable<FoodItemRO> tests, int intcheck, string searchString = "")
        {
            int j = 0;
            IEnumerable<FoodItemRO> query;

            if (intcheck == 1)
            {
                query = (from test in tests
                         where test.FoodName.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                         select test);
            }
            else
            {
                query = (from test in tests
                         where test.FoodID.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                         select test);
            }

            DGLedger.Rows.Clear();
            foreach (FoodItemRO objFm in query)
            {
                DGLedger.Rows.Add(1);
                DGLedger.Rows[j].Cells[0].Value = objFm.FoodID;
                DGLedger.Rows[j].Cells[1].Value = objFm.FoodName;
                j = j + 1;
            }
        }

        private void DGLedger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                int i = Convert.ToInt16(DGLedger.CurrentRow.Index.ToString());

                txtFoodName.Text = DGLedger.Rows[i].Cells[1].Value.ToString();
                txtFoodCode.Text = DGLedger.Rows[i].Cells[0].Value.ToString();
                txtQty.Focus();
                DGLedger.Visible = false;
            }
        }

        private void DGLedger_DoubleClick(object sender, EventArgs e)
        {
            if (DGLedger.SelectedRows.Count > 0)
            {
                int i = Convert.ToInt16(DGLedger.CurrentRow.Index.ToString());
                txtFoodName.Text = DGLedger.Rows[i].Cells[1].Value.ToString();
                txtFoodCode.Text = DGLedger.Rows[i].Cells[0].Value.ToString();
                DGLedger.Visible = false;
                txtQty.Focus();
                

            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DG.RowCount; i++)
            {

                if (txtFoodName.Text != null && txtFoodName.Text !="")
                    {
            
                        if (txtQty.Text == "" && txtQty.Text =="0")
                        {
                            MessageBox.Show("Cannot Empty");
                            return;
                        }
                        mAdditem(cbofoodCat.SelectedValue.ToString(),cbofoodCat.Text,txtFoodCode.Text,txtFoodName.Text,0,Convert.ToDouble(txtQty.Text));
                        txtFoodCode.Text = "";
                        txtFoodName.Text = "";
                        txtQty.Text = "";
                        txtFoodName.Focus();
                    }
            }
        }


        private void mAdditem(string strGrCode,string strGrNam, string strFoodID, string strFoodName,double  dblOpnQty,double  dblQty)
        {
            int selRaw;
            int intTotal = 0;
            string strDown = "";
            double dblRate = 0,dblAmount=0;
            double dblNetQty = 0, dblNetAmount = 0;
            Boolean blngCheck = false;

            //lblNetQty.Text = "0";
            //lblTotal.Text = "0";

            for (int j = 0; j < DG.RowCount; j++)
            {
                if (DG[2, j].Value != null)
                {
                    strDown = DG[2, j].Value.ToString();
                }
                if (strFoodID == strDown.ToString())
                {
                    blngCheck = true;
                }

            }
            if (blngCheck == false)
            {
                List<FoodMaster> objFm = fnbs.GetItemRate(strFoodID).ToList();
                if (objFm.Count > 0)
                {
                    foreach (FoodMaster fm in objFm)
                    {
                        dblRate = fm.Price;
                    }
                }

                DG.AllowUserToAddRows = true;
                selRaw = Convert.ToInt16(DG.RowCount.ToString());
                selRaw = selRaw - 1;
                DG.Rows.Add(1);
                for (int i = 1; i < DG.Rows.Count; i++)
                {
                    DG[0, selRaw].Value = strGrCode.ToString();
                    DG[1, selRaw].Value = strGrNam.ToString();
                    DG[2, selRaw].Value = strFoodID.ToString();
                    DG[3, selRaw].Value = strFoodName.ToString();
                    DG[5, selRaw].Value = dblOpnQty.ToString();
                    DG[6, selRaw].Value = dblQty.ToString();
                    DG[7, selRaw].Value = dblRate.ToString();
                    DG[8, selRaw].Value = (dblQty * dblRate).ToString();
                    dblNetQty = Convert.ToDouble(lblNetQty.Text) + dblQty;
                    dblNetAmount = Convert.ToDouble(lblTotal.Text) + (dblQty * dblRate);
                    List<Inventory> objInvCls = fnbs.GetClosingQty(strFoodID.ToString()).ToList();
                    if (objInvCls.Count > 0)
                    {
                        foreach (Inventory invCls in objInvCls)
                        {
                            if (invCls.dblClosingQty > 0)
                            {
                                DG[4, selRaw].Value = invCls.dblClosingQty;
                            }
                            else
                            {
                                DG[4, selRaw].Value = 0;
                            }
                        }
                    }

                    if (i % 2 == 0)
                    {
                        DG.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                    }
                    else
                    {
                        DG.Rows[i].DefaultCellStyle.BackColor = Color.Beige;
                    }

                    intTotal = intTotal + 1;
                }
                lblNetQty.Text = dblNetQty.ToString();
                lblTotal.Text = dblNetAmount.ToString();
            }
            

        }

        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double dblNetQty = 0, dblNetTotal = 0;

            if (e.ColumnIndex == 9)
            {
                int selRowIndex = e.RowIndex;

                if (DG.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    
                    dblNetQty = Convert.ToDouble(DG.Rows[e.RowIndex].Cells[6].Value);
                    dblNetTotal= Convert.ToDouble(DG.Rows[e.RowIndex].Cells[8].Value);
                    DG.Rows.RemoveAt(selRowIndex);
                }

                lblNetQty.Text = (Convert.ToDouble (lblNetQty.Text) - dblNetQty).ToString();
                lblTotal.Text = (Convert.ToDouble(lblTotal.Text) - dblNetTotal).ToString();

            }
        }

        private void dteDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cbofoodCat.Focus();
            }

        }

        private void CalculateTotal()
        {
            double dblNetAmount = 0,dblQty=0;
            for (int i=0 ;i < DG.Rows.Count;i++)
            {
                dblQty = dblQty + Convert.ToDouble(DG.Rows[i].Cells[6].Value);
                dblNetAmount = dblNetAmount+ Convert.ToDouble(DG.Rows[i].Cells[8].Value);
            }

            lblNetQty.Text = dblQty.ToString();
            lblTotal.Text = dblNetAmount.ToString();
        }

       

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtQty.Text != "")
                {
                    btnDown.PerformClick();
                }
                else
                {
                    btnSave.Focus();
                }
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }
        private bool ValidateFields()
        {

            List<string> vf = new List<string>() { "txtFoodCategory" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            if (cbofoodCat.Text == "--Select--")
            {
                MessageBox.Show("Cannot Empty");
                cbofoodCat.Focus();
                return false;
            }

            if (DG.Rows.Count == 1 )
            {
                MessageBox.Show("Cannot Empty");
                return false;
            }
            if (Vtype == 4)
            {
                for (int i = 0; i < DG.Rows.Count-1; i++)
                {
                    if ((DG.Rows[i].Cells[4].Value) == null)
                    {
                        MessageBox.Show("Stock is Not Available of " + (DG.Rows[i].Cells[3].Value));
                        return false;

                    }
                }
            }




            return true;
        }

        private Inventory  PopulateInventory()
        {

            string strString = "";
            string strPost = "";
            Inventory objInv = new Inventory();
            objInv.MrrDate = dteDate.Text;
            objInv.intVtype = Vtype;

            if (txtRefNo.Text != "")
            {
                objInv.MrrNo = txtRefNo.Text;
            }
            else
            {
                objInv.MrrNo = "";
            }

            if (txtIssueRefNo.Text != "")
            {
                objInv.IssueRefNo = txtIssueRefNo.Text;
            }
            else
            {
                objInv.IssueRefNo = "";
            }

            if (chkPost.Checked==true)
            {
                strPost = "Y";
            }
            else
            {
                strPost = "N";
            }
            
            for (int i=0; i <DG.Rows.Count-1;i++ )
            {
                

                strString =  strString + DG.Rows[i].Cells[0].Value.ToString() + "," 
                                        + DG.Rows[i].Cells[2].Value.ToString() + "," 
                                        + Vtype +","
                                        + DG.Rows[i].Cells[6].Value.ToString() + ","
                                        + DG.Rows[i].Cells[7].Value.ToString() + "," 
                                        + DG.Rows[i].Cells[8].Value.ToString() + ","
                                        + strPost + ","
                                        + DG.Rows[i].Cells[5].Value.ToString() + ",";

                strString += ";";
            }

            objInv.strString = strString;


            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objInv.EntryParameter = ep;
            return objInv;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    Inventory objInv = this.PopulateInventory();
                    string  i = fnbs.InsertInventory(objInv);
                    if (i == "")
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        mClear();
                        mLoadMonthTree();
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
        private void mClear()
        {
            txtQty.Text = "0";
            //txtOpnQty.Text = "0";
            txtFoodCode.Text = "";
            txtFoodName.Text = "";
            cbofoodCat.SelectedIndex  = 0;

            lblNetQty.Text = "0";
            lblTotal.Text = "0";

            chkPost.Checked = false;
            mcPost = "";
            DG.Rows.Clear();
            dteDate.Focus();

        }

        private void txtOpnQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Return)
            {
                txtQty.Focus();
            }
        }

        private void tvNode_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strSelection;
            int intRow = 0;
            DG.Rows.Clear();
            lblNetQty.Text = "0";
            lblTotal.Text = "0";
            strSelection = tvNode.SelectedNode.Text;
            txtRefNo.Text = strSelection.ToString();

            if (strSelection != "")
            {
                  
                List<Inventory> objInv = fnbs.DisplayVoucher(strSelection).ToList();
                if (objInv.Count >0)
                {
                    DG.Rows.Add(objInv.Count());
                    foreach (Inventory inv in objInv)
                    {
                        cbofoodCat.SelectedValue = inv.CatID;
                        if (inv.PostStatus.Trim()=="Y")
                        {
                            chkPost.Checked = true;
                            chkPost.Enabled = false;
                            mcPost = "Y";
                        }
                        else
                        {
                            chkPost.Checked = false;
                            chkPost.Enabled = true;
                            mcPost = "N";
                        }

                        dteDate.Text = inv.MrrDate;
                        txtIssueRefNo.Text = inv.IssueRefNo.ToString();
                        DG.Rows[intRow].Cells[0].Value = inv.CatID;
                        DG.Rows[intRow].Cells[1].Value = inv.CatName;
                        DG.Rows[intRow].Cells[2].Value = inv.FoodID ;
                        DG.Rows[intRow].Cells[3].Value = inv.FoodName ;
                        //DG.Rows[intRow].Cells[4].Value = inv.dblClosingQty;
                        List<Inventory> objInvCls = fnbs.GetClosingQty(inv.FoodID).ToList();
                        if (objInvCls.Count > 0)
                        {
                            foreach (Inventory invCls in objInvCls)
                             {
                                 DG.Rows[intRow].Cells[4].Value = invCls.dblClosingQty;
                             }
                        }

                        DG.Rows[intRow].Cells[5].Value = 0;
                        DG.Rows[intRow].Cells[6].Value = inv.dblTranqty;
                        DG.Rows[intRow].Cells[7].Value = inv.dblTranRate;
                        DG.Rows[intRow].Cells[8].Value = inv.dblNetAmount ;

                        if (intRow % 2 == 0)
                        {
                            DG.Rows[intRow].DefaultCellStyle.BackColor = Color.Aqua;
                        }
                        else
                        {
                            DG.Rows[intRow].DefaultCellStyle.BackColor = Color.Beige;
                        }

                        intRow = intRow + 1;
                    }
                    CalculateTotal();
                    btnSave.Enabled = false;
                    btnEdit.Enabled = true;     
                }

            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
           
            if ( mcPost == "Y")
            {
                MessageBox.Show("Already Posted , Cannot Edit");
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    Inventory objInv = this.PopulateInventory();
                    string i = fnbs.UpdateInventory(objInv);
                    if (i == "")
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        mClear();
                        btnSave.Enabled = true;
                        btnEdit.Enabled = false;
                        mLoadMonthTree();
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            DG.Rows.Clear();
            lblNetQty.Text = "0";
            lblTotal.Text = "0";
            mcPost = "";
            btnEdit.Enabled = false;
            btnSave.Enabled = true;

        }

        private void txtIssueRefNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Return)
            {
                txtFoodName.Focus();
            }

        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {

            //int i = 0;
            //if (this.DG.SelectedRows.Count == 0)
            //    return;
            //i = Convert.ToInt16(this.DG.SelectedRows.Count);

            //txtFoodCode.Text = DG.Rows[i].Cells[1].Value.ToString();
            //txtFoodName.Text = DG.Rows[i].Cells[2].Value.ToString();
            //txt.Text = DG.Rows[i].Cells[2].Value.ToString();


            //foreach (DataGridViewCell cell in this.DG.SelectedRows[0].Cells)
            //{
            //    string value = cell.Value == null ? string.Empty : cell.Value.ToString();
            //    txtFoodCode.Text = value;
            //    txtFoodName.Text = cell.Value == null ? string.Empty : cell.Value.ToString();
            //}


        }

        private void cbofoodCat_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int j = 0;
            if (cbofoodCat.Text.ToString() != "--Select--" && cbofoodCat.Text.ToString() != "")
            {
                mEnabled(true);
                objFood = fnbs.GetFoodItem(cbofoodCat.SelectedValue.ToString()).ToList();
                {
                    foreach (FoodItemRO objFm in objFood)
                    {
                        DGLedger.Rows.Add(1);
                        DGLedger.Rows[j].Cells[0].Value = objFm.FoodID;
                        DGLedger.Rows[j].Cells[1].Value = objFm.FoodName;
                        j = j + 1;

                    }
                
                }

            }
            else
            {
                mEnabled(false);
            }

        }

        private void cbofoodCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtIssueRefNo.Visible)
                {
                    txtIssueRefNo.Focus();
                }
                else
                {
                    txtFoodName.Focus();
                }

            }
        }


       
        
    




    
    
    }
}
