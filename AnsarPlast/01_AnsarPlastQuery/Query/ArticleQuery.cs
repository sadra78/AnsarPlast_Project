using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using _01_AnsarPlastQuery.Contracts.Article;
using BlogManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace _01_AnsarPlastQuery.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _context;

        public ArticleQuery(BlogContext context)
        {
            _context = context;
        }

        public ArticleQueryModel GetArticleDetails(string slug)
        {

            var article = _context.Articles.Include(x => x.Category)
                .Where(x => x.PublishDate <= DateTime.Now)
                .Select(x => new ArticleQueryModel
                {
                    Title = x.Title,
                    Description = x.Description,
                    ShortDescription = x.ShortDescription,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    PublishDate = x.PublishDate.ToFarsi(),
                    Slug = x.Slug,
                    Keywords = x.Keywords,
                    MetaDescription = x.MetaDescription,
                    CanonicalAddress = x.CanonicalAddress,
                    CategoryName = x.Category.Name,
                    CategorySlug = x.Category.Slug,

                }).FirstOrDefault(x => x.Slug == slug);

            if (!string.IsNullOrWhiteSpace(article.Keywords))
                article.KeywordsList = article.Keywords.Split(",").ToList();
            return article;
        }

        public List<ArticleQueryModel> LatesArticles()
        {
            return _context.Articles.Include(x => x.Category)
                .Where(x => x.PublishDate <= DateTime.Now)
                .Select(x => new ArticleQueryModel
                {
                    Title = x.Title,
                    ShortDescription = x.ShortDescription,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    PublishDate = x.PublishDate.ToFarsi(),
                    Slug = x.Slug,

                }).ToList();
        }
    }
}
