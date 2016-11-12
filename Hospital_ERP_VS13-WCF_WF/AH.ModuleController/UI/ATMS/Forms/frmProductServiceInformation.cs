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
    public partial class frmProductServiceInformation : AH.Shared.UI.frmSmartFormStandard
    {
        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();
        public frmProductServiceInformation()
        {
            InitializeComponent();
        }

        #region "Load"
        private void GetDetails(string strSlNo)
        {
            int i;
            int k = 0;
            DGS.Rows.Clear();
            try
            {
                List<ServiceProvider> objsp = atms.GetServiceDetailsofSlno("GetserviceInfo", strSlNo).ToList();
                i = objsp.Count();
                if (i > 0)
                {
                    DGS.Rows.Add(i);
                    foreach (ServiceProvider sp in objsp)
                    {
                        DGS.Rows[k].Cells[0].Value = sp.SerialNo;
                        DGS.Rows[k].Cells[1].Value = sp.itemName;
                        DGS.Rows[k].Cells[2].Value = sp.servicedate;
                        DGS.Rows[k].Cells[3].Value = sp.ServiceProviderName;
                        DGS.Rows[k].Cells[4].Value = "Servicing";
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
        private void GetInvGroups()
        {
            try
            {
                cboGroupName.ValueMember = "groupid";
                cboGroupName.DisplayMember = "GroupName";
                cboGroupName.DataSource = atms.GetInvGroup("Getgroupinfo", "").ToList();
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
        #region "CreateGrid"
        private DataGridViewTextBoxColumn Create_Grid_Column(string pname, string htext, int cwidth, Boolean true_false, DataGridViewContentAlignment Align,
         Boolean read_only)
        {
            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.DataPropertyName = pname;
            col0.HeaderText = htext;
            col0.DefaultCellStyle.ForeColor = Color.Black;
            col0.DefaultCellStyle.BackColor = Color.White;
            col0.Visible = true_false;
            col0.DefaultCellStyle.Alignment = Align;
            col0.Width = cwidth;
            col0.ReadOnly = read_only;
            return col0;
        }
        public DataGridViewButtonColumn Create_Grid_Column_button(string pname, string htext, string btext, int cwidth, Boolean true_false,
          DataGridViewContentAlignment Align, Boolean read_only)
        {
            DataGridViewButtonColumn col0 = new DataGridViewButtonColumn();
            col0.DataPropertyName = pname;
            col0.HeaderText = htext;
            col0.Text = btext;
            col0.DefaultCellStyle.ForeColor = Color.Red;
            col0.DefaultCellStyle.BackColor = Color.Pink ;
            col0.Visible = true_false;
            col0.DefaultCellStyle.Alignment = Align;
            col0.Width = cwidth;
            col0.ReadOnly = read_only;
            return col0;
        }
        #endregion
        #region "Load"
        private void LaodService()
        {
            DGS.Rows.Clear();
            DGI.Rows.Clear();
            DGS.Columns.Add(Create_Grid_Column("Product Sl", "Product Sl", 120, true, DataGridViewContentAlignment.MiddleLeft, true));
            DGS.Columns.Add(Create_Grid_Column("Product Name", "Product Name", 150, true, DataGridViewContentAlignment.MiddleLeft, true));
            DGS.Columns.Add(Create_Grid_Column("Service Provider Name", "Service Provider Name", 150, true, DataGridViewContentAlignment.MiddleLeft, true));
            DGS.Columns.Add(Create_Grid_Column("Phone No", "Phone No", 150, true, DataGridViewContentAlignment.MiddleLeft, true));
            DGS.Columns.Add(Create_Grid_Column("Warrenty Date", "Warrenty Date", 100, true, DataGridViewContentAlignment.MiddleLeft, true));
            DGS.Columns.Add(Create_Grid_Column("Rem. Days", "Rem. Days", 100, true, DataGridViewContentAlignment.MiddleLeft, true));
            DGS.Columns.Add(Create_Grid_Column("Exp. Return Date", "Exp. Return Date", 100, true, DataGridViewContentAlignment.MiddleLeft, true));
            DGS.Columns.Add(Create_Grid_Column("Return Date", "Return Date", 120, true, DataGridViewContentAlignment.MiddleLeft, true));
            DGS.Columns.Add(Create_Grid_Column("Warrenty Status", "Warrenty Status", 100, true, DataGridViewContentAlignment.MiddleLeft, true));
            DGS.Columns.Add(Create_Grid_Column_button("Show", "Show", "Show", 40, true, DataGridViewContentAlignment.TopCenter, true));

            DGI.Columns.Add(Create_Grid_Column("Emp. ID", "Emp. ID", 200, true, DataGridViewContentAlignment.MiddleLeft, true));
            DGI.Columns.Add(Create_Grid_Column("Employee Name", "Employee Name", 400, true, DataGridViewContentAlignment.MiddleLeft, true));
            DGI.Columns.Add(Create_Grid_Column("Department Name", "Department Name", 380, true, DataGridViewContentAlignment.MiddleLeft, true));
            DGI.Columns.Add(Create_Grid_Column("Receipt Date", "Receipt Date", 160, true, DataGridViewContentAlignment.MiddleLeft, true));
        }
        private void frmProductServiceInformation_Load(object sender, EventArgs e)
        {
            LaodService();
            GetInvGroups();
        }
        #endregion
        #region "ServiceDetails"
        private void  GetWarrentyServiceDetails(string strGrCode)
        {
            int i;
            int k = 0;
            DateTime dtedate;
            long lngDays;
            string strGroupID = strGrCode;
            DGS.Rows.Clear();
            List<ServiceProvider> objsp = atms.GetServiceDetailsofSlno("Getservicetogrpid", strGroupID).ToList();
            i = objsp.Count();
            if (i > 0)
            {
                DGS.Rows.Add(i);
                foreach (ServiceProvider sp in objsp)
                {
                    DGS.Rows[k].Cells[0].Value = sp.SerialNo;
                    DGS.Rows[k].Cells[1].Value = sp.itemName;
                    DGS.Rows[k].Cells[2].Value = sp.ServiceProviderName;
                    DGS.Rows[k].Cells[3].Value = sp.Phone;
                    DGS.Rows[k].Cells[4].Value = sp.servicedate;
                    dtedate = Convert.ToDateTime(sp.servicedate);
                    lngDays = (dtedate.Subtract(DateTime.Now).Days);
                    if (lngDays < 0)
                    {
                        lngDays = 0;
                    }
                    else
                    {
                        lngDays = Math.Abs(lngDays);
                    }
                    DGS.Rows[k].Cells[5].Value = lngDays;
                    DGS.Rows[k].Cells[6].Value = sp.expectedReturnDate;
                    DGS.Rows[k].Cells[7].Value = sp.returndate;
                    if (lngDays > 0)
                    {
                        DGS.Rows[k].Cells[8].Value = "Applicable";
                    }
                    else
                    {
                        DGS.Rows[k].Cells[8].Value = "Not Applicable";
                        DGS.Rows[k].Cells[8].Style.ForeColor = Color.Red;
                    }
                    k = k + 1;
                }
            }
        }
        #endregion 
        #region "Selected Index Changed"
        private void cboGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGS.Rows.Clear();
            try
            {
                if (cboGroupName.SelectedIndex >= 0 || cboGroupName.SelectedIndex == -1)
                {
                    if (cboGroupName.Text != "")
                        GetWarrentyServiceDetails(cboGroupName.SelectedValue.ToString());
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
        #region "Click"
        private void btnapply_Click(object sender, EventArgs e)
        {
            int i;
            int k = 0;
            DateTime dtedate;
            long lngDays;
            //string strGroupID = strGrCode;
            try
            {
                DGS.Rows.Clear();
                List<ServiceProvider> objsp = atms.GetServiceDetailsofSlno("GetserviceDetailstoSl", txtSLNo.Text).ToList();
                i = objsp.Count();
                if (i > 0)
                {
                    DGS.Rows.Add(i);
                    foreach (ServiceProvider sp in objsp)
                    {
                        DGS.Rows[k].Cells[0].Value = sp.SerialNo;
                        DGS.Rows[k].Cells[1].Value = sp.itemName;
                        DGS.Rows[k].Cells[2].Value = sp.ServiceProviderName;
                        DGS.Rows[k].Cells[3].Value = sp.Phone;
                        DGS.Rows[k].Cells[4].Value = sp.servicedate;
                        dtedate = Convert.ToDateTime(sp.servicedate);
                        lngDays = (dtedate.Subtract(DateTime.Now).Days);
                        if (lngDays < 0)
                        {
                            lngDays = 0;
                        }
                        else
                        {
                            lngDays = Math.Abs(lngDays);
                        }
                        DGS.Rows[k].Cells[5].Value = lngDays;
                        DGS.Rows[k].Cells[6].Value = sp.expectedReturnDate;
                        DGS.Rows[k].Cells[7].Value = sp.returndate;
                        if (lngDays > 0)
                        {
                            DGS.Rows[k].Cells[8].Value = "Applicable";
                        }
                        else
                        {
                            DGS.Rows[k].Cells[8].Value = "Not Applicable";
                        }
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
        private void DGS_DoubleClick(object sender, EventArgs e)
        {
            //string strSlNo = "";
            //strSlNo =DGS.Rows[e.]
        }
        private void DGS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strSlNo = "";
            if (e.ColumnIndex == 9)
            {
                int selRowIndex = e.RowIndex;
                if (selRowIndex >= 0)
                {
                    if (DGS.Rows[e.RowIndex].Cells[0].Value !=null)
                    {
                        strSlNo = DGS.Rows[e.RowIndex].Cells[0].Value.ToString();
                        frmServiceDetails frm = new frmServiceDetails();
                        frm.strSlNo = strSlNo;
                        frm.ShowDialog();
                    }
                }
            }
            


        }
        private void DGS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strSlNo = "";
            int intRow;
            int i=0;
            DGI.Rows.Clear();
                int selRowIndex = e.RowIndex;
                if (selRowIndex >= 0)
                {
                    if (DGS.Rows[e.RowIndex].Cells[0].Value != null)
                    {
                        strSlNo = DGS.Rows[e.RowIndex].Cells[0].Value.ToString();
                        List<AssetsIssue> objsp = atms.GetProductIssue("GetProductIssue", strSlNo).ToList();
                        intRow = objsp.Count;
                        if (intRow >0 )
                        {
                            foreach( AssetsIssue ai in objsp)
                            {
                                DGI.Rows[i].Cells[0].Value = ai.EmpID;
                                DGI.Rows[i].Cells[1].Value = ai.AssetsUser;
                                DGI.Rows[i].Cells[2].Value = ai.DepName;
                                DGI.Rows[i].Cells[3].Value = ai.Receiptdate;
                                i = i + 1;
                            }
                        }
                    }
                }
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

    }
}
