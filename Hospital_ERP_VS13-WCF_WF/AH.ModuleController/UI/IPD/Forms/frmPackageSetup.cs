using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.IPDSR;
using AH.DUtility;
//using AH.IPD.MODEL;


namespace AH.ModuleController.UI.IPD.Forms
{
    public partial class frmPackageSetup : AH.Shared.UI.frmSmartFormStandard
    {
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        public frmPackageSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtPackageName", "txtPackageNameBeng", "dtPackageEndDate", "dtPackageEndDate", "chckIsAmountDependent", "chckIsStayDependent", "txtStayDays", "txtAmount" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lstPackage, 1, txtPackageName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPackageName.Focus();
                    return;
                }

                PackageSetup oPkg = this.PopulatePackage();
                short i = ipdSc.SavePackageMaster(oPkg);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtPackageName.Focus();
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
        private void FormatGrid()
        {
            lstPackage.CheckBoxes = false;
            lstPackage.Columns.Add("Package ID", 100, HorizontalAlignment.Center);
            lstPackage.Columns.Add("Package Name", 200, HorizontalAlignment.Left);
            lstPackage.Columns.Add("Package Name(Bangla)", 200, HorizontalAlignment.Left);          
            lstPackage.Columns.Add("Package Start Date", 100, HorizontalAlignment.Center);
            lstPackage.Columns.Add("Package End Date", 100, HorizontalAlignment.Center);
            lstPackage.Columns.Add("Is Saty Dependent", 100, HorizontalAlignment.Center);
            lstPackage.Columns.Add("Is Amount Dependent", 100, HorizontalAlignment.Center);
            lstPackage.Columns.Add("Stay Days ", 50, HorizontalAlignment.Center);
            lstPackage.Columns.Add("Amount ", 100, HorizontalAlignment.Center);
            lstPackage.Columns.Add("Remarks", 200, HorizontalAlignment.Left);

        }

        private PackageSetup PopulatePackage()
        {
           
            PackageSetup oPackage = new PackageSetup();

            DateTime startDate = DateTime.ParseExact(dtPackageStartDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            DateTime endDate = DateTime.ParseExact(dtPackageEndDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));

            oPackage.PackageID = txtPackageID.Text;
            oPackage.PackageTitle = txtPackageName.Text;
            oPackage.PackageTitleBeng = txtPackageNameBeng.Text;
            oPackage.Remarks = txtRemarks.Text;

            if (startDate >= DateTime.Now.Date && endDate>= DateTime.Now.Date)
            {
            oPackage.PackageStartDate = startDate; //DateTime.ParseExact(dtPackageStartDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB")); 
            oPackage.PackageEndDate = endDate;// DateTime.ParseExact(dtPackageEndDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            }

            if (chckIsStayDependent.Checked == true)
            {
                oPackage.IsStayDependent = char.Parse("1");
            }
            else
            {
                oPackage.IsStayDependent = char.Parse("0");
            }

            if (chckIsAmountDependent.Checked == true)
            {
                oPackage.IsAmountDependent = char.Parse("1");
            }
            else
            {
                oPackage.IsAmountDependent = char.Parse("0");
            }
            oPackage.StayDays =Convert.ToInt32( txtStayDays.Text);
            oPackage.Amount =Convert.ToInt32( txtAmount.Text) ;


            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oPackage.EntryParameter = ep;
            return oPackage;
        }
        private void LoadListView()
        {
            lstPackage.Items.Clear();

            List<PackageSetup> oPkgs = ipdSc.GetPackageMaster().ToList();
            foreach (PackageSetup pkg in oPkgs)
            {
                ListViewItem itm = new ListViewItem(pkg.PackageID);
                itm.SubItems.Add(pkg.PackageTitle);
                itm.SubItems.Add(pkg.PackageTitleBeng);               
                itm.SubItems.Add(pkg.PackageStartDate.ToString("dd-MM-yyyy"));
                itm.SubItems.Add(pkg.PackageEndDate.ToString("dd-MM-yyyy"));
                itm.SubItems.Add((pkg.IsStayDependent).ToString());
                itm.SubItems.Add((pkg.IsAmountDependent).ToString());
                itm.SubItems.Add((pkg.StayDays).ToString());
                itm.SubItems.Add((pkg.Amount).ToString());
                itm.SubItems.Add(pkg.Remarks);
        
                lstPackage.Items.Add(itm);
            }

        }

        private void frmPackageSetup_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadListView();
            txtPackageName.Select();
        }

        private void lstPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPackage.SelectedItems.Count > 0)
            {
                ListViewItem itm = lstPackage.SelectedItems[0];
                txtPackageID.Text = itm.SubItems[0].Text;
                txtPackageName.Text = itm.SubItems[1].Text;
                txtPackageNameBeng.Text = itm.SubItems[2].Text;               
                dtPackageStartDate.Text = itm.SubItems[3].Text;
                dtPackageEndDate.Text = itm.SubItems[4].Text;
                if (itm.SubItems[5].Text == "1")
                {
                    chckIsStayDependent.Checked = true;
                }
                else
                {
                    chckIsStayDependent.Checked = false;
                }
                if (itm.SubItems[6].Text == "1")
                {
                    chckIsAmountDependent.Checked = true;
                }
                else 
                {
                    chckIsAmountDependent.Checked = false;
                }
                txtStayDays.Text = itm.SubItems[7].Text;
                txtAmount.Text = itm.SubItems[8].Text;
                txtRemarks.Text = itm.SubItems[9].Text;
            }
            btnSave.Enabled = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtPackageID","txtPackageName", "txtPackageNameBeng", "dtPackageEndDate", "dtPackageEndDate", "chckIsAmountDependent", "chckIsStayDependent", "txtStayDays", "txtAmount" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            //if (ipdSc.VerifyDelivery(txtPackageID.Text) == 0)
            //{
            //    MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtPackageID.Select();
            //    btnNew.PerformClick();
            //    return;
            //}
            try
            {

                PackageSetup oPkg = this.PopulatePackage();
                short i = ipdSc.UpdatePackageMaster(oPkg);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtPackageName.Focus();
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
            txtPackageName.Focus();         
        }

    }
}
