using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.PHRMSSR;

namespace AH.ModuleController.UI.PHRMS.Forms
{
    public partial class frmDayClose : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        public frmDayClose()
        {
            InitializeComponent();
        }

        private void frmDayClose_Load(object sender, EventArgs e)
        {
            cboPharmacy.Select();
            cboPharmacy.DisplayMember = "Value";
            cboPharmacy.ValueMember = "Key";
            cboPharmacy.DataSource = new BindingSource(phrSr.GetPharmacyName("D"), null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (phrSr.VerifyDate(cboPharmacy.SelectedValue.ToString(), DateTime.Parse(txtDate.Text).Date) > 0)
                {
                    MessageBox.Show("Already Dayend", "Caution");
                    return;
                }
                if (phrSr.VerifyDate(cboPharmacy.SelectedValue.ToString(), DateTime.Parse(txtDate.Text).Date) == 0)
                {
                    DayEnd odayclose = this.populateDayEnd();
                    short i = phrSr.StartDayClose(odayclose);
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
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //if(phrSr.VerifyDate(cboPharmacy.SelectedValue.ToString(), DateTime.Parse(txtDate.Text).Date) == 0)
            //{
            //    MessageBox.Show("Please Enter valid Date","Warning");
            //}

           
        }
        private DayEnd populateDayEnd()
        {
            DayEnd odayclose = new DayEnd();
            

            odayclose.Date = DateTime.Parse(txtDate.Text).Date;

            

            Pharmacy phr = new Pharmacy();
            phr.PharmacyID = cboPharmacy.SelectedValue.ToString();
            odayclose.Pharmacy = phr;

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
