using System.Collections.Generic;
using _0_Framework.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Slide;

namespace ServiceHost.Areas.Admininstration.Pages.Shop.Slides
{
    public class IndexModel : PageModel
    {
        [TempData] public string message { get; set; }
        public List<SlideViewModel> Slides;

        private readonly ISlideApplication _slideApplication;

        public IndexModel(ISlideApplication slideApplication)
        {
            _slideApplication = slideApplication;
        }

        [NeedPermission(AdminPermissions.ListOrder)]
        public void OnGet()
        {
            Slides = _slideApplication.GetList();
        }

        [NeedPermission(AdminPermissions.CreateSlider)]
        public IActionResult OnGetCreate()
        {
            var command = new CreateSlide();
            return Partial("./Create",command);

        }

        [NeedPermission(AdminPermissions.CreateSlider)]
        public JsonResult OnPostCreate(CreateSlide command)
        {
            var result = _slideApplication.Create(command);
            return new JsonResult(result);
        }

        [NeedPermission(AdminPermissions.EditSlider)]
        public IActionResult OnGetEdit(long id)
        {
            var slide = _slideApplication.GetDetails(id);
            return Partial("Edit", slide);
        }

        public JsonResult OnPostEdit(EditSlide command)
        {
            var result = _slideApplication.Edit(command);
            return new JsonResult(result);
        }

        [NeedPermission(AdminPermissions.DeleteSlider)]
        public IActionResult OnGetRemove(long id)
        {
            var result = _slideApplication.Remove(id);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            message = result.Message;
            return RedirectToPage("./Index");
        }

        public IActionResult OnGetRestore(long id)
        {
            var result = _slideApplication.Restore(id);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
