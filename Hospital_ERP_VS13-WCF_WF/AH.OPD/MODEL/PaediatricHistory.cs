using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.OPD.MODEL
{
    public class PaediatricHistory
    {
        public string Antenatal { get; set; }
        public string AntenatalText { get; set; }
        public string Natal { get; set; }
        public string NatalText { get; set; }
        public string PostNatal { get; set; }
        public string PostNatalText { get; set; }
        public string ExclusiveFeed { get; set; }
        public string ExclusiveFeedText { get; set; }
        public string CompFeed { get; set; }
        public string CompFeedText { get; set; }
        public string CompFeedWText { get; set; }
        public string PresentFeed { get; set; }
        public string PresentFeedText { get; set; }

        public string MileStoneOfDev { get; set; }
        public string MileStoneOfDevText { get; set; }

        public string Immunization { get; set; }
        public string ImmunizationText { get; set; }

        public string SocioEcoHistory  { get; set; }
        public string SocioEcoHistoryText { get; set; }

        public EntryParameter EntryParameter { set; get; }

    }
}
