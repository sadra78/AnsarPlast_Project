using System;

namespace DiscountManagement.Application.Contract.DiscountCode
{
    public class DiscountCodeViewModel
    {
        public long Id { get; set; }
        public int DiscountRate { get; set; }
        public string CodeDiscount { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public DateTime StartDateGr { get; set; }
        public DateTime EndDateGr { get; set; }
        public string Reason { get; set; }
        public string CreationDate { get; set; }
    }
}