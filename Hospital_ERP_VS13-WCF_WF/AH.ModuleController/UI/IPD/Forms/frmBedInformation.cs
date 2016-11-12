
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.DUtility;
using AH.ModuleController.IPDSR;

namespace AH.ModuleController.UI.IPD.Forms
{
    public partial class frmBedInformation : AH.Shared.UI.frmSmartFormStandard
    {
        PatientAdmissionUtility obj = new PatientAdmissionUtility();
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        List<InPatient> oInpats = new List<InPatient>();
        public frmBedInformation()
        {
            InitializeComponent();
        }

        private DataGridViewTextBoxColumn FormatColumns(string pname, string htext, int cwidth, Boolean true_false, string font, int fontsize, DataGridViewContentAlignment Algin)
        {
            DataGridViewTextBoxColumn BedInformation = new DataGridViewTextBoxColumn();
            BedInformation.DataPropertyName = pname;
            BedInformation.HeaderText = htext;
            BedInformation.DefaultCellStyle.ForeColor = Color.Black;
            BedInformation.DefaultCellStyle.BackColor = Color.White;
            BedInformation.Visible = true_false;
            BedInformation.DefaultCellStyle.Alignment = Algin;
            BedInformation.Width = cwidth;
            BedInformation.ReadOnly = true;
            BedInformation.DefaultCellStyle.Font = new Font(font, fontsize, FontStyle.Regular);
            BedInformation.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvBedInformation.GridColor = Color.BlueViolet;

            return BedInformation;
        }

        private void frmBedInformation_Load(object sender, EventArgs e)
        {
            
            obj.cboWard(cboWard);
            obj.cboBedType(cboBedType);

            for (int x = 0; x < 10; x++)
            {
                dgvBedInformation.Columns.Add(FormatColumns("", "", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            }
           
        }

        private void btnBedFind_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboWard", "cboBedType" };
           
            dgvBedInformation.Rows.Clear();
            txtAvailability.Text = "";
            txtWaiting.Text = "";
            txtOccupied.Text = "";
            smartTextBoxColorful1.Text = "";
            int availability = 0, occupied = 0, waiting = 0;

            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                txtWardTitle.Text = cboWard.Text;
               
                oInpats.Clear();
              //  oInpats = ipdSc.GetNumberOfBed(cboWard.SelectedValue.ToString(),cboBedType.SelectedValue.ToString()).ToList();
                int k = 0;
                int p = 0;
                if (oInpats.Count != 0)
                {                 
                    dgvBedInformation.Rows.Add();
                    for (int r = 0; r < dgvBedInformation.Rows.Count && p <oInpats.Count; r++)
                    {
                        dgvBedInformation.Rows[r].Height = dgvBedInformation.Rows[r].Height + 50;
                        int c = 0;
                       
                           for (int lst = k; lst < oInpats.Count; lst++)                            
                            {
                                if (c < 10)
                                {
                                    dgvBedInformation.Rows[0].Cells[0].Selected = false;
                                    dgvBedInformation.Rows[r].Cells[c].Value = oInpats[lst].Bed.BedNo.ToString() + "\r\n" + oInpats[lst].Bed.BedStatus.ToString();
                                    c++;k++;
                                }
                                
                            }
                            p = k;
                            if (p < oInpats.Count)
                            {
                                dgvBedInformation.Rows.Add();
                            }

                   }

                    for (int j = 0; j < dgvBedInformation.Rows.Count ; j++)
                    {
                         for (int i = 0; i < dgvBedInformation.ColumnCount; i++)
                         {
                             if (dgvBedInformation.Rows[j].Cells[i].Value != null)
                             {
                               string var = dgvBedInformation.Rows[j].Cells[i].Value.ToString();
                               string var1 = Utility.GetStringPart(var, "\r\n",true);
                            
                                 if (var1 == "C")
                                 {
                                     dgvBedInformation.Rows[j].Cells[i].Style.BackColor = Color.GreenYellow;
                                     availability++;
                                 }
                                 else if (var1 == "O")
                                 {
                                     dgvBedInformation.Rows[j].Cells[i].Style.BackColor = Color.OrangeRed;
                                     occupied++;
                                 }
                                 else
                                 {
                                     dgvBedInformation.Rows[j].Cells[i].Style.BackColor = Color.Yellow;
                                      waiting++;
                                 }

                             }
                         }

                      }
                    txtAvailability.Text = availability.ToString();
                    txtWaiting.Text = waiting.ToString();
                    txtOccupied.Text = occupied.ToString();
                    smartTextBoxColorful1.Text = oInpats.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dgvBedInformation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvBedInformation.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected)
            //{
            //    dgvBedInformation.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Gray;
            //}
            //else
            //{
            //    dgvBedInformation.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = dgvBedInformation.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor;
            //}
            if (dgvBedInformation.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.OrangeRed && dgvBedInformation.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
               // string bedID = 
                string bedID = Utility.GetStringPart(dgvBedInformation.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "\r");
                frmPatientDetails ofrm = new frmPatientDetails(bedID);
                ofrm.ShowDialog();
            }
            if (dgvBedInformation.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.GreenYellow && dgvBedInformation.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                frmAdmission ofrm = new frmAdmission("D");
                ofrm.ShowDialog();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

    }
}
