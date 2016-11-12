using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using AH.ModuleController.ATMSSR;
using AH.DUtility;


namespace AH.ModuleController.UI.ATMS.Forms
{
    public partial class frmServiceDetails : AH.Shared.UI.frmSmartFormStandard
    {
        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();
        public string strSlNo = "";
        public frmServiceDetails()
        {
            InitializeComponent();
        }
        #region "Validationfields"
        private bool validationfields()
        {
            string strServiceDate = "";
            string strExpectedReturnDate = "";
            string strReturnDate = "";
            
            if (txtSLNo.Text.ToString() == "")
            {
                txtSLNo.Focus();
                return true;
            }

            try
            {
                for (int i = 0; i < DG.Rows.Count - 1; i++)
                {
                    if (DG.Rows[i].Cells[2].Value.ToString() == null)
                    {
                        MessageBox.Show("Service Date Cannot be Empty");
                        return true;
                    }
                    if (DG.Rows[i].Cells[2].Value != null)
                    {
                        strServiceDate = DG.Rows[i].Cells[2].Value.ToString();
                    }
                    else
                    {
                        strServiceDate = "";

                    }
                    if (DG.Rows[i].Cells[3].Value != null)
                    {
                        strExpectedReturnDate = DG.Rows[i].Cells[3].Value.ToString();
                    }
                    else
                    {
                        strExpectedReturnDate = "";
                    }
                    if (DG.Rows[i].Cells[4].Value != null )
                    {
                        strReturnDate = DG.Rows[i].Cells[4].Value.ToString();
                    }
                    else
                    {
                        strReturnDate = "";
                    }

                    if (strServiceDate != "" && strExpectedReturnDate != "")
                    {
                        DateTime dteServiceDate = Convert.ToDateTime(strServiceDate.ToString());
                        DateTime dteExpectedRDate = Convert.ToDateTime(strExpectedReturnDate.ToString());

                        if (dteServiceDate > dteExpectedRDate)
                        {
                            MessageBox.Show("Expected Return Date Cannot be Less than Your Service date");
                            return true;
                        }
                    }

                    if (strServiceDate != "" && strReturnDate != "")
                    {
                        DateTime dteServiceDate = Convert.ToDateTime(strServiceDate.ToString());
                        DateTime dteReturnDate = Convert.ToDateTime(strReturnDate.ToString());
                        if (dteServiceDate > dteReturnDate)
                        {
                            MessageBox.Show("Return Date Cannot be Less than Your Service date");
                            return true;
                        }
                    }

                    if (strReturnDate != "" && strExpectedReturnDate != "")
                    {
                        DateTime dteReturnDate = Convert.ToDateTime(strReturnDate.ToString());
                        DateTime dteExpectedRDate = Convert.ToDateTime(strExpectedReturnDate.ToString());

                        if (dteExpectedRDate > dteReturnDate)
                        {
                            MessageBox.Show("Return Date Cannot be Less than Your  EXpected Return date");
                            return true;
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Date Format");
                return true;
            }


                return false;
        }
        #endregion
        #region "Save"
        private void btnSave_Click(object sender, EventArgs e)
        {
            short k = 0;
            if (validationfields() == true)
            {
                return;
            }
            else
            {
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    short t = atms.DeleteServiceDetails(txtSLNo.Text);
                    if (t > 0)
                    {
                        ServiceDetails SP = this.PopulateServiceProvider();
                        for (int i = 0; i < DG.Rows.Count - 1; i++)
                        {
                            string slNo = "", serviceid = "", serviceDate = "", strRetuenDate = "", expireReturnDate = "", Remarks = "";
                            int intstatus = 0;
                            slNo = txtSLNo.Text;
                            serviceid = DG.Rows[i].Cells[0].Value.ToString();
                            serviceDate = DG.Rows[i].Cells[2].Value.ToString();
                            //strRetuenDate = DG.Rows[i].Cells[2].Value.ToString();
                          
                            if (DG.Rows[i].Cells[3].Value != null)
                            {
                                expireReturnDate = DG.Rows[i].Cells[3].Value.ToString();
                            }
                            else
                            {
                                expireReturnDate = "";
                            }
                            if (DG.Rows[i].Cells[4].Value != null)
                            {
                                strRetuenDate = DG.Rows[i].Cells[4].Value.ToString();
                            }
                            else
                            {
                                strRetuenDate = "";
                            }
                            if (DG.Rows[i].Cells[5].Value != null)
                            {
                                Remarks = DG.Rows[i].Cells[5].Value.ToString();
                            }
                            else
                            {
                                Remarks = "";
                            }
                            if (Convert.ToBoolean(DG.Rows[i].Cells[6].Value) == true)
                            {
                                intstatus = 1;
                            }
                            //Remarks = DG.Rows[i].Cells[4].Value.ToString();

                            //serviceid = DG.Rows[i].Cells[0].Value.ToString();

                            k = atms.SaveServiceDetails(slNo, serviceid, serviceDate, strRetuenDate, expireReturnDate, Remarks, intstatus, SP);
                        }

                    }
                    //short i = atms.SaveServiceProviderInfor(SP);
                    if (k == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (k > 0)
                    {
                        //MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // DisplayDetails();
                        btnNew.PerformClick();
                        DG.Rows.Clear();
                        //txtServiceProviderName.Focus();

                    }
                }

            }
        }
        #endregion
        #region "Populated"
        private ServiceDetails PopulateServiceProvider()
        {
            ServiceDetails objSp = new ServiceDetails();

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objSp.EntryParameter = ep;
            return objSp;
        }
        #endregion
        #region "Load"
        private void frmServiceDetails_Load(object sender, EventArgs e)
        {
            try
            {
                Column2.ValueMember = "Key";
                Column2.DisplayMember = "value";
                Column2.DataSource = new BindingSource(atms.GetServiceProvider("Getservicprovider", ""), null);
                //GetDetails(txtSLNo.Text);
                if (strSlNo != "")
                {
                    txtSLNo.Text = strSlNo;
                }

                if (txtSLNo.Text != "")
                {
                    GetDetails(txtSLNo.Text);
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
        private void GetLoad(string strSlNo)
        {
            int i;
            int k = 0;
            try
            {
                List<ServiceProvider> objsp = atms.GetServiceProviderInfo("LoadService", strSlNo).ToList();
                i = objsp.Count();
                if (i > 0)
                {
                    DG.Rows.Add(i);
                    foreach (ServiceProvider sp in objsp)
                    {
                        txtProductName.Text = sp.itemName;
                        DG[0, k].Value = sp.ID;
                        //  DG[1, k].Value = sp.ServiceProviderName;

                        DG.Rows[k].Cells["Column2"].Value = sp.ID.ToString();
                        DG.Rows[k].Cells[2].Value = sp.servicedate;
                        //DG.Rows[k].Cells[0].Value = sp.ID;
                        //DG.Rows[k].Cells[1].Value = sp.ServiceProviderName;
                        k = k + 1;
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
        #region "Details"
        private void GetDetails(string strSlNo)
        {
            int i;
            int k = 0;
            DG.Rows.Clear();
            try
            {
                List<ServiceProvider> objsp = atms.GetServiceDetailsofSlno("Getservicedetails", strSlNo).ToList();
                i = objsp.Count();
                if (i > 0)
                {
                    DG.Rows.Add(i);
                    foreach (ServiceProvider sp in objsp)
                    {
                        txtProductName.Text = sp.itemName;
                        //DG.Rows[k].Cells[0].Value = sp.ID;
                        DG[0, k].Value = sp.ID;
                        //DG[1, k].Value = sp.ServiceProviderName;
                        DG.Rows[k].Cells["Column2"].Value = sp.ID.ToString();
                        DG.Rows[k].Cells[2].Value = sp.servicedate;
                        // DG.Rows[k].Cells[1].Value = sp.ServiceProviderName;
                        DG.Rows[k].Cells[3].Value = sp.expectedReturnDate;
                        DG.Rows[k].Cells[4].Value = sp.returndate;
                        DG.Rows[k].Cells[5].Value = sp.Remarks;
                        if (Convert.ToInt16(sp.Status) == 1)
                        {
                            Convert.ToBoolean(DG.Rows[k].Cells[6].Value = true);
                        }
                        else
                        {
                            Convert.ToBoolean(DG.Rows[k].Cells[6].Value = false);
                        }
                        k = k + 1;
                    }
                }
                else
                {
                    GetLoad(strSlNo);
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
        #region "Keypress"
        private void txtSLNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Return)
            {
                DG.Focus();
            }
        }
        private void dteSDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                DG.Focus();
            }
        }
        #endregion 
        #region "Click
        private void btnapply_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSLNo.Text != "")
                {
                    GetDetails(txtSLNo.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            short k = 0;
            if (validationfields() == true)
            {
                return;
            }
            else
            {
                var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    short t = atms.DeleteServiceDetails(txtSLNo.Text);
                    if (t > 0)
                    {
                        ServiceDetails SP = this.PopulateServiceProvider();
                        for (int i = 0; i < DG.Rows.Count - 1; i++)
                        {
                            string slNo = "", serviceid = "", serviceDate = "", strRetuenDate = "", expireReturnDate = "", Remarks = "";
                            int intStatus = 0;
                            slNo = txtSLNo.Text;
                            serviceid = DG.Rows[i].Cells[0].Value.ToString();
                            //serviceDate = dteSDate.Text;
                            //strRetuenDate = DG.Rows[i].Cells[2].Value.ToString();

                            if (DG.Rows[i].Cells[2].Value != null)
                            {
                                strRetuenDate = DG.Rows[i].Cells[2].Value.ToString();
                            }
                            else
                            {
                                strRetuenDate = "";
                            }

                            if (DG.Rows[i].Cells[3].Value != null)
                            {
                                expireReturnDate = DG.Rows[i].Cells[3].Value.ToString();
                            }
                            else
                            {
                                expireReturnDate = "";
                            }
                            if (DG.Rows[i].Cells[4].Value != null)
                            {
                                Remarks = DG.Rows[i].Cells[4].Value.ToString();
                            }
                            else
                            {
                                Remarks = "";
                            }
                            k = atms.SaveServiceDetails(slNo, serviceid, serviceDate, strRetuenDate, expireReturnDate, Remarks, intStatus, SP);
                        }

                        if (k == 0)
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (k > 0)
                        {
                            btnNew.PerformClick();
                        }
                    }
                }

            }
        }
        #endregion
        #region "CellEvent"
        private void DG_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {   if (e.ColumnIndex==1)
            DG.Rows[e.RowIndex].Cells[0].Value = DG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }
        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex==6)
            //{
            //    if (Convert.ToBoolean(DG.Rows[e.RowIndex].Cells[6].Value = false))
            //    {
            //        DG.Rows[e.RowIndex].Cells[4].ReadOnly = false;
            //    }
            //    else
            //    {
            //        DG.Rows[e.RowIndex].Cells[4].ReadOnly = true;
            //    }
            //}
        }
        #endregion
    }
}
