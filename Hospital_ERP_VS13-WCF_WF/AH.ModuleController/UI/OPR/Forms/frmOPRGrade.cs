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
    public partial class frmOPRGrade : AH.Shared.UI.frmSmartFormStandard
    {
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        public frmOPRGrade()
        {
            InitializeComponent();
        }
        #region "Grade"
        private Grade PopulateGrade()
        {
            Grade  grade = new Grade();
            grade.GradeId = txtGradeID.Text.ToString();
            grade.GradeTitle  = txtGradetitle.Text.ToString();
            //grade.TitleBangla  = txtGradetitleBangla.Text.ToString();
            grade.Remarks = txtRemarks.Text.ToString();
            if (Cboactive.Text.ToString() == "Active")
            {
                grade.Active = "1";
            }
            else
            {
                grade.Active = "0";
            }
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            grade.EntryParameter = ep;
            return grade;
        }
        private bool ValidateFields()
        {
            List<string> vf = new List<string>() {"txtRemarks" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            if (Cboactive.Text == "")
            {
                MessageBox.Show(Utility.getFMS(Cboactive.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            return true;
        }
        private void FormatGrid()
        {
            lvwGradeDetails.CheckBoxes = false;
            lvwGradeDetails.Columns.Add("Grade Id", 260, HorizontalAlignment.Center);
            lvwGradeDetails.Columns.Add("Title Name", 290, HorizontalAlignment.Left);
            lvwGradeDetails.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
            lvwGradeDetails.Columns.Add("Status", 290, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvwGradeDetails.Items.Clear();
            List<Grade> grade = accmSc.GetGrade().ToList(); 
            foreach (Grade bo in grade)
            {
                ListViewItem itm = new ListViewItem(bo.GradeId);
                itm.SubItems.Add(bo.GradeTitle);
                itm.SubItems.Add(bo.Remarks);
                if (bo.Active == "1")
                {
                    itm.SubItems.Add("Active");
                }
                else
                {
                    itm.SubItems.Add("Inactive");
                }
                lvwGradeDetails.Items.Add(itm);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }

            try
            {
                if (Utility.IsDuplicateFoundInList(lvwGradeDetails, 1, txtGradeID.Text) == true)
                {
                    MessageBox.Show("Cannot Insert Duplicate Value", "AGH Operation");
                    return;
                }

                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    Grade grade = this.PopulateGrade();
                    short i = accmSc.SaveGradeSetup(grade);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtGradeID.Focus();
                        LoadListView();

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
        private void frmOPRGrade_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadListView();
        }
        private void lvwGradeDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwGradeDetails.SelectedItems.Count > 0)
            {
                txtGradeID.ReadOnly = true;
                ListViewItem itm = lvwGradeDetails.SelectedItems[0];
                txtGradeID.Text = itm.SubItems[0].Text;
                txtGradetitle.Text = itm.SubItems[1].Text;
                txtRemarks.Text = itm.SubItems[2].Text;
                if (itm.SubItems[3].Text == "Active")
                {
                    Cboactive.Text = "Active";
                }
                else
                {
                    Cboactive.Text = "Inactive";
                }
                txtGradetitle.Select();

            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    Grade grade = this.PopulateGrade();
                    short i = accmSc.UpdateGradeSetup(grade);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtGradeID.Select();
                        LoadListView();

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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var strResponse = MessageBox.Show("Do U want to Delete?", "Delete Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (strResponse == DialogResult.Yes)
            {

                Grade grade = this.PopulateGrade();
                short i = accmSc.DeleteGrade(grade);
                if (i == 0)
                {
                    MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtGradeID.Select();
                    LoadListView();

                }
            }
        }
        #endregion

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

      
    }
}
