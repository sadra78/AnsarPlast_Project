using System.Collections.Generic;
using _0_Framework.Domain;
using DiscountManagement.Application.Contract.DiscountCode;

namespace DiscountManagement.Domain.DiscountCodeAgg
{
    public interface IDiscountCodeRepository : IRepository<long,DiscountCode>
    {
        EditDiscountCode GetBy(string code);
        EditDiscountCode GetDetails(long id);
        List<DiscountCodeViewModel> Search(DiscountCodeSearchModel searchModel);
    }
}