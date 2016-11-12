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
    public partial class frmOTCalender : AH.Shared.UI.frmSmartFormStandard
    {
        public int  intOT { set; get; }
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used 

        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        public DateTime dteOtDate { set; get; }
        List<string> ottheater = new List<string>();
        List<string> myCollection = new List<string>();
        List<string> otIncharge = new List<string>();
        public string a;
        #region "Grid"
        public frmOTCalender(string strRegId, string dtDate, string strCollRow = "", int intCol = 0)
        {
            a = strRegId;
            InitializeComponent();
        }
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }
        private void frmOTCalender_Load(object sender, EventArgs e)
        {
            this.Top = 70;
            try
            {
                DateTime dtedate = Convert.ToDateTime(dteOTSchedulingDate.Text.ToString());
                txtotDate.Text = dtedate.ToString("dd/MM/yyyy") + " " + dtedate.ToString("dddd");
                pictureBox1.Image = ScaleImage(pictureBox1.Image, 180, 200);
                grid_column();
                int i = 1;
                //DG.Rows[0].Cells[i].Selected = true; 'Cahnge 05_02_15'
                DG.Rows[0].Cells[intOT].Selected = true; //Cahnge 05_02_15'

                // DataGridViewCellStyle style = new DataGridViewCellStyle();
                for (int k = 0; k < DG.Rows.Count; k++)
                {
                    //DG.Rows[k].Cells[intOT].Style.BackColor = Color.Yellow;
                    if (DG[intOT, k].Style.BackColor != Color.Pink)
                    {
                        DG[intOT, k].Style.BackColor = Color.Yellow;
                    }
                }

                tabControl2.TabPages[i - 1].Controls.Add(pictureBox1);
                tabControl2.TabPages[i - 1].Controls.Add(lvwDetails);
                tabControl2.TabPages[i - 1].Controls.Add(lvwPackage);
                lvwPackage.Items.Clear();
                lvwDetails.Items.Clear();
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
        private void grid_column()
        {
            //int r = DG.RowCount;
            try
            {
                ottheater.Clear();
                DG.Columns.Clear();
                DG.Rows.Clear();
                DG.Columns.Add(Create_Grid_Column("Theater Name>>", "Theater Name>>", 400, true, DataGridViewContentAlignment.MiddleCenter, true));
                mFillTheaterist();
                tabControl2.TabPages.Clear();
                foreach (string strtheater in ottheater)
                {
                    DG.Columns.Add(Create_Grid_Column(strtheater, strtheater, 400, true, DataGridViewContentAlignment.TopCenter, true));
                    string title = strtheater + (tabControl2.TabCount + 1).ToString();
                    //TabPage myTabPage = new TabPage(title);
                    TabPage myTabPage = new TabPage(strtheater);
                    tabControl2.TabPages.Add(myTabPage);
                }


                int j = 48;
                DG.Rows.Add(j);
                var fromTimeString = "";
                TimeSpan result = TimeSpan.FromMinutes(30);
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                for (int i = 0; i < j; i++)
                {
                    fromTimeString = result.ToString().Substring(0, 5);
                    DG[0, i].Style.BackColor = Color.Wheat;
                    DG[0, i].Style.ForeColor = Color.DimGray;
                    DG[0, i].Style.Font = new Font("Courier New", 12.4f, FontStyle.Bold);
                    DG[0, i].Value = fromTimeString;
                    DG.Columns[0].Width = 80;
                    DG.Rows[i].Height = 40;
                    if (i == 46)
                    {
                        result = result + TimeSpan.Parse("00:29");
                    }

                    else
                    {
                        result = result + TimeSpan.Parse("00:30");
                    }
                }

                int k = 0;
                string strSchedulueID = "";
                List<CalenderOT> objcal = new List<CalenderOT>();
                objcal = accmSc.DisplayOTScheduling("Displayschedule", dteOTSchedulingDate.Text.ToString()).ToList();
                foreach (CalenderOT strpos in objcal)
                {
                    if (strSchedulueID != strpos.ScheduleID)
                    {
                        if (strpos.intCol != k)
                        {
                            //DG[strpos.intCol, strpos.intRow].Value = "Occupied for " + strpos.RegNo + " to " + strpos.Fromtime + "-" + strpos.Totime;
                            //DG[strpos.intCol, strpos.intRow].Value = "Occupied - " + strpos.ScheduleID;
                            DG[strpos.intCol, strpos.intRow].Value = "Occupied " + strpos.RegNo + " " + strpos.PatientName + "-" + strpos.ScheduleID;
                            DG[strpos.intCol, strpos.intRow].Style.ForeColor = Color.Blue;
                            strSchedulueID = strpos.ScheduleID;
                            k = strpos.intCol;
                        }
                    }
                    DG[strpos.intCol, strpos.intRow].Style.BackColor = Color.Pink; //doesn't work
                    k = 0;
                }
                objcal.Clear();

                for (int b = 0; b < DG.Rows.Count; b++)
                {
                    if (DG.Rows[b].Cells[intOT].Style.BackColor != Color.Pink)
                    {
                        DG.Rows[b].Cells[intOT].Style.BackColor = Color.Yellow;
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
        public double[] ExtractGridData(DataGridView grid)
        {
            int numCells = grid.SelectedCells.Count;
            int intcells = 1;
            int lngpos;
            string strrowpos = "";
            string strcolpos = "";
            string strTheaterName = "";
            string hh = "";
            double[] cellsData = new double[numCells];

           
                foreach (DataGridViewCell cell in grid.SelectedCells)
                {
                    hh = DG.Rows[cell.RowIndex].Cells[0].Value.ToString();
                    strrowpos = strrowpos + (hh + "|" + cell.RowIndex) + ",";
                    strcolpos = cell.ColumnIndex.ToString();
                    if (intcells == 1)
                    {
                        //DG.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = "Occupied";
                        strTheaterName = DG.Columns[cell.ColumnIndex].HeaderText;
                        txtEndtime.Text = hh;
                        intcells = intcells + 1;
                    }
                    //MessageBox.Show(hh.ToString());
                }


                txtStarttime.Text = hh;
                lngpos = (strrowpos.ToString().Length - 1);
                txtstartRowpos.Text = strrowpos.Substring(0, lngpos);
                txtColpos.Text = strcolpos;
                txtTheaterName.Text = strTheaterName.ToString();
                myCollection.Clear();
                myCollection.Add(txtstartRowpos.Text);
                intcells = 1;
                foreach (DataGridViewCell cell in grid.SelectedCells)
                {
                    if (intcells == 1)
                    {

                        if (a != "")
                        {
                            //DG.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = "Occupied for "
                            //                            + txtStarttime.Text + " to " + txtEndtime.Text;
                            DG.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = "Occupied for ";

                        }
                        intcells = intcells + 1;
                    }

                }
                return cellsData;
            }

    

    
        private void mFillTheaterist()
        {
            try
            {
                List<Theater> theater = accmSc.GetTheater().ToList();
                foreach (Theater bo in theater)
                {
                    ottheater.Add(bo.Theatertitle.ToString());
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
        private void MergeCellsInRow(int row, int col1, int col2)
        {
            Graphics g = DG.CreateGraphics();
            Pen p = new Pen(DG.GridColor);
            Rectangle r1 = DG.GetCellDisplayRectangle(col1, row, true);
            Rectangle r2 = DG.GetCellDisplayRectangle(col2, row, true);
            int recWidth = 0;
            string recValue = string.Empty;
            for (int i = col1; i <= col2; i++)
            {
                recWidth += DG.GetCellDisplayRectangle(i, row, true).Width;
                if (DG[i, row].Value != null)
                    recValue += DG[i, row].Value.ToString() + " ";
            }
            Rectangle newCell = new Rectangle(r1.X, r1.Y, recWidth, r1.Height);
            g.FillRectangle(new SolidBrush(DG.DefaultCellStyle.BackColor), newCell);
            g.DrawRectangle(p, newCell);
            g.DrawString(recValue, DG.DefaultCellStyle.Font, new SolidBrush(DG.DefaultCellStyle.ForeColor), newCell.X + 3, newCell.Y + 3);
        }
        private void MergeCellsInColumn(int col, int row1, int row2)
        {
            Graphics g = DG.CreateGraphics();
            Pen p = new Pen(DG.GridColor);
            Rectangle r1 = DG.GetCellDisplayRectangle(col, row1, true);
            Rectangle r2 = DG.GetCellDisplayRectangle(col, row2, true);

            int recHeight = 0;
            string recValue = string.Empty;
            for (int i = row1; i <= row2; i++)
            {
                recHeight += DG.GetCellDisplayRectangle(col, i, true).Height;
                if (DG[col, i].Value != null)
                    recValue += DG[col, i].Value.ToString() + " ";
            }
            Rectangle newCell = new Rectangle(r1.X, r1.Y, r1.Width, recHeight);
            g.FillRectangle(new SolidBrush(DG.DefaultCellStyle.BackColor), newCell);
            g.DrawRectangle(p, newCell);
            g.DrawString(recValue, DG.DefaultCellStyle.Font, new SolidBrush(DG.DefaultCellStyle.ForeColor), newCell.X + 3, newCell.Y + 3);
        }
        private void MergeCells(int RowId1, int RowId2, int Column, bool isSelected)
        {
            Graphics g = DG.CreateGraphics();
            Pen gridPen = new Pen(DG.GridColor);
            Rectangle CellRectangle1 = DG.GetCellDisplayRectangle(Column, RowId1, true);
            Rectangle CellRectangle2 = DG.GetCellDisplayRectangle(Column, RowId2, true);
            int rectHeight = 0;
            string MergedRows = String.Empty;

            for (int i = RowId1; i <= RowId2; i++)
            {
                rectHeight += DG.GetCellDisplayRectangle(Column, i, false).Height;
            }
            Rectangle newCell = new Rectangle(CellRectangle1.X, CellRectangle1.Y, CellRectangle1.Width, rectHeight);
            g.FillRectangle(new SolidBrush(isSelected ? DG.DefaultCellStyle.SelectionBackColor : DG.DefaultCellStyle.BackColor), newCell);
            g.DrawRectangle(gridPen, newCell);
            g.DrawString(DG.Rows[RowId1].Cells[Column].Value.ToString(), DG.DefaultCellStyle.Font, new SolidBrush(isSelected ? DG.DefaultCellStyle.SelectionForeColor : DG.DefaultCellStyle.ForeColor), newCell.X + newCell.Width / 3, newCell.Y + newCell.Height / 3);
        }
        private void patientAssignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //double chargeCount;
            ExtractGridData(DG);
            foreach (DataGridViewCell cell in DG.SelectedCells)
            {
                DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();
                CellStyle.BackColor = Color.Pink;
                DG.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Style = CellStyle;
            }

            frmOTPatient frm = new frmOTPatient(myCollection);
            frm.starttime = txtStarttime.Text;
            frm.Endtime = txtEndtime.Text;
            frm.strDate = dteOTSchedulingDate.Text.ToString();
            frm.TheaterName = txtTheaterName.Text;
            frm.Colpos = txtColpos.Text;
            frm.intStatus = 0;
            if (lvwDetails.Items.Count > 0)
            {
                frm.strScheduleID = lvwDetails.Items[0].Text.ToString();
            }
            frm.ShowDialog();
            btnrefresh_Click(sender, e);
        }
        private void DG_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (DG.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected == true)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                    using (Pen p = new Pen(Color.Red, 1))
                    {
                        Rectangle rect = e.CellBounds;
                        rect.Width -= 2;
                        rect.Height -= 2;
                        e.Graphics.DrawRectangle(p, rect);
                    }
                    e.Handled = true;
                }
            }
         }
        private void DG_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            foreach (DataGridViewCell cell in this.DG.SelectedCells)
            {
                if (cell.Value != null && (cell.ColumnIndex != 0 && cell.RowIndex != 0))
                {
                    cell.Style = style;
                    style.Font = new Font("Courier New", 10f, FontStyle.Bold);
                    style.ForeColor = Color.Blue;
                    style.BackColor = Color.Pink;
                }
            }
        }
        private void DG_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {

                    tabControl2.SelectedIndex = e.ColumnIndex - 1;
                    if (e.ColumnIndex > 0)
                    {
                        tabControl2.TabPages[e.ColumnIndex - 1].Controls.Add(pictureBox1);
                        tabControl2.TabPages[e.ColumnIndex - 1].Controls.Add(lvwDetails);
                        tabControl2.TabPages[e.ColumnIndex - 1].Controls.Add(lvwPackage);
                    }
                    else
                    {
                        tabControl2.TabPages[e.ColumnIndex].Controls.Add(pictureBox1);
                        tabControl2.TabPages[e.ColumnIndex].Controls.Add(lvwDetails);
                        tabControl2.TabPages[e.ColumnIndex].Controls.Add(lvwPackage);
                    }
                    lvwDetails.Items.Clear();
                    lvwPackage.Items.Clear();
                    //if (DG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    //{
                    //    string name = DG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    //    lvwDetails.Items.Add(name.ToString());
                    //}

                    // pictureBox1.Image = new Bitmap("C:" + @"\pic\CAN6WFNL.jpg");
                    if (DG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        string name = DG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        string strSchedulingID = name.Substring(name.LastIndexOf("-") + 1).Trim();
                        string strRegNo = "";

                        List<CalenderOT> objdoctors = new List<CalenderOT>();
                        //objdoctors = Doctorsdetails(name.ToString());
                        objdoctors = accmSc.DisplayOTPackage("Displaypackage1", strSchedulingID.ToString()).ToList();
                        foreach (CalenderOT Doctotrs in objdoctors)
                        {
                            ListViewItem lvi1 = new ListViewItem();
                            lvi1.Text = Doctotrs.PackageId.ToString();
                            lvi1.SubItems.Add(Doctotrs.PackageName.ToString());
                            lvwPackage.Items.Add(lvi1);
                        }
                        objdoctors = accmSc.DisplayOTSschedulingDoctors("Displayscheduingpatient", strSchedulingID.ToString()).ToList();
                        foreach (CalenderOT Doctotrs in objdoctors)
                        {
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = Doctotrs.ScheduleID;
                            lvi.SubItems.Add(Doctotrs.RegNo.ToString());
                            strRegNo = Doctotrs.RegNo.ToString();
                            lvi.SubItems.Add(Doctotrs.DoctorsCode.ToString());
                            lvi.SubItems.Add(Doctotrs.doctorsName.ToString());
                            //lvi.SubItems[1].UseItemStyleForSubItems = false;
                            //listView1.Items[0].SubItems[1].BackColor = Color.Yellow;
                            lvwDetails.Items.Add(lvi);
                        }
                        if (strRegNo.ToString() != "")
                        {
                            //loadImage(strRegNo.ToString() + ".Jpg");
                        }
                        foreach (ListViewItem item in lvwDetails.Items)
                        {
                            if ((item.Index % 2) == 0)
                                item.BackColor = Color.Yellow;
                            else
                                item.BackColor = Color.LightBlue;
                        }

                    }

                    if (e.Button == MouseButtons.Right)
                    {
                        if (e.ColumnIndex == intOT)
                        {
                            DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                            this.DG.CurrentCell = clickedCell;  // Select the clicked cell, for instance
                            var relativeMousePosition = DG.PointToClient(Cursor.Position);
                            this.menuStrip.Show(DG, relativeMousePosition);
                        }
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
        private void dteOTSchedulingDate_ValueChanged(object sender, EventArgs e)
        {
            //DateTime dtedate = Convert.ToDateTime(dteOtDate.ToString());
            //DateTime dtedate = Convert.ToDateTime(dteOTSchedulingDate.Text.ToString());
            //txtotDate.Text = dtedate.ToString("dd/MM/yyyy") + " " + dtedate.ToString("dddd");
           
            tabControl2.TabPages.Clear();
            DG.Rows.Clear();
            grid_column();
            DateTime dtedate = Convert.ToDateTime(dteOTSchedulingDate.Text.ToString());
            txtotDate.Text = dtedate.ToString("dd/MM/yyyy") + " " + dtedate.ToString("dddd");
            //getData();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            foreach (DataGridViewCell cell in this.DG.SelectedCells)
            {
                if (cell.Value != null && (cell.ColumnIndex != 0 && cell.RowIndex != 0))
                {
                    cell.Style = style;
                    style.Font = new Font("Courier New", 15f, FontStyle.Bold);
                    style.ForeColor = Color.Blue;
                    style.BackColor = Color.Pink;
                }
            }
            tabControl1.SelectedTab = tabPage1;
            //grid_column1(dtedate.ToString());

        }
        private void tabControl2_Click(object sender, EventArgs e)
        {

            for (int j = 0; j < DG.Columns.Count; j++)
            {
                DG.Rows[0].Cells[j].Selected = false;
            }
            int i = tabControl2.SelectedIndex + 1;
            DG.Rows[0].Cells[i].Selected = true;
            tabControl2.TabPages[i - 1].Controls.Add(pictureBox1);
            tabControl2.TabPages[i - 1].Controls.Add(lvwDetails);
            tabControl2.TabPages[i - 1].Controls.Add(lvwPackage);
            //pictureBox1.Image = new Bitmap("C:" + @"\pic\CAN6WFNL.jpg");
            lvwDetails.Items.Clear();
            lvwPackage.Items.Clear();

        }
        private void tabControl2_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage CurrentTab = tabControl2.TabPages[e.Index];
            Rectangle ItemRect = tabControl2.GetTabRect(e.Index);
            SolidBrush FillBrush = new SolidBrush(Color.Red);
            SolidBrush TextBrush = new SolidBrush(Color.White);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            //If we are currently painting the Selected TabItem we'll
            //change the brush colors and inflate the rectangle.
            if (System.Convert.ToBoolean(e.State & DrawItemState.Selected))
            {
                FillBrush.Color = Color.White;
                TextBrush.Color = Color.Red;
                ItemRect.Inflate(2, 2);
            }

            //Set up rotation for left and right aligned tabs
            if (tabControl2.Alignment == TabAlignment.Left || tabControl2.Alignment == TabAlignment.Right)
            {
                float RotateAngle = 90;
                if (tabControl2.Alignment == TabAlignment.Left)
                    RotateAngle = 270;
                PointF cp = new PointF(ItemRect.Left + (ItemRect.Width / 2), ItemRect.Top + (ItemRect.Height / 2));
                e.Graphics.TranslateTransform(cp.X, cp.Y);
                e.Graphics.RotateTransform(RotateAngle);
                ItemRect = new Rectangle(-(ItemRect.Height / 2), -(ItemRect.Width / 2), ItemRect.Height, ItemRect.Width);
            }

            //Next we'll paint the TabItem with our Fill Brush
            e.Graphics.FillRectangle(FillBrush, ItemRect);

            //Now draw the text.
            e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, (RectangleF)ItemRect, sf);

            //Reset any Graphics rotation
            e.Graphics.ResetTransform();

            //Finally, we should Dispose of our brushes.
            FillBrush.Dispose();
            TextBrush.Dispose();

            //*************************
            tabControl2.TabPages[e.Index].BackColor = Color.Beige;
            TabPage tabPages = tabControl2.TabPages[e.Index];
            Graphics graphics = e.Graphics;
            Brush textBrush = new SolidBrush(Color.Green); //fore color brush
            Rectangle tabBounds = tabControl2.GetTabRect(e.Index);
            if (e.State == DrawItemState.Selected)
            {
                graphics.FillRectangle(Brushes.SkyBlue, e.Bounds); //fill background color
            }
            else
            {
                textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }
            Font tabFont = new Font("Book Antiqua", 12, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Near;
            strFormat.LineAlignment = StringAlignment.Near;
            // draw text
            graphics.DrawString(tabPages.Text, tabFont, textBrush, tabBounds, new StringFormat(strFormat));
            graphics.Dispose();
            textBrush.Dispose();
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
           
            tabControl2.TabPages.Clear();
            DG.Rows.Clear();
            grid_column();
            DateTime dtedate = Convert.ToDateTime(dteOTSchedulingDate.Text.ToString());
            txtotDate.Text = dtedate.ToString("dd/MM/yyyy") + " " + dtedate.ToString("dddd");
            //getData();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            foreach (DataGridViewCell cell in this.DG.SelectedCells)
            {
                if (cell.Value != null && (cell.ColumnIndex != 0 && cell.RowIndex != 0))
                {
                    cell.Style = style;
                    style.Font = new Font("Courier New", 15f, FontStyle.Bold);
                    style.ForeColor = Color.Blue;
                    style.BackColor = Color.Pink;
                }
            }
        }
        private void grid_column1(string strDate)
        {
            int j = 49;
            int introw = 0;
            try
            {
                DGbarChart.Rows.Clear();
                var fromTimeString = "";
                TimeSpan result = TimeSpan.FromMinutes(30);
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                for (int i = 0; i < j; i++)
                {
                    fromTimeString = result.ToString().Substring(0, 5);
                    if (i == 0)
                    {
                        DGbarChart.Columns.Add(Create_Grid_Column("Incharge", "Incharge", 200, true, DataGridViewContentAlignment.TopLeft, true));
                        DGbarChart.Rows[i].Height = 80;
                    }
                    else
                    {
                        //TimeSpan result = TimeSpan.FromHours(i - 1);
                        //string fromTimeString = result.ToString("hh':'mm");
                        //DG.Columns.Add(_clsGrid.Create_Grid_Column((i-1).ToString(),(i-1).ToString(), 50, true, DataGridViewContentAlignment.TopLeft, true));
                        DGbarChart.Columns.Add(Create_Grid_Column(fromTimeString, fromTimeString, 50, true, DataGridViewContentAlignment.TopLeft, true));
                        //DGbarChart.Rows[i].Height = 40;
                        DGbarChart[i, 0].Style.Font = new Font("Courier New", 10f, FontStyle.Regular);
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

                List<CalenderOT> Cal = new List<CalenderOT>();
                //Cal = accmSc.GetInchargeIDBar("Getincharge", "").ToList();
                List<OperationMaster> oprMaster = new List<OperationMaster>();
                oprMaster = accmSc.GetInchargeIDBarchart().ToList();
                int intRow = oprMaster.Count;
                int K = 0;
                DGbarChart.Rows.Add(intRow);
                foreach (OperationMaster strIncharName in oprMaster)
                {
                    if (strIncharName.RegName.ToString() != "")
                    {
                        DGbarChart[0, introw].Value = strIncharName.RegName.ToString() + "|" + strIncharName.RegId.ToString();
                        string strName = DGbarChart[0, introw].Value.ToString();
                        string strInchargeIdID = strName.Substring(strName.LastIndexOf("|") + 1).Trim();
                        //DGbarChart[1, introw].Value = strIncharName.RegName.ToString();
                        //Cal = accmSc.GetInchargeIDBar("Getincharge", DGbarChart[0, 0].Value.ToString()).ToList();
                        Cal = accmSc.GetRowposofBarchat("Getrowpos", strInchargeIdID.ToString(), strDate.ToString()).ToList();
                        foreach (CalenderOT rowpos in Cal)
                        {
                            int i = rowpos.intRow;
                            //DGbarChart[i + 1, introw].Value = i;
                            DGbarChart[i + 1, introw].Value = "A";
                            //DG.Rows[strpos].DefaultCellStyle.BackColor = Color.Yellow;
                            DGbarChart[i + 1, introw].Style.BackColor = Color.DarkSeaGreen; //doesn't work
                        }

                        introw = introw + 1;
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
        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex==1 )
            {
                DateTime dtedate = Convert.ToDateTime(dteOTSchedulingDate.Text.ToString());
                grid_column1(dtedate.ToString("dd/MM/yyyy"));
            }
        }
        #endregion
        #region "Print"
        private void btnPrintBar_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;
            printDialog.UseEXDialog = true;

            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDoc.DocumentName = "Bar Chart Print";
                printDoc.Print();
                

            }
        }
        private void printDoc_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in DG.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in DGbarChart.Columns)
                    {
                        //iTmpWidth = 14;
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth)))) + 1;

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= DGbarChart.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = DGbarChart.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Draw Header
                            e.Graphics.DrawString("Customer Summary", new Font(DGbarChart.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 2 -
                                    e.Graphics.MeasureString("Customer Summary", new Font(DGbarChart.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);
                            e.Graphics.DrawString("Address1", new Font(DGbarChart.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 15 -
                                    e.Graphics.MeasureString("Address1", new Font(DGbarChart.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);
                            e.Graphics.DrawString("Address2", new Font(DGbarChart.Font, FontStyle.Bold),
                                   Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 30 -
                                   e.Graphics.MeasureString("Address2", new Font(DGbarChart.Font,
                                   FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            e.Graphics.DrawString("Email", new Font(DGbarChart.Font, FontStyle.Bold),
                                  Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 40 -
                                  e.Graphics.MeasureString("Email", new Font(DGbarChart.Font,
                                  FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(DGbarChart.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(DGbarChart.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Customer Summary", new Font(new Font(DGbarChart.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top + 30;
                            foreach (DataGridViewColumn GridCol in DGbarChart.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                if (Cel.InheritedStyle.BackColor != Color.DarkSeaGreen)
                                {
                                    e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                                new SolidBrush(Cel.InheritedStyle.ForeColor),
                                                new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                                (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);

                                }
                                else
                                {
                                    e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                                new SolidBrush(Cel.InheritedStyle.ForeColor),
                                                new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                                (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                                }
                                //Drawing Cells Borders 

                                //e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                //        iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            }
                            if (Cel.InheritedStyle.BackColor != Color.DarkSeaGreen)
                            {
                                e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                   iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));
                            }
                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void printCal_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in DG.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
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
        private void printCal_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in DG.Columns)
                    {
                        //iTmpWidth = 14;
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth)))) + 1;

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= DG.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = DG.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Draw Header
                            e.Graphics.DrawString("Operation Schedule", new Font(DG.Font, FontStyle.Bold),
                                 Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 2 -
                                 e.Graphics.MeasureString("Operation Schedule", new Font(DG.Font,
                                 FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            e.Graphics.DrawString(Utility.GetCompanyName, new Font(DG.Font, FontStyle.Bold),
                                  Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 20 -
                                  e.Graphics.MeasureString(Utility.GetCompanyName, new Font(DG.Font,
                                  FontStyle.Bold), e.MarginBounds.Width).Height - 13);
                            e.Graphics.DrawString("115/7/A Distillary Road, Gandaria", new Font(DG.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 40 -
                                    e.Graphics.MeasureString("115/7/A Distillary Road, Gandaria", new Font(DGbarChart.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);
                            e.Graphics.DrawString("Dhaka-1207, Bangladesh", new Font(DG.Font, FontStyle.Bold),
                                   Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 60 -
                                   e.Graphics.MeasureString("Dhaka-1207, Bangladesh", new Font(DG.Font,
                                   FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            e.Graphics.DrawString("[T]:88-02-7440527,7440907 [F]:88-02-7441006", new Font(DG.Font, FontStyle.Bold),
                                  Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 80 -
                                  e.Graphics.MeasureString("[T]:88-02-7440527,7440907 [F]:88-02-7441006", new Font(DG.Font,
                                  FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            //e.Graphics.DrawString("Schedule Date: " + dteOTSchedulingDate.Text, new Font(DG.Font, FontStyle.Bold),
                            //    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 80 -
                            //    e.Graphics.MeasureString("Schedule Date: " + dteOTSchedulingDate.Text, new Font(DG.Font,
                            //    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            
                            String strDate =  "Print Date: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(DG.Font, FontStyle.Regular),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(DG.Font,
                                    FontStyle.Regular), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Operation Schedule", new Font(new Font(DG.Font,
                                    FontStyle.Regular), FontStyle.Regular), e.MarginBounds.Width).Height - 13);

                            e.Graphics.DrawString("Schedule Date: " + dteOTSchedulingDate.Text, new Font(DG.Font, FontStyle.Regular),
                                   Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                   e.Graphics.MeasureString(strDate, new Font(DG.Font,
                                   FontStyle.Regular), e.MarginBounds.Width).Width), e.MarginBounds.Top +15-
                                   e.Graphics.MeasureString("Schedule Date: " + dteOTSchedulingDate.Text, new Font(new Font(DG.Font,
                                   FontStyle.Regular), FontStyle.Regular), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top + 75;
                            foreach (DataGridViewColumn GridCol in DG.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                if (Cel.InheritedStyle.BackColor == Color.Pink)
                                {
                                    //MessageBox.Show("");

                                    //e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                    //           new SolidBrush(Cel.InheritedStyle.BackColor),
                                    //           new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                    //           (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                                    e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                               new SolidBrush(Cel.InheritedStyle.ForeColor),
                                               new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                               (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                                }
                                else
                                {
                                    e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                                new SolidBrush(Cel.InheritedStyle.ForeColor),
                                                new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                                (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));
                                }

                            }
                            else
                            {
                                if (Cel.InheritedStyle.BackColor != Color.Pink)
                                {
                                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                       iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));
                                }
                            }
                            //Drawing Cells Borders 
                            //e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                            //        iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));



                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPrintCal_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printCal;
            printDialog.UseEXDialog = true;

            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printCal.DocumentName = "OT Calender Print";
                //printPreviewDialog1.Document = printDocument2;
                Printpreview.Document = printCal;
                Printpreview.PrintPreviewControl.Zoom = 1;
                //printCal.Print();
                Printpreview.ShowDialog();
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;
            printDialog.UseEXDialog = true;

            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDoc.DocumentName = "OT Calender Print";
                //printPreviewDialog1.Document = printDocument2;
                Printpreview.Document = printDoc;
                Printpreview.PrintPreviewControl.Zoom = 1;
                //printCal.Print();
                Printpreview.ShowDialog();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

    }
}
