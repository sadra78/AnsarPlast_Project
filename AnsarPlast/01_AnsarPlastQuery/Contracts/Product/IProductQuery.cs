using System.Collections.Generic;
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
        List<Wishlist> GetDetailsWishlist(List<Wishlist> wishLists);
    }
}
