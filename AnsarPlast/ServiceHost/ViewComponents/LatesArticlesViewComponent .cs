using _01_AnsarPlastQuery.Contracts.Article;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class LatesArticlesViewComponent : ViewComponent
    {
        private readonly IArticleQuery _articleQuery;

        public LatesArticlesViewComponent(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public IViewComponentResult Invoke()
        {
            var latesArticles = _articleQuery.LatesArticles();
            return View(latesArticles);
        }
    }
}
