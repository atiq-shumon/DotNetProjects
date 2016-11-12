using AH.DUtility;
using AH.ModuleController.PatientRegistrationSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AH.ModuleController.UI.PatientRegistration.Forms
{
    public partial class frmPatientDetails : AH.Shared.UI.frmSmartFormStandard
    {
        public frmPatientDetails()
        {
            InitializeComponent();
        }
        PatientRegistrationSR.PatientRegistrationWSClient srch = new PatientRegistrationWSClient();
        private void frmPatientDetails_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadListView();
            txtPatientName.Select();
        }
        private void FormatGrid()
        {
            listPatientDetails.CheckBoxes = false;
            listPatientDetails.Columns.Add("HCN", 112, HorizontalAlignment.Left);
            listPatientDetails.Columns.Add("Patient Name", 165, HorizontalAlignment.Left);
            listPatientDetails.Columns.Add("Father's Name", 165, HorizontalAlignment.Left);
            listPatientDetails.Columns.Add("Mother's Name", 165, HorizontalAlignment.Left);
            listPatientDetails.Columns.Add("DOB", 92, HorizontalAlignment.Left);
            listPatientDetails.Columns.Add("Cell Phone Number", 142, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            listPatientDetails.Items.Clear();
            List<Patient> lspat = srch.GetPatientsDetails().ToList();

            foreach (Patient pat in lspat)
            {
                ListViewItem itm = new ListViewItem(pat.HCN);
                itm.SubItems.Add(pat.Name);
                itm.SubItems.Add(pat.FathersName);
                itm.SubItems.Add(pat.MothersName);
                itm.SubItems.Add(pat.DOB.Date.ToString("dd-MM-yyyy"));
                itm.SubItems.Add(pat.CellPhone);
                listPatientDetails.Items.Add(itm);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtPatientName.Text == "" && txtFathersName.Text == "" && txtPhoneNumber.Text == "" && txtDOB.Text.Length != 10)
            {
                MessageBox.Show("Please Provide Search Content", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string name, fathersName, phoneNumber, DOB;
                name = txtPatientName.Text.ToString();
                fathersName = txtFathersName.Text.ToString();
                phoneNumber = txtPhoneNumber.Text.ToString();
                if (txtDOB.Text != "  /  /")
                {
                    DOB = txtDOB.Text;
                }
                else
                {
                    DOB = "";
                }
               
                LoadListViewByCell( DOB,name, fathersName, phoneNumber);
            }
        }

        private void LoadListViewByCell(string DOB,string name, string fathersName,string phoneNumber )
        {
            listPatientDetails.Items.Clear();
            List<Patient> searchByCell = srch.SearchPatients(DOB,name, fathersName, phoneNumber).ToList();

            foreach (Patient cl in searchByCell)
            {
                ListViewItem itm = new ListViewItem(cl.HCN);
                itm.SubItems.Add(cl.Name);
                itm.SubItems.Add(cl.FathersName);
                itm.SubItems.Add(cl.MothersName);
                itm.SubItems.Add(cl.DOB.Date.ToString("dd/MM/yyyy"));
                itm.SubItems.Add(cl.CellPhone);
                listPatientDetails.Items.Add(itm);
            }
            this.listPatientDetails.View = View.Details;

            if (listPatientDetails.Items.Count == 0)
            {
                MessageBox.Show("Please Provide Valid Information...", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtPatientName.Text = string.Empty;
                //txtPhoneNumber.Text = string.Empty;
                //txtFathersName.Text = string.Empty;
                //txtDOB.Text = string.Empty;
                LoadListView();
            }
        }


        private void LoadListViewByCell(string p1, string p2)
        {
            string name = txtPatientName.Text;
            string phone = txtPhoneNumber.Text;

            listPatientDetails.Items.Clear();

            List<Patient> searchByCell = srch.GetPatientDetails(name, phone).ToList();

            foreach (Patient cl in searchByCell)
            {
                ListViewItem itm = new ListViewItem(cl.HCN);
                itm.SubItems.Add(cl.Name);
                itm.SubItems.Add(cl.FathersName);
                itm.SubItems.Add(cl.MothersName);
                itm.SubItems.Add(cl.DOB.Date.ToString("dd-MM-yyyy"));
                itm.SubItems.Add(cl.CellPhone);
                listPatientDetails.Items.Add(itm);
            }
            this.listPatientDetails.View = View.Details;

            if (listPatientDetails.Items.Count == 0 )
            {
                MessageBox.Show("Please Provide Valid Information...", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPatientName.Text = string.Empty;
                txtPhoneNumber.Text = string.Empty; 
                LoadListView();
            }            
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listPatientDetails.Clear();
            FormatGrid();
            LoadListView();
        }

        private void btnFullInfo_Click(object sender, EventArgs e)
        {
            if (listPatientDetails.SelectedItems.Count > 0)
            { 
                ListViewItem itm = listPatientDetails.SelectedItems[0];
                string HCN = itm.SubItems[0].Text;
                Dispose();
                frmPatientRegistration prObj = new frmPatientRegistration(HCN);
                prObj.ShowDialog();   
            }
        }

        private void listPatientDetails_DoubleClick(object sender, EventArgs e)
        {
            this.btnFullInfo_Click(sender, e);
        }
    }
}
