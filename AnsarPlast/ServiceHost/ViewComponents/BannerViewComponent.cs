using _01_AnsarPlastQuery.Contracts.Banner;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class BannerViewComponent : ViewComponent
    {
        private readonly IBannerQuery _bannerQuery;

        public BannerViewComponent(IBannerQuery bannerQuery)
        {
            _bannerQuery = bannerQuery;
        }

        public IViewComponentResult Invoke()
        {
            var banners = _bannerQuery.GetBanner();
            return View(banners);
        }
    }
}