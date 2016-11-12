using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.OPRMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.OPR.Forms
{
    public partial class frmOtMap : AH.Shared.UI.frmSmartFormStandard
    {
        List<string> ottheater = new List<string>();
        private bool blngot1=false ;
        private bool blngot2=false;
        private bool blngot3=false;
        
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        public frmOtMap()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }
        private void btnOT1_Click(object sender, EventArgs e)
        {
            frmOTCalender frm = new frmOTCalender("","");
            frm.intOT = 1;
            frm.ShowDialog();
            DateTime dtedate = Convert.ToDateTime(DateTime.Now);
            //DG.Rows.Clear();
            grid_column1(dtedate.ToString("dd/MM/yyyy"),"1");
        }
        private void btnOT2_Click(object sender, EventArgs e)
        {
            frmOTCalender frm = new frmOTCalender("","");
            frm.intOT = 2;
            frm.ShowDialog();
            DateTime dtedate = Convert.ToDateTime(DateTime.Now);
            grid_column1(dtedate.ToString("dd/MM/yyyy"),"2");

        }
        private void btnOT3_Click(object sender, EventArgs e)
        {
      
            frmOTCalender frm = new frmOTCalender("","");
            frm.intOT =3 ;
            frm.ShowDialog();
            DateTime dtedate = Convert.ToDateTime(DateTime.Now);
            grid_column1(dtedate.ToString("dd/MM/yyyy"),"3");

      
        }
        private DataGridViewTextBoxColumn Create_Grid_Column(string pname, string htext, int cwidth, Boolean true_false, DataGridViewContentAlignment Align,
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
        private void mFillTheaterist()
        {
            List<Theater> theater = accmSc.GetTheater().ToList();
            foreach (Theater bo in theater)
            {
                ottheater.Add(bo.Theatertitle.ToString());
            }
        }
        private void grid_column1(string strDate,string strfromot)
        {
            int j = 49;
            int introw = 0;
            if (strfromot == "")
            {
              
                DG.BackgroundColor = Color.Gold;
                //DG.Columns[0].DefaultCellStyle.BackColor = Color.Gold;
               // DG.Rows[0].DefaultCellStyle.BackColor = Color.Gold;
                var fromTimeString = "";
                TimeSpan result = TimeSpan.FromMinutes(30);
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                for (int i = 0; i < j; i++)
                {
                    fromTimeString = result.ToString().Substring(0, 5);
                    if (i == 0)
                    {
                        DG.Columns.Add(Create_Grid_Column("Theater", "Theater", 60, true, DataGridViewContentAlignment.TopLeft, true));
                        //DG.Rows[i].Height = 80;
                    }
                    else
                    {
                        DG.Columns.Add(Create_Grid_Column(fromTimeString, fromTimeString, 50, true, DataGridViewContentAlignment.TopLeft, true));
                        DG[i, 0].Style.Font = new Font("Courier New", 10f, FontStyle.Regular);
                        if (i == 47)
                        {
                            result = result + TimeSpan.Parse("00:29");
                        }

                        else
                        {
                            result = result + TimeSpan.Parse("00:30");
                        }
                    }
                }
            }
            DG.Rows.Clear();
            List<CalenderOT> Cal = new List<CalenderOT>();
            List<OperationMaster> oprMaster = new List<OperationMaster>();
            //oprMaster = accmSc.GetInchargeIDBarchart().ToList();
            List<Theater> theater = accmSc.GetTheater().ToList();
            int intRow = theater.Count-1;
            int K = 0;
            DG.Rows.Add(intRow);
            foreach (Theater objOT in theater)
            {
                if (objOT.Theaterid.ToString() != "")
                {
                    DG[0, introw].Value = objOT.Theatertitle.ToString();
                    if (introw ==0 )
                    {
                        btnOT1.Text = objOT.Theatertitle.ToString();
                    }
                    else if(introw==1)
                    {
                        btnOT2.Text = objOT.Theatertitle.ToString();
                    }
                    else if (introw == 2)
                    {
                        btnOT3.Text = objOT.Theatertitle.ToString();
                    }

                    Cal = accmSc.GetRowposofBarchat("Getrowmap", objOT.Theaterid.ToString(), strDate.ToString()).ToList();
                    foreach (CalenderOT rowpos in Cal)
                    {
                        int i = rowpos.intRow;
                        DG[i + 1, introw].Value = "A";
                        DG[i + 1, introw].Style.BackColor = Color.DarkSeaGreen; //doesn't work
                        if (introw==0) 
                        {
                            blngot1=true;
                        }
                        if (introw == 1)
                        {
                            blngot2 = true;
                        }
                        if (introw == 2)
                        {
                            blngot3 = true;
                        }
                    }

                    introw = introw + 1;
                }
            }
        }
        private void frmOtMap_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime dtedate = Convert.ToDateTime(DateTime.Now);
                lblchart.Text = "Chart :" + dtedate.ToString("dd/MM/yyyy") + " " + dtedate.ToString("dddd");
                grid_column1(dtedate.ToString("dd/MM/yyyy"), "");
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (blngot1 == true)
                {
                    btnOT1.BackColor = Color.Red;
                    btnOT1.ForeColor = Color.Yellow;
                    timer2.Interval = 1000;
                }
                if (blngot2 == true)
                {
                    btnOT2.BackColor = Color.Red;
                    btnOT2.ForeColor = Color.Yellow;
                    timer2.Interval = 1000;
                }

                if (blngot3 == true)
                {
                    btnOT3.BackColor = Color.Red;
                    btnOT3.ForeColor = Color.Yellow;
                    timer2.Interval = 1000;
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
        private void timer2_Tick(object sender, EventArgs e)
        {
            btnOT1.BackColor = Color.Pink;
            btnOT1.ForeColor = Color.Black;
            btnOT2.BackColor = Color.Pink;
            btnOT2.ForeColor = Color.Black;
            btnOT3.BackColor = Color.Pink;
            btnOT3.ForeColor = Color.Black;
        }

      
    }
}
