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
    public partial class frmIssue : AH.Shared.UI.frmSmartFormStandard
    {
        public int intVtype { set; get; }
        public string strTagNo { set; get; }
        public string strProductCode { set; get; }
        public string strProductName { set; get; }
        public string strGroupCode { set; get; }
        public string strBrandCode { set; get; }
        public string strUnitCode { set; get; }
        public string strModelCode { set; get; }
        public string strSlCode { set; get; }

        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();
        public frmIssue()
        {
            InitializeComponent();
        }
        private void DepartmentLoad()
        {
            cboDepartment.ValueMember = "Key";
            cboDepartment.DisplayMember = "Value";
            cboDepartment.DataSource = new BindingSource(atms.GetDepartment("HrsDep", ""), null);
        }
        private void GetAssetsUser(string Where)
        {
            cboAssetsUser.ValueMember = "Key";
            cboAssetsUser.DisplayMember = "Value";
            cboAssetsUser.DataSource = new BindingSource(atms.GetAssetsUsertoDep("GetAssetsUsertoDep", Where), null);
        }

        private void frmIssue_Load(object sender, EventArgs e)
        {
            txtTagNo.Text = strTagNo;
            txtProductCode.Text = strProductCode;
            txtProductName.Text = strProductName;
            txtGroupCode.Text = strGroupCode;
            txtModel.Text = strModelCode;
            txtBrancode.Text = strBrandCode;
            txtUnit.Text = strUnitCode;
            txtSlNo.Text = strSlCode;
            txtTagNo.Focus();

            List<MaterialReceipt> objmrr = atms.GetTotalQty("Getitemtotalqty", txtProductCode.Text).ToList();
            foreach(MaterialReceipt mr in objmrr )
            {
                txtTotalQty.Text = mr.dblQty.ToString();
            }
            DepartmentLoad();
           
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedIndex >= 0 || cboDepartment.SelectedIndex == -1)
            {
                if (cboDepartment.Text != " ")
                {
                    GetAssetsUser(cboDepartment.SelectedValue.ToString());
                }
            }
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
            if (Convert.ToDouble(txtTotalQty.Text) < 0 )
            {
                return true;
            }
            if (cboDepartment.Text.ToString() == "Select")
            {
                return true;
            }
            if (cboAssetsUser.Text.ToString() == "Select")
            {
                return true;
            }

            if (Convert.ToDouble(txtIssueQty.Text) > Convert.ToDouble(txtTotalQty.Text))
            {
                MessageBox.Show("No of Qty Cannot be Grater than Total Qnty");
                return true;
            }

            return false;
        }

        private AssetsIssue  PopulateIssue()
        {
            AssetsIssue objissue = new AssetsIssue();

            objissue.brandCode =txtBrancode.Text ;
            objissue.Groupcode = txtGroupCode.Text;
            objissue.ModelId = txtModel.Text;
            objissue.ProductID = txtProductCode.Text;
            objissue.UnitID = txtUnit.Text;
            objissue.Issudate = dteIssueDate.Text;
            objissue.DepID = cboDepartment.SelectedValue.ToString();
            objissue.AssetsUser = cboAssetsUser.SelectedValue.ToString();
            objissue.intVtype = intVtype;
            objissue.FormName = "Issue";
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
                        short i = atms.SaveMaterialIssueTran(strIssueNo, intVtype, strProductCode, strModelCode, strUnitCode,strUnitCode , strSlCode, "", "",
                                                "", Convert.ToDouble(txtIssueQty.Text)*-1, 0, 0, "", objIssue);
                        this.Dispose();
                    }
                    

                }
            }
        }

        private void cboDepartment_KeyUp(object sender, KeyEventArgs e)
        {
            int index;
            string actual;
            string found;
            if ((e.KeyCode == Keys.Back) ||
                    (e.KeyCode == Keys.Left) ||
                    (e.KeyCode == Keys.Right) ||
                    (e.KeyCode == Keys.Up) ||
                    (e.KeyCode == Keys.Down) ||
                    (e.KeyCode == Keys.Delete) ||
                    (e.KeyCode == Keys.PageUp) ||
                    (e.KeyCode == Keys.PageDown) ||
                    (e.KeyCode == Keys.Home) ||
                    (e.KeyCode == Keys.End))
            {
                return;
            }

            // Store the actual text that has been typed.
            actual = this.cboDepartment.Text;

            // Find the first match for the typed value.
            index = this.cboDepartment.FindString(actual);

            // Get the text of the first match.
            if (index > -1)
            {
                found = this.cboDepartment.Items[index].ToString();

                // Select this item from the list.
                this.cboDepartment.SelectedIndex = index;

                // Select the portion of the text that was automatically
                // added so that additional typing replaces it.
                this.cboDepartment.SelectionStart = actual.Length;
                this.cboDepartment.SelectionLength = found.Length;
            }
        }

        private void cboAssetsUser_KeyUp(object sender, KeyEventArgs e)
        {
            int index;
            string actual;
            string found;
            if ((e.KeyCode == Keys.Back) ||
                    (e.KeyCode == Keys.Left) ||
                    (e.KeyCode == Keys.Right) ||
                    (e.KeyCode == Keys.Up) ||
                    (e.KeyCode == Keys.Down) ||
                    (e.KeyCode == Keys.Delete) ||
                    (e.KeyCode == Keys.PageUp) ||
                    (e.KeyCode == Keys.PageDown) ||
                    (e.KeyCode == Keys.Home) ||
                    (e.KeyCode == Keys.End))
            {
                return;
            }

            // Store the actual text that has been typed.
            actual = this.cboAssetsUser.Text;

            // Find the first match for the typed value.
            index = this.cboAssetsUser.FindString(actual);

            // Get the text of the first match.
            if (index > -1)
            {
                found = this.cboAssetsUser.Items[index].ToString();

                // Select this item from the list.
                this.cboDepartment.SelectedIndex = index;

                // Select the portion of the text that was automatically
                // added so that additional typing replaces it.
                this.cboAssetsUser.SelectionStart = actual.Length;
                this.cboAssetsUser.SelectionLength = found.Length;
            }
        }

        private void txtTagNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Return)
            {
                txtProductCode.Focus();
            }
        }

        private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                dteIssueDate.Focus();
            }
        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboDepartment.Focus();
            }
        }

        private void cboDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboAssetsUser.Focus();
            }
        }

        private void cboAssetsUser_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dteIssueDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtProductName.Focus();
            }
        }
    }
}
