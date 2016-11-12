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
    public partial class frmPOTypes : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        public frmPOTypes()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string> { "txtTypeName", "txtTypeNameBang" };
            Control control = Utility.ReqFieldValidator(this,vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvPOType,1,txtTypeName.Text))
            {
                MessageBox.Show("Same PO Type Name cannot be saved");
                return;
            }
            try
            {
                POTypes otype = this.populatePOType();
                short i = phrSr.SavePOType(otype);

                if (i == 0)
                {

                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    btnNew.PerformClick();
                    txtTypeID.Focus();
                    
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
        private POTypes populatePOType()
        {
            POTypes otype = new POTypes();
            otype.ID = txtTypeID.Text;
            otype.Name = txtTypeName.Text;
            otype.NameBeng = txtTypeNameBang.Text;
            otype.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            otype.EntryParameter = ep;

            return otype;
        }
        private void FormatGrid()
        {
            lvPOType.CheckBoxes = false;
            lvPOType.Columns.Add("ID",100,HorizontalAlignment.Left);
            lvPOType.Columns.Add("Name",150,HorizontalAlignment.Left);
            lvPOType.Columns.Add("NameBeng", 150, HorizontalAlignment.Left);
            lvPOType.Columns.Add("Remarks", 150, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvPOType.Items.Clear();

            List<POTypes> opolst = phrSr.GetPOTypes().ToList();

            foreach (POTypes po in opolst)
            {
                ListViewItem itm = new ListViewItem(po.ID);
                itm.SubItems.Add(po.Name);
                itm.SubItems.Add(po.NameBeng);
                itm.SubItems.Add(po.Remarks);
                lvPOType.Items.Add(itm);
            }

        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void frmPOTypes_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadListView();
        }

        private void lvPOType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPOType.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvPOType.SelectedItems[0];
                txtTypeID.Text = itm.SubItems[0].Text;
                txtTypeName.Text = itm.SubItems[1].Text;
                txtTypeNameBang.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string> { "txtTypeName", "txtTypeNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            
            try
            {
                POTypes otype = this.populatePOType();
                short i = phrSr.ModifyPOType(otype);

                if (i == 0)
                {

                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    //btnNew.PerformClick();
                    txtTypeID.Focus();

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
