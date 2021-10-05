using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_AnsarPlastQuery.Contracts.ArticleCategory;
using _01_AnsarPlastQuery.Contracts.ProductCategory;

namespace _01_AnsarPlastQuery
{
    public class MenuModel
    {
        public List<ArticleCategoryQueryModel> ArticleCategories { get; set; }
        public List<ProductCategoryQueryModel> ProductCategories { get; set; }
    }
}
