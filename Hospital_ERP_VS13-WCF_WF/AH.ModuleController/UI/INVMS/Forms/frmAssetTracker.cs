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
    public partial class frmAssetTracker : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        private string MrrID;

        public frmAssetTracker(string MrrID)
        {
            
            InitializeComponent();          
            this.MrrID = MrrID;
            
        }

        private void FormatData(DataGridView dtv)
        {
            //dtv.Height = 300;
            //dtv.Width = 840;
            
            dtv.AutoGenerateColumns = false;
            //dtv.Location = new Point(txtItemID.Location.X, txtItemID.Location.Y);

            DataGridViewTextBoxColumn itemid = new DataGridViewTextBoxColumn();
            itemid.Name = "ItemID";
            itemid.DataPropertyName = "ItemID";
            itemid.Width = 0;
            itemid.Visible = false;
            dtv.Columns.Add(itemid);
            DataGridViewTextBoxColumn itemname = new DataGridViewTextBoxColumn();
            itemname.Name = "Item";
            itemname.DataPropertyName = "Item";
            itemname.Width = 200;
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
            compname.Width = 200;
            compname.Visible = true;
            compname.ReadOnly = true;
            dtv.Columns.Add(compname);


            DataGridViewTextBoxColumn brandname = new DataGridViewTextBoxColumn();
            brandname.Name = "Brand";
            brandname.DataPropertyName = "Brand";
            brandname.Width = 150;
            brandname.Visible = true;
            brandname.ReadOnly = true;
            dtv.Columns.Add(brandname);

            DataGridViewTextBoxColumn modelname = new DataGridViewTextBoxColumn();
            modelname.Name = "Model";
            modelname.DataPropertyName = "Model";
            modelname.Width = 150;
            modelname.Visible = true;
            modelname.ReadOnly = true;
            dtv.Columns.Add(modelname);
        }
        private void populateDataToGridForIssue(DataGridView dtv, string mrid)
        {


            dgvMrrDetails.Visible = true;
            List<MaterialReceive> list = new List<MaterialReceive>();
            list.AddRange(invSr.GetMrrDetails(mrid).ToList());

            dgvMrrDetails.DataSource = list.Select(data => new
            {
                ItemID = data.ItemOrder.ItemMaster.ID,
                Item = data.ItemOrder.ItemMaster.Name,
                TYPEID = data.ItemOrder.ItemMaster.PacketType.ID,
                UNITID = data.ItemOrder.ItemMaster.Units.ID,
                GROUPID = data.ItemOrder.ItemMaster.GroupDetails.ID,
                COMPANYID = data.ItemOrder.ItemMaster.Company.ID,
                BrandID = data.ItemOrder.ItemMaster.BrandSetup.ID,
                ModelID = data.ItemOrder.ItemMaster.ModelSetup.ID,
                GROUP = data.ItemOrder.ItemMaster.GroupDetails.Name,
                COMPANY = data.ItemOrder.ItemMaster.Company.Name,
                Brand = data.ItemOrder.ItemMaster.BrandSetup.Name,
                Model = data.ItemOrder.ItemMaster.ModelSetup.Name,
                

            }).ToList();
            //dgvMrrDetails.Rows.Clear();
            this.dgvMrrDetails.Focus();
        }

       

        private void frmAssetTracker_Load(object sender, EventArgs e)
        {
            dgvMrrDetails.Rows.Clear();
            //txtMrrID.Text = this.MrrID;
            FormatData(dgvMrrDetails);
            populateDataToGridForIssue(dgvMrrDetails, this.MrrID);
        }

      

       
    }
}
