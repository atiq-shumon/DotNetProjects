using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.ModuleController.UI.DMS.Reports.Viewer
{
    public enum ViewerSelector
    {
        Admission, DMSTestDetails, DMSMoneyReceipt, DueMoneyReceipt, DueList, TotalCollection, UserWiseCollection, ResultHead,ResHead, TestDetails, IntegretedVoucherReport, RefundMoneyReceipt,TestUnderPanel,
        RefundMoneyReceiptReport, TestCancelReport, DoctorWiseDiagnosticCollectionDetails, DoctorWiseDiagnosticCollectionSummary,AllPanelTest,ResultHeadUnderTest,AllTestByHCN,AllTestByHCNDate,
        UserWiseCashCollection,AllCollectionSummary,AllTestOfPatient,TestMainWiseTestDetails,EmergencyMR
    }
}
