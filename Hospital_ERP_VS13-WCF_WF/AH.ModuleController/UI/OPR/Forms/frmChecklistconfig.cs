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

namespace AH.ModuleController.UI.OPR
{
    public partial class frmChecklistconfig : AH.Shared.UI.frmSmartFormStandard
    {
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        public frmChecklistconfig()
        {
            InitializeComponent();
        }

        #region "LoadOperation Type"
        private void LoadOperationtype()
        {
            try
            {
                cboOperationType.ValueMember = "Key";
                cboOperationType.DisplayMember = "Value";
                cboOperationType.DataSource = new BindingSource(accmSc.GetOperationType("D"), null);
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
        //private void LoadRegNo()
        //{
        //    cboRegNo.ValueMember = "Key";
        //    cboRegNo.DisplayMember = "Key";
        //    cboRegNo.DataSource = new BindingSource(accmSc.GetCheklistRegNo("GetregNoofChecklist"), null);
        //}
        #region "formload"
        private void frmChecklistconfig_Load(object sender, EventArgs e)
        {
            try
            {
                LoadOperationtype();
                //LoadRegNo();
                LoadListViewLeft("");
                Format_Grid();
                LoadListView();
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
        #region "Loadlistciewleft"
        private void LoadListViewLeft(string strWhere)
        {
            try
            {
                lvwItems.Items.Clear();
                List<ChecklistItem> objcheck = accmSc.GetCheklistOprtype("GetchecklisttoOprTypeLeft", strWhere).ToList();
                foreach (ChecklistItem chk in objcheck)
                {
                    ListViewItem itm = new ListViewItem(chk.itemCode);
                    itm.SubItems.Add(chk.itemName);
                    lvwItems.Items.Add(itm);
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
        #region "Display"
        private void GetDisplayRegNochecklist(string strRegNo)
        {
            try
            {
                List<ChecklistItem> objcheck = accmSc.GetRegNotoChecklist("DisplayRegNotoCheklist", strRegNo.ToString()).ToList();
                foreach (ChecklistItem chk in objcheck)
                {

                    txtPatientName.Text = chk.PatientName.ToString();
                    if (chk.RegDate.ToString() != "")
                    {
                        DateTime dteOtDate = Convert.ToDateTime(chk.RegDate.ToString());
                        txtOTDate.Text = dteOtDate.ToString("dd/MM/yyyy");
                    }
                    txtStarttime.Text = chk.startime.ToString();
                    txtEndtime.Text = chk.endtime.ToString();
                    cboOperationType.SelectedValue = chk.oprType.ToString();
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
        //private void LoadListViewRight(string strWhere)
        //{
        //    lvwRight.Items.Clear();
        //    List<ChecklistItem> objcheck = accmSc.GetCheklistOprtype("GetchecklisttoOprTyperight", strWhere).ToList();
        //    foreach (ChecklistItem chk in objcheck)
        //    {
        //        ListViewItem itm = new ListViewItem(chk.itemCode);
        //        itm.SubItems.Add(chk.itemName);
        //        lvwLeft.Items.Add(itm);
        //    }
        //}
        #region "Grid"
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

        #endregion
        public DataGridViewButtonColumn Create_Grid_Column_button(string pname, string htext, string btext, int cwidth, Boolean true_false,
          DataGridViewContentAlignment Align, Boolean read_only)
        {
            DataGridViewButtonColumn col0 = new DataGridViewButtonColumn();
            col0.DataPropertyName = pname;
            col0.HeaderText = htext;
            col0.Text = btext;
            col0.DefaultCellStyle.ForeColor = Color.Red;
            col0.DefaultCellStyle.BackColor = Color.Pink;
            col0.Visible = true_false;
            col0.DefaultCellStyle.Alignment = Align;
            col0.Width = cwidth;
            col0.ReadOnly = read_only;
            return col0;
        }
        #region "FormatGrid"
        private void Format_Grid()
        {
            DGdown.Columns.Add(Create_Grid_Column("Item Code", "Item Code", 0, false, DataGridViewContentAlignment.TopLeft, false));
            DGdown.Columns.Add(Create_Grid_Column("Item Name", "Item Name", 370, true, DataGridViewContentAlignment.TopLeft, true));
            //DGdown.Columns.Add(CreateChkBxGrd("Yes", "Yes", 370, true, DataGridViewContentAlignment.TopLeft, true));
            DGdown.Columns.Add(CreateChkBxGrd(" Yes", " Yes", 60, true, DataGridViewContentAlignment.TopCenter, false, false, "checkbox"));
            DGdown.Columns.Add(CreateChkBxGrd(" No", " No", 60, true, DataGridViewContentAlignment.TopCenter, false, false, "checkbox"));
            //DGdown.Columns.Add(CreateChkBxGrd("No", "No", 370, true, DataGridViewContentAlignment.TopLeft, true));
            DGdown.Columns.Add(Create_Grid_Column("Comments", "Comments", 300, true, DataGridViewContentAlignment.TopLeft, false));
           // DGdown.Columns.Add(CreateChkBxGrd(" ", " ", 80, true, DataGridViewContentAlignment.TopCenter, false, false, "checkbox"));
            DGdown.Columns.Add(Create_Grid_Column_button("Del", "Del", "Del", 80, true, DataGridViewContentAlignment.TopCenter, true));
        }
        #endregion
        #region "Add"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvwItems.Items.Count;i++ )
            {
                if (lvwItems.Items[i].Checked==true)
                {
                    mAdditem(lvwItems.Items[i].SubItems[0].Text, lvwItems.Items[i].SubItems[1].Text);

                }
            }
        }
        private void mAdditem(string stritemsCode, string strItemsName)
        {
            int selRaw;
            string strDown = "";
            Boolean blngCheck = false;
            for (int j = 0; j < DGdown.RowCount; j++)
            {
                if (DGdown[0, j].Value != null)
                {
                    strDown = DGdown[0, j].Value.ToString();
                }
                if (stritemsCode == strDown.ToString())
                {
                    blngCheck = true;
                    return;
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
                    DGdown[0, selRaw].Value = stritemsCode.ToString();
                    DGdown[1, selRaw].Value = strItemsName.ToString();
                }
            }
        }
        //private void cboRegNo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboRegNo.SelectedIndex >= 0 || cboRegNo.SelectedIndex != -1)
        //    {
        //        GetDisplayRegNochecklist(cboRegNo.SelectedValue.ToString());
        //    }

        //}
        #endregion
        #region "Validationfields"
        private bool ValidateFields()
        {
            //List<string> vf = new List<string>() { "txtRemarks" };
            //Control control = Utility.ReqFieldValidator(this, vf);
            //if (control != null)
            //{
            //    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    control.Focus();
            //    return false;
            //}
            if (cboOperationType.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboOperationType.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboOperationType.Focus();
                return false;
            }
            if (txtPatientRegNo.Text == "")
            {
                MessageBox.Show(Utility.getFMS(txtPatientRegNo.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPatientRegNo.Focus();
                return false;
            }

            return true;
        }
        #endregion
        #region "Populatechecklist"
        private ChecklistItem Populatechecklist()
        {
            {
                ChecklistItem objcheck = new ChecklistItem();
                if (txtItemCode.Text.ToString() != "")
                {
                    objcheck.itemCode = txtItemCode.Text.ToString();
                }
                objcheck.oprType=cboOperationType.SelectedValue.ToString();
                //objcheck.RegNo=cboRegNo.SelectedValue.ToString();
                objcheck.RegNo = txtPatientRegNo.Text.ToString();
                objcheck.RegDate  = txtOTDate.Text;
                objcheck.startime = txtStarttime.Text.ToString();
                objcheck.endtime = txtEndtime.Text.ToString();
                objcheck.ChecklistDate = dteChecklistDate.Text;

                EntryParameter ep = new EntryParameter();
                ep.EntryBy = Utility.UserId;
                ep.CompanyID = Utility.CompanyID;
                ep.LocationID = Utility.LocationID;
                ep.MachineID = Utility.MachineID;
                objcheck.EntryParameter = ep;
                return objcheck;
            }
        }
        #endregion
        #region "Clear"
        private void Clear()
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            for (int i = 0; i < lvwItems.Items.Count; i++)
            {
                lvwItems.Items[i].Checked = false;
            }

            DGdown.Rows.Clear();

        }
        #endregion
        #region "Displayview"
        private void DisplayView(string strWhere)
        {

            Clear();
            try
            {
                List<ChecklistItem> objCheck = accmSc.DisplayChecklistfromChecklistNo("DisplayCheklistFromchecklistNo", strWhere).ToList();
                int i = objCheck.Count();
                int j = 0;
                if (i > 0)
                {
                    DGdown.Rows.Add(i);
                }
                foreach (ChecklistItem chk in objCheck)
                {
                    txtItemCode.Text = chk.itemCode.ToString();
                    //cboOperationType.SelectedValue = chk.oprType.ToString();
                    //cboRegNo.SelectedValue = chk.RegNo.ToString();

                    txtPatientRegNo.Text = chk.RegNo.ToString();
                    GetDisplayRegNochecklist(txtPatientRegNo.Text.ToString());
                    DateTime dtedate = Convert.ToDateTime(chk.ChecklistDate.ToString());
                    dteChecklistDate.Text = dtedate.ToString("dd/MM/yyyy");
                    DGdown.Rows[j].Cells[0].Value = chk.itemCode.ToString();
                    DGdown.Rows[j].Cells[1].Value = chk.itemName.ToString();
                    if (chk.intYes == 1)
                    {
                        Convert.ToBoolean(DGdown.Rows[j].Cells[2].Value = true);
                    }

                    if (chk.intNo == 1)
                    {
                        Convert.ToBoolean(DGdown.Rows[j].Cells[3].Value = true);
                    }

                    DGdown.Rows[j].Cells[4].Value = chk.Comments.ToString();

                    j = j + 1;
                }

                ////foreach (ChecklistItem chk in objCheck)
                ////{
                //txtItemCode.Text = chk.itemCode.ToString();
                //cboOperationType.SelectedValue = chk.oprType.ToString();
                //cboRegNo.SelectedValue = chk.RegNo.ToString();
                //DateTime dtedate = Convert.ToDateTime(chk.ChecklistDate.ToString());
                //dteChecklistDate.Text = dtedate.ToString("dd/MM/yyyy");


                //}
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
        private void LoadListView() 
        {
            try
            {
                lvwLoadCheklist.Items.Clear();
                List<ChecklistItem> objCheck = accmSc.LoadCheckList("LoadChecklist").ToList();
                foreach (ChecklistItem chk in objCheck)
                {
                    ListViewItem itm = new ListViewItem(chk.itemCode.ToString());
                    itm.SubItems.Add(chk.RegNo);
                    lvwLoadCheklist.Items.Add(itm);
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
        #region "Save/Edit"
        private void btnSave_Click(object sender, EventArgs e)
        {
            string  strRefNo;
             int i;
            ChecklistItem objOprMaster;
            if (ValidateFields() == false)
            {
                return;
            }

            //if (Utility.IsDuplicateFoundInList(lvwOperationMaster, 1, txtOperationTitle.Text) == true)
            //{
            //    MessageBox.Show("Cannot Insert Duplicate Value", "AGH Operation");
            //    return;
            //}
            try
            {
                var strResponse = MessageBox.Show("Do You Want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    objOprMaster = this.Populatechecklist();
                    strRefNo = accmSc.SavedChecklistConfigMaster(objOprMaster);
                    if (strRefNo == "0")
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (strRefNo != "0")
                    {
                        for (int g = 0; g < DGdown.Rows.Count - 1; g++)
                        {
                            int intyes = 0;
                            int intNo = 0;
                            string strCommnets;
                            if (Convert.ToBoolean(DGdown.Rows[g].Cells[2].Value) == true)
                            {
                                intyes = 1;
                            }
                            if (Convert.ToBoolean(DGdown.Rows[g].Cells[3].Value) == true)
                            {
                                intNo = 1;
                            }
                            if (DGdown.Rows[g].Cells[4].Value != null)
                            {
                                strCommnets = DGdown[4, g].Value.ToString();
                            }
                            else
                            {
                                strCommnets = "";
                            }
                            i = accmSc.SavedChecklistConfigChild(strRefNo, DGdown.Rows[g].Cells[0].Value.ToString(), intyes, intNo, strCommnets, objOprMaster);
                        }
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        cboOperationType.Focus();
                        Clear();
                        LoadListView();

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
        private void lvwLoadCheklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwLoadCheklist.SelectedItems.Count > 0)
            {
                DisplayView(lvwLoadCheklist.SelectedItems[0].Text);
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int k;
            int i;
            ChecklistItem objOprMaster;
            if (ValidateFields() == false)
            {
                return;
            }

            try
            {
                var strResponse = MessageBox.Show("Do You Want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    objOprMaster = this.Populatechecklist();
                    k = accmSc.UpdateChecklistConfigMaster(objOprMaster);
                    if (k == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (k != 0)
                    {
                        for (int g = 0; g < DGdown.Rows.Count - 1; g++)
                        {
                            int intyes = 0;
                            int intNo = 0;
                            string strCommnets;
                            if (DGdown.Rows[g].Cells[0].Value != null)
                            {
                                if (Convert.ToBoolean(DGdown.Rows[g].Cells[2].Value) == true)
                                {
                                    intyes = 1;
                                }
                                if (Convert.ToBoolean(DGdown.Rows[g].Cells[3].Value) == true)
                                {
                                    intNo = 1;
                                }
                                if (DGdown.Rows[g].Cells[4].Value != null)
                                {
                                    strCommnets = DGdown[4, g].Value.ToString();
                                }
                                else
                                {
                                    strCommnets = "";
                                }
                                i = accmSc.UpdateChecklistConfigChild(txtItemCode.Text.ToString(), DGdown.Rows[g].Cells[0].Value.ToString(), intyes, intNo, strCommnets, objOprMaster);
                            }
                        }
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        cboOperationType.Focus();
                        Clear();
                        LoadListView();

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
        #endregion 
        #region "Keyup"
        private void txtRegNo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtPatientRegNo.TextLength == Utility.ScanLength)
                {
                    btnSearch_Click(sender, e);
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
        #region "Click"
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //InPatient opjPat = accmSc.GetPatreg(txtPatientRegNo.ToString());
                //txtPatientName.Text = opjPat.Name;
                GetDisplayRegNochecklist(txtPatientRegNo.Text.ToString());
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
        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void DGdown_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int selRowIndex = e.RowIndex;
                if (DGdown.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    DGdown.Rows.RemoveAt(selRowIndex);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

    }
}
