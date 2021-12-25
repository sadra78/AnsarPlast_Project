using System.Collections.Generic;
using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Application.Contracts.Role;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiceHost.Areas.Admininstration.Pages.Accounts.Role
{
    [Authorize]
    public class IndexModel : PageModel
    {
        [TempData] public string message { get; set; }
        public List<RoleViewModel> Roles;

        private readonly IRoleApplication _roleApplication;
        public IndexModel(IRoleApplication roleApplication)
        {
            _roleApplication = roleApplication;
        }
        [NeedPermission(AdminPermissions.ListRole)]
        public void OnGet()
        {
            Roles = _roleApplication.List();
        }

    }

}
