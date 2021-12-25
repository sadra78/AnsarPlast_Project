using System.Collections.Generic;
using _0_Framework.Application;

namespace DiscountManagement.Application.Contract.DiscountCode
{
    public interface IDiscountCodeApplication
    {
        OperationResult Define(DefineDiscountCode command);
        OperationResult Edit(EditDiscountCode command);
        OperationResult CheckCode(GetCode command);
        EditDiscountCode GetDetails(long id);
        EditDiscountCode GetDetailsBy(string code);
        List<DiscountCodeViewModel> Search(DiscountCodeSearchModel searchModel);
    }
}