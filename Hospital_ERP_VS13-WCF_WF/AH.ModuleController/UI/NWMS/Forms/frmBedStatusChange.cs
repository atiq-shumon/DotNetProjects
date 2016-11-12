using AH.DUtility;
using AH.ModuleController.NWMSSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AH.ModuleController.UI.NWMS
{
    public partial class frmBedStatusChange : AH.Shared.UI.frmSmartFormStandard
    {
        NWMSSR.NWMSWSClient nwbnch = new NWMSSR.NWMSWSClient();
       // private string bedID;
        public frmBedStatusChange()
        {
            InitializeComponent();
        }
        private void frmBedStatusChange_Load(object sender, EventArgs e)
        {
           // txtBedTitle.Text = bedID;
            cboBedStatus.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBedTitle.Text != "" && cboBedStatus.Text != "")
            {
                try
                {
                    //ChangeBedStatus
                    Bed bdst = this.Populate();
                    short i = nwbnch.ChangeBedStatus(bdst);
                    if (i == 1)
                    {
                        MessageBox.Show("Bed Status Changed Successfully", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Cannot Change Bed Status", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
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

        private Bed Populate()
        {
            Bed bds = new Bed();
            bds.BedID = txtBedID.Text; // txtBedTitle.Text;
            if (cboBedStatus.Text == "Clean") 
            {
                bds.BedStatus = "C";
            }

            if (cboBedStatus.Text == "Need To Clean")
            {
                bds.BedStatus = "N";
            }

            if (cboBedStatus.Text == "Damaged")
            {
                bds.BedStatus = "D";
            }

            if (cboBedStatus.Text == "Blocked")
            {
                bds.BedStatus = "B";
            }

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            bds.EntryParameter = ep;

            return bds;
        }
    }
}
