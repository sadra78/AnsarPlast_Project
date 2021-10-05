using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AnsarPlastQuery.Contracts.ArticleCategory
{
     public interface IArticleCategoryQuery
     {
         ArticleCategoryQueryModel getArticleCategoryBy(string slug);
         List<ArticleCategoryQueryModel> GetArticleCategories();
     }
}
