using System.Collections.Generic;
using _0_Framework.Infrastructure;
using DiscountManagement.Application.Contract.CustomerDiscount;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;

namespace ServiceHost.Areas.Admininstration.Pages.Discounts.CustomerDiscounts
{
    public class IndexModel : PageModel
    {
        [TempData] public string message { get; set; }
        public CustomerDiscountSearchModel SearchModel;
        public List<CustomerDiscountViewModel> CustomerDiscount;
        public SelectList Products;

        private readonly IProductApplication _productApplication;
        private readonly ICustomerDiscountApplication _discountApplication;

        public IndexModel(IProductApplication productApplication, ICustomerDiscountApplication customerDiscount)
        {
            _productApplication = productApplication;
            _discountApplication = customerDiscount;
        }

        [NeedPermission(AdminPermissions.ListCustomerDiscount)]
        public void OnGet(CustomerDiscountSearchModel searchModel)
        {
            Products = new SelectList(_productApplication.GetProducts(), "Id", "Name");
            CustomerDiscount = _discountApplication.Search(searchModel);
        }

        [NeedPermission(AdminPermissions.DefineCustomerDiscount)]
        public IActionResult OnGetCreate()
        {
            var command = new DefineCustomerDiscount
            {
                Products = _productApplication.GetProducts()

            };
            return Partial("./Create", command);

        }

        public JsonResult OnPostCreate(DefineCustomerDiscount command)
        {
            var result = _discountApplication.Define(command);
            return new JsonResult(result);
        }

        [NeedPermission(AdminPermissions.EditCustomerDiscount)]
        public IActionResult OnGetEdit(long id)
        {
            var customerDiscount = _discountApplication.GetDetails(id);
            customerDiscount.Products = _productApplication.GetProducts();
            return Partial("Edit", customerDiscount);
        }

        public JsonResult OnPostEdit(EditCustomerDiscount command)
        {
            var result = _discountApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
