using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AH.ModuleController.UI.DMS.Forms
{
    public partial class frmDiagTestAssociation : AH.Shared.UI.frmSmartFormStandard
    {
        public frmDiagTestAssociation()
        {
            InitializeComponent();
        }

        private void lvDiagMain_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }      
    }
}
