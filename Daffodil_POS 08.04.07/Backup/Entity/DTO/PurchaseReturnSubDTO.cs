using System;
using System.Collections.Generic;
using System.Text;
using DSL.POS.DTO.Common.DTO;

namespace DSL.POS.DTO.DTO
{
 public  class PurchaseReturnSubDTO : CommonDTO 
    {
        private Guid strPRM_PK;
        private Guid strP_PK;
        private decimal strReceivedQuantity;
        private decimal strItemRate;
        private decimal strDiscount;
        private string strNotes;

        public Guid PRM_PK
        {
            set { strPRM_PK = value; }
            get { return strPRM_PK; }
        }
        public Guid P_PK
        {
            set { strP_PK = value; }
            get { return strP_PK; }
        }
        public decimal ReceivedQuantity
        {
            set { strReceivedQuantity = value; }
            get { return strReceivedQuantity; }
        }
        public decimal ItemRate
        {
            set { strItemRate = value; }
            get { return strItemRate; }
        }
        public decimal Discount
        {
            set { strDiscount = value; }
            get { return strDiscount; }
        }
        public string Notes
        {
            set { strNotes = value; }
            get { return strNotes; }
        }

    }
}
