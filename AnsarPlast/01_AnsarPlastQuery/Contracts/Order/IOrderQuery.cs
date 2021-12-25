using System.Collections.Generic;

namespace _01_AnsarPlastQuery.Contracts.Order
{
    public interface IOrderQuery
    {
        List<OrderQueryModel> GetOrders();
    }
}