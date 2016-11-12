using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using AH.ModuleController.ACMSSR;
using AH.DUtility;


namespace AH.ModuleController.UI.ACMS.Forms
{
    public partial class frmCreateObject : AH.Shared.UI.frmSmartFormStandard
    {
        ACMSSR.ACMSWSClient clnt = new ACMSWSClient();

        public frmCreateObject()
        {
            InitializeComponent();
        }
        ObjectSetup oObjectSetupBO = new ObjectSetup();
        //EntryParameter oEntryParameter = new EntryParameter();
        List<ObjectSetup> oObjectSetupBOs = new List<ObjectSetup>();
      

        private ObjectSetup PopulateObject()
        {
            ObjectSetup oObjectSetupBO = new ObjectSetup();

            oObjectSetupBO.ObjSerial = txtObjSerial.Text;
            oObjectSetupBO.ObjID = txtObjectID.Text;
            oObjectSetupBO.ObjName = txtObject.Text;
            oObjectSetupBO.ObjType = cboObjectType.SelectedValue.ToString();

            Module oModule = new Module();
            oModule.ModuleID = cboModule.SelectedValue.ToString();
            oModule.ModuleName = txtModuleID.Text;
            oObjectSetupBO.Module = oModule;

            EntryParameter oEntryParameter = new EntryParameter();
            oEntryParameter.Active = "1";
            oEntryParameter.Version = "1";
            oEntryParameter.CompanyID = Utility.CompanyID;
            oEntryParameter.LocationID = Utility.LocationID;
            oEntryParameter.MachineID = Utility.MachineID;
            oEntryParameter.EntryBy = Utility.UserId;
            oObjectSetupBO.EntryParameter = oEntryParameter;

            oObjectSetupBOs.Add(oObjectSetupBO);
            
            return oObjectSetupBO;
        }

        private void FormatGrid()
        {
            lvObject.Columns.Add("Serial", 100, HorizontalAlignment.Center);
            lvObject.Columns.Add("Object ID", 150, HorizontalAlignment.Center);
            lvObject.Columns.Add("Object Tittle", 150, HorizontalAlignment.Center);
            lvObject.Columns.Add("Object Type", 150, HorizontalAlignment.Center);
            lvObject.Columns.Add("Module ID", 0, HorizontalAlignment.Center);
            lvObject.Columns.Add("Module", 300, HorizontalAlignment.Center); 
        }

        private class TempGrid
        {
            public string ObjSerial { get; set; }
            public string ObjID { get; set; }
            public string ObjName { get; set; }
            public string ObjType { get; set; }
            public string ModuleID { get; set; }
            public string Module { get; set; }
        }


        private void LoadListView()
        {
            lvObject.Items.Clear();
            oObjectSetupBOs = clnt.GetsObjectSetupGrid().ToList();
            foreach (ObjectSetup fcat in oObjectSetupBOs)
            {
                ListViewItem itm = new ListViewItem(fcat.ObjSerial.ToString());
                itm.SubItems.Add(fcat.ObjID.ToString());
                itm.SubItems.Add(fcat.ObjName.ToString());
                itm.SubItems.Add(fcat.ObjType.ToString());
                itm.SubItems.Add(fcat.Module.ModuleID.ToString());
                itm.SubItems.Add(fcat.Module.ModuleName.ToString());
 
                lvObject.Items.Add(itm);
            }

            this.lvObject.View = View.Details;
        }

        private void LoadModule()
        {
            cboModule.ValueMember = "Key";
            cboModule.DisplayMember = "Value";
            cboModule.DataSource = new BindingSource(Utility.GetModuleNames(), null);
        }

        private void LoadObjecType()
        {
            cboObjectType.ValueMember = "Key";
            cboObjectType.DisplayMember = "Value";
            cboObjectType.DataSource = new BindingSource(Utility.GetObjectTypes(), null);
        }

        private void frmCreateObject_Load(object sender, EventArgs e)
        {
            txtModuleID.Visible = false;
            txtObjSerial.Visible = true;

            
            FormatGrid();
           // LoadListView();

            LoadObjecType();
            LoadModule();
         }

        private bool EditDelPreRequisit()
        {
            List<string> vf = new List<string>() { "cboModule", "cboObjectType", "txtObject", "txtObjectID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            return true;
        }

        private bool SavePreRequisit()
        {
            List<string> vf = new List<string>() { "cboModule", "cboObjectType", "txtObject" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ObjectSetup oObjectSetupBO = new ObjectSetup();
            btnEdit.Enabled = false;
            if (!SavePreRequisit())
            {
                return;
            }
            if (SavePreRequisit())
            {
                try
                {
                   // oObjectSetupBO = clnt.SaveObjectSetup(PopulateObject());
                    short i = clnt.SaveObjectSetup(PopulateObject());
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                    else if (i ==1)
                    {
                        MessageBox.Show("Already Same Object Exists!");
                        //btnNew.PerformClick();
                        txtObjectID.Text = "";
                        txtObject.Text = "";

                    }
                    else if (i == 2)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnShow.PerformClick();
                        txtObjectID.Text = "";
                        txtObject.Text = "";
                       // btnNew.PerformClick();

                    }
                    //if (oObjectSetupBO.EntryParameter.ErrorMessage == "")
                    //{
                    //    LoadListView();
                    //    btnNew.PerformClick();
                    //}
                    //if (oObjectSetupBO.EntryParameter.ErrorMessage != "")
                    //{
                    //    MessageBox.Show(oObjectSetupBO.EntryParameter.ErrorMessage);
                    //}
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

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            ObjectSetup oObjectSetupBO = new ObjectSetup();

            if (!EditDelPreRequisit())
            {
                return;
            }
            if (EditDelPreRequisit())
            {
                try
                {

                    //oObjectSetupBO = clnt.EditObjectSetup(PopulateObject());
                    oObjectSetupBO = clnt.UpdateObject(PopulateObject());
                    if (oObjectSetupBO.EntryParameter.ErrorMessage == "")
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //LoadListView();
                        btnShow.PerformClick();
                        btnNew.PerformClick();
                        return;
                    }
                    if (oObjectSetupBO.EntryParameter.ErrorMessage != "")
                    {
                        MessageBox.Show(oObjectSetupBO.EntryParameter.ErrorMessage);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void lvObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvObject.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvObject.SelectedItems[0];

                txtObjSerial.Text = itm.SubItems[0].Text;
                txtObjectID.Text = itm.SubItems[1].Text;
                txtObject.Text = itm.SubItems[2].Text;
                cboObjectType.Text = itm.SubItems[3].Text;
                txtModuleID.Text = itm.SubItems[4].Text;
                cboModule.Text = itm.SubItems[5].Text;
  
            }
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //ObjectSetup oObjectSetupBO = new ObjectSetup();

            if (!EditDelPreRequisit())
            {
                return;
            }
            if (EditDelPreRequisit())
            {
                try
                {
                    oObjectSetupBO = clnt.DeleteObjectSetup(txtObjectID.Text.ToString());
                    if (oObjectSetupBO.EntryParameter.ErrorMessage == "")
                    {
                        LoadListView();
                        btnShow.PerformClick();
                        txtObjectID.Text = "";
                        txtObject.Text = "";
                       // btnNew.PerformClick();

                    }
                    if (oObjectSetupBO.EntryParameter.ErrorMessage != "")
                    {
                        MessageBox.Show(oObjectSetupBO.EntryParameter.ErrorMessage.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
           LoadListView();
           string ModuleID = "";
           string ObjetType = ""; 
           List<TempGrid> oTempGrids = new List<TempGrid>();

           if(ModuleID!=null && ObjetType!=null )
           {
               ModuleID = cboModule.SelectedValue.ToString();
               ObjetType = cboObjectType.Text.ToString();
           }

           for (int rowcnt = 0; rowcnt < oObjectSetupBOs.Count; rowcnt++)
           {
               if (ModuleID == oObjectSetupBOs[rowcnt].Module.ModuleID.ToString() && ObjetType == oObjectSetupBOs[rowcnt].ObjType.ToString())
               {
                   TempGrid oTempGrid = new TempGrid();

                   oTempGrid.ObjSerial = oObjectSetupBOs[rowcnt].ObjSerial;
                   oTempGrid.ObjID = oObjectSetupBOs[rowcnt].ObjID;
                   oTempGrid.ObjName = oObjectSetupBOs[rowcnt].ObjName;
                   oTempGrid.ObjType = oObjectSetupBOs[rowcnt].ObjType;
                   oTempGrid.ModuleID = oObjectSetupBOs[rowcnt].Module.ModuleID;
                   oTempGrid.Module = oObjectSetupBOs[rowcnt].Module.ModuleName;
                             
                   oTempGrids.Add(oTempGrid);
               }

           }

            lvObject.Items.Clear();

            if (oTempGrids.Count>0)
            {
                foreach (TempGrid fcat in oTempGrids)
                {
                    ListViewItem itm = new ListViewItem(fcat.ObjSerial);
                    itm.SubItems.Add(fcat.ObjID);
                    itm.SubItems.Add(fcat.ObjName);
                    itm.SubItems.Add(fcat.ObjType);
                    itm.SubItems.Add(fcat.ModuleID);
                    itm.SubItems.Add(fcat.Module);

                    lvObject.Items.Add(itm);
                }

            }
            
            this.lvObject.View = View.Details;
        }

        private void cboModule_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                cboObjectType.Focus();
            }
        }

        private void cboObjectType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtObject.Focus();
            }
        }

        private void txtObject_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
