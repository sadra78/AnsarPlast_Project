using System.Collections.Generic;
using System.Linq;
using _01_AnsarPlastQuery.Contracts.Banner;
using ShopManagement.Infrastructure.EFCore;

namespace _01_AnsarPlastQuery.Query
{
    public class BannerQuery : IBannerQuery
    {
        private readonly ShopContext _shopContext;

        public BannerQuery(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public List<BannerQueryModel> GetBanner()
        {
            return _shopContext.Banners.Where(x => !x.IsRemoved).Select(x => new BannerQueryModel
            {
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Title = x.Title,
                Text = x.Text,
                BtnText = x.BtnText,
                Link = x.Link
            }).ToList();
        }
    }
}