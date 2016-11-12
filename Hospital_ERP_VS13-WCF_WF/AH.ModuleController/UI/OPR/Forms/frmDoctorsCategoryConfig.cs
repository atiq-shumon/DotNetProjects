using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.OPRMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.OPR.Forms
{
    public partial class frmDoctorsCategoryConfig : AH.Shared.UI.frmSmartFormStandard
    {
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        public frmDoctorsCategoryConfig()
        {
            InitializeComponent();
        }
        #region "FormLoad"
        private void frmDoctorsCategoryConfig_Load(object sender, EventArgs e)
        {
            try
            {
                LoadModule();
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
        #region "Load Module"
        private void LoadModule()
        {
            try
            {
                lstLeftList.ValueMember = "Key";
                lstLeftList.DisplayMember = "Value";
                lstLeftList.DataSource = new BindingSource(accmSc.GetDoctorsCategory("getregidFromhrm", "D"), null);
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
        #region "check Duplicate"
        private Boolean  checkDuplicate(string strRight)
        {
            for(int i=0; i<lstRightList.Items.Count;i++)
            {
                string strDuplicate = lstRightList.Items[i].ToString();
                if (strRight == strDuplicate)
                {
                    MessageBox.Show("Cannot Move Duplicate Value of " + strRight );
                    return true;
                }
            }
            return false;
        }
        #endregion
        #region "Right/Left"
        private void cmdRightOne_Click(object sender, EventArgs e)
        {
            string strRitem = lstLeftList.Text.ToString();
            if (checkDuplicate(strRitem))
            {
                return;
            }
            
            
            if (lstLeftList.SelectedItem != null)
            {

                listBox1.Items.Add(lstLeftList.SelectedValue.ToString());
                lstRightList.Items.Add(lstLeftList.Text);
                lstLeftList.Items.Remove(lstRightList.Text);
            }

            for (int x = 0; x < lstLeftList.Items.Count; x++)
            {

                lstLeftList.SetSelected(x, false);
            }
            for (int x = 0; x < lstRightList.Items.Count; x++)
            {

                lstRightList.SetSelected(x, true);
            }
        }
        private void cmdPreviousLeft_Click(object sender, EventArgs e)
        {
            if (lstRightList.Items.Count > 0)
            {
                for (int i = 0; i < lstRightList.Items.Count; i++)
                {
                    if (lstRightList.GetSelected(i) == true)
                    {
                        lstRightList.Items.RemoveAt(i);
                        listBox1.Items.RemoveAt(i);
                    }
                }
            }
            for (int x = 0; x < lstLeftList.Items.Count; x++)
            {

                lstLeftList.SetSelected(0, true);
            }
            for (int x = 0; x < lstRightList.Items.Count; x++)
            {

                lstRightList.SetSelected(x, false);
            }
        }
        #endregion
        #region "Validationfields"
        private bool ValidateFields()
        {
            if (cboDoctorsCategory.Text == "")
            {
                MessageBox.Show("Cannot empty");
                cboDoctorsCategory.Focus();
                return true;
            }


            return false;
        }
        #endregion
        #region "Category"
        private int  GetCategoryValue(string strCatName)
        {
            int i = 0;
            switch (strCatName.ToString())
            {
                case "Surgeon":
                    i =  1;
                    break;
                case "RMO":
                    i= 2;
                    break;
                case "OT Nurse":
                    i = 3;
                    break;
                 case "OT Technisian":
                    i = 4;
                    break;
                case "General Nurse":
                    i = 5;
                    break;
                case "Anesthesiologist":
                    i = 6;
                    break;
                case "OT Helper":
                    i = 7;
                    break;
                case "Others":
                    i = 8;
                    break;
                case "Assistant Surgeon":
                    i = 9;
                    break;
            }
            return i;

        }
        private string FixedMasterKey(string strCatName)
        {
            string strCateValue="";
            switch (strCatName.ToString())
            {
                case "Surgeon":
                    strCateValue = "Surgeon" + "0000001";
                    break;
                case "RMO":
                    strCateValue = "RMO" + "0000001";
                    break;
                case "OT Nurse":
                    strCateValue = "OTNurse" + "0000001";
                    break;
                case "OT Technisian":
                    strCateValue = "OTTechnisian" + "0000001";
                    break;
                case "General Nurse":
                    strCateValue = "GeneralNurse" + "0000001";
                    break;
                case "Anesthesiologist":
                    strCateValue = "Anesthesiologist" + "0000001";
                    break;
                case "OT Helper":
                    strCateValue = "OTHelper" + "0000001";
                    break;
                case "Others":
                    strCateValue = "Others" + "0000001";
                    break;
                case "OT Incharge":
                    strCateValue = "OT Incharge" + "0000001";
                    break;
                case "Assistant Surgeon":
                    strCateValue = "Assistant Surgeon" + "0000001";
                    break;
                  
            }
            return strCateValue.ToString();
        }
        private void Getdisplay(string strCatName)
        {
            string strFixedValue;
            listBox1.Items.Clear();
            lstRightList.Items.Clear();
            strFixedValue = FixedMasterKey(strCatName.ToString());
            List<DoctorsCategory> objCat = accmSc.DisplayDoctorsCategory("DisplayCattype", strFixedValue).ToList();
            foreach (DoctorsCategory dc in objCat)
            {
                //cboDoctorsCategory.Text = dc.CategoryName.ToString();
                listBox1.Items.Add(dc.doctorscode.ToString());
                lstRightList.Items.Add(dc.doctorsName.ToString());
            }
        }
        private DoctorsCategory PopulateDoctorsCategory(string strCatName,string strDoctorsCode="")
        {
            int j;
            string strFixedKey="";
            j = GetCategoryValue(strCatName.ToString());
            strFixedKey = FixedMasterKey(strCatName.ToString());

            DoctorsCategory objCat = new DoctorsCategory();
            objCat.doctorscode = strDoctorsCode;
            objCat.assignId = strFixedKey.ToString();
            objCat.assignmenttype = j;
            objCat.FixedKeyMaster = strFixedKey.ToString();
            objCat.CategoryName = strCatName.ToString();

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objCat.EntryParameter = ep;
            return objCat;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            short i=0;
            if (ValidateFields() == true)
            {
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    DoctorsCategory objCategory1 = this.PopulateDoctorsCategory(cboDoctorsCategory.Text.ToString());
                    i = accmSc.SavedDoctotsCategoryMaster(objCategory1);
                    if (i > 0)
                    {
                        for (int k = 0; k < listBox1.Items.Count; k++)
                        {
                            DoctorsCategory objCategory = this.PopulateDoctorsCategory(cboDoctorsCategory.Text.ToString(), listBox1.Items[k].ToString());
                            i = accmSc.SavedDoctotsCategory(objCategory);
                        }
                    }
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        cboDoctorsCategory.Focus();
                        LoadModule();

                    }
                }
            }

            //catch (System.ServiceModel.CommunicationException commp)
            //{
            //    MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void cboDoctorsCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btnEdit.Enabled = true ;
            //btnSave.Enabled = false;
            
            if (cboDoctorsCategory.SelectedIndex >= 0 || cboDoctorsCategory.SelectedIndex == -1)
            {
                Getdisplay(cboDoctorsCategory.Text.ToString());
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            short i = 0;
            if (ValidateFields() == true)
            {
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    DoctorsCategory objCategory1 = this.PopulateDoctorsCategory(cboDoctorsCategory.Text.ToString());
                    i = accmSc.SavedDoctotsCategoryMaster(objCategory1);
                    if (i > 0)
                    {
                        for (int k = 0; k < listBox1.Items.Count; k++)
                        {
                            DoctorsCategory objCategory = this.PopulateDoctorsCategory(cboDoctorsCategory.Text.ToString(), listBox1.Items[k].ToString());
                            i = accmSc.SavedDoctotsCategory(objCategory);
                        }
                    }
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        cboDoctorsCategory.Focus();
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
        #region "Clear"
        private void Clear()
        {
            listBox1.Items.Clear();
            lstRightList.Items.Clear();
            cboDoctorsCategory.Focus();
        }
        #endregion
        #region "New"
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            Clear();
        }
        #endregion


    }
}
