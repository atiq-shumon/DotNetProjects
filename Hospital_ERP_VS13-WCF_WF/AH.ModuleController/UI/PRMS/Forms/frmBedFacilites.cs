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
    public partial class frmBedFacilites : AH.Shared.UI.frmSmartFormStandard
    {
        PRMSSR.PRMSWSClient prsSC = new PRMSSR.PRMSWSClient();
        public frmBedFacilites()
        {
            InitializeComponent();
        }

        private void btnTopClose_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtFacilityName", "txtFacilityNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                BedFacility bfac = this.PopulateBedfacility();
                short i = prsSC.SaveBedfacility(bfac);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtFacilityName.Select();
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
        private BedFacility PopulateBedfacility()
        {
            BedFacility bfacobj = new BedFacility();
            bfacobj.ID = txtFacilityID.Text;
            bfacobj.Title = txtFacilityName.Text;
            bfacobj.TitleBeng = txtFacilityNameBeng.Text;
            bfacobj.TV = short.Parse(cboTv.Text);
            bfacobj.Fridge = short.Parse(cboFridge.Text);
            bfacobj.Sofa = short.Parse(cboSofa.Text);
            bfacobj.Internet = short.Parse(cboInternet.Text);
            bfacobj.Newspaper = short.Parse(cboNewspaper.Text);
            bfacobj.Corridor = short.Parse(cboCorridor.Text);
            bfacobj.Veranda = short.Parse(cboVeranda.Text);
            bfacobj.XtraBed = short.Parse(cboBedxtra.Text);
            bfacobj.Almirah = short.Parse(cboAlmirah.Text);
            bfacobj.MaxAllowedPerson = short.Parse(cboPerson.Text);
            bfacobj.AC = short.Parse(cboAc.Text);
            bfacobj.WashRoom = short.Parse(cboWashroom.Text);
            bfacobj.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            bfacobj.EntryParameter = ep;


            return bfacobj;
        }
        private void FormatGrid()
        {
            lvBedFacilities.CheckBoxes = false;
            lvBedFacilities.Columns.Add("Facility ID", 200, HorizontalAlignment.Center);
            lvBedFacilities.Columns.Add("Facility Name", 350, HorizontalAlignment.Left);
            lvBedFacilities.Columns.Add("Facility Name(Beng)", 350, HorizontalAlignment.Left);
            lvBedFacilities.Columns.Add("TV", 0, HorizontalAlignment.Center);
            lvBedFacilities.Columns.Add("Fridge", 0, HorizontalAlignment.Center);
            lvBedFacilities.Columns.Add("Sofa", 0, HorizontalAlignment.Center);
            lvBedFacilities.Columns.Add("Internet", 0, HorizontalAlignment.Center);
            lvBedFacilities.Columns.Add("Newspaper", 0, HorizontalAlignment.Center);
            lvBedFacilities.Columns.Add("Corridor", 0, HorizontalAlignment.Center);
            lvBedFacilities.Columns.Add("Veranda", 0, HorizontalAlignment.Center);
            lvBedFacilities.Columns.Add("Almirah", 0, HorizontalAlignment.Center);
            lvBedFacilities.Columns.Add("XtraBed", 0, HorizontalAlignment.Center);
            lvBedFacilities.Columns.Add("MaxPerson", 0, HorizontalAlignment.Center);
            lvBedFacilities.Columns.Add("AC", 0, HorizontalAlignment.Center);
            lvBedFacilities.Columns.Add("Washroom", 0, HorizontalAlignment.Center);
            lvBedFacilities.Columns.Add("Remarks", 0, HorizontalAlignment.Center);
        }

        private void frmBedFacilites_Load(object sender, EventArgs e)
        {
            List<short> tv = prsSC.GetNumbers(0, 6).ToList();
            cboTv.DataSource = tv;
            List<short> fridge = prsSC.GetNumbers(0, 6).ToList();
            cboFridge.DataSource = fridge;
            List<short> sofa = prsSC.GetNumbers(0, 6).ToList();
            cboSofa.DataSource = sofa;
            List<short> internet = prsSC.GetNumbers(0, 6).ToList();
            cboInternet.DataSource = internet;
            List<short> paper = prsSC.GetNumbers(0, 6).ToList();
            cboNewspaper.DataSource = paper;
            List<short> veranda = prsSC.GetNumbers(0, 6).ToList();
            cboVeranda.DataSource = veranda;
            List<short> person = prsSC.GetNumbers(0, 6).ToList();
            cboPerson.DataSource = person;
            List<short> wash = prsSC.GetNumbers(0, 6).ToList();
            cboWashroom.DataSource = wash;
            List<short> ac = prsSC.GetNumbers(0, 6).ToList();
            cboAc.DataSource = ac;
            List<short> bdxtra = prsSC.GetNumbers(0, 6).ToList();
            cboBedxtra.DataSource = bdxtra;
            List<short> coridor = prsSC.GetNumbers(0, 6).ToList();
            cboCorridor.DataSource = coridor;
            List<short> almira = prsSC.GetNumbers(0, 6).ToList();
            cboAlmirah.DataSource = almira;

            txtFacilityName.Select();
            FormatGrid();
            LoadListView();

        }
        private void LoadListView()
        {
            lvBedFacilities.Items.Clear();

            List<BedFacility> bdfacs = prsSC.GetBedfacility().ToList();
            int i = 0;
            foreach (BedFacility bfac in bdfacs)
            {
                ListViewItem itm = new ListViewItem(bfac.ID);
                itm.SubItems.Add(bfac.Title);
                itm.SubItems.Add(bfac.TitleBeng);
                itm.SubItems.Add(bfac.TV.ToString());
                itm.SubItems.Add(bfac.Fridge.ToString());
                itm.SubItems.Add(bfac.Sofa.ToString());
                itm.SubItems.Add(bfac.Internet.ToString());
                itm.SubItems.Add(bfac.Newspaper.ToString());
                itm.SubItems.Add(bfac.Corridor.ToString());
                itm.SubItems.Add(bfac.Veranda.ToString());
                itm.SubItems.Add(bfac.Almirah.ToString());
                itm.SubItems.Add(bfac.XtraBed.ToString());
                itm.SubItems.Add(bfac.MaxAllowedPerson.ToString());
                itm.SubItems.Add(bfac.AC.ToString());
                itm.SubItems.Add(bfac.WashRoom.ToString());
                itm.SubItems.Add(bfac.Remarks);
                lvBedFacilities.Items.Add(itm);
            }


        }


        private void smartLabel10_Click(object sender, EventArgs e)
        {

        }

        private void cboCorridor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void smartLabel9_Click(object sender, EventArgs e)
        {

        }

        private void cboVeranda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void smartLabel8_Click(object sender, EventArgs e)
        {

        }

        private void cboBedxtra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvBedFacilities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBedFacilities.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvBedFacilities.SelectedItems[0];
                txtFacilityID.Text = itm.SubItems[0].Text;
                txtFacilityName.Text = itm.SubItems[1].Text;
                txtFacilityNameBeng.Text = itm.SubItems[2].Text;
                cboTv.Text = itm.SubItems[3].Text;
                cboFridge.Text = itm.SubItems[4].Text;
                cboSofa.Text = itm.SubItems[5].Text;
                cboInternet.Text = itm.SubItems[6].Text;
                cboNewspaper.Text = itm.SubItems[7].Text;
                cboCorridor.Text = itm.SubItems[8].Text;
                cboVeranda.Text = itm.SubItems[9].Text;
                cboAlmirah.Text = itm.SubItems[10].Text;
                cboBedxtra.Text = itm.SubItems[11].Text;
                cboPerson.Text = itm.SubItems[12].Text;
                cboAc.Text = itm.SubItems[13].Text;
                cboWashroom.Text = itm.SubItems[14].Text;
                txtRemarks.Text = itm.SubItems[15].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtFacilityID", "txtFacilityName", "txtFacilityNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (prsSC.VerifyBedFacility(txtFacilityID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFacilityID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                BedFacility bfac = this.PopulateBedfacility();
                short i = prsSC.UpdateBedFacility(bfac);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtFacilityName.Select();
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
