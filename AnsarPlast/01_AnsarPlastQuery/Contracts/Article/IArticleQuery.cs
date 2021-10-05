using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AnsarPlastQuery.Contracts.Article
{
    public interface IArticleQuery
    {
        ArticleQueryModel GetArticleDetails(string slug);
        List<ArticleQueryModel> LatesArticles();
    }
}
