using System.Collections.Generic;
using _01_AnsarPlastQuery.Contracts.Product;
using Microsoft.AspNetCore.Mvc;

namespace ShopManagement.Presentation.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductQuery _productQuery;

        public ProductController(IProductQuery productQuery)
        {
            _productQuery = productQuery;
        }

        [HttpGet]
        public List<ProductQueryModel> GetLatesProducts()
        {
            return _productQuery.GetLatesProducts();
        }
    }
}
