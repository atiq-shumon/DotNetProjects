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
using System.Globalization;
using System.Diagnostics;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmFinalizeDropList : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        int selectedIndex = 0;
        public frmFinalizeDropList()
        {
            InitializeComponent();
        }

        private void txtFinalizeBy_Leave(object sender, EventArgs e)
        {
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtFinalizeBy.Text);
            if (txtFinalizeBy.Text != "")
            {
                if (txtFinalizeBy.Text == oEmpMas.EmpId)
                {
                    txtFinalizeByName.Text = oEmpMas.FirstName;
                }

                else
                {
                    MessageBox.Show("Invalid Employee ID!!!Please Enter Correct ID", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFinalizeByName.Text = "";
                    txtFinalizeBy.Focus();
                }
            }
        }

        private void FormatGrid()
        {
            dgvFinalizeGrid.ColumnCount = 10;
            this.dgvFinalizeGrid.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvFinalizeGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvFinalizeGrid.Columns[0].Name = "Srl";
            dgvFinalizeGrid.Columns[0].Width = 0;
            dgvFinalizeGrid.Columns[0].Visible = false;
            dgvFinalizeGrid.Columns[1].Name = "ID";
            dgvFinalizeGrid.Columns[1].Width = 45;
            dgvFinalizeGrid.Columns[1].ReadOnly = true;
            dgvFinalizeGrid.Columns[2].Name = "Name";
            dgvFinalizeGrid.Columns[2].Width = 200;
            dgvFinalizeGrid.Columns[2].ReadOnly = true;
            dgvFinalizeGrid.Columns[3].Name = "Drop Type";
            dgvFinalizeGrid.Columns[3].Width = 0;
            dgvFinalizeGrid.Columns[3].Visible = false;
            dgvFinalizeGrid.Columns[4].Name = "Drop Date";
            dgvFinalizeGrid.Columns[4].Width = 90;
            dgvFinalizeGrid.Columns[4].ReadOnly = true;
            dgvFinalizeGrid.Columns[5].Name = "Effective Date";
            dgvFinalizeGrid.Columns[5].Width = 100;
            dgvFinalizeGrid.Columns[5].ReadOnly = true;
            dgvFinalizeGrid.Columns[6].Name = "Verified By";
            dgvFinalizeGrid.Columns[6].Width = 0;
            dgvFinalizeGrid.Columns[6].Visible = false;
            dgvFinalizeGrid.Columns[7].Name = "Verified By Name";
            dgvFinalizeGrid.Columns[7].Width = 180;
            dgvFinalizeGrid.Columns[7].ReadOnly = true;
            dgvFinalizeGrid.Columns[8].Name = "Verified Date";
            dgvFinalizeGrid.Columns[8].Width = 0;
            dgvFinalizeGrid.Columns[8].Visible = false;
            dgvFinalizeGrid.Columns[9].Name = "Remarks";
            dgvFinalizeGrid.Columns[9].Width = 0;
            dgvFinalizeGrid.Columns[9].Visible = false;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvFinalizeGrid.Columns.Add(btn);
            btn.HeaderText = "Finalize";
            btn.Text = "Finalize";
            btn.Name = "btn";
            btn.DefaultCellStyle.ForeColor = Color.Navy;
            btn.UseColumnTextForButtonValue = true;
            btn.Width = 61;
        }
        private void FormatCompletedGrid()
        {
            dgvCompletedGrid.ColumnCount = 10;
            this.dgvCompletedGrid.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvCompletedGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvCompletedGrid.Columns[0].Name = "Srl";
            dgvCompletedGrid.Columns[0].Width = 0;
            dgvCompletedGrid.Columns[0].Visible = false;
            dgvCompletedGrid.Columns[1].Name = "ID";
            dgvCompletedGrid.Columns[1].Width = 50;
            dgvCompletedGrid.Columns[1].ReadOnly = true;
            dgvCompletedGrid.Columns[2].Name = "Name";
            dgvCompletedGrid.Columns[2].Width = 220;
            dgvCompletedGrid.Columns[2].ReadOnly = true;
            dgvCompletedGrid.Columns[3].Name = "Drop Type";
            dgvCompletedGrid.Columns[3].Width = 0;
            dgvCompletedGrid.Columns[3].Visible = false;
            dgvCompletedGrid.Columns[4].Name = "Drop Date";
            dgvCompletedGrid.Columns[4].Width = 100;
            dgvCompletedGrid.Columns[4].ReadOnly = true;
            dgvCompletedGrid.Columns[5].Name = "Effective Date";
            dgvCompletedGrid.Columns[5].Width = 110;
            dgvCompletedGrid.Columns[5].ReadOnly = true;
            dgvCompletedGrid.Columns[6].Name = "Verified By";
            dgvCompletedGrid.Columns[6].Width = 0;
            dgvCompletedGrid.Columns[6].Visible = false;
            dgvCompletedGrid.Columns[7].Name = "Verified By Name";
            dgvCompletedGrid.Columns[7].Width = 220;
            dgvCompletedGrid.Columns[7].ReadOnly = true;
            dgvCompletedGrid.Columns[8].Name = "Verified Date";
            dgvCompletedGrid.Columns[8].Width = 0;
            dgvCompletedGrid.Columns[8].Visible = false;
            dgvCompletedGrid.Columns[9].Name = "Remarks";
            dgvCompletedGrid.Columns[9].Width = 0;
            dgvCompletedGrid.Columns[9].Visible = false;         
        }

        private void frmFinalizeDropList_Load(object sender, EventArgs e)
        {
            cboDropType.DisplayMember = "Value";
            cboDropType.ValueMember = "Key";
            cboDropType.DataSource = new BindingSource(Utility.GetDropTypes(), null);

            FormatGrid();
            FormatCompletedGrid();
        }

        private void LoadListView(string DropType)
        {
            try
            {
                dgvFinalizeGrid.Rows.Clear();
                int i = 0;
                List<EmployeeDropList> oDrops = hmsSC.GetEmpDropListForFinalizeByType(cboDropType.SelectedValue.ToString()).ToList();
                if (oDrops.Count > 0)
                {
                    foreach (EmployeeDropList oDrop in oDrops)
                    {
                        dgvFinalizeGrid.Rows.Add(1);
                        dgvFinalizeGrid.Rows[i].Cells[0].Value = oDrop.ListSerial;
                        dgvFinalizeGrid.Rows[i].Cells[1].Value = oDrop.EmployeeMaster.EmpId;
                        dgvFinalizeGrid.Rows[i].Cells[2].Value = oDrop.EmployeeMaster.Name;
                        dgvFinalizeGrid.Rows[i].Cells[3].Value = oDrop.DropTypeID;
                        dgvFinalizeGrid.Rows[i].Cells[4].Value = oDrop.DropDate;
                        dgvFinalizeGrid.Rows[i].Cells[5].Value = oDrop.DropEffectiveDate;
                        dgvFinalizeGrid.Rows[i].Cells[6].Value = oDrop.VerifiedBy;
                        dgvFinalizeGrid.Rows[i].Cells[7].Value = oDrop.VerifiedByName;
                        dgvFinalizeGrid.Rows[i].Cells[8].Value = oDrop.VerifiedDate;
                        dgvFinalizeGrid.Rows[i].Cells[9].Value = oDrop.Remarks;
                        i = i + 1;
                    }
                    dgvFinalizeGrid.AllowUserToAddRows = false;
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void LoadCompletedListView(string DropType)
        {
            try
            {
                dgvCompletedGrid.Rows.Clear();
                int i = 0;
                List<EmployeeDropList> oDrops = hmsSC.GetCompletedFinalizedList(cboDropType.SelectedValue.ToString()).ToList();
                if (oDrops.Count > 0)
                {
                    foreach (EmployeeDropList oDrop in oDrops)
                    {
                        dgvCompletedGrid.Rows.Add(1);
                        dgvCompletedGrid.Rows[i].Cells[0].Value = oDrop.ListSerial;
                        dgvCompletedGrid.Rows[i].Cells[1].Value = oDrop.EmployeeMaster.EmpId;
                        dgvCompletedGrid.Rows[i].Cells[2].Value = oDrop.EmployeeMaster.Name;
                        dgvCompletedGrid.Rows[i].Cells[3].Value = oDrop.DropTypeID;
                        dgvCompletedGrid.Rows[i].Cells[4].Value = oDrop.DropDate;
                        dgvCompletedGrid.Rows[i].Cells[5].Value = oDrop.DropEffectiveDate;
                        dgvCompletedGrid.Rows[i].Cells[6].Value = oDrop.VerifiedBy;
                        dgvCompletedGrid.Rows[i].Cells[7].Value = oDrop.VerifiedByName;
                        dgvCompletedGrid.Rows[i].Cells[8].Value = oDrop.VerifiedDate;
                        dgvCompletedGrid.Rows[i].Cells[9].Value = oDrop.Remarks;
                        i = i + 1;
                    }
                    dgvCompletedGrid.AllowUserToAddRows = false;
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private EmployeeDropList PopulateDropListFinalize()
        {
            EmployeeDropList oDropList = new EmployeeDropList();
            oDropList.ListSerial = dgvFinalizeGrid.Rows[selectedIndex].Cells[0].Value.ToString();
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas.EmpId = dgvFinalizeGrid.Rows[selectedIndex].Cells[1].Value.ToString();
            oDropList.EmployeeMaster = oEmpMas;
            oDropList.FinalizeBy = txtFinalizeBy.Text.ToString();            
            return oDropList;
        }
        private void dgvFinalizeGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFinalizeGrid.Columns[e.ColumnIndex].Name == "btn")
            {
                if (dgvFinalizeGrid.CurrentCell != null)
                {
                    selectedIndex = dgvFinalizeGrid.CurrentCell.RowIndex;
                    if (selectedIndex > -1)
                    {
                        List<string> vf = new List<string>() {"txtFinalizeBy"};
                        Control control = Utility.ReqFieldValidator(this, vf);
                        if (control != null)
                        {
                            MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            control.Focus();
                            return;
                        }

                        DialogResult msg = MessageBox.Show("Do You want to Finalize Drop List?", Utility.MessageCaptionMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                         if (msg == DialogResult.Yes)
                         {
                             EmployeeDropList oEmpDropList = this.PopulateDropListFinalize();
                             short i = hmsSC.UpdateFinalizeDropList(oEmpDropList);
                             if (i == 0)
                             {
                                 MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                             }
                             else if (i > 0)
                             {
                                 MessageBox.Show("Employee Added to Drop List Successfully", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                 LoadListView(cboDropType.SelectedValue.ToString());
                                 LoadCompletedListView(cboDropType.SelectedValue.ToString());
                             }
                         }
                         if (msg == DialogResult.No)
                         {
                             return;
                         }
                    }
                }
            }      
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadListView(cboDropType.SelectedValue.ToString());
            LoadCompletedListView(cboDropType.SelectedValue.ToString());
        }


    }
}
