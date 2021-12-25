using System.Collections.Generic;

namespace _01_AnsarPlastQuery.Contracts.Banner
{
    public interface IBannerQuery
    {
        List<BannerQueryModel> GetBanner();
    }
}