using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.ModuleController.ATMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.ATMS.Forms
{
    public partial class frmVoucher : AH.Shared.UI.frmSmartFormStandard
    {
        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();
        public int intVtype { set; get; }
        public string strTagNo { set; get; }
        public string strProductCode { set; get; }
        public string strProductName { set; get; }
        public string strGroupCode { set; get; }
        public string strBrandCode { set; get; }
        public string strUnitCode { set; get; }
        public string strModelCode { set; get; }
        public string strSlCode { set; get; }
        public frmVoucher()
        {
            InitializeComponent();
        }

        private AssetsIssue PopulateIssue()
        {
            AssetsIssue objissue = new AssetsIssue();

            objissue.brandCode = txtBrancode.Text;
            objissue.Groupcode = txtGroupCode.Text;
            objissue.ModelId = txtModel.Text;
            objissue.ProductID = txtProductCode.Text;
            objissue.UnitID = txtUnit.Text;
            objissue.Issudate = dteIssueDate.Text;
            objissue.intVtype = intVtype;
            //objissue.DepID = cboDepartment.SelectedValue.ToString();
            //objissue.AssetsUser = cboAssetsUser.SelectedValue.ToString();
        
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objissue.EntryParameter = ep;
            return objissue;
        }

        private bool validationfields()
        {
            if (txtTagNo.Text.ToString() == "")
            {
                return true;
            }
            if (txtProductCode.Text.ToString() == "")
            {
                return true;
            }
            if (txtProductName.Text.ToString() == "")
            {
                return true;
            }
            if (txtIssueQty.Text.ToString() == "")
            {
                return true;
            }
            if (txtIssueQty.Text.ToString() == "0")
            {
                return true;
            }
            if (Convert.ToDouble(txtTotalQty.Text) < 0)
            {
                return true;
            }
            //if (cboDepartment.Text.ToString() == "Select")
            //{
            //    return true;
            //}
            //if (cboAssetsUser.Text.ToString() == "Select")
            //{
            //    return true;
            //}

            return false;
        }

        private static string Getvoucher(int  intvtype)
        {
            string strVoucher="";
            if (intvtype==31 )
            {
                strVoucher= "Material Receiving Report";
            }
            else if(intvtype==32 )
            {
                strVoucher= "Sales Return";
            }
            else if(intvtype==33 )
            {
                strVoucher= "Material Issue";
            }
             else if(intvtype==34 )
            {
                strVoucher= "Material Damage";
            }
            return strVoucher;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationfields() == true)
            {
                MessageBox.Show("Empty field");
            }
            else
            {
                var strResponse = MessageBox.Show("Do You want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    AssetsIssue objIssue = this.PopulateIssue();
                    string strIssueNo = atms.SaveMatIssue(objIssue);
                    if (strIssueNo != "null")
                    {
                        short i = atms.SaveMaterialIssueTran(strIssueNo, intVtype, strProductCode, strModelCode, strUnitCode, strUnitCode, strSlCode, "", "",
                                                "", Convert.ToDouble(txtIssueQty.Text) * -1, 0, 0, "", objIssue);
                        this.Dispose();
                    }


                }
            }
        }

        private void frmVoucher_Load(object sender, EventArgs e)
        {
            frmLabel.Text = Getvoucher(intVtype);
            txtTagNo.Text = strTagNo;
            txtProductCode.Text = strProductCode;
            txtProductName.Text = strProductName;
            txtGroupCode.Text = strGroupCode;
            txtModel.Text = strModelCode;
            txtBrancode.Text = strBrandCode;
            txtUnit.Text = strUnitCode;
            txtSlNo.Text = strSlCode;

            List<MaterialReceipt> objmrr = atms.GetTotalQty("Getitemtotalqty", txtProductCode.Text).ToList();
            foreach (MaterialReceipt mr in objmrr)
            {
                txtTotalQty.Text = mr.dblQty.ToString();
            }
        }

        private void txtTagNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtProductCode.Focus();
            }
        }

        private void dteIssueDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtProductName.Focus();
            }
        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtIssueQty.Focus();
            }
        }

        private void txtIssueQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSave.Focus();
            }
        }
    }
}
