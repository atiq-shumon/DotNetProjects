using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.ATMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.ATMS.Forms
{
    public partial class frmWarehouseIssue : AH.Shared.UI.frmSmartFormStandard
    {
        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();
        public int ioFlag = 0;
        public string ModuleName;
        public string Active;
        public frmWarehouseIssue()
        {
            InitializeComponent();
        }
        private void FormatList()
        {
            lvwIssue.Columns.Add("Io ID", 200, HorizontalAlignment.Left);
            lvwIssue.Columns.Add("ID Date", 120, HorizontalAlignment.Left);
        }
        private void Format_Grid()
        {
            DG.Columns.Add(Create_Grid_Column("ItemCode", "Item Code", 0, false, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Item Name", "Item Name", 360, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Unit", "Unit", 0, false, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Unit Name", "Unit Name", 120, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Closing Qty.", "Closing Qty.", 0, false, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Issue Qty.", " Issue Qty.", 130,true, DataGridViewContentAlignment.TopLeft,false));
            DG.Columns.Add(Create_Grid_Column("Status", "Status", 135, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column_button("Del", "Del", "Del", 40, true, DataGridViewContentAlignment.TopCenter, true));
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

        private void LoadListView()
        {
            lvwIssue.Items.Clear();
            List<IOmaster> Io = atms.GetWarehouseIssueItem(ModuleName, ioFlag.ToString()).ToList();
            if (Io.Count > 0)
            {
                foreach (IOmaster objIo in Io)
                {
                    ListViewItem itm = new ListViewItem(objIo.IoRefNo);
                    itm.SubItems.Add(objIo.Iodate.ToString());
                    lvwIssue.Items.Add(itm);
                }
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
        private void frmWarehouseIssue_Load(object sender, EventArgs e)
        {

            cboWarehouseType.Select();
            cboWarehouseType.ValueMember = "Key";
            cboWarehouseType.DisplayMember = "Value";
            cboWarehouseType.DataSource = new BindingSource(atms.GetHkwarehouseType(ModuleName), null);
            Format_Grid();
            FormatList();
            LoadListView();
        }
        private void GetWarehouseType(string Warehousetype)
        {
            //cboWarehouse.ValueMember = "TypeID";
            //cboWarehouse.DisplayMember = "TypeName";
            //cboWarehouse.DataSource = atms.GeHktwarehouse(Warehousetype).ToList();

            cboWarehouse.ValueMember = "TypeID";
            cboWarehouse.DisplayMember = "TypeName";
            cboWarehouse.DataSource = new BindingSource(atms.GeHktwarehouse(Warehousetype), null);
        }
        private void cboWarehouseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strWarehousetype = "";
            if (cboWarehouseType.Text != "--Select--")
            {
                cboWarehouse.Text = "";
                strWarehousetype = cboWarehouseType.SelectedValue.ToString();
                GetWarehouseType(strWarehousetype);
            }
        }

        private void DisplayHkItem(string strWarehousecode,int intStatus)
        {
            int i;
          
            List<IOmaster> objIo = atms.GetHkDirtyItem(strWarehousecode, intStatus).ToList();
            if(objIo.Count > 0)
            {
                i = objIo.Count;
                DG.Rows.Add(i);
                i = 0;
                foreach(IOmaster io in objIo)
                {
                    txtgrpID.Text = io.Grpid;
                    txtStoreid.Text = io.Storeid;
                    txtModuleID.Text = io.IntMtype.ToString();
                    if (io.Qty > 0)
                    {
                        DG.Rows[i].Cells[0].Value = io.ItemCode;
                        DG.Rows[i].Cells[1].Value = io.ItemName;
                        DG.Rows[i].Cells[2].Value = io.UnitCode;
                        DG.Rows[i].Cells[3].Value = io.UnitName;
                        DG.Rows[i].Cells[4].Value = io.Qty;
                        DG.Rows[i].Cells[5].Value = io.Qty;
                        DG.Rows[i].Cells[6].Value = "Dirty";
                        if (i % 2 == 0)
                        {
                            DG.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                        }
                        else
                        {
                            DG.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        }
                        i = i + 1;
                    }
                
                }
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            string strWarehousetype = "";
            DG.Rows.Clear();
            if (cboWarehouse.Text  != "")
            {
                //cboWarehouse.Text = "";
                //strWarehousetype = cboWarehouseType.SelectedValue.ToString();
                strWarehousetype = cboWarehouse.SelectedValue.ToString();
                DisplayHkItem(strWarehousetype, 1); //1 Dirty
            }
        }

        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int selRowIndex = e.RowIndex;

                if (DG.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    DG.Rows.RemoveAt(selRowIndex);
                }
            }
        }
        private IOmaster PopulateIOmaster()
        {
            IOmaster objIO = new IOmaster();
            if (txtRefNo.Text != "")
            {
                objIO.IoRefNo = txtRefNo.Text;
            }
            objIO.Grpid = txtgrpID.Text;
            objIO.Storeid = txtStoreid.Text;
            objIO.Iodate = dtevDate.Text;
            objIO.WhType = cboWarehouseType.SelectedValue.ToString();
            objIO.Whid = cboWarehouse.SelectedValue.ToString();
            objIO.Ioflag = ioFlag.ToString();
            objIO.Active = ModuleName;
            objIO.Moduletype = txtModuleID.Text;
            objIO.Remarks = txtRemarks.Text;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objIO.EntryParameter = ep;
            return objIO;
        }
        private bool validationfields()
        {
            if (cboWarehouse.Text.ToString() == "--Select--")
            {
                cboWarehouse.Focus();
                return true;
            }
            if (cboWarehouseType.Text.ToString() == "--Select--")
            {
                cboWarehouseType.Focus();
                return true;
            }
            return false;
        }

        private bool mCheckIssuQty()
        {
            long lngIssuQty=0,BalanceQty=0;
            for (int i=0;i<DG.Rows.Count-1;i++)
            {
                BalanceQty = Convert.ToInt64(DG.Rows[i].Cells[4].Value);
                lngIssuQty =Convert.ToInt64( DG.Rows[i].Cells[5].Value);
                if (lngIssuQty > BalanceQty)
                {
                   
                    return true;
                }
            }

            return false;
        }


        private void mClear()
        {
            txtgrpID.Text = "";
            txtModuleID.Text = "";
            txtStoreid.Text = "";
            cboWarehouse.Text = "";
            txtRemarks.Text = "";
            cboWarehouseType.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            short i = 0;
            if (validationfields() == true)
            {
                MessageBox.Show("Empty field");
                return;
            }
            if (mCheckIssuQty() == true)
            {
                MessageBox.Show("Issue Qty Cannot be Greater than your Balance Qty");
                return;
            }

            else
            {
                try
                {
                    var strResponse = MessageBox.Show("Do You want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (strResponse == DialogResult.Yes)
                    {
                        IOmaster objio = this.PopulateIOmaster();
                        string strRefNo = atms.SaveIomaster(objio);
                        if (strRefNo != "")
                        {
                            double dblQty = 0;
                            int intFlag = 0;
                            string strItemCode = "";
                            for (int k = 0; k < DG.Rows.Count - 1; k++)
                            {
                                if (DG.Rows[k].Cells[0].Value != "")
                                {
                                    strItemCode = DG.Rows[k].Cells[0].Value.ToString();
                                }
                                else
                                {
                                    strItemCode = "";
                                }
                                if (DG.Rows[k].Cells[5].Value != "")
                                {
                                    dblQty = Convert.ToDouble(DG.Rows[k].Cells[5].Value) * -1;
                                }
                                else
                                {
                                    dblQty = 0;
                                }
                                if (DG.Rows[k].Cells[6].Value.ToString() == "Dirty")
                                {
                                    intFlag = 1;
                                }
                                else
                                {
                                    intFlag = 0;
                                }

                                i = atms.SaveIoDetails(strRefNo.ToString(), strItemCode.ToString(), dblQty, intFlag, "", "M", objio);

                            }
                            if (i == 0)
                            {
                                MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (i > 0)
                            {
                                btnNew.PerformClick();
                                DG.Rows.Clear();
                                mClear();
                            }

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
        }

        private void cboWarehouseType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Return)
            {
                cboWarehouse.Focus();
            }
        }

        private void cboWarehouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                dtevDate.Focus();
            }
        }

        private void dtevDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                DG.Focus();
            }
        }

        private void DG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtRemarks.Focus();
            }
        }
        private void GetWarehouseItem(string strRefNo)
        {
            int i = 0, k = 0;

            DG.Rows.Clear();

            List<IOmaster> Io = atms.DisplayIssueInformation(ModuleName, strRefNo).ToList();
            if (Io.Count > 0)
            {
                i = Io.Count;
                DG.Rows.Add(i);
                foreach (IOmaster objIo in Io)
                {
                    txtRefNo.Text = objIo.IoRefNo;
                    txtModuleID.Text = objIo.IntMtype.ToString();
                    txtgrpID.Text = objIo.Grpid;
                    txtStoreid.Text = objIo.Storeid;
                    cboWarehouseType.SelectedValue = objIo.WhType;
                    cboWarehouse.SelectedValue = objIo.Whid;
                    txtRemarks.Text = objIo.Remarks; 
                    DG.Rows[k].Cells[0].Value = objIo.ItemCode.ToString();
                    DG.Rows[k].Cells[1].Value = objIo.ItemName.ToString();
                    DG.Rows[k].Cells[2].Value = objIo.UnitCode;
                    DG.Rows[k].Cells[3].Value = objIo.UnitName;
                    DG.Rows[k].Cells[5].Value = Math.Abs(objIo.Qty);
                    //if (objIo.Ioflag == "0")
                    //{
                        DG.Rows[k].Cells[6].Value = "Dirty";
                    //}
                    //else
                    //{
                    //    DG.Rows[k].Cells[3].Value = "Clean";
                    //}
                    k = k + 1;
                }
            }
        }
        private void lvwIssue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwIssue.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwIssue.SelectedItems[0];
                GetWarehouseItem(itm.SubItems[0].Text);
                //cboModuleName.Enabled = false;
                //cboNsStnId.Enabled = false;
                cboWarehouse.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            short i = 0;
            if (validationfields() == true)
            {
                MessageBox.Show("Empty field");
                return;
            }
            //if (mCheckIssuQty() == true)
            //{
            //    MessageBox.Show("Issue Qty Cannot be Greater than your Balance Qty");
            //    return;
            //}

            else
            {
                var strResponse = MessageBox.Show("Do You want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    IOmaster objio = this.PopulateIOmaster();
                    int t = atms.UpdateIomaster(objio);
                    if (t   == 1)
                    {
                        double dblQty = 0;
                        int intFlag = 0;
                        string strItemCode = "";
                        for (int k = 0; k < DG.Rows.Count - 1; k++)
                        {
                            if (DG.Rows[k].Cells[0].Value != "")
                            {
                                strItemCode = DG.Rows[k].Cells[0].Value.ToString();
                            }
                            else
                            {
                                strItemCode = "";
                            }
                            if (DG.Rows[k].Cells[5].Value != "")
                            {
                                dblQty = Convert.ToDouble(DG.Rows[k].Cells[5].Value) * -1;
                            }
                            else
                            {
                                dblQty = 0;
                            }
                            if (DG.Rows[k].Cells[6].Value.ToString() == "Dirty")
                            {
                                intFlag = 1;
                            }
                            else
                            {
                                intFlag = 0;
                            }

                            i = atms.UpdateIoDetails(txtRefNo.Text.ToString(), strItemCode.ToString(), dblQty, intFlag, "", "M", objio);

                        }
                        if (i == 0)
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i > 0)
                        {
                            btnNew.PerformClick();
                            DG.Rows.Clear();
                            mClear();
                        }

                    }

                }
            }
        }

      

    }
}
