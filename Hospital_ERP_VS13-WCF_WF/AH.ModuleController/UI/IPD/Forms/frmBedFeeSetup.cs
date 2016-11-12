using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
//using AH.Shared.MODEL;
using AH.ModuleController.IPDSR;

namespace AH.ModuleController.UI.IPD.Forms
{
    public partial class frmBedFeeSetup : AH.Shared.UI.frmSmartFormStandard
    {
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        public frmBedFeeSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnShow.PerformClick();
            List<string> vf = new List<string>() { "txtAmount", "cboRevenueHead", "cboRevenueHeadGroup" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (ipdSc.VerifyBedTestFee(cboBedType.SelectedValue.ToString(),cboBedFacilityType.SelectedValue.ToString()) == 1)
            {
                MessageBox.Show(Utility.VerifyMessage, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDeptID.Select();
                //btnShow.PerformClick();
                btnNew.PerformClick();
                return;
            }
            try
            {
                BedCharges tbd = this.PopulateBedFee();
                short i = ipdSc.SaveBedFee(tbd);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    cboRevenueHeadGroup.Select();
                    RefreshGrid(cboBedType.SelectedValue.ToString(),cboBedFacilityType.SelectedValue.ToString());
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

        private BedCharges PopulateBedFee()
        {
            BedCharges bdch = new BedCharges();
            bdch.Amount = decimal.Parse(txtAmount.Text);
           
            Building bld = new Building();
            bld.BuildingID = "01";//cboBuilding.SelectedValue.ToString();
            bdch.Building = bld;

            Department dpt = new Department();
            dpt.DepartmentID = "";//cboDeptID.SelectedValue.ToString();
            bdch.Department = dpt;

            BedType type = new BedType();
            type.ID = cboBedType.SelectedValue.ToString();

            BedFacility bedFacility = new BedFacility();
            bedFacility.ID = cboBedFacilityType.SelectedValue.ToString();
            type.BedFacility = bedFacility;
            bdch.BedType = type;

            RevenueHeadGroup rhd = new RevenueHeadGroup();
            rhd.ID = cboRevenueHeadGroup.SelectedValue.ToString();
            bdch.RevenueHeadGroup = rhd;

            RevenueHead rv = new RevenueHead();
            rv.ID = cboRevenueHead.SelectedValue.ToString();
            bdch.RevenueHead = rv;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            bdch.EntryParameter = ep;

            return bdch;
        }
        private void FormatGrid()
        {
            lvBedFee.CheckBoxes = false;
            lvBedFee.Columns.Add("BedType", 100, HorizontalAlignment.Left);
            lvBedFee.Columns.Add("BedCategoryType", 150, HorizontalAlignment.Left);
            lvBedFee.Columns.Add("RevenueHeadGroup", 200, HorizontalAlignment.Left);
            lvBedFee.Columns.Add("RevenueHead", 200, HorizontalAlignment.Left);
            lvBedFee.Columns.Add("Amount", 150, HorizontalAlignment.Left);
        }
        private void LoadListView(string bedtype,string bedFacilityType)
        {
            lvBedFee.Items.Clear();
            List<BedCharges> bdch;

            if (bedtype.Length != 0)
            {
                bdch = ipdSc.GetBedRate(bedtype,bedFacilityType).ToList();

            }
            else
            {
                return;
            }
            int i = 0;
            foreach (BedCharges tbd in bdch)
            {
                ListViewItem itm = new ListViewItem(tbd.BedType.Title);
                itm.SubItems.Add(tbd.BedType.BedFacility.Title);
                itm.SubItems.Add(tbd.RevenueHeadGroup.Title);
                itm.SubItems.Add(tbd.RevenueHead.Title);
                itm.SubItems.Add(tbd.Amount.ToString());

                lvBedFee.Items.Add(itm);
            }

        }
        private void RefreshGrid(string bedtype,string bedFacilityType)
        {
            LoadListView(bedtype, bedFacilityType);
        }
        private void frmBedFeeSetup_Load(object sender, EventArgs e)
        {
          
                cboBedType.DisplayMember = "Value";
                cboBedType.ValueMember = "Key";
                cboBedType.DataSource = new BindingSource(ipdSc.GetBedtypeDict("F"), null);

                cboBuilding.DisplayMember = "Value";
                cboBuilding.ValueMember = "Key";
                cboBuilding.DataSource = new BindingSource(ipdSc.GetBuildingDict("D"), null);

                //cboDeptID.DisplayMember = "Value";
                //cboDeptID.ValueMember = "Key";
                //cboDeptID.DataSource = new BindingSource(admsSC.GetDepartmentDict("E"), null);

                cboRevenueHeadGroup.DisplayMember = "Value";
                cboRevenueHeadGroup.ValueMember = "Key";
                cboRevenueHeadGroup.DataSource = new BindingSource(ipdSc.GetRevHdGrps("D"), null);

                cboRevenueHead.DataSource = null;

                cboBedType.Select();
                LoadListView(cboBedType.SelectedValue.ToString(), cboBedFacilityType.SelectedValue.ToString());
                FormatGrid();
      
        }

        private void cboDeptID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadListView(cboRvHeadGr.SelectedValue.ToString());
        }

        private void lvBedFee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBedFee.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvBedFee.SelectedItems[0];
                cboBedType.Text = itm.SubItems[0].Text;
                cboBedFacilityType.Text = itm.SubItems[1].Text;
                cboRevenueHeadGroup.Text = itm.SubItems[2].Text;
                cboRevenueHead.Text = itm.SubItems[3].Text;
                txtAmount.Text = itm.SubItems[4].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtBedFee" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                BedCharges tbd = this.PopulateBedFee();
                short i = ipdSc.UpdateBedFee(tbd);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    cboRevenueHeadGroup.Select();
                    RefreshGrid(cboBedType.SelectedValue.ToString(),cboBedFacilityType.SelectedValue.ToString());
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


        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {//if (cboBedType.Text.Length == 0)
                //{
                //    //MessageBox.Show("You must provide a (unique) item number.",
                //    //                "Fun Department Store",
                //    //                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //}
                //else
                //{
                LoadListView(cboBedType.SelectedValue.ToString(), cboBedFacilityType.SelectedValue.ToString());
                // }
                //LoadListView(cboBedType.SelectedValue.ToString(), cboRevenueHeadGroup.SelectedValue.ToString(), cboRevenueHead.SelectedValue.ToString());
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

        private void cboRevenueHeadGroup_Click(object sender, EventArgs e)
        {
            cboRevenueHead.DisplayMember = "Value";
            cboRevenueHead.ValueMember = "Key";
            cboRevenueHead.DataSource = new BindingSource(Utility.VerifyDic(ipdSc.GetRevenueHeads("D", cboRevenueHeadGroup.SelectedValue.ToString())), null);
        }

        private void cboBedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboBedFacilityType.DisplayMember = "Value";
            cboBedFacilityType.ValueMember = "Key";
            cboBedFacilityType.DataSource = new BindingSource(Utility.VerifyDic(ipdSc.GetBedfacility("D")), null);
            
        }

        private void cboBedFacilityType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btnShow.PerformClick();
        }
    }
}
