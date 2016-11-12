using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PRMS.MODEL;
using AH.HR.MODEL;
using AH.Shared.MODEL;
namespace AH.DTMS.MODEL
{
    public class TestSub : TestMain
    {
        public string TestSubID { set; get; }
        public string MRTestSubID { set; get; }
        public string AccCloseFlag { set; get; }
        public string AllTest { set; get; }
        public string TestSubTitle { set; get; }
        public string TestSubTitleBeng { set; get; }
        public string TestSubTitleAlias { set; get; }
        public string ShortCode{ set; get; }
        public string PanelID { set; get; }
        public string PanelTitle { set; get; }
        public short DeliveryAfter{ set; get; }
        public short DeliveryAfterHours { set; get; }
        public string Serial { set; get; }
        public string PosSerial { set; get; }
        public string TicketType { set; get; }
        public string TicketNo { set; get; }
        public string LabelGroup { set; get; }
        public string Priority { set; get; }
        public TestFee TestFee { set; get; }
        public Room Room { set; get; }
        public LabRoom LabRoom { set; get; }
        public SpecimenCollectionRoom SpecimenCollectionRoom { set; get; }
        public LabTechnologist Technologist { set; get; }
        public Specimen Specimen { set; get; }
        public TestCategory TestCategory { set; get; }
        public ReportGroup ReportGroup { set; get; }
        public ReportSection ReportSection { set; get; }
        public SpecimenHolder SpecimenHolder { set; get; }
        public TestMethod TestMethod { set; get; }

        public EntryParameter EParameter { set; get; }

    }
}
