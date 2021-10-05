using System.Collections.Generic;
using _01_AnsarPlastQuery.Contracts.Comment;

namespace _01_AnsarPlastQuery.Contracts.Product
{
    public class ProductQueryModel
    {

        public long Id { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string PriceWithDiscount { get; set; }
        public int DiscountRate { get; set; }
        public string Category { get; set; }
        public string Slug { get; set; }
        public bool HasDiscount { get; set; }
        public string CategorySlug { get; set; }
        public string DiscountExp_Date { get; set; }
        public string Code { get; set; }
        public long CategoryId { get; set; }
        public string Keyword { get; set; }
        public string MetaDescription { get; set; }
        public bool IsInStock { get; set; }
        public List<CommentQueryModel> Comments { get; set; }
        public List<ProductPictureQueryModel> Pictures { get; set; }
    }
}