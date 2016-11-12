using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.IPDSR;

namespace  AH.ModuleController.UI.IPD.Forms
{
    public partial class frmDeliveryType : AH.Shared.UI.frmSmartFormStandard
    {
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        public frmDeliveryType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtTypeName", "txtTypeNameBeng"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvDeliv, 1, txtTypeName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTypeName.Focus();
                    return;
                }

                DeliveryType tdel = this.PopulateDeliveryType();
                short i = ipdSc.SaveDeliveryType(tdel);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtTypeName.Focus();
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
        private void RefreshGrid()
        {
            LoadListView();
        }
        private void FormatGrid()
        {
            lvDeliv.CheckBoxes = false;
            lvDeliv.Columns.Add("Type ID", 100, HorizontalAlignment.Center);
            lvDeliv.Columns.Add("Type Name", 200, HorizontalAlignment.Left);
            lvDeliv.Columns.Add("Type Name(Bangla)", 200, HorizontalAlignment.Left);
            lvDeliv.Columns.Add("Remarks", 340, HorizontalAlignment.Left);

        }

        private DeliveryType PopulateDeliveryType()
        {
            DeliveryType delobj = new DeliveryType();
            delobj.ID = txtTypeID.Text;
            delobj.Title = txtTypeName.Text;
            delobj.TitleBeng = txtTypeNameBeng.Text;
            delobj.Remarks = txtRemarks.Text;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            delobj.EntryParameter = ep;
            return delobj;
        }
        private void LoadListView()
        {
            lvDeliv.Items.Clear();

            List<DeliveryType> dtps =  ipdSc.GetDeliveryType().ToList();
            //int i = 0;
            foreach (DeliveryType di in dtps)
            {
                ListViewItem itm = new ListViewItem(di.ID);
                itm.SubItems.Add(di.Title);
                itm.SubItems.Add(di.TitleBeng);
                itm.SubItems.Add(di.Remarks);
                lvDeliv.Items.Add(itm);
            }

        }

        private void frmDeliveryType_Load(object sender, EventArgs e)
        {
            
                FormatGrid();
                LoadListView();
                txtTypeName.Select();
        }

        private void lvDeliv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvDeliv.SelectedItems.Count > 0)
                {
                    ListViewItem itm = lvDeliv.SelectedItems[0];
                    txtTypeID.Text = itm.SubItems[0].Text;
                    txtTypeName.Text = itm.SubItems[1].Text;
                    txtTypeNameBeng.Text = itm.SubItems[2].Text;
                    txtRemarks.Text = itm.SubItems[3].Text;
                }
                btnSave.Enabled = false;
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
            if (ipdSc.VerifyDelivery(txtTypeID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTypeID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
               
                DeliveryType tdel = this.PopulateDeliveryType();
                short i = ipdSc.UpdateDelType(tdel);
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
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtTypeName_TextChanged(object sender, EventArgs e)
        {
            txtTypeNameBeng.Text = txtTypeName.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

    }
}
