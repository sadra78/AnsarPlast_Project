using System.Collections.Generic;
using ShopManagement.Application.Contracts.Order;
using ShopManagement.Infrastructure.EFCore;

namespace _01_AnsarPlastQuery.Contracts
{
    public interface ICartCalculatorService
    {
        Cart CumputeCart(List<CartItem> cartItems,int disRate);
    }
}
