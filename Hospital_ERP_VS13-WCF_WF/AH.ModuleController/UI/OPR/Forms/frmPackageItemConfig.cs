using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.OPRMSSR;
using AH.DUtility;
namespace AH.ModuleController.UI.OPR.Forms
{
    public partial class frmPackageItemConfig : AH.Shared.UI.frmSmartFormStandard
    {
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
      

        public frmPackageItemConfig()
        {
            InitializeComponent();
            txtSubItem.LostFocus += new EventHandler(txtSubItem_LostFocus);
            txtSubItem.GotFocus += new EventHandler(txtSubItem_GotFocus);

        }
        void txtSubItem_GotFocus(object sender, EventArgs e)
        {
            lstSubItem.Visible = false;
            
        }

        void txtSubItem_LostFocus(object sender, EventArgs e)
        {
           // lstSubItem.Visible = false;
        }

        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "txtPackageItem" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
          
            return true;
        }
        private void FormatGrid()
        {
            lvwPackageItem.CheckBoxes = false;
            lvwPackageItem.Columns.Add("Item Code", 260, HorizontalAlignment.Left);
            lvwPackageItem.Columns.Add("Package Item Name", 540, HorizontalAlignment.Left);
            lvwPackageItem.Columns.Add("Item rate", 0, HorizontalAlignment.Left);
            lvwPackageItem.Columns.Add("Sub Type", 0, HorizontalAlignment.Left);
            
        }

        private PackageItem PopulatePackage()
        {
            PackageItem package = new PackageItem();
            
            package.ItemNo = txtPackageCode.Text.ToString();
            package.ItemName = txtPackageItem.Text.ToString();
            package.ItemRate = 0;
            package.submenuID = lstSubItem.SelectedValue.ToString();

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            package.EntryParameter = ep;
            return package;
        }
        private void LoadListView()
        {
            try
            {
                lvwPackageItem.Items.Clear();
                List<PackageItem> objPack = accmSc.GetPackageItem("PackageItemAll", "").ToList();
                foreach (PackageItem pack in objPack)
                {

                    ListViewItem itm = new ListViewItem(pack.ItemNo);
                    itm.SubItems.Add(pack.ItemName);
                    itm.SubItems.Add(pack.ItemRate.ToString());
                    itm.SubItems.Add(pack.submenuID.ToString());
                    lvwPackageItem.Items.Add(itm);
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }

            if (Utility.IsDuplicateFoundInList(lvwPackageItem, 2, txtPackageItem.Text) == true)
            {
                MessageBox.Show("Cannot Insert Duplicate Value", "AGH Operation");
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    PackageItem Package = this.PopulatePackage();
                    short i = accmSc.SavedPackagedItem(Package);

                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        //MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //btnNew.PerformClick();
                        txtPackageItem.Text = "";
                        txtpackageRate.Text = "";
                        txtPackageItem.Focus();
                        LoadListView();
                        btnSave.Enabled = true;
                        btnEdit.Enabled = false;

                    }
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

        private void frmPackageItemConfig_Load(object sender, EventArgs e)
        {
           
            //cboSubItem.DisplayMember = "ItemName";
            //cboSubItem.ValueMember = "ItemNo";
            //cboSubItem.DataSource = accmSc.GetOprSubItem().ToList();
            txtPackageItem.GotFocus += new System.EventHandler(this.txtSubItem_GotFocus); 

            //lstSubItem.DisplayMember = "ItemName";
            //lstSubItem.ValueMember = "ItemNo";
            //lstSubItem.DataSource = accmSc.GetOprSubItem().ToList();

            lstSubItem.ValueMember = "ItemNo";
            lstSubItem.DisplayMember = "ItemName";
            lstSubItem.DataSource = new BindingSource(accmSc.GetOprSubItem(), null);



            this.lstSubItem.Location = new System.Drawing.Point(314, 248);
            this.lstSubItem.Size = new System.Drawing.Size(507, 210);
            this.lstSubItem.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular);
            //lstSubItem.BackColor = Color.Yellow;
            FormatGrid();
            LoadListView();
            txtPackageItem.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }

            //if (Utility.IsDuplicateFoundInList(lvwPackageItem, 2, txtPackageItem.Text) == true)
            //{
            //    MessageBox.Show("Cannot Insert Duplicate Value", "AGH Operation");
            //    return;
            //}
            try
            {
                var strResponse = MessageBox.Show("Do You Want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    PackageItem Package = this.PopulatePackage();
                    short i = accmSc.UpdatePackagedItem(Package);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        //MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtPackageItem.Focus();
                        LoadListView();
                        btnSave.Enabled = true;
                        btnEdit.Enabled = false;

                    }
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

        private void Clear()
        {
            txtPackageItem.Text = "";
            txtPackageCode.Text = "";
            txtpackageRate.Text="";
            txtPackageItem.Focus();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            txtPackageItem.Focus();
        }

        private void txtPackageItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                //txtpackageRate.Focus();
                btnSave.Focus();
            }
        }

        private void txtpackageRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (btnSave.Enabled)
                {
                    btnSave.Focus();
                }
                else
                {
                    btnEdit.Focus();
                }
            }
        }

        private void lvwPackageItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwPackageItem.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwPackageItem.SelectedItems[0];
                txtPackageCode.Text = itm.SubItems[0].Text;
                txtPackageItem.Text = itm.SubItems[1].Text;
                txtpackageRate.Text = itm.SubItems[2].Text;
                 lstSubItem.SelectedValue = itm.SubItems[3].Text;
                 txtSubItem.Text = lstSubItem.Text;
                txtPackageItem.Select();

            }
        }

        private void cboSubItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtpackageRate.Focus();
                
            }
        }

        private void txtSubItem_TextChanged(object sender, EventArgs e)
        {
            lstSubItem.Visible = true;
            lstSubItem.SelectedIndex = lstSubItem.FindString(txtSubItem.Text);
        }

        private void txtSubItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (lstSubItem.SelectedItem != null)
                {
                    lstSubItem.SelectedIndex = lstSubItem.SelectedIndex - 1;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (lstSubItem.Items.Count - 1 > lstSubItem.SelectedIndex)
                {
                    lstSubItem.SelectedIndex = lstSubItem.SelectedIndex + 1;
                }
            }
        }




        private void txtSubItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (lstSubItem.Items.Count > 0)
                {
                    txtSubItem.Text = lstSubItem.Text;
                    txtpackageRate.Focus();
                    lstSubItem.Visible = false;
                }
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            //lstSubItem.Visible = true;
            //this.lstSubItem.Location = new System.Drawing.Point(296, 248);
            //this.lstSubItem.Size = new System.Drawing.Size(130, 95);
            //lstSubItem.Dock = DockStyle.Fill;
            //lstSubItem.BringToFront =true;
            //this.Controls.Add(lstSubItem);
            //ListBox lstSubItem = new ListBox();
            //lstSubItem.BackColor = Color.Gray;
            ////lstSubItem.Text = "Add";
            //lstSubItem.Location = new System.Drawing.Point(130, 248);
            //lstSubItem.Size = new System.Drawing.Size(130, 95);
            //lstSubItem.BringToFront();
            //this.pnlMain.Controls.Add(lstSubItem);
        }

        private void txtPackageItem_TextChanged(object sender, EventArgs e)
        {
            //txtPackageItem.GotFocus += new System.EventHandler(this.txtSubItem_GotFocus); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show (lstSubItem.GetItemText("GEN-00001"));
            lstSubItem.SelectedValue = "GEN-00001";

        }

        private void lstSubItem_DoubleClick(object sender, EventArgs e)
        {
            txtSubItem.Text = lstSubItem.Text;
            lstSubItem.Visible = false;
            txtpackageRate.Focus();

        }

      
       
       






    }
}
