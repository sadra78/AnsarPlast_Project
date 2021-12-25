using System.Collections.Generic;
using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Order;

namespace ServiceHost.Areas.Admininstration.Pages.Shop.Orders
{
    public class IndexModel : PageModel
    {
        public OrderSearchModel SearchModel;
        public List<OrderViewModel> Orders;
        public SelectList Accounts;

        private readonly IOrderApplication _orderApplication;
        private readonly IAccountApplication _accountApplication;

        public IndexModel(IOrderApplication orderApplication, IAccountApplication accountApplication)
        {
            _orderApplication = orderApplication;
            _accountApplication = accountApplication;
        }

        [NeedPermission(AdminPermissions.ListOrder)]
        public void OnGet(OrderSearchModel searchModel)
        {
            Accounts = new SelectList(_accountApplication.GetAccounts(), "Id", "FullName");
            Orders = _orderApplication.Search(searchModel);
        }

        [NeedPermission(AdminPermissions.SubmitOrder)]
        public IActionResult OnGetConfirm(long orderId)
        {
            _orderApplication.PaymentSucceeded(orderId, 0);
            return RedirectToPage("./Index");
        }

        [NeedPermission(AdminPermissions.CancelOrder)]
        public IActionResult OnGetCancel(long orderId)
        {
            _orderApplication.Cancel(orderId);
            return RedirectToPage("./Index");
        }

        [NeedPermission(AdminPermissions.ItemOrder)]
        public IActionResult OnGetItems(long id)
        {
            var items = _orderApplication.GetItems(id);
            return Partial("Items", items);
        }
    }
}
