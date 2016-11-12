using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AH.ModuleController.UI.ATMS.Forms
{
    public partial class frmAssetsDetailsInformation : AH.Shared.UI.frmSmartFormStandard
    {
        private DateTimePicker oDateTimePicker;
        public frmAssetsDetailsInformation()
        {
            InitializeComponent();
        }
        private void mLoad()
        {
            DG.Rows.Clear();
            DG.Rows.Add(1);
            DG[0, 1].Value = "aa";
            DG[0, 2].Value = "bb";
            DG[0, 3].Value = "v";
            DG[0, 4].Value = "sd";
           // DataGridViewComboBoxColumn cmb= DG.Columns["columns4"] as DataGridViewComboBoxCell(); 
            Column4.DataSource = "ss";
            Column4.DisplayMember = "ss";

        }

        private void frmAssetsDetailsInformation_Load(object sender, EventArgs e)
        {
            mLoad();
        }

        private void DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex==0)
            //{
            //    oDateTimePicker = new DateTimePicker();  
            //    DG.Controls.Add(oDateTimePicker);
            //    oDateTimePicker.Visible = false;
            //    oDateTimePicker.Format = DateTimePickerFormat.Short;  //
            //    oDateTimePicker.TextChanged += new EventHandler(DG_OnTextChange);
            //    oDateTimePicker.Visible = true;
            //    Rectangle oRectangle = DG.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            //    oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);
            //    oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);
            //    oDateTimePicker.CloseUp += new EventHandler(DG_CloseUp);
            //}
        }
        //private void DG_OnTextChange(object sender, EventArgs e)
        //{
        //    DG.CurrentCell.Value = oDateTimePicker.Text.ToString();
        //}

        //void DG_CloseUp(object sender, EventArgs e)
        //{
        //    oDateTimePicker.Visible = false;
        //}
    }
}
