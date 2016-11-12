using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.ModuleController.FNBSR;
using AH.DUtility;
using System.IO;
using AH.ModuleController.UI.FNB.Reports.Viewer;
using AH.Shared.UI;


namespace AH.ModuleController.UI.FNB.Forms
{
    public partial class frmVisitors : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        List<Visitors> objVs;
        List<FoodMaster> objfood;
        List<FoodMenuItemSetup> objfi;
        private string strFid = "", strVo = "",Vno="",strMenuId="";
        List <string  >dic;
        public frmVisitors()
        {
            InitializeComponent();
        }

        
        private DataGridViewTextBoxColumn Create_Grid_Column(string pname, string htext, int cwidth, Boolean true_false, DataGridViewContentAlignment Align,
                                                           Boolean read_only)
        {
            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.DataPropertyName = pname;
            col0.HeaderText = htext;
            col0.DefaultCellStyle.ForeColor = Color.Black;
            col0.DefaultCellStyle.BackColor = Color.White;
            col0.Visible = true_false;
            col0.DefaultCellStyle.Alignment = Align;
            col0.Width = cwidth;
            col0.ReadOnly = read_only;
            return col0;
        }

        private DataGridViewCheckBoxColumn CreateChkBxGrd(string pname, string htext, int cwidth, Boolean visibility, DataGridViewContentAlignment Algin, bool IsReadOnly, bool Isfrozen, string columnType)
        {
            DataGridViewCheckBoxColumn Ckbox = new DataGridViewCheckBoxColumn();
            Ckbox.DataPropertyName = pname;
            Ckbox.HeaderText = htext;
            Ckbox.Name = pname;
            Ckbox.DefaultCellStyle.ForeColor = Color.Black;
            Ckbox.DefaultCellStyle.BackColor = Color.White;
            Ckbox.Visible = visibility;
            Ckbox.DefaultCellStyle.Alignment = Algin;
            Ckbox.Width = cwidth - 1;
            Ckbox.ReadOnly = IsReadOnly;
            Ckbox.Frozen = Isfrozen;
            return Ckbox;
        }

        public DataGridViewButtonColumn Create_Grid_Column_button(string pname, string htext, string btext, int cwidth, Boolean true_false,
           DataGridViewContentAlignment Align, Boolean read_only)
        {
            DataGridViewButtonColumn col0 = new DataGridViewButtonColumn();
            col0.DataPropertyName = pname;
            col0.HeaderText = htext;
            col0.Text = btext;
            col0.DefaultCellStyle.ForeColor = Color.Red;
            col0.DefaultCellStyle.BackColor = Color.White;
            col0.Visible = true_false;
            col0.DefaultCellStyle.Alignment = Align;
            col0.Width = cwidth;
            col0.ReadOnly = read_only;
            return col0;
        }
        #region "Comment"

        //private void SearchListView(IEnumerable<FoodMaster> tests, string searchString = "")
        //{
        //    IEnumerable<FoodMaster> query;
        //    if (!(searchString.Length > 0))
        //    {
        //        query = tests;
        //    }
        //    else
        //    {
        //        query = (from test in tests
        //                 where test.CatID.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
        //                 select test);

        //    }
        //    lvwCategory.Items.Clear();
        //    foreach (FoodMaster objFm in query)
        //    {
        //        ListViewItem itm = new ListViewItem(objFm.FoodID);
        //        itm.SubItems.Add(objFm.FoodName);
        //        itm.SubItems.Add(objFm.CatID);
        //        itm.SubItems.Add(objFm.UnitId);
        //        itm.SubItems.Add(objFm.Remarks);
        //        itm.SubItems.Add(objFm.IsNormal);
        //        itm.SubItems.Add(objFm.IsDiabetic);
        //        itm.SubItems.Add(objFm.IsHighprotein);
        //        itm.SubItems.Add(objFm.IsLowProtein);
        //        itm.SubItems.Add(objFm.IsRenal);
        //        itm.SubItems.Add(objFm.IsHighFat);
        //        itm.SubItems.Add(objFm.IsLowFat);
        //        itm.SubItems.Add(objFm.Price.ToString());
        //        lvwCategory.Items.Add(itm);
        //    }
        //}

        //private void grid_column()
        //{
        //    DGUP.Columns.Add(CreateChkBxGrd(" ", " ", 40, true, DataGridViewContentAlignment.TopCenter, false, false, "checkbox"));
        //    DGUP.Columns.Add(Create_Grid_Column("Item Code", "Item Code", 300, false, DataGridViewContentAlignment.TopLeft, true));
        //    DGUP.Columns.Add(Create_Grid_Column("Item Name", "Item Name", 320, true, DataGridViewContentAlignment.TopLeft, true));
        //    DGUP.Columns.Add(Create_Grid_Column("Item Qty", "Item Qty", 80, true, DataGridViewContentAlignment.TopLeft, false));
        //    DGUP.Columns.Add(Create_Grid_Column("Item Rate", "Item Rate", 80, true, DataGridViewContentAlignment.TopLeft, true));
        //    DGUP.Columns.Add(Create_Grid_Column("Dis.", "Dis.", 80, true, DataGridViewContentAlignment.TopLeft, false));
        //    DGUP.Columns.Add(Create_Grid_Column("Net Amount", "Net Amount", 150, true, DataGridViewContentAlignment.TopLeft, true));
        //}
        private void cboMenuId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboMenuId.Text != "--Select--")
            //{
            //    List<FoodMenuItemSetup> objFIS = fnbs.GetVisitorsMenuItem(cboMenuId.SelectedValue.ToString()).ToList();
            //    if (objFIS.Count > 0)
            //    {
            //        int intRow = objFIS.Count;
            //        DGUP.Rows.Add(intRow);
            //        int i = 0;
            //        foreach (FoodMenuItemSetup fs in objFIS)
            //        {
            //            DGUP.Rows[i].Cells[1].Value = fs.FoodItemID;
            //            DGUP.Rows[i].Cells[2].Value = fs.FoodItemName;
            //            DGUP.Rows[i].Cells[4].Value = fs.ItemRate;
            //            //DG.Rows[i].Cells[4].Value = fs.ItemRate * Convert.ToDouble(DG.Rows[i].Cells[3].Value);
            //            if (i % 2 == 0)
            //            {
            //                DGUP.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
            //            }
            //            else
            //            {
            //                DGUP.Rows[i].DefaultCellStyle.BackColor = Color.Beige;
            //            }
            //            i = i + 1;

            //        }

            //    }

            //}
        }


        private void DG_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //DGUP.Rows[e.RowIndex].Cells[6].Value = (Convert.ToDouble(DGUP.Rows[e.RowIndex].Cells[3].Value) * Convert.ToDouble(DGUP.Rows[e.RowIndex].Cells[4].Value)) - Convert.ToDouble(DGUP.Rows[e.RowIndex].Cells[5].Value);
            //CalculateTotal();
        }



        private void CalculateTotal()
        {
            //double dblNetTotal = 0;
            //for (int i = 0; i < DGUP.Rows.Count; i++)
            //{
            //    dblNetTotal = dblNetTotal + Convert.ToDouble(DGUP.Rows[i].Cells[5].Value);
            //}

            //txtNetTotal.Text = dblNetTotal.ToString();
            //NetTotal(txtDiscount.Text, txtVat.Text, txtNetTotal.Text);

        }

        private void btnright_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < DGUP.RowCount; i++)
            //{
            //    if (Convert.ToBoolean(DGUP.Rows[i].Cells[0].Value) == true)
            //    {
            //        if (DGUP[0, i].Value != null)
            //        {
            //            if (DGUP[3, i].Value == null)
            //            {
            //                DGUP[3, i].Value = "0";
            //            }

            //            if (DGUP[5, i].Value == null)
            //            {
            //                DGUP[5, i].Value = "0";
            //            }
            //            if (Convert.ToDouble(DGUP[3, i].Value) > 0)
            //            {
            //                mAdditem(DGUP[1, i].Value.ToString(), DGUP[2, i].Value.ToString(), Convert.ToDouble(DGUP[3, i].Value.ToString()),
            //                               Convert.ToDouble(DGUP[4, i].Value.ToString()), Convert.ToDouble(DGUP[5, i].Value.ToString()),
            //                               Convert.ToDouble(DGUP[6, i].Value.ToString()));
            //            }


            //        }
            //    }
            //}
        }
        #endregion
        private void grid_columnDown()
        {
            DGdown.Columns.Add(Create_Grid_Column("Item Code", "Item Code", 300, false, DataGridViewContentAlignment.TopLeft, true));
            DGdown.Columns.Add(Create_Grid_Column("Item Name", "Item Name", 285, true, DataGridViewContentAlignment.TopLeft, true));
            DGdown.Columns.Add(Create_Grid_Column("Item Qty", "Item Qty", 83, true, DataGridViewContentAlignment.TopLeft, false));
            DGdown.Columns.Add(Create_Grid_Column("Item Rate", "Item Rate", 80, true, DataGridViewContentAlignment.TopLeft, true));
            DGdown.Columns.Add(Create_Grid_Column("Dis.", "Dis.", 50, true, DataGridViewContentAlignment.TopLeft, false));
            DGdown.Columns.Add(Create_Grid_Column("Net Amount", "Net Amount", 110, true, DataGridViewContentAlignment.TopLeft, false));
            DGdown.Columns.Add(Create_Grid_Column_button("Del", "Del", "Del", 40, true, DataGridViewContentAlignment.TopCenter, true));
            DGdown.Columns.Add(Create_Grid_Column("SetmenuID", "SetmenuID", 110, false, DataGridViewContentAlignment.TopLeft, false));
            DGdown.Columns.Add(Create_Grid_Column("Cls. Qnty.", "Cls Qnty.", 80, true, DataGridViewContentAlignment.TopLeft, true));

        }

        private void frmVisitors_Load(object sender, EventArgs e)
        {
            mLoadCategoery();
            grid_columnDown();
            LoadListViewVisitors();
            LoadListViewFood("0");
            
        }

        private void mLoadCategoery()
        {
            List<FoodCategory> objcat = fnbs.LoadFoodCategory().ToList();
            foreach(FoodCategory cat in objcat)
            {
                ListViewItem lvi = new ListViewItem(cat.FoodID);
                lvi.SubItems.Add(cat.FoodcatName);
                lvwCategory.Items.Add(lvi);
            }

        }

        private void LoadListViewFood(string where)
        {

            lvwDisplay.Items.Clear();
            mDisplayImage();
            int k = 0;
         
            objfood = fnbs.LoadFoodItemFromCat(where).ToList();
            if (objfood.Count > 0)
            {
                foreach (FoodMaster objFm in objfood)
                {
                    ListViewItem itm = new ListViewItem(objFm.FoodID + "~" + objFm.FoodName);
                    itm.SubItems.Add(objFm.FoodID.ToString());
                    itm.SubItems.Add(objFm.FoodName.ToString());
                    itm.ImageIndex = 0;
                    itm.SubItems.Add(objFm.Price.ToString());
                    if (listView1.Items.Count > 0)
                    {
                        ListViewItem itm1 = new ListViewItem();
                        for (k=0;k< listView1.Items.Count ;k++ )
                        {
                            
                           int i  = Convert.ToInt32(listView1.Items[k].Text);
                           string name1 = listView1.Items[k].SubItems[1].Text.ToString();
                           if (name1 == objFm.FoodID + ".JPEG")
                           {
                               lvwDisplay.LargeImageList = imageList1;
                               itm.ImageIndex = i;
                           }

                        }
                    }
                    lvwDisplay.Items.Add(itm);
                }
            }
        }

        private string GetImageName(ImageList imglist, int index)
        {
            return imglist.Images.Keys[index].ToString();
        }

        private void mDisplayImage()
        {

            DirectoryInfo dir = new DirectoryInfo(Utility.FoodPhotoPath);
            int i = 1;
            listView1.Items.Clear();
            imageList1.Images.Clear();

            imageList1.Images.Add(imageList2.Images[0]);

            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {

                    this.imageList1.Images.Add(Image.FromFile(file.FullName));
                    string last = file.FullName.Substring(file.FullName.LastIndexOf('\\') + 1);
                    ListViewItem itm = new ListViewItem(i.ToString());
                    itm.SubItems.Add(last);
                    listView1.Items.Add(itm);
                    i = i + 1;
                }
                catch
                {
                    Console.WriteLine("This is not an image file");

                }

            }
        }


        private void LoadListViewVisitors()
        {
            lvwVisitors.Items.Clear();
            objVs = fnbs.GetVisitors("").ToList();
            if (objVs.Count > 0)
            {
                foreach (Visitors vs in objVs)
                {
                    ListViewItem itm = new ListViewItem(vs.InvoiceNo);
                    itm.SubItems.Add(vs.VName);
                    lvwVisitors.Items.Add(itm);
                }
            }
        }


        private void mAdditem(string strItemsCode, string strItemsName, double dblQty, double dblRate, double dblDis, double dblNetAmount)
        {
            int selRaw;
            double dblTotal = 0;
            string strDown = "";
            Boolean blngCheck = false;
            for (int j = 0; j < DGdown.RowCount; j++)
            {
                if (DGdown[0, j].Value != null)
                {
                    strDown = DGdown[0, j].Value.ToString();
                }
                if (strItemsCode == strDown.ToString())
                {
                    DGdown[2, j].Value = Convert.ToDouble(DGdown[2, j].Value.ToString()) + 1;
                    DGdown[5, j].Value = Math.Round(Convert.ToDouble(DGdown[2, j].Value) * Convert.ToDouble(DGdown[3, j].Value),2);

                    blngCheck = true;
                }
            }
            if (blngCheck == false)
            {
                DGdown.AllowUserToAddRows = true;
                selRaw = Convert.ToInt16(DGdown.RowCount.ToString());
                selRaw = selRaw - 1;
                DGdown.Rows.Add(1);

                for (int i = 1; i < DGdown.Rows.Count; i++)
                {
                    DGdown[0, selRaw].Value = strItemsCode.ToString();
                    DGdown[1, selRaw].Value = strItemsName.ToString();
                    DGdown[2, selRaw].Value = dblQty;
                    DGdown[3, selRaw].Value = dblRate;
                    DGdown[4, selRaw].Value = dblDis;
                    DGdown[5, selRaw].Value = dblNetAmount;
                    if (radSetMenu.Checked == true)
                    {
                        DGdown[7, selRaw].Value = strItemsCode.ToString();
                    }
                    else
                    {
                        DGdown[7, selRaw].Value = "";
                    }

                    List<Inventory> objInvCls = fnbs.GetClosingQty(strItemsCode.ToString()).ToList();
                    if (objInvCls.Count > 0)
                    {
                        foreach (Inventory invCls in objInvCls)
                        {
                            if (invCls.dblClosingQty > 0)
                            {
                                DGdown[8, selRaw].Value = invCls.dblClosingQty;
                            }
                            else
                            {
                                DGdown[8, selRaw].Value = 0;
                            }
                        }
                    }



                    dblTotal = dblTotal + dblNetAmount;
                    if (i % 2 == 0)
                    {
                        DGdown.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                    }
                    else
                    {
                        DGdown.Rows[i].DefaultCellStyle.BackColor = Color.Beige;
                    }
                }
               
                DGdown.AllowUserToAddRows = false;
            }
            CalculateDownsTotal();
            NetTotal(txtDiscount.Text, txtVat.Text, txtNetTotal.Text);

        }

        private void CalculateDownsTotal()
        {
            double dblDNetTotal = 0;
            for (int i = 0; i < DGdown.Rows.Count; i++)
            {
                dblDNetTotal = dblDNetTotal + Convert.ToDouble(DGdown.Rows[i].Cells[5].Value);
            }

            txtNetTotal.Text = dblDNetTotal.ToString();
            NetTotal(txtDiscount.Text, txtVat.Text, txtNetTotal.Text);
        }

        private void DGdown_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            long  intTotlal = 0;
            if (e.ColumnIndex == 6)
            {
                int selRowIndex = e.RowIndex;

                if (e.RowIndex != -1)
                {

                    if (DGdown.Rows[e.RowIndex].Cells[1].Value != null)
                    {
                        DGdown.Rows.RemoveAt(selRowIndex);
                        intTotlal = Convert.ToInt64(txtNetTotal.Text) - 1;
                        CalculateDownsTotal();
                    }
                    else
                    {
                        CalculateDownsTotal();
                    }
                }
            }
        }
        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "txtVisitorsName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            if (txtNetPaid.Text =="0")
            {
                MessageBox.Show("Amount Cannot be Empty");
                return false;
            }
            if (txtNetPaid.Text == "")
            {
                MessageBox.Show("Amount Cannot be Empty");
                return false;
            }

            for (int i = 0; i < DGdown.Rows.Count ; i++ )
            {
                if ((DGdown.Rows[i].Cells[8].Value) == null )
                {
                    MessageBox.Show("Stock is Not Available of "+ (DGdown.Rows[i].Cells[1].Value));
                    return false;

                }
            }




                return true;
        }

        private Visitors PopulateVisitors(OPDPayment payment,string setMenu="",string Vo="",string strInvNo="",string purposeID="")
        {
            Visitors vs = new Visitors();
            vs.InvoiceNo = strInvNo;
            //vs.SetMenuID = cboMenuId.SelectedValue.ToString();
            vs.SetMenuID = setMenu;
            if (txtEmpID.Text != "")
            {
                vs.VName = txtEmpID.Text.ToString();
            }
            else
            {
                vs.VName = "NONE";
            }
            vs.TransNo = "No";
            vs.DisType = "No";
            vs.DisRef = "No";
            vs.DisAuthority = "No";
            if (txtDiscount.Text != "")
            {
                vs.Discount = Convert.ToDouble(txtDiscount.Text);
            }
            else
            {
                vs.Discount = 0;
            }
            if (txtVat.Text != "")
            {
                vs.Vat = txtVat.Text;
            }
            else
            {
                vs.Vat = "0";
            }
            //vs.NetPaid = Math.Round(Convert.ToDouble(txtNetPaid.Text),2);
            vs.NetPaid = Math.Round(Convert.ToDouble((payment.NetAmount)),2);
            vs.PaymentString = payment.PaymentString;
            vs.VisOrders = Vo;
            vs.PurposeID = purposeID;
            

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            vs.EntryParameter = ep;
            return vs;
        }

        #region "Save"
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                CalculateDownsTotal();
                string label = "Visitors Order";
                string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.FNBCollection);
                string patNo = "0";
                string patName = "0";
                string department = "0";
                string departmentUnit = "0";
                string reffDepartment = "0";
                string departmentReffUnit = "0";
                decimal departmentAmount = 0;
                decimal reffDepartmentAmount = 0;
                string amount = txtNetPaid.Text;
                string advance = "0";
                string vat = "15";
                string discount = "0";
                string discountBy = "0";
                string paymentType = "0";
                DateTime updateDate = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));

                frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, amount, advance, vat.ToString(),
                                                discount, discountBy, department, reffDepartment, departmentUnit, departmentReffUnit,
                                                departmentAmount, reffDepartmentAmount, updateDate, paymentType, 0, true);
                frm.onSaveButtonClicked = new frmPayment.SaveButtonClick(PaymentData);
                frm.ShowDialog();
                LoadListViewVisitors();

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



        #endregion
        #region "Payment"
        private object PaymentObject(AH.Shared.MODEL.OPDPayment payment)
        {
            OPDPayment paymentObject = new OPDPayment();
            txtDiscount.Text = payment.Discount.ToString();
            txtNetPaid.Text = payment.NetAmount.ToString();
            txtVat.Text = payment.VAT.ToString();
            paymentObject.Advance = 0;
            //paymentObject.Amount = Convert.ToDecimal(txtNetPaid.Text);
            paymentObject.Amount = Convert.ToDecimal(payment.NetAmount);

            paymentObject.CompanyID = Utility.CompanyID;
            paymentObject.ConsultantFee = 0;
            paymentObject.Department = "";
            paymentObject.DepartmentUnit = "";
            paymentObject.DeptAmount = 0;
            paymentObject.Discount = payment.Discount;
            paymentObject.EntryBy = Utility.UserId;
            paymentObject.EntryDate = DateTime.Now;
            paymentObject.EntryName = Utility.UserId;
            paymentObject.HCN = "0124";
            paymentObject.LocationID = Utility.LocationID;
            paymentObject.MachineID = Utility.MachineID;
            paymentObject.NetAmount = Convert.ToDecimal(payment.NetAmount); ;
            paymentObject.PaymentDate = DateTime.Now;
            paymentObject.PaymentType = "I";
            paymentObject.PreviousDue = 0;
            paymentObject.PurposeID = "01";
            paymentObject.PurposeTitle = "Test";
            paymentObject.ReffDept = "";
            paymentObject.ReffDeptAmount = 0;
            paymentObject.ReffDeptUnit = "";
            paymentObject.RefferedFee = 0;
            paymentObject.RegistrationNo = "0124";
            paymentObject.Staff = "012";
            paymentObject.TransactionNo = "012";
            paymentObject.VAT = payment.VAT;
            paymentObject.PaymentString = payment.PaymentString;
            return paymentObject;
        }
        private void PaymentData(AH.Shared.MODEL.OPDPayment payment)
        {

            try
            {
                string callName = "";
                //if (radCategory.Checked ==true)
                //{
                //    callName = "Food";
                //}
                strVo = "";
                string strPuID= Utility.GetPurposeCode(Utility.PurposeCode.FNBCollection);
                double dblQnty = 0, dblRate = 0, dblDiscount = 0, dblTotal = 0;
                 for (int k = 0; k < DGdown.Rows.Count; k++)
                    {
                       // Visitors Vsc = this.PopulateVisitors(strFid);
                        
                        if (DGdown.Rows[k].Cells[0].Value != null)
                        {
                            strFid = DGdown.Rows[k].Cells[0].Value.ToString();
                        }

                        if (DGdown.Rows[k].Cells[7].Value != null)
                        {
                            strMenuId = DGdown.Rows[k].Cells[7].Value.ToString();
                        }

                        if (DGdown.Rows[k].Cells[2].Value != null)
                        {
                            dblQnty = Convert.ToDouble(DGdown.Rows[k].Cells[2].Value.ToString());
                        }
                        if (DGdown.Rows[k].Cells[3].Value != null)
                        {
                            dblRate = Convert.ToDouble(DGdown.Rows[k].Cells[3].Value.ToString());
                        }
                        if (DGdown.Rows[k].Cells[4].Value != null)
                        {
                            dblDiscount = Convert.ToDouble(DGdown.Rows[k].Cells[4].Value.ToString());
                        }
                        if (DGdown.Rows[k].Cells[5].Value != null)
                        {
                            dblTotal = Convert.ToDouble(DGdown.Rows[k].Cells[5].Value.ToString());
                        }

                        if (strMenuId == "")
                        {
                            strVo += Vno + "," + "" + "," + strFid + "," + dblQnty + "," + dblRate + "," + dblDiscount + "," + dblTotal;
                        }
                        else
                        {
                            strVo += Vno + "," + strFid + "," + "" + "," + dblQnty + "," + dblRate + "," + dblDiscount + "," + dblTotal;
                        }

                        
                        //if (radCategory.Checked==  true)
                        //{
                        //    strVo += Vno + "," + "" + "," + strFid + "," + dblQnty + "," + dblRate + "," + dblDiscount + "," + dblTotal;
                        //}
                        //else
                        //{
                        //    strVo += Vno + "," + strFid + "," + "" + "," + dblQnty + "," + dblRate + "," + dblDiscount + "," + dblTotal;
                        //}
                        strVo += ";";
                 }


                    
                 

                Visitors Vo = this.PopulateVisitors((OPDPayment)PaymentObject(payment),strFid,strVo,"",strPuID);
                string  i = fnbs.InsertVisitorsOrderTran(Vo);

                frmReportViewer frmV = new frmReportViewer();
                frmV.selector = ViewerSelector.visitortSlip;
                frmV.Where = i;
                frmV.where1 = txtEmpName.Text;
                frmV.CallName = callName;
                frmV.ShowDialog();
                payment.PaymentString = "";
                DGdown.Rows.Clear();
                txtInvoiceNo.Text = "";
                txtVisitorsName.Text = "";
                txtVat.Text = "";
                txtDiscount.Text = "";
                txtNetPaid.Text = "";
                txtNetTotal.Text = "";
                txtEmpID.Text = "";
                txtEmpName.Text = "";
                txtVisitorsName.Text = "None";
                strVo = "";
                txtEmpID.Focus();
                //lvwCategory.Focus();

            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //printMR(txtMoneyReceiptNo.Text);
            btnNew.PerformClick();
        }
        #endregion
        #region "Keypress/Clik/Changed"
        private void txtVisitorsName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                lvwCategory.Focus();
            }
        }
        private void cboMenuId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                //DGUP.Focus();
            }
        }
        private void DGdown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtDiscount.Focus();
            }
        }
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtVat.Focus();
            }
        }
        private void txtVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtNetPaid.Focus();
            }
        }
        private void txtNetPaid_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            NetTotal(txtDiscount.Text, txtVat.Text, txtNetTotal.Text);
        }
        private void NetTotal(string strDiscount, string strVat, string strNetTotal)
        {

            double dblTotal = 0;
            double dblDiscount1 = 0, dblVat1 = 0, dblNetTotal1 = 0;

            if (strDiscount == "")
            {
                strDiscount = "0";
            }
            else
            {
                dblDiscount1 = Convert.ToDouble(strDiscount);
            }

            if (strVat == "")
            {
                strVat = "0";
            }
            else
            {
                dblVat1 = Convert.ToDouble(strVat);
            }

            if (strNetTotal != "")
            {
                dblNetTotal1 = Convert.ToDouble(strNetTotal);
            }
            else
            {
                dblNetTotal1 = Convert.ToDouble(strNetTotal);
            }


            dblTotal = dblNetTotal1 - dblDiscount1;
            txtNetPaid.Text = (dblTotal + (dblTotal * dblVat1) / 100).ToString();

        }
        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            NetTotal(txtDiscount.Text, txtVat.Text, txtNetTotal.Text);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            radCategory.Checked = true;
            txtVisitorsName.Text = "None";
        }
        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    if (ValidateFields() == false)
        //    {
        //        return;
        //    }
        //    double dblQnty = 0, dblRate = 0, dblDiscount = 0, dblTotal = 0;
        //    var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (strResponse == DialogResult.Yes)
        //    {

        //        Visitors vs = this.PopulateVisitors();
        //        int Vno = fnbs.UpdateVisitorsMaster(txtInvoiceNo.Text, vs);
        //        if (Vno != 0)
        //        {
        //            string strFid = "";
        //            for (int k = 0; k < DGdown.Rows.Count; k++)
        //            {
        //                Visitors Vsc = this.PopulateVisitors(strFid);
        //                if (DGdown.Rows[k].Cells[0].Value != null)
        //                {
        //                    strFid = DGdown.Rows[k].Cells[0].Value.ToString();
        //                }
        //                if (DGdown.Rows[k].Cells[2].Value != null)
        //                {
        //                    dblQnty = Convert.ToDouble(DGdown.Rows[k].Cells[2].Value.ToString());
        //                }
        //                if (DGdown.Rows[k].Cells[3].Value != null)
        //                {
        //                    dblRate = Convert.ToDouble(DGdown.Rows[k].Cells[3].Value.ToString());
        //                }
        //                if (DGdown.Rows[k].Cells[4].Value != null)
        //                {
        //                    dblDiscount = Convert.ToDouble(DGdown.Rows[k].Cells[4].Value.ToString());
        //                }
        //                if (DGdown.Rows[k].Cells[5].Value != null)
        //                {
        //                    dblTotal = Convert.ToDouble(DGdown.Rows[k].Cells[5].Value.ToString());
        //                }

        //                short i = fnbs.InsertVisitorsTran(txtInvoiceNo.Text, strFid, dblQnty, dblRate, dblDiscount, dblTotal, Vsc);
        //            }
        //        }
        //        LoadListViewVisitors();
        //        DGdown.Rows.Clear();
        //        txtInvoiceNo.Text = "";
        //        txtVisitorsName.Text = "";
        //        txtVat.Text = "";
        //        txtDiscount.Text = "";
        //        txtNetPaid.Text = "";
        //        txtNetTotal.Text = "";
        //        txtVisitorsName.Focus();

        //    }

        //}
   
        private void radSetMenu_CheckedChanged(object sender, EventArgs e)
        {
            lvwCategory.Items.Clear();
            lvwDisplay.Items.Clear();
            LoadSetmenu("All");
        }
        private void LoadSetmenu(string CallName, string where="")
        {
             objfi = fnbs.GetFoodMenuItemSetupFromMenuID(CallName, where).ToList();
            foreach(FoodMenuItemSetup Fm in objfi)
            {
                ListViewItem itm = new ListViewItem(Fm.FoodMenuID + "~" + Fm.FoodMenuName);
                itm.ImageIndex = 0;
                itm.SubItems.Add(Fm.FoodMenuID.ToString());
                itm.SubItems.Add(Fm.FoodMenuName.ToString());
                itm.SubItems.Add(Fm.ItemRate.ToString());
                lvwDisplay.Items.Add(itm);
            }

        }
        private void lvwCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwCategory.SelectedItems.Count > 0)
                {
                    ListViewItem itm = lvwCategory.SelectedItems[0];
                    LoadListViewFood(itm.SubItems[0].Text);
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
        private void radCategory_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                lvwCategory.Items.Clear();
                lvwDisplay.Items.Clear();
                mLoadCategoery();
                LoadListViewFood("0");
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
        private void DGdown_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DGdown.Rows[e.RowIndex].Cells[5].Value = (Convert.ToDouble(DGdown.Rows[e.RowIndex].Cells[2].Value) * Convert.ToDouble(DGdown.Rows[e.RowIndex].Cells[3].Value)) - Convert.ToDouble(DGdown.Rows[e.RowIndex].Cells[4].Value);
            CalculateDownsTotal();
        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            long result;
            int intCheck;
            try
            {
                if (long.TryParse(txtSearch.Text, out result))
                {
                    intCheck = 0;
                }
                else
                {
                    intCheck = 1;
                }

                if (radCategory.Checked == true)
                {
                    SearchListView(objfood, intCheck, txtSearch.Text);
                }
                else
                {
                    SearchListViewMenu(objfi, intCheck, txtSearch.Text);
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
        private void SearchListView(IEnumerable<FoodMaster> tests,int intcheck, string searchString = "")
        {
            int k;
            try
            {
                IEnumerable<FoodMaster> query;
                if (tests != null)
                {
                    if (intcheck == 1)
                    {
                        query = (from test in tests
                                 where test.FoodName.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                                 select test);
                    }
                    else
                    {
                        query = (from test in tests
                                 where test.FoodID.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                                 select test);
                    }
                    mDisplayImage();

                    lvwDisplay.Items.Clear();
                    foreach (FoodMaster objFm in query)
                    {
                        ListViewItem itm = new ListViewItem(objFm.FoodID + "~" + objFm.FoodName);
                        //itm.ImageIndex = 1;
                        itm.ImageIndex = 0;
                        if (listView1.Items.Count > 0)
                        {
                            ListViewItem itm1 = new ListViewItem();
                            for (k = 0; k < listView1.Items.Count; k++)
                            {

                                int i = Convert.ToInt32(listView1.Items[k].Text);
                                string name1 = listView1.Items[k].SubItems[1].Text.ToString();
                                if (name1 == objFm.FoodID + ".JPEG")
                                {
                                    lvwDisplay.LargeImageList = imageList1;
                                    itm.ImageIndex = i;
                                }

                            }
                        }


                        lvwDisplay.Items.Add(itm);
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
        private void SearchListViewMenu(IEnumerable<FoodMenuItemSetup> tests, int intcheck, string searchString = "")
        {
            IEnumerable<FoodMenuItemSetup> query;
            try
            {
                if (intcheck == 1)
                {
                    query = (from test in tests
                             where test.FoodMenuName.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                             select test);
                }
                else
                {
                    query = (from test in tests
                             where test.FoodMenuID.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                             select test);
                }

                lvwDisplay.Items.Clear();
                foreach (FoodMenuItemSetup objFm in query)
                {
                    ListViewItem itm = new ListViewItem(objFm.FoodMenuID + "~" + objFm.FoodMenuName);
                    itm.ImageIndex = 0;
                    lvwDisplay.Items.Add(itm);
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

        private void lvwVisitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwVisitors.SelectedItems.Count > 0)
                {
                    ListViewItem itm = lvwVisitors.SelectedItems[0];
                    string strInvoiceNo = itm.SubItems[0].Text;
                    DisplayVisitors(strInvoiceNo);
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
        #endregion
        private void DisplayVisitors(string strInvoiceNo)
        {
            double dblDiscount = 0;
            string dblVat = "";
            DGdown.Rows.Clear();
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            int i = 0;
            try
            {
                List<Visitors> objlv = fnbs.DisplaytVisitors(strInvoiceNo).ToList();
                int iRow = objlv.Count;
                if (iRow > 0)
                {
                    DGdown.Rows.Add(iRow);
                }

                foreach (Visitors objVs in objlv)
                {
                    txtInvoiceNo.Text = objVs.InvoiceNo;
                    txtVisitorsName.Text = objVs.VName;
                    dblDiscount = objVs.Discount;
                    dblVat = objVs.Vat.ToString();
                    txtNetPaid.Text = objVs.NetPaid.ToString();
                    DGdown.Rows[i].Cells[0].Value = objVs.FoodID;
                    DGdown.Rows[i].Cells[1].Value = objVs.FoodName;
                    DGdown.Rows[i].Cells[2].Value = objVs.Qnty;
                    DGdown.Rows[i].Cells[3].Value = objVs.Rate;
                    DGdown.Rows[i].Cells[4].Value = objVs.ItemDiscount;
                    DGdown.Rows[i].Cells[5].Value = objVs.Total;
                    i = i + 1;
                }
                CalculateDownsTotal();
                txtDiscount.Text = dblDiscount.ToString();
                txtVat.Text = dblVat.ToString();
                txtVisitorsName.Focus();
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
        private void lvwCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Return)
            {
                lvwDisplay.Focus();
            }
        }

        private void lvwDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                DGdown.Focus();
            }
        }

        private void txtvisitors_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                DisplayVisitors(txtInvoiceNo.Text);

            }
        }

        private void txtInvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            DisplayVisitors(txtInvoiceNo.Text);
        }

        private void lvwDisplay_DoubleClick(object sender, EventArgs e)
        {

            string Itemcode = "", ItemName = "", DisplayItem = "";
            double dblRate = 0;
            try
            {
                if (lvwDisplay.SelectedItems.Count > 0)
                {
                    if (radCategory.Checked == true)
                    {
                        ListViewItem itm = lvwDisplay.SelectedItems[0];
                        DisplayItem = lvwDisplay.SelectedItems[0].Text.ToString();
                        int intlen = lvwDisplay.SelectedItems[0].Text.ToString().Length;
                        Itemcode = DisplayItem.Substring(DisplayItem.LastIndexOf("~") + 1).ToString();
                        Itemcode = DisplayItem.ToString().Substring(0, (intlen - Itemcode.Length) - 1);
                        ItemName = DisplayItem.ToString().Substring(DisplayItem.LastIndexOf("~") + 1);

                        List<FoodMaster> objFm = fnbs.GetItemRate(Itemcode).ToList();
                        if (objFm.Count > 0)
                        {
                            foreach (FoodMaster fm in objFm)
                            {
                                dblRate = fm.Price;
                            }
                        }
                    }
                    else
                    {
                        ListViewItem itm = lvwDisplay.SelectedItems[0];
                        DisplayItem = lvwDisplay.SelectedItems[0].Text.ToString();
                        int intlen = lvwDisplay.SelectedItems[0].Text.ToString().Length;
                        Itemcode = DisplayItem.Substring(DisplayItem.LastIndexOf("~") + 1).ToString();
                        Itemcode = DisplayItem.ToString().Substring(0, (intlen - Itemcode.Length) - 1);
                        ItemName = DisplayItem.ToString().Substring(DisplayItem.LastIndexOf("~") + 1);
                        List<FoodMenuItemSetup> objfi = fnbs.GetFoodMenuItemSetupFromMenuID("Ind", Itemcode).ToList();
                        foreach (FoodMenuItemSetup Fm in objfi)
                        {
                            dblRate = Fm.ItemRate;

                        }
                    }

                    mAdditem(Itemcode, ItemName, 1, dblRate, 0, 1 * dblRate);
                    DGdown.Focus();

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmVisitorsDetails frm = new frmVisitorsDetails();
            frm.ShowDialog();
        }

        private void txtEmpID_KeyUp(object sender, KeyEventArgs e)
        {
            GetEmpDetails(txtEmpID.Text);
        }


        private void GetEmpDetails(string strCardNo)
        {
            txtEmpName.Text = "";
            try
            {
                EmployeeMaster oEmpMas = new EmployeeMaster();
                //EmployeeJobInformation oEmpJobInfo = new EmployeeJobInformation();
                oEmpMas = fnbs.GetEmpMaster(strCardNo);
                if (txtEmpID.Text == oEmpMas.EmpId)
                {
                    txtEmpName.Text = oEmpMas.FirstName;
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

        private void txtEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Return)
            {
                lvwCategory.Focus();
            }


        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
      

       
       







    }
}
