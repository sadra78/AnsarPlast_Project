namespace _01_AnsarPlastQuery.Contracts.Product
{
    public class ProductPictureQueryModel
    {
        public long ProductId { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public bool IsRemoved { get; set; }
       // public ShopManagement.Domain.ProductAgg.Product Product { get; set; }
    }
}