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
    public partial class frmOTTeamAssign : AH.Shared.UI.frmSmartFormStandard
    {
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        public frmOTTeamAssign()
        {
            InitializeComponent();
        }

        //private void LoadModule()
        //{
        //    lstLeftList.ValueMember = "Key";
        //    lstLeftList.DisplayMember = "Value";
        //    lstLeftList.DataSource = new BindingSource(accmSc.GetDoctorsCategory("getregidFromhrm", "D"), null);
        //}
        private string FixedMasterKey(string strCatName)
        {
            string strCateValue = "";
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
            }
            return strCateValue.ToString();
        }
       
        private void frmOTTeamAssign_Load(object sender, EventArgs e)
        {
            // Getdisplay();
            Format_Grid();
        }

        private  DataGridViewTextBoxColumn Create_Grid_Column(string pname, string htext, int cwidth, Boolean true_false, DataGridViewContentAlignment Align,
                                                            Boolean read_only)
        {
            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.DataPropertyName = pname;
            col0.HeaderText = htext;
            col0.DefaultCellStyle.ForeColor = Color.Black;
            col0.DefaultCellStyle.BackColor = Color.White;
            col0.Visible = true_false;
            col0.DefaultCellStyle.Alignment = Align;
            col0.Width = cwidth;
            col0.ReadOnly = read_only;
            return col0;
        }

        private  DataGridViewCheckBoxColumn CreateChkBxGrd(string pname, string htext, int cwidth, Boolean visibility, DataGridViewContentAlignment Algin, bool IsReadOnly, bool Isfrozen, string columnType)
        {
            DataGridViewCheckBoxColumn Ckbox = new DataGridViewCheckBoxColumn();
            Ckbox.DataPropertyName = pname;
            Ckbox.HeaderText = htext;
            Ckbox.Name = pname;
            Ckbox.DefaultCellStyle.ForeColor = Color.Black;
            Ckbox.DefaultCellStyle.BackColor = Color.White;
            Ckbox.Visible = visibility;
            Ckbox.DefaultCellStyle.Alignment = Algin;
            Ckbox.Width = cwidth - 1;
            Ckbox.ReadOnly = IsReadOnly;
            Ckbox.Frozen = Isfrozen;
            return Ckbox;

        }
        public DataGridViewButtonColumn Create_Grid_Column_button(string pname, string htext, string btext, int cwidth, Boolean true_false,
            DataGridViewContentAlignment Align, Boolean read_only)
        {
            DataGridViewButtonColumn col0 = new DataGridViewButtonColumn();
            col0.DataPropertyName = pname;
            col0.HeaderText = htext;
            col0.Text = btext;
            col0.DefaultCellStyle.ForeColor = Color.Red;
            col0.DefaultCellStyle.BackColor = Color.White;
            col0.Visible = true_false;
            col0.DefaultCellStyle.Alignment = Align;
            col0.Width = cwidth;
            col0.ReadOnly = read_only;
            return col0;
        }
        private void grid_column()
        {
            DG.Columns.Add(Create_Grid_Column("Doctors Code", "Doctors code", 300, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Doctors Name", "Doctors Name", 400, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column_button("Del", "Del", "Del", 40, true, DataGridViewContentAlignment.TopCenter, true));
        }

        private void Format_Grid()
        {
            DGdisplay.Columns.Add(Create_Grid_Column("Doctors Code", "Doctors code", 300, true, DataGridViewContentAlignment.TopLeft, true));
            DGdisplay.Columns.Add(Create_Grid_Column("Doctors Name", "Doctors Name", 400, true, DataGridViewContentAlignment.TopLeft, true));
            DGdisplay.Columns.Add(CreateChkBxGrd("Status1", "", 80, true, DataGridViewContentAlignment.TopCenter, false, false, "checkbox"));
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            //int selRaw;
            //int k=0;
            //DG.AllowUserToAddRows = true;
            //selRaw = Convert.ToInt16(DG.RowCount.ToString());
            //selRaw = selRaw - 1;
            //DG.Rows.Add(1);
            //for (int i =1; i < DGdisplay.Rows.Count; i++)
            //{
            //    DG[0, selRaw].Value = listBox1.Text[k];
            //    DG[1, selRaw].Value = lstRightList.Text[k];
            //    k = k + 1;
            //}
            grid_column();
            for (int i = 0; i < DGdisplay.Rows.Count; i++)
            {
                if (Convert.ToBoolean(DGdisplay.Rows[i].Cells["Status1"].Value) == true)
                {
                    DGdisplay.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                  
                    maddItemNew(DGdisplay.Rows[i].Cells[0].Value.ToString(), DGdisplay.Rows[i].Cells[1].Value.ToString());
                    DGdisplay.Rows[i].DefaultCellStyle.BackColor = Color.Beige;
                }
                else
                {
                    DGdisplay.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }

        }

        private void maddItem(string strDoctoreCode, string strDoctorName)
        {
            int selRaw;
            DGdisplay.AllowUserToAddRows = true;
            selRaw = Convert.ToInt16(DGdisplay.RowCount.ToString());
            selRaw = selRaw - 1;
            DGdisplay.Rows.Add(1);
            for (int i = 1; i < DGdisplay.Rows.Count; i++)
            {
                DGdisplay[0, selRaw].Value = strDoctoreCode.ToString();
                DGdisplay[1, selRaw].Value = strDoctorName.ToString();

            }

        }
        private void maddItemNew(string strDoctoreCode, string strDoctorName)
        {
            int selRaw;
            DG.AllowUserToAddRows = true;
            selRaw = Convert.ToInt16(DG.RowCount.ToString());
            selRaw = selRaw - 1;
            DG.Rows.Add(1);
            for (int i = 1; i < DG.Rows.Count; i++)
            {
                DG[0, selRaw].Value = strDoctoreCode.ToString();
                DG[1, selRaw].Value = strDoctorName.ToString();
             
            }

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            DGdisplay.Rows.Clear();
        }
        private void Getdisplay(string strCatName)
        {
            string strFixedValue;
            strFixedValue = FixedMasterKey(strCatName.ToString());
            //List<DoctorsCategory> objCat = accmSc.DisplayDoctorsCategory("DisplayCattype", strFixedValue).ToList();
            //List<DoctorsCategory> objCat = accmSc.GetDoctorsAssign("DoctorsAssign", strFixedValue.ToString()).ToList();
            //foreach (DoctorsCategory dc in objCat)
            //{
            //    //cboDoctorsCategory.Text = dc.CategoryName.ToString();
            //    //listBox1.Items.Add(dc.doctorscode.ToString());
            //    //lstRightList.Items.Add(dc.doctorsName.ToString());
            //}
        }

        private void cboDoctorsCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDoctorsCategory.SelectedIndex > 0 || cboDoctorsCategory.SelectedIndex == -1)
            {
                Getdisplay(cboDoctorsCategory.Text.ToString());
            }
        }

    }
}
