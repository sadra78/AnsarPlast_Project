using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagement.Application.Contracts.Order;

namespace _01_AnsarPlastQuery.Contracts.Product
{
    public interface IProductQuery
    {
        ProductQueryModel GetProductDetailsBy(string slug);
        List<ProductQueryModel> GetLatesProducts();
        int GetProductCount();
        List<ProductQueryModel> Search(string value);
        List<CartItem> checkInventoryStatus(List<CartItem> cartItems);
    }
}
