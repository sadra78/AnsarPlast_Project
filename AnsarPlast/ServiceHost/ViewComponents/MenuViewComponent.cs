using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_AnsarPlastQuery.Contracts.ProductCategory;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IProductCategoryQuery _productCategoryQuery;

        public MenuViewComponent(IProductCategoryQuery productCategoryQuery)
        {
            _productCategoryQuery = productCategoryQuery;
        }

        public IViewComponentResult Invoke()
        {
            var ProductCategories = _productCategoryQuery.GetProductCategories();
            return View(ProductCategories);
        }
    }
}
