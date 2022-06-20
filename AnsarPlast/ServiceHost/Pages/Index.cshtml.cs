using System.Collections.Generic;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using _01_AnsarPlastQuery.Contracts.Product;
using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Product;

namespace ServiceHost.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IAccountApplication _accountApplication;
        private readonly IAuthHelper _authHelper;
        private readonly IProductQuery _productQuery;

        public List<ProductViewModel> Product;


        public IndexModel(IAccountApplication accountApplication, IAuthHelper authHelper, IProductQuery productQuery)
        {
            _accountApplication = accountApplication;
            _authHelper = authHelper;
            _productQuery = productQuery;
        }

        public void OnGet()
        {
        }

        public IActionResult OnGetLogin()
        {
            var command = new Login();
            return Partial("./Login", command);

        }
        public IActionResult OnPostLogin(Login command)
        {
            var result = _accountApplication.Login(command);
            return result.IsSuccedded ? RedirectToPage("./Index") : RedirectToPage("./Index","Login");
        }

        public IActionResult OnGetLogOut()
        {
            _accountApplication.LogOut();
            return RedirectToPage("./Index");
        }

        public IActionResult OnGetRegister()
        {
            var command = new RegisterAccount();
            return Partial("./Register", command);

        }
        public IActionResult OnPostRegister(RegisterAccount command)
        {
            var result = _accountApplication.Register(command);
            if (result.IsSuccedded)
                return RedirectToPage("/Index");
            return RedirectToPage("./Index", "Register");
        }

        public IActionResult OnGetAccountArea(string id)
        {
            var accountrole = _authHelper.CurrentAccountRole();
            return accountrole switch
            {
                Roles.Administrator => RedirectToPage("./Index", new { Area = "Admininstration" }),
                Roles.ContentUploader => RedirectToPage("./Index", new { Area = "Admininstration" }),
                Roles.ColleagueUser => RedirectToPage("./Profile"),
                Roles.SystemUser => RedirectToPage("./Profile"),
                _ => null
            };
        }

        public IActionResult OnGetPartialProductDetail(string slug)
        {
            var productDetails = _productQuery.GetProductDetailsBy(slug);
            return Partial("PartialProductDetail", productDetails);
        }
    }
}
