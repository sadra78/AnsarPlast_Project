using System.Collections.Generic;
using _0_Framework.Infrastructure;
using CommentManagement.Application.Contracts.Comment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admininstration.Pages.Comments
{
    [Authorize]
    public class IndexModel : PageModel

    {
        [TempData] public string Message { get; set; }
        public List<CommentViewModel> Comments;
        public CommentSearchModel SearchModel;
        private readonly ICommentApplication _commentApplication;
        public IndexModel(ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
        }

        [NeedPermission(AdminPermissions.ListComment)]
        public void OnGet(CommentSearchModel searchModel)
        {
            Comments = _commentApplication.Search(searchModel);
        }

        [NeedPermission(AdminPermissions.CancelComment)]
        public IActionResult OnGetCancel(long id)
        {
            var result = _commentApplication.Cancel(id);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");
        }

        [NeedPermission(AdminPermissions.ConfirmComment)]
        public IActionResult OnGetConfirm(long id)
        {
            var result = _commentApplication.Confirm(id);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
