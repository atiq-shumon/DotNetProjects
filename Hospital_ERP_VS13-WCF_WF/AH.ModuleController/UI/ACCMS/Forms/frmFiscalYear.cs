using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.AccountsMSSR;
using AH.DUtility;



namespace AH.ModuleController.UI.ACCMS.Forms
{
    public partial class frmFiscalYear : AH.Shared.UI.frmSmartFormStandard
    {
        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();


        public frmFiscalYear()
        {
            InitializeComponent();
        }
        private void LoadListView()
        {
            lvwFiscalYear.Items.Clear();
            List<FinancialYear> purp = accmSc.GetFiscalYear().ToList();
            foreach (FinancialYear fy in purp)
            {
                ListViewItem itm = new ListViewItem(fy.YearID);
                itm.SubItems.Add(fy.FinancialYearForm.ToString());
                itm.SubItems.Add(fy.FinancialYearTo);
                if (fy.YearStatus.ToString() == "1")
                {
                    itm.SubItems.Add("Closed");
                }
                else
                {
                    itm.SubItems.Add("Active");
                }
                lvwFiscalYear.Items.Add(itm);
            }
        }






        private FinancialYear PopulateFiscalYear()
        {
            FinancialYear fy = new FinancialYear();
            fy.YearID = txtYearID.Text;
            fy.FinancialYearForm = dteStartDate.Value.ToString("dd/MM/yyyy");
            fy.FinancialYearTo = dteEndDate.Value.ToString("dd/MM/yyyy");
            fy.YearStatus = Convert.ToInt16(cboStatus.SelectedValue);

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            fy.EntryParameter = ep;
            return fy ;
        }


        private bool Validatefields()
        {

            if (Convert.ToDateTime(dteStartDate.Value.ToString("dd/MM/yyyy")) > Convert.ToDateTime(dteEndDate.Value.ToString("dd/MM/yyyy")))
            {
                MessageBox.Show("Form Date Cannot be Greater then To Date");
                dteStartDate.Focus();
                return true;
            }

            if (Convert.ToDateTime(dteEndDate.Value.ToString("dd/MM/yyyy")) < Convert.ToDateTime(dteStartDate.Value.ToString("dd/MM/yyyy")))
            {
                MessageBox.Show("To Date Cannot be Less then From Date");
                dteStartDate.Focus();
                return true;
            }





            if (btnSave.Enabled == true)
            {
                if (Utility.IsDuplicateFoundInList(lvwFiscalYear, 3, "Active"))
                {
                    MessageBox.Show("Only One Financial Year Can be Active at a time");
                    cboStatus.Focus();
                    return true;
                }
            }
            else
            {
                for (int i = 0; i < lvwFiscalYear.Items.Count; i++)
                {
                    if (cboStatus.SelectedValue != "1")
                    {
                        if (txtYearID.Text.ToString() != lvwFiscalYear.Items[i].SubItems[0].Text.ToString())
                        {
                            if (lvwFiscalYear.Items[i].SubItems[3].Text.ToString() == "Active")
                            {
                                MessageBox.Show("Only One Financial Year Can be Active at a time");
                                return true;
                            }
                        }
                    }
                }

            }





            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validatefields() == true)
            {
                return;
            }


            if (cboStatus.Text == "")
            {
                MessageBox.Show("Cannot be Empty");
                cboStatus.Focus();
                return;
            }
            try
            {
                FinancialYear Fy = this.PopulateFiscalYear();
                short i = accmSc.InsertFiscalYear(Fy);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListView();
                    btnNew.PerformClick();
                    dteStartDate.Focus();
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
            if (Validatefields() == true)
            {
                return;
            }

            if (cboStatus.Text == "")
            {
                MessageBox.Show("Cannot be Empty");
                cboStatus.Focus();
                return;
            }
            try
            {
                FinancialYear Fy = this.PopulateFiscalYear();
                short i = accmSc.UpdateFiscalYear(Fy);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListView();
                    btnNew.PerformClick();
                    dteStartDate.Focus();
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

        private void lvwFiscalYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwFiscalYear.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
                ListViewItem itm = lvwFiscalYear.SelectedItems[0];
                txtYearID.Text = itm.SubItems[0].Text;
                dteStartDate.Text = itm.SubItems[1].Text;
                dteEndDate.Text = itm.SubItems[2].Text;
                if (itm.SubItems[3].Text == "Active")
                {
                    cboStatus.SelectedValue = "0";
                }
                else
                {
                    cboStatus.SelectedValue = "1";
                }
                
            }
        }

        private void frmFiscalYear_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> objcomboBox = new Dictionary<string, string>();
            objcomboBox.Add("0", "Active");
            objcomboBox.Add("1", "Closed");
            cboStatus.DataSource = new BindingSource(objcomboBox, null);
            cboStatus.DisplayMember = "Value";
            cboStatus.ValueMember = "Key";
            cboStatus.SelectedIndex = 1;
            dteStartDate.Focus();
            LoadListView();

        }

        private void dteStartDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)  Keys.Return )
            {
                dteEndDate.Focus();
            }
        }

        private void dteEndDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboStatus.Focus();
            }
        }

        private void cboStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSave.Focus();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            dteStartDate.Focus();
        }

       



    }
}
