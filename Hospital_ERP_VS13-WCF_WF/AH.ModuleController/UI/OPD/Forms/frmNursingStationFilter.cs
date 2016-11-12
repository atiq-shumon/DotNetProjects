using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AH.ModuleController.UI.OPD.Forms
{
    public partial class frmNursingStationFilter : AH.Shared.UI.frmSmartFormStandard
    {
        OPDSR.OPDWSClient opdsr = new OPDSR.OPDWSClient();
        private string Purpose = "";
        public frmNursingStationFilter(string Purpose)
        {
            InitializeComponent();
            this.Purpose = Purpose;
        }

        private void frmNursingStationFilter_Load(object sender, EventArgs e)
        {
            GetNursesStationId();
        }
        private void GetNursesStationId()
        {
            cboRoomGroup.ValueMember = "Key";
            cboRoomGroup.DisplayMember = "Value";
            cboRoomGroup.DataSource = new BindingSource(opdsr.GetNurseStationDic("D"), null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if(Purpose =="T")
            //{
            //    frmOPDTicketIssue tktFrm = new frmOPDTicketIssue(cboRoomGroup.SelectedValue.ToString());
            //    tktFrm.ShowDialog();
            //}
            if(Purpose =="Q")
            {
                frmNurseCalling ofrm = new frmNurseCalling(cboRoomGroup.SelectedValue.ToString());
                ofrm.Show();
            }
        }
    }
}
