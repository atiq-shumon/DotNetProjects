using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.OPRMSSR;
using AH.DUtility;



namespace AH.ModuleController.UI.OPR.Forms
{
    public partial class frmOpPackrMaster : AH.Shared.UI.frmSmartFormStandard
    {

        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();

        public frmOpPackrMaster()
        {
            InitializeComponent();
        }

        private void frmOpPackrMaster_Load(object sender, EventArgs e)
        {
            cboUnitName.DisplayMember = "UnitTitle";
            cboUnitName.ValueMember = "UnitId";
            cboUnitName.DataSource = accmSc.GetUnits().ToList();
            FormatGrid();
            LoadListView();
        }

        private void LoadListView()
        {
            try
            {
                lvwPackage.Items.Clear();
                List<PackageItem> objPI = accmSc.GetPackageMaster().ToList();
                foreach (PackageItem PI in objPI)
                {
                    ListViewItem itm = new ListViewItem(PI.ItemNo);
                    itm.SubItems.Add(PI.ItemName.ToString());
                    itm.SubItems.Add(PI.unitID.ToString());
                    lvwPackage.Items.Add(itm);
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
            lvwPackage.CheckBoxes = false;
            lvwPackage.Columns.Add("Item Code", 100, HorizontalAlignment.Center);
            lvwPackage.Columns.Add("Item Name", 730, HorizontalAlignment.Left);
            lvwPackage.Columns.Add("Unit ID", 0, HorizontalAlignment.Left);
            
        }
        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "txtName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
          return true;
        }

        private PackageItem PopulateedItem()
        {
            PackageItem objPI = new PackageItem();
            
            if (txtItemCode.Text != "")
            {
                objPI.ItemNo = txtItemCode.Text;
            }
            else
            {
                objPI.ItemNo = "";
            }

            objPI.ItemName = txtName.Text;
            objPI.unitName = cboUnitName.Text;
            objPI.unitID = cboUnitName.SelectedValue.ToString();

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objPI.EntryParameter = ep;

            return objPI;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvwPackage,1,txtName.Text))
            {
                MessageBox.Show("Cannot Insert Duplicate Value");
                txtName.Focus();
                return;
            }

            try
            {
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    PackageItem objPI = this.PopulateedItem();
                    short i = accmSc.SavePackageOprMaster(objPI);
                    if (i == 1)
                    {
                        //btnNew.PerformClick();
                        txtName.Text = "";
                        txtName.Focus();
                        LoadListView();
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
          
                PackageItem objPI = this.PopulateedItem();
                short i = accmSc.UpdatePackageOprMaster(objPI);
                try
                {
                    if (i == 1)
                    {
                        btnNew.PerformClick();
                        txtName.Focus();
                        LoadListView();
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

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Return)
            {
                cboUnitName.Focus();
            }
        }

        private void cboUnitName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSave.Focus();
            }
        }

        private void lvwPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwPackage.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
                ListViewItem itm = lvwPackage.SelectedItems[0];
                txtItemCode.Text = itm.SubItems[0].Text;
                txtName.Text = itm.SubItems[1].Text;
                cboUnitName.SelectedValue = itm.SubItems[2].Text;
                txtName.Focus();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            txtName.Focus();
        }






    }
}
