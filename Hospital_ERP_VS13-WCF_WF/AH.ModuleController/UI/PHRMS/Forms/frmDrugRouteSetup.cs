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
    public partial class frmDrugRouteSetup : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        public frmDrugRouteSetup()
        {
            InitializeComponent();
        }

        private void frmDrugRouteSetup_Load(object sender, EventArgs e)
        {
            FormatList();
            LoadListView();
        }
        private void FormatList()
        {
            lvDrugRoute.CheckBoxes = false;
            lvDrugRoute.Columns.Add("ID", 80, HorizontalAlignment.Left);
            lvDrugRoute.Columns.Add("Name", 150, HorizontalAlignment.Left);
            lvDrugRoute.Columns.Add("Name Beng", 150, HorizontalAlignment.Left);
            lvDrugRoute.Columns.Add("Remarks", 120, HorizontalAlignment.Left);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtRouteName", "txtRouteNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvDrugRoute, 1, txtRouteName.Text))
            {
                MessageBox.Show("This Drug Route is already Added");                
                return;
            }
            try
            {
                DrugRoute mstr = this.populateDrugRoute();
                string i = phrSr.SaveDrugRoute(mstr);

                if (i == "0")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRouteID.Text = i;
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
        private DrugRoute populateDrugRoute()
        {
            DrugRoute ocns = new DrugRoute();
            ocns.ID = txtRouteID.Text;
            ocns.Name = txtRouteName.Text;
            ocns.NameBeng = txtRouteNameBang.Text;
            ocns.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            ocns.EntryParameter = ep;

            return ocns;
        }
        private void LoadListView()
        {
            lvDrugRoute.Items.Clear();
            List<DrugRoute> ocons = phrSr.GetDrugRoute().ToList();            
            int i = 0;
            foreach (DrugRoute cns in ocons)
            {
                ListViewItem itm = new ListViewItem(cns.ID);
                itm.SubItems.Add(cns.Name);
                itm.SubItems.Add(cns.NameBeng);
                itm.SubItems.Add(cns.Remarks);
                lvDrugRoute.Items.Add(itm);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtRouteName", "txtRouteNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {

                DrugRoute mstr = this.populateDrugRoute();
                short i = phrSr.ModifyDrugRoute(mstr);


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

        private void lvDrugRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDrugRoute.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDrugRoute.SelectedItems[0];
                txtRouteID.Text = itm.SubItems[0].Text;
                txtRouteName.Text = itm.SubItems[1].Text;
                txtRouteNameBang.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }
    }
}
