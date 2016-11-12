using AH.APMS.DAL;
using AH.APMS.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmApmsTest
{
    public partial class frmApms : Form
    {
        public frmApms()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadListView();
        }
        List<OpdAppointment> oOpdAppointments = new List<OpdAppointment>();

        private void LoadListView()
        {

            oOpdAppointments = new ApmsSetupDAL().TEST();
            for (int count = 0; count < oOpdAppointments.Count; count++)
            {
                OpdAppointment oOpdAppointment = new OpdAppointment();
                oOpdAppointment.AppointDate = oOpdAppointments[count].AppointDate;
                oOpdAppointment.ApproxSTime = oOpdAppointments[count].ApproxSTime;
                oOpdAppointments.Add(oOpdAppointment);
            }
           dgvPatientAppoint.DataSource = oOpdAppointments;

            //int i = 0;
            //foreach (OpdAppointment oOPDApp in oOpdAppointments)
            //{
            //    ListViewItem itm = new ListViewItem(di.);
            //    itm.SubItems.Add(oOPDApp.Title);
            //    itm.SubItems.Add(oOPDApp.TitleBeng);
            //    itm.SubItems.Add(oOPDApp.Remarks);
            //    dgvPatientAppoint.Items.Add(itm);
            //}

        }
    }
}
