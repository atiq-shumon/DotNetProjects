using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.HRSR;
using AH.DUtility;


namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmSalaryHead : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmSalaryHead()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() {"cboHeadType", "cboHeadGroup", "txtHeadTitle", "txtHeadTitleBeng"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {               
                    if (Utility.IsDuplicateFoundInList(lvSalHead, 1, txtHeadTitle.Text))
                    {
                        MessageBox.Show("Cannot Insert Duplicate Name");
                        txtHeadTitle.Focus();
                        return;
                    }
                    else
                    {
                        SalaryHead oSalHead = this.PopulateSalHdSetup();
                        short i = hmsSC.SaveSalaryHead(oSalHead);
                        if (i == 0)
                        {
                            MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i > 0)
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);                           
                            RefreshGrid();
                            txtHeadTitle.Text = "";
                            txtHeadTitleBeng.Text = "";
                            txtRemarks.Text = "";
                            txtHeadTitle.Focus();
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

        private SalaryHead PopulateSalHdSetup()
        {
            SalaryHead oSalHd = new SalaryHead();

            SalaryHeadGroup oSalHdGrp = new SalaryHeadGroup();
            oSalHdGrp.HeadGroupID = cboHeadGroup.SelectedValue.ToString();
            oSalHd.SalaryHeadGroup = oSalHdGrp; 

            oSalHdGrp.HeadType = cboHeadType.SelectedValue.ToString();
            oSalHd.SalaryHeadGroup = oSalHdGrp;      

            oSalHd.Srl = txtSerial.Text;
            oSalHd.HeadID = txtHeadID.Text;
            oSalHd.HeadTitle = txtHeadTitle.Text;
            oSalHd.HeadTitleBeng = txtHeadTitleBeng.Text;
            oSalHd.Remarks = txtRemarks.Text;
            
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oSalHd.EntryParameter = ep;
            return oSalHd;

        }

        private void frmSalaryHead_Load(object sender, EventArgs e)
        {
            cboHeadType.DisplayMember = "Value";
            cboHeadType.ValueMember = "Key";
            cboHeadType.DataSource = new BindingSource(Utility.GetSalaryTypes(), null);

           
            FormatGrid();
            LoadListView(cboHeadGroup.SelectedValue.ToString(), cboHeadType.SelectedValue.ToString());
            txtHeadTitle.Focus();
            
        }

        private void RefreshGrid()
        {
            LoadListView(cboHeadGroup.SelectedValue.ToString(),cboHeadType.SelectedValue.ToString());
        }

        private void FormatGrid()
        {
            lvSalHead.CheckBoxes = false;
            lvSalHead.Columns.Add("Head Type", 100, HorizontalAlignment.Left);            
            lvSalHead.Columns.Add("Head Group", 100, HorizontalAlignment.Left);
            lvSalHead.Columns.Add("Serial", 50, HorizontalAlignment.Center);
            lvSalHead.Columns.Add("Head ID", 50, HorizontalAlignment.Left);
            lvSalHead.Columns.Add("Head Name", 200, HorizontalAlignment.Left);
            lvSalHead.Columns.Add("Head Name(Beng)", 200, HorizontalAlignment.Left);
            lvSalHead.Columns.Add("Remarks", 200, HorizontalAlignment.Left);
        }

        private void LoadListView(string oSalHdG,string oSalHdH)
        {
            lvSalHead.Items.Clear();
            List<SalaryHead> oSalHds = new List<SalaryHead>();
            oSalHds = hmsSC.GetSalaryHeadsetup(cboHeadGroup.SelectedValue.ToString(),cboHeadType.SelectedValue.ToString()).ToList();
            foreach (SalaryHead salhd in oSalHds)
            {
                ListViewItem itm = new ListViewItem(salhd.SalaryHeadGroup.HeadType);
                itm.SubItems.Add(salhd.SalaryHeadGroup.HeadGroupID);
                itm.SubItems.Add(salhd.Srl);
                itm.SubItems.Add(salhd.HeadID);
                itm.SubItems.Add(salhd.HeadTitle);
                itm.SubItems.Add(salhd.HeadTitleBeng);
                itm.SubItems.Add(salhd.Remarks);
                lvSalHead.Items.Add(itm);

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtHeadID", "cboHeadType", "cboHeadGroup", "txtHeadTitle", "txtHeadTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                SalaryHead oSalHead = this.PopulateSalHdSetup();
                short i = hmsSC.UpdateSalaryHead(oSalHead);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    txtHeadID.Text = "";
                    txtHeadTitle.Text = "";
                    txtHeadTitleBeng.Text = "";
                    txtRemarks.Text = "";
                    txtHeadTitle.Focus();
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

        private void lvSalHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSalHead.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvSalHead.SelectedItems[0];
                cboHeadType.SelectedValue = itm.SubItems[0].Text;
                cboHeadGroup.SelectedValue = itm.SubItems[1].Text;
                txtSerial.Text = itm.SubItems[2].Text;
                txtHeadID.Text = itm.SubItems[3].Text;
                txtHeadTitle.Text = itm.SubItems[4].Text;
                txtHeadTitleBeng.Text = itm.SubItems[5].Text;
                txtRemarks.Text = itm.SubItems[6].Text;
            }
        }

        private void cboHeadType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboHeadGroup.DisplayMember = "Value";
            cboHeadGroup.ValueMember = "Key";
            cboHeadGroup.DataSource = new BindingSource(hmsSC.GetSalGrp(cboHeadType.SelectedValue.ToString()), null);

        }

        private void cboHeadGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListView(cboHeadGroup.SelectedValue.ToString(), cboHeadType.SelectedValue.ToString());
        }

        private void lvSalHead_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtHeadTitle_TextChanged(object sender, EventArgs e)
        {
            txtHeadTitleBeng.Text = txtHeadTitle.Text;
        }
       
    }
}
