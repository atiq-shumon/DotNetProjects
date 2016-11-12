using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.DUtility;
using AH.ModuleController.INVMSSR;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmWarehouseConfig : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        public frmWarehouseConfig()
        {
            InitializeComponent();
        }
        private WarehouseConfig Populatewarehouse()
        {
            WarehouseConfig objWh = new WarehouseConfig();
            if (txtWarehouseID.Text != "")
            {
                objWh.Whid = txtWarehouseID.Text;
            }
            else
            {
                objWh.Whid = "";
            }
            objWh.BuildID  = cboBuildID.SelectedValue.ToString();
            objWh.FloorNo = cboFloorNo.SelectedValue.ToString();
            //objWh.BlockNo = txtWarehouseName.Text;
            objWh.DepID  = cboDeptID.SelectedValue.ToString();
            //objWh.UnitID = txtWarehouseName.Text;
            objWh.Typeid = cboTypeName.SelectedValue.ToString();
            objWh.WhName = txtWarehouseName.Text;
            objWh.Typeid = cboTypeName.SelectedValue.ToString();
            objWh.NurseStationID = cboNsStnId.SelectedValue.ToString();
            objWh.Contactperson = txtCantactPerson.Text.ToString();
            objWh.phoneNo = txtPhoneNo.Text;
            objWh.Remarks = txtRemarks.Text;
            
            //objWh.Active = Convert.ToChar(cboStatus.Text.Substring(0, 1));
            objWh.IsPharmacyTransferAllowed = chkPhrTransfer.Checked ? "1" : "0";
            objWh.IsSCMTransferAllowed = ChkSCMTransfer.Checked ? "1" : "0";

            if (cboStatus.Text == "Active")
            {
                objWh.Active = '1';
            }
            else
            {
                objWh.Active = '0';
            }


            objWh.CostCategoryID = cbocostcategoryName.SelectedValue.ToString();
            objWh.CostCenterID = cbocostCenterID.SelectedValue.ToString();
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objWh.EntryParameter = ep;
            return objWh;
        }
        private bool validationfields()
        {
            if (txtWarehouseName.Text.ToString() == "")
            {
                MessageBox.Show("Name cannot be Empty");
                txtWarehouseName.Focus();
                return true;
            }
            if (cboStatus.Text.ToString() == "")
            {
                MessageBox.Show("Status cannot be Empty");
                cboStatus.Focus();
                return true;
            }
            if (cboTypeName.Text.ToString() == "Select")
            {
                MessageBox.Show("Type Name cannot be Empty");
                cboTypeName.Focus();
                return true;
            }
            return false;
        }
        private void FormatGrid()
        {
            lvwWarehouse.CheckBoxes = false;
            lvwWarehouse.Columns.Add("Build id", 0, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Floor No", 0, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Block No", 0, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Dep. id", 0, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Unit id", 0, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Nurse id", 0, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Category id", 0, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Cost Center id", 0, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Type id", 0, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Warehouse id", 200, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Warehouse Name", 300, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Status", 0, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Contact Person", 200, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Phone No", 200, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("PharmacyTransferAllow", 0, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("SCMTransferAllow", 0, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvwWarehouse.Items.Clear();
            List<WarehouseConfig> objwh = invSr.GetWarehouse().ToList();
            if (objwh.Count > 0)
            {
                foreach (WarehouseConfig wh in objwh)
                {
                    ListViewItem itm = new ListViewItem(wh.BuildID);
                    //itm.SubItems.Add(wh.BuildID);
                    itm.SubItems.Add(wh.FloorNo);
                    itm.SubItems.Add(wh.BlockNo);
                    itm.SubItems.Add(wh.DepID);
                    itm.SubItems.Add(wh.UnitID);
                    itm.SubItems.Add(wh.NurseStationID);
                    itm.SubItems.Add(wh.CostCategoryID);
                    itm.SubItems.Add(wh.CostCenterID);
                    itm.SubItems.Add(wh.Typeid);
                    itm.SubItems.Add(wh.Whid);
                    itm.SubItems.Add(wh.WhName);
                    itm.SubItems.Add(wh.Remarks.ToString());
                    itm.SubItems.Add(wh.Active.ToString());
                    itm.SubItems.Add(wh.Contactperson.ToString());
                    itm.SubItems.Add(wh.phoneNo.ToString());
                    itm.SubItems.Add(wh.IsPharmacyTransferAllowed);
                    itm.SubItems.Add(wh.IsSCMTransferAllowed);
                    lvwWarehouse.Items.Add(itm);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationfields() != false)
            {
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    WarehouseConfig objWh = this.Populatewarehouse();
                    short i = invSr.Savewarehouse(objWh);
                    if (i == 1)
                    {
                        LoadListView();
                        txtWarehouseID.Text = "";
                        txtWarehouseName.Text = "";
                        txtRemarks.Text = "";
                        txtWarehouseName.Focus();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (validationfields() != false)
            {
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    WarehouseConfig objWh = this.Populatewarehouse();
                    short i = invSr.Updatewarehouse(objWh);
                    if (i == 1)
                    {
                        LoadListView();
                        txtWarehouseID.Text = "";
                        txtWarehouseName.Text = "";
                        txtRemarks.Text = "";
                        txtWarehouseName.Focus();
                        btnSave.Enabled = true;
                        btnEdit.Enabled = false;
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
       private void frmWarehouseConfig_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadListView();
            cboTypeName.ValueMember = "Typeid";
            cboTypeName.DisplayMember = "TypeName";
            cboTypeName.DataSource = invSr.LoadWarehouse().ToList();

            cboNsStnId.ValueMember = "Key";
            cboNsStnId.DisplayMember = "Value";
            cboNsStnId.DataSource = new BindingSource(invSr.GetNurseStationDic("D"), null);

            cbocostcategoryName.ValueMember = "Key";
            cbocostcategoryName.DisplayMember = "Value";
            cbocostcategoryName.DataSource = new BindingSource(invSr.LoadCategory(), null);

            cboBuildID.DisplayMember = "Value";
            cboBuildID.ValueMember = "Key";
            cboBuildID.DataSource = new BindingSource(invSr.GetBuildingDict("D"), null);

            cboDeptID.DisplayMember = "Value";
            cboDeptID.ValueMember = "Key";
            cboDeptID.DataSource = new BindingSource(invSr.GetDepartments("E"), null);

            List<short> ListValues = invSr.GetNumbers(0, 21).ToList();
            cboFloorNo.DataSource = ListValues;

        }
       private void cboTypeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtWarehouseName.Focus();
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
        private void cboStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtRemarks.Focus();
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

        private void lvwWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwWarehouse.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
                ListViewItem itm = lvwWarehouse.SelectedItems[0];
                cboBuildID.SelectedValue = itm.SubItems[0].Text;
                cboFloorNo.Text = itm.SubItems[1].Text;
                //cbob.SelectedValue = itm.SubItems[2].Text;
                cboDeptID.SelectedValue = itm.SubItems[3].Text;
                //cbounit.SelectedValue = itm.SubItems[4].Text;
                cboNsStnId.SelectedValue = itm.SubItems[5].Text;
                cbocostcategoryName.SelectedValue = itm.SubItems[6].Text;
                cbocostCenterID.SelectedValue = itm.SubItems[7].Text;
                cboTypeName.SelectedValue = itm.SubItems[8].Text;
                txtWarehouseID.Text = itm.SubItems[9].Text;
                txtWarehouseName.Text = itm.SubItems[10].Text;
                txtRemarks.Text = itm.SubItems[11].Text;
                if (itm.SubItems[12].Text == "1")
                {
                    cboStatus.Text = "Active";
                }
                else
                {
                    cboStatus.Text = "Inactive";
                }
                txtCantactPerson.Text = itm.SubItems[13].Text;
                txtPhoneNo.Text = itm.SubItems[14].Text;                
                chkPhrTransfer.Checked = itm.SubItems[15].Text == "1" ? true : false;
                ChkSCMTransfer.Checked = itm.SubItems[16].Text == "1" ? true : false;
                txtWarehouseName.Focus();
            }
        }

        private void cbocostcategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strCatName;
            if (cbocostcategoryName.SelectedValue != "")
            {
                strCatName = cbocostcategoryName.SelectedValue.ToString();
                cbocostCenterID.ValueMember = "CostCenterID";
                cbocostCenterID.DisplayMember = "CostcenterName";
                cbocostCenterID.DataSource = invSr.GetCostcenterTreeview("CostcenterTreeview", strCatName, "").ToList();
            }
        }

        private void cboBuildID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboFloorNo.Focus();
            }

        }

        private void cboFloorNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboDeptID.Focus();
            }
        }

        private void cboDeptID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboTypeName.Focus();
            }
        }

        private void cboNsStnId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cbocostcategoryName.Focus();
            }
        }

        private void cbocostcategoryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cbocostCenterID.Focus();
            }
        }

        private void cbocostCenterID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtPhoneNo.Focus();
            }
        }

        private void txtWarehouseName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboNsStnId.Focus();
            }
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtCantactPerson.Focus();
            }
        }

        private void txtCantactPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboStatus.Focus();
            }
        }

       
    }
}
