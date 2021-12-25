using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _0_Framework.Infrastructure;
using BlogManagement.Application.Contract.ArticleCategory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.ProductCategory;

namespace ServiceHost.Areas.Admininstration.Pages.Blog.ArticleCategories
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public ArticleCategorySearchModel SearchModel;
        public List<ArticleCategoryViewModel> ArticleCategories;
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public IndexModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        [NeedPermission(AdminPermissions.ListArticleCategories)]
        public void OnGet(ArticleCategorySearchModel searchModel)
        {
            ArticleCategories = _articleCategoryApplication.Search(searchModel);
        }


        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreateArticleCategory());

        }

        [NeedPermission(AdminPermissions.CreateArticleCategory)]
        public JsonResult OnPostCreate(CreateArticleCategory command)
        {
            var result = _articleCategoryApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var productCategory = _articleCategoryApplication.GetDetails(id);
            return Partial("Edit", productCategory);
        }

        [NeedPermission(AdminPermissions.EditArticleCategory)]
        public JsonResult OnPostEdit(EditArticleCategory command)
        {

            var result = _articleCategoryApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
