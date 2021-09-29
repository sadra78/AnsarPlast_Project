using System.Collections.Generic;

namespace _01_AnsarPlastQuery.Contracts.ProductCategory
{
    public interface IProductCategoryQuery
    {
        ProductCategoryQueryModel GetProductCategoryWithProductsBy(string slug);
        List<ProductCategoryQueryModel> GetProductCategories();
        List<ProductCategoryQueryModel> GetProductCategoriesWirhProducts();
    }
}