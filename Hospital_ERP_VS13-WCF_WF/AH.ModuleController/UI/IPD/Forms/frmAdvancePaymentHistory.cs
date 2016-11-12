using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.IPDSR;

namespace  AH.ModuleController.UI.IPD.Forms
{
    public partial class frmAdvancePaymentHistory : AH.Shared.UI.frmSmartFormStandard
    {
        private string regNo, name;
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        public frmAdvancePaymentHistory(string regNo, string name)
        {
            InitializeComponent();
            this.regNo = regNo;
            this.name = name;
        }
        PatientAdmissionUtility obj = new PatientAdmissionUtility();
        private void LoadPatient(InPatient pat)
        {
            txtPatientName.Text = pat.Name;
            txtRegNo.Text = pat.RegistrationNo;
            txtHcnNo.Text = pat.HCN;
        }
        private void RefreshGrid(string regNo)
        {
            obj.LoadAdnceListView(lvAdPay, regNo);
        }     
       
        private void frmAdvancePayment_Load(object sender, EventArgs e)
        {         
                obj.FormatAdvancePaymentList(lvAdPay);
                InPatient pat = ipdSc.GetAdmittedPatient(regNo);
                LoadPatient(pat);
                txtTotalAmount.Text = ipdSc.GetTotalAmount(regNo).ToString();
                RefreshGrid(regNo);
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

    }
}
