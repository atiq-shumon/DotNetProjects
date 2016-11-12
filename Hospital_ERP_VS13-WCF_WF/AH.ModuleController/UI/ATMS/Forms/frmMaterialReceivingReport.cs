using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.ATMSSR;
using System.Linq;
using AH.DUtility;
using AH.ModuleController.UI.ATMS.Reports.Viewer;

namespace AH.ModuleController.UI.ATMS.Forms
{
    public partial class frmMaterialReceivingReport : AH.Shared.UI.frmSmartFormStandard
    {
        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();
        public int vouchertype { set; get; }
        public frmMaterialReceivingReport()
        {
            InitializeComponent();
        }

        private void mLaodAgainstRef()
        {
            cboAgainstRefNo.Items.Clear();
            List<MaterialReceipt> objReceipt = atms.GeAgsinstRefNo("LoadMrr", "").ToList();
            foreach(MaterialReceipt mrr in objReceipt)
            {
                cboAgainstRefNo.Items.Add(mrr.MrrNo);
            }

        }

        private void mloadMrr()
        {
            //cboMRRLoad.ValueMember = "MrrNo";
            //cboMRRLoad.DisplayMember = "MrrNo";
            //cboMRRLoad.DataSource = atms.GetMrrNo("MrrNo", "").ToList();

            //cboMRRLoad.ValueMember = "Key";
            //cboMRRLoad.DisplayMember = "Value";
            //cboMRRLoad.DataSource = new BindingSource(atms.GetMrrNo("MrrNo", ""), null);
        }

        private void frmMaterialReceivingReport_Load(object sender, EventArgs e)
        {
            cboSupplier.ValueMember = "Key";
            cboSupplier.DisplayMember = "Value";
            cboSupplier.DataSource = new BindingSource(atms.GetSupplierID("Supplier",""), null);
            mLaodAgainstRef();
            mloadMrr();
        }
        private void Display(string strRefNo)
        {
            List<MaterialReceipt> objReceipt = atms.DisplayDetailsAgainsrRef("Displaydetails", strRefNo).ToList();
            int i;
            int k=0;
            DG.Rows.Clear();
            i = objReceipt.Count();
            DG.Rows.Add(i);
            foreach(MaterialReceipt mrr in objReceipt)
            {
                txtInvoiceNo.Text = mrr.MrrNo;
                txtChallanNo.Text = mrr.ChallanNo.ToString();
                AgainstRefDate.Text = mrr.againstDate.ToString(); 
                dteChallanDate.Text = mrr.ChallanDate.ToString();
                cboSupplier.SelectedValue = mrr.supplierCode.ToString();
                DG.Rows[k].Cells[0].Value = mrr.ProductID.ToString();
                DG.Rows[k].Cells[1].Value = mrr.ProductName .ToString();
                DG.Rows[k].Cells[2].Value = mrr.brandCode.ToString();
                DG.Rows[k].Cells[3].Value = mrr.ModelId.ToString();
                DG.Rows[k].Cells[4].Value = mrr.ModelName.ToString();
                DG.Rows[k].Cells[9].Value = mrr.UnitID.ToString();
                DG.Rows[k].Cells[10].Value = mrr.UnitName.ToString();
                DG.Rows[k].Cells[11].Value = mrr.dblQty.ToString();
                k = k + 1;

            }
        }
        private MaterialReceipt PopulateReceipt()
        {
            MaterialReceipt objMrr = new MaterialReceipt();
            if (txtInvoiceNo.Text != "")
            {
                objMrr.MrrNo = txtInvoiceNo.Text;
            }
            objMrr.mrrdate = dteInvoiceDate.Text;
            objMrr.FormName = "Material Receipt";
            objMrr.supplierCode = cboSupplier.SelectedValue.ToString();
            objMrr.ChallanNo = txtChallanNo.Text;
            objMrr.ChallanDate = dteChallanDate.Text;
            objMrr.agiaintRefNo = cboAgainstRefNo.Text;
            objMrr.againstDate =  dteInvoiceDate.Text;
            objMrr.intVtype = (int)vouchertype;
            objMrr.Notes = txtNotes.Text;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objMrr.EntryParameter = ep;
            return objMrr;
        }
        private bool validationfields()
        {
            if (dteInvoiceDate.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }
        private void cboAgainstRefNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAgainstRefNo.SelectedIndex >= 0 || cboAgainstRefNo.SelectedIndex == -1)
            {
                if (cboAgainstRefNo.Text != " ")
                {
                    Display(cboAgainstRefNo.Text);
                }
            }
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
                    MaterialReceipt objMrr = this.PopulateReceipt();
                    string strRefNo = atms.SaveMaterialReceipt(objMrr);
                    if (strRefNo != "")
                    {
                        string strUnit = "" ,strModelNo = "", strseialNo = "", strBrand="", strDate="",des1 = "", des2 = "", des3 = "";
                        DateTime dtedate;
                        for(int i=0;i<DG.Rows.Count-1 ;i++)
                        {
                            #region description event ..........................................
                            if (DG[2, i].Value != null)
                            {
                                strBrand = DG.Rows[i].Cells[2].Value.ToString();
                            }
                            else
                            {
                                strBrand = "";
                            }
                            if (DG[3, i].Value != null)
                            {
                                strModelNo = DG.Rows[i].Cells[3].Value.ToString();
                            }
                            else
                            {
                                strModelNo = "";
                            }
                            if (DG[5, i].Value != null)
                            {
                                strseialNo = DG.Rows[i].Cells[5].Value.ToString();
                            }
                            else
                            {
                                strseialNo = "";
                            }

                            if (DG[6, i].Value != null)
                            {
                                des1 = DG.Rows[i].Cells[6].Value.ToString();
                            }
                            else
                            {
                                des1 = "";
                            }

                            if (DG[7, i].Value != null)
                            {
                                des2 = DG.Rows[i].Cells[7].Value.ToString();
                            }
                            else
                            {
                                des2 = "";
                            }
                            if (DG[8, i].Value != null)
                            {
                                des3 = DG.Rows[i].Cells[8].Value.ToString();
                            }
                            else
                            {
                                des3 = "";
                            }

                            if (DG[9, i].Value != null)
                            {
                                strUnit = DG.Rows[i].Cells[9].Value.ToString();
                            }
                            else
                            {
                                strUnit = "";
                            }

                          
                            if (DG[12, i].Value != null)
                            {
                                dtedate = Convert.ToDateTime(DG.Rows[i].Cells[12].Value.ToString());
                                strDate = dtedate.ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                strDate = "";
                            }

                            #endregion

                            short k = atms.SaveMaterialReceiptTran(strRefNo, (int)vouchertype, DG.Rows[i].Cells[0].Value.ToString(), strBrand,
                                strModelNo ,strUnit,strseialNo,des1,des2,des3,
                                Convert.ToDouble(DG.Rows[i].Cells[11].Value.ToString()), 0, 0, strDate, objMrr);
                        }
                    }
                    btnNew.PerformClick();
                    dteInvoiceDate.Focus();
                    cboAgainstRefNo.Text = "";
                    DG.Rows.Clear();
                    mLaodAgainstRef();
                }
            }
        }
        private void DisplaymrrDetails(string strRefNo)
        {
            List<MaterialReceipt> objReceipt = atms.DisplayDetaialstoMrr("GetMrrfromId", strRefNo).ToList();
            int i;
            int k = 0;
            DG.Rows.Clear();
            i = objReceipt.Count();
            if (i > 0)
            {
                DG.Rows.Add(i);
                foreach (MaterialReceipt mrr in objReceipt)
                {

                    txtInvoiceNo.Text = mrr.MrrNo;
                    txtChallanNo.Text = mrr.ChallanNo.ToString();
                    dteChallanDate.Text = mrr.ChallanDate.ToString();
                    cboAgainstRefNo.Text = mrr.agiaintRefNo.ToString();
                    AgainstRefDate.Text = mrr.againstDate.ToString();
                    cboSupplier.SelectedValue = mrr.supplierCode.ToString();
                    dteInvoiceDate.Text = mrr.mrrdate;
                    DG.Rows[k].Cells[0].Value = mrr.ProductID.ToString();
                    DG.Rows[k].Cells[1].Value = mrr.ProductName.ToString();
                    DG.Rows[k].Cells[2].Value = mrr.brandCode.ToString();
                    DG.Rows[k].Cells[3].Value = mrr.ModelId.ToString();
                    DG.Rows[k].Cells[4].Value = mrr.ModelName.ToString();

                    DG.Rows[k].Cells[5].Value = mrr.SerialNo.ToString();
                    DG.Rows[k].Cells[6].Value = mrr.Des1;
                    DG.Rows[k].Cells[7].Value = mrr.Des2;
                    DG.Rows[k].Cells[8].Value = mrr.Des3;

                    DG.Rows[k].Cells[9].Value = mrr.UnitID.ToString();
                    DG.Rows[k].Cells[10].Value = mrr.UnitName.ToString();
                    DG.Rows[k].Cells[11].Value = mrr.dblQty.ToString();
                    DG.Rows[k].Cells[12].Value = mrr.WarrentyDate.ToString();
                    DG.Rows[k].Cells[14].Value = mrr.TagNo.ToString();
                    k = k + 1;
                }
            }
        }
        private void cboMRRLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMRRLoad.SelectedIndex >= 0 || cboMRRLoad.SelectedIndex == -1)
            {
                if (cboMRRLoad.Text != " ")
                {
                    cboMRRLoad.Enabled = false;
                    DisplaymrrDetails(cboMRRLoad.Text);  
                }
            }
        }
        private void btnSearch2_Click(object sender, EventArgs e)
        {

            btnPrint.Enabled = true;
            cboMRRLoad.Items.Clear();
            cboMRRLoad.Enabled = true;
            List<MaterialReceipt> oMat = atms.GetMrrNo("MrrNo", "").ToList();
            foreach(MaterialReceipt mrr in oMat)
            {
                cboMRRLoad.Items.Add(mrr.MrrNo);
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
                    MaterialReceipt objMrr = this.PopulateReceipt();
                    int  strRefNo = atms.UpdateMaterialReceipt(objMrr);
                    if (strRefNo ==1)
                    {
                        string strUnit = "", strModelNo = "", strseialNo = "",
                            strBrand = "", strDate = "", des1 = "", des2 = "", des3 = "", strTranID="";
                        DateTime dtedate;
                        for (int i = 0; i < DG.Rows.Count - 1; i++)
                        {
                            #region description event ..........................................
                            if (DG[2, i].Value != null)
                            {
                                strBrand = DG.Rows[i].Cells[2].Value.ToString();
                            }
                            else
                            {
                                strBrand = "";
                            }
                            if (DG[3, i].Value != null)
                            {
                                strModelNo = DG.Rows[i].Cells[3].Value.ToString();
                            }
                            else
                            {
                                strModelNo = "";
                            }
                            if (DG[5, i].Value != null)
                            {
                                strseialNo = DG.Rows[i].Cells[5].Value.ToString();
                            }
                            else
                            {
                                strseialNo = "";
                            }

                            if (DG[6, i].Value != null)
                            {
                                des1 = DG.Rows[i].Cells[6].Value.ToString();
                            }
                            else
                            {
                                des1 = "";
                            }

                            if (DG[7, i].Value != null)
                            {
                                des2 = DG.Rows[i].Cells[7].Value.ToString();
                            }
                            else
                            {
                                des2 = "";
                            }
                            if (DG[8, i].Value != null)
                            {
                                des3 = DG.Rows[i].Cells[8].Value.ToString();
                            }
                            else
                            {
                                des3 = "";
                            }

                            if (DG[9, i].Value != null)
                            {
                                strUnit = DG.Rows[i].Cells[9].Value.ToString();
                            }
                            else
                            {
                                strUnit = "";
                            }


                            if (DG[12, i].Value != "")
                            {
                                dtedate = Convert.ToDateTime(DG.Rows[i].Cells[12].Value.ToString());
                                strDate = dtedate.ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                strDate = "";
                            }
                            if (DG[14, i].Value != null)
                            {
                              strTranID =(DG[14, i].Value).ToString();
                            }
                            else
                            {
                                strTranID = "";
                            }

                            #endregion

                            int  k = atms.UpdateMaterialReceiptTran(txtInvoiceNo.Text.ToString(), strTranID, (int)vouchertype, DG.Rows[i].Cells[0].Value.ToString(), strBrand,
                                strModelNo, strUnit, strseialNo, des1, des2, des3,
                                Convert.ToDouble(DG.Rows[i].Cells[11].Value.ToString()), 0, 0, strDate, objMrr);
                        }
                    }
                    btnNew.PerformClick();
                    dteInvoiceDate.Focus();
                    DG.Rows.Clear();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportViewer frm = new frmReportViewer();
            frm.selector = ViewerSelector.itemmrr;
            frm.intVoucherType = vouchertype;
            frm.WhereCondition = cboMRRLoad.Text;
            frm.ShowDialog();
        }

       
        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmAssetsDetailsInformation frm = new frmAssetsDetailsInformation();
            //frm.ShowDialog(); 
        }
    }
}
