using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.ATMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.ATMS.Forms
{
    public partial class frmWarrentyService : AH.Shared.UI.frmSmartFormStandard
    {
        DateTimePicker oDateTimePicker;
        public string strTagNo { set; get; }
        public string strProductCode { set; get; }
        public string strProductName { set; get; }
        public string strWarrentyDate { set; get; }


        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();
        public frmWarrentyService()
        {
            InitializeComponent();
        }

        private void frmWarrentyService_Load(object sender, EventArgs e)
        {
            txttagNo.Text = strTagNo;
            txtProductCode.Text = strProductCode;
            txtProductName.Text = strProductName;
            txtWarrentyDate.Text = strWarrentyDate;

            List<ServiceWarrenty> Sw = atms.GetwarrentyService("GetwarrentyDetails", strTagNo).ToList();
            int i = Sw.Count();
            int k = 0;
            if (i > 0)
            {
                DG.Rows.Add(i);
                foreach (ServiceWarrenty objservice in Sw)
                {
                    DG.Rows[k].Cells[0].Value = objservice.TagNo;
                    DG.Rows[k].Cells[1].Value = objservice.productCode;
                    DG.Rows[k].Cells[2].Value = objservice.productName;
                    DG.Rows[k].Cells[3].Value = objservice.voucherDate;
                    DG.Rows[k].Cells[4].Value = objservice.ServiceStartDate;
                    DG.Rows[k].Cells[5].Value = objservice.ServiceEndDate;
                    DG.Rows[k].Cells[6].Value = objservice.WarrentyDate;
                    DG.Rows[k].Cells[7].Value = objservice.RecivedDate;
                    DG.Rows[k].Cells[8].Value = objservice.Notes;
                    DG.Rows[k].Cells[10].Value = objservice.WarrentyStatus;
                    k = k + 1;
                }
            }
        }

        //private void DG_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == 7)
        //    {
        //        oDateTimePicker = new DateTimePicker();  //DateTimePicker 
        //        DG.Controls.Add(oDateTimePicker);
        //        oDateTimePicker.Visible = false;
        //        oDateTimePicker.Format = DateTimePickerFormat.Short;  //
        //        oDateTimePicker.TextChanged += new EventHandler(DG_OnTextChange);
        //        oDateTimePicker.Visible = true;
        //        Rectangle oRectangle = DG.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
        //        oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);
        //        oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);
        //        oDateTimePicker.CloseUp += new EventHandler(DG_CloseUp);
        //    }
        //}

        //private void DG_OnTextChange(object sender, EventArgs e)
        //{
        //    DG.CurrentCell.Value = oDateTimePicker.Text.ToString();
        //}
        //void DG_CloseUp(object sender, EventArgs e)
        //{
        //    oDateTimePicker.Visible = false;
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < DG.RowCount; i++)
            //{
                    mAdditem(txttagNo.Text , txtProductCode.Text,txtProductName.Text,dteWdate.Text,mskFDate.Text,mskTdate.Text,txtWarrentyDate.Text );
            //}
        }
        private void mAdditem(string strTagNo, string strProductCode, string strProductName, string strDate, string serviceStartDate, string serviceEnddate, string strWaarrentyDate)
        {
            int selraw;
            selraw = Convert.ToInt32(DG.RowCount.ToString()); //current position or current row
            selraw = selraw - 1;
            DG.Rows.Add(1);
                if (strTagNo != null)
                {
                    DG[0, selraw].Value = strTagNo;
                    DG[1, selraw].Value = strProductCode;
                    DG[2, selraw].Value = strProductName;
                    DG[3, selraw].Value = strDate;
                    if (serviceStartDate != "  /  /")
                    {
                        DG[4, selraw].Value = serviceStartDate;
                    }
                    if (serviceStartDate != "  /  /")
                    {
                        DG[5, selraw].Value = serviceEnddate;
                    }
                    DG[7, selraw].Value = strWaarrentyDate;
                    DG[10, selraw].Value = 0;
                    
                }
            //}
        }

        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
               int selRowIndex = e.RowIndex;
               int seColumnindex = e.ColumnIndex;
               if (DG.Rows[e.RowIndex].Cells[10].Value != null)
               {
                   if (Convert.ToInt16(DG.Rows[e.RowIndex].Cells[10].Value) == 0)
                   {
                       if (selRowIndex < 1)
                       {
                           DG.Rows.Clear();
                       }
                       else
                       {
                           DG.Rows.RemoveAt(selRowIndex);
                       }
                   }
                   else
                   {
                       MessageBox.Show("Cannot Removed,It is already Saved,only You can change it");
                        return ;
                   }
               }
               
            }
        }
        private bool validationfields()
        {
            if (txttagNo.Text.ToString() == "")
            {
                return true;
            }
            //if (txtWarrentyDate.Text.ToString() == "")
            //{
            //    return true;
            //}
            if (txtProductName.Text.ToString() == "")
            {
                return true;
            }
            return false;
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
                    //DeleteServiceWarrenty
                    int t = atms.DeleteServiceWarrenty(txttagNo.Text);
                    for (int i = 0; i < DG.Rows.Count - 1; i++)
                    {
                        string strTagNo = "", strproductcode = "", strVDate = "", strServiceFDate = "", strServiceTDate = "", strReceiveDate = "", strWaarrentyDate = "", strNotes="";
                        if (DG.Rows[i].Cells[0].Value.ToString() != null)
                        {
                            strTagNo = DG.Rows[i].Cells[0].Value.ToString();
                        }
                        else
                        {
                            strTagNo = "";
                        }

                        if (DG.Rows[i].Cells[1].Value.ToString() != null)
                        {
                            strproductcode = DG.Rows[i].Cells[1].Value.ToString();
                        }
                        else
                        {
                            strproductcode = "";
                        }

                        if (DG.Rows[i].Cells[3].Value != null)
                        {
                            strVDate = DG.Rows[i].Cells[3].Value.ToString();
                        }
                        else
                        {
                            strVDate = "";
                        }

                        if (DG.Rows[i].Cells[4].Value != null)
                        {
                            strServiceFDate = DG.Rows[i].Cells[4].Value.ToString();
                        }
                        else
                        {
                            strServiceFDate = "";
                        }
                        if (DG.Rows[i].Cells[5].Value != null)
                        {
                            strServiceTDate = DG.Rows[i].Cells[5].Value.ToString();
                        }
                        else
                        {
                            strServiceTDate = "";
                        }
                        if (DG.Rows[i].Cells[6].Value != null)
                        {
                            strWaarrentyDate = DG.Rows[i].Cells[6].Value.ToString();
                        }
                        else
                        {
                            strWaarrentyDate = "";
                        }
                        if (DG.Rows[i].Cells[7].Value != null)
                        {
                            strReceiveDate   = DG.Rows[i].Cells[7].Value.ToString();
                        }
                        else
                        {
                            strReceiveDate = "";
                        }
                        if (DG.Rows[i].Cells[8].Value != null)
                        {
                            strNotes = DG.Rows[i].Cells[8].Value.ToString();
                        }
                        else
                        {
                            strNotes = "";
                        }
                        ServiceWarrenty objService = this.PopulateService(strTagNo,strproductcode ,strVDate
                                                       ,strServiceFDate,strServiceTDate,strWarrentyDate,
                                                        strReceiveDate,strNotes);
                        short k = atms.SaveServiceWarrenty(objService);
                        ////btnNew.PerformClick();
                        //txtBrandName.Text = "";
                        //txtBrandName.Focus();
                    }
                }
            }
        }
        private ServiceWarrenty  PopulateService(string strtagNo,string strProductCode,string strvDate,
                                                    string serviceStartDate,string serviceEnddate,string strwarrentyDate,string strReceivedDate,string strNotes )
        {
            ServiceWarrenty objService = new ServiceWarrenty();
            if (txttagNo.Text != "")
            {
                objService.TagNo = txttagNo.Text;
            }
            objService.productCode = strProductCode;
            objService.voucherDate = strvDate;
            objService.WarrentyDate = strwarrentyDate;
            objService.ServiceStartDate = serviceStartDate;
            objService.ServiceEndDate = serviceEnddate;
            objService.RecivedDate = strReceivedDate;
            objService.Notes = strNotes;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objService.EntryParameter = ep;
            return objService;
        }

        private void DG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnSave.Focus();
            }
        }

        private void txttagNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char) Keys.Return)
            {
                txtProductName.Focus();
            }
        }

        private void txtWarrentyDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                mskFDate.Focus();
            }
        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                dteWdate.Focus();
            }
        }

        private void mskFDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                mskTdate.Focus();
            }
        }

        private void dteWdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtWarrentyDate.Focus();
            }
        }

        private void mskTdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                DG.Focus();
            }
        }

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    if (validationfields() == true)
        //    {
        //        MessageBox.Show("Empty field");
        //    }
        //    else
        //    {
        //        var strResponse = MessageBox.Show("Do You want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (strResponse == DialogResult.Yes)
        //        {
        //            Brand objBrnd = this.PopulateBrand();
        //            short i = atms.SaveBrand(objBrnd);
        //            //btnNew.PerformClick();
        //            txtBrandName.Text = "";
        //            txtBrandName.Focus();
        //        }
        //    }
        //}
    }
}
