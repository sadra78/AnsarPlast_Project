using System;
using _0_Framework.Domain;

namespace DiscountManagement.Domain.DiscountCodeAgg
{
    public class DiscountCode : EntityBase
    {
        public int DiscountRate { get; private set; }
        public string CodeDiscount { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string Reason { get; private set; }

        public DiscountCode(int discountRate, string codeDiscount, DateTime startDate, DateTime endDate, string reason)
        {
            DiscountRate = discountRate;
            CodeDiscount = codeDiscount;
            StartDate = startDate;
            EndDate = endDate;
            Reason = reason;
        }

        public void Edit(int discountRate, string codeDiscount, DateTime startDate, DateTime endDate, string reason)
        {
            DiscountRate = discountRate;
            CodeDiscount = codeDiscount;
            StartDate = startDate;
            EndDate = endDate;
            Reason = reason;
        }
    }
    
}