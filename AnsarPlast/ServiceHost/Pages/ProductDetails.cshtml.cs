using _01_AnsarPlastQuery.Contracts.Product;
using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Infrastructure.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ProductDetailsModel : PageModel
    {
        private readonly IProductQuery _productQuery;
        public ProductQueryModel Product;
        private readonly ICommentApplication _commentApplication;

        public ProductDetailsModel(IProductQuery productQuery, ICommentApplication commentApplication)
        {
            _productQuery = productQuery;
            _commentApplication = commentApplication;
        }

        public void OnGet(string id)
        {
            Product = _productQuery.GetProductDetailsBy(id);
        }

        public IActionResult OnPost(AddComment command,string productSlug)
        {
            command.Type = CommentsType.Product;
            var result = _commentApplication.Add(command);
            return RedirectToPage("./ProductDetails", new { Id = productSlug });
        }
    }
}
