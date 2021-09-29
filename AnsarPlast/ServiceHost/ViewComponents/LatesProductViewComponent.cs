using _01_AnsarPlastQuery.Contracts.Product;
using _01_AnsarPlastQuery.Contracts.ProductCategory;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class LatesProductViewComponent : ViewComponent
    {
        private readonly IProductQuery _productQuery;

        public LatesProductViewComponent(IProductQuery productQuery)
        {
            _productQuery = productQuery;
        }

        public IViewComponentResult Invoke()
        {
            var latesProducts = _productQuery.GetLatesProducts();
            return View(latesProducts);
        }
    }
}
