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
    public partial class frmLedgerList : AH.Shared.UI.frmSmartFormStandard
    {
        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();
        public frmLedgerList()
        {
            InitializeComponent();
        }
        #region "listview"
        private void FormatGrid()
        {
            lvwLedgerList.CheckBoxes = false;
            lvwLedgerList.Columns.Add("Sl No", 0, HorizontalAlignment.Center);
            lvwLedgerList.Columns.Add("Ledger Name", 360, HorizontalAlignment.Left);
            lvwLedgerList.Columns.Add("Under", 370, HorizontalAlignment.Left);
            lvwLedgerList.Columns.Add("Oepning Dr", 0, HorizontalAlignment.Left);
            lvwLedgerList.Columns.Add("Opening Cr", 0, HorizontalAlignment.Left);
            lvwLedgerList.Columns.Add("Default Ledger", 0, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvwLedgerList.Items.Clear();

            List<Ledgers> ldr = accmSc.GetLedgersDetails().ToList();
            int i = 0;
            foreach (Ledgers ledgers in ldr )
            {
                ListViewItem itm = new ListViewItem(ledgers.lngSlNo.ToString());
                itm.SubItems.Add(ledgers.strLedgerName);
                itm.SubItems.Add(ledgers.strGrUnder);
                //itm.SubItems.Add(ledgers.);
                if (double.Parse(ledgers.dblopeningBalance.ToString()) < 0)
                {
                    itm.SubItems.Add(Math.Abs(double.Parse(ledgers.dblopeningBalance.ToString())) + "Dr");
                }
                else
                {
                    itm.SubItems.Add("0");
                }

                if (double.Parse(ledgers.dblopeningBalance.ToString()) > 0)
                {
                    itm.SubItems.Add(Math.Abs(double.Parse(ledgers.dblopeningBalance.ToString())) + "Cr");
                }
                else
                {
                    itm.SubItems.Add("0");
                }

                itm.SubItems.Add(ledgers.lngDefaultLedger.ToString());
                lvwLedgerList.Items.Add(itm);
            }
        }
        #endregion
        #region "Load"
        private void frmLedgerList_Load(object sender, EventArgs e)
        {
            try
            {
                FormatGrid();
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
        #region "Delete"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            
            if ((Int32.Parse(lvwLedgerList.FocusedItem.SubItems[5].Text)) == 1)
            {
                MessageBox.Show("Degault ledger Cannot Delete","Delete",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    var strResponse = MessageBox.Show("Do U want to Delete?", "Delete Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (strResponse == DialogResult.Yes)
                    {
                        short i = accmSc.DeleteLedger((Int32.Parse(lvwLedgerList.FocusedItem.SubItems[0].Text)));
                        if (i == 0)
                        {
                            MessageBox.Show("Transaction Found Cannot Delete", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i > 0)
                        {
                            MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnNew.PerformClick();
                            //txtGroupName.Focus();
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


        }
        #endregion
        #region "SelectedChanged"
        private void lvwLedgerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwLedgerList.SelectedItems.Count == 0)
            {
                return;
            }
            txtEdit.Text = lvwLedgerList.FocusedItem.SubItems[1].Text;
        }
        #endregion


    }
}
