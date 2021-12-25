using System.Collections.Generic;
using _0_Framework.Infrastructure;
using DiscountManagement.Application.Contract.ColleagueDiscount;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;

namespace ServiceHost.Areas.Admininstration.Pages.Discounts.ColleagueDiscounts
{
    [Authorize]
    public class IndexModel : PageModel
    {
        [TempData] public string message { get; set; }
        public ColleagueDiscountSearchModel SearchModel;
        public List<ColleagueDiscountViewModel> ColleagueDiscounts;
        public SelectList Products;

        private readonly IProductApplication _productApplication;
        private readonly IColleagueDiscountApplication _discountApplication;

        public IndexModel(IProductApplication productApplication, IColleagueDiscountApplication colleagueDiscount)
        {
            _productApplication = productApplication;
            _discountApplication = colleagueDiscount;
        }

        [NeedPermission(AdminPermissions.ListColleagueDiscount)]
        public void OnGet(ColleagueDiscountSearchModel searchModel)
        {
            Products = new SelectList(_productApplication.GetProducts(), "Id", "Name");
            ColleagueDiscounts = _discountApplication.Search(searchModel);
        }


        public IActionResult OnGetCreate()
        {
            var command = new DefineColleagueDiscount
            {
                Products = _productApplication.GetProducts()

            };
            return Partial("./Create", command);

        }

        [NeedPermission(AdminPermissions.DefineColleagueDiscount)]
        public JsonResult OnPostCreate(DefineColleagueDiscount command)
        {
            var result = _discountApplication.Define(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var colleagueDiscount = _discountApplication.GetDetails(id);
            colleagueDiscount.Products = _productApplication.GetProducts();
            return Partial("Edit", colleagueDiscount);
        }

        [NeedPermission(AdminPermissions.EditColleagueDiscount)]
        public JsonResult OnPostEdit(EditColleagueDiscount command)
        {
            var result = _discountApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetRemove(long id)
        {
            _discountApplication.Remove(id);
            return RedirectToPage("./Index");
        }
        public IActionResult OnGetRestore(long id)
        {
            _discountApplication.Restore(id);
            return RedirectToPage("./Index");
        }
    }
}
