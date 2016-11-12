using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.ATMSSR;
using AH.ModuleController.UI.ATMS.Reports.Viewer;
using AH.DUtility;

namespace AH.ModuleController.UI.ATMS.Forms
{
    public partial class frmAssetsEdit : AH.Shared.UI.frmSmartFormStandard
    {
        public int  intVtype { set; get; }
        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();
        public frmAssetsEdit()
        {
            InitializeComponent();
        }

        private void FormatGrid()
        {
            lvwDetails.CheckBoxes = false;
            lvwDetails.Columns.Add("Mrr No", 150, HorizontalAlignment.Center);
            lvwDetails.Columns.Add("Tran. ID", 150, HorizontalAlignment.Left);
            lvwDetails.Columns.Add("Mrr. date", 120, HorizontalAlignment.Left);
            lvwDetails.Columns.Add("Supplier Id", 0, HorizontalAlignment.Left);
            lvwDetails.Columns.Add("Challan No", 0, HorizontalAlignment.Left);
            lvwDetails.Columns.Add("Challan Date",0, HorizontalAlignment.Left);
            lvwDetails.Columns.Add("AgainstRefNo", 0, HorizontalAlignment.Left);
            lvwDetails.Columns.Add("Ref Date", 0, HorizontalAlignment.Left);
            lvwDetails.Columns.Add("Notes", 0, HorizontalAlignment.Left);
            lvwDetails.Columns.Add("User", 0, HorizontalAlignment.Left);
            lvwDetails.Columns.Add("Dep ID", 0, HorizontalAlignment.Left);
            lvwDetails.Columns.Add("ProductID", 0, HorizontalAlignment.Left);
            lvwDetails.Columns.Add("ProductName", 300, HorizontalAlignment.Left);
            lvwDetails.Columns.Add("brandID", 0, HorizontalAlignment.Left);
            lvwDetails.Columns.Add("modelID", 0, HorizontalAlignment.Left);
            lvwDetails.Columns.Add("Unit ID", 0, HorizontalAlignment.Left);
            lvwDetails.Columns.Add("Qnty", 120, HorizontalAlignment.Left);

        }
        private void GetVoucherDetails(string vType)
        {
            
            if (vType =="Issue")
            {
                intVtype =  33;
            }
            else if (vType=="Damage")
            {
                intVtype = 34;
            }
            else if (vType == "Return")
            {
                intVtype = 32;
            }
            if (vType != "Issue")
            {
                lblDep.Visible = false;
                cboDepartment.Visible = false;
                lblAssets.Visible = false;
                cboAssetsUser.Visible = false;
            }
            else
            {
                lblDep.Visible = true ;
                cboDepartment.Visible = true ;
                lblAssets.Visible = true;
                cboAssetsUser.Visible = true;
            }
            lvwDetails.Items.Clear();
            List<MaterialReceipt> omrr = atms.DisplayvoucherDetails("VoucherDetails", intVtype.ToString()).ToList();
            foreach(MaterialReceipt mrr in omrr)
            {
                double dblQty;
                ListViewItem lvi = new ListViewItem();
                dblQty = Convert.ToDouble(mrr.dblQty) * -1;
                lvi.Text = mrr.MrrNo;
                lvi.SubItems.Add(mrr.TagNo);
                lvi.SubItems.Add(mrr.mrrdate);
                lvi.SubItems.Add(mrr.supplierCode);
                lvi.SubItems.Add(mrr.ChallanNo);
                lvi.SubItems.Add(mrr.ChallanDate);
                lvi.SubItems.Add(mrr.agiaintRefNo);
                lvi.SubItems.Add(mrr.againstDate);
                lvi.SubItems.Add(mrr.Notes);
                lvi.SubItems.Add(mrr.assetsUser);
                lvi.SubItems.Add(mrr.DepID);
                lvi.SubItems.Add(mrr.ProductID);
                lvi.SubItems.Add(mrr.ProductName);
                lvi.SubItems.Add(mrr.brandCode);
                lvi.SubItems.Add(mrr.ModelId);
                lvi.SubItems.Add(mrr.UnitID);
                lvi.SubItems.Add(dblQty.ToString());
                lvwDetails.Items.Add(lvi);
            }
            

        }

        private void frmAssetsEdit_Load(object sender, EventArgs e)
        {
            FormatGrid();
            DepartmentLoad();
            //DepartmentLoad();
        }
        private void GetAssetsUser(string Where)
        {
            cboAssetsUser.ValueMember = "Key";
            cboAssetsUser.DisplayMember = "Value";
            cboAssetsUser.DataSource = new BindingSource(atms.GetAssetsUsertoDep("GetAssetsUsertoDep", Where), null);
        }
        private void cboVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVoucher.Text  == "Issue")
            {
                frmLabel.Text = "Issue Edit";
            }
            else if (cboVoucher.Text == "Damage")
            {
                frmLabel.Text = "Damage Edit";
            }
            else if (cboVoucher.Text  == "Return")
            {
                frmLabel.Text = "Return Edit";
            }
            if (cboVoucher.SelectedIndex >= 0 || cboVoucher.SelectedIndex == -1)
            {
                if (cboVoucher.Text != " ")
                {
                    GetVoucherDetails(cboVoucher.Text);
                }
            }
        }
        private void mClear()
        {
            txtRefNo.Text = "";
            txtTagNo.Text = "";
            txtProductCode.Text = "";
            txtProductName.Text = "";
            cboDepartment.Text = "";
            cboAssetsUser.Text = "";
            txtTotalQty.Text = "";
            txtIssueQty.Text = "";
            txtGroupCode.Text = "";
            txtBrancode.Text = "";
            txtModel.Text = "";
            txtUnit.Text = "";
            txtSlNo.Text = "";

        }
        private void DepartmentLoad()
        {
            cboDepartment.ValueMember = "Key";
            cboDepartment.DisplayMember = "Value";
            cboDepartment.DataSource = new BindingSource(atms.GetDepartment("HrsDep", ""), null);
        }
        //private void GetAssetsUser(string Where)
        //{
        //    cboAssetsUser.ValueMember = "Key";
        //    cboAssetsUser.DisplayMember = "Value";
        //    cboAssetsUser.DataSource = new BindingSource(atms.GetAssetsUsertoDep("GetAssetsUsertoDep", Where), null);
        //}
        private void lvwDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
              mClear();
              if (lvwDetails.SelectedItems.Count > 0)
              {
                  double dblQty;
                 
                  ListViewItem itm = lvwDetails.SelectedItems[0];
                  dblQty = Convert.ToDouble(itm.SubItems[16].Text);
                  txtRefNo.Text = itm.SubItems[0].Text;
                  txtTagNo.Text = itm.SubItems[1].Text;
                  txtProductCode.Text = itm.SubItems[11].Text;
                  txtProductName.Text = itm.SubItems[12].Text;
                  //cboDepartment.Text = itm.SubItems[10].Text;
                  cboDepartment.SelectedValue  = itm.SubItems[10].Text;
                 // cboAssetsUser.SelectedValue = itm.SubItems[9].Text;
                  //txtTotalQty.Text = itm.SubItems[9].Text;
                  txtIssueQty.Text = dblQty.ToString();
                  //txtGroupCode.Text = itm.SubItems[9].Text;
                  txtBrancode.Text = itm.SubItems[13].Text;
                  txtModel.Text = itm.SubItems[14].Text;
                  txtUnit.Text = itm.SubItems[15].Text;
                  GetAssetsUser(itm.SubItems[10].Text);
                  cboAssetsUser.SelectedValue = itm.SubItems[9].Text;
                  //txtSlNo.Text = itm.SubItems[9].Text;
                  List<MaterialReceipt> objmrr = atms.GetTotalQty("Getitemtotalqty", txtProductCode.Text).ToList();
                  foreach (MaterialReceipt mr in objmrr)
                  {
                      txtTotalQty.Text = mr.dblQty.ToString();
                  }
              }
        }
        private bool validationfields()
        {
            if (txtTagNo.Text.ToString() == "")
            {
                txtTagNo.Focus();
                return true;
            }
            if (txtProductCode.Text.ToString() == "")
            {
                txtProductCode.Focus();
                return true;
            }
            if (txtProductName.Text.ToString() == "")
            {
                txtProductName.Focus();
                return true;
            }
            if (txtIssueQty.Text.ToString() == "")
            {
                txtIssueQty.Focus();
                return true;
            }
            if (txtIssueQty.Text.ToString() == "0")
            {
                txtIssueQty.Focus();
                return true;
            }
            if (Convert.ToDouble(txtTotalQty.Text) < 0)
            {
                txtTotalQty.Focus();
                return true;
            }
            if (cboAssetsUser.Text == "Issue")
            {
                if (cboDepartment.Text.ToString() == "Select")
                {
                    return true;
                }
                if (cboAssetsUser.Text.ToString() == "Select")
                {
                    return true;
                }
            }

            return false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
        private AssetsIssue   PopulateVoucherUpdate()
        {
            AssetsIssue objissue = new AssetsIssue();
            
            objissue.IssueNo = txtRefNo.Text;
            objissue.brandCode = txtBrancode.Text;
            //objissue.Groupcode = txtGroupCode.Text;
            objissue.ModelId = txtModel.Text;
            objissue.ProductID = txtProductCode.Text;
            objissue.UnitID = txtUnit.Text;
            objissue.Issudate = dteIssueDate.Text;
            objissue.DepID = cboDepartment.SelectedValue.ToString();
            objissue.AssetsUser = cboAssetsUser.SelectedValue.ToString();
            objissue.intVtype = intVtype;
            objissue.SerialNo = txtSlNo.Text;
            objissue.dblQty = Convert.ToDouble(txtIssueQty.Text);
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objissue.EntryParameter = ep;
            return objissue;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationfields() == true)
            {
                return;
            }
            else
            {
                var strResponse = MessageBox.Show("Do You want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    AssetsIssue objIssue = this.PopulateVoucherUpdate();
                    int strIssueNo = atms.UpdatevoucherMaster(objIssue);
                    if (strIssueNo == 1)
                    {
                        short i = atms.UpdatevoucherTran(objIssue);
                        this.Dispose();
                    }
                    


                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lvwDetails.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvwDetails.SelectedItems[0];
                frmReportViewer frm = new frmReportViewer();
                frm.selector = ViewerSelector.itemmrr;
                frm.selector = ViewerSelector.voucher;
                frm.intVoucherType = intVtype;
                frm.WhereCondition = itm.SubItems[0].Text; ; ;
                frm.ShowDialog();
            }
        }
    }
}
