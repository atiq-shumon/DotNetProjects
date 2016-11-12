using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.DMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.DMS.Forms
{
    public partial class frmEmeregencyCollectionHead : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSc = new DMSSR.DMSWSClient();
        private List<EmrCollHead> oCols;
        public frmEmeregencyCollectionHead()
        {
            InitializeComponent();
        }

        private void frmEmeregencyCollectionHead_Load(object sender, EventArgs e)
        {
            FormatGrid();

            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);

            cboDepartmentType.Text = "Medical";
            cboDepartmentType.Enabled = false;
            cboDepartmentGroup.Text = "Clinical";
            cboDepartmentGroup.Enabled = false;
            cboDepartment.Text = "Emergency";
            cboDepartment.Enabled = false;
            cboUnit.Text = "--";
            cboUnit.Enabled = false;
        }

        private void cboDepartmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentType.SelectedValue != null)
            {
                cboDepartmentGroup.DisplayMember = "Value";
                cboDepartmentGroup.ValueMember = "Key";
                cboDepartmentGroup.DataSource = new BindingSource(dmsSc.GetDeptGroupDicByType(cboDepartmentType.SelectedValue.ToString()), null);
            }
        }

        private void cboDepartmentGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentGroup.SelectedValue != null)
            {
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(dmsSc.GetDepartmentsetupDic(null, cboDepartmentGroup.SelectedValue.ToString()), null);
            }
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(dmsSc.GetDeptUnitDic(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString())), null);

                this.btnShow_Click(sender, e);
            }
        }
        private void FormatGrid()
        {
            lvEmerCollHead.CheckBoxes = false;
            lvEmerCollHead.Columns.Add("DeptType", 0, HorizontalAlignment.Left);
            lvEmerCollHead.Columns.Add("DeptGroupID", 0, HorizontalAlignment.Left);
            lvEmerCollHead.Columns.Add("DeptGroupTitle", 0, HorizontalAlignment.Left);
            lvEmerCollHead.Columns.Add("DepartmentID", 0, HorizontalAlignment.Left);
            lvEmerCollHead.Columns.Add("DepartmentTitle", 0, HorizontalAlignment.Left);
            lvEmerCollHead.Columns.Add("UnitID", 0, HorizontalAlignment.Left);
            lvEmerCollHead.Columns.Add("UnitTitle", 0, HorizontalAlignment.Left);
            lvEmerCollHead.Columns.Add("HeadGroup", 0, HorizontalAlignment.Left);
            lvEmerCollHead.Columns.Add("HeadID", 150, HorizontalAlignment.Center);
            lvEmerCollHead.Columns.Add("HeadTitle", 500, HorizontalAlignment.Left);
            lvEmerCollHead.Columns.Add("HeadTitleBeng", 0, HorizontalAlignment.Left);
            lvEmerCollHead.Columns.Add("Fee", 200, HorizontalAlignment.Center);
            lvEmerCollHead.Columns.Add("SetAsDefault", 0, HorizontalAlignment.Center);
            lvEmerCollHead.Columns.Add("IsSelectable", 0, HorizontalAlignment.Center);
            lvEmerCollHead.Columns.Add("PosSerial", 150, HorizontalAlignment.Center);
        }

        private void LoadListView(string DeptGroup,string Department,string Unit)
        {
            lvEmerCollHead.Items.Clear();
            oCols = dmsSc.GetEmrCollHead("A",cboDepartmentGroup.SelectedValue.ToString(),cboDepartment.SelectedValue.ToString(),cboUnit.SelectedValue.ToString()).ToList();
            foreach (EmrCollHead oCol in oCols)
            {
                ListViewItem itm = new ListViewItem(oCol.DepartmentGroup.DepartmentTypeID);
                itm.SubItems.Add(oCol.DepartmentGroup.DepartmentGroupID);
                itm.SubItems.Add(oCol.DepartmentGroup.DepartmentGroupTitle);
                itm.SubItems.Add(oCol.Department.DepartmentID);
                itm.SubItems.Add(oCol.Department.DepartmentTitle);
                itm.SubItems.Add(oCol.DepartmentUnit.UnitId);
                itm.SubItems.Add(oCol.DepartmentUnit.UnitTitle);
                itm.SubItems.Add(oCol.HeadGroupID);
                itm.SubItems.Add(oCol.HeadID);
                itm.SubItems.Add(oCol.HeadTitle);
                itm.SubItems.Add(oCol.HeadTitleBeng);
                itm.SubItems.Add(oCol.Fee.ToString());
                itm.SubItems.Add(oCol.SetAsDefault);
                itm.SubItems.Add(oCol.IsSelectable);
                itm.SubItems.Add(oCol.PosSerial);
                lvEmerCollHead.Items.Add(itm);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> vf = new List<string>() { "cboDepartmentType", "cboDepartmentGroup", "cboDepartment", "cboUnit" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }
                LoadListView(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString());
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

        private void lvEmerCollHead_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            lvEmerCollHead.Items.Clear();
        }

        private void lvEmerCollHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmerCollHead.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvEmerCollHead.SelectedItems[0];
                cboDepartmentType.SelectedValue = itm.SubItems[0].Text;
                cboDepartmentGroup.SelectedValue = itm.SubItems[1].Text;
                cboDepartment.SelectedValue = itm.SubItems[3].Text;
                cboUnit.SelectedValue = itm.SubItems[5].Text;
                txtHeadGroup.Text = itm.SubItems[7].Text;
                txtHeadID.Text = itm.SubItems[8].Text;
                txtHeadTitle.Text = itm.SubItems[9].Text;
                txtHeadTitleBeng.Text = itm.SubItems[10].Text;
                txtFee.Text = itm.SubItems[11].Text;
                if (itm.SubItems[12].Text == "1")
                {
                    chkDefault.Checked = true;
                }
                if (itm.SubItems[12].Text == "0")
                {
                    chkDefault.Checked = false;
                }
                if (itm.SubItems[13].Text == "1")
                {
                    chkIsSelectable.Checked = true;
                }
                if (itm.SubItems[13].Text == "0")
                {
                    chkIsSelectable.Checked = false;
                }
                txtPosSerial.Text = itm.SubItems[14].Text;
            }
        }

        private EmrCollHead PopulateEmrCollHeadSetup()
        {
            EmrCollHead oCol = new EmrCollHead();
            DepartmentGroup oDeptGrp = new DepartmentGroup();
            Department oDept = new Department();
            DepartmentUnit oDeptUnit = new DepartmentUnit();
            oDeptGrp.DepartmentGroupID = cboDepartmentGroup.SelectedValue.ToString();
            oDeptGrp.DepartmentTypeID = cboDepartmentType.SelectedValue.ToString();
            oCol.DepartmentGroup = oDeptGrp;
            oDept.DepartmentID = cboDepartment.SelectedValue.ToString();
            oCol.Department = oDept;
            oDeptUnit.UnitId = cboUnit.SelectedValue.ToString();
            oCol.DepartmentUnit = oDeptUnit;
            oCol.HeadGroupID = "0";
            oCol.HeadID = txtHeadID.Text;
            oCol.HeadTitle = txtHeadTitle.Text;
            oCol.HeadTitleBeng = txtHeadTitleBeng.Text;
            oCol.Fee =Convert.ToDouble(txtFee.Text.ToString());
            if (chkDefault.Checked == true)
            {
                oCol.SetAsDefault = "1";              
            }
            if (chkDefault.Checked == false)
            {
                oCol.SetAsDefault = "0";               
            }
            if (chkIsSelectable.Checked == true)
            {
                oCol.IsSelectable = "1";
            }
            if (chkIsSelectable.Checked == false)
            {
                oCol.IsSelectable = "0";
            }
            oCol.PosSerial = txtPosSerial.Text.ToString();

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oCol.EntryParameter = ep;
            return oCol;
        }

        private void txtHeadTitle_TextChanged(object sender, EventArgs e)
        {
            txtHeadTitleBeng.Text = txtHeadTitle.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDepartmentType", "cboDepartmentGroup", "cboDepartment", "cboUnit", "txtHeadTitle", "txtHeadTitleBeng", "txtFee", "txtPosSerial" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                EmrCollHead oCol = this.PopulateEmrCollHeadSetup();
                if (Utility.IsDuplicateFoundInList(lvEmerCollHead, 9, txtHeadTitle.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHeadTitle.Focus();
                    return;
                }
                else
                {
                    short i = dmsSc.SaveEmrCollHead(oCol);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtHeadID.Text = "";
                        txtHeadTitle.Text = "";
                        txtHeadTitleBeng.Text = "";
                        txtFee.Text = "";
                        txtPosSerial.Text = "";
                        chkDefault.Checked = false;
                        chkIsSelectable.Checked = false;
                        this.btnShow_Click(sender, e);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDepartmentType", "cboDepartmentGroup", "cboDepartment", "cboUnit", "txtHeadID", "txtHeadTitle", "txtHeadTitleBeng", "txtFee", "txtPosSerial" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                 EmrCollHead oCol = this.PopulateEmrCollHeadSetup();
                 short i = dmsSc.UpdateEmrCollHead(oCol);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtHeadID.Text = "";
                        txtHeadTitle.Text = "";
                        txtHeadTitleBeng.Text = "";
                        txtFee.Text = "";
                        txtPosSerial.Text = "";
                        chkDefault.Checked = false;
                        chkIsSelectable.Checked = false;
                        this.btnShow_Click(sender, e);
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

        private void txtHeadTitle_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(oCols, txtHeadTitle.Text);
        }
        private void SearchListView(IEnumerable<EmrCollHead> oResults, string searchString = "")
        {
            try
            {
                IEnumerable<EmrCollHead> query;
                if (oResults != null)
                {
                    if (!(searchString.Length > 0))
                    {
                        query = oResults;
                    }
                    else
                    {
                        query = (from oRes in oResults
                                 where oRes.HeadTitle.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                                 select oRes);
                    }
                    lvEmerCollHead.Items.Clear();
                    foreach (EmrCollHead oCol in query)
                    {
                        ListViewItem itm = new ListViewItem(oCol.DepartmentGroup.DepartmentTypeID);
                        itm.SubItems.Add(oCol.DepartmentGroup.DepartmentGroupID);
                        itm.SubItems.Add(oCol.DepartmentGroup.DepartmentGroupTitle);
                        itm.SubItems.Add(oCol.Department.DepartmentID);
                        itm.SubItems.Add(oCol.Department.DepartmentTitle);
                        itm.SubItems.Add(oCol.DepartmentUnit.UnitId);
                        itm.SubItems.Add(oCol.DepartmentUnit.UnitTitle);
                        itm.SubItems.Add(oCol.HeadGroupID);
                        itm.SubItems.Add(oCol.HeadID);
                        itm.SubItems.Add(oCol.HeadTitle);
                        itm.SubItems.Add(oCol.HeadTitleBeng);
                        itm.SubItems.Add(oCol.Fee.ToString());
                        itm.SubItems.Add(oCol.SetAsDefault);
                        itm.SubItems.Add(oCol.IsSelectable);
                        itm.SubItems.Add(oCol.PosSerial);
                        lvEmerCollHead.Items.Add(itm);
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


    }
}
