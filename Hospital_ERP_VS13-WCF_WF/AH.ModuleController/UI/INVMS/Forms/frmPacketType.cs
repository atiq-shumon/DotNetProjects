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
    public partial class frmPacketType : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        public frmPacketType()
        {
            InitializeComponent();
        }

        private void frmLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "txtTypeName", "txtTypeNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvPacketType, 1, txtTypeName.Text))
            {
                MessageBox.Show("This Type Name has already been added");
                return;
            }
            try
            {
                PacketType otype = this.populatePacketType();
                short i = invSr.SavePacketType(otype);

                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    RefreshGrid();
                    txtTypeName.Select();

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

            
        private PacketType populatePacketType()
        {
            PacketType opack = new PacketType();
            opack.ID = txtTypeID.Text;
            opack.Name = txtTypeName.Text;
            opack.NameBeng = txtTypeNameBang.Text;
            opack.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            opack.EntryParameter = ep;
            return opack;
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPacketType_Load(object sender, EventArgs e)
        {
            txtTypeName.Select();
            FormatGrid();
            LoadListView();
            btnEdit.Enabled = false;
        }
        private void FormatGrid()
        {

            lvPacketType.CheckBoxes = false;
            lvPacketType.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lvPacketType.Columns.Add("Name", 275, HorizontalAlignment.Left);
            lvPacketType.Columns.Add("NameBeng", 0, HorizontalAlignment.Left);
            lvPacketType.Columns.Add("Remarks", 350, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvPacketType.Items.Clear();

            List<PacketType> opack = invSr.GetPacketType().ToList();
            int i = 0;
            foreach (PacketType tp in opack)
            {
                ListViewItem itm = new ListViewItem(tp.ID);
                itm.SubItems.Add(tp.Name);
                itm.SubItems.Add(tp.NameBeng);
                itm.SubItems.Add(tp.Remarks);
                lvPacketType.Items.Add(itm);
            }
        }
        private void RefreshGrid()
        {
            LoadListView();

        }
        private void lvPacketType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPacketType.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvPacketType.SelectedItems[0];
                txtTypeID.Text = itm.SubItems[0].Text;
                txtTypeName.Text = itm.SubItems[1].Text;
                txtTypeNameBang.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                PacketType otype = this.populatePacketType();
                short i = invSr.ModifyPacketType(otype);

                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    RefreshGrid();
                    txtTypeName.Select();

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

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }
    }
}
