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
    public partial class frmIssueReturn : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
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
            Drugid.Name = "ItemID";
            Drugid.DataPropertyName = "ItemID";
            Drugid.Width = 0;
            Drugid.Visible = false;
            dtv.Columns.Add(Drugid);
            DataGridViewTextBoxColumn drugname = new DataGridViewTextBoxColumn();
            drugname.Name = "ItemName";
            drugname.DataPropertyName = "ItemName";
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

            DataGridViewTextBoxColumn brandid = new DataGridViewTextBoxColumn();
            brandid.Name = "BrandID";
            brandid.DataPropertyName = "BrandID";
            brandid.Width = 0;
            brandid.Visible = false;
            dtv.Columns.Add(brandid);

            DataGridViewTextBoxColumn modelid = new DataGridViewTextBoxColumn();
            modelid.Name = "ModelID";
            modelid.DataPropertyName = "ModelID";
            modelid.Width = 0;
            modelid.Visible = false;
            dtv.Columns.Add(modelid);

            DataGridViewTextBoxColumn storetype = new DataGridViewTextBoxColumn();
            storetype.Name = "StoreTypeID";
            storetype.DataPropertyName = "StoreTypeID";
            storetype.Width = 0;
            storetype.Visible = false;
            dtv.Columns.Add(storetype);
            DataGridViewTextBoxColumn majorgroup = new DataGridViewTextBoxColumn();
            majorgroup.Name = "MajorGroup";
            majorgroup.DataPropertyName = "MajorGroup";
            majorgroup.Width = 0;
            majorgroup.Visible = false;
            dtv.Columns.Add(majorgroup);

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

            DataGridViewTextBoxColumn StoreID = new DataGridViewTextBoxColumn();
            StoreID.Name = "StoreID";
            StoreID.DataPropertyName = "StoreID";
            StoreID.Width = 0;
            StoreID.Visible = false;
            dtv.Columns.Add(StoreID);

            DataGridViewTextBoxColumn StoreName = new DataGridViewTextBoxColumn();
            StoreName.Name = "StoreName";
            StoreName.DataPropertyName = "StoreName";
            StoreName.Width = 0;
            StoreName.Visible = false;
            StoreName.ReadOnly = true;
            dtv.Columns.Add(StoreName);

            DataGridViewTextBoxColumn IssueQty = new DataGridViewTextBoxColumn();
            IssueQty.Name = "IssQty";
            IssueQty.DataPropertyName = "IssQty";
            IssueQty.Width = 60;
            IssueQty.Visible = true;
            IssueQty.ReadOnly = true;
            dtv.Columns.Add(IssueQty);

            DataGridViewTextBoxColumn ReturnQty = new DataGridViewTextBoxColumn();
            ReturnQty.Name = "RetQty";
            ReturnQty.DataPropertyName = "RetQty";
            ReturnQty.Width = 60;
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
            colBatch.Width = 80;
            colBatch.Visible = true;
            colBatch.ReadOnly = true;
            dtv.Columns.Add(colBatch);

            DataGridViewTextBoxColumn CompareQty = new DataGridViewTextBoxColumn();
            CompareQty.Name = "CompQty";
            CompareQty.DataPropertyName = "CompQty";
            CompareQty.Width = 0;
            CompareQty.Visible = false;
            CompareQty.ReadOnly = false;
            dtv.Columns.Add(CompareQty);

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

            //Rectangle rect = dtv.GetCellDisplayRectangle(20, -1, true);
            //rect.Y = 3;
            //rect.X = rect.Location.X + (rect.Width / 4);
            //CheckBox checkboxHeader = new CheckBox();
            //checkboxHeader.Name = "checkboxHeader";            
            //checkboxHeader.Size = new Size(18, 18);           
            //checkboxHeader.Location = new Point(1058, 0);
            //checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);
            //dtv.Controls.Add(checkboxHeader);

        }
        

        private void frmIssueReturn_Load(object sender, EventArgs e)
        {
            FormatData(dgvIssueDetails);
            FormatData(dgvIssueReturn);
            FormatDataForSerialNo(dgvSerialNo);
            FormatDataForSerialNo(dgvLoadSerialNo);
            dgvIssueDetails.Visible = true;
            dgvIssueDetails.Columns[21].Visible = false;
        }
        private void populateDataToGrid(DataGridView dtv, string issueid)
        {
            short index = 0;
            dgvIssueDetails.Visible = true;
            dgvIssueDetails.Rows.Clear();
            List<ItemIssue> list = new List<ItemIssue>();
            list.Clear();
            list.AddRange(invSr.GetIssueDetails(issueid).ToList());
            foreach (ItemIssue data in list)
            {
                string[] row = new string[] { 
                                              data.ItemOrder.ItemMaster.ID,
                                              data.ItemOrder.ItemMaster.Name,
                                              data.ItemOrder.ItemMaster.PacketType.ID,
                                              data.ItemOrder.ItemMaster.Units.ID,
                                              data.ItemOrder.ItemMaster.GroupDetails.ID,
                                              data.ItemOrder.ItemMaster.Company.ID,
                                              data.ItemOrder.ItemMaster.BrandSetup.ID,
                                              data.ItemOrder.ItemMaster.ModelSetup.ID,
                                              data.ItemOrder.ItemMaster.StoreType.strTypeID,
                                              data.ItemOrder.ItemMaster.Majorgroup.MajorgrpID,
                                              data.ItemOrder.ItemMaster.GroupDetails.Name,
                                              data.ItemOrder.ItemMaster.Company.Name,
                                              data.ItemOrder.ItemMaster.Units.Name,
                                              data.ItemOrder.ItemMaster.PacketType.Name,
                                              data.StoreLocation.ID,
                                              data.StoreLocation.Name,
                                              data.IssueQty.ToString(),
                                              data.ReturnQty.ToString(),
                                              data.IssueDate.ToString("dd/MM/yyyy"),
                                              data.BatchID,
                                              data.CompareQty.ToString()

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

            txtStoreID.DataBindings.Clear();
            txtStoreName.DataBindings.Clear();
            txtIssueTypeName.DataBindings.Clear();
            txtIssueDate.DataBindings.Clear();
            txtStoreID.DataBindings.Add("Text", invSr.GetIssueDetails(txtIssueID.Text).ToList(), "StoreLocation.ID");
            txtStoreName.DataBindings.Add("Text", invSr.GetIssueDetails(txtIssueID.Text).ToList(), "StoreLocation.Name");
            txtIssueTypeName.DataBindings.Add("Text", invSr.GetIssueDetails(txtIssueID.Text).ToList(), "IssueType");
            txtIssueDate.DataBindings.Add("Text", invSr.GetIssueDetails(txtIssueID.Text).ToList(), "IssueDate");
            populateDataToGrid(dgvIssueDetails, txtIssueID.Text);
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            dgvIssueReturn.Rows.Clear();

            foreach (DataGridViewRow row in dgvIssueDetails.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    for (int k = 0; k < dgvIssueDetails.Rows.Count; k++)
                    {
                        if (Convert.ToBoolean(dgvIssueDetails.Rows[k].Cells["checkBoxColumn"].Value) == true)
                        {
                            if (float.Parse(dgvIssueDetails.Rows[k].Cells["CompQty"].Value.ToString()) == 0)
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

                        this.dgvIssueReturn.Focus();
                    }
                }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtReceivedBy" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(dgvIssueReturn.Rows.Count == 0)
            {
                MessageBox.Show("Please Select Item ");
                return;
            }
            foreach (DataGridViewRow i in dgvIssueReturn.Rows)
            {
                if (float.Parse(i.Cells["RetQty"].Value.ToString()) == 0)
                {
                    MessageBox.Show("Please insert ReturnQty");
                    return;
                }
                if (float.Parse(i.Cells["RetQty"].Value.ToString()) > float.Parse(i.Cells["CompQty"].Value.ToString()))
                {
                    MessageBox.Show("Return Qty can not exceed more than RemQty");
                    return;
                }
                //if (float.Parse(i.Cells["RetQty"].Value.ToString()) > float.Parse(i.Cells["IssQty"].Value.ToString()))
                //{
                //    MessageBox.Show("Quantity Exceeded");
                //    return;
                //}
            }
            try
            {

                IssueReturn issueObj = this.populateIssueReturn();

                string i = invSr.SaveIssueReturn(issueObj);


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
                    txtStoreID.Text = string.Empty;
                    txtStoreName.Text = string.Empty;
                    txtIssueTypeName.Text = string.Empty;
                    txtIssueDate.Text = string.Empty;
                    txtRemarks.Text = string.Empty;
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

            ItemIssue oissue = new ItemIssue();
            oissue.ID = txtIssueID.Text;
            oissue.IssueType = txtIssueTypeName.Text;
           // oissue.BatchID = txtBatchID.Text;
            oret.ItemIssue = oissue;

            StoreLocation ph = new StoreLocation();
            ph.ID = txtStoreID.Text;
            oret.StoreLocation = ph;


            string IssueString = "";

            foreach (DataGridViewRow dr in dgvIssueReturn.Rows)
            {
                IssueString += dr.Cells[0].Value.ToString() + "," + dr.Cells[2].Value.ToString() + "," + dr.Cells[3].Value.ToString() + "," + dr.Cells[8].Value.ToString() + "," + dr.Cells[9].Value.ToString() + "," + dr.Cells[4].Value.ToString() + "," + dr.Cells[5].Value.ToString() + "," + dr.Cells[6].Value.ToString() + "," + dr.Cells[7].Value.ToString() + "," + dr.Cells[17].Value.ToString() + "," + dr.Cells[19].Value.ToString();
                IssueString += ";";
            }
            oret.ReturnDetails = IssueString;

            string assettrackerslno = "";

            foreach (DataGridViewRow sl in dgvLoadSerialNo.Rows)
            {
                assettrackerslno += sl.Cells[0].Value.ToString();
                assettrackerslno += ":";
            }

            oret.AssetTrackerSerialNo = assettrackerslno;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oret.EntryParameter = ep;


            return oret;
        }
        private void FormatDataForSerialNo(DataGridView dtv)
        {
            //dtv.Height = 300;
            //dtv.Width = 840;

            //dtv.AutoGenerateColumns = false;
            //dtv.Location = new Point(txtItemID.Location.X, txtItemID.Location.Y);

            DataGridViewTextBoxColumn serialno = new DataGridViewTextBoxColumn();
            serialno.Name = "serialno";
            serialno.DataPropertyName = "serialno";
            serialno.Width = 100;
            serialno.Visible = true;
            dtv.Columns.Add(serialno);
            dtv.Columns[0].DefaultCellStyle.ForeColor = Color.Black;

            DataGridViewTextBoxColumn itemid = new DataGridViewTextBoxColumn();
            itemid.Name = "ItemID";
            itemid.DataPropertyName = "ItemID";
            itemid.Width = 0;
            itemid.Visible = false;
            dtv.Columns.Add(itemid);
            //dtv.Columns[1].DefaultCellStyle.ForeColor = Color.Black;

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Visible = true;
            checkBoxColumn.Name = "checkBoxColumn";
            dtv.Columns.Insert(2, checkBoxColumn);
        }
        private void populateDataToGridForSerialNo(DataGridView dtv,string issueid, string itemid)
        {

            //dgvSerialNo.Visible = true;
            List<AssetTrackerMaster> list = new List<AssetTrackerMaster>();
            list.AddRange(invSr.GetAssetSerialNoForIssueReturn(issueid,itemid).ToList());

            dgvSerialNo.DataSource = list.Select(data => new
            {

                serialno = data.SerialNo,
                ItemID = data.ItemMaster.ID

            }).ToList();

            //this.dgvSerialNo.Focus();


        }
        private void setvaluesFromList(DataGridView dtv, object sender)
        {

            if (dgvIssueReturn.Rows.Count > 0)
            {

                int currentRow = dgvIssueReturn.CurrentRow.Index;
                currentRow--;
                //txtProductID.Text = dtv.CurrentRow.Cells["DRUGID"].Value.ToString();
                txtItemID.Text = dgvIssueReturn[0, currentRow + 1].Value.ToString();
            }


        }

        private void dgvIssueReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            setvaluesFromList(dgvIssueReturn,sender);
            populateDataToGridForSerialNo(dgvSerialNo,txtIssueID.Text,txtItemID.Text);
        }

        private void btnAddSerial_Click(object sender, EventArgs e)
        {
            for (int k = 0; k <= dgvIssueReturn.Rows.Count - 1; k++)
            {
                if (dgvIssueReturn.Rows[k].Cells[0].Value != "")
                {

                    if (CheckItemIssueQty(dgvIssueReturn.Rows[k].Cells[0].Value.ToString(), Convert.ToInt32(dgvIssueReturn.Rows[k].Cells[17].Value)))
                    {
                        MessageBox.Show("Please select serial number as Issue Quantity");
                        return;
                    }
                }
            }
            

            foreach (DataGridViewRow row in dgvSerialNo.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {

                    if (Checkduplicate(row.Cells["serialno"].Value.ToString()) == false)
                    {
                        dgvLoadSerialNo.Rows.Add(row.Cells["serialno"].Value.ToString());
                    }
                    dgvLoadSerialNo.Columns["checkBoxColumn"].Visible = false;
                    this.dgvSerialNo.Focus();
                }

            }
        }
        private bool CheckItemIssueQty(string strItemCode, int dblQty)
        {

            int i = 1, intCount = 0;

            foreach (DataGridViewRow row in dgvSerialNo.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {

                    if (strItemCode == row.Cells[2].Value.ToString())
                    {
                        intCount = intCount + 1;

                    }
                }
            }
            if (intCount > 0)
            {
                if (intCount != dblQty)
                {

                    return true;
                }
            }

            return false;


        }
        private bool Checkduplicate(string strSlNo)
        {

            for (int j = 0; j < dgvLoadSerialNo.Rows.Count; j++)
            {
                if (strSlNo == dgvLoadSerialNo.Rows[j].Cells[0].Value)
                {
                    return true;
                }
            }
            return false;

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
        }

        private void dgvIssueReturn_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dgvIssueDetails.Columns["RetQty"].Index)
            {
                dgvIssueDetails.Rows[e.RowIndex].ErrorText = "";
                int newInteger;

                // Don't try to validate the 'new row' until finished  
                // editing since there 
                // is not any point in validating its initial value. 
                if (dgvIssueDetails.Rows[e.RowIndex].IsNewRow) { return; }
                if (!int.TryParse(e.FormattedValue.ToString(),
                    out newInteger) || newInteger <= 0)
                {
                    e.Cancel = true;
                    dgvIssueDetails.Rows[e.RowIndex].ErrorText = "the value must be a Positive integer";
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
           // btnEdit.Enabled = false;
            dgvIssueDetails.Rows.Clear();
            dgvIssueReturn.Rows.Clear();
            txtReturnType.Text = "01";
            txtReturnFrom.Text = "01";
            txtReturnCause.Text = "01";
            //dgvIssueDetails.Columns.Clear();
            txtIssueID.Text = string.Empty;
            txtReturnID.Text = string.Empty;
            txtStoreID.Text = string.Empty;
            txtStoreName.Text = string.Empty;
            txtIssueTypeName.Text = string.Empty;
            txtIssueDate.Text = string.Empty;
            txtRemarks.Text = string.Empty;
        }

    }
}
