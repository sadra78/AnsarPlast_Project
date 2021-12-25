using System.Collections.Generic;
using _0_Framework.Infrastructure;
using DiscountManagement.Application.Contract.DiscountCode;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admininstration.Pages.Discounts.DiscountCodes
{
    public class IndexModel : PageModel
    {
        [TempData] public string message { get; set; }
        public DiscountCodeSearchModel SearchModel;
        public List<DiscountCodeViewModel> DiscountCode;

        private readonly IDiscountCodeApplication _discountCodeApplicationApplication;

        public IndexModel(IDiscountCodeApplication discountCodeApplication)
        {
            _discountCodeApplicationApplication = discountCodeApplication;
        }

        [NeedPermission(AdminPermissions.ListDiscountCode)]
        public void OnGet(DiscountCodeSearchModel searchModel)
        {
            DiscountCode = _discountCodeApplicationApplication.Search(searchModel);
        }

        [NeedPermission(AdminPermissions.DefineDiscountCode)]
        public IActionResult OnGetCreate()
        {
            var command = new DefineDiscountCode
            {
            };
            return Partial("./Create", command);

        }

        public JsonResult OnPostCreate(DefineDiscountCode command)
        {
            var result = _discountCodeApplicationApplication.Define(command);
            return new JsonResult(result);
        }

        [NeedPermission(AdminPermissions.EditDiscountCode)]
        public IActionResult OnGetEdit(long id)
        {
            var codeDiscount = _discountCodeApplicationApplication.GetDetails(id);
            return Partial("Edit", codeDiscount);
        }

        public JsonResult OnPostEdit(EditDiscountCode command)
        {
            var result = _discountCodeApplicationApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
