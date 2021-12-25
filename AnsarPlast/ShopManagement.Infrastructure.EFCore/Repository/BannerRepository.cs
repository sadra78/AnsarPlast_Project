using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.Banner;
using ShopManagement.Domain.BannerAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class BannerRepository : RepositoryBase<long,Banner>,IBannerRepository
    {
        private readonly ShopContext _context;
        public BannerRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public EditBanner GetDetails(long id)
        {
            return _context.Banners.Select(x => new EditBanner
            {
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Title = x.Title,
                Text = x.Text,
                BtnText = x.BtnText,
                Link = x.Link,
                Id = x.Id
            }).FirstOrDefault(x=>x.Id == id);
        }

        public List<BannerViewModel> GetList()
        {
            return _context.Banners.Select(x => new BannerViewModel
            {
                Id = x.Id,
                Picture = x.Picture,
                Title = x.Title,
                IsRemoved = x.IsRemoved,
                CreationDate = x.CreationDate.ToFarsi(),
            }).OrderByDescending(x => x.Id).ToList();
        }
    }
}