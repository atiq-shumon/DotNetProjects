using AH.ModuleController.OPDSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;


namespace AH.ModuleController.UI.OPD.Forms
{
    public partial class frmNurseCalling : AH.Shared.UI.frmSmartFormStandard
    {
        private OPDSR.OPDWSClient clnt = new OPDWSClient();
        private string NsStnID = "";
        public frmNurseCalling(string roomGrp)
        {
            InitializeComponent();
            
            this.NsStnID = roomGrp;
        }

        int Postcur = 0;

        public void StyleDGDoctor()
        {
            grdDoctor.ClearSelection();
            #region ColumnSize
            grdDoctor.Columns["PatientCount"].HeaderText = "Patient";
            grdDoctor.Columns["DepertmentName"].Width = 80;
            grdDoctor.Columns["DoctorName"].Width = 100;
            grdDoctor.Columns["RoomNo"].Width = 70;
            grdDoctor.Columns["DoctorStatus"].Width = 50;
            grdDoctor.Columns["DepertmentName"].HeaderText = "Department";
            grdDoctor.Columns["DoctorName"].HeaderText = "Doctor";
            grdDoctor.Columns["RoomNo"].HeaderText = "Room";
            grdDoctor.Columns["DoctorStatus"].HeaderText = "Status";
            grdDoctor.Columns["DepertmentName"].DisplayIndex = 0;
            grdDoctor.Columns["DoctorName"].DisplayIndex = 1;
            grdDoctor.Columns["RoomNo"].DisplayIndex = 2;
            grdDoctor.Columns["DoctorStatus"].DisplayIndex = 3;
            #endregion
            #region ColumnVisibility
            #region VisibleFalse
            grdDoctor.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            grdDoctor.EnableHeadersVisualStyles = false;
            grdDoctor.Columns["UnitId"].Visible = false;
            grdDoctor.Columns["Doc_ID"].Visible = false;
            grdDoctor.Columns["NurseID"].Visible = false;
            grdDoctor.Columns["NStationID"].Visible = false;
            grdDoctor.Columns["DT"].Visible = false;
            grdDoctor.Columns["Dept_ID"].Visible = false;
            grdDoctor.Columns["TicketNo"].Visible = false;
            grdDoctor.Columns["UnitName"].Visible = false;
            #endregion
            #endregion
            #region Readonly
            grdDoctor.Columns["DoctorName"].ReadOnly = true;
            grdDoctor.Columns["DepertmentName"].ReadOnly = true;
            grdDoctor.Columns["RoomNo"].ReadOnly = true;
            grdDoctor.Columns["PatientCount"].ReadOnly = true;
            #endregion
        }
        public void StyleDGPatient()
        {
            grdPatient.AllowUserToOrderColumns = false;
            grdDoctor.ClearSelection();
            #region ColumnSize 463
            grdPatient.Columns["PatientName"].Width = 197;
            grdPatient.Columns["TicketNo"].Width = 80;
            grdPatient.Columns["Age"].Width = 63;
            grdPatient.Columns["Tkt_Status"].Width = 60;
            grdPatient.Columns["PatSerial"].Width = 60;

            grdPatient.Columns["PatientName"].HeaderText = "Name";
            grdPatient.Columns["Age"].HeaderText = "Age";
            grdPatient.Columns["TicketNo"].HeaderText = "MR No";
            grdPatient.Columns["Tkt_Status"].HeaderText = "Status";
            grdPatient.Columns["PatSerial"].HeaderText = "Serial";

            #endregion
            #region ColumnVisibility
            #region VisibleTrue
            grdPatient.Columns["PatientName"].Visible = true;
            grdPatient.Columns["TicketNo"].Visible = true;
            grdPatient.Columns["Age"].Visible = true;
            grdPatient.Columns["Tkt_Status"].Visible = true;
            grdPatient.Columns["PatSerial"].Visible = true;
            grdPatient.Columns["PatientName"].DisplayIndex = 3;
            grdPatient.Columns["Age"].DisplayIndex = 1;
            grdPatient.Columns["TicketNo"].DisplayIndex = 0;
            grdPatient.Columns["Tkt_Status"].DisplayIndex = 2;
            grdPatient.Columns["PatSerial"].DisplayIndex = 4;

            #endregion
            #region VisibleFalse
            grdPatient.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            grdPatient.EnableHeadersVisualStyles = false;
            grdPatient.Columns["DoctorName"].Visible = false;
            grdPatient.Columns["DepertmentName"].Visible = false;
            grdPatient.Columns["RoomNo"].Visible = false;
            grdPatient.Columns["HCN"].Visible = false;
            grdPatient.Columns["Staff_ID"].Visible = false;
            grdPatient.Columns["Case_ID"].Visible = false;
            grdPatient.Columns["TransactionNo"].Visible = false;
            grdPatient.Columns["Tkt_Type_ID"].Visible = false;
            grdPatient.Columns["Tkt_Cat"].Visible = false;
            grdPatient.Columns["Dept_ID"].Visible = false;
            grdPatient.Columns["Unit_ID"].Visible = false;
            grdPatient.Columns["UnitName"].Visible = false;
            grdPatient.Columns["TKT_Valid"].Visible = false;
            grdPatient.Columns["Copy_Printed"].Visible = false;
            grdPatient.Columns["PreviousTicketNo"].Visible = false;
            grdPatient.Columns["TicketFee"].Visible = false;
            grdPatient.Columns["Consult_fee"].Visible = false;
            grdPatient.Columns["Refd_fee"].Visible = false;
            grdPatient.Columns["Dept_fee"].Visible = false;
            grdPatient.Columns["Discount"].Visible = false;
            grdPatient.Columns["VAT"].Visible = false;
            grdPatient.Columns["VoucherNo"].Visible = false;
            grdPatient.Columns["TotalAmount"].Visible = false;
            grdPatient.Columns["EntryDate"].Visible = false;
            grdPatient.Columns["Sex"].Visible = false;
            grdPatient.Columns["Address"].Visible = false;
            grdPatient.Columns["MobileNo"].Visible = false;
            grdPatient.Columns["HomePhone"].Visible = false;
            grdPatient.Columns["DOB"].Visible = false;
            grdPatient.Columns["DoctorID"].Visible = false;
            grdPatient.Columns["EntryBy"].Visible = false;
            grdPatient.Columns["DoctorStatus"].Visible = false;
            grdPatient.Columns["AppointmentID"].Visible = false;
            grdPatient.Columns["CashAmount"].Visible = false;
            grdPatient.Columns["CreditCardAmount"].Visible = false;
            grdPatient.Columns["DebitCardAmount"].Visible = false;
           // grdPatient.Columns["PatSerial"].Visible = false;
            
            #endregion
            #endregion
            #region Readonly
            grdPatient.Columns["PatientName"].ReadOnly = true;
            grdPatient.Columns["Age"].ReadOnly = true;
            grdPatient.Columns["TicketNo"].ReadOnly = true;
            grdPatient.Columns["Tkt_Status"].ReadOnly = true;
            grdPatient.Columns["PatSerial"].ReadOnly = true;
            #endregion

       /*   DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            grdPatient.Columns.Add(btn);
            btn.HeaderText = "SendToVisit";
            btn.Text = "SendToVisit";
            btn.Name = "btn";
           // btn.DisplayIndex = 4;
            btn.DefaultCellStyle.ForeColor = Color.Navy;
            btn.UseColumnTextForButtonValue = true;
            btn.Width = 120;  */

        }

        public class CheckDuplicateDoctor
        {
            public string DoctorID { get; set; }
        }

        //private void DoctorLoad()  //....................
        //{
        //    List<OPDTicketRO> oOpdTicketROs = new List<OPDTicketRO>();
        //    lblDoctor.Text = "";
        //    oOpdTicketROs = clnt.GetsOPDDoctorName().ToList();

        //    if (oOpdTicketROs.Count > 0)
        //    {
        //        grdDoctor.DataSource = null;
        //        grdDoctor.DataSource = oOpdTicketROs;
        //        StyleDGDoctor();
        //        for (int i = 0; i < oOpdTicketROs.Count; i++)
        //        {
        //            if (oOpdTicketROs[i].DoctorStatus == "F")
        //            {
        //                for (int j = 0; j < grdDoctor.Rows.Count; j++)
        //                {
        //                    if (Convert.ToString(grdDoctor.Rows[j].Cells["RoomNo"].Value) == oOpdTicketROs[i].RoomNo)
        //                    {
        //                        //grdDoctor.Rows[j].DefaultCellStyle.BackColor = GetRandomColour();
        //                        //grdDoctor.Rows[j].Cells["RoomNo"].Style.BackColor = GetRandomColour();
        //                        grdDoctor.Rows[j].Cells["RoomNo"].Style.BackColor = Color.Red;
        //                    }
        //                }
        //            }
        //        }

        //        grdDoctor.ClearSelection();
        //    }
        //    if (oOpdTicketROs.Count <= 0)
        //    {
        //        lblDoctor.Text = "No Doctor Available";
        //        grdDoctor.DataSource = null;
        //    }

        //}

        private void DoctorLoadCallQ()
        {
            List<OPDDoctorCallQ> oOPDDrCQs = new List<OPDDoctorCallQ>();
            lblDoctor.Text = "";
            oOPDDrCQs = clnt.GetsOPDDoctorName().ToList();
            List<OPDDoctorCallQ> oTmps = new List<OPDDoctorCallQ>();
            if (oOPDDrCQs.Count > 0)
            {
                //var list =  from c in oOPDDrCQs Select new{ Name=c.M, DepartmentName=c.Department.DepartmentName, Roll=c.Roll }).ToList();
                var distinctKeys = oOPDDrCQs.Select(e => new { e.Doc_ID, e.DoctorName, e.RoomNo, e.DoctorStatus, e.DepertmentName, e.Dept_ID, e.PatientCount })
                            .Distinct().ToList();

                for (int i = 0; i < distinctKeys.Count; i++)
                {
                    OPDDoctorCallQ oTmpDQ = new OPDDoctorCallQ();
                    oTmpDQ.DepertmentName = distinctKeys[i].DepertmentName;
                    oTmpDQ.Dept_ID = distinctKeys[i].Dept_ID;
                    oTmpDQ.Doc_ID = distinctKeys[i].Doc_ID;
                    oTmpDQ.DoctorName = distinctKeys[i].DoctorName;
                    oTmpDQ.RoomNo = distinctKeys[i].RoomNo;
                    oTmpDQ.DoctorStatus = distinctKeys[i].DoctorStatus;
                    oTmpDQ.PatientCount = distinctKeys[i].PatientCount;
                    oTmps.Add(oTmpDQ);
                }

                grdDoctor.DataSource = null;
                grdDoctor.DataSource = oTmps;
                StyleDGDoctor();
                for (int i = 0; i < oTmps.Count; i++)
                {
                    if (oTmps[i].DoctorStatus == "F")
                    {
                        for (int j = 0; j < grdDoctor.Rows.Count; j++)
                        {
                            if (Convert.ToString(grdDoctor.Rows[j].Cells["RoomNo"].Value) == oTmps[i].RoomNo && Convert.ToString(grdDoctor.Rows[j].Cells["Doc_ID"].Value) == oTmps[i].Doc_ID)
                            {
                                //grdDoctor.Rows[j].DefaultCellStyle.BackColor = GetRandomColour();
                                //grdDoctor.Rows[j].Cells["RoomNo"].Style.BackColor = GetRandomColour();
                                grdDoctor.Rows[j].Cells["RoomNo"].Value.ToString();//.Style.BackColor = Color.Red;
                            }
                        }
                    }
                }
                grdDoctor.ClearSelection();
            }
            if (oOPDDrCQs.Count <= 0)
            {
                lblDoctor.Text = "No Doctor Available";
                grdDoctor.DataSource = null;
            }

        }

        public readonly Random rand = new Random();
        private Color GetRandomColour()
        {
            return Color.FromArgb(this.rand.Next(256), this.rand.Next(256), this.rand.Next(256));
        }

        private void InsertDoct()
        {
            List<OPDDoctorCallQ> oOPDDrCQs = new List<OPDDoctorCallQ>();
            lblDoctor.Text = "";
            oOPDDrCQs = clnt.InsDrRoom("1").ToList();
        }

        //string NsStnID = roomGrp;
        private void frmNurseCalling_Load(object sender, EventArgs e)
        {
            List<OPDDoctorCallQ> doctorsListTemp = new List<OPDDoctorCallQ>();
            doctorsListTemp.AddRange(clnt.GetDoctorsList(NsStnID).ToList<OPDDoctorCallQ>());
            if (doctorsListTemp.Count > 0)
            {
                dgvDoctorsList.BackgroundColor = Color.AliceBlue;
                grdPatient.BackgroundColor = Color.AliceBlue;
                FormatGridView(dgvDoctorsList);
                DoctorLoad(NsStnID);
                // InsertDoct();
                // DoctorLoadCallQ();
                //tFunctionCall.Start();    // temporarily commented
                lblHistory.Text = "";
                treePatientHistory.DataSource = null;
                tabPage1.Name = "Standard";
                tabPage1.Name = "Metric";

                //---------visible false
                //txtAllergy.Enabled = false;
                //chkHypertension.Checked = true;
                StyleDGPatient();

                lblStationNumber.Text = NsStnID;
            }
            else
            {
                lblStationNumber.Text = NsStnID;
                MessageBox.Show("No Doctor in this Nursing Station Yet!!!");  
            }
        }
        private void FormatGridView(DataGridView dtv)
        {
            dtv.AutoGenerateColumns = true;
            #region Doctors Name
            DataGridViewTextBoxColumn colDoctorsName = new DataGridViewTextBoxColumn();
            colDoctorsName.Name = "DoctorsName";
            colDoctorsName.DataPropertyName = "DoctorsName";
            colDoctorsName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colDoctorsName.Width = 150;
            colDoctorsName.Visible = true;
            dtv.Columns.Add(colDoctorsName);
            #endregion
            #region Doctors ID
            DataGridViewTextBoxColumn colDoctorsID = new DataGridViewTextBoxColumn();
            colDoctorsID.Name = "DoctorsID";
            colDoctorsID.DataPropertyName = "DoctorsID";
            colDoctorsID.Width = 0;
            colDoctorsID.Visible = false;
            dtv.Columns.Add(colDoctorsID);
            #endregion
            #region Doctors Status
            DataGridViewTextBoxColumn colDoctorsStatus = new DataGridViewTextBoxColumn();
            colDoctorsStatus.Name = "Status";
            colDoctorsStatus.DataPropertyName = "Status";
            colDoctorsStatus.Width = 50;
            colDoctorsStatus.Visible = true;
            dtv.Columns.Add(colDoctorsStatus);
            #endregion
            #region DepartmentID
            DataGridViewTextBoxColumn colDepartmentID = new DataGridViewTextBoxColumn();
            colDepartmentID.Name = "DepartmentID";
            colDepartmentID.DataPropertyName = "DepartmentID";
            colDepartmentID.Width = 0;
            colDepartmentID.Visible = false;
            dtv.Columns.Add(colDepartmentID);
            #endregion
            #region DepartmentName
            DataGridViewTextBoxColumn colDepartmentName = new DataGridViewTextBoxColumn();
            colDepartmentName.Name = "Department";
            colDepartmentName.DataPropertyName = "Department";
           // colDepartmentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colDepartmentName.Width =89;
            colDepartmentName.Visible = true;
            dtv.Columns.Add(colDepartmentName);
            #endregion
            #region UnitID
            DataGridViewTextBoxColumn colUnitID = new DataGridViewTextBoxColumn();
            colUnitID.Name = "UnitID";
            colUnitID.DataPropertyName = "UnitID";
            colUnitID.Width = 0;
            colUnitID.Visible = false;
            dtv.Columns.Add(colUnitID);
            #endregion
            #region DepartmentUnit
            DataGridViewTextBoxColumn colDepartmentUnit = new DataGridViewTextBoxColumn();
            colDepartmentUnit.Name = "Unit";
            colDepartmentUnit.DataPropertyName = "Unit";
            colDepartmentUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //colDepartmentUnit.Width = 90;
            colDepartmentUnit.Visible = true;
            dtv.Columns.Add(colDepartmentUnit);
            #endregion
            #region PatientCount
            DataGridViewTextBoxColumn colPatientCount = new DataGridViewTextBoxColumn();
            colPatientCount.Name = "Patient";
            colPatientCount.DataPropertyName = "Patient";
            colPatientCount.Width = 55;
            colPatientCount.Visible = true;
            dtv.Columns.Add(colPatientCount);
            #endregion

            #region Room No
            DataGridViewTextBoxColumn colRoomNo = new DataGridViewTextBoxColumn();
            colRoomNo.Name = "RoomNo";
            colRoomNo.DataPropertyName = "RoomNo";
            colRoomNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
           // colRoomNo.Width = 70;
            colRoomNo.Visible = false;
            dtv.Columns.Add(colRoomNo);
            #endregion
            #region Room
            DataGridViewTextBoxColumn colRoom = new DataGridViewTextBoxColumn();
            colRoom.Name = "Room";
            colRoom.DataPropertyName = "Room";
           // colRoom.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colRoom.Width = 47;
            colRoom.Visible = true;
            dtv.Columns.Add(colRoom);
            #endregion
        }
        private void DoctorLoad(string NsStnID)
        {
            List<OPDDoctorCallQ> doctorsList = new List<OPDDoctorCallQ>();
            doctorsList.AddRange(clnt.GetDoctorsList(NsStnID).ToList<OPDDoctorCallQ>());
            if (doctorsList.Count > 0)
            {
                dgvDoctorsList.DataSource = doctorsList.Select (data => new
                {
                    DoctorsName = data.DoctorName,
                    DoctorsID = data.Doc_ID,
                    Status = data.DoctorStatus,
                    DepartmentID = data.Dept_ID,
                    Department = data.DepertmentName,
                    UnitID = data.UnitId,
                    Unit = data.UnitName,
                    Patient = data.PatientCount,
                    RoomNo = data.RoomNo,
                    Room = data.Room,
                    
                }).ToList();
            }
            else
            {
               // MessageBox.Show("There is no Doctor in OPD Yet!!! ");
            }
        }

        private void dgvDoctorsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dgvDocListChange();
        }
        private void dgvDocListChange()
        {
            clean();
            treePatientHistory.DataSource = null;
            lblHistory.Text = "";
            Doc_ID = "";
            if (this.dgvDoctorsList.CurrentRow != null)
            {
                Postcur = 0;
                lblPatient.Text = "";
                int position = dgvDoctorsList.CurrentRow.Index;
                Postcur = Convert.ToInt16(position);
                string RoomNo = dgvDoctorsList.Rows[position].Cells["RoomNo"].Value.ToString();
                string DocID = dgvDoctorsList.Rows[position].Cells["DoctorsID"].Value.ToString();
                Doc_ID = DocID;
                List<OPDTicketRO> oOpdTicROs = new List<OPDTicketRO>();
                oOpdTicROs = clnt.GetsOPDDocRoomNo(RoomNo, DocID).ToList();
                grdPatient.DataSource = oOpdTicROs;
               // if (oOpdTicROs.Count > 0)
               // {

               // }

                //if (oOpdTicROs.Count > 0)
                //{
                //    grdPatient.DataSource = null;
                //    //grdPatient.DataSource = oOpdTicROs;
                //  //  StyleDGPatient();
                //    //grdPatient.ClearSelection();
                //    //grdPatient.CurrentRow.Index = Convert.ToInt32(txtserial.Text);
                //    //int p = grdPatient.CurrentRow.Index;
                //    //txtserial.Text = Convert.(position);
                //    //dgvDoctorsList.Rows[position].Cells["RoomNo"].Style.BackColor = Color.White;
                //}
                //if (oOpdTicROs.Count <= 0)
                //{
                //    lblPatName.Text = "";
                //    lblPatient.Location = new System.Drawing.Point(686, 9);
                //    lblPatient.Text = "No Patient Available";
                //    grdPatient.DataSource = null;
                //}
            }
        }
        private void tFunctionCall_Tick(object sender, EventArgs e)
        {
            DoctorLoad(NsStnID);
        }

        string Doc_ID = "";
        private void grdDoctor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            treePatientHistory.DataSource = null;
            lblHistory.Text = "";
            Doc_ID = "";
            if (this.grdDoctor.CurrentRow != null)
            {
                Postcur = 0;
                lblPatient.Text = "";
                int position = grdDoctor.CurrentRow.Index;
                Postcur = Convert.ToInt16(position);
                string RoomNo = grdDoctor.Rows[position].Cells["RoomNo"].Value.ToString();
                string DocID = grdDoctor.Rows[position].Cells["Doc_ID"].Value.ToString();
                Doc_ID = DocID;
                List<OPDTicketRO> oOpdTicROs = new List<OPDTicketRO>();
                oOpdTicROs = clnt.GetsOPDDocRoomNo(RoomNo, DocID).ToList();
                if (oOpdTicROs.Count > 0)
                {
                    grdPatient.DataSource = null;
                    grdPatient.DataSource = oOpdTicROs;
                    //StyleDGPatient();
                    grdPatient.ClearSelection();
                    grdDoctor.Rows[position].Cells["RoomNo"].Style.BackColor = Color.White;
                    //grdDoctor.Rows[position].DefaultCellStyle.BackColor = Color.White;
                }

                if (oOpdTicROs.Count <= 0)
                {
                    lblPatient.Location = new System.Drawing.Point(560, 9);
                    lblPatient.Text = "No Patient Available";
                    grdPatient.DataSource = null;
                }
            }
        }
        private void grdPatient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (this.grdPatient.CurrentRow != null)
            //{
            //    lblPatient.Text = "";
            //    int position = grdPatient.CurrentRow.Index;
            //    string PatientMR = grdPatient.Rows[position].Cells["TicketNo"].Value.ToString();
            //    lblPatName.Text = grdPatient.Rows[position].Cells["PatientName"].Value.ToString();
            //    string RoomNo = grdPatient.Rows[position].Cells["RoomNo"].Value.ToString();
            //    List<OPDTicketRO> oOpdTicROs = new List<OPDTicketRO>();

                //oOpdTicROs = clnt.ChangePatientStatus(PatientMR, RoomNo, Doc_ID).ToList();
                //grdPatient.DataSource = null;
                //grdPatient.DataSource = oOpdTicROs;
                ////if (oOpdTicROs.Count > 0)
                //{
                //    grdPatient.DataSource = null;
                //    grdPatient.DataSource = oOpdTicROs;
                // //   StyleDGPatient();
                //    grdPatient.ClearSelection();
                //    //grdPatient.DataSource = null;
                //    treePatientHistory.DataSource = null;
                //    //grdDoctor.Rows[Postcur].Cells["TicketNo"].Style.BackColor = Color.White;
                //    //grdDoctor.Rows[position].DefaultCellStyle.BackColor = Color.White;
                //}
                //if (oOpdTicROs.Count <= 0)
                //{
                //    lblPatient.Text = "No Patient Available";
                //    grdPatient.DataSource = null;
                //    lblPatName.Text = "";
                //}
              //  return;
           // }
        }
        private string hcntemp = "";
        List<PatHistoryTree> oPatTrees = new List<PatHistoryTree>();
        private List<PatHistoryTree> Orderby(List<PatHistoryTree> oPatTrees)
        {
            oPatTrees.OrderBy(x => x.VisitAndDept);
            return oPatTrees;
        }
        private void linkLabel1_Click(object sender, EventArgs e)
        {
            DoctorLoad(NsStnID);
            clean();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            lblHistory.Text = "";
            treePatientHistory.DataSource = null;
            TreeGenerate();
            return;
        }

        private void TreeGenerate()
        {
            lblHistory.Text = "";

            if (this.grdPatient.CurrentRow == null)
            {
                MessageBox.Show("Select Patient to find History");
                return;
            }
            if (this.grdPatient.CurrentRow != null)
            {
                int position = grdPatient.CurrentRow.Index;
                hcntemp = grdPatient.Rows[position].Cells["HCN"].Value.ToString(); ;
            }

            treePatientHistory.DataSource = null;
            treePatientHistory.RemoveAllGroups();
            oPatTrees = clnt.GetsTree(hcntemp).ToList();
            if (oPatTrees.Count <= 0)
            {
                lblHistory.Text = "No History available for this Patient";
                return;
            }
            Orderby(oPatTrees);
            treePatientHistory.ExpandAll();
            //treePatientHistory.DataSource = oPatTrees;
            //treePatientHistory.SetLeafData("Result", "ResultDetails", "ResultDetails", 0, 0);
            //treePatientHistory.AddGroup("Date", "VisitAndDept", "VisitAndDept", "VisitAndDept", 0, 0);
            //treePatientHistory.AddGroup("Tree", "TreeGroup", "TreeGroup", "TreeGroup", 0, 0);
            //treePatientHistory.AddGroup("Name", "Name", "Name", "Name", 0, 0);

            treePatientHistory.SetLeafData("Result", "ResultDetails", "ResultDetails", 0, 0);
            treePatientHistory.AddGroup("Date", "VisitAndDept", "VisitAndDept", "VisitAndDept", 0, 0);
            treePatientHistory.AddGroup("Tree", "TreeGroup", "TreeGroup", "TreeGroup", 0, 0);
            treePatientHistory.AddGroup("Name", "Name", "Name", "Name", 0, 0);

            treePatientHistory.BuildTree();
            //j = oPatTrees.Count;

            for (int i = 0; i < treePatientHistory.Nodes.Count; i++)
            {
                treePatientHistory.Nodes[i].ForeColor = Color.DarkRed;
                treePatientHistory.Nodes[i].NodeFont = new Font("Callibri", 8, FontStyle.Bold);

                for (int p = 0; p < treePatientHistory.Nodes[i].Nodes.Count; p++)
                {
                    treePatientHistory.Nodes[i].Nodes[p].ForeColor = Color.DarkBlue; //GetRandomColour();
                    treePatientHistory.Nodes[i].Nodes[p].NodeFont = new Font("Callibri", 8, FontStyle.Bold);
                }
            }
        }
        #region BMICalculation
        private void btnBMICaculation_Click(object sender, EventArgs e)
        {
            lblBmiStatus.Text = "";
            if (smartTab1.SelectedIndex == 0)
            {
                if (txtHeightF.Text != "0" && txtWeightKg1.Text != "0")
                {
                    List<string> vf = new List<string>() { "txtHeightF", "txtHeightI", "txtWeightPound", "txtWeightKg1" };
                    Control control = Utility.ReqFieldValidator(this, vf);
                    if (control != null)
                    {
                        MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control.Focus();
                        return;
                    }
                   // string inch2Feet = Convert.ToString(/*Math.Round(*/(Double.Parse(txtHeightI.Text) * 0.0833333)/*, 5)*/);              
                    //double h = (Convert.ToDouble(txtHeightF.Text) + Convert.ToDouble(inch2Feet));
                    //string h1 = txtHeightF.Text + "." + txtHeightI.Text;
                    //double height = Math.Round((Double.Parse(h1) * 12), 3);

                    string Feet2inch = Convert.ToString(Double.Parse(txtHeightI.Text) + (Double.Parse(txtHeightF.Text) * 12));
                    double height = Double.Parse(Feet2inch);    //Math.Round((h * 12), 5);
                    double heightM = (height * 0.0254);
                    //double weight = Math.Round((Double.Parse(txtWeightPound.Text) * 703), 5);
                    double weight = Double.Parse(txtWeightKg1.Text);
                    txtBMI.Text = Convert.ToString(calculateBMI(heightM, weight));
                    double bmi = Math.Round(Double.Parse(txtBMI.Text), 5);
                    checkStatus(bmi);

                    //=============Replace the value to CM =======

                    txtWeightKG.Text = txtWeightKg1.Text;
                    //txtHeightCM.Text = Convert.ToString(Math.Round((height * 2.54), 5));
                    txtHeightCM.Text = Convert.ToString((height * 2.54));

                    if (txtBMI.Text != "")
                    {
                        txtBMIM.Text = txtBMI.Text;
                    }  
                    //--------------------------------------------
                }
                else
                {
                    MessageBox.Show("Please Provide Valid Data", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (smartTab1.SelectedIndex == 1)
            {
                if (txtHeightCM.Text != "0" && txtWeightKG.Text != "0")
                {
                    List<string> vf = new List<string>() { "txtHeightCM", "txtWeightKG" };
                    Control control = Utility.ReqFieldValidator(this, vf);
                    if (control != null)
                    {
                        MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control.Focus();
                        return;
                    }

                    double h2 = Math.Round((Double.Parse(txtHeightCM.Text) * (0.01)), 5);
                    double height2 = h2;
                    double weight = Math.Round((Double.Parse(txtWeightKG.Text)), 5);
                    txtBMIM.Text = Convert.ToString(calculateBMI(height2, weight));
                    double bmi = Math.Round((Double.Parse(txtBMIM.Text)), 5);
                    checkStatus(bmi);

                    //=============Replace the value to Feet Inch =======
                    string HeightF,HeightI ;
                    txtWeightKg1.Text = txtWeightKG.Text;
                    //double HeightCM2Feet = Math.Round((Double.Parse(txtHeightCM.Text) * 0.0328084),5);
                    double HeightCM2Inch = (Double.Parse(txtHeightCM.Text) * 0.393701);
                    //string newHeight = Convert.ToString(HeightCM2Feet);
                    //string newHeight = Convert.ToString(HeightCM2Inch);
                    double inch2feet = Math.Round((HeightCM2Inch / 12),4);
                    string newHeight = Convert.ToString(inch2feet);
                    if (newHeight.Contains(".") == true)
                    {
                        HeightF = newHeight.Split('.')[0];
                        //HeightI = newHeight.Split('.')[1];
                        string HeightI2 = "." + newHeight.Split('.')[1];
                        HeightI = Convert.ToString(Convert.ToDouble(HeightI2) * 12);
                        //if (HeightI.Length == 2)
                        //{
                        //    double tempHeightI = (Convert.ToDouble(HeightI) * 10);
                        //    double HeightIToinch = Math.Floor((Convert.ToDouble(tempHeightI) / 1000) * 12);
                        //    HeightI = Convert.ToString(HeightIToinch);
                        //}
                        //else
                        //{
                        //    double HeightIToinch = Math.Floor((Convert.ToDouble(HeightI) / 1000) * 12);
                        //    HeightI = Convert.ToString(HeightIToinch);
                        //}
                    }
                    else
                    {
                        HeightF = newHeight;
                        HeightI = "0";
                    }
                    txtHeightF.Text = HeightF;
                    txtHeightI.Text = HeightI;

                    if (txtBMIM.Text != "")
                    {
                        txtBMI.Text = txtBMIM.Text;
                    }
                    //--------------------------------------------
                }
                else
                {
                    MessageBox.Show("Please Provide Valid Data", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void checkStatus(double bmi)
        {
            if (bmi < 18.5)
            {
                lblBmiStatus.Text = "UnderWeight";
                lblBmiStatus.ForeColor = Color.Red;
            }
            if (bmi >= 18.5 && bmi <= 24.9)
            {
                lblBmiStatus.Text = "Normal";
                lblBmiStatus.ForeColor = Color.Green;
            }
            if (bmi >= 25.0 && bmi <= 29.9)
            {
                lblBmiStatus.Text = "OverWeight";
                lblBmiStatus.ForeColor = Color.YellowGreen;
            }
            if (bmi >= 30 && bmi <= 39.9)
            {
                lblBmiStatus.Text = "Obese";
                lblBmiStatus.ForeColor = Color.Red;
            }
            if (bmi >= 40.0)
            {
                lblBmiStatus.Text = "Extremely Obese";
                lblBmiStatus.ForeColor = Color.DarkRed;
            }
        }

        private double calculateBMI(double height, double weight)
        {
            double calculatedBMI = Math.Round((weight / (Math.Pow(height, 2))), 5);
            return calculatedBMI;
        }

        private void txtHeightF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtHeightI_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtWeightPound_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtHeightCM_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtWeightKG_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtWeightKg1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtWeightKg1.Text != "")
            {
                double WinKG = Math.Round((Double.Parse(txtWeightKg1.Text)), 5);
                double KG2Pound = Math.Round((WinKG * 2.20462), 5);
                txtWeightPound.Text = Convert.ToString(KG2Pound);
            }

        }
        private void smartTab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*  if (smartTab1.SelectedIndex == 0)
              {
                  if (txtWeightKG.Text != "" && txtHeightCM.Text != "")
                  {
                      txtWeightKg1.Text = txtWeightKG.Text;
                      string HeightF = "";
                      string HeightI = "";
                      double HeightCM2Feet = Math.Round((Double.Parse(txtHeightCM.Text) * 0.0328084), 3);
                      string newHeight = Convert.ToString(HeightCM2Feet);
                      if (newHeight.Contains(".") == true)
                      {
                          HeightF = newHeight.Split('.')[0];
                          HeightI = newHeight.Split('.')[1];
                          if (HeightI.Length == 2)
                          {
                              double tempHeightI = (Convert.ToDouble(HeightI) * 10);
                              double HeightIToinch = Math.Floor((Convert.ToDouble(tempHeightI) / 1000) * 12);
                              HeightI = Convert.ToString(HeightIToinch);
                          }
                          else
                          {
                              double HeightIToinch = Math.Floor((Convert.ToDouble(HeightI) / 1000) * 12);
                              HeightI = Convert.ToString(HeightIToinch);
                          }
                      }
                      else 
                      {
                          HeightF = newHeight;
                          HeightI = "0";
                      }
                      txtHeightF.Text = HeightF;
                      txtHeightI.Text = HeightI;

                      if (txtBMIM.Text !="")
                      {
                          txtBMI.Text = txtBMIM.Text;
                      }
                  }
              }

              if (smartTab1.SelectedIndex == 1)
              {
                  if (txtWeightKg1.Text != "" && txtHeightF.Text != "" && txtHeightI.Text != "")
                  {
                      txtWeightKG.Text = txtWeightKg1.Text;
                      txtHeightCM.Text = Convert.ToString(Math.Round((Double.Parse(txtHeightF.Text + "." + txtHeightI.Text) * 30.48), 3));
 
                      if (txtBMI.Text != "")
                      {
                          txtBMIM.Text = txtBMI.Text;
                      }
                  }
              }*/
        }
        #endregion BMICalculation  

        private void btnSv_Click(object sender, EventArgs e)
        { 
            if (this.grdPatient.CurrentRow != null)
            {
                checkprerequisits();
                btnBMICaculation.PerformClick();
                int position = grdPatient.CurrentRow.Index;
                string PatientMR = grdPatient.Rows[position].Cells["TicketNo"].Value.ToString();
                string RoomNo = grdPatient.Rows[position].Cells["RoomNo"].Value.ToString();
                List<OPDTicketRO> oOpdTicROs = new List<OPDTicketRO>();

                List<string> vf = new List<string>() { "txtHeightCM", "txtWeightKG", "txtBP", "txtTemp" }; //NsStnID
                Control control = Utility.ReqFieldValidator(this, vf);

                    if (control != null)
                    {
                        MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control.Focus();
                        return;
                    }
                    try 
                    {
                        if (txtHeightCM.Text != "0" && txtWeightKG.Text != "0" && txtBP.Text != "0" && txtTemp.Text != "0")
                        {
                            OPDDoctorCallQ Qobj = this.PopulateData(RoomNo, PatientMR);
                            short i = clnt.UpdateCallQ(Qobj);
                            if (i == 0)
                            {
                                MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (i > 0)
                            {
                                MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                lblPatName.Text = "";
                            }
                        }
                        else
                        {
                           // MessageBox.Show("Height/Weight/Temparature/BP cannot be Zero(0)", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    } 
            }
            else 
            {
                MessageBox.Show("To save health information, SELECT the patient first", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkprerequisits()
        {
            if (txtHeightF.Text != "")
            {
                string h1 = txtHeightF.Text;
                if (Convert.ToInt32(h1) < 1 || Convert.ToInt32(h1) > 8)
                {
                   // MessageBox.Show("please Provide Valid Height Reading", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHeightF.Select();
                }
            }

            if (txtHeightI.Text != "")
            {
                if (txtHeightI.Text.Contains(".") == true)
                {
                    string HeightI1 = txtHeightI.Text.Split('.')[0];
                    string HeightI2 = txtHeightI.Text.Split('.')[1];
                    string h2 = HeightI1;
                    if (Convert.ToInt32(h2) < 0 || Convert.ToInt32(h2) > 12)
                    {
                      //  MessageBox.Show("please Provide Valid Height Reading", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtHeightI.Select();
                    }
                }
            }

            if (txtHeightCM.Text != "")
            {
                string h2 = txtHeightCM.Text;
                if (Convert.ToDouble(h2) < 30.48 || Convert.ToDouble(h2) > 243.84)
                {
                  //  MessageBox.Show("please Provide Valid Height Reading", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHeightCM.Select();
                }
            }

            if (txtWeightKG.Text != "")
            {
                string w2 = txtWeightKG.Text;
                if (Convert.ToDouble(w2) < 1 || Convert.ToDouble(w2) > 635)
                {
                  //  MessageBox.Show("please Provide Valid Weight Reading", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtWeightKG.Select();
                }
            }

            if (txtWeightKg1.Text != "")
            {
                string w1 = txtWeightKg1.Text;
                if (Convert.ToDouble(w1) < 2.50 || Convert.ToDouble(w1) > 635)
                {
                    // MessageBox.Show("please Provide Valid Weight Reading", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtWeightKg1.Select();
                }
            }

            if (txtBP.Text != "")
            {
                string bp = txtBP.Text;
                if (bp.Length >= 5 && bp.Length <8 && bp.Contains("/") == true)
                {
                    string BP1 = txtBP.Text.Split('/')[0];
                    string BP2 = txtBP.Text.Split('/')[1];
                  //  if ((Convert.ToInt32(BP1) < 70 || Convert.ToInt32(BP1) > 190) && (Convert.ToInt32(BP2) < 40 || Convert.ToInt32(BP2) > 100))
                  //  {
                       // MessageBox.Show("Please provide Valid Blood Pressure Reading", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   //     txtBP.Select();
                        
                  //  }
                }
                else
                {
                  //  MessageBox.Show("Please provide Valid Blood Pressure Reading", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBP.Select();
                   
                }
            }

            if (txtTemp.Text != "")
            {
                string tmp = txtTemp.Text;
                if (Convert.ToDouble(tmp) > 113 || Convert.ToDouble(tmp) < 86)
                {
                  //  MessageBox.Show("please Provide Valid Temperature Reading", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTemp.Select();
                }
            }
            if(txtSPOTWO.Text !="")
            {
                string tmpSPO2 = txtSPOTWO.Text;
                if(Convert.ToDouble(tmpSPO2) > 100 || Convert.ToDouble(tmpSPO2) < 50)
                {
                    txtSPOTWO.Select();
                }
            }

        }

        private OPDDoctorCallQ PopulateData(string RoomNo, string PatientMR )
        {
            OPDDoctorCallQ Qobj = new OPDDoctorCallQ();
            Qobj.NStationID = NsStnID;
            Qobj.RoomNo = RoomNo;
            Qobj.TicketNo = PatientMR;
            Qobj.Height = txtHeightCM.Text;
            Qobj.Weight = txtWeightKG.Text;
            Qobj.Bp = txtBP.Text;
            Qobj.Temparature = txtTemp.Text;
            if (txtSPOTWO.Text == "")
            {
                Qobj.SPOTWO = "0";
            }
            if (txtSPOTWO.Text != "")
            {
                Qobj.SPOTWO = txtSPOTWO.Text;
            }

            if (txtOFC.Text == "")
            {
                Qobj.OFC = "0";
            }
            if (txtOFC.Text != "")
            {
                Qobj.OFC = txtOFC.Text;
            }
            
            
            //---------------------------------------------

            ////Qobj.Allergy = 
            //if (chkAllergy.Checked == true)
            //{
            //    if (txtAllergy.Text != string.Empty)
            //    {
            //        Qobj.AllergyText = txtAllergy.Text;
            //    }
            //    if (txtAllergy.Text == string.Empty)
            //    {
            //        Qobj.AllergyText = "";
            //    }
            //}
            //if (chkAllergy.Checked == false)
            //{
            //    Qobj.Allergy = "0";
            //    Qobj.AllergyText = "";
            //}

            Qobj.Allergy = chk1(chkAllergy);
            Qobj.AllergyText = chk2(chkAllergy,txtAllergy);

            Qobj.Asthma = chk1(chkAsthma);
            Qobj.AsthmaText = chk2(chkAsthma, txtAsthma);

            Qobj.Diabetes = chk1(chkDiabetes);
            Qobj.DiabetesText = chk2(chkDiabetes, txtDiabetes);

            Qobj.Pressure = chk1(chkHypertension);
            Qobj.PressureText = chk2(chkHypertension, txtHypertension);

            Qobj.HeartDisease = chk1(chkHeartDisease);
            Qobj.HeartDiseaseText = chk2(chkHeartDisease, txtHeartDisease);

            Qobj.KidneyDisease = chk1(chkKidneyDisease);
            Qobj.KidneyDiseaseText = chk2(chkKidneyDisease, txtKidneyDisease);

            Qobj.Others = "0";
            Qobj.OthersText = "";

            Qobj.PastMedicalHistory = "0";
            Qobj.PastMedicalHistoryText = "";

            Qobj.PastSurgicalHistory = "0";
            Qobj.PastSurgicalHistoryText = "";

            Qobj.FamilyHistory = "0";
            Qobj.FamilyHistoryText = "";

            /*  //  Qobj.Gastric =YesOrNo1(Convert.ToString(chkGastric1.CheckState));
                Qobj.Asthma = YesOrNo1(Convert.ToString(chkAsthma.CheckState));
                Qobj.Diabetes = YesOrNo1(Convert.ToString(chkDiabetes.CheckState));

                if (rdoPNor.Checked == true)
                {
                    Qobj.Pressure = "N";
                }
                if (rdoPHigh.Checked == true)
                {
                    Qobj.Pressure = "H";
                }
                if (rdoPLow.Checked == true)
                {
                    Qobj.Pressure = "L";
                }

                Qobj.HeartDisease = YesOrNo1(Convert.ToString(chkHeartDisease.CheckState));
                Qobj.KidneyDisease = YesOrNo1(Convert.ToString(chkKidneyDisease.CheckState));
              //  Qobj.Tuberculosis = YesOrNo1(Convert.ToString(chkTuberculosis1.CheckState));*/
            //---------------------------------------------
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            Qobj.EntryParameter = ep;
            return Qobj;
        }
        private string chk1(CheckBox chk)
        {
            string val ="";
            if (chk.Checked == true)
            {
                val = "1";
            }
            else if (chk.Checked == false)
            {
                val = "0";
            }
            return val;
        }
        private string chk2(CheckBox chk, TextBox txt)
        {
            string val = "";
            string text = "";

            if (chk.Checked == true)
            {
                val = "1";
                text = txt.Text;
            }
            else if (chk.Checked == false)
            {
                val = "0";
                text = "";
            }
            return text;
        }

     /*   private string YesOrNo1(string yn1)
        {
            var retValue = "";
            if (yn1 == "Checked")
            {
                retValue = "1";
            }
            if (yn1 == "Unchecked")
            {
                retValue = "0";
            }
            return retValue;
       }
      private string YesOrNo(string yn)
        {
            var retValue = "";
            if (yn == "Yes")
            {
                retValue= "1";
            }
            if (yn == "No")
            {
                retValue= "0";
            }
            return retValue;
        }*/
        public void clean()
        {
            txtWeightKG.Text = string.Empty;
            txtWeightKg1.Text = string.Empty;
            txtWeightPound.Text = string.Empty;
            txtHeightCM.Text = string.Empty;
            txtHeightF.Text = string.Empty;
            txtHeightI.Text = string.Empty;
            txtBMI.Text = string.Empty;
            txtBMIM.Text = string.Empty;
            txtBP.Text = string.Empty;
            txtTemp.Text = string.Empty;
            txtTempC.Text = string.Empty;
            lblBmiStatus.Text = string.Empty;
            txtSPOTWO.Text = string.Empty;
            txtOFC.Text = string.Empty;

            chkAllergy.Checked = false;
            txtAllergy.Text = string.Empty;
            txtAllergy.Enabled = false;
          //  chkGastric1.Checked = false;
            chkAsthma.Checked = false;
            chkDiabetes.Checked = false;
            chkHypertension.Checked = false;
            chkHeartDisease.Checked = false;
            chkKidneyDisease.Checked = false;
          //  chkTuberculosis1.Checked = false;
        }
        private void grdPatient_MouseClick(object sender, MouseEventArgs e)
        {
            clean();
            treePatientHistory.DataSource = null;
            if (this.grdPatient.CurrentRow != null)
            {
                lblPatient.Text = "";
                
                int position = grdPatient.CurrentRow.Index;
                string PatientMR = grdPatient.Rows[position].Cells["TicketNo"].Value.ToString();
                lblPatName.Text = grdPatient.Rows[position].Cells["PatientName"].Value.ToString();
                OPDDoctorCallQ HealthInfo = clnt.GetPatHealthInfo(PatientMR);
                LoadPatHealthInfo(HealthInfo);
            }
        }

        private void metric2Standard()
        {
            if (txtWeightKG.Text != "" && txtHeightCM.Text != "")
            {
                string HeightF, HeightI;
                txtWeightKg1.Text = txtWeightKG.Text;
                double HeightCM2Inch = (Double.Parse(txtHeightCM.Text) * 0.393701);
                double inch2feet = (HeightCM2Inch / 12);
                string newHeight = Convert.ToString(inch2feet);
                if (newHeight.Contains(".") == true)
                {
                    HeightF = newHeight.Split('.')[0];

                    string HeightI2 = "." + newHeight.Split('.')[1];
                    HeightI = Convert.ToString(Math.Round((Convert.ToDouble(HeightI2) * 12), 2));
                }
                else
                {
                    HeightF = newHeight;
                    HeightI = "0";
                }
                txtHeightF.Text = HeightF;
                txtHeightI.Text = HeightI;

                if (txtBMIM.Text != "")
                {
                    txtBMI.Text = txtBMIM.Text;
                }
            }

        }
        private void LoadPatHealthInfo(OPDDoctorCallQ HealthInfo)
        {
            txtHeightCM.Text = HealthInfo.Height;
            txtWeightKG.Text = HealthInfo.Weight;
            CalculateBmi();
            metric2Standard();
            txtBP.Text = HealthInfo.Bp;
            txtTemp.Text = HealthInfo.Temparature;
            txtSPOTWO.Text = HealthInfo.SPOTWO;
            txtOFC.Text = HealthInfo.OFC;

            //--------------------------------------
           /* if (HealthInfo.Allergy != "0" && HealthInfo.Allergy != null)
            {
                chkAllergy.Checked = true;
                txtAllergy.Text = HealthInfo.Allergy;
            }
            if (HealthInfo.Allergy == "0")
            {
                chkAllergy.Checked = false;
                txtAllergy.Text = string.Empty;
            }*/

            assignValue(HealthInfo.Allergy, HealthInfo.AllergyText, chkAllergy, txtAllergy);
            assignValue(HealthInfo.Asthma, HealthInfo.AsthmaText, chkAsthma, txtAsthma);
            assignValue(HealthInfo.Diabetes, HealthInfo.DiabetesText, chkDiabetes,txtDiabetes);
            assignValue(HealthInfo.Pressure, HealthInfo.PressureText, chkHypertension, txtHypertension);
            assignValue(HealthInfo.HeartDisease, HealthInfo.HeartDiseaseText, chkHeartDisease, txtHeartDisease);
            assignValue(HealthInfo.KidneyDisease, HealthInfo.KidneyDiseaseText, chkKidneyDisease, txtKidneyDisease);

          //--------------------------------------
          //  chk(chkGastric1, HealthInfo.Gastric);
          /*  chk(chkAsthma, HealthInfo.Asthma);
            chk(chkDiabetes, HealthInfo.Diabetes);
            //-------------------------------------
            if (HealthInfo.Pressure == "N")
            {
                //rdoPNor.Checked = true;
            }
            if (HealthInfo.Pressure == "H")
            {
                //rdoPHigh.Checked = true;
            }
            if (HealthInfo.Pressure == "L")
            {
                //rdoPLow.Checked = true;
            }       
            chk(chkHeartDisease, HealthInfo.HeartDisease);
            chk(chkKidneyDisease, HealthInfo.KidneyDisease);        */       
            //chk(chkTuberculosis1, HealthInfo.Tuberculosis);

        }
        private void assignValue(string value, string text, CheckBox chkbox, TextBox txtbox)
        {
            if (value == "1")
            {
                chkbox.Checked = true;
                txtbox.Text = text;
            }
            else if (value == "0")
            {
                chkbox.Checked = false;
                txtbox.Text = "";
            }
            else
            {
                chkbox.Checked = false;
                txtbox.Text = "";
            }
        }
        private void chk(CheckBox chk, string value)
        {
            if (value == "1")
            {
                chk.Checked = true;
            }
            else if (value == "0")
            {
                chk.Checked = false;
            }
            else
            {
                chk.Checked = false;
            }
        }

        private void CalculateBmi()
        {
            if ((txtHeightCM.Text != "" || txtHeightCM.Text != "0") && (txtWeightKG.Text != "" && txtWeightKG.Text != "0"))
            {
                //double HeightCM2M = Math.Round((Double.Parse(txtHeightCM.Text) * (0.01)), 5);
                //double WeightKG = Math.Round((Double.Parse(txtWeightKG.Text)), 5);
                double HeightCM2M = (Double.Parse(txtHeightCM.Text) * (0.01));
                double WeightKG = (Double.Parse(txtWeightKG.Text));
                double bmi = Math.Round((WeightKG / (Math.Pow(HeightCM2M, 2))), 5);
                txtBMIM.Text = Convert.ToString(bmi);
                checkStatus(bmi);
            }
        }

        private void txtHeightCM_TextChanged(object sender, EventArgs e)
        {
          /*  if (txtHeightCM.Text != "")
            {
                txtWeightKg1.Text = txtWeightKG.Text;
                string HeightF = "";
                string HeightI = "";
                double HeightCM2Feet = Math.Round((Double.Parse(txtHeightCM.Text) * 0.0328084), 3); // cm to feet
                string newHeight = Convert.ToString(HeightCM2Feet);

                if (newHeight.Contains(".") == true)
                {
                    HeightF = newHeight.Split('.')[0];
                    HeightI = newHeight.Split('.')[1];
                    if(HeightI.Length == 2)
                    {
                        double tempHeightI = (Convert.ToDouble(HeightI) * 10);
                        double HeightIToinch = Math.Floor((Convert.ToDouble(tempHeightI) / 1000) * 12);
                        HeightI = Convert.ToString(HeightIToinch);
                    }
                    else
                    {
                        double HeightIToinch = Math.Floor((Convert.ToDouble(HeightI) / 1000) * 12);
                        HeightI = Convert.ToString(HeightIToinch);
                    }
                }
                else 
                {
                    HeightF = newHeight;
                }
                txtHeightF.Text = HeightF;
                txtHeightI.Text = HeightI;
            }*/
        }

        private void txtWeightKG_TextChanged(object sender, EventArgs e)
        {
           /* if (txtWeightKG.Text != "")
            {
                txtWeightKg1.Text = txtWeightKG.Text;
            }*/
        }

        private void txtBP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '/')
            {
                e.Handled = true;
            }
        }

        private void txtTemp_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTemp.Text != "")
            {
                double tempF = Double.Parse(txtTemp.Text);
                double tempF2tempC = Math.Round(((tempF-32)*(.555)), 5);
                txtTempC.Text = Convert.ToString(tempF2tempC);
            }
        }

        private void txtTemp_TextChanged(object sender, EventArgs e)
        {
            if (txtTemp.Text != "")
            {
                double tempF = Double.Parse(txtTemp.Text);
                double tempF2tempC = Math.Round(((tempF - 32) * (.555)),5);
                txtTempC.Text = Convert.ToString(tempF2tempC);
            }
        }

        private void txtBMI_TextChanged(object sender, EventArgs e)
        {
           /* if (txtWeightKg1.Text != "" && txtHeightF.Text != "" && txtHeightI.Text != "")
            {
                txtWeightKG.Text = txtWeightKg1.Text;
                txtHeightCM.Text = Convert.ToString(Math.Round((Double.Parse(txtHeightF.Text + "." + txtHeightI.Text) * 30.48), 3));

                if (txtBMI.Text != "")
                {
                    txtBMIM.Text = txtBMI.Text;
                }
            }*/
        }

        private void dgvDoctorsList_MouseClick(object sender, MouseEventArgs e)
        {
            clean();
        }

        private void dgvDoctorsList_SelectionChanged(object sender, EventArgs e)
        {
            dgvDocListChange();
        }

        private void chkYesOrNo1(string chYN1, RadioButton Yes, RadioButton No)
        {
            if (chYN1 == "Checked")
            {
                Yes.Checked = true;
                No.Checked = false;
            }
            else if (chYN1 == "Unchecked")
            {
                Yes.Checked = false;
                No.Checked = true;
            }
        }
        #region checkedChange1
        private void chkAllergy1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkGastric1_CheckedChanged(object sender, EventArgs e)
        {
          /*  if (chkGastric1.Checked == true)
            {
                rdoGYes.Checked = true;
                rdoGNo.Checked = false;
            }
            if (chkGastric1.Checked == false)
            {
                rdoGYes.Checked = false;
                rdoGNo.Checked = true;
            }*/
        }

        private void chkAsthma1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void chkDiabetes1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkHeartDisease1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkKidneyDisease1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTuberculosis1_CheckedChanged(object sender, EventArgs e)
        {
          /*  if (chkTuberculosis1.Checked == true)
            {
                rdoTYes.Checked = true;
                rdoTNo.Checked = false;
            }
            if (chkTuberculosis1.Checked == false)
            {
                rdoTYes.Checked = false;
                rdoTNo.Checked = true;
            }*/
        }
        private void chkPressure1_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion checkedChange1

        private void txtBP_Leave(object sender, EventArgs e)
        {
          /*  if(txtBP.Text !="")
            {
                string bp = txtBP.Text;
                if (bp.Length > 5 && bp.IndexOf("/") != -1)
                {
                    string BP1 = txtBP.Text.Split('/')[0];
                    string BP2 = txtBP.Text.Split('/')[1];
                    if ((Convert.ToInt32(BP1) < 70 || Convert.ToInt32(BP1) > 190) && (Convert.ToInt32(BP2) < 40 || Convert.ToInt32(BP2) > 100))
                    {
                        MessageBox.Show("Please provide Valid Blood Pressure Reading", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBP.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please provide Valid Blood Pressure Reading", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBP.Focus();
                }
            }*/
        }

        private void txtHeightF_Leave(object sender, EventArgs e)
        {
           /* if(txtHeightF.Text !="")
            {
                string h1 = txtHeightF.Text;
                if (Convert.ToInt32(h1) < 1 || Convert.ToInt32(h1) > 8)
                {
                    MessageBox.Show("please Provide Valid Height Reading", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHeightF.Focus();
                }
            }*/
        }

        private void txtHeightI_Leave(object sender, EventArgs e)
        {
           /* if (txtHeightI.Text != "")
            {
                if (txtHeightI.Text.Contains(".") == true)
                {
                    string HeightI1 = txtHeightI.Text.Split('.')[0];
                    string HeightI2 = txtHeightI.Text.Split('.')[1];
                    string h2 = HeightI1;
                    if (Convert.ToInt32(h2) < 0 || Convert.ToInt32(h2) > 12)
                    {
                        MessageBox.Show("please Provide Valid Height Reading", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtHeightI.Focus();
                    }
                }
            }*/
        }

        private void txtWeightKg1_Leave(object sender, EventArgs e)
        {
           /* if(txtWeightKg1.Text != "")
            {
                string w1 = txtWeightKg1.Text;
                if (Convert.ToDouble(w1) < 2.50 || Convert.ToDouble(w1) > 635)
                {
                    MessageBox.Show("please Provide Valid Weight Reading", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtWeightKg1.Focus();
                }
            }*/
        }

        private void txtTemp_Leave(object sender, EventArgs e)
        {
          /*  if(txtTemp.Text != "")
            {
                string tmp = txtTemp.Text; 
                if (Convert.ToDouble(tmp) > 113 || Convert.ToDouble(tmp) < 86)
                {
                    MessageBox.Show("please Provide Valid Temperature Reading", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTemp.Focus();
                }
            }*/
        }

        private void txtWeightKG_Leave(object sender, EventArgs e)
        {
           /* if (txtWeightKG.Text != "")
            {
                string w2 = txtWeightKG.Text;
                if (Convert.ToDouble(w2) < 1 || Convert.ToDouble(w2) > 635)
                {
                    MessageBox.Show("please Provide Valid Weight Reading", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtWeightKG.Focus();
                }
            }*/
        }

        private void txtHeightCM_Leave(object sender, EventArgs e)
        {
            /*if (txtHeightCM.Text != "")
            {
                string h2 = txtHeightCM.Text;
                if (Convert.ToDouble(h2) < 30.48 || Convert.ToDouble(h2) > 243.84)
                {
                    MessageBox.Show("please Provide Valid Height Reading", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHeightCM.Focus();
                }
            }*/
        }
        private void txtWeightKg1_TextChanged(object sender, EventArgs e)
        {
            if (txtWeightKg1.Text != "")
            {
                double WinKG = Math.Round((Double.Parse(txtWeightKg1.Text)), 5);
                double KG2Pound = Math.Round((WinKG * 2.20462), 5);
                txtWeightPound.Text = Convert.ToString(KG2Pound);
            }
        }

        private void grdPatient_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
          /*  if (e.ColumnIndex == 38)
            {
                if (this.grdPatient.CurrentRow != null)
                {
                    lblPatient.Text = "";
                    int position = grdPatient.CurrentRow.Index;
                    string PatientMR = grdPatient.Rows[position].Cells["TicketNo"].Value.ToString();
                    lblPatName.Text = grdPatient.Rows[position].Cells["PatientName"].Value.ToString();
                    string RoomNo = grdPatient.Rows[position].Cells["RoomNo"].Value.ToString();
                    List<OPDTicketRO> oOpdTktROs = new List<OPDTicketRO>();


                    oOpdTktROs = clnt.ChangePatientStatus(PatientMR, RoomNo, Doc_ID).ToList();
                    
                   // grdPatient.DataSource = null;
                   // grdPatient.DataSource = oOpdTicROs;
                }
            }*/
        }

        private void grdPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          /*  if (e.ColumnIndex == 38)
            {
                if (this.grdPatient.CurrentRow != null)
                {
                    lblPatient.Text = "";
                    int position = grdPatient.CurrentRow.Index;
                    string PatientMR = grdPatient.Rows[position].Cells["TicketNo"].Value.ToString();
                    lblPatName.Text = grdPatient.Rows[position].Cells["PatientName"].Value.ToString();
                    string RoomNo = grdPatient.Rows[position].Cells["RoomNo"].Value.ToString();
                    List<OPDTicketRO> oOpdTktROs = new List<OPDTicketRO>();

                    oOpdTktROs = clnt.ChangePatientStatus(PatientMR, RoomNo, Doc_ID).ToList();
                    dgvDocListChange();

                }
            }*/
        }

        private void btnSendToVisit_Click(object sender, EventArgs e)
        {
            if (this.grdPatient.CurrentRow != null)
            {
                lblPatient.Text = "";
                int position = grdPatient.CurrentRow.Index;
                string PatientMR = grdPatient.Rows[position].Cells["TicketNo"].Value.ToString();
                lblPatName.Text = grdPatient.Rows[position].Cells["PatientName"].Value.ToString();
                string RoomNo = grdPatient.Rows[position].Cells["RoomNo"].Value.ToString();
                List<OPDTicketRO> oOpdTktROs = new List<OPDTicketRO>();

                oOpdTktROs = clnt.ChangePatientStatus(PatientMR, RoomNo, Doc_ID).ToList();
                dgvDocListChange();
            }

        }

        private void chkAllergy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllergy.Checked == true)
            {
                txtAllergy.Enabled = true;
            }
            else
            {
                txtAllergy.Enabled = false;
            }
        }

        private void chkAsthma_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAsthma.Checked == true)
            {
               txtAsthma.Enabled = true;
            }
            else
            {
                txtAsthma.Enabled = false;
            }
        }

        private void chkDiabetes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiabetes.Checked == true)
            {
                txtDiabetes.Enabled = true;
            }
            else
            {
                txtDiabetes.Enabled = false;
            }
        }

        private void chkHypertension_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHypertension.Checked == true)
            {
                txtHypertension.Enabled = true;
            }
            else
            {
                txtHypertension.Enabled = false;
            }
        }

        private void chkHeartDisease_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHeartDisease.Checked == true)
            {
                txtHeartDisease.Enabled = true;
            }
            else
            {
                txtHeartDisease.Enabled = false;
            }
        }

        private void chkKidneyDisease_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKidneyDisease.Checked == true)
            {
                txtKidneyDisease.Enabled = true;
            }
            else
            {
                txtKidneyDisease.Enabled = false;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void txtAllergy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtAsthma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtDiabetes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtHypertension_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtHeartDisease_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        }

        private void txtKidneyDisease_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) && e.KeyChar == '~' || e.KeyChar == '`')
            {
                e.Handled = true;
            }
        } 
    }
}
