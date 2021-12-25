namespace _01_AnsarPlastQuery.Contracts.Order
{
    public class OrderQueryModel
    {
        public long Id { get; set; }
        public double TotalAmount { get; set; }
        public double DiscountAmount { get; set; }
        public double PayAmount { get; set; }
        public bool IsPaied { get; set; }
        public bool IsCanceled { get; set; }
    }
}