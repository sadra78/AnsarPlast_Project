using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using _01_AnsarPlastQuery.Contracts.Article;
using _01_AnsarPlastQuery.Contracts.ArticleCategory;
using BlogManagement.Domain.ArticleAgg;
using BlogManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace _01_AnsarPlastQuery.Query
{
    public class ArticleCategoryQuery : IArticleCategoryQuery
    {
        private readonly BlogContext _context;

        public ArticleCategoryQuery(BlogContext context)
        {
            _context = context;
        }

        public ArticleCategoryQueryModel getArticleCategoryBy(string slug)
        {
            var articleCategory = _context.ArticleCategories
                .Include(x => x.Articles)
                .Select(x => new ArticleCategoryQueryModel
                {
                    Slug = x.Slug,
                    Name = x.Name,
                    Description = x.Description,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Keywords = x.Keywords,
                    MetaDescription = x.MetaDescription,
                    CanonicalAddress = x.CanonicalAddress,
                    ArticlesCount = x.Articles.Count,
                    Articles = MapArticles(x.Articles)
                }).FirstOrDefault(x => x.Slug == slug);
            if (!string.IsNullOrWhiteSpace(articleCategory.Keywords))
                articleCategory.KeywordList = articleCategory.Keywords.Split(",").ToList();

            return articleCategory;
        }

        public List<ArticleCategoryQueryModel> GetArticleCategories()
        {
            return _context.ArticleCategories
                .Include(x => x.Articles)
                .Select(x => new ArticleCategoryQueryModel
                {
                    Name = x.Name,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug,
                    ArticlesCount = x.Articles.Count
                })
                .ToList();
        }

        private static List<ArticleQueryModel> MapArticles(List<Article> articles)
        {
            return articles.Select(x => new ArticleQueryModel
            {
                Title = x.Title,
                Slug = x.Slug,
                ShortDescription = x.ShortDescription,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                PublishDate = x.PublishDate.ToFarsi(),

            }).ToList();
        }
    }
}
