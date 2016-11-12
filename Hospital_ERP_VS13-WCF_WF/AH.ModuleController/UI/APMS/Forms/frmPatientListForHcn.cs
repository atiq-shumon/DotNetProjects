using AH.ModuleController.APMSSR;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;

namespace AH.ModuleController.UI.APMS.Forms
{
    public partial class frmPatientListForHcn : AH.Shared.UI.frmSmartFormStandard
    {
        APMSWSClient clnt = new APMSWSClient();
        APMSSR.APMSWSClient apmssr = new APMSSR.APMSWSClient();
        public frmPatientListForHcn()
        {
            InitializeComponent();
        }

        List<OpdAppointment> patList;     
        private void FormatGrid()
        {
            lstPatientList.CheckBoxes = false;
            lstPatientList.Columns.Add("Patient Name", 200, HorizontalAlignment.Center);
            lstPatientList.Columns.Add("Age", 50, HorizontalAlignment.Center);
            lstPatientList.Columns.Add("Phone Number", 150, HorizontalAlignment.Center);
            lstPatientList.Columns.Add("Appoint Time", 100, HorizontalAlignment.Center);
            lstPatientList.Columns.Add("Appoint Date", 100, HorizontalAlignment.Center);
            lstPatientList.Columns.Add("Token No.", 100, HorizontalAlignment.Center);
            lstPatientList.Columns.Add("Address", 200, HorizontalAlignment.Center);
            lstPatientList.Columns.Add("Email", 200, HorizontalAlignment.Center);
            lstPatientList.Columns.Add("Country", 200, HorizontalAlignment.Center);
            lstPatientList.Columns.Add("AppointID",0, HorizontalAlignment.Center);
        }
        private void LoadListView()
        {
            lstPatientList.Items.Clear();
            foreach (OpdAppointment Pat in patList)
            {               
               
                ListViewItem itm = new ListViewItem(Pat.Patient.Name);
                itm.SubItems.Add(Pat.Patient.AgeBreakDown.Year.ToString());
                itm.SubItems.Add(Pat.Patient.CellPhone.ToString());
                itm.SubItems.Add(Pat.ApproxSTime.ToString());
                itm.SubItems.Add(Pat.AppointDate.ToString());
                itm.SubItems.Add(Pat.TokenNo.ToString());
                itm.SubItems.Add(Pat.Patient.Permanent_H_R_B.ToString());
                itm.SubItems.Add(Pat.Patient.Email.ToString());
                itm.SubItems.Add(Pat.Patient.Country.ToString());
                itm.SubItems.Add(Pat.AppointID.ToString());
                lstPatientList.Items.Add(itm);

            }

        }

       // OpdAppointment oPat = new OpdAppointment();
        private void SearchPatientList(IEnumerable<OpdAppointment> patList, string searchString = "")
        {
            try
            {
                IEnumerable<OpdAppointment> query;
                if (!(searchString.Length > 0))
                {
                    query = patList;
                }
                else
                {
                    query = (from inPats in patList
                             where
                                 //inPats.Name.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)||
                             inPats.Patient.CellPhone.StartsWith(searchString, StringComparison.OrdinalIgnoreCase) ||
                             inPats.Patient.Name.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                             select inPats);
                }
                lstPatientList.Items.Clear();

                foreach (OpdAppointment Pat in query)
                {
                    ListViewItem itm = new ListViewItem(Pat.Patient.Name);
                    itm.SubItems.Add(Pat.Patient.AgeBreakDown.Year.ToString());
                    itm.SubItems.Add(Pat.Patient.CellPhone.ToString());
                    itm.SubItems.Add(Pat.ApproxSTime.ToString());
                    itm.SubItems.Add(Pat.AppointDate.ToString());
                    itm.SubItems.Add(Pat.TokenNo.ToString());
                    itm.SubItems.Add(Pat.Patient.Permanent_H_R_B.ToString());
                    itm.SubItems.Add(Pat.Patient.Email.ToString());
                    itm.SubItems.Add(Pat.Patient.Country.ToString());
                    itm.SubItems.Add(Pat.AppointID.ToString());
                    lstPatientList.Items.Add(itm);
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

        private void txtPatientMobile_KeyUp(object sender, KeyEventArgs e)
        {
            SearchPatientList(patList, txtPatientMobile.Text);
        }

        private void frmPatientListForHcn_Load(object sender, EventArgs e)
        {
          
                FormatGrid();
                patList = clnt.GetPatientListForHcn().ToList();
                LoadListView();
        
        }

        private void txtPatientMobile_Enter(object sender, EventArgs e)
        {
           // SearchPatientList(patList, txtPatientMobile.Text);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
