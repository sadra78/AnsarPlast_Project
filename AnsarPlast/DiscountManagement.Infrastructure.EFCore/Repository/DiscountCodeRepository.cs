using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using DiscountManagement.Application.Contract.DiscountCode;
using DiscountManagement.Domain.DiscountCodeAgg;

namespace DiscountManagement.Infrastructure.EFCore.Repository
{
    public class DiscountCodeRepository : RepositoryBase<long, DiscountCode>, IDiscountCodeRepository
    {
        private readonly DiscountContext _context;

        public DiscountCodeRepository(DiscountContext context) : base(context)
        {
            _context = context;
        }

        public EditDiscountCode GetBy(string code)
        {
            //return _context.DiscountCodes.Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).FirstOrDefault(x => x.CodeDiscount == code);
            return _context.DiscountCodes.Select(x => new EditDiscountCode()
            {
                Id = x.Id,
                DiscountRate = x.DiscountRate,
                CodeDiscount = x.CodeDiscount,
                StartDate = x.StartDate.ToString(),
                EndDate = x.EndDate.ToString(),
                Reason = x.Reason,
            }).FirstOrDefault(x => x.CodeDiscount == code);
        }

        public EditDiscountCode GetDetails(long id)
        {
            return _context.DiscountCodes.Select(x => new EditDiscountCode
            {
                Id = x.Id,
                DiscountRate = x.DiscountRate,
                CodeDiscount = x.CodeDiscount,
                StartDate = x.StartDate.ToString(),
                EndDate = x.EndDate.ToString(),
                Reason = x.Reason,
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<DiscountCodeViewModel> Search(DiscountCodeSearchModel searchModel)
        {
            var query = _context.DiscountCodes.Select(x => new DiscountCodeViewModel
            {
                Id = x.Id,
                DiscountRate = x.DiscountRate,
                CodeDiscount = x.CodeDiscount,
                StartDate = x.StartDate.ToFarsi(),
                EndDate = x.EndDate.ToFarsi(),
                StartDateGr = x.StartDate,
                EndDateGr = x.EndDate,
                Reason = x.Reason,
                CreationDate = x.CreationDate.ToFarsi(),
            });

            if (!string.IsNullOrWhiteSpace(searchModel.StartDate))
            {

                query = query.Where(x => x.StartDateGr >= searchModel.StartDate.ToGeorgianDateTime());

            }
            if (!string.IsNullOrWhiteSpace(searchModel.EndDate))
            {
                var endDate = DateTime.Now;
                query = query.Where(x => x.EndDateGr < searchModel.EndDate.ToGeorgianDateTime());

            }

            if (!string.IsNullOrWhiteSpace(searchModel.CodeDiscount))
            {
                query = query.Where(x => x.CodeDiscount == searchModel.CodeDiscount);
            }

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}