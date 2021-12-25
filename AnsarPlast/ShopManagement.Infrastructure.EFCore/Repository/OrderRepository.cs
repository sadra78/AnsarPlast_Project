using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using AccountManagement.Infrastructure.EFCore;
using ShopManagement.Application.Contracts;
using ShopManagement.Application.Contracts.Order;
using ShopManagement.Domain.OrderAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class OrderRepository : RepositoryBase<long, Order>, IOrderRepository
    {
        private readonly ShopContext _context;
        private readonly AccountContext _accountContext;
        public OrderRepository(ShopContext context, AccountContext accountContext) : base(context)
        {
            _context = context;
            _accountContext = accountContext;
        }

        public double GetAmountBy(long Id)
        {
            var order = _context.Orders.Select(x => new { x.PayAmount, x.Id }).FirstOrDefault(x => x.Id == Id);
            if (order != null)
            {
                return order.PayAmount;
            }

            return 0;
        }

        public List<OrderItemViewModel> GetItems(long orderId)
        {
            var products = _context.Products.Select(x => new {x.Id,x.Name }).ToList();
            var order = _context.Orders.FirstOrDefault(x => x.Id == orderId);
            if (order == null)
            {
                return new List<OrderItemViewModel>();
            }

            var items = order.Items.Select(x => new OrderItemViewModel
            {
                ProductId = x.ProductId,
                Count = x.Count,
                UnitPrice = x.UnitPrice,
                DiscountRate = x.DiscountRate,
                OrderId = x.OrderId
            }).ToList();

            foreach (var item in items)
            {
                item.Product = products.FirstOrDefault(x => x.Id == item.ProductId)?.Name;
            }

            return items;
        }

        public List<OrderViewModel> Search(OrderSearchModel searchModel)
        {
            var accounts = _accountContext.Accounts.Select(x => new { x.Id, x.FullName }).ToList();
            var query = _context.Orders.Select(x => new OrderViewModel
            {
                Id = x.Id,
                AccountId = x.AccountId,
                PaymentMethodId = x.PaymentMethod,
                TotalAmount = x.TotalAmount,
                DiscountAmount = x.DiscountAmount,
                PayAmount = x.PayAmount,
                IsPaied = x.IsPaied,
                IsCanceled = x.IsCanceled,
                IssueTrackingNo = x.IssueTrackingNo,
                RefId = x.RefId,
                CreationDate = x.CreationDate.ToFarsi(),
            });

            query = query.Where(x => x.IsCanceled == searchModel.IsCanceled);

            if (searchModel.AccountId > 0)
            {
                query = query.Where(x => x.AccountId == searchModel.AccountId);
            }

            var orders = query.OrderByDescending(x => x.Id).ToList();
            foreach (var order in orders)
            {
                order.AccountFullName = accounts.FirstOrDefault(x => x.Id == order.AccountId)?.FullName;
                order.PaymentMethod = PaymentMethod.GetBy(order.PaymentMethodId)?.Name;
            }

            return orders;
        }
    }
}
