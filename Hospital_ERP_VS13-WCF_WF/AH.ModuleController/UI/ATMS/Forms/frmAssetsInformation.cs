using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.ModuleController.ATMSSR;
using AH.DUtility;


namespace AH.ModuleController.UI.ATMS.Forms
{
    public partial class frmAssetsInformation : AH.Shared.UI.frmSmartFormStandard
    {
        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();
        public string strTagNo { set; get; }
        public string strModelNo { set; get; }
        public string strModelName { set; get; }
        public string strSerialNo { set; get; }
        public string strsupplierCode { set; get; }
        public string strsupplierName { set; get; }
        public string strChallanNo { set; get; }
        public string strChallanDate { set; get; }
        public string strWarrentyDate { set; get; }
        public string strInventoryRef { set; get; }
        public string strInventoryDate { set; get; }
        public string strProductcode { set; get; }

        public frmAssetsInformation()
        {
            InitializeComponent();
        }

        private void frmAssetsInformation_Load(object sender, EventArgs e)
        {

            txtTagNo.Text = strTagNo.ToString();
            txtModelCode.Text = strModelNo;
            txtModelName.Text = strModelName;
            txtSerialNo.Text = strSerialNo;
            txtSupplierCode.Text = strsupplierCode; 
            txtSupplierName.Text = strsupplierName;
            txtchallanNo.Text = strChallanNo;
            txtChallanadte.Text = strChallanDate;
            txtInvMrr.Text = strInventoryRef;
            txtInvDate.Text = strInventoryDate;
            txtWarrentyDate.Text = strWarrentyDate; 
            txtProductCode.Text = strProductcode;
            List<AdditionalInformation> objadd = atms.DisplayAddInformation("DispalyAddinfo", txtTagNo.Text).ToList();
            int i = objadd.Count();
            int j = 0;
            DG.Rows.Add(i);
            foreach (AdditionalInformation add in objadd)
            {
                txtColor.Text = add.color;
                txtCondition.Text = add.condition;
                txtManufacturerName.Text = add.manufacturername;
                txtSereviceProviderName.Text = add.serviceprovidername;
                txtContactPerson.Text = add.contactperson;
                txtMobileNo.Text = add.mobileno;
                DG.Rows[j].Cells[0].Value = add.componentname;
                DG.Rows[j].Cells[1].Value = add.description;
                DG.Rows[j].Cells[2].Value = add.notes;
                j = j + 1;
            }
        }
        private AdditionalInformation  PopulateAddinformation()
        {
            AdditionalInformation objAdd = new AdditionalInformation();
            objAdd.tagNo = txtTagNo.Text;
            objAdd.color = txtColor.Text;
            objAdd.condition = txtCondition.Text;
            objAdd.manufacturername  = txtManufacturerName.Text;
            objAdd.serviceprovidername = txtSereviceProviderName.Text;
            objAdd.contactperson = txtContactPerson.Text;
            objAdd.mobileno  = txtMobileNo.Text;
            objAdd.ProductCode = txtProductCode.Text;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objAdd.EntryParameter = ep;
            return objAdd;
        }

        private AdditionalInformation PopulateAaddCom(string strComponentName,string strDescription,string strNotes)
        {
            AdditionalInformation objAdd = new AdditionalInformation();
            objAdd.tagNo = txtTagNo.Text;
            objAdd.ProductCode = txtProductCode.Text;
            objAdd.componentname = strComponentName;
            objAdd.description = strDescription;
            objAdd.notes = strNotes;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objAdd.EntryParameter = ep;
            return objAdd;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
          
                var strResponse = MessageBox.Show("Do You want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    AdditionalInformation objAdd = this.PopulateAddinformation();
                    short i = atms.SaveAdditionalInfo(objAdd);
                    if (i == 1)
                    {
                        for (int k = 0; k < DG.Rows.Count-1; k++)
                        {
                            AdditionalInformation objcom = this.PopulateAaddCom(DG.Rows[k].Cells[0].Value.ToString(),
                                                            DG.Rows[k].Cells[1].Value.ToString(), DG.Rows[k].Cells[2].Value.ToString());

                            short t = atms.SaveAdditionalCompInfo(objcom);
                        }
                    }
                    
                }
          
        }

      
    }
}
