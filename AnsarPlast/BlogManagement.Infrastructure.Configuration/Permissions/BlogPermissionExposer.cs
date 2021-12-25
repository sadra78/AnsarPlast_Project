using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace BlogManagement.Infrastructure.Configuration.Permissions
{
    public class BlogPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "ArticleCategories",new List<PermissionDto>
                    {
                        new PermissionDto(AdminPermissions.SearchArticleCategories,"جست جو در دسته بندی مقالات"),
                        new PermissionDto(AdminPermissions.ListArticleCategories,"لیست دسته بندی مقالات"),
                        new PermissionDto(AdminPermissions.CreateArticleCategory,"ایجاد دسته بندی مقالات"),
                        new PermissionDto(AdminPermissions.EditArticleCategory,"ویرایش دسته بندی مقالات"),
                    }
                },
                {
                    "Article", new List<PermissionDto>
                    {
                        new PermissionDto(AdminPermissions.ListArticles,"لیست مقالات"),
                        new PermissionDto(AdminPermissions.SearchArticles,"جستجو مقالات"),
                        new PermissionDto(AdminPermissions.CreateArticle,"ایجاد مقاله"),
                        new PermissionDto(AdminPermissions.EditArticle,"ویرایش مقالات"),
                    }
                },
            };
        }
    }
}
