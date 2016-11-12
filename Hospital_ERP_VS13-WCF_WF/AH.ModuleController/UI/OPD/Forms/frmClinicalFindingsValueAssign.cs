using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.OPDSR;
using AH.DUtility;

namespace AH.ModuleController.UI.OPD.Forms
{
    public partial class frmClinicalFindingsValueAssign : AH.Shared.UI.frmSmartFormStandard
    {
        OPDSR.OPDWSClient opdSc = new OPDSR.OPDWSClient();
        public frmClinicalFindingsValueAssign()
        {
            InitializeComponent();
        }
        List<ClinicalFindings> oCfTrees = new List<ClinicalFindings>();
        List<string> oCategories = new List<string>();
        List<string> oGroups = new List<string>();
      //  List<string> oCfs = new List<string>();
       // List<string> oCfs1 = new List<string>();
      //  List<string> oCfs2 = new List<string>();

        List<ClinicalFindingsValues> cfv;
        private void frmClinicalFindingsValueAssign_Load(object sender, EventArgs e)
        {
            FormateGridView();
            LoadCFValues();
            CFTreeGenerate();
            treeClinicalFindingsTree.Select();
        }

        private void FormateGridView()
        {
            dgvCFValues.ReadOnly = false;

            DataGridView dtv = new DataGridView();
            dtv = dgvCFValues;

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Name = "chk";
            chk.Width = 35;
            chk.Visible = true;
            //chk.ValueType = typeof(bool);
            chk.ReadOnly = false;
            dtv.Columns.Add(chk);

            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.Name = "ID";
            colID.Width = 50;
            colID.Visible = true;
            colID.ReadOnly = true;
            colID.DefaultCellStyle.Font = new Font("Tahoma", 10F);
            dtv.Columns.Add(colID);

            DataGridViewTextBoxColumn colDrugTitle = new DataGridViewTextBoxColumn();
            colDrugTitle.Name = "CF Value Name";
            colDrugTitle.Width = 190;
            colDrugTitle.Visible = true;
            colDrugTitle.ReadOnly = true;
            colDrugTitle.DefaultCellStyle.Font = new Font("Tahoma", 10F);
            dtv.Columns.Add(colDrugTitle);

        }
        private void LoadCFValues()
        {
            int i = 0;
            dgvCFValues.BackgroundColor = Color.Lavender;
            dgvCFValues.Rows.Clear();
            cfv = opdSc.GetClinicalFindingsValues().ToList();
            if (cfv.Count != 0)
            {
                foreach (ClinicalFindingsValues oCFVal in cfv)
                {
                    dgvCFValues.Rows.Add(1);
                    dgvCFValues.Rows[i].Cells[1].Value = oCFVal.FindingsValID;
                    dgvCFValues.Rows[i].Cells[2].Value = oCFVal.FindingsValTitle;
                    i = i + 1;
                }
            }
        }
        private void CFTreeGenerate()
        {
            oCfTrees = opdSc.GetCfTree().ToList();

            oCategories = oCfTrees.GroupBy(s => s.GrpCategoryTitle).Select(s => s.First().GrpCategoryTitle).ToList();
            for (int i = 0; i < oCategories.Count; i++)
            {
                treeClinicalFindingsTree.Nodes.Add(oCategories[i]);
                treeClinicalFindingsTree.Nodes[i].ForeColor = Color.DarkViolet;
                treeClinicalFindingsTree.Nodes[i].Name = oCategories[i];
                treeClinicalFindingsTree.ExpandAll();

                oGroups = oCfTrees.GroupBy(s => s.FindingsGrpTitle).Where(s => s.First().GrpCategoryTitle == oCategories[i]
                                                                        ).Select(s => s.First().FindingsGrpTitle).ToList();

                for (int j = 0; j < oGroups.Count; j++)
                {
                    List<ClinicalFindings> oCfGrp = oCfTrees.Where(s => s.GrpCategoryTitle == oCategories[i] && s.FindingsGrpTitle == oGroups[j]).ToList();

                    treeClinicalFindingsTree.Nodes[i].Nodes.Add(oGroups[j]);
                    treeClinicalFindingsTree.Nodes[i].Nodes[j].ForeColor = Color.Blue;
                    treeClinicalFindingsTree.Nodes[i].Nodes[j].Name = oCfGrp[i].FindingsGrpID;
                    treeClinicalFindingsTree.Nodes[i].ExpandAll();

                    List<ClinicalFindings> oCfs = oCfTrees.Where(s => s.GrpCategoryTitle == oCategories[i] &&
                                                                             s.FindingsGrpTitle == oGroups[j] &&
                                                                             s.FindingsLevel == "0" &&
                                                                             s.FindingsParentID == "0"
                                                                        ).ToList();

                    for (int k = 0; k < oCfs.Count; k++)
                    {
                        treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes.Add(oCfs[k].FindingsTitle);
                        treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].ForeColor = Color.Green;
                        treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].Name = oCfs[k].FindingsID;
                        treeClinicalFindingsTree.Nodes[i].Nodes[j].ExpandAll();

                        List<ClinicalFindings> oCfs1 = oCfTrees.Where(s => s.GrpCategoryTitle == oCategories[i] &&
                                                                           s.FindingsGrpTitle == oGroups[j] &&
                                                                           s.FindingsLevel == "1" &&
                                                                           s.FindingsParentID != "0" &&
                                                                           s.FindingsParentID == oCfs[k].FindingsID
                                                                        ).ToList();
                        for (int l = 0; l < oCfs1.Count; l++)
                        {
                            treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].Nodes.Add(oCfs1[l].FindingsTitle);
                            treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].Nodes[l].ForeColor = Color.Purple;
                            treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].Nodes[l].Name = oCfs1[l].FindingsID;
                            treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].ExpandAll();

                            List<ClinicalFindings> oCfs2 = oCfTrees.Where(s => s.GrpCategoryTitle == oCategories[i] &&
                                                                               s.FindingsGrpTitle == oGroups[j] &&
                                                                               s.FindingsLevel == "2" &&
                                                                               s.FindingsParentID != "0" &&
                                                                               s.FindingsParentID == oCfs1[l].FindingsID
                                                                            ).ToList();
                            for (int m = 0; m < oCfs2.Count; m++)
                            {
                                treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].Nodes[l].Nodes.Add(oCfs2[m].FindingsTitle);
                                treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].Nodes[l].Nodes[m].Name = oCfs2[m].FindingsID;
                                treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].Nodes[l].Nodes[m].ForeColor = Color.Red;
                                // treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].Nodes[l].ExpandAll();
                            }
                        }
                    }
                }
            }
            #region comment
            /*   -------------------------------------------------------------commented------------------------            
            //oCategories = oCfTrees.GroupBy(x => new  { Name = x.GrpCategoryTitle }).Distinct().ToList<String>(); 
            //oCfTrees.GroupBy(x => x.GrpCategoryTitle);

           // treeClinicalFindingsTree.Nodes.Add(oCategories);

            //for (int i = 0; i < oCfTrees.Count; i++)
            //{
            //    treeClinicalFindingsTree.Nodes.Add(oCfTrees[i].GrpCategoryTitle);
            //    //List<ClinicalFindings> CfGrpCats = oCfTrees.Where(x => x.GrpCategoryTitle == oCfTrees[i].GrpCategoryTitle).ToList();
                

            //    for (int j = 0; j < CfGrpCats.Count; j++)
            //    {
            //        treeClinicalFindingsTree.Nodes[i].Nodes.Add(CfGrpCats[j].GrpCategoryTitle);
            //        treeClinicalFindingsTree.Nodes[i].ForeColor = Color.Green;
            //        treeClinicalFindingsTree.Nodes[i].Tag = CfGrpCats[j].GrpCategoryTitle;
            //        treeClinicalFindingsTree.Nodes[i].ExpandAll();

            //        List<ClinicalFindings> CfGrps = oCfTrees.Where(x => x.FindingsGrpTitle == oCfTrees[j].FindingsGrpTitle).ToList();
            //        for (int k = 0; k < CfGrps.Count; k++)
            //        {
            //            treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes.Add(CfGrps[k].FindingsGrpTitle);
            //            treeClinicalFindingsTree.Nodes[i].Nodes[j].ForeColor = Color.Red;
            //            treeClinicalFindingsTree.Nodes[i].Nodes[j].Tag = CfGrps[k].FindingsGrpTitle;
            //            treeClinicalFindingsTree.Nodes[i].Nodes[j].ExpandAll();

            //            List<ClinicalFindings> Cfs = oCfTrees.Where(x => x.FindingsTitle == oCfTrees[k].FindingsTitle).ToList();
            //            for (int l = 0; l < Cfs.Count; l++)
            //            {
            //                treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].Nodes.Add(Cfs[l].FindingsTitle);
            //                treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].ForeColor = Color.Purple;
            //                treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].Tag = Cfs[l].FindingsTitle;
            //                treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].ExpandAll();
            //            }
            //        }
            //    }
            //}
                      
         /*   treeClinicalFindingsTree.Nodes.Clear();
          //  oCfTrees = opdSc.GetCfTree().ToList();
            if (oCfTrees.Count > 0)
            {
                treeClinicalFindingsTree.ExpandAll();
               // treeClinicalFindingsTree.DataSource = oCfTrees;

                for (int i = 0; i < treeClinicalFindingsTree.Nodes.Count; i++)
                {
                    treeClinicalFindingsTree.Nodes[i].Nodes.Add(oCfTrees[i].FindingsGrpTitle);
                    treeClinicalFindingsTree.Nodes[i].ForeColor = Color.DarkRed;
                    treeClinicalFindingsTree.Nodes[i].NodeFont = new Font("Callibri", 8, FontStyle.Bold);
                    treeClinicalFindingsTree.Nodes[i].Tag = oCfTrees[i].FindingsGrpTitle;
                    treeClinicalFindingsTree.Nodes[i].ExpandAll();

                    //for (int j = 0; j < treeClinicalFindingsTree.Nodes[i].Nodes.Count; j++)
                    //{
                    //    treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes.Add(oCfTrees[j].FindingsParentID);
                    //    treeClinicalFindingsTree.Nodes[i].Nodes[j].ForeColor = Color.DarkBlue;
                    //    treeClinicalFindingsTree.Nodes[i].Nodes[j].NodeFont = new Font("Callibri", 8, FontStyle.Bold);
                    //    treeClinicalFindingsTree.Nodes[i].Nodes[j].Tag = oCfTrees[j].FindingsParentID;
                    //    treeClinicalFindingsTree.Nodes[i].Nodes[j].ExpandAll();
          
                    //    for (int k = 0; k < treeClinicalFindingsTree.Nodes[j].Nodes.Count; k++)
                    //    {
                    //        treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].Nodes.Add(oCfTrees[k].FindingsTitle);
                    //        treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].ForeColor = Color.DarkBlue;
                    //        treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].NodeFont = new Font("Callibri", 8, FontStyle.Bold);
                    //        treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].Tag = oCfTrees[k].FindingsTitle;
                    //        treeClinicalFindingsTree.Nodes[i].Nodes[j].Nodes[k].ExpandAll();
                    //    }
                    //}
                }
            }
            */
            #endregion
        }
       
        private void treeClinicalFindingsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtCFTitle.Text = string.Empty;
            txtCFID.Text = string.Empty;

            if (treeClinicalFindingsTree.SelectedNode.Level != 0 && treeClinicalFindingsTree.SelectedNode.Level != 1)
            {
                txtCFTitle.Text = treeClinicalFindingsTree.SelectedNode.Text;
                txtCFID.Text = treeClinicalFindingsTree.SelectedNode.Name.ToString();

                FindingsValues(txtCFID.Text);
            }
        }

        private void FindingsValues(string cfID)
        {
            cboFindingsValues.DisplayMember = "Value";
            cboFindingsValues.ValueMember = "Key";
            cboFindingsValues.DataSource = new BindingSource(opdSc.getCFAssignedValueDict(cfID), null);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtCFTitle" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                ClinicalFindingsValueAssign cfvs = this.PopulateCFValue();
                short i = opdSc.SaveCFAssignedValue(cfvs);
                if (i == 0)
                {
                    MessageBox.Show("Data Insertion failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Data Insertion Successful", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCFValues();
                    txtCFID.Text = string.Empty;
                    txtCFTitle.Text = string.Empty;
                }
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private ClinicalFindingsValueAssign PopulateCFValue()
        {
            ClinicalFindingsValueAssign cfvAs = new ClinicalFindingsValueAssign();
            string AddValues = "";

            if (dgvCFValues.Rows.Count > 0)
            {              
                    for (int i = 0; i < dgvCFValues.Rows.Count; i++)
                    {
                        if (Convert.ToBoolean(dgvCFValues.Rows[i].Cells["chk"].Value) == true) 
                        {
                            AddValues += txtCFID.Text + ":" + dgvCFValues.Rows[i].Cells["ID"].Value.ToString() + ":" + ";";
                        }                        
                    }
            }
            cfvAs.AssignedFindingsValue = AddValues;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            cfvAs.EntryParameter = ep;

            return cfvAs;
        }

        private void btnCFValueAdd_Click(object sender, EventArgs e)
        {
            frmClinicalFindingsValue ofrm = new frmClinicalFindingsValue();
            ofrm.ShowDialog();
        }

        private void btnCFValueAssignRefresh_Click(object sender, EventArgs e)
        {
            LoadCFValues();
        }

        private void btnCFTree_Click(object sender, EventArgs e)
        {
         //   CFTreeGenerate();
        }
      
    }
}
