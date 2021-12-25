using System.Collections.Generic;
using _0_Framework.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Banner;

namespace ServiceHost.Areas.Admininstration.Pages.Shop.Banners
{
    public class IndexModel : PageModel
    {
        [TempData] public string message { get; set; }
        public List<BannerViewModel> Banners;

        private readonly IBannerApplication _bannerApplication;

        public IndexModel(IBannerApplication bannerApplication)
        {
            _bannerApplication = bannerApplication;
        }

        [NeedPermission(AdminPermissions.ListBanner)]
        public void OnGet()
        {
            Banners = _bannerApplication.GetList();
        }

        [NeedPermission(AdminPermissions.CreateBanner)]
        public IActionResult OnGetCreate()
        {
            var command = new CreateBanner();
            return Partial("./Create",command);

        }

        [NeedPermission(AdminPermissions.CreateBanner)]
        public JsonResult OnPostCreate(CreateBanner command)
        {
            var result = _bannerApplication.Create(command);
            return new JsonResult(result);
        }

        [NeedPermission(AdminPermissions.EditBanner)]
        public IActionResult OnGetEdit(long id)
        {
            var slide = _bannerApplication.GetDetails(id);
            return Partial("Edit", slide);
        }

        public JsonResult OnPostEdit(EditBanner command)
        {
            var result = _bannerApplication.Edit(command);
            return new JsonResult(result);
        }

        [NeedPermission(AdminPermissions.DeleteBanner)]
        public IActionResult OnGetRemove(long id)
        {
            var result = _bannerApplication.Remove(id);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            message = result.Message;
            return RedirectToPage("./Index");
        }

        public IActionResult OnGetRestore(long id)
        {
            var result = _bannerApplication.Restore(id);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
