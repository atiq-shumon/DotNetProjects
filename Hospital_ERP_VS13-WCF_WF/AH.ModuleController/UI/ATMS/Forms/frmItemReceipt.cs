using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.ModuleController.ATMSSR;
using AH.DUtility;


namespace AH.ModuleController.UI.ATMS.Forms
{
    public partial class frmItemReceipt : AH.Shared.UI.frmSmartFormStandard
    {
        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();
        public int ioFlag;
        public string ModuleName;

        public frmItemReceipt()
        {
            InitializeComponent();
        }

        #region "Grid"
        private void Format_Grid()
        {
            DG.Columns.Add(Create_Grid_Column("Item Code", "Item Code", 0, false, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Item Name", "Item Name", 500, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Qty.", "Qty.", 130, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Status", "Status", 135, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column_button("Del", "Del", "Del", 70, true, DataGridViewContentAlignment.TopCenter, true));
        }
        private void FormatList()
        {
            lvwWarehouse.Columns.Add("Io ID", 200, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("ID Date", 120, HorizontalAlignment.Left);
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
        private void frmItemReceipt_Load(object sender, EventArgs e)
        {
            cboGroupName.Select();
            try
            {
                Format_Grid();
                FormatList();
                LoadListView();
                cboGroupName.ValueMember = "GroupID";
                cboGroupName.DisplayMember = "GroupName";
                cboGroupName.DataSource = new BindingSource(atms.GetStockWHGroup(), null);

                cbostoretype.ValueMember = "strTypeID";
                cbostoretype.DisplayMember = "TypeTitle";
                cbostoretype.DataSource = new BindingSource(atms.GetStoreWhstoretype(), null);

                cboWarehouseType.ValueMember = "Key";
                cboWarehouseType.DisplayMember = "Value";
                cboWarehouseType.DataSource = new BindingSource(atms.GetHkwarehouseType(ModuleName), null);

                cboModuleName.Items.Clear();
                cboModuleName.Items.Add("--Select--");
                cboModuleName.Text = "--Select--";
                cboModuleName.ValueMember = "1";
                cboModuleName.Items.Add("Inventory Management");
                cboModuleName.ValueMember = "2";
                cboModuleName.Items.Add("Nursing Station");
                if (ModuleName == "H")
                {
                    cboModuleName.ValueMember = "3";
                    cboModuleName.Items.Add("CSSD");
                }

                if (ModuleName == "H")
                {
                    frmLabel.Text = "Product Receipt from House Keeping";
                }
                else
                {
                    frmLabel.Text = "Product Receipt from CSSD";
                }

                cboNsStnId.ValueMember = "Key";
                cboNsStnId.DisplayMember = "Value";
                cboNsStnId.DataSource = new BindingSource(atms.GetNurseStationDic("D"), null);

                //cboLocation.ValueMember = "storeId";
                //cboLocation.DisplayMember = "storeTitle";
                //cboLocation.DataSource = new BindingSource(atms.GetStockWHLocation(), null);
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
        #region "Load Listview"
        private void LoadListView()
        {
            lvwWarehouse.Items.Clear();
            List<IOmaster> Io = atms.GetWarehouseItem(ModuleName).ToList();
            if (Io.Count > 0)
            {
                foreach (IOmaster objIo in Io)
                {
                    ListViewItem itm = new ListViewItem(objIo.IoRefNo);
                    itm.SubItems.Add(objIo.Iodate.ToString());
                    lvwWarehouse.Items.Add(itm);
                }
            }
        }
        #endregion
        #region "LiadItem"
        private void GetWarehouseItem(string strRefNo)
        {
            int i = 0,k=0;
            
            DG.Rows.Clear();

            List<IOmaster> Io = atms.DisplayReceiptInformation(ModuleName,strRefNo).ToList();
            if (Io.Count > 0)
            {
                i = Io.Count;
                DG.Rows.Add(i);
                foreach (IOmaster objIo in Io)
                {
                    txtRefNo.Text =objIo.IoRefNo;
                    cboGroupName.SelectedValue = objIo.Grpid;
                    cbostoretype.SelectedValue = objIo.Storeid;
                    cboWarehouse.SelectedValue = objIo.Whid;
                    cboWarehouseType.SelectedValue = objIo.WhType;
                    if (objIo.IntMtype == 1)
                    {
                        cboModuleName.Text = "Inventory Management";
                    }
                    else if (objIo.IntMtype == 2)
                    {
                        cboModuleName.Text = "Nursing Station";
                    }
                    else
                    {
                        cboModuleName.Text = "CSSD";
                    }

                    if (cboModuleName.Text == "Nursing Station")
                    {
                        cboNsStnId.SelectedValue = objIo.NursingStationId;
                    }
                    else
                    {
                        cboNsStnId.Text = "";
                    }

                    DG.Rows[k].Cells[0].Value = objIo.ItemCode.ToString();
                    DG.Rows[k].Cells[1].Value = objIo.ItemName.ToString();
                    DG.Rows[k].Cells[2].Value = objIo.Qty.ToString();
                    if (objIo.Ioflag == "0")
                    {
                        DG.Rows[k].Cells[3].Value = "Dirty";
                    }
                    else
                    {
                        DG.Rows[k].Cells[3].Value = "Clean";
                    }
                    k = k + 1;
                }
            }
        }
        #endregion
        #region "Grid"
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

        #endregion
        #region "Item Information"
        private void GetItemInformation()
        {
            string strGroup = "", strType = "", strLocation = "";
            if (cboGroupName.SelectedValue != null)
            {
                strGroup = cboGroupName.SelectedValue.ToString();
            }
            else
            {
                strGroup = "";
            }
            if (cbostoretype.SelectedValue != null)
            {
                strType = cbostoretype.SelectedValue.ToString();
            }
            else
            {
                strType = "";
            }
            //strLocation = cboLocation.SelectedValue.ToString();
            if (strGroup != " " && strType != " ")
            {
                cboItemName.ValueMember = "ItemCode";
                cboItemName.DisplayMember = "itemname";
                cboItemName.DataSource = new BindingSource(atms.GethkItem(strGroup, strType, strLocation), null);
            }
        }
        #endregion 
        #region "Changed"
        private void cboWarehouseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strWarehousetype="";
            if (cboWarehouseType.Text != "--Select--")
            {
                cboWarehouse.Text = "";
                strWarehousetype = cboWarehouseType.SelectedValue.ToString();
                GetWarehouseType (strWarehousetype);
            }
        }
        private void GetWarehouseType(string Warehousetype)
        {
            cboWarehouse.ValueMember = "TypeID";
            cboWarehouse.DisplayMember = "TypeName";
            cboWarehouse.DataSource = new BindingSource(atms.GeHktwarehouse(Warehousetype), null);
        }
        private void cboGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGroupName.SelectedValue != " " && cbostoretype.SelectedValue != null)
                GetItemInformation();
        }
        private void cbostoretype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGroupName.SelectedValue != " " && cbostoretype.SelectedValue != "" )
                GetItemInformation();
        }
        private void cboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGroupName.SelectedValue != " " && cbostoretype.SelectedValue != "" )
                GetItemInformation();
        }
        #endregion
        #region "Click"
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (cboModuleName.Text =="")
            {
                MessageBox.Show("Module Name Cannot be Empty");
                cboModuleName.Focus();
                return;
            }

            if (cboItemName.Text != "" && cboItemName.Text != "--Select--")
            {
                int i = Convert.ToInt16(DG.Rows.Count) - 1;
                DG.Rows.Add(1);
                DG.Rows[i].Cells[0].Value = cboItemName.SelectedValue.ToString();
                DG.Rows[i].Cells[1].Value = cboItemName.Text.ToString();
                DG.Rows[i].Cells[2].Value = txtQty.Text;
                if (chkClean.Checked == true)
                {
                    DG.Rows[i].Cells[3].Value = "Dirty";
                    DG.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                    DG.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
                else
                {
                    DG.Rows[i].Cells[3].Value = "Clean";
                    DG.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                }
                cboItemName.Text = "";
                txtQty.Text = "";
                cboItemName.Focus();
            }

        }
        #endregion
        #region "Changed"
        private void cboModuleName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModuleName.Text == "Inventory Management")
            {
                chkClean.Checked = false;
                cboNsStnId.Enabled = false;
            }
            else if (cboModuleName.Text == "CSSD")
            {
                chkClean.Checked = false;
                cboNsStnId.Enabled = false;
            }
            else if (cboModuleName.Text == "Nursing Station")
            {
                chkClean.Checked = true;
                cboNsStnId.Enabled = true;
            }
        }
        #endregion
        #region "Click"
        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int selRowIndex = e.RowIndex;

                if (DG.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    DG.Rows.RemoveAt(selRowIndex);
                }
            }
        }
        #endregion
        #region "Populated"
        private IOmaster PopulateIOmaster()
        {
            IOmaster objIO = new IOmaster();
            if (txtRefNo.Text != "")
            {
                objIO.IoRefNo = txtRefNo.Text;
            }
            else
            {
                objIO.IoRefNo="";
            }
            objIO.Grpid = cboGroupName.SelectedValue.ToString();
            objIO.Storeid = cbostoretype.SelectedValue.ToString();
            objIO.Iodate = dtevDate.Text;
            objIO.WhType = cboWarehouseType.SelectedValue.ToString();
            objIO.Whid  = cboWarehouse.SelectedValue.ToString();
            objIO.Ioflag = ioFlag.ToString();
            objIO.Active = ModuleName;

            if (cboModuleName.Text == "Inventory Management")
            {
                objIO.Moduletype = "1";
            }
            else if (cboModuleName.Text == "Nursing Station")
            {
                objIO.Moduletype = "2";
            }
            else
            {
                objIO.Moduletype = "3";
            }


            if (objIO.Moduletype =="2")
            {
                objIO.NursingStationId = cboNsStnId.SelectedValue.ToString();
            }
            else
            {
                objIO.NursingStationId = "";
            }



            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objIO.EntryParameter = ep;
            return objIO;
        }
        #endregion 
        #region "ValidationFields"
        private bool validationfields()
        {
            if (cboModuleName.Text.ToString() == "--Select--")
            {
                cboModuleName.Focus();
                return true;
            }
            if (cboGroupName.Text.ToString() == "--Select--")
            {
                cboGroupName.Focus();
                return true;
            }

            if (cbostoretype.Text.ToString() == "--Select--")
            {
                cbostoretype.Focus();
                return true;
            }

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
        #endregion
        #region  "Keypress"
        private void cboGroupName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Return)
            {
                dtevDate.Focus();
            }
        }
        private void dtevDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cbostoretype.Focus();
            }
        }
        private void cbostoretype_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (cboModuleName.Enabled)
                {
                    cboModuleName.Focus();
                }
                else
                {
                    cboWarehouseType.Focus();
                }
            }
        }
        private void cboModuleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (cboNsStnId.Enabled)
                {
                    cboNsStnId.Focus();
                }
                else
                {
                    cboWarehouseType.Focus();
                }
            }
        }
        private void cboWarehouseType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboWarehouse.Focus();
            }
        }
        private void cboWarehouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboItemName.Focus();
            }
        }
        private void cboItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (cboItemName.Text != "")
                {
                    txtQty.Focus();
                }
                else
                {
                    txtRemarks.Focus();
                }
            }
        }
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnDown.Focus();
            }
        }
        private void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (btnSave.Enabled)
                {
                    btnSave.Focus();
                }
                else
                {
                    btnEdit.Focus(); 
                }
            }
        }
        private void cboNsStnId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboWarehouseType.Focus();
            }
        }
        #endregion
        #region "Click"
        private void btnSave_Click(object sender, EventArgs e)
        {
         
            short i=0;
            if (validationfields() == true)
            {
                MessageBox.Show("Empty field");
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
                            string strItemCode = "", istatus;
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
                                if (DG.Rows[k].Cells[2].Value != "")
                                {
                                    dblQty = Convert.ToDouble(DG.Rows[k].Cells[2].Value);
                                }
                                else
                                {
                                    dblQty = 0;
                                }
                                if (DG.Rows[k].Cells[3].Value.ToString() == "Dirty")
                                {
                                    intFlag = 1;
                                    istatus = "D";
                                }
                                else
                                {
                                    intFlag = 0;
                                    istatus = "C";
                                }

                                i = atms.SaveIoDetails(strRefNo.ToString(), strItemCode.ToString(), dblQty, intFlag, "", istatus, objio);

                            }
                            if (i == 0)
                            {
                                MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (i > 0)
                            {
                                btnNew.PerformClick();
                                DG.Rows.Clear();
                                cboNsStnId.Enabled = false;
                                LoadListView();
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
        private void lvwWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwWarehouse.SelectedItems.Count > 0)
                {
                    btnSave.Enabled = false;
                    btnEdit.Enabled = true;
                    ListViewItem itm = lvwWarehouse.SelectedItems[0];
                    GetWarehouseItem(itm.SubItems[0].Text);
                    cboModuleName.Enabled = false;
                    cboNsStnId.Enabled = false;
                    cboGroupName.Focus();
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
            cboModuleName.Enabled = true;
            cboNsStnId.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            cboNsStnId.Text = "";
            DG.Rows.Clear();
            cboGroupName.Focus();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
             short i=0;
             try
             {
                 if (validationfields() == true)
                 {
                     MessageBox.Show("Empty field");
                 }
                 else
                 {
                     var strResponse = MessageBox.Show("Do You want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                     if (strResponse == DialogResult.Yes)
                     {
                         IOmaster objio = this.PopulateIOmaster();
                         int t = atms.UpdateIomaster(objio);
                         if (t == 1)
                         {
                             double dblQty = 0;
                             int intFlag = 0;
                             string strItemCode = "", istatus;
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
                                 if (DG.Rows[k].Cells[2].Value != "")
                                 {
                                     dblQty = Convert.ToDouble(DG.Rows[k].Cells[2].Value);
                                 }
                                 else
                                 {
                                     dblQty = 0;
                                 }
                                 if (DG.Rows[k].Cells[3].Value.ToString() == "Dirty")
                                 {
                                     intFlag = 1;
                                     istatus = "D";
                                 }
                                 else
                                 {
                                     intFlag = 0;
                                     istatus = "C";
                                 }

                                 i = atms.UpdateIoDetails(txtRefNo.Text.ToString(), strItemCode.ToString(), dblQty, intFlag, "", istatus, objio);
                             }
                             if (i == 0)
                             {
                                 MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                             }
                             else if (i > 0)
                             {
                                 btnNew.PerformClick();
                                 DG.Rows.Clear();
                                 cboNsStnId.Enabled = true;
                                 LoadListView();
                             }

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




        #endregion

    }
}
