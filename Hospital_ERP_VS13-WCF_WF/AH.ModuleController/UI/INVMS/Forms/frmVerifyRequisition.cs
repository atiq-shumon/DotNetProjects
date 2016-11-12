using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.UI.InvMS.Reports.Viewer;
using AH.ModuleController.INVMSSR;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmVerifyRequisition : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        public frmVerifyRequisition()
        {
            InitializeComponent();
        }
        private void FormatGrid(DataGridView dtv)
        {
            dtv.AutoGenerateColumns = false;
            dtv.EditMode = DataGridViewEditMode.EditOnKeystroke;

            DataGridViewTextBoxColumn colreqid = new DataGridViewTextBoxColumn();
            colreqid.Name = "DR ID";
            colreqid.DataPropertyName = "reqid";
            colreqid.Width = 100;
            colreqid.Visible = true;
            dtv.Columns.Add(colreqid);

            DataGridViewTextBoxColumn coldeptid = new DataGridViewTextBoxColumn();
            coldeptid.Name = "Dept ID";
            coldeptid.DataPropertyName = "deptid";
            coldeptid.Width = 0;
            coldeptid.Visible = false;
            dtv.Columns.Add(coldeptid);

            DataGridViewTextBoxColumn colunitid = new DataGridViewTextBoxColumn();
            colunitid.Name = "Unit ID";
            colunitid.DataPropertyName = "unitid";
            colunitid.Width = 0;
            colunitid.Visible = false;
            dtv.Columns.Add(colunitid);

            DataGridViewTextBoxColumn coldeptname = new DataGridViewTextBoxColumn();
            coldeptname.Name = "Dept Name";
            coldeptname.DataPropertyName = "deptname";
            coldeptname.Width = 160;
            coldeptname.Visible = true;
            dtv.Columns.Add(coldeptname);

            DataGridViewTextBoxColumn colunitname = new DataGridViewTextBoxColumn();
            colunitname.Name = "Unit Name";
            colunitname.DataPropertyName = "unitname";
            colunitname.Width = 120;
            colunitname.Visible = true;
            dtv.Columns.Add(colunitname);

            DataGridViewTextBoxColumn colreqBy = new DataGridViewTextBoxColumn();
            colreqBy.Name = "ReqBy";
            colreqBy.DataPropertyName = "ReqBy";
            colreqBy.Width = 150;
            colreqBy.Visible = true;
            dtv.Columns.Add(colreqBy);

        }
        private void populateDataToGrid(DataGridView dtv,string deptid,string unitid)
        {
            dgvReqVerify.Visible = true;
            List<DemandRequisition> list = new List<DemandRequisition>();
            list.AddRange(invSr.GetRequisitionVerifiedBy(deptid,unitid,Utility.UserId).ToList());

            dgvReqVerify.DataSource = list.Select(data => new
            {
                reqid = data.ID,
                deptid = data.Department.DepartmentID,
                unitid = data.DepartmentUnit.UnitId,
                deptname = data.Department.DepartmentTitle,
                unitname = data.DepartmentUnit.UnitTitle,
                ReqBy = data.RequisitionBy
            }).ToList();

            this.dgvReqVerify.Focus();
            
        }

        private void frmVerifyRequisition_Load(object sender, EventArgs e)
        {
            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(invSr.GetDepartmentsetupDic(null, Utility.UserDepartmentGroupID), null);
            
            FormatGrid(dgvReqVerify);

            cboDepartment.Text = Utility.UserDepartment;
            cboUnit.Text = Utility.UserUnitTitle;
            
            FormatDataForRequisition(dgvRequisition);
           
            dgvRequisition.ReadOnly = false;

            cboDepartment.SelectedIndexChanged += new EventHandler(cboDepartment_SelectedIndexChanged);

            txtRequisitionBy.Text = Utility.UserId;

            txtDRDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            populateDataToGrid(dgvReqVerify, cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString());
            //btnShow.PerformClick();
       
        }

        private void FormatDataForRequisition(DataGridView dtv)
        {

            dtv.AutoGenerateColumns = false;
            dtv.EditMode = DataGridViewEditMode.EditOnEnter;
            //dtv.Location = new Point(txtItemID.Location.X, txtItemID.Location.Y);
            DataGridViewTextBoxColumn coldrid = new DataGridViewTextBoxColumn();
            coldrid.Name = "DrID";
            coldrid.DataPropertyName = "DrID";
            coldrid.Width = 100;
            coldrid.Visible = true;
            coldrid.ReadOnly = true;
            dtv.Columns.Add(coldrid);
            DataGridViewTextBoxColumn itemid = new DataGridViewTextBoxColumn();
            itemid.Name = "ItemID";
            itemid.DataPropertyName = "ItemID";
            itemid.Width = 0;
            itemid.Visible = false;
            dtv.Columns.Add(itemid);
            DataGridViewTextBoxColumn itemname = new DataGridViewTextBoxColumn();
            itemname.Name = "Item";
            itemname.DataPropertyName = "Item";
            itemname.Width = 280;
            itemname.Visible = true;
            itemname.ReadOnly = true;
            dtv.Columns.Add(itemname);
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
            groupname.Name = "Group";
            groupname.DataPropertyName = "Group";
            groupname.Width = 200;
            groupname.Visible = true;
            groupname.ReadOnly = true;
            dtv.Columns.Add(groupname);

            DataGridViewTextBoxColumn compname = new DataGridViewTextBoxColumn();
            compname.Name = "Company";
            compname.DataPropertyName = "Company";
            compname.Width = 0;
            compname.Visible = false;
            compname.ReadOnly = true;
            dtv.Columns.Add(compname);


            DataGridViewTextBoxColumn brandname = new DataGridViewTextBoxColumn();
            brandname.Name = "Brand";
            brandname.DataPropertyName = "Brand";
            brandname.Width = 0;
            brandname.Visible = false;
            brandname.ReadOnly = false;
            dtv.Columns.Add(brandname);

            DataGridViewTextBoxColumn modelname = new DataGridViewTextBoxColumn();
            modelname.Name = "Model";
            modelname.DataPropertyName = "Model";
            modelname.Width = 0;
            modelname.Visible = false;
            modelname.ReadOnly = true;
            dtv.Columns.Add(modelname);

            DataGridViewTextBoxColumn colreqqty = new DataGridViewTextBoxColumn();
            colreqqty.Name = "ReqQty";
            colreqqty.DataPropertyName = "ReqQty";
            colreqqty.Width = 60;
            colreqqty.Visible = true;
            colreqqty.ReadOnly = false;
            dtv.Columns.Add(colreqqty);

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.Width = 50;
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            dtv.Columns.Add(Deletelink);


            //DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            //checkBoxColumn.HeaderText = "";
            //checkBoxColumn.Width = 30;
            //checkBoxColumn.Visible = true;
            //checkBoxColumn.Name = "checkBoxColumn";
            //dtv.Columns.Insert(17, checkBoxColumn);

        }
        private void populateDataToGridForRequisition(DataGridView dtv, string drid)
        {
            
            short index = 0;
            dgvRequisition.Rows.Clear();
            List<DemandRequisition> list = new List<DemandRequisition>();
            list.Clear();
            list.AddRange(invSr.GetDrDetails(drid).ToList());
            foreach (DemandRequisition data in list)
            {
                string[] row = new string[] { data.ID, 
                                              data.ItemMaster.ID,
                                              data.ItemMaster.Name, 
                                              data.ItemMaster.PacketType.ID,                                               
                                              data.ItemMaster.Units.ID,                                             
                                              data.ItemMaster.GroupDetails.ID,                                               
                                              data.ItemMaster.Company.ID,                                             
                                              data.ItemMaster.BrandSetup.ID,                                              
                                              data.ItemMaster.ModelSetup.ID,
                                              data.ItemMaster.StoreType.strTypeID,
                                              data.ItemMaster.Majorgroup.MajorgrpID,
                                              data.ItemMaster.GroupDetails.Name,
                                              data.ItemMaster.Company.Name,
                                              data.ItemMaster.BrandSetup.Name,
                                              data.ItemMaster.ModelSetup.Name,
                                              data.DemandQty.ToString()
                                             };
                AddRowsToCollection(dgvRequisition, row,index);
                index ++;
                //ColurTheGrid(data.DraftResultID);
            }               

        }
        private void AddRowsToCollection(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
        }


        private void dgvReqVerify_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            populateDataToGridForRequisition(dgvRequisition, dgvReqVerify.CurrentRow.Cells[0].Value.ToString());
            txtDRID.Text = Convert.ToString(dgvRequisition.CurrentRow.Cells[0].Value);
        }

        private void dgvRequisition_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            //dgvRequisition.CurrentRow.Cells[0].Value = txtRequisitionNo.Text;
        }

        private void dgvReqVerify_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            populateDataToGridForRequisition(dgvRequisition, dgvReqVerify.CurrentRow.Cells[0].Value.ToString());
            txtDRID.Text = Convert.ToString(dgvRequisition.CurrentRow.Cells[0].Value);

        }

       

       
        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(invSr.GetDeptUnitDic(Utility.UserDepartmentGroupID, cboDepartment.SelectedValue.ToString())), null);
            }
            
        }

       

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtRequisitionBy" };
            Control control = Utility.ReqFieldValidator(this, vf);
            
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(dgvRequisition.Rows.Count == 0)
            {
                MessageBox.Show("Please Select Item ");
                return;
            }

            try
            {

                DemandRequisition odemand = this.populateDemandRequisition();
                short i = invSr.VerifyDemandRequisition(odemand);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvRequisition.Rows.Clear();
                    
                    PrintReport(txtDRID.Text);
                    //cboBuilding.Focus();
                    populateDataToGrid(dgvReqVerify, cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString());
                   
                    btnSave.Enabled = false;

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
        private DemandRequisition populateDemandRequisition()
        {
            DemandRequisition odemand = new DemandRequisition();
            odemand.ID = txtDRID.Text;
            odemand.RequisitionBy = txtRequisitionBy.Text;
            odemand.RequisitionDate = DateTime.Parse(txtDRDate.Text);
            
            string drString = "";
            foreach (DataGridViewRow dr in dgvRequisition.Rows)
            {

                drString += dr.Cells[1].Value.ToString() + "," + dr.Cells[3].Value.ToString() + "," + dr.Cells[4].Value.ToString() + "," + dr.Cells[5].Value.ToString() + "," + dr.Cells[6].Value.ToString() + "," + dr.Cells[7].Value.ToString() + "," + dr.Cells[8].Value.ToString() + "," + dr.Cells[9].Value.ToString() + "," + dr.Cells[10].Value.ToString() + "," + dr.Cells[15].Value.ToString() + "," + dr.Cells[15].Value.ToString();
                drString += ";";
            }

            odemand.ReqDetails = drString;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            odemand.EntryParameter = ep;

            return odemand;

        }

        private void txtRequisitionBy_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtRequisitionBy_Leave(object sender, EventArgs e)
        {
           
        }

        private void dgvRequisition_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void dgvRequisition_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvRequisition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 16)
            {
                int selRowIndex = e.RowIndex;
                if (selRowIndex < 0)
                {

                    dgvRequisition.Rows.Clear();
                }
                else
                {
                    dgvRequisition.Rows.RemoveAt(selRowIndex);
                }

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void txtRequisitionBy_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            populateDataToGrid(dgvReqVerify, cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString());
        }
        private void PrintReport(string drid)
        {
            frmReportViewer ofrmreportviewer = new frmReportViewer();
            ofrmreportviewer.selector = ViewerSelector.DrReport;
            ofrmreportviewer.DRID = drid;
            ofrmreportviewer.ReportTitle = "Demand Requisition";
            ofrmreportviewer.ViewReport();
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            PrintReport(txtReqNo.Text);
        }

        private void dgvRequisition_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dgvRequisition.Columns["ReqQty"].Index) //this is numeric column
            {
                float i;
                if (!float.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("Must be numeric");
                }
            }
        }

        private void dgvRequisition_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRequisition.Columns[e.ColumnIndex].Name.Equals("ReqQty"))
            {
                double intValue;
                if (dgvRequisition.Rows[e.RowIndex].IsNewRow) { return; }
                if (double.TryParse((String)e.Value, out intValue) &&
                    (intValue < 0))
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.SelectionBackColor = Color.DarkRed;
                }
            }

            ((DataGridViewTextBoxColumn)dgvRequisition.Columns["ReqQty"]).MaxInputLength = 6;
        }

    }
}
