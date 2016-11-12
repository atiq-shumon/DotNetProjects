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
    public partial class frmConsumptionPurpose : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        public frmConsumptionPurpose()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }
        private void FormatGrid()
        {
            lvConsumer.CheckBoxes = false;
            lvConsumer.Columns.Add("PurposeID", 120, HorizontalAlignment.Left);
            lvConsumer.Columns.Add("Purpose",230,HorizontalAlignment.Left);
            lvConsumer.Columns.Add("Priority",100,HorizontalAlignment.Left);
            lvConsumer.Columns.Add("Remarks",350,HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvConsumer.Items.Clear();

            List<ConsumerPurpose> con = phrSr.GetConsumerPurpose().ToList();
            int i = 0;
            foreach (ConsumerPurpose cn in con)
            {
                ListViewItem itm = new ListViewItem(cn.PurposeID);
                itm.SubItems.Add(cn.PurposeTitle);
                itm.SubItems.Add(cn.Priority.ToString());
                itm.SubItems.Add(cn.Remarks);
                lvConsumer.Items.Add(itm);
            }

        }
        private ConsumerPurpose populateConsumerPurpose()
        {
            ConsumerPurpose con = new ConsumerPurpose();
            con.PurposeID = txtConsumptionID.Text;
            con.PurposeTitle = txtConsumptionName.Text;
            con.Remarks = txtRemarks.Text;
            con.Priority = txtPriority.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            con.EntryParameter = ep;

            return con;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtConsumerName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(Utility.IsDuplicateFoundInList(lvConsumer,1,txtConsumptionName.Text))
            {
                MessageBox.Show("This Consumption Name is a duplicate");
                return;
            }
            try
            {
                ConsumerPurpose con = this.populateConsumerPurpose();
                short i = phrSr.SaveConsumerPurpose(con);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtConsumptionName.Select();
                    RefreshGrid();
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

        private void frmConsumerPurpose_Load(object sender, EventArgs e)
        {
            txtConsumptionName.Select();
            FormatGrid();
            LoadListView();
        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void lvConsumer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvConsumer.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvConsumer.SelectedItems[0];
                txtConsumptionID.Text = itm.SubItems[0].Text;
                txtConsumptionName.Text = itm.SubItems[1].Text;
                txtPriority.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtConsumerName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                ConsumerPurpose con = this.populateConsumerPurpose();
                short i = phrSr.UpdateConsumerPurpose(con);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtConsumptionName.Select();
                    RefreshGrid();
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
}
