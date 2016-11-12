using AH.DUtility;
using AH.ModuleController.IPDSR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AH.ModuleController.UI.IPD.Forms
{
    
   public class PatientAdmissionUtility
   {
       IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
       public List<Bed> oCleanBedList;
       string MasterCode = Utility.GetMasterChargeCode(Utility.ChargesCode.BedCharges);
       public void FormatListForBed(ListView lv)
       {
           lv.CheckBoxes = false;
           lv.Columns.Add("RevenueHeadGroup", 0, HorizontalAlignment.Left);
           lv.Columns.Add("RevenueHeadCode", 0, HorizontalAlignment.Left);
           lv.Columns.Add("RevenueHeadTitle", 150, HorizontalAlignment.Left);
           lv.Columns.Add("RevenueHeadGroupID", 0, HorizontalAlignment.Left);
           lv.Columns.Add("RevenueHeadGroupTitle", 200, HorizontalAlignment.Left);
           lv.Columns.Add("Amount", 100, HorizontalAlignment.Left);
       }
       public void FormatListBedForBedInformation(ListView lst)
       {
           lst.CheckBoxes = false;
           lst.Columns.Add("Admission", 160, HorizontalAlignment.Left);
           lst.Columns.Add("BedType", 160, HorizontalAlignment.Left);
          // lst.Columns.Add("BedCategoryType", 110, HorizontalAlignment.Left);
           lst.Columns.Add("Bed No", 80, HorizontalAlignment.Left);
           lst.Columns.Add("Release Date", 160, HorizontalAlignment.Left);
           lst.Columns.Add("Staying Days", 50, HorizontalAlignment.Left);
           lst.Columns.Add("Bed Charges", 90, HorizontalAlignment.Right);
           lst.Columns.Add("Amount", 80, HorizontalAlignment.Right);
           lst.Columns.Add("Department", 100, HorizontalAlignment.Left);
           lst.Columns.Add("Unit", 140, HorizontalAlignment.Left);          
           lst.Columns.Add("serial", 0, HorizontalAlignment.Right);

       }
       public void LoadListViewBed(ListView lst,string regno)
       {
           lst.Items.Clear();

           List<InPatient> bdh = ipdSc.GetBedHist(regno).ToList();
           foreach (InPatient bdhs in bdh)
           {
               ListViewItem itm = new ListViewItem(bdhs.AdmissionDate.ToString());
               itm.SubItems.Add(bdhs.Bed.BedType.Title+"-"+bdhs.Bed.BedType.BedFacility.Title);           
               itm.SubItems.Add(bdhs.Bed.BedNo.ToString());              
               itm.SubItems.Add(bdhs.DischargeDate.ToString());
               itm.SubItems.Add(bdhs.Bed.NoOfDays.ToString());         
               itm.SubItems.Add(bdhs.Bed.BedChargesString.ToString());
               itm.SubItems.Add((Convert.ToInt32(bdhs.Bed.BedChargesString) * (bdhs.Bed.NoOfDays)).ToString());          
               itm.SubItems.Add(bdhs.Department.DepartmentTitle.ToString());
               itm.SubItems.Add(bdhs.DepartmentUnit.UnitTitle);
               itm.SubItems.Add(bdhs.Bed.SerialNo.ToString()); 
               lst.Items.Add(itm);

           }
       }
        

       public void FormatListDept(ListView lst)
       {
           lst.CheckBoxes = false;
           lst.Columns.Add("Department Name", 150, HorizontalAlignment.Left);
           lst.Columns.Add("Unit Name", 160, HorizontalAlignment.Left);
           lst.Columns.Add("Admission Date", 160, HorizontalAlignment.Left);
           lst.Columns.Add("Release Date", 160, HorizontalAlignment.Left);

       }
       public void LoadListViewDept(ListView lst,string regno)
       {
           lst.Items.Clear();

           List<InPatient> depts = ipdSc.GetDeptHistory(regno).ToList();
           foreach (InPatient dpt in depts)
           {
               ListViewItem itm = new ListViewItem(dpt.Department.DepartmentTitle.ToString());
               itm.SubItems.Add(dpt.DepartmentUnit.UnitTitle);
               itm.SubItems.Add(dpt.AdmissionDate.ToString());
               itm.SubItems.Add(dpt.DischargeDate.ToString());
               lst.Items.Add(itm);
           }

       }
       public void FormatGridReport(ListView lst)
       {
           lst.CheckBoxes = false;
           lst.Columns.Add("Service Name", 200, HorizontalAlignment.Left);
           lst.Columns.Add("Amount", 100, HorizontalAlignment.Right);
       }
       
       public void FormatAdvancePaymentList(ListView lst)
       {
           lst.CheckBoxes = false;
           lst.Columns.Add("Deposit Date", 160, HorizontalAlignment.Center);
           lst.Columns.Add("Deposit Type", 200, HorizontalAlignment.Left);
           lst.Columns.Add("Amount", 200, HorizontalAlignment.Right);
           lst.Columns.Add("Transaction No", 300, HorizontalAlignment.Center);

       }
       public void LoadAdnceListView(ListView lst,string regNo)
       {
           lst.Items.Clear();
           List<OPDPayment> adv = ipdSc.GetAdvPay(regNo).ToList();

           foreach (OPDPayment adpay in adv)
           {
               ListViewItem itm = new ListViewItem(adpay.EntryDate.ToString("dd-MM-yyyy"));
               itm.SubItems.Add(adpay.DepositType.ToString());
               itm.SubItems.Add(adpay.Amount.ToString());
               itm.SubItems.Add(adpay.TransactionNo.ToString());
               lst.Items.Add(itm);
               //  amount = +(Convert.ToInt32(adpay.Amount));
           }

       }

       public void LoadListView(ListView lv, string bedCategoryTypeId)
       {
           lv.Items.Clear();
           List<BedCharges> bdc = ipdSc.GetBedRateSetup(bedCategoryTypeId, MasterCode).ToList();
           foreach (BedCharges bedch in bdc)
           {
               ListViewItem itm = new ListViewItem(bedch.RevenueHead.ID);
               itm.SubItems.Add(bedch.RevenueHead.ID);
               itm.SubItems.Add(bedch.RevenueHead.Title);
               itm.SubItems.Add(bedch.RevenueHeadGroup.ID);
               itm.SubItems.Add(bedch.RevenueHeadGroup.Title);
               itm.SubItems.Add(bedch.Amount.ToString());
               lv.Items.Add(itm);
           }

       }
       public void ComboDepartment(ComboBox cbo)
       {
           cbo.DisplayMember = "Value";
           cbo.ValueMember = "Key";
           cbo.DataSource = new BindingSource(Utility.VerifyDic(ipdSc.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical))), null);

       }

       public void cboBedType(ComboBox cbo)
       {
           cbo.DisplayMember = "Value";
           cbo.ValueMember = "Key";
           cbo.DataSource = new BindingSource(ipdSc.GetBedtypeDict("D"), null);
       }
       public void cboWard(ComboBox cbo)
       {
           cbo.DisplayMember = "Value";
           cbo.ValueMember = "Key";
           cbo.DataSource = new BindingSource(ipdSc.GetWards("D"), null);
       }

       public void cboReceivingNurseStation(ComboBox cbo)
       {
           cbo.DisplayMember = "Value";
           cbo.ValueMember = "Key";
           cbo.DataSource = new BindingSource(Utility.VerifyDic(ipdSc.GetNurseStationDic("E")), null);
       }
       public void cboUnit(ComboBox cbo, string department)
       {
           cbo.DisplayMember = "Value";
           cbo.ValueMember = "Key";
           cbo.DataSource = new BindingSource(Utility.VerifyDic(ipdSc.GetDeptUnitDic(Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical), department)), null);
       }
       public void cboBed(ComboBox cbo, string cboWard, string cboBedType, string cboRoomNo)
       {
           cbo.DisplayMember = "Value";
           cbo.ValueMember = "Key";
        
       }
       public void cboDischargeType(ComboBox cbo)
       {
           cbo.DisplayMember = "Value";
           cbo.ValueMember = "Key";
           cbo.DataSource = new BindingSource(Utility.VerifyDic(Utility.GetReleaseTypes()), null);
       }

       public void cboBedTypeCategory(ComboBox cbo,string bedType)
       {
           oCleanBedList = ipdSc.GetBedSets(bedType, "C").ToList();
           var oBedTypeCategories = oCleanBedList.GroupBy(x => x.Facility.ID).Select(g => g.First()).ToList();
           List<BedFacility> oBedFacility = new List<BedFacility>();
           foreach (var type in oBedTypeCategories)
           {
               BedFacility otype = new BedFacility();
               otype.ID = type.Facility.ID;
               otype.Title = type.Facility.Title;
               oBedFacility.Add(otype);
           }
           cbo.DisplayMember = "Title";
           cbo.ValueMember = "ID";
           cbo.DataSource = new BindingSource(oBedFacility, null);
       }
       public void getBeds(ComboBox cbo, string bedType, string bedTypeCategory)
       {
           List<Bed> oBeds = new List<Bed>();
           var oBedNoList = (from bed in oCleanBedList
                             where (bed.BedType.ID == bedType) && (bed.Facility.ID == bedTypeCategory)
                             select bed);
           foreach (Bed oBed in oBedNoList)
           {
               Bed iBed = new Bed();
               iBed.BedID = oBed.BedID;
               iBed.BedTitle = oBed.BedTitle;
               oBeds.Add(iBed);
           }
           cbo.DisplayMember = "BedTitle";
           cbo.ValueMember = "BedID";
           cbo.DataSource = new BindingSource(oBeds, null);

       }
       public List<Bed> getFloorAndRoom(string bedNo)
       {
           List<Bed> oBedNoList = new List<Bed>();
           oBedNoList = (from bed in oCleanBedList
                         where bed.BedID == bedNo
                         select bed).ToList();

           return oBedNoList;
       }

    }

}


