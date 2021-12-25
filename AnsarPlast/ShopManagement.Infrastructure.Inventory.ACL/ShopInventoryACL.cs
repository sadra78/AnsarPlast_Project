using System;
using System.Collections.Generic;
using System.Linq;
using InventoryManagement.Application.Contract.Inventory;
using ShopManagement.Domain.OrderAgg;
using ShopManagement.Domain.Services;

namespace ShopManagement.Infrastructure.Inventory.ACL
{
    public class ShopInventoryACL :IShopInventoryACL
    {
        private readonly IInventoryApplication _inventoryApplication;

        public ShopInventoryACL(IInventoryApplication inventoryApplication)
        {
            _inventoryApplication = inventoryApplication;
        }

        public bool ReduceFromInventory(List<OrderItem> items)
        {
            var command = items.Select(orderItem =>
                new ReduceInventory(orderItem.ProductId, orderItem.Count, "خرید مشتری", orderItem.OrderId)).ToList();

            return _inventoryApplication.Reduce(command).IsSuccedded;
        }
    }
}
