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

namespace AH.ModuleController.UI.OPR.Forms
{
    public partial class frmOTPatient : AH.Shared.UI.frmSmartFormStandard
    {
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        OpenFileDialog opFile = new OpenFileDialog();
        SaveFileDialog optSave = new SaveFileDialog();
        List<CalenderOT> oblCalDoc;
        public string starttime { set; get; }
        public string strDate { set; get; }
        public string Endtime { set; get; }
        public string rowpos { set; get; }
        public string TheaterName { set; get; }
        public string Colpos { set; get; }
        public string[] strArray { set; get; }
        List<string> myCollection = new List<string>();
        public string strScheduleID { set; get; }
        public int intStatus { set; get; }
        public frmOTPatient(List<string> a)
        {
            InitializeComponent();
            myCollection = a;
        }
        #region "Load"
        //private void LoadSchedule()
        //{
        //    cboRegID.ValueMember = "Key";
        //    cboRegID.DisplayMember = "Value";

        //    //cboRegID.DataSource = new BindingSource(accmSc.GetTheaterBed("TheaterDep"), null);
        //    cboRegID.DataSource = new BindingSource(accmSc.GetRegScheduling(), null);
        //}

        private void LoadInchargeID()
        {
            cboInchargeID.ValueMember = "Key";
            cboInchargeID.DisplayMember = "Value";
            //cboRegID.DataSource = new BindingSource(accmSc.GetTheaterBed("TheaterDep"), null);
            cboInchargeID.DataSource = new BindingSource(accmSc.GetInchargeID(), null);
        }
        private void LoadPackage()
        {
            cboPackagename.ValueMember = "Key";
            cboPackagename.DisplayMember = "Value";
            //cboRegID.DataSource = new BindingSource(accmSc.GetTheaterBed("TheaterDep"), null);
            cboPackagename.DataSource = new BindingSource(accmSc.GetPacageInformation(), null);
        }

        private void Loadtheaterid()
        {
            cbotheaterId.ValueMember = "Key";
            cbotheaterId.DisplayMember = "Value";
            //cboRegID.DataSource = new BindingSource(accmSc.GetTheaterBed("TheaterDep"), null);
            cbotheaterId.DataSource = new BindingSource(accmSc.LoadOTtheater(), null);
        }
        private void LoadOperationtype()
        {
            cboOperationtype.ValueMember = "Key";
            cboOperationtype.DisplayMember = "Value";
            cboOperationtype.DataSource = new BindingSource(accmSc.GetOperationType("D"), null);
        }
        private void LoadDoctorsSchedule()
        {
            lvwDoctorsAvail.Items.Clear();
            //oblCalDoc.Clear();
            oblCalDoc = accmSc.GetDoctorsAvaiable("", txtStartDate.Text, txtStartDate.Text).ToList();
            foreach (CalenderOT cal in oblCalDoc)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = cal.DoctorsCode;
                lvi.SubItems.Add(cal.AvailableFromTime);
                lvi.SubItems.Add(cal.AvailablrToTime);
                lvwDoctorsAvail.Items.Add(lvi);

            }
        }

        private void frmOTPatient_Load(object sender, EventArgs e)
        {

            try
            {
                //string strScheduleID = "";
                cboOperationtype.Select();
                DateTime dtedate = Convert.ToDateTime(strDate.ToString());
                txtStartDate.Text = dtedate.ToString("dd/MM/yyyy");
                LoadOperationtype();
                LoadDoctorsSchedule();
                //LoadOTnameFromOTtype("");
                Loadtheaterid();
                grid_column();
                Format_Grid();
                //LoadSchedule();
                LoadInchargeID();
                LoadPackage();

                if (strScheduleID != null)
                {
                    strScheduleID = strScheduleID.Substring(strScheduleID.LastIndexOf("-") + 1);
                }
                else
                {
                    strScheduleID = "";
                }

                if (strScheduleID == "")
                {
                    btnSave.Enabled = true;
                    btnEdit.Enabled = false;
                    txtStartTime.Text = starttime.ToString();
                    txtendtime.Text = Endtime.ToString();
                    cbotheaterId.Text = TheaterName.ToString();
                    //txtStartDate.Text = strDate.ToString();
                    //listView1.Clear();
                    foreach (string b in myCollection)
                    {
                        string[] tt = b.Split(',');
                        foreach (string word1 in tt)
                        {
                            ListViewItem lvi = new ListViewItem();
                            string[] aa = word1.Split('|');
                            lvi.Text = aa[0].ToString();
                            lvi.SubItems.Add(aa[1].ToString());
                            lvi.SubItems.Add(Colpos.ToString());
                            lvwPatient.Items.Add(lvi);
                        }
                    }
                }
                else
                {
                    btnSave.Enabled = false;
                    btnEdit.Enabled = true;
                    List<CalenderOT> objcal = new List<CalenderOT>();
                    objcal = accmSc.DisplayDoctorsInformation("DisplayDoctorsInfo", strScheduleID.ToString()).ToList();
                    DGdown.Rows.Add(objcal.Count);
                    int j = 0;
                    foreach (CalenderOT cal in objcal)
                    {
                        DGdown[0, j].Value = cal.DoctorsCode.ToString();
                        DGdown[1, j].Value = cal.doctorsName.ToString();
                        j = j + 1;
                    }
                    txtNetTotal.Text = j.ToString();
                    //objcal = mDisplaySchedule(strSchedulingID.ToString());
                    objcal = accmSc.GetOTschedulingDetails("DisplayotScheduling", strScheduleID.ToString()).ToList();
                    //DGdown.Rows.Add(objcal.Count);
                    //int j = 0;
                    foreach (CalenderOT cal in objcal)
                    {
                        txtSchedulingID.Text = cal.ScheduleID.ToString();
                        //cboRegID.SelectedValue    = cal.RegNo.ToString();
                        txtPatientRegNo.Text = cal.RegNo.ToString();
                        btnSearch_Click(txtPatientRegNo.Text, e);
                        cboOperationtype.SelectedValue = cal.Oprtype.ToString();
                        cboOpearationName.SelectedValue = cal.OprID.ToString();
                        cboPackagename.SelectedValue = cal.PackageName.ToString();
                        txtStartTime.Text = cal.Fromtime.ToString();
                        txtendtime.Text = cal.Totime.ToString();
                        cbotheaterId.Text = TheaterName.ToString();
                        cboInchargeID.SelectedValue = cal.InchargeId.ToString();

                        if (cal.status == 0)
                        {
                            radNormal.Checked = true;
                            radEmergency.Checked = false;
                        }
                        else
                        {
                            radEmergency.Checked = true;
                            radNormal.Checked = false;
                        }
                        DateTime dtedate1 = Convert.ToDateTime(cal.RegDate.ToString());
                        txtStartDate.Text = dtedate1.ToString("dd/MM/yyyy");
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
        #endregion;
        #region "FixedKey"
        private string FixedMasterKey(string strCatName)
        {
            string strCateValue = "";
            switch (strCatName.ToString())
            {
                case "Surgeon":
                    strCateValue = "Surgeon" + "0000001";
                    break;
                case "RMO":
                    strCateValue = "RMO" + "0000001";
                    break;
                case "OT Nurse":
                    strCateValue = "OTNurse" + "0000001";
                    break;
                case "OT Technisian":
                    strCateValue = "OTTechnisian" + "0000001";
                    break;
                case "General Nurse":
                    strCateValue = "GeneralNurse" + "0000001";
                    break;
                case "Anesthesiologist":
                    strCateValue = "Anesthesiologist" + "0000001";
                    break;
                case "OT Helper":
                    strCateValue = "OTHelper" + "0000001";
                    break;
                case "Others":
                    strCateValue = "Others" + "0000001";
                    break;
                case "Assistant Surgeon":
                    strCateValue = "Assistant Surgeon" + "0000001";
                    break;
            }
            return strCateValue.ToString();
        }
        #endregion
        #region "Display"
        private void Getdisplay(string strCatName)
        {
            try
            {
                string strFixedValue;
                DGUP.Rows.Clear();
                strFixedValue = FixedMasterKey(strCatName.ToString());
                List<DoctorsCategory> objCat = accmSc.DisplayDoctorsCategory("DisplayCattype", strFixedValue).ToList();
                foreach (DoctorsCategory dc in objCat)
                {
                    maddItem(dc.doctorscode, dc.doctorsName);
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
        private void maddItem(string strDoctoreCode, string strDoctorName)
        {
            int selRaw;
            DGUP.AllowUserToAddRows = true;
            selRaw = Convert.ToInt16(DGUP.RowCount.ToString());
            selRaw = selRaw - 1;
            DGUP.Rows.Add(1);
            for (int i = 1; i < DGUP.Rows.Count; i++)
            {
                DGUP[0, selRaw].Value = strDoctoreCode.ToString();
                DGUP[1, selRaw].Value = strDoctorName.ToString();
            }
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
        #region "Grid"
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
        private void grid_column()
        {
            DGdown.Columns.Add(Create_Grid_Column("Doctors Code", "Doctors code", 80, true, DataGridViewContentAlignment.TopLeft, true));
            DGdown.Columns.Add(Create_Grid_Column("Doctors Name", "Doctors Name", 370, true, DataGridViewContentAlignment.TopLeft, true));
            DGdown.Columns.Add(Create_Grid_Column_button("Del", "Del", "Del", 40, true, DataGridViewContentAlignment.TopCenter, true));
        }
        private void Format_Grid()
        {
            DGUP.Columns.Add(Create_Grid_Column("Doctors Code", "Doctors code", 80, true, DataGridViewContentAlignment.TopLeft, true));
            DGUP.Columns.Add(Create_Grid_Column("Doctors Name", "Doctors Name", 370, true, DataGridViewContentAlignment.TopLeft, true));
            DGUP.Columns.Add(CreateChkBxGrd(" ", " ", 80, true, DataGridViewContentAlignment.TopCenter, false, false, "checkbox"));
        }
        #endregion
        #region "Category"
        private void cboDoctorsCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDoctorsCategory.SelectedIndex >= 0 || cboDoctorsCategory.SelectedIndex == -1)
            {
                Getdisplay(cboDoctorsCategory.Text.ToString());
            }
        }
        private void btnAttach_Click(object sender, EventArgs e)
        {
            opFile.Multiselect = true;
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                opFile.Filter = "allfiles|*";
                string strFileName = (opFile.FileName);
                string iFileName = strFileName.Substring(strFileName.LastIndexOf("\\") + 1);
                ListViewItem itm = new ListViewItem(strFileName);
                itm.SubItems.Add(iFileName);
                lvwDetails.Items.Add(itm);
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (lvwDetails.SelectedItems.Count > 0)
            {
                for (int lcount = 0; lcount <= lvwDetails.Items.Count - 1; lcount++)
                {
                    if (lvwDetails.Items[lcount].Selected == true)
                    {
                        System.Diagnostics.Process.Start(lvwDetails.Items[lcount].Text);
                        break;
                    }
                }
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvwDetails.Items.Count; i++)
            {
                if (lvwDetails.Items[i].Selected)
                {
                    lvwDetails.Items[i].Remove();
                    i--;
                }
            }
            
        }
        private void maddItemNew(string strDoctoreCode, string strDoctorName)
        {
                int selRaw;
                DGdown.AllowUserToAddRows = true;
                selRaw = Convert.ToInt16(DGdown.RowCount.ToString());
                selRaw = selRaw - 1;
                DGdown.Rows.Add(1);
                for (int i = 1; i < DGdown.Rows.Count; i++)
                {
                    DGdown[0, selRaw].Value = strDoctoreCode.ToString();
                    DGdown[1, selRaw].Value = strDoctorName.ToString();
                }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // for (int i = 0; i < DGdisplay.Rows.Count; i++)
            //{
            //    if (Convert.ToBoolean(DGdisplay.Rows[i].Cells["Status1"].Value) == true)
            //    {
            //        DGdisplay.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            //        maddItemNew(DGdisplay.Rows[i].Cells[0].Value.ToString(), DGdisplay.Rows[i].Cells[1].Value.ToString());
            //        DGdisplay.Rows[i].DefaultCellStyle.BackColor = Color.Beige;
            //    }
            //    else
            //    {
            //        DGdisplay.Rows[i].DefaultCellStyle.BackColor = Color.White;
            //    }
            //}
            for (int i = 0; i < DGUP.RowCount; i++)
            {
                if (Convert.ToBoolean(DGUP.Rows[i].Cells[2].Value) == true)
                {
                    if (DGUP[0, i].Value != null)
                    {
                        mAdditem(DGUP[0, i].Value.ToString(), DGUP[1, i].Value.ToString());
                    }
                }
            }


        }
        private void mAdditem(string strDoctorsCode, string strDoctorsName)
        {
            int selRaw;
            int intTotal = 0;
            string strDown = "";
            Boolean blngCheck = false;
            for (int j = 0; j < DGdown.RowCount; j++)
            {
                if (DGdown[0, j].Value != null)
                {
                    strDown = DGdown[0, j].Value.ToString();
                }
                if (strDoctorsCode == strDown.ToString())
                {
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
                    DGdown[0, selRaw].Value = strDoctorsCode.ToString();
                    DGdown[1, selRaw].Value = strDoctorsName.ToString();
                    intTotal = intTotal + 1;
                }
                txtNetTotal.Text =intTotal.ToString();
            }
          
        }
        #endregion

        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int intTotlal = 0;
            if (e.ColumnIndex == 2)
            {
                int selRowIndex = e.RowIndex;
                
                if (DGdown.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    DGdown.Rows.RemoveAt(selRowIndex);
                    intTotlal = Convert.ToInt16(txtNetTotal.Text) - 1;
                    txtNetTotal.Text = intTotlal.ToString();
                }
                else 
                {
                    if (txtNetTotal.Text != "")
                    {
                        intTotlal = Convert.ToInt16(txtNetTotal.Text) - 1;
                        if (intTotlal > 0)
                            txtNetTotal.Text = intTotlal.ToString();
                    }
                }
            }
        }
        #region "Populated"
        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "txtStartDate", "txtRemarks", "FloorNo", "txttheaterTitle", "txtNoofFacilities","txtRegNo" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            //if (cboRegID.Text == "")
            //{
            //    MessageBox.Show(Utility.getFMS(cboRegID.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    cboRegID.Focus();
            //    return false;
            //}

            if (cboInchargeID.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboInchargeID.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboInchargeID.Focus();
                return false;
            }

            if (cboPackagename.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboPackagename.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPackagename.Focus();
                return false;
            }

            if (cboOperationtype.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboOperationtype.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboOperationtype.Focus();
                return false;
            }

            if (cboOpearationName.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboOpearationName.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboOpearationName.Focus();
                return false;
            }

            if (DGdown.Rows.Count < 2)
            {
                MessageBox.Show("Cannt Empty");
                return false;
            }

            if (txtPatientRegNo.Text == "")
            {
                MessageBox.Show(Utility.getFMS(txtRegID.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegID.Focus();
                return false;
            }

            return true;
        }
        private CalenderOT PopulateCalender()
        {

            CalenderOT cal = new CalenderOT();
            if (txtSchedulingID.Text.ToString() != "")
            {
                cal.ScheduleID = txtSchedulingID.Text.ToString();
            }
            else
            {
                cal.ScheduleID = "";
            }
            cal.RegDate = txtStartDate.Text.ToString();
            cal.InchargeId = cboInchargeID.SelectedValue.ToString();
            cal.PackageId = cboPackagename.SelectedValue.ToString();
            //cal.PatientId = cboRegID.Text.ToString();
            //cal.PatientId = cboRegID.SelectedValue.ToString();
            cal.PatientId = txtPatientRegNo.Text.ToString();
            cal.TheterId = cbotheaterId.SelectedValue.ToString();
            cal.Fromtime  = txtStartTime.Text.ToString();
            cal.Totime = txtendtime.Text.ToString();
            if (radNormal.Checked == true)
            {
                cal.status = 0;
            }
            else
            {
                cal.status = 1;
            }

            cal.Comments = txtComments.Text.ToString();
            cal.Oprtype = cboOperationtype.SelectedValue.ToString();
            cal.OprID = cboOpearationName.SelectedValue.ToString();
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            cal.EntryParameter = ep;
            return cal ;
        }
        #endregion
        #region "Save"
        private void btnSave_Click(object sender, EventArgs e)
        {
            string strDoctorsFCode;
            string strDoctorsTCode;
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {

                CalenderOT objCal;
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    objCal = this.PopulateCalender();

                    for (int i = 0; i < DGdown.Rows.Count - 1; i++)
                    {
                        DateTime dtedate = Convert.ToDateTime(objCal.RegDate);
                        string strRegDate = dtedate.ToString("ddMMyyy");

                        strDoctorsFCode = DGdown.Rows[i].Cells[0].Value.ToString() + strRegDate + txtStartTime.Text.Trim();
                        strDoctorsTCode = DGdown.Rows[i].Cells[0].Value.ToString() + strRegDate + txtendtime.Text.Trim();
                        if (Utility.IsDuplicateFoundInList(lvwDoctorsAvail, 1, strDoctorsFCode) == true)
                        {
                            MessageBox.Show("Doctors is Not Available: " + strDoctorsTCode, " AGH Operation");
                            return;
                        }
                        if (Utility.IsDuplicateFoundInList(lvwDoctorsAvail, 2, strDoctorsTCode) == true)
                        {
                            MessageBox.Show("Doctors is Not Available: " + strDoctorsTCode, " AGH Operation");
                            return;
                        }

                    }
                    string strSchedule = accmSc.SavedOperationSchedulingMaster(objCal);
                    if (strSchedule == "0")
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (strSchedule != "0")
                    {
                        for (int j = 0; j < lvwPatient.Items.Count; j++)
                        {
                            int k = accmSc.SavedOperationSchedulingChild(strSchedule.ToString(), objCal.RegDate,
                                                                       Convert.ToInt32(lvwPatient.Items[j].SubItems[1].Text),
                                                                        Convert.ToInt32(lvwPatient.Items[j].SubItems[2].Text), objCal.TheterId,
                                                                        lvwPatient.Items[j].SubItems[0].Text, objCal.EntryParameter.EntryBy.ToString(),
                                                                        Convert.ToInt32(objCal.EntryParameter.Version), objCal.EntryParameter.CompanyID.ToString(), objCal.EntryParameter.LocationID.ToString(),
                                                                        objCal.EntryParameter.MachineID.ToString());
                        }


                        for (int i = 0; i < DGdown.Rows.Count - 1; i++)
                        {
                            DateTime dtedate = Convert.ToDateTime(objCal.RegDate);
                            string strRegDate = dtedate.ToString("ddMMyyy");

                            strDoctorsFCode = DGdown.Rows[i].Cells[0].Value.ToString() + strRegDate + txtStartTime.Text.Trim();
                            strDoctorsTCode = DGdown.Rows[i].Cells[0].Value.ToString() + strRegDate + txtendtime.Text.Trim();
                            int k = accmSc.SavedOTteam(strSchedule.ToString(), DGdown.Rows[i].Cells[0].Value.ToString(),
                                                                      objCal.EntryParameter.EntryBy.ToString(),
                                                                      Convert.ToInt32(objCal.EntryParameter.Version),
                                                                      objCal.EntryParameter.CompanyID.ToString(),
                                                                      objCal.EntryParameter.LocationID.ToString(),
                                                                      objCal.EntryParameter.MachineID.ToString(), strDoctorsFCode, strDoctorsTCode);
                        }
                        btnNew.PerformClick();
                        frmOTCalender frm = new frmOTCalender(cboPackagename.SelectedValue.ToString(), txtStartDate.Text.ToString());
                        this.Dispose();
                        //txttheaterId.Focus();
                        //LoadListView();
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
        private bool blnCheckDoctors(string strFcode, string strTCode)
        {
            string strDoctorsCode1, strDoctorsCode2;
            
            for (int l = 0; l < lvwDoctorsAvail.Items.Count; l++)
            {
                strDoctorsCode1 = lvwDoctorsAvail.Items[l].SubItems[1].Text;
                strDoctorsCode2 = lvwDoctorsAvail.Items[l].SubItems[2].Text;
                if (strDoctorsCode1 == strFcode)
                {
                    return true;
                }
                if (strDoctorsCode2 == strTCode)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            CalenderOT objCal;
            string strDoctorsFCode = "";
            string strDoctorsTCode = "";
            //if (Utility.IsDuplicateFoundInList(lvwTheaterConfig, 1, txttheaterId.Text) == true)
            //{
            //    MessageBox.Show("Cannot Insert Duplicate Value", "AGH Operation");
            //    return;
            //}
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    objCal = this.PopulateCalender();
                    for (int i = 0; i < DGdown.Rows.Count - 1; i++)
                    {
                        DateTime dtedate = Convert.ToDateTime(objCal.RegDate);
                        string strRegDate = dtedate.ToString("ddMMyyy");

                        strDoctorsFCode = DGdown.Rows[i].Cells[0].Value.ToString() + strRegDate + txtStartTime.Text.Trim();
                        strDoctorsTCode = DGdown.Rows[i].Cells[0].Value.ToString() + strRegDate + txtendtime.Text.Trim();
                        if (blnCheckDoctors(strDoctorsFCode, strDoctorsTCode) == false)
                        {
                            if (Utility.IsDuplicateFoundInList(lvwDoctorsAvail, 1, strDoctorsFCode) == true)
                            {
                                MessageBox.Show("Doctors is Not Available: " + strDoctorsFCode, " AGH Operation");
                                return;
                            }
                            if (Utility.IsDuplicateFoundInList(lvwDoctorsAvail, 2, strDoctorsTCode) == true)
                            {
                                MessageBox.Show("Doctors is Not Available: " + strDoctorsTCode, " AGH Operation");
                                return;
                            }
                        }
                    }

                    string strSchedule = accmSc.UpdateOperationSchedulingMaster(objCal);
                    if (strSchedule == "0")
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (strSchedule != "0")
                    {
                        for (int i = 0; i < DGdown.Rows.Count - 1; i++)
                        {
                            DateTime dtedate = Convert.ToDateTime(objCal.RegDate);
                            string strRegDate = dtedate.ToString("ddMMyyy");
                            strDoctorsFCode = DGdown.Rows[i].Cells[0].Value.ToString() + strRegDate + txtStartTime.Text.Trim();
                            strDoctorsTCode = DGdown.Rows[i].Cells[0].Value.ToString() + strRegDate + txtendtime.Text.Trim();
                            int k = accmSc.SavedOTteam(txtSchedulingID.Text.ToString(), DGdown.Rows[i].Cells[0].Value.ToString(),
                                                                      objCal.EntryParameter.EntryBy.ToString(),
                                                                      Convert.ToInt32(objCal.EntryParameter.Version),
                                                                      objCal.EntryParameter.CompanyID.ToString(),
                                                                      objCal.EntryParameter.LocationID.ToString(),
                                                                      objCal.EntryParameter.MachineID.ToString(), strDoctorsFCode, strDoctorsTCode);
                        }

                        btnNew.PerformClick();
                        frmOTCalender frm = new frmOTCalender(cboPackagename.SelectedValue.ToString(), txtStartDate.Text.ToString());
                        this.Dispose();
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
        #region "Selected Index"
        //private void cboRegID_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboRegID.Text != "Select")
        //    {
        //        txtRegID.Text =  "Reg. ID: " + cboRegID.SelectedValue.ToString();
        //    }
        //}
        private void LoadOTnameFromOTtype(string strWhere)
        {
            if (strWhere != "")
            {
                cboOpearationName.ValueMember = "Key";
                cboOpearationName.DisplayMember = "Value";
                //cboRegID.DataSource = new BindingSource(accmSc.GetTheaterBed("TheaterDep"), null);
                cboOpearationName.DataSource = new BindingSource(accmSc.GetOTnameFromOTtype(strWhere), null);
            }
        }
        private void cboOperationtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOperationtype.SelectedIndex > 0 || cboOperationtype.SelectedIndex == -1)
            {
                LoadOTnameFromOTtype(cboOperationtype.SelectedValue.ToString());
            }
        }
        #endregion
        private void clear()
        {
            txtPatName.Text = "";
            txtRoomNo.Text = "";
            txtBedNo.Text = "";
            txtWardNo.Text = "";
        }
        private void GetPatientDetails(string strRegNo)
        {
            InPatient opjPat = accmSc.GetAdmittedPatient(strRegNo);
            try
            {
                clear();
                txtPatName.Text = opjPat.Name.ToString();
                txtRoomNo.Text = opjPat.Room.RoomTitle.ToString();
                txtBedNo.Text = opjPat.Bed.BedTitle.ToString();
                //txtWardNo.Text = opjPat.Ward.WardNo;
            }
         

            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                clear();
                MessageBox.Show("Invalid Reg ID");
            }



        }
        #region "Search"
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                GetPatientDetails(txtPatientRegNo.Text);
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
        private void txtPatientRegNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPatientRegNo.TextLength == Utility.ScanLength)
            {
                btnSearch_Click(sender, e);
            }
        }
        #endregion

        private void txtPati0entRegNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtPatientRegNo.TextLength == Utility.ScanLength)
                {
                    btnSearch_Click(sender, e);
                }
            }
        }
    }
}
