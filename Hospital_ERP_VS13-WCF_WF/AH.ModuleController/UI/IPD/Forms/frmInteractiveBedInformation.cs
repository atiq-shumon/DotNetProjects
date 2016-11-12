using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.IPDSR;
using AH.ModuleController.UI.NWMS.Forms;
using AH.ModuleController.UI.NWMS;

namespace AH.ModuleController.UI.IPD.Forms
{
    public partial class frmInteractiveBedInformation : AH.Shared.UI.frmSmartFormStandard
    {
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        int C = 0; int N, B, D = 0; int O = 0;
        List<Bed> oBeds = new List<Bed>();
        string mode;
        string deptID;
        string unitID;
        string DocID;
        string deptGroupID;
        public frmInteractiveBedInformation(string deptGroupID, string deptID, string unitID, string DocID, string mode)
        {
            InitializeComponent();
            this.mode = mode;
            this.deptID = deptID;
            this.unitID = unitID;
            this.DocID = DocID;
            this.deptGroupID = deptGroupID;
        }

        private void frmInteractiveBedInformation_Load(object sender, EventArgs e)
        {

            GenerateBedsLeve4ICU();
            GenerateBedsLeve4PostOP();
            GenerateBedsLeve4Dialysis();

        }


        private void GenerateBedsLeve4ICU()
        {
            try
            {
                oBeds = ipdSc.GetLevelWiseBeds("09", "4").ToList();
                List<string> btns = new List<string> { "B_0107","B_0108", "B_0109", "B_0110", "B_0111", "B_0112","B_0113","B_0114"};
                BedColors(btns);
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTotal4NSICU.Text = oBeds.Count.ToString();
            txtVacant4NSICU.Text = C.ToString();
            txtOccupied4NSICU.Text = O.ToString();
            txtWaiting4NSICU.Text = N.ToString();
            txtDamage4NSICU.Text = D.ToString();
            txtBlock4NSICU.Text = B.ToString();
        }
        private void GenerateBedsLeve4PostOP()
        {
            try
            {
                oBeds = ipdSc.GetLevelWiseBeds("11", "4").ToList();
                List<string> btns = new List<string> { "B_0115", "B_0116", "B_0117", "B_0118", "B_0119", "B_0120", "B_0121" };
                BedColors(btns);
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTotal4NSPO.Text = oBeds.Count.ToString();
            txtVacant4NSPO.Text = C.ToString();
            txtOccupied4NSPO.Text = O.ToString();
            txtWaiting4NSPO.Text = N.ToString();
            txtDamage4NSPO.Text = D.ToString();
            txtBlock4NSPO.Text = B.ToString();
        }
        private void GenerateBedsLeve4Dialysis()
        {
            try
            {
                oBeds = ipdSc.GetLevelWiseBeds("10", "4").ToList();
                List<string> btns = new List<string> { "B_0122", "B_0123", "B_0124", "B_0125", "B_0126", "B_0127", "B_0128"};
                BedColors(btns);
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTotal4NSDia.Text = oBeds.Count.ToString();
            txtVacant4NSDia.Text = C.ToString();
            txtOccupied4NSDia.Text = O.ToString();
            txtWaiting4NSDia.Text = N.ToString();
            txtDamage4NSDia.Text = D.ToString();
            txtBlock4NSDia.Text = B.ToString();
        }
        private void BedColors(List<string> btns)
        {
            try
            {
                C = 0; N = 0; O = 0; ; B = 0; D = 0;
                Button tempButton = new Button();
                foreach (string btn in btns)
                {
                    string curBtn = Utility.GetStringPart(btn, "_", true);
                    foreach (Bed bed in oBeds)
                    {
                        if (curBtn == bed.BedID)
                        {
                            tempButton = (Button)this.Controls.Find(btn, true)[0];
                            tempButton.Text = bed.BedTitle.ToString();

                            if (bed.BedStatus == "C")
                            {
                                tempButton.BackColor = Color.YellowGreen;
                                C++;
                            }
                            if (bed.BedStatus == "O")
                            {
                                tempButton.BackColor = Color.OrangeRed;
                                O++;
                            }
                            if (bed.BedStatus == "N")
                            {
                                tempButton.BackColor = Color.Yellow;
                                N++;
                            }
                            if (bed.BedStatus == "B")
                            {
                                tempButton.BackColor = Color.DarkGray;
                                B++;
                            }
                            if (bed.BedStatus == "D")
                            {
                                tempButton.BackColor = Color.DimGray;
                                D++;
                            }
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

        private void GenerateBedsLevel6NSA()
        {
            try
            {
                oBeds = ipdSc.GetLevelWiseBeds("03", "6").ToList();
                List<string> btns = new List<string> { "B_0001","B_0002", "B_0003", "B_0004", "B_0005", "B_0006","B_0007",
                                                       "B_0008","B_0009","B_0010","B_0013","B_0014","B_0015","B_0016","B_0017","B_0018","B_0020"};
                BedColors(btns);
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTotal.Text = oBeds.Count.ToString();
            txtAvailability.Text = C.ToString();
            txtOccupied.Text = O.ToString();
            txtWaiting.Text = N.ToString();
            txtDamage.Text = D.ToString();
            txtBlock.Text = B.ToString();
        }
        private void GenerateBedsLevel6NSB()
        {
            try
            {
                oBeds = ipdSc.GetLevelWiseBeds("04", "6").ToList();
                List<string> btns = new List<string> { "B_0011","B_0012", "B_0019", "B_0021", "B_0022", "B_0023","B_0024","B_0025","B_0026",
                                                       "B_0027","B_0028","B_0029","B_0030","B_0031","B_0032","B_0033","B_0034","B_0035","B_0036","B_0037","B_0038","B_0039"};
                BedColors(btns);
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtVacantNSB.Text = C.ToString();
            txtOccupiedNSB.Text = O.ToString();
            txtWaitingNSB.Text = N.ToString();
            txtDamgeNSB.Text = D.ToString();
            txtBlockNSB.Text = B.ToString();
            txtTotalNSB.Text = oBeds.Count.ToString();
        }
        private void GenerateBedsLevel7NSA()
        {
            try
            {
                oBeds = ipdSc.GetLevelWiseBeds("05", "7").ToList();
                List<string> btns = new List<string> { "B_0042","B_0043", "B_0044", "B_0045", "B_0046", "B_0047","B_0048","B_0049","B_0050",
                                                       "B_0051","B_0052","B_0053","B_0054","B_0055","B_0056","B_0057","B_0058"};
                BedColors(btns);
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTotal7NSA.Text = oBeds.Count.ToString();
            txtVacant7NSA.Text = C.ToString();
            txtOccupied7NSA.Text = O.ToString();
            txtWaiting7NSA.Text = N.ToString();
            txtDamage7NSA.Text = D.ToString();
            txtBlock7NSA.Text = B.ToString();
        }
        private void GenerateBedsLevel7NSB()
        {
            try
            {
                oBeds = ipdSc.GetLevelWiseBeds("06", "7").ToList();
                List<string> btns = new List<string> { "B_0059","B_0060", "B_0061", "B_0062", "B_0063", "B_0064","B_0065","B_0066","B_0067",
                                                       "B_0068","B_0069","B_0070","B_0071","B_0072","B_0073","B_0074","B_0075","B_0076","B_0077","B_0078","B_0079","B_0080"};
                BedColors(btns);
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTotal7NSB.Text = oBeds.Count.ToString();
            txtVacant7NSB.Text = C.ToString();
            txtOccupied7NSB.Text = O.ToString();
            txtWaiting7NSB.Text = N.ToString();
            txtDamage7NSB.Text = D.ToString();
            txtBlock7NSB.Text = B.ToString();
        }
        private void GenerateBedsLevel8NSA()
        {
            try
            {
                oBeds = ipdSc.GetLevelWiseBeds("07", "8").ToList();
                List<string> btns = new List<string> { "B_0081","B_0082", "B_0083", "B_0084", "B_0085", "B_0086","B_0087","B_0088","B_0089",
                                                       "B_0090","B_0091","B_0092","B_0093","B_0094","B_0095","B_0105","B_0106"};
                BedColors(btns);
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTotal8NSA.Text = oBeds.Count.ToString();
            txtVacant8NSA.Text = C.ToString();
            txtOccupied8NSA.Text = O.ToString();
            txtWaiting8NSA.Text = N.ToString();
            txtDamage8NSA.Text = D.ToString();
            txtBlock8NSA.Text = B.ToString();
        }
        private void GenerateBedsLevel8NSB()
        {
            try
            {
                oBeds = ipdSc.GetLevelWiseBeds("08", "8").ToList();
                List<string> btns = new List<string> { "B_0096", "B_0097", "B_0098", "B_0099", "B_0100", "B_0101", "B_0102", "B_0103", "B_0104" };
                BedColors(btns);
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTotal8NSB.Text = oBeds.Count.ToString();
            txtVacant8NSB.Text = C.ToString();
            txtOccupied8NSB.Text = O.ToString();
            txtWaiting8NSB.Text = N.ToString();
            txtDamage8NSB.Text = D.ToString();
            txtBlock8NSB.Text = B.ToString();
        }
        private void GenerateBedsLevel9NSA()
        {
            try
            {
                oBeds = ipdSc.GetLevelWiseBeds("13", "9").ToList();
                List<string> btns = new List<string> { "B_0129","B_0131", "B_0132", "B_0133", "B_0134","B_0135","B_0137","B_0136",
                                                       "B_0138","B_0139","B_0140","B_0141","B_0142"};
                BedColors(btns);
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTotal9NSA.Text = oBeds.Count.ToString();
            txtVacant9NSA.Text = C.ToString();
            txtOccupied9NSA.Text = O.ToString();
            txtWaiting9NSA.Text = N.ToString();
            txtDamage9NSA.Text = D.ToString();
            txtBlock9NSA.Text = B.ToString();
        }
        private void GenerateBedsLevel9NSB()
        {
            try
            {
                oBeds = ipdSc.GetLevelWiseBeds("14", "9").ToList();
                List<string> btns = new List<string> { "B_0143","B_0144", "B_0145", "B_0146", "B_0147", "B_0148","B_0149","B_0150","B_0151",
                                                       "B_0152","B_0153","B_0154","B_0155","B_0156","B_0157","B_0158","B_0159"};
                BedColors(btns);
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTotal9NSB.Text = oBeds.Count.ToString();
            txtVacant9NSB.Text = C.ToString();
            txtOccupied9NSB.Text = O.ToString();
            txtWaiting9NSB.Text = N.ToString();
            txtDamage9NSB.Text = D.ToString();
            txtBlock9NSB.Text = B.ToString();
        }
      
        private void GenerateBedsLevel10NSA()
        {
            try
            {
                oBeds = ipdSc.GetLevelWiseBeds("16", "10").ToList();
                List<string> btns = new List<string> { "B_0167","B_0168", "B_0169", "B_0170", "B_0171", "B_0172","B_0173","B_0174","B_0175",
                                                       "B_0176","B_0177","B_0178","B_0179","B_0180","B_0181","B_0182"};
                BedColors(btns);
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTotal10NSA.Text = oBeds.Count.ToString();
            txtVacant10NSA.Text = C.ToString();
            txtOccupied10NSA.Text = O.ToString();
            txtWaiting10NSA.Text = N.ToString();
            txtDamage10NSA.Text = D.ToString();
            txtBlock10NSA.Text = B.ToString();
        }
        private void GenerateBedsLevel10NSB()
        {
            try
            {
                oBeds = ipdSc.GetLevelWiseBeds("17", "10").ToList();
                List<string> btns = new List<string> { "B_0183","B_0184", "B_0185", "B_0186", "B_0187", "B_0188","B_0189","B_0190","B_0191"};
                BedColors(btns);
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTotal10NSB.Text = oBeds.Count.ToString();
            txtVacant10NSB.Text = C.ToString();
            txtOccupied10NSB.Text = O.ToString();
            txtWaiting10NSB.Text = N.ToString();
            txtDamage10NSB.Text = D.ToString();
            txtBlock10NSB.Text = B.ToString();
        }
        private void GenerateBedsLevel9NSCCU()
        {
            try
            {
                oBeds = ipdSc.GetLevelWiseBeds("15", "9").ToList();
                List<string> btns = new List<string> { "B_0160", "B_0161", "B_0162", "B_0163", "B_0164", "B_0164", "B_0165", "B_0166" };
                BedColors(btns);
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTotal9NSCCU.Text = oBeds.Count.ToString();
            txtVacant9NSCCU.Text = C.ToString();
            txtOccupied9NSCCU.Text = O.ToString();
            txtWaiting9NSCCU.Text = N.ToString();
            txtDamage9NSCCU.Text = D.ToString();
            txtBlock9NSCCU.Text = B.ToString();
        }
        private void GenerateBedsLevel10NSPICUNICU()
        {
            try
            {
                oBeds = ipdSc.GetLevelWiseBeds("18", "10").ToList();
                List<string> btns = new List<string> { "B_0192","B_0193", "B_0194", "B_0195", "B_0196", "B_0197","B_0198","B_0199","B_0200",
                                                       "B_0201","B_0202","B_0203","B_0204","B_0205","B_0206","B_0207","B_0208","B_0209","B_0210","B_0211"
                                                       ,"B_0212","B_0213","B_0214","B_0215","B_0216","B_0217"};
                BedColors(btns);
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //txtTotal10NSC.Text = oBeds.Count.ToString();
            //txtVacant10NSC.Text = C.ToString();
            //txtOccupied10NSC.Text = O.ToString();
            //txtWaiting10NSC.Text = N.ToString();
            //txtDamage10NSC.Text = D.ToString();
            //txtBlock10NSC.Text = B.ToString();
        }
        private void ButtonAcivities(Button btn, string bedID)
        {
            try
            {
                if (this.mode == "I")
                {
                    if (btn.BackColor == Color.OrangeRed)
                    {
                        frmAdmittedPatientDetails ofrm = new frmAdmittedPatientDetails(bedID);
                        ofrm.ShowDialog();
                        btnRefresh.PerformClick();
                    }
                    else if (btn.BackColor == Color.YellowGreen)
                    {
                        frmAdmission ofrm = new frmAdmission(bedID);
                        ofrm.ShowDialog();
                        btnRefresh.PerformClick();

                    }
                    else if (btn.BackColor == Color.DarkGray)
                    {
                        MessageBox.Show("This Bed is need to repair !", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnRefresh.PerformClick();

                    }
                    else if (btn.BackColor == Color.DimGray)
                    {
                        MessageBox.Show("This is Bed Block!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnRefresh.PerformClick();

                    }
                    else
                    {
                        MessageBox.Show("Please wait for a while..This Bed is need to clean !!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnRefresh.PerformClick();
                    }
                }
                if (this.mode == "N")
                {
                    if (btn.BackColor == Color.OrangeRed)
                    {
                        frmNurseRequisition ofrm = new frmNurseRequisition(bedID);
                        ofrm.ShowDialog();
                    }
                    else if (btn.BackColor == Color.Yellow)
                    {
                        frmBedStatusChange ofrm = new frmBedStatusChange();
                        ofrm.txtBedID.Text = bedID;
                        ofrm.txtBedTitle.Text = btn.Text;
                        ofrm.ShowDialog();
                        btnRefresh.PerformClick();
                    }
                    else if (btn.BackColor == Color.YellowGreen)
                    {
                        frmBedStatusChange ofrm = new frmBedStatusChange();
                        ofrm.txtBedID.Text = bedID;
                        ofrm.txtBedTitle.Text = btn.Text;
                        ofrm.ShowDialog();
                        btnRefresh.PerformClick();
                    }
                    else if (btn.BackColor == Color.DimGray)
                    {
                        frmBedStatusChange ofrm = new frmBedStatusChange();
                        ofrm.txtBedID.Text = bedID;
                        ofrm.txtBedTitle.Text = btn.Text;
                        ofrm.ShowDialog();
                        btnRefresh.PerformClick();

                    }
                    else if (btn.BackColor == Color.DarkGray)
                    {
                        frmBedStatusChange ofrm = new frmBedStatusChange();
                        ofrm.txtBedID.Text = bedID;
                        ofrm.txtBedTitle.Text = btn.Text;
                        ofrm.ShowDialog();
                        btnRefresh.PerformClick();

                    }
                    else
                    {
                        MessageBox.Show("Please wait for a while..This Bed need to clean !!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (this.mode == "D")
                {
                    if (btn.BackColor == Color.OrangeRed)
                    {
                        frmDischargeAdvice frmIPDPrs = new frmDischargeAdvice(deptGroupID, deptID, unitID, DocID, bedID, mode);
                        frmIPDPrs.ShowDialog();
                    }
                    else
                    {
                        return;
                    }
                }

                if (this.mode == "E")
                {
                    if (btn.BackColor == Color.OrangeRed)
                    {
                        frmDischargeAdvice frmIPDPrs = new frmDischargeAdvice(deptGroupID, deptID, unitID, DocID, bedID, mode);
                        frmIPDPrs.ShowDialog();
                    }
                    else
                    {
                        return;
                    }
                }

                if (this.mode == "V" || this.mode == "VE")
                {
                    if (btn.BackColor == Color.OrangeRed)
                    {
                        frmIPDPrescription frmIPDPrs = new frmIPDPrescription("", mode);
                        //frmIPDPrescription frmIPDPrs = new frmIPDPrescription(deptGroupID, deptID, unitID, DocID, bedID, mode);
                        frmIPDPrs.ShowDialog();
                    }
                    else
                    {
                        return;
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

        #region Level 6 Nurse Station A
        private void B_0001_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0001, "0001");
        }
        private void B_0002_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0002, "0002");
        }
        private void B_0003_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0003, "0003");
        }
        private void B_0004_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0004, "0004");
        }
        private void B_0005_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0005, "0005");
        }
        private void B_0006_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0006, "0006");
        }
        private void B_0007_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0007, "0007");
        }
        private void B_0008_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0008, "0008");
        }
        private void B_0009_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0009, "0009");
        }
        private void B_0010_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0010, "0010");
        }
        private void B_0013_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0013, "0013");
        }
        private void B_0014_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0014, "0014");
        }
        private void B_0015_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0015, "0015");
        }
        private void B_0016_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0016, "0016");
        }
        private void B_0017_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0017, "0017");
        }
        private void B_0018_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0018, "0018");
        }

        private void B_0020_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0020, "0020");
        }

        #endregion

        private void B_0002_MouseMove(object sender, MouseEventArgs e)
        {
            if (B_0005.BackColor == Color.OrangeRed)
            {
                patientDeatils(B_0005, "0002");
            }

        }
        private void patientDeatils(Button btn, string bedID)
        {
            try
            {
                InPatient pat = ipdSc.GetPatientInfoByBedID(bedID);
                // lblPatientInfo.Text = pat.RegistrationNo + "\r\n" + pat.Name + "\r\n" + pat.Room.RoomTitle;
                System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                // ToolTip1.SetToolTip(btn, this.lblPatientInfo.Text);
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

        private void B_0001_MouseHover(object sender, EventArgs e)
        {
            if (B_0017.BackColor == Color.OrangeRed)
            {
                patientDeatils(B_0017, "0001");
            }
        }
        private void B_0018_MouseHover(object sender, EventArgs e)
        {
            if (B_0018.BackColor == Color.OrangeRed)
            {
                patientDeatils(B_0018, "0018");
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.frmInteractiveBedInformation_Load("", e);
               // GenerateBedsLevel6NSB();
                this.tblevel_SelectedIndexChanged("", e);
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

        private void tblevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tblevel.SelectedTab == tb6NS1)
            {
                GenerateBedsLevel6NSA();
            }
            if (tblevel.SelectedTab == tb6NS2)
            {
                GenerateBedsLevel6NSB();
            }

            if (tblevel.SelectedTab == tb7NS1)
            {
                GenerateBedsLevel7NSA();
            }
            if (tblevel.SelectedTab == tb7NS2)
            {
                GenerateBedsLevel7NSB();
            }

            if (tblevel.SelectedTab == tb8NS1)
            {
                GenerateBedsLevel8NSA();
            }
            if (tblevel.SelectedTab == tb8NS2)
            {
                GenerateBedsLevel8NSB();
            }
            if (tblevel.SelectedTab == tb9NS1)
            {
                GenerateBedsLevel9NSA();
            }
            if (tblevel.SelectedTab == tb9NS2)
            {
                GenerateBedsLevel9NSB();
            }
            if (tblevel.SelectedTab == tb9NS3)
            {
                GenerateBedsLevel9NSCCU();
            }
            if (tblevel.SelectedTab == tb10NS1)
            {
                GenerateBedsLevel10NSA();
            }
            if (tblevel.SelectedTab == tb10NS2)
            {
                GenerateBedsLevel10NSB();
            }
            if (tblevel.SelectedTab == tb10NS3)
            {
                GenerateBedsLevel10NSPICUNICU();
            }

        }
        #region Level 6 Nurse Station B
        private void B_0019_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0019, "0019");
        }

        private void B_0026_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0026, "0026");
        }

        private void B_0025_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0025, "0025");
        }

        private void B_0024_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0024, "0024");
        }

        private void B_0023_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0023, "0023");
        }

        private void B_0022_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0022, "0022");
        }

        private void B_0012_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0012, "0012");
        }

        private void B_0011_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0011, "0011");
        }
        private void B_0021_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0021, "0021");
        }
        private void B_0027_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0027, "0027");
        }

        private void B_0028_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0028, "0028");
        }

        private void B_0029_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0029, "0029");
        }

        private void B_0030_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0030, "0030");
        }

        private void B_0036_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0036, "0036");
        }

        private void B_0037_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0037, "0037");
        }

        private void B_0038_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0038, "0038");
        }

        private void B_0039_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0039, "0039");
        }

        private void B_0031_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0031, "0031");
        }

        private void B_0032_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0032, "0032");
        }

        private void B_0033_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0033, "0033");
        }

        private void B_0034_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0034, "0034");
        }

        private void B_0035_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0035, "0035");
        }
        # endregion

        #region Level 7 Nurse Station a
        private void B_0042_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0042, "0042");
        }

        private void B_0043_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0043, "0043");
        }

        private void B_0044_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0044, "0044");
        }

        private void B_0045_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0045, "0045");
        }

        private void B_0046_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0046, "0046");
        }

        private void B_0047_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0047, "0047");
        }

        private void B_0048_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0048, "0048");
        }

        private void B_0049_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0049, "0049");
        }

        private void B_0050_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0050, "0050");
        }

        private void B_0051_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0051, "0051");
        }

        private void B_0052_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0052, "0052");
        }

        private void B_0053_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0053, "0053");
        }

        private void B_0058_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0058, "0058");
        }

        private void B_0054_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0054, "0054");
        }

        private void B_0055_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0055, "0055");
        }

        private void B_0056_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0056, "0056");
        }

        private void B_0057_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0057, "0057");
        }

        # endregion
        #region Level 7 Nurse Station B
        private void B_0059_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0059, "0059");
        }

        private void B_0060_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0060, "0060");
        }

        private void B_0061_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0061, "0061");
        }

        private void B_0062_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0062, "0062");
        }

        private void B_0063_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0063, "0063");
        }

        private void B_0064_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0064, "0064");
        }

        private void B_0065_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0065, "0065");
        }

        private void B_0066_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0066, "0066");
        }

        private void B_0069_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0069, "0069");
        }

        private void B_0068_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0068, "0068");
        }

        private void B_0067_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0067, "0067");
        }

        private void B_0070_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0070, "0070");
        }

        private void B_0071_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0071, "0071");
        }

        private void B_0072_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0072, "0072");
        }

        private void B_0073_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0073, "0073");
        }

        private void B_0075_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0075, "0075");
        }

        private void B_0074_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0074, "0074");
        }

        private void B_0077_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0077, "0077");
        }

        private void B_0078_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0078, "0078");
        }

        private void B_0076_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0076, "0076");
        }

        private void B_0080_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0080, "0080");
        }

        private void B_0079_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0079, "0079");
        }
        # endregion

        #region Level 8 Nurse Station A
        private void B_0081_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0081, "0081");
        }

        private void B_0082_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0082, "0082");
        }

        private void B_0083_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0083, "0083");
        }

        private void B_0084_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0084, "0084");
        }

        private void B_0085_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0085, "0085");
        }

        private void B_0086_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0086, "0086");
        }

        private void B_0105_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0105, "0105");
        }

        private void B_0106_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0106, "0106");
        }

        private void B_0087_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0087, "0087");
        }

        private void B_0088_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0088, "0088");
        }

        private void B_0089_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0089, "0089");
        }

        private void B_0090_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0090, "0090");
        }

        private void B_0091_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0091, "0091");
        }

        private void B_0092_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0092, "0092");
        }

        private void B_0093_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0093, "0093");
        }

        private void B_0094_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0094, "0094");
        }

        private void B_0095_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0095, "0095");
        }

        #endregion

        #region Level 8 Nurse Station B
        private void B_0096_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0096, "0096");
        }

        private void B_0097_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0097, "0097");
        }

        private void B_0100_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0100, "0100");
        }

        private void B_0099_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0099, "0099");
        }

        private void B_0098_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0098, "0098");
        }

        private void B_0101_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0101, "0101");
        }

        private void B_0102_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0102, "0102");
        }

        private void B_0104_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0104, "0104");
        }

        private void B_0103_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0103, "0103");
        }
        #endregion

        private void B_0107_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0107, "0107");
        }

        private void B_0108_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0108, "0108");
        }

        private void B_0109_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0109, "0109");
        }

        private void B_0110_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0110, "0110");
        }

        private void B_0111_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0111, "0111");
        }

        private void B_0112_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0112, "0112");
        }

        private void B_0113_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0113, "0113");
        }

        private void B_0114_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0114, "0114");
        }

        private void B_0115_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0115, "0115");
        }

        private void B_0116_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0116, "0116");
        }

        private void B_0117_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0117, "0117");
        }

        private void B_0118_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0118, "0118");
        }

        private void B_0119_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0119, "0119");
        }

        private void B_0120_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0120, "0120");
        }

        private void B_0121_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0121, "0121");
        }

        private void B_0122_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0122, "0122");
        }

        private void B_0123_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0123, "0123");
        }

        private void B_0124_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0124, "0124");
        }

        private void B_0125_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0125, "0125");
        }

        private void B_0126_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0126, "0126");
        }

        private void B_0127_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0127, "0127");
        }

        private void B_0128_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0128, "0128");
        }

        private void tb9NS2_Click(object sender, EventArgs e)
        {
            //patientDeatils(B_0005, "0002");
        }

        private void B_0129_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0129, "0129");
        }

        private void B_0131_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0131, "0131");
        }

        private void B_0132_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0132, "0132");
        }

        private void B_0133_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0133, "0133");
        }

        private void B_0137_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0137, "0137");
        }

        private void B_0134_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0134, "0134");
        }

        private void B_0135_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0135, "0135");
        }

        private void B_0136_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0136, "0136");
        }

        private void B_0138_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0138, "0138");
        }

        private void B_0139_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0139, "0139");
        }

        private void B_0140_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0140, "0140");
        }

        private void B_0141_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0141, "0141");
        }

        private void B_0142_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0142, "0142");
        }

        private void B_0143_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0143, "0143");
        }

        private void B_0144_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0144, "0144");
        }

        private void B_0147_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0147, "0147");
        }

        private void B_0145_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0145, "0145");
        }

        private void B_0146_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0146, "0146");
        }

        private void B_0148_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0148, "0148");
        }

        private void B_0149_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0149, "0149");
        }

        private void B_0151_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0151, "0151");
        }

        private void B_0150_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0150, "0150");
        }

        private void B_0154_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0154, "0154");
        }

        private void B_0152_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0152, "0152");
        }

        private void B_0153_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0153, "0153");
        }

        private void B_0155_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0155, "0155");
        }

        private void B_0159_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0141, "0141");
        }

        private void B_0156_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0156, "0156");
        }

        private void B_0157_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0157, "0157");
        }

        private void B_0158_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0158, "0158");
        }

        private void B_0160_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0160, "0160");
        }

        private void B_0161_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0161, "0161");
        }

        private void B_0162_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0162, "0162");
        }

        private void B_0163_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0163, "0163");
        }

        private void b_0164_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0164, "0164");
        }

        private void B_0165_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0165, "0165");
        }

        private void B_0166_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0166, "0166");
        }

        private void B_0167_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0167, "0167");
        }

        private void B_0168_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0168, "0168");
        }

        private void B_0169_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0169, "0169");
        }

        private void B_0170_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0170, "0170");
        }

        private void B_0171_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0171, "0171");
        }

        private void B_0172_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0172, "0172");
        }

        private void B_0173_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0173, "0173");
        }

        private void B_0174_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0174, "0174");
        }

        private void B_0175_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0175, "0175");
        }

        private void B_0176_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0176, "0176");
        }

        private void B_0177_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0177, "0177");
        }

        private void B_0178_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0178, "0178");
        }

        private void B_0179_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0179, "0179");
        }

        private void B_0180_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0180, "0180");
        }

        private void B_0181_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0181, "0181");
        }

        private void B_0182_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0182, "0182");
        }

        private void B_0183_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0183, "0183");
        }

        private void B_0184_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0184, "0184");
        }

        private void B_0185_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0185, "0185");
        }

        private void B_0186_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0186, "0186");
        }

        private void B_0187_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0187, "0187");
        }

        private void B_0188_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0188, "0188");
        }

        private void B_0189_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0189, "0189");
        }

        private void B_0190_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0190, "0190");
        }

        private void B_0191_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0191, "0191");
        }

        private void B_0192_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0192, "0192");
        }

        private void B_0193_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0193, "0193");
        }

        private void B_0194_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0194, "0194");
        }

        private void B_0195_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0195, "0195");
        }

        private void B_0196_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0196, "0196");
        }

        private void B_0197_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0197, "0197");
        }

        private void B_0198_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0198, "0198");
        }

        private void B_0199_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0199, "0199");
        }

        private void B_0200_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0200, "0200");
        }

        private void B_0201_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0201, "0201");
        }

        private void B_0202_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0202, "0202");
        }

        private void B_0203_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0203, "0203");
        }

        private void B_0204_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0204, "0204");
        }

        private void B_0205_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0205, "0205");
        }

        private void B_0206_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0206, "0206");
        }

        private void B_0207_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0207, "0207");
        }

        private void B_0208_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0208, "0208");
        }

        private void B_0209_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0209, "0209");
        }

        private void B_0210_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0210, "0210");
        }

        private void B_0211_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0211, "0211");
        }

        private void B_0212_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0212, "0212");
        }

        private void B_0213_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0213, "0213");
        }

        private void B_0214_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0214, "0214");
        }

        private void B_0215_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0215, "0215");
        }

        private void B_0216_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0216, "0216");
        }

        private void B_0217_Click(object sender, EventArgs e)
        {
            ButtonAcivities(B_0217, "0217");
        }
    }
}
