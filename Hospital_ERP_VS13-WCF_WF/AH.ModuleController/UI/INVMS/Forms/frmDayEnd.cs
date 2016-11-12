using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.INVMSSR;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmDayEnd : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();

        public frmDayEnd()
        {
            InitializeComponent();
        }

        private void frmDayEnd_Load(object sender, EventArgs e)
        {
            cboStoreLocation.Select();
            cboStoreLocation.ValueMember = "ID";
            cboStoreLocation.DisplayMember = "Name";
            cboStoreLocation.DataSource = new BindingSource(invSr.GetStoreLocation(),null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (invSr.VerifyDate(cboStoreLocation.SelectedValue.ToString(), DateTime.Parse(txtDate.Text)) > 0)
            {
                MessageBox.Show("Already Dayend", "Caution");
                return;
            }
            if (invSr.VerifyDate(cboStoreLocation.SelectedValue.ToString(), DateTime.Parse(txtDate.Text)) == 0)
            {
                DayEnd odayclose = this.populateDayEnd();
                short i = invSr.StartDayClose(odayclose);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //RefreshGrid();
                    btnNew.PerformClick();

                }
            }
        }
        private DayEnd populateDayEnd()
        {
            DayEnd odayclose = new DayEnd();


            odayclose.Date = DateTime.Parse(txtDate.Text).Date;



            StoreLocation ostore = new StoreLocation();
            ostore.ID = cboStoreLocation.SelectedValue.ToString();
            odayclose.StoreLocation = ostore;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            odayclose.EntryParameter = ep;


            return odayclose;
        }
    }
}
