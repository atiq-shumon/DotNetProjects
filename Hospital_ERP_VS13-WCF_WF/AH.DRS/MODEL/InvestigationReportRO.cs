using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.DRS.MODEL
{
   public class InvestigationReportRO
    {       
            #region properties
            public string HCN { get; set; }
            public string RegistrationNo { get; set; }
            public string MRNo { get; set; }
            public string PatientName { get; set; }
            public string Age { get; set; }
            public string Sex { get; set; }
            public string Address { get; set; }
            public string MobileNo { get; set; }
            public string HomePhone { get; set; }
            public string result_id { get; set; }
            public string SpecimenNo { get; set; }
            public string Doctorname { get; set; }
            public string DoctorDesignation { get; set; }
            public string UnitName { get; set; }
            public string DepartmentName { get; set; }
            public string WardTitle { get; set; }
            public string WardNo { get; set; }
            public string BedNo { get; set; }
            public string ReportType { get; set; }
            public string ReportGroup { get; set; }
            public string DMAdvice { get; set; }
            public string DMComments { get; set; }
            public string DMRemarks { get; set; }
            public string SampleDate { get; set; }
            public string DDResult { get; set; }
            public string DDRemarks { get; set; }
            public string HDGroup { get; set; }
            public string HDTitle { get; set; }
            public string HDLRange { get; set; }
            public string HDURange { get; set; }
            public string HDUHRange { get; set; }
            public string HDRefValue { get; set; }
            public string HDSerial { get; set; }
            public string HDUnit { get; set; }
            public string HDULRange { get; set; }
            public string MachineTitle { get; set; }
            public string VerifiedBy { get; set; }
            public string EntryBy { get; set; }
            public string ResultEntryBy { get; set; }
            public string ResultEntryDate { get; set; }
            public string MREntryBy { get; set; }
            public string MREntryDate { get; set; }
            public string VerifiedByDesignation { get; set; }
            public string FinalizeByDesignation { get; set; }
            public string TicketType { get; set; }
            public string SampleCollected { get; set; }
            public string SampleCollectedDate { get; set; }
            public string Specimen { get; set; }
            public string SampleReceivedBy { get; set; }
            public string SampleReceivedByDate { get; set; }
            public string ReportSection { get; set; }
            public string ReportSectionID {get;set;}
            public string TestMethodTitle { get; set; }
            public char IsInterpretation { get; set; }
            public string InterpretationText { get; set; }
            public string GrowthResultA { get; set; }
            public string GrowthResultB { get; set; }
            public string GrowthResultC { get; set; }
            public string ResultA { get; set; }
            public string ResultB { get; set; }
            public string ResultC { get; set; }
            public string IsGrowth { get; set; }
            public string Temperature { get; set; }
            public string FirstPart { get; set; }
            public string PowerA { get; set; }
            public string PowerB { get; set; }
            public string PowerC { get; set; }
            public string Hour { get; set; }     
            public string serial { get; set; }
            public string TestDetailID { get; set; }
            public int count { get; set; }
            public string dayHours { get; set; }
            public string IsPrint { get; set; }
            public string VerifiedByDate { get; set; }
            public string FinalizedDate { get; set; }
            public string Priority { get; set; }
            public string PrintedBY { get; set; }
            public string PrintedDate { get; set; }
            public string RePrintedBY { get; set; }
            public string RePrintedDate { get; set; }
            public char IsCancel { get; set; }
            public string CancelBy { get; set; }
            public string CancelDate { get; set; }
            #endregion
        }
    }

