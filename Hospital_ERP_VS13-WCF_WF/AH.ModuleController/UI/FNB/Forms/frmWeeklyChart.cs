using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.ModuleController.FNBSR;
using AH.DUtility;
using System.Collections;




namespace AH.ModuleController.UI.FNB.Forms
{
    public partial class frmWeeklyChart : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used 

        List<string> FoodChart = new List<string>();
        public frmWeeklyChart()
        {
            InitializeComponent();
        }

        private void frmWeeklyChart_Load(object sender, EventArgs e)
        {
            try
            {
                cbomealId.DataSource = new BindingSource(fnbs.LoadWeeklyMealSetup(), null);
                cbomealId.DisplayMember = "value";
                cbomealId.ValueMember = "Key";

                cboSetmenuTypeID.DataSource = fnbs.LaodWeeklySetMenuType().ToList();
                cboSetmenuTypeID.ValueMember = "WeeklySetMenuTypeID";
                cboSetmenuTypeID.DisplayMember = "WeeklySetMenuTypeName";
                Format_Grid();
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
        private void Format_Grid()
        {
            
            DG.Columns.Add(Create_Grid_Column("Day", "Day", 200, true, DataGridViewContentAlignment.TopLeft, true));
            for (int i = 1; i < cbomealId.Items.Count;i++ )
            {
                string strName = cbomealId.Items[i].ToString();
                strName = strName.Substring(strName.LastIndexOf(",") + 1);
                int intlen = strName.Length;
                strName = strName.Substring(0, intlen - 1);
              
                DG.Columns.Add(Create_Grid_Column(strName, strName, 170, true, DataGridViewContentAlignment.TopLeft, true));
                
            }

            DG.Columns.Add(Create_Grid_Column("Remarks", "Remarks", 270, true, DataGridViewContentAlignment.TopLeft,false));
                
            
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


        private void GetWeekchart(string strSetmenuID)
        {
            DG.Rows.Clear();
            bool blngCheckColumn = false;
            string menuname = "";
            int i, j = 0, c, k = 1;
            try
            {
                List<WeeklyChart> wc = fnbs.LaodWeeklyChart(strSetmenuID).ToList();
                i = wc.Count;
                if (i > 0)
                {
                    DG.Rows.Add(i);
                    foreach (WeeklyChart objwc in wc)
                    {
                        if (CheckDuplicate(objwc.Day.ToString()) == false)
                        {
                            DG.Rows[j].Cells[0].Value = objwc.Day;
                            DG.Rows[j].Height = 100;
                            for (c = 1; c < DG.Columns.Count - 1; c++)
                            {
                                if (blngCheckColumn == false)
                                {
                                    string strHName = DG.Columns[c].HeaderText;
                                    if (strHName.Trim() == objwc.MealName.Trim())
                                    {
                                        blngCheckColumn = true;
                                        k = c;
                                    }
                                }
                            }

                            DG.Rows[j].Cells[k].Value = menuname + objwc.menu_name;
                            //DG.Columns[j].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                            DG.Columns[k].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                            DG.AllowUserToAddRows = false;
                            DG.Rows[j].Height = 100;
                        }
                        else
                        {
                            for (c = 1; c < DG.Columns.Count - 1; c++)
                            {
                                if (blngCheckColumn == false)
                                {
                                    string strHName = DG.Columns[c].HeaderText;
                                    if (strHName.Trim() == objwc.MealName.Trim())
                                    {
                                        blngCheckColumn = true;
                                        k = c;
                                    }
                                }
                            }
                            DG.Rows[j].Cells[k].Value = menuname + objwc.menu_name;
                            DG.Columns[k].DefaultCellStyle.WrapMode = DataGridViewTriState.True;


                            DG.Rows[j].Height = 100;
                        }
                        blngCheckColumn = false;
                        DG.AllowUserToAddRows = false;
                        j = j + 1;

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

        private void addField(int intCol,string strName)
        {
            bool blngChek = false;
            for(int i=0;i < DG.Rows.Count;i++)
            {
                if (blngChek == false)
                {
                    if (DG.Rows[i].Cells[intCol].Value == null)
                    {
                        DG.Rows[i].Cells[intCol].Value = strName;
                        blngChek = true;
                    }
                }
            }
        }


        private bool  CheckDuplicate(string strDay)
        {
            
            for(int k=0; k < DG.Rows.Count;k++)
            {
                if (DG.Rows[k].Cells[0].Value != null)
                {
                    string strRow = DG.Rows[k].Cells[0].Value.ToString();
                    if (strRow == strDay)
                    {
                        return true;
                    }
                }
            }
            return false;
        }




        private void cboSetmenuTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboSetmenuTypeID.SelectedValue != "--Select--" && cboSetmenuTypeID.SelectedValue != "")
                {
                    GetWeekchart(cboSetmenuTypeID.SelectedValue.ToString());
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                GetWeekchart(cboSetmenuTypeID.SelectedValue.ToString());
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printCal;
            printDialog.UseEXDialog = true;

            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printCal.DocumentName = "Food Chart ";
                //printPreviewDialog1.Document = printDocument2;
                Printpreview.Document = printCal;
                Printpreview.PrintPreviewControl.Zoom = 1;
                //printCal.Print();
                Printpreview.ShowDialog();
            }
        }

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
                            //e.Graphics.DrawString("Food Chart", new Font(DG.Font, FontStyle.Bold),
                            //     Brushes.Black, e.MarginBounds.Left+230, e.MarginBounds.Top + 30 -
                            //     e.Graphics.MeasureString("Food Chart", new Font(DG.Font,
                            //     FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            e.Graphics.DrawString(Utility.GetCompanyName, new Font(DG.Font, FontStyle.Bold),
                                  Brushes.Black, e.MarginBounds.Left+230, e.MarginBounds.Top + 20 -
                                  e.Graphics.MeasureString(Utility.GetCompanyName, new Font(DG.Font,
                                  FontStyle.Bold), e.MarginBounds.Width).Height - 13);
                            e.Graphics.DrawString("Food Chart", new Font(DG.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left+230, e.MarginBounds.Top + 40 -
                                    e.Graphics.MeasureString("Food Chart", new Font(DG.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //e.Graphics.DrawString("Dhaka-1207, Bangladesh", new Font(DG.Font, FontStyle.Bold),
                            //       Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 60 -
                            //       e.Graphics.MeasureString("Dhaka-1207, Bangladesh", new Font(DG.Font,
                            //       FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //e.Graphics.DrawString("[T]:88-02-7440527,7440907 [F]:88-02-7441006", new Font(DG.Font, FontStyle.Bold),
                            //      Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 80 -
                            //      e.Graphics.MeasureString("[T]:88-02-7440527,7440907 [F]:88-02-7441006", new Font(DG.Font,
                            //      FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                           


                            String strDate = "Print Date: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(DG.Font, FontStyle.Regular),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(DG.Font,
                                    FontStyle.Regular), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Print Date", new Font(new Font(DG.Font,
                                    FontStyle.Regular), FontStyle.Regular), e.MarginBounds.Width).Height - 13);

                            //e.Graphics.DrawString("Schedule Date: " + dteOTSchedulingDate.Text, new Font(DG.Font, FontStyle.Regular),
                            //       Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                            //       e.Graphics.MeasureString(strDate, new Font(DG.Font,
                            //       FontStyle.Regular), e.MarginBounds.Width).Width), e.MarginBounds.Top + 15 -
                            //       e.Graphics.MeasureString("Schedule Date: " + dteOTSchedulingDate.Text, new Font(new Font(DG.Font,
                            //       FontStyle.Regular), FontStyle.Regular), e.MarginBounds.Width).Height - 13);

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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }








    }
}
