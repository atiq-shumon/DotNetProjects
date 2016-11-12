using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.PHRMSSR;

namespace AH.ModuleController.UI.PHRMS.Forms
{
    public partial class frmIssueReturn : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        public frmIssueReturn()
        {
            InitializeComponent();
        }


        private void FormatData(DataGridView dtv)
        {
            //dtv.Height = 300;
            //dtv.Width = 840;

            dtv.AutoGenerateColumns = false;
            dtv.EditMode = DataGridViewEditMode.EditOnKeystroke;
            //dtv.Location = new Point(txtItemID.Location.X, txtItemID.Location.Y);

            DataGridViewTextBoxColumn Drugid = new DataGridViewTextBoxColumn();
            Drugid.Name = "Drugid";
            Drugid.DataPropertyName = "Drugid";
            Drugid.Width = 0;
            Drugid.Visible = false;
            dtv.Columns.Add(Drugid);
            DataGridViewTextBoxColumn drugname = new DataGridViewTextBoxColumn();
            drugname.Name = "Drugname";
            drugname.DataPropertyName = "Drugname";
            drugname.Width = 270;
            drugname.Visible = true;
            drugname.ReadOnly = false;
            dtv.Columns.Add(drugname);

            DataGridViewTextBoxColumn typeid = new DataGridViewTextBoxColumn();
            typeid.Name = "TypeID";
            typeid.DataPropertyName = "TypeID";
            typeid.Width = 0;
            typeid.Visible = false;
            dtv.Columns.Add(typeid);

            DataGridViewTextBoxColumn unitid = new DataGridViewTextBoxColumn();
            unitid.Name = "UnitID";
            unitid.DataPropertyName = "UnitID";
            unitid.Width = 0;
            unitid.Visible = false;
            dtv.Columns.Add(unitid);

            DataGridViewTextBoxColumn groupid = new DataGridViewTextBoxColumn();
            groupid.Name = "GroupID";
            groupid.DataPropertyName = "GroupID";
            groupid.Width = 0;
            groupid.Visible = false;
            dtv.Columns.Add(groupid);

            DataGridViewTextBoxColumn compid = new DataGridViewTextBoxColumn();
            compid.Name = "CompanyID";
            compid.DataPropertyName = "CompanyID";
            compid.Width = 0;
            compid.Visible = false;
            dtv.Columns.Add(compid);

            DataGridViewTextBoxColumn groupname = new DataGridViewTextBoxColumn();
            groupname.Name = "GroupName";
            groupname.DataPropertyName = "GroupName";
            groupname.Width = 250;
            groupname.Visible = true;
            groupname.ReadOnly = true;
            dtv.Columns.Add(groupname);

            DataGridViewTextBoxColumn compname = new DataGridViewTextBoxColumn();
            compname.Name = "CompanyName";
            compname.DataPropertyName = "CompanyName";
            compname.Width = 250;
            compname.Visible = true;
            compname.ReadOnly = true;
            dtv.Columns.Add(compname);

            DataGridViewTextBoxColumn UnitName = new DataGridViewTextBoxColumn();
            UnitName.Name = "UnitName";
            UnitName.DataPropertyName = "UnitName";
            UnitName.Width = 0;
            UnitName.Visible = false;
            UnitName.ReadOnly = true;
            dtv.Columns.Add(UnitName);

            DataGridViewTextBoxColumn TypeName = new DataGridViewTextBoxColumn();
            TypeName.Name = "TypeName";
            TypeName.DataPropertyName = "TypeName";
            TypeName.Width = 0;
            TypeName.Visible = false;
            TypeName.ReadOnly = true;
            dtv.Columns.Add(TypeName);

            DataGridViewTextBoxColumn PharmacyID = new DataGridViewTextBoxColumn();
            PharmacyID.Name = "PharmacyID";
            PharmacyID.DataPropertyName = "PharmacyID";
            PharmacyID.Width = 0;
            PharmacyID.Visible = false;

            dtv.Columns.Add(PharmacyID);

            DataGridViewTextBoxColumn PharmacyName = new DataGridViewTextBoxColumn();
            PharmacyName.Name = "PharmacyName";
            PharmacyName.DataPropertyName = "PharmacyName";
            PharmacyName.Width = 0;
            PharmacyName.Visible = false;
            PharmacyName.ReadOnly = true;
            dtv.Columns.Add(PharmacyName);

            DataGridViewTextBoxColumn IssueQty = new DataGridViewTextBoxColumn();
            IssueQty.Name = "IssueQty";
            IssueQty.DataPropertyName = "IssueQty";
            IssueQty.Width = 80;
            IssueQty.Visible = true;
            IssueQty.ReadOnly = true;
            dtv.Columns.Add(IssueQty);

            DataGridViewTextBoxColumn ReturnQty = new DataGridViewTextBoxColumn();
            ReturnQty.Name = "ReturnQty";
            ReturnQty.DataPropertyName = "ReturnQty";
            ReturnQty.Width = 80;
            ReturnQty.Visible = true;
            ReturnQty.ReadOnly = false;
            dtv.Columns.Add(ReturnQty);

            DataGridViewTextBoxColumn IssueDate = new DataGridViewTextBoxColumn();
            IssueDate.Name = "IssueDate";
            IssueDate.DataPropertyName = "IssueDate";
            IssueDate.Width = 0;
            IssueDate.Visible = false;
            IssueDate.ReadOnly = true;
            dtv.Columns.Add(IssueDate);

            DataGridViewTextBoxColumn colBatch = new DataGridViewTextBoxColumn();
            colBatch.Name = "BatchNo";
            colBatch.DataPropertyName = "BatchNo";
            colBatch.Width = 0;
            colBatch.Visible = false;
            colBatch.ReadOnly = true;
            dtv.Columns.Add(colBatch);

            DataGridViewTextBoxColumn CompareQty = new DataGridViewTextBoxColumn();
            CompareQty.Name = "RemQty";
            CompareQty.DataPropertyName = "RemQty";
            CompareQty.Width = 60;
            CompareQty.Visible = true;
            CompareQty.ReadOnly = true;
            dtv.Columns.Add(CompareQty);

            DataGridViewTextBoxColumn colUrate = new DataGridViewTextBoxColumn();
            colUrate.Name = "Rate";
            colUrate.DataPropertyName = "Rate";
            colUrate.Width = 50;
            colUrate.Visible = true;
            colUrate.ReadOnly = true;
            dtv.Columns.Add(colUrate);

            DataGridViewTextBoxColumn colvat = new DataGridViewTextBoxColumn();
            colvat.Name = "Vat";
            colvat.DataPropertyName = "Vat";
            colvat.Width = 0;
            colvat.Visible = false;
            dtv.Columns.Add(colvat);

            DataGridViewTextBoxColumn colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "Discount";
            colDiscount.DataPropertyName = "Discount";
            colDiscount.Width = 0;
            colDiscount.Visible = false;
            dtv.Columns.Add(colDiscount);

            DataGridViewTextBoxColumn colamount = new DataGridViewTextBoxColumn();
            colamount.Name = "Amount";
            colamount.DataPropertyName = "Amount";
            colamount.Width = 80;
            colamount.ReadOnly = true;
            dtv.Columns.Add(colamount);

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.Width = 60;
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            dtv.Columns.Add(Deletelink);

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            dtv.Columns.Insert(22, checkBoxColumn);

           // Rectangle rect = dtv.GetCellDisplayRectangle(16, -1, true);
           // rect.Y = 3;
           // rect.X = rect.Location.X + (rect.Width / 4);
           // CheckBox checkboxHeader = new CheckBox();
           // checkboxHeader.Name = "checkboxHeader";
           // //datagridview[0, 0].ToolTipText = "sdfsdf";
           // checkboxHeader.Size = new Size(18, 18);

           //// checkboxHeader.Location = rect.Location;
           // checkboxHeader.Location = new Point(1058, 0);

           // checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);
           // dtv.Controls.Add(checkboxHeader); 

           // // add checkbox header
          
        }

        private void AddCheckBoxHeader(int index)
        {

            Rectangle rect = dgvIssueDetails.GetCellDisplayRectangle(15, -1, true);
            rect.X = rect.Location.X + (rect.Width / 5);
            rect.Y = 5;
            CheckBox checkboxHeader = new CheckBox();
            //checkboxHeader.Name = "checkboxHeader";
            //checkboxHeader.Size = new Size(13, 13);
            checkboxHeader.Location = rect.Location;
            //checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);
            dgvIssueDetails.Controls.Add(checkboxHeader);
        }

        private void checkboxHeader_CheckedChanged(object sender, EventArgs e)
        {


          
                CheckBox headerBox = ((CheckBox)dgvIssueDetails.Controls.Find("checkboxHeader", true)[0]);
                if (headerBox.Checked == true)
                {
                    for (int i = 0; i < dgvIssueDetails.RowCount; i++)
                    {
                        dgvIssueDetails.Rows[i].Cells[22].Value = true;

                    }
                }
                else
                {
                    for (int i = 0; i < dgvIssueDetails.RowCount; i++)
                    {
                        dgvIssueDetails.Rows[i].Cells[22].Value = false;

                    }
                }
            
        }

        private void frmIssueReturn_Load(object sender, EventArgs e)
        {
            FormatData(dgvIssueDetails);
            FormatData(dgvIssueReturn);
            dgvIssueDetails.Visible = true;
            dgvIssueDetails.Columns[20].Visible = false;
            dgvIssueDetails.Columns[21].Visible = false;
            
            
        }
      
        private void populateDataToGrid(DataGridView dtv,string issueid)
        {
            short index = 0;
            dgvIssueDetails.Visible = true;
            dgvIssueDetails.Rows.Clear();
            List<DrugIssue> list = new List<DrugIssue>();
            list.Clear();
            list.AddRange(phrSr.GetIssueDetails(issueid).ToList());
            foreach(DrugIssue data in list)            
            {
                string[] row = new string[] {  data.DrugMaster.ID,
                                               data.DrugMaster.Name,
                                               data.DrugMaster.DrugPackType.ID,
                                               data.DrugMaster.DrugUnit.ID,
                                               data.DrugMaster.DrugGroup.ID,
                                               data.DrugMaster.DrugCompany.ID,
                                               data.DrugMaster.DrugGroup.Name,
                                               data.DrugMaster.DrugCompany.Name,
                                               data.DrugMaster.DrugUnit.Name,
                                               data.DrugMaster.DrugPackType.Name,
                                               data.Warehouse.TypeID,
                                               data.Warehouse.TypeName,
                                               data.IssueQty.ToString(),
                                               data.ReturnQty.ToString(),
                                               data.IssueDate.ToString("dd/MM/yyyy"),
                                               data.BatchID,
                                               data.CompareQty.ToString(),
                                               data.DrugMaster.Urate.ToString(),
                                               data.DrugMaster.VAT.ToString(),
                                               data.DrugMaster.Discount.ToString(),
                                               "0"

                 };
                AddRowsToCollection(dgvIssueDetails, row, index);
                index++;
            }
        }
        private void AddRowsToCollection(DataGridView dtv,string[] row,short index)
        {
            dtv.Rows.Insert(index,row);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtPharmacyID.DataBindings.Clear();
            txtPharmacyName.DataBindings.Clear();
            txtIssueTypeName.DataBindings.Clear();
            txtIssueDate.DataBindings.Clear();
            txtPharmacyID.DataBindings.Add("Text", phrSr.GetIssueDetails(txtIssueID.Text).ToList(), "Warehouse.TypeID");
            txtPharmacyName.DataBindings.Add("Text", phrSr.GetIssueDetails(txtIssueID.Text).ToList(), "Warehouse.TypeName");
            txtIssueTypeName.DataBindings.Add("Text", phrSr.GetIssueDetails(txtIssueID.Text).ToList(), "IssueType");
            txtIssueDate.DataBindings.Add("Text", phrSr.GetIssueDetails(txtIssueID.Text).ToList(), "IssueDate");           
            populateDataToGrid(dgvIssueDetails,txtIssueID.Text);
            dgvIssueReturn.Rows.Clear();
          
        }

        private void dgvIssueDetails_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgvIssueDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvIssueReturn.Rows.Clear();
            
            //FormatData(dgvIssueReturn);
            //string message = string.Empty;
            foreach (DataGridViewRow row in dgvIssueDetails.Rows)
            {
           
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    for (int k = 0; k < dgvIssueDetails.Rows.Count; k++)
                    {
                        if (Convert.ToBoolean(dgvIssueDetails.Rows[k].Cells["checkBoxColumn"].Value) == true)
                        {
                            if (float.Parse(dgvIssueDetails.Rows[k].Cells["RemQty"].Value.ToString()) == 0)
                            {
                                MessageBox.Show("This item is already returned");
                                return;
                            }
                        }
                    }
                    dgvIssueReturn.Rows.Add(row.Cells[0].Value.ToString(),
                                            row.Cells[1].Value.ToString(),
                                            row.Cells[2].Value.ToString(),
                                            row.Cells[3].Value.ToString(),
                                            row.Cells[4].Value.ToString(),
                                            row.Cells[5].Value.ToString(),
                                            row.Cells[6].Value.ToString(),
                                            row.Cells[7].Value.ToString(),
                                            row.Cells[8].Value.ToString(),
                                            row.Cells[9].Value.ToString(),
                                            row.Cells[10].Value.ToString(),
                                            row.Cells[11].Value.ToString(),
                                            row.Cells[12].Value.ToString(),
                                            row.Cells[13].Value.ToString(),
                                            row.Cells[14].Value.ToString(),
                                            row.Cells[15].Value.ToString(),
                                            row.Cells[16].Value.ToString(),
                                            row.Cells[17].Value.ToString(),
                                            row.Cells[18].Value.ToString(),
                                            row.Cells[19].Value.ToString(),
                                            row.Cells[20].Value.ToString()
                                        );
                    dgvIssueReturn.Columns["checkBoxColumn"].Visible = false;
                    dgvIssueReturn.Columns["RemQty"].Visible = false;
                    dgvIssueReturn.Columns["IssueQty"].Visible = false;
                    this.dgvIssueReturn.Focus();
                }
                CalculateQty();
               
            }
           
           // MessageBox.Show("Selected Values" + message);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //dgvIssueDetails.Rows.Clear();
            //dgvIssueReturn.Rows.Clear();
            txtIssueID.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            btnSave.Enabled = true;
        }

        private void dgvIssueReturn_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dgvIssueReturn.Columns["ReturnQty"].Index)
            {
                dgvIssueReturn.Rows[e.RowIndex].ErrorText = "";
                int newInteger;

                // Don't try to validate the 'new row' until finished  
                // editing since there 
                // is not any point in validating its initial value. 
                if (dgvIssueReturn.Rows[e.RowIndex].IsNewRow) { return; }
                if (!int.TryParse(e.FormattedValue.ToString(),
                    out newInteger) || newInteger < 0)
                {
                    e.Cancel = true;
                    dgvIssueReturn.Rows[e.RowIndex].ErrorText = "the value must be a Positive integer";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtReceivedBy"};
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dgvIssueReturn.Rows.Count == 0)
            {
                MessageBox.Show("Please Select Item ");
                return;
            }
            foreach (DataGridViewRow i in dgvIssueReturn.Rows)
            {
                if (float.Parse(i.Cells["ReturnQty"].Value.ToString()) == 0)
                {
                    MessageBox.Show("Please insert ReturnQty");
                    return;
                }
                if (float.Parse(i.Cells["ReturnQty"].Value.ToString()) > float.Parse(i.Cells["RemQty"].Value.ToString()))
                {
                    MessageBox.Show("Return Qty can not exceed more than RemQty");
                    return;
                }
            }
          
            try
            {

                IssueReturn issueObj = this.populateIssueReturn();

                string i = phrSr.SaveIssueReturn(issueObj);


                if (i == "0")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReturnID.Text = i;
                    btnSave.Enabled = false;
                    dgvIssueReturn.Rows.Clear();
                    dgvIssueDetails.Rows.Clear();
                    lblTotalItem.Text = "0";
                    lblNetTotal.Text = "0";
                    //ResetField();
                    //btnNew.PerformClick();
                    //lvDrugIssue.Items.Clear();
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
        private IssueReturn populateIssueReturn()
        {
            IssueReturn oret = new IssueReturn();
            oret.ReturnDate = DateTime.Parse(txtRetDate.Text);
            oret.ReturnType = txtReturnType.Text;
            oret.ReturnFrom = txtReturnFrom.Text;
            oret.ReturnCause = txtReturnCause.Text;
            oret.Remarks = txtRemarks.Text;
            oret.NetAmount = float.Parse(lblNetTotal.Text);

            DrugIssue oissue = new DrugIssue();
            oissue.ID = txtIssueID.Text;
            //oissue.BatchID = txtBatchID.Text;
            oret.DrugIssue = oissue;

            Warehouse ph = new Warehouse();            
            ph.TypeID = txtPharmacyID.Text;
            oret.Warehouse = ph;

            
            string IssueString = "";

            foreach (DataGridViewRow dr in dgvIssueReturn.Rows)
            {
                IssueString += dr.Cells[0].Value.ToString() + "," + dr.Cells[2].Value.ToString() + "," + dr.Cells[3].Value.ToString() + "," + dr.Cells[4].Value.ToString() + "," + dr.Cells[5].Value.ToString() + "," + dr.Cells[13].Value.ToString() + "," + dr.Cells[15].Value.ToString() + "," + dr.Cells[17].Value.ToString() + "," + dr.Cells[18].Value.ToString() + "," + dr.Cells[19].Value.ToString();
                IssueString += ";";
            }
            oret.ReturnDetails  = IssueString;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oret.EntryParameter = ep;


            return oret;
        }

        private void smartLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txtReturnFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvIssueReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 21)
            {
                int selRowIndex = e.RowIndex;
                if (selRowIndex < 0)
                {
                    dgvIssueReturn.Rows.Clear();
                }
                else
                {
                    dgvIssueReturn.Rows.RemoveAt(selRowIndex);
                }

            }
            CalculateQty();
        }
        private void CalculateQty()
        {
            lblTotalItem.Text = dgvIssueReturn.Rows.Count.ToString();
            float sum = 0;
            for (int i = 0; i < dgvIssueReturn.Rows.Count; i++)
            {
                dgvIssueReturn.Rows[i].Cells[20].Value = float.Parse(dgvIssueReturn.Rows[i].Cells[13].Value.ToString()) * float.Parse(dgvIssueReturn.Rows[i].Cells[17].Value.ToString()) + float.Parse(dgvIssueReturn.Rows[i].Cells[18].Value.ToString()) - float.Parse(dgvIssueReturn.Rows[i].Cells[19].Value.ToString());
                sum += float.Parse(dgvIssueReturn.Rows[i].Cells[20].Value.ToString());
                lblNetTotal.Text = sum.ToString();
                //dgvPODetails.Rows[i].Cells[21].Value = Convert.ToInt32(dgvPODetails.Rows[i].Cells[15].Value) * Convert.ToInt32(dgvPODetails.Rows[i].Cells[17].Value) + Convert.ToInt32(dgvPODetails.Rows[i].Cells[19].Value) - Convert.ToInt32(dgvPODetails.Rows[i].Cells[20].Value);
            }
        }
        private void dgvIssueReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CalculateQty();
        }

    }
}
