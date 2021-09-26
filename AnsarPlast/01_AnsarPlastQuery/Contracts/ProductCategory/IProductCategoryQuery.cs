using System.Collections.Generic;

namespace _01_AnsarPlastQuery.Contracts.ProductCategory
{
    public interface IProductCategoryQuery
    {
        List<ProductCategoryQueryModel> getProductCategories();
    }
}