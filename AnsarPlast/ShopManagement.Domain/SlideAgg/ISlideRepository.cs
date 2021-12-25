using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Application.Contracts.Slide;

namespace ShopManagement.Domain.SlideAgg
{
    public interface ISlideRepository : IRepository<long,Slide>
    {
        EditSlide GetDeatails(long id);
        List<SlideViewModel> GetList();
    }
}
