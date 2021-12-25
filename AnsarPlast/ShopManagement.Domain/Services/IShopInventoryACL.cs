using System.Collections.Generic;
using ShopManagement.Domain.OrderAgg;

namespace ShopManagement.Domain.Services
{
    public interface IShopInventoryACL
    {
        bool ReduceFromInventory(List<OrderItem> items);
    }
}