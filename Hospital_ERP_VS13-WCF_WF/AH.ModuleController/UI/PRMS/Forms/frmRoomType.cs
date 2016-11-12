using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.PRMSSR;
using AH.DUtility;
namespace AH.ModuleController.UI.PRMS.Forms
{
    public partial class frmRoomType : AH.Shared.UI.frmSmartFormStandard
    {
        PRMSSR.PRMSWSClient prsSc = new PRMSSR.PRMSWSClient();
        public frmRoomType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtTypeName", "txtTypeNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                RoomType trmset = this.PopulateRoomType();
                short i = prsSc.SaveRoomType(trmset);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtTypeName.Focus();
                    RefreshGrid();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
        private RoomType PopulateRoomType()
        {
            RoomType rmtpobj = new RoomType();
            rmtpobj.ID = txtTypeID.Text;
            rmtpobj.Title = txtTypeName.Text;
            rmtpobj.TitleBeng = txtTypeNameBeng.Text;
            rmtpobj.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            rmtpobj.EntryParameter = ep;

            return rmtpobj;
        }
        private void RefreshGrid()
        {
            LoadListView();
        }
        private void FormatGrid()
        {
            lvRoomType.CheckBoxes = false;
            lvRoomType.Columns.Add("RoomType ID", 100, HorizontalAlignment.Center);
            lvRoomType.Columns.Add("RoomType Name", 200, HorizontalAlignment.Left);
            lvRoomType.Columns.Add("RoomType Name(Beng)", 200, HorizontalAlignment.Left);
            lvRoomType.Columns.Add("Remarks", 250, HorizontalAlignment.Left);
        }

        private void frmRoomType_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadListView();
        }
        private void LoadListView()
        {
            lvRoomType.Items.Clear();

            List<RoomType> trmtp = prsSc.GetRoomTypes().ToList();
            int i = 0;
            foreach (RoomType trms in trmtp)
            {
                ListViewItem itm = new ListViewItem(trms.ID);
                itm.SubItems.Add(trms.Title);
                itm.SubItems.Add(trms.TitleBeng);
                itm.SubItems.Add(trms.Remarks);
                lvRoomType.Items.Add(itm);


            }

        }

        private void lvRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRoomType.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvRoomType.SelectedItems[0];
                txtTypeID.Text = itm.SubItems[0].Text;
                txtTypeName.Text = itm.SubItems[1].Text;
                txtTypeNameBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtTypeID", "txtTypeName", "txtTypeNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (prsSc.VerifyRoomType(txtTypeID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTypeID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                RoomType trmset = this.PopulateRoomType();
                short i = prsSc.UpdateRoomType(trmset);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtTypeName.Focus();
                    RefreshGrid();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

    }
}
