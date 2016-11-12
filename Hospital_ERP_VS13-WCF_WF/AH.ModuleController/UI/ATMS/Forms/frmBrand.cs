using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.ATMSSR;
using AH.DUtility;


namespace AH.ModuleController.UI.ATMS.Forms
{
    public partial class frmBrand : AH.Shared.UI.frmSmartFormStandard
    {
        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();
        public string strMode { set; get; }
        public string strUnder { set; get; }
        public string strindex { set; get; }

        public frmBrand()
        {
            InitializeComponent();
        }
        private bool validationfields()
        {
            if (txtBrandName.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }
        private Brand PopulateBrand()
        {
            Brand objbrnd = new Brand();
            if (txtbrandId.Text != "")
            {
                objbrnd.BrandID = txtbrandId.Text;
            }
            objbrnd.BrandName = txtBrandName.Text;
            objbrnd.groupid = cboGroup.SelectedValue.ToString();
            objbrnd.FormName = "Groups";
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objbrnd.EntryParameter = ep;
            return objbrnd;
        }
        private void btnSave_Click(object sender, EventArgs e)
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
                    Brand objBrnd = this.PopulateBrand();
                    short i = atms.SaveBrand(objBrnd);
                    //btnNew.PerformClick();
                    txtBrandName.Text = "";
                    txtBrandName.Focus();
                }
            }
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {
            cboGroup.ValueMember = "Key";
            cboGroup.DisplayMember = "Value";
            cboGroup.DataSource = new BindingSource(atms.Gegroup("LoadGroup",""), null);
            cboGroup.Text = strUnder.ToString();
        }
    }
}
