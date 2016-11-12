using AH.DUtility;
using AH.ModuleController.NWMSSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AH.ModuleController.UI.NWMS.Forms
{
    public partial class frmIPDPatDocVisitDetails : AH.Shared.UI.frmSmartFormStandard
    {
        NWMSSR.NWMSWSClient nwbnch = new NWMSSR.NWMSWSClient();
        public frmIPDPatDocVisitDetails()
        {
            InitializeComponent();
        }

        private void frmIPDPatDocVisitDetails_Load(object sender, EventArgs e)
        {
            FormateListView();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtPatRegNoIPD.Text != "")
            {
                string vrfy = nwbnch.VerifyInPatient(txtPatRegNoIPD.Text);
                if (vrfy.Length > 0)
                {
                    MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnNew.PerformClick();
                    txtPatRegNoIPD.Focus();
                    return;
                }
                else
                {
                    LoadListView();
                }
            }
        }
        private void FormateListView()
        {
            lvIPDDoctors.Columns.Add("Department ID", 0, HorizontalAlignment.Left);//1
            lvIPDDoctors.Columns.Add("Department", 125, HorizontalAlignment.Left);//2
            lvIPDDoctors.Columns.Add("Unit ID", 0, HorizontalAlignment.Left);//3
            lvIPDDoctors.Columns.Add("Unit", 125, HorizontalAlignment.Left);//4
            lvIPDDoctors.Columns.Add("Doctor ID", 0, HorizontalAlignment.Left);//5
            lvIPDDoctors.Columns.Add("Doctor", 231, HorizontalAlignment.Left);//6
            lvIPDDoctors.Columns.Add("Visiting Fee", 125, HorizontalAlignment.Left);//7
            lvIPDDoctors.Columns.Add("Visiting Date", 125, HorizontalAlignment.Left);//8
        }
        private void LoadListView()
        {
            List<IPDDoctor> oIPDDoc = nwbnch.GetIPDVisitingFeeDetails(txtPatRegNoIPD.Text).ToList();

            lvIPDDoctors.Items.Clear();

            if (oIPDDoc.Count > 0)
            {
                foreach (IPDDoctor doc in oIPDDoc)
                {
                    ListViewItem itm = new ListViewItem(doc.Department.DepartmentID);
                    itm.SubItems.Add(doc.Department.DepartmentTitle);
                    itm.SubItems.Add(doc.DepartmentUnit.UnitId);
                    itm.SubItems.Add(doc.DepartmentUnit.UnitTitle);
                    itm.SubItems.Add(doc.ID);
                    itm.SubItems.Add(doc.Name);
                    itm.SubItems.Add(Convert.ToString(doc.IPDVisitingFee));
                    itm.SubItems.Add(Convert.ToString(doc.EntryParameter.EntryDate.ToString("dd-MMM-yyyy")));
                    lvIPDDoctors.Items.Add(itm);
                }
            }
        }

       

    }
}
