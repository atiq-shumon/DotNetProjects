using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.PHRMSSR;

namespace AH.ModuleController.UI.PHRMS.Forms
{
    public partial class frmConsumptionForm : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        public frmConsumptionForm()
        {
            InitializeComponent();
        }
        private void FormatList()
        {
            lvDrugConsumption.CheckBoxes = false;
            lvDrugConsumption.Columns.Add("ID",80,HorizontalAlignment.Left);
            lvDrugConsumption.Columns.Add("Name", 150, HorizontalAlignment.Left);
            lvDrugConsumption.Columns.Add("Name Beng", 150, HorizontalAlignment.Left);
            lvDrugConsumption.Columns.Add("Remarks", 120, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvDrugConsumption.Items.Clear();
            List<ConsumptionForm> ocons = phrSr.GetConsumption().ToList();

            int i = 0;

            foreach (ConsumptionForm cns in ocons)
            {
                ListViewItem itm = new ListViewItem(cns.ID);
                itm.SubItems.Add(cns.Name);
                itm.SubItems.Add(cns.NameBeng);
                itm.SubItems.Add(cns.Remarks);
                lvDrugConsumption.Items.Add(itm);
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDrugConsumption_Load(object sender, EventArgs e)
        {
            FormatList();
            LoadListView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtConsumptionName", "txtConsumptionNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvDrugConsumption, 1, txtConsumptionName.Text))
            {
                MessageBox.Show("This Consumption is already Added");
                //RefreshListBox();
                return;
            }
            try
            {

                ConsumptionForm mstr = this.populateDrugConsumption();
                string i = phrSr.SaveDrugConsumption(mstr);
                

                if (i == "0")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtConsumptionID.Text = i;
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
        private ConsumptionForm populateDrugConsumption()
        {
            ConsumptionForm ocns = new ConsumptionForm();
            ocns.ID = txtConsumptionID.Text;
            ocns.Name = txtConsumptionName.Text;
            ocns.NameBeng = txtConsumptionNameBang.Text;
            ocns.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            ocns.EntryParameter = ep;

            return ocns;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "txtConsumptionName", "txtConsumptionNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {

                ConsumptionForm mstr = this.populateDrugConsumption();
                short i = phrSr.ModifyDrugConsumption(mstr);


                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
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

        private void lvDrugConsumption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvDrugConsumption.SelectedItems.Count > 0)
            {
                ListViewItem itm  = lvDrugConsumption.SelectedItems[0];
                txtConsumptionID.Text = itm.SubItems[0].Text;
                txtConsumptionName.Text = itm.SubItems[1].Text;
                txtConsumptionNameBang.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }
    }
}
