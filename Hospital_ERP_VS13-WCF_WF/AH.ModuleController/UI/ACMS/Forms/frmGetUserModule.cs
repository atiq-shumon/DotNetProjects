using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Linq;
using AH.DUtility;
using AH.ModuleController.ACMSSR;
using AH.Shared.MODEL;


namespace AH.ModuleController.UI.ACMS.Forms
{
    public partial class frmGetUserModule : AH.Shared.UI.frmSmartFormStandard
    {
        ACMSSR.ACMSWSClient clnt = new ACMSWSClient();

        public frmGetUserModule()
        {
            InitializeComponent();
        }

        public class UserModule
        {
            public string EmployeeID { get; set; }  
        }

        //private void btnShowModule_Click(object sender, EventArgs e)
        //{
        //    lvEmployeeAccessModule.Items.Clear();

        //    //FormatGrid();
        //    LoadListView();

        //}
        //private void btnShowModule_Click(object sender, EventArgs e)
        //{
        //    lvEmployeeAccessModule.Items.Clear(); 

        //    //FormatGrid();
        //    LoadListView();

        //    //List<Module> olist = new List<Module>();
        //    //olist = clnt.GetUserModule(txtEmployeeID.Text).ToList();
        //    //    for (int rowcnt = 0; rowcnt < olist.Count; rowcnt++)
        //    //    {
        //    //        if (olist[rowcnt].ModuleID.ToString() != "")
        //    //        {
        //    //            Module oModule = new Module();
        //    //            oModule.ModuleID = olist[rowcnt].ToString();
        //    //            oModule.ModuleName = olist[rowcnt].ToString(); //***
        //    //        }
        //    //    }
           
        //}

        private void btnShowModule_Click(object sender, EventArgs e)
        {
            AH.ModuleController.ACMSSR.EmployeeMaster oEmpMas = clnt.GetEmpoyee(txtEmployeeID.Text);
            if (txtEmployeeID.Text != oEmpMas.EmpId)
            {
                MessageBox.Show("Please put a valid employee id", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeID.Select();
                return;
            }
            lvEmployeeAccessModule.Items.Clear();

            //FormatGrid();
            LoadListView();
        }

        private void FormatGrid()
        {
            lvEmployeeAccessModule.Items.Clear();
            lvEmployeeAccessModule.Columns.Add("Module ID", 150, HorizontalAlignment.Center);
            lvEmployeeAccessModule.Columns.Add("Module Name", 300, HorizontalAlignment.Center);
        }

        private void LoadListView()
        {
            lvEmployeeAccessModule.Items.Clear();

            List<Module> olist = new List<Module>();

            olist = clnt.GetUserModule(txtEmployeeID.Text).ToList();
            if (lvEmployeeAccessModule.Columns.Count > 0)
            {
                foreach (Module fcat in olist)
                {
                    ListViewItem itm = new ListViewItem(fcat.ModuleID);
                    //itm.SubItems.Add(fcat.ModuleID);
                    itm.SubItems.Add(fcat.ModuleName);
                    lvEmployeeAccessModule.Items.Add(itm);
                }
                this.lvEmployeeAccessModule.View = View.Details;
            }
        }

        private void frmGetUserModule_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Select();
            FormatGrid();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lvEmployeeAccessModule.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
       
    }
}
