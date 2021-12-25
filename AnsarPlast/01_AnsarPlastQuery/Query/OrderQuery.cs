using System.Collections.Generic;
using System.Linq;
using _01_AnsarPlastQuery.Contracts.Order;
using ShopManagement.Application.Contracts.Order;
using ShopManagement.Infrastructure.EFCore;

namespace _01_AnsarPlastQuery.Query
{
    public class OrderQuery : IOrderQuery
    {
        private readonly ShopContext _shopContext;

        public OrderQuery(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public List<OrderQueryModel> GetOrders()
        {
            return _shopContext.Orders.Where(x => !x.IsCanceled).Select(x => new OrderQueryModel
            {
                Id = x.Id,
                TotalAmount = x.TotalAmount,
                DiscountAmount = x.DiscountAmount,
                PayAmount = x.PayAmount,
                IsPaied = x.IsPaied,
                IsCanceled = x.IsCanceled
            }).ToList();
        }
    }
}