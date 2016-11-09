using System;
using System.Collections.Generic;
using System.Text;
using DSL.POS.DTO.Common.DTO;

namespace DSL.POS.DTO.DTO
{
    public class OpeningBalanceDTO : CommonDTO 
    {
        private Guid guP_PK;
        private DateTime dtOpeningDate;
        private decimal dcmOpeningQty;
        private decimal dcmOpeningRate;
        private decimal dcmOpeningDiscount;

        public Guid P_PK
        {
            set 
            {
                guP_PK = value;
            }
            get 
            {
                return guP_PK;
            }
        }
        public DateTime OpeningDate
        {
            set
            {
                dtOpeningDate = value;
            }
            get
            {
                return dtOpeningDate;
            }
        }
        public decimal OpeningQty
        {
            set
            {
                dcmOpeningQty = value;
            }
            get
            {
                return dcmOpeningQty;
            }
        }
        public decimal OpeningRate
        {
            set
            {
                dcmOpeningRate = value;
            }
            get
            {
                return dcmOpeningRate;
            }
        }
        public decimal OpeningDiscount
        {
            set
            {
                dcmOpeningDiscount = value;
            }
            get
            {
                return dcmOpeningDiscount;
            }
        }
    }
}
