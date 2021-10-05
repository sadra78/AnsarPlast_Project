using System.Collections.Generic;
using _01_AnsarPlastQuery.Contracts.Article;
using _01_AnsarPlastQuery.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ArticleCategoryModel : PageModel
    {
        public ArticleCategoryQueryModel ArticleCategory;
        public List<ArticleCategoryQueryModel> ArticleCategories;
        public List<ArticleQueryModel> LatesArticles;

        private readonly IArticleQuery _articleQuery;
        private readonly IArticleCategoryQuery _articleCategoryQuery;

        public ArticleCategoryModel(IArticleCategoryQuery articleCategoryQuery, IArticleQuery articleQuery)
        {
            _articleCategoryQuery = articleCategoryQuery;
            _articleQuery = articleQuery;
        }

        public void OnGet(string id)
        {
            ArticleCategory = _articleCategoryQuery.getArticleCategoryBy(id);
            ArticleCategories = _articleCategoryQuery.GetArticleCategories();
            LatesArticles = _articleQuery.LatesArticles();
        }
    }
}
