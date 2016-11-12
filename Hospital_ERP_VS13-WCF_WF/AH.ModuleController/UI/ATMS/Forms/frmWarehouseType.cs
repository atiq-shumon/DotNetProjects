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
    public partial class frmWarehouseType : AH.Shared.UI.frmSmartFormStandard
    {
        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();
        public frmWarehouseType()
        {
            InitializeComponent();
        }

        private Warehouse Populatewarehouse()
        {
            Warehouse objWh = new Warehouse();
            if (txtTypeID.Text != "")
            {
                objWh.TypeID = txtTypeID.Text;
            }
            else
            {
                objWh.TypeID = "";
            }
            objWh.TypeName  = txtTypeName.Text;
            objWh.Remarks = txtRemarks.Text;
            //objWh.Active = Convert.ToChar(cboStatus.Text.Substring(0,1));

            if (cboStatus.Text == "Active")
            {
                objWh.Active='1';
            }
            else
            {
                objWh.Active = '0';
            }
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
            if (txtTypeName.Text.ToString() == "")
            {
                MessageBox.Show("type Name cannot be Empty");
                txtTypeName.Focus();
                return true;
            }
            if (cboStatus.Text.ToString() == "")
            {
                MessageBox.Show("Status cannot be Empty");
                cboStatus.Focus();
                return true;
            }
            return false;
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
                    Warehouse objWh = this.Populatewarehouse();
                    short i = atms.Savewarehousetype(objWh);
                    if (i == 1)
                    {
                        LoadListView();
                        txtTypeID.Text = "";
                        txtTypeName.Text = "";
                        txtTypeName.Focus();
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
        private void FormatGrid()
        {
            lvwWarehouse.CheckBoxes = false;
            lvwWarehouse.Columns.Add("Type id", 200, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Type Name", 300, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Status", 0, HorizontalAlignment.Left);

        }
        private void LoadListView()
        {
            lvwWarehouse.Items.Clear();
            List<Warehouse> objwh = atms.GetWarehousetype().ToList();
            if (objwh.Count > 0)
            {
                foreach (Warehouse wh in objwh)
                {
                    ListViewItem itm = new ListViewItem(wh.TypeID);
                    itm.SubItems.Add(wh.TypeName.ToString());
                    itm.SubItems.Add(wh.Remarks.ToString());
                    itm.SubItems.Add(wh.Active.ToString());
                    lvwWarehouse.Items.Add(itm);
                }
            }
        }
        private void btnEdit_Click(object sender, System.EventArgs e)
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
                    Warehouse objWh = this.Populatewarehouse();
                    short i = atms.Updatewarehousetype(objWh);
                    if (i == 1)
                    {
                        LoadListView();
                        btnSave.Enabled = true;
                        btnEdit.Enabled = false;
                        txtTypeID.Text = "";
                        txtTypeName.Text = "";
                        txtTypeName.Focus();
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

        private void frmWarehouse_Load(object sender, System.EventArgs e)
        {
            //txtTypeName.Focus();
            txtTypeName.Select();
            FormatGrid();
            LoadListView();
        }
        private void lvwWarehouse_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lvwWarehouse.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
                ListViewItem itm = lvwWarehouse.SelectedItems[0];
                txtTypeID.Text = itm.SubItems[0].Text; 
                txtTypeName.Text = itm.SubItems[1].Text;
                txtRemarks.Text = itm.SubItems[2].Text;
                if (itm.SubItems[3].Text == "1")
                {
                    cboStatus.Text = "Active";
                }
                else
                {
                    cboStatus.Text = "Inactive";
                }
                txtTypeName.Focus();
            }
        }

        private void txtTypeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Return)
            {
                txtRemarks.Focus();
            }
        }

        private void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboStatus.Focus();
            }
        }

        private void cboStatus_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            txtTypeName.Focus();
        }
    }
}
