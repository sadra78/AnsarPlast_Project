﻿
using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Application.Contracts.ProductCategory;

namespace ShopManagement.Domain.ProductCategoryAgg
{
    public interface IProductCategoryRepository : IRepository<long,ProductCategory>
    {
        List<ProductCategoryViewModel> getProductCategories();
        EditProductCategory GetDetails(long id);
        string GetCategorySlugBy(long id);
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);
    }
}
