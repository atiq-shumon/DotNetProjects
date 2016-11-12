using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmAcademicDetails : AH.Shared.UI.frmSmartFormStandard
    {
        public event EventHandler Event;

        public frmAcademicDetails()
        {
            InitializeComponent();
        }

        public int Property
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Property1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
