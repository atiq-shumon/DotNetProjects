using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using AH.DUtility;
using AH.ModuleController.HRSR;
using System.Drawing.Drawing2D;
using System.IO;

using System.Drawing.Imaging;
namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmEmployeePunishmentSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string EmpId { set; get; }
        public frmEmployeePunishmentSetup()
        {
            InitializeComponent();
        }
        private PunishmentType PopulatePunishmentType()
        {
            PunishmentType oPunType = new PunishmentType();
            EmployeeMaster oEmp = new EmployeeMaster();
            oEmp.EmpId = txtEmpId.Text.ToString();
            oPunType.EmployeeMaster = oEmp;
            oPunType.PunID = cboPunishment.SelectedValue.ToString();
            oPunType.Amount = txtAmount.Text;
            oPunType.EffectiveDate =Convert.ToDateTime(txtEffectiveDate.Text);
            oPunType.Duration = txtDuration.Text;
            oPunType.Serial = txtSerial.Text.ToString();
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oPunType.EntryParameter = ep;
            return oPunType;
        }
        private void RefreshGrid()
        {
            if (EmpId != "")
            {
                txtEmpId.Text = EmpId;
                LoadListView(txtEmpId.Text.ToString());
            }
            if (EmpId == "")
            {
                return;
            }            
        }
        private void FormatGrid()
        {
            lvPunishementType.CheckBoxes = false;
            lvPunishementType.Columns.Add("Serial", 0, HorizontalAlignment.Center);
            lvPunishementType.Columns.Add("Emp ID", 0, HorizontalAlignment.Center);
            lvPunishementType.Columns.Add("Punishment ID", 150, HorizontalAlignment.Center);
            lvPunishementType.Columns.Add("Punishment Title", 250, HorizontalAlignment.Left);
            lvPunishementType.Columns.Add("Amount", 100, HorizontalAlignment.Left);
            lvPunishementType.Columns.Add("Effective Date", 150, HorizontalAlignment.Left);
            lvPunishementType.Columns.Add("Duration", 100, HorizontalAlignment.Left);
        }
        private void LoadListView(string Emp)
        {
            lvPunishementType.Items.Clear();
            List<PunishmentType> oBenTypes = new List<PunishmentType>();
            oBenTypes = hmsSC.GetEmpPunishmentType(txtEmpId.Text.ToString()).ToList();
            foreach (PunishmentType oBenType in oBenTypes)
            {
                ListViewItem itm = new ListViewItem(oBenType.Serial);
                itm.SubItems.Add(oBenType.EmployeeMaster.EmpId);
                itm.SubItems.Add(oBenType.PunID);
                itm.SubItems.Add(oBenType.PunTitle);
                itm.SubItems.Add(oBenType.Amount);
                itm.SubItems.Add(oBenType.EffectiveDate.ToString("dd/MM/yyyy"));
                itm.SubItems.Add(oBenType.Duration);
                lvPunishementType.Items.Add(itm);
            }
        }

        private void lvPunishementType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPunishementType.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvPunishementType.SelectedItems[0];
                txtSerial.Text = itm.SubItems[0].Text;
                txtEmpId.Text = itm.SubItems[1].Text;
                cboPunishment.SelectedValue = itm.SubItems[2].Text;
                txtAmount.Text = itm.SubItems[4].Text;
                txtEffectiveDate.Text = itm.SubItems[5].Text;
                txtDuration.Text = itm.SubItems[6].Text; 
            }        
        }

        private void frmEmployeePunishmentSetup_Load(object sender, EventArgs e)
        {
            cboPunishment.DisplayMember = "Value";
            cboPunishment.ValueMember = "Key";
            cboPunishment.DataSource = new BindingSource(hmsSC.GetPunishmentDict("D"), null);
            FormatGrid();
            RefreshGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboPunishment", "txtEmpId" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (txtEffectiveDate.Text == "  /  /")
            {
                MessageBox.Show("Effective Date cannot be empty");
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvPunishementType, 1, cboPunishment.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name");
                    cboPunishment.Focus();
                    return;
                }
                else
                {
                    PunishmentType oPunType = this.PopulatePunishmentType();
                    short i = hmsSC.SaveEmpPunishmentSetup(oPunType);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //btnNew.PerformClick();
                        //RefreshGrid();
                        btnSearch_Click(sender, e);
                        txtAmount.Text = "";
                        txtEffectiveDate.Text = "";
                        txtDuration.Text = "";
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
            List<string> vf = new List<string>() { "cboPunishment", "txtEmpId" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (txtEffectiveDate.Text == "  /  /")
            {
                MessageBox.Show("Effective Date cannot be empty");
                return;
            }
            try
            {
                PunishmentType oPunType = this.PopulatePunishmentType();
                short i = hmsSC.UpdateEmpPunishmentSetup(oPunType);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    //RefreshGrid();
                    btnSearch_Click(sender, e);
                    txtAmount.Text = "";
                    txtEffectiveDate.Text = "";
                    txtDuration.Text = "";
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            lblInfo.Text = "";
            if (lvPunishementType.Items.Count > 0)
            {
                lvPunishementType.Items.Clear();
            }
            
        }

        private void lvPunishementType_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void cboPunishment_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<PunishmentType> oPunTypes = hmsSC.CheckPunishmentType(cboPunishment.SelectedValue.ToString()).ToList();
            if (oPunTypes.Count > 0)
            {
                foreach (PunishmentType oPun in oPunTypes)
                {
                    if (oPun.isAmount.ToString() == "1")
                    {
                        lblAmount.Enabled = true;
                        txtAmount.Enabled = true;
                        lblStar.Visible = true;
                        txtAmount.Focus();
                        txtAmount.Text = "";
                        //txtEffectiveDate.Text = "";
                    }
                    if (oPun.isAmount.ToString() == "0")
                    {
                        lblAmount.Enabled = false;
                        txtAmount.Enabled = false;
                        lblStar.Visible = false;
                        txtAmount.Text = "";
                        //txtEffectiveDate.Text = "";
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadListView(txtEmpId.Text.ToString());
        }

        private void btnAddPunishment_Click(object sender, EventArgs e)
        {
            frmPunishmentTypeSetup oPun = new frmPunishmentTypeSetup();
            oPun.ShowDialog();
        }

        private void btnRefreshPunishment_Click(object sender, EventArgs e)
        {
            cboPunishment.DisplayMember = "Value";
            cboPunishment.ValueMember = "Key";
            cboPunishment.DataSource = new BindingSource(hmsSC.GetPunishmentDict("D"), null);
        }

        private void txtEmpId_Leave(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtEmpId.Text);
            if (txtEmpId.Text == "")
            {
                lblInfo.Text = "";
                return;
            }
            if (txtEmpId.Text != "")
            {
                if (txtEmpId.Text == oEmpMas.EmpId)
                {
                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Designation.DesignationId.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Department.DepartmentTitle.ToString();
                }

                else
                {
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }     
    }
}
