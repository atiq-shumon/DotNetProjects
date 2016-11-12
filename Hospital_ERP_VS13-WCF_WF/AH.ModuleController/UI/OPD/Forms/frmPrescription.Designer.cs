namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmPrescription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtPrescriptionNo = new System.Windows.Forms.TextBox();
            this.btnPatientSearch = new System.Windows.Forms.Button();
            this.txtSex = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtPatientName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.tabNewPrescription = new AtiqsControlLibrary.SmartTab();
            this.tbNP = new System.Windows.Forms.TabPage();
            this.lvClinicalFindings = new AtiqsControlLibrary.SmartListViewDetails();
            this.btnCFValue = new System.Windows.Forms.Button();
            this.btnOtherComplaints = new System.Windows.Forms.Button();
            this.lvOtherComplaints = new AtiqsControlLibrary.SmartListViewDetails();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnComplaints = new System.Windows.Forms.Button();
            this.btnAddInvestigation = new System.Windows.Forms.Button();
            this.btnAddDrugs = new System.Windows.Forms.Button();
            this.lvDrugs = new AtiqsControlLibrary.SmartListViewDetails();
            this.btnAddAdvice = new System.Windows.Forms.Button();
            this.btnDiagnosis = new System.Windows.Forms.Button();
            this.lvSelectedTests = new AtiqsControlLibrary.SmartListViewDetails();
            this.lvAdvicePrescription = new AtiqsControlLibrary.SmartListViewDetails();
            this.lvComplaints = new AtiqsControlLibrary.SmartListViewDetails();
            this.lvCollectedClinicalDiagnosis = new AtiqsControlLibrary.SmartListViewDetails();
            this.tbHistory = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtFamilyHis = new System.Windows.Forms.TextBox();
            this.chkFamilyHis = new AtiqsControlLibrary.SmartCheckBox();
            this.smartTextBox10 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel43 = new AtiqsControlLibrary.SmartLabel();
            this.smartTextBox11 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel44 = new AtiqsControlLibrary.SmartLabel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtPSurgHis = new System.Windows.Forms.TextBox();
            this.chkPSurgHis = new AtiqsControlLibrary.SmartCheckBox();
            this.smartTextBox8 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel41 = new AtiqsControlLibrary.SmartLabel();
            this.smartTextBox9 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel42 = new AtiqsControlLibrary.SmartLabel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkPMedHis = new AtiqsControlLibrary.SmartCheckBox();
            this.txtPMedHis = new System.Windows.Forms.TextBox();
            this.smartTextBox2 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel39 = new AtiqsControlLibrary.SmartLabel();
            this.smartTextBox5 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel40 = new AtiqsControlLibrary.SmartLabel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chkOtherDisease = new AtiqsControlLibrary.SmartCheckBox();
            this.txtOtherDisease = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkAllergy = new AtiqsControlLibrary.SmartCheckBox();
            this.txtAllergy = new System.Windows.Forms.TextBox();
            this.smartTextBox6 = new AtiqsControlLibrary.SmartTextBox();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.chkKidneyDisease = new AtiqsControlLibrary.SmartCheckBox();
            this.txtKidneyDisease = new System.Windows.Forms.TextBox();
            this.smartLabel33 = new AtiqsControlLibrary.SmartLabel();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.chkHeartDisease = new AtiqsControlLibrary.SmartCheckBox();
            this.txtHeartDisease = new System.Windows.Forms.TextBox();
            this.smartTextBox7 = new AtiqsControlLibrary.SmartTextBox();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.chkHypertension = new AtiqsControlLibrary.SmartCheckBox();
            this.txtHypertension = new System.Windows.Forms.TextBox();
            this.smartLabel34 = new AtiqsControlLibrary.SmartLabel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.chkDiabetes = new AtiqsControlLibrary.SmartCheckBox();
            this.txtDiabetes = new System.Windows.Forms.TextBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.chkAsthma = new AtiqsControlLibrary.SmartCheckBox();
            this.txtAsthma = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tbRx = new System.Windows.Forms.TabPage();
            this.PatientsHistoryTree = new AH.ModuleController.TreeViewControl(this.components);
            this.treePatientHistory1 = new AH.ModuleController.TreeViewControl(this.components);
            this.tbPediatric = new System.Windows.Forms.TabPage();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.rdoEecoHis = new System.Windows.Forms.RadioButton();
            this.txtEcoHis = new AtiqsControlLibrary.SmartTextBox();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.rdoImmuMiss = new System.Windows.Forms.RadioButton();
            this.rdoImmuUTD = new System.Windows.Forms.RadioButton();
            this.txtImmu = new AtiqsControlLibrary.SmartTextBox();
            this.groupBox36 = new System.Windows.Forms.GroupBox();
            this.rdoMSTNDelay = new System.Windows.Forms.RadioButton();
            this.txtMSTNDev = new AtiqsControlLibrary.SmartTextBox();
            this.rdoMSTNAppro = new System.Windows.Forms.RadioButton();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompFeedHis2 = new AtiqsControlLibrary.SmartTextBox();
            this.txtPresFeed = new AtiqsControlLibrary.SmartTextBox();
            this.chkExFeed = new AtiqsControlLibrary.SmartCheckBox();
            this.txtExFeedHis = new AtiqsControlLibrary.SmartTextBox();
            this.chkPresentFeed = new AtiqsControlLibrary.SmartCheckBox();
            this.chkCompFeed = new AtiqsControlLibrary.SmartCheckBox();
            this.txtCompFeedHis1 = new AtiqsControlLibrary.SmartTextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.rdoPostNCom = new System.Windows.Forms.RadioButton();
            this.rdoPostNUn = new System.Windows.Forms.RadioButton();
            this.txtPostNatal = new AtiqsControlLibrary.SmartTextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.rdoNatalCS = new System.Windows.Forms.RadioButton();
            this.rdoNatalN = new System.Windows.Forms.RadioButton();
            this.txtNatal = new AtiqsControlLibrary.SmartTextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.rdoAntenatalAbN = new System.Windows.Forms.RadioButton();
            this.rdoAntenatalN = new System.Windows.Forms.RadioButton();
            this.txtAntenatal = new AtiqsControlLibrary.SmartTextBox();
            this.tbGynOBS = new System.Windows.Forms.TabPage();
            this.groupBox34 = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.chkObs = new AtiqsControlLibrary.SmartCheckBox();
            this.groupBox35 = new System.Windows.Forms.GroupBox();
            this.chkGyn = new AtiqsControlLibrary.SmartCheckBox();
            this.txtGyn = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.smartTextBox19 = new AtiqsControlLibrary.SmartTextBox();
            this.smartTextBox18 = new AtiqsControlLibrary.SmartTextBox();
            this.smartTextBox17 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel49 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel48 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel47 = new AtiqsControlLibrary.SmartLabel();
            this.smartTextBox21 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel56 = new AtiqsControlLibrary.SmartLabel();
            this.smartTextBox20 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel55 = new AtiqsControlLibrary.SmartLabel();
            this.groupBox37 = new System.Windows.Forms.GroupBox();
            this.smartTextBox16 = new AtiqsControlLibrary.SmartTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.smartLabel46 = new AtiqsControlLibrary.SmartLabel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cboFrequency = new AtiqsControlLibrary.SmartComboBox();
            this.txtFrequency = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel24 = new AtiqsControlLibrary.SmartLabel();
            this.txtOtherInfoOfDisease = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel38 = new AtiqsControlLibrary.SmartLabel();
            this.txtHDiagDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.smartLabel37 = new AtiqsControlLibrary.SmartLabel();
            this.cboCaseID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel17 = new AtiqsControlLibrary.SmartLabel();
            this.chkDiagHere = new AtiqsControlLibrary.SmartCheckBox();
            this.lvPatientsHistory = new AtiqsControlLibrary.SmartListViewDetails();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.smartComboBox5 = new AtiqsControlLibrary.SmartComboBox();
            this.smartTextBox3 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel60 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel58 = new AtiqsControlLibrary.SmartLabel();
            this.smartNumericTextBox1 = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartComboBox7 = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel57 = new AtiqsControlLibrary.SmartLabel();
            this.smartComboBox1 = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel59 = new AtiqsControlLibrary.SmartLabel();
            this.smartListViewDetails2 = new AtiqsControlLibrary.SmartListViewDetails();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.smartLabel54 = new AtiqsControlLibrary.SmartLabel();
            this.smartCheckBox22 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox21 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox20 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox19 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox18 = new AtiqsControlLibrary.SmartCheckBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.smartCheckBox65 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartLabel53 = new AtiqsControlLibrary.SmartLabel();
            this.smartCheckBox15 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox16 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox14 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox17 = new AtiqsControlLibrary.SmartCheckBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.smartCheckBox64 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartLabel52 = new AtiqsControlLibrary.SmartLabel();
            this.smartCheckBox10 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox13 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox11 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox12 = new AtiqsControlLibrary.SmartCheckBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.smartCheckBox1 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartLabel51 = new AtiqsControlLibrary.SmartLabel();
            this.smartCheckBox9 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox8 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox6 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox7 = new AtiqsControlLibrary.SmartCheckBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.smartCheckBox63 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartLabel50 = new AtiqsControlLibrary.SmartLabel();
            this.smartCheckBox4 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox3 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox5 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox2 = new AtiqsControlLibrary.SmartCheckBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.smartListViewDetails3 = new AtiqsControlLibrary.SmartListViewDetails();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.smartComboBox2 = new AtiqsControlLibrary.SmartComboBox();
            this.smartTextBox4 = new AtiqsControlLibrary.SmartTextBox();
            this.smartTextBox1 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel18 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel19 = new AtiqsControlLibrary.SmartLabel();
            this.smartNumericTextBox2 = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel20 = new AtiqsControlLibrary.SmartLabel();
            this.smartComboBox3 = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel21 = new AtiqsControlLibrary.SmartLabel();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.panel13 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.smartLabel32 = new AtiqsControlLibrary.SmartLabel();
            this.smartCheckBox62 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox61 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox59 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox60 = new AtiqsControlLibrary.SmartCheckBox();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.smartLabel25 = new AtiqsControlLibrary.SmartLabel();
            this.smartCheckBox54 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox53 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox52 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox51 = new AtiqsControlLibrary.SmartCheckBox();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.smartLabel31 = new AtiqsControlLibrary.SmartLabel();
            this.smartCheckBox58 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox57 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox56 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox55 = new AtiqsControlLibrary.SmartCheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.smartLabel23 = new AtiqsControlLibrary.SmartLabel();
            this.smartCheckBox50 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox49 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox48 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox47 = new AtiqsControlLibrary.SmartCheckBox();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.smartLabel22 = new AtiqsControlLibrary.SmartLabel();
            this.smartCheckBox46 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox45 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox44 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox35 = new AtiqsControlLibrary.SmartCheckBox();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.smartLabel30 = new AtiqsControlLibrary.SmartLabel();
            this.smartCheckBox32 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox29 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox26 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox23 = new AtiqsControlLibrary.SmartCheckBox();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.smartLabel28 = new AtiqsControlLibrary.SmartLabel();
            this.smartCheckBox33 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox30 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox27 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox24 = new AtiqsControlLibrary.SmartCheckBox();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.smartLabel29 = new AtiqsControlLibrary.SmartLabel();
            this.smartCheckBox43 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox40 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox39 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox36 = new AtiqsControlLibrary.SmartCheckBox();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.smartLabel27 = new AtiqsControlLibrary.SmartLabel();
            this.smartCheckBox34 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox31 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox28 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox25 = new AtiqsControlLibrary.SmartCheckBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.smartLabel26 = new AtiqsControlLibrary.SmartLabel();
            this.smartCheckBox42 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox41 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox38 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartCheckBox37 = new AtiqsControlLibrary.SmartCheckBox();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtNextVisit = new AtiqsControlLibrary.SmartDateTextBox();
            this.txtNextVisitYear = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtNextVisitMonth = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtNextVisitDay = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel15 = new AtiqsControlLibrary.SmartLabel();
            this.lvTicketList = new AtiqsControlLibrary.SmartListViewDetails();
            this.panel1 = new System.Windows.Forms.Panel();
            this.smartLabel35 = new AtiqsControlLibrary.SmartLabel();
            this.lblComplaints = new System.Windows.Forms.Label();
            this.lblDeptDoctor = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblComplaints1 = new System.Windows.Forms.Label();
            this.lblDeptDoctor1 = new System.Windows.Forms.Label();
            this.LocalSourceFile1 = new System.Windows.Forms.Label();
            this.txtDoctorID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtDepartment = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtDoctorName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtDepartmentName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel14 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.cboTicketType = new AtiqsControlLibrary.SmartComboBox();
            this.txtHCN = new AtiqsControlLibrary.SmartTextBox();
            this.txtDepartmentUnit = new AtiqsControlLibrary.SmartTextBox();
            this.lblBusy = new System.Windows.Forms.LinkLabel();
            this.lblVisit = new System.Windows.Forms.LinkLabel();
            this.lblFree = new System.Windows.Forms.LinkLabel();
            this.lblRefresh = new System.Windows.Forms.LinkLabel();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtAgeHours = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtAgeDays = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtAgeMonths = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtAgeYears = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartListViewDetails1 = new AtiqsControlLibrary.SmartListViewDetails();
            this.treePatientHistory = new AH.ModuleController.TreeViewControl(this.components);
            this.llblBMI = new AtiqsControlLibrary.SmartLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtWeightS = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtHeightS = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lblHeightFeet = new AtiqsControlLibrary.SmartLabel();
            this.lblWeighPound = new AtiqsControlLibrary.SmartLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtWeightM = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtHeightM = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lblHeightCM = new AtiqsControlLibrary.SmartLabel();
            this.lblWeightKg = new AtiqsControlLibrary.SmartLabel();
            this.lblBMIStatus = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel16 = new AtiqsControlLibrary.SmartLabel();
            this.lblBMIStatusList = new System.Windows.Forms.Label();
            this.txtBMI = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtBP = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtTemp = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboDoctor = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.chkReferTo = new AtiqsControlLibrary.SmartCheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.chkAllergy1 = new System.Windows.Forms.CheckBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.chkKidneyDisease1 = new System.Windows.Forms.CheckBox();
            this.chkHeartDisease1 = new System.Windows.Forms.CheckBox();
            this.chkHypertension1 = new System.Windows.Forms.CheckBox();
            this.chkDiabetes1 = new System.Windows.Forms.CheckBox();
            this.chkAsthma1 = new System.Windows.Forms.CheckBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtBpP2 = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel36 = new AtiqsControlLibrary.SmartLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.chkOtherDisease1 = new System.Windows.Forms.CheckBox();
            this.chkPSurgHis1 = new System.Windows.Forms.CheckBox();
            this.chkPMedHis1 = new System.Windows.Forms.CheckBox();
            this.chkFamilyHis1 = new AtiqsControlLibrary.SmartCheckBox();
            this.txtDiseaseCase = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.panel20 = new System.Windows.Forms.Panel();
            this.txtSPOTWO = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtBSA = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtOFC = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.btnVisitedPatList = new System.Windows.Forms.Button();
            this.btnCancelTicket = new System.Windows.Forms.Button();
            this.groupBox38 = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.tabNewPrescription.SuspendLayout();
            this.tbNP.SuspendLayout();
            this.tbHistory.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tbRx.SuspendLayout();
            this.tbPediatric.SuspendLayout();
            this.groupBox33.SuspendLayout();
            this.groupBox32.SuspendLayout();
            this.groupBox36.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox31.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.tbGynOBS.SuspendLayout();
            this.groupBox34.SuspendLayout();
            this.groupBox35.SuspendLayout();
            this.groupBox37.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox30.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel15.SuspendLayout();
            this.groupBox38.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(1236, 3);
            this.btnTopClose.Size = new System.Drawing.Size(13, 13);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(660, 6);
            this.frmLabel.Size = new System.Drawing.Size(154, 33);
            this.frmLabel.Text = "Prescription";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabControl1);
            this.pnlMain.Controls.Add(this.txtOFC);
            this.pnlMain.Controls.Add(this.txtBSA);
            this.pnlMain.Controls.Add(this.txtSPOTWO);
            this.pnlMain.Controls.Add(this.panel20);
            this.pnlMain.Controls.Add(this.txtBpP2);
            this.pnlMain.Controls.Add(this.panel17);
            this.pnlMain.Controls.Add(this.panel16);
            this.pnlMain.Controls.Add(this.panel12);
            this.pnlMain.Controls.Add(this.panel15);
            this.pnlMain.Controls.Add(this.panel10);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lblEndTime);
            this.pnlMain.Controls.Add(this.lblStartTime);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.txtTemp);
            this.pnlMain.Controls.Add(this.txtBP);
            this.pnlMain.Controls.Add(this.txtNextVisit);
            this.pnlMain.Controls.Add(this.txtNextVisitYear);
            this.pnlMain.Controls.Add(this.txtBMI);
            this.pnlMain.Controls.Add(this.txtNextVisitMonth);
            this.pnlMain.Controls.Add(this.txtNextVisitDay);
            this.pnlMain.Controls.Add(this.smartLabel16);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.smartLabel14);
            this.pnlMain.Controls.Add(this.tabNewPrescription);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.lblBMIStatus);
            this.pnlMain.Controls.Add(this.llblBMI);
            this.pnlMain.Controls.Add(this.panel9);
            this.pnlMain.Controls.Add(this.panel7);
            this.pnlMain.Controls.Add(this.lblBMIStatusList);
            this.pnlMain.Controls.Add(this.lvTicketList);
            this.pnlMain.Controls.Add(this.smartLabel36);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.btnPatientSearch);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel15);
            this.pnlMain.Controls.Add(this.txtPrescriptionNo);
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Size = new System.Drawing.Size(1475, 725);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.panel11);
            this.pnlTop.Size = new System.Drawing.Size(1475, 51);
            this.pnlTop.Click += new System.EventHandler(this.pnlTop_Click);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.panel11, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(480, 784);
            this.btnEdit.Size = new System.Drawing.Size(14, 17);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1244, 782);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(466, 799);
            this.btnDelete.Size = new System.Drawing.Size(10, 15);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1130, 782);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1358, 782);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(466, 784);
            this.btnPrint.Size = new System.Drawing.Size(10, 15);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 822);
            this.groupBox1.Size = new System.Drawing.Size(1475, 25);
            // 
            // txtPrescriptionNo
            // 
            this.txtPrescriptionNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrescriptionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrescriptionNo.ForeColor = System.Drawing.Color.Red;
            this.txtPrescriptionNo.Location = new System.Drawing.Point(0, 0);
            this.txtPrescriptionNo.MaxLength = 11;
            this.txtPrescriptionNo.Name = "txtPrescriptionNo";
            this.txtPrescriptionNo.Size = new System.Drawing.Size(239, 31);
            this.txtPrescriptionNo.TabIndex = 117;
            this.txtPrescriptionNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrescriptionNo_KeyUp);
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSearch.ForeColor = System.Drawing.Color.White;
            this.btnPatientSearch.Location = new System.Drawing.Point(240, -1);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(55, 33);
            this.btnPatientSearch.TabIndex = 115;
            this.btnPatientSearch.Text = "Find";
            this.btnPatientSearch.UseVisualStyleBackColor = false;
            this.btnPatientSearch.Click += new System.EventHandler(this.btnPatientSearch_Click);
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.Linen;
            this.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSex.Location = new System.Drawing.Point(69, 783);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(10, 24);
            this.txtSex.TabIndex = 113;
            this.txtSex.TabStop = false;
            this.txtSex.Visible = false;
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.Linen;
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPatientName.Location = new System.Drawing.Point(82, 783);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(22, 24);
            this.txtPatientName.TabIndex = 103;
            this.txtPatientName.TabStop = false;
            this.txtPatientName.Visible = false;
            // 
            // tabNewPrescription
            // 
            this.tabNewPrescription.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabNewPrescription.Controls.Add(this.tbNP);
            this.tabNewPrescription.Controls.Add(this.tbHistory);
            this.tabNewPrescription.Controls.Add(this.tbRx);
            this.tabNewPrescription.Controls.Add(this.tbPediatric);
            this.tabNewPrescription.Controls.Add(this.tbGynOBS);
            this.tabNewPrescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabNewPrescription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNewPrescription.Location = new System.Drawing.Point(0, 186);
            this.tabNewPrescription.Multiline = true;
            this.tabNewPrescription.Name = "tabNewPrescription";
            this.tabNewPrescription.SelectedIndex = 0;
            this.tabNewPrescription.Size = new System.Drawing.Size(1474, 537);
            this.tabNewPrescription.TabIndex = 118;
            this.tabNewPrescription.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabNewPrescription_MouseClick);
            // 
            // tbNP
            // 
            this.tbNP.BackColor = System.Drawing.Color.White;
            this.tbNP.Controls.Add(this.lvClinicalFindings);
            this.tbNP.Controls.Add(this.btnCFValue);
            this.tbNP.Controls.Add(this.btnOtherComplaints);
            this.tbNP.Controls.Add(this.lvOtherComplaints);
            this.tbNP.Controls.Add(this.panel6);
            this.tbNP.Controls.Add(this.panel5);
            this.tbNP.Controls.Add(this.btnComplaints);
            this.tbNP.Controls.Add(this.btnAddInvestigation);
            this.tbNP.Controls.Add(this.btnAddDrugs);
            this.tbNP.Controls.Add(this.lvDrugs);
            this.tbNP.Controls.Add(this.btnAddAdvice);
            this.tbNP.Controls.Add(this.btnDiagnosis);
            this.tbNP.Controls.Add(this.lvSelectedTests);
            this.tbNP.Controls.Add(this.lvAdvicePrescription);
            this.tbNP.Controls.Add(this.lvComplaints);
            this.tbNP.Controls.Add(this.lvCollectedClinicalDiagnosis);
            this.tbNP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNP.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbNP.Location = new System.Drawing.Point(4, 31);
            this.tbNP.Name = "tbNP";
            this.tbNP.Padding = new System.Windows.Forms.Padding(3);
            this.tbNP.Size = new System.Drawing.Size(1466, 502);
            this.tbNP.TabIndex = 0;
            this.tbNP.Text = "New Prescription";
            // 
            // lvClinicalFindings
            // 
            this.lvClinicalFindings.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvClinicalFindings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvClinicalFindings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvClinicalFindings.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvClinicalFindings.FullRowSelect = true;
            this.lvClinicalFindings.GridLines = true;
            this.lvClinicalFindings.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvClinicalFindings.Location = new System.Drawing.Point(1, 279);
            this.lvClinicalFindings.Name = "lvClinicalFindings";
            this.lvClinicalFindings.Size = new System.Drawing.Size(402, 222);
            this.lvClinicalFindings.TabIndex = 244;
            this.lvClinicalFindings.UseCompatibleStateImageBehavior = false;
            this.lvClinicalFindings.View = System.Windows.Forms.View.Details;
            this.lvClinicalFindings.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvClinicalFindings_MouseDoubleClick);
            // 
            // btnCFValue
            // 
            this.btnCFValue.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCFValue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCFValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCFValue.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCFValue.ForeColor = System.Drawing.Color.Ivory;
            this.btnCFValue.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCFValue.Location = new System.Drawing.Point(71, 251);
            this.btnCFValue.Name = "btnCFValue";
            this.btnCFValue.Size = new System.Drawing.Size(260, 28);
            this.btnCFValue.TabIndex = 243;
            this.btnCFValue.Text = "Add Clinical Finding(s)";
            this.btnCFValue.UseVisualStyleBackColor = false;
            this.btnCFValue.Click += new System.EventHandler(this.btnCFValue_Click);
            // 
            // btnOtherComplaints
            // 
            this.btnOtherComplaints.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOtherComplaints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOtherComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOtherComplaints.ForeColor = System.Drawing.Color.Ivory;
            this.btnOtherComplaints.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOtherComplaints.Location = new System.Drawing.Point(113, 252);
            this.btnOtherComplaints.Name = "btnOtherComplaints";
            this.btnOtherComplaints.Size = new System.Drawing.Size(71, 26);
            this.btnOtherComplaints.TabIndex = 242;
            this.btnOtherComplaints.Text = "Other Complaint(s)";
            this.btnOtherComplaints.UseVisualStyleBackColor = false;
            this.btnOtherComplaints.Visible = false;
            this.btnOtherComplaints.Click += new System.EventHandler(this.btnOtherComplaints_Click);
            // 
            // lvOtherComplaints
            // 
            this.lvOtherComplaints.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvOtherComplaints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvOtherComplaints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvOtherComplaints.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOtherComplaints.FullRowSelect = true;
            this.lvOtherComplaints.GridLines = true;
            this.lvOtherComplaints.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvOtherComplaints.Location = new System.Drawing.Point(250, 296);
            this.lvOtherComplaints.Name = "lvOtherComplaints";
            this.lvOtherComplaints.Size = new System.Drawing.Size(35, 97);
            this.lvOtherComplaints.TabIndex = 241;
            this.lvOtherComplaints.UseCompatibleStateImageBehavior = false;
            this.lvOtherComplaints.View = System.Windows.Forms.View.Details;
            this.lvOtherComplaints.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(810, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 500);
            this.panel6.TabIndex = 240;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(403, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 500);
            this.panel5.TabIndex = 239;
            // 
            // btnComplaints
            // 
            this.btnComplaints.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnComplaints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaints.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnComplaints.ForeColor = System.Drawing.Color.Ivory;
            this.btnComplaints.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnComplaints.Location = new System.Drawing.Point(71, 1);
            this.btnComplaints.Name = "btnComplaints";
            this.btnComplaints.Size = new System.Drawing.Size(260, 28);
            this.btnComplaints.TabIndex = 223;
            this.btnComplaints.Text = "Add Chief Complaint(s)";
            this.btnComplaints.UseVisualStyleBackColor = false;
            this.btnComplaints.Click += new System.EventHandler(this.btnComplaints_Click);
            // 
            // btnAddInvestigation
            // 
            this.btnAddInvestigation.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddInvestigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddInvestigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInvestigation.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddInvestigation.ForeColor = System.Drawing.Color.Ivory;
            this.btnAddInvestigation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddInvestigation.Location = new System.Drawing.Point(476, 251);
            this.btnAddInvestigation.Name = "btnAddInvestigation";
            this.btnAddInvestigation.Size = new System.Drawing.Size(260, 28);
            this.btnAddInvestigation.TabIndex = 211;
            this.btnAddInvestigation.Text = "Add Investigation(s)";
            this.btnAddInvestigation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddInvestigation.UseVisualStyleBackColor = false;
            this.btnAddInvestigation.Click += new System.EventHandler(this.btnAddInvestigation_Click);
            // 
            // btnAddDrugs
            // 
            this.btnAddDrugs.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddDrugs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDrugs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDrugs.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddDrugs.ForeColor = System.Drawing.Color.Ivory;
            this.btnAddDrugs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddDrugs.Location = new System.Drawing.Point(1009, 1);
            this.btnAddDrugs.Name = "btnAddDrugs";
            this.btnAddDrugs.Size = new System.Drawing.Size(260, 28);
            this.btnAddDrugs.TabIndex = 217;
            this.btnAddDrugs.Text = "Add Drug(s)";
            this.btnAddDrugs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddDrugs.UseVisualStyleBackColor = false;
            this.btnAddDrugs.Click += new System.EventHandler(this.btnAddDrugs_Click);
            // 
            // lvDrugs
            // 
            this.lvDrugs.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDrugs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDrugs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDrugs.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDrugs.FullRowSelect = true;
            this.lvDrugs.GridLines = true;
            this.lvDrugs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDrugs.Location = new System.Drawing.Point(815, 29);
            this.lvDrugs.Name = "lvDrugs";
            this.lvDrugs.Size = new System.Drawing.Size(650, 222);
            this.lvDrugs.TabIndex = 216;
            this.lvDrugs.UseCompatibleStateImageBehavior = false;
            this.lvDrugs.View = System.Windows.Forms.View.Details;
            this.lvDrugs.DoubleClick += new System.EventHandler(this.lvDrugs_DoubleClick);
            // 
            // btnAddAdvice
            // 
            this.btnAddAdvice.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddAdvice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAdvice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdvice.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddAdvice.ForeColor = System.Drawing.Color.Ivory;
            this.btnAddAdvice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddAdvice.Location = new System.Drawing.Point(1009, 251);
            this.btnAddAdvice.Name = "btnAddAdvice";
            this.btnAddAdvice.Size = new System.Drawing.Size(260, 28);
            this.btnAddAdvice.TabIndex = 213;
            this.btnAddAdvice.Text = "Add Advice(s)";
            this.btnAddAdvice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddAdvice.UseVisualStyleBackColor = false;
            this.btnAddAdvice.Click += new System.EventHandler(this.btnAddAdvice_Click);
            // 
            // btnDiagnosis
            // 
            this.btnDiagnosis.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDiagnosis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnosis.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDiagnosis.ForeColor = System.Drawing.Color.Ivory;
            this.btnDiagnosis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDiagnosis.Location = new System.Drawing.Point(476, 1);
            this.btnDiagnosis.Name = "btnDiagnosis";
            this.btnDiagnosis.Size = new System.Drawing.Size(260, 28);
            this.btnDiagnosis.TabIndex = 224;
            this.btnDiagnosis.Text = "Add Clinical Impression(s)";
            this.btnDiagnosis.UseVisualStyleBackColor = false;
            this.btnDiagnosis.Click += new System.EventHandler(this.btnDiagnosis_Click);
            // 
            // lvSelectedTests
            // 
            this.lvSelectedTests.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvSelectedTests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSelectedTests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvSelectedTests.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSelectedTests.FullRowSelect = true;
            this.lvSelectedTests.GridLines = true;
            this.lvSelectedTests.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSelectedTests.Location = new System.Drawing.Point(408, 279);
            this.lvSelectedTests.Name = "lvSelectedTests";
            this.lvSelectedTests.Size = new System.Drawing.Size(402, 222);
            this.lvSelectedTests.TabIndex = 96;
            this.lvSelectedTests.UseCompatibleStateImageBehavior = false;
            this.lvSelectedTests.View = System.Windows.Forms.View.Details;
            this.lvSelectedTests.DoubleClick += new System.EventHandler(this.lvSelectedTests_DoubleClick);
            // 
            // lvAdvicePrescription
            // 
            this.lvAdvicePrescription.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvAdvicePrescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAdvicePrescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvAdvicePrescription.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAdvicePrescription.FullRowSelect = true;
            this.lvAdvicePrescription.GridLines = true;
            this.lvAdvicePrescription.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAdvicePrescription.Location = new System.Drawing.Point(815, 279);
            this.lvAdvicePrescription.Name = "lvAdvicePrescription";
            this.lvAdvicePrescription.Size = new System.Drawing.Size(650, 222);
            this.lvAdvicePrescription.TabIndex = 226;
            this.lvAdvicePrescription.UseCompatibleStateImageBehavior = false;
            this.lvAdvicePrescription.View = System.Windows.Forms.View.Details;
            this.lvAdvicePrescription.SelectedIndexChanged += new System.EventHandler(this.lvAdvicePrescription_SelectedIndexChanged);
            this.lvAdvicePrescription.DoubleClick += new System.EventHandler(this.lvAdvicePrescription_DoubleClick);
            // 
            // lvComplaints
            // 
            this.lvComplaints.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvComplaints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvComplaints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvComplaints.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvComplaints.FullRowSelect = true;
            this.lvComplaints.GridLines = true;
            this.lvComplaints.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvComplaints.Location = new System.Drawing.Point(1, 29);
            this.lvComplaints.Name = "lvComplaints";
            this.lvComplaints.Size = new System.Drawing.Size(402, 222);
            this.lvComplaints.TabIndex = 221;
            this.lvComplaints.UseCompatibleStateImageBehavior = false;
            this.lvComplaints.View = System.Windows.Forms.View.Details;
            this.lvComplaints.DoubleClick += new System.EventHandler(this.lstVComplaints_DoubleClick);
            this.lvComplaints.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstVComplaints_MouseDoubleClick);
            // 
            // lvCollectedClinicalDiagnosis
            // 
            this.lvCollectedClinicalDiagnosis.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvCollectedClinicalDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCollectedClinicalDiagnosis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCollectedClinicalDiagnosis.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCollectedClinicalDiagnosis.FullRowSelect = true;
            this.lvCollectedClinicalDiagnosis.GridLines = true;
            this.lvCollectedClinicalDiagnosis.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCollectedClinicalDiagnosis.Location = new System.Drawing.Point(408, 29);
            this.lvCollectedClinicalDiagnosis.Name = "lvCollectedClinicalDiagnosis";
            this.lvCollectedClinicalDiagnosis.Size = new System.Drawing.Size(402, 222);
            this.lvCollectedClinicalDiagnosis.TabIndex = 214;
            this.lvCollectedClinicalDiagnosis.UseCompatibleStateImageBehavior = false;
            this.lvCollectedClinicalDiagnosis.View = System.Windows.Forms.View.Details;
            this.lvCollectedClinicalDiagnosis.DoubleClick += new System.EventHandler(this.lvCollectedClinicalDiagnosis_DoubleClick);
            this.lvCollectedClinicalDiagnosis.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvCollectedClinicalDiagnosis_MouseDoubleClick);
            // 
            // tbHistory
            // 
            this.tbHistory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbHistory.Controls.Add(this.groupBox11);
            this.tbHistory.Controls.Add(this.panel19);
            this.tbHistory.Controls.Add(this.groupBox8);
            this.tbHistory.Controls.Add(this.groupBox7);
            this.tbHistory.Controls.Add(this.panel18);
            this.tbHistory.Controls.Add(this.groupBox6);
            this.tbHistory.Controls.Add(this.panel14);
            this.tbHistory.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHistory.Location = new System.Drawing.Point(4, 31);
            this.tbHistory.Name = "tbHistory";
            this.tbHistory.Size = new System.Drawing.Size(1466, 502);
            this.tbHistory.TabIndex = 2;
            this.tbHistory.Text = "Comorbid Illness & History";
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.Lavender;
            this.groupBox11.Controls.Add(this.txtFamilyHis);
            this.groupBox11.Controls.Add(this.chkFamilyHis);
            this.groupBox11.Controls.Add(this.smartTextBox10);
            this.groupBox11.Controls.Add(this.smartLabel43);
            this.groupBox11.Controls.Add(this.smartTextBox11);
            this.groupBox11.Controls.Add(this.smartLabel44);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox11.Location = new System.Drawing.Point(1138, 3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(325, 495);
            this.groupBox11.TabIndex = 253;
            this.groupBox11.TabStop = false;
            // 
            // txtFamilyHis
            // 
            this.txtFamilyHis.BackColor = System.Drawing.Color.White;
            this.txtFamilyHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFamilyHis.Location = new System.Drawing.Point(5, 56);
            this.txtFamilyHis.MaxLength = 1500;
            this.txtFamilyHis.Multiline = true;
            this.txtFamilyHis.Name = "txtFamilyHis";
            this.txtFamilyHis.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFamilyHis.Size = new System.Drawing.Size(313, 434);
            this.txtFamilyHis.TabIndex = 248;
            this.txtFamilyHis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFamilyHis_KeyPress);
            // 
            // chkFamilyHis
            // 
            this.chkFamilyHis.AutoSize = true;
            this.chkFamilyHis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkFamilyHis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFamilyHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFamilyHis.ForeColor = System.Drawing.Color.Black;
            this.chkFamilyHis.Location = new System.Drawing.Point(10, 22);
            this.chkFamilyHis.Name = "chkFamilyHis";
            this.chkFamilyHis.Size = new System.Drawing.Size(118, 22);
            this.chkFamilyHis.TabIndex = 247;
            this.chkFamilyHis.Text = "Family History";
            this.chkFamilyHis.UseVisualStyleBackColor = true;
            this.chkFamilyHis.CheckedChanged += new System.EventHandler(this.chkFamilyHis_CheckedChanged);
            // 
            // smartTextBox10
            // 
            this.smartTextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox10.Location = new System.Drawing.Point(860, 16);
            this.smartTextBox10.Name = "smartTextBox10";
            this.smartTextBox10.Size = new System.Drawing.Size(167, 24);
            this.smartTextBox10.TabIndex = 99;
            // 
            // smartLabel43
            // 
            this.smartLabel43.AutoSize = true;
            this.smartLabel43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel43.Location = new System.Drawing.Point(812, 21);
            this.smartLabel43.Name = "smartLabel43";
            this.smartLabel43.Size = new System.Drawing.Size(49, 13);
            this.smartLabel43.TabIndex = 100;
            this.smartLabel43.Text = "HCN  : ";
            // 
            // smartTextBox11
            // 
            this.smartTextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox11.Location = new System.Drawing.Point(860, 46);
            this.smartTextBox11.Name = "smartTextBox11";
            this.smartTextBox11.Size = new System.Drawing.Size(135, 24);
            this.smartTextBox11.TabIndex = 92;
            // 
            // smartLabel44
            // 
            this.smartLabel44.AutoSize = true;
            this.smartLabel44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel44.Location = new System.Drawing.Point(812, 51);
            this.smartLabel44.Name = "smartLabel44";
            this.smartLabel44.Size = new System.Drawing.Size(45, 13);
            this.smartLabel44.TabIndex = 94;
            this.smartLabel44.Text = "DOB  :";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel19.Location = new System.Drawing.Point(1131, 1);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(5, 504);
            this.panel19.TabIndex = 252;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Lavender;
            this.groupBox8.Controls.Add(this.txtPSurgHis);
            this.groupBox8.Controls.Add(this.chkPSurgHis);
            this.groupBox8.Controls.Add(this.smartTextBox8);
            this.groupBox8.Controls.Add(this.smartLabel41);
            this.groupBox8.Controls.Add(this.smartTextBox9);
            this.groupBox8.Controls.Add(this.smartLabel42);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox8.Location = new System.Drawing.Point(804, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(325, 495);
            this.groupBox8.TabIndex = 251;
            this.groupBox8.TabStop = false;
            // 
            // txtPSurgHis
            // 
            this.txtPSurgHis.BackColor = System.Drawing.Color.White;
            this.txtPSurgHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtPSurgHis.Location = new System.Drawing.Point(5, 56);
            this.txtPSurgHis.MaxLength = 1500;
            this.txtPSurgHis.Multiline = true;
            this.txtPSurgHis.Name = "txtPSurgHis";
            this.txtPSurgHis.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPSurgHis.Size = new System.Drawing.Size(313, 434);
            this.txtPSurgHis.TabIndex = 248;
            this.txtPSurgHis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPSurgHis_KeyPress);
            // 
            // chkPSurgHis
            // 
            this.chkPSurgHis.AutoSize = true;
            this.chkPSurgHis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPSurgHis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPSurgHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPSurgHis.ForeColor = System.Drawing.Color.Black;
            this.chkPSurgHis.Location = new System.Drawing.Point(11, 22);
            this.chkPSurgHis.Name = "chkPSurgHis";
            this.chkPSurgHis.Size = new System.Drawing.Size(162, 22);
            this.chkPSurgHis.TabIndex = 247;
            this.chkPSurgHis.Text = "Past Surgical History";
            this.chkPSurgHis.UseVisualStyleBackColor = true;
            this.chkPSurgHis.CheckedChanged += new System.EventHandler(this.chkPSurgHis_CheckedChanged);
            // 
            // smartTextBox8
            // 
            this.smartTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox8.Location = new System.Drawing.Point(860, 16);
            this.smartTextBox8.Name = "smartTextBox8";
            this.smartTextBox8.Size = new System.Drawing.Size(167, 24);
            this.smartTextBox8.TabIndex = 99;
            // 
            // smartLabel41
            // 
            this.smartLabel41.AutoSize = true;
            this.smartLabel41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel41.Location = new System.Drawing.Point(812, 21);
            this.smartLabel41.Name = "smartLabel41";
            this.smartLabel41.Size = new System.Drawing.Size(49, 13);
            this.smartLabel41.TabIndex = 100;
            this.smartLabel41.Text = "HCN  : ";
            // 
            // smartTextBox9
            // 
            this.smartTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox9.Location = new System.Drawing.Point(860, 46);
            this.smartTextBox9.Name = "smartTextBox9";
            this.smartTextBox9.Size = new System.Drawing.Size(135, 24);
            this.smartTextBox9.TabIndex = 92;
            // 
            // smartLabel42
            // 
            this.smartLabel42.AutoSize = true;
            this.smartLabel42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel42.Location = new System.Drawing.Point(812, 51);
            this.smartLabel42.Name = "smartLabel42";
            this.smartLabel42.Size = new System.Drawing.Size(45, 13);
            this.smartLabel42.TabIndex = 94;
            this.smartLabel42.Text = "DOB  :";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Lavender;
            this.groupBox7.Controls.Add(this.chkPMedHis);
            this.groupBox7.Controls.Add(this.txtPMedHis);
            this.groupBox7.Controls.Add(this.smartTextBox2);
            this.groupBox7.Controls.Add(this.smartLabel39);
            this.groupBox7.Controls.Add(this.smartTextBox5);
            this.groupBox7.Controls.Add(this.smartLabel40);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox7.Location = new System.Drawing.Point(471, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(325, 495);
            this.groupBox7.TabIndex = 250;
            this.groupBox7.TabStop = false;
            // 
            // chkPMedHis
            // 
            this.chkPMedHis.AutoSize = true;
            this.chkPMedHis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPMedHis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPMedHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPMedHis.ForeColor = System.Drawing.Color.Black;
            this.chkPMedHis.Location = new System.Drawing.Point(10, 22);
            this.chkPMedHis.Name = "chkPMedHis";
            this.chkPMedHis.Size = new System.Drawing.Size(160, 22);
            this.chkPMedHis.TabIndex = 157;
            this.chkPMedHis.Text = "Past Medical History";
            this.chkPMedHis.UseVisualStyleBackColor = true;
            this.chkPMedHis.CheckedChanged += new System.EventHandler(this.chkPMedHis_CheckedChanged);
            // 
            // txtPMedHis
            // 
            this.txtPMedHis.BackColor = System.Drawing.Color.White;
            this.txtPMedHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPMedHis.Location = new System.Drawing.Point(5, 56);
            this.txtPMedHis.MaxLength = 1500;
            this.txtPMedHis.Multiline = true;
            this.txtPMedHis.Name = "txtPMedHis";
            this.txtPMedHis.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPMedHis.Size = new System.Drawing.Size(313, 434);
            this.txtPMedHis.TabIndex = 144;
            this.txtPMedHis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPMedHis_KeyPress);
            // 
            // smartTextBox2
            // 
            this.smartTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox2.Location = new System.Drawing.Point(860, 16);
            this.smartTextBox2.Name = "smartTextBox2";
            this.smartTextBox2.Size = new System.Drawing.Size(167, 24);
            this.smartTextBox2.TabIndex = 99;
            // 
            // smartLabel39
            // 
            this.smartLabel39.AutoSize = true;
            this.smartLabel39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel39.Location = new System.Drawing.Point(812, 21);
            this.smartLabel39.Name = "smartLabel39";
            this.smartLabel39.Size = new System.Drawing.Size(49, 13);
            this.smartLabel39.TabIndex = 100;
            this.smartLabel39.Text = "HCN  : ";
            // 
            // smartTextBox5
            // 
            this.smartTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox5.Location = new System.Drawing.Point(860, 46);
            this.smartTextBox5.Name = "smartTextBox5";
            this.smartTextBox5.Size = new System.Drawing.Size(135, 24);
            this.smartTextBox5.TabIndex = 92;
            // 
            // smartLabel40
            // 
            this.smartLabel40.AutoSize = true;
            this.smartLabel40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel40.Location = new System.Drawing.Point(812, 51);
            this.smartLabel40.Name = "smartLabel40";
            this.smartLabel40.Size = new System.Drawing.Size(45, 13);
            this.smartLabel40.TabIndex = 94;
            this.smartLabel40.Text = "DOB  :";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel18.Location = new System.Drawing.Point(798, 1);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(5, 504);
            this.panel18.TabIndex = 249;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Lavender;
            this.groupBox6.Controls.Add(this.splitContainer2);
            this.groupBox6.Controls.Add(this.splitContainer1);
            this.groupBox6.Controls.Add(this.smartTextBox6);
            this.groupBox6.Controls.Add(this.splitContainer6);
            this.groupBox6.Controls.Add(this.smartLabel33);
            this.groupBox6.Controls.Add(this.splitContainer7);
            this.groupBox6.Controls.Add(this.smartTextBox7);
            this.groupBox6.Controls.Add(this.splitContainer8);
            this.groupBox6.Controls.Add(this.smartLabel34);
            this.groupBox6.Controls.Add(this.splitContainer3);
            this.groupBox6.Controls.Add(this.splitContainer4);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(458, 496);
            this.groupBox6.TabIndex = 247;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Co-morbid Illness";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Lavender;
            this.splitContainer2.Location = new System.Drawing.Point(5, 427);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.chkOtherDisease);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtOtherDisease);
            this.splitContainer2.Size = new System.Drawing.Size(447, 64);
            this.splitContainer2.SplitterDistance = 213;
            this.splitContainer2.TabIndex = 252;
            // 
            // chkOtherDisease
            // 
            this.chkOtherDisease.AutoSize = true;
            this.chkOtherDisease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOtherDisease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkOtherDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOtherDisease.ForeColor = System.Drawing.Color.Black;
            this.chkOtherDisease.Location = new System.Drawing.Point(10, 21);
            this.chkOtherDisease.Name = "chkOtherDisease";
            this.chkOtherDisease.Size = new System.Drawing.Size(69, 22);
            this.chkOtherDisease.TabIndex = 164;
            this.chkOtherDisease.Text = "Others";
            this.chkOtherDisease.UseVisualStyleBackColor = true;
            this.chkOtherDisease.CheckedChanged += new System.EventHandler(this.chkOtherDisease_CheckedChanged);
            // 
            // txtOtherDisease
            // 
            this.txtOtherDisease.BackColor = System.Drawing.Color.White;
            this.txtOtherDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherDisease.Location = new System.Drawing.Point(4, 6);
            this.txtOtherDisease.MaxLength = 300;
            this.txtOtherDisease.Multiline = true;
            this.txtOtherDisease.Name = "txtOtherDisease";
            this.txtOtherDisease.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOtherDisease.Size = new System.Drawing.Size(222, 55);
            this.txtOtherDisease.TabIndex = 145;
            this.txtOtherDisease.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtherDisease_KeyPress);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Lavender;
            this.splitContainer1.Location = new System.Drawing.Point(5, 19);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkAllergy);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.splitContainer1.Panel2.Controls.Add(this.txtAllergy);
            this.splitContainer1.Size = new System.Drawing.Size(447, 64);
            this.splitContainer1.SplitterDistance = 213;
            this.splitContainer1.TabIndex = 245;
            // 
            // chkAllergy
            // 
            this.chkAllergy.AutoSize = true;
            this.chkAllergy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAllergy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAllergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllergy.ForeColor = System.Drawing.Color.Black;
            this.chkAllergy.Location = new System.Drawing.Point(14, 21);
            this.chkAllergy.Name = "chkAllergy";
            this.chkAllergy.Size = new System.Drawing.Size(67, 22);
            this.chkAllergy.TabIndex = 156;
            this.chkAllergy.Text = "Allergy";
            this.chkAllergy.UseVisualStyleBackColor = true;
            this.chkAllergy.CheckedChanged += new System.EventHandler(this.chkAllergy_CheckedChanged);
            // 
            // txtAllergy
            // 
            this.txtAllergy.BackColor = System.Drawing.Color.White;
            this.txtAllergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllergy.Location = new System.Drawing.Point(4, 5);
            this.txtAllergy.MaxLength = 200;
            this.txtAllergy.Multiline = true;
            this.txtAllergy.Name = "txtAllergy";
            this.txtAllergy.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAllergy.Size = new System.Drawing.Size(222, 55);
            this.txtAllergy.TabIndex = 144;
            this.txtAllergy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAllergy_KeyPress);
            // 
            // smartTextBox6
            // 
            this.smartTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox6.Location = new System.Drawing.Point(860, 16);
            this.smartTextBox6.Name = "smartTextBox6";
            this.smartTextBox6.Size = new System.Drawing.Size(167, 24);
            this.smartTextBox6.TabIndex = 99;
            // 
            // splitContainer6
            // 
            this.splitContainer6.BackColor = System.Drawing.Color.White;
            this.splitContainer6.Location = new System.Drawing.Point(5, 359);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.chkKidneyDisease);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.txtKidneyDisease);
            this.splitContainer6.Size = new System.Drawing.Size(447, 64);
            this.splitContainer6.SplitterDistance = 213;
            this.splitContainer6.TabIndex = 251;
            // 
            // chkKidneyDisease
            // 
            this.chkKidneyDisease.AutoSize = true;
            this.chkKidneyDisease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkKidneyDisease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkKidneyDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKidneyDisease.ForeColor = System.Drawing.Color.Black;
            this.chkKidneyDisease.Location = new System.Drawing.Point(10, 25);
            this.chkKidneyDisease.Name = "chkKidneyDisease";
            this.chkKidneyDisease.Size = new System.Drawing.Size(182, 22);
            this.chkKidneyDisease.TabIndex = 168;
            this.chkKidneyDisease.Text = "Chronic Kidney Disease";
            this.chkKidneyDisease.UseVisualStyleBackColor = true;
            this.chkKidneyDisease.CheckedChanged += new System.EventHandler(this.chkKidneyDisease_CheckedChanged);
            // 
            // txtKidneyDisease
            // 
            this.txtKidneyDisease.BackColor = System.Drawing.Color.White;
            this.txtKidneyDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKidneyDisease.Location = new System.Drawing.Point(4, 6);
            this.txtKidneyDisease.MaxLength = 100;
            this.txtKidneyDisease.Multiline = true;
            this.txtKidneyDisease.Name = "txtKidneyDisease";
            this.txtKidneyDisease.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtKidneyDisease.Size = new System.Drawing.Size(222, 55);
            this.txtKidneyDisease.TabIndex = 145;
            this.txtKidneyDisease.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKidneyDisease_KeyPress);
            // 
            // smartLabel33
            // 
            this.smartLabel33.AutoSize = true;
            this.smartLabel33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel33.Location = new System.Drawing.Point(812, 21);
            this.smartLabel33.Name = "smartLabel33";
            this.smartLabel33.Size = new System.Drawing.Size(49, 13);
            this.smartLabel33.TabIndex = 100;
            this.smartLabel33.Text = "HCN  : ";
            // 
            // splitContainer7
            // 
            this.splitContainer7.BackColor = System.Drawing.Color.Lavender;
            this.splitContainer7.Location = new System.Drawing.Point(5, 291);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.chkHeartDisease);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.txtHeartDisease);
            this.splitContainer7.Size = new System.Drawing.Size(447, 64);
            this.splitContainer7.SplitterDistance = 213;
            this.splitContainer7.TabIndex = 250;
            // 
            // chkHeartDisease
            // 
            this.chkHeartDisease.AutoSize = true;
            this.chkHeartDisease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHeartDisease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHeartDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHeartDisease.ForeColor = System.Drawing.Color.Black;
            this.chkHeartDisease.Location = new System.Drawing.Point(10, 22);
            this.chkHeartDisease.Name = "chkHeartDisease";
            this.chkHeartDisease.Size = new System.Drawing.Size(181, 22);
            this.chkHeartDisease.TabIndex = 166;
            this.chkHeartDisease.Text = "Ischemic Heart Disease";
            this.chkHeartDisease.UseVisualStyleBackColor = true;
            this.chkHeartDisease.CheckedChanged += new System.EventHandler(this.chkHeartDisease_CheckedChanged);
            // 
            // txtHeartDisease
            // 
            this.txtHeartDisease.BackColor = System.Drawing.Color.White;
            this.txtHeartDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeartDisease.Location = new System.Drawing.Point(4, 6);
            this.txtHeartDisease.MaxLength = 100;
            this.txtHeartDisease.Multiline = true;
            this.txtHeartDisease.Name = "txtHeartDisease";
            this.txtHeartDisease.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHeartDisease.Size = new System.Drawing.Size(222, 55);
            this.txtHeartDisease.TabIndex = 145;
            this.txtHeartDisease.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeartDisease_KeyPress);
            // 
            // smartTextBox7
            // 
            this.smartTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox7.Location = new System.Drawing.Point(860, 46);
            this.smartTextBox7.Name = "smartTextBox7";
            this.smartTextBox7.Size = new System.Drawing.Size(135, 24);
            this.smartTextBox7.TabIndex = 92;
            // 
            // splitContainer8
            // 
            this.splitContainer8.BackColor = System.Drawing.Color.White;
            this.splitContainer8.Location = new System.Drawing.Point(5, 223);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.chkHypertension);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.txtHypertension);
            this.splitContainer8.Size = new System.Drawing.Size(447, 64);
            this.splitContainer8.SplitterDistance = 213;
            this.splitContainer8.TabIndex = 249;
            // 
            // chkHypertension
            // 
            this.chkHypertension.AutoSize = true;
            this.chkHypertension.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHypertension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHypertension.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHypertension.ForeColor = System.Drawing.Color.Black;
            this.chkHypertension.Location = new System.Drawing.Point(10, 21);
            this.chkHypertension.Name = "chkHypertension";
            this.chkHypertension.Size = new System.Drawing.Size(111, 22);
            this.chkHypertension.TabIndex = 164;
            this.chkHypertension.Text = "Hypertension";
            this.chkHypertension.UseVisualStyleBackColor = true;
            this.chkHypertension.CheckedChanged += new System.EventHandler(this.chkHypertension_CheckedChanged);
            // 
            // txtHypertension
            // 
            this.txtHypertension.BackColor = System.Drawing.Color.White;
            this.txtHypertension.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHypertension.Location = new System.Drawing.Point(4, 6);
            this.txtHypertension.MaxLength = 100;
            this.txtHypertension.Multiline = true;
            this.txtHypertension.Name = "txtHypertension";
            this.txtHypertension.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHypertension.Size = new System.Drawing.Size(222, 55);
            this.txtHypertension.TabIndex = 145;
            this.txtHypertension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHypertension_KeyPress);
            // 
            // smartLabel34
            // 
            this.smartLabel34.AutoSize = true;
            this.smartLabel34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel34.Location = new System.Drawing.Point(812, 51);
            this.smartLabel34.Name = "smartLabel34";
            this.smartLabel34.Size = new System.Drawing.Size(45, 13);
            this.smartLabel34.TabIndex = 94;
            this.smartLabel34.Text = "DOB  :";
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.Lavender;
            this.splitContainer3.Location = new System.Drawing.Point(5, 155);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.chkDiabetes);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.txtDiabetes);
            this.splitContainer3.Size = new System.Drawing.Size(447, 64);
            this.splitContainer3.SplitterDistance = 213;
            this.splitContainer3.TabIndex = 248;
            // 
            // chkDiabetes
            // 
            this.chkDiabetes.AutoSize = true;
            this.chkDiabetes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDiabetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDiabetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDiabetes.ForeColor = System.Drawing.Color.Black;
            this.chkDiabetes.Location = new System.Drawing.Point(12, 22);
            this.chkDiabetes.Name = "chkDiabetes";
            this.chkDiabetes.Size = new System.Drawing.Size(136, 22);
            this.chkDiabetes.TabIndex = 162;
            this.chkDiabetes.Text = "Diabetes Mellitus";
            this.chkDiabetes.UseVisualStyleBackColor = true;
            this.chkDiabetes.CheckedChanged += new System.EventHandler(this.chkDiabetes_CheckedChanged);
            // 
            // txtDiabetes
            // 
            this.txtDiabetes.BackColor = System.Drawing.Color.White;
            this.txtDiabetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiabetes.Location = new System.Drawing.Point(4, 5);
            this.txtDiabetes.MaxLength = 200;
            this.txtDiabetes.Multiline = true;
            this.txtDiabetes.Name = "txtDiabetes";
            this.txtDiabetes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDiabetes.Size = new System.Drawing.Size(222, 55);
            this.txtDiabetes.TabIndex = 145;
            this.txtDiabetes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiabetes_KeyPress);
            // 
            // splitContainer4
            // 
            this.splitContainer4.BackColor = System.Drawing.Color.White;
            this.splitContainer4.Location = new System.Drawing.Point(5, 87);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.chkAsthma);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.txtAsthma);
            this.splitContainer4.Size = new System.Drawing.Size(447, 64);
            this.splitContainer4.SplitterDistance = 213;
            this.splitContainer4.TabIndex = 247;
            // 
            // chkAsthma
            // 
            this.chkAsthma.AutoSize = true;
            this.chkAsthma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAsthma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAsthma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAsthma.ForeColor = System.Drawing.Color.Black;
            this.chkAsthma.Location = new System.Drawing.Point(12, 22);
            this.chkAsthma.Name = "chkAsthma";
            this.chkAsthma.Size = new System.Drawing.Size(140, 22);
            this.chkAsthma.TabIndex = 160;
            this.chkAsthma.Text = "Bronchial Asthma";
            this.chkAsthma.UseVisualStyleBackColor = true;
            this.chkAsthma.CheckedChanged += new System.EventHandler(this.chkAsthma_CheckedChanged);
            // 
            // txtAsthma
            // 
            this.txtAsthma.BackColor = System.Drawing.Color.White;
            this.txtAsthma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsthma.Location = new System.Drawing.Point(4, 5);
            this.txtAsthma.MaxLength = 200;
            this.txtAsthma.Multiline = true;
            this.txtAsthma.Name = "txtAsthma";
            this.txtAsthma.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAsthma.Size = new System.Drawing.Size(222, 55);
            this.txtAsthma.TabIndex = 145;
            this.txtAsthma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsthma_KeyPress);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel14.Location = new System.Drawing.Point(463, -3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(5, 504);
            this.panel14.TabIndex = 246;
            // 
            // tbRx
            // 
            this.tbRx.Controls.Add(this.PatientsHistoryTree);
            this.tbRx.Controls.Add(this.treePatientHistory1);
            this.tbRx.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRx.Location = new System.Drawing.Point(4, 31);
            this.tbRx.Name = "tbRx";
            this.tbRx.Padding = new System.Windows.Forms.Padding(3);
            this.tbRx.Size = new System.Drawing.Size(1466, 502);
            this.tbRx.TabIndex = 1;
            this.tbRx.Text = "Previous Medical Record";
            this.tbRx.UseVisualStyleBackColor = true;
            // 
            // PatientsHistoryTree
            // 
            this.PatientsHistoryTree.AutoBuildTree = true;
            this.PatientsHistoryTree.BackColor = System.Drawing.Color.Azure;
            this.PatientsHistoryTree.DataSource = null;
            this.PatientsHistoryTree.DisplayMember = null;
            this.PatientsHistoryTree.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsHistoryTree.Location = new System.Drawing.Point(2, 2);
            this.PatientsHistoryTree.Name = "PatientsHistoryTree";
            this.PatientsHistoryTree.Size = new System.Drawing.Size(1464, 500);
            this.PatientsHistoryTree.TabIndex = 9;
            this.PatientsHistoryTree.ValueMember = null;
            // 
            // treePatientHistory1
            // 
            this.treePatientHistory1.AutoBuildTree = true;
            this.treePatientHistory1.DataSource = null;
            this.treePatientHistory1.DisplayMember = null;
            this.treePatientHistory1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treePatientHistory1.Location = new System.Drawing.Point(1438, 6);
            this.treePatientHistory1.Name = "treePatientHistory1";
            this.treePatientHistory1.Size = new System.Drawing.Size(20, 31);
            this.treePatientHistory1.TabIndex = 8;
            this.treePatientHistory1.ValueMember = null;
            this.treePatientHistory1.Visible = false;
            // 
            // tbPediatric
            // 
            this.tbPediatric.BackColor = System.Drawing.Color.FloralWhite;
            this.tbPediatric.Controls.Add(this.groupBox33);
            this.tbPediatric.Controls.Add(this.groupBox32);
            this.tbPediatric.Controls.Add(this.groupBox36);
            this.tbPediatric.Controls.Add(this.groupBox13);
            this.tbPediatric.Controls.Add(this.groupBox14);
            this.tbPediatric.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPediatric.Location = new System.Drawing.Point(4, 31);
            this.tbPediatric.Name = "tbPediatric";
            this.tbPediatric.Size = new System.Drawing.Size(1466, 502);
            this.tbPediatric.TabIndex = 3;
            this.tbPediatric.Text = "Paediatrics History";
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.rdoEecoHis);
            this.groupBox33.Controls.Add(this.txtEcoHis);
            this.groupBox33.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox33.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox33.Location = new System.Drawing.Point(736, 340);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(725, 155);
            this.groupBox33.TabIndex = 20;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "Socio-Economic History ";
            // 
            // rdoEecoHis
            // 
            this.rdoEecoHis.AutoSize = true;
            this.rdoEecoHis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoEecoHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rdoEecoHis.ForeColor = System.Drawing.Color.Black;
            this.rdoEecoHis.Location = new System.Drawing.Point(17, 62);
            this.rdoEecoHis.Name = "rdoEecoHis";
            this.rdoEecoHis.Size = new System.Drawing.Size(72, 22);
            this.rdoEecoHis.TabIndex = 98;
            this.rdoEecoHis.TabStop = true;
            this.rdoEecoHis.Text = "History";
            this.rdoEecoHis.UseVisualStyleBackColor = true;
            // 
            // txtEcoHis
            // 
            this.txtEcoHis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEcoHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEcoHis.ForeColor = System.Drawing.Color.Black;
            this.txtEcoHis.Location = new System.Drawing.Point(156, 23);
            this.txtEcoHis.MaxLength = 200;
            this.txtEcoHis.Multiline = true;
            this.txtEcoHis.Name = "txtEcoHis";
            this.txtEcoHis.Size = new System.Drawing.Size(562, 123);
            this.txtEcoHis.TabIndex = 5;
            this.txtEcoHis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEcoHis_KeyPress);
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.rdoImmuMiss);
            this.groupBox32.Controls.Add(this.rdoImmuUTD);
            this.groupBox32.Controls.Add(this.txtImmu);
            this.groupBox32.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox32.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox32.Location = new System.Drawing.Point(5, 340);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(725, 155);
            this.groupBox32.TabIndex = 19;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "Immunization ";
            // 
            // rdoImmuMiss
            // 
            this.rdoImmuMiss.AutoSize = true;
            this.rdoImmuMiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoImmuMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rdoImmuMiss.ForeColor = System.Drawing.Color.Black;
            this.rdoImmuMiss.Location = new System.Drawing.Point(17, 89);
            this.rdoImmuMiss.Name = "rdoImmuMiss";
            this.rdoImmuMiss.Size = new System.Drawing.Size(73, 22);
            this.rdoImmuMiss.TabIndex = 97;
            this.rdoImmuMiss.TabStop = true;
            this.rdoImmuMiss.Text = "Missed";
            this.rdoImmuMiss.UseVisualStyleBackColor = true;
            // 
            // rdoImmuUTD
            // 
            this.rdoImmuUTD.AutoSize = true;
            this.rdoImmuUTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoImmuUTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rdoImmuUTD.ForeColor = System.Drawing.Color.Black;
            this.rdoImmuUTD.Location = new System.Drawing.Point(17, 39);
            this.rdoImmuUTD.Name = "rdoImmuUTD";
            this.rdoImmuUTD.Size = new System.Drawing.Size(93, 22);
            this.rdoImmuUTD.TabIndex = 96;
            this.rdoImmuUTD.TabStop = true;
            this.rdoImmuUTD.Text = "Up to date";
            this.rdoImmuUTD.UseVisualStyleBackColor = true;
            // 
            // txtImmu
            // 
            this.txtImmu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImmu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImmu.ForeColor = System.Drawing.Color.Black;
            this.txtImmu.Location = new System.Drawing.Point(144, 23);
            this.txtImmu.MaxLength = 200;
            this.txtImmu.Multiline = true;
            this.txtImmu.Name = "txtImmu";
            this.txtImmu.Size = new System.Drawing.Size(569, 123);
            this.txtImmu.TabIndex = 8;
            this.txtImmu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImmu_KeyPress);
            // 
            // groupBox36
            // 
            this.groupBox36.Controls.Add(this.rdoMSTNDelay);
            this.groupBox36.Controls.Add(this.txtMSTNDev);
            this.groupBox36.Controls.Add(this.rdoMSTNAppro);
            this.groupBox36.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox36.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox36.Location = new System.Drawing.Point(736, 150);
            this.groupBox36.Name = "groupBox36";
            this.groupBox36.Size = new System.Drawing.Size(725, 186);
            this.groupBox36.TabIndex = 18;
            this.groupBox36.TabStop = false;
            this.groupBox36.Text = "Milestone of Developments ";
            // 
            // rdoMSTNDelay
            // 
            this.rdoMSTNDelay.AutoSize = true;
            this.rdoMSTNDelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMSTNDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rdoMSTNDelay.ForeColor = System.Drawing.Color.Black;
            this.rdoMSTNDelay.Location = new System.Drawing.Point(7, 109);
            this.rdoMSTNDelay.Name = "rdoMSTNDelay";
            this.rdoMSTNDelay.Size = new System.Drawing.Size(78, 22);
            this.rdoMSTNDelay.TabIndex = 99;
            this.rdoMSTNDelay.TabStop = true;
            this.rdoMSTNDelay.Text = "Delayed";
            this.rdoMSTNDelay.UseVisualStyleBackColor = true;
            // 
            // txtMSTNDev
            // 
            this.txtMSTNDev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMSTNDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSTNDev.ForeColor = System.Drawing.Color.Black;
            this.txtMSTNDev.Location = new System.Drawing.Point(156, 37);
            this.txtMSTNDev.MaxLength = 200;
            this.txtMSTNDev.Multiline = true;
            this.txtMSTNDev.Name = "txtMSTNDev";
            this.txtMSTNDev.Size = new System.Drawing.Size(562, 123);
            this.txtMSTNDev.TabIndex = 5;
            this.txtMSTNDev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMSTNDev_KeyPress);
            // 
            // rdoMSTNAppro
            // 
            this.rdoMSTNAppro.AutoSize = true;
            this.rdoMSTNAppro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMSTNAppro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rdoMSTNAppro.ForeColor = System.Drawing.Color.Black;
            this.rdoMSTNAppro.Location = new System.Drawing.Point(5, 54);
            this.rdoMSTNAppro.Name = "rdoMSTNAppro";
            this.rdoMSTNAppro.Size = new System.Drawing.Size(151, 22);
            this.rdoMSTNAppro.TabIndex = 98;
            this.rdoMSTNAppro.TabStop = true;
            this.rdoMSTNAppro.Text = "Appropriate for Age";
            this.rdoMSTNAppro.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label5);
            this.groupBox13.Controls.Add(this.txtCompFeedHis2);
            this.groupBox13.Controls.Add(this.txtPresFeed);
            this.groupBox13.Controls.Add(this.chkExFeed);
            this.groupBox13.Controls.Add(this.txtExFeedHis);
            this.groupBox13.Controls.Add(this.chkPresentFeed);
            this.groupBox13.Controls.Add(this.chkCompFeed);
            this.groupBox13.Controls.Add(this.txtCompFeedHis1);
            this.groupBox13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox13.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox13.Location = new System.Drawing.Point(5, 150);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(725, 186);
            this.groupBox13.TabIndex = 17;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Feeding History ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(357, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "with ";
            // 
            // txtCompFeedHis2
            // 
            this.txtCompFeedHis2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompFeedHis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompFeedHis2.ForeColor = System.Drawing.Color.Black;
            this.txtCompFeedHis2.Location = new System.Drawing.Point(398, 78);
            this.txtCompFeedHis2.MaxLength = 200;
            this.txtCompFeedHis2.Multiline = true;
            this.txtCompFeedHis2.Name = "txtCompFeedHis2";
            this.txtCompFeedHis2.Size = new System.Drawing.Size(315, 27);
            this.txtCompFeedHis2.TabIndex = 26;
            this.txtCompFeedHis2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompFeedHis2_KeyPress);
            // 
            // txtPresFeed
            // 
            this.txtPresFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPresFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresFeed.ForeColor = System.Drawing.Color.Black;
            this.txtPresFeed.Location = new System.Drawing.Point(140, 123);
            this.txtPresFeed.Multiline = true;
            this.txtPresFeed.Name = "txtPresFeed";
            this.txtPresFeed.Size = new System.Drawing.Size(573, 53);
            this.txtPresFeed.TabIndex = 23;
            this.txtPresFeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPresFeed_KeyPress);
            // 
            // chkExFeed
            // 
            this.chkExFeed.AutoSize = true;
            this.chkExFeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkExFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkExFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExFeed.ForeColor = System.Drawing.Color.Black;
            this.chkExFeed.Location = new System.Drawing.Point(7, 32);
            this.chkExFeed.Name = "chkExFeed";
            this.chkExFeed.Size = new System.Drawing.Size(274, 22);
            this.chkExFeed.TabIndex = 20;
            this.chkExFeed.Text = "Exclusive breast feeding for periods of";
            this.chkExFeed.UseVisualStyleBackColor = true;
            this.chkExFeed.CheckedChanged += new System.EventHandler(this.chkExFeed_CheckedChanged);
            // 
            // txtExFeedHis
            // 
            this.txtExFeedHis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExFeedHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExFeedHis.ForeColor = System.Drawing.Color.Black;
            this.txtExFeedHis.Location = new System.Drawing.Point(282, 30);
            this.txtExFeedHis.MaxLength = 200;
            this.txtExFeedHis.Multiline = true;
            this.txtExFeedHis.Name = "txtExFeedHis";
            this.txtExFeedHis.Size = new System.Drawing.Size(431, 27);
            this.txtExFeedHis.TabIndex = 19;
            this.txtExFeedHis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExFeedHis_KeyPress);
            // 
            // chkPresentFeed
            // 
            this.chkPresentFeed.AutoSize = true;
            this.chkPresentFeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPresentFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPresentFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPresentFeed.ForeColor = System.Drawing.Color.Black;
            this.chkPresentFeed.Location = new System.Drawing.Point(6, 130);
            this.chkPresentFeed.Name = "chkPresentFeed";
            this.chkPresentFeed.Size = new System.Drawing.Size(131, 22);
            this.chkPresentFeed.TabIndex = 24;
            this.chkPresentFeed.Text = "Present Feeding";
            this.chkPresentFeed.UseVisualStyleBackColor = true;
            this.chkPresentFeed.CheckedChanged += new System.EventHandler(this.chkPresentFeed_CheckedChanged);
            // 
            // chkCompFeed
            // 
            this.chkCompFeed.AutoSize = true;
            this.chkCompFeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCompFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkCompFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCompFeed.ForeColor = System.Drawing.Color.Black;
            this.chkCompFeed.Location = new System.Drawing.Point(6, 81);
            this.chkCompFeed.Name = "chkCompFeed";
            this.chkCompFeed.Size = new System.Drawing.Size(276, 22);
            this.chkCompFeed.TabIndex = 22;
            this.chkCompFeed.Text = "Complimentary feeding starded at age ";
            this.chkCompFeed.UseVisualStyleBackColor = true;
            this.chkCompFeed.CheckedChanged += new System.EventHandler(this.chkCompFeed_CheckedChanged);
            // 
            // txtCompFeedHis1
            // 
            this.txtCompFeedHis1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompFeedHis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompFeedHis1.ForeColor = System.Drawing.Color.Black;
            this.txtCompFeedHis1.Location = new System.Drawing.Point(282, 79);
            this.txtCompFeedHis1.MaxLength = 20;
            this.txtCompFeedHis1.Multiline = true;
            this.txtCompFeedHis1.Name = "txtCompFeedHis1";
            this.txtCompFeedHis1.Size = new System.Drawing.Size(71, 27);
            this.txtCompFeedHis1.TabIndex = 21;
            this.txtCompFeedHis1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompFeedHis1_KeyPress);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.groupBox31);
            this.groupBox14.Controls.Add(this.groupBox15);
            this.groupBox14.Controls.Add(this.groupBox12);
            this.groupBox14.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox14.Location = new System.Drawing.Point(5, 4);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(1456, 140);
            this.groupBox14.TabIndex = 16;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Birth History ";
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.rdoPostNCom);
            this.groupBox31.Controls.Add(this.rdoPostNUn);
            this.groupBox31.Controls.Add(this.txtPostNatal);
            this.groupBox31.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox31.ForeColor = System.Drawing.Color.Black;
            this.groupBox31.Location = new System.Drawing.Point(972, 21);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new System.Drawing.Size(475, 111);
            this.groupBox31.TabIndex = 11;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "Post Natal ";
            // 
            // rdoPostNCom
            // 
            this.rdoPostNCom.AutoSize = true;
            this.rdoPostNCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPostNCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rdoPostNCom.Location = new System.Drawing.Point(6, 59);
            this.rdoPostNCom.Name = "rdoPostNCom";
            this.rdoPostNCom.Size = new System.Drawing.Size(112, 22);
            this.rdoPostNCom.TabIndex = 95;
            this.rdoPostNCom.TabStop = true;
            this.rdoPostNCom.Text = "Complication";
            this.rdoPostNCom.UseVisualStyleBackColor = true;
            // 
            // rdoPostNUn
            // 
            this.rdoPostNUn.AutoSize = true;
            this.rdoPostNUn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPostNUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rdoPostNUn.Location = new System.Drawing.Point(6, 25);
            this.rdoPostNUn.Name = "rdoPostNUn";
            this.rdoPostNUn.Size = new System.Drawing.Size(97, 22);
            this.rdoPostNUn.TabIndex = 94;
            this.rdoPostNUn.TabStop = true;
            this.rdoPostNUn.Text = "Uneventfull";
            this.rdoPostNUn.UseVisualStyleBackColor = true;
            // 
            // txtPostNatal
            // 
            this.txtPostNatal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostNatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostNatal.Location = new System.Drawing.Point(122, 19);
            this.txtPostNatal.MaxLength = 200;
            this.txtPostNatal.Multiline = true;
            this.txtPostNatal.Name = "txtPostNatal";
            this.txtPostNatal.Size = new System.Drawing.Size(345, 80);
            this.txtPostNatal.TabIndex = 5;
            this.txtPostNatal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostNatal_KeyPress);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.rdoNatalCS);
            this.groupBox15.Controls.Add(this.rdoNatalN);
            this.groupBox15.Controls.Add(this.txtNatal);
            this.groupBox15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox15.ForeColor = System.Drawing.Color.Black;
            this.groupBox15.Location = new System.Drawing.Point(488, 21);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(475, 111);
            this.groupBox15.TabIndex = 10;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Natal ";
            // 
            // rdoNatalCS
            // 
            this.rdoNatalCS.AutoSize = true;
            this.rdoNatalCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoNatalCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rdoNatalCS.Location = new System.Drawing.Point(15, 59);
            this.rdoNatalCS.Name = "rdoNatalCS";
            this.rdoNatalCS.Size = new System.Drawing.Size(50, 22);
            this.rdoNatalCS.TabIndex = 95;
            this.rdoNatalCS.TabStop = true;
            this.rdoNatalCS.Text = "C/S";
            this.rdoNatalCS.UseVisualStyleBackColor = true;
            // 
            // rdoNatalN
            // 
            this.rdoNatalN.AutoSize = true;
            this.rdoNatalN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoNatalN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rdoNatalN.Location = new System.Drawing.Point(15, 25);
            this.rdoNatalN.Name = "rdoNatalN";
            this.rdoNatalN.Size = new System.Drawing.Size(78, 22);
            this.rdoNatalN.TabIndex = 94;
            this.rdoNatalN.TabStop = true;
            this.rdoNatalN.Text = "Normal ";
            this.rdoNatalN.UseVisualStyleBackColor = true;
            // 
            // txtNatal
            // 
            this.txtNatal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNatal.Location = new System.Drawing.Point(122, 19);
            this.txtNatal.MaxLength = 200;
            this.txtNatal.Multiline = true;
            this.txtNatal.Name = "txtNatal";
            this.txtNatal.Size = new System.Drawing.Size(345, 80);
            this.txtNatal.TabIndex = 5;
            this.txtNatal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNatal_KeyPress);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.rdoAntenatalAbN);
            this.groupBox12.Controls.Add(this.rdoAntenatalN);
            this.groupBox12.Controls.Add(this.txtAntenatal);
            this.groupBox12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.ForeColor = System.Drawing.Color.Black;
            this.groupBox12.Location = new System.Drawing.Point(5, 21);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(475, 111);
            this.groupBox12.TabIndex = 9;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Antenatal ";
            // 
            // rdoAntenatalAbN
            // 
            this.rdoAntenatalAbN.AutoSize = true;
            this.rdoAntenatalAbN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAntenatalAbN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rdoAntenatalAbN.Location = new System.Drawing.Point(18, 59);
            this.rdoAntenatalAbN.Name = "rdoAntenatalAbN";
            this.rdoAntenatalAbN.Size = new System.Drawing.Size(92, 22);
            this.rdoAntenatalAbN.TabIndex = 93;
            this.rdoAntenatalAbN.TabStop = true;
            this.rdoAntenatalAbN.Text = "Abnormal ";
            this.rdoAntenatalAbN.UseVisualStyleBackColor = true;
            // 
            // rdoAntenatalN
            // 
            this.rdoAntenatalN.AutoSize = true;
            this.rdoAntenatalN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAntenatalN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rdoAntenatalN.Location = new System.Drawing.Point(18, 25);
            this.rdoAntenatalN.Name = "rdoAntenatalN";
            this.rdoAntenatalN.Size = new System.Drawing.Size(78, 22);
            this.rdoAntenatalN.TabIndex = 92;
            this.rdoAntenatalN.TabStop = true;
            this.rdoAntenatalN.Text = "Normal ";
            this.rdoAntenatalN.UseVisualStyleBackColor = true;
            // 
            // txtAntenatal
            // 
            this.txtAntenatal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAntenatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAntenatal.Location = new System.Drawing.Point(122, 19);
            this.txtAntenatal.MaxLength = 200;
            this.txtAntenatal.Multiline = true;
            this.txtAntenatal.Name = "txtAntenatal";
            this.txtAntenatal.Size = new System.Drawing.Size(345, 80);
            this.txtAntenatal.TabIndex = 3;
            this.txtAntenatal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAntenatal_KeyPress);
            // 
            // tbGynOBS
            // 
            this.tbGynOBS.BackColor = System.Drawing.Color.FloralWhite;
            this.tbGynOBS.Controls.Add(this.groupBox34);
            this.tbGynOBS.Controls.Add(this.groupBox35);
            this.tbGynOBS.Controls.Add(this.panel8);
            this.tbGynOBS.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGynOBS.Location = new System.Drawing.Point(4, 31);
            this.tbGynOBS.Name = "tbGynOBS";
            this.tbGynOBS.Size = new System.Drawing.Size(1466, 502);
            this.tbGynOBS.TabIndex = 4;
            this.tbGynOBS.Text = "Gyn-OBS";
            // 
            // groupBox34
            // 
            this.groupBox34.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox34.Controls.Add(this.txtObs);
            this.groupBox34.Controls.Add(this.chkObs);
            this.groupBox34.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox34.ForeColor = System.Drawing.Color.DarkViolet;
            this.groupBox34.Location = new System.Drawing.Point(740, 3);
            this.groupBox34.Name = "groupBox34";
            this.groupBox34.Size = new System.Drawing.Size(723, 496);
            this.groupBox34.TabIndex = 254;
            this.groupBox34.TabStop = false;
            this.groupBox34.Text = "Obstetric History";
            // 
            // txtObs
            // 
            this.txtObs.BackColor = System.Drawing.Color.White;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(11, 66);
            this.txtObs.MaxLength = 400;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObs.Size = new System.Drawing.Size(702, 424);
            this.txtObs.TabIndex = 248;
            this.txtObs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObs_KeyPress);
            // 
            // chkObs
            // 
            this.chkObs.AutoSize = true;
            this.chkObs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkObs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkObs.ForeColor = System.Drawing.Color.Black;
            this.chkObs.Location = new System.Drawing.Point(16, 30);
            this.chkObs.Name = "chkObs";
            this.chkObs.Size = new System.Drawing.Size(135, 22);
            this.chkObs.TabIndex = 247;
            this.chkObs.Text = "Obstetric History";
            this.chkObs.UseVisualStyleBackColor = true;
            this.chkObs.CheckedChanged += new System.EventHandler(this.chkObs_CheckedChanged);
            // 
            // groupBox35
            // 
            this.groupBox35.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox35.Controls.Add(this.chkGyn);
            this.groupBox35.Controls.Add(this.txtGyn);
            this.groupBox35.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox35.ForeColor = System.Drawing.Color.DarkViolet;
            this.groupBox35.Location = new System.Drawing.Point(4, 3);
            this.groupBox35.Name = "groupBox35";
            this.groupBox35.Size = new System.Drawing.Size(721, 496);
            this.groupBox35.TabIndex = 253;
            this.groupBox35.TabStop = false;
            this.groupBox35.Text = "Gynaecological History";
            // 
            // chkGyn
            // 
            this.chkGyn.AutoSize = true;
            this.chkGyn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkGyn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkGyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGyn.ForeColor = System.Drawing.Color.Black;
            this.chkGyn.Location = new System.Drawing.Point(13, 30);
            this.chkGyn.Name = "chkGyn";
            this.chkGyn.Size = new System.Drawing.Size(177, 22);
            this.chkGyn.TabIndex = 157;
            this.chkGyn.Text = "Gynaecological History";
            this.chkGyn.UseVisualStyleBackColor = true;
            this.chkGyn.CheckedChanged += new System.EventHandler(this.chkGyn_CheckedChanged);
            // 
            // txtGyn
            // 
            this.txtGyn.BackColor = System.Drawing.Color.White;
            this.txtGyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGyn.Location = new System.Drawing.Point(10, 66);
            this.txtGyn.MaxLength = 400;
            this.txtGyn.Multiline = true;
            this.txtGyn.Name = "txtGyn";
            this.txtGyn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGyn.Size = new System.Drawing.Size(702, 424);
            this.txtGyn.TabIndex = 144;
            this.txtGyn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGyn_KeyPress);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel8.Location = new System.Drawing.Point(731, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 504);
            this.panel8.TabIndex = 252;
            // 
            // smartTextBox19
            // 
            this.smartTextBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox19.Location = new System.Drawing.Point(400, 163);
            this.smartTextBox19.Multiline = true;
            this.smartTextBox19.Name = "smartTextBox19";
            this.smartTextBox19.Size = new System.Drawing.Size(60, 50);
            this.smartTextBox19.TabIndex = 108;
            // 
            // smartTextBox18
            // 
            this.smartTextBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox18.Location = new System.Drawing.Point(400, 98);
            this.smartTextBox18.Multiline = true;
            this.smartTextBox18.Name = "smartTextBox18";
            this.smartTextBox18.Size = new System.Drawing.Size(60, 50);
            this.smartTextBox18.TabIndex = 107;
            // 
            // smartTextBox17
            // 
            this.smartTextBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox17.Location = new System.Drawing.Point(400, 34);
            this.smartTextBox17.Multiline = true;
            this.smartTextBox17.Name = "smartTextBox17";
            this.smartTextBox17.Size = new System.Drawing.Size(60, 50);
            this.smartTextBox17.TabIndex = 106;
            // 
            // smartLabel49
            // 
            this.smartLabel49.AutoSize = true;
            this.smartLabel49.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel49.ForeColor = System.Drawing.Color.Black;
            this.smartLabel49.Location = new System.Drawing.Point(288, 181);
            this.smartLabel49.Name = "smartLabel49";
            this.smartLabel49.Size = new System.Drawing.Size(128, 18);
            this.smartLabel49.TabIndex = 105;
            this.smartLabel49.Text = "Age of last child";
            // 
            // smartLabel48
            // 
            this.smartLabel48.AutoSize = true;
            this.smartLabel48.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel48.ForeColor = System.Drawing.Color.Black;
            this.smartLabel48.Location = new System.Drawing.Point(288, 115);
            this.smartLabel48.Name = "smartLabel48";
            this.smartLabel48.Size = new System.Drawing.Size(43, 18);
            this.smartLabel48.TabIndex = 104;
            this.smartLabel48.Text = "Para";
            // 
            // smartLabel47
            // 
            this.smartLabel47.AutoSize = true;
            this.smartLabel47.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel47.ForeColor = System.Drawing.Color.Black;
            this.smartLabel47.Location = new System.Drawing.Point(288, 49);
            this.smartLabel47.Name = "smartLabel47";
            this.smartLabel47.Size = new System.Drawing.Size(96, 18);
            this.smartLabel47.TabIndex = 103;
            this.smartLabel47.Text = "Married for ";
            // 
            // smartTextBox21
            // 
            this.smartTextBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox21.Location = new System.Drawing.Point(223, 178);
            this.smartTextBox21.Multiline = true;
            this.smartTextBox21.Name = "smartTextBox21";
            this.smartTextBox21.Size = new System.Drawing.Size(35, 50);
            this.smartTextBox21.TabIndex = 252;
            // 
            // smartLabel56
            // 
            this.smartLabel56.AutoSize = true;
            this.smartLabel56.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel56.ForeColor = System.Drawing.Color.Black;
            this.smartLabel56.Location = new System.Drawing.Point(28, 196);
            this.smartLabel56.Name = "smartLabel56";
            this.smartLabel56.Size = new System.Drawing.Size(171, 18);
            this.smartLabel56.TabIndex = 251;
            this.smartLabel56.Text = "Contraceptive History";
            // 
            // smartTextBox20
            // 
            this.smartTextBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox20.Location = new System.Drawing.Point(223, 116);
            this.smartTextBox20.Multiline = true;
            this.smartTextBox20.Name = "smartTextBox20";
            this.smartTextBox20.Size = new System.Drawing.Size(35, 50);
            this.smartTextBox20.TabIndex = 250;
            // 
            // smartLabel55
            // 
            this.smartLabel55.AutoSize = true;
            this.smartLabel55.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel55.ForeColor = System.Drawing.Color.Black;
            this.smartLabel55.Location = new System.Drawing.Point(28, 133);
            this.smartLabel55.Name = "smartLabel55";
            this.smartLabel55.Size = new System.Drawing.Size(171, 18);
            this.smartLabel55.TabIndex = 249;
            this.smartLabel55.Text = "Last menstrual period";
            // 
            // groupBox37
            // 
            this.groupBox37.Controls.Add(this.smartTextBox16);
            this.groupBox37.Controls.Add(this.radioButton1);
            this.groupBox37.Controls.Add(this.radioButton2);
            this.groupBox37.Location = new System.Drawing.Point(223, 22);
            this.groupBox37.Name = "groupBox37";
            this.groupBox37.Size = new System.Drawing.Size(35, 92);
            this.groupBox37.TabIndex = 105;
            this.groupBox37.TabStop = false;
            // 
            // smartTextBox16
            // 
            this.smartTextBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox16.Location = new System.Drawing.Point(209, 25);
            this.smartTextBox16.Multiline = true;
            this.smartTextBox16.Name = "smartTextBox16";
            this.smartTextBox16.Size = new System.Drawing.Size(284, 50);
            this.smartTextBox16.TabIndex = 105;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(13, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 22);
            this.radioButton1.TabIndex = 103;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Regular";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(107, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 22);
            this.radioButton2.TabIndex = 104;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Irregular";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // smartLabel46
            // 
            this.smartLabel46.AutoSize = true;
            this.smartLabel46.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel46.ForeColor = System.Drawing.Color.Black;
            this.smartLabel46.Location = new System.Drawing.Point(28, 39);
            this.smartLabel46.Name = "smartLabel46";
            this.smartLabel46.Size = new System.Drawing.Size(200, 54);
            this.smartLabel46.TabIndex = 102;
            this.smartLabel46.Text = "Menstrual Period (M/P)\r\n--------------------------------\r\nMenstrual Cycle (M/C)";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(500, 781);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(59, 36);
            this.tabControl2.TabIndex = 218;
            this.tabControl2.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.OldLace;
            this.tabPage4.Controls.Add(this.groupBox9);
            this.tabPage4.Controls.Add(this.lvPatientsHistory);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(51, 10);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Health History";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cboFrequency);
            this.groupBox9.Controls.Add(this.txtFrequency);
            this.groupBox9.Controls.Add(this.smartLabel24);
            this.groupBox9.Controls.Add(this.txtOtherInfoOfDisease);
            this.groupBox9.Controls.Add(this.smartLabel38);
            this.groupBox9.Controls.Add(this.txtHDiagDate);
            this.groupBox9.Controls.Add(this.smartLabel37);
            this.groupBox9.Controls.Add(this.cboCaseID);
            this.groupBox9.Controls.Add(this.smartLabel17);
            this.groupBox9.Controls.Add(this.chkDiagHere);
            this.groupBox9.ForeColor = System.Drawing.Color.Black;
            this.groupBox9.Location = new System.Drawing.Point(5, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(810, 146);
            this.groupBox9.TabIndex = 120;
            this.groupBox9.TabStop = false;
            // 
            // cboFrequency
            // 
            this.cboFrequency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFrequency.ForeColor = System.Drawing.Color.Blue;
            this.cboFrequency.FormattingEnabled = true;
            this.cboFrequency.Items.AddRange(new object[] {
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.cboFrequency.Location = new System.Drawing.Point(405, 33);
            this.cboFrequency.Name = "cboFrequency";
            this.cboFrequency.Size = new System.Drawing.Size(88, 26);
            this.cboFrequency.TabIndex = 129;
            // 
            // txtFrequency
            // 
            this.txtFrequency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrequency.Location = new System.Drawing.Point(338, 34);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(66, 24);
            this.txtFrequency.TabIndex = 128;
            // 
            // smartLabel24
            // 
            this.smartLabel24.AutoSize = true;
            this.smartLabel24.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel24.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel24.Location = new System.Drawing.Point(6, 62);
            this.smartLabel24.Name = "smartLabel24";
            this.smartLabel24.Size = new System.Drawing.Size(206, 15);
            this.smartLabel24.TabIndex = 126;
            this.smartLabel24.Text = "Other information about this disease";
            // 
            // txtOtherInfoOfDisease
            // 
            this.txtOtherInfoOfDisease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtherInfoOfDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherInfoOfDisease.Location = new System.Drawing.Point(4, 81);
            this.txtOtherInfoOfDisease.Multiline = true;
            this.txtOtherInfoOfDisease.Name = "txtOtherInfoOfDisease";
            this.txtOtherInfoOfDisease.Size = new System.Drawing.Size(262, 54);
            this.txtOtherInfoOfDisease.TabIndex = 125;
            // 
            // smartLabel38
            // 
            this.smartLabel38.AutoSize = true;
            this.smartLabel38.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel38.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel38.Location = new System.Drawing.Point(340, 11);
            this.smartLabel38.Name = "smartLabel38";
            this.smartLabel38.Size = new System.Drawing.Size(67, 15);
            this.smartLabel38.TabIndex = 123;
            this.smartLabel38.Text = "Frequency ";
            // 
            // txtHDiagDate
            // 
            this.txtHDiagDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHDiagDate.Enabled = false;
            this.txtHDiagDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtHDiagDate.Location = new System.Drawing.Point(216, 33);
            this.txtHDiagDate.Mask = "00/00/0000";
            this.txtHDiagDate.Name = "txtHDiagDate";
            this.txtHDiagDate.Size = new System.Drawing.Size(88, 24);
            this.txtHDiagDate.TabIndex = 122;
            this.txtHDiagDate.ValidatingType = typeof(System.DateTime);
            // 
            // smartLabel37
            // 
            this.smartLabel37.AutoSize = true;
            this.smartLabel37.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel37.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel37.Location = new System.Drawing.Point(213, 8);
            this.smartLabel37.Name = "smartLabel37";
            this.smartLabel37.Size = new System.Drawing.Size(90, 15);
            this.smartLabel37.TabIndex = 120;
            this.smartLabel37.Text = "Diagnosis Date";
            // 
            // cboCaseID
            // 
            this.cboCaseID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCaseID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaseID.ForeColor = System.Drawing.Color.Blue;
            this.cboCaseID.FormattingEnabled = true;
            this.cboCaseID.Location = new System.Drawing.Point(5, 33);
            this.cboCaseID.Name = "cboCaseID";
            this.cboCaseID.Size = new System.Drawing.Size(205, 26);
            this.cboCaseID.TabIndex = 118;
            // 
            // smartLabel17
            // 
            this.smartLabel17.AutoSize = true;
            this.smartLabel17.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel17.Location = new System.Drawing.Point(8, 10);
            this.smartLabel17.Name = "smartLabel17";
            this.smartLabel17.Size = new System.Drawing.Size(84, 15);
            this.smartLabel17.TabIndex = 119;
            this.smartLabel17.Text = "Disease Name";
            // 
            // chkDiagHere
            // 
            this.chkDiagHere.AutoSize = true;
            this.chkDiagHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDiagHere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDiagHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDiagHere.ForeColor = System.Drawing.Color.Black;
            this.chkDiagHere.Location = new System.Drawing.Point(494, 35);
            this.chkDiagHere.Name = "chkDiagHere";
            this.chkDiagHere.Size = new System.Drawing.Size(126, 22);
            this.chkDiagHere.TabIndex = 124;
            this.chkDiagHere.Text = "Diagnosis Here";
            this.chkDiagHere.UseVisualStyleBackColor = true;
            // 
            // lvPatientsHistory
            // 
            this.lvPatientsHistory.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvPatientsHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvPatientsHistory.CheckBoxes = true;
            this.lvPatientsHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPatientsHistory.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPatientsHistory.FullRowSelect = true;
            this.lvPatientsHistory.GridLines = true;
            this.lvPatientsHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPatientsHistory.Location = new System.Drawing.Point(6, 155);
            this.lvPatientsHistory.Name = "lvPatientsHistory";
            this.lvPatientsHistory.Size = new System.Drawing.Size(777, 252);
            this.lvPatientsHistory.TabIndex = 121;
            this.lvPatientsHistory.UseCompatibleStateImageBehavior = false;
            this.lvPatientsHistory.View = System.Windows.Forms.View.Details;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage5.Controls.Add(this.groupBox10);
            this.tabPage5.Controls.Add(this.smartListViewDetails2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(51, 10);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Family History";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.smartComboBox5);
            this.groupBox10.Controls.Add(this.smartTextBox3);
            this.groupBox10.Controls.Add(this.smartLabel60);
            this.groupBox10.Controls.Add(this.smartLabel58);
            this.groupBox10.Controls.Add(this.smartNumericTextBox1);
            this.groupBox10.Controls.Add(this.smartComboBox7);
            this.groupBox10.Controls.Add(this.smartLabel57);
            this.groupBox10.Controls.Add(this.smartComboBox1);
            this.groupBox10.Controls.Add(this.smartLabel59);
            this.groupBox10.ForeColor = System.Drawing.Color.Black;
            this.groupBox10.Location = new System.Drawing.Point(4, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(778, 85);
            this.groupBox10.TabIndex = 122;
            this.groupBox10.TabStop = false;
            // 
            // smartComboBox5
            // 
            this.smartComboBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smartComboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartComboBox5.ForeColor = System.Drawing.Color.Blue;
            this.smartComboBox5.FormattingEnabled = true;
            this.smartComboBox5.Location = new System.Drawing.Point(258, 34);
            this.smartComboBox5.Name = "smartComboBox5";
            this.smartComboBox5.Size = new System.Drawing.Size(82, 26);
            this.smartComboBox5.TabIndex = 126;
            // 
            // smartTextBox3
            // 
            this.smartTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox3.Location = new System.Drawing.Point(505, 26);
            this.smartTextBox3.Multiline = true;
            this.smartTextBox3.Name = "smartTextBox3";
            this.smartTextBox3.Size = new System.Drawing.Size(247, 46);
            this.smartTextBox3.TabIndex = 125;
            // 
            // smartLabel60
            // 
            this.smartLabel60.AutoSize = true;
            this.smartLabel60.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel60.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel60.Location = new System.Drawing.Point(506, 6);
            this.smartLabel60.Name = "smartLabel60";
            this.smartLabel60.Size = new System.Drawing.Size(217, 15);
            this.smartLabel60.TabIndex = 124;
            this.smartLabel60.Text = "If Deceased, cause of Death And When ";
            // 
            // smartLabel58
            // 
            this.smartLabel58.AutoSize = true;
            this.smartLabel58.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel58.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel58.Location = new System.Drawing.Point(172, 13);
            this.smartLabel58.Name = "smartLabel58";
            this.smartLabel58.Size = new System.Drawing.Size(29, 15);
            this.smartLabel58.TabIndex = 123;
            this.smartLabel58.Text = "Age";
            // 
            // smartNumericTextBox1
            // 
            this.smartNumericTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartNumericTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartNumericTextBox1.Location = new System.Drawing.Point(175, 36);
            this.smartNumericTextBox1.Name = "smartNumericTextBox1";
            this.smartNumericTextBox1.Size = new System.Drawing.Size(81, 24);
            this.smartNumericTextBox1.TabIndex = 122;
            // 
            // smartComboBox7
            // 
            this.smartComboBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smartComboBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartComboBox7.ForeColor = System.Drawing.Color.Blue;
            this.smartComboBox7.FormattingEnabled = true;
            this.smartComboBox7.Location = new System.Drawing.Point(7, 34);
            this.smartComboBox7.Name = "smartComboBox7";
            this.smartComboBox7.Size = new System.Drawing.Size(157, 26);
            this.smartComboBox7.TabIndex = 120;
            // 
            // smartLabel57
            // 
            this.smartLabel57.AutoSize = true;
            this.smartLabel57.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel57.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel57.Location = new System.Drawing.Point(9, 14);
            this.smartLabel57.Name = "smartLabel57";
            this.smartLabel57.Size = new System.Drawing.Size(52, 15);
            this.smartLabel57.TabIndex = 121;
            this.smartLabel57.Text = "Member";
            // 
            // smartComboBox1
            // 
            this.smartComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smartComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartComboBox1.ForeColor = System.Drawing.Color.Blue;
            this.smartComboBox1.FormattingEnabled = true;
            this.smartComboBox1.Location = new System.Drawing.Point(342, 34);
            this.smartComboBox1.Name = "smartComboBox1";
            this.smartComboBox1.Size = new System.Drawing.Size(160, 26);
            this.smartComboBox1.TabIndex = 118;
            // 
            // smartLabel59
            // 
            this.smartLabel59.AutoSize = true;
            this.smartLabel59.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel59.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel59.Location = new System.Drawing.Point(345, 11);
            this.smartLabel59.Name = "smartLabel59";
            this.smartLabel59.Size = new System.Drawing.Size(84, 15);
            this.smartLabel59.TabIndex = 119;
            this.smartLabel59.Text = "Disease Name";
            // 
            // smartListViewDetails2
            // 
            this.smartListViewDetails2.BackColor = System.Drawing.Color.LemonChiffon;
            this.smartListViewDetails2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartListViewDetails2.CheckBoxes = true;
            this.smartListViewDetails2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartListViewDetails2.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartListViewDetails2.FullRowSelect = true;
            this.smartListViewDetails2.GridLines = true;
            this.smartListViewDetails2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.smartListViewDetails2.Location = new System.Drawing.Point(4, 108);
            this.smartListViewDetails2.Name = "smartListViewDetails2";
            this.smartListViewDetails2.Size = new System.Drawing.Size(776, 310);
            this.smartListViewDetails2.TabIndex = 123;
            this.smartListViewDetails2.UseCompatibleStateImageBehavior = false;
            this.smartListViewDetails2.View = System.Windows.Forms.View.Details;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.MintCream;
            this.tabPage6.Controls.Add(this.groupBox2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(51, 10);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Social History";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox18);
            this.groupBox2.Controls.Add(this.groupBox20);
            this.groupBox2.Controls.Add(this.groupBox19);
            this.groupBox2.Controls.Add(this.groupBox17);
            this.groupBox2.Controls.Add(this.groupBox16);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 246);
            this.groupBox2.TabIndex = 121;
            this.groupBox2.TabStop = false;
            // 
            // groupBox18
            // 
            this.groupBox18.BackColor = System.Drawing.Color.White;
            this.groupBox18.Controls.Add(this.smartLabel54);
            this.groupBox18.Controls.Add(this.smartCheckBox22);
            this.groupBox18.Controls.Add(this.smartCheckBox21);
            this.groupBox18.Controls.Add(this.smartCheckBox20);
            this.groupBox18.Controls.Add(this.smartCheckBox19);
            this.groupBox18.Controls.Add(this.smartCheckBox18);
            this.groupBox18.Location = new System.Drawing.Point(5, 191);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(794, 37);
            this.groupBox18.TabIndex = 124;
            this.groupBox18.TabStop = false;
            // 
            // smartLabel54
            // 
            this.smartLabel54.AutoSize = true;
            this.smartLabel54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel54.Location = new System.Drawing.Point(10, 11);
            this.smartLabel54.Name = "smartLabel54";
            this.smartLabel54.Size = new System.Drawing.Size(273, 15);
            this.smartLabel54.TabIndex = 4;
            this.smartLabel54.Text = "Excessive Exposure At Home or Work To :";
            // 
            // smartCheckBox22
            // 
            this.smartCheckBox22.AutoSize = true;
            this.smartCheckBox22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox22.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox22.Location = new System.Drawing.Point(694, 10);
            this.smartCheckBox22.Name = "smartCheckBox22";
            this.smartCheckBox22.Size = new System.Drawing.Size(86, 22);
            this.smartCheckBox22.TabIndex = 25;
            this.smartCheckBox22.Text = "Radiation";
            this.smartCheckBox22.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox21
            // 
            this.smartCheckBox21.AutoSize = true;
            this.smartCheckBox21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox21.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox21.Location = new System.Drawing.Point(284, 10);
            this.smartCheckBox21.Name = "smartCheckBox21";
            this.smartCheckBox21.Size = new System.Drawing.Size(74, 22);
            this.smartCheckBox21.TabIndex = 21;
            this.smartCheckBox21.Text = "Fumes ";
            this.smartCheckBox21.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox20
            // 
            this.smartCheckBox20.AutoSize = true;
            this.smartCheckBox20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox20.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox20.Location = new System.Drawing.Point(361, 10);
            this.smartCheckBox20.Name = "smartCheckBox20";
            this.smartCheckBox20.Size = new System.Drawing.Size(55, 22);
            this.smartCheckBox20.TabIndex = 22;
            this.smartCheckBox20.Text = "Dust";
            this.smartCheckBox20.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox19
            // 
            this.smartCheckBox19.AutoSize = true;
            this.smartCheckBox19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox19.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox19.Location = new System.Drawing.Point(446, 10);
            this.smartCheckBox19.Name = "smartCheckBox19";
            this.smartCheckBox19.Size = new System.Drawing.Size(81, 22);
            this.smartCheckBox19.TabIndex = 23;
            this.smartCheckBox19.Text = "Solvents";
            this.smartCheckBox19.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox18
            // 
            this.smartCheckBox18.AutoSize = true;
            this.smartCheckBox18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox18.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox18.Location = new System.Drawing.Point(546, 10);
            this.smartCheckBox18.Name = "smartCheckBox18";
            this.smartCheckBox18.Size = new System.Drawing.Size(140, 22);
            this.smartCheckBox18.TabIndex = 24;
            this.smartCheckBox18.Text = "Airborne Particles";
            this.smartCheckBox18.UseVisualStyleBackColor = true;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.smartCheckBox65);
            this.groupBox20.Controls.Add(this.smartLabel53);
            this.groupBox20.Controls.Add(this.smartCheckBox15);
            this.groupBox20.Controls.Add(this.smartCheckBox16);
            this.groupBox20.Controls.Add(this.smartCheckBox14);
            this.groupBox20.Controls.Add(this.smartCheckBox17);
            this.groupBox20.Location = new System.Drawing.Point(6, 142);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(794, 37);
            this.groupBox20.TabIndex = 125;
            this.groupBox20.TabStop = false;
            // 
            // smartCheckBox65
            // 
            this.smartCheckBox65.AutoSize = true;
            this.smartCheckBox65.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox65.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox65.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox65.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox65.Location = new System.Drawing.Point(546, 9);
            this.smartCheckBox65.Name = "smartCheckBox65";
            this.smartCheckBox65.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox65.TabIndex = 18;
            this.smartCheckBox65.Text = "frequently";
            this.smartCheckBox65.UseVisualStyleBackColor = true;
            // 
            // smartLabel53
            // 
            this.smartLabel53.AutoSize = true;
            this.smartLabel53.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel53.Location = new System.Drawing.Point(10, 13);
            this.smartLabel53.Name = "smartLabel53";
            this.smartLabel53.Size = new System.Drawing.Size(188, 15);
            this.smartLabel53.TabIndex = 3;
            this.smartLabel53.Text = "Use of Recreational Drugs : ";
            // 
            // smartCheckBox15
            // 
            this.smartCheckBox15.AutoSize = true;
            this.smartCheckBox15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox15.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox15.Location = new System.Drawing.Point(446, 9);
            this.smartCheckBox15.Name = "smartCheckBox15";
            this.smartCheckBox15.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox15.TabIndex = 19;
            this.smartCheckBox15.Text = "Moderate";
            this.smartCheckBox15.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox16
            // 
            this.smartCheckBox16.AutoSize = true;
            this.smartCheckBox16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox16.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox16.Location = new System.Drawing.Point(361, 9);
            this.smartCheckBox16.Name = "smartCheckBox16";
            this.smartCheckBox16.Size = new System.Drawing.Size(66, 22);
            this.smartCheckBox16.TabIndex = 18;
            this.smartCheckBox16.Text = "Rarely";
            this.smartCheckBox16.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox14
            // 
            this.smartCheckBox14.AutoSize = true;
            this.smartCheckBox14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox14.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox14.Location = new System.Drawing.Point(694, 6);
            this.smartCheckBox14.Name = "smartCheckBox14";
            this.smartCheckBox14.Size = new System.Drawing.Size(56, 22);
            this.smartCheckBox14.TabIndex = 20;
            this.smartCheckBox14.Text = "Daily";
            this.smartCheckBox14.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox17
            // 
            this.smartCheckBox17.AutoSize = true;
            this.smartCheckBox17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox17.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox17.Location = new System.Drawing.Point(283, 9);
            this.smartCheckBox17.Name = "smartCheckBox17";
            this.smartCheckBox17.Size = new System.Drawing.Size(67, 22);
            this.smartCheckBox17.TabIndex = 17;
            this.smartCheckBox17.Text = "Never ";
            this.smartCheckBox17.UseVisualStyleBackColor = true;
            // 
            // groupBox19
            // 
            this.groupBox19.BackColor = System.Drawing.Color.White;
            this.groupBox19.Controls.Add(this.smartCheckBox64);
            this.groupBox19.Controls.Add(this.smartLabel52);
            this.groupBox19.Controls.Add(this.smartCheckBox10);
            this.groupBox19.Controls.Add(this.smartCheckBox13);
            this.groupBox19.Controls.Add(this.smartCheckBox11);
            this.groupBox19.Controls.Add(this.smartCheckBox12);
            this.groupBox19.Location = new System.Drawing.Point(6, 99);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(794, 37);
            this.groupBox19.TabIndex = 125;
            this.groupBox19.TabStop = false;
            // 
            // smartCheckBox64
            // 
            this.smartCheckBox64.AutoSize = true;
            this.smartCheckBox64.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox64.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox64.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox64.Location = new System.Drawing.Point(546, 8);
            this.smartCheckBox64.Name = "smartCheckBox64";
            this.smartCheckBox64.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox64.TabIndex = 17;
            this.smartCheckBox64.Text = "frequently";
            this.smartCheckBox64.UseVisualStyleBackColor = true;
            // 
            // smartLabel52
            // 
            this.smartLabel52.AutoSize = true;
            this.smartLabel52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel52.Location = new System.Drawing.Point(10, 12);
            this.smartLabel52.Name = "smartLabel52";
            this.smartLabel52.Size = new System.Drawing.Size(114, 15);
            this.smartLabel52.TabIndex = 2;
            this.smartLabel52.Text = "Use of Tobacco :";
            // 
            // smartCheckBox10
            // 
            this.smartCheckBox10.AutoSize = true;
            this.smartCheckBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox10.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox10.Location = new System.Drawing.Point(694, 8);
            this.smartCheckBox10.Name = "smartCheckBox10";
            this.smartCheckBox10.Size = new System.Drawing.Size(56, 22);
            this.smartCheckBox10.TabIndex = 16;
            this.smartCheckBox10.Text = "Daily";
            this.smartCheckBox10.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox13
            // 
            this.smartCheckBox13.AutoSize = true;
            this.smartCheckBox13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox13.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox13.Location = new System.Drawing.Point(282, 9);
            this.smartCheckBox13.Name = "smartCheckBox13";
            this.smartCheckBox13.Size = new System.Drawing.Size(67, 22);
            this.smartCheckBox13.TabIndex = 13;
            this.smartCheckBox13.Text = "Never ";
            this.smartCheckBox13.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox11
            // 
            this.smartCheckBox11.AutoSize = true;
            this.smartCheckBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox11.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox11.Location = new System.Drawing.Point(446, 9);
            this.smartCheckBox11.Name = "smartCheckBox11";
            this.smartCheckBox11.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox11.TabIndex = 15;
            this.smartCheckBox11.Text = "Moderate";
            this.smartCheckBox11.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox12
            // 
            this.smartCheckBox12.AutoSize = true;
            this.smartCheckBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox12.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox12.Location = new System.Drawing.Point(361, 9);
            this.smartCheckBox12.Name = "smartCheckBox12";
            this.smartCheckBox12.Size = new System.Drawing.Size(66, 22);
            this.smartCheckBox12.TabIndex = 14;
            this.smartCheckBox12.Text = "Rarely";
            this.smartCheckBox12.UseVisualStyleBackColor = true;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.smartCheckBox1);
            this.groupBox17.Controls.Add(this.smartLabel51);
            this.groupBox17.Controls.Add(this.smartCheckBox9);
            this.groupBox17.Controls.Add(this.smartCheckBox8);
            this.groupBox17.Controls.Add(this.smartCheckBox6);
            this.groupBox17.Controls.Add(this.smartCheckBox7);
            this.groupBox17.Location = new System.Drawing.Point(6, 56);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(794, 37);
            this.groupBox17.TabIndex = 123;
            this.groupBox17.TabStop = false;
            // 
            // smartCheckBox1
            // 
            this.smartCheckBox1.AutoSize = true;
            this.smartCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox1.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox1.Location = new System.Drawing.Point(546, 8);
            this.smartCheckBox1.Name = "smartCheckBox1";
            this.smartCheckBox1.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox1.TabIndex = 13;
            this.smartCheckBox1.Text = "frequently";
            this.smartCheckBox1.UseVisualStyleBackColor = true;
            // 
            // smartLabel51
            // 
            this.smartLabel51.AutoSize = true;
            this.smartLabel51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel51.Location = new System.Drawing.Point(9, 12);
            this.smartLabel51.Name = "smartLabel51";
            this.smartLabel51.Size = new System.Drawing.Size(107, 15);
            this.smartLabel51.TabIndex = 1;
            this.smartLabel51.Text = "Use of Alcohol :";
            // 
            // smartCheckBox9
            // 
            this.smartCheckBox9.AutoSize = true;
            this.smartCheckBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox9.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox9.Location = new System.Drawing.Point(283, 9);
            this.smartCheckBox9.Name = "smartCheckBox9";
            this.smartCheckBox9.Size = new System.Drawing.Size(67, 22);
            this.smartCheckBox9.TabIndex = 9;
            this.smartCheckBox9.Text = "Never ";
            this.smartCheckBox9.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox8
            // 
            this.smartCheckBox8.AutoSize = true;
            this.smartCheckBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox8.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox8.Location = new System.Drawing.Point(361, 9);
            this.smartCheckBox8.Name = "smartCheckBox8";
            this.smartCheckBox8.Size = new System.Drawing.Size(66, 22);
            this.smartCheckBox8.TabIndex = 10;
            this.smartCheckBox8.Text = "Rarely";
            this.smartCheckBox8.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox6
            // 
            this.smartCheckBox6.AutoSize = true;
            this.smartCheckBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox6.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox6.Location = new System.Drawing.Point(694, 9);
            this.smartCheckBox6.Name = "smartCheckBox6";
            this.smartCheckBox6.Size = new System.Drawing.Size(56, 22);
            this.smartCheckBox6.TabIndex = 12;
            this.smartCheckBox6.Text = "Daily";
            this.smartCheckBox6.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox7
            // 
            this.smartCheckBox7.AutoSize = true;
            this.smartCheckBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox7.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox7.Location = new System.Drawing.Point(446, 9);
            this.smartCheckBox7.Name = "smartCheckBox7";
            this.smartCheckBox7.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox7.TabIndex = 11;
            this.smartCheckBox7.Text = "Moderate";
            this.smartCheckBox7.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.BackColor = System.Drawing.Color.White;
            this.groupBox16.Controls.Add(this.smartCheckBox63);
            this.groupBox16.Controls.Add(this.smartLabel50);
            this.groupBox16.Controls.Add(this.smartCheckBox4);
            this.groupBox16.Controls.Add(this.smartCheckBox3);
            this.groupBox16.Controls.Add(this.smartCheckBox5);
            this.groupBox16.Controls.Add(this.smartCheckBox2);
            this.groupBox16.Location = new System.Drawing.Point(6, 13);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(794, 37);
            this.groupBox16.TabIndex = 122;
            this.groupBox16.TabStop = false;
            // 
            // smartCheckBox63
            // 
            this.smartCheckBox63.AutoSize = true;
            this.smartCheckBox63.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox63.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox63.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox63.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox63.Location = new System.Drawing.Point(694, 9);
            this.smartCheckBox63.Name = "smartCheckBox63";
            this.smartCheckBox63.Size = new System.Drawing.Size(91, 22);
            this.smartCheckBox63.TabIndex = 26;
            this.smartCheckBox63.Text = "Separated";
            this.smartCheckBox63.UseVisualStyleBackColor = true;
            // 
            // smartLabel50
            // 
            this.smartLabel50.AutoSize = true;
            this.smartLabel50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel50.Location = new System.Drawing.Point(9, 13);
            this.smartLabel50.Name = "smartLabel50";
            this.smartLabel50.Size = new System.Drawing.Size(108, 15);
            this.smartLabel50.TabIndex = 0;
            this.smartLabel50.Text = "Marital Status : ";
            // 
            // smartCheckBox4
            // 
            this.smartCheckBox4.AutoSize = true;
            this.smartCheckBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox4.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox4.Location = new System.Drawing.Point(446, 9);
            this.smartCheckBox4.Name = "smartCheckBox4";
            this.smartCheckBox4.Size = new System.Drawing.Size(83, 22);
            this.smartCheckBox4.TabIndex = 7;
            this.smartCheckBox4.Text = "Divorced";
            this.smartCheckBox4.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox3
            // 
            this.smartCheckBox3.AutoSize = true;
            this.smartCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox3.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox3.Location = new System.Drawing.Point(361, 9);
            this.smartCheckBox3.Name = "smartCheckBox3";
            this.smartCheckBox3.Size = new System.Drawing.Size(74, 22);
            this.smartCheckBox3.TabIndex = 6;
            this.smartCheckBox3.Text = "Married";
            this.smartCheckBox3.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox5
            // 
            this.smartCheckBox5.AutoSize = true;
            this.smartCheckBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox5.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox5.Location = new System.Drawing.Point(546, 9);
            this.smartCheckBox5.Name = "smartCheckBox5";
            this.smartCheckBox5.Size = new System.Drawing.Size(86, 22);
            this.smartCheckBox5.TabIndex = 8;
            this.smartCheckBox5.Text = "Widowed";
            this.smartCheckBox5.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox2
            // 
            this.smartCheckBox2.AutoSize = true;
            this.smartCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox2.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox2.Location = new System.Drawing.Point(283, 9);
            this.smartCheckBox2.Name = "smartCheckBox2";
            this.smartCheckBox2.Size = new System.Drawing.Size(64, 22);
            this.smartCheckBox2.TabIndex = 5;
            this.smartCheckBox2.Text = "Single";
            this.smartCheckBox2.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.Azure;
            this.tabPage8.Controls.Add(this.smartListViewDetails3);
            this.tabPage8.Controls.Add(this.groupBox3);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(51, 10);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Drug History";
            // 
            // smartListViewDetails3
            // 
            this.smartListViewDetails3.BackColor = System.Drawing.Color.LemonChiffon;
            this.smartListViewDetails3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartListViewDetails3.CheckBoxes = true;
            this.smartListViewDetails3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartListViewDetails3.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartListViewDetails3.FullRowSelect = true;
            this.smartListViewDetails3.GridLines = true;
            this.smartListViewDetails3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.smartListViewDetails3.Location = new System.Drawing.Point(6, 98);
            this.smartListViewDetails3.Name = "smartListViewDetails3";
            this.smartListViewDetails3.Size = new System.Drawing.Size(776, 290);
            this.smartListViewDetails3.TabIndex = 124;
            this.smartListViewDetails3.UseCompatibleStateImageBehavior = false;
            this.smartListViewDetails3.View = System.Windows.Forms.View.Details;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.smartComboBox2);
            this.groupBox3.Controls.Add(this.smartTextBox4);
            this.groupBox3.Controls.Add(this.smartTextBox1);
            this.groupBox3.Controls.Add(this.smartLabel18);
            this.groupBox3.Controls.Add(this.smartLabel19);
            this.groupBox3.Controls.Add(this.smartNumericTextBox2);
            this.groupBox3.Controls.Add(this.smartLabel20);
            this.groupBox3.Controls.Add(this.smartComboBox3);
            this.groupBox3.Controls.Add(this.smartLabel21);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(5, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(777, 89);
            this.groupBox3.TabIndex = 123;
            this.groupBox3.TabStop = false;
            // 
            // smartComboBox2
            // 
            this.smartComboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smartComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartComboBox2.ForeColor = System.Drawing.Color.Blue;
            this.smartComboBox2.FormattingEnabled = true;
            this.smartComboBox2.Items.AddRange(new object[] {
            "Days",
            "Months",
            "Years"});
            this.smartComboBox2.Location = new System.Drawing.Point(162, 55);
            this.smartComboBox2.Name = "smartComboBox2";
            this.smartComboBox2.Size = new System.Drawing.Size(69, 26);
            this.smartComboBox2.TabIndex = 127;
            // 
            // smartTextBox4
            // 
            this.smartTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox4.Location = new System.Drawing.Point(6, 27);
            this.smartTextBox4.Name = "smartTextBox4";
            this.smartTextBox4.Size = new System.Drawing.Size(150, 24);
            this.smartTextBox4.TabIndex = 126;
            // 
            // smartTextBox1
            // 
            this.smartTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox1.Location = new System.Drawing.Point(382, 30);
            this.smartTextBox1.Multiline = true;
            this.smartTextBox1.Name = "smartTextBox1";
            this.smartTextBox1.Size = new System.Drawing.Size(374, 53);
            this.smartTextBox1.TabIndex = 125;
            // 
            // smartLabel18
            // 
            this.smartLabel18.AutoSize = true;
            this.smartLabel18.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel18.Location = new System.Drawing.Point(382, 8);
            this.smartLabel18.Name = "smartLabel18";
            this.smartLabel18.Size = new System.Drawing.Size(344, 15);
            this.smartLabel18.TabIndex = 124;
            this.smartLabel18.Text = "Any reaction after taking this drug? If, yes  please give details";
            // 
            // smartLabel19
            // 
            this.smartLabel19.AutoSize = true;
            this.smartLabel19.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel19.Location = new System.Drawing.Point(160, 8);
            this.smartLabel19.Name = "smartLabel19";
            this.smartLabel19.Size = new System.Drawing.Size(71, 15);
            this.smartLabel19.TabIndex = 123;
            this.smartLabel19.Text = "How Long ?";
            // 
            // smartNumericTextBox2
            // 
            this.smartNumericTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartNumericTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartNumericTextBox2.Location = new System.Drawing.Point(162, 27);
            this.smartNumericTextBox2.Name = "smartNumericTextBox2";
            this.smartNumericTextBox2.Size = new System.Drawing.Size(70, 24);
            this.smartNumericTextBox2.TabIndex = 122;
            // 
            // smartLabel20
            // 
            this.smartLabel20.AutoSize = true;
            this.smartLabel20.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel20.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel20.Location = new System.Drawing.Point(8, 5);
            this.smartLabel20.Name = "smartLabel20";
            this.smartLabel20.Size = new System.Drawing.Size(70, 15);
            this.smartLabel20.TabIndex = 121;
            this.smartLabel20.Text = "Drug Name";
            // 
            // smartComboBox3
            // 
            this.smartComboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smartComboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartComboBox3.ForeColor = System.Drawing.Color.Blue;
            this.smartComboBox3.FormattingEnabled = true;
            this.smartComboBox3.Location = new System.Drawing.Point(237, 28);
            this.smartComboBox3.Name = "smartComboBox3";
            this.smartComboBox3.Size = new System.Drawing.Size(139, 26);
            this.smartComboBox3.TabIndex = 118;
            // 
            // smartLabel21
            // 
            this.smartLabel21.AutoSize = true;
            this.smartLabel21.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel21.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel21.Location = new System.Drawing.Point(240, 7);
            this.smartLabel21.Name = "smartLabel21";
            this.smartLabel21.Size = new System.Drawing.Size(122, 15);
            this.smartLabel21.TabIndex = 119;
            this.smartLabel21.Text = "For Which Disease ?";
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.Linen;
            this.tabPage9.Controls.Add(this.panel13);
            this.tabPage9.Controls.Add(this.groupBox4);
            this.tabPage9.Controls.Add(this.groupBox5);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(51, 10);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "Other History";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel13.Location = new System.Drawing.Point(2, 281);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(810, 4);
            this.panel13.TabIndex = 245;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox30);
            this.groupBox4.Controls.Add(this.groupBox29);
            this.groupBox4.Controls.Add(this.groupBox28);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(6, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(817, 126);
            this.groupBox4.TabIndex = 126;
            this.groupBox4.TabStop = false;
            // 
            // groupBox30
            // 
            this.groupBox30.BackColor = System.Drawing.Color.White;
            this.groupBox30.Controls.Add(this.smartLabel32);
            this.groupBox30.Controls.Add(this.smartCheckBox62);
            this.groupBox30.Controls.Add(this.smartCheckBox61);
            this.groupBox30.Controls.Add(this.smartCheckBox59);
            this.groupBox30.Controls.Add(this.smartCheckBox60);
            this.groupBox30.Location = new System.Drawing.Point(7, 84);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(799, 33);
            this.groupBox30.TabIndex = 132;
            this.groupBox30.TabStop = false;
            // 
            // smartLabel32
            // 
            this.smartLabel32.AutoSize = true;
            this.smartLabel32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel32.Location = new System.Drawing.Point(10, 11);
            this.smartLabel32.Name = "smartLabel32";
            this.smartLabel32.Size = new System.Drawing.Size(221, 15);
            this.smartLabel32.TabIndex = 5;
            this.smartLabel32.Text = "Your overall physical well being ?";
            // 
            // smartCheckBox62
            // 
            this.smartCheckBox62.AutoSize = true;
            this.smartCheckBox62.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox62.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox62.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox62.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox62.Location = new System.Drawing.Point(397, 7);
            this.smartCheckBox62.Name = "smartCheckBox62";
            this.smartCheckBox62.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox62.TabIndex = 50;
            this.smartCheckBox62.Text = "Moderate";
            this.smartCheckBox62.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox61
            // 
            this.smartCheckBox61.AutoSize = true;
            this.smartCheckBox61.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox61.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox61.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox61.Location = new System.Drawing.Point(556, 7);
            this.smartCheckBox61.Name = "smartCheckBox61";
            this.smartCheckBox61.Size = new System.Drawing.Size(62, 22);
            this.smartCheckBox61.TabIndex = 49;
            this.smartCheckBox61.Text = "Good";
            this.smartCheckBox61.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox59
            // 
            this.smartCheckBox59.AutoSize = true;
            this.smartCheckBox59.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox59.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox59.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox59.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox59.Location = new System.Drawing.Point(257, 7);
            this.smartCheckBox59.Name = "smartCheckBox59";
            this.smartCheckBox59.Size = new System.Drawing.Size(50, 22);
            this.smartCheckBox59.TabIndex = 48;
            this.smartCheckBox59.Text = "Bad";
            this.smartCheckBox59.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox60
            // 
            this.smartCheckBox60.AutoSize = true;
            this.smartCheckBox60.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox60.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox60.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox60.Location = new System.Drawing.Point(699, 7);
            this.smartCheckBox60.Name = "smartCheckBox60";
            this.smartCheckBox60.Size = new System.Drawing.Size(63, 22);
            this.smartCheckBox60.TabIndex = 51;
            this.smartCheckBox60.Text = "Better";
            this.smartCheckBox60.UseVisualStyleBackColor = true;
            // 
            // groupBox29
            // 
            this.groupBox29.BackColor = System.Drawing.Color.White;
            this.groupBox29.Controls.Add(this.smartLabel25);
            this.groupBox29.Controls.Add(this.smartCheckBox54);
            this.groupBox29.Controls.Add(this.smartCheckBox53);
            this.groupBox29.Controls.Add(this.smartCheckBox52);
            this.groupBox29.Controls.Add(this.smartCheckBox51);
            this.groupBox29.Location = new System.Drawing.Point(7, 14);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(799, 33);
            this.groupBox29.TabIndex = 131;
            this.groupBox29.TabStop = false;
            // 
            // smartLabel25
            // 
            this.smartLabel25.AutoSize = true;
            this.smartLabel25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel25.Location = new System.Drawing.Point(6, 10);
            this.smartLabel25.Name = "smartLabel25";
            this.smartLabel25.Size = new System.Drawing.Size(181, 15);
            this.smartLabel25.TabIndex = 3;
            this.smartLabel25.Text = "Your overall quality of life ?";
            // 
            // smartCheckBox54
            // 
            this.smartCheckBox54.AutoSize = true;
            this.smartCheckBox54.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox54.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox54.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox54.Location = new System.Drawing.Point(397, 8);
            this.smartCheckBox54.Name = "smartCheckBox54";
            this.smartCheckBox54.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox54.TabIndex = 42;
            this.smartCheckBox54.Text = "Moderate";
            this.smartCheckBox54.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox53
            // 
            this.smartCheckBox53.AutoSize = true;
            this.smartCheckBox53.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox53.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox53.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox53.Location = new System.Drawing.Point(556, 8);
            this.smartCheckBox53.Name = "smartCheckBox53";
            this.smartCheckBox53.Size = new System.Drawing.Size(62, 22);
            this.smartCheckBox53.TabIndex = 41;
            this.smartCheckBox53.Text = "Good";
            this.smartCheckBox53.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox52
            // 
            this.smartCheckBox52.AutoSize = true;
            this.smartCheckBox52.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox52.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox52.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox52.Location = new System.Drawing.Point(699, 8);
            this.smartCheckBox52.Name = "smartCheckBox52";
            this.smartCheckBox52.Size = new System.Drawing.Size(63, 22);
            this.smartCheckBox52.TabIndex = 43;
            this.smartCheckBox52.Text = "Better";
            this.smartCheckBox52.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox51
            // 
            this.smartCheckBox51.AutoSize = true;
            this.smartCheckBox51.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox51.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox51.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox51.Location = new System.Drawing.Point(257, 8);
            this.smartCheckBox51.Name = "smartCheckBox51";
            this.smartCheckBox51.Size = new System.Drawing.Size(50, 22);
            this.smartCheckBox51.TabIndex = 40;
            this.smartCheckBox51.Text = "Bad";
            this.smartCheckBox51.UseVisualStyleBackColor = true;
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.smartLabel31);
            this.groupBox28.Controls.Add(this.smartCheckBox58);
            this.groupBox28.Controls.Add(this.smartCheckBox57);
            this.groupBox28.Controls.Add(this.smartCheckBox56);
            this.groupBox28.Controls.Add(this.smartCheckBox55);
            this.groupBox28.Location = new System.Drawing.Point(7, 45);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(799, 33);
            this.groupBox28.TabIndex = 130;
            this.groupBox28.TabStop = false;
            // 
            // smartLabel31
            // 
            this.smartLabel31.AutoSize = true;
            this.smartLabel31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel31.Location = new System.Drawing.Point(8, 11);
            this.smartLabel31.Name = "smartLabel31";
            this.smartLabel31.Size = new System.Drawing.Size(233, 15);
            this.smartLabel31.TabIndex = 4;
            this.smartLabel31.Text = "Your overall emotional well being ?";
            // 
            // smartCheckBox58
            // 
            this.smartCheckBox58.AutoSize = true;
            this.smartCheckBox58.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox58.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox58.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox58.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox58.Location = new System.Drawing.Point(397, 8);
            this.smartCheckBox58.Name = "smartCheckBox58";
            this.smartCheckBox58.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox58.TabIndex = 46;
            this.smartCheckBox58.Text = "Moderate";
            this.smartCheckBox58.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox57
            // 
            this.smartCheckBox57.AutoSize = true;
            this.smartCheckBox57.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox57.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox57.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox57.Location = new System.Drawing.Point(556, 8);
            this.smartCheckBox57.Name = "smartCheckBox57";
            this.smartCheckBox57.Size = new System.Drawing.Size(62, 22);
            this.smartCheckBox57.TabIndex = 45;
            this.smartCheckBox57.Text = "Good";
            this.smartCheckBox57.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox56
            // 
            this.smartCheckBox56.AutoSize = true;
            this.smartCheckBox56.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox56.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox56.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox56.Location = new System.Drawing.Point(699, 8);
            this.smartCheckBox56.Name = "smartCheckBox56";
            this.smartCheckBox56.Size = new System.Drawing.Size(63, 22);
            this.smartCheckBox56.TabIndex = 47;
            this.smartCheckBox56.Text = "Better";
            this.smartCheckBox56.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox55
            // 
            this.smartCheckBox55.AutoSize = true;
            this.smartCheckBox55.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox55.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox55.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox55.Location = new System.Drawing.Point(257, 8);
            this.smartCheckBox55.Name = "smartCheckBox55";
            this.smartCheckBox55.Size = new System.Drawing.Size(50, 22);
            this.smartCheckBox55.TabIndex = 44;
            this.smartCheckBox55.Text = "Bad";
            this.smartCheckBox55.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox27);
            this.groupBox5.Controls.Add(this.groupBox24);
            this.groupBox5.Controls.Add(this.groupBox26);
            this.groupBox5.Controls.Add(this.groupBox25);
            this.groupBox5.Controls.Add(this.groupBox23);
            this.groupBox5.Controls.Add(this.groupBox22);
            this.groupBox5.Controls.Add(this.groupBox21);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(5, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(818, 278);
            this.groupBox5.TabIndex = 125;
            this.groupBox5.TabStop = false;
            // 
            // groupBox27
            // 
            this.groupBox27.BackColor = System.Drawing.Color.White;
            this.groupBox27.Controls.Add(this.smartLabel23);
            this.groupBox27.Controls.Add(this.smartCheckBox50);
            this.groupBox27.Controls.Add(this.smartCheckBox49);
            this.groupBox27.Controls.Add(this.smartCheckBox48);
            this.groupBox27.Controls.Add(this.smartCheckBox47);
            this.groupBox27.Location = new System.Drawing.Point(7, 235);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(799, 33);
            this.groupBox27.TabIndex = 130;
            this.groupBox27.TabStop = false;
            // 
            // smartLabel23
            // 
            this.smartLabel23.AutoSize = true;
            this.smartLabel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel23.Location = new System.Drawing.Point(6, 12);
            this.smartLabel23.Name = "smartLabel23";
            this.smartLabel23.Size = new System.Drawing.Size(109, 15);
            this.smartLabel23.TabIndex = 27;
            this.smartLabel23.Text = "Mood Disorders";
            // 
            // smartCheckBox50
            // 
            this.smartCheckBox50.AutoSize = true;
            this.smartCheckBox50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox50.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox50.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox50.Location = new System.Drawing.Point(556, 7);
            this.smartCheckBox50.Name = "smartCheckBox50";
            this.smartCheckBox50.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox50.TabIndex = 38;
            this.smartCheckBox50.Text = "Moderate";
            this.smartCheckBox50.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox49
            // 
            this.smartCheckBox49.AutoSize = true;
            this.smartCheckBox49.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox49.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox49.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox49.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox49.Location = new System.Drawing.Point(397, 7);
            this.smartCheckBox49.Name = "smartCheckBox49";
            this.smartCheckBox49.Size = new System.Drawing.Size(66, 22);
            this.smartCheckBox49.TabIndex = 37;
            this.smartCheckBox49.Text = "Rarely";
            this.smartCheckBox49.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox48
            // 
            this.smartCheckBox48.AutoSize = true;
            this.smartCheckBox48.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox48.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox48.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox48.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox48.Location = new System.Drawing.Point(699, 7);
            this.smartCheckBox48.Name = "smartCheckBox48";
            this.smartCheckBox48.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox48.TabIndex = 39;
            this.smartCheckBox48.Text = "frequently";
            this.smartCheckBox48.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox47
            // 
            this.smartCheckBox47.AutoSize = true;
            this.smartCheckBox47.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox47.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox47.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox47.Location = new System.Drawing.Point(257, 7);
            this.smartCheckBox47.Name = "smartCheckBox47";
            this.smartCheckBox47.Size = new System.Drawing.Size(67, 22);
            this.smartCheckBox47.TabIndex = 36;
            this.smartCheckBox47.Text = "Never ";
            this.smartCheckBox47.UseVisualStyleBackColor = true;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.smartLabel22);
            this.groupBox24.Controls.Add(this.smartCheckBox46);
            this.groupBox24.Controls.Add(this.smartCheckBox45);
            this.groupBox24.Controls.Add(this.smartCheckBox44);
            this.groupBox24.Controls.Add(this.smartCheckBox35);
            this.groupBox24.Location = new System.Drawing.Point(7, 196);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(799, 33);
            this.groupBox24.TabIndex = 129;
            this.groupBox24.TabStop = false;
            // 
            // smartLabel22
            // 
            this.smartLabel22.AutoSize = true;
            this.smartLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel22.Location = new System.Drawing.Point(9, 13);
            this.smartLabel22.Name = "smartLabel22";
            this.smartLabel22.Size = new System.Drawing.Size(133, 15);
            this.smartLabel22.TabIndex = 26;
            this.smartLabel22.Text = "Behavioral Problem";
            // 
            // smartCheckBox46
            // 
            this.smartCheckBox46.AutoSize = true;
            this.smartCheckBox46.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox46.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox46.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox46.Location = new System.Drawing.Point(556, 6);
            this.smartCheckBox46.Name = "smartCheckBox46";
            this.smartCheckBox46.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox46.TabIndex = 34;
            this.smartCheckBox46.Text = "Moderate";
            this.smartCheckBox46.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox45
            // 
            this.smartCheckBox45.AutoSize = true;
            this.smartCheckBox45.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox45.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox45.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox45.Location = new System.Drawing.Point(397, 6);
            this.smartCheckBox45.Name = "smartCheckBox45";
            this.smartCheckBox45.Size = new System.Drawing.Size(66, 22);
            this.smartCheckBox45.TabIndex = 33;
            this.smartCheckBox45.Text = "Rarely";
            this.smartCheckBox45.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox44
            // 
            this.smartCheckBox44.AutoSize = true;
            this.smartCheckBox44.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox44.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox44.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox44.Location = new System.Drawing.Point(699, 6);
            this.smartCheckBox44.Name = "smartCheckBox44";
            this.smartCheckBox44.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox44.TabIndex = 35;
            this.smartCheckBox44.Text = "frequently";
            this.smartCheckBox44.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox35
            // 
            this.smartCheckBox35.AutoSize = true;
            this.smartCheckBox35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox35.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox35.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox35.Location = new System.Drawing.Point(257, 6);
            this.smartCheckBox35.Name = "smartCheckBox35";
            this.smartCheckBox35.Size = new System.Drawing.Size(67, 22);
            this.smartCheckBox35.TabIndex = 32;
            this.smartCheckBox35.Text = "Never ";
            this.smartCheckBox35.UseVisualStyleBackColor = true;
            // 
            // groupBox26
            // 
            this.groupBox26.BackColor = System.Drawing.Color.White;
            this.groupBox26.Controls.Add(this.smartLabel30);
            this.groupBox26.Controls.Add(this.smartCheckBox32);
            this.groupBox26.Controls.Add(this.smartCheckBox29);
            this.groupBox26.Controls.Add(this.smartCheckBox26);
            this.groupBox26.Controls.Add(this.smartCheckBox23);
            this.groupBox26.Location = new System.Drawing.Point(7, 159);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(799, 33);
            this.groupBox26.TabIndex = 130;
            this.groupBox26.TabStop = false;
            // 
            // smartLabel30
            // 
            this.smartLabel30.AutoSize = true;
            this.smartLabel30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel30.Location = new System.Drawing.Point(8, 11);
            this.smartLabel30.Name = "smartLabel30";
            this.smartLabel30.Size = new System.Drawing.Size(109, 15);
            this.smartLabel30.TabIndex = 4;
            this.smartLabel30.Text = "Mental Problem";
            // 
            // smartCheckBox32
            // 
            this.smartCheckBox32.AutoSize = true;
            this.smartCheckBox32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox32.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox32.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox32.Location = new System.Drawing.Point(556, 7);
            this.smartCheckBox32.Name = "smartCheckBox32";
            this.smartCheckBox32.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox32.TabIndex = 30;
            this.smartCheckBox32.Text = "Moderate";
            this.smartCheckBox32.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox29
            // 
            this.smartCheckBox29.AutoSize = true;
            this.smartCheckBox29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox29.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox29.Location = new System.Drawing.Point(397, 6);
            this.smartCheckBox29.Name = "smartCheckBox29";
            this.smartCheckBox29.Size = new System.Drawing.Size(66, 22);
            this.smartCheckBox29.TabIndex = 29;
            this.smartCheckBox29.Text = "Rarely";
            this.smartCheckBox29.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox26
            // 
            this.smartCheckBox26.AutoSize = true;
            this.smartCheckBox26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox26.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox26.Location = new System.Drawing.Point(699, 7);
            this.smartCheckBox26.Name = "smartCheckBox26";
            this.smartCheckBox26.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox26.TabIndex = 31;
            this.smartCheckBox26.Text = "frequently";
            this.smartCheckBox26.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox23
            // 
            this.smartCheckBox23.AutoSize = true;
            this.smartCheckBox23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox23.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox23.Location = new System.Drawing.Point(257, 7);
            this.smartCheckBox23.Name = "smartCheckBox23";
            this.smartCheckBox23.Size = new System.Drawing.Size(67, 22);
            this.smartCheckBox23.TabIndex = 28;
            this.smartCheckBox23.Text = "Never ";
            this.smartCheckBox23.UseVisualStyleBackColor = true;
            // 
            // groupBox25
            // 
            this.groupBox25.BackColor = System.Drawing.Color.White;
            this.groupBox25.Controls.Add(this.smartLabel28);
            this.groupBox25.Controls.Add(this.smartCheckBox33);
            this.groupBox25.Controls.Add(this.smartCheckBox30);
            this.groupBox25.Controls.Add(this.smartCheckBox27);
            this.groupBox25.Controls.Add(this.smartCheckBox24);
            this.groupBox25.Location = new System.Drawing.Point(7, 84);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(799, 33);
            this.groupBox25.TabIndex = 130;
            this.groupBox25.TabStop = false;
            // 
            // smartLabel28
            // 
            this.smartLabel28.AutoSize = true;
            this.smartLabel28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel28.Location = new System.Drawing.Point(6, 9);
            this.smartLabel28.Name = "smartLabel28";
            this.smartLabel28.Size = new System.Drawing.Size(109, 15);
            this.smartLabel28.TabIndex = 2;
            this.smartLabel28.Text = "Temper Change";
            // 
            // smartCheckBox33
            // 
            this.smartCheckBox33.AutoSize = true;
            this.smartCheckBox33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox33.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox33.Location = new System.Drawing.Point(699, 8);
            this.smartCheckBox33.Name = "smartCheckBox33";
            this.smartCheckBox33.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox33.TabIndex = 16;
            this.smartCheckBox33.Text = "frequently";
            this.smartCheckBox33.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox30
            // 
            this.smartCheckBox30.AutoSize = true;
            this.smartCheckBox30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox30.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox30.Location = new System.Drawing.Point(556, 8);
            this.smartCheckBox30.Name = "smartCheckBox30";
            this.smartCheckBox30.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox30.TabIndex = 15;
            this.smartCheckBox30.Text = "Moderate";
            this.smartCheckBox30.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox27
            // 
            this.smartCheckBox27.AutoSize = true;
            this.smartCheckBox27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox27.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox27.Location = new System.Drawing.Point(397, 8);
            this.smartCheckBox27.Name = "smartCheckBox27";
            this.smartCheckBox27.Size = new System.Drawing.Size(66, 22);
            this.smartCheckBox27.TabIndex = 14;
            this.smartCheckBox27.Text = "Rarely";
            this.smartCheckBox27.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox24
            // 
            this.smartCheckBox24.AutoSize = true;
            this.smartCheckBox24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox24.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox24.Location = new System.Drawing.Point(257, 8);
            this.smartCheckBox24.Name = "smartCheckBox24";
            this.smartCheckBox24.Size = new System.Drawing.Size(67, 22);
            this.smartCheckBox24.TabIndex = 13;
            this.smartCheckBox24.Text = "Never ";
            this.smartCheckBox24.UseVisualStyleBackColor = true;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.smartLabel29);
            this.groupBox23.Controls.Add(this.smartCheckBox43);
            this.groupBox23.Controls.Add(this.smartCheckBox40);
            this.groupBox23.Controls.Add(this.smartCheckBox39);
            this.groupBox23.Controls.Add(this.smartCheckBox36);
            this.groupBox23.Location = new System.Drawing.Point(7, 121);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(799, 33);
            this.groupBox23.TabIndex = 128;
            this.groupBox23.TabStop = false;
            // 
            // smartLabel29
            // 
            this.smartLabel29.AutoSize = true;
            this.smartLabel29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel29.Location = new System.Drawing.Point(4, 11);
            this.smartLabel29.Name = "smartLabel29";
            this.smartLabel29.Size = new System.Drawing.Size(104, 15);
            this.smartLabel29.TabIndex = 3;
            this.smartLabel29.Text = "School Refusal";
            // 
            // smartCheckBox43
            // 
            this.smartCheckBox43.AutoSize = true;
            this.smartCheckBox43.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox43.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox43.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox43.Location = new System.Drawing.Point(556, 7);
            this.smartCheckBox43.Name = "smartCheckBox43";
            this.smartCheckBox43.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox43.TabIndex = 19;
            this.smartCheckBox43.Text = "Moderate";
            this.smartCheckBox43.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox40
            // 
            this.smartCheckBox40.AutoSize = true;
            this.smartCheckBox40.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox40.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox40.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox40.Location = new System.Drawing.Point(397, 7);
            this.smartCheckBox40.Name = "smartCheckBox40";
            this.smartCheckBox40.Size = new System.Drawing.Size(66, 22);
            this.smartCheckBox40.TabIndex = 18;
            this.smartCheckBox40.Text = "Rarely";
            this.smartCheckBox40.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox39
            // 
            this.smartCheckBox39.AutoSize = true;
            this.smartCheckBox39.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox39.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox39.Location = new System.Drawing.Point(699, 7);
            this.smartCheckBox39.Name = "smartCheckBox39";
            this.smartCheckBox39.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox39.TabIndex = 20;
            this.smartCheckBox39.Text = "frequently";
            this.smartCheckBox39.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox36
            // 
            this.smartCheckBox36.AutoSize = true;
            this.smartCheckBox36.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox36.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox36.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox36.Location = new System.Drawing.Point(257, 7);
            this.smartCheckBox36.Name = "smartCheckBox36";
            this.smartCheckBox36.Size = new System.Drawing.Size(67, 22);
            this.smartCheckBox36.TabIndex = 17;
            this.smartCheckBox36.Text = "Never ";
            this.smartCheckBox36.UseVisualStyleBackColor = true;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.smartLabel27);
            this.groupBox22.Controls.Add(this.smartCheckBox34);
            this.groupBox22.Controls.Add(this.smartCheckBox31);
            this.groupBox22.Controls.Add(this.smartCheckBox28);
            this.groupBox22.Controls.Add(this.smartCheckBox25);
            this.groupBox22.Location = new System.Drawing.Point(7, 48);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(799, 33);
            this.groupBox22.TabIndex = 127;
            this.groupBox22.TabStop = false;
            // 
            // smartLabel27
            // 
            this.smartLabel27.AutoSize = true;
            this.smartLabel27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel27.Location = new System.Drawing.Point(6, 11);
            this.smartLabel27.Name = "smartLabel27";
            this.smartLabel27.Size = new System.Drawing.Size(130, 15);
            this.smartLabel27.TabIndex = 1;
            this.smartLabel27.Text = "Emotional Problem";
            // 
            // smartCheckBox34
            // 
            this.smartCheckBox34.AutoSize = true;
            this.smartCheckBox34.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox34.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox34.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox34.Location = new System.Drawing.Point(257, 7);
            this.smartCheckBox34.Name = "smartCheckBox34";
            this.smartCheckBox34.Size = new System.Drawing.Size(67, 22);
            this.smartCheckBox34.TabIndex = 9;
            this.smartCheckBox34.Text = "Never ";
            this.smartCheckBox34.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox31
            // 
            this.smartCheckBox31.AutoSize = true;
            this.smartCheckBox31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox31.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox31.Location = new System.Drawing.Point(397, 7);
            this.smartCheckBox31.Name = "smartCheckBox31";
            this.smartCheckBox31.Size = new System.Drawing.Size(66, 22);
            this.smartCheckBox31.TabIndex = 10;
            this.smartCheckBox31.Text = "Rarely";
            this.smartCheckBox31.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox28
            // 
            this.smartCheckBox28.AutoSize = true;
            this.smartCheckBox28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox28.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox28.Location = new System.Drawing.Point(556, 7);
            this.smartCheckBox28.Name = "smartCheckBox28";
            this.smartCheckBox28.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox28.TabIndex = 11;
            this.smartCheckBox28.Text = "Moderate";
            this.smartCheckBox28.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox25
            // 
            this.smartCheckBox25.AutoSize = true;
            this.smartCheckBox25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox25.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox25.Location = new System.Drawing.Point(699, 7);
            this.smartCheckBox25.Name = "smartCheckBox25";
            this.smartCheckBox25.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox25.TabIndex = 12;
            this.smartCheckBox25.Text = "frequently";
            this.smartCheckBox25.UseVisualStyleBackColor = true;
            // 
            // groupBox21
            // 
            this.groupBox21.BackColor = System.Drawing.Color.White;
            this.groupBox21.Controls.Add(this.smartLabel26);
            this.groupBox21.Controls.Add(this.smartCheckBox42);
            this.groupBox21.Controls.Add(this.smartCheckBox41);
            this.groupBox21.Controls.Add(this.smartCheckBox38);
            this.groupBox21.Controls.Add(this.smartCheckBox37);
            this.groupBox21.Location = new System.Drawing.Point(7, 13);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(799, 33);
            this.groupBox21.TabIndex = 40;
            this.groupBox21.TabStop = false;
            // 
            // smartLabel26
            // 
            this.smartLabel26.AutoSize = true;
            this.smartLabel26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel26.Location = new System.Drawing.Point(9, 11);
            this.smartLabel26.Name = "smartLabel26";
            this.smartLabel26.Size = new System.Drawing.Size(52, 15);
            this.smartLabel26.TabIndex = 0;
            this.smartLabel26.Text = "Anxiety";
            // 
            // smartCheckBox42
            // 
            this.smartCheckBox42.AutoSize = true;
            this.smartCheckBox42.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox42.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox42.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox42.Location = new System.Drawing.Point(556, 8);
            this.smartCheckBox42.Name = "smartCheckBox42";
            this.smartCheckBox42.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox42.TabIndex = 7;
            this.smartCheckBox42.Text = "Moderate";
            this.smartCheckBox42.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox41
            // 
            this.smartCheckBox41.AutoSize = true;
            this.smartCheckBox41.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox41.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox41.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox41.Location = new System.Drawing.Point(397, 8);
            this.smartCheckBox41.Name = "smartCheckBox41";
            this.smartCheckBox41.Size = new System.Drawing.Size(66, 22);
            this.smartCheckBox41.TabIndex = 6;
            this.smartCheckBox41.Text = "Rarely";
            this.smartCheckBox41.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox38
            // 
            this.smartCheckBox38.AutoSize = true;
            this.smartCheckBox38.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox38.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox38.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox38.Location = new System.Drawing.Point(699, 8);
            this.smartCheckBox38.Name = "smartCheckBox38";
            this.smartCheckBox38.Size = new System.Drawing.Size(87, 22);
            this.smartCheckBox38.TabIndex = 8;
            this.smartCheckBox38.Text = "frequently";
            this.smartCheckBox38.UseVisualStyleBackColor = true;
            // 
            // smartCheckBox37
            // 
            this.smartCheckBox37.AutoSize = true;
            this.smartCheckBox37.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox37.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox37.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox37.Location = new System.Drawing.Point(257, 8);
            this.smartCheckBox37.Name = "smartCheckBox37";
            this.smartCheckBox37.Size = new System.Drawing.Size(67, 22);
            this.smartCheckBox37.TabIndex = 5;
            this.smartCheckBox37.Text = "Never ";
            this.smartCheckBox37.UseVisualStyleBackColor = true;
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.smartLabel13.Location = new System.Drawing.Point(1433, 80);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(16, 15);
            this.smartLabel13.TabIndex = 238;
            this.smartLabel13.Text = "D";
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.smartLabel12.Location = new System.Drawing.Point(1385, 80);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(18, 15);
            this.smartLabel12.TabIndex = 237;
            this.smartLabel12.Text = "M";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.smartLabel7.Location = new System.Drawing.Point(1344, 80);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(15, 15);
            this.smartLabel7.TabIndex = 236;
            this.smartLabel7.Text = "Y";
            // 
            // txtNextVisit
            // 
            this.txtNextVisit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNextVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNextVisit.Location = new System.Drawing.Point(1331, 120);
            this.txtNextVisit.Mask = "00/00/0000";
            this.txtNextVisit.Name = "txtNextVisit";
            this.txtNextVisit.Size = new System.Drawing.Size(134, 24);
            this.txtNextVisit.TabIndex = 148;
            this.txtNextVisit.ValidatingType = typeof(System.DateTime);
            this.txtNextVisit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNextVisit_KeyUp);
            this.txtNextVisit.Leave += new System.EventHandler(this.txtNextVisit_Leave);
            // 
            // txtNextVisitYear
            // 
            this.txtNextVisitYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNextVisitYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNextVisitYear.Location = new System.Drawing.Point(1331, 94);
            this.txtNextVisitYear.MaxLength = 2;
            this.txtNextVisitYear.Name = "txtNextVisitYear";
            this.txtNextVisitYear.Size = new System.Drawing.Size(42, 24);
            this.txtNextVisitYear.TabIndex = 145;
            this.txtNextVisitYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNextVisitYear_KeyPress);
            this.txtNextVisitYear.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNextVisitYear_KeyUp);
            this.txtNextVisitYear.Leave += new System.EventHandler(this.txtNextVisitYear_Leave);
            // 
            // txtNextVisitMonth
            // 
            this.txtNextVisitMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNextVisitMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNextVisitMonth.Location = new System.Drawing.Point(1377, 94);
            this.txtNextVisitMonth.MaxLength = 2;
            this.txtNextVisitMonth.Name = "txtNextVisitMonth";
            this.txtNextVisitMonth.Size = new System.Drawing.Size(42, 24);
            this.txtNextVisitMonth.TabIndex = 144;
            this.txtNextVisitMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNextVisitMonth_KeyPress);
            this.txtNextVisitMonth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNextVisitMonth_KeyUp);
            this.txtNextVisitMonth.Leave += new System.EventHandler(this.txtNextVisitMonth_Leave);
            // 
            // txtNextVisitDay
            // 
            this.txtNextVisitDay.BackColor = System.Drawing.Color.White;
            this.txtNextVisitDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNextVisitDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNextVisitDay.Location = new System.Drawing.Point(1423, 94);
            this.txtNextVisitDay.MaxLength = 2;
            this.txtNextVisitDay.Name = "txtNextVisitDay";
            this.txtNextVisitDay.Size = new System.Drawing.Size(42, 24);
            this.txtNextVisitDay.TabIndex = 143;
            this.txtNextVisitDay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNextVisitDay_KeyUp);
            this.txtNextVisitDay.Leave += new System.EventHandler(this.txtNextVisitDay_Leave);
            // 
            // smartLabel15
            // 
            this.smartLabel15.AutoSize = true;
            this.smartLabel15.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel15.ForeColor = System.Drawing.Color.DodgerBlue;
            this.smartLabel15.Location = new System.Drawing.Point(1345, 67);
            this.smartLabel15.Name = "smartLabel15";
            this.smartLabel15.Size = new System.Drawing.Size(93, 15);
            this.smartLabel15.TabIndex = 134;
            this.smartLabel15.Text = "Next Visit After";
            // 
            // lvTicketList
            // 
            this.lvTicketList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvTicketList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvTicketList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvTicketList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTicketList.FullRowSelect = true;
            this.lvTicketList.GridLines = true;
            this.lvTicketList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTicketList.Location = new System.Drawing.Point(0, 31);
            this.lvTicketList.Name = "lvTicketList";
            this.lvTicketList.Size = new System.Drawing.Size(296, 155);
            this.lvTicketList.TabIndex = 119;
            this.lvTicketList.UseCompatibleStateImageBehavior = false;
            this.lvTicketList.View = System.Windows.Forms.View.Details;
            this.lvTicketList.SelectedIndexChanged += new System.EventHandler(this.lvTicketList_SelectedIndexChanged);
            this.lvTicketList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvTicketList_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.smartLabel35);
            this.panel1.Controls.Add(this.lblComplaints);
            this.panel1.Controls.Add(this.lblDeptDoctor);
            this.panel1.Controls.Add(this.lblPatientName);
            this.panel1.Location = new System.Drawing.Point(301, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 61);
            this.panel1.TabIndex = 121;
            // 
            // smartLabel35
            // 
            this.smartLabel35.AutoSize = true;
            this.smartLabel35.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel35.ForeColor = System.Drawing.Color.DarkRed;
            this.smartLabel35.Location = new System.Drawing.Point(4, 39);
            this.smartLabel35.Name = "smartLabel35";
            this.smartLabel35.Size = new System.Drawing.Size(112, 15);
            this.smartLabel35.TabIndex = 218;
            this.smartLabel35.Text = "Main Complain :";
            // 
            // lblComplaints
            // 
            this.lblComplaints.AutoSize = true;
            this.lblComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblComplaints.ForeColor = System.Drawing.Color.IndianRed;
            this.lblComplaints.Location = new System.Drawing.Point(124, 40);
            this.lblComplaints.Name = "lblComplaints";
            this.lblComplaints.Size = new System.Drawing.Size(79, 15);
            this.lblComplaints.TabIndex = 150;
            this.lblComplaints.Text = "Complaints";
            // 
            // lblDeptDoctor
            // 
            this.lblDeptDoctor.AutoSize = true;
            this.lblDeptDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptDoctor.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDeptDoctor.Location = new System.Drawing.Point(282, 6);
            this.lblDeptDoctor.Name = "lblDeptDoctor";
            this.lblDeptDoctor.Size = new System.Drawing.Size(102, 15);
            this.lblDeptDoctor.TabIndex = 149;
            this.lblDeptDoctor.Text = "Doctor\'s Name";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPatientName.Location = new System.Drawing.Point(4, 6);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(94, 15);
            this.lblPatientName.TabIndex = 148;
            this.lblPatientName.Text = "Patient Name";
            // 
            // lblComplaints1
            // 
            this.lblComplaints1.AutoSize = true;
            this.lblComplaints1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplaints1.ForeColor = System.Drawing.Color.IndianRed;
            this.lblComplaints1.Location = new System.Drawing.Point(720, 8);
            this.lblComplaints1.Name = "lblComplaints1";
            this.lblComplaints1.Size = new System.Drawing.Size(85, 16);
            this.lblComplaints1.TabIndex = 147;
            this.lblComplaints1.Text = "Complaints";
            // 
            // lblDeptDoctor1
            // 
            this.lblDeptDoctor1.AutoSize = true;
            this.lblDeptDoctor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptDoctor1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDeptDoctor1.Location = new System.Drawing.Point(333, 5);
            this.lblDeptDoctor1.Name = "lblDeptDoctor1";
            this.lblDeptDoctor1.Size = new System.Drawing.Size(87, 16);
            this.lblDeptDoctor1.TabIndex = 146;
            this.lblDeptDoctor1.Text = "DeptDoctor";
            // 
            // LocalSourceFile1
            // 
            this.LocalSourceFile1.AutoSize = true;
            this.LocalSourceFile1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LocalSourceFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalSourceFile1.ForeColor = System.Drawing.Color.DarkRed;
            this.LocalSourceFile1.Location = new System.Drawing.Point(10, 5);
            this.LocalSourceFile1.Name = "LocalSourceFile1";
            this.LocalSourceFile1.Size = new System.Drawing.Size(101, 16);
            this.LocalSourceFile1.TabIndex = 142;
            this.LocalSourceFile1.Text = "Patient Name";
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.BackColor = System.Drawing.Color.Linen;
            this.txtDoctorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDoctorID.Location = new System.Drawing.Point(186, 783);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.ReadOnly = true;
            this.txtDoctorID.Size = new System.Drawing.Size(10, 24);
            this.txtDoctorID.TabIndex = 127;
            this.txtDoctorID.TabStop = false;
            this.txtDoctorID.Visible = false;
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.Color.Linen;
            this.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDepartment.Location = new System.Drawing.Point(164, 783);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(10, 24);
            this.txtDepartment.TabIndex = 126;
            this.txtDepartment.TabStop = false;
            this.txtDepartment.Visible = false;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.BackColor = System.Drawing.Color.Linen;
            this.txtDoctorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDoctorName.Location = new System.Drawing.Point(175, 783);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.ReadOnly = true;
            this.txtDoctorName.Size = new System.Drawing.Size(10, 24);
            this.txtDoctorName.TabIndex = 117;
            this.txtDoctorName.TabStop = false;
            this.txtDoctorName.Visible = false;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.BackColor = System.Drawing.Color.Linen;
            this.txtDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDepartmentName.Location = new System.Drawing.Point(197, 783);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.ReadOnly = true;
            this.txtDepartmentName.Size = new System.Drawing.Size(10, 24);
            this.txtDepartmentName.TabIndex = 115;
            this.txtDepartmentName.TabStop = false;
            this.txtDepartmentName.Visible = false;
            // 
            // smartLabel14
            // 
            this.smartLabel14.AutoSize = true;
            this.smartLabel14.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel14.ForeColor = System.Drawing.Color.Maroon;
            this.smartLabel14.Location = new System.Drawing.Point(1029, 69);
            this.smartLabel14.Name = "smartLabel14";
            this.smartLabel14.Size = new System.Drawing.Size(62, 15);
            this.smartLabel14.TabIndex = 129;
            this.smartLabel14.Text = "BSA(m^2)";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.ForeColor = System.Drawing.Color.Maroon;
            this.smartLabel10.Location = new System.Drawing.Point(893, 75);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(70, 15);
            this.smartLabel10.TabIndex = 122;
            this.smartLabel10.Text = "BP (mm Hg)";
            // 
            // cboTicketType
            // 
            this.cboTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTicketType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTicketType.ForeColor = System.Drawing.Color.Blue;
            this.cboTicketType.FormattingEnabled = true;
            this.cboTicketType.Location = new System.Drawing.Point(107, 781);
            this.cboTicketType.Name = "cboTicketType";
            this.cboTicketType.Size = new System.Drawing.Size(32, 26);
            this.cboTicketType.TabIndex = 17;
            this.cboTicketType.Visible = false;
            // 
            // txtHCN
            // 
            this.txtHCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHCN.Location = new System.Drawing.Point(142, 783);
            this.txtHCN.Name = "txtHCN";
            this.txtHCN.Size = new System.Drawing.Size(10, 24);
            this.txtHCN.TabIndex = 15;
            this.txtHCN.Visible = false;
            // 
            // txtDepartmentUnit
            // 
            this.txtDepartmentUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartmentUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentUnit.Location = new System.Drawing.Point(208, 783);
            this.txtDepartmentUnit.Name = "txtDepartmentUnit";
            this.txtDepartmentUnit.Size = new System.Drawing.Size(10, 24);
            this.txtDepartmentUnit.TabIndex = 16;
            this.txtDepartmentUnit.Visible = false;
            // 
            // lblBusy
            // 
            this.lblBusy.AutoSize = true;
            this.lblBusy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusy.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblBusy.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.lblBusy.Location = new System.Drawing.Point(133, 7);
            this.lblBusy.Name = "lblBusy";
            this.lblBusy.Size = new System.Drawing.Size(42, 16);
            this.lblBusy.TabIndex = 213;
            this.lblBusy.TabStop = true;
            this.lblBusy.Text = "Busy";
            this.lblBusy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBusy_LinkClicked);
            // 
            // lblVisit
            // 
            this.lblVisit.AutoSize = true;
            this.lblVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisit.ForeColor = System.Drawing.Color.Azure;
            this.lblVisit.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.lblVisit.Location = new System.Drawing.Point(189, 7);
            this.lblVisit.Name = "lblVisit";
            this.lblVisit.Size = new System.Drawing.Size(59, 16);
            this.lblVisit.TabIndex = 214;
            this.lblVisit.TabStop = true;
            this.lblVisit.Text = "Visiting";
            this.lblVisit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVisit_LinkClicked);
            this.lblVisit.Click += new System.EventHandler(this.lblVisit_Click);
            // 
            // lblFree
            // 
            this.lblFree.AutoSize = true;
            this.lblFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFree.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblFree.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.lblFree.Location = new System.Drawing.Point(85, 7);
            this.lblFree.Name = "lblFree";
            this.lblFree.Size = new System.Drawing.Size(40, 16);
            this.lblFree.TabIndex = 215;
            this.lblFree.TabStop = true;
            this.lblFree.Text = "Free";
            this.lblFree.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblFree_LinkClicked);
            // 
            // lblRefresh
            // 
            this.lblRefresh.AutoSize = true;
            this.lblRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefresh.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblRefresh.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRefresh.Location = new System.Drawing.Point(14, 7);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(62, 16);
            this.lblRefresh.TabIndex = 227;
            this.lblRefresh.TabStop = true;
            this.lblRefresh.Text = "Refresh";
            this.lblRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRefresh_LinkClicked);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblStartTime.Location = new System.Drawing.Point(1237, 88);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(10, 13);
            this.lblStartTime.TabIndex = 212;
            this.lblStartTime.Text = "l";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEndTime.Location = new System.Drawing.Point(1237, 123);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(10, 13);
            this.lblEndTime.TabIndex = 213;
            this.lblEndTime.Text = "l";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtAgeHours
            // 
            this.txtAgeHours.BackColor = System.Drawing.Color.Linen;
            this.txtAgeHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeHours.Location = new System.Drawing.Point(52, 783);
            this.txtAgeHours.Name = "txtAgeHours";
            this.txtAgeHours.ReadOnly = true;
            this.txtAgeHours.Size = new System.Drawing.Size(15, 24);
            this.txtAgeHours.TabIndex = 111;
            this.txtAgeHours.TabStop = false;
            this.txtAgeHours.Visible = false;
            // 
            // txtAgeDays
            // 
            this.txtAgeDays.BackColor = System.Drawing.Color.Linen;
            this.txtAgeDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeDays.Location = new System.Drawing.Point(36, 783);
            this.txtAgeDays.Name = "txtAgeDays";
            this.txtAgeDays.ReadOnly = true;
            this.txtAgeDays.Size = new System.Drawing.Size(15, 24);
            this.txtAgeDays.TabIndex = 109;
            this.txtAgeDays.TabStop = false;
            this.txtAgeDays.Visible = false;
            // 
            // txtAgeMonths
            // 
            this.txtAgeMonths.BackColor = System.Drawing.Color.Linen;
            this.txtAgeMonths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeMonths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeMonths.Location = new System.Drawing.Point(20, 783);
            this.txtAgeMonths.Name = "txtAgeMonths";
            this.txtAgeMonths.ReadOnly = true;
            this.txtAgeMonths.Size = new System.Drawing.Size(15, 24);
            this.txtAgeMonths.TabIndex = 107;
            this.txtAgeMonths.TabStop = false;
            this.txtAgeMonths.Visible = false;
            // 
            // txtAgeYears
            // 
            this.txtAgeYears.BackColor = System.Drawing.Color.Linen;
            this.txtAgeYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeYears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeYears.Location = new System.Drawing.Point(4, 784);
            this.txtAgeYears.Name = "txtAgeYears";
            this.txtAgeYears.ReadOnly = true;
            this.txtAgeYears.Size = new System.Drawing.Size(15, 24);
            this.txtAgeYears.TabIndex = 105;
            this.txtAgeYears.TabStop = false;
            this.txtAgeYears.Visible = false;
            // 
            // smartListViewDetails1
            // 
            this.smartListViewDetails1.BackColor = System.Drawing.Color.LemonChiffon;
            this.smartListViewDetails1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartListViewDetails1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartListViewDetails1.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartListViewDetails1.FullRowSelect = true;
            this.smartListViewDetails1.GridLines = true;
            this.smartListViewDetails1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.smartListViewDetails1.Location = new System.Drawing.Point(257, 353);
            this.smartListViewDetails1.Name = "smartListViewDetails1";
            this.smartListViewDetails1.Size = new System.Drawing.Size(652, 166);
            this.smartListViewDetails1.TabIndex = 226;
            this.smartListViewDetails1.UseCompatibleStateImageBehavior = false;
            this.smartListViewDetails1.View = System.Windows.Forms.View.Details;
            // 
            // treePatientHistory
            // 
            this.treePatientHistory.AutoBuildTree = true;
            this.treePatientHistory.DataSource = null;
            this.treePatientHistory.DisplayMember = null;
            this.treePatientHistory.LineColor = System.Drawing.Color.Empty;
            this.treePatientHistory.Location = new System.Drawing.Point(0, 0);
            this.treePatientHistory.Name = "treePatientHistory";
            this.treePatientHistory.Size = new System.Drawing.Size(121, 97);
            this.treePatientHistory.TabIndex = 0;
            this.treePatientHistory.ValueMember = null;
            // 
            // llblBMI
            // 
            this.llblBMI.AutoSize = true;
            this.llblBMI.BackColor = System.Drawing.Color.Transparent;
            this.llblBMI.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.llblBMI.ForeColor = System.Drawing.Color.Maroon;
            this.llblBMI.Location = new System.Drawing.Point(508, 93);
            this.llblBMI.Name = "llblBMI";
            this.llblBMI.Size = new System.Drawing.Size(80, 15);
            this.llblBMI.TabIndex = 215;
            this.llblBMI.Text = "BMI (kg/m^2)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(301, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(198, 78);
            this.tabControl1.TabIndex = 216;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Snow;
            this.tabPage1.Controls.Add(this.txtWeightS);
            this.tabPage1.Controls.Add(this.txtHeightS);
            this.tabPage1.Controls.Add(this.lblHeightFeet);
            this.tabPage1.Controls.Add(this.lblWeighPound);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(190, 53);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Standard";
            // 
            // txtWeightS
            // 
            this.txtWeightS.BackColor = System.Drawing.Color.Linen;
            this.txtWeightS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeightS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtWeightS.Location = new System.Drawing.Point(99, 22);
            this.txtWeightS.Name = "txtWeightS";
            this.txtWeightS.ReadOnly = true;
            this.txtWeightS.Size = new System.Drawing.Size(80, 24);
            this.txtWeightS.TabIndex = 225;
            this.txtWeightS.TabStop = false;
            // 
            // txtHeightS
            // 
            this.txtHeightS.BackColor = System.Drawing.Color.Linen;
            this.txtHeightS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeightS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeightS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtHeightS.Location = new System.Drawing.Point(6, 22);
            this.txtHeightS.Name = "txtHeightS";
            this.txtHeightS.ReadOnly = true;
            this.txtHeightS.Size = new System.Drawing.Size(80, 24);
            this.txtHeightS.TabIndex = 224;
            this.txtHeightS.TabStop = false;
            // 
            // lblHeightFeet
            // 
            this.lblHeightFeet.AutoSize = true;
            this.lblHeightFeet.BackColor = System.Drawing.Color.Transparent;
            this.lblHeightFeet.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lblHeightFeet.ForeColor = System.Drawing.Color.Maroon;
            this.lblHeightFeet.Location = new System.Drawing.Point(7, 6);
            this.lblHeightFeet.Name = "lblHeightFeet";
            this.lblHeightFeet.Size = new System.Drawing.Size(77, 15);
            this.lblHeightFeet.TabIndex = 132;
            this.lblHeightFeet.Text = "Height (Feet)";
            // 
            // lblWeighPound
            // 
            this.lblWeighPound.AutoSize = true;
            this.lblWeighPound.BackColor = System.Drawing.Color.Transparent;
            this.lblWeighPound.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lblWeighPound.ForeColor = System.Drawing.Color.Maroon;
            this.lblWeighPound.Location = new System.Drawing.Point(94, 6);
            this.lblWeighPound.Name = "lblWeighPound";
            this.lblWeighPound.Size = new System.Drawing.Size(88, 15);
            this.lblWeighPound.TabIndex = 133;
            this.lblWeighPound.Text = "Weight (Pound)";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Snow;
            this.tabPage2.Controls.Add(this.txtWeightM);
            this.tabPage2.Controls.Add(this.txtHeightM);
            this.tabPage2.Controls.Add(this.lblHeightCM);
            this.tabPage2.Controls.Add(this.lblWeightKg);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(190, 53);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Metric";
            // 
            // txtWeightM
            // 
            this.txtWeightM.BackColor = System.Drawing.Color.Linen;
            this.txtWeightM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeightM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtWeightM.Location = new System.Drawing.Point(99, 22);
            this.txtWeightM.Name = "txtWeightM";
            this.txtWeightM.ReadOnly = true;
            this.txtWeightM.Size = new System.Drawing.Size(80, 24);
            this.txtWeightM.TabIndex = 223;
            this.txtWeightM.TabStop = false;
            this.txtWeightM.TextChanged += new System.EventHandler(this.txtWeightM_TextChanged);
            // 
            // txtHeightM
            // 
            this.txtHeightM.BackColor = System.Drawing.Color.Linen;
            this.txtHeightM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeightM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeightM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtHeightM.Location = new System.Drawing.Point(6, 22);
            this.txtHeightM.Name = "txtHeightM";
            this.txtHeightM.ReadOnly = true;
            this.txtHeightM.Size = new System.Drawing.Size(80, 24);
            this.txtHeightM.TabIndex = 222;
            this.txtHeightM.TabStop = false;
            this.txtHeightM.TextChanged += new System.EventHandler(this.txtHeightM_TextChanged);
            // 
            // lblHeightCM
            // 
            this.lblHeightCM.AutoSize = true;
            this.lblHeightCM.BackColor = System.Drawing.Color.Transparent;
            this.lblHeightCM.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lblHeightCM.ForeColor = System.Drawing.Color.Maroon;
            this.lblHeightCM.Location = new System.Drawing.Point(9, 6);
            this.lblHeightCM.Name = "lblHeightCM";
            this.lblHeightCM.Size = new System.Drawing.Size(69, 15);
            this.lblHeightCM.TabIndex = 136;
            this.lblHeightCM.Text = "Height (cm)";
            // 
            // lblWeightKg
            // 
            this.lblWeightKg.AutoSize = true;
            this.lblWeightKg.BackColor = System.Drawing.Color.Transparent;
            this.lblWeightKg.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lblWeightKg.ForeColor = System.Drawing.Color.Maroon;
            this.lblWeightKg.Location = new System.Drawing.Point(103, 6);
            this.lblWeightKg.Name = "lblWeightKg";
            this.lblWeightKg.Size = new System.Drawing.Size(68, 15);
            this.lblWeightKg.TabIndex = 137;
            this.lblWeightKg.Text = "Weight (kg)";
            // 
            // lblBMIStatus
            // 
            this.lblBMIStatus.AutoSize = true;
            this.lblBMIStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblBMIStatus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBMIStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBMIStatus.Location = new System.Drawing.Point(507, 71);
            this.lblBMIStatus.Name = "lblBMIStatus";
            this.lblBMIStatus.Size = new System.Drawing.Size(69, 15);
            this.lblBMIStatus.TabIndex = 217;
            this.lblBMIStatus.Text = "BMI Status";
            // 
            // smartLabel16
            // 
            this.smartLabel16.AutoSize = true;
            this.smartLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel16.ForeColor = System.Drawing.Color.DarkRed;
            this.smartLabel16.Location = new System.Drawing.Point(669, 72);
            this.smartLabel16.Name = "smartLabel16";
            this.smartLabel16.Size = new System.Drawing.Size(124, 18);
            this.smartLabel16.TabIndex = 219;
            this.smartLabel16.Text = "BMI Categories";
            this.smartLabel16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBMIStatusList
            // 
            this.lblBMIStatusList.AutoSize = true;
            this.lblBMIStatusList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMIStatusList.Location = new System.Drawing.Point(598, 96);
            this.lblBMIStatusList.Name = "lblBMIStatusList";
            this.lblBMIStatusList.Size = new System.Drawing.Size(254, 39);
            this.lblBMIStatusList.TabIndex = 220;
            this.lblBMIStatusList.Text = "Underweight = <18.5   ;  Normal weight = 18.5-24.9 ;\r\nOverweight = 25-29.9  ;  Ob" +
    "ese = 30-39.9 ;\r\nExtremely Obese = BMI of 40 or greater";
            this.lblBMIStatusList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBMI
            // 
            this.txtBMI.BackColor = System.Drawing.Color.Linen;
            this.txtBMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBMI.Location = new System.Drawing.Point(505, 110);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.ReadOnly = true;
            this.txtBMI.Size = new System.Drawing.Size(91, 24);
            this.txtBMI.TabIndex = 221;
            this.txtBMI.TabStop = false;
            // 
            // txtBP
            // 
            this.txtBP.BackColor = System.Drawing.Color.Linen;
            this.txtBP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBP.Location = new System.Drawing.Point(870, 98);
            this.txtBP.Name = "txtBP";
            this.txtBP.ReadOnly = true;
            this.txtBP.Size = new System.Drawing.Size(46, 24);
            this.txtBP.TabIndex = 222;
            this.txtBP.TabStop = false;
            // 
            // txtTemp
            // 
            this.txtTemp.BackColor = System.Drawing.Color.Linen;
            this.txtTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtTemp.Location = new System.Drawing.Point(1128, 84);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.ReadOnly = true;
            this.txtTemp.Size = new System.Drawing.Size(80, 24);
            this.txtTemp.TabIndex = 223;
            this.txtTemp.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Location = new System.Drawing.Point(301, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1173, 4);
            this.panel2.TabIndex = 224;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboDoctor);
            this.panel3.Controls.Add(this.smartLabel3);
            this.panel3.Controls.Add(this.cboUnit);
            this.panel3.Controls.Add(this.cboDepartment);
            this.panel3.Controls.Add(this.smartLabel1);
            this.panel3.Controls.Add(this.smartLabel5);
            this.panel3.Controls.Add(this.chkReferTo);
            this.panel3.Location = new System.Drawing.Point(896, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 61);
            this.panel3.TabIndex = 225;
            // 
            // cboDoctor
            // 
            this.cboDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoctor.ForeColor = System.Drawing.Color.Blue;
            this.cboDoctor.FormattingEnabled = true;
            this.cboDoctor.Location = new System.Drawing.Point(172, 32);
            this.cboDoctor.Name = "cboDoctor";
            this.cboDoctor.Size = new System.Drawing.Size(397, 26);
            this.cboDoctor.TabIndex = 11;
            this.cboDoctor.SelectedIndexChanged += new System.EventHandler(this.cboDoctor_SelectedIndexChanged);
            this.cboDoctor.Leave += new System.EventHandler(this.cboDoctor_Leave);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(318, 8);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(37, 15);
            this.smartLabel3.TabIndex = 9;
            this.smartLabel3.Text = "Unit :";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.Location = new System.Drawing.Point(359, 3);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(209, 26);
            this.cboUnit.TabIndex = 10;
            this.cboUnit.SelectedIndexChanged += new System.EventHandler(this.cboUnit_SelectedIndexChanged);
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(172, 4);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(141, 26);
            this.cboDepartment.TabIndex = 3;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(93, 9);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(78, 15);
            this.smartLabel1.TabIndex = 4;
            this.smartLabel1.Text = "Department :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(120, 37);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(51, 15);
            this.smartLabel5.TabIndex = 12;
            this.smartLabel5.Text = "Doctor :";
            // 
            // chkReferTo
            // 
            this.chkReferTo.AutoSize = true;
            this.chkReferTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkReferTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkReferTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReferTo.ForeColor = System.Drawing.Color.Black;
            this.chkReferTo.Location = new System.Drawing.Point(8, 21);
            this.chkReferTo.Name = "chkReferTo";
            this.chkReferTo.Size = new System.Drawing.Size(82, 22);
            this.chkReferTo.TabIndex = 13;
            this.chkReferTo.Text = "Refer To";
            this.chkReferTo.UseVisualStyleBackColor = true;
            this.chkReferTo.CheckedChanged += new System.EventHandler(this.chkReferTo_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LimeGreen;
            this.panel4.Location = new System.Drawing.Point(891, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 64);
            this.panel4.TabIndex = 225;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LimeGreen;
            this.panel7.Location = new System.Drawing.Point(855, 67);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(3, 79);
            this.panel7.TabIndex = 239;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LimeGreen;
            this.panel9.Location = new System.Drawing.Point(1321, 67);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(3, 79);
            this.panel9.TabIndex = 241;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(1228, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 242;
            this.label1.Text = "Start Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(1229, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 243;
            this.label3.Text = "Visiting Time:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LimeGreen;
            this.panel10.Location = new System.Drawing.Point(301, 146);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1173, 4);
            this.panel10.TabIndex = 244;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.LimeGreen;
            this.panel12.Location = new System.Drawing.Point(296, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(5, 186);
            this.panel12.TabIndex = 255;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.AliceBlue;
            this.panel11.Controls.Add(this.lblVisit);
            this.panel11.Controls.Add(this.lblRefresh);
            this.panel11.Controls.Add(this.lblBusy);
            this.panel11.Controls.Add(this.lblFree);
            this.panel11.Location = new System.Drawing.Point(1202, 7);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(261, 31);
            this.panel11.TabIndex = 228;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // chkAllergy1
            // 
            this.chkAllergy1.AutoSize = true;
            this.chkAllergy1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAllergy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAllergy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllergy1.ForeColor = System.Drawing.Color.Black;
            this.chkAllergy1.Location = new System.Drawing.Point(12, 4);
            this.chkAllergy1.Name = "chkAllergy1";
            this.chkAllergy1.Size = new System.Drawing.Size(67, 22);
            this.chkAllergy1.TabIndex = 256;
            this.chkAllergy1.Text = "Allergy";
            this.chkAllergy1.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FloralWhite;
            this.panel15.Controls.Add(this.chkKidneyDisease1);
            this.panel15.Controls.Add(this.chkHeartDisease1);
            this.panel15.Controls.Add(this.chkHypertension1);
            this.panel15.Controls.Add(this.chkDiabetes1);
            this.panel15.Controls.Add(this.chkAsthma1);
            this.panel15.Controls.Add(this.chkAllergy1);
            this.panel15.Location = new System.Drawing.Point(301, 151);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1169, 30);
            this.panel15.TabIndex = 257;
            // 
            // chkKidneyDisease1
            // 
            this.chkKidneyDisease1.AutoSize = true;
            this.chkKidneyDisease1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkKidneyDisease1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkKidneyDisease1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKidneyDisease1.ForeColor = System.Drawing.Color.Black;
            this.chkKidneyDisease1.Location = new System.Drawing.Point(946, 4);
            this.chkKidneyDisease1.Name = "chkKidneyDisease1";
            this.chkKidneyDisease1.Size = new System.Drawing.Size(182, 22);
            this.chkKidneyDisease1.TabIndex = 262;
            this.chkKidneyDisease1.Text = "Chronic Kidney Disease";
            this.chkKidneyDisease1.UseVisualStyleBackColor = true;
            // 
            // chkHeartDisease1
            // 
            this.chkHeartDisease1.AutoSize = true;
            this.chkHeartDisease1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHeartDisease1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHeartDisease1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHeartDisease1.ForeColor = System.Drawing.Color.Black;
            this.chkHeartDisease1.Location = new System.Drawing.Point(712, 4);
            this.chkHeartDisease1.Name = "chkHeartDisease1";
            this.chkHeartDisease1.Size = new System.Drawing.Size(181, 22);
            this.chkHeartDisease1.TabIndex = 261;
            this.chkHeartDisease1.Text = "Ischemic Heart Disease";
            this.chkHeartDisease1.UseVisualStyleBackColor = true;
            // 
            // chkHypertension1
            // 
            this.chkHypertension1.AutoSize = true;
            this.chkHypertension1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHypertension1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHypertension1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHypertension1.ForeColor = System.Drawing.Color.Black;
            this.chkHypertension1.Location = new System.Drawing.Point(544, 4);
            this.chkHypertension1.Name = "chkHypertension1";
            this.chkHypertension1.Size = new System.Drawing.Size(111, 22);
            this.chkHypertension1.TabIndex = 260;
            this.chkHypertension1.Text = "Hypertension";
            this.chkHypertension1.UseVisualStyleBackColor = true;
            // 
            // chkDiabetes1
            // 
            this.chkDiabetes1.AutoSize = true;
            this.chkDiabetes1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDiabetes1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDiabetes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDiabetes1.ForeColor = System.Drawing.Color.Black;
            this.chkDiabetes1.Location = new System.Drawing.Point(344, 4);
            this.chkDiabetes1.Name = "chkDiabetes1";
            this.chkDiabetes1.Size = new System.Drawing.Size(136, 22);
            this.chkDiabetes1.TabIndex = 259;
            this.chkDiabetes1.Text = "Diabetes Mellitus";
            this.chkDiabetes1.UseVisualStyleBackColor = true;
            // 
            // chkAsthma1
            // 
            this.chkAsthma1.AutoSize = true;
            this.chkAsthma1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAsthma1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAsthma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAsthma1.ForeColor = System.Drawing.Color.Black;
            this.chkAsthma1.Location = new System.Drawing.Point(148, 4);
            this.chkAsthma1.Name = "chkAsthma1";
            this.chkAsthma1.Size = new System.Drawing.Size(140, 22);
            this.chkAsthma1.TabIndex = 258;
            this.chkAsthma1.Text = "Bronchial Asthma";
            this.chkAsthma1.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.LimeGreen;
            this.panel16.Location = new System.Drawing.Point(301, 182);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1173, 4);
            this.panel16.TabIndex = 258;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.LimeGreen;
            this.panel17.Location = new System.Drawing.Point(1005, 67);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(3, 79);
            this.panel17.TabIndex = 259;
            // 
            // txtBpP2
            // 
            this.txtBpP2.BackColor = System.Drawing.Color.Linen;
            this.txtBpP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBpP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBpP2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBpP2.Location = new System.Drawing.Point(945, 98);
            this.txtBpP2.Name = "txtBpP2";
            this.txtBpP2.ReadOnly = true;
            this.txtBpP2.Size = new System.Drawing.Size(46, 24);
            this.txtBpP2.TabIndex = 260;
            this.txtBpP2.TabStop = false;
            // 
            // smartLabel36
            // 
            this.smartLabel36.AutoSize = true;
            this.smartLabel36.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel36.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel36.ForeColor = System.Drawing.Color.Maroon;
            this.smartLabel36.Location = new System.Drawing.Point(866, 124);
            this.smartLabel36.Name = "smartLabel36";
            this.smartLabel36.Size = new System.Drawing.Size(133, 15);
            this.smartLabel36.TabIndex = 261;
            this.smartLabel36.Text = "Systolic           Diastolic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(920, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 25);
            this.label4.TabIndex = 262;
            this.label4.Text = "/";
            // 
            // chkOtherDisease1
            // 
            this.chkOtherDisease1.AutoSize = true;
            this.chkOtherDisease1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOtherDisease1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkOtherDisease1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOtherDisease1.ForeColor = System.Drawing.Color.Black;
            this.chkOtherDisease1.Location = new System.Drawing.Point(349, 797);
            this.chkOtherDisease1.Name = "chkOtherDisease1";
            this.chkOtherDisease1.Size = new System.Drawing.Size(66, 22);
            this.chkOtherDisease1.TabIndex = 259;
            this.chkOtherDisease1.Text = "others";
            this.chkOtherDisease1.UseVisualStyleBackColor = true;
            this.chkOtherDisease1.Visible = false;
            // 
            // chkPSurgHis1
            // 
            this.chkPSurgHis1.AutoSize = true;
            this.chkPSurgHis1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPSurgHis1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPSurgHis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPSurgHis1.ForeColor = System.Drawing.Color.Black;
            this.chkPSurgHis1.Location = new System.Drawing.Point(224, 797);
            this.chkPSurgHis1.Name = "chkPSurgHis1";
            this.chkPSurgHis1.Size = new System.Drawing.Size(119, 22);
            this.chkPSurgHis1.TabIndex = 260;
            this.chkPSurgHis1.Text = "chkPSurgHis1";
            this.chkPSurgHis1.UseVisualStyleBackColor = true;
            this.chkPSurgHis1.Visible = false;
            // 
            // chkPMedHis1
            // 
            this.chkPMedHis1.AutoSize = true;
            this.chkPMedHis1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPMedHis1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPMedHis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPMedHis1.ForeColor = System.Drawing.Color.Black;
            this.chkPMedHis1.Location = new System.Drawing.Point(349, 784);
            this.chkPMedHis1.Name = "chkPMedHis1";
            this.chkPMedHis1.Size = new System.Drawing.Size(117, 22);
            this.chkPMedHis1.TabIndex = 261;
            this.chkPMedHis1.Text = "chkPMedHis1";
            this.chkPMedHis1.UseVisualStyleBackColor = true;
            this.chkPMedHis1.Visible = false;
            // 
            // chkFamilyHis1
            // 
            this.chkFamilyHis1.AutoSize = true;
            this.chkFamilyHis1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkFamilyHis1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFamilyHis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFamilyHis1.ForeColor = System.Drawing.Color.Black;
            this.chkFamilyHis1.Location = new System.Drawing.Point(224, 780);
            this.chkFamilyHis1.Name = "chkFamilyHis1";
            this.chkFamilyHis1.Size = new System.Drawing.Size(121, 22);
            this.chkFamilyHis1.TabIndex = 262;
            this.chkFamilyHis1.Text = "chkFamilyHis1";
            this.chkFamilyHis1.UseVisualStyleBackColor = true;
            this.chkFamilyHis1.Visible = false;
            // 
            // txtDiseaseCase
            // 
            this.txtDiseaseCase.BackColor = System.Drawing.Color.Linen;
            this.txtDiseaseCase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiseaseCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiseaseCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDiseaseCase.Location = new System.Drawing.Point(153, 783);
            this.txtDiseaseCase.Name = "txtDiseaseCase";
            this.txtDiseaseCase.ReadOnly = true;
            this.txtDiseaseCase.Size = new System.Drawing.Size(10, 24);
            this.txtDiseaseCase.TabIndex = 124;
            this.txtDiseaseCase.TabStop = false;
            this.txtDiseaseCase.Visible = false;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.LimeGreen;
            this.panel20.Location = new System.Drawing.Point(1220, 67);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(3, 79);
            this.panel20.TabIndex = 263;
            // 
            // txtSPOTWO
            // 
            this.txtSPOTWO.BackColor = System.Drawing.Color.Linen;
            this.txtSPOTWO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSPOTWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSPOTWO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSPOTWO.Location = new System.Drawing.Point(1128, 120);
            this.txtSPOTWO.Name = "txtSPOTWO";
            this.txtSPOTWO.ReadOnly = true;
            this.txtSPOTWO.Size = new System.Drawing.Size(80, 24);
            this.txtSPOTWO.TabIndex = 264;
            this.txtSPOTWO.TabStop = false;
            // 
            // txtBSA
            // 
            this.txtBSA.BackColor = System.Drawing.Color.Linen;
            this.txtBSA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBSA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBSA.Location = new System.Drawing.Point(1020, 84);
            this.txtBSA.Name = "txtBSA";
            this.txtBSA.ReadOnly = true;
            this.txtBSA.Size = new System.Drawing.Size(80, 24);
            this.txtBSA.TabIndex = 265;
            this.txtBSA.TabStop = false;
            // 
            // txtOFC
            // 
            this.txtOFC.BackColor = System.Drawing.Color.Linen;
            this.txtOFC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOFC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtOFC.Location = new System.Drawing.Point(1020, 120);
            this.txtOFC.Name = "txtOFC";
            this.txtOFC.ReadOnly = true;
            this.txtOFC.Size = new System.Drawing.Size(80, 24);
            this.txtOFC.TabIndex = 267;
            this.txtOFC.TabStop = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.smartLabel2.Location = new System.Drawing.Point(1039, 106);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(33, 15);
            this.smartLabel2.TabIndex = 266;
            this.smartLabel2.Text = "OFC";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.ForeColor = System.Drawing.Color.Maroon;
            this.smartLabel4.Location = new System.Drawing.Point(1140, 106);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(60, 15);
            this.smartLabel4.TabIndex = 268;
            this.smartLabel4.Text = "SPO2 (%)";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.ForeColor = System.Drawing.Color.Maroon;
            this.smartLabel6.Location = new System.Drawing.Point(1139, 68);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(53, 15);
            this.smartLabel6.TabIndex = 269;
            this.smartLabel6.Text = "Temp(C)";
            // 
            // btnVisitedPatList
            // 
            this.btnVisitedPatList.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVisitedPatList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitedPatList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitedPatList.ForeColor = System.Drawing.Color.White;
            this.btnVisitedPatList.Location = new System.Drawing.Point(5, 782);
            this.btnVisitedPatList.Name = "btnVisitedPatList";
            this.btnVisitedPatList.Size = new System.Drawing.Size(214, 33);
            this.btnVisitedPatList.TabIndex = 229;
            this.btnVisitedPatList.Text = "Prescribed Patient\'s List";
            this.btnVisitedPatList.UseVisualStyleBackColor = false;
            this.btnVisitedPatList.Click += new System.EventHandler(this.btnVisitedPatList_Click);
            // 
            // btnCancelTicket
            // 
            this.btnCancelTicket.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelTicket.ForeColor = System.Drawing.Color.White;
            this.btnCancelTicket.Location = new System.Drawing.Point(225, 782);
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.Size = new System.Drawing.Size(191, 33);
            this.btnCancelTicket.TabIndex = 230;
            this.btnCancelTicket.Text = "Cancel from Queue";
            this.btnCancelTicket.UseVisualStyleBackColor = false;
            this.btnCancelTicket.Click += new System.EventHandler(this.btnCancelTicket_Click);
            // 
            // groupBox38
            // 
            this.groupBox38.Controls.Add(this.smartTextBox21);
            this.groupBox38.Controls.Add(this.smartLabel49);
            this.groupBox38.Controls.Add(this.smartLabel56);
            this.groupBox38.Controls.Add(this.smartTextBox19);
            this.groupBox38.Controls.Add(this.smartTextBox20);
            this.groupBox38.Controls.Add(this.smartLabel47);
            this.groupBox38.Controls.Add(this.smartLabel55);
            this.groupBox38.Controls.Add(this.smartTextBox18);
            this.groupBox38.Controls.Add(this.groupBox37);
            this.groupBox38.Controls.Add(this.smartLabel48);
            this.groupBox38.Controls.Add(this.smartTextBox17);
            this.groupBox38.Controls.Add(this.smartLabel46);
            this.groupBox38.Location = new System.Drawing.Point(565, 779);
            this.groupBox38.Name = "groupBox38";
            this.groupBox38.Size = new System.Drawing.Size(48, 42);
            this.groupBox38.TabIndex = 109;
            this.groupBox38.TabStop = false;
            this.groupBox38.Text = "groupBox38";
            this.groupBox38.Visible = false;
            // 
            // frmPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1475, 847);
            this.Controls.Add(this.groupBox38);
            this.Controls.Add(this.btnCancelTicket);
            this.Controls.Add(this.btnVisitedPatList);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.chkFamilyHis1);
            this.Controls.Add(this.chkPMedHis1);
            this.Controls.Add(this.chkPSurgHis1);
            this.Controls.Add(this.chkOtherDisease1);
            this.Controls.Add(this.cboTicketType);
            this.Controls.Add(this.txtDoctorID);
            this.Controls.Add(this.txtDiseaseCase);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtDepartmentUnit);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.txtHCN);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtAgeHours);
            this.Controls.Add(this.txtAgeYears);
            this.Controls.Add(this.txtAgeDays);
            this.Controls.Add(this.txtAgeMonths);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmPrescription";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrescription_FormClosing);
            this.Load += new System.EventHandler(this.frmPrescription_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPrescription_Paint);
            this.Controls.SetChildIndex(this.txtAgeMonths, 0);
            this.Controls.SetChildIndex(this.txtAgeDays, 0);
            this.Controls.SetChildIndex(this.txtAgeYears, 0);
            this.Controls.SetChildIndex(this.txtAgeHours, 0);
            this.Controls.SetChildIndex(this.txtSex, 0);
            this.Controls.SetChildIndex(this.txtPatientName, 0);
            this.Controls.SetChildIndex(this.txtHCN, 0);
            this.Controls.SetChildIndex(this.txtDepartmentName, 0);
            this.Controls.SetChildIndex(this.txtDepartmentUnit, 0);
            this.Controls.SetChildIndex(this.txtDepartment, 0);
            this.Controls.SetChildIndex(this.txtDoctorName, 0);
            this.Controls.SetChildIndex(this.txtDiseaseCase, 0);
            this.Controls.SetChildIndex(this.txtDoctorID, 0);
            this.Controls.SetChildIndex(this.cboTicketType, 0);
            this.Controls.SetChildIndex(this.chkOtherDisease1, 0);
            this.Controls.SetChildIndex(this.chkPSurgHis1, 0);
            this.Controls.SetChildIndex(this.chkPMedHis1, 0);
            this.Controls.SetChildIndex(this.chkFamilyHis1, 0);
            this.Controls.SetChildIndex(this.tabControl2, 0);
            this.Controls.SetChildIndex(this.btnVisitedPatList, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnCancelTicket, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.groupBox38, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tabNewPrescription.ResumeLayout(false);
            this.tbNP.ResumeLayout(false);
            this.tbHistory.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel1.PerformLayout();
            this.splitContainer8.Panel2.ResumeLayout(false);
            this.splitContainer8.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tbRx.ResumeLayout(false);
            this.tbPediatric.ResumeLayout(false);
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            this.groupBox36.ResumeLayout(false);
            this.groupBox36.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.tbGynOBS.ResumeLayout(false);
            this.groupBox34.ResumeLayout(false);
            this.groupBox34.PerformLayout();
            this.groupBox35.ResumeLayout(false);
            this.groupBox35.PerformLayout();
            this.groupBox37.ResumeLayout(false);
            this.groupBox37.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.groupBox38.ResumeLayout(false);
            this.groupBox38.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrescriptionNo;
        private System.Windows.Forms.Button btnPatientSearch;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSex;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPatientName;
        private AtiqsControlLibrary.SmartTab tabNewPrescription;
        private System.Windows.Forms.TabPage tbRx;
        private AtiqsControlLibrary.SmartListViewDetails lvTicketList;
        private System.Windows.Forms.Panel panel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDoctorName;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDepartmentName;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDepartment;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDoctorID;
        private AtiqsControlLibrary.SmartTextBox txtHCN;
        private AtiqsControlLibrary.SmartTextBox txtDepartmentUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel14;
        private AtiqsControlLibrary.SmartLabel smartLabel15;
        private AtiqsControlLibrary.SmartNumericTextBox txtNextVisitYear;
        private AtiqsControlLibrary.SmartNumericTextBox txtNextVisitMonth;
        private AtiqsControlLibrary.SmartNumericTextBox txtNextVisitDay;
        private AtiqsControlLibrary.SmartComboBox cboTicketType;
        private TreeViewControl treePatientHistory;
        private System.Windows.Forms.Label LocalSourceFile1;
        private System.Windows.Forms.Label lblDeptDoctor1;
        private System.Windows.Forms.Label lblComplaints1;
        private AtiqsControlLibrary.SmartDateTextBox txtNextVisit;
        private System.Windows.Forms.LinkLabel lblBusy;
        private System.Windows.Forms.LinkLabel lblVisit;
        private System.Windows.Forms.LinkLabel lblFree;
        private System.Windows.Forms.LinkLabel lblRefresh;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Timer timer1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeHours;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeDays;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeMonths;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeYears;
        private AtiqsControlLibrary.SmartListViewDetails smartListViewDetails1;
        private TreeViewControl treePatientHistory1;
        private System.Windows.Forms.Label lblComplaints;
        private System.Windows.Forms.Label lblDeptDoctor;
        private System.Windows.Forms.Label lblPatientName;
        private AtiqsControlLibrary.SmartLabel llblBMI;
        private AtiqsControlLibrary.SmartLabel lblBMIStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AtiqsControlLibrary.SmartLabel lblHeightFeet;
        private AtiqsControlLibrary.SmartLabel lblWeighPound;
        private System.Windows.Forms.TabPage tabPage2;
        private AtiqsControlLibrary.SmartLabel lblHeightCM;
        private AtiqsControlLibrary.SmartLabel lblWeightKg;
        private AtiqsControlLibrary.SmartLabel smartLabel16;
        private System.Windows.Forms.Label lblBMIStatusList;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtBMI;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtWeightS;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtHeightS;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtWeightM;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtHeightM;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtTemp;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtBP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private System.Windows.Forms.Panel panel4;
        private AtiqsControlLibrary.SmartCheckBox chkReferTo;
        private AtiqsControlLibrary.SmartComboBox cboDoctor;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private System.Windows.Forms.TabPage tbHistory;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox9;
        private AtiqsControlLibrary.SmartCheckBox chkDiagHere;
        private AtiqsControlLibrary.SmartLabel smartLabel38;
        private AtiqsControlLibrary.SmartDateTextBox txtHDiagDate;
        private AtiqsControlLibrary.SmartLabel smartLabel37;
        private AtiqsControlLibrary.SmartComboBox cboCaseID;
        private AtiqsControlLibrary.SmartLabel smartLabel17;
        private AtiqsControlLibrary.SmartListViewDetails lvPatientsHistory;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox10;
        private AtiqsControlLibrary.SmartTextBox smartTextBox3;
        private AtiqsControlLibrary.SmartLabel smartLabel60;
        private AtiqsControlLibrary.SmartLabel smartLabel58;
        private AtiqsControlLibrary.SmartNumericTextBox smartNumericTextBox1;
        private AtiqsControlLibrary.SmartComboBox smartComboBox7;
        private AtiqsControlLibrary.SmartLabel smartLabel57;
        private AtiqsControlLibrary.SmartComboBox smartComboBox1;
        private AtiqsControlLibrary.SmartLabel smartLabel59;
        private AtiqsControlLibrary.SmartListViewDetails smartListViewDetails2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartLabel smartLabel50;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox22;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox13;
        private AtiqsControlLibrary.SmartLabel smartLabel51;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox6;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox18;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox12;
        private AtiqsControlLibrary.SmartLabel smartLabel52;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox7;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox19;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox11;
        private AtiqsControlLibrary.SmartLabel smartLabel53;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox8;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox20;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox10;
        private AtiqsControlLibrary.SmartLabel smartLabel54;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox9;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox21;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox17;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox2;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox5;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox14;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox16;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox3;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox4;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox15;
        private System.Windows.Forms.GroupBox groupBox3;
        private AtiqsControlLibrary.SmartTextBox smartTextBox4;
        private AtiqsControlLibrary.SmartTextBox smartTextBox1;
        private AtiqsControlLibrary.SmartLabel smartLabel18;
        private AtiqsControlLibrary.SmartLabel smartLabel19;
        private AtiqsControlLibrary.SmartNumericTextBox smartNumericTextBox2;
        private AtiqsControlLibrary.SmartLabel smartLabel20;
        private AtiqsControlLibrary.SmartComboBox smartComboBox3;
        private AtiqsControlLibrary.SmartLabel smartLabel21;
        private AtiqsControlLibrary.SmartComboBox smartComboBox2;
        private AtiqsControlLibrary.SmartTextBox txtOtherInfoOfDisease;
        private AtiqsControlLibrary.SmartListViewDetails smartListViewDetails3;
        private AtiqsControlLibrary.SmartLabel smartLabel24;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox63;
        private AtiqsControlLibrary.SmartComboBox cboFrequency;
        private AtiqsControlLibrary.SmartNumericTextBox txtFrequency;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private AtiqsControlLibrary.SmartComboBox smartComboBox5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TabPage tbNP;
        private System.Windows.Forms.Button btnOtherComplaints;
        private AtiqsControlLibrary.SmartListViewDetails lvOtherComplaints;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnComplaints;
        private System.Windows.Forms.Button btnAddInvestigation;
        private System.Windows.Forms.Button btnAddDrugs;
        private AtiqsControlLibrary.SmartListViewDetails lvDrugs;
        private System.Windows.Forms.Button btnAddAdvice;
        private System.Windows.Forms.Button btnDiagnosis;
        public AtiqsControlLibrary.SmartListViewDetails lvSelectedTests;
        private AtiqsControlLibrary.SmartListViewDetails lvAdvicePrescription;
        private AtiqsControlLibrary.SmartListViewDetails lvComplaints;
        private AtiqsControlLibrary.SmartListViewDetails lvCollectedClinicalDiagnosis;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox30;
        private AtiqsControlLibrary.SmartLabel smartLabel32;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox62;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox61;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox59;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox60;
        private System.Windows.Forms.GroupBox groupBox29;
        private AtiqsControlLibrary.SmartLabel smartLabel25;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox54;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox53;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox52;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox51;
        private System.Windows.Forms.GroupBox groupBox28;
        private AtiqsControlLibrary.SmartLabel smartLabel31;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox58;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox57;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox56;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox55;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox27;
        private AtiqsControlLibrary.SmartLabel smartLabel23;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox50;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox49;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox48;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox47;
        private System.Windows.Forms.GroupBox groupBox24;
        private AtiqsControlLibrary.SmartLabel smartLabel22;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox46;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox45;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox44;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox35;
        private System.Windows.Forms.GroupBox groupBox26;
        private AtiqsControlLibrary.SmartLabel smartLabel30;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox32;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox29;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox26;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox23;
        private System.Windows.Forms.GroupBox groupBox25;
        private AtiqsControlLibrary.SmartLabel smartLabel28;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox33;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox30;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox27;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox24;
        private System.Windows.Forms.GroupBox groupBox23;
        private AtiqsControlLibrary.SmartLabel smartLabel29;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox43;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox40;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox39;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox36;
        private System.Windows.Forms.GroupBox groupBox22;
        private AtiqsControlLibrary.SmartLabel smartLabel27;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox34;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox31;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox28;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox25;
        private System.Windows.Forms.GroupBox groupBox21;
        private AtiqsControlLibrary.SmartLabel smartLabel26;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox42;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox41;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox38;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox37;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.CheckBox chkAllergy1;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.CheckBox chkKidneyDisease1;
        private System.Windows.Forms.CheckBox chkHeartDisease1;
        private System.Windows.Forms.CheckBox chkHypertension1;
        private System.Windows.Forms.CheckBox chkDiabetes1;
        private System.Windows.Forms.CheckBox chkAsthma1;
        private AtiqsControlLibrary.SmartLabel smartLabel35;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtBpP2;
        private System.Windows.Forms.Panel panel17;
        private AtiqsControlLibrary.SmartLabel smartLabel36;
        private System.Windows.Forms.Label label4;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox65;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox64;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AtiqsControlLibrary.SmartCheckBox chkAllergy;
        private System.Windows.Forms.TextBox txtAllergy;
        private AtiqsControlLibrary.SmartTextBox smartTextBox6;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private AtiqsControlLibrary.SmartCheckBox chkKidneyDisease;
        private System.Windows.Forms.TextBox txtKidneyDisease;
        private AtiqsControlLibrary.SmartLabel smartLabel33;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private AtiqsControlLibrary.SmartCheckBox chkHeartDisease;
        private System.Windows.Forms.TextBox txtHeartDisease;
        private AtiqsControlLibrary.SmartTextBox smartTextBox7;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private AtiqsControlLibrary.SmartCheckBox chkHypertension;
        private System.Windows.Forms.TextBox txtHypertension;
        private AtiqsControlLibrary.SmartLabel smartLabel34;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private AtiqsControlLibrary.SmartCheckBox chkDiabetes;
        private System.Windows.Forms.TextBox txtDiabetes;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private AtiqsControlLibrary.SmartCheckBox chkAsthma;
        private System.Windows.Forms.TextBox txtAsthma;
        private System.Windows.Forms.Button btnCFValue;
        private AtiqsControlLibrary.SmartListViewDetails lvClinicalFindings;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private AtiqsControlLibrary.SmartCheckBox chkOtherDisease;
        private System.Windows.Forms.TextBox txtOtherDisease;
        private System.Windows.Forms.CheckBox chkOtherDisease1;
        private System.Windows.Forms.GroupBox groupBox8;
        private AtiqsControlLibrary.SmartTextBox smartTextBox8;
        private AtiqsControlLibrary.SmartLabel smartLabel41;
        private AtiqsControlLibrary.SmartTextBox smartTextBox9;
        private AtiqsControlLibrary.SmartLabel smartLabel42;
        private System.Windows.Forms.GroupBox groupBox7;
        private AtiqsControlLibrary.SmartTextBox smartTextBox2;
        private AtiqsControlLibrary.SmartLabel smartLabel39;
        private AtiqsControlLibrary.SmartTextBox smartTextBox5;
        private AtiqsControlLibrary.SmartLabel smartLabel40;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox txtPMedHis;
        private System.Windows.Forms.TextBox txtPSurgHis;
        private AtiqsControlLibrary.SmartCheckBox chkPSurgHis;
        private AtiqsControlLibrary.SmartCheckBox chkPMedHis;
        private System.Windows.Forms.CheckBox chkPSurgHis1;
        private System.Windows.Forms.CheckBox chkPMedHis1;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox txtFamilyHis;
        private AtiqsControlLibrary.SmartCheckBox chkFamilyHis;
        private AtiqsControlLibrary.SmartTextBox smartTextBox10;
        private AtiqsControlLibrary.SmartLabel smartLabel43;
        private AtiqsControlLibrary.SmartTextBox smartTextBox11;
        private AtiqsControlLibrary.SmartLabel smartLabel44;
        private System.Windows.Forms.Panel panel19;
        private AtiqsControlLibrary.SmartCheckBox chkFamilyHis1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDiseaseCase;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtOFC;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtBSA;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSPOTWO;
        private System.Windows.Forms.Panel panel20;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private System.Windows.Forms.TabPage tbPediatric;
        private System.Windows.Forms.GroupBox groupBox33;
        private System.Windows.Forms.RadioButton rdoEecoHis;
        private AtiqsControlLibrary.SmartTextBox txtEcoHis;
        private System.Windows.Forms.GroupBox groupBox32;
        private System.Windows.Forms.RadioButton rdoImmuMiss;
        private System.Windows.Forms.RadioButton rdoImmuUTD;
        private AtiqsControlLibrary.SmartTextBox txtImmu;
        private System.Windows.Forms.GroupBox groupBox36;
        private System.Windows.Forms.RadioButton rdoMSTNDelay;
        private System.Windows.Forms.RadioButton rdoMSTNAppro;
        private AtiqsControlLibrary.SmartTextBox txtMSTNDev;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBox31;
        private System.Windows.Forms.RadioButton rdoPostNCom;
        private System.Windows.Forms.RadioButton rdoPostNUn;
        private AtiqsControlLibrary.SmartTextBox txtPostNatal;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.RadioButton rdoNatalCS;
        private System.Windows.Forms.RadioButton rdoNatalN;
        private AtiqsControlLibrary.SmartTextBox txtNatal;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.RadioButton rdoAntenatalAbN;
        private System.Windows.Forms.RadioButton rdoAntenatalN;
        private AtiqsControlLibrary.SmartTextBox txtAntenatal;
        private System.Windows.Forms.Label label5;
        private AtiqsControlLibrary.SmartTextBox txtCompFeedHis2;
        private AtiqsControlLibrary.SmartTextBox txtPresFeed;
        private AtiqsControlLibrary.SmartCheckBox chkExFeed;
        private AtiqsControlLibrary.SmartTextBox txtExFeedHis;
        private AtiqsControlLibrary.SmartCheckBox chkPresentFeed;
        private AtiqsControlLibrary.SmartCheckBox chkCompFeed;
        private AtiqsControlLibrary.SmartTextBox txtCompFeedHis1;
        private System.Windows.Forms.Button btnVisitedPatList;
        private System.Windows.Forms.Button btnCancelTicket;
        private System.Windows.Forms.TabPage tbGynOBS;
        private System.Windows.Forms.GroupBox groupBox34;
        private System.Windows.Forms.TextBox txtObs;
        private AtiqsControlLibrary.SmartCheckBox chkObs;
        private System.Windows.Forms.GroupBox groupBox35;
        private AtiqsControlLibrary.SmartCheckBox chkGyn;
        private System.Windows.Forms.TextBox txtGyn;
        private System.Windows.Forms.Panel panel8;
        private TreeViewControl PatientsHistoryTree;
        private AtiqsControlLibrary.SmartTextBox smartTextBox19;
        private AtiqsControlLibrary.SmartTextBox smartTextBox18;
        private AtiqsControlLibrary.SmartTextBox smartTextBox17;
        private AtiqsControlLibrary.SmartLabel smartLabel49;
        private AtiqsControlLibrary.SmartLabel smartLabel48;
        private AtiqsControlLibrary.SmartLabel smartLabel47;
        private AtiqsControlLibrary.SmartTextBox smartTextBox21;
        private AtiqsControlLibrary.SmartLabel smartLabel56;
        private AtiqsControlLibrary.SmartTextBox smartTextBox20;
        private AtiqsControlLibrary.SmartLabel smartLabel55;
        private System.Windows.Forms.GroupBox groupBox37;
        private AtiqsControlLibrary.SmartTextBox smartTextBox16;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private AtiqsControlLibrary.SmartLabel smartLabel46;
        private System.Windows.Forms.GroupBox groupBox38;

        //  private Reports.ReportUI.CachedrptSubReportOPDMedicine cachedrptSubReportOPDMedicine1;

    }
}
