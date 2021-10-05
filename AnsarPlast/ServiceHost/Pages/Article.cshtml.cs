using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_AnsarPlastQuery.Contracts.Article;
using _01_AnsarPlastQuery.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ArticleModel : PageModel
    {
        public ArticleQueryModel Article;
        public List<ArticleQueryModel> LatesArticles;
        public List<ArticleCategoryQueryModel> ArticleCategories;
        private readonly IArticleQuery _articleQuery;
        private readonly IArticleCategoryQuery _articleCategoryQuery;

        public ArticleModel(IArticleQuery articleQuery, IArticleCategoryQuery articleCategoryQuery)
        {
            _articleQuery = articleQuery;
            _articleCategoryQuery = articleCategoryQuery;
        }

        public void OnGet(string id)
        {

            Article = _articleQuery.GetArticleDetails(id);
            LatesArticles = _articleQuery.LatesArticles();
            ArticleCategories = _articleCategoryQuery.GetArticleCategories();
        }
    }
}
