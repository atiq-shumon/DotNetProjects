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
    public partial class frmUnitDetails : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        public frmUnitDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "txtUnitName", "txtUnitNameBang", "txtRemarks" };
            Control control = Utility.ReqFieldValidator(this,vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name)+Utility.Req,Utility.MessageCaptionMsg,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(Utility.IsDuplicateFoundInList(lvUnit,1,txtUnitName.Text))
            {
                MessageBox.Show("This unit has already been added");
                return;
            }
            try
            {
                Units ounit = this.populateUnitSetup();
                short i = invSr.SaveUnitDetails(ounit);

                 if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtUnitName.Select();
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
        private Units populateUnitSetup()
        {
            Units ounit = new Units();
            ounit.ID = txtUnitID.Text;
            ounit.Name = txtUnitName.Text;
            ounit.NameBeng = txtUnitNameBang.Text;
            ounit.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            ounit.EntryParameter = ep;
            return ounit;
        }
        private void FormatGrid()
        {
            lvUnit.CheckBoxes = false;

            lvUnit.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lvUnit.Columns.Add("Name", 275, HorizontalAlignment.Left);
            lvUnit.Columns.Add("NameBeng", 0, HorizontalAlignment.Left);
            lvUnit.Columns.Add("Remarks", 350, HorizontalAlignment.Left);

        }
        private void LoadListView()
        {
            lvUnit.Items.Clear();

            List<Units> ounit = invSr.GetUnitSetup().ToList();
            int i = 0;

            foreach (Units unt in ounit)
            {
                ListViewItem itm = new ListViewItem(unt.ID);
                itm.SubItems.Add(unt.Name);
                itm.SubItems.Add(unt.NameBeng);
                itm.SubItems.Add(unt.Remarks);
                lvUnit.Items.Add(itm);
            }

        }
        private void RefreshGrid()
        {

            LoadListView();
        }

        private void frmUnitDetails_Load(object sender, EventArgs e)
        {
            txtUnitName.Select();
            FormatGrid();
            LoadListView();
        }

        private void lvUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUnit.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvUnit.SelectedItems[0];
                txtUnitID.Text = itm.SubItems[0].Text;
                txtUnitName.Text = itm.SubItems[1].Text;
                txtUnitNameBang.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Units ounit = this.populateUnitSetup();
                short i = invSr.ModifyUnitDetails(ounit);

                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    txtUnitName.Select();
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
