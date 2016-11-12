using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.PRMSSR;

namespace AH.ModuleController.UI.PRMS.Forms
{
    public partial class frmBedType : AH.Shared.UI.frmSmartFormStandard
    {
        PRMSSR.PRMSWSClient prsSC = new PRMSSR.PRMSWSClient();
        public frmBedType()
        {
            InitializeComponent();
        }

        private void txtRemarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void smartLabel12_Click(object sender, EventArgs e)
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
            try
            {
                BedType btype = this.PopulateBedtype();
                short i = prsSC.SaveBedtype(btype);
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
        private void RefreshGrid()
        {
            LoadListView();
        }


        private BedType PopulateBedtype()
        {
            BedType btpobj = new BedType();
            btpobj.ID = txtTypeID.Text;
            btpobj.Title = txtTypeName.Text;
            btpobj.TitleBeng = txtTypeNameBang.Text;
            btpobj.Remarks = txtRemarks.Text;
            btpobj.SerialPriority = short.Parse(cboSerialPriority.SelectedValue.ToString());

            BedFacility bfobj = new BedFacility();
            bfobj.ID = cboFacilityID.SelectedValue.ToString();
            btpobj.BedFacility = bfobj;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            btpobj.EntryParameter = ep;

            return btpobj;
        }
        private void FormatGrid()
        {
            lvBedType.CheckBoxes = false;
            lvBedType.Columns.Add("BedType ID", 100, HorizontalAlignment.Center);
            lvBedType.Columns.Add("BedType Name", 300, HorizontalAlignment.Left);
            lvBedType.Columns.Add("BedType Name(Beng)", 300, HorizontalAlignment.Left);
            lvBedType.Columns.Add("Remarks", 250, HorizontalAlignment.Left);
            lvBedType.Columns.Add("Bed FacilityID", 0, HorizontalAlignment.Center);
        }


        private void frmBedType_Load(object sender, EventArgs e)
        {
            List<short> ListValues = prsSC.GetNumbers(0, 11).ToList();
            cboSerialPriority.DataSource = ListValues;


            cboFacilityID.DisplayMember = "Value";
            cboFacilityID.ValueMember = "Key";
            cboFacilityID.DataSource = new BindingSource(prsSC.GetBedfacilityDict("D"), null);

            FormatGrid();
            LoadListView();

        }
        private void LoadListView()
        {
            lvBedType.Items.Clear();

            List<BedType> btps = prsSC.GetBedtype().ToList();
            int i = 0;
            foreach (BedType bdtpe in btps)
            {
                ListViewItem itm = new ListViewItem(bdtpe.ID);
                itm.SubItems.Add(bdtpe.Title);
                itm.SubItems.Add(bdtpe.TitleBeng);
                itm.SubItems.Add(bdtpe.Remarks);
                itm.SubItems.Add(bdtpe.BedFacility.ID);
                lvBedType.Items.Add(itm);
            }
        }

        private void lvBedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBedType.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvBedType.SelectedItems[0];
                txtTypeID.Text = itm.SubItems[0].Text;
                txtTypeName.Text = itm.SubItems[1].Text;
                txtTypeNameBang.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
                cboFacilityID.SelectedValue = itm.SubItems[4].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtTypeID", "txtTypeName", "txtTypeNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (prsSC.VerifyBedType(txtTypeID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTypeID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                BedType btype = this.PopulateBedtype();
                short i = prsSC.UpdateBedType(btype);
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
